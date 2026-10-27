using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Login
{
	// Token: 0x020056B0 RID: 22192
	[NullableContext(1)]
	[Nullable(0)]
	public class LoginLoadView : UiPanelBase
	{
		// Token: 0x06038751 RID: 231249 RVA: 0x00D676D2 File Offset: 0x00D658D2
		public LoginLoadView(AActor actor)
		{
			base.CreateThenShowByActor(actor, null);
		}

		// Token: 0x06038752 RID: 231250 RVA: 0x00D676E4 File Offset: 0x00D658E4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06038753 RID: 231251 RVA: 0x00D6776E File Offset: 0x00D6596E
		protected override void OnStart()
		{
			this.ProgressText = base.GetText(1);
			this.DownLoadTipsText = base.GetText(2);
		}

		// Token: 0x06038754 RID: 231252 RVA: 0x00D6778A File Offset: 0x00D6598A
		public void SetDownLoadTipsTextActive(bool value)
		{
			UUIText downLoadTipsText = this.DownLoadTipsText;
			if (downLoadTipsText == null)
			{
				return;
			}
			downLoadTipsText.SetUIActive(value);
		}

		// Token: 0x06038755 RID: 231253 RVA: 0x00D6779D File Offset: 0x00D6599D
		public void SetDownLoadTipsText(string textId)
		{
			LguiUtil.Instance.SetLocalText(this.DownLoadTipsText, textId, Array.Empty<object>());
		}

		// Token: 0x06038756 RID: 231254 RVA: 0x00D677B5 File Offset: 0x00D659B5
		public void SetProgressSprite(float value)
		{
			UUISprite sprite = base.GetSprite(0);
			if (sprite == null)
			{
				return;
			}
			sprite.SetFillAmount(value);
		}

		// Token: 0x06038757 RID: 231255 RVA: 0x00D677C9 File Offset: 0x00D659C9
		public void SetProgressText(string textId, params object[] args)
		{
			LguiUtil.Instance.SetLocalText(this.ProgressText, textId, args);
		}

		// Token: 0x0401DA66 RID: 121446
		private UUIText ProgressText;

		// Token: 0x0401DA67 RID: 121447
		private UUIText DownLoadTipsText;
	}
}
