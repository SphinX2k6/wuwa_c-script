using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200506A RID: 20586
	public class ICycleModeType_UnionUnion
	{
		// Token: 0x17009555 RID: 38229
		// (get) Token: 0x06020FDB RID: 135131 RVA: 0x0049589D File Offset: 0x00493A9D
		// (set) Token: 0x06020FDC RID: 135132 RVA: 0x004958A5 File Offset: 0x00493AA5
		public ICycleModeType_Union Type { get; set; }

		// Token: 0x17009556 RID: 38230
		// (get) Token: 0x06020FDD RID: 135133 RVA: 0x004958AE File Offset: 0x00493AAE
		// (set) Token: 0x06020FDE RID: 135134 RVA: 0x004958B6 File Offset: 0x00493AB6
		public object Value { get; set; }

		// Token: 0x06020FDF RID: 135135 RVA: 0x004958BF File Offset: 0x00493ABF
		public ICycleModeType_UnionUnion()
		{
			this.Type = ICycleModeType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06020FE0 RID: 135136 RVA: 0x004958D5 File Offset: 0x00493AD5
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06020FE1 RID: 135137 RVA: 0x004958E7 File Offset: 0x00493AE7
		public ICycleModeTypeT AsICycleModeType()
		{
			return this.As<ICycleModeTypeT>();
		}

		// Token: 0x06020FE2 RID: 135138 RVA: 0x004958EF File Offset: 0x00493AEF
		public static ICycleModeType_UnionUnion FromICycleModeType(ICycleModeTypeT _icyclemodetype)
		{
			return new ICycleModeType_UnionUnion
			{
				Type = ICycleModeType_Union.ICycleModeType,
				Value = _icyclemodetype
			};
		}

		// Token: 0x06020FE3 RID: 135139 RVA: 0x00495904 File Offset: 0x00493B04
		public IPatrolCycleLooplyT AsIPatrolCycleLooply()
		{
			return this.As<IPatrolCycleLooplyT>();
		}

		// Token: 0x06020FE4 RID: 135140 RVA: 0x0049590C File Offset: 0x00493B0C
		public static ICycleModeType_UnionUnion FromIPatrolCycleLooply(IPatrolCycleLooplyT _ipatrolcyclelooply)
		{
			return new ICycleModeType_UnionUnion
			{
				Type = ICycleModeType_Union.IPatrolCycleLooply,
				Value = _ipatrolcyclelooply
			};
		}

		// Token: 0x06020FE5 RID: 135141 RVA: 0x00495921 File Offset: 0x00493B21
		public IPatrolCycleOncelyT AsIPatrolCycleOncely()
		{
			return this.As<IPatrolCycleOncelyT>();
		}

		// Token: 0x06020FE6 RID: 135142 RVA: 0x00495929 File Offset: 0x00493B29
		public static ICycleModeType_UnionUnion FromIPatrolCycleOncely(IPatrolCycleOncelyT _ipatrolcycleoncely)
		{
			return new ICycleModeType_UnionUnion
			{
				Type = ICycleModeType_Union.IPatrolCycleOncely,
				Value = _ipatrolcycleoncely
			};
		}

		// Token: 0x06020FE7 RID: 135143 RVA: 0x00495940 File Offset: 0x00493B40
		public static int Pack(FlatBufferBuilder builder, ICycleModeType_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case ICycleModeType_Union.ICycleModeType:
				return ICycleModeType.Pack(builder, _o.AsICycleModeType()).Value;
			case ICycleModeType_Union.IPatrolCycleLooply:
				return IPatrolCycleLooply.Pack(builder, _o.AsIPatrolCycleLooply()).Value;
			case ICycleModeType_Union.IPatrolCycleOncely:
				return IPatrolCycleOncely.Pack(builder, _o.AsIPatrolCycleOncely()).Value;
			default:
				return 0;
			}
		}
	}
}
