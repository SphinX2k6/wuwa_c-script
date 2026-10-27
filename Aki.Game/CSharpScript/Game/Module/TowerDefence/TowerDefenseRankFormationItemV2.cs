using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.Skin;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.TowerDefence
{
	// Token: 0x02004B28 RID: 19240
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class TowerDefenseRankFormationItemV2 : GridProxyAbstract<TowerDefenseRankRoleData>
	{
		// Token: 0x06031D53 RID: 204115 RVA: 0x00B9187C File Offset: 0x00B8FA7C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 5;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06031D54 RID: 204116 RVA: 0x00B91948 File Offset: 0x00B8FB48
		protected override UniTask OnBeforeStartAsync()
		{
			TowerDefenseRankFormationItemV2.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<TowerDefenseRankFormationItemV2.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06031D55 RID: 204117 RVA: 0x00B9198C File Offset: 0x00B8FB8C
		private void RefreshOnlineKey()
		{
			UUITexture texture = base.GetTexture(2);
			if (this.Data != null && this.Data.IsOnline)
			{
				texture.SetUIActive(true);
				string posTexture = TowerDefenseRankItemUtil.Instance.GetPosTexture(this.Data.Pos);
				string resourcePath = UiResourceConfig.Instance.GetResourcePath(posTexture);
				base.SetTextureByPath(resourcePath, texture, null, null);
				return;
			}
			texture.SetUIActive(false);
		}

		// Token: 0x06031D56 RID: 204118 RVA: 0x00B919FC File Offset: 0x00B8FBFC
		private void RefreshItemGrid()
		{
			RoleSkin? roleSkinConfig = SkinConfig.Instance.GetRoleSkinConfig(this.Data.RoleSkinId);
			RoleInfo? roleConfig = RoleConfig.Instance.GetRoleConfig(roleSkinConfig.Value.RoleId);
			if (this.CacheGridData == null)
			{
				this.CacheGridData = new CharacterSmallItemGrid
				{
					Data = null
				};
			}
			this.CacheGridData.ItemConfigId = new int?(roleSkinConfig.Value.RoleId);
			this.CacheGridData.SkinId = new int?(this.Data.RoleSkinId);
			this.CacheGridData.BottomTextId = "Text_LevelShow_Text";
			this.CacheGridData.BottomTextParameter = new object[]
			{
				this.Data.RoleLevel
			};
			this.CacheGridData.ElementId = new int?(roleConfig.Value.ElementId);
			this.ItemGrid.Apply<CharacterSmallItemGrid>(this.CacheGridData);
		}

		// Token: 0x06031D57 RID: 204119 RVA: 0x00B91AF4 File Offset: 0x00B8FCF4
		private void RefreshPhantomIcon()
		{
			TowerDefencePhantom? towerDefensePhantomById = InstanceDungeonConfig.Instance.GetTowerDefensePhantomById(this.Data.PhantomId);
			base.SetTextureByPath(PhantomBattleConfig.Instance.GetPhantomItemById(towerDefensePhantomById.Value.PhantomItemId).Value.IconMiddle, base.GetTexture(1), null, null);
		}

		// Token: 0x06031D58 RID: 204120 RVA: 0x00B91B58 File Offset: 0x00B8FD58
		public override void Refresh(TowerDefenseRankRoleData data, bool isSelected, int gridIndex)
		{
			this.Data = data;
			bool flag = !data.IsEmpty;
			UUIItem item = base.GetItem(3);
			if (item != null)
			{
				item.SetUIActive(flag);
			}
			UUIItem item2 = base.GetItem(4);
			if (item2 != null)
			{
				item2.SetUIActive(!flag);
			}
			if (flag)
			{
				this.RefreshOnlineKey();
				this.RefreshItemGrid();
				this.RefreshPhantomIcon();
			}
		}

		// Token: 0x0401A97B RID: 108923
		private TowerDefenseRankRoleData Data;

		// Token: 0x0401A97C RID: 108924
		private SmallItemGrid ItemGrid;

		// Token: 0x0401A97D RID: 108925
		[Nullable(2)]
		private CharacterSmallItemGrid CacheGridData;

		// Token: 0x0200ACB7 RID: 44215
		[NullableContext(0)]
		private class EFormationItemComponent
		{
			// Token: 0x04034797 RID: 214935
			public const int RoleItem = 0;

			// Token: 0x04034798 RID: 214936
			public const int PhantomIconTex = 1;

			// Token: 0x04034799 RID: 214937
			public const int OnlineKeyTex = 2;

			// Token: 0x0403479A RID: 214938
			public const int FormationItem = 3;

			// Token: 0x0403479B RID: 214939
			public const int EmptyItem = 4;
		}
	}
}
