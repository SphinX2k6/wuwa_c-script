using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200648A RID: 25738
	public class ICommonTip2Type_UnionUnion
	{
		// Token: 0x1700BF8B RID: 49035
		// (get) Token: 0x0602C9A4 RID: 182692 RVA: 0x00620195 File Offset: 0x0061E395
		// (set) Token: 0x0602C9A5 RID: 182693 RVA: 0x0062019D File Offset: 0x0061E39D
		public ICommonTip2Type_Union Type { get; set; }

		// Token: 0x1700BF8C RID: 49036
		// (get) Token: 0x0602C9A6 RID: 182694 RVA: 0x006201A6 File Offset: 0x0061E3A6
		// (set) Token: 0x0602C9A7 RID: 182695 RVA: 0x006201AE File Offset: 0x0061E3AE
		public object Value { get; set; }

		// Token: 0x0602C9A8 RID: 182696 RVA: 0x006201B7 File Offset: 0x0061E3B7
		public ICommonTip2Type_UnionUnion()
		{
			this.Type = ICommonTip2Type_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602C9A9 RID: 182697 RVA: 0x006201CD File Offset: 0x0061E3CD
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602C9AA RID: 182698 RVA: 0x006201DF File Offset: 0x0061E3DF
		public ICommonTip2TypeT AsICommonTip2Type()
		{
			return this.As<ICommonTip2TypeT>();
		}

		// Token: 0x0602C9AB RID: 182699 RVA: 0x006201E7 File Offset: 0x0061E3E7
		public static ICommonTip2Type_UnionUnion FromICommonTip2Type(ICommonTip2TypeT _icommontip2type)
		{
			return new ICommonTip2Type_UnionUnion
			{
				Type = ICommonTip2Type_Union.ICommonTip2Type,
				Value = _icommontip2type
			};
		}

		// Token: 0x0602C9AC RID: 182700 RVA: 0x006201FC File Offset: 0x0061E3FC
		public ICommonTip2PrepareCountdownT AsICommonTip2PrepareCountdown()
		{
			return this.As<ICommonTip2PrepareCountdownT>();
		}

		// Token: 0x0602C9AD RID: 182701 RVA: 0x00620204 File Offset: 0x0061E404
		public static ICommonTip2Type_UnionUnion FromICommonTip2PrepareCountdown(ICommonTip2PrepareCountdownT _icommontip2preparecountdown)
		{
			return new ICommonTip2Type_UnionUnion
			{
				Type = ICommonTip2Type_Union.ICommonTip2PrepareCountdown,
				Value = _icommontip2preparecountdown
			};
		}

		// Token: 0x0602C9AE RID: 182702 RVA: 0x0062021C File Offset: 0x0061E41C
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
