using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Module.Util.Layout;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.Cipher
{
	// Token: 0x02006F38 RID: 28472
	[NullableContext(1)]
	[Nullable(0)]
	public class CipherView : UiTickViewBase
	{
		// Token: 0x06045446 RID: 283718 RVA: 0x011231C3 File Offset: 0x011213C3
		public CipherView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06045447 RID: 283719 RVA: 0x011231CC File Offset: 0x011213CC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 7;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUINiagara));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUINiagara));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUINiagara));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUINiagara));
			this.ComponentRegisterInfos = list;
			if (this.CipherKeyIndexList == null)
			{
				this.CipherKeyIndexList = new List<int>();
			}
			this.CipherKeyIndexList.Clear();
			for (int i = 0; i < 4; i++)
			{
				this.CipherKeyIndexList.Add(i);
			}
			if (this.CipherKeyList == null)
			{
				this.CipherKeyList = new List<CipherKey>();
			}
			this.CipherKeyList.Clear();
			this.CanConfirm = true;
		}

		// Token: 0x06045448 RID: 283720 RVA: 0x01123335 File Offset: 0x01121535
		protected override void OnStart()
		{
			this.OnKeySelectedHandle = new Action<int, int>(this.KeySelectedHandle);
			this.PasswordPanel = new GenericLayoutNew<CipherKey>(base.GetHorizontalLayout(2), new CSharpScript.Game.Module.Util.Layout.TLayoutRefresh<CipherKey>(this.CreateCipherKeyItem), null);
		}

		// Token: 0x06045449 RID: 283721 RVA: 0x01123368 File Offset: 0x01121568
		protected override void OnAfterShow()
		{
			this.PasswordPanel.RebuildLayoutByDataNew<int>(this.CipherKeyIndexList, null);
			for (int i = 0; i < 4; i++)
			{
				this.KeySelectedHandle(i, 0);
			}
		}

		// Token: 0x0604544A RID: 283722 RVA: 0x011233A3 File Offset: 0x011215A3
		protected override void OnAfterHide()
		{
			this.PasswordPanel.ClearChildren();
			if (!this.CanConfirm)
			{
				UiLayer.Instance.SetShowMaskLayer("CipherConfirmClick", false);
			}
		}

		// Token: 0x0604544B RID: 283723 RVA: 0x011233C8 File Offset: 0x011215C8
		protected override void OnBeforeDestroy()
		{
			if (TimerSystem.Instance.Has(this.CorrectTimerId))
			{
				TimerSystem.Instance.Remove(this.CorrectTimerId);
			}
			if (TimerSystem.Instance.Has(this.WrongTimerId))
			{
				TimerSystem.Instance.Remove(this.WrongTimerId);
			}
		}

		// Token: 0x0604544C RID: 283724 RVA: 0x0112341B File Offset: 0x0112161B
		protected override void OnAddEventListener()
		{
			base.GetButton(0).OnClickCallBack.Bind(new Action(this.OnCloseClick));
			base.GetButton(1).OnClickCallBack.Bind(new Action(this.OnConfirmClick));
		}

		// Token: 0x0604544D RID: 283725 RVA: 0x01123457 File Offset: 0x01121657
		protected override void OnRemoveEventListener()
		{
			base.GetButton(0).OnClickCallBack.Unbind();
			base.GetButton(1).OnClickCallBack.Unbind();
		}

		// Token: 0x0604544E RID: 283726 RVA: 0x0112347C File Offset: 0x0112167C
		private ILayoutItem<CipherKey> CreateCipherKeyItem(object data, UUIItem uiItem, int index)
		{
			CipherKey cipherKey = new CipherKey(uiItem, index);
			cipherKey.InitKey(this.OnKeySelectedHandle);
			this.CipherKeyList.Add(cipherKey);
			return new LayoutItem<CipherKey>
			{
				Key = index,
				Value = cipherKey
			};
		}

		// Token: 0x0604544F RID: 283727 RVA: 0x011234C1 File Offset: 0x011216C1
		public void OnCloseClick()
		{
			if (!this.CanConfirm)
			{
				UiLayer.Instance.SetShowMaskLayer("CipherConfirmClick", false);
			}
			UiManager.Instance.CloseView(EUiViewName.CipherView, null);
		}

		// Token: 0x06045450 RID: 283728 RVA: 0x011234EC File Offset: 0x011216EC
		public void OnConfirmClick()
		{
			if (!this.CanConfirm)
			{
				return;
			}
			int num = 1500;
			int num2 = 1500;
			bool flag = CipherModel.Instance.IsPasswordCorrect();
			int index = 0;
			UiLayer.Instance.SetShowMaskLayer("CipherConfirmClick", true);
			foreach (CipherKey cipherKey in this.CipherKeyList)
			{
				bool checkResultByIndex = CipherModel.Instance.GetCheckResultByIndex(index);
				cipherKey.HandleConfirm(checkResultByIndex);
				this.HandleEffect(index, checkResultByIndex, false);
				int index3 = index;
				index = index3 + 1;
			}
			base.GetButton(1).SetEnable(false);
			this.CanConfirm = false;
			if (flag)
			{
				this.CorrectTimerId = TimerSystem.Instance.Delay(delegate(float _)
				{
					this.TriggerInteraction();
					UiManager.Instance.CloseView(EUiViewName.CipherView, null);
					UiLayer.Instance.SetShowMaskLayer("CipherConfirmClick", false);
				}, (float)num, null, null, true, 1f);
				AudioSystem.Instance.PostEvent("ui_cipher_confirm_success");
				return;
			}
			this.WrongTimerId = TimerSystem.Instance.Delay(delegate(float _)
			{
				this.GetButton(1).SetEnable(true);
				index = 0;
				foreach (CipherKey cipherKey2 in this.CipherKeyList)
				{
					bool checkResultByIndex2 = CipherModel.Instance.GetCheckResultByIndex(index);
					if (!checkResultByIndex2)
					{
						cipherKey2.HandleRest();
					}
					this.HandleEffect(index, checkResultByIndex2, true);
					int index2 = index;
					index = index2 + 1;
				}
				this.CanConfirm = true;
				UiLayer.Instance.SetShowMaskLayer("CipherConfirmClick", false);
			}, (float)num2, null, null, true, 1f);
			AudioSystem.Instance.PostEvent("ui_cipher_confirm_failure");
		}

		// Token: 0x06045451 RID: 283729 RVA: 0x0112363C File Offset: 0x0112183C
		public void TriggerInteraction()
		{
			CipherController.Instance.RequestCipherComplete();
		}

		// Token: 0x06045452 RID: 283730 RVA: 0x01123648 File Offset: 0x01121848
		private void HandleEffect(int inIndex, bool inResult, bool inIsRest)
		{
			int num = -1;
			int num2 = 0;
			if (inResult)
			{
				num = 1;
				num2 = 1;
			}
			if (inResult && inIsRest)
			{
				return;
			}
			if (inIsRest)
			{
				num = 0;
			}
			switch (inIndex)
			{
			case 0:
				base.GetUiNiagara(3).SetNiagaraVarFloat("TargetTime", (float)num);
				base.GetUiNiagara(3).SetNiagaraVarFloat("Flag", (float)num2);
				return;
			case 1:
				base.GetUiNiagara(4).SetNiagaraVarFloat("TargetTime", (float)num);
				base.GetUiNiagara(4).SetNiagaraVarFloat("Flag", (float)num2);
				return;
			case 2:
				base.GetUiNiagara(5).SetNiagaraVarFloat("TargetTime", (float)num);
				base.GetUiNiagara(5).SetNiagaraVarFloat("Flag", (float)num2);
				return;
			case 3:
				base.GetUiNiagara(6).SetNiagaraVarFloat("TargetTime", (float)num);
				base.GetUiNiagara(6).SetNiagaraVarFloat("Flag", (float)num2);
				return;
			default:
				return;
			}
		}

		// Token: 0x06045453 RID: 283731 RVA: 0x01123720 File Offset: 0x01121920
		private void KeySelectedHandle(int index, int value)
		{
			float value2 = MathUtils.Instance.RangeClamp((float)value, 0f, 9f, 0.1f, 1.5f);
			switch (index)
			{
			case 0:
				base.GetUiNiagara(3).SetNiagaraVarFloat("WPO", value2);
				break;
			case 1:
				base.GetUiNiagara(4).SetNiagaraVarFloat("WPO", value2);
				break;
			case 2:
				base.GetUiNiagara(5).SetNiagaraVarFloat("WPO", value2);
				break;
			case 3:
				base.GetUiNiagara(6).SetNiagaraVarFloat("WPO", value2);
				break;
			}
			AudioSystem.Instance.PostEvent("ui_cipher_picker_select");
		}

		// Token: 0x040241DA RID: 147930
		private const int WRONG_COLOR = -1;

		// Token: 0x040241DB RID: 147931
		private const int RIGHT_COLOR = 1;

		// Token: 0x040241DC RID: 147932
		private const int NORMAL_COLOR = 0;

		// Token: 0x040241DD RID: 147933
		private const string WPO = "WPO";

		// Token: 0x040241DE RID: 147934
		private const string COLOR = "TargetTime";

		// Token: 0x040241DF RID: 147935
		private const string FLAG = "Flag";

		// Token: 0x040241E0 RID: 147936
		private const int LEN = 4;

		// Token: 0x040241E1 RID: 147937
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayoutNew<CipherKey> PasswordPanel;

		// Token: 0x040241E2 RID: 147938
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<CipherKey> CipherKeyList;

		// Token: 0x040241E3 RID: 147939
		[Nullable(2)]
		private List<int> CipherKeyIndexList;

		// Token: 0x040241E4 RID: 147940
		[Nullable(2)]
		public TimerHandle CorrectTimerId;

		// Token: 0x040241E5 RID: 147941
		[Nullable(2)]
		private TimerHandle WrongTimerId;

		// Token: 0x040241E6 RID: 147942
		private bool CanConfirm;

		// Token: 0x040241E7 RID: 147943
		[Nullable(2)]
		protected Action<int, int> OnKeySelectedHandle;

		// Token: 0x0200CD77 RID: 52599
		[NullableContext(0)]
		private class ECipherView
		{
			// Token: 0x0403DEA9 RID: 253609
			public const int Close = 0;

			// Token: 0x0403DEAA RID: 253610
			public const int Confirm = 1;

			// Token: 0x0403DEAB RID: 253611
			public const int PasswordPanel = 2;

			// Token: 0x0403DEAC RID: 253612
			public const int Effect1 = 3;

			// Token: 0x0403DEAD RID: 253613
			public const int Effect2 = 4;

			// Token: 0x0403DEAE RID: 253614
			public const int Effect3 = 5;

			// Token: 0x0403DEAF RID: 253615
			public const int Effect4 = 6;
		}
	}
}
