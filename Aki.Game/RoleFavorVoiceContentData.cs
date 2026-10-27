using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02002844 RID: 10308
[NullableContext(1)]
[Nullable(0)]
public class RoleFavorVoiceContentData : RoleFavorContentDataBase
{
	// Token: 0x0601541E RID: 87070 RVA: 0x0055F20F File Offset: 0x0055D40F
	public RoleFavorVoiceContentData(int roleId, EFavorVoiceType favorVoiceParamType, FavorWord configData) : base(roleId)
	{
		this.FavorVoiceParamType = favorVoiceParamType;
		this.ConfigData = configData;
	}

	// Token: 0x17001C51 RID: 7249
	// (get) Token: 0x0601541F RID: 87071 RVA: 0x0055F22D File Offset: 0x0055D42D
	public override int ConfigId
	{
		get
		{
			return this.ConfigData.Id;
		}
	}

	// Token: 0x17001C52 RID: 7250
	// (get) Token: 0x06015420 RID: 87072 RVA: 0x0055F23A File Offset: 0x0055D43A
	public override int ConfigConGroupId
	{
		get
		{
			return this.ConfigData.CondGroupId;
		}
	}

	// Token: 0x17001C53 RID: 7251
	// (get) Token: 0x06015421 RID: 87073 RVA: 0x0055F247 File Offset: 0x0055D447
	public override string TitleTextId
	{
		get
		{
			return this.ConfigData.Title;
		}
	}

	// Token: 0x17001C54 RID: 7252
	// (get) Token: 0x06015422 RID: 87074 RVA: 0x0055F254 File Offset: 0x0055D454
	public override string ContentTextId
	{
		get
		{
			return this.ConfigData.Content;
		}
	}

	// Token: 0x06015423 RID: 87075 RVA: 0x0055F261 File Offset: 0x0055D461
	protected override EFavorContentType GetFavorContentType()
	{
		return EFavorContentType.Voice;
	}

	// Token: 0x04009EC6 RID: 40646
	public EFavorVoiceType FavorVoiceParamType = EFavorVoiceType.FavorNatureVoice;

	// Token: 0x04009EC7 RID: 40647
	public FavorWord ConfigData;
}
