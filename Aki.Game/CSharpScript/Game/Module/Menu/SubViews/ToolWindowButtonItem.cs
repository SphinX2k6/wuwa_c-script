using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Menu.SubViews
{
	// Token: 0x02005432 RID: 21554
	[NullableContext(1)]
	[Nullable(0)]
	public class ToolWindowButtonItem : ButtonAndTextItem
	{
		// Token: 0x060370C8 RID: 225480 RVA: 0x00D0B813 File Offset: 0x00D09A13
		public ToolWindowButtonItem(UUIItem uiItem) : base(uiItem)
		{
		}

		// Token: 0x060370C9 RID: 225481 RVA: 0x00D0B81C File Offset: 0x00D09A1C
		protected override void OnRegisterComponent()
		{
			base.OnRegisterComponent();
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(2, typeof(UUISprite)));
		}

		// Token: 0x060370CA RID: 225482 RVA: 0x00D0B83F File Offset: 0x00D09A3F
		protected override void OnStart()
		{
			this.SetIconVisible(false);
		}

		// Token: 0x060370CB RID: 225483 RVA: 0x00D0B848 File Offset: 0x00D09A48
		public void RefreshIcon(string iconPath, [Nullable(2)] Action<bool> callback = null)
		{
			this.SetSpriteByPath(iconPath, base.GetSprite(2), false, null, callback);
		}

		// Token: 0x060370CC RID: 225484 RVA: 0x00D0B86E File Offset: 0x00D09A6E
		public void SetIconVisible(bool bVisible)
		{
			base.GetSprite(2).SetUIActive(bVisible);
		}
	}
}
