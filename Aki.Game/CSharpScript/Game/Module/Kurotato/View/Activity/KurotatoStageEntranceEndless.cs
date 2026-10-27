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
	// Token: 0x0200578C RID: 22412
	public class KurotatoStageEntranceEndless : UiPanelBase
	{
		// Token: 0x06038EE8 RID: 233192 RVA: 0x00D8824C File Offset: 0x00D8644C
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

		// Token: 0x06038EE9 RID: 233193 RVA: 0x00D88334 File Offset: 0x00D86534
		public void InitView(EKurotatoLevelMode levelMode)
		{
			this.LevelMode = levelMode;
			this.RefreshView();
		}

		// Token: 0x06038EEA RID: 233194 RVA: 0x00D88344 File Offset: 0x00D86544
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

		// Token: 0x06038EEB RID: 233195 RVA: 0x00D883EE File Offset: 0x00D865EE
		private void OnSelfBtnClick()
		{
			Action clickCallback = this.ClickCallback;
			if (clickCallback == null)
			{
				return;
			}
			clickCallback();
		}

		// Token: 0x0401DD7F RID: 122239
		public EKurotatoLevelMode LevelMode = EKurotatoLevelMode.Endless;

		// Token: 0x0401DD80 RID: 122240
		[Nullable(2)]
		public Action ClickCallback;

		// Token: 0x0200B9B3 RID: 47539
		private enum EStageEntranceEndlessComponents
		{
			// Token: 0x04038260 RID: 229984
			BtnSelf,
			// Token: 0x04038261 RID: 229985
			TextureScore,
			// Token: 0x04038262 RID: 229986
			TextLevelName,
			// Token: 0x04038263 RID: 229987
			RedDot
		}
	}
}
