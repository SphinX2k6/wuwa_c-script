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
	// Token: 0x02004762 RID: 18274
	public class KurotatoStageEntrance : UiPanelBase
	{
		// Token: 0x0602DDF3 RID: 187891 RVA: 0x00CD6D20 File Offset: 0x00CD4F20
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

		// Token: 0x0602DDF4 RID: 187892 RVA: 0x00CD6E8C File Offset: 0x00CD508C
		public void InitView(EKurotatoLevelMode levelMode)
		{
			this.LevelMode = levelMode;
			this.RefreshView();
		}

		// Token: 0x0602DDF5 RID: 187893 RVA: 0x00CD6E9C File Offset: 0x00CD509C
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

		// Token: 0x0602DDF6 RID: 187894 RVA: 0x00CD6F84 File Offset: 0x00CD5184
		private void OnSelfBtnClick()
		{
			Action clickCallback = this.ClickCallback;
			if (clickCallback == null)
			{
				return;
			}
			clickCallback();
		}

		// Token: 0x04018813 RID: 100371
		public EKurotatoLevelMode LevelMode = EKurotatoLevelMode.Teach;

		// Token: 0x04018814 RID: 100372
		[Nullable(2)]
		public Action ClickCallback;

		// Token: 0x0200A3C8 RID: 41928
		private enum EStageEntranceComponents
		{
			// Token: 0x04032C48 RID: 207944
			BtnSelf,
			// Token: 0x04032C49 RID: 207945
			PanelNormal,
			// Token: 0x04032C4A RID: 207946
			PanelFinish,
			// Token: 0x04032C4B RID: 207947
			TextLevelNum,
			// Token: 0x04032C4C RID: 207948
			TextLevelTotalNum,
			// Token: 0x04032C4D RID: 207949
			TextLevelName,
			// Token: 0x04032C4E RID: 207950
			SpriteFinish,
			// Token: 0x04032C4F RID: 207951
			RedDot
		}
	}
}
