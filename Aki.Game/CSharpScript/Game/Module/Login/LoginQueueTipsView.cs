using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Login
{
	// Token: 0x020056B4 RID: 22196
	public class LoginQueueTipsView : UiTickViewBase
	{
		// Token: 0x0603875E RID: 231262 RVA: 0x00D678A5 File Offset: 0x00D65AA5
		[NullableContext(1)]
		public LoginQueueTipsView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603875F RID: 231263 RVA: 0x00D678B0 File Offset: 0x00D65AB0
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(3, new Action(this.QuitButton));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06038760 RID: 231264 RVA: 0x00D67998 File Offset: 0x00D65B98
		private void QuitButton()
		{
			base.CloseMe(null);
		}

		// Token: 0x06038761 RID: 231265 RVA: 0x00D679A1 File Offset: 0x00D65BA1
		protected override void OnBeforeDestroy()
		{
			if (LoginModel.Instance.HasAutoLoginPromise())
			{
				LoginModel.Instance.FinishAutoLoginPromise(false);
			}
		}

		// Token: 0x06038762 RID: 231266 RVA: 0x00D679BC File Offset: 0x00D65BBC
		protected override void OnStart()
		{
			this.LoginQueueConfig = (this.OpenParam as LoginQueueConfig);
			LoginQueueConfig loginQueueConfig = this.LoginQueueConfig;
			int? num = (loginQueueConfig != null) ? new int?(loginQueueConfig.ClientWaitingMode) : null;
			if (num != null)
			{
				int valueOrDefault = num.GetValueOrDefault();
				if (valueOrDefault == 0)
				{
					UUIText text = base.GetText(0);
					if (text != null)
					{
						text.ShowTextNew("NormalWaitTipsText");
					}
					LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "ExpectWaitingTimeText", new <>z__ReadOnlySingleElementList<object>(Math.Floor((double)this.LoginQueueConfig.ClientWaitingTime / TimeUtil.Instance.Minute + 0.5).ToString().PadLeft(2, '0')));
					this.RefreshAddTimeText();
					return;
				}
				if (valueOrDefault != 1)
				{
					return;
				}
				UUIText text2 = base.GetText(0);
				if (text2 != null)
				{
					text2.ShowTextNew("specialWaitTipsText");
				}
				UUIText text3 = base.GetText(1);
				if (text3 != null)
				{
					text3.SetUIActive(false);
				}
				UUIText text4 = base.GetText(2);
				if (text4 == null)
				{
					return;
				}
				text4.SetUIActive(false);
			}
		}

		// Token: 0x06038763 RID: 231267 RVA: 0x00D67AC1 File Offset: 0x00D65CC1
		protected override void OnTick(float delta)
		{
			this.AddTimeMs += delta;
			this.RefreshAddTimeText();
		}

		// Token: 0x06038764 RID: 231268 RVA: 0x00D67AD8 File Offset: 0x00D65CD8
		private void RefreshAddTimeText()
		{
			UUIText text = base.GetText(2);
			if (text == null || !text.IsUIActiveInHierarchy())
			{
				return;
			}
			double num = Math.Floor(TimeUtil.Instance.SetTimeSecond((double)this.AddTimeMs) + 0.5);
			double num2 = Math.Floor(num / TimeUtil.Instance.Minute);
			double num3 = num % TimeUtil.Instance.Minute;
			LguiUtil.Instance.SetLocalTextNew(text, "AddWaitingTimeText", new <>z__ReadOnlyArray<object>(new object[]
			{
				num2.ToString().PadLeft(2, '0'),
				num3.ToString().PadLeft(2, '0')
			}));
		}

		// Token: 0x0401DA6F RID: 121455
		[Nullable(2)]
		private LoginQueueConfig LoginQueueConfig;

		// Token: 0x0401DA70 RID: 121456
		private float AddTimeMs;
	}
}
