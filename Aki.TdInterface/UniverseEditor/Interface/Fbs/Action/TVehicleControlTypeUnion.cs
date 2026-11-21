using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200803D RID: 32829
	public class TVehicleControlTypeUnion
	{
		// Token: 0x1700F34B RID: 62283
		// (get) Token: 0x0603B109 RID: 241929 RVA: 0x007EDD5E File Offset: 0x007EBF5E
		// (set) Token: 0x0603B10A RID: 241930 RVA: 0x007EDD66 File Offset: 0x007EBF66
		public TVehicleControlType Type { get; set; }

		// Token: 0x1700F34C RID: 62284
		// (get) Token: 0x0603B10B RID: 241931 RVA: 0x007EDD6F File Offset: 0x007EBF6F
		// (set) Token: 0x0603B10C RID: 241932 RVA: 0x007EDD77 File Offset: 0x007EBF77
		public object Value { get; set; }

		// Token: 0x0603B10D RID: 241933 RVA: 0x007EDD80 File Offset: 0x007EBF80
		public TVehicleControlTypeUnion()
		{
			this.Type = TVehicleControlType.NONE;
			this.Value = null;
		}

		// Token: 0x0603B10E RID: 241934 RVA: 0x007EDD96 File Offset: 0x007EBF96
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603B10F RID: 241935 RVA: 0x007EDDA8 File Offset: 0x007EBFA8
		public IVehicleEnterPathMoveT AsIVehicleEnterPathMove()
		{
			return this.As<IVehicleEnterPathMoveT>();
		}

		// Token: 0x0603B110 RID: 241936 RVA: 0x007EDDB0 File Offset: 0x007EBFB0
		public static TVehicleControlTypeUnion FromIVehicleEnterPathMove(IVehicleEnterPathMoveT _ivehicleenterpathmove)
		{
			return new TVehicleControlTypeUnion
			{
				Type = TVehicleControlType.IVehicleEnterPathMove,
				Value = _ivehicleenterpathmove
			};
		}

		// Token: 0x0603B111 RID: 241937 RVA: 0x007EDDC5 File Offset: 0x007EBFC5
		public IVehicleExitPathMoveT AsIVehicleExitPathMove()
		{
			return this.As<IVehicleExitPathMoveT>();
		}

		// Token: 0x0603B112 RID: 241938 RVA: 0x007EDDCD File Offset: 0x007EBFCD
		public static TVehicleControlTypeUnion FromIVehicleExitPathMove(IVehicleExitPathMoveT _ivehicleexitpathmove)
		{
			return new TVehicleControlTypeUnion
			{
				Type = TVehicleControlType.IVehicleExitPathMove,
				Value = _ivehicleexitpathmove
			};
		}

		// Token: 0x0603B113 RID: 241939 RVA: 0x007EDDE4 File Offset: 0x007EBFE4
		public static int Pack(FlatBufferBuilder builder, TVehicleControlTypeUnion _o)
		{
			TVehicleControlType type = _o.Type;
			if (type == TVehicleControlType.IVehicleEnterPathMove)
			{
				return IVehicleEnterPathMove.Pack(builder, _o.AsIVehicleEnterPathMove()).Value;
			}
			if (type != TVehicleControlType.IVehicleExitPathMove)
			{
				return 0;
			}
			return IVehicleExitPathMove.Pack(builder, _o.AsIVehicleExitPathMove()).Value;
		}
	}
}
