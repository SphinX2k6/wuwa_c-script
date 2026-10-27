using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E9B RID: 28315
	public class IResetPlayerFocusType_UnionUnion
	{
		// Token: 0x1700D2D2 RID: 53970
		// (get) Token: 0x060320AB RID: 204971 RVA: 0x006C497D File Offset: 0x006C2B7D
		// (set) Token: 0x060320AC RID: 204972 RVA: 0x006C4985 File Offset: 0x006C2B85
		public IResetPlayerFocusType_Union Type { get; set; }

		// Token: 0x1700D2D3 RID: 53971
		// (get) Token: 0x060320AD RID: 204973 RVA: 0x006C498E File Offset: 0x006C2B8E
		// (set) Token: 0x060320AE RID: 204974 RVA: 0x006C4996 File Offset: 0x006C2B96
		public object Value { get; set; }

		// Token: 0x060320AF RID: 204975 RVA: 0x006C499F File Offset: 0x006C2B9F
		public IResetPlayerFocusType_UnionUnion()
		{
			this.Type = IResetPlayerFocusType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060320B0 RID: 204976 RVA: 0x006C49B5 File Offset: 0x006C2BB5
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060320B1 RID: 204977 RVA: 0x006C49C7 File Offset: 0x006C2BC7
		public IResetPlayerFocusTypeT AsIResetPlayerFocusType()
		{
			return this.As<IResetPlayerFocusTypeT>();
		}

		// Token: 0x060320B2 RID: 204978 RVA: 0x006C49CF File Offset: 0x006C2BCF
		public static IResetPlayerFocusType_UnionUnion FromIResetPlayerFocusType(IResetPlayerFocusTypeT _iresetplayerfocustype)
		{
			return new IResetPlayerFocusType_UnionUnion
			{
				Type = IResetPlayerFocusType_Union.IResetPlayerFocusType,
				Value = _iresetplayerfocustype
			};
		}

		// Token: 0x060320B3 RID: 204979 RVA: 0x006C49E4 File Offset: 0x006C2BE4
		public IResetPlayerFocusToDefaultDirectionT AsIResetPlayerFocusToDefaultDirection()
		{
			return this.As<IResetPlayerFocusToDefaultDirectionT>();
		}

		// Token: 0x060320B4 RID: 204980 RVA: 0x006C49EC File Offset: 0x006C2BEC
		public static IResetPlayerFocusType_UnionUnion FromIResetPlayerFocusToDefaultDirection(IResetPlayerFocusToDefaultDirectionT _iresetplayerfocustodefaultdirection)
		{
			return new IResetPlayerFocusType_UnionUnion
			{
				Type = IResetPlayerFocusType_Union.IResetPlayerFocusToDefaultDirection,
				Value = _iresetplayerfocustodefaultdirection
			};
		}

		// Token: 0x060320B5 RID: 204981 RVA: 0x006C4A01 File Offset: 0x006C2C01
		public IResetPlayerFocusToFixedDirectionT AsIResetPlayerFocusToFixedDirection()
		{
			return this.As<IResetPlayerFocusToFixedDirectionT>();
		}

		// Token: 0x060320B6 RID: 204982 RVA: 0x006C4A09 File Offset: 0x006C2C09
		public static IResetPlayerFocusType_UnionUnion FromIResetPlayerFocusToFixedDirection(IResetPlayerFocusToFixedDirectionT _iresetplayerfocustofixeddirection)
		{
			return new IResetPlayerFocusType_UnionUnion
			{
				Type = IResetPlayerFocusType_Union.IResetPlayerFocusToFixedDirection,
				Value = _iresetplayerfocustofixeddirection
			};
		}

		// Token: 0x060320B7 RID: 204983 RVA: 0x006C4A20 File Offset: 0x006C2C20
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
