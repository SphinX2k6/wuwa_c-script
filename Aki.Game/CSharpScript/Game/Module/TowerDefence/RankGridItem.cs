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
	// Token: 0x02004B1A RID: 19226
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RankGridItem : GridProxyAbstract<TowerDefenseRankRoleData>
	{
		// Token: 0x06031CDE RID: 203998 RVA: 0x00B8F9CC File Offset: 0x00B8DBCC
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

		// Token: 0x06031CDF RID: 203999 RVA: 0x00B8FA98 File Offset: 0x00B8DC98
		protected override UniTask OnBeforeStartAsync()
		{
			RankGridItem.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RankGridItem.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06031CE0 RID: 204000 RVA: 0x00B8FADC File Offset: 0x00B8DCDC
		private void RefreshPosTexture()
		{
			UUITexture texture = base.GetTexture(2);
			if (this.Data != null)
			{
				texture.SetUIActive(this.Data.IsOnline);
				if (this.Data.IsOnline)
				{
					string posTexture = TowerDefenseRankItemUtil.Instance.GetPosTexture(this.Data.Pos);
					string resourcePath = UiResourceConfig.Instance.GetResourcePath(posTexture);
					base.SetTextureByPath(resourcePath, texture, null, null);
					return;
				}
			}
			else
			{
				texture.SetUIActive(false);
			}
		}

		// Token: 0x06031CE1 RID: 204001 RVA: 0x00B8FB54 File Offset: 0x00B8DD54
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

		// Token: 0x06031CE2 RID: 204002 RVA: 0x00B8FC4C File Offset: 0x00B8DE4C
		private void RefreshPhantomIcon()
		{
			TowerDefencePhantom? towerDefensePhantomById = InstanceDungeonConfig.Instance.GetTowerDefensePhantomById(this.Data.PhantomId);
			base.SetTextureByPath(PhantomBattleConfig.Instance.GetPhantomItemById(towerDefensePhantomById.Value.PhantomItemId).Value.IconMiddle, base.GetTexture(1), null, null);
		}

		// Token: 0x06031CE3 RID: 204003 RVA: 0x00B8FCB0 File Offset: 0x00B8DEB0
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
				this.RefreshPosTexture();
				this.RefreshItemGrid();
				this.RefreshPhantomIcon();
			}
		}

		// Token: 0x0401A942 RID: 108866
		private TowerDefenseRankRoleData Data;

		// Token: 0x0401A943 RID: 108867
		private SmallItemGrid ItemGrid;

		// Token: 0x0401A944 RID: 108868
		private CharacterSmallItemGrid CacheGridData;

		// Token: 0x0200AC9D RID: 44189
		[NullableContext(0)]
		private class ERankGridItem
		{
			// Token: 0x0403472A RID: 214826
			public const int GridItem = 0;

			// Token: 0x0403472B RID: 214827
			public const int PhantomTexture = 1;

			// Token: 0x0403472C RID: 214828
			public const int PosTexture = 2;

			// Token: 0x0403472D RID: 214829
			public const int ContentItem = 3;

			// Token: 0x0403472E RID: 214830
			public const int EmptyItem = 4;
		}
	}
}
