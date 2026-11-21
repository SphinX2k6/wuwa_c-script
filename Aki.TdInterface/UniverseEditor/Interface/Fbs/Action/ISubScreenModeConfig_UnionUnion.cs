using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020079EA RID: 31210
	public class ISubScreenModeConfig_UnionUnion
	{
		// Token: 0x1700E4C7 RID: 58567
		// (get) Token: 0x06036FCC RID: 225228 RVA: 0x00759D95 File Offset: 0x00757F95
		// (set) Token: 0x06036FCD RID: 225229 RVA: 0x00759D9D File Offset: 0x00757F9D
		public ISubScreenModeConfig_Union Type { get; set; }

		// Token: 0x1700E4C8 RID: 58568
		// (get) Token: 0x06036FCE RID: 225230 RVA: 0x00759DA6 File Offset: 0x00757FA6
		// (set) Token: 0x06036FCF RID: 225231 RVA: 0x00759DAE File Offset: 0x00757FAE
		public object Value { get; set; }

		// Token: 0x06036FD0 RID: 225232 RVA: 0x00759DB7 File Offset: 0x00757FB7
		public ISubScreenModeConfig_UnionUnion()
		{
			this.Type = ISubScreenModeConfig_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06036FD1 RID: 225233 RVA: 0x00759DCD File Offset: 0x00757FCD
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06036FD2 RID: 225234 RVA: 0x00759DDF File Offset: 0x00757FDF
		public ISubScreenModeConfigT AsISubScreenModeConfig()
		{
			return this.As<ISubScreenModeConfigT>();
		}

		// Token: 0x06036FD3 RID: 225235 RVA: 0x00759DE7 File Offset: 0x00757FE7
		public static ISubScreenModeConfig_UnionUnion FromISubScreenModeConfig(ISubScreenModeConfigT _isubscreenmodeconfig)
		{
			return new ISubScreenModeConfig_UnionUnion
			{
				Type = ISubScreenModeConfig_Union.ISubScreenModeConfig,
				Value = _isubscreenmodeconfig
			};
		}

		// Token: 0x06036FD4 RID: 225236 RVA: 0x00759DFC File Offset: 0x00757FFC
		public ISubScreenModeInitT AsISubScreenModeInit()
		{
			return this.As<ISubScreenModeInitT>();
		}

		// Token: 0x06036FD5 RID: 225237 RVA: 0x00759E04 File Offset: 0x00758004
		public static ISubScreenModeConfig_UnionUnion FromISubScreenModeInit(ISubScreenModeInitT _isubscreenmodeinit)
		{
			return new ISubScreenModeConfig_UnionUnion
			{
				Type = ISubScreenModeConfig_Union.ISubScreenModeInit,
				Value = _isubscreenmodeinit
			};
		}

		// Token: 0x06036FD6 RID: 225238 RVA: 0x00759E19 File Offset: 0x00758019
		public ISubScreenModeAdjustT AsISubScreenModeAdjust()
		{
			return this.As<ISubScreenModeAdjustT>();
		}

		// Token: 0x06036FD7 RID: 225239 RVA: 0x00759E21 File Offset: 0x00758021
		public static ISubScreenModeConfig_UnionUnion FromISubScreenModeAdjust(ISubScreenModeAdjustT _isubscreenmodeadjust)
		{
			return new ISubScreenModeConfig_UnionUnion
			{
				Type = ISubScreenModeConfig_Union.ISubScreenModeAdjust,
				Value = _isubscreenmodeadjust
			};
		}

		// Token: 0x06036FD8 RID: 225240 RVA: 0x00759E36 File Offset: 0x00758036
		public ISubScreenModeExitT AsISubScreenModeExit()
		{
			return this.As<ISubScreenModeExitT>();
		}

		// Token: 0x06036FD9 RID: 225241 RVA: 0x00759E3E File Offset: 0x0075803E
		public static ISubScreenModeConfig_UnionUnion FromISubScreenModeExit(ISubScreenModeExitT _isubscreenmodeexit)
		{
			return new ISubScreenModeConfig_UnionUnion
			{
				Type = ISubScreenModeConfig_Union.ISubScreenModeExit,
				Value = _isubscreenmodeexit
			};
		}

		// Token: 0x06036FDA RID: 225242 RVA: 0x00759E54 File Offset: 0x00758054
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
