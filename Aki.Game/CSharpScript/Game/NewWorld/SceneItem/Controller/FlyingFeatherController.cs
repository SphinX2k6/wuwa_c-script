using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using AkiClient.Game.Aki.Effect.BluePrint.BP_FX_Common;
using CSharpScript.Core.Framework;
using CSharpScript.Game.NewWorld.SceneItem.SpecificScanEffect;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.SceneItem.Controller
{
	// Token: 0x02007239 RID: 29241
	[NullableContext(1)]
	[Nullable(0)]
	[TickController(0)]
	public class FlyingFeatherController : ControllerBase
	{
		// Token: 0x06047A97 RID: 293527 RVA: 0x012569DC File Offset: 0x01254BDC
		protected override void OnTick(float delta)
		{
			if (this.FlyingFeatherScanEffectMap.Count == 0)
			{
				return;
			}
			List<int> list = new List<int>();
			foreach (KeyValuePair<int, SpecificScanEffectData> keyValuePair in this.FlyingFeatherScanEffectMap)
			{
				int num;
				SpecificScanEffectData specificScanEffectData;
				keyValuePair.Deconstruct(out num, out specificScanEffectData);
				int item = num;
				if (!specificScanEffectData.Update(delta))
				{
					list.Add(item);
				}
			}
			foreach (int id in list)
			{
				this.StopFlyingFeatherScanEffect(id);
			}
		}

		// Token: 0x06047A98 RID: 293528 RVA: 0x01256A9C File Offset: 0x01254C9C
		public int StartFlyingFeatherScanEffect(FTransformDouble transform)
		{
			global::Log.Instance.Info(ELogModule.LevelEvent, ELogAuthor.CH, "[FlyingFeatherController] StartChargeSlashScanEffect", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.Uid++;
			ResourceSystem.Instance.LoadAsync<UClass>("/Game/Aki/Effect/BluePrint/BP_FX_Common/BP_Fx_Scanning_2_7.BP_Fx_Scanning_2_7_C", delegate([Nullable(2)] UClass result, string _)
			{
				if (result == null)
				{
					global::Log instance = global::Log.Instance;
					ELogModule module = ELogModule.LevelEvent;
					ELogAuthor author = ELogAuthor.CH;
					string message = "加载飞雷神扫描特效失败";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("path", "/Game/Aki/Effect/BluePrint/BP_FX_Common/BP_Fx_Scanning_2_7.BP_Fx_Scanning_2_7_C");
					instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
					return;
				}
				BP_Fx_Scanning_2_7_C bp_Fx_Scanning_2_7_C = ActorSystem.Instance.Spawn<BP_Fx_Scanning_2_7_C>(result.ClassStackOnlyPtr, transform, null);
				if (bp_Fx_Scanning_2_7_C == null)
				{
					return;
				}
				bp_Fx_Scanning_2_7_C.StartScanEffect();
				this.FlyingFeatherScanEffectMap.Add(this.Uid, new SpecificScanEffectData(this.Uid, bp_Fx_Scanning_2_7_C, transform.GetLocation(), new ESpecificScanType?(ESpecificScanType.FlyingFeather)));
			}, 100, "js_undefined");
			return this.Uid;
		}

		// Token: 0x06047A99 RID: 293529 RVA: 0x01256B10 File Offset: 0x01254D10
		public void StopFlyingFeatherScanEffect(int id)
		{
			SpecificScanEffectData valueOrDefault = this.FlyingFeatherScanEffectMap.GetValueOrDefault(id);
			if (valueOrDefault == null)
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.LevelEvent;
				ELogAuthor author = ELogAuthor.CH;
				string message = "[StopFlyingFeatherScanEffect] data is null";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", id);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			ActorSystem instance2 = ActorSystem.Instance;
			string reason = "StopChargeSlashScanEffect";
			SpecificScanEffectData specificScanEffectData = valueOrDefault;
			instance2.Put(reason, (specificScanEffectData.EffectActor != null) ? specificScanEffectData.EffectActor.GetValueOrDefault().AsT2 : null, null);
			this.FlyingFeatherScanEffectMap.Remove(id);
		}

		// Token: 0x06047A9A RID: 293530 RVA: 0x01256B98 File Offset: 0x01254D98
		public void StopAllFlyingFeatherScanEffect()
		{
			foreach (KeyValuePair<int, SpecificScanEffectData> keyValuePair in this.FlyingFeatherScanEffectMap)
			{
				int num;
				SpecificScanEffectData specificScanEffectData;
				keyValuePair.Deconstruct(out num, out specificScanEffectData);
				SpecificScanEffectData specificScanEffectData2 = specificScanEffectData;
				ActorSystem instance = ActorSystem.Instance;
				string reason = "StopAllFlyingFeatherScanEffect";
				SpecificScanEffectData specificScanEffectData3 = specificScanEffectData2;
				instance.Put(reason, (specificScanEffectData3.EffectActor != null) ? specificScanEffectData3.EffectActor.GetValueOrDefault().AsT2 : null, null);
			}
			this.FlyingFeatherScanEffectMap.Clear();
		}

		// Token: 0x17009E40 RID: 40512
		// (get) Token: 0x06047A9B RID: 293531 RVA: 0x01256C30 File Offset: 0x01254E30
		public static FlyingFeatherController Instance
		{
			get
			{
				return FlyingFeatherController._Instance;
			}
		}

		// Token: 0x06047A9C RID: 293532 RVA: 0x01256C37 File Offset: 0x01254E37
		public static FlyingFeatherController GetOrCreateInstance()
		{
			if (FlyingFeatherController._Instance == null)
			{
				FlyingFeatherController.CreateInstance();
			}
			return FlyingFeatherController._Instance;
		}

		// Token: 0x06047A9D RID: 293533 RVA: 0x01256C4B File Offset: 0x01254E4B
		public static bool CreateInstance()
		{
			if (FlyingFeatherController._Instance != null)
			{
				return true;
			}
			FlyingFeatherController._Instance = new FlyingFeatherController();
			return true;
		}

		// Token: 0x06047A9E RID: 293534 RVA: 0x01256C61 File Offset: 0x01254E61
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06047A9F RID: 293535 RVA: 0x01256C63 File Offset: 0x01254E63
		public static void ResetStaticDefaultValue()
		{
			FlyingFeatherController._Instance = null;
		}

		// Token: 0x06047AA0 RID: 293536 RVA: 0x01256C6B File Offset: 0x01254E6B
		static FlyingFeatherController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(FlyingFeatherController.CreateStaticDefaultValue), new Action(FlyingFeatherController.ResetStaticDefaultValue));
		}

		// Token: 0x04025B50 RID: 154448
		private const string SCAN_EFFECT_CLASS_PATH = "/Game/Aki/Effect/BluePrint/BP_FX_Common/BP_Fx_Scanning_2_7.BP_Fx_Scanning_2_7_C";

		// Token: 0x04025B51 RID: 154449
		private int Uid = -1;

		// Token: 0x04025B52 RID: 154450
		private readonly Dictionary<int, SpecificScanEffectData> FlyingFeatherScanEffectMap = new Dictionary<int, SpecificScanEffectData>();

		// Token: 0x04025B53 RID: 154451
		[Nullable(2)]
		private static FlyingFeatherController _Instance;
	}
}
