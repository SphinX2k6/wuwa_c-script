using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020069A4 RID: 27044
	public class IChangeTimerType_UnionUnion
	{
		// Token: 0x1700C711 RID: 50961
		// (get) Token: 0x0602E63C RID: 190012 RVA: 0x00654DC5 File Offset: 0x00652FC5
		// (set) Token: 0x0602E63D RID: 190013 RVA: 0x00654DCD File Offset: 0x00652FCD
		public IChangeTimerType_Union Type { get; set; }

		// Token: 0x1700C712 RID: 50962
		// (get) Token: 0x0602E63E RID: 190014 RVA: 0x00654DD6 File Offset: 0x00652FD6
		// (set) Token: 0x0602E63F RID: 190015 RVA: 0x00654DDE File Offset: 0x00652FDE
		public object Value { get; set; }

		// Token: 0x0602E640 RID: 190016 RVA: 0x00654DE7 File Offset: 0x00652FE7
		public IChangeTimerType_UnionUnion()
		{
			this.Type = IChangeTimerType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602E641 RID: 190017 RVA: 0x00654DFD File Offset: 0x00652FFD
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602E642 RID: 190018 RVA: 0x00654E0F File Offset: 0x0065300F
		public IChangeTimerTypeT AsIChangeTimerType()
		{
			return this.As<IChangeTimerTypeT>();
		}

		// Token: 0x0602E643 RID: 190019 RVA: 0x00654E17 File Offset: 0x00653017
		public static IChangeTimerType_UnionUnion FromIChangeTimerType(IChangeTimerTypeT _ichangetimertype)
		{
			return new IChangeTimerType_UnionUnion
			{
				Type = IChangeTimerType_Union.IChangeTimerType,
				Value = _ichangetimertype
			};
		}

		// Token: 0x0602E644 RID: 190020 RVA: 0x00654E2C File Offset: 0x0065302C
		public IAddTimeT AsIAddTime()
		{
			return this.As<IAddTimeT>();
		}

		// Token: 0x0602E645 RID: 190021 RVA: 0x00654E34 File Offset: 0x00653034
		public static IChangeTimerType_UnionUnion FromIAddTime(IAddTimeT _iaddtime)
		{
			return new IChangeTimerType_UnionUnion
			{
				Type = IChangeTimerType_Union.IAddTime,
				Value = _iaddtime
			};
		}

		// Token: 0x0602E646 RID: 190022 RVA: 0x00654E49 File Offset: 0x00653049
		public IReduceTimeT AsIReduceTime()
		{
			return this.As<IReduceTimeT>();
		}

		// Token: 0x0602E647 RID: 190023 RVA: 0x00654E51 File Offset: 0x00653051
		public static IChangeTimerType_UnionUnion FromIReduceTime(IReduceTimeT _ireducetime)
		{
			return new IChangeTimerType_UnionUnion
			{
				Type = IChangeTimerType_Union.IReduceTime,
				Value = _ireducetime
			};
		}

		// Token: 0x0602E648 RID: 190024 RVA: 0x00654E66 File Offset: 0x00653066
		public ISetTimeT AsISetTime()
		{
			return this.As<ISetTimeT>();
		}

		// Token: 0x0602E649 RID: 190025 RVA: 0x00654E6E File Offset: 0x0065306E
		public static IChangeTimerType_UnionUnion FromISetTime(ISetTimeT _isettime)
		{
			return new IChangeTimerType_UnionUnion
			{
				Type = IChangeTimerType_Union.ISetTime,
				Value = _isettime
			};
		}

		// Token: 0x0602E64A RID: 190026 RVA: 0x00654E84 File Offset: 0x00653084
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
