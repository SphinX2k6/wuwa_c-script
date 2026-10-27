using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.Role.Common.Data.Structure;
using UnrealEngine;

// Token: 0x02003071 RID: 12401
[NullableContext(1)]
[Nullable(0)]
public class CameraFollowInputConfig
{
	// Token: 0x0601A6BB RID: 108219 RVA: 0x0070BA34 File Offset: 0x00709C34
	public void Init(BP_FirstPersonConfig_C asset, int triggerTagId)
	{
		this.TriggerTagId = triggerTagId;
		this.ForwardAngle = (float)asset.ForwardAngle;
		this.DashInForwardAngle = asset.DashInForwardAngle;
		int num = 0;
		for (;;)
		{
			int num2 = num;
			int? num3 = (asset != null) ? new int?(asset.FirstPersonTagList.GameplayTags.Num()) : null;
			if (!(num2 < num3.GetValueOrDefault() & num3 != null))
			{
				break;
			}
			this.FirstPersonTagList.Add(asset.FirstPersonTagList.GameplayTags.Get(num).TagId());
			num++;
		}
		int num4 = 0;
		for (;;)
		{
			int num5 = num4;
			int? num3 = (asset != null) ? new int?(asset.ForbidRotationTagList.GameplayTags.Num()) : null;
			if (!(num5 < num3.GetValueOrDefault() & num3 != null))
			{
				break;
			}
			this.ForbidRotationTagList.Add(asset.ForbidRotationTagList.GameplayTags.Get(num4).TagId());
			num4++;
		}
	}

	// Token: 0x0400CA95 RID: 51861
	public int TriggerTagId;

	// Token: 0x0400CA96 RID: 51862
	public float ForwardAngle = 50f;

	// Token: 0x0400CA97 RID: 51863
	public bool DashInForwardAngle = true;

	// Token: 0x0400CA98 RID: 51864
	public List<int> FirstPersonTagList = new List<int>();

	// Token: 0x0400CA99 RID: 51865
	public List<int> ForbidRotationTagList = new List<int>();
}
