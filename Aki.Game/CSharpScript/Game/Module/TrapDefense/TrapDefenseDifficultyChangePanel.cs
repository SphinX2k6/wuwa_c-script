using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02004AAB RID: 19115
	[NullableContext(1)]
	[Nullable(0)]
	public class TrapDefenseDifficultyChangePanel : UiPanelBase
	{
		// Token: 0x06031870 RID: 202864 RVA: 0x00B7BE40 File Offset: 0x00B7A040
		public UniTask Init(UUIItem item)
		{
			TrapDefenseDifficultyChangePanel.<Init>d__6 <Init>d__;
			<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Init>d__.<>4__this = this;
			<Init>d__.item = item;
			<Init>d__.<>1__state = -1;
			<Init>d__.<>t__builder.Start<TrapDefenseDifficultyChangePanel.<Init>d__6>(ref <Init>d__);
			return <Init>d__.<>t__builder.Task;
		}

		// Token: 0x06031871 RID: 202865 RVA: 0x00B7BE8B File Offset: 0x00B7A08B
		protected override void OnBeforeCreate()
		{
		}

		// Token: 0x06031872 RID: 202866 RVA: 0x00B7BE90 File Offset: 0x00B7A090
		protected unsafe override void OnRegisterComponent()
		{
			int num = 6;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 2;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(2, new Action(this.OnClickBtnLeft));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(4, new Action(this.OnClickBtnRight));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06031873 RID: 202867 RVA: 0x00B7BFE0 File Offset: 0x00B7A1E0
		protected override UniTask OnBeforeStartAsync()
		{
			TrapDefenseDifficultyChangePanel.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<TrapDefenseDifficultyChangePanel.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06031874 RID: 202868 RVA: 0x00B7C023 File Offset: 0x00B7A223
		protected override void OnStart()
		{
		}

		// Token: 0x06031875 RID: 202869 RVA: 0x00B7C025 File Offset: 0x00B7A225
		protected override void OnBeforeShow()
		{
		}

		// Token: 0x06031876 RID: 202870 RVA: 0x00B7C027 File Offset: 0x00B7A227
		protected override void OnBeforeDestroy()
		{
		}

		// Token: 0x06031877 RID: 202871 RVA: 0x00B7C029 File Offset: 0x00B7A229
		public void OnClickBtnLeft()
		{
			this.ChangeDifficultyAdd(-1);
		}

		// Token: 0x06031878 RID: 202872 RVA: 0x00B7C032 File Offset: 0x00B7A232
		public void OnClickBtnRight()
		{
			this.ChangeDifficultyAdd(1);
		}

		// Token: 0x06031879 RID: 202873 RVA: 0x00B7C03B File Offset: 0x00B7A23B
		public void SetRedDotLeftVisible(bool visible)
		{
			UUIItem item = base.GetItem(3);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(visible);
		}

		// Token: 0x0603187A RID: 202874 RVA: 0x00B7C04F File Offset: 0x00B7A24F
		public void SetRedDotRightVisible(bool visible)
		{
			UUIItem item = base.GetItem(5);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(visible);
		}

		// Token: 0x0603187B RID: 202875 RVA: 0x00B7C063 File Offset: 0x00B7A263
		public void UpdateDataList(ITrapDefenseDifficultyLevelInfo[] list, int selectIndex = 0)
		{
			this.DataList = list;
			this.SelectIndex = selectIndex;
			this.UpdateSelectData();
		}

		// Token: 0x0603187C RID: 202876 RVA: 0x00B7C07C File Offset: 0x00B7A27C
		private void UpdateSelectData()
		{
			ITrapDefenseDifficultyLevelInfo trapDefenseDifficultyLevelInfo = this.DataList[this.SelectIndex];
			base.GetText(1).ShowTextNew(trapDefenseDifficultyLevelInfo.NameKey.ToString());
			UUISprite sprite = base.GetSprite(0);
			string resourcePath = UiResourceConfig.Instance.GetResourcePath(trapDefenseDifficultyLevelInfo.NameBgKey);
			this.SetSpriteByPath(resourcePath, sprite, false, null, null);
			UUIItem item = base.GetItem(3);
			if (item != null)
			{
				Func<int, bool> onRedDotLeftVisibleCallback = this.OnRedDotLeftVisibleCallback;
				item.SetUIActive(onRedDotLeftVisibleCallback != null && onRedDotLeftVisibleCallback(this.GetAddAfterIndex(this.SelectIndex, -1)));
			}
			UUIItem item2 = base.GetItem(5);
			if (item2 != null)
			{
				Func<int, bool> onRedDotRightVisibleCallback = this.OnRedDotRightVisibleCallback;
				item2.SetUIActive(onRedDotRightVisibleCallback != null && onRedDotRightVisibleCallback(this.GetAddAfterIndex(this.SelectIndex, 1)));
			}
			Action<ITrapDefenseDifficultyLevelInfo> onSelectDifficultyCallback = this.OnSelectDifficultyCallback;
			if (onSelectDifficultyCallback == null)
			{
				return;
			}
			onSelectDifficultyCallback(trapDefenseDifficultyLevelInfo);
		}

		// Token: 0x0603187D RID: 202877 RVA: 0x00B7C14D File Offset: 0x00B7A34D
		public void ChangeDifficultyAdd(int add)
		{
			this.SelectIndex = this.GetAddAfterIndex(this.SelectIndex, add);
			this.UpdateSelectData();
			GuideModel.Instance.FinishFocusGuideGroupOnView(EUiViewName.TrapDefenseMainLevelView);
		}

		// Token: 0x0603187E RID: 202878 RVA: 0x00B7C177 File Offset: 0x00B7A377
		public int GetAddAfterIndex(int index, int add)
		{
			return (int)MathCommon.Warp((float)(index + add), 0f, (float)this.DataList.Length);
		}

		// Token: 0x0401A792 RID: 108434
		public ITrapDefenseDifficultyLevelInfo[] DataList = new ITrapDefenseDifficultyLevelInfo[0];

		// Token: 0x0401A793 RID: 108435
		public int SelectIndex;

		// Token: 0x0401A794 RID: 108436
		[Nullable(2)]
		public Func<int, bool> OnRedDotLeftVisibleCallback;

		// Token: 0x0401A795 RID: 108437
		[Nullable(2)]
		public Func<int, bool> OnRedDotRightVisibleCallback;

		// Token: 0x0401A796 RID: 108438
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<ITrapDefenseDifficultyLevelInfo> OnSelectDifficultyCallback;

		// Token: 0x0200ABFE RID: 44030
		[NullableContext(0)]
		private class EChildType
		{
			// Token: 0x04034436 RID: 214070
			public const int SpriteBg = 0;

			// Token: 0x04034437 RID: 214071
			public const int TextTitle = 1;

			// Token: 0x04034438 RID: 214072
			public const int BtnLeft = 2;

			// Token: 0x04034439 RID: 214073
			public const int ItemRedDotLeft = 3;

			// Token: 0x0403443A RID: 214074
			public const int BtnRight = 4;

			// Token: 0x0403443B RID: 214075
			public const int ItemRedDotRight = 5;
		}
	}
}
