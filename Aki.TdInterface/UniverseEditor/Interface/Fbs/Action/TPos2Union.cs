using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007757 RID: 30551
	public class TPos2Union
	{
		// Token: 0x1700E67D RID: 59005
		// (get) Token: 0x060377F0 RID: 227312 RVA: 0x00782FB8 File Offset: 0x007811B8
		// (set) Token: 0x060377F1 RID: 227313 RVA: 0x00782FC0 File Offset: 0x007811C0
		public TPos2 Type { get; set; }

		// Token: 0x1700E67E RID: 59006
		// (get) Token: 0x060377F2 RID: 227314 RVA: 0x00782FC9 File Offset: 0x007811C9
		// (set) Token: 0x060377F3 RID: 227315 RVA: 0x00782FD1 File Offset: 0x007811D1
		public object Value { get; set; }

		// Token: 0x060377F4 RID: 227316 RVA: 0x00782FDA File Offset: 0x007811DA
		public TPos2Union()
		{
			this.Type = TPos2.NONE;
			this.Value = null;
		}

		// Token: 0x060377F5 RID: 227317 RVA: 0x00782FF0 File Offset: 0x007811F0
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060377F6 RID: 227318 RVA: 0x00783002 File Offset: 0x00781202
		public IAbsolutePos2T AsIAbsolutePos2()
		{
			return this.As<IAbsolutePos2T>();
		}

		// Token: 0x060377F7 RID: 227319 RVA: 0x0078300A File Offset: 0x0078120A
		public static TPos2Union FromIAbsolutePos2(IAbsolutePos2T _iabsolutepos2)
		{
			return new TPos2Union
			{
				Type = TPos2.IAbsolutePos2,
				Value = _iabsolutepos2
			};
		}

		// Token: 0x060377F8 RID: 227320 RVA: 0x0078301F File Offset: 0x0078121F
		public IEntityPos2T AsIEntityPos2()
		{
			return this.As<IEntityPos2T>();
		}

		// Token: 0x060377F9 RID: 227321 RVA: 0x00783027 File Offset: 0x00781227
		public static TPos2Union FromIEntityPos2(IEntityPos2T _ientitypos2)
		{
			return new TPos2Union
			{
				Type = TPos2.IEntityPos2,
				Value = _ientitypos2
			};
		}

		// Token: 0x060377FA RID: 227322 RVA: 0x0078303C File Offset: 0x0078123C
		public IPlayerPos2T AsIPlayerPos2()
		{
			return this.As<IPlayerPos2T>();
		}

		// Token: 0x060377FB RID: 227323 RVA: 0x00783044 File Offset: 0x00781244
		public static TPos2Union FromIPlayerPos2(IPlayerPos2T _iplayerpos2)
		{
			return new TPos2Union
			{
				Type = TPos2.IPlayerPos2,
				Value = _iplayerpos2
			};
		}

		// Token: 0x060377FC RID: 227324 RVA: 0x00783059 File Offset: 0x00781259
		public IEffectPlayerPos2T AsIEffectPlayerPos2()
		{
			return this.As<IEffectPlayerPos2T>();
		}

		// Token: 0x060377FD RID: 227325 RVA: 0x00783061 File Offset: 0x00781261
		public static TPos2Union FromIEffectPlayerPos2(IEffectPlayerPos2T _ieffectplayerpos2)
		{
			return new TPos2Union
			{
				Type = TPos2.IEffectPlayerPos2,
				Value = _ieffectplayerpos2
			};
		}

		// Token: 0x060377FE RID: 227326 RVA: 0x00783076 File Offset: 0x00781276
		public IEffectEntityPos2T AsIEffectEntityPos2()
		{
			return this.As<IEffectEntityPos2T>();
		}

		// Token: 0x060377FF RID: 227327 RVA: 0x0078307E File Offset: 0x0078127E
		public static TPos2Union FromIEffectEntityPos2(IEffectEntityPos2T _ieffectentitypos2)
		{
			return new TPos2Union
			{
				Type = TPos2.IEffectEntityPos2,
				Value = _ieffectentitypos2
			};
		}

		// Token: 0x06037800 RID: 227328 RVA: 0x00783094 File Offset: 0x00781294
		public static int Pack(FlatBufferBuilder builder, TPos2Union _o)
		{
			switch (_o.Type)
			{
			case TPos2.IAbsolutePos2:
				return IAbsolutePos2.Pack(builder, _o.AsIAbsolutePos2()).Value;
			case TPos2.IEntityPos2:
				return IEntityPos2.Pack(builder, _o.AsIEntityPos2()).Value;
			case TPos2.IPlayerPos2:
				return IPlayerPos2.Pack(builder, _o.AsIPlayerPos2()).Value;
			case TPos2.IEffectPlayerPos2:
				return IEffectPlayerPos2.Pack(builder, _o.AsIEffectPlayerPos2()).Value;
			case TPos2.IEffectEntityPos2:
				return IEffectEntityPos2.Pack(builder, _o.AsIEffectEntityPos2()).Value;
			default:
				return 0;
			}
		}
	}
}
