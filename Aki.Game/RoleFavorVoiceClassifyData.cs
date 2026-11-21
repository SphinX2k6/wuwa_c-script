using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02001DBB RID: 7611
[NullableContext(1)]
[Nullable(0)]
public class RoleFavorVoiceClassifyData : RoleFavorClassifyDataBase
{
	// Token: 0x06012E03 RID: 77315 RVA: 0x00589CB0 File Offset: 0x00587EB0
	public RoleFavorVoiceClassifyData(string titleTableId, int roleId, EFavorVoiceType typeParam) : base(titleTableId, roleId)
	{
		this.TypeParam = typeParam;
	}

	// Token: 0x06012E04 RID: 77316 RVA: 0x00589CC8 File Offset: 0x00587EC8
	protected override EFavorTabType GetFavorTabType()
	{
		return EFavorTabType.Voice;
	}

	// Token: 0x06012E05 RID: 77317 RVA: 0x00589CCC File Offset: 0x00587ECC
	protected override void InitContentDataList()
	{
		this.ContentDataList.Clear();
		IReadOnlyList<FavorWord> favorWordConfig = RoleFavorConfig.Instance.GetFavorWordConfig(this.RoleId, (int)this.TypeParam);
		if (favorWordConfig == null)
		{
			return;
		}
		int count = favorWordConfig.Count;
		for (int i = 0; i < count; i++)
		{
			FavorWord config = favorWordConfig[i];
			this.ContentDataList.Add(this.CreateVoiceContentData(config));
		}
	}

	// Token: 0x06012E06 RID: 77318 RVA: 0x00589D2C File Offset: 0x00587F2C
	private RoleFavorVoiceContentData CreateVoiceContentData(FavorWord config)
	{
		return new RoleFavorVoiceContentData(this.RoleId, this.TypeParam, config);
	}

	// Token: 0x0400A2AA RID: 41642
	public EFavorVoiceType TypeParam = EFavorVoiceType.FavorNatureVoice;
}
