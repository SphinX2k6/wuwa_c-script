using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.BigStuffedDoll.View
{
	// Token: 0x020060DB RID: 24795
	public class BigStuffedRingLightItem : BigStuffedRingSubItem<ESubItemType>
	{
		// Token: 0x0603B73B RID: 243515 RVA: 0x010D355E File Offset: 0x010D175E
		public BigStuffedRingLightItem(int ringId, [Nullable(new byte[]
		{
			0,
			1
		})] OneOf<BrokenRockRing, BrokenRockRingConfig> config) : base(ringId, config)
		{
			this.Type = ESubItemType.Light;
		}

		// Token: 0x0603B73C RID: 243516 RVA: 0x010D357F File Offset: 0x010D177F
		protected override void OnStart()
		{
			base.OnStart();
			this.TextureRing.SetUIActive(false);
			this.TextureRing.SetAlpha(0f);
		}

		// Token: 0x0603B73D RID: 243517 RVA: 0x010D35A4 File Offset: 0x010D17A4
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

		// Token: 0x0401F585 RID: 128389
		private readonly FName ProgressParamName = new FName("Progress");
	}
}
