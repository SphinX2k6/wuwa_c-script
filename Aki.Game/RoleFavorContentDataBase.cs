using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02001DBE RID: 7614
[NullableContext(1)]
[Nullable(0)]
public abstract class RoleFavorContentDataBase : IStaticVariableResetter
{
	// Token: 0x06012E0F RID: 77327 RVA: 0x00589EAC File Offset: 0x005880AC
	static RoleFavorContentDataBase()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(RoleFavorContentDataBase.CreateStaticDefaultValue), new Action(RoleFavorContentDataBase.ResetStaticDefaultValue));
	}

	// Token: 0x06012E10 RID: 77328 RVA: 0x00589ECB File Offset: 0x005880CB
	public RoleFavorContentDataBase(int roleId)
	{
		this.RoleId = roleId;
		this.InstanceIdInternal = RoleFavorContentDataBase.IdCounter++;
	}

	// Token: 0x17001CA1 RID: 7329
	// (get) Token: 0x06012E11 RID: 77329
	public abstract int ConfigId { get; }

	// Token: 0x17001CA2 RID: 7330
	// (get) Token: 0x06012E12 RID: 77330
	public abstract int ConfigConGroupId { get; }

	// Token: 0x17001CA3 RID: 7331
	// (get) Token: 0x06012E13 RID: 77331
	public abstract string TitleTextId { get; }

	// Token: 0x17001CA4 RID: 7332
	// (get) Token: 0x06012E14 RID: 77332
	public abstract string ContentTextId { get; }

	// Token: 0x06012E15 RID: 77333
	protected abstract EFavorContentType GetFavorContentType();

	// Token: 0x17001CA5 RID: 7333
	// (get) Token: 0x06012E16 RID: 77334 RVA: 0x00589EED File Offset: 0x005880ED
	public int InstanceId
	{
		get
		{
			return this.InstanceIdInternal;
		}
	}

	// Token: 0x17001CA6 RID: 7334
	// (get) Token: 0x06012E17 RID: 77335 RVA: 0x00589EF5 File Offset: 0x005880F5
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

	// Token: 0x17001CA7 RID: 7335
	// (get) Token: 0x06012E18 RID: 77336 RVA: 0x00589F24 File Offset: 0x00588124
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

	// Token: 0x17001CA8 RID: 7336
	// (get) Token: 0x06012E19 RID: 77337 RVA: 0x00589F53 File Offset: 0x00588153
	public EFavorContentType FavorContentType
	{
		get
		{
			return this.GetFavorContentType();
		}
	}

	// Token: 0x06012E1A RID: 77338 RVA: 0x00589F5B File Offset: 0x0058815B
	public static void CreateStaticDefaultValue()
	{
		RoleFavorContentDataBase.IdCounter = 0;
	}

	// Token: 0x06012E1B RID: 77339 RVA: 0x00589F63 File Offset: 0x00588163
	public static void ResetStaticDefaultValue()
	{
		RoleFavorContentDataBase.IdCounter = 0;
	}

	// Token: 0x0400A2AC RID: 41644
	public int RoleId;

	// Token: 0x0400A2AD RID: 41645
	private readonly int InstanceIdInternal;

	// Token: 0x0400A2AE RID: 41646
	private static int IdCounter;
}
