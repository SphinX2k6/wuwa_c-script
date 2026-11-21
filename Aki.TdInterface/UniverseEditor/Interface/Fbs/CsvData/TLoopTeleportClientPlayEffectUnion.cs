using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.CsvData
{
	// Token: 0x02004DCE RID: 19918
	public class TLoopTeleportClientPlayEffectUnion
	{
		// Token: 0x17008E74 RID: 36468
		// (get) Token: 0x0601EE7F RID: 126591 RVA: 0x0045163E File Offset: 0x0044F83E
		// (set) Token: 0x0601EE80 RID: 126592 RVA: 0x00451646 File Offset: 0x0044F846
		public TLoopTeleportClientPlayEffect Type { get; set; }

		// Token: 0x17008E75 RID: 36469
		// (get) Token: 0x0601EE81 RID: 126593 RVA: 0x0045164F File Offset: 0x0044F84F
		// (set) Token: 0x0601EE82 RID: 126594 RVA: 0x00451657 File Offset: 0x0044F857
		public object Value { get; set; }

		// Token: 0x0601EE83 RID: 126595 RVA: 0x00451660 File Offset: 0x0044F860
		public TLoopTeleportClientPlayEffectUnion()
		{
			this.Type = TLoopTeleportClientPlayEffect.NONE;
			this.Value = null;
		}

		// Token: 0x0601EE84 RID: 126596 RVA: 0x00451676 File Offset: 0x0044F876
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601EE85 RID: 126597 RVA: 0x00451688 File Offset: 0x0044F888
		public ILoopTeleportClientMpcEffectT AsILoopTeleportClientMpcEffect()
		{
			return this.As<ILoopTeleportClientMpcEffectT>();
		}

		// Token: 0x0601EE86 RID: 126598 RVA: 0x00451690 File Offset: 0x0044F890
		public static TLoopTeleportClientPlayEffectUnion FromILoopTeleportClientMpcEffect(ILoopTeleportClientMpcEffectT _iloopteleportclientmpceffect)
		{
			return new TLoopTeleportClientPlayEffectUnion
			{
				Type = TLoopTeleportClientPlayEffect.ILoopTeleportClientMpcEffect,
				Value = _iloopteleportclientmpceffect
			};
		}

		// Token: 0x0601EE87 RID: 126599 RVA: 0x004516A5 File Offset: 0x0044F8A5
		public ILoopTeleportClientScreenEffectT AsILoopTeleportClientScreenEffect()
		{
			return this.As<ILoopTeleportClientScreenEffectT>();
		}

		// Token: 0x0601EE88 RID: 126600 RVA: 0x004516AD File Offset: 0x0044F8AD
		public static TLoopTeleportClientPlayEffectUnion FromILoopTeleportClientScreenEffect(ILoopTeleportClientScreenEffectT _iloopteleportclientscreeneffect)
		{
			return new TLoopTeleportClientPlayEffectUnion
			{
				Type = TLoopTeleportClientPlayEffect.ILoopTeleportClientScreenEffect,
				Value = _iloopteleportclientscreeneffect
			};
		}

		// Token: 0x0601EE89 RID: 126601 RVA: 0x004516C4 File Offset: 0x0044F8C4
		public static int Pack(FlatBufferBuilder builder, TLoopTeleportClientPlayEffectUnion _o)
		{
			TLoopTeleportClientPlayEffect type = _o.Type;
			if (type == TLoopTeleportClientPlayEffect.ILoopTeleportClientMpcEffect)
			{
				return ILoopTeleportClientMpcEffect.Pack(builder, _o.AsILoopTeleportClientMpcEffect()).Value;
			}
			if (type != TLoopTeleportClientPlayEffect.ILoopTeleportClientScreenEffect)
			{
				return 0;
			}
			return ILoopTeleportClientScreenEffect.Pack(builder, _o.AsILoopTeleportClientScreenEffect()).Value;
		}
	}
}
