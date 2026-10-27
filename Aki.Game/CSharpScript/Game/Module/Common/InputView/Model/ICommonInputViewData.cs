using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.Common.InputView.Model
{
	// Token: 0x02005B7F RID: 23423
	[NullableContext(1)]
	public interface ICommonInputViewData
	{
		// Token: 0x17008CBD RID: 36029
		// (get) Token: 0x0603B43D RID: 242749
		// (set) Token: 0x0603B43E RID: 242750
		TableTextArgNew TitleTextArgs { get; set; }

		// Token: 0x17008CBE RID: 36030
		// (get) Token: 0x0603B43F RID: 242751
		// (set) Token: 0x0603B440 RID: 242752
		[Nullable(new byte[]
		{
			1,
			1,
			0
		})]
		Func<string, UniTask<ErrorCode>> ConfirmFunc { [return: Nullable(new byte[]
		{
			1,
			1,
			0
		})] get; [param: Nullable(new byte[]
		{
			1,
			1,
			0
		})] set; }

		// Token: 0x17008CBF RID: 36031
		// (get) Token: 0x0603B441 RID: 242753
		// (set) Token: 0x0603B442 RID: 242754
		string InputText { get; set; }

		// Token: 0x17008CC0 RID: 36032
		// (get) Token: 0x0603B443 RID: 242755
		// (set) Token: 0x0603B444 RID: 242756
		string DefaultText { get; set; }

		// Token: 0x17008CC1 RID: 36033
		// (get) Token: 0x0603B445 RID: 242757
		// (set) Token: 0x0603B446 RID: 242758
		bool IsCheckNone { get; set; }

		// Token: 0x17008CC2 RID: 36034
		// (get) Token: 0x0603B447 RID: 242759
		// (set) Token: 0x0603B448 RID: 242760
		bool NeedFunctionButton { get; set; }

		// Token: 0x17008CC3 RID: 36035
		// (get) Token: 0x0603B449 RID: 242761
		// (set) Token: 0x0603B44A RID: 242762
		string BottomTipsText { get; set; }

		// Token: 0x17008CC4 RID: 36036
		// (get) Token: 0x0603B44B RID: 242763
		// (set) Token: 0x0603B44C RID: 242764
		[Nullable(2)]
		string BottomTipsColor { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x17008CC5 RID: 36037
		// (get) Token: 0x0603B44D RID: 242765
		// (set) Token: 0x0603B44E RID: 242766
		bool? NeedCheckBlank { get; set; }
	}
}
