using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.BigStuffedDoll.View
{
	// Token: 0x02006F5A RID: 28506
	public class BigStuffedRingLightItem : BigStuffedRingSubItem<ESubItemType>
	{
		// Token: 0x0604558D RID: 284045 RVA: 0x0112977E File Offset: 0x0112797E
		public BigStuffedRingLightItem(int ringId, [Nullable(new byte[]
		{
			0,
			1
		})] OneOf<BrokenRockRing, BrokenRockRingConfig> config) : base(ringId, config)
		{
			this.Type = ESubItemType.Light;
		}

		// Token: 0x0604558E RID: 284046 RVA: 0x0112979F File Offset: 0x0112799F
		protected override void OnStart()
		{
			base.OnStart();
			this.TextureRing.SetUIActive(false);
			this.TextureRing.SetAlpha(0f);
		}

		// Token: 0x0604558F RID: 284047 RVA: 0x011297C4 File Offset: 0x011279C4
		[NullableContext(1)]
		public void SpawnLightByArea(ContinuousArea area)
		{
			int startCellIndex = area.StartCellIndex;
			int endCellIndex = area.EndCellIndex;
			float num = (float)Math.Max(startCellIndex - 1, 0) * 10f;
			UUIItem textureRing = this.TextureRing;
			FRotator frotator = Rotator.Create(0f, -num, 0f).ToUeRotator();
			textureRing.SetUIRelativeRotation(frotator);
			float value = (float)BigStuffedDefine.calculateCellSize(startCellIndex, endCellIndex) / 36f;
			this.TextureRing.SetCustomMaterialScalarParameter(this.ProgressParamName, value);
			this.TextureRing.SetUIActive(true);
		}

		// Token: 0x040242D0 RID: 148176
		private readonly FName ProgressParamName = new FName("Progress");
	}
}
