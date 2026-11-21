using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x0200573B RID: 22331
	public class DangoBrawlCombineItem : UiPanelBase
	{
		// Token: 0x06036FCD RID: 225229 RVA: 0x00F58098 File Offset: 0x00F56298
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUISprite));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickCombine));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06036FCE RID: 225230 RVA: 0x00F5815F File Offset: 0x00F5635F
		protected override void OnStart()
		{
			this.InitSequencePlayer();
		}

		// Token: 0x06036FCF RID: 225231 RVA: 0x00F58167 File Offset: 0x00F56367
		protected override void OnBeforeDestroy()
		{
			this.ClearSequencePlayer();
		}

		// Token: 0x06036FD0 RID: 225232 RVA: 0x00F58170 File Offset: 0x00F56370
		private void InitSequencePlayer()
		{
			this.ClearSequencePlayer();
			UUIItem rootItem = base.GetRootItem();
			if (rootItem == null)
			{
				return;
			}
			this.SequencePlayer = new UiSequencePlayer(rootItem);
		}

		// Token: 0x06036FD1 RID: 225233 RVA: 0x00F5819A File Offset: 0x00F5639A
		private void ClearSequencePlayer()
		{
			UiSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer != null)
			{
				sequencePlayer.Clear();
			}
			this.SequencePlayer = null;
		}

		// Token: 0x06036FD2 RID: 225234 RVA: 0x00F581B4 File Offset: 0x00F563B4
		public void Refresh(DangoBrawlCombineRowData data)
		{
			this.Data = new DangoBrawlCombineRowData?(data);
			DangoBrawlItem? itemConfigById = DangoBrawlConfig.Instance.GetItemConfigById(data.ResultItemId);
			if (itemConfigById == null)
			{
				return;
			}
			base.SetTextureByPath(itemConfigById.Value.IconHandBook, base.GetTexture(1), null, null);
			DangoBrawlItemQuality? itemQualityConfigById = DangoBrawlConfig.Instance.GetItemQualityConfigById(itemConfigById.Value.Quality);
			if (itemQualityConfigById != null)
			{
				this.SetSpriteByPath(itemQualityConfigById.Value.CombineBgIcon, base.GetSprite(2), false, null, null);
			}
			UiSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer == null)
			{
				return;
			}
			sequencePlayer.PlaySequencePurely("Start", false, false);
		}

		// Token: 0x06036FD3 RID: 225235 RVA: 0x00F58270 File Offset: 0x00F56470
		private void OnClickCombine()
		{
			if (this.Data == null || DangoBrawlViewManager.TryBlockIfThreeChoose(true) || DangoBrawlViewManager.TryBlockIfCombineUniqueWeapon(this.Data.Value, true))
			{
				return;
			}
			DangoBrawlCombineRowData value = this.Data.Value;
			UiManager.Instance.OpenView(EUiViewName.DangoBrawlCombineView, new DangoBrawlCombineViewOpenData
			{
				FocusConfigId = value.ResultItemId,
				AllowCombine = true,
				UseActData = true,
				ShowIntoSelf = true,
				ShowSelfIntoOther = true,
				UseIntoSelfTitleQuick = true
			}, null);
		}

		// Token: 0x0401D1A1 RID: 119201
		private DangoBrawlCombineRowData? Data;

		// Token: 0x0401D1A2 RID: 119202
		[Nullable(2)]
		private UiSequencePlayer SequencePlayer;

		// Token: 0x0200B2EA RID: 45802
		private enum EComponents
		{
			// Token: 0x0403746E RID: 226414
			BtnCombine,
			// Token: 0x0403746F RID: 226415
			TexIcon,
			// Token: 0x04037470 RID: 226416
			SprQuality
		}
	}
}
