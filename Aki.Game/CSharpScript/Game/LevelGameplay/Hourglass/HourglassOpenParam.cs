using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay.Hourglass
{
	// Token: 0x02005F7C RID: 24444
	[NullableContext(1)]
	[Nullable(0)]
	[RequiredMember]
	public class HourglassOpenParam : IHourglassOpenParam
	{
		// Token: 0x17006EEB RID: 28395
		// (get) Token: 0x0603AC63 RID: 240739 RVA: 0x0109E1B4 File Offset: 0x0109C3B4
		// (set) Token: 0x0603AC64 RID: 240740 RVA: 0x0109E1BC File Offset: 0x0109C3BC
		[RequiredMember]
		public IQteHourglass Config { get; set; }

		// Token: 0x17006EEC RID: 28396
		// (get) Token: 0x0603AC65 RID: 240741 RVA: 0x0109E1C5 File Offset: 0x0109C3C5
		// (set) Token: 0x0603AC66 RID: 240742 RVA: 0x0109E1CD File Offset: 0x0109C3CD
		public bool? AutoStartQte { get; set; }

		// Token: 0x0603AC67 RID: 240743 RVA: 0x0109E1D6 File Offset: 0x0109C3D6
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public HourglassOpenParam()
		{
		}
	}
}
