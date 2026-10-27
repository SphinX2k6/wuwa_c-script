using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.SkipInterface.SkipTask
{
	// Token: 0x02004BB8 RID: 19384
	public class SkipTaskRouletteAssembly : SkipTask
	{
		// Token: 0x060322FE RID: 205566 RVA: 0x00BA9658 File Offset: 0x00BA7858
		protected override void OnRun([Nullable(new byte[]
		{
			1,
			2
		})] params object[] data)
		{
			string s = (string)data[0];
			string text = (string)data[1];
			string text2 = (string)data[2];
			int num = int.Parse(s);
			int? selectGridId = (text != null) ? new int?(int.Parse(text)) : null;
			if (RouletteConfig.Instance.GetExploreRouletteTypeById(num) == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SkipInterface;
				ELogAuthor author = ELogAuthor.YYZ;
				string message = "探索工具界面跳转失败,轮盘类型不存在";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Type", num);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				base.Finish();
				return;
			}
			RouletteController.Instance.OpenAssemblyView((ERouletteType)num, null, null, selectGridId, false);
			base.Finish();
		}
	}
}
