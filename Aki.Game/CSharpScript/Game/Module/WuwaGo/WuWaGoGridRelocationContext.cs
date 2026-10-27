using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.WuwaGo.Model;

namespace CSharpScript.Game.Module.WuwaGo
{
	// Token: 0x02004703 RID: 18179
	[NullableContext(1)]
	[Nullable(0)]
	[RequiredMember]
	public class WuWaGoGridRelocationContext : IWuWaGoGridRelocationContext
	{
		// Token: 0x1700769F RID: 30367
		// (get) Token: 0x0602F849 RID: 194633 RVA: 0x00B036C1 File Offset: 0x00B018C1
		// (set) Token: 0x0602F84A RID: 194634 RVA: 0x00B036C9 File Offset: 0x00B018C9
		[RequiredMember]
		public WuWaGoGrid Grid { get; set; }

		// Token: 0x170076A0 RID: 30368
		// (get) Token: 0x0602F84B RID: 194635 RVA: 0x00B036D2 File Offset: 0x00B018D2
		// (set) Token: 0x0602F84C RID: 194636 RVA: 0x00B036DA File Offset: 0x00B018DA
		[RequiredMember]
		public Vector StartCoordinate { get; set; }

		// Token: 0x170076A1 RID: 30369
		// (get) Token: 0x0602F84D RID: 194637 RVA: 0x00B036E3 File Offset: 0x00B018E3
		// (set) Token: 0x0602F84E RID: 194638 RVA: 0x00B036EB File Offset: 0x00B018EB
		[RequiredMember]
		public Vector TargetCoordinate { get; set; }

		// Token: 0x0602F84F RID: 194639 RVA: 0x00B036F4 File Offset: 0x00B018F4
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public WuWaGoGridRelocationContext()
		{
		}
	}
}
