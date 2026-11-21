using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02001DBF RID: 7615
[NullableContext(1)]
[Nullable(0)]
public class RoleFavorVoiceContentData : RoleFavorContentDataBase
{
	// Token: 0x06012E1C RID: 77340 RVA: 0x00589F6B File Offset: 0x0058816B
	public RoleFavorVoiceContentData(int roleId, EFavorVoiceType favorVoiceParamType, FavorWord configData) : base(roleId)
	{
		this.FavorVoiceParamType = favorVoiceParamType;
		this.ConfigData = configData;
	}

	// Token: 0x17001CA9 RID: 7337
	// (get) Token: 0x06012E1D RID: 77341 RVA: 0x00589F89 File Offset: 0x00588189
	public override int ConfigId
	{
		get
		{
			return this.ConfigData.Id;
		}
	}

	// Token: 0x17001CAA RID: 7338
	// (get) Token: 0x06012E1E RID: 77342 RVA: 0x00589F96 File Offset: 0x00588196
	public override int ConfigConGroupId
	{
		get
		{
			return this.ConfigData.CondGroupId;
		}
	}

	// Token: 0x17001CAB RID: 7339
	// (get) Token: 0x06012E1F RID: 77343 RVA: 0x00589FA3 File Offset: 0x005881A3
	public override string TitleTextId
	{
		get
		{
			return this.ConfigData.Title;
		}
	}

	// Token: 0x17001CAC RID: 7340
	// (get) Token: 0x06012E20 RID: 77344 RVA: 0x00589FB0 File Offset: 0x005881B0
	public override string ContentTextId
	{
		get
		{
			return this.ConfigData.Content;
		}
	}

	// Token: 0x06012E21 RID: 77345 RVA: 0x00589FBD File Offset: 0x005881BD
	protected override EFavorContentType GetFavorContentType()
	{
		return EFavorContentType.Voice;
	}

	// Token: 0x0400A2AF RID: 41647
	public EFavorVoiceType FavorVoiceParamType = EFavorVoiceType.FavorNatureVoice;

	// Token: 0x0400A2B0 RID: 41648
	public FavorWord ConfigData;
}
