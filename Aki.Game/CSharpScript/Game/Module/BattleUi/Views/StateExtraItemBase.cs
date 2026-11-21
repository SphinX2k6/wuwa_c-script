using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004E1B RID: 19995
	[NullableContext(1)]
	[Nullable(0)]
	public class StateExtraItemBase : UiPanelBase
	{
		// Token: 0x060324C7 RID: 206023 RVA: 0x00E1A0D9 File Offset: 0x00E182D9
		public EExtraItemType GetExtraItemType()
		{
			return this.Type;
		}

		// Token: 0x060324C8 RID: 206024 RVA: 0x00E1A0E1 File Offset: 0x00E182E1
		public void InitExtraItemType(EExtraItemType type)
		{
			this.Type = type;
		}

		// Token: 0x060324C9 RID: 206025 RVA: 0x00E1A0EA File Offset: 0x00E182EA
		public void InitExtraParams(ExtraItemParams paramsObj)
		{
			this.OnInitExtraParams(paramsObj);
		}

		// Token: 0x060324CA RID: 206026 RVA: 0x00E1A0F3 File Offset: 0x00E182F3
		protected virtual void OnInitExtraParams(ExtraItemParams paramsObj)
		{
		}

		// Token: 0x0401AA97 RID: 109207
		private EExtraItemType Type;
	}
}
