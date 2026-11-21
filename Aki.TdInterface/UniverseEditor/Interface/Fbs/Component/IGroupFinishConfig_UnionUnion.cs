using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020058D7 RID: 22743
	public class IGroupFinishConfig_UnionUnion
	{
		// Token: 0x1700A4ED RID: 42221
		// (get) Token: 0x06024EEC RID: 151276 RVA: 0x00512215 File Offset: 0x00510415
		// (set) Token: 0x06024EED RID: 151277 RVA: 0x0051221D File Offset: 0x0051041D
		public IGroupFinishConfig_Union Type { get; set; }

		// Token: 0x1700A4EE RID: 42222
		// (get) Token: 0x06024EEE RID: 151278 RVA: 0x00512226 File Offset: 0x00510426
		// (set) Token: 0x06024EEF RID: 151279 RVA: 0x0051222E File Offset: 0x0051042E
		public object Value { get; set; }

		// Token: 0x06024EF0 RID: 151280 RVA: 0x00512237 File Offset: 0x00510437
		public IGroupFinishConfig_UnionUnion()
		{
			this.Type = IGroupFinishConfig_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06024EF1 RID: 151281 RVA: 0x0051224D File Offset: 0x0051044D
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06024EF2 RID: 151282 RVA: 0x0051225F File Offset: 0x0051045F
		public IGroupFinishConfigT AsIGroupFinishConfig()
		{
			return this.As<IGroupFinishConfigT>();
		}

		// Token: 0x06024EF3 RID: 151283 RVA: 0x00512267 File Offset: 0x00510467
		public static IGroupFinishConfig_UnionUnion FromIGroupFinishConfig(IGroupFinishConfigT _igroupfinishconfig)
		{
			return new IGroupFinishConfig_UnionUnion
			{
				Type = IGroupFinishConfig_Union.IGroupFinishConfig,
				Value = _igroupfinishconfig
			};
		}

		// Token: 0x06024EF4 RID: 151284 RVA: 0x0051227C File Offset: 0x0051047C
		public IGroupFinishSilenceT AsIGroupFinishSilence()
		{
			return this.As<IGroupFinishSilenceT>();
		}

		// Token: 0x06024EF5 RID: 151285 RVA: 0x00512284 File Offset: 0x00510484
		public static IGroupFinishConfig_UnionUnion FromIGroupFinishSilence(IGroupFinishSilenceT _igroupfinishsilence)
		{
			return new IGroupFinishConfig_UnionUnion
			{
				Type = IGroupFinishConfig_Union.IGroupFinishSilence,
				Value = _igroupfinishsilence
			};
		}

		// Token: 0x06024EF6 RID: 151286 RVA: 0x00512299 File Offset: 0x00510499
		public IGroupFinishDestroyT AsIGroupFinishDestroy()
		{
			return this.As<IGroupFinishDestroyT>();
		}

		// Token: 0x06024EF7 RID: 151287 RVA: 0x005122A1 File Offset: 0x005104A1
		public static IGroupFinishConfig_UnionUnion FromIGroupFinishDestroy(IGroupFinishDestroyT _igroupfinishdestroy)
		{
			return new IGroupFinishConfig_UnionUnion
			{
				Type = IGroupFinishConfig_Union.IGroupFinishDestroy,
				Value = _igroupfinishdestroy
			};
		}

		// Token: 0x06024EF8 RID: 151288 RVA: 0x005122B8 File Offset: 0x005104B8
		public static int Pack(FlatBufferBuilder builder, IGroupFinishConfig_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IGroupFinishConfig_Union.IGroupFinishConfig:
				return IGroupFinishConfig.Pack(builder, _o.AsIGroupFinishConfig()).Value;
			case IGroupFinishConfig_Union.IGroupFinishSilence:
				return IGroupFinishSilence.Pack(builder, _o.AsIGroupFinishSilence()).Value;
			case IGroupFinishConfig_Union.IGroupFinishDestroy:
				return IGroupFinishDestroy.Pack(builder, _o.AsIGroupFinishDestroy()).Value;
			default:
				return 0;
			}
		}
	}
}
