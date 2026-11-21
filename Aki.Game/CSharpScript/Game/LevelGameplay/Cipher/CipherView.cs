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
	// Token: 0x020060B9 RID: 24761
	[NullableContext(1)]
	[Nullable(0)]
	public class CipherView : UiTickViewBase
	{
		// Token: 0x0603B5F4 RID: 243188 RVA: 0x010CD16F File Offset: 0x010CB36F
		public CipherView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603B5F5 RID: 243189 RVA: 0x010CD178 File Offset: 0x010CB378
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

		// Token: 0x0603B5F6 RID: 243190 RVA: 0x010CD2E1 File Offset: 0x010CB4E1
		protected override void OnStart()
		{
			this.OnKeySelectedHandle = new Action<int, int>(this.KeySelectedHandle);
			this.PasswordPanel = new GenericLayoutNew<CipherKey>(base.GetHorizontalLayout(2), new CSharpScript.Game.Module.Util.Layout.TLayoutRefresh<CipherKey>(this.CreateCipherKeyItem), null);
		}

		// Token: 0x0603B5F7 RID: 243191 RVA: 0x010CD314 File Offset: 0x010CB514
		protected override void OnAfterShow()
		{
			this.PasswordPanel.RebuildLayoutByDataNew<int>(this.CipherKeyIndexList, null);
			for (int i = 0; i < 4; i++)
			{
				this.KeySelectedHandle(i, 0);
			}
		}

		// Token: 0x0603B5F8 RID: 243192 RVA: 0x010CD34F File Offset: 0x010CB54F
		protected override void OnAfterHide()
		{
			this.PasswordPanel.ClearChildren();
			if (!this.CanConfirm)
			{
				UiLayer.Instance.SetShowMaskLayer("CipherConfirmClick", false);
			}
		}

		// Token: 0x0603B5F9 RID: 243193 RVA: 0x010CD374 File Offset: 0x010CB574
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

		// Token: 0x0603B5FA RID: 243194 RVA: 0x010CD3C7 File Offset: 0x010CB5C7
		protected override void OnAddEventListener()
		{
			base.GetButton(0).OnClickCallBack.Bind(new Action(this.OnCloseClick));
			base.GetButton(1).OnClickCallBack.Bind(new Action(this.OnConfirmClick));
		}

		// Token: 0x0603B5FB RID: 243195 RVA: 0x010CD403 File Offset: 0x010CB603
		protected override void OnRemoveEventListener()
		{
			base.GetButton(0).OnClickCallBack.Unbind();
			base.GetButton(1).OnClickCallBack.Unbind();
		}

		// Token: 0x0603B5FC RID: 243196 RVA: 0x010CD428 File Offset: 0x010CB628
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

		// Token: 0x0603B5FD RID: 243197 RVA: 0x010CD46D File Offset: 0x010CB66D
		public void OnCloseClick()
		{
			if (!this.CanConfirm)
			{
				UiLayer.Instance.SetShowMaskLayer("CipherConfirmClick", false);
			}
			UiManager.Instance.CloseView(EUiViewName.CipherView, null);
		}

		// Token: 0x0603B5FE RID: 243198 RVA: 0x010CD498 File Offset: 0x010CB698
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

		// Token: 0x0603B5FF RID: 243199 RVA: 0x010CD5E8 File Offset: 0x010CB7E8
		public void TriggerInteraction()
		{
			CipherController.Instance.RequestCipherComplete();
		}

		// Token: 0x0603B600 RID: 243200 RVA: 0x010CD5F4 File Offset: 0x010CB7F4
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

		// Token: 0x0603B601 RID: 243201 RVA: 0x010CD6CC File Offset: 0x010CB8CC
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

		// Token: 0x0401F48F RID: 128143
		private const int WRONG_COLOR = -1;

		// Token: 0x0401F490 RID: 128144
		private const int RIGHT_COLOR = 1;

		// Token: 0x0401F491 RID: 128145
		private const int NORMAL_COLOR = 0;

		// Token: 0x0401F492 RID: 128146
		private const string WPO = "WPO";

		// Token: 0x0401F493 RID: 128147
		private const string COLOR = "TargetTime";

		// Token: 0x0401F494 RID: 128148
		private const string FLAG = "Flag";

		// Token: 0x0401F495 RID: 128149
		private const int LEN = 4;

		// Token: 0x0401F496 RID: 128150
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayoutNew<CipherKey> PasswordPanel;

		// Token: 0x0401F497 RID: 128151
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<CipherKey> CipherKeyList;

		// Token: 0x0401F498 RID: 128152
		[Nullable(2)]
		private List<int> CipherKeyIndexList;

		// Token: 0x0401F499 RID: 128153
		[Nullable(2)]
		public TimerHandle CorrectTimerId;

		// Token: 0x0401F49A RID: 128154
		[Nullable(2)]
		private TimerHandle WrongTimerId;

		// Token: 0x0401F49B RID: 128155
		private bool CanConfirm;

		// Token: 0x0401F49C RID: 128156
		[Nullable(2)]
		protected Action<int, int> OnKeySelectedHandle;

		// Token: 0x0200B969 RID: 47465
		[NullableContext(0)]
		private class ECipherView
		{
			// Token: 0x040392D8 RID: 234200
			public const int Close = 0;

			// Token: 0x040392D9 RID: 234201
			public const int Confirm = 1;

			// Token: 0x040392DA RID: 234202
			public const int PasswordPanel = 2;

			// Token: 0x040392DB RID: 234203
			public const int Effect1 = 3;

			// Token: 0x040392DC RID: 234204
			public const int Effect2 = 4;

			// Token: 0x040392DD RID: 234205
			public const int Effect3 = 5;

			// Token: 0x040392DE RID: 234206
			public const int Effect4 = 6;
		}
	}
}
