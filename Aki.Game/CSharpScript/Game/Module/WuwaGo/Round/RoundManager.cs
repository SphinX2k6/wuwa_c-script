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
	// Token: 0x02004729 RID: 18217
	[NullableContext(1)]
	[Nullable(0)]
	public class RoundManager : IStaticVariableResetter
	{
		// Token: 0x0602F9A8 RID: 194984 RVA: 0x00B06DB3 File Offset: 0x00B04FB3
		static RoundManager()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(RoundManager.CreateStaticDefaultValue), new Action(RoundManager.ResetStaticDefaultValue));
		}

		// Token: 0x0602F9A9 RID: 194985 RVA: 0x00B06DD4 File Offset: 0x00B04FD4
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

		// Token: 0x0602F9AA RID: 194986 RVA: 0x00B06EE7 File Offset: 0x00B050E7
		public static void ResetStaticDefaultValue()
		{
			RoundManager._resolutionSequence = null;
		}

		// Token: 0x170076F3 RID: 30451
		// (get) Token: 0x0602F9AB RID: 194987 RVA: 0x00B06EF0 File Offset: 0x00B050F0
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

		// Token: 0x170076F4 RID: 30452
		// (get) Token: 0x0602F9AC RID: 194988 RVA: 0x00B06F0F File Offset: 0x00B0510F
		// (set) Token: 0x0602F9AD RID: 194989 RVA: 0x00B06F17 File Offset: 0x00B05117
		public bool IsBusy { get; private set; }

		// Token: 0x170076F5 RID: 30453
		// (get) Token: 0x0602F9AE RID: 194990 RVA: 0x00B06F20 File Offset: 0x00B05120
		// (set) Token: 0x0602F9AF RID: 194991 RVA: 0x00B06F28 File Offset: 0x00B05128
		public ERoundStep? CurrentStep { get; private set; }

		// Token: 0x170076F6 RID: 30454
		// (get) Token: 0x0602F9B0 RID: 194992 RVA: 0x00B06F31 File Offset: 0x00B05131
		// (set) Token: 0x0602F9B1 RID: 194993 RVA: 0x00B06F39 File Offset: 0x00B05139
		[Nullable(2)]
		public string CurrentProcessDebugName { [NullableContext(2)] get; [NullableContext(2)] private set; }

		// Token: 0x0602F9B2 RID: 194994 RVA: 0x00B06F44 File Offset: 0x00B05144
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

		// Token: 0x0602F9B3 RID: 194995 RVA: 0x00B0703C File Offset: 0x00B0523C
		public void RegisterUnit(ERoundStep step, IExecutableUnit unit)
		{
			List<IExecutableUnit> list;
			if (this.StepUnits.TryGetValue(step, out list))
			{
				list.Add(unit);
			}
		}

		// Token: 0x0602F9B4 RID: 194996 RVA: 0x00B07060 File Offset: 0x00B05260
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

		// Token: 0x0602F9B5 RID: 194997 RVA: 0x00B070F8 File Offset: 0x00B052F8
		public void ResetForRollback()
		{
			this.ExecutionToken++;
			this.IsBusy = false;
			this.CurProcess = null;
			this.CurrentStep = null;
			this.CurrentProcessDebugName = null;
			this.HasMoveMonsterActed = false;
		}

		// Token: 0x0602F9B6 RID: 194998 RVA: 0x00B07140 File Offset: 0x00B05340
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

		// Token: 0x0602F9B7 RID: 194999 RVA: 0x00B071E8 File Offset: 0x00B053E8
		public void Tick(float delta)
		{
			if (!this.IsBusy)
			{
				this.EnterNextRound();
			}
		}

		// Token: 0x0602F9B8 RID: 195000 RVA: 0x00B071F8 File Offset: 0x00B053F8
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

		// Token: 0x0602F9B9 RID: 195001 RVA: 0x00B07244 File Offset: 0x00B05444
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

		// Token: 0x0602F9BA RID: 195002 RVA: 0x00B07290 File Offset: 0x00B05490
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

		// Token: 0x0602F9BB RID: 195003 RVA: 0x00B072DC File Offset: 0x00B054DC
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

		// Token: 0x0602F9BC RID: 195004 RVA: 0x00B07328 File Offset: 0x00B05528
		public UniTask RunResolutionPhaseAsync()
		{
			RoundManager.<RunResolutionPhaseAsync>d__36 <RunResolutionPhaseAsync>d__;
			<RunResolutionPhaseAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RunResolutionPhaseAsync>d__.<>4__this = this;
			<RunResolutionPhaseAsync>d__.<>1__state = -1;
			<RunResolutionPhaseAsync>d__.<>t__builder.Start<RoundManager.<RunResolutionPhaseAsync>d__36>(ref <RunResolutionPhaseAsync>d__);
			return <RunResolutionPhaseAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602F9BD RID: 195005 RVA: 0x00B0736C File Offset: 0x00B0556C
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

		// Token: 0x0602F9BE RID: 195006 RVA: 0x00B073C0 File Offset: 0x00B055C0
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

		// Token: 0x0602F9BF RID: 195007 RVA: 0x00B07413 File Offset: 0x00B05613
		public bool ShouldAbortCurrentRound()
		{
			return this.ShouldAbortRound(this.ExecutionToken);
		}

		// Token: 0x0602F9C0 RID: 195008 RVA: 0x00B07424 File Offset: 0x00B05624
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

		// Token: 0x0602F9C1 RID: 195009 RVA: 0x00B07473 File Offset: 0x00B05673
		public void NotifyMoveMonsterActed()
		{
			this.HasMoveMonsterActed = true;
		}

		// Token: 0x0602F9C2 RID: 195010 RVA: 0x00B0747C File Offset: 0x00B0567C
		private IRoundStepExecutor GetStepExecutor(ERoundStep step)
		{
			return this.StepExecutors.GetValueOrDefault(step) ?? this.DefaultStepExecutor;
		}

		// Token: 0x0602F9C3 RID: 195011 RVA: 0x00B07494 File Offset: 0x00B05694
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

		// Token: 0x0602F9C4 RID: 195012 RVA: 0x00B074F0 File Offset: 0x00B056F0
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

		// Token: 0x04019B48 RID: 105288
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private static IReadOnlyList<RoundManager.RoundSequenceNode> _resolutionSequence;

		// Token: 0x04019B49 RID: 105289
		protected WuWaGoGameData GameData;

		// Token: 0x04019B4A RID: 105290
		private readonly Dictionary<ERoundStep, List<IExecutableUnit>> StepUnits;

		// Token: 0x04019B4B RID: 105291
		[Nullable(2)]
		private IExecutableUnit CurProcess;

		// Token: 0x04019B4C RID: 105292
		private bool HasMoveMonsterActed;

		// Token: 0x04019B4D RID: 105293
		private int ExecutionToken;

		// Token: 0x04019B4E RID: 105294
		private readonly Dictionary<ERoundStep, IRoundStepExecutor> StepExecutors;

		// Token: 0x04019B4F RID: 105295
		private IRoundStepExecutor DefaultStepExecutor;

		// Token: 0x0200A985 RID: 43397
		[Nullable(0)]
		private class RoundSequenceNode : IEquatable<RoundManager.RoundSequenceNode>
		{
			// Token: 0x0604D6E1 RID: 317153 RVA: 0x0145F8EE File Offset: 0x0145DAEE
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

			// Token: 0x1700A153 RID: 41299
			// (get) Token: 0x0604D6E2 RID: 317154 RVA: 0x0145F90B File Offset: 0x0145DB0B
			[CompilerGenerated]
			protected virtual Type EqualityContract
			{
				[CompilerGenerated]
				get
				{
					return typeof(RoundManager.RoundSequenceNode);
				}
			}

			// Token: 0x1700A154 RID: 41300
			// (get) Token: 0x0604D6E3 RID: 317155 RVA: 0x0145F917 File Offset: 0x0145DB17
			// (set) Token: 0x0604D6E4 RID: 317156 RVA: 0x0145F91F File Offset: 0x0145DB1F
			public ERoundStep Step { get; set; }

			// Token: 0x1700A155 RID: 41301
			// (get) Token: 0x0604D6E5 RID: 317157 RVA: 0x0145F928 File Offset: 0x0145DB28
			// (set) Token: 0x0604D6E6 RID: 317158 RVA: 0x0145F930 File Offset: 0x0145DB30
			public string PhaseTag { get; set; }

			// Token: 0x1700A156 RID: 41302
			// (get) Token: 0x0604D6E7 RID: 317159 RVA: 0x0145F939 File Offset: 0x0145DB39
			// (set) Token: 0x0604D6E8 RID: 317160 RVA: 0x0145F941 File Offset: 0x0145DB41
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

			// Token: 0x0604D6E9 RID: 317161 RVA: 0x0145F94C File Offset: 0x0145DB4C
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

			// Token: 0x0604D6EA RID: 317162 RVA: 0x0145F998 File Offset: 0x0145DB98
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

			// Token: 0x0604D6EB RID: 317163 RVA: 0x0145FA04 File Offset: 0x0145DC04
			[NullableContext(2)]
			[CompilerGenerated]
			public static bool operator !=(RoundManager.RoundSequenceNode left, RoundManager.RoundSequenceNode right)
			{
				return !(left == right);
			}

			// Token: 0x0604D6EC RID: 317164 RVA: 0x0145FA10 File Offset: 0x0145DC10
			[NullableContext(2)]
			[CompilerGenerated]
			public static bool operator ==(RoundManager.RoundSequenceNode left, RoundManager.RoundSequenceNode right)
			{
				return left == right || (left != null && left.Equals(right));
			}

			// Token: 0x0604D6ED RID: 317165 RVA: 0x0145FA24 File Offset: 0x0145DC24
			[CompilerGenerated]
			public override int GetHashCode()
			{
				return ((EqualityComparer<Type>.Default.GetHashCode(this.EqualityContract) * -1521134295 + EqualityComparer<ERoundStep>.Default.GetHashCode(this.<Step>k__BackingField)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.<PhaseTag>k__BackingField)) * -1521134295 + EqualityComparer<Func<RoundManager, bool>>.Default.GetHashCode(this.<ShouldExecute>k__BackingField);
			}

			// Token: 0x0604D6EE RID: 317166 RVA: 0x0145FA86 File Offset: 0x0145DC86
			[NullableContext(2)]
			[CompilerGenerated]
			public override bool Equals(object obj)
			{
				return this.Equals(obj as RoundManager.RoundSequenceNode);
			}

			// Token: 0x0604D6EF RID: 317167 RVA: 0x0145FA94 File Offset: 0x0145DC94
			[NullableContext(2)]
			[CompilerGenerated]
			public virtual bool Equals(RoundManager.RoundSequenceNode other)
			{
				return this == other || (other != null && this.EqualityContract == other.EqualityContract && EqualityComparer<ERoundStep>.Default.Equals(this.<Step>k__BackingField, other.<Step>k__BackingField) && EqualityComparer<string>.Default.Equals(this.<PhaseTag>k__BackingField, other.<PhaseTag>k__BackingField) && EqualityComparer<Func<RoundManager, bool>>.Default.Equals(this.<ShouldExecute>k__BackingField, other.<ShouldExecute>k__BackingField));
			}

			// Token: 0x0604D6F1 RID: 317169 RVA: 0x0145FB0D File Offset: 0x0145DD0D
			[CompilerGenerated]
			protected RoundSequenceNode(RoundManager.RoundSequenceNode original)
			{
				this.Step = original.<Step>k__BackingField;
				this.PhaseTag = original.<PhaseTag>k__BackingField;
				this.ShouldExecute = original.<ShouldExecute>k__BackingField;
			}

			// Token: 0x0604D6F2 RID: 317170 RVA: 0x0145FB39 File Offset: 0x0145DD39
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
