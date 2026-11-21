using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.AutoAttach;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.Cipher
{
	// Token: 0x020060B7 RID: 24759
	[NullableContext(2)]
	[Nullable(0)]
	public class CipherKey : UiPanelBase
	{
		// Token: 0x0603B5DC RID: 243164 RVA: 0x010CCCF6 File Offset: 0x010CAEF6
		[NullableContext(1)]
		public CipherKey(UUIItem uiItem, int index)
		{
			this.KeyIndex = index;
			base.CreateThenShowByActor(uiItem.GetOwner(), null);
		}

		// Token: 0x0603B5DD RID: 243165 RVA: 0x010CCD12 File Offset: 0x010CAF12
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIItem))
			};
		}

		// Token: 0x0603B5DE RID: 243166 RVA: 0x010CCD4C File Offset: 0x010CAF4C
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

		// Token: 0x0603B5DF RID: 243167 RVA: 0x010CCE40 File Offset: 0x010CB040
		protected override void OnBeforeDestroy()
		{
			this.RemoveEvent();
			this.CircleExhibitionView.Clear();
		}

		// Token: 0x0603B5E0 RID: 243168 RVA: 0x010CCE53 File Offset: 0x010CB053
		public void AddEvent()
		{
		}

		// Token: 0x0603B5E1 RID: 243169 RVA: 0x010CCE55 File Offset: 0x010CB055
		public void RemoveEvent()
		{
		}

		// Token: 0x0603B5E2 RID: 243170 RVA: 0x010CCE57 File Offset: 0x010CB057
		public void InitKey(Action<int, int> cb)
		{
			this.KeySelectedCallback = cb;
		}

		// Token: 0x0603B5E3 RID: 243171 RVA: 0x010CCE60 File Offset: 0x010CB060
		[NullableContext(1)]
		private CipherCircleAttachItem CreateCircleItem(AActor actor, int index, int showNum)
		{
			CipherCircleAttachItem cipherCircleAttachItem = new CipherCircleAttachItem(actor);
			cipherCircleAttachItem.InitData(this.KeyIndex, this.OnKeyItemSelectedHandle);
			this.CircleItemList.Add(cipherCircleAttachItem);
			return cipherCircleAttachItem;
		}

		// Token: 0x0603B5E4 RID: 243172 RVA: 0x010CCE93 File Offset: 0x010CB093
		private void KeyItemSelectedHandle(int value)
		{
			this.SelectedItemValue = value;
			if (this.KeySelectedCallback == null)
			{
				return;
			}
			this.KeySelectedCallback(this.KeyIndex, value);
		}

		// Token: 0x0603B5E5 RID: 243173 RVA: 0x010CCEB8 File Offset: 0x010CB0B8
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

		// Token: 0x0603B5E6 RID: 243174 RVA: 0x010CCF30 File Offset: 0x010CB130
		public void HandleRest()
		{
			this.CircleExhibitionView.ReloadView(10, this.AllNumber, 0);
			this.CircleExhibitionView.AttachToIndex(0, false);
		}

		// Token: 0x0401F47F RID: 128127
		private const int INITGP = 0;

		// Token: 0x0401F480 RID: 128128
		private const int LEN = 10;

		// Token: 0x0401F481 RID: 128129
		public int KeyIndex;

		// Token: 0x0401F482 RID: 128130
		private Action<int, int> KeySelectedCallback;

		// Token: 0x0401F483 RID: 128131
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private CircleAttachView<int, CipherCircleAttachItem> CircleExhibitionView;

		// Token: 0x0401F484 RID: 128132
		private int[] AllNumber;

		// Token: 0x0401F485 RID: 128133
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<CipherCircleAttachItem> CircleItemList;

		// Token: 0x0401F486 RID: 128134
		private Action<int> OnKeyItemSelectedHandle;

		// Token: 0x0401F487 RID: 128135
		private int SelectedItemValue;

		// Token: 0x0200B968 RID: 47464
		[NullableContext(0)]
		private class ECipherKey
		{
			// Token: 0x040392D6 RID: 234198
			public const int DragCipherList = 0;

			// Token: 0x040392D7 RID: 234199
			public const int CipherCircleItem = 1;
		}
	}
}
