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
	// Token: 0x02003A53 RID: 14931
	[NullableContext(1)]
	[Nullable(0)]
	public class TrapDefenseDifficultyChangePanel : UiPanelBase
	{
		// Token: 0x06026600 RID: 157184 RVA: 0x00ABFDF4 File Offset: 0x00ABDFF4
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

		// Token: 0x06026601 RID: 157185 RVA: 0x00ABFE3F File Offset: 0x00ABE03F
		protected override void OnBeforeCreate()
		{
		}

		// Token: 0x06026602 RID: 157186 RVA: 0x00ABFE44 File Offset: 0x00ABE044
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

		// Token: 0x06026603 RID: 157187 RVA: 0x00ABFF94 File Offset: 0x00ABE194
		protected override UniTask OnBeforeStartAsync()
		{
			TrapDefenseDifficultyChangePanel.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<TrapDefenseDifficultyChangePanel.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06026604 RID: 157188 RVA: 0x00ABFFD7 File Offset: 0x00ABE1D7
		protected override void OnStart()
		{
		}

		// Token: 0x06026605 RID: 157189 RVA: 0x00ABFFD9 File Offset: 0x00ABE1D9
		protected override void OnBeforeShow()
		{
		}

		// Token: 0x06026606 RID: 157190 RVA: 0x00ABFFDB File Offset: 0x00ABE1DB
		protected override void OnBeforeDestroy()
		{
		}

		// Token: 0x06026607 RID: 157191 RVA: 0x00ABFFDD File Offset: 0x00ABE1DD
		public void OnClickBtnLeft()
		{
			this.ChangeDifficultyAdd(-1);
		}

		// Token: 0x06026608 RID: 157192 RVA: 0x00ABFFE6 File Offset: 0x00ABE1E6
		public void OnClickBtnRight()
		{
			this.ChangeDifficultyAdd(1);
		}

		// Token: 0x06026609 RID: 157193 RVA: 0x00ABFFEF File Offset: 0x00ABE1EF
		public void SetRedDotLeftVisible(bool visible)
		{
			UUIItem item = base.GetItem(3);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(visible);
		}

		// Token: 0x0602660A RID: 157194 RVA: 0x00AC0003 File Offset: 0x00ABE203
		public void SetRedDotRightVisible(bool visible)
		{
			UUIItem item = base.GetItem(5);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(visible);
		}

		// Token: 0x0602660B RID: 157195 RVA: 0x00AC0017 File Offset: 0x00ABE217
		public void UpdateDataList(ITrapDefenseDifficultyLevelInfo[] list, int selectIndex = 0)
		{
			this.DataList = list;
			this.SelectIndex = selectIndex;
			this.UpdateSelectData();
		}

		// Token: 0x0602660C RID: 157196 RVA: 0x00AC0030 File Offset: 0x00ABE230
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

		// Token: 0x0602660D RID: 157197 RVA: 0x00AC0101 File Offset: 0x00ABE301
		public void ChangeDifficultyAdd(int add)
		{
			this.SelectIndex = this.GetAddAfterIndex(this.SelectIndex, add);
			this.UpdateSelectData();
			GuideModel.Instance.FinishFocusGuideGroupOnView(EUiViewName.TrapDefenseMainLevelView);
		}

		// Token: 0x0602660E RID: 157198 RVA: 0x00AC012B File Offset: 0x00ABE32B
		public int GetAddAfterIndex(int index, int add)
		{
			return (int)MathCommon.Warp((float)(index + add), 0f, (float)this.DataList.Length);
		}

		// Token: 0x040150E4 RID: 86244
		public ITrapDefenseDifficultyLevelInfo[] DataList = new ITrapDefenseDifficultyLevelInfo[0];

		// Token: 0x040150E5 RID: 86245
		public int SelectIndex;

		// Token: 0x040150E6 RID: 86246
		[Nullable(2)]
		public Func<int, bool> OnRedDotLeftVisibleCallback;

		// Token: 0x040150E7 RID: 86247
		[Nullable(2)]
		public Func<int, bool> OnRedDotRightVisibleCallback;

		// Token: 0x040150E8 RID: 86248
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<ITrapDefenseDifficultyLevelInfo> OnSelectDifficultyCallback;

		// Token: 0x0200961E RID: 38430
		[NullableContext(0)]
		private class EChildType
		{
			// Token: 0x0402EDE7 RID: 191975
			public const int SpriteBg = 0;

			// Token: 0x0402EDE8 RID: 191976
			public const int TextTitle = 1;

			// Token: 0x0402EDE9 RID: 191977
			public const int BtnLeft = 2;

			// Token: 0x0402EDEA RID: 191978
			public const int ItemRedDotLeft = 3;

			// Token: 0x0402EDEB RID: 191979
			public const int BtnRight = 4;

			// Token: 0x0402EDEC RID: 191980
			public const int ItemRedDotRight = 5;
		}
	}
}
