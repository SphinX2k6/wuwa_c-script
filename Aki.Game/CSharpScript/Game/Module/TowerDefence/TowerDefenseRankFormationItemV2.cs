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
	// Token: 0x02003AD0 RID: 15056
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class TowerDefenseRankFormationItemV2 : GridProxyAbstract<TowerDefenseRankRoleData>
	{
		// Token: 0x06026AE3 RID: 158435 RVA: 0x00AD58E0 File Offset: 0x00AD3AE0
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

		// Token: 0x06026AE4 RID: 158436 RVA: 0x00AD59AC File Offset: 0x00AD3BAC
		protected override UniTask OnBeforeStartAsync()
		{
			TowerDefenseRankFormationItemV2.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<TowerDefenseRankFormationItemV2.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06026AE5 RID: 158437 RVA: 0x00AD59F0 File Offset: 0x00AD3BF0
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

		// Token: 0x06026AE6 RID: 158438 RVA: 0x00AD5A60 File Offset: 0x00AD3C60
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

		// Token: 0x06026AE7 RID: 158439 RVA: 0x00AD5B58 File Offset: 0x00AD3D58
		private void RefreshPhantomIcon()
		{
			TowerDefencePhantom? towerDefensePhantomById = InstanceDungeonConfig.Instance.GetTowerDefensePhantomById(this.Data.PhantomId);
			base.SetTextureByPath(PhantomBattleConfig.Instance.GetPhantomItemById(towerDefensePhantomById.Value.PhantomItemId).Value.IconMiddle, base.GetTexture(1), null, null);
		}

		// Token: 0x06026AE8 RID: 158440 RVA: 0x00AD5BBC File Offset: 0x00AD3DBC
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

		// Token: 0x040152CD RID: 86733
		private TowerDefenseRankRoleData Data;

		// Token: 0x040152CE RID: 86734
		private SmallItemGrid ItemGrid;

		// Token: 0x040152CF RID: 86735
		[Nullable(2)]
		private CharacterSmallItemGrid CacheGridData;

		// Token: 0x020096D7 RID: 38615
		[NullableContext(0)]
		private class EFormationItemComponent
		{
			// Token: 0x0402F148 RID: 192840
			public const int RoleItem = 0;

			// Token: 0x0402F149 RID: 192841
			public const int PhantomIconTex = 1;

			// Token: 0x0402F14A RID: 192842
			public const int OnlineKeyTex = 2;

			// Token: 0x0402F14B RID: 192843
			public const int FormationItem = 3;

			// Token: 0x0402F14C RID: 192844
			public const int EmptyItem = 4;
		}
	}
}
