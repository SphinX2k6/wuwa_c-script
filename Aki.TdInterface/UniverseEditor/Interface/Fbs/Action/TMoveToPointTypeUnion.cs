using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007F5B RID: 32603
	public class TMoveToPointTypeUnion
	{
		// Token: 0x1700F2B5 RID: 62133
		// (get) Token: 0x0603AC6F RID: 240751 RVA: 0x007E6D66 File Offset: 0x007E4F66
		// (set) Token: 0x0603AC70 RID: 240752 RVA: 0x007E6D6E File Offset: 0x007E4F6E
		public TMoveToPointType Type { get; set; }

		// Token: 0x1700F2B6 RID: 62134
		// (get) Token: 0x0603AC71 RID: 240753 RVA: 0x007E6D77 File Offset: 0x007E4F77
		// (set) Token: 0x0603AC72 RID: 240754 RVA: 0x007E6D7F File Offset: 0x007E4F7F
		public object Value { get; set; }

		// Token: 0x0603AC73 RID: 240755 RVA: 0x007E6D88 File Offset: 0x007E4F88
		public TMoveToPointTypeUnion()
		{
			this.Type = TMoveToPointType.NONE;
			this.Value = null;
		}

		// Token: 0x0603AC74 RID: 240756 RVA: 0x007E6D9E File Offset: 0x007E4F9E
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603AC75 RID: 240757 RVA: 0x007E6DB0 File Offset: 0x007E4FB0
		public IUniformMotionT AsIUniformMotion()
		{
			return this.As<IUniformMotionT>();
		}

		// Token: 0x0603AC76 RID: 240758 RVA: 0x007E6DB8 File Offset: 0x007E4FB8
		public static TMoveToPointTypeUnion FromIUniformMotion(IUniformMotionT _iuniformmotion)
		{
			return new TMoveToPointTypeUnion
			{
				Type = TMoveToPointType.IUniformMotion,
				Value = _iuniformmotion
			};
		}

		// Token: 0x0603AC77 RID: 240759 RVA: 0x007E6DCD File Offset: 0x007E4FCD
		public IVariableMotionT AsIVariableMotion()
		{
			return this.As<IVariableMotionT>();
		}

		// Token: 0x0603AC78 RID: 240760 RVA: 0x007E6DD5 File Offset: 0x007E4FD5
		public static TMoveToPointTypeUnion FromIVariableMotion(IVariableMotionT _ivariablemotion)
		{
			return new TMoveToPointTypeUnion
			{
				Type = TMoveToPointType.IVariableMotion,
				Value = _ivariablemotion
			};
		}

		// Token: 0x0603AC79 RID: 240761 RVA: 0x007E6DEC File Offset: 0x007E4FEC
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
