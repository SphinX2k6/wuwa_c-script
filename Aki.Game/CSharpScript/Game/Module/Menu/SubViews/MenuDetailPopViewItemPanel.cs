using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using UnrealEngine;

namespace CSharpScript.Game.Module.Menu.SubViews
{
	// Token: 0x02005429 RID: 21545
	[NullableContext(1)]
	[Nullable(0)]
	public class MenuDetailPopViewItemPanel : UiPanelBase
	{
		// Token: 0x060370A5 RID: 225445 RVA: 0x00D0B213 File Offset: 0x00D09413
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUITexture)),
				new ValueTuple<int, Type>(1, typeof(UUIText))
			};
		}

		// Token: 0x060370A6 RID: 225446 RVA: 0x00D0B24C File Offset: 0x00D0944C
		protected override UniTask OnBeforeStartAsync()
		{
			this.View = new MenuDetailPopViewItemView(base.GetText(1), base.GetTexture(0), delegate(string path, UUITexture texture)
			{
				base.SetTextureByPath(path, texture, null, null);
			});
			return UniTask.CompletedTask;
		}

		// Token: 0x060370A7 RID: 225447 RVA: 0x00D0B278 File Offset: 0x00D09478
		public void RefreshByData(MenuDetailPopItemData data)
		{
			MenuDetailPopViewItemView view = this.View;
			if (view == null)
			{
				return;
			}
			view.RefreshByData(data);
		}

		// Token: 0x060370A8 RID: 225448 RVA: 0x00D0B28B File Offset: 0x00D0948B
		protected override void OnBeforeDestroy()
		{
			MenuDetailPopViewItemView view = this.View;
			if (view != null)
			{
				view.Clear();
			}
			this.View = null;
		}

		// Token: 0x0401D0B6 RID: 118966
		private const string VIDEO_NAME = "MenuDetailPopViewItemPanel";

		// Token: 0x0401D0B7 RID: 118967
		[Nullable(2)]
		private MenuDetailPopViewItemView View;
	}
}
