using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Menu.SubViews.EyeProtect
{
	// Token: 0x0200442D RID: 17453
	[NullableContext(1)]
	[Nullable(0)]
	public class EyeProtectItemData
	{
		// Token: 0x0602C0C3 RID: 180419 RVA: 0x00C5E1F6 File Offset: 0x00C5C3F6
		public EyeProtectItemData(int modeValue, string modeName, EyeProtectViewModel viewModel)
		{
			this.ModeValue = modeValue;
			this.ModeName = modeName;
			this.ViewModel = viewModel;
		}

		// Token: 0x0602C0C4 RID: 180420 RVA: 0x00C5E21E File Offset: 0x00C5C41E
		public int GetModeValue()
		{
			return this.ModeValue;
		}

		// Token: 0x0602C0C5 RID: 180421 RVA: 0x00C5E226 File Offset: 0x00C5C426
		public string GetModeName()
		{
			return this.ModeName;
		}

		// Token: 0x0602C0C6 RID: 180422 RVA: 0x00C5E22E File Offset: 0x00C5C42E
		public bool IsCustom()
		{
			return this.ModeValue == 2;
		}

		// Token: 0x0602C0C7 RID: 180423 RVA: 0x00C5E239 File Offset: 0x00C5C439
		[NullableContext(2)]
		public EyeProtectViewModel GetViewModel()
		{
			return this.ViewModel;
		}

		// Token: 0x04017BA2 RID: 97186
		protected bool IsActiveInternal;

		// Token: 0x04017BA3 RID: 97187
		protected int ModeValue;

		// Token: 0x04017BA4 RID: 97188
		protected string ModeName = "";

		// Token: 0x04017BA5 RID: 97189
		[Nullable(2)]
		protected EyeProtectViewModel ViewModel;
	}
}
