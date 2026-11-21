using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006950 RID: 26960
	public class IChangeElementalBoxStateTarget_UnionUnion
	{
		// Token: 0x1700C672 RID: 50802
		// (get) Token: 0x0602E362 RID: 189282 RVA: 0x0064FE46 File Offset: 0x0064E046
		// (set) Token: 0x0602E363 RID: 189283 RVA: 0x0064FE4E File Offset: 0x0064E04E
		public IChangeElementalBoxStateTarget_Union Type { get; set; }

		// Token: 0x1700C673 RID: 50803
		// (get) Token: 0x0602E364 RID: 189284 RVA: 0x0064FE57 File Offset: 0x0064E057
		// (set) Token: 0x0602E365 RID: 189285 RVA: 0x0064FE5F File Offset: 0x0064E05F
		public object Value { get; set; }

		// Token: 0x0602E366 RID: 189286 RVA: 0x0064FE68 File Offset: 0x0064E068
		public IChangeElementalBoxStateTarget_UnionUnion()
		{
			this.Type = IChangeElementalBoxStateTarget_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602E367 RID: 189287 RVA: 0x0064FE7E File Offset: 0x0064E07E
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602E368 RID: 189288 RVA: 0x0064FE90 File Offset: 0x0064E090
		public IChangeElementalBoxStateTargetT AsIChangeElementalBoxStateTarget()
		{
			return this.As<IChangeElementalBoxStateTargetT>();
		}

		// Token: 0x0602E369 RID: 189289 RVA: 0x0064FE98 File Offset: 0x0064E098
		public static IChangeElementalBoxStateTarget_UnionUnion FromIChangeElementalBoxStateTarget(IChangeElementalBoxStateTargetT _ichangeelementalboxstatetarget)
		{
			return new IChangeElementalBoxStateTarget_UnionUnion
			{
				Type = IChangeElementalBoxStateTarget_Union.IChangeElementalBoxStateTarget,
				Value = _ichangeelementalboxstatetarget
			};
		}

		// Token: 0x0602E36A RID: 189290 RVA: 0x0064FEAD File Offset: 0x0064E0AD
		public IChangeElementalBoxStatePlayerTargetT AsIChangeElementalBoxStatePlayerTarget()
		{
			return this.As<IChangeElementalBoxStatePlayerTargetT>();
		}

		// Token: 0x0602E36B RID: 189291 RVA: 0x0064FEB5 File Offset: 0x0064E0B5
		public static IChangeElementalBoxStateTarget_UnionUnion FromIChangeElementalBoxStatePlayerTarget(IChangeElementalBoxStatePlayerTargetT _ichangeelementalboxstateplayertarget)
		{
			return new IChangeElementalBoxStateTarget_UnionUnion
			{
				Type = IChangeElementalBoxStateTarget_Union.IChangeElementalBoxStatePlayerTarget,
				Value = _ichangeelementalboxstateplayertarget
			};
		}

		// Token: 0x0602E36C RID: 189292 RVA: 0x0064FECA File Offset: 0x0064E0CA
		public IChangeElementalBoxStateTargetBoxIdT AsIChangeElementalBoxStateTargetBoxId()
		{
			return this.As<IChangeElementalBoxStateTargetBoxIdT>();
		}

		// Token: 0x0602E36D RID: 189293 RVA: 0x0064FED2 File Offset: 0x0064E0D2
		public static IChangeElementalBoxStateTarget_UnionUnion FromIChangeElementalBoxStateTargetBoxId(IChangeElementalBoxStateTargetBoxIdT _ichangeelementalboxstatetargetboxid)
		{
			return new IChangeElementalBoxStateTarget_UnionUnion
			{
				Type = IChangeElementalBoxStateTarget_Union.IChangeElementalBoxStateTargetBoxId,
				Value = _ichangeelementalboxstatetargetboxid
			};
		}

		// Token: 0x0602E36E RID: 189294 RVA: 0x0064FEE8 File Offset: 0x0064E0E8
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
