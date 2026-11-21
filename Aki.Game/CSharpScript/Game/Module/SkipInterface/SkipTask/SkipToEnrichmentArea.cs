using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Map.Controller;

namespace CSharpScript.Game.Module.SkipInterface.SkipTask
{
	// Token: 0x02003B72 RID: 15218
	public class SkipToEnrichmentArea : SkipTask
	{
		// Token: 0x060270B0 RID: 159920 RVA: 0x00AEE530 File Offset: 0x00AEC730
		protected override void OnRun([Nullable(new byte[]
		{
			1,
			2
		})] params object[] data)
		{
			int num = (data.Length > 3 && data[3] != null) ? ((int)data[3]) : 0;
			if (num == 0)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SkipInterface;
				ELogAuthor author = ELogAuthor.LRX;
				string message = "跳转富集区失败,道具Id为空->";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("itemId:", num);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			MapController.Instance.RequestTrackEnrichmentArea(new int?(num));
		}
	}
}
