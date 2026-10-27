using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.Role.Common.Data.Structure;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.Character.Common.Component
{
	// Token: 0x020070CE RID: 28878
	[NullableContext(1)]
	[Nullable(0)]
	public class OverShoulderModeConfig
	{
		// Token: 0x06046775 RID: 288629 RVA: 0x011B1A6C File Offset: 0x011AFC6C
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

		// Token: 0x06046776 RID: 288630 RVA: 0x011B1AFD File Offset: 0x011AFCFD
		public bool IsValid()
		{
			return this.MinTurnSpeed <= this.MaxTurnSpeed && this.MinTurnSpeed > 0f && this.SprintExitDegAbs > 0f;
		}

		// Token: 0x06046777 RID: 288631 RVA: 0x011B1B2C File Offset: 0x011AFD2C
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

		// Token: 0x06046778 RID: 288632 RVA: 0x011B1BA4 File Offset: 0x011AFDA4
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

		// Token: 0x04024EEB RID: 151275
		public float MaxTurnSpeed;

		// Token: 0x04024EEC RID: 151276
		public float MinTurnSpeed;

		// Token: 0x04024EED RID: 151277
		public float LerpBeginDeg;

		// Token: 0x04024EEE RID: 151278
		public float SprintExitDegAbs;

		// Token: 0x04024EEF RID: 151279
		public float LerpPow = 1f;

		// Token: 0x04024EF0 RID: 151280
		[Nullable(2)]
		public UCurveFloat LerpCurve;

		// Token: 0x04024EF1 RID: 151281
		public List<int> TagList = new List<int>();
	}
}
