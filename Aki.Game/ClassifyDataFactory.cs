using System;
using System.Runtime.CompilerServices;

// Token: 0x0200285F RID: 10335
[NullableContext(1)]
[Nullable(0)]
public static class ClassifyDataFactory
{
	// Token: 0x06015496 RID: 87190 RVA: 0x0056007A File Offset: 0x0055E27A
	public static RoleFavorActionClassifyData CreateClassifyData(string titleTableId, EFavorTabType favorTabType, int roleId, EFavorActionType typeParam)
	{
		if (favorTabType == EFavorTabType.Action)
		{
			return new RoleFavorActionClassifyData(titleTableId, roleId, typeParam);
		}
		throw new Exception("不支持的好感度类型");
	}

	// Token: 0x06015497 RID: 87191 RVA: 0x00560093 File Offset: 0x0055E293
	public static RoleFavorExperienceClassifyData CreateClassifyData(string titleTableId, EFavorTabType favorTabType, int roleId, EFavorExperienceType typeParam)
	{
		if (favorTabType == EFavorTabType.Experience)
		{
			return new RoleFavorExperienceClassifyData(titleTableId, roleId, typeParam);
		}
		throw new Exception("不支持的好感度类型");
	}

	// Token: 0x06015498 RID: 87192 RVA: 0x005600AC File Offset: 0x0055E2AC
	public static RoleFavorPreciousItemClassifyData CreateClassifyData(string titleTableId, EFavorTabType favorTabType, int roleId)
	{
		if (favorTabType == EFavorTabType.PreciousItem)
		{
			return new RoleFavorPreciousItemClassifyData(titleTableId, roleId);
		}
		throw new Exception("不支持的好感度类型");
	}

	// Token: 0x06015499 RID: 87193 RVA: 0x005600C4 File Offset: 0x0055E2C4
	public static RoleFavorVoiceClassifyData CreateClassifyData(string titleTableId, EFavorTabType favorTabType, int roleId, EFavorVoiceType typeParam)
	{
		if (favorTabType == EFavorTabType.Voice)
		{
			return new RoleFavorVoiceClassifyData(titleTableId, roleId, typeParam);
		}
		throw new Exception("不支持的好感度类型");
	}

	// Token: 0x0601549A RID: 87194 RVA: 0x005600DC File Offset: 0x0055E2DC
	public static RoleFavorClassifyDataBase CreateClassifyData(string titleTableId, EFavorTabType favorTabType, int roleId, [Nullable(2)] object typeParam = null)
	{
		switch (favorTabType)
		{
		case EFavorTabType.Voice:
			return new RoleFavorVoiceClassifyData(titleTableId, roleId, (EFavorVoiceType)typeParam);
		case EFavorTabType.Experience:
			return new RoleFavorExperienceClassifyData(titleTableId, roleId, (EFavorExperienceType)typeParam);
		case EFavorTabType.Action:
			return new RoleFavorActionClassifyData(titleTableId, roleId, (EFavorActionType)typeParam);
		case EFavorTabType.PreciousItem:
			return new RoleFavorPreciousItemClassifyData(titleTableId, roleId);
		default:
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Role;
			ELogAuthor author = ELogAuthor.LRC;
			string message = "不支持的好感度类型";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("favorTabType", favorTabType);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			throw new Exception("不支持的好感度类型");
		}
		}
	}
}
