using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Login
{
	// Token: 0x02004686 RID: 18054
	[NullableContext(1)]
	[Nullable(0)]
	public class LoginLoadView : UiPanelBase
	{
		// Token: 0x0602D64E RID: 185934 RVA: 0x00CB5896 File Offset: 0x00CB3A96
		public LoginLoadView(AActor actor)
		{
			base.CreateThenShowByActor(actor, null);
		}

		// Token: 0x0602D64F RID: 185935 RVA: 0x00CB58A8 File Offset: 0x00CB3AA8
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

		// Token: 0x0602D650 RID: 185936 RVA: 0x00CB5932 File Offset: 0x00CB3B32
		protected override void OnStart()
		{
			this.ProgressText = base.GetText(1);
			this.DownLoadTipsText = base.GetText(2);
		}

		// Token: 0x0602D651 RID: 185937 RVA: 0x00CB594E File Offset: 0x00CB3B4E
		public void SetDownLoadTipsTextActive(bool value)
		{
			UUIText downLoadTipsText = this.DownLoadTipsText;
			if (downLoadTipsText == null)
			{
				return;
			}
			downLoadTipsText.SetUIActive(value);
		}

		// Token: 0x0602D652 RID: 185938 RVA: 0x00CB5961 File Offset: 0x00CB3B61
		public void SetDownLoadTipsText(string textId)
		{
			LguiUtil.Instance.SetLocalText(this.DownLoadTipsText, textId, Array.Empty<object>());
		}

		// Token: 0x0602D653 RID: 185939 RVA: 0x00CB5979 File Offset: 0x00CB3B79
		public void SetProgressSprite(float value)
		{
			UUISprite sprite = base.GetSprite(0);
			if (sprite == null)
			{
				return;
			}
			sprite.SetFillAmount(value);
		}

		// Token: 0x0602D654 RID: 185940 RVA: 0x00CB598D File Offset: 0x00CB3B8D
		public void SetProgressText(string textId, params object[] args)
		{
			LguiUtil.Instance.SetLocalText(this.ProgressText, textId, args);
		}

		// Token: 0x040184F1 RID: 99569
		private UUIText ProgressText;

		// Token: 0x040184F2 RID: 99570
		private UUIText DownLoadTipsText;
	}
}
