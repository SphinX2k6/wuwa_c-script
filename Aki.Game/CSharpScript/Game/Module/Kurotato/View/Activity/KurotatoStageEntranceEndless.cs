using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Kurotato.Data;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Kurotato.View.Activity
{
	// Token: 0x02004763 RID: 18275
	public class KurotatoStageEntranceEndless : UiPanelBase
	{
		// Token: 0x0602DDF8 RID: 187896 RVA: 0x00CD6FA8 File Offset: 0x00CD51A8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnSelfBtnClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0602DDF9 RID: 187897 RVA: 0x00CD7090 File Offset: 0x00CD5290
		public void InitView(EKurotatoLevelMode levelMode)
		{
			this.LevelMode = levelMode;
			this.RefreshView();
		}

		// Token: 0x0602DDFA RID: 187898 RVA: 0x00CD70A0 File Offset: 0x00CD52A0
		public void RefreshView()
		{
			KurotatoLevelGroup value = KurotatoConfig.Instance.GetLevelGroupConfig((int)this.LevelMode).Value;
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), value.Name, Array.Empty<object>());
			KurotatoActivityData activityData = KurotatoActivityController.Instance.GetActivityData();
			int currentEndlessModeWave = activityData.GetCurrentEndlessModeWave();
			string currentScoreLevelIcon = activityData.GetCurrentScoreLevelIcon(currentEndlessModeWave);
			UUITexture texture = base.GetTexture(1);
			bool flag = !string.IsNullOrEmpty(currentScoreLevelIcon);
			texture.SetUIActive(flag);
			if (flag)
			{
				base.SetTextureByPath(currentScoreLevelIcon, texture, null, null);
			}
			bool uiactive = activityData.IsStageEntranceRedDot(this.LevelMode);
			base.GetItem(3).SetUIActive(uiactive);
		}

		// Token: 0x0602DDFB RID: 187899 RVA: 0x00CD714A File Offset: 0x00CD534A
		private void OnSelfBtnClick()
		{
			Action clickCallback = this.ClickCallback;
			if (clickCallback == null)
			{
				return;
			}
			clickCallback();
		}

		// Token: 0x04018815 RID: 100373
		public EKurotatoLevelMode LevelMode = EKurotatoLevelMode.Endless;

		// Token: 0x04018816 RID: 100374
		[Nullable(2)]
		public Action ClickCallback;

		// Token: 0x0200A3C9 RID: 41929
		private enum EStageEntranceEndlessComponents
		{
			// Token: 0x04032C51 RID: 207953
			BtnSelf,
			// Token: 0x04032C52 RID: 207954
			TextureScore,
			// Token: 0x04032C53 RID: 207955
			TextLevelName,
			// Token: 0x04032C54 RID: 207956
			RedDot
		}
	}
}
