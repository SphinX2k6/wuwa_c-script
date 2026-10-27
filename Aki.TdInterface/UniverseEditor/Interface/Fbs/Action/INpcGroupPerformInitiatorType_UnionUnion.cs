using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006BBC RID: 27580
	public class INpcGroupPerformInitiatorType_UnionUnion
	{
		// Token: 0x1700CCFA RID: 52474
		// (get) Token: 0x0603072B RID: 198443 RVA: 0x006944A1 File Offset: 0x006926A1
		// (set) Token: 0x0603072C RID: 198444 RVA: 0x006944A9 File Offset: 0x006926A9
		public INpcGroupPerformInitiatorType_Union Type { get; set; }

		// Token: 0x1700CCFB RID: 52475
		// (get) Token: 0x0603072D RID: 198445 RVA: 0x006944B2 File Offset: 0x006926B2
		// (set) Token: 0x0603072E RID: 198446 RVA: 0x006944BA File Offset: 0x006926BA
		public object Value { get; set; }

		// Token: 0x0603072F RID: 198447 RVA: 0x006944C3 File Offset: 0x006926C3
		public INpcGroupPerformInitiatorType_UnionUnion()
		{
			this.Type = INpcGroupPerformInitiatorType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06030730 RID: 198448 RVA: 0x006944D9 File Offset: 0x006926D9
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06030731 RID: 198449 RVA: 0x006944EB File Offset: 0x006926EB
		public INpcGroupPerformInitiatorTypeT AsINpcGroupPerformInitiatorType()
		{
			return this.As<INpcGroupPerformInitiatorTypeT>();
		}

		// Token: 0x06030732 RID: 198450 RVA: 0x006944F3 File Offset: 0x006926F3
		public static INpcGroupPerformInitiatorType_UnionUnion FromINpcGroupPerformInitiatorType(INpcGroupPerformInitiatorTypeT _inpcgroupperforminitiatortype)
		{
			return new INpcGroupPerformInitiatorType_UnionUnion
			{
				Type = INpcGroupPerformInitiatorType_Union.INpcGroupPerformInitiatorType,
				Value = _inpcgroupperforminitiatortype
			};
		}

		// Token: 0x06030733 RID: 198451 RVA: 0x00694508 File Offset: 0x00692708
		public IPlayerInitiatorT AsIPlayerInitiator()
		{
			return this.As<IPlayerInitiatorT>();
		}

		// Token: 0x06030734 RID: 198452 RVA: 0x00694510 File Offset: 0x00692710
		public static INpcGroupPerformInitiatorType_UnionUnion FromIPlayerInitiator(IPlayerInitiatorT _iplayerinitiator)
		{
			return new INpcGroupPerformInitiatorType_UnionUnion
			{
				Type = INpcGroupPerformInitiatorType_Union.IPlayerInitiator,
				Value = _iplayerinitiator
			};
		}

		// Token: 0x06030735 RID: 198453 RVA: 0x00694528 File Offset: 0x00692728
		public static int Pack(FlatBufferBuilder builder, INpcGroupPerformInitiatorType_UnionUnion _o)
		{
			INpcGroupPerformInitiatorType_Union type = _o.Type;
			if (type == INpcGroupPerformInitiatorType_Union.INpcGroupPerformInitiatorType)
			{
				return INpcGroupPerformInitiatorType.Pack(builder, _o.AsINpcGroupPerformInitiatorType()).Value;
			}
			if (type != INpcGroupPerformInitiatorType_Union.IPlayerInitiator)
			{
				return 0;
			}
			return IPlayerInitiator.Pack(builder, _o.AsIPlayerInitiator()).Value;
		}
	}
}
