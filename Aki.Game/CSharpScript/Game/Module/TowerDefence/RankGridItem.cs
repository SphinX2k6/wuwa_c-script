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
	// Token: 0x02003AC2 RID: 15042
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RankGridItem : GridProxyAbstract<TowerDefenseRankRoleData>
	{
		// Token: 0x06026A6E RID: 158318 RVA: 0x00AD3A30 File Offset: 0x00AD1C30
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

		// Token: 0x06026A6F RID: 158319 RVA: 0x00AD3AFC File Offset: 0x00AD1CFC
		protected override UniTask OnBeforeStartAsync()
		{
			RankGridItem.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RankGridItem.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06026A70 RID: 158320 RVA: 0x00AD3B40 File Offset: 0x00AD1D40
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

		// Token: 0x06026A71 RID: 158321 RVA: 0x00AD3BB8 File Offset: 0x00AD1DB8
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

		// Token: 0x06026A72 RID: 158322 RVA: 0x00AD3CB0 File Offset: 0x00AD1EB0
		private void RefreshPhantomIcon()
		{
			TowerDefencePhantom? towerDefensePhantomById = InstanceDungeonConfig.Instance.GetTowerDefensePhantomById(this.Data.PhantomId);
			base.SetTextureByPath(PhantomBattleConfig.Instance.GetPhantomItemById(towerDefensePhantomById.Value.PhantomItemId).Value.IconMiddle, base.GetTexture(1), null, null);
		}

		// Token: 0x06026A73 RID: 158323 RVA: 0x00AD3D14 File Offset: 0x00AD1F14
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

		// Token: 0x04015294 RID: 86676
		private TowerDefenseRankRoleData Data;

		// Token: 0x04015295 RID: 86677
		private SmallItemGrid ItemGrid;

		// Token: 0x04015296 RID: 86678
		private CharacterSmallItemGrid CacheGridData;

		// Token: 0x020096BD RID: 38589
		[NullableContext(0)]
		private class ERankGridItem
		{
			// Token: 0x0402F0DB RID: 192731
			public const int GridItem = 0;

			// Token: 0x0402F0DC RID: 192732
			public const int PhantomTexture = 1;

			// Token: 0x0402F0DD RID: 192733
			public const int PosTexture = 2;

			// Token: 0x0402F0DE RID: 192734
			public const int ContentItem = 3;

			// Token: 0x0402F0DF RID: 192735
			public const int EmptyItem = 4;
		}
	}
}
