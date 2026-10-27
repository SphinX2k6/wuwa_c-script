using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02002843 RID: 10307
[NullableContext(1)]
[Nullable(0)]
public abstract class RoleFavorContentDataBase : IStaticVariableResetter
{
	// Token: 0x06015411 RID: 87057 RVA: 0x0055F150 File Offset: 0x0055D350
	static RoleFavorContentDataBase()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(RoleFavorContentDataBase.CreateStaticDefaultValue), new Action(RoleFavorContentDataBase.ResetStaticDefaultValue));
	}

	// Token: 0x06015412 RID: 87058 RVA: 0x0055F16F File Offset: 0x0055D36F
	public RoleFavorContentDataBase(int roleId)
	{
		this.RoleId = roleId;
		this.InstanceIdInternal = RoleFavorContentDataBase.IdCounter++;
	}

	// Token: 0x17001C49 RID: 7241
	// (get) Token: 0x06015413 RID: 87059
	public abstract int ConfigId { get; }

	// Token: 0x17001C4A RID: 7242
	// (get) Token: 0x06015414 RID: 87060
	public abstract int ConfigConGroupId { get; }

	// Token: 0x17001C4B RID: 7243
	// (get) Token: 0x06015415 RID: 87061
	public abstract string TitleTextId { get; }

	// Token: 0x17001C4C RID: 7244
	// (get) Token: 0x06015416 RID: 87062
	public abstract string ContentTextId { get; }

	// Token: 0x06015417 RID: 87063
	protected abstract EFavorContentType GetFavorContentType();

	// Token: 0x17001C4D RID: 7245
	// (get) Token: 0x06015418 RID: 87064 RVA: 0x0055F191 File Offset: 0x0055D391
	public int InstanceId
	{
		get
		{
			return this.InstanceIdInternal;
		}
	}

	// Token: 0x17001C4E RID: 7246
	// (get) Token: 0x06015419 RID: 87065 RVA: 0x0055F199 File Offset: 0x0055D399
	public string Title
	{
		get
		{
			if (this.TitleTextId == "")
			{
				return "";
			}
			return ConfigMultiTextLang.GetLocalTextNew(this.TitleTextId, null) ?? "";
		}
	}

	// Token: 0x17001C4F RID: 7247
	// (get) Token: 0x0601541A RID: 87066 RVA: 0x0055F1C8 File Offset: 0x0055D3C8
	public string Content
	{
		get
		{
			if (this.ContentTextId == "")
			{
				return "";
			}
			return ConfigMultiTextLang.GetLocalTextNew(this.ContentTextId, null) ?? "";
		}
	}

	// Token: 0x17001C50 RID: 7248
	// (get) Token: 0x0601541B RID: 87067 RVA: 0x0055F1F7 File Offset: 0x0055D3F7
	public EFavorContentType FavorContentType
	{
		get
		{
			return this.GetFavorContentType();
		}
	}

	// Token: 0x0601541C RID: 87068 RVA: 0x0055F1FF File Offset: 0x0055D3FF
	public static void CreateStaticDefaultValue()
	{
		RoleFavorContentDataBase.IdCounter = 0;
	}

	// Token: 0x0601541D RID: 87069 RVA: 0x0055F207 File Offset: 0x0055D407
	public static void ResetStaticDefaultValue()
	{
		RoleFavorContentDataBase.IdCounter = 0;
	}

	// Token: 0x04009EC3 RID: 40643
	public int RoleId;

	// Token: 0x04009EC4 RID: 40644
	private readonly int InstanceIdInternal;

	// Token: 0x04009EC5 RID: 40645
	private static int IdCounter;
}
