using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200778A RID: 30602
	public class TSetTeleControlConfigUnion
	{
		// Token: 0x1700E69F RID: 59039
		// (get) Token: 0x060378EA RID: 227562 RVA: 0x007846DC File Offset: 0x007828DC
		// (set) Token: 0x060378EB RID: 227563 RVA: 0x007846E4 File Offset: 0x007828E4
		public TSetTeleControlConfig Type { get; set; }

		// Token: 0x1700E6A0 RID: 59040
		// (get) Token: 0x060378EC RID: 227564 RVA: 0x007846ED File Offset: 0x007828ED
		// (set) Token: 0x060378ED RID: 227565 RVA: 0x007846F5 File Offset: 0x007828F5
		public object Value { get; set; }

		// Token: 0x060378EE RID: 227566 RVA: 0x007846FE File Offset: 0x007828FE
		public TSetTeleControlConfigUnion()
		{
			this.Type = TSetTeleControlConfig.NONE;
			this.Value = null;
		}

		// Token: 0x060378EF RID: 227567 RVA: 0x00784714 File Offset: 0x00782914
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060378F0 RID: 227568 RVA: 0x00784726 File Offset: 0x00782926
		public IOpenGravityT AsIOpenGravity()
		{
			return this.As<IOpenGravityT>();
		}

		// Token: 0x060378F1 RID: 227569 RVA: 0x0078472E File Offset: 0x0078292E
		public static TSetTeleControlConfigUnion FromIOpenGravity(IOpenGravityT _iopengravity)
		{
			return new TSetTeleControlConfigUnion
			{
				Type = TSetTeleControlConfig.IOpenGravity,
				Value = _iopengravity
			};
		}

		// Token: 0x060378F2 RID: 227570 RVA: 0x00784743 File Offset: 0x00782943
		public ISetResetPositionT AsISetResetPosition()
		{
			return this.As<ISetResetPositionT>();
		}

		// Token: 0x060378F3 RID: 227571 RVA: 0x0078474B File Offset: 0x0078294B
		public static TSetTeleControlConfigUnion FromISetResetPosition(ISetResetPositionT _isetresetposition)
		{
			return new TSetTeleControlConfigUnion
			{
				Type = TSetTeleControlConfig.ISetResetPosition,
				Value = _isetresetposition
			};
		}

		// Token: 0x060378F4 RID: 227572 RVA: 0x00784760 File Offset: 0x00782960
		public static int Pack(FlatBufferBuilder builder, TSetTeleControlConfigUnion _o)
		{
			TSetTeleControlConfig type = _o.Type;
			if (type == TSetTeleControlConfig.IOpenGravity)
			{
				return IOpenGravity.Pack(builder, _o.AsIOpenGravity()).Value;
			}
			if (type != TSetTeleControlConfig.ISetResetPosition)
			{
				return 0;
			}
			return ISetResetPosition.Pack(builder, _o.AsISetResetPosition()).Value;
		}
	}
}
