using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200552D RID: 21805
	public class ICommonRotationConfig_UnionUnion
	{
		// Token: 0x17009BDE RID: 39902
		// (get) Token: 0x060227A3 RID: 141219 RVA: 0x004BFD40 File Offset: 0x004BDF40
		// (set) Token: 0x060227A4 RID: 141220 RVA: 0x004BFD48 File Offset: 0x004BDF48
		public ICommonRotationConfig_Union Type { get; set; }

		// Token: 0x17009BDF RID: 39903
		// (get) Token: 0x060227A5 RID: 141221 RVA: 0x004BFD51 File Offset: 0x004BDF51
		// (set) Token: 0x060227A6 RID: 141222 RVA: 0x004BFD59 File Offset: 0x004BDF59
		public object Value { get; set; }

		// Token: 0x060227A7 RID: 141223 RVA: 0x004BFD62 File Offset: 0x004BDF62
		public ICommonRotationConfig_UnionUnion()
		{
			this.Type = ICommonRotationConfig_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060227A8 RID: 141224 RVA: 0x004BFD78 File Offset: 0x004BDF78
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060227A9 RID: 141225 RVA: 0x004BFD8A File Offset: 0x004BDF8A
		public ICommonRotationConfigT AsICommonRotationConfig()
		{
			return this.As<ICommonRotationConfigT>();
		}

		// Token: 0x060227AA RID: 141226 RVA: 0x004BFD92 File Offset: 0x004BDF92
		public static ICommonRotationConfig_UnionUnion FromICommonRotationConfig(ICommonRotationConfigT _icommonrotationconfig)
		{
			return new ICommonRotationConfig_UnionUnion
			{
				Type = ICommonRotationConfig_Union.ICommonRotationConfig,
				Value = _icommonrotationconfig
			};
		}

		// Token: 0x060227AB RID: 141227 RVA: 0x004BFDA7 File Offset: 0x004BDFA7
		public IRotationConfigT AsIRotationConfig()
		{
			return this.As<IRotationConfigT>();
		}

		// Token: 0x060227AC RID: 141228 RVA: 0x004BFDAF File Offset: 0x004BDFAF
		public static ICommonRotationConfig_UnionUnion FromIRotationConfig(IRotationConfigT _irotationconfig)
		{
			return new ICommonRotationConfig_UnionUnion
			{
				Type = ICommonRotationConfig_Union.IRotationConfig,
				Value = _irotationconfig
			};
		}

		// Token: 0x060227AD RID: 141229 RVA: 0x004BFDC4 File Offset: 0x004BDFC4
		public IKeyRotatorConfigT AsIKeyRotatorConfig()
		{
			return this.As<IKeyRotatorConfigT>();
		}

		// Token: 0x060227AE RID: 141230 RVA: 0x004BFDCC File Offset: 0x004BDFCC
		public static ICommonRotationConfig_UnionUnion FromIKeyRotatorConfig(IKeyRotatorConfigT _ikeyrotatorconfig)
		{
			return new ICommonRotationConfig_UnionUnion
			{
				Type = ICommonRotationConfig_Union.IKeyRotatorConfig,
				Value = _ikeyrotatorconfig
			};
		}

		// Token: 0x060227AF RID: 141231 RVA: 0x004BFDE1 File Offset: 0x004BDFE1
		public IAxisAngleMethodConfigT AsIAxisAngleMethodConfig()
		{
			return this.As<IAxisAngleMethodConfigT>();
		}

		// Token: 0x060227B0 RID: 141232 RVA: 0x004BFDE9 File Offset: 0x004BDFE9
		public static ICommonRotationConfig_UnionUnion FromIAxisAngleMethodConfig(IAxisAngleMethodConfigT _iaxisanglemethodconfig)
		{
			return new ICommonRotationConfig_UnionUnion
			{
				Type = ICommonRotationConfig_Union.IAxisAngleMethodConfig,
				Value = _iaxisanglemethodconfig
			};
		}

		// Token: 0x060227B1 RID: 141233 RVA: 0x004BFE00 File Offset: 0x004BE000
		public static int Pack(FlatBufferBuilder builder, ICommonRotationConfig_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case ICommonRotationConfig_Union.ICommonRotationConfig:
				return ICommonRotationConfig.Pack(builder, _o.AsICommonRotationConfig()).Value;
			case ICommonRotationConfig_Union.IRotationConfig:
				return IRotationConfig.Pack(builder, _o.AsIRotationConfig()).Value;
			case ICommonRotationConfig_Union.IKeyRotatorConfig:
				return IKeyRotatorConfig.Pack(builder, _o.AsIKeyRotatorConfig()).Value;
			case ICommonRotationConfig_Union.IAxisAngleMethodConfig:
				return IAxisAngleMethodConfig.Pack(builder, _o.AsIAxisAngleMethodConfig()).Value;
			default:
				return 0;
			}
		}
	}
}
