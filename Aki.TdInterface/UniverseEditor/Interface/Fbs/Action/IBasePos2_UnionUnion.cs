using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020061E6 RID: 25062
	public class IBasePos2_UnionUnion
	{
		// Token: 0x1700BAD9 RID: 47833
		// (get) Token: 0x0602B321 RID: 176929 RVA: 0x005F4009 File Offset: 0x005F2209
		// (set) Token: 0x0602B322 RID: 176930 RVA: 0x005F4011 File Offset: 0x005F2211
		public IBasePos2_Union Type { get; set; }

		// Token: 0x1700BADA RID: 47834
		// (get) Token: 0x0602B323 RID: 176931 RVA: 0x005F401A File Offset: 0x005F221A
		// (set) Token: 0x0602B324 RID: 176932 RVA: 0x005F4022 File Offset: 0x005F2222
		public object Value { get; set; }

		// Token: 0x0602B325 RID: 176933 RVA: 0x005F402B File Offset: 0x005F222B
		public IBasePos2_UnionUnion()
		{
			this.Type = IBasePos2_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602B326 RID: 176934 RVA: 0x005F4041 File Offset: 0x005F2241
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602B327 RID: 176935 RVA: 0x005F4053 File Offset: 0x005F2253
		public IBasePos2T AsIBasePos2()
		{
			return this.As<IBasePos2T>();
		}

		// Token: 0x0602B328 RID: 176936 RVA: 0x005F405B File Offset: 0x005F225B
		public static IBasePos2_UnionUnion FromIBasePos2(IBasePos2T _ibasepos2)
		{
			return new IBasePos2_UnionUnion
			{
				Type = IBasePos2_Union.IBasePos2,
				Value = _ibasepos2
			};
		}

		// Token: 0x0602B329 RID: 176937 RVA: 0x005F4070 File Offset: 0x005F2270
		public IPlayerPos2T AsIPlayerPos2()
		{
			return this.As<IPlayerPos2T>();
		}

		// Token: 0x0602B32A RID: 176938 RVA: 0x005F4078 File Offset: 0x005F2278
		public static IBasePos2_UnionUnion FromIPlayerPos2(IPlayerPos2T _iplayerpos2)
		{
			return new IBasePos2_UnionUnion
			{
				Type = IBasePos2_Union.IPlayerPos2,
				Value = _iplayerpos2
			};
		}

		// Token: 0x0602B32B RID: 176939 RVA: 0x005F408D File Offset: 0x005F228D
		public IEffectPlayerPos2T AsIEffectPlayerPos2()
		{
			return this.As<IEffectPlayerPos2T>();
		}

		// Token: 0x0602B32C RID: 176940 RVA: 0x005F4095 File Offset: 0x005F2295
		public static IBasePos2_UnionUnion FromIEffectPlayerPos2(IEffectPlayerPos2T _ieffectplayerpos2)
		{
			return new IBasePos2_UnionUnion
			{
				Type = IBasePos2_Union.IEffectPlayerPos2,
				Value = _ieffectplayerpos2
			};
		}

		// Token: 0x0602B32D RID: 176941 RVA: 0x005F40AA File Offset: 0x005F22AA
		public IEntityPos2T AsIEntityPos2()
		{
			return this.As<IEntityPos2T>();
		}

		// Token: 0x0602B32E RID: 176942 RVA: 0x005F40B2 File Offset: 0x005F22B2
		public static IBasePos2_UnionUnion FromIEntityPos2(IEntityPos2T _ientitypos2)
		{
			return new IBasePos2_UnionUnion
			{
				Type = IBasePos2_Union.IEntityPos2,
				Value = _ientitypos2
			};
		}

		// Token: 0x0602B32F RID: 176943 RVA: 0x005F40C7 File Offset: 0x005F22C7
		public IEffectEntityPos2T AsIEffectEntityPos2()
		{
			return this.As<IEffectEntityPos2T>();
		}

		// Token: 0x0602B330 RID: 176944 RVA: 0x005F40CF File Offset: 0x005F22CF
		public static IBasePos2_UnionUnion FromIEffectEntityPos2(IEffectEntityPos2T _ieffectentitypos2)
		{
			return new IBasePos2_UnionUnion
			{
				Type = IBasePos2_Union.IEffectEntityPos2,
				Value = _ieffectentitypos2
			};
		}

		// Token: 0x0602B331 RID: 176945 RVA: 0x005F40E4 File Offset: 0x005F22E4
		public IAbsolutePos2T AsIAbsolutePos2()
		{
			return this.As<IAbsolutePos2T>();
		}

		// Token: 0x0602B332 RID: 176946 RVA: 0x005F40EC File Offset: 0x005F22EC
		public static IBasePos2_UnionUnion FromIAbsolutePos2(IAbsolutePos2T _iabsolutepos2)
		{
			return new IBasePos2_UnionUnion
			{
				Type = IBasePos2_Union.IAbsolutePos2,
				Value = _iabsolutepos2
			};
		}

		// Token: 0x0602B333 RID: 176947 RVA: 0x005F4104 File Offset: 0x005F2304
		public static int Pack(FlatBufferBuilder builder, IBasePos2_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IBasePos2_Union.IBasePos2:
				return IBasePos2.Pack(builder, _o.AsIBasePos2()).Value;
			case IBasePos2_Union.IPlayerPos2:
				return IPlayerPos2.Pack(builder, _o.AsIPlayerPos2()).Value;
			case IBasePos2_Union.IEffectPlayerPos2:
				return IEffectPlayerPos2.Pack(builder, _o.AsIEffectPlayerPos2()).Value;
			case IBasePos2_Union.IEntityPos2:
				return IEntityPos2.Pack(builder, _o.AsIEntityPos2()).Value;
			case IBasePos2_Union.IEffectEntityPos2:
				return IEffectEntityPos2.Pack(builder, _o.AsIEffectEntityPos2()).Value;
			case IBasePos2_Union.IAbsolutePos2:
				return IAbsolutePos2.Pack(builder, _o.AsIAbsolutePos2()).Value;
			default:
				return 0;
			}
		}
	}
}
