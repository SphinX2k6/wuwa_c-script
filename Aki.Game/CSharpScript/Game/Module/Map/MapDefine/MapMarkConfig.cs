using System;
using Aki.Config;

namespace CSharpScript.Game.Module.Map.MapDefine
{
	// Token: 0x02004555 RID: 17749
	public class MapMarkConfig : IMarkConfig
	{
		// Token: 0x0602CB96 RID: 183190 RVA: 0x00C86FB8 File Offset: 0x00C851B8
		public MapMarkConfig(MapMark config)
		{
		}

		// Token: 0x17005A00 RID: 23040
		// (get) Token: 0x0602CB97 RID: 183191 RVA: 0x00C86FC7 File Offset: 0x00C851C7
		public MapMark Raw
		{
			get
			{
				return this._config;
			}
		}

		// Token: 0x17005A01 RID: 23041
		// (get) Token: 0x0602CB98 RID: 183192 RVA: 0x00C86FCF File Offset: 0x00C851CF
		public int MarkId
		{
			get
			{
				return this._config.MarkId;
			}
		}

		// Token: 0x17005A02 RID: 23042
		// (get) Token: 0x0602CB99 RID: 183193 RVA: 0x00C86FDC File Offset: 0x00C851DC
		public int TrackHudEnable
		{
			get
			{
				return this._config.TrackHudEnable;
			}
		}

		// Token: 0x17005A03 RID: 23043
		// (get) Token: 0x0602CB9A RID: 183194 RVA: 0x00C86FE9 File Offset: 0x00C851E9
		public float TrackAutoCancelDistance
		{
			get
			{
				return this._config.TrackAutoCancelDistance;
			}
		}

		// Token: 0x17005A04 RID: 23044
		// (get) Token: 0x0602CB9B RID: 183195 RVA: 0x00C86FF6 File Offset: 0x00C851F6
		public int? RelativeId
		{
			get
			{
				return new int?(this._config.RelativeId);
			}
		}

		// Token: 0x17005A05 RID: 23045
		// (get) Token: 0x0602CB9C RID: 183196 RVA: 0x00C87008 File Offset: 0x00C85208
		public int? RelativeDungeonId
		{
			get
			{
				return new int?(this._config.RelativeDungeonId);
			}
		}

		// Token: 0x17005A06 RID: 23046
		// (get) Token: 0x0602CB9D RID: 183197 RVA: 0x00C8701A File Offset: 0x00C8521A
		public EMarkRelativeType? RelativeType
		{
			get
			{
				return new EMarkRelativeType?((EMarkRelativeType)this._config.RelativeType);
			}
		}

		// Token: 0x17005A07 RID: 23047
		// (get) Token: 0x0602CB9E RID: 183198 RVA: 0x00C8702C File Offset: 0x00C8522C
		public EMarkRelativeSubType? RelativeSubType
		{
			get
			{
				return new EMarkRelativeSubType?((EMarkRelativeSubType)this._config.RelativeSubType);
			}
		}

		// Token: 0x17005A08 RID: 23048
		// (get) Token: 0x0602CB9F RID: 183199 RVA: 0x00C8703E File Offset: 0x00C8523E
		public int? FogHide
		{
			get
			{
				return new int?(this._config.FogHide);
			}
		}

		// Token: 0x17005A09 RID: 23049
		// (get) Token: 0x0602CBA0 RID: 183200 RVA: 0x00C87050 File Offset: 0x00C85250
		public int AssociatedGameplayMarksLength
		{
			get
			{
				return this._config.AssociatedGameplayMarksLength;
			}
		}

		// Token: 0x0602CBA1 RID: 183201 RVA: 0x00C8705D File Offset: 0x00C8525D
		public int AssociatedGameplayMarks(int index)
		{
			return this._config.AssociatedGameplayMarks(index);
		}

		// Token: 0x04017FC9 RID: 98249
		private MapMark _config = config;
	}
}
