using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020055CC RID: 21964
	public class ICycleModeType_UnionUnion
	{
		// Token: 0x17009D3B RID: 40251
		// (get) Token: 0x06022F15 RID: 143125 RVA: 0x004CF551 File Offset: 0x004CD751
		// (set) Token: 0x06022F16 RID: 143126 RVA: 0x004CF559 File Offset: 0x004CD759
		public ICycleModeType_Union Type { get; set; }

		// Token: 0x17009D3C RID: 40252
		// (get) Token: 0x06022F17 RID: 143127 RVA: 0x004CF562 File Offset: 0x004CD762
		// (set) Token: 0x06022F18 RID: 143128 RVA: 0x004CF56A File Offset: 0x004CD76A
		public object Value { get; set; }

		// Token: 0x06022F19 RID: 143129 RVA: 0x004CF573 File Offset: 0x004CD773
		public ICycleModeType_UnionUnion()
		{
			this.Type = ICycleModeType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06022F1A RID: 143130 RVA: 0x004CF589 File Offset: 0x004CD789
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06022F1B RID: 143131 RVA: 0x004CF59B File Offset: 0x004CD79B
		public ICycleModeTypeT AsICycleModeType()
		{
			return this.As<ICycleModeTypeT>();
		}

		// Token: 0x06022F1C RID: 143132 RVA: 0x004CF5A3 File Offset: 0x004CD7A3
		public static ICycleModeType_UnionUnion FromICycleModeType(ICycleModeTypeT _icyclemodetype)
		{
			return new ICycleModeType_UnionUnion
			{
				Type = ICycleModeType_Union.ICycleModeType,
				Value = _icyclemodetype
			};
		}

		// Token: 0x06022F1D RID: 143133 RVA: 0x004CF5B8 File Offset: 0x004CD7B8
		public IPatrolCycleLooplyT AsIPatrolCycleLooply()
		{
			return this.As<IPatrolCycleLooplyT>();
		}

		// Token: 0x06022F1E RID: 143134 RVA: 0x004CF5C0 File Offset: 0x004CD7C0
		public static ICycleModeType_UnionUnion FromIPatrolCycleLooply(IPatrolCycleLooplyT _ipatrolcyclelooply)
		{
			return new ICycleModeType_UnionUnion
			{
				Type = ICycleModeType_Union.IPatrolCycleLooply,
				Value = _ipatrolcyclelooply
			};
		}

		// Token: 0x06022F1F RID: 143135 RVA: 0x004CF5D5 File Offset: 0x004CD7D5
		public IPatrolCycleOncelyT AsIPatrolCycleOncely()
		{
			return this.As<IPatrolCycleOncelyT>();
		}

		// Token: 0x06022F20 RID: 143136 RVA: 0x004CF5DD File Offset: 0x004CD7DD
		public static ICycleModeType_UnionUnion FromIPatrolCycleOncely(IPatrolCycleOncelyT _ipatrolcycleoncely)
		{
			return new ICycleModeType_UnionUnion
			{
				Type = ICycleModeType_Union.IPatrolCycleOncely,
				Value = _ipatrolcycleoncely
			};
		}

		// Token: 0x06022F21 RID: 143137 RVA: 0x004CF5F4 File Offset: 0x004CD7F4
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
