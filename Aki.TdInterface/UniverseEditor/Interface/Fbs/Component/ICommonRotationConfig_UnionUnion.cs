using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004FCE RID: 20430
	public class ICommonRotationConfig_UnionUnion
	{
		// Token: 0x170093FD RID: 37885
		// (get) Token: 0x06020889 RID: 133257 RVA: 0x004863C4 File Offset: 0x004845C4
		// (set) Token: 0x0602088A RID: 133258 RVA: 0x004863CC File Offset: 0x004845CC
		public ICommonRotationConfig_Union Type { get; set; }

		// Token: 0x170093FE RID: 37886
		// (get) Token: 0x0602088B RID: 133259 RVA: 0x004863D5 File Offset: 0x004845D5
		// (set) Token: 0x0602088C RID: 133260 RVA: 0x004863DD File Offset: 0x004845DD
		public object Value { get; set; }

		// Token: 0x0602088D RID: 133261 RVA: 0x004863E6 File Offset: 0x004845E6
		public ICommonRotationConfig_UnionUnion()
		{
			this.Type = ICommonRotationConfig_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602088E RID: 133262 RVA: 0x004863FC File Offset: 0x004845FC
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602088F RID: 133263 RVA: 0x0048640E File Offset: 0x0048460E
		public ICommonRotationConfigT AsICommonRotationConfig()
		{
			return this.As<ICommonRotationConfigT>();
		}

		// Token: 0x06020890 RID: 133264 RVA: 0x00486416 File Offset: 0x00484616
		public static ICommonRotationConfig_UnionUnion FromICommonRotationConfig(ICommonRotationConfigT _icommonrotationconfig)
		{
			return new ICommonRotationConfig_UnionUnion
			{
				Type = ICommonRotationConfig_Union.ICommonRotationConfig,
				Value = _icommonrotationconfig
			};
		}

		// Token: 0x06020891 RID: 133265 RVA: 0x0048642B File Offset: 0x0048462B
		public IRotationConfigT AsIRotationConfig()
		{
			return this.As<IRotationConfigT>();
		}

		// Token: 0x06020892 RID: 133266 RVA: 0x00486433 File Offset: 0x00484633
		public static ICommonRotationConfig_UnionUnion FromIRotationConfig(IRotationConfigT _irotationconfig)
		{
			return new ICommonRotationConfig_UnionUnion
			{
				Type = ICommonRotationConfig_Union.IRotationConfig,
				Value = _irotationconfig
			};
		}

		// Token: 0x06020893 RID: 133267 RVA: 0x00486448 File Offset: 0x00484648
		public IKeyRotatorConfigT AsIKeyRotatorConfig()
		{
			return this.As<IKeyRotatorConfigT>();
		}

		// Token: 0x06020894 RID: 133268 RVA: 0x00486450 File Offset: 0x00484650
		public static ICommonRotationConfig_UnionUnion FromIKeyRotatorConfig(IKeyRotatorConfigT _ikeyrotatorconfig)
		{
			return new ICommonRotationConfig_UnionUnion
			{
				Type = ICommonRotationConfig_Union.IKeyRotatorConfig,
				Value = _ikeyrotatorconfig
			};
		}

		// Token: 0x06020895 RID: 133269 RVA: 0x00486468 File Offset: 0x00484668
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
			default:
				return 0;
			}
		}
	}
}
