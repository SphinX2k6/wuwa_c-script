using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200722C RID: 29228
	public class IMontageConfig_UnionUnion
	{
		// Token: 0x1700D5EB RID: 54763
		// (get) Token: 0x06032DB6 RID: 208310 RVA: 0x006DDC91 File Offset: 0x006DBE91
		// (set) Token: 0x06032DB7 RID: 208311 RVA: 0x006DDC99 File Offset: 0x006DBE99
		public IMontageConfig_Union Type { get; set; }

		// Token: 0x1700D5EC RID: 54764
		// (get) Token: 0x06032DB8 RID: 208312 RVA: 0x006DDCA2 File Offset: 0x006DBEA2
		// (set) Token: 0x06032DB9 RID: 208313 RVA: 0x006DDCAA File Offset: 0x006DBEAA
		public object Value { get; set; }

		// Token: 0x06032DBA RID: 208314 RVA: 0x006DDCB3 File Offset: 0x006DBEB3
		public IMontageConfig_UnionUnion()
		{
			this.Type = IMontageConfig_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06032DBB RID: 208315 RVA: 0x006DDCC9 File Offset: 0x006DBEC9
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06032DBC RID: 208316 RVA: 0x006DDCDB File Offset: 0x006DBEDB
		public IMontageConfigT AsIMontageConfig()
		{
			return this.As<IMontageConfigT>();
		}

		// Token: 0x06032DBD RID: 208317 RVA: 0x006DDCE3 File Offset: 0x006DBEE3
		public static IMontageConfig_UnionUnion FromIMontageConfig(IMontageConfigT _imontageconfig)
		{
			return new IMontageConfig_UnionUnion
			{
				Type = IMontageConfig_Union.IMontageConfig,
				Value = _imontageconfig
			};
		}

		// Token: 0x06032DBE RID: 208318 RVA: 0x006DDCF8 File Offset: 0x006DBEF8
		public IMontageAssetT AsIMontageAsset()
		{
			return this.As<IMontageAssetT>();
		}

		// Token: 0x06032DBF RID: 208319 RVA: 0x006DDD00 File Offset: 0x006DBF00
		public static IMontageConfig_UnionUnion FromIMontageAsset(IMontageAssetT _imontageasset)
		{
			return new IMontageConfig_UnionUnion
			{
				Type = IMontageConfig_Union.IMontageAsset,
				Value = _imontageasset
			};
		}

		// Token: 0x06032DC0 RID: 208320 RVA: 0x006DDD15 File Offset: 0x006DBF15
		public IMontageRegisteredT AsIMontageRegistered()
		{
			return this.As<IMontageRegisteredT>();
		}

		// Token: 0x06032DC1 RID: 208321 RVA: 0x006DDD1D File Offset: 0x006DBF1D
		public static IMontageConfig_UnionUnion FromIMontageRegistered(IMontageRegisteredT _imontageregistered)
		{
			return new IMontageConfig_UnionUnion
			{
				Type = IMontageConfig_Union.IMontageRegistered,
				Value = _imontageregistered
			};
		}

		// Token: 0x06032DC2 RID: 208322 RVA: 0x006DDD34 File Offset: 0x006DBF34
		public static int Pack(FlatBufferBuilder builder, IMontageConfig_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IMontageConfig_Union.IMontageConfig:
				return IMontageConfig.Pack(builder, _o.AsIMontageConfig()).Value;
			case IMontageConfig_Union.IMontageAsset:
				return IMontageAsset.Pack(builder, _o.AsIMontageAsset()).Value;
			case IMontageConfig_Union.IMontageRegistered:
				return IMontageRegistered.Pack(builder, _o.AsIMontageRegistered()).Value;
			default:
				return 0;
			}
		}
	}
}
