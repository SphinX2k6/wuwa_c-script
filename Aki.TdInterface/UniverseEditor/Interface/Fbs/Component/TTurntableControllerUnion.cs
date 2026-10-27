using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005CCD RID: 23757
	public class TTurntableControllerUnion
	{
		// Token: 0x1700B266 RID: 45670
		// (get) Token: 0x06028A87 RID: 166535 RVA: 0x00595FC6 File Offset: 0x005941C6
		// (set) Token: 0x06028A88 RID: 166536 RVA: 0x00595FCE File Offset: 0x005941CE
		public TTurntableController Type { get; set; }

		// Token: 0x1700B267 RID: 45671
		// (get) Token: 0x06028A89 RID: 166537 RVA: 0x00595FD7 File Offset: 0x005941D7
		// (set) Token: 0x06028A8A RID: 166538 RVA: 0x00595FDF File Offset: 0x005941DF
		public object Value { get; set; }

		// Token: 0x06028A8B RID: 166539 RVA: 0x00595FE8 File Offset: 0x005941E8
		public TTurntableControllerUnion()
		{
			this.Type = TTurntableController.NONE;
			this.Value = null;
		}

		// Token: 0x06028A8C RID: 166540 RVA: 0x00595FFE File Offset: 0x005941FE
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06028A8D RID: 166541 RVA: 0x00596010 File Offset: 0x00594210
		public IFixedAngleTurntableT AsIFixedAngleTurntable()
		{
			return this.As<IFixedAngleTurntableT>();
		}

		// Token: 0x06028A8E RID: 166542 RVA: 0x00596018 File Offset: 0x00594218
		public static TTurntableControllerUnion FromIFixedAngleTurntable(IFixedAngleTurntableT _ifixedangleturntable)
		{
			return new TTurntableControllerUnion
			{
				Type = TTurntableController.IFixedAngleTurntable,
				Value = _ifixedangleturntable
			};
		}

		// Token: 0x06028A8F RID: 166543 RVA: 0x0059602D File Offset: 0x0059422D
		public IFreeAngleTurntableT AsIFreeAngleTurntable()
		{
			return this.As<IFreeAngleTurntableT>();
		}

		// Token: 0x06028A90 RID: 166544 RVA: 0x00596035 File Offset: 0x00594235
		public static TTurntableControllerUnion FromIFreeAngleTurntable(IFreeAngleTurntableT _ifreeangleturntable)
		{
			return new TTurntableControllerUnion
			{
				Type = TTurntableController.IFreeAngleTurntable,
				Value = _ifreeangleturntable
			};
		}

		// Token: 0x06028A91 RID: 166545 RVA: 0x0059604C File Offset: 0x0059424C
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
