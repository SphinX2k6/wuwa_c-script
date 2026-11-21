using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004D07 RID: 19719
	public class FormationConcertoItem : UiPanelBase
	{
		// Token: 0x06031683 RID: 202371 RVA: 0x00DCF498 File Offset: 0x00DCD698
		[NullableContext(1)]
		public FormationConcertoItem(AActor rootActor)
		{
			base.CreateThenShowByActor(rootActor, null);
		}

		// Token: 0x06031684 RID: 202372 RVA: 0x00DCF4B4 File Offset: 0x00DCD6B4
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

		// Token: 0x06031685 RID: 202373 RVA: 0x00DCF520 File Offset: 0x00DCD720
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

		// Token: 0x06031686 RID: 202374 RVA: 0x00DCF5A0 File Offset: 0x00DCD7A0
		public void RefreshConcertoProgress(float progress)
		{
			UUISprite sprite = base.GetSprite(0);
			if (sprite == null)
			{
				return;
			}
			sprite.SetFillAmount(progress);
		}

		// Token: 0x0401A2B4 RID: 107188
		[Nullable(1)]
		private string LastSetIconPath = string.Empty;

		// Token: 0x0200A9B1 RID: 43441
		private enum EChildType
		{
			// Token: 0x040346EE RID: 214766
			ProgressSprite,
			// Token: 0x040346EF RID: 214767
			ContentTexture
		}
	}
}
