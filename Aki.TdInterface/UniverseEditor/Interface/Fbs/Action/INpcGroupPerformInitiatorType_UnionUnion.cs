using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007308 RID: 29448
	public class INpcGroupPerformInitiatorType_UnionUnion
	{
		// Token: 0x1700D7E6 RID: 55270
		// (get) Token: 0x060335A5 RID: 210341 RVA: 0x006ECE41 File Offset: 0x006EB041
		// (set) Token: 0x060335A6 RID: 210342 RVA: 0x006ECE49 File Offset: 0x006EB049
		public INpcGroupPerformInitiatorType_Union Type { get; set; }

		// Token: 0x1700D7E7 RID: 55271
		// (get) Token: 0x060335A7 RID: 210343 RVA: 0x006ECE52 File Offset: 0x006EB052
		// (set) Token: 0x060335A8 RID: 210344 RVA: 0x006ECE5A File Offset: 0x006EB05A
		public object Value { get; set; }

		// Token: 0x060335A9 RID: 210345 RVA: 0x006ECE63 File Offset: 0x006EB063
		public INpcGroupPerformInitiatorType_UnionUnion()
		{
			this.Type = INpcGroupPerformInitiatorType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060335AA RID: 210346 RVA: 0x006ECE79 File Offset: 0x006EB079
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060335AB RID: 210347 RVA: 0x006ECE8B File Offset: 0x006EB08B
		public INpcGroupPerformInitiatorTypeT AsINpcGroupPerformInitiatorType()
		{
			return this.As<INpcGroupPerformInitiatorTypeT>();
		}

		// Token: 0x060335AC RID: 210348 RVA: 0x006ECE93 File Offset: 0x006EB093
		public static INpcGroupPerformInitiatorType_UnionUnion FromINpcGroupPerformInitiatorType(INpcGroupPerformInitiatorTypeT _inpcgroupperforminitiatortype)
		{
			return new INpcGroupPerformInitiatorType_UnionUnion
			{
				Type = INpcGroupPerformInitiatorType_Union.INpcGroupPerformInitiatorType,
				Value = _inpcgroupperforminitiatortype
			};
		}

		// Token: 0x060335AD RID: 210349 RVA: 0x006ECEA8 File Offset: 0x006EB0A8
		public IPlayerInitiatorT AsIPlayerInitiator()
		{
			return this.As<IPlayerInitiatorT>();
		}

		// Token: 0x060335AE RID: 210350 RVA: 0x006ECEB0 File Offset: 0x006EB0B0
		public static INpcGroupPerformInitiatorType_UnionUnion FromIPlayerInitiator(IPlayerInitiatorT _iplayerinitiator)
		{
			return new INpcGroupPerformInitiatorType_UnionUnion
			{
				Type = INpcGroupPerformInitiatorType_Union.IPlayerInitiator,
				Value = _iplayerinitiator
			};
		}

		// Token: 0x060335AF RID: 210351 RVA: 0x006ECEC8 File Offset: 0x006EB0C8
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
