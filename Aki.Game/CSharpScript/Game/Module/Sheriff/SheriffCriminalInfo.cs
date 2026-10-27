using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;

namespace CSharpScript.Game.Module.Sheriff
{
	// Token: 0x02004C31 RID: 19505
	public class SheriffCriminalInfo
	{
		// Token: 0x0603277F RID: 206719 RVA: 0x00BC2BAC File Offset: 0x00BC0DAC
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

		// Token: 0x0401ADCE RID: 110030
		public int ZoneId;

		// Token: 0x0401ADCF RID: 110031
		public int CriminalId;

		// Token: 0x0401ADD0 RID: 110032
		public int Identity;

		// Token: 0x0401ADD1 RID: 110033
		public ESheriffCriminalState State;

		// Token: 0x0401ADD2 RID: 110034
		public int AnomalyId;
	}
}
