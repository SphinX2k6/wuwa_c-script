using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.Role.Common.Data.Structure;
using UnrealEngine;

// Token: 0x020025C8 RID: 9672
[NullableContext(1)]
[Nullable(0)]
public class CameraFollowInputConfig
{
	// Token: 0x06018076 RID: 98422 RVA: 0x0073222C File Offset: 0x0073042C
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

	// Token: 0x0400CE6F RID: 52847
	public int TriggerTagId;

	// Token: 0x0400CE70 RID: 52848
	public float ForwardAngle = 50f;

	// Token: 0x0400CE71 RID: 52849
	public bool DashInForwardAngle = true;

	// Token: 0x0400CE72 RID: 52850
	public List<int> FirstPersonTagList = new List<int>();

	// Token: 0x0400CE73 RID: 52851
	public List<int> ForbidRotationTagList = new List<int>();
}
