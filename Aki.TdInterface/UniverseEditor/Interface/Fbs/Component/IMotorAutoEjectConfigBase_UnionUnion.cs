using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B47 RID: 23367
	public class IMotorAutoEjectConfigBase_UnionUnion
	{
		// Token: 0x1700AA7C RID: 43644
		// (get) Token: 0x060266DC RID: 157404 RVA: 0x00543289 File Offset: 0x00541489
		// (set) Token: 0x060266DD RID: 157405 RVA: 0x00543291 File Offset: 0x00541491
		public IMotorAutoEjectConfigBase_Union Type { get; set; }

		// Token: 0x1700AA7D RID: 43645
		// (get) Token: 0x060266DE RID: 157406 RVA: 0x0054329A File Offset: 0x0054149A
		// (set) Token: 0x060266DF RID: 157407 RVA: 0x005432A2 File Offset: 0x005414A2
		public object Value { get; set; }

		// Token: 0x060266E0 RID: 157408 RVA: 0x005432AB File Offset: 0x005414AB
		public IMotorAutoEjectConfigBase_UnionUnion()
		{
			this.Type = IMotorAutoEjectConfigBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060266E1 RID: 157409 RVA: 0x005432C1 File Offset: 0x005414C1
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060266E2 RID: 157410 RVA: 0x005432D3 File Offset: 0x005414D3
		public IMotorAutoEjectConfigBaseT AsIMotorAutoEjectConfigBase()
		{
			return this.As<IMotorAutoEjectConfigBaseT>();
		}

		// Token: 0x060266E3 RID: 157411 RVA: 0x005432DB File Offset: 0x005414DB
		public static IMotorAutoEjectConfigBase_UnionUnion FromIMotorAutoEjectConfigBase(IMotorAutoEjectConfigBaseT _imotorautoejectconfigbase)
		{
			return new IMotorAutoEjectConfigBase_UnionUnion
			{
				Type = IMotorAutoEjectConfigBase_Union.IMotorAutoEjectConfigBase,
				Value = _imotorautoejectconfigbase
			};
		}

		// Token: 0x060266E4 RID: 157412 RVA: 0x005432F0 File Offset: 0x005414F0
		public IMotorAutoEjectNextHookConfigT AsIMotorAutoEjectNextHookConfig()
		{
			return this.As<IMotorAutoEjectNextHookConfigT>();
		}

		// Token: 0x060266E5 RID: 157413 RVA: 0x005432F8 File Offset: 0x005414F8
		public static IMotorAutoEjectConfigBase_UnionUnion FromIMotorAutoEjectNextHookConfig(IMotorAutoEjectNextHookConfigT _imotorautoejectnexthookconfig)
		{
			return new IMotorAutoEjectConfigBase_UnionUnion
			{
				Type = IMotorAutoEjectConfigBase_Union.IMotorAutoEjectNextHookConfig,
				Value = _imotorautoejectnexthookconfig
			};
		}

		// Token: 0x060266E6 RID: 157414 RVA: 0x0054330D File Offset: 0x0054150D
		public IMotorAutoEjectPositionEntityConfigT AsIMotorAutoEjectPositionEntityConfig()
		{
			return this.As<IMotorAutoEjectPositionEntityConfigT>();
		}

		// Token: 0x060266E7 RID: 157415 RVA: 0x00543315 File Offset: 0x00541515
		public static IMotorAutoEjectConfigBase_UnionUnion FromIMotorAutoEjectPositionEntityConfig(IMotorAutoEjectPositionEntityConfigT _imotorautoejectpositionentityconfig)
		{
			return new IMotorAutoEjectConfigBase_UnionUnion
			{
				Type = IMotorAutoEjectConfigBase_Union.IMotorAutoEjectPositionEntityConfig,
				Value = _imotorautoejectpositionentityconfig
			};
		}

		// Token: 0x060266E8 RID: 157416 RVA: 0x0054332C File Offset: 0x0054152C
		public static int Pack(FlatBufferBuilder builder, IMotorAutoEjectConfigBase_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IMotorAutoEjectConfigBase_Union.IMotorAutoEjectConfigBase:
				return IMotorAutoEjectConfigBase.Pack(builder, _o.AsIMotorAutoEjectConfigBase()).Value;
			case IMotorAutoEjectConfigBase_Union.IMotorAutoEjectNextHookConfig:
				return IMotorAutoEjectNextHookConfig.Pack(builder, _o.AsIMotorAutoEjectNextHookConfig()).Value;
			case IMotorAutoEjectConfigBase_Union.IMotorAutoEjectPositionEntityConfig:
				return IMotorAutoEjectPositionEntityConfig.Pack(builder, _o.AsIMotorAutoEjectPositionEntityConfig()).Value;
			default:
				return 0;
			}
		}
	}
}
