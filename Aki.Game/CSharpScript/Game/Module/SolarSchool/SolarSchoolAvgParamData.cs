using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020058C8 RID: 22728
	[NullableContext(1)]
	[Nullable(0)]
	public sealed class SolarSchoolAvgParamData : SolarSchoolRecordBase
	{
		// Token: 0x06037F8E RID: 229262 RVA: 0x00FA5849 File Offset: 0x00FA3A49
		public bool GetParam(string key)
		{
			return this.TrueKeys.Contains(key);
		}

		// Token: 0x06037F8F RID: 229263 RVA: 0x00FA5858 File Offset: 0x00FA3A58
		public unsafe void SetParam(string key, bool value)
		{
			int activityId = SolarSchoolGamePlayModel.Instance.ActivityId;
			if (!SolarSchoolConfig.Instance.HasAvgParam(activityId, key))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.LRC;
				string message = "[SolarSchool] AVG 变量未在 SolarSchoolAvgParam 表中配置";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("activityId", activityId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("key", key);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return;
			}
			if (!(value ? this.TrueKeys.Add(key) : this.TrueKeys.Remove(key)))
			{
				return;
			}
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.SolarSchool;
			ELogAuthor author2 = ELogAuthor.LRC;
			string message2 = "[SolarSchool] AVG 变量变更";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("key", key);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("value", value);
			instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
			EventSystem.Instance.Emit(EEventName.SolarSchoolAvgParamChanged);
		}

		// Token: 0x06037F90 RID: 229264 RVA: 0x00FA5965 File Offset: 0x00FA3B65
		public void Reset()
		{
			this.TrueKeys.Clear();
		}

		// Token: 0x06037F91 RID: 229265 RVA: 0x00FA5974 File Offset: 0x00FA3B74
		public override void Serialize(SolarSchoolSaveGamePb gameData)
		{
			SolarSchoolAvgDataPb solarSchoolAvgDataPb = SolarSchoolAvgDataPb.Create();
			int activityId = SolarSchoolGamePlayModel.Instance.ActivityId;
			foreach (SolarSchoolAvgParam solarSchoolAvgParam in SolarSchoolConfig.Instance.GetAvgParamListByActivityId(activityId))
			{
				if (solarSchoolAvgParam.Key != null && this.TrueKeys.Contains(solarSchoolAvgParam.Key))
				{
					SolarSchoolUtils.SetSaveBit(solarSchoolAvgDataPb.AvgParamBit, solarSchoolAvgParam.BitFlag);
				}
			}
			gameData.Avg = solarSchoolAvgDataPb;
		}

		// Token: 0x06037F92 RID: 229266 RVA: 0x00FA5A08 File Offset: 0x00FA3C08
		public override void Deserialize(SolarSchoolSaveGamePb gameData)
		{
			this.TrueKeys.Clear();
			if (gameData.Avg == null)
			{
				return;
			}
			int activityId = SolarSchoolGamePlayModel.Instance.ActivityId;
			foreach (SolarSchoolAvgParam solarSchoolAvgParam in SolarSchoolConfig.Instance.GetAvgParamListByActivityId(activityId))
			{
				if (solarSchoolAvgParam.Key != null && SolarSchoolUtils.GetSaveBit(gameData.Avg.AvgParamBit, solarSchoolAvgParam.BitFlag))
				{
					this.TrueKeys.Add(solarSchoolAvgParam.Key);
				}
			}
		}

		// Token: 0x0401D859 RID: 120921
		private readonly HashSet<string> TrueKeys = new HashSet<string>();
	}
}
