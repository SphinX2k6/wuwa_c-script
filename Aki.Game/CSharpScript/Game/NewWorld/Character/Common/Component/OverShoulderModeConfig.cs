using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.Role.Common.Data.Structure;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.Character.Common.Component
{
	// Token: 0x02006332 RID: 25394
	[NullableContext(1)]
	[Nullable(0)]
	public class OverShoulderModeConfig
	{
		// Token: 0x0603D871 RID: 252017 RVA: 0x011D0CB0 File Offset: 0x011CEEB0
		public void InitFromAsset(BP_OverShoulderModeConfig_C asset)
		{
			this.MaxTurnSpeed = asset.MaxTurnSpeed;
			this.MinTurnSpeed = asset.MinTurnSpeed;
			this.LerpBeginDeg = asset.LerpBeginDeg;
			this.LerpPow = asset.LerpPow;
			this.LerpCurve = asset.LerpCurve;
			this.SprintExitDegAbs = asset.SprintExitInputDegAbs;
			for (int i = 0; i < asset.TagList.GameplayTags.Num(); i++)
			{
				this.TagList.Add(asset.TagList.GameplayTags.Get(i).TagId());
			}
		}

		// Token: 0x0603D872 RID: 252018 RVA: 0x011D0D41 File Offset: 0x011CEF41
		public bool IsValid()
		{
			return this.MinTurnSpeed <= this.MaxTurnSpeed && this.MinTurnSpeed > 0f && this.SprintExitDegAbs > 0f;
		}

		// Token: 0x0603D873 RID: 252019 RVA: 0x011D0D70 File Offset: 0x011CEF70
		public void TryAddOrRemoveTags(Entity entity, bool isAdd = true)
		{
			BaseTagComponent component = entity.GetComponent<BaseTagComponent>();
			if (component == null)
			{
				return;
			}
			if (isAdd)
			{
				for (int i = 0; i < this.TagList.Count; i++)
				{
					component.AddTag(new int?(this.TagList[i]));
				}
				return;
			}
			for (int j = 0; j < this.TagList.Count; j++)
			{
				component.RemoveTag(new int?(this.TagList[j]));
			}
		}

		// Token: 0x0603D874 RID: 252020 RVA: 0x011D0DE8 File Offset: 0x011CEFE8
		public float GetLerpDegAlpha(float inAlpha)
		{
			float num = MathUtils.Instance.Clamp(inAlpha, 0f, 1f);
			UCurveFloat lerpCurve = this.LerpCurve;
			if (lerpCurve != null && lerpCurve.IsValid())
			{
				return MathUtils.Instance.Clamp(this.LerpCurve.GetFloatValue(num), 0f, 1f);
			}
			return MathF.Pow(num, this.LerpPow);
		}

		// Token: 0x04020A2A RID: 133674
		public float MaxTurnSpeed;

		// Token: 0x04020A2B RID: 133675
		public float MinTurnSpeed;

		// Token: 0x04020A2C RID: 133676
		public float LerpBeginDeg;

		// Token: 0x04020A2D RID: 133677
		public float SprintExitDegAbs;

		// Token: 0x04020A2E RID: 133678
		public float LerpPow = 1f;

		// Token: 0x04020A2F RID: 133679
		[Nullable(2)]
		public UCurveFloat LerpCurve;

		// Token: 0x04020A30 RID: 133680
		public List<int> TagList = new List<int>();
	}
}
