using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004F0B RID: 20235
	public class IBeamLayoutConfig_UnionUnion
	{
		// Token: 0x170091AA RID: 37290
		// (get) Token: 0x0601FFAE RID: 130990 RVA: 0x00473560 File Offset: 0x00471760
		// (set) Token: 0x0601FFAF RID: 130991 RVA: 0x00473568 File Offset: 0x00471768
		public IBeamLayoutConfig_Union Type { get; set; }

		// Token: 0x170091AB RID: 37291
		// (get) Token: 0x0601FFB0 RID: 130992 RVA: 0x00473571 File Offset: 0x00471771
		// (set) Token: 0x0601FFB1 RID: 130993 RVA: 0x00473579 File Offset: 0x00471779
		public object Value { get; set; }

		// Token: 0x0601FFB2 RID: 130994 RVA: 0x00473582 File Offset: 0x00471782
		public IBeamLayoutConfig_UnionUnion()
		{
			this.Type = IBeamLayoutConfig_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0601FFB3 RID: 130995 RVA: 0x00473598 File Offset: 0x00471798
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601FFB4 RID: 130996 RVA: 0x004735AA File Offset: 0x004717AA
		public IBeamLayoutConfigT AsIBeamLayoutConfig()
		{
			return this.As<IBeamLayoutConfigT>();
		}

		// Token: 0x0601FFB5 RID: 130997 RVA: 0x004735B2 File Offset: 0x004717B2
		public static IBeamLayoutConfig_UnionUnion FromIBeamLayoutConfig(IBeamLayoutConfigT _ibeamlayoutconfig)
		{
			return new IBeamLayoutConfig_UnionUnion
			{
				Type = IBeamLayoutConfig_Union.IBeamLayoutConfig,
				Value = _ibeamlayoutconfig
			};
		}

		// Token: 0x0601FFB6 RID: 130998 RVA: 0x004735C7 File Offset: 0x004717C7
		public IBeamLayoutConfigWallT AsIBeamLayoutConfigWall()
		{
			return this.As<IBeamLayoutConfigWallT>();
		}

		// Token: 0x0601FFB7 RID: 130999 RVA: 0x004735CF File Offset: 0x004717CF
		public static IBeamLayoutConfig_UnionUnion FromIBeamLayoutConfigWall(IBeamLayoutConfigWallT _ibeamlayoutconfigwall)
		{
			return new IBeamLayoutConfig_UnionUnion
			{
				Type = IBeamLayoutConfig_Union.IBeamLayoutConfigWall,
				Value = _ibeamlayoutconfigwall
			};
		}

		// Token: 0x0601FFB8 RID: 131000 RVA: 0x004735E4 File Offset: 0x004717E4
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
