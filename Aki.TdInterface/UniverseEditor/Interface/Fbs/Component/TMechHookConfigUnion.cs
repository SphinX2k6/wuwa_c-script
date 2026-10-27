using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C5E RID: 23646
	public class TMechHookConfigUnion
	{
		// Token: 0x1700B21C RID: 45596
		// (get) Token: 0x06028869 RID: 165993 RVA: 0x00592DF2 File Offset: 0x00590FF2
		// (set) Token: 0x0602886A RID: 165994 RVA: 0x00592DFA File Offset: 0x00590FFA
		public TMechHookConfig Type { get; set; }

		// Token: 0x1700B21D RID: 45597
		// (get) Token: 0x0602886B RID: 165995 RVA: 0x00592E03 File Offset: 0x00591003
		// (set) Token: 0x0602886C RID: 165996 RVA: 0x00592E0B File Offset: 0x0059100B
		public object Value { get; set; }

		// Token: 0x0602886D RID: 165997 RVA: 0x00592E14 File Offset: 0x00591014
		public TMechHookConfigUnion()
		{
			this.Type = TMechHookConfig.NONE;
			this.Value = null;
		}

		// Token: 0x0602886E RID: 165998 RVA: 0x00592E2A File Offset: 0x0059102A
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602886F RID: 165999 RVA: 0x00592E3C File Offset: 0x0059103C
		public IBurrowHookT AsIBurrowHook()
		{
			return this.As<IBurrowHookT>();
		}

		// Token: 0x06028870 RID: 166000 RVA: 0x00592E44 File Offset: 0x00591044
		public static TMechHookConfigUnion FromIBurrowHook(IBurrowHookT _iburrowhook)
		{
			return new TMechHookConfigUnion
			{
				Type = TMechHookConfig.IBurrowHook,
				Value = _iburrowhook
			};
		}

		// Token: 0x06028871 RID: 166001 RVA: 0x00592E59 File Offset: 0x00591059
		public IMechFixedPointHookT AsIMechFixedPointHook()
		{
			return this.As<IMechFixedPointHookT>();
		}

		// Token: 0x06028872 RID: 166002 RVA: 0x00592E61 File Offset: 0x00591061
		public static TMechHookConfigUnion FromIMechFixedPointHook(IMechFixedPointHookT _imechfixedpointhook)
		{
			return new TMechHookConfigUnion
			{
				Type = TMechHookConfig.IMechFixedPointHook,
				Value = _imechfixedpointhook
			};
		}

		// Token: 0x06028873 RID: 166003 RVA: 0x00592E78 File Offset: 0x00591078
		public static int Pack(FlatBufferBuilder builder, TMechHookConfigUnion _o)
		{
			TMechHookConfig type = _o.Type;
			if (type == TMechHookConfig.IBurrowHook)
			{
				return IBurrowHook.Pack(builder, _o.AsIBurrowHook()).Value;
			}
			if (type != TMechHookConfig.IMechFixedPointHook)
			{
				return 0;
			}
			return IMechFixedPointHook.Pack(builder, _o.AsIMechFixedPointHook()).Value;
		}
	}
}
