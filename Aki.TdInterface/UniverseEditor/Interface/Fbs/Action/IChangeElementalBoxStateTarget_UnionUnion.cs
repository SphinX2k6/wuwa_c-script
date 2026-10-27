using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020062DF RID: 25311
	public class IChangeElementalBoxStateTarget_UnionUnion
	{
		// Token: 0x1700BCE8 RID: 48360
		// (get) Token: 0x0602BBF9 RID: 179193 RVA: 0x00604E3A File Offset: 0x0060303A
		// (set) Token: 0x0602BBFA RID: 179194 RVA: 0x00604E42 File Offset: 0x00603042
		public IChangeElementalBoxStateTarget_Union Type { get; set; }

		// Token: 0x1700BCE9 RID: 48361
		// (get) Token: 0x0602BBFB RID: 179195 RVA: 0x00604E4B File Offset: 0x0060304B
		// (set) Token: 0x0602BBFC RID: 179196 RVA: 0x00604E53 File Offset: 0x00603053
		public object Value { get; set; }

		// Token: 0x0602BBFD RID: 179197 RVA: 0x00604E5C File Offset: 0x0060305C
		public IChangeElementalBoxStateTarget_UnionUnion()
		{
			this.Type = IChangeElementalBoxStateTarget_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602BBFE RID: 179198 RVA: 0x00604E72 File Offset: 0x00603072
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602BBFF RID: 179199 RVA: 0x00604E84 File Offset: 0x00603084
		public IChangeElementalBoxStateTargetT AsIChangeElementalBoxStateTarget()
		{
			return this.As<IChangeElementalBoxStateTargetT>();
		}

		// Token: 0x0602BC00 RID: 179200 RVA: 0x00604E8C File Offset: 0x0060308C
		public static IChangeElementalBoxStateTarget_UnionUnion FromIChangeElementalBoxStateTarget(IChangeElementalBoxStateTargetT _ichangeelementalboxstatetarget)
		{
			return new IChangeElementalBoxStateTarget_UnionUnion
			{
				Type = IChangeElementalBoxStateTarget_Union.IChangeElementalBoxStateTarget,
				Value = _ichangeelementalboxstatetarget
			};
		}

		// Token: 0x0602BC01 RID: 179201 RVA: 0x00604EA1 File Offset: 0x006030A1
		public IChangeElementalBoxStatePlayerTargetT AsIChangeElementalBoxStatePlayerTarget()
		{
			return this.As<IChangeElementalBoxStatePlayerTargetT>();
		}

		// Token: 0x0602BC02 RID: 179202 RVA: 0x00604EA9 File Offset: 0x006030A9
		public static IChangeElementalBoxStateTarget_UnionUnion FromIChangeElementalBoxStatePlayerTarget(IChangeElementalBoxStatePlayerTargetT _ichangeelementalboxstateplayertarget)
		{
			return new IChangeElementalBoxStateTarget_UnionUnion
			{
				Type = IChangeElementalBoxStateTarget_Union.IChangeElementalBoxStatePlayerTarget,
				Value = _ichangeelementalboxstateplayertarget
			};
		}

		// Token: 0x0602BC03 RID: 179203 RVA: 0x00604EBE File Offset: 0x006030BE
		public IChangeElementalBoxStateTargetBoxIdT AsIChangeElementalBoxStateTargetBoxId()
		{
			return this.As<IChangeElementalBoxStateTargetBoxIdT>();
		}

		// Token: 0x0602BC04 RID: 179204 RVA: 0x00604EC6 File Offset: 0x006030C6
		public static IChangeElementalBoxStateTarget_UnionUnion FromIChangeElementalBoxStateTargetBoxId(IChangeElementalBoxStateTargetBoxIdT _ichangeelementalboxstatetargetboxid)
		{
			return new IChangeElementalBoxStateTarget_UnionUnion
			{
				Type = IChangeElementalBoxStateTarget_Union.IChangeElementalBoxStateTargetBoxId,
				Value = _ichangeelementalboxstatetargetboxid
			};
		}

		// Token: 0x0602BC05 RID: 179205 RVA: 0x00604EDC File Offset: 0x006030DC
		public static int Pack(FlatBufferBuilder builder, IChangeElementalBoxStateTarget_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IChangeElementalBoxStateTarget_Union.IChangeElementalBoxStateTarget:
				return IChangeElementalBoxStateTarget.Pack(builder, _o.AsIChangeElementalBoxStateTarget()).Value;
			case IChangeElementalBoxStateTarget_Union.IChangeElementalBoxStatePlayerTarget:
				return IChangeElementalBoxStatePlayerTarget.Pack(builder, _o.AsIChangeElementalBoxStatePlayerTarget()).Value;
			case IChangeElementalBoxStateTarget_Union.IChangeElementalBoxStateTargetBoxId:
				return IChangeElementalBoxStateTargetBoxId.Pack(builder, _o.AsIChangeElementalBoxStateTargetBoxId()).Value;
			default:
				return 0;
			}
		}
	}
}
