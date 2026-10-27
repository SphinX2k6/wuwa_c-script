using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.AutoAttach;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.Cipher
{
	// Token: 0x02006F36 RID: 28470
	[NullableContext(2)]
	[Nullable(0)]
	public class CipherKey : UiPanelBase
	{
		// Token: 0x0604542E RID: 283694 RVA: 0x01122D4A File Offset: 0x01120F4A
		[NullableContext(1)]
		public CipherKey(UUIItem uiItem, int index)
		{
			this.KeyIndex = index;
			base.CreateThenShowByActor(uiItem.GetOwner(), null);
		}

		// Token: 0x0604542F RID: 283695 RVA: 0x01122D66 File Offset: 0x01120F66
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIItem))
			};
		}

		// Token: 0x06045430 RID: 283696 RVA: 0x01122DA0 File Offset: 0x01120FA0
		protected override void OnStart()
		{
			this.AllNumber = new int[10];
			for (int i = 0; i < 10; i++)
			{
				this.AllNumber[i] = i;
			}
			this.CircleItemList = new List<CipherCircleAttachItem>();
			this.OnKeyItemSelectedHandle = new Action<int>(this.KeyItemSelectedHandle);
			CircleAttachView<int, CipherCircleAttachItem> circleExhibitionView = this.CircleExhibitionView;
			if (circleExhibitionView != null)
			{
				circleExhibitionView.Clear();
			}
			this.CircleExhibitionView = null;
			this.CircleExhibitionView = new CircleAttachView<int, CipherCircleAttachItem>(base.GetItem(0).GetOwner() as AUIBaseActor, false);
			this.CircleExhibitionView.SetAudioEvent("ui_cipher_picker_tick");
			this.CircleExhibitionView.CreateItems(base.GetItem(1).GetOwner() as AUIBaseActor, 0f, new Func<AActor, int, int, CipherCircleAttachItem>(this.CreateCircleItem), EAttachDirection.Vertical);
			base.GetItem(1).SetUIActive(false);
			this.CircleExhibitionView.ReloadView(10, this.AllNumber, 0);
			this.CircleExhibitionView.AttachToIndex(0, false);
			this.AddEvent();
		}

		// Token: 0x06045431 RID: 283697 RVA: 0x01122E94 File Offset: 0x01121094
		protected override void OnBeforeDestroy()
		{
			this.RemoveEvent();
			this.CircleExhibitionView.Clear();
		}

		// Token: 0x06045432 RID: 283698 RVA: 0x01122EA7 File Offset: 0x011210A7
		public void AddEvent()
		{
		}

		// Token: 0x06045433 RID: 283699 RVA: 0x01122EA9 File Offset: 0x011210A9
		public void RemoveEvent()
		{
		}

		// Token: 0x06045434 RID: 283700 RVA: 0x01122EAB File Offset: 0x011210AB
		public void InitKey(Action<int, int> cb)
		{
			this.KeySelectedCallback = cb;
		}

		// Token: 0x06045435 RID: 283701 RVA: 0x01122EB4 File Offset: 0x011210B4
		[NullableContext(1)]
		private CipherCircleAttachItem CreateCircleItem(AActor actor, int index, int showNum)
		{
			CipherCircleAttachItem cipherCircleAttachItem = new CipherCircleAttachItem(actor);
			cipherCircleAttachItem.InitData(this.KeyIndex, this.OnKeyItemSelectedHandle);
			this.CircleItemList.Add(cipherCircleAttachItem);
			return cipherCircleAttachItem;
		}

		// Token: 0x06045436 RID: 283702 RVA: 0x01122EE7 File Offset: 0x011210E7
		private void KeyItemSelectedHandle(int value)
		{
			this.SelectedItemValue = value;
			if (this.KeySelectedCallback == null)
			{
				return;
			}
			this.KeySelectedCallback(this.KeyIndex, value);
		}

		// Token: 0x06045437 RID: 283703 RVA: 0x01122F0C File Offset: 0x0112110C
		public void HandleConfirm(bool result)
		{
			foreach (CipherCircleAttachItem cipherCircleAttachItem in this.CircleItemList)
			{
				int? number = cipherCircleAttachItem.GetNumber();
				int selectedItemValue = this.SelectedItemValue;
				if (number.GetValueOrDefault() == selectedItemValue & number != null)
				{
					cipherCircleAttachItem.HandleConfirm(result);
					break;
				}
			}
		}

		// Token: 0x06045438 RID: 283704 RVA: 0x01122F84 File Offset: 0x01121184
		public void HandleRest()
		{
			this.CircleExhibitionView.ReloadView(10, this.AllNumber, 0);
			this.CircleExhibitionView.AttachToIndex(0, false);
		}

		// Token: 0x040241CA RID: 147914
		private const int INITGP = 0;

		// Token: 0x040241CB RID: 147915
		private const int LEN = 10;

		// Token: 0x040241CC RID: 147916
		public int KeyIndex;

		// Token: 0x040241CD RID: 147917
		private Action<int, int> KeySelectedCallback;

		// Token: 0x040241CE RID: 147918
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private CircleAttachView<int, CipherCircleAttachItem> CircleExhibitionView;

		// Token: 0x040241CF RID: 147919
		private int[] AllNumber;

		// Token: 0x040241D0 RID: 147920
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<CipherCircleAttachItem> CircleItemList;

		// Token: 0x040241D1 RID: 147921
		private Action<int> OnKeyItemSelectedHandle;

		// Token: 0x040241D2 RID: 147922
		private int SelectedItemValue;

		// Token: 0x0200CD76 RID: 52598
		[NullableContext(0)]
		private class ECipherKey
		{
			// Token: 0x0403DEA7 RID: 253607
			public const int DragCipherList = 0;

			// Token: 0x0403DEA8 RID: 253608
			public const int CipherCircleItem = 1;
		}
	}
}
