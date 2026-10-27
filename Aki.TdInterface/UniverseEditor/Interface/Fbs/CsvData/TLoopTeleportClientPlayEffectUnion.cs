using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.CsvData
{
	// Token: 0x0200491B RID: 18715
	public class TLoopTeleportClientPlayEffectUnion
	{
		// Token: 0x170087B9 RID: 34745
		// (get) Token: 0x0601D45A RID: 119898 RVA: 0x00421189 File Offset: 0x0041F389
		// (set) Token: 0x0601D45B RID: 119899 RVA: 0x00421191 File Offset: 0x0041F391
		public TLoopTeleportClientPlayEffect Type { get; set; }

		// Token: 0x170087BA RID: 34746
		// (get) Token: 0x0601D45C RID: 119900 RVA: 0x0042119A File Offset: 0x0041F39A
		// (set) Token: 0x0601D45D RID: 119901 RVA: 0x004211A2 File Offset: 0x0041F3A2
		public object Value { get; set; }

		// Token: 0x0601D45E RID: 119902 RVA: 0x004211AB File Offset: 0x0041F3AB
		public TLoopTeleportClientPlayEffectUnion()
		{
			this.Type = TLoopTeleportClientPlayEffect.NONE;
			this.Value = null;
		}

		// Token: 0x0601D45F RID: 119903 RVA: 0x004211C1 File Offset: 0x0041F3C1
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601D460 RID: 119904 RVA: 0x004211D3 File Offset: 0x0041F3D3
		public ILoopTeleportClientMpcEffectT AsILoopTeleportClientMpcEffect()
		{
			return this.As<ILoopTeleportClientMpcEffectT>();
		}

		// Token: 0x0601D461 RID: 119905 RVA: 0x004211DB File Offset: 0x0041F3DB
		public static TLoopTeleportClientPlayEffectUnion FromILoopTeleportClientMpcEffect(ILoopTeleportClientMpcEffectT _iloopteleportclientmpceffect)
		{
			return new TLoopTeleportClientPlayEffectUnion
			{
				Type = TLoopTeleportClientPlayEffect.ILoopTeleportClientMpcEffect,
				Value = _iloopteleportclientmpceffect
			};
		}

		// Token: 0x0601D462 RID: 119906 RVA: 0x004211F0 File Offset: 0x0041F3F0
		public ILoopTeleportClientScreenEffectT AsILoopTeleportClientScreenEffect()
		{
			return this.As<ILoopTeleportClientScreenEffectT>();
		}

		// Token: 0x0601D463 RID: 119907 RVA: 0x004211F8 File Offset: 0x0041F3F8
		public static TLoopTeleportClientPlayEffectUnion FromILoopTeleportClientScreenEffect(ILoopTeleportClientScreenEffectT _iloopteleportclientscreeneffect)
		{
			return new TLoopTeleportClientPlayEffectUnion
			{
				Type = TLoopTeleportClientPlayEffect.ILoopTeleportClientScreenEffect,
				Value = _iloopteleportclientscreeneffect
			};
		}

		// Token: 0x0601D464 RID: 119908 RVA: 0x00421210 File Offset: 0x0041F410
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
