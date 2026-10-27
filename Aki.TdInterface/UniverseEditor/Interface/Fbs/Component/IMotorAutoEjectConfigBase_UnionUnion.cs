using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020055A9 RID: 21929
	public class IMotorAutoEjectConfigBase_UnionUnion
	{
		// Token: 0x1700A1F4 RID: 41460
		// (get) Token: 0x060244CF RID: 148687 RVA: 0x00502D11 File Offset: 0x00500F11
		// (set) Token: 0x060244D0 RID: 148688 RVA: 0x00502D19 File Offset: 0x00500F19
		public IMotorAutoEjectConfigBase_Union Type { get; set; }

		// Token: 0x1700A1F5 RID: 41461
		// (get) Token: 0x060244D1 RID: 148689 RVA: 0x00502D22 File Offset: 0x00500F22
		// (set) Token: 0x060244D2 RID: 148690 RVA: 0x00502D2A File Offset: 0x00500F2A
		public object Value { get; set; }

		// Token: 0x060244D3 RID: 148691 RVA: 0x00502D33 File Offset: 0x00500F33
		public IMotorAutoEjectConfigBase_UnionUnion()
		{
			this.Type = IMotorAutoEjectConfigBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060244D4 RID: 148692 RVA: 0x00502D49 File Offset: 0x00500F49
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060244D5 RID: 148693 RVA: 0x00502D5B File Offset: 0x00500F5B
		public IMotorAutoEjectConfigBaseT AsIMotorAutoEjectConfigBase()
		{
			return this.As<IMotorAutoEjectConfigBaseT>();
		}

		// Token: 0x060244D6 RID: 148694 RVA: 0x00502D63 File Offset: 0x00500F63
		public static IMotorAutoEjectConfigBase_UnionUnion FromIMotorAutoEjectConfigBase(IMotorAutoEjectConfigBaseT _imotorautoejectconfigbase)
		{
			return new IMotorAutoEjectConfigBase_UnionUnion
			{
				Type = IMotorAutoEjectConfigBase_Union.IMotorAutoEjectConfigBase,
				Value = _imotorautoejectconfigbase
			};
		}

		// Token: 0x060244D7 RID: 148695 RVA: 0x00502D78 File Offset: 0x00500F78
		public IMotorAutoEjectNextHookConfigT AsIMotorAutoEjectNextHookConfig()
		{
			return this.As<IMotorAutoEjectNextHookConfigT>();
		}

		// Token: 0x060244D8 RID: 148696 RVA: 0x00502D80 File Offset: 0x00500F80
		public static IMotorAutoEjectConfigBase_UnionUnion FromIMotorAutoEjectNextHookConfig(IMotorAutoEjectNextHookConfigT _imotorautoejectnexthookconfig)
		{
			return new IMotorAutoEjectConfigBase_UnionUnion
			{
				Type = IMotorAutoEjectConfigBase_Union.IMotorAutoEjectNextHookConfig,
				Value = _imotorautoejectnexthookconfig
			};
		}

		// Token: 0x060244D9 RID: 148697 RVA: 0x00502D95 File Offset: 0x00500F95
		public IMotorAutoEjectPositionEntityConfigT AsIMotorAutoEjectPositionEntityConfig()
		{
			return this.As<IMotorAutoEjectPositionEntityConfigT>();
		}

		// Token: 0x060244DA RID: 148698 RVA: 0x00502D9D File Offset: 0x00500F9D
		public static IMotorAutoEjectConfigBase_UnionUnion FromIMotorAutoEjectPositionEntityConfig(IMotorAutoEjectPositionEntityConfigT _imotorautoejectpositionentityconfig)
		{
			return new IMotorAutoEjectConfigBase_UnionUnion
			{
				Type = IMotorAutoEjectConfigBase_Union.IMotorAutoEjectPositionEntityConfig,
				Value = _imotorautoejectpositionentityconfig
			};
		}

		// Token: 0x060244DB RID: 148699 RVA: 0x00502DB4 File Offset: 0x00500FB4
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
