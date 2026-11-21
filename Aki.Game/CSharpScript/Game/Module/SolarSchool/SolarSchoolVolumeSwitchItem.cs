using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Menu;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005A5F RID: 23135
	public class SolarSchoolVolumeSwitchItem : SyncGridProxyAbstract<EFunction>
	{
		// Token: 0x06038FEC RID: 233452 RVA: 0x00FF69EC File Offset: 0x00FF4BEC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 9;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIExtendToggleSpriteTransition));
			this.ComponentRegisterInfos = list;
			num2 = 2;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(2, new Action(this.OnLeftClick));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(3, new Action(this.OnRightClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06038FED RID: 233453 RVA: 0x00FF6BA0 File Offset: 0x00FF4DA0
		protected override void OnStart()
		{
			this.DetailToggle = (this.RootActor.GetComponentByClass(UUIExtendToggle.StaticClass()) as UUIExtendToggle);
			UUIExtendToggle detailToggle = this.DetailToggle;
			if (detailToggle != null)
			{
				detailToggle.SetToggleGroup(null);
			}
			UUIExtendToggle detailToggle2 = this.DetailToggle;
			if (detailToggle2 != null)
			{
				detailToggle2.SetToggleStateForce(EToggleState.ETT_UnChecked, false, true, false);
			}
			UUIExtendToggle detailToggle3 = this.DetailToggle;
			if (detailToggle3 == null)
			{
				return;
			}
			detailToggle3.CanExecuteChange.Bind(new Func<bool>(this.OnDetailClicked));
		}

		// Token: 0x06038FEE RID: 233454 RVA: 0x00FF6C15 File Offset: 0x00FF4E15
		protected override void OnBeforeDestroy()
		{
			UUIExtendToggle detailToggle = this.DetailToggle;
			if (detailToggle != null)
			{
				detailToggle.CanExecuteChange.Unbind();
			}
			this.DetailToggle = null;
		}

		// Token: 0x06038FEF RID: 233455 RVA: 0x00FF6C34 File Offset: 0x00FF4E34
		public override void Refresh(EFunction functionId)
		{
			this.FunctionId = functionId;
			MenuConfig? menuConfigByFunctionId = MenuBaseConfig.Instance.GetMenuConfigByFunctionId((int)functionId);
			if (menuConfigByFunctionId == null)
			{
				return;
			}
			MenuData menuData = new MenuData(menuConfigByFunctionId.Value);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), menuData.FunctionName, Array.Empty<object>());
			if (menuData.HasDetailText())
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(5), menuData.GetDetailTextId(), Array.Empty<object>());
			}
			else
			{
				this.IsDetailVisible = false;
			}
			int currentIndex = this.GetCurrentIndex(menuData);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), menuData.OptionsNameList[currentIndex], Array.Empty<object>());
			base.GetButton(2).SetSelfInteractive(currentIndex > 0);
			base.GetButton(3).SetSelfInteractive(currentIndex < menuData.OptionsValueList.Count - 1);
			base.GetItem(4).SetUIActive(this.IsDetailVisible);
			UUIExtendToggle detailToggle = this.DetailToggle;
			if (detailToggle != null)
			{
				detailToggle.SetToggleStateForce(EToggleState.ETT_UnChecked, false, true, false);
			}
			base.GetSprite(7).SetUIActive(menuData.IsRecommendIndex(currentIndex));
			base.GetSprite(6).SetUIActive(menuData.ShowHelpBtn());
			this.RefreshDetailSprite(menuData).Forget();
		}

		// Token: 0x06038FF0 RID: 233456 RVA: 0x00FF6D64 File Offset: 0x00FF4F64
		[NullableContext(1)]
		private UniTask RefreshDetailSprite(MenuData menuData)
		{
			SolarSchoolVolumeSwitchItem.<RefreshDetailSprite>d__8 <RefreshDetailSprite>d__;
			<RefreshDetailSprite>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshDetailSprite>d__.<>4__this = this;
			<RefreshDetailSprite>d__.menuData = menuData;
			<RefreshDetailSprite>d__.<>1__state = -1;
			<RefreshDetailSprite>d__.<>t__builder.Start<SolarSchoolVolumeSwitchItem.<RefreshDetailSprite>d__8>(ref <RefreshDetailSprite>d__);
			return <RefreshDetailSprite>d__.<>t__builder.Task;
		}

		// Token: 0x06038FF1 RID: 233457 RVA: 0x00FF6DB0 File Offset: 0x00FF4FB0
		private bool OnDetailClicked()
		{
			MenuConfig? menuConfigByFunctionId = MenuBaseConfig.Instance.GetMenuConfigByFunctionId((int)this.FunctionId);
			if (menuConfigByFunctionId == null)
			{
				return false;
			}
			MenuData menuData = new MenuData(menuConfigByFunctionId.Value);
			this.IsDetailVisible = (!this.IsDetailVisible && menuData.HasDetailText());
			base.GetItem(4).SetUIActive(this.IsDetailVisible);
			return false;
		}

		// Token: 0x06038FF2 RID: 233458 RVA: 0x00FF6E10 File Offset: 0x00FF5010
		[NullableContext(1)]
		private int GetCurrentIndex(MenuData menuData)
		{
			int currentValueSafely = GameSettingsManager.Instance.GetCurrentValueSafely(this.FunctionId, menuData.OptionsDefault, true);
			for (int i = 0; i < menuData.OptionsValueList.Count; i++)
			{
				if (menuData.OptionsValueList[i] == currentValueSafely)
				{
					return i;
				}
			}
			for (int j = 0; j < menuData.OptionsValueList.Count; j++)
			{
				if (menuData.OptionsValueList[j] == menuData.OptionsDefault)
				{
					return j;
				}
			}
			return 0;
		}

		// Token: 0x06038FF3 RID: 233459 RVA: 0x00FF6E89 File Offset: 0x00FF5089
		private void OnLeftClick()
		{
			this.ChangeValue(-1);
		}

		// Token: 0x06038FF4 RID: 233460 RVA: 0x00FF6E92 File Offset: 0x00FF5092
		private void OnRightClick()
		{
			this.ChangeValue(1);
		}

		// Token: 0x06038FF5 RID: 233461 RVA: 0x00FF6E9C File Offset: 0x00FF509C
		private void ChangeValue(int direction)
		{
			MenuConfig? menuConfigByFunctionId = MenuBaseConfig.Instance.GetMenuConfigByFunctionId((int)this.FunctionId);
			if (menuConfigByFunctionId == null)
			{
				return;
			}
			MenuData menuData = new MenuData(menuConfigByFunctionId.Value);
			int num = this.GetCurrentIndex(menuData) + direction;
			if (num < 0 || num >= menuData.OptionsValueList.Count)
			{
				return;
			}
			MenuController.Instance.HandleFireSaveMenuChange(menuData, (float)menuData.OptionsValueList[num]);
			this.Refresh(this.FunctionId);
		}

		// Token: 0x0401DFF9 RID: 122873
		private EFunction FunctionId;

		// Token: 0x0401DFFA RID: 122874
		[Nullable(2)]
		private UUIExtendToggle DetailToggle;

		// Token: 0x0401DFFB RID: 122875
		private bool IsDetailVisible;

		// Token: 0x0200B64B RID: 46667
		private class EComponents
		{
			// Token: 0x04038641 RID: 230977
			public const int Title = 0;

			// Token: 0x04038642 RID: 230978
			public const int Value = 1;

			// Token: 0x04038643 RID: 230979
			public const int LeftButton = 2;

			// Token: 0x04038644 RID: 230980
			public const int RightButton = 3;

			// Token: 0x04038645 RID: 230981
			public const int DetailItem = 4;

			// Token: 0x04038646 RID: 230982
			public const int DetailText = 5;

			// Token: 0x04038647 RID: 230983
			public const int DetailSprite = 6;

			// Token: 0x04038648 RID: 230984
			public const int RecommendIcon = 7;

			// Token: 0x04038649 RID: 230985
			public const int DetailToggleTransition = 8;
		}
	}
}
