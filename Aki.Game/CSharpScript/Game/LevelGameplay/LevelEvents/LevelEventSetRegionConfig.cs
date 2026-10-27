using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.TDConfigMgr.Action;
using AkiClient.Game.Aki.Render.RuntimeBP.RenderData;
using CSharpScript.Game.Render;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02006B7A RID: 27514
	public class LevelEventSetRegionConfig : LevelEventBase
	{
		// Token: 0x06044256 RID: 279126 RVA: 0x010CA108 File Offset: 0x010C8308
		public LevelEventSetRegionConfig(int id) : base(id)
		{
		}

		// Token: 0x06044257 RID: 279127 RVA: 0x010CA114 File Offset: 0x010C8314
		[NullableContext(1)]
		public unsafe override void ExecuteNew(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			SetRegionConfig setRegionConfig = inParams as SetRegionConfig;
			if (setRegionConfig.Type != ERegionConfigType.Mpc)
			{
				base.FinishExecute(true, false, true);
				return;
			}
			AreaMpc? config = ConfigAreaMpcById.GetConfig((setRegionConfig as ISetRegionMpc).RegionMpcId, true);
			string mpcData = config.Value.MpcData;
			if (string.IsNullOrEmpty(mpcData) || mpcData == "None" || mpcData == "Empty")
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.LevelEvent;
				ELogAuthor author = ELogAuthor.YZH;
				string message = "[SetRegionConfig]未配置对应区域的MPCData";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("AreaId", config.Value.RegionId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("MpcData", mpcData);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				base.FinishExecute(true, false, true);
				return;
			}
			ResourceSystem.Instance.LoadAsync<ItemMaterialControllerMPCData_C>(mpcData, delegate([Nullable(2)] ItemMaterialControllerMPCData_C data, string _)
			{
				if (data == null || !data.IsValid())
				{
					global::Log.Instance.Error(ELogModule.LevelEvent, ELogAuthor.YZH, "[SetRegionConfig]: MPCData无效", default(ReadOnlySpan<ValueTuple<string, object>>));
					base.FinishExecute(true, false, true);
					return;
				}
				RenderModuleModel.Instance.UpdateItemMaterialParameterCollection(data);
				base.FinishExecute(true, false, true);
			}, 100, "js_undefined");
		}
	}
}
