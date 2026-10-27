using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.CsvData
{
	// Token: 0x0200490C RID: 18700
	public class ILoopTeleportClientPlayEffectBase_UnionUnion
	{
		// Token: 0x17008794 RID: 34708
		// (get) Token: 0x0601D3B4 RID: 119732 RVA: 0x0041FA41 File Offset: 0x0041DC41
		// (set) Token: 0x0601D3B5 RID: 119733 RVA: 0x0041FA49 File Offset: 0x0041DC49
		public ILoopTeleportClientPlayEffectBase_Union Type { get; set; }

		// Token: 0x17008795 RID: 34709
		// (get) Token: 0x0601D3B6 RID: 119734 RVA: 0x0041FA52 File Offset: 0x0041DC52
		// (set) Token: 0x0601D3B7 RID: 119735 RVA: 0x0041FA5A File Offset: 0x0041DC5A
		public object Value { get; set; }

		// Token: 0x0601D3B8 RID: 119736 RVA: 0x0041FA63 File Offset: 0x0041DC63
		public ILoopTeleportClientPlayEffectBase_UnionUnion()
		{
			this.Type = ILoopTeleportClientPlayEffectBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0601D3B9 RID: 119737 RVA: 0x0041FA79 File Offset: 0x0041DC79
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601D3BA RID: 119738 RVA: 0x0041FA8B File Offset: 0x0041DC8B
		public ILoopTeleportClientPlayEffectBaseT AsILoopTeleportClientPlayEffectBase()
		{
			return this.As<ILoopTeleportClientPlayEffectBaseT>();
		}

		// Token: 0x0601D3BB RID: 119739 RVA: 0x0041FA93 File Offset: 0x0041DC93
		public static ILoopTeleportClientPlayEffectBase_UnionUnion FromILoopTeleportClientPlayEffectBase(ILoopTeleportClientPlayEffectBaseT _iloopteleportclientplayeffectbase)
		{
			return new ILoopTeleportClientPlayEffectBase_UnionUnion
			{
				Type = ILoopTeleportClientPlayEffectBase_Union.ILoopTeleportClientPlayEffectBase,
				Value = _iloopteleportclientplayeffectbase
			};
		}

		// Token: 0x0601D3BC RID: 119740 RVA: 0x0041FAA8 File Offset: 0x0041DCA8
		public ILoopTeleportClientScreenEffectT AsILoopTeleportClientScreenEffect()
		{
			return this.As<ILoopTeleportClientScreenEffectT>();
		}

		// Token: 0x0601D3BD RID: 119741 RVA: 0x0041FAB0 File Offset: 0x0041DCB0
		public static ILoopTeleportClientPlayEffectBase_UnionUnion FromILoopTeleportClientScreenEffect(ILoopTeleportClientScreenEffectT _iloopteleportclientscreeneffect)
		{
			return new ILoopTeleportClientPlayEffectBase_UnionUnion
			{
				Type = ILoopTeleportClientPlayEffectBase_Union.ILoopTeleportClientScreenEffect,
				Value = _iloopteleportclientscreeneffect
			};
		}

		// Token: 0x0601D3BE RID: 119742 RVA: 0x0041FAC5 File Offset: 0x0041DCC5
		public ILoopTeleportClientMpcEffectT AsILoopTeleportClientMpcEffect()
		{
			return this.As<ILoopTeleportClientMpcEffectT>();
		}

		// Token: 0x0601D3BF RID: 119743 RVA: 0x0041FACD File Offset: 0x0041DCCD
		public static ILoopTeleportClientPlayEffectBase_UnionUnion FromILoopTeleportClientMpcEffect(ILoopTeleportClientMpcEffectT _iloopteleportclientmpceffect)
		{
			return new ILoopTeleportClientPlayEffectBase_UnionUnion
			{
				Type = ILoopTeleportClientPlayEffectBase_Union.ILoopTeleportClientMpcEffect,
				Value = _iloopteleportclientmpceffect
			};
		}

		// Token: 0x0601D3C0 RID: 119744 RVA: 0x0041FAE4 File Offset: 0x0041DCE4
		public static int Pack(FlatBufferBuilder builder, ILoopTeleportClientPlayEffectBase_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case ILoopTeleportClientPlayEffectBase_Union.ILoopTeleportClientPlayEffectBase:
				return ILoopTeleportClientPlayEffectBase.Pack(builder, _o.AsILoopTeleportClientPlayEffectBase()).Value;
			case ILoopTeleportClientPlayEffectBase_Union.ILoopTeleportClientScreenEffect:
				return ILoopTeleportClientScreenEffect.Pack(builder, _o.AsILoopTeleportClientScreenEffect()).Value;
			case ILoopTeleportClientPlayEffectBase_Union.ILoopTeleportClientMpcEffect:
				return ILoopTeleportClientMpcEffect.Pack(builder, _o.AsILoopTeleportClientMpcEffect()).Value;
			default:
				return 0;
			}
		}
	}
}
