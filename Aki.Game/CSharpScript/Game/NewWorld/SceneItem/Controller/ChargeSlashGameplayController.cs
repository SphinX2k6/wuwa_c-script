using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Component;
using AkiClient.Game.Aki.Effect.BluePrint.BP_FX_Common;
using CSharpScript.Core.Framework;
using CSharpScript.Game.NewWorld.Character.Custom.Components;
using CSharpScript.Game.NewWorld.SceneItem.Common.Component;
using CSharpScript.Game.NewWorld.SceneItem.SpecificScanEffect;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.SceneItem.Controller
{
	// Token: 0x02007238 RID: 29240
	[NullableContext(1)]
	[Nullable(0)]
	[TickController(0)]
	public class ChargeSlashGameplayController : ControllerBase
	{
		// Token: 0x06047A86 RID: 293510 RVA: 0x01256240 File Offset: 0x01254440
		public void StartChargeSlash(GrapplingHookPointComponent targetHook)
		{
			global::Log.Instance.Info(ELogModule.ChargeSlash, ELogAuthor.CH, "[ChargeSlashGameplayController] StartChargeSlash", default(ReadOnlySpan<ValueTuple<string, object>>));
			IChargeSlashHook chargeSlashHook = targetHook.GetHookInteractConfig() as IChargeSlashHook;
			if (chargeSlashHook == null)
			{
				global::Log.Instance.Error(ELogModule.ChargeSlash, ELogAuthor.CH, "[StartChargeSlash] interactConfig is null", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			float valueOrDefault = chargeSlashHook.MaxRandomDelayTime.GetValueOrDefault(1f);
			using (List<int>.Enumerator enumerator = chargeSlashHook.TargetEntityIds.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					int id = enumerator.Current;
					EntityHandle entityByPbDataId = CreatureModel.Instance.GetEntityByPbDataId(id);
					if (((entityByPbDataId != null) ? entityByPbDataId.Entity : null) == null)
					{
						global::Log instance = global::Log.Instance;
						ELogModule module = ELogModule.ChargeSlash;
						ELogAuthor author = ELogAuthor.CH;
						string message = "[StartChargeSlash] cannont find entity";
						ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("pbDataId", id);
						instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
					}
					else if (!entityByPbDataId.IsInit || !entityByPbDataId.Entity.IsInit)
					{
						global::Log instance2 = global::Log.Instance;
						ELogModule module2 = ELogModule.ChargeSlash;
						ELogAuthor author2 = ELogAuthor.CH;
						string message2 = "[StartChargeSlash] entity is not init";
						ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("pbDataId", id);
						instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
					}
					else
					{
						SceneItemCurveControlComponent curveControlComp = entityByPbDataId.Entity.GetComponent<SceneItemCurveControlComponent>();
						if (curveControlComp == null)
						{
							global::Log instance3 = global::Log.Instance;
							ELogModule module3 = ELogModule.ChargeSlash;
							ELogAuthor author3 = ELogAuthor.CH;
							string message3 = "[StartChargeSlash] Entity has no curveControlComp";
							ValueTuple<string, object> valueTuple3 = new ValueTuple<string, object>("pbDataId", id);
							instance3.Error(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple3));
						}
						else
						{
							float randomTime = Math.Max(Random.Shared.NextSingle() * valueOrDefault, 0.02f);
							TimerHandle timerHandle = TimerSystem.Instance.Delay(delegate(float _)
							{
								this.TimerHandlesMap.Remove(id);
								this.SceneItemStartPerformance(curveControlComp, randomTime);
							}, randomTime * 1000f, null, null, true, 1f);
							if (timerHandle == null)
							{
								global::Log instance4 = global::Log.Instance;
								ELogModule module4 = ELogModule.ChargeSlash;
								ELogAuthor author4 = ELogAuthor.CH;
								string message4 = "[StartChargeSlash] timerHandle is null";
								ValueTuple<string, object> valueTuple4 = new ValueTuple<string, object>("pbDataId", id);
								instance4.Error(module4, author4, message4, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple4));
							}
							else
							{
								this.TimerHandlesMap[id] = timerHandle;
							}
						}
					}
				}
			}
		}

		// Token: 0x06047A87 RID: 293511 RVA: 0x012564B8 File Offset: 0x012546B8
		public void StopChargeSlash(GrapplingHookPointComponent targetHook)
		{
			global::Log.Instance.Info(ELogModule.ChargeSlash, ELogAuthor.CH, "[ChargeSlashGameplayController] StopChargeSlash", default(ReadOnlySpan<ValueTuple<string, object>>));
			IChargeSlashHook chargeSlashHook = targetHook.GetHookInteractConfig() as IChargeSlashHook;
			if (chargeSlashHook == null)
			{
				global::Log.Instance.Error(ELogModule.ChargeSlash, ELogAuthor.CH, "[StopChargeSlash] interactConfig is null", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			foreach (int num in chargeSlashHook.TargetEntityIds)
			{
				EntityHandle entityByPbDataId = CreatureModel.Instance.GetEntityByPbDataId(num);
				if (((entityByPbDataId != null) ? entityByPbDataId.Entity : null) == null)
				{
					global::Log instance = global::Log.Instance;
					ELogModule module = ELogModule.ChargeSlash;
					ELogAuthor author = ELogAuthor.CH;
					string message = "[StopChargeSlash] cannont find entity";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("pbDataId", num);
					instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				}
				else if (!entityByPbDataId.IsInit || !entityByPbDataId.Entity.IsInit)
				{
					global::Log instance2 = global::Log.Instance;
					ELogModule module2 = ELogModule.ChargeSlash;
					ELogAuthor author2 = ELogAuthor.CH;
					string message2 = "[StopChargeSlash] entity is not init";
					ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("pbDataId", num);
					instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				}
				else
				{
					SceneItemCurveControlComponent component = entityByPbDataId.Entity.GetComponent<SceneItemCurveControlComponent>();
					if (component == null)
					{
						global::Log instance3 = global::Log.Instance;
						ELogModule module3 = ELogModule.ChargeSlash;
						ELogAuthor author3 = ELogAuthor.CH;
						string message3 = "[StopChargeSlash] Entity has no curveControlComp";
						ValueTuple<string, object> valueTuple3 = new ValueTuple<string, object>("pbDataId", num);
						instance3.Error(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple3));
					}
					else if (this.TimerHandlesMap.ContainsKey(num))
					{
						TimerSystem.Instance.Remove(this.TimerHandlesMap[num]);
						this.TimerHandlesMap.Remove(num);
					}
					else
					{
						component.StopPerformance();
					}
				}
			}
		}

		// Token: 0x06047A88 RID: 293512 RVA: 0x01256688 File Offset: 0x01254888
		private void SceneItemStartPerformance(SceneItemCurveControlComponent curveControlComp, float delayTime)
		{
			curveControlComp.StartPerformance(delayTime);
		}

		// Token: 0x06047A89 RID: 293513 RVA: 0x01256694 File Offset: 0x01254894
		private void ClearTimerHandles()
		{
			foreach (TimerHandle handle in this.TimerHandlesMap.Values)
			{
				TimerSystem.Instance.Remove(handle);
			}
			this.TimerHandlesMap.Clear();
		}

		// Token: 0x06047A8A RID: 293514 RVA: 0x012566FC File Offset: 0x012548FC
		protected override bool OnLeaveLevel()
		{
			this.ClearTimerHandles();
			return true;
		}

		// Token: 0x06047A8B RID: 293515 RVA: 0x01256705 File Offset: 0x01254905
		protected override bool OnClear()
		{
			this.ClearTimerHandles();
			return true;
		}

		// Token: 0x06047A8C RID: 293516 RVA: 0x01256710 File Offset: 0x01254910
		protected override void OnTick(float delta)
		{
			if (this.ChargeSlashScanEffectMap.Count == 0)
			{
				return;
			}
			List<int> list = new List<int>();
			foreach (KeyValuePair<int, SpecificScanEffectData> keyValuePair in this.ChargeSlashScanEffectMap)
			{
				if (!keyValuePair.Value.Update(delta))
				{
					list.Add(keyValuePair.Key);
				}
			}
			foreach (int id in list)
			{
				this.StopChargeSlashScanEffect(id);
			}
		}

		// Token: 0x06047A8D RID: 293517 RVA: 0x012567CC File Offset: 0x012549CC
		public int StartChargeSlashScanEffect(FTransformDouble transform)
		{
			global::Log.Instance.Info(ELogModule.ChargeSlash, ELogAuthor.CH, "[ChargeSlashGameplayController] StartChargeSlashScanEffect", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.Uid++;
			ResourceSystem.Instance.LoadAsync<UClass>("/Game/Aki/Effect/BluePrint/BP_FX_Common/BP_DistortionWave.BP_DistortionWave_C", delegate([Nullable(2)] UClass result, string _)
			{
				if (result == null)
				{
					global::Log instance = global::Log.Instance;
					ELogModule module = ELogModule.LevelEvent;
					ELogAuthor author = ELogAuthor.CH;
					string message = "加载ChargeSlash扫描特效失败";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("path", "/Game/Aki/Effect/BluePrint/BP_FX_Common/BP_DistortionWave.BP_DistortionWave_C");
					instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
					return;
				}
				BP_DistortionWave_C bp_DistortionWave_C = ActorSystem.Instance.Spawn(result.ClassStackOnlyPtr, transform, null) as BP_DistortionWave_C;
				bp_DistortionWave_C.StartScanEffect();
				this.ChargeSlashScanEffectMap.Add(this.Uid, new SpecificScanEffectData(this.Uid, bp_DistortionWave_C, transform.GetLocation(), new ESpecificScanType?(ESpecificScanType.ChargeSlash)));
			}, 100, "js_undefined");
			return this.Uid;
		}

		// Token: 0x06047A8E RID: 293518 RVA: 0x01256844 File Offset: 0x01254A44
		public void StopChargeSlashScanEffect(int id)
		{
			SpecificScanEffectData specificScanEffectData;
			if (this.ChargeSlashScanEffectMap.TryGetValue(id, out specificScanEffectData))
			{
				ActorSystem instance = ActorSystem.Instance;
				string reason = "StopChargeSlashScanEffect";
				SpecificScanEffectData specificScanEffectData2 = specificScanEffectData;
				instance.Put(reason, (specificScanEffectData2.EffectActor != null) ? specificScanEffectData2.EffectActor.GetValueOrDefault().AsT1 : null, null);
				this.ChargeSlashScanEffectMap.Remove(id);
				return;
			}
			global::Log instance2 = global::Log.Instance;
			ELogModule module = ELogModule.ChargeSlash;
			ELogAuthor author = ELogAuthor.CH;
			string message = "[StopChargeSlashScanEffect] data is null";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", id);
			instance2.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}

		// Token: 0x06047A8F RID: 293519 RVA: 0x012568D0 File Offset: 0x01254AD0
		public void StopAllChargeSlashScanEffect()
		{
			foreach (SpecificScanEffectData specificScanEffectData in this.ChargeSlashScanEffectMap.Values)
			{
				ActorSystem instance = ActorSystem.Instance;
				string reason = "StopAllChargeSlashScanEffect";
				SpecificScanEffectData specificScanEffectData2 = specificScanEffectData;
				instance.Put(reason, (specificScanEffectData2.EffectActor != null) ? specificScanEffectData2.EffectActor.GetValueOrDefault().AsT1 : null, null);
			}
			this.ChargeSlashScanEffectMap.Clear();
		}

		// Token: 0x17009E3F RID: 40511
		// (get) Token: 0x06047A90 RID: 293520 RVA: 0x0125695C File Offset: 0x01254B5C
		public static ChargeSlashGameplayController Instance
		{
			get
			{
				return ChargeSlashGameplayController._Instance;
			}
		}

		// Token: 0x06047A91 RID: 293521 RVA: 0x01256963 File Offset: 0x01254B63
		public static ChargeSlashGameplayController GetOrCreateInstance()
		{
			if (ChargeSlashGameplayController._Instance == null)
			{
				ChargeSlashGameplayController.CreateInstance();
			}
			return ChargeSlashGameplayController._Instance;
		}

		// Token: 0x06047A92 RID: 293522 RVA: 0x01256977 File Offset: 0x01254B77
		public static bool CreateInstance()
		{
			if (ChargeSlashGameplayController._Instance != null)
			{
				return true;
			}
			ChargeSlashGameplayController._Instance = new ChargeSlashGameplayController();
			return true;
		}

		// Token: 0x06047A93 RID: 293523 RVA: 0x0125698D File Offset: 0x01254B8D
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06047A94 RID: 293524 RVA: 0x0125698F File Offset: 0x01254B8F
		public static void ResetStaticDefaultValue()
		{
			ChargeSlashGameplayController._Instance = null;
		}

		// Token: 0x06047A95 RID: 293525 RVA: 0x01256997 File Offset: 0x01254B97
		static ChargeSlashGameplayController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ChargeSlashGameplayController.CreateStaticDefaultValue), new Action(ChargeSlashGameplayController.ResetStaticDefaultValue));
		}

		// Token: 0x04025B4A RID: 154442
		private const float SMALLEST_RANDOM_TIME = 0.02f;

		// Token: 0x04025B4B RID: 154443
		private const string SCAN_EFFECT_CLASS_PATH = "/Game/Aki/Effect/BluePrint/BP_FX_Common/BP_DistortionWave.BP_DistortionWave_C";

		// Token: 0x04025B4C RID: 154444
		private readonly Dictionary<int, TimerHandle> TimerHandlesMap = new Dictionary<int, TimerHandle>();

		// Token: 0x04025B4D RID: 154445
		private int Uid = -1;

		// Token: 0x04025B4E RID: 154446
		private readonly Dictionary<int, SpecificScanEffectData> ChargeSlashScanEffectMap = new Dictionary<int, SpecificScanEffectData>();

		// Token: 0x04025B4F RID: 154447
		[Nullable(2)]
		private static ChargeSlashGameplayController _Instance;
	}
}
