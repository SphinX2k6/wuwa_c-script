using System;
using System.Runtime.CompilerServices;

// Token: 0x02001DDA RID: 7642
[NullableContext(1)]
[Nullable(0)]
public static class ClassifyDataFactory
{
	// Token: 0x06012E94 RID: 77460 RVA: 0x0058ADD6 File Offset: 0x00588FD6
	public static RoleFavorActionClassifyData CreateClassifyData(string titleTableId, EFavorTabType favorTabType, int roleId, EFavorActionType typeParam)
	{
		if (favorTabType == EFavorTabType.Action)
		{
			return new RoleFavorActionClassifyData(titleTableId, roleId, typeParam);
		}
		throw new Exception("不支持的好感度类型");
	}

	// Token: 0x06012E95 RID: 77461 RVA: 0x0058ADEF File Offset: 0x00588FEF
	public static RoleFavorExperienceClassifyData CreateClassifyData(string titleTableId, EFavorTabType favorTabType, int roleId, EFavorExperienceType typeParam)
	{
		if (favorTabType == EFavorTabType.Experience)
		{
			return new RoleFavorExperienceClassifyData(titleTableId, roleId, typeParam);
		}
		throw new Exception("不支持的好感度类型");
	}

	// Token: 0x06012E96 RID: 77462 RVA: 0x0058AE08 File Offset: 0x00589008
	public static RoleFavorPreciousItemClassifyData CreateClassifyData(string titleTableId, EFavorTabType favorTabType, int roleId)
	{
		if (favorTabType == EFavorTabType.PreciousItem)
		{
			return new RoleFavorPreciousItemClassifyData(titleTableId, roleId);
		}
		throw new Exception("不支持的好感度类型");
	}

	// Token: 0x06012E97 RID: 77463 RVA: 0x0058AE20 File Offset: 0x00589020
	public static RoleFavorVoiceClassifyData CreateClassifyData(string titleTableId, EFavorTabType favorTabType, int roleId, EFavorVoiceType typeParam)
	{
		if (favorTabType == EFavorTabType.Voice)
		{
			return new RoleFavorVoiceClassifyData(titleTableId, roleId, typeParam);
		}
		throw new Exception("不支持的好感度类型");
	}

	// Token: 0x06012E98 RID: 77464 RVA: 0x0058AE38 File Offset: 0x00589038
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
