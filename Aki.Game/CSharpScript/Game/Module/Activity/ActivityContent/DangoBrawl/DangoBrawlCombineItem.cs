using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x020067EB RID: 26603
	public class DangoBrawlCombineItem : UiPanelBase
	{
		// Token: 0x06042477 RID: 271479 RVA: 0x01016C00 File Offset: 0x01014E00
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

		// Token: 0x06042478 RID: 271480 RVA: 0x01016CC7 File Offset: 0x01014EC7
		protected override void OnStart()
		{
			this.InitSequencePlayer();
		}

		// Token: 0x06042479 RID: 271481 RVA: 0x01016CCF File Offset: 0x01014ECF
		protected override void OnBeforeDestroy()
		{
			this.ClearSequencePlayer();
		}

		// Token: 0x0604247A RID: 271482 RVA: 0x01016CD8 File Offset: 0x01014ED8
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

		// Token: 0x0604247B RID: 271483 RVA: 0x01016D02 File Offset: 0x01014F02
		private void ClearSequencePlayer()
		{
			UiSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer != null)
			{
				sequencePlayer.Clear();
			}
			this.SequencePlayer = null;
		}

		// Token: 0x0604247C RID: 271484 RVA: 0x01016D1C File Offset: 0x01014F1C
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

		// Token: 0x0604247D RID: 271485 RVA: 0x01016DD8 File Offset: 0x01014FD8
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

		// Token: 0x04022944 RID: 141636
		private DangoBrawlCombineRowData? Data;

		// Token: 0x04022945 RID: 141637
		[Nullable(2)]
		private UiSequencePlayer SequencePlayer;

		// Token: 0x0200C91C RID: 51484
		private enum EComponents
		{
			// Token: 0x0403CB7D RID: 248701
			BtnCombine,
			// Token: 0x0403CB7E RID: 248702
			TexIcon,
			// Token: 0x0403CB7F RID: 248703
			SprQuality
		}
	}
}
