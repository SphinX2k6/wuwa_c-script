using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using UnrealEngine;

namespace CSharpScript.Game.Module.Menu.SubViews
{
	// Token: 0x0200440C RID: 17420
	[NullableContext(1)]
	[Nullable(0)]
	public class MenuDetailPopViewItemPanel : UiPanelBase
	{
		// Token: 0x0602BFEE RID: 180206 RVA: 0x00C5A633 File Offset: 0x00C58833
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUITexture)),
				new ValueTuple<int, Type>(1, typeof(UUIText))
			};
		}

		// Token: 0x0602BFEF RID: 180207 RVA: 0x00C5A66C File Offset: 0x00C5886C
		protected override UniTask OnBeforeStartAsync()
		{
			this.View = new MenuDetailPopViewItemView(base.GetText(1), base.GetTexture(0), delegate(string path, UUITexture texture)
			{
				base.SetTextureByPath(path, texture, null, null);
			});
			return UniTask.CompletedTask;
		}

		// Token: 0x0602BFF0 RID: 180208 RVA: 0x00C5A698 File Offset: 0x00C58898
		public void RefreshByData(MenuDetailPopItemData data)
		{
			MenuDetailPopViewItemView view = this.View;
			if (view == null)
			{
				return;
			}
			view.RefreshByData(data);
		}

		// Token: 0x0602BFF1 RID: 180209 RVA: 0x00C5A6AB File Offset: 0x00C588AB
		protected override void OnBeforeDestroy()
		{
			MenuDetailPopViewItemView view = this.View;
			if (view != null)
			{
				view.Clear();
			}
			this.View = null;
		}

		// Token: 0x04017B4F RID: 97103
		private const string VIDEO_NAME = "MenuDetailPopViewItemPanel";

		// Token: 0x04017B50 RID: 97104
		[Nullable(2)]
		private MenuDetailPopViewItemView View;
	}
}
