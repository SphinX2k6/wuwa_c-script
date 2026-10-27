using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005546 RID: 21830
	public class IMechHookConfigType_UnionUnion
	{
		// Token: 0x1700A12B RID: 41259
		// (get) Token: 0x06024135 RID: 147765 RVA: 0x004FBE49 File Offset: 0x004FA049
		// (set) Token: 0x06024136 RID: 147766 RVA: 0x004FBE51 File Offset: 0x004FA051
		public IMechHookConfigType_Union Type { get; set; }

		// Token: 0x1700A12C RID: 41260
		// (get) Token: 0x06024137 RID: 147767 RVA: 0x004FBE5A File Offset: 0x004FA05A
		// (set) Token: 0x06024138 RID: 147768 RVA: 0x004FBE62 File Offset: 0x004FA062
		public object Value { get; set; }

		// Token: 0x06024139 RID: 147769 RVA: 0x004FBE6B File Offset: 0x004FA06B
		public IMechHookConfigType_UnionUnion()
		{
			this.Type = IMechHookConfigType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602413A RID: 147770 RVA: 0x004FBE81 File Offset: 0x004FA081
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602413B RID: 147771 RVA: 0x004FBE93 File Offset: 0x004FA093
		public IMechHookConfigTypeT AsIMechHookConfigType()
		{
			return this.As<IMechHookConfigTypeT>();
		}

		// Token: 0x0602413C RID: 147772 RVA: 0x004FBE9B File Offset: 0x004FA09B
		public static IMechHookConfigType_UnionUnion FromIMechHookConfigType(IMechHookConfigTypeT _imechhookconfigtype)
		{
			return new IMechHookConfigType_UnionUnion
			{
				Type = IMechHookConfigType_Union.IMechHookConfigType,
				Value = _imechhookconfigtype
			};
		}

		// Token: 0x0602413D RID: 147773 RVA: 0x004FBEB0 File Offset: 0x004FA0B0
		public IBurrowHookT AsIBurrowHook()
		{
			return this.As<IBurrowHookT>();
		}

		// Token: 0x0602413E RID: 147774 RVA: 0x004FBEB8 File Offset: 0x004FA0B8
		public static IMechHookConfigType_UnionUnion FromIBurrowHook(IBurrowHookT _iburrowhook)
		{
			return new IMechHookConfigType_UnionUnion
			{
				Type = IMechHookConfigType_Union.IBurrowHook,
				Value = _iburrowhook
			};
		}

		// Token: 0x0602413F RID: 147775 RVA: 0x004FBECD File Offset: 0x004FA0CD
		public IMechFixedPointHookT AsIMechFixedPointHook()
		{
			return this.As<IMechFixedPointHookT>();
		}

		// Token: 0x06024140 RID: 147776 RVA: 0x004FBED5 File Offset: 0x004FA0D5
		public static IMechHookConfigType_UnionUnion FromIMechFixedPointHook(IMechFixedPointHookT _imechfixedpointhook)
		{
			return new IMechHookConfigType_UnionUnion
			{
				Type = IMechHookConfigType_Union.IMechFixedPointHook,
				Value = _imechfixedpointhook
			};
		}

		// Token: 0x06024141 RID: 147777 RVA: 0x004FBEEC File Offset: 0x004FA0EC
		public static int Pack(FlatBufferBuilder builder, IMechHookConfigType_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IMechHookConfigType_Union.IMechHookConfigType:
				return IMechHookConfigType.Pack(builder, _o.AsIMechHookConfigType()).Value;
			case IMechHookConfigType_Union.IBurrowHook:
				return IBurrowHook.Pack(builder, _o.AsIBurrowHook()).Value;
			case IMechHookConfigType_Union.IMechFixedPointHook:
				return IMechFixedPointHook.Pack(builder, _o.AsIMechFixedPointHook()).Value;
			default:
				return 0;
			}
		}
	}
}
