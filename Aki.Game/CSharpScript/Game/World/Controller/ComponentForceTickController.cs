using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Core.Framework;

namespace CSharpScript.Game.World.Controller
{
	// Token: 0x02004537 RID: 17719
	[NullableContext(1)]
	[Nullable(0)]
	[TickController(0)]
	public class ComponentForceTickController : ControllerBase
	{
		// Token: 0x0602DC79 RID: 187513 RVA: 0x00A84FFC File Offset: 0x00A831FC
		protected unsafe override bool OnInit()
		{
			int num = 4;
			List<EComponent> list = new List<EComponent>(num);
			CollectionsMarshal.SetCount<EComponent>(list, num);
			Span<EComponent> span = CollectionsMarshal.AsSpan<EComponent>(list);
			int num2 = 0;
			*span[num2] = EComponent.GamePlayElevatorComponent;
			num2++;
			*span[num2] = EComponent.RoadNetworkNavigationComponent;
			num2++;
			*span[num2] = EComponent.PathDrivenActorSpawnerComponent;
			num2++;
			*span[num2] = EComponent.SceneItemReferenceComponent;
			this.ApproveRegisterPreTickComponents = list;
			num2 = 11;
			List<EComponent> list2 = new List<EComponent>(num2);
			CollectionsMarshal.SetCount<EComponent>(list2, num2);
			span = CollectionsMarshal.AsSpan<EComponent>(list2);
			num = 0;
			*span[num] = EComponent.CharacterCombatMessageComponent;
			num++;
			*span[num] = EComponent.CharacterMovementSyncComponent;
			num++;
			*span[num] = EComponent.GamePlayElevatorComponent;
			num++;
			*span[num] = EComponent.PostProcessBridgeComponent;
			num++;
			*span[num] = EComponent.SceneItemManipulatableComponent;
			num++;
			*span[num] = EComponent.SceneItemMovementSyncComponent;
			num++;
			*span[num] = EComponent.SceneItemDropItemComponent;
			num++;
			*span[num] = EComponent.SceneItemConveyorBeltComponent;
			num++;
			*span[num] = EComponent.SceneItemFanComponent;
			num++;
			*span[num] = EComponent.SceneItemMultiInteractionActorComponent;
			num++;
			*span[num] = EComponent.SceneItemCameraAlertComponent;
			this.ApproveRegisterTickComponents = list2;
			num = 3;
			List<EComponent> list3 = new List<EComponent>(num);
			CollectionsMarshal.SetCount<EComponent>(list3, num);
			span = CollectionsMarshal.AsSpan<EComponent>(list3);
			num2 = 0;
			*span[num2] = EComponent.CharacterLogicStateSyncComponent;
			num2++;
			*span[num2] = EComponent.CharacterMovementSyncComponent;
			num2++;
			*span[num2] = EComponent.SceneItemMovementSyncComponent;
			this.ApproveRegisterAfterTickComponents = list3;
			return true;
		}

		// Token: 0x0602DC7A RID: 187514 RVA: 0x00A85194 File Offset: 0x00A83394
		public void RegisterPreMoveTick(EntityComponent comp, Action<float> func)
		{
			if (!this.IsTypeApproveRegisterPreTick(comp))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.TickController;
				ELogAuthor author = ELogAuthor.ZFJ;
				string message = "[ComponentForceTickController.RegisterPreMoveTick] 当前Comp不允许注册到ForceTickController";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Comp", comp.ToString());
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			if (this.PreMoveTickFunctions.ContainsKey(comp))
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.TickController;
				ELogAuthor author2 = ELogAuthor.ZFJ;
				string message2 = "[ComponentForceTickController.RegisterPreMoveTick] 当前Comp已经注册过ForceTick";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("Comp", comp.ToString());
				instance2.Warn(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				return;
			}
			this.PreMoveTickFunctions[comp] = func;
		}

		// Token: 0x0602DC7B RID: 187515 RVA: 0x00A85228 File Offset: 0x00A83428
		public void RegisterPreTick(EntityComponent comp, Action<float> func)
		{
			if (!this.IsTypeApproveRegisterPreTick(comp))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.TickController;
				ELogAuthor author = ELogAuthor.CH;
				string message = "[ComponentForceTickController.RegisterTick] 当前Comp不允许注册到ForceTickController";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Comp", comp.ToString());
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			Core.Instance.RegisterPreTick(func);
		}

		// Token: 0x0602DC7C RID: 187516 RVA: 0x00A85279 File Offset: 0x00A83479
		public void UnregisterPreTick(Action<float> func)
		{
			Core.Instance.UnRegisterPreTick(func);
		}

		// Token: 0x0602DC7D RID: 187517 RVA: 0x00A85288 File Offset: 0x00A83488
		public void RegisterTick(EntityComponent comp, Action<float> func)
		{
			if (!this.IsTypeApproveRegisterTick(comp))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.TickController;
				ELogAuthor author = ELogAuthor.CH;
				string message = "[ComponentForceTickController.RegisterTick] 当前Comp不允许注册到ForceTickController";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Comp", comp.ToString());
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			if (this.TickFunctions.ContainsKey(comp))
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.TickController;
				ELogAuthor author2 = ELogAuthor.CH;
				string message2 = "[ComponentForceTickController.RegisterTick] 当前Comp已经注册过ForceTick";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("Comp", comp.ToString());
				instance2.Warn(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				return;
			}
			this.TickFunctions[comp] = func;
		}

		// Token: 0x0602DC7E RID: 187518 RVA: 0x00A8531C File Offset: 0x00A8351C
		public void RegisterAfterTick(EntityComponent comp, Action<float> func)
		{
			if (!this.IsTypeApproveRegisterAfterTick(comp))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.TickController;
				ELogAuthor author = ELogAuthor.CH;
				string message = "[ComponentForceTickController.RegisterAfterTick] 当前Comp不允许注册到ForceTickController";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Comp", comp.ToString());
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			if (this.AfterTickFunctions.ContainsKey(comp))
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.TickController;
				ELogAuthor author2 = ELogAuthor.CH;
				string message2 = "[ComponentForceTickController.RegisterAfterTick] 当前Comp已经注册过ForceAfterTick";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("Comp", comp.ToString());
				instance2.Warn(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				return;
			}
			this.AfterTickFunctions[comp] = func;
		}

		// Token: 0x0602DC7F RID: 187519 RVA: 0x00A853B0 File Offset: 0x00A835B0
		public void UnregisterPreMoveTick(EntityComponent comp)
		{
			if (!this.PreMoveTickFunctions.ContainsKey(comp))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.TickController;
				ELogAuthor author = ELogAuthor.ZFJ;
				string message = "[ComponentForceTickController.UnregisterPreTick] 当前Comp未注册过";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Comp", comp.ToString());
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			this.PreMoveTickFunctions.Remove(comp);
		}

		// Token: 0x0602DC80 RID: 187520 RVA: 0x00A85408 File Offset: 0x00A83608
		public void UnregisterTick(EntityComponent comp)
		{
			if (!this.TickFunctions.ContainsKey(comp))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.TickController;
				ELogAuthor author = ELogAuthor.CH;
				string message = "[ComponentForceTickController.UnregisterTick] 当前Comp未注册过ForceTick";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Comp", comp.ToString());
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			this.TickFunctions.Remove(comp);
		}

		// Token: 0x0602DC81 RID: 187521 RVA: 0x00A85460 File Offset: 0x00A83660
		public void UnregisterAfterTick(EntityComponent comp)
		{
			if (!this.AfterTickFunctions.ContainsKey(comp))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.TickController;
				ELogAuthor author = ELogAuthor.CH;
				string message = "[ComponentForceTickController.UnregisterAfterTick] 当前Comp未注册过ForceAfterTick";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Comp", comp.ToString());
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			this.AfterTickFunctions.Remove(comp);
		}

		// Token: 0x0602DC82 RID: 187522 RVA: 0x00A854B8 File Offset: 0x00A836B8
		public unsafe void MoveTickPriority1(float delta)
		{
			foreach (KeyValuePair<EntityComponent, Action<float>> keyValuePair in this.PreMoveTickFunctions)
			{
				EntityComponent entityComponent;
				Action<float> action;
				keyValuePair.Deconstruct(out entityComponent, out action);
				EntityComponent entityComponent2 = entityComponent;
				Action<float> action2 = action;
				if (entityComponent2.Active)
				{
					try
					{
						this.CreateStat(this.PreTickStatMap, entityComponent2.GetType().Name, "ComponentForceTickController.PreMoveTick");
						action2(delta * this.TimeDilationInternal);
					}
					catch (Exception ex)
					{
						Log instance = Log.Instance;
						ELogModule module = ELogModule.TickController;
						ELogAuthor author = ELogAuthor.ZFJ;
						string message = "处理方法执行异常";
						Exception error = ex;
						<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("comp", entityComponent2.ToString());
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("error", ex.Message);
						instance.ErrorWithStack(module, author, message, error, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
					}
				}
			}
		}

		// Token: 0x0602DC83 RID: 187523 RVA: 0x00A855C8 File Offset: 0x00A837C8
		protected unsafe override void OnTick(float delta)
		{
			foreach (KeyValuePair<EntityComponent, Action<float>> keyValuePair in this.TickFunctions)
			{
				EntityComponent entityComponent;
				Action<float> action;
				keyValuePair.Deconstruct(out entityComponent, out action);
				EntityComponent entityComponent2 = entityComponent;
				Action<float> action2 = action;
				if (entityComponent2.Active)
				{
					try
					{
						this.CreateStat(this.TickStatMap, entityComponent2.GetType().Name, "ComponentForceTickController.OnTick.");
						action2(delta * this.TimeDilationInternal);
					}
					catch (Exception ex)
					{
						Log instance = Log.Instance;
						ELogModule module = ELogModule.TickController;
						ELogAuthor author = ELogAuthor.CH;
						string message = "处理方法执行异常";
						Exception error = ex;
						<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("comp", entityComponent2.ToString());
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("error", ex.Message);
						instance.ErrorWithStack(module, author, message, error, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
					}
				}
			}
		}

		// Token: 0x0602DC84 RID: 187524 RVA: 0x00A856D8 File Offset: 0x00A838D8
		protected unsafe override void OnAfterTick(float delta)
		{
			foreach (KeyValuePair<EntityComponent, Action<float>> keyValuePair in this.AfterTickFunctions)
			{
				EntityComponent entityComponent;
				Action<float> action;
				keyValuePair.Deconstruct(out entityComponent, out action);
				EntityComponent entityComponent2 = entityComponent;
				Action<float> action2 = action;
				try
				{
					if (entityComponent2.Active)
					{
						this.CreateStat(this.AfterTickStatMap, entityComponent2.GetType().Name, "ComponentForceTickController.OnAfterTick.");
						action2(delta * this.TimeDilationInternal);
					}
				}
				catch (Exception ex)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.TickController;
					ELogAuthor author = ELogAuthor.CH;
					string message = "处理方法执行异常";
					Exception error = ex;
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("comp", entityComponent2.ToString());
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("error", ex.Message);
					instance.ErrorWithStack(module, author, message, error, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				}
			}
		}

		// Token: 0x0602DC85 RID: 187525 RVA: 0x00A857EC File Offset: 0x00A839EC
		private bool IsTypeApproveRegisterPreTick(EntityComponent comp)
		{
			foreach (EComponent compId in this.ApproveRegisterPreTickComponents)
			{
				if (this.IsComponentInstance(comp, compId))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x0602DC86 RID: 187526 RVA: 0x00A8584C File Offset: 0x00A83A4C
		private bool IsTypeApproveRegisterTick(EntityComponent comp)
		{
			foreach (EComponent compId in this.ApproveRegisterTickComponents)
			{
				if (this.IsComponentInstance(comp, compId))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x0602DC87 RID: 187527 RVA: 0x00A858AC File Offset: 0x00A83AAC
		private bool IsTypeApproveRegisterAfterTick(EntityComponent comp)
		{
			foreach (EComponent compId in this.ApproveRegisterAfterTickComponents)
			{
				if (this.IsComponentInstance(comp, compId))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x0602DC88 RID: 187528 RVA: 0x00A8590C File Offset: 0x00A83B0C
		[return: Nullable(2)]
		private Stat CreateStat(Dictionary<string, Stat> map, string type, string prefix)
		{
			if (!Stat.Enable)
			{
				return null;
			}
			Stat stat;
			if (!map.TryGetValue(type, out stat))
			{
				stat = Stat.CreateNoFlameGraph(prefix + type, "", "");
				map[type] = stat;
			}
			return stat;
		}

		// Token: 0x0602DC89 RID: 187529 RVA: 0x00A8594D File Offset: 0x00A83B4D
		public void SetTimeDilation(float timeDilation)
		{
			this.TimeDilationInternal = timeDilation;
		}

		// Token: 0x0602DC8A RID: 187530 RVA: 0x00A85958 File Offset: 0x00A83B58
		private bool IsComponentInstance(EntityComponent comp, EComponent compId)
		{
			Type type = comp.GetType();
			while (type != null && type != typeof(EntityComponent))
			{
				if (EntityComponent.GetByType(type.Name) == (int)compId)
				{
					return true;
				}
				type = type.BaseType;
			}
			return false;
		}

		// Token: 0x1700753E RID: 30014
		// (get) Token: 0x0602DC8B RID: 187531 RVA: 0x00A859A1 File Offset: 0x00A83BA1
		public static ComponentForceTickController Instance
		{
			get
			{
				return ComponentForceTickController._Instance;
			}
		}

		// Token: 0x0602DC8C RID: 187532 RVA: 0x00A859A8 File Offset: 0x00A83BA8
		public static ComponentForceTickController GetOrCreateInstance()
		{
			if (ComponentForceTickController._Instance == null)
			{
				ComponentForceTickController.CreateInstance();
			}
			return ComponentForceTickController._Instance;
		}

		// Token: 0x0602DC8D RID: 187533 RVA: 0x00A859BC File Offset: 0x00A83BBC
		public static bool CreateInstance()
		{
			if (ComponentForceTickController._Instance != null)
			{
				return true;
			}
			ComponentForceTickController._Instance = new ComponentForceTickController();
			return true;
		}

		// Token: 0x0602DC8E RID: 187534 RVA: 0x00A859D2 File Offset: 0x00A83BD2
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602DC8F RID: 187535 RVA: 0x00A859D4 File Offset: 0x00A83BD4
		public static void ResetStaticDefaultValue()
		{
			ComponentForceTickController._Instance = null;
		}

		// Token: 0x0602DC90 RID: 187536 RVA: 0x00A859DC File Offset: 0x00A83BDC
		static ComponentForceTickController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ComponentForceTickController.CreateStaticDefaultValue), new Action(ComponentForceTickController.ResetStaticDefaultValue));
		}

		// Token: 0x0401872E RID: 100142
		private List<EComponent> ApproveRegisterTickComponents = new List<EComponent>();

		// Token: 0x0401872F RID: 100143
		private List<EComponent> ApproveRegisterAfterTickComponents = new List<EComponent>();

		// Token: 0x04018730 RID: 100144
		private List<EComponent> ApproveRegisterPreTickComponents = new List<EComponent>();

		// Token: 0x04018731 RID: 100145
		private readonly Dictionary<string, Stat> PreTickStatMap = new Dictionary<string, Stat>();

		// Token: 0x04018732 RID: 100146
		private readonly Dictionary<string, Stat> TickStatMap = new Dictionary<string, Stat>();

		// Token: 0x04018733 RID: 100147
		private readonly Dictionary<string, Stat> AfterTickStatMap = new Dictionary<string, Stat>();

		// Token: 0x04018734 RID: 100148
		private float TimeDilationInternal = 1f;

		// Token: 0x04018735 RID: 100149
		private readonly Dictionary<EntityComponent, Action<float>> PreMoveTickFunctions = new Dictionary<EntityComponent, Action<float>>();

		// Token: 0x04018736 RID: 100150
		private readonly Dictionary<EntityComponent, Action<float>> TickFunctions = new Dictionary<EntityComponent, Action<float>>();

		// Token: 0x04018737 RID: 100151
		private readonly Dictionary<EntityComponent, Action<float>> AfterTickFunctions = new Dictionary<EntityComponent, Action<float>>();

		// Token: 0x04018738 RID: 100152
		[Nullable(2)]
		private static ComponentForceTickController _Instance;
	}
}
