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
	// Token: 0x02006422 RID: 25634
	public class MotorFightArchiveTip : UiViewBase
	{
		// Token: 0x06040752 RID: 264018 RVA: 0x00F98F08 File Offset: 0x00F97108
		[NullableContext(1)]
		public MotorFightArchiveTip(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06040753 RID: 264019 RVA: 0x00F98F14 File Offset: 0x00F97114
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

		// Token: 0x06040754 RID: 264020 RVA: 0x00F99040 File Offset: 0x00F97240
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

		// Token: 0x06040755 RID: 264021 RVA: 0x00F99130 File Offset: 0x00F97330
		private void OnContinueBtnClick()
		{
			MotorFightLevelData levelDataById = this.ActivityData.GetLevelDataById(this.LastSavedLevelId);
			MotorFightController.Instance.EnterMotorFightDungeonDirectly(this.LastSavedLevelId, levelDataById.RoleId, true);
		}

		// Token: 0x06040756 RID: 264022 RVA: 0x00F99168 File Offset: 0x00F97368
		private void OnStartDirectlyBtnClick()
		{
			MotorFightController.Instance.RequestSettlement(false, null);
			MotorFightLevelData levelDataById = this.ActivityData.GetLevelDataById(this.SelectedLevelId);
			MotorFightLevelDetailViewModel param = new MotorFightLevelDetailViewModel(this.ActivityData, levelDataById);
			base.CloseMe(null);
			UiManager.Instance.OpenView(EUiViewName.MotorFightLevelDetailView, param, null);
		}

		// Token: 0x0402182D RID: 137261
		[Nullable(2)]
		private MotorFightActivityData ActivityData;

		// Token: 0x0402182E RID: 137262
		private int SelectedLevelId;

		// Token: 0x0402182F RID: 137263
		private int LastSavedLevelId;

		// Token: 0x0200C650 RID: 50768
		private class EComponent
		{
			// Token: 0x0403BDEA RID: 245226
			public const int BtnContinue = 0;

			// Token: 0x0403BDEB RID: 245227
			public const int BtnStartDirectly = 1;

			// Token: 0x0403BDEC RID: 245228
			public const int TextName = 2;

			// Token: 0x0403BDED RID: 245229
			public const int TextTime = 3;

			// Token: 0x0403BDEE RID: 245230
			public const int TextScore = 4;
		}
	}
}
