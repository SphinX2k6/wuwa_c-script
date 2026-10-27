using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02002840 RID: 10304
[NullableContext(1)]
[Nullable(0)]
public class RoleFavorVoiceClassifyData : RoleFavorClassifyDataBase
{
	// Token: 0x06015405 RID: 87045 RVA: 0x0055EF54 File Offset: 0x0055D154
	public RoleFavorVoiceClassifyData(string titleTableId, int roleId, EFavorVoiceType typeParam) : base(titleTableId, roleId)
	{
		this.TypeParam = typeParam;
	}

	// Token: 0x06015406 RID: 87046 RVA: 0x0055EF6C File Offset: 0x0055D16C
	protected override EFavorTabType GetFavorTabType()
	{
		return EFavorTabType.Voice;
	}

	// Token: 0x06015407 RID: 87047 RVA: 0x0055EF70 File Offset: 0x0055D170
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

	// Token: 0x06015408 RID: 87048 RVA: 0x0055EFD0 File Offset: 0x0055D1D0
	private RoleFavorVoiceContentData CreateVoiceContentData(FavorWord config)
	{
		return new RoleFavorVoiceContentData(this.RoleId, this.TypeParam, config);
	}

	// Token: 0x04009EC1 RID: 40641
	public EFavorVoiceType TypeParam = EFavorVoiceType.FavorNatureVoice;
}
