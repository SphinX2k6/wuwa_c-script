using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005E36 RID: 24118
	[NullableContext(1)]
	[Nullable(0)]
	public class StateExtraItemBase : UiPanelBase
	{
		// Token: 0x0603D537 RID: 251191 RVA: 0x00EC8B6D File Offset: 0x00EC6D6D
		public EExtraItemType GetExtraItemType()
		{
			return this.Type;
		}

		// Token: 0x0603D538 RID: 251192 RVA: 0x00EC8B75 File Offset: 0x00EC6D75
		public void InitExtraItemType(EExtraItemType type)
		{
			this.Type = type;
		}

		// Token: 0x0603D539 RID: 251193 RVA: 0x00EC8B7E File Offset: 0x00EC6D7E
		public void InitExtraParams(ExtraItemParams paramsObj)
		{
			this.OnInitExtraParams(paramsObj);
		}

		// Token: 0x0603D53A RID: 251194 RVA: 0x00EC8B87 File Offset: 0x00EC6D87
		protected virtual void OnInitExtraParams(ExtraItemParams paramsObj)
		{
		}

		// Token: 0x0401FFD0 RID: 131024
		private EExtraItemType Type;
	}
}
