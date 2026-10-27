using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay.Hourglass
{
	// Token: 0x02006DFD RID: 28157
	[NullableContext(1)]
	[Nullable(0)]
	[RequiredMember]
	public class HourglassOpenParam : IHourglassOpenParam
	{
		// Token: 0x170099E8 RID: 39400
		// (get) Token: 0x06044AFF RID: 281343 RVA: 0x010F3EEC File Offset: 0x010F20EC
		// (set) Token: 0x06044B00 RID: 281344 RVA: 0x010F3EF4 File Offset: 0x010F20F4
		[RequiredMember]
		public IQteHourglass Config { get; set; }

		// Token: 0x170099E9 RID: 39401
		// (get) Token: 0x06044B01 RID: 281345 RVA: 0x010F3EFD File Offset: 0x010F20FD
		// (set) Token: 0x06044B02 RID: 281346 RVA: 0x010F3F05 File Offset: 0x010F2105
		public bool? AutoStartQte { get; set; }

		// Token: 0x06044B03 RID: 281347 RVA: 0x010F3F0E File Offset: 0x010F210E
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public HourglassOpenParam()
		{
		}
	}
}
