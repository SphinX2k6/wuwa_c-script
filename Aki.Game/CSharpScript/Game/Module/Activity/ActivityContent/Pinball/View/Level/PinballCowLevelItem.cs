using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Level
{
	// Token: 0x0200633B RID: 25403
	public class PinballCowLevelItem : UiPanelBase
	{
		// Token: 0x0603FED1 RID: 261841 RVA: 0x00F7761C File Offset: 0x00F7581C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(delegate(EToggleState _)
			{
				this.OnTogClick();
			}));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603FED2 RID: 261842 RVA: 0x00F77704 File Offset: 0x00F75904
		private bool IsLevelLock(int levelId)
		{
			return PinballModel.Instance.ActivityData.GetLevelLockStatus(levelId) != EPinballChapterLevelLockStatus.Activated;
		}

		// Token: 0x0603FED3 RID: 261843 RVA: 0x00F7771C File Offset: 0x00F7591C
		[NullableContext(1)]
		private string GetLevelLockTexts(int levelId)
		{
			return PinballModel.Instance.ActivityData.GetLevelPreConditionLockTexts(levelId);
		}

		// Token: 0x0603FED4 RID: 261844 RVA: 0x00F77730 File Offset: 0x00F75930
		[NullableContext(1)]
		public void Refresh(PinballLevelRecordData data)
		{
			this.Data = data;
			PinballLevelConfig? pinballLevelConfigById = PinballConfig.Instance.GetPinballLevelConfigById(data.LevelId);
			bool uiactive = this.IsLevelLock(data.LevelId);
			bool uiactive2 = data.PassStatus == EPinballLevelPassStatus.Perfect;
			base.GetItem(1).SetUIActive(uiactive);
			base.GetItem(3).SetUIActive(uiactive2);
			base.SetTextureByPath(pinballLevelConfigById.Value.Icon, base.GetTexture(2), null, null);
		}

		// Token: 0x0603FED5 RID: 261845 RVA: 0x00F777AD File Offset: 0x00F759AD
		public void SelectLevel()
		{
			this.OnTogClick();
		}

		// Token: 0x0603FED6 RID: 261846 RVA: 0x00F777B8 File Offset: 0x00F759B8
		private void OnTogClick()
		{
			if (this.Data == null)
			{
				return;
			}
			PinballLevelInfoData arg = new PinballLevelInfoData
			{
				LevelId = this.Data.LevelId,
				RealLevelId = this.Data.LevelId,
				LevelLock = new bool?(this.IsLevelLock(this.Data.LevelId)),
				LevelLockTexts = this.GetLevelLockTexts(this.Data.LevelId),
				LevelScore = new int?(this.Data.LevelScore),
				ShowScore = new bool?(true),
				ShowDesc = new bool?(true)
			};
			Action<PinballLevelRecordData, IPinballLevelInfoData, UUIExtendToggle> onTogLevelClick = this.OnTogLevelClick;
			if (onTogLevelClick == null)
			{
				return;
			}
			onTogLevelClick(this.Data, arg, base.GetExtendToggle(0));
		}

		// Token: 0x04021585 RID: 136581
		[Nullable(new byte[]
		{
			2,
			1,
			1,
			1
		})]
		public Action<PinballLevelRecordData, IPinballLevelInfoData, UUIExtendToggle> OnTogLevelClick;

		// Token: 0x04021586 RID: 136582
		[Nullable(2)]
		private PinballLevelRecordData Data;

		// Token: 0x0200C54C RID: 50508
		private enum EComponent
		{
			// Token: 0x0403B8BE RID: 243902
			TogItem,
			// Token: 0x0403B8BF RID: 243903
			LockItem,
			// Token: 0x0403B8C0 RID: 243904
			SprIcon,
			// Token: 0x0403B8C1 RID: 243905
			FinishedItem
		}
	}
}
