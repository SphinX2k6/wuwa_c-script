using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007732 RID: 30514
	public class TMoveToPointTypeUnion
	{
		// Token: 0x1700E665 RID: 58981
		// (get) Token: 0x06037734 RID: 227124 RVA: 0x00781DD6 File Offset: 0x0077FFD6
		// (set) Token: 0x06037735 RID: 227125 RVA: 0x00781DDE File Offset: 0x0077FFDE
		public TMoveToPointType Type { get; set; }

		// Token: 0x1700E666 RID: 58982
		// (get) Token: 0x06037736 RID: 227126 RVA: 0x00781DE7 File Offset: 0x0077FFE7
		// (set) Token: 0x06037737 RID: 227127 RVA: 0x00781DEF File Offset: 0x0077FFEF
		public object Value { get; set; }

		// Token: 0x06037738 RID: 227128 RVA: 0x00781DF8 File Offset: 0x0077FFF8
		public TMoveToPointTypeUnion()
		{
			this.Type = TMoveToPointType.NONE;
			this.Value = null;
		}

		// Token: 0x06037739 RID: 227129 RVA: 0x00781E0E File Offset: 0x0078000E
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603773A RID: 227130 RVA: 0x00781E20 File Offset: 0x00780020
		public IUniformMotionT AsIUniformMotion()
		{
			return this.As<IUniformMotionT>();
		}

		// Token: 0x0603773B RID: 227131 RVA: 0x00781E28 File Offset: 0x00780028
		public static TMoveToPointTypeUnion FromIUniformMotion(IUniformMotionT _iuniformmotion)
		{
			return new TMoveToPointTypeUnion
			{
				Type = TMoveToPointType.IUniformMotion,
				Value = _iuniformmotion
			};
		}

		// Token: 0x0603773C RID: 227132 RVA: 0x00781E3D File Offset: 0x0078003D
		public IVariableMotionT AsIVariableMotion()
		{
			return this.As<IVariableMotionT>();
		}

		// Token: 0x0603773D RID: 227133 RVA: 0x00781E45 File Offset: 0x00780045
		public static TMoveToPointTypeUnion FromIVariableMotion(IVariableMotionT _ivariablemotion)
		{
			return new TMoveToPointTypeUnion
			{
				Type = TMoveToPointType.IVariableMotion,
				Value = _ivariablemotion
			};
		}

		// Token: 0x0603773E RID: 227134 RVA: 0x00781E5C File Offset: 0x0078005C
		public static int Pack(FlatBufferBuilder builder, TMoveToPointTypeUnion _o)
		{
			TMoveToPointType type = _o.Type;
			if (type == TMoveToPointType.IUniformMotion)
			{
				return IUniformMotion.Pack(builder, _o.AsIUniformMotion()).Value;
			}
			if (type != TMoveToPointType.IVariableMotion)
			{
				return 0;
			}
			return IVariableMotion.Pack(builder, _o.AsIVariableMotion()).Value;
		}
	}
}
