using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Menu.SubViews.EyeProtect
{
	// Token: 0x0200544A RID: 21578
	[NullableContext(1)]
	[Nullable(0)]
	public class EyeProtectItemData
	{
		// Token: 0x0603717A RID: 225658 RVA: 0x00D0EDDE File Offset: 0x00D0CFDE
		public EyeProtectItemData(int modeValue, string modeName, EyeProtectViewModel viewModel)
		{
			this.ModeValue = modeValue;
			this.ModeName = modeName;
			this.ViewModel = viewModel;
		}

		// Token: 0x0603717B RID: 225659 RVA: 0x00D0EE06 File Offset: 0x00D0D006
		public int GetModeValue()
		{
			return this.ModeValue;
		}

		// Token: 0x0603717C RID: 225660 RVA: 0x00D0EE0E File Offset: 0x00D0D00E
		public string GetModeName()
		{
			return this.ModeName;
		}

		// Token: 0x0603717D RID: 225661 RVA: 0x00D0EE16 File Offset: 0x00D0D016
		public bool IsCustom()
		{
			return this.ModeValue == 2;
		}

		// Token: 0x0603717E RID: 225662 RVA: 0x00D0EE21 File Offset: 0x00D0D021
		[NullableContext(2)]
		public EyeProtectViewModel GetViewModel()
		{
			return this.ViewModel;
		}

		// Token: 0x0401D109 RID: 119049
		protected bool IsActiveInternal;

		// Token: 0x0401D10A RID: 119050
		protected int ModeValue;

		// Token: 0x0401D10B RID: 119051
		protected string ModeName = "";

		// Token: 0x0401D10C RID: 119052
		[Nullable(2)]
		protected EyeProtectViewModel ViewModel;
	}
}
