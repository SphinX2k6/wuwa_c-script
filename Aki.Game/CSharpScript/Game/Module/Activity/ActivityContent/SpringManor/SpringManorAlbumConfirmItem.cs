using System;
using System.Collections.Generic;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.SpringManor
{
	// Token: 0x02006058 RID: 24664
	public class SpringManorAlbumConfirmItem : UiPanelBase
	{
		// Token: 0x0603E685 RID: 255621 RVA: 0x00F13120 File Offset: 0x00F11320
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUISprite)),
				new ValueTuple<int, Type>(4, typeof(UUISprite)),
				new ValueTuple<int, Type>(5, typeof(UUIText))
			};
		}

		// Token: 0x0603E686 RID: 255622 RVA: 0x00F131BC File Offset: 0x00F113BC
		public void SetState(EBrochureState state, int conditionGroupId)
		{
			UUIItem item = base.GetItem(2);
			if (item != null)
			{
				item.SetUIActive(state == EBrochureState.Unlock);
			}
			bool flag = SpringManorModel.Instance.IsQuestTracking(conditionGroupId);
			if (state == EBrochureState.Lock)
			{
				if (flag)
				{
					UUIText text = base.GetText(5);
					if (text != null)
					{
						text.ShowTextNew("PictureAlbum_BtnName_UnTrack");
					}
				}
				else
				{
					UUIText text2 = base.GetText(5);
					if (text2 != null)
					{
						text2.ShowTextNew("PictureAlbum_BtnName_Track");
					}
				}
			}
			else if (state == EBrochureState.Unlock)
			{
				UUIText text3 = base.GetText(1);
				if (text3 != null)
				{
					text3.ShowTextNew("PictureAlbum_BtnName_Receive");
				}
			}
			this.SetBtnBg(state == EBrochureState.Lock);
		}

		// Token: 0x0603E687 RID: 255623 RVA: 0x00F13248 File Offset: 0x00F11448
		public void SetBtnBg(bool isTrackBtn)
		{
			UUISprite sprite = base.GetSprite(3);
			if (sprite != null)
			{
				sprite.SetUIActive(!isTrackBtn);
			}
			UUISprite sprite2 = base.GetSprite(4);
			if (sprite2 != null)
			{
				sprite2.SetUIActive(isTrackBtn);
			}
			UUIText text = base.GetText(1);
			if (text != null)
			{
				text.SetUIActive(!isTrackBtn);
			}
			UUIText text2 = base.GetText(5);
			if (text2 == null)
			{
				return;
			}
			text2.SetUIActive(isTrackBtn);
		}
	}
}
