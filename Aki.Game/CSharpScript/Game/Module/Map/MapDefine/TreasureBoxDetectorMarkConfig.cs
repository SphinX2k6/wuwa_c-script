using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Map.MapDefine
{
	// Token: 0x02004557 RID: 17751
	public class TreasureBoxDetectorMarkConfig : IMarkConfig
	{
		// Token: 0x0602CBAE RID: 183214 RVA: 0x00C87109 File Offset: 0x00C85309
		public TreasureBoxDetectorMarkConfig(TreasureBoxDetectorMark config)
		{
		}

		// Token: 0x17005A14 RID: 23060
		// (get) Token: 0x0602CBAF RID: 183215 RVA: 0x00C87118 File Offset: 0x00C85318
		public TreasureBoxDetectorMark Raw
		{
			get
			{
				return this.<config>P;
			}
		} = config;

		// Token: 0x17005A15 RID: 23061
		// (get) Token: 0x0602CBB0 RID: 183216 RVA: 0x00C87120 File Offset: 0x00C85320
		public int MarkId
		{
			get
			{
				return this.<config>P.MarkId;
			}
		}

		// Token: 0x17005A16 RID: 23062
		// (get) Token: 0x0602CBB1 RID: 183217 RVA: 0x00C8712D File Offset: 0x00C8532D
		public int TrackHudEnable
		{
			get
			{
				return this.<config>P.TrackHudEnable;
			}
		}

		// Token: 0x17005A17 RID: 23063
		// (get) Token: 0x0602CBB2 RID: 183218 RVA: 0x00C8713A File Offset: 0x00C8533A
		public float TrackAutoCancelDistance
		{
			get
			{
				return this.<config>P.TrackAutoCancelDistance;
			}
		}

		// Token: 0x17005A18 RID: 23064
		// (get) Token: 0x0602CBB3 RID: 183219 RVA: 0x00C87148 File Offset: 0x00C85348
		public int? RelativeId
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005A19 RID: 23065
		// (get) Token: 0x0602CBB4 RID: 183220 RVA: 0x00C87160 File Offset: 0x00C85360
		public int? RelativeDungeonId
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005A1A RID: 23066
		// (get) Token: 0x0602CBB5 RID: 183221 RVA: 0x00C87178 File Offset: 0x00C85378
		public EMarkRelativeType? RelativeType
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005A1B RID: 23067
		// (get) Token: 0x0602CBB6 RID: 183222 RVA: 0x00C87190 File Offset: 0x00C85390
		public EMarkRelativeSubType? RelativeSubType
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005A1C RID: 23068
		// (get) Token: 0x0602CBB7 RID: 183223 RVA: 0x00C871A8 File Offset: 0x00C853A8
		public int? FogHide
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005A1D RID: 23069
		// (get) Token: 0x0602CBB8 RID: 183224 RVA: 0x00C871BE File Offset: 0x00C853BE
		public int AssociatedGameplayMarksLength
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x0602CBB9 RID: 183225 RVA: 0x00C871C1 File Offset: 0x00C853C1
		public int AssociatedGameplayMarks(int index)
		{
			return 0;
		}

		// Token: 0x04017FCB RID: 98251
		[CompilerGenerated]
		private TreasureBoxDetectorMark <config>P;
	}
}
