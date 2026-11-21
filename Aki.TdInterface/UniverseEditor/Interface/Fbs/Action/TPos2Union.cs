using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007F83 RID: 32643
	public class TPos2Union
	{
		// Token: 0x1700F2CF RID: 62159
		// (get) Token: 0x0603AD39 RID: 240953 RVA: 0x007E8086 File Offset: 0x007E6286
		// (set) Token: 0x0603AD3A RID: 240954 RVA: 0x007E808E File Offset: 0x007E628E
		public TPos2 Type { get; set; }

		// Token: 0x1700F2D0 RID: 62160
		// (get) Token: 0x0603AD3B RID: 240955 RVA: 0x007E8097 File Offset: 0x007E6297
		// (set) Token: 0x0603AD3C RID: 240956 RVA: 0x007E809F File Offset: 0x007E629F
		public object Value { get; set; }

		// Token: 0x0603AD3D RID: 240957 RVA: 0x007E80A8 File Offset: 0x007E62A8
		public TPos2Union()
		{
			this.Type = TPos2.NONE;
			this.Value = null;
		}

		// Token: 0x0603AD3E RID: 240958 RVA: 0x007E80BE File Offset: 0x007E62BE
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603AD3F RID: 240959 RVA: 0x007E80D0 File Offset: 0x007E62D0
		public IAbsolutePos2T AsIAbsolutePos2()
		{
			return this.As<IAbsolutePos2T>();
		}

		// Token: 0x0603AD40 RID: 240960 RVA: 0x007E80D8 File Offset: 0x007E62D8
		public static TPos2Union FromIAbsolutePos2(IAbsolutePos2T _iabsolutepos2)
		{
			return new TPos2Union
			{
				Type = TPos2.IAbsolutePos2,
				Value = _iabsolutepos2
			};
		}

		// Token: 0x0603AD41 RID: 240961 RVA: 0x007E80ED File Offset: 0x007E62ED
		public IEntityPos2T AsIEntityPos2()
		{
			return this.As<IEntityPos2T>();
		}

		// Token: 0x0603AD42 RID: 240962 RVA: 0x007E80F5 File Offset: 0x007E62F5
		public static TPos2Union FromIEntityPos2(IEntityPos2T _ientitypos2)
		{
			return new TPos2Union
			{
				Type = TPos2.IEntityPos2,
				Value = _ientitypos2
			};
		}

		// Token: 0x0603AD43 RID: 240963 RVA: 0x007E810A File Offset: 0x007E630A
		public IPlayerPos2T AsIPlayerPos2()
		{
			return this.As<IPlayerPos2T>();
		}

		// Token: 0x0603AD44 RID: 240964 RVA: 0x007E8112 File Offset: 0x007E6312
		public static TPos2Union FromIPlayerPos2(IPlayerPos2T _iplayerpos2)
		{
			return new TPos2Union
			{
				Type = TPos2.IPlayerPos2,
				Value = _iplayerpos2
			};
		}

		// Token: 0x0603AD45 RID: 240965 RVA: 0x007E8127 File Offset: 0x007E6327
		public IEffectPlayerPos2T AsIEffectPlayerPos2()
		{
			return this.As<IEffectPlayerPos2T>();
		}

		// Token: 0x0603AD46 RID: 240966 RVA: 0x007E812F File Offset: 0x007E632F
		public static TPos2Union FromIEffectPlayerPos2(IEffectPlayerPos2T _ieffectplayerpos2)
		{
			return new TPos2Union
			{
				Type = TPos2.IEffectPlayerPos2,
				Value = _ieffectplayerpos2
			};
		}

		// Token: 0x0603AD47 RID: 240967 RVA: 0x007E8144 File Offset: 0x007E6344
		public IEffectEntityPos2T AsIEffectEntityPos2()
		{
			return this.As<IEffectEntityPos2T>();
		}

		// Token: 0x0603AD48 RID: 240968 RVA: 0x007E814C File Offset: 0x007E634C
		public static TPos2Union FromIEffectEntityPos2(IEffectEntityPos2T _ieffectentitypos2)
		{
			return new TPos2Union
			{
				Type = TPos2.IEffectEntityPos2,
				Value = _ieffectentitypos2
			};
		}

		// Token: 0x0603AD49 RID: 240969 RVA: 0x007E8164 File Offset: 0x007E6364
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
