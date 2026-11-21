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
	// Token: 0x020062EE RID: 25326
	[NullableContext(1)]
	[Nullable(0)]
	[TickController(0)]
	public class FlyingFeatherController : ControllerBase
	{
		// Token: 0x0603D3F9 RID: 250873 RVA: 0x011AF67C File Offset: 0x011AD87C
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

		// Token: 0x0603D3FA RID: 250874 RVA: 0x011AF73C File Offset: 0x011AD93C
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

		// Token: 0x0603D3FB RID: 250875 RVA: 0x011AF7B0 File Offset: 0x011AD9B0
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

		// Token: 0x0603D3FC RID: 250876 RVA: 0x011AF838 File Offset: 0x011ADA38
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

		// Token: 0x170073F7 RID: 29687
		// (get) Token: 0x0603D3FD RID: 250877 RVA: 0x011AF8D0 File Offset: 0x011ADAD0
		public static FlyingFeatherController Instance
		{
			get
			{
				return FlyingFeatherController._Instance;
			}
		}

		// Token: 0x0603D3FE RID: 250878 RVA: 0x011AF8D7 File Offset: 0x011ADAD7
		public static FlyingFeatherController GetOrCreateInstance()
		{
			if (FlyingFeatherController._Instance == null)
			{
				FlyingFeatherController.CreateInstance();
			}
			return FlyingFeatherController._Instance;
		}

		// Token: 0x0603D3FF RID: 250879 RVA: 0x011AF8EB File Offset: 0x011ADAEB
		public static bool CreateInstance()
		{
			if (FlyingFeatherController._Instance != null)
			{
				return true;
			}
			FlyingFeatherController._Instance = new FlyingFeatherController();
			return true;
		}

		// Token: 0x0603D400 RID: 250880 RVA: 0x011AF901 File Offset: 0x011ADB01
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603D401 RID: 250881 RVA: 0x011AF903 File Offset: 0x011ADB03
		public static void ResetStaticDefaultValue()
		{
			FlyingFeatherController._Instance = null;
		}

		// Token: 0x0603D402 RID: 250882 RVA: 0x011AF90B File Offset: 0x011ADB0B
		static FlyingFeatherController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(FlyingFeatherController.CreateStaticDefaultValue), new Action(FlyingFeatherController.ResetStaticDefaultValue));
		}

		// Token: 0x040207BF RID: 133055
		private const string SCAN_EFFECT_CLASS_PATH = "/Game/Aki/Effect/BluePrint/BP_FX_Common/BP_Fx_Scanning_2_7.BP_Fx_Scanning_2_7_C";

		// Token: 0x040207C0 RID: 133056
		private int Uid = -1;

		// Token: 0x040207C1 RID: 133057
		private readonly Dictionary<int, SpecificScanEffectData> FlyingFeatherScanEffectMap = new Dictionary<int, SpecificScanEffectData>();

		// Token: 0x040207C2 RID: 133058
		[Nullable(2)]
		private static FlyingFeatherController _Instance;
	}
}
