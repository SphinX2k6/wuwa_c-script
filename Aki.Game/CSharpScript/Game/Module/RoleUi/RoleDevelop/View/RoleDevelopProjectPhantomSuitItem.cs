using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.RoleUi.RoleDevelop.View
{
	// Token: 0x02003D0C RID: 15628
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RoleDevelopProjectPhantomSuitItem : GridProxyAbstract<RoleDevelopPhantomSuitData>
	{
		// Token: 0x06027FF7 RID: 163831 RVA: 0x00B3187C File Offset: 0x00B2FA7C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 5;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIVerticalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIButtonComponent));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(4, new Action(this.OnClickFetter));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06027FF8 RID: 163832 RVA: 0x00B31988 File Offset: 0x00B2FB88
		private void OnClickFetter()
		{
			bool showFastFilter = RoleModel.Instance.IsRoleOwned(this.Data.DevelopRoleId);
			PhantomBattleController.Instance.OpenPhantomBattleFetterView(this.Data.FetterGroupId, this.Data.DevelopRoleId, showFastFilter, this.Data.VisionFetterRecommendInfo.BuildFetterList()).Forget();
		}

		// Token: 0x06027FF9 RID: 163833 RVA: 0x00B319E4 File Offset: 0x00B2FBE4
		protected override UniTask OnBeforeStartAsync()
		{
			RoleDevelopProjectPhantomSuitItem.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RoleDevelopProjectPhantomSuitItem.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06027FFA RID: 163834 RVA: 0x00B31A28 File Offset: 0x00B2FC28
		public unsafe override void Refresh(RoleDevelopPhantomSuitData data, bool isSelected, int gridIndex)
		{
			this.Data = data;
			PhantomFetterGroup fetterGroupById = PhantomBattleConfig.Instance.GetFetterGroupById(data.FetterGroupId);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), fetterGroupById.FetterGroupName, Array.Empty<object>());
			bool flag = !string.IsNullOrEmpty(fetterGroupById.FetterElementPath);
			this.SuitItem.SetUiActive(flag);
			if (flag)
			{
				this.SuitItem.Update(new PhantomFetterGroup?(fetterGroupById));
			}
			List<RoleDevelopPhantomVisionSuitItemData> list = new List<RoleDevelopPhantomVisionSuitItemData>();
			if (data.FirstVisionMonsterId != null)
			{
				IReadOnlyList<PhantomItem> phantomItemByMonsterId = PhantomBattleConfig.Instance.GetPhantomItemByMonsterId(data.FirstVisionMonsterId.Value);
				if (phantomItemByMonsterId != null && phantomItemByMonsterId.Count > 0 && Array.IndexOf<int>(phantomItemByMonsterId[0].FetterGroup(), data.FetterGroupId) >= 0)
				{
					RoleDevelopPhantomVisionSuitItemData item = RoleDevelopUtil.CreateFetterGroupVisionSuitItem(data.FetterGroupId, data.DevelopRoleId, data.FirstVisionMonsterId.Value);
					list.Add(item);
				}
			}
			RoleDevPhantomJumpGroup? phantomJumpGroupConfig = RoleDevConfig.Instance.GetPhantomJumpGroupConfig(data.FetterGroupId);
			if (phantomJumpGroupConfig != null)
			{
				Span<int> phantomJumpIdBytes = phantomJumpGroupConfig.Value.GetPhantomJumpIdBytes();
				for (int i = 0; i < phantomJumpIdBytes.Length; i++)
				{
					RoleDevelopPhantomVisionSuitItemData roleDevelopPhantomVisionSuitItemData = RoleDevelopUtil.CreateDungeonVisionSuitItem(*phantomJumpIdBytes[i], data.DevelopRoleId);
					if (roleDevelopPhantomVisionSuitItemData != null)
					{
						list.Add(roleDevelopPhantomVisionSuitItemData);
					}
				}
			}
			this.VisionSuitLayout.RefreshByData(list, null, false);
			base.GetButton(4).RootUIComp.Get().SetUIActive(data.IsNeedFetterButton.GetValueOrDefault());
		}

		// Token: 0x06027FFB RID: 163835 RVA: 0x00B31BBF File Offset: 0x00B2FDBF
		public override object GetKey(RoleDevelopPhantomSuitData data, int gridIndex)
		{
			return data.FetterGroupId;
		}

		// Token: 0x06027FFC RID: 163836 RVA: 0x00B31BCC File Offset: 0x00B2FDCC
		private RoleDevelopProjectPhantomVisionSuitItem CreateVisionSuitItem()
		{
			return new RoleDevelopProjectPhantomVisionSuitItem();
		}

		// Token: 0x04015C76 RID: 89206
		[Nullable(2)]
		private RoleDevelopPhantomSuitData Data;

		// Token: 0x04015C77 RID: 89207
		private VisionFetterSuitItem SuitItem;

		// Token: 0x04015C78 RID: 89208
		private GenericLayout<RoleDevelopProjectPhantomVisionSuitItem, RoleDevelopPhantomVisionSuitItemData> VisionSuitLayout;

		// Token: 0x020098DB RID: 39131
		[NullableContext(0)]
		private enum EComponentType
		{
			// Token: 0x0402FAB6 RID: 195254
			PanelElementIcon,
			// Token: 0x0402FAB7 RID: 195255
			TxtSuitName,
			// Token: 0x0402FAB8 RID: 195256
			TxtUseRate,
			// Token: 0x0402FAB9 RID: 195257
			PanelVisionSuitLayout,
			// Token: 0x0402FABA RID: 195258
			ButtonFetter
		}
	}
}
