using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Common.InputView.View
{
	// Token: 0x02005B7B RID: 23419
	[NullableContext(1)]
	public interface ITextInputData
	{
		// Token: 0x17008CB3 RID: 36019
		// (get) Token: 0x0603B40C RID: 242700
		// (set) Token: 0x0603B40D RID: 242701
		TConfirm ConfirmFunc { get; set; }

		// Token: 0x17008CB4 RID: 36020
		// (get) Token: 0x0603B40E RID: 242702
		// (set) Token: 0x0603B40F RID: 242703
		TResult ResultFunc { get; set; }

		// Token: 0x17008CB5 RID: 36021
		// (get) Token: 0x0603B410 RID: 242704
		// (set) Token: 0x0603B411 RID: 242705
		string InputText { get; set; }

		// Token: 0x17008CB6 RID: 36022
		// (get) Token: 0x0603B412 RID: 242706
		// (set) Token: 0x0603B413 RID: 242707
		[Nullable(2)]
		string DefaultText { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x17008CB7 RID: 36023
		// (get) Token: 0x0603B414 RID: 242708
		// (set) Token: 0x0603B415 RID: 242709
		bool IsCheckNone { get; set; }
	}
}
