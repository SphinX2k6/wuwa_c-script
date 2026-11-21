using System;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020058C1 RID: 22721
	public class SolarSchoolShopAction : SolarSchoolActionBase
	{
		// Token: 0x06037F43 RID: 229187 RVA: 0x00FA4400 File Offset: 0x00FA2600
		protected override void OnStart()
		{
			if (!SolarSchoolGamePlayModel.Instance.TryOpenAvailableShop())
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.SWC;
				string message = "[SolarSchool] 当前没有可用商店";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("actionId", base.ActionId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				base.MarkFailed();
				return;
			}
			base.MarkDone();
		}
	}
}
