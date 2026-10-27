using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.CyberPunk
{
	// Token: 0x020068C3 RID: 26819
	[NullableContext(1)]
	[Nullable(0)]
	public class CyberPunkTaskTopItem : UiPanelBase
	{
		// Token: 0x06042EE9 RID: 274153 RVA: 0x0104C9F4 File Offset: 0x0104ABF4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
			this.ComponentRegisterInfos = list;
			num2 = 2;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(2, new Action(this.OnClickHelp));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(3, new Action(this.OnClickBack));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06042EEA RID: 274154 RVA: 0x0104CAFF File Offset: 0x0104ACFF
		public void SetOnClose(Action callback)
		{
			this.CloseCallback = callback;
		}

		// Token: 0x06042EEB RID: 274155 RVA: 0x0104CB08 File Offset: 0x0104AD08
		public void SetOnHelp(Action callback)
		{
			this.HelpCallback = callback;
		}

		// Token: 0x06042EEC RID: 274156 RVA: 0x0104CB11 File Offset: 0x0104AD11
		public void SetTitleByTextId(string textId, params string[] args)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), textId, args);
		}

		// Token: 0x06042EED RID: 274157 RVA: 0x0104CB26 File Offset: 0x0104AD26
		public void SetTitleByText(string text)
		{
			UUIText text2 = base.GetText(1);
			if (text2 == null)
			{
				return;
			}
			text2.SetText(text, true);
		}

		// Token: 0x06042EEE RID: 274158 RVA: 0x0104CB3C File Offset: 0x0104AD3C
		public void SetTitleIconByPath(string path)
		{
			this.SetSpriteByPath(path, base.GetSprite(0), false, null, null);
		}

		// Token: 0x06042EEF RID: 274159 RVA: 0x0104CB62 File Offset: 0x0104AD62
		private void OnClickHelp()
		{
			Action helpCallback = this.HelpCallback;
			if (helpCallback == null)
			{
				return;
			}
			helpCallback();
		}

		// Token: 0x06042EF0 RID: 274160 RVA: 0x0104CB74 File Offset: 0x0104AD74
		private void OnClickBack()
		{
			Action closeCallback = this.CloseCallback;
			if (closeCallback == null)
			{
				return;
			}
			closeCallback();
		}

		// Token: 0x04022D1A RID: 142618
		[Nullable(2)]
		private Action CloseCallback;

		// Token: 0x04022D1B RID: 142619
		[Nullable(2)]
		private Action HelpCallback;

		// Token: 0x0200CA9C RID: 51868
		[NullableContext(0)]
		private static class ETopItemComponent
		{
			// Token: 0x0403D3DD RID: 250845
			public const int TitleSpriteIcon = 0;

			// Token: 0x0403D3DE RID: 250846
			public const int TxtTitle = 1;

			// Token: 0x0403D3DF RID: 250847
			public const int BtnHelpInfo = 2;

			// Token: 0x0403D3E0 RID: 250848
			public const int BtnBack = 3;
		}
	}
}
