using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.RoleUi.RoleDevelop.View
{
	// Token: 0x02004D43 RID: 19779
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RoleDevelopProjectPhantomSuitItem : GridProxyAbstract<RoleDevelopPhantomSuitData>
	{
		// Token: 0x0603319E RID: 209310 RVA: 0x00BE8AD4 File Offset: 0x00BE6CD4
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

		// Token: 0x0603319F RID: 209311 RVA: 0x00BE8BE0 File Offset: 0x00BE6DE0
		private void OnClickFetter()
		{
			bool showFastFilter = RoleModel.Instance.IsRoleOwned(this.Data.DevelopRoleId);
			PhantomBattleController.Instance.OpenPhantomBattleFetterView(this.Data.FetterGroupId, this.Data.DevelopRoleId, showFastFilter, this.Data.VisionFetterRecommendInfo.BuildFetterList()).Forget();
		}

		// Token: 0x060331A0 RID: 209312 RVA: 0x00BE8C3C File Offset: 0x00BE6E3C
		protected override UniTask OnBeforeStartAsync()
		{
			RoleDevelopProjectPhantomSuitItem.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RoleDevelopProjectPhantomSuitItem.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060331A1 RID: 209313 RVA: 0x00BE8C80 File Offset: 0x00BE6E80
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
				if (phantomItemByMonsterId != null && phantomItemByMonsterId.Count > 0 && phantomItemByMonsterId[0].FetterGroup().Contains(data.FetterGroupId))
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

		// Token: 0x060331A2 RID: 209314 RVA: 0x00BE8E16 File Offset: 0x00BE7016
		public override object GetKey(RoleDevelopPhantomSuitData data, int gridIndex)
		{
			return data.FetterGroupId;
		}

		// Token: 0x060331A3 RID: 209315 RVA: 0x00BE8E23 File Offset: 0x00BE7023
		private RoleDevelopProjectPhantomVisionSuitItem CreateVisionSuitItem()
		{
			return new RoleDevelopProjectPhantomVisionSuitItem();
		}

		// Token: 0x0401B2A6 RID: 111270
		[Nullable(2)]
		private RoleDevelopPhantomSuitData Data;

		// Token: 0x0401B2A7 RID: 111271
		private VisionFetterSuitItem SuitItem;

		// Token: 0x0401B2A8 RID: 111272
		private GenericLayout<RoleDevelopProjectPhantomVisionSuitItem, RoleDevelopPhantomVisionSuitItemData> VisionSuitLayout;

		// Token: 0x0200AEA8 RID: 44712
		[NullableContext(0)]
		public static class EComponentType
		{
			// Token: 0x04035098 RID: 217240
			public const int PanelElementIcon = 0;

			// Token: 0x04035099 RID: 217241
			public const int TxtSuitName = 1;

			// Token: 0x0403509A RID: 217242
			public const int TxtUseRate = 2;

			// Token: 0x0403509B RID: 217243
			public const int PanelVisionSuitLayout = 3;

			// Token: 0x0403509C RID: 217244
			public const int ButtonFetter = 4;
		}
	}
}
