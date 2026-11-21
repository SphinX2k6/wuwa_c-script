using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.Common.InputView.Model
{
	// Token: 0x02004B5F RID: 19295
	[NullableContext(1)]
	public interface ICommonInputViewData
	{
		// Token: 0x1700608F RID: 24719
		// (get) Token: 0x0603038A RID: 197514
		// (set) Token: 0x0603038B RID: 197515
		TableTextArgNew TitleTextArgs { get; set; }

		// Token: 0x17006090 RID: 24720
		// (get) Token: 0x0603038C RID: 197516
		// (set) Token: 0x0603038D RID: 197517
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

		// Token: 0x17006091 RID: 24721
		// (get) Token: 0x0603038E RID: 197518
		// (set) Token: 0x0603038F RID: 197519
		string InputText { get; set; }

		// Token: 0x17006092 RID: 24722
		// (get) Token: 0x06030390 RID: 197520
		// (set) Token: 0x06030391 RID: 197521
		string DefaultText { get; set; }

		// Token: 0x17006093 RID: 24723
		// (get) Token: 0x06030392 RID: 197522
		// (set) Token: 0x06030393 RID: 197523
		bool IsCheckNone { get; set; }

		// Token: 0x17006094 RID: 24724
		// (get) Token: 0x06030394 RID: 197524
		// (set) Token: 0x06030395 RID: 197525
		bool NeedFunctionButton { get; set; }

		// Token: 0x17006095 RID: 24725
		// (get) Token: 0x06030396 RID: 197526
		// (set) Token: 0x06030397 RID: 197527
		string BottomTipsText { get; set; }

		// Token: 0x17006096 RID: 24726
		// (get) Token: 0x06030398 RID: 197528
		// (set) Token: 0x06030399 RID: 197529
		[Nullable(2)]
		string BottomTipsColor { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x17006097 RID: 24727
		// (get) Token: 0x0603039A RID: 197530
		// (set) Token: 0x0603039B RID: 197531
		bool? NeedCheckBlank { get; set; }
	}
}
