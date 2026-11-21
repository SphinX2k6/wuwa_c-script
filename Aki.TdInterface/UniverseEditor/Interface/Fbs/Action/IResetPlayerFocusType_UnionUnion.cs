using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200761F RID: 30239
	public class IResetPlayerFocusType_UnionUnion
	{
		// Token: 0x1700DE29 RID: 56873
		// (get) Token: 0x060350EB RID: 217323 RVA: 0x007206B1 File Offset: 0x0071E8B1
		// (set) Token: 0x060350EC RID: 217324 RVA: 0x007206B9 File Offset: 0x0071E8B9
		public IResetPlayerFocusType_Union Type { get; set; }

		// Token: 0x1700DE2A RID: 56874
		// (get) Token: 0x060350ED RID: 217325 RVA: 0x007206C2 File Offset: 0x0071E8C2
		// (set) Token: 0x060350EE RID: 217326 RVA: 0x007206CA File Offset: 0x0071E8CA
		public object Value { get; set; }

		// Token: 0x060350EF RID: 217327 RVA: 0x007206D3 File Offset: 0x0071E8D3
		public IResetPlayerFocusType_UnionUnion()
		{
			this.Type = IResetPlayerFocusType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060350F0 RID: 217328 RVA: 0x007206E9 File Offset: 0x0071E8E9
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060350F1 RID: 217329 RVA: 0x007206FB File Offset: 0x0071E8FB
		public IResetPlayerFocusTypeT AsIResetPlayerFocusType()
		{
			return this.As<IResetPlayerFocusTypeT>();
		}

		// Token: 0x060350F2 RID: 217330 RVA: 0x00720703 File Offset: 0x0071E903
		public static IResetPlayerFocusType_UnionUnion FromIResetPlayerFocusType(IResetPlayerFocusTypeT _iresetplayerfocustype)
		{
			return new IResetPlayerFocusType_UnionUnion
			{
				Type = IResetPlayerFocusType_Union.IResetPlayerFocusType,
				Value = _iresetplayerfocustype
			};
		}

		// Token: 0x060350F3 RID: 217331 RVA: 0x00720718 File Offset: 0x0071E918
		public IResetPlayerFocusToDefaultDirectionT AsIResetPlayerFocusToDefaultDirection()
		{
			return this.As<IResetPlayerFocusToDefaultDirectionT>();
		}

		// Token: 0x060350F4 RID: 217332 RVA: 0x00720720 File Offset: 0x0071E920
		public static IResetPlayerFocusType_UnionUnion FromIResetPlayerFocusToDefaultDirection(IResetPlayerFocusToDefaultDirectionT _iresetplayerfocustodefaultdirection)
		{
			return new IResetPlayerFocusType_UnionUnion
			{
				Type = IResetPlayerFocusType_Union.IResetPlayerFocusToDefaultDirection,
				Value = _iresetplayerfocustodefaultdirection
			};
		}

		// Token: 0x060350F5 RID: 217333 RVA: 0x00720735 File Offset: 0x0071E935
		public IResetPlayerFocusToFixedDirectionT AsIResetPlayerFocusToFixedDirection()
		{
			return this.As<IResetPlayerFocusToFixedDirectionT>();
		}

		// Token: 0x060350F6 RID: 217334 RVA: 0x0072073D File Offset: 0x0071E93D
		public static IResetPlayerFocusType_UnionUnion FromIResetPlayerFocusToFixedDirection(IResetPlayerFocusToFixedDirectionT _iresetplayerfocustofixeddirection)
		{
			return new IResetPlayerFocusType_UnionUnion
			{
				Type = IResetPlayerFocusType_Union.IResetPlayerFocusToFixedDirection,
				Value = _iresetplayerfocustofixeddirection
			};
		}

		// Token: 0x060350F7 RID: 217335 RVA: 0x00720754 File Offset: 0x0071E954
		public static int Pack(FlatBufferBuilder builder, IResetPlayerFocusType_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IResetPlayerFocusType_Union.IResetPlayerFocusType:
				return IResetPlayerFocusType.Pack(builder, _o.AsIResetPlayerFocusType()).Value;
			case IResetPlayerFocusType_Union.IResetPlayerFocusToDefaultDirection:
				return IResetPlayerFocusToDefaultDirection.Pack(builder, _o.AsIResetPlayerFocusToDefaultDirection()).Value;
			case IResetPlayerFocusType_Union.IResetPlayerFocusToFixedDirection:
				return IResetPlayerFocusToFixedDirection.Pack(builder, _o.AsIResetPlayerFocusToFixedDirection()).Value;
			default:
				return 0;
			}
		}
	}
}
