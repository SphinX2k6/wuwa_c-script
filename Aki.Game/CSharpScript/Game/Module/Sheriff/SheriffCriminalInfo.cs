using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;

namespace CSharpScript.Game.Module.Sheriff
{
	// Token: 0x02003BE2 RID: 15330
	public class SheriffCriminalInfo
	{
		// Token: 0x06027532 RID: 161074 RVA: 0x00B077D4 File Offset: 0x00B059D4
		[NullableContext(1)]
		public void UpdateByProto(SheriffCriminalInfo proto, int? zoneId = null)
		{
			if (zoneId != null)
			{
				this.ZoneId = zoneId.Value;
			}
			this.CriminalId = proto.CriminalId;
			this.Identity = proto.IdentityId;
			this.State = (ESheriffCriminalState)proto.State;
			this.Identity = proto.IdentityId;
			SheriffCriminal? criminalConfigById = SheriffConfig.Instance.GetCriminalConfigById(this.CriminalId);
			if (criminalConfigById != null)
			{
				this.AnomalyId = criminalConfigById.Value.SheriffAnomalyId;
			}
		}

		// Token: 0x0401572B RID: 87851
		public int ZoneId;

		// Token: 0x0401572C RID: 87852
		public int CriminalId;

		// Token: 0x0401572D RID: 87853
		public int Identity;

		// Token: 0x0401572E RID: 87854
		public ESheriffCriminalState State;

		// Token: 0x0401572F RID: 87855
		public int AnomalyId;
	}
}
