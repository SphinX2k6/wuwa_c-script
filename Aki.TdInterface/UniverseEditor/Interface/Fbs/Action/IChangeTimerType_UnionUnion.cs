using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006333 RID: 25395
	public class IChangeTimerType_UnionUnion
	{
		// Token: 0x1700BD89 RID: 48521
		// (get) Token: 0x0602BED2 RID: 179922 RVA: 0x00609C71 File Offset: 0x00607E71
		// (set) Token: 0x0602BED3 RID: 179923 RVA: 0x00609C79 File Offset: 0x00607E79
		public IChangeTimerType_Union Type { get; set; }

		// Token: 0x1700BD8A RID: 48522
		// (get) Token: 0x0602BED4 RID: 179924 RVA: 0x00609C82 File Offset: 0x00607E82
		// (set) Token: 0x0602BED5 RID: 179925 RVA: 0x00609C8A File Offset: 0x00607E8A
		public object Value { get; set; }

		// Token: 0x0602BED6 RID: 179926 RVA: 0x00609C93 File Offset: 0x00607E93
		public IChangeTimerType_UnionUnion()
		{
			this.Type = IChangeTimerType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602BED7 RID: 179927 RVA: 0x00609CA9 File Offset: 0x00607EA9
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602BED8 RID: 179928 RVA: 0x00609CBB File Offset: 0x00607EBB
		public IChangeTimerTypeT AsIChangeTimerType()
		{
			return this.As<IChangeTimerTypeT>();
		}

		// Token: 0x0602BED9 RID: 179929 RVA: 0x00609CC3 File Offset: 0x00607EC3
		public static IChangeTimerType_UnionUnion FromIChangeTimerType(IChangeTimerTypeT _ichangetimertype)
		{
			return new IChangeTimerType_UnionUnion
			{
				Type = IChangeTimerType_Union.IChangeTimerType,
				Value = _ichangetimertype
			};
		}

		// Token: 0x0602BEDA RID: 179930 RVA: 0x00609CD8 File Offset: 0x00607ED8
		public IAddTimeT AsIAddTime()
		{
			return this.As<IAddTimeT>();
		}

		// Token: 0x0602BEDB RID: 179931 RVA: 0x00609CE0 File Offset: 0x00607EE0
		public static IChangeTimerType_UnionUnion FromIAddTime(IAddTimeT _iaddtime)
		{
			return new IChangeTimerType_UnionUnion
			{
				Type = IChangeTimerType_Union.IAddTime,
				Value = _iaddtime
			};
		}

		// Token: 0x0602BEDC RID: 179932 RVA: 0x00609CF5 File Offset: 0x00607EF5
		public IReduceTimeT AsIReduceTime()
		{
			return this.As<IReduceTimeT>();
		}

		// Token: 0x0602BEDD RID: 179933 RVA: 0x00609CFD File Offset: 0x00607EFD
		public static IChangeTimerType_UnionUnion FromIReduceTime(IReduceTimeT _ireducetime)
		{
			return new IChangeTimerType_UnionUnion
			{
				Type = IChangeTimerType_Union.IReduceTime,
				Value = _ireducetime
			};
		}

		// Token: 0x0602BEDE RID: 179934 RVA: 0x00609D12 File Offset: 0x00607F12
		public ISetTimeT AsISetTime()
		{
			return this.As<ISetTimeT>();
		}

		// Token: 0x0602BEDF RID: 179935 RVA: 0x00609D1A File Offset: 0x00607F1A
		public static IChangeTimerType_UnionUnion FromISetTime(ISetTimeT _isettime)
		{
			return new IChangeTimerType_UnionUnion
			{
				Type = IChangeTimerType_Union.ISetTime,
				Value = _isettime
			};
		}

		// Token: 0x0602BEE0 RID: 179936 RVA: 0x00609D30 File Offset: 0x00607F30
		public static int Pack(FlatBufferBuilder builder, IChangeTimerType_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IChangeTimerType_Union.IChangeTimerType:
				return IChangeTimerType.Pack(builder, _o.AsIChangeTimerType()).Value;
			case IChangeTimerType_Union.IAddTime:
				return IAddTime.Pack(builder, _o.AsIAddTime()).Value;
			case IChangeTimerType_Union.IReduceTime:
				return IReduceTime.Pack(builder, _o.AsIReduceTime()).Value;
			case IChangeTimerType_Union.ISetTime:
				return ISetTime.Pack(builder, _o.AsISetTime()).Value;
			default:
				return 0;
			}
		}
	}
}
