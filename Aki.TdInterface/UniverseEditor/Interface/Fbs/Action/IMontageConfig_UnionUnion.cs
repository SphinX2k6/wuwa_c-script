using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006AF5 RID: 27381
	public class IMontageConfig_UnionUnion
	{
		// Token: 0x1700CB1C RID: 51996
		// (get) Token: 0x0602FFE2 RID: 196578 RVA: 0x006865D9 File Offset: 0x006847D9
		// (set) Token: 0x0602FFE3 RID: 196579 RVA: 0x006865E1 File Offset: 0x006847E1
		public IMontageConfig_Union Type { get; set; }

		// Token: 0x1700CB1D RID: 51997
		// (get) Token: 0x0602FFE4 RID: 196580 RVA: 0x006865EA File Offset: 0x006847EA
		// (set) Token: 0x0602FFE5 RID: 196581 RVA: 0x006865F2 File Offset: 0x006847F2
		public object Value { get; set; }

		// Token: 0x0602FFE6 RID: 196582 RVA: 0x006865FB File Offset: 0x006847FB
		public IMontageConfig_UnionUnion()
		{
			this.Type = IMontageConfig_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602FFE7 RID: 196583 RVA: 0x00686611 File Offset: 0x00684811
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602FFE8 RID: 196584 RVA: 0x00686623 File Offset: 0x00684823
		public IMontageConfigT AsIMontageConfig()
		{
			return this.As<IMontageConfigT>();
		}

		// Token: 0x0602FFE9 RID: 196585 RVA: 0x0068662B File Offset: 0x0068482B
		public static IMontageConfig_UnionUnion FromIMontageConfig(IMontageConfigT _imontageconfig)
		{
			return new IMontageConfig_UnionUnion
			{
				Type = IMontageConfig_Union.IMontageConfig,
				Value = _imontageconfig
			};
		}

		// Token: 0x0602FFEA RID: 196586 RVA: 0x00686640 File Offset: 0x00684840
		public IMontageAssetT AsIMontageAsset()
		{
			return this.As<IMontageAssetT>();
		}

		// Token: 0x0602FFEB RID: 196587 RVA: 0x00686648 File Offset: 0x00684848
		public static IMontageConfig_UnionUnion FromIMontageAsset(IMontageAssetT _imontageasset)
		{
			return new IMontageConfig_UnionUnion
			{
				Type = IMontageConfig_Union.IMontageAsset,
				Value = _imontageasset
			};
		}

		// Token: 0x0602FFEC RID: 196588 RVA: 0x0068665D File Offset: 0x0068485D
		public IMontageRegisteredT AsIMontageRegistered()
		{
			return this.As<IMontageRegisteredT>();
		}

		// Token: 0x0602FFED RID: 196589 RVA: 0x00686665 File Offset: 0x00684865
		public static IMontageConfig_UnionUnion FromIMontageRegistered(IMontageRegisteredT _imontageregistered)
		{
			return new IMontageConfig_UnionUnion
			{
				Type = IMontageConfig_Union.IMontageRegistered,
				Value = _imontageregistered
			};
		}

		// Token: 0x0602FFEE RID: 196590 RVA: 0x0068667C File Offset: 0x0068487C
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
