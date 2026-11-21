using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Level
{
	// Token: 0x020052B9 RID: 21177
	public class PinballCowLevelItem : UiPanelBase
	{
		// Token: 0x06034B92 RID: 215954 RVA: 0x00EBE578 File Offset: 0x00EBC778
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

		// Token: 0x06034B93 RID: 215955 RVA: 0x00EBE660 File Offset: 0x00EBC860
		private bool IsLevelLock(int levelId)
		{
			return PinballModel.Instance.ActivityData.GetLevelLockStatus(levelId) != EPinballChapterLevelLockStatus.Activated;
		}

		// Token: 0x06034B94 RID: 215956 RVA: 0x00EBE678 File Offset: 0x00EBC878
		[NullableContext(1)]
		private string GetLevelLockTexts(int levelId)
		{
			return PinballModel.Instance.ActivityData.GetLevelPreConditionLockTexts(levelId);
		}

		// Token: 0x06034B95 RID: 215957 RVA: 0x00EBE68C File Offset: 0x00EBC88C
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

		// Token: 0x06034B96 RID: 215958 RVA: 0x00EBE709 File Offset: 0x00EBC909
		public void SelectLevel()
		{
			this.OnTogClick();
		}

		// Token: 0x06034B97 RID: 215959 RVA: 0x00EBE714 File Offset: 0x00EBC914
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

		// Token: 0x0401BEB4 RID: 114356
		[Nullable(new byte[]
		{
			2,
			1,
			1,
			1
		})]
		public Action<PinballLevelRecordData, IPinballLevelInfoData, UUIExtendToggle> OnTogLevelClick;

		// Token: 0x0401BEB5 RID: 114357
		[Nullable(2)]
		private PinballLevelRecordData Data;

		// Token: 0x0200AF33 RID: 44851
		private enum EComponent
		{
			// Token: 0x04036220 RID: 221728
			TogItem,
			// Token: 0x04036221 RID: 221729
			LockItem,
			// Token: 0x04036222 RID: 221730
			SprIcon,
			// Token: 0x04036223 RID: 221731
			FinishedItem
		}
	}
}
