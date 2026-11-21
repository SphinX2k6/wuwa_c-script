using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Map.MapDefine
{
	// Token: 0x02004556 RID: 17750
	public class DynamicMapMarkConfig : IMarkConfig
	{
		// Token: 0x0602CBA2 RID: 183202 RVA: 0x00C8706B File Offset: 0x00C8526B
		public DynamicMapMarkConfig(DynamicMapMark config)
		{
		}

		// Token: 0x17005A0A RID: 23050
		// (get) Token: 0x0602CBA3 RID: 183203 RVA: 0x00C8707A File Offset: 0x00C8527A
		public DynamicMapMark Raw
		{
			get
			{
				return this.<config>P;
			}
		} = config;

		// Token: 0x17005A0B RID: 23051
		// (get) Token: 0x0602CBA4 RID: 183204 RVA: 0x00C87082 File Offset: 0x00C85282
		public int MarkId
		{
			get
			{
				return this.<config>P.MarkId;
			}
		}

		// Token: 0x17005A0C RID: 23052
		// (get) Token: 0x0602CBA5 RID: 183205 RVA: 0x00C8708F File Offset: 0x00C8528F
		public int TrackHudEnable
		{
			get
			{
				return this.<config>P.TrackHudEnable;
			}
		}

		// Token: 0x17005A0D RID: 23053
		// (get) Token: 0x0602CBA6 RID: 183206 RVA: 0x00C8709C File Offset: 0x00C8529C
		public float TrackAutoCancelDistance
		{
			get
			{
				return this.<config>P.TrackAutoCancelDistance;
			}
		}

		// Token: 0x17005A0E RID: 23054
		// (get) Token: 0x0602CBA7 RID: 183207 RVA: 0x00C870A9 File Offset: 0x00C852A9
		public int? RelativeId
		{
			get
			{
				return new int?(this.<config>P.RelativeId);
			}
		}

		// Token: 0x17005A0F RID: 23055
		// (get) Token: 0x0602CBA8 RID: 183208 RVA: 0x00C870BB File Offset: 0x00C852BB
		public int? RelativeDungeonId
		{
			get
			{
				return new int?(this.<config>P.RelativeDungeonId);
			}
		}

		// Token: 0x17005A10 RID: 23056
		// (get) Token: 0x0602CBA9 RID: 183209 RVA: 0x00C870CD File Offset: 0x00C852CD
		public EMarkRelativeType? RelativeType
		{
			get
			{
				return new EMarkRelativeType?((EMarkRelativeType)this.<config>P.RelativeType);
			}
		}

		// Token: 0x17005A11 RID: 23057
		// (get) Token: 0x0602CBAA RID: 183210 RVA: 0x00C870DF File Offset: 0x00C852DF
		public EMarkRelativeSubType? RelativeSubType
		{
			get
			{
				return new EMarkRelativeSubType?((EMarkRelativeSubType)this.<config>P.RelativeSubType);
			}
		}

		// Token: 0x17005A12 RID: 23058
		// (get) Token: 0x0602CBAB RID: 183211 RVA: 0x00C870F1 File Offset: 0x00C852F1
		public int? FogHide
		{
			get
			{
				return new int?(this.<config>P.FogHide);
			}
		}

		// Token: 0x17005A13 RID: 23059
		// (get) Token: 0x0602CBAC RID: 183212 RVA: 0x00C87103 File Offset: 0x00C85303
		public int AssociatedGameplayMarksLength
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x0602CBAD RID: 183213 RVA: 0x00C87106 File Offset: 0x00C85306
		public int AssociatedGameplayMarks(int index)
		{
			return 0;
		}

		// Token: 0x04017FCA RID: 98250
		[CompilerGenerated]
		private DynamicMapMark <config>P;
	}
}
