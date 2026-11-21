using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007283 RID: 29315
	public class IMotorSoarInWindFieldEnterWindFieldT
	{
		// Token: 0x1700D6E1 RID: 55009
		// (get) Token: 0x06033152 RID: 209234 RVA: 0x006E4E9E File Offset: 0x006E309E
		// (set) Token: 0x06033153 RID: 209235 RVA: 0x006E4EA6 File Offset: 0x006E30A6
		public EMotorSoarInWindFieldControlType Type { get; set; }

		// Token: 0x1700D6E2 RID: 55010
		// (get) Token: 0x06033154 RID: 209236 RVA: 0x006E4EAF File Offset: 0x006E30AF
		// (set) Token: 0x06033155 RID: 209237 RVA: 0x006E4EB7 File Offset: 0x006E30B7
		public IVectorInfoT Direction { get; set; }

		// Token: 0x1700D6E3 RID: 55011
		// (get) Token: 0x06033156 RID: 209238 RVA: 0x006E4EC0 File Offset: 0x006E30C0
		// (set) Token: 0x06033157 RID: 209239 RVA: 0x006E4EC8 File Offset: 0x006E30C8
		public IVectorInfoT Offset { get; set; }

		// Token: 0x1700D6E4 RID: 55012
		// (get) Token: 0x06033158 RID: 209240 RVA: 0x006E4ED1 File Offset: 0x006E30D1
		// (set) Token: 0x06033159 RID: 209241 RVA: 0x006E4ED9 File Offset: 0x006E30D9
		public float WindFieldDepth { get; set; }

		// Token: 0x1700D6E5 RID: 55013
		// (get) Token: 0x0603315A RID: 209242 RVA: 0x006E4EE2 File Offset: 0x006E30E2
		// (set) Token: 0x0603315B RID: 209243 RVA: 0x006E4EEA File Offset: 0x006E30EA
		public float MaxAdditionalSpeed { get; set; }

		// Token: 0x1700D6E6 RID: 55014
		// (get) Token: 0x0603315C RID: 209244 RVA: 0x006E4EF3 File Offset: 0x006E30F3
		// (set) Token: 0x0603315D RID: 209245 RVA: 0x006E4EFB File Offset: 0x006E30FB
		public string SpeedCurve { get; set; }

		// Token: 0x1700D6E7 RID: 55015
		// (get) Token: 0x0603315E RID: 209246 RVA: 0x006E4F04 File Offset: 0x006E3104
		// (set) Token: 0x0603315F RID: 209247 RVA: 0x006E4F0C File Offset: 0x006E310C
		public float SpeedTolerance { get; set; }

		// Token: 0x06033160 RID: 209248 RVA: 0x006E4F18 File Offset: 0x006E3118
		public IMotorSoarInWindFieldEnterWindFieldT()
		{
			this.Type = EMotorSoarInWindFieldControlType.EnterWindField;
			this.Direction = null;
			this.Offset = null;
			this.WindFieldDepth = 0f;
			this.MaxAdditionalSpeed = 0f;
			this.SpeedCurve = null;
			this.SpeedTolerance = 0f;
		}
	}
}
