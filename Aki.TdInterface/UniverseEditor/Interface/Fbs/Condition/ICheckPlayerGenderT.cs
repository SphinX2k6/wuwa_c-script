using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004FC0 RID: 20416
	public class ICheckPlayerGenderT
	{
		// Token: 0x1700920A RID: 37386
		// (get) Token: 0x0601FD4D RID: 130381 RVA: 0x0046BFF0 File Offset: 0x0046A1F0
		// (set) Token: 0x0601FD4E RID: 130382 RVA: 0x0046BFF8 File Offset: 0x0046A1F8
		public ECondition Type { get; set; }

		// Token: 0x1700920B RID: 37387
		// (get) Token: 0x0601FD4F RID: 130383 RVA: 0x0046C001 File Offset: 0x0046A201
		// (set) Token: 0x0601FD50 RID: 130384 RVA: 0x0046C009 File Offset: 0x0046A209
		public EGender Gender { get; set; }

		// Token: 0x0601FD51 RID: 130385 RVA: 0x0046C012 File Offset: 0x0046A212
		public ICheckPlayerGenderT()
		{
			this.Type = ECondition.CompareVar;
			this.Gender = EGender.M;
		}
	}
}
