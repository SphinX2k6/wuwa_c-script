using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006AF5 RID: 27381
	public class ICommonTip2Type_UnionUnion
	{
		// Token: 0x1700C918 RID: 51480
		// (get) Token: 0x0602F11E RID: 192798 RVA: 0x0066BD69 File Offset: 0x00669F69
		// (set) Token: 0x0602F11F RID: 192799 RVA: 0x0066BD71 File Offset: 0x00669F71
		public ICommonTip2Type_Union Type { get; set; }

		// Token: 0x1700C919 RID: 51481
		// (get) Token: 0x0602F120 RID: 192800 RVA: 0x0066BD7A File Offset: 0x00669F7A
		// (set) Token: 0x0602F121 RID: 192801 RVA: 0x0066BD82 File Offset: 0x00669F82
		public object Value { get; set; }

		// Token: 0x0602F122 RID: 192802 RVA: 0x0066BD8B File Offset: 0x00669F8B
		public ICommonTip2Type_UnionUnion()
		{
			this.Type = ICommonTip2Type_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602F123 RID: 192803 RVA: 0x0066BDA1 File Offset: 0x00669FA1
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602F124 RID: 192804 RVA: 0x0066BDB3 File Offset: 0x00669FB3
		public ICommonTip2TypeT AsICommonTip2Type()
		{
			return this.As<ICommonTip2TypeT>();
		}

		// Token: 0x0602F125 RID: 192805 RVA: 0x0066BDBB File Offset: 0x00669FBB
		public static ICommonTip2Type_UnionUnion FromICommonTip2Type(ICommonTip2TypeT _icommontip2type)
		{
			return new ICommonTip2Type_UnionUnion
			{
				Type = ICommonTip2Type_Union.ICommonTip2Type,
				Value = _icommontip2type
			};
		}

		// Token: 0x0602F126 RID: 192806 RVA: 0x0066BDD0 File Offset: 0x00669FD0
		public ICommonTip2PrepareCountdownT AsICommonTip2PrepareCountdown()
		{
			return this.As<ICommonTip2PrepareCountdownT>();
		}

		// Token: 0x0602F127 RID: 192807 RVA: 0x0066BDD8 File Offset: 0x00669FD8
		public static ICommonTip2Type_UnionUnion FromICommonTip2PrepareCountdown(ICommonTip2PrepareCountdownT _icommontip2preparecountdown)
		{
			return new ICommonTip2Type_UnionUnion
			{
				Type = ICommonTip2Type_Union.ICommonTip2PrepareCountdown,
				Value = _icommontip2preparecountdown
			};
		}

		// Token: 0x0602F128 RID: 192808 RVA: 0x0066BDF0 File Offset: 0x00669FF0
		public static int Pack(FlatBufferBuilder builder, ICommonTip2Type_UnionUnion _o)
		{
			ICommonTip2Type_Union type = _o.Type;
			if (type == ICommonTip2Type_Union.ICommonTip2Type)
			{
				return ICommonTip2Type.Pack(builder, _o.AsICommonTip2Type()).Value;
			}
			if (type != ICommonTip2Type_Union.ICommonTip2PrepareCountdown)
			{
				return 0;
			}
			return ICommonTip2PrepareCountdown.Pack(builder, _o.AsICommonTip2PrepareCountdown()).Value;
		}
	}
}
