using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.TotalTopUp
{
	// Token: 0x02005FA3 RID: 24483
	[NullableContext(1)]
	[Nullable(0)]
	public class TotalTopUpPickRoleRolePanel : UiPanelBase
	{
		// Token: 0x0603E17B RID: 254331 RVA: 0x00EFE6A8 File Offset: 0x00EFC8A8
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUIText)),
				new ValueTuple<int, Type>(4, typeof(UUISprite)),
				new ValueTuple<int, Type>(5, typeof(UUIText)),
				new ValueTuple<int, Type>(6, typeof(UUIItem))
			};
		}

		// Token: 0x0603E17C RID: 254332 RVA: 0x00EFE75C File Offset: 0x00EFC95C
		protected override UniTask OnBeforeStartAsync()
		{
			TotalTopUpPickRoleRolePanel.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<TotalTopUpPickRoleRolePanel.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603E17D RID: 254333 RVA: 0x00EFE7A0 File Offset: 0x00EFC9A0
		public void Refresh(TotalTopUpPickRoleViewModel viewModel)
		{
			if (viewModel.CurrentRoleId <= 0)
			{
				return;
			}
			this.CurrentRoleId = viewModel.CurrentRoleId;
			this.PreviewRoleCallback = new Action(viewModel.PreviewAllRoles);
			this.RefreshRoleSpineItem(viewModel.CurrentRoleId);
			RoleDescribeComponent descComponent = this.DescComponent;
			if (descComponent != null)
			{
				descComponent.Update(viewModel.CurrentRoleId, false);
			}
			int currentRoleChainNum = viewModel.CurrentRoleChainNum;
			UUIItem item = base.GetItem(6);
			if (item != null)
			{
				item.SetUIActive(!viewModel.CurrentRoleOwned);
			}
			UUIItem item2 = base.GetItem(2);
			if (item2 != null)
			{
				item2.SetUIActive(viewModel.CurrentRoleOwned);
			}
			this.ApplyFullChainChangeColor(viewModel.CurrentIsFullChain);
			UUIText text = base.GetText(5);
			if (text == null)
			{
				return;
			}
			text.SetText(currentRoleChainNum.ToString(), true);
		}

		// Token: 0x0603E17E RID: 254334 RVA: 0x00EFE85C File Offset: 0x00EFCA5C
		private UniTask RefreshRoleSpineItem(int roleId)
		{
			TotalTopUpPickRoleRolePanel.<RefreshRoleSpineItem>d__7 <RefreshRoleSpineItem>d__;
			<RefreshRoleSpineItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshRoleSpineItem>d__.<>4__this = this;
			<RefreshRoleSpineItem>d__.roleId = roleId;
			<RefreshRoleSpineItem>d__.<>1__state = -1;
			<RefreshRoleSpineItem>d__.<>t__builder.Start<TotalTopUpPickRoleRolePanel.<RefreshRoleSpineItem>d__7>(ref <RefreshRoleSpineItem>d__);
			return <RefreshRoleSpineItem>d__.<>t__builder.Task;
		}

		// Token: 0x0603E17F RID: 254335 RVA: 0x00EFE8A8 File Offset: 0x00EFCAA8
		private void ShowCurrentRole(int currentRoleId)
		{
			foreach (KeyValuePair<int, SpineRoleGachaPoolItem> keyValuePair in this.SpineItemMap)
			{
				int key = keyValuePair.Key;
				SpineRoleGachaPoolItem value = keyValuePair.Value;
				bool flag = key == currentRoleId;
				value.SetUiActive(flag);
				if (flag)
				{
					value.RefreshAnimation();
				}
			}
		}

		// Token: 0x0603E180 RID: 254336 RVA: 0x00EFE918 File Offset: 0x00EFCB18
		private void ApplyFullChainChangeColor(bool isChange)
		{
			UUIText text = base.GetText(3);
			if (text != null)
			{
				UUIItem uuiitem = text;
				FColor? fcolor = new FColor?(text.changeColor);
				uuiitem.SetChangeColor(isChange, fcolor);
			}
			UUISprite sprite = base.GetSprite(4);
			if (sprite != null)
			{
				UUIItem uuiitem2 = sprite;
				FColor? fcolor = new FColor?(sprite.changeColor);
				uuiitem2.SetChangeColor(isChange, fcolor);
			}
			UUIText text2 = base.GetText(5);
			if (text2 != null)
			{
				UUIItem uuiitem3 = text2;
				FColor? fcolor = new FColor?(text2.changeColor);
				uuiitem3.SetChangeColor(isChange, fcolor);
			}
		}

		// Token: 0x040206F3 RID: 132851
		private readonly Dictionary<int, SpineRoleGachaPoolItem> SpineItemMap = new Dictionary<int, SpineRoleGachaPoolItem>();

		// Token: 0x040206F4 RID: 132852
		[Nullable(2)]
		private RoleDescribeComponent DescComponent;

		// Token: 0x040206F5 RID: 132853
		private int CurrentRoleId;

		// Token: 0x040206F6 RID: 132854
		[Nullable(2)]
		private Action PreviewRoleCallback;
	}
}
