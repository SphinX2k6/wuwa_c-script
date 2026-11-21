using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using CSharpScript.Game.Module.WuwaGo.Controller.Role;
using CSharpScript.Game.Module.WuwaGo.Model;
using CSharpScript.Game.Module.WuwaGo.Model.Role;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.WuwaGo.Round
{
	// Token: 0x0200365A RID: 13914
	[NullableContext(1)]
	[Nullable(0)]
	public class RoundManager : IStaticVariableResetter
	{
		// Token: 0x06024172 RID: 147826 RVA: 0x00A36C3F File Offset: 0x00A34E3F
		static RoundManager()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(RoundManager.CreateStaticDefaultValue), new Action(RoundManager.ResetStaticDefaultValue));
		}

		// Token: 0x06024173 RID: 147827 RVA: 0x00A36C60 File Offset: 0x00A34E60
		public static void CreateStaticDefaultValue()
		{
			List<RoundManager.RoundSequenceNode> list = new List<RoundManager.RoundSequenceNode>();
			list.Add(new RoundManager.RoundSequenceNode(ERoundStep.SpikeTrap, "Normal", null));
			list.Add(new RoundManager.RoundSequenceNode(ERoundStep.PressureTrigger, "Normal", null));
			list.Add(new RoundManager.RoundSequenceNode(ERoundStep.MovableFloor, "Normal", null));
			list.Add(new RoundManager.RoundSequenceNode(ERoundStep.MonsterAction, "Normal", null));
			list.Add(new RoundManager.RoundSequenceNode(ERoundStep.SpikeTrap, "PostMoveMonster", (RoundManager manager) => manager.HasMoveMonsterActed));
			list.Add(new RoundManager.RoundSequenceNode(ERoundStep.PressureTrigger, "PostMoveMonster", (RoundManager manager) => manager.HasMoveMonsterActed));
			list.Add(new RoundManager.RoundSequenceNode(ERoundStep.MovableFloor, "PostMoveMonster", (RoundManager manager) => manager.HasMoveMonsterActed));
			list.Add(new RoundManager.RoundSequenceNode(ERoundStep.GearTrap, "Normal", null));
			list.Add(new RoundManager.RoundSequenceNode(ERoundStep.BowTrap, "Normal", null));
			RoundManager._resolutionSequence = list;
		}

		// Token: 0x06024174 RID: 147828 RVA: 0x00A36D73 File Offset: 0x00A34F73
		public static void ResetStaticDefaultValue()
		{
			RoundManager._resolutionSequence = null;
		}

		// Token: 0x170049AF RID: 18863
		// (get) Token: 0x06024175 RID: 147829 RVA: 0x00A36D7C File Offset: 0x00A34F7C
		[Nullable(2)]
		public WuWaGoRoleController CurProcessUnit
		{
			[NullableContext(2)]
			get
			{
				WuWaGoRoleController wuWaGoRoleController = this.CurProcess as WuWaGoRoleController;
				if (wuWaGoRoleController == null)
				{
					return null;
				}
				return wuWaGoRoleController;
			}
		}

		// Token: 0x170049B0 RID: 18864
		// (get) Token: 0x06024176 RID: 147830 RVA: 0x00A36D9B File Offset: 0x00A34F9B
		// (set) Token: 0x06024177 RID: 147831 RVA: 0x00A36DA3 File Offset: 0x00A34FA3
		public bool IsBusy { get; private set; }

		// Token: 0x170049B1 RID: 18865
		// (get) Token: 0x06024178 RID: 147832 RVA: 0x00A36DAC File Offset: 0x00A34FAC
		// (set) Token: 0x06024179 RID: 147833 RVA: 0x00A36DB4 File Offset: 0x00A34FB4
		public ERoundStep? CurrentStep { get; private set; }

		// Token: 0x170049B2 RID: 18866
		// (get) Token: 0x0602417A RID: 147834 RVA: 0x00A36DBD File Offset: 0x00A34FBD
		// (set) Token: 0x0602417B RID: 147835 RVA: 0x00A36DC5 File Offset: 0x00A34FC5
		[Nullable(2)]
		public string CurrentProcessDebugName { [NullableContext(2)] get; [NullableContext(2)] private set; }

		// Token: 0x0602417C RID: 147836 RVA: 0x00A36DD0 File Offset: 0x00A34FD0
		public void Init(WuWaGoGameData gameData, IWuWaGoGridMutationService gridMutationService, [Nullable(new byte[]
		{
			2,
			1
		})] Func<IWuWaGoMovableFloorBatchResult, UniTask> onMovableFloorBatchFinished = null)
		{
			RoundManager.<>c__DisplayClass26_0 CS$<>8__locals1 = new RoundManager.<>c__DisplayClass26_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.onMovableFloorBatchFinished = onMovableFloorBatchFinished;
			this.GameData = gameData;
			this.ExecutionToken++;
			GearAndBowTrapRoundStepExecutor value = new GearAndBowTrapRoundStepExecutor((ERoundStep step) => CS$<>8__locals1.<>4__this.StepUnits.GetValueOrDefault(step), () => CS$<>8__locals1.<>4__this.ExecutionToken, new Action<IExecutableUnit, string>(this.SetCurrentProcess));
			this.DefaultStepExecutor = new SequentialRoundStepExecutor((ERoundStep step) => CS$<>8__locals1.<>4__this.StepUnits.GetValueOrDefault(step), () => CS$<>8__locals1.<>4__this.ExecutionToken, new Action<IExecutableUnit, string>(this.SetCurrentProcess), new Func<int, bool>(this.ShouldAbortRound));
			this.StepExecutors.Clear();
			this.StepExecutors[ERoundStep.MovableFloor] = new MovableFloorRoundStepExecutor(gridMutationService, () => CS$<>8__locals1.<>4__this.ExecutionToken, new Action<IExecutableUnit, string>(this.SetCurrentProcess), delegate(IWuWaGoMovableFloorBatchResult result, int movableFloorExecutionToken)
			{
				RoundManager.<>c__DisplayClass26_0.<<Init>b__5>d <<Init>b__5>d;
				<<Init>b__5>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
				<<Init>b__5>d.<>4__this = CS$<>8__locals1;
				<<Init>b__5>d.result = result;
				<<Init>b__5>d.movableFloorExecutionToken = movableFloorExecutionToken;
				<<Init>b__5>d.<>1__state = -1;
				<<Init>b__5>d.<>t__builder.Start<RoundManager.<>c__DisplayClass26_0.<<Init>b__5>d>(ref <<Init>b__5>d);
				return <<Init>b__5>d.<>t__builder.Task;
			});
			this.StepExecutors[ERoundStep.GearTrap] = value;
			this.StepExecutors[ERoundStep.BowTrap] = value;
		}

		// Token: 0x0602417D RID: 147837 RVA: 0x00A36EC8 File Offset: 0x00A350C8
		public void RegisterUnit(ERoundStep step, IExecutableUnit unit)
		{
			List<IExecutableUnit> list;
			if (this.StepUnits.TryGetValue(step, out list))
			{
				list.Add(unit);
			}
		}

		// Token: 0x0602417E RID: 147838 RVA: 0x00A36EEC File Offset: 0x00A350EC
		public void Clear()
		{
			this.ExecutionToken++;
			foreach (KeyValuePair<ERoundStep, List<IExecutableUnit>> keyValuePair in this.StepUnits)
			{
				ERoundStep eroundStep;
				List<IExecutableUnit> list;
				keyValuePair.Deconstruct(out eroundStep, out list);
				list.Clear();
			}
			this.IsBusy = false;
			this.CurProcess = null;
			this.CurrentStep = null;
			this.CurrentProcessDebugName = null;
			this.HasMoveMonsterActed = false;
		}

		// Token: 0x0602417F RID: 147839 RVA: 0x00A36F84 File Offset: 0x00A35184
		public void ResetForRollback()
		{
			this.ExecutionToken++;
			this.IsBusy = false;
			this.CurProcess = null;
			this.CurrentStep = null;
			this.CurrentProcessDebugName = null;
			this.HasMoveMonsterActed = false;
		}

		// Token: 0x06024180 RID: 147840 RVA: 0x00A36FCC File Offset: 0x00A351CC
		public unsafe void RemoveController(WuWaGoRoleController controller)
		{
			ERoundStep eroundStep = controller.BaseRole.IsMonster ? ERoundStep.MonsterAction : ERoundStep.PlayerAction;
			List<IExecutableUnit> list;
			if (!this.StepUnits.TryGetValue(eroundStep, out list))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.WuWaGo;
				ELogAuthor author = ELogAuthor.YSQ;
				string message = "尝试移除未注册步骤的 Controller";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("controllerId", controller.Id);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("step", eroundStep);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return;
			}
			int num = list.IndexOf(controller);
			if (num >= 0)
			{
				list.RemoveAt(num);
			}
		}

		// Token: 0x06024181 RID: 147841 RVA: 0x00A37074 File Offset: 0x00A35274
		public void Tick(float delta)
		{
			if (!this.IsBusy)
			{
				this.EnterNextRound();
			}
		}

		// Token: 0x06024182 RID: 147842 RVA: 0x00A37084 File Offset: 0x00A35284
		public void EnterNextRound()
		{
			this.GameData.Round++;
			this.IsBusy = true;
			this.HasMoveMonsterActed = false;
			int num = this.ExecutionToken + 1;
			this.ExecutionToken = num;
			int executionToken = num;
			this.ProcessCurrentRound(executionToken).Forget();
		}

		// Token: 0x06024183 RID: 147843 RVA: 0x00A370D0 File Offset: 0x00A352D0
		private UniTask ProcessCurrentRound(int executionToken)
		{
			RoundManager.<ProcessCurrentRound>d__33 <ProcessCurrentRound>d__;
			<ProcessCurrentRound>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ProcessCurrentRound>d__.<>4__this = this;
			<ProcessCurrentRound>d__.executionToken = executionToken;
			<ProcessCurrentRound>d__.<>1__state = -1;
			<ProcessCurrentRound>d__.<>t__builder.Start<RoundManager.<ProcessCurrentRound>d__33>(ref <ProcessCurrentRound>d__);
			return <ProcessCurrentRound>d__.<>t__builder.Task;
		}

		// Token: 0x06024184 RID: 147844 RVA: 0x00A3711C File Offset: 0x00A3531C
		private UniTask ProcessPlayerPhase(int executionToken)
		{
			RoundManager.<ProcessPlayerPhase>d__34 <ProcessPlayerPhase>d__;
			<ProcessPlayerPhase>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ProcessPlayerPhase>d__.<>4__this = this;
			<ProcessPlayerPhase>d__.executionToken = executionToken;
			<ProcessPlayerPhase>d__.<>1__state = -1;
			<ProcessPlayerPhase>d__.<>t__builder.Start<RoundManager.<ProcessPlayerPhase>d__34>(ref <ProcessPlayerPhase>d__);
			return <ProcessPlayerPhase>d__.<>t__builder.Task;
		}

		// Token: 0x06024185 RID: 147845 RVA: 0x00A37168 File Offset: 0x00A35368
		private UniTask ProcessResolutionPhase(int executionToken)
		{
			RoundManager.<ProcessResolutionPhase>d__35 <ProcessResolutionPhase>d__;
			<ProcessResolutionPhase>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ProcessResolutionPhase>d__.<>4__this = this;
			<ProcessResolutionPhase>d__.executionToken = executionToken;
			<ProcessResolutionPhase>d__.<>1__state = -1;
			<ProcessResolutionPhase>d__.<>t__builder.Start<RoundManager.<ProcessResolutionPhase>d__35>(ref <ProcessResolutionPhase>d__);
			return <ProcessResolutionPhase>d__.<>t__builder.Task;
		}

		// Token: 0x06024186 RID: 147846 RVA: 0x00A371B4 File Offset: 0x00A353B4
		public UniTask RunResolutionPhaseAsync()
		{
			RoundManager.<RunResolutionPhaseAsync>d__36 <RunResolutionPhaseAsync>d__;
			<RunResolutionPhaseAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RunResolutionPhaseAsync>d__.<>4__this = this;
			<RunResolutionPhaseAsync>d__.<>1__state = -1;
			<RunResolutionPhaseAsync>d__.<>t__builder.Start<RoundManager.<RunResolutionPhaseAsync>d__36>(ref <RunResolutionPhaseAsync>d__);
			return <RunResolutionPhaseAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06024187 RID: 147847 RVA: 0x00A371F8 File Offset: 0x00A353F8
		private UniTask ProcessSequence(IReadOnlyList<RoundManager.RoundSequenceNode> sequence, int executionToken)
		{
			RoundManager.<ProcessSequence>d__37 <ProcessSequence>d__;
			<ProcessSequence>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ProcessSequence>d__.<>4__this = this;
			<ProcessSequence>d__.sequence = sequence;
			<ProcessSequence>d__.executionToken = executionToken;
			<ProcessSequence>d__.<>1__state = -1;
			<ProcessSequence>d__.<>t__builder.Start<RoundManager.<ProcessSequence>d__37>(ref <ProcessSequence>d__);
			return <ProcessSequence>d__.<>t__builder.Task;
		}

		// Token: 0x06024188 RID: 147848 RVA: 0x00A3724C File Offset: 0x00A3544C
		private UniTask ProcessStep(ERoundStep step, int executionToken)
		{
			RoundManager.<ProcessStep>d__38 <ProcessStep>d__;
			<ProcessStep>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ProcessStep>d__.<>4__this = this;
			<ProcessStep>d__.step = step;
			<ProcessStep>d__.executionToken = executionToken;
			<ProcessStep>d__.<>1__state = -1;
			<ProcessStep>d__.<>t__builder.Start<RoundManager.<ProcessStep>d__38>(ref <ProcessStep>d__);
			return <ProcessStep>d__.<>t__builder.Task;
		}

		// Token: 0x06024189 RID: 147849 RVA: 0x00A3729F File Offset: 0x00A3549F
		public bool ShouldAbortCurrentRound()
		{
			return this.ShouldAbortRound(this.ExecutionToken);
		}

		// Token: 0x0602418A RID: 147850 RVA: 0x00A372B0 File Offset: 0x00A354B0
		private bool ShouldAbortRound(int executionToken)
		{
			if (this.ExecutionToken != executionToken)
			{
				return true;
			}
			WuWaGoMainControlRole mainControlRole = this.GameData.MainControlRole;
			if (mainControlRole == null)
			{
				return false;
			}
			if (mainControlRole.IsDead)
			{
				return true;
			}
			WuWaGoGrid gridById = this.GameData.GetGridById(mainControlRole.StandGridId);
			return gridById != null && gridById.IsEndPoint;
		}

		// Token: 0x0602418B RID: 147851 RVA: 0x00A372FF File Offset: 0x00A354FF
		public void NotifyMoveMonsterActed()
		{
			this.HasMoveMonsterActed = true;
		}

		// Token: 0x0602418C RID: 147852 RVA: 0x00A37308 File Offset: 0x00A35508
		private IRoundStepExecutor GetStepExecutor(ERoundStep step)
		{
			return this.StepExecutors.GetValueOrDefault(step) ?? this.DefaultStepExecutor;
		}

		// Token: 0x0602418D RID: 147853 RVA: 0x00A37320 File Offset: 0x00A35520
		[NullableContext(2)]
		private void SetCurrentProcess(IExecutableUnit unit = null, string debugName = null)
		{
			this.CurProcess = unit;
			string currentProcessDebugName = debugName;
			if (debugName == null)
			{
				if (unit == null)
				{
					currentProcessDebugName = null;
				}
				else
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
					defaultInterpolatedStringHandler.AppendFormatted<Enum>(unit.Type);
					defaultInterpolatedStringHandler.AppendLiteral(":");
					defaultInterpolatedStringHandler.AppendFormatted<int>(unit.Id);
					currentProcessDebugName = defaultInterpolatedStringHandler.ToStringAndClear();
				}
			}
			this.CurrentProcessDebugName = currentProcessDebugName;
		}

		// Token: 0x0602418E RID: 147854 RVA: 0x00A3737C File Offset: 0x00A3557C
		public RoundManager()
		{
			Dictionary<ERoundStep, List<IExecutableUnit>> dictionary = new Dictionary<ERoundStep, List<IExecutableUnit>>();
			dictionary[ERoundStep.PlayerAction] = new List<IExecutableUnit>();
			dictionary[ERoundStep.SpikeTrap] = new List<IExecutableUnit>();
			dictionary[ERoundStep.PressureTrigger] = new List<IExecutableUnit>();
			dictionary[ERoundStep.BowTrap] = new List<IExecutableUnit>();
			dictionary[ERoundStep.MovableFloor] = new List<IExecutableUnit>();
			dictionary[ERoundStep.MonsterAction] = new List<IExecutableUnit>();
			dictionary[ERoundStep.GearTrap] = new List<IExecutableUnit>();
			this.StepUnits = dictionary;
			this.StepExecutors = new Dictionary<ERoundStep, IRoundStepExecutor>();
			base..ctor();
		}

		// Token: 0x040141F8 RID: 82424
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private static IReadOnlyList<RoundManager.RoundSequenceNode> _resolutionSequence;

		// Token: 0x040141F9 RID: 82425
		protected WuWaGoGameData GameData;

		// Token: 0x040141FA RID: 82426
		private readonly Dictionary<ERoundStep, List<IExecutableUnit>> StepUnits;

		// Token: 0x040141FB RID: 82427
		[Nullable(2)]
		private IExecutableUnit CurProcess;

		// Token: 0x040141FC RID: 82428
		private bool HasMoveMonsterActed;

		// Token: 0x040141FD RID: 82429
		private int ExecutionToken;

		// Token: 0x040141FE RID: 82430
		private readonly Dictionary<ERoundStep, IRoundStepExecutor> StepExecutors;

		// Token: 0x040141FF RID: 82431
		private IRoundStepExecutor DefaultStepExecutor;

		// Token: 0x0200933F RID: 37695
		[Nullable(0)]
		private class RoundSequenceNode : IEquatable<RoundManager.RoundSequenceNode>
		{
			// Token: 0x06043C05 RID: 277509 RVA: 0x0140DEAA File Offset: 0x0140C0AA
			public RoundSequenceNode(ERoundStep Step, string PhaseTag, [Nullable(new byte[]
			{
				2,
				1
			})] Func<RoundManager, bool> ShouldExecute = null)
			{
				this.Step = Step;
				this.PhaseTag = PhaseTag;
				this.ShouldExecute = ShouldExecute;
				base..ctor();
			}

			// Token: 0x170078E9 RID: 30953
			// (get) Token: 0x06043C06 RID: 277510 RVA: 0x0140DEC7 File Offset: 0x0140C0C7
			[CompilerGenerated]
			protected virtual Type EqualityContract
			{
				[CompilerGenerated]
				get
				{
					return typeof(RoundManager.RoundSequenceNode);
				}
			}

			// Token: 0x170078EA RID: 30954
			// (get) Token: 0x06043C07 RID: 277511 RVA: 0x0140DED3 File Offset: 0x0140C0D3
			// (set) Token: 0x06043C08 RID: 277512 RVA: 0x0140DEDB File Offset: 0x0140C0DB
			public ERoundStep Step { get; set; }

			// Token: 0x170078EB RID: 30955
			// (get) Token: 0x06043C09 RID: 277513 RVA: 0x0140DEE4 File Offset: 0x0140C0E4
			// (set) Token: 0x06043C0A RID: 277514 RVA: 0x0140DEEC File Offset: 0x0140C0EC
			public string PhaseTag { get; set; }

			// Token: 0x170078EC RID: 30956
			// (get) Token: 0x06043C0B RID: 277515 RVA: 0x0140DEF5 File Offset: 0x0140C0F5
			// (set) Token: 0x06043C0C RID: 277516 RVA: 0x0140DEFD File Offset: 0x0140C0FD
			[Nullable(new byte[]
			{
				2,
				1
			})]
			public Func<RoundManager, bool> ShouldExecute { [return: Nullable(new byte[]
			{
				2,
				1
			})] get; [param: Nullable(new byte[]
			{
				2,
				1
			})] set; }

			// Token: 0x06043C0D RID: 277517 RVA: 0x0140DF08 File Offset: 0x0140C108
			[CompilerGenerated]
			public override string ToString()
			{
				StringBuilder stringBuilder = new StringBuilder();
				stringBuilder.Append("RoundSequenceNode");
				stringBuilder.Append(" { ");
				if (this.PrintMembers(stringBuilder))
				{
					stringBuilder.Append(' ');
				}
				stringBuilder.Append('}');
				return stringBuilder.ToString();
			}

			// Token: 0x06043C0E RID: 277518 RVA: 0x0140DF54 File Offset: 0x0140C154
			[CompilerGenerated]
			protected virtual bool PrintMembers(StringBuilder builder)
			{
				RuntimeHelpers.EnsureSufficientExecutionStack();
				builder.Append("Step = ");
				builder.Append(this.Step.ToString());
				builder.Append(", PhaseTag = ");
				builder.Append(this.PhaseTag);
				builder.Append(", ShouldExecute = ");
				builder.Append(this.ShouldExecute);
				return true;
			}

			// Token: 0x06043C0F RID: 277519 RVA: 0x0140DFC0 File Offset: 0x0140C1C0
			[NullableContext(2)]
			[CompilerGenerated]
			public static bool operator !=(RoundManager.RoundSequenceNode left, RoundManager.RoundSequenceNode right)
			{
				return !(left == right);
			}

			// Token: 0x06043C10 RID: 277520 RVA: 0x0140DFCC File Offset: 0x0140C1CC
			[NullableContext(2)]
			[CompilerGenerated]
			public static bool operator ==(RoundManager.RoundSequenceNode left, RoundManager.RoundSequenceNode right)
			{
				return left == right || (left != null && left.Equals(right));
			}

			// Token: 0x06043C11 RID: 277521 RVA: 0x0140DFE0 File Offset: 0x0140C1E0
			[CompilerGenerated]
			public override int GetHashCode()
			{
				return ((EqualityComparer<Type>.Default.GetHashCode(this.EqualityContract) * -1521134295 + EqualityComparer<ERoundStep>.Default.GetHashCode(this.<Step>k__BackingField)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.<PhaseTag>k__BackingField)) * -1521134295 + EqualityComparer<Func<RoundManager, bool>>.Default.GetHashCode(this.<ShouldExecute>k__BackingField);
			}

			// Token: 0x06043C12 RID: 277522 RVA: 0x0140E042 File Offset: 0x0140C242
			[NullableContext(2)]
			[CompilerGenerated]
			public override bool Equals(object obj)
			{
				return this.Equals(obj as RoundManager.RoundSequenceNode);
			}

			// Token: 0x06043C13 RID: 277523 RVA: 0x0140E050 File Offset: 0x0140C250
			[NullableContext(2)]
			[CompilerGenerated]
			public virtual bool Equals(RoundManager.RoundSequenceNode other)
			{
				return this == other || (other != null && this.EqualityContract == other.EqualityContract && EqualityComparer<ERoundStep>.Default.Equals(this.<Step>k__BackingField, other.<Step>k__BackingField) && EqualityComparer<string>.Default.Equals(this.<PhaseTag>k__BackingField, other.<PhaseTag>k__BackingField) && EqualityComparer<Func<RoundManager, bool>>.Default.Equals(this.<ShouldExecute>k__BackingField, other.<ShouldExecute>k__BackingField));
			}

			// Token: 0x06043C15 RID: 277525 RVA: 0x0140E0C9 File Offset: 0x0140C2C9
			[CompilerGenerated]
			protected RoundSequenceNode(RoundManager.RoundSequenceNode original)
			{
				this.Step = original.<Step>k__BackingField;
				this.PhaseTag = original.<PhaseTag>k__BackingField;
				this.ShouldExecute = original.<ShouldExecute>k__BackingField;
			}

			// Token: 0x06043C16 RID: 277526 RVA: 0x0140E0F5 File Offset: 0x0140C2F5
			[CompilerGenerated]
			public void Deconstruct(out ERoundStep Step, out string PhaseTag, [Nullable(new byte[]
			{
				2,
				1
			})] out Func<RoundManager, bool> ShouldExecute)
			{
				Step = this.Step;
				PhaseTag = this.PhaseTag;
				ShouldExecute = this.ShouldExecute;
			}
		}
	}
}
