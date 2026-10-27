using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020071A0 RID: 29088
	public class ISportConfig_UnionUnion
	{
		// Token: 0x1700D804 RID: 55300
		// (get) Token: 0x0603391E RID: 211230 RVA: 0x006F1F75 File Offset: 0x006F0175
		// (set) Token: 0x0603391F RID: 211231 RVA: 0x006F1F7D File Offset: 0x006F017D
		public ISportConfig_Union Type { get; set; }

		// Token: 0x1700D805 RID: 55301
		// (get) Token: 0x06033920 RID: 211232 RVA: 0x006F1F86 File Offset: 0x006F0186
		// (set) Token: 0x06033921 RID: 211233 RVA: 0x006F1F8E File Offset: 0x006F018E
		public object Value { get; set; }

		// Token: 0x06033922 RID: 211234 RVA: 0x006F1F97 File Offset: 0x006F0197
		public ISportConfig_UnionUnion()
		{
			this.Type = ISportConfig_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06033923 RID: 211235 RVA: 0x006F1FAD File Offset: 0x006F01AD
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06033924 RID: 211236 RVA: 0x006F1FBF File Offset: 0x006F01BF
		public ISportConfigT AsISportConfig()
		{
			return this.As<ISportConfigT>();
		}

		// Token: 0x06033925 RID: 211237 RVA: 0x006F1FC7 File Offset: 0x006F01C7
		public static ISportConfig_UnionUnion FromISportConfig(ISportConfigT _isportconfig)
		{
			return new ISportConfig_UnionUnion
			{
				Type = ISportConfig_Union.ISportConfig,
				Value = _isportconfig
			};
		}

		// Token: 0x06033926 RID: 211238 RVA: 0x006F1FDC File Offset: 0x006F01DC
		public ISkiConfigT AsISkiConfig()
		{
			return this.As<ISkiConfigT>();
		}

		// Token: 0x06033927 RID: 211239 RVA: 0x006F1FE4 File Offset: 0x006F01E4
		public static ISportConfig_UnionUnion FromISkiConfig(ISkiConfigT _iskiconfig)
		{
			return new ISportConfig_UnionUnion
			{
				Type = ISportConfig_Union.ISkiConfig,
				Value = _iskiconfig
			};
		}

		// Token: 0x06033928 RID: 211240 RVA: 0x006F1FF9 File Offset: 0x006F01F9
		public ISlideConfigT AsISlideConfig()
		{
			return this.As<ISlideConfigT>();
		}

		// Token: 0x06033929 RID: 211241 RVA: 0x006F2001 File Offset: 0x006F0201
		public static ISportConfig_UnionUnion FromISlideConfig(ISlideConfigT _islideconfig)
		{
			return new ISportConfig_UnionUnion
			{
				Type = ISportConfig_Union.ISlideConfig,
				Value = _islideconfig
			};
		}

		// Token: 0x0603392A RID: 211242 RVA: 0x006F2016 File Offset: 0x006F0216
		public IPetalGrabConfigT AsIPetalGrabConfig()
		{
			return this.As<IPetalGrabConfigT>();
		}

		// Token: 0x0603392B RID: 211243 RVA: 0x006F201E File Offset: 0x006F021E
		public static ISportConfig_UnionUnion FromIPetalGrabConfig(IPetalGrabConfigT _ipetalgrabconfig)
		{
			return new ISportConfig_UnionUnion
			{
				Type = ISportConfig_Union.IPetalGrabConfig,
				Value = _ipetalgrabconfig
			};
		}

		// Token: 0x0603392C RID: 211244 RVA: 0x006F2034 File Offset: 0x006F0234
		public static int Pack(FlatBufferBuilder builder, ISportConfig_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case ISportConfig_Union.ISportConfig:
				return ISportConfig.Pack(builder, _o.AsISportConfig()).Value;
			case ISportConfig_Union.ISkiConfig:
				return ISkiConfig.Pack(builder, _o.AsISkiConfig()).Value;
			case ISportConfig_Union.ISlideConfig:
				return ISlideConfig.Pack(builder, _o.AsISlideConfig()).Value;
			case ISportConfig_Union.IPetalGrabConfig:
				return IPetalGrabConfig.Pack(builder, _o.AsIPetalGrabConfig()).Value;
			default:
				return 0;
			}
		}
	}
}
