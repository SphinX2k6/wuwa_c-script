using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006301 RID: 25345
	public class TTurntableControllerUnion
	{
		// Token: 0x1700BBC2 RID: 48066
		// (get) Token: 0x0602B0DB RID: 176347 RVA: 0x005DE836 File Offset: 0x005DCA36
		// (set) Token: 0x0602B0DC RID: 176348 RVA: 0x005DE83E File Offset: 0x005DCA3E
		public TTurntableController Type { get; set; }

		// Token: 0x1700BBC3 RID: 48067
		// (get) Token: 0x0602B0DD RID: 176349 RVA: 0x005DE847 File Offset: 0x005DCA47
		// (set) Token: 0x0602B0DE RID: 176350 RVA: 0x005DE84F File Offset: 0x005DCA4F
		public object Value { get; set; }

		// Token: 0x0602B0DF RID: 176351 RVA: 0x005DE858 File Offset: 0x005DCA58
		public TTurntableControllerUnion()
		{
			this.Type = TTurntableController.NONE;
			this.Value = null;
		}

		// Token: 0x0602B0E0 RID: 176352 RVA: 0x005DE86E File Offset: 0x005DCA6E
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602B0E1 RID: 176353 RVA: 0x005DE880 File Offset: 0x005DCA80
		public IFixedAngleTurntableT AsIFixedAngleTurntable()
		{
			return this.As<IFixedAngleTurntableT>();
		}

		// Token: 0x0602B0E2 RID: 176354 RVA: 0x005DE888 File Offset: 0x005DCA88
		public static TTurntableControllerUnion FromIFixedAngleTurntable(IFixedAngleTurntableT _ifixedangleturntable)
		{
			return new TTurntableControllerUnion
			{
				Type = TTurntableController.IFixedAngleTurntable,
				Value = _ifixedangleturntable
			};
		}

		// Token: 0x0602B0E3 RID: 176355 RVA: 0x005DE89D File Offset: 0x005DCA9D
		public IFreeAngleTurntableT AsIFreeAngleTurntable()
		{
			return this.As<IFreeAngleTurntableT>();
		}

		// Token: 0x0602B0E4 RID: 176356 RVA: 0x005DE8A5 File Offset: 0x005DCAA5
		public static TTurntableControllerUnion FromIFreeAngleTurntable(IFreeAngleTurntableT _ifreeangleturntable)
		{
			return new TTurntableControllerUnion
			{
				Type = TTurntableController.IFreeAngleTurntable,
				Value = _ifreeangleturntable
			};
		}

		// Token: 0x0602B0E5 RID: 176357 RVA: 0x005DE8BC File Offset: 0x005DCABC
		public static int Pack(FlatBufferBuilder builder, TTurntableControllerUnion _o)
		{
			TTurntableController type = _o.Type;
			if (type == TTurntableController.IFixedAngleTurntable)
			{
				return IFixedAngleTurntable.Pack(builder, _o.AsIFixedAngleTurntable()).Value;
			}
			if (type != TTurntableController.IFreeAngleTurntable)
			{
				return 0;
			}
			return IFreeAngleTurntable.Pack(builder, _o.AsIFreeAngleTurntable()).Value;
		}
	}
}
