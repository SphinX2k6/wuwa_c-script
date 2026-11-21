using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.CyberPunk
{
	// Token: 0x02005813 RID: 22547
	[NullableContext(1)]
	[Nullable(0)]
	public class CyberPunkTaskTopItem : UiPanelBase
	{
		// Token: 0x06037A41 RID: 227905 RVA: 0x00F8E01C File Offset: 0x00F8C21C
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

		// Token: 0x06037A42 RID: 227906 RVA: 0x00F8E127 File Offset: 0x00F8C327
		public void SetOnClose(Action callback)
		{
			this.CloseCallback = callback;
		}

		// Token: 0x06037A43 RID: 227907 RVA: 0x00F8E130 File Offset: 0x00F8C330
		public void SetOnHelp(Action callback)
		{
			this.HelpCallback = callback;
		}

		// Token: 0x06037A44 RID: 227908 RVA: 0x00F8E139 File Offset: 0x00F8C339
		public void SetTitleByTextId(string textId, params string[] args)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), textId, args);
		}

		// Token: 0x06037A45 RID: 227909 RVA: 0x00F8E14E File Offset: 0x00F8C34E
		public void SetTitleByText(string text)
		{
			UUIText text2 = base.GetText(1);
			if (text2 == null)
			{
				return;
			}
			text2.SetText(text, true);
		}

		// Token: 0x06037A46 RID: 227910 RVA: 0x00F8E164 File Offset: 0x00F8C364
		public void SetTitleIconByPath(string path)
		{
			this.SetSpriteByPath(path, base.GetSprite(0), false, null, null);
		}

		// Token: 0x06037A47 RID: 227911 RVA: 0x00F8E18A File Offset: 0x00F8C38A
		private void OnClickHelp()
		{
			Action helpCallback = this.HelpCallback;
			if (helpCallback == null)
			{
				return;
			}
			helpCallback();
		}

		// Token: 0x06037A48 RID: 227912 RVA: 0x00F8E19C File Offset: 0x00F8C39C
		private void OnClickBack()
		{
			Action closeCallback = this.CloseCallback;
			if (closeCallback == null)
			{
				return;
			}
			closeCallback();
		}

		// Token: 0x0401D576 RID: 120182
		[Nullable(2)]
		private Action CloseCallback;

		// Token: 0x0401D577 RID: 120183
		[Nullable(2)]
		private Action HelpCallback;

		// Token: 0x0200B464 RID: 46180
		[NullableContext(0)]
		private static class ETopItemComponent
		{
			// Token: 0x04037CB7 RID: 228535
			public const int TitleSpriteIcon = 0;

			// Token: 0x04037CB8 RID: 228536
			public const int TxtTitle = 1;

			// Token: 0x04037CB9 RID: 228537
			public const int BtnHelpInfo = 2;

			// Token: 0x04037CBA RID: 228538
			public const int BtnBack = 3;
		}
	}
}
