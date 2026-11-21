using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x0200204E RID: 8270
[NullableContext(2)]
[Nullable(0)]
public class SurvivorsRogueCardDataFactory
{
	// Token: 0x06014733 RID: 83763 RVA: 0x005F7B04 File Offset: 0x005F5D04
	public static SurvivorsRogueItemCard CreateGeneralItem(int itemId)
	{
		SurvivorsItem? survivorsItem = SurvivorsRogueConfig.Instance.GetSurvivorsItem(itemId);
		if (survivorsItem == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.SurvivorsRogue;
			ELogAuthor author = ELogAuthor.YYZ;
			string message = "[SurvivorsRogue] 无法创建对应卡片数据类,无道具配置";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Id", itemId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		return new SurvivorsRogueItemCard
		{
			Type = ESurvivorsRogueItemType.Normal,
			Id = itemId,
			Index = 0,
			QualityId = survivorsItem.Value.Quality,
			TitleId = survivorsItem.Value.Name,
			DescId = (survivorsItem.Value.Desc ?? "")
		};
	}

	// Token: 0x06014734 RID: 83764 RVA: 0x005F7BBC File Offset: 0x005F5DBC
	public static SurvivorsRogueCharacterCard CreateGeneralCharacter(int roleId)
	{
		SurvivorsRole? survivorsRole = SurvivorsRogueConfig.Instance.GetSurvivorsRole(roleId);
		if (survivorsRole == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.SurvivorsRogue;
			ELogAuthor author = ELogAuthor.YYZ;
			string message = "[SurvivorsRogue] 无法创建对应卡片数据类,无角色配置";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Id", roleId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		RoleDataBase roleDataById = RoleModel.Instance.GetRoleDataById(survivorsRole.Value.TrialRoleId, true);
		if (roleDataById == null)
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.SurvivorsRogue;
			ELogAuthor author2 = ELogAuthor.YYZ;
			string message2 = "[SurvivorsRogue] 无法创建对应卡片数据类,无试用角色数据";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("Id", roleId);
			instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			return null;
		}
		SurvivorsRoleEvolve? survivorsRoleDefaultEvolve = SurvivorsRogueConfig.Instance.GetSurvivorsRoleDefaultEvolve(roleId);
		if (survivorsRoleDefaultEvolve == null)
		{
			Log instance3 = Log.Instance;
			ELogModule module3 = ELogModule.SurvivorsRogue;
			ELogAuthor author3 = ELogAuthor.YYZ;
			string message3 = "[SurvivorsRogue] 无法创建对应卡片数据类,查找不到角色默认进化id";
			ValueTuple<string, object> valueTuple3 = new ValueTuple<string, object>("Id", roleId);
			instance3.Error(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple3));
			return null;
		}
		return new SurvivorsRogueCharacterCard
		{
			Type = ESurvivorsRogueItemType.Character,
			Id = roleId,
			Index = 0,
			QualityId = survivorsRoleDefaultEvolve.Value.Quality,
			TitleText = roleDataById.GetName(null),
			DescId = (survivorsRoleDefaultEvolve.Value.Describe ?? "")
		};
	}

	// Token: 0x06014735 RID: 83765 RVA: 0x005F7D0C File Offset: 0x005F5F0C
	public static SurvivorsRogueWeaponCard CreateGeneralWeapon(int weaponId)
	{
		SurvivorsWeapon? survivorsWeapon = SurvivorsRogueConfig.Instance.GetSurvivorsWeapon(weaponId);
		if (survivorsWeapon == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.SurvivorsRogue;
			ELogAuthor author = ELogAuthor.YYZ;
			string message = "[SurvivorsRogue] 无法创建对应卡片数据类,无武器配置";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Id", weaponId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		SurvivorsWeaponEvolve? survivorsWeaponDefaultEvolve = SurvivorsRogueConfig.Instance.GetSurvivorsWeaponDefaultEvolve(weaponId);
		if (survivorsWeaponDefaultEvolve == null)
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.SurvivorsRogue;
			ELogAuthor author2 = ELogAuthor.YYZ;
			string message2 = "[SurvivorsRogue] 无法创建对应卡片数据类,查找不到武器默认进化id";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("Id", weaponId);
			instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			return null;
		}
		return new SurvivorsRogueWeaponCard
		{
			Type = ESurvivorsRogueItemType.Weapon,
			Id = weaponId,
			Index = 0,
			QualityId = survivorsWeaponDefaultEvolve.Value.Quality,
			TitleId = survivorsWeapon.Value.Name,
			DescId = (survivorsWeaponDefaultEvolve.Value.Describe ?? "")
		};
	}
}
