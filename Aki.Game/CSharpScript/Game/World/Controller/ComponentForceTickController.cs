using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Core.Framework;

namespace CSharpScript.Game.World.Controller
{
	// Token: 0x0200345F RID: 13407
	[NullableContext(1)]
	[Nullable(0)]
	[TickController(0)]
	public class ComponentForceTickController : ControllerBase
	{
		// Token: 0x06022356 RID: 140118 RVA: 0x009B04EC File Offset: 0x009AE6EC
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

		// Token: 0x06022357 RID: 140119 RVA: 0x009B0684 File Offset: 0x009AE884
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

		// Token: 0x06022358 RID: 140120 RVA: 0x009B0718 File Offset: 0x009AE918
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

		// Token: 0x06022359 RID: 140121 RVA: 0x009B0769 File Offset: 0x009AE969
		public void UnregisterPreTick(Action<float> func)
		{
			Core.Instance.UnRegisterPreTick(func);
		}

		// Token: 0x0602235A RID: 140122 RVA: 0x009B0778 File Offset: 0x009AE978
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

		// Token: 0x0602235B RID: 140123 RVA: 0x009B080C File Offset: 0x009AEA0C
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

		// Token: 0x0602235C RID: 140124 RVA: 0x009B08A0 File Offset: 0x009AEAA0
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

		// Token: 0x0602235D RID: 140125 RVA: 0x009B08F8 File Offset: 0x009AEAF8
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

		// Token: 0x0602235E RID: 140126 RVA: 0x009B0950 File Offset: 0x009AEB50
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

		// Token: 0x0602235F RID: 140127 RVA: 0x009B09A8 File Offset: 0x009AEBA8
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

		// Token: 0x06022360 RID: 140128 RVA: 0x009B0AB8 File Offset: 0x009AECB8
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

		// Token: 0x06022361 RID: 140129 RVA: 0x009B0BC8 File Offset: 0x009AEDC8
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

		// Token: 0x06022362 RID: 140130 RVA: 0x009B0CDC File Offset: 0x009AEEDC
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

		// Token: 0x06022363 RID: 140131 RVA: 0x009B0D3C File Offset: 0x009AEF3C
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

		// Token: 0x06022364 RID: 140132 RVA: 0x009B0D9C File Offset: 0x009AEF9C
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

		// Token: 0x06022365 RID: 140133 RVA: 0x009B0DFC File Offset: 0x009AEFFC
		[return: Nullable(2)]
		private Stat CreateStat(Dictionary<string, Stat> map, string type, string prefix)
		{
			return null;
		}

		// Token: 0x06022366 RID: 140134 RVA: 0x009B0E0A File Offset: 0x009AF00A
		public void SetTimeDilation(float timeDilation)
		{
			this.TimeDilationInternal = timeDilation;
		}

		// Token: 0x06022367 RID: 140135 RVA: 0x009B0E14 File Offset: 0x009AF014
		private bool IsComponentInstance(EntityComponent comp, EComponent compId)
		{
			Type type = comp.GetType();
			while (type != null && type != typeof(EntityComponent))
			{
				if (EntityComponentConstant.GetComponentIndex(type) == (int)compId)
				{
					return true;
				}
				type = type.BaseType;
			}
			return false;
		}

		// Token: 0x170047F5 RID: 18421
		// (get) Token: 0x06022368 RID: 140136 RVA: 0x009B0E58 File Offset: 0x009AF058
		public static ComponentForceTickController Instance
		{
			get
			{
				return ComponentForceTickController._Instance;
			}
		}

		// Token: 0x06022369 RID: 140137 RVA: 0x009B0E5F File Offset: 0x009AF05F
		public static ComponentForceTickController GetOrCreateInstance()
		{
			if (ComponentForceTickController._Instance == null)
			{
				ComponentForceTickController.CreateInstance();
			}
			return ComponentForceTickController._Instance;
		}

		// Token: 0x0602236A RID: 140138 RVA: 0x009B0E73 File Offset: 0x009AF073
		public static bool CreateInstance()
		{
			if (ComponentForceTickController._Instance != null)
			{
				return true;
			}
			ComponentForceTickController._Instance = new ComponentForceTickController();
			return true;
		}

		// Token: 0x0602236B RID: 140139 RVA: 0x009B0E89 File Offset: 0x009AF089
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602236C RID: 140140 RVA: 0x009B0E8B File Offset: 0x009AF08B
		public static void ResetStaticDefaultValue()
		{
			ComponentForceTickController._Instance = null;
		}

		// Token: 0x0602236D RID: 140141 RVA: 0x009B0E93 File Offset: 0x009AF093
		static ComponentForceTickController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ComponentForceTickController.CreateStaticDefaultValue), new Action(ComponentForceTickController.ResetStaticDefaultValue));
		}

		// Token: 0x04012D61 RID: 77153
		private List<EComponent> ApproveRegisterTickComponents = new List<EComponent>();

		// Token: 0x04012D62 RID: 77154
		private List<EComponent> ApproveRegisterAfterTickComponents = new List<EComponent>();

		// Token: 0x04012D63 RID: 77155
		private List<EComponent> ApproveRegisterPreTickComponents = new List<EComponent>();

		// Token: 0x04012D64 RID: 77156
		private readonly Dictionary<string, Stat> PreTickStatMap = new Dictionary<string, Stat>();

		// Token: 0x04012D65 RID: 77157
		private readonly Dictionary<string, Stat> TickStatMap = new Dictionary<string, Stat>();

		// Token: 0x04012D66 RID: 77158
		private readonly Dictionary<string, Stat> AfterTickStatMap = new Dictionary<string, Stat>();

		// Token: 0x04012D67 RID: 77159
		private float TimeDilationInternal = 1f;

		// Token: 0x04012D68 RID: 77160
		private readonly Dictionary<EntityComponent, Action<float>> PreMoveTickFunctions = new Dictionary<EntityComponent, Action<float>>();

		// Token: 0x04012D69 RID: 77161
		private readonly Dictionary<EntityComponent, Action<float>> TickFunctions = new Dictionary<EntityComponent, Action<float>>();

		// Token: 0x04012D6A RID: 77162
		private readonly Dictionary<EntityComponent, Action<float>> AfterTickFunctions = new Dictionary<EntityComponent, Action<float>>();

		// Token: 0x04012D6B RID: 77163
		[Nullable(2)]
		private static ComponentForceTickController _Instance;
	}
}
