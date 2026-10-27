using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007215 RID: 29205
	public class ISubScreenModeConfig_UnionUnion
	{
		// Token: 0x1700D8CE RID: 55502
		// (get) Token: 0x06033CCA RID: 212170 RVA: 0x006F8A35 File Offset: 0x006F6C35
		// (set) Token: 0x06033CCB RID: 212171 RVA: 0x006F8A3D File Offset: 0x006F6C3D
		public ISubScreenModeConfig_Union Type { get; set; }

		// Token: 0x1700D8CF RID: 55503
		// (get) Token: 0x06033CCC RID: 212172 RVA: 0x006F8A46 File Offset: 0x006F6C46
		// (set) Token: 0x06033CCD RID: 212173 RVA: 0x006F8A4E File Offset: 0x006F6C4E
		public object Value { get; set; }

		// Token: 0x06033CCE RID: 212174 RVA: 0x006F8A57 File Offset: 0x006F6C57
		public ISubScreenModeConfig_UnionUnion()
		{
			this.Type = ISubScreenModeConfig_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06033CCF RID: 212175 RVA: 0x006F8A6D File Offset: 0x006F6C6D
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06033CD0 RID: 212176 RVA: 0x006F8A7F File Offset: 0x006F6C7F
		public ISubScreenModeConfigT AsISubScreenModeConfig()
		{
			return this.As<ISubScreenModeConfigT>();
		}

		// Token: 0x06033CD1 RID: 212177 RVA: 0x006F8A87 File Offset: 0x006F6C87
		public static ISubScreenModeConfig_UnionUnion FromISubScreenModeConfig(ISubScreenModeConfigT _isubscreenmodeconfig)
		{
			return new ISubScreenModeConfig_UnionUnion
			{
				Type = ISubScreenModeConfig_Union.ISubScreenModeConfig,
				Value = _isubscreenmodeconfig
			};
		}

		// Token: 0x06033CD2 RID: 212178 RVA: 0x006F8A9C File Offset: 0x006F6C9C
		public ISubScreenModeInitT AsISubScreenModeInit()
		{
			return this.As<ISubScreenModeInitT>();
		}

		// Token: 0x06033CD3 RID: 212179 RVA: 0x006F8AA4 File Offset: 0x006F6CA4
		public static ISubScreenModeConfig_UnionUnion FromISubScreenModeInit(ISubScreenModeInitT _isubscreenmodeinit)
		{
			return new ISubScreenModeConfig_UnionUnion
			{
				Type = ISubScreenModeConfig_Union.ISubScreenModeInit,
				Value = _isubscreenmodeinit
			};
		}

		// Token: 0x06033CD4 RID: 212180 RVA: 0x006F8AB9 File Offset: 0x006F6CB9
		public ISubScreenModeAdjustT AsISubScreenModeAdjust()
		{
			return this.As<ISubScreenModeAdjustT>();
		}

		// Token: 0x06033CD5 RID: 212181 RVA: 0x006F8AC1 File Offset: 0x006F6CC1
		public static ISubScreenModeConfig_UnionUnion FromISubScreenModeAdjust(ISubScreenModeAdjustT _isubscreenmodeadjust)
		{
			return new ISubScreenModeConfig_UnionUnion
			{
				Type = ISubScreenModeConfig_Union.ISubScreenModeAdjust,
				Value = _isubscreenmodeadjust
			};
		}

		// Token: 0x06033CD6 RID: 212182 RVA: 0x006F8AD6 File Offset: 0x006F6CD6
		public ISubScreenModeExitT AsISubScreenModeExit()
		{
			return this.As<ISubScreenModeExitT>();
		}

		// Token: 0x06033CD7 RID: 212183 RVA: 0x006F8ADE File Offset: 0x006F6CDE
		public static ISubScreenModeConfig_UnionUnion FromISubScreenModeExit(ISubScreenModeExitT _isubscreenmodeexit)
		{
			return new ISubScreenModeConfig_UnionUnion
			{
				Type = ISubScreenModeConfig_Union.ISubScreenModeExit,
				Value = _isubscreenmodeexit
			};
		}

		// Token: 0x06033CD8 RID: 212184 RVA: 0x006F8AF4 File Offset: 0x006F6CF4
		public static int Pack(FlatBufferBuilder builder, ISubScreenModeConfig_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case ISubScreenModeConfig_Union.ISubScreenModeConfig:
				return ISubScreenModeConfig.Pack(builder, _o.AsISubScreenModeConfig()).Value;
			case ISubScreenModeConfig_Union.ISubScreenModeInit:
				return ISubScreenModeInit.Pack(builder, _o.AsISubScreenModeInit()).Value;
			case ISubScreenModeConfig_Union.ISubScreenModeAdjust:
				return ISubScreenModeAdjust.Pack(builder, _o.AsISubScreenModeAdjust()).Value;
			case ISubScreenModeConfig_Union.ISubScreenModeExit:
				return ISubScreenModeExit.Pack(builder, _o.AsISubScreenModeExit()).Value;
			default:
				return 0;
			}
		}
	}
}
