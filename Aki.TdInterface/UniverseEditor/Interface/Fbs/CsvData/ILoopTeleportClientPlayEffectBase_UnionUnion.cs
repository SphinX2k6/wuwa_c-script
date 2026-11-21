using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.CsvData
{
	// Token: 0x02004DA7 RID: 19879
	public class ILoopTeleportClientPlayEffectBase_UnionUnion
	{
		// Token: 0x17008E37 RID: 36407
		// (get) Token: 0x0601ED4D RID: 126285 RVA: 0x0044F1A1 File Offset: 0x0044D3A1
		// (set) Token: 0x0601ED4E RID: 126286 RVA: 0x0044F1A9 File Offset: 0x0044D3A9
		public ILoopTeleportClientPlayEffectBase_Union Type { get; set; }

		// Token: 0x17008E38 RID: 36408
		// (get) Token: 0x0601ED4F RID: 126287 RVA: 0x0044F1B2 File Offset: 0x0044D3B2
		// (set) Token: 0x0601ED50 RID: 126288 RVA: 0x0044F1BA File Offset: 0x0044D3BA
		public object Value { get; set; }

		// Token: 0x0601ED51 RID: 126289 RVA: 0x0044F1C3 File Offset: 0x0044D3C3
		public ILoopTeleportClientPlayEffectBase_UnionUnion()
		{
			this.Type = ILoopTeleportClientPlayEffectBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0601ED52 RID: 126290 RVA: 0x0044F1D9 File Offset: 0x0044D3D9
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601ED53 RID: 126291 RVA: 0x0044F1EB File Offset: 0x0044D3EB
		public ILoopTeleportClientPlayEffectBaseT AsILoopTeleportClientPlayEffectBase()
		{
			return this.As<ILoopTeleportClientPlayEffectBaseT>();
		}

		// Token: 0x0601ED54 RID: 126292 RVA: 0x0044F1F3 File Offset: 0x0044D3F3
		public static ILoopTeleportClientPlayEffectBase_UnionUnion FromILoopTeleportClientPlayEffectBase(ILoopTeleportClientPlayEffectBaseT _iloopteleportclientplayeffectbase)
		{
			return new ILoopTeleportClientPlayEffectBase_UnionUnion
			{
				Type = ILoopTeleportClientPlayEffectBase_Union.ILoopTeleportClientPlayEffectBase,
				Value = _iloopteleportclientplayeffectbase
			};
		}

		// Token: 0x0601ED55 RID: 126293 RVA: 0x0044F208 File Offset: 0x0044D408
		public ILoopTeleportClientScreenEffectT AsILoopTeleportClientScreenEffect()
		{
			return this.As<ILoopTeleportClientScreenEffectT>();
		}

		// Token: 0x0601ED56 RID: 126294 RVA: 0x0044F210 File Offset: 0x0044D410
		public static ILoopTeleportClientPlayEffectBase_UnionUnion FromILoopTeleportClientScreenEffect(ILoopTeleportClientScreenEffectT _iloopteleportclientscreeneffect)
		{
			return new ILoopTeleportClientPlayEffectBase_UnionUnion
			{
				Type = ILoopTeleportClientPlayEffectBase_Union.ILoopTeleportClientScreenEffect,
				Value = _iloopteleportclientscreeneffect
			};
		}

		// Token: 0x0601ED57 RID: 126295 RVA: 0x0044F225 File Offset: 0x0044D425
		public ILoopTeleportClientMpcEffectT AsILoopTeleportClientMpcEffect()
		{
			return this.As<ILoopTeleportClientMpcEffectT>();
		}

		// Token: 0x0601ED58 RID: 126296 RVA: 0x0044F22D File Offset: 0x0044D42D
		public static ILoopTeleportClientPlayEffectBase_UnionUnion FromILoopTeleportClientMpcEffect(ILoopTeleportClientMpcEffectT _iloopteleportclientmpceffect)
		{
			return new ILoopTeleportClientPlayEffectBase_UnionUnion
			{
				Type = ILoopTeleportClientPlayEffectBase_Union.ILoopTeleportClientMpcEffect,
				Value = _iloopteleportclientmpceffect
			};
		}

		// Token: 0x0601ED59 RID: 126297 RVA: 0x0044F244 File Offset: 0x0044D444
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
