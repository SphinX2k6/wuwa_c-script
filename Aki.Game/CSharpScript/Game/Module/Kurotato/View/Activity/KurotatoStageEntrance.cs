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
	// Token: 0x0200578B RID: 22411
	public class KurotatoStageEntrance : UiPanelBase
	{
		// Token: 0x06038EE3 RID: 233187 RVA: 0x00D87FC4 File Offset: 0x00D861C4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 8;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnSelfBtnClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06038EE4 RID: 233188 RVA: 0x00D88130 File Offset: 0x00D86330
		public void InitView(EKurotatoLevelMode levelMode)
		{
			this.LevelMode = levelMode;
			this.RefreshView();
		}

		// Token: 0x06038EE5 RID: 233189 RVA: 0x00D88140 File Offset: 0x00D86340
		public void RefreshView()
		{
			KurotatoLevelGroup value = KurotatoConfig.Instance.GetLevelGroupConfig((int)this.LevelMode).Value;
			LguiUtil.Instance.SetLocalTextNew(base.GetText(5), value.Name, Array.Empty<object>());
			KurotatoActivityData activityData = KurotatoActivityController.Instance.GetActivityData();
			ValueTuple<int, int> levelProgressByLevelGroup = activityData.GetLevelProgressByLevelGroup((int)this.LevelMode);
			int item = levelProgressByLevelGroup.Item1;
			int item2 = levelProgressByLevelGroup.Item2;
			base.GetText(3).SetText(item.ToString(), true);
			base.GetText(4).SetText("/" + item2.ToString(), true);
			base.GetItem(1).SetUIActive(item < item2);
			base.GetItem(2).SetUIActive(item >= item2);
			base.GetSprite(6).SetUIActive(item >= item2);
			bool uiactive = activityData.IsStageEntranceRedDot(this.LevelMode);
			base.GetItem(7).SetUIActive(uiactive);
		}

		// Token: 0x06038EE6 RID: 233190 RVA: 0x00D88228 File Offset: 0x00D86428
		private void OnSelfBtnClick()
		{
			Action clickCallback = this.ClickCallback;
			if (clickCallback == null)
			{
				return;
			}
			clickCallback();
		}

		// Token: 0x0401DD7D RID: 122237
		public EKurotatoLevelMode LevelMode = EKurotatoLevelMode.Teach;

		// Token: 0x0401DD7E RID: 122238
		[Nullable(2)]
		public Action ClickCallback;

		// Token: 0x0200B9B2 RID: 47538
		private enum EStageEntranceComponents
		{
			// Token: 0x04038257 RID: 229975
			BtnSelf,
			// Token: 0x04038258 RID: 229976
			PanelNormal,
			// Token: 0x04038259 RID: 229977
			PanelFinish,
			// Token: 0x0403825A RID: 229978
			TextLevelNum,
			// Token: 0x0403825B RID: 229979
			TextLevelTotalNum,
			// Token: 0x0403825C RID: 229980
			TextLevelName,
			// Token: 0x0403825D RID: 229981
			SpriteFinish,
			// Token: 0x0403825E RID: 229982
			RedDot
		}
	}
}
