using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007FDD RID: 32733
	public class TSportStateUnion
	{
		// Token: 0x1700F30B RID: 62219
		// (get) Token: 0x0603AEE1 RID: 241377 RVA: 0x007EA6F4 File Offset: 0x007E88F4
		// (set) Token: 0x0603AEE2 RID: 241378 RVA: 0x007EA6FC File Offset: 0x007E88FC
		public TSportState Type { get; set; }

		// Token: 0x1700F30C RID: 62220
		// (get) Token: 0x0603AEE3 RID: 241379 RVA: 0x007EA705 File Offset: 0x007E8905
		// (set) Token: 0x0603AEE4 RID: 241380 RVA: 0x007EA70D File Offset: 0x007E890D
		public object Value { get; set; }

		// Token: 0x0603AEE5 RID: 241381 RVA: 0x007EA716 File Offset: 0x007E8916
		public TSportStateUnion()
		{
			this.Type = TSportState.NONE;
			this.Value = null;
		}

		// Token: 0x0603AEE6 RID: 241382 RVA: 0x007EA72C File Offset: 0x007E892C
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603AEE7 RID: 241383 RVA: 0x007EA73E File Offset: 0x007E893E
		public IPetalFlyConfigT AsIPetalFlyConfig()
		{
			return this.As<IPetalFlyConfigT>();
		}

		// Token: 0x0603AEE8 RID: 241384 RVA: 0x007EA746 File Offset: 0x007E8946
		public static TSportStateUnion FromIPetalFlyConfig(IPetalFlyConfigT _ipetalflyconfig)
		{
			return new TSportStateUnion
			{
				Type = TSportState.IPetalFlyConfig,
				Value = _ipetalflyconfig
			};
		}

		// Token: 0x0603AEE9 RID: 241385 RVA: 0x007EA75B File Offset: 0x007E895B
		public IPetalGrabConfigT AsIPetalGrabConfig()
		{
			return this.As<IPetalGrabConfigT>();
		}

		// Token: 0x0603AEEA RID: 241386 RVA: 0x007EA763 File Offset: 0x007E8963
		public static TSportStateUnion FromIPetalGrabConfig(IPetalGrabConfigT _ipetalgrabconfig)
		{
			return new TSportStateUnion
			{
				Type = TSportState.IPetalGrabConfig,
				Value = _ipetalgrabconfig
			};
		}

		// Token: 0x0603AEEB RID: 241387 RVA: 0x007EA778 File Offset: 0x007E8978
		public ISkiConfigT AsISkiConfig()
		{
			return this.As<ISkiConfigT>();
		}

		// Token: 0x0603AEEC RID: 241388 RVA: 0x007EA780 File Offset: 0x007E8980
		public static TSportStateUnion FromISkiConfig(ISkiConfigT _iskiconfig)
		{
			return new TSportStateUnion
			{
				Type = TSportState.ISkiConfig,
				Value = _iskiconfig
			};
		}

		// Token: 0x0603AEED RID: 241389 RVA: 0x007EA795 File Offset: 0x007E8995
		public ISlideConfigT AsISlideConfig()
		{
			return this.As<ISlideConfigT>();
		}

		// Token: 0x0603AEEE RID: 241390 RVA: 0x007EA79D File Offset: 0x007E899D
		public static TSportStateUnion FromISlideConfig(ISlideConfigT _islideconfig)
		{
			return new TSportStateUnion
			{
				Type = TSportState.ISlideConfig,
				Value = _islideconfig
			};
		}

		// Token: 0x0603AEEF RID: 241391 RVA: 0x007EA7B4 File Offset: 0x007E89B4
		public static int Pack(FlatBufferBuilder builder, TSportStateUnion _o)
		{
			switch (_o.Type)
			{
			case TSportState.IPetalFlyConfig:
				return IPetalFlyConfig.Pack(builder, _o.AsIPetalFlyConfig()).Value;
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
