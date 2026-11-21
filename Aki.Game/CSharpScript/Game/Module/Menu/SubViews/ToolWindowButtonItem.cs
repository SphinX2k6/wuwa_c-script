using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Menu.SubViews
{
	// Token: 0x02004415 RID: 17429
	[NullableContext(1)]
	[Nullable(0)]
	public class ToolWindowButtonItem : ButtonAndTextItem
	{
		// Token: 0x0602C011 RID: 180241 RVA: 0x00C5AC33 File Offset: 0x00C58E33
		public ToolWindowButtonItem(UUIItem uiItem) : base(uiItem)
		{
		}

		// Token: 0x0602C012 RID: 180242 RVA: 0x00C5AC3C File Offset: 0x00C58E3C
		protected override void OnRegisterComponent()
		{
			base.OnRegisterComponent();
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(2, typeof(UUISprite)));
		}

		// Token: 0x0602C013 RID: 180243 RVA: 0x00C5AC5F File Offset: 0x00C58E5F
		protected override void OnStart()
		{
			this.SetIconVisible(false);
		}

		// Token: 0x0602C014 RID: 180244 RVA: 0x00C5AC68 File Offset: 0x00C58E68
		public void RefreshIcon(string iconPath, [Nullable(2)] Action<bool> callback = null)
		{
			this.SetSpriteByPath(iconPath, base.GetSprite(2), false, null, callback);
		}

		// Token: 0x0602C015 RID: 180245 RVA: 0x00C5AC8E File Offset: 0x00C58E8E
		public void SetIconVisible(bool bVisible)
		{
			base.GetSprite(2).SetUIActive(bVisible);
		}
	}
}
