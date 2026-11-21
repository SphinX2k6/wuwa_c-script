using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MotorFight
{
	// Token: 0x020053A0 RID: 21408
	public class MotorFightArchiveTip : UiViewBase
	{
		// Token: 0x06035413 RID: 218131 RVA: 0x00EDFEA8 File Offset: 0x00EDE0A8
		[NullableContext(1)]
		public MotorFightArchiveTip(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06035414 RID: 218132 RVA: 0x00EDFEB4 File Offset: 0x00EDE0B4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 5;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			this.ComponentRegisterInfos = list;
			num2 = 2;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnContinueBtnClick));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(1, new Action(this.OnStartDirectlyBtnClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06035415 RID: 218133 RVA: 0x00EDFFE0 File Offset: 0x00EDE1E0
		protected override void OnBeforeShow()
		{
			this.SelectedLevelId = (int)this.OpenParam;
			this.ActivityData = MotorFightController.Instance.GetMotorFightActivityData();
			MotorFightLastSaveData lastSavedLevelData = this.ActivityData.GetLastSavedLevelData();
			if (lastSavedLevelData == null)
			{
				Log.Instance.Error(ELogModule.MotorFightActivity, ELogAuthor.CXJ, "摩托战斗存档数据不存在", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			this.LastSavedLevelId = lastSavedLevelData.LevelId;
			string localTextNew = ConfigMultiTextLang.GetLocalTextNew(this.ActivityData.GetLevelDataById(this.LastSavedLevelId).LevelName, null);
			UUIText text = base.GetText(2);
			if (text != null)
			{
				text.SetText(localTextNew, true);
			}
			long num = MathUtils.Instance.LongToNumber(lastSavedLevelData.CostTime);
			string timeDataFormatWithHour = TimeUtil.Instance.GetTimeDataFormatWithHour((double)num);
			UUIText text2 = base.GetText(3);
			if (text2 != null)
			{
				text2.SetText(timeDataFormatWithHour, true);
			}
			UUIText text3 = base.GetText(4);
			if (text3 == null)
			{
				return;
			}
			text3.SetText(lastSavedLevelData.Score.ToString(), true);
		}

		// Token: 0x06035416 RID: 218134 RVA: 0x00EE00D0 File Offset: 0x00EDE2D0
		private void OnContinueBtnClick()
		{
			MotorFightLevelData levelDataById = this.ActivityData.GetLevelDataById(this.LastSavedLevelId);
			MotorFightController.Instance.EnterMotorFightDungeonDirectly(this.LastSavedLevelId, levelDataById.RoleId, true);
		}

		// Token: 0x06035417 RID: 218135 RVA: 0x00EE0108 File Offset: 0x00EDE308
		private void OnStartDirectlyBtnClick()
		{
			MotorFightController.Instance.RequestSettlement(false, null);
			MotorFightLevelData levelDataById = this.ActivityData.GetLevelDataById(this.SelectedLevelId);
			MotorFightLevelDetailViewModel param = new MotorFightLevelDetailViewModel(this.ActivityData, levelDataById);
			base.CloseMe(null);
			UiManager.Instance.OpenView(EUiViewName.MotorFightLevelDetailView, param, null);
		}

		// Token: 0x0401C15C RID: 115036
		[Nullable(2)]
		private MotorFightActivityData ActivityData;

		// Token: 0x0401C15D RID: 115037
		private int SelectedLevelId;

		// Token: 0x0401C15E RID: 115038
		private int LastSavedLevelId;

		// Token: 0x0200B037 RID: 45111
		private class EComponent
		{
			// Token: 0x04036747 RID: 223047
			public const int BtnContinue = 0;

			// Token: 0x04036748 RID: 223048
			public const int BtnStartDirectly = 1;

			// Token: 0x04036749 RID: 223049
			public const int TextName = 2;

			// Token: 0x0403674A RID: 223050
			public const int TextTime = 3;

			// Token: 0x0403674B RID: 223051
			public const int TextScore = 4;
		}
	}
}
