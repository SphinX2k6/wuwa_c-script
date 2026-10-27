using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020077A5 RID: 30629
	public class TSportStateUnion
	{
		// Token: 0x1700E6B1 RID: 59057
		// (get) Token: 0x06037962 RID: 227682 RVA: 0x00785166 File Offset: 0x00783366
		// (set) Token: 0x06037963 RID: 227683 RVA: 0x0078516E File Offset: 0x0078336E
		public TSportState Type { get; set; }

		// Token: 0x1700E6B2 RID: 59058
		// (get) Token: 0x06037964 RID: 227684 RVA: 0x00785177 File Offset: 0x00783377
		// (set) Token: 0x06037965 RID: 227685 RVA: 0x0078517F File Offset: 0x0078337F
		public object Value { get; set; }

		// Token: 0x06037966 RID: 227686 RVA: 0x00785188 File Offset: 0x00783388
		public TSportStateUnion()
		{
			this.Type = TSportState.NONE;
			this.Value = null;
		}

		// Token: 0x06037967 RID: 227687 RVA: 0x0078519E File Offset: 0x0078339E
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06037968 RID: 227688 RVA: 0x007851B0 File Offset: 0x007833B0
		public IPetalGrabConfigT AsIPetalGrabConfig()
		{
			return this.As<IPetalGrabConfigT>();
		}

		// Token: 0x06037969 RID: 227689 RVA: 0x007851B8 File Offset: 0x007833B8
		public static TSportStateUnion FromIPetalGrabConfig(IPetalGrabConfigT _ipetalgrabconfig)
		{
			return new TSportStateUnion
			{
				Type = TSportState.IPetalGrabConfig,
				Value = _ipetalgrabconfig
			};
		}

		// Token: 0x0603796A RID: 227690 RVA: 0x007851CD File Offset: 0x007833CD
		public ISkiConfigT AsISkiConfig()
		{
			return this.As<ISkiConfigT>();
		}

		// Token: 0x0603796B RID: 227691 RVA: 0x007851D5 File Offset: 0x007833D5
		public static TSportStateUnion FromISkiConfig(ISkiConfigT _iskiconfig)
		{
			return new TSportStateUnion
			{
				Type = TSportState.ISkiConfig,
				Value = _iskiconfig
			};
		}

		// Token: 0x0603796C RID: 227692 RVA: 0x007851EA File Offset: 0x007833EA
		public ISlideConfigT AsISlideConfig()
		{
			return this.As<ISlideConfigT>();
		}

		// Token: 0x0603796D RID: 227693 RVA: 0x007851F2 File Offset: 0x007833F2
		public static TSportStateUnion FromISlideConfig(ISlideConfigT _islideconfig)
		{
			return new TSportStateUnion
			{
				Type = TSportState.ISlideConfig,
				Value = _islideconfig
			};
		}

		// Token: 0x0603796E RID: 227694 RVA: 0x00785208 File Offset: 0x00783408
		public static int Pack(FlatBufferBuilder builder, TSportStateUnion _o)
		{
			switch (_o.Type)
			{
			case TSportState.IPetalGrabConfig:
				return IPetalGrabConfig.Pack(builder, _o.AsIPetalGrabConfig()).Value;
			case TSportState.ISkiConfig:
				return ISkiConfig.Pack(builder, _o.AsISkiConfig()).Value;
			case TSportState.ISlideConfig:
				return ISlideConfig.Pack(builder, _o.AsISlideConfig()).Value;
			default:
				return 0;
			}
		}
	}
}
