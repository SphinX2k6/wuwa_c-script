using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using AkiClient.Game.Aki.Render.RuntimeBP.PCG.CarPaint.BluePrints;
using AkiClient.Game.Aki.Render.RuntimeBP.PCG.PBD_PhysicBridge.BP;
using CSharpScript.Game.NewWorld.SceneItem;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02006B23 RID: 27427
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelEventExecBpActorFunc : LevelEventBase
	{
		// Token: 0x060440D0 RID: 278736 RVA: 0x010BAD6B File Offset: 0x010B8F6B
		public LevelEventExecBpActorFunc(int id) : base(id)
		{
		}

		// Token: 0x060440D1 RID: 278737 RVA: 0x010BAD74 File Offset: 0x010B8F74
		public override void ExecuteNew(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			ExecBpActorFunc execBpActorFunc = inParams as ExecBpActorFunc;
			if (execBpActorFunc == null)
			{
				global::Log.Instance.Error(ELogModule.LevelEvent, ELogAuthor.HF, "[LevelEventExecBpActorFunc] 参数不合法", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			EBpActorFuncType type = execBpActorFunc.ExecFuncType.Type;
			if (type == EBpActorFuncType.CarPaintChange)
			{
				this.HandleCarPaintChange(execBpActorFunc.ExecFuncType as ICarPaintChangeBpActorFunc, context);
				base.FinishExecute(true, false, true);
				return;
			}
			if (type != EBpActorFuncType.BrokenBridgeEffectInMobile)
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.LevelEvent;
				ELogAuthor author = ELogAuthor.HF;
				string message = "[LevelEventExecBpActorFunc] 未支持的蓝图函数类型";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ExecFuncType", execBpActorFunc.ExecFuncType);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			this.HandleBrokenBridgeEffectInMobile(execBpActorFunc.ExecFuncType as IBrokenBridgeEffectInMobileBpActorFunc, context);
			base.FinishExecute(true, false, true);
		}

		// Token: 0x060440D2 RID: 278738 RVA: 0x010BAE24 File Offset: 0x010B9024
		private void HandleCarPaintChange([Nullable(2)] ICarPaintChangeBpActorFunc param, GeneralContext context)
		{
			if (param == null)
			{
				global::Log.Instance.Error(ELogModule.LevelEvent, ELogAuthor.HF, "[LevelEventExecBpActorFunc] CarPaintChange参数不合法", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			IBPI_CarPaintChange_C ibpi_CarPaintChange_C = this.GetSceneRefActor(param.BpActor.PathName, context) as IBPI_CarPaintChange_C;
			if (ibpi_CarPaintChange_C == null)
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.LevelEvent;
				ELogAuthor author = ELogAuthor.HF;
				string message = "[LevelEventExecBpActorFunc] BpActor不是BPI_CarPaintChange_C";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("RefPath", param.BpActor.PathName);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			global::Log.Instance.Info(ELogModule.LevelEvent, ELogAuthor.HF, "[LevelEventExecBpActorFunc] HandleCarPaintChange", default(ReadOnlySpan<ValueTuple<string, object>>));
			ibpi_CarPaintChange_C.SetColorFunctionByBPI(true);
		}

		// Token: 0x060440D3 RID: 278739 RVA: 0x010BAEC4 File Offset: 0x010B90C4
		private void HandleBrokenBridgeEffectInMobile([Nullable(2)] IBrokenBridgeEffectInMobileBpActorFunc param, GeneralContext context)
		{
			if (param == null)
			{
				global::Log.Instance.Error(ELogModule.LevelEvent, ELogAuthor.CK, "[LevelEventExecBpActorFunc] BrokenBridgeEffectInMobile参数不合法", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			AActor sceneRefActor = this.GetSceneRefActor(param.BpActor.PathName, context);
			if (sceneRefActor == null)
			{
				global::Log.Instance.Info(ELogModule.LevelEvent, ELogAuthor.CK, "[LevelEventExecBpActorFunc] Skip HandleBrokenBridgeEffectInMobile", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			IBPI_BridgeModels_BrokenMobile_C ibpi_BridgeModels_BrokenMobile_C = sceneRefActor as IBPI_BridgeModels_BrokenMobile_C;
			if (ibpi_BridgeModels_BrokenMobile_C == null)
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.LevelEvent;
				ELogAuthor author = ELogAuthor.CK;
				string message = "[LevelEventExecBpActorFunc] BpActor不是BPI_BridgeModels_BrokenMobile_C";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("RefPath", param.BpActor.PathName);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			global::Log.Instance.Info(ELogModule.LevelEvent, ELogAuthor.CK, "[LevelEventExecBpActorFunc] HandleBrokenBridgeEffectInMobile", default(ReadOnlySpan<ValueTuple<string, object>>));
			ibpi_BridgeModels_BrokenMobile_C.BreakTrigger();
		}

		// Token: 0x060440D4 RID: 278740 RVA: 0x010BAF84 File Offset: 0x010B9184
		[return: Nullable(2)]
		private AActor GetSceneRefActor(string pathName, GeneralContext context)
		{
			EntityContext entityContext = context as EntityContext;
			if (entityContext == null)
			{
				global::Log.Instance.Error(ELogModule.LevelEvent, ELogAuthor.HF, "[LevelEventExecBpActorFunc] 此事件只能配置在SceneActorRefComponent中", default(ReadOnlySpan<ValueTuple<string, object>>));
				return null;
			}
			if (entityContext.EntityId == null)
			{
				global::Log.Instance.Error(ELogModule.LevelEvent, ELogAuthor.HF, "[LevelEventExecBpActorFunc] EntityId不存在", default(ReadOnlySpan<ValueTuple<string, object>>));
				return null;
			}
			Entity entity = EntitySystem.Instance.Get(entityContext.EntityId.Value);
			if (entity == null || !entity.Valid)
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.LevelEvent;
				ELogAuthor author = ELogAuthor.HF;
				string message = "[LevelEventExecBpActorFunc] entity不存在";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("EntityId", entityContext.EntityId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return null;
			}
			SceneItemReferenceComponent component = entity.GetComponent<SceneItemReferenceComponent>();
			if (component == null)
			{
				global::Log.Instance.Error(ELogModule.LevelEvent, ELogAuthor.HF, "[LevelEventExecBpActorFunc] SceneItemReferenceComponent 组件不存在", default(ReadOnlySpan<ValueTuple<string, object>>));
				return null;
			}
			string[] array = pathName.Split('.', StringSplitOptions.None);
			if (array.Length < 3)
			{
				global::Log instance2 = global::Log.Instance;
				ELogModule module2 = ELogModule.LevelEvent;
				ELogAuthor author2 = ELogAuthor.HF;
				string message2 = "[LevelEventExecBpActorFunc] actor路径错误";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("RefPath", pathName);
				instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				return null;
			}
			string text = array[1] + "." + array[2];
			if (!component.IsValidPlatFormPath(text))
			{
				return null;
			}
			UKuroActorSubsystem ukuroActorSubsystem = UKuroRenderingRuntimeBPPluginBPLibrary.GetSubsystem(GlobalData.World, UKuroActorSubsystem.StaticClass()) as UKuroActorSubsystem;
			AActor aactor = (ukuroActorSubsystem != null) ? ukuroActorSubsystem.GetActor(new FName(text)) : null;
			if (aactor == null || !aactor.IsValid())
			{
				global::Log instance3 = global::Log.Instance;
				ELogModule module3 = ELogModule.LevelEvent;
				ELogAuthor author3 = ELogAuthor.HF;
				string message3 = "[LevelEventExecBpActorFunc] 目标actor不存在";
				ValueTuple<string, object> valueTuple3 = new ValueTuple<string, object>("RefPath", pathName);
				instance3.Warn(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple3));
				return null;
			}
			return aactor;
		}
	}
}
