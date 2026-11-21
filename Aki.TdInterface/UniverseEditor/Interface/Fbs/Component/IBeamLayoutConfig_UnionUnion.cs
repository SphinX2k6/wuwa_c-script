using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200543D RID: 21565
	public class IBeamLayoutConfig_UnionUnion
	{
		// Token: 0x1700992C RID: 39212
		// (get) Token: 0x06021D1E RID: 138526 RVA: 0x004A98F4 File Offset: 0x004A7AF4
		// (set) Token: 0x06021D1F RID: 138527 RVA: 0x004A98FC File Offset: 0x004A7AFC
		public IBeamLayoutConfig_Union Type { get; set; }

		// Token: 0x1700992D RID: 39213
		// (get) Token: 0x06021D20 RID: 138528 RVA: 0x004A9905 File Offset: 0x004A7B05
		// (set) Token: 0x06021D21 RID: 138529 RVA: 0x004A990D File Offset: 0x004A7B0D
		public object Value { get; set; }

		// Token: 0x06021D22 RID: 138530 RVA: 0x004A9916 File Offset: 0x004A7B16
		public IBeamLayoutConfig_UnionUnion()
		{
			this.Type = IBeamLayoutConfig_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06021D23 RID: 138531 RVA: 0x004A992C File Offset: 0x004A7B2C
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06021D24 RID: 138532 RVA: 0x004A993E File Offset: 0x004A7B3E
		public IBeamLayoutConfigT AsIBeamLayoutConfig()
		{
			return this.As<IBeamLayoutConfigT>();
		}

		// Token: 0x06021D25 RID: 138533 RVA: 0x004A9946 File Offset: 0x004A7B46
		public static IBeamLayoutConfig_UnionUnion FromIBeamLayoutConfig(IBeamLayoutConfigT _ibeamlayoutconfig)
		{
			return new IBeamLayoutConfig_UnionUnion
			{
				Type = IBeamLayoutConfig_Union.IBeamLayoutConfig,
				Value = _ibeamlayoutconfig
			};
		}

		// Token: 0x06021D26 RID: 138534 RVA: 0x004A995B File Offset: 0x004A7B5B
		public IBeamLayoutConfigWallT AsIBeamLayoutConfigWall()
		{
			return this.As<IBeamLayoutConfigWallT>();
		}

		// Token: 0x06021D27 RID: 138535 RVA: 0x004A9963 File Offset: 0x004A7B63
		public static IBeamLayoutConfig_UnionUnion FromIBeamLayoutConfigWall(IBeamLayoutConfigWallT _ibeamlayoutconfigwall)
		{
			return new IBeamLayoutConfig_UnionUnion
			{
				Type = IBeamLayoutConfig_Union.IBeamLayoutConfigWall,
				Value = _ibeamlayoutconfigwall
			};
		}

		// Token: 0x06021D28 RID: 138536 RVA: 0x004A9978 File Offset: 0x004A7B78
		public static int Pack(FlatBufferBuilder builder, IBeamLayoutConfig_UnionUnion _o)
		{
			IBeamLayoutConfig_Union type = _o.Type;
			if (type == IBeamLayoutConfig_Union.IBeamLayoutConfig)
			{
				return IBeamLayoutConfig.Pack(builder, _o.AsIBeamLayoutConfig()).Value;
			}
			if (type != IBeamLayoutConfig_Union.IBeamLayoutConfigWall)
			{
				return 0;
			}
			return IBeamLayoutConfigWall.Pack(builder, _o.AsIBeamLayoutConfigWall()).Value;
		}
	}
}
