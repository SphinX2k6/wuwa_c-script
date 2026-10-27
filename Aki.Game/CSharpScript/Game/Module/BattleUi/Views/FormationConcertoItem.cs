using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005D25 RID: 23845
	public class FormationConcertoItem : UiPanelBase
	{
		// Token: 0x0603C72A RID: 247594 RVA: 0x00E7ECF8 File Offset: 0x00E7CEF8
		[NullableContext(1)]
		public FormationConcertoItem(AActor rootActor)
		{
			base.CreateThenShowByActor(rootActor, null);
		}

		// Token: 0x0603C72B RID: 247595 RVA: 0x00E7ED14 File Offset: 0x00E7CF14
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603C72C RID: 247596 RVA: 0x00E7ED80 File Offset: 0x00E7CF80
		public void RefreshConcertoInfoView(in ElementInfo info, int elementId, FColor color)
		{
			UUITexture texture = base.GetTexture(1);
			if (texture != null)
			{
				texture.SetColor(color);
			}
			UUISprite sprite = base.GetSprite(0);
			if (sprite != null)
			{
				sprite.SetColor(color);
			}
			string lastSetIconPath = this.LastSetIconPath;
			ElementInfo elementInfo = info;
			if (lastSetIconPath != elementInfo.Icon3)
			{
				elementInfo = info;
				this.LastSetIconPath = elementInfo.Icon3;
				elementInfo = info;
				base.SetElementIcon(elementInfo.Icon3, texture, elementId, null);
			}
		}

		// Token: 0x0603C72D RID: 247597 RVA: 0x00E7EE00 File Offset: 0x00E7D000
		public void RefreshConcertoProgress(float progress)
		{
			UUISprite sprite = base.GetSprite(0);
			if (sprite == null)
			{
				return;
			}
			sprite.SetFillAmount(progress);
		}

		// Token: 0x0401F7FB RID: 129019
		[Nullable(1)]
		private string LastSetIconPath = string.Empty;

		// Token: 0x0200BFAB RID: 49067
		private enum EChildType
		{
			// Token: 0x04039D2C RID: 236844
			ProgressSprite,
			// Token: 0x04039D2D RID: 236845
			ContentTexture
		}
	}
}
