using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005585 RID: 21893
	public class IMonsterNpcInteractionConfig_UnionUnion
	{
		// Token: 0x1700A1C9 RID: 41417
		// (get) Token: 0x060243D7 RID: 148439 RVA: 0x005012FD File Offset: 0x004FF4FD
		// (set) Token: 0x060243D8 RID: 148440 RVA: 0x00501305 File Offset: 0x004FF505
		public IMonsterNpcInteractionConfig_Union Type { get; set; }

		// Token: 0x1700A1CA RID: 41418
		// (get) Token: 0x060243D9 RID: 148441 RVA: 0x0050130E File Offset: 0x004FF50E
		// (set) Token: 0x060243DA RID: 148442 RVA: 0x00501316 File Offset: 0x004FF516
		public object Value { get; set; }

		// Token: 0x060243DB RID: 148443 RVA: 0x0050131F File Offset: 0x004FF51F
		public IMonsterNpcInteractionConfig_UnionUnion()
		{
			this.Type = IMonsterNpcInteractionConfig_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060243DC RID: 148444 RVA: 0x00501335 File Offset: 0x004FF535
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060243DD RID: 148445 RVA: 0x00501347 File Offset: 0x004FF547
		public IMonsterNpcInteractionConfigT AsIMonsterNpcInteractionConfig()
		{
			return this.As<IMonsterNpcInteractionConfigT>();
		}

		// Token: 0x060243DE RID: 148446 RVA: 0x0050134F File Offset: 0x004FF54F
		public static IMonsterNpcInteractionConfig_UnionUnion FromIMonsterNpcInteractionConfig(IMonsterNpcInteractionConfigT _imonsternpcinteractionconfig)
		{
			return new IMonsterNpcInteractionConfig_UnionUnion
			{
				Type = IMonsterNpcInteractionConfig_Union.IMonsterNpcInteractionConfig,
				Value = _imonsternpcinteractionconfig
			};
		}

		// Token: 0x060243DF RID: 148447 RVA: 0x00501364 File Offset: 0x004FF564
		public IMonsterNpcInteractionWallRunT AsIMonsterNpcInteractionWallRun()
		{
			return this.As<IMonsterNpcInteractionWallRunT>();
		}

		// Token: 0x060243E0 RID: 148448 RVA: 0x0050136C File Offset: 0x004FF56C
		public static IMonsterNpcInteractionConfig_UnionUnion FromIMonsterNpcInteractionWallRun(IMonsterNpcInteractionWallRunT _imonsternpcinteractionwallrun)
		{
			return new IMonsterNpcInteractionConfig_UnionUnion
			{
				Type = IMonsterNpcInteractionConfig_Union.IMonsterNpcInteractionWallRun,
				Value = _imonsternpcinteractionwallrun
			};
		}

		// Token: 0x060243E1 RID: 148449 RVA: 0x00501381 File Offset: 0x004FF581
		public IMonsterNpcInteractionHookT AsIMonsterNpcInteractionHook()
		{
			return this.As<IMonsterNpcInteractionHookT>();
		}

		// Token: 0x060243E2 RID: 148450 RVA: 0x00501389 File Offset: 0x004FF589
		public static IMonsterNpcInteractionConfig_UnionUnion FromIMonsterNpcInteractionHook(IMonsterNpcInteractionHookT _imonsternpcinteractionhook)
		{
			return new IMonsterNpcInteractionConfig_UnionUnion
			{
				Type = IMonsterNpcInteractionConfig_Union.IMonsterNpcInteractionHook,
				Value = _imonsternpcinteractionhook
			};
		}

		// Token: 0x060243E3 RID: 148451 RVA: 0x0050139E File Offset: 0x004FF59E
		public IMonsterNpcInteractionSwordRidingT AsIMonsterNpcInteractionSwordRiding()
		{
			return this.As<IMonsterNpcInteractionSwordRidingT>();
		}

		// Token: 0x060243E4 RID: 148452 RVA: 0x005013A6 File Offset: 0x004FF5A6
		public static IMonsterNpcInteractionConfig_UnionUnion FromIMonsterNpcInteractionSwordRiding(IMonsterNpcInteractionSwordRidingT _imonsternpcinteractionswordriding)
		{
			return new IMonsterNpcInteractionConfig_UnionUnion
			{
				Type = IMonsterNpcInteractionConfig_Union.IMonsterNpcInteractionSwordRiding,
				Value = _imonsternpcinteractionswordriding
			};
		}

		// Token: 0x060243E5 RID: 148453 RVA: 0x005013BB File Offset: 0x004FF5BB
		public IMonsterNpcInteractionGazePerformT AsIMonsterNpcInteractionGazePerform()
		{
			return this.As<IMonsterNpcInteractionGazePerformT>();
		}

		// Token: 0x060243E6 RID: 148454 RVA: 0x005013C3 File Offset: 0x004FF5C3
		public static IMonsterNpcInteractionConfig_UnionUnion FromIMonsterNpcInteractionGazePerform(IMonsterNpcInteractionGazePerformT _imonsternpcinteractiongazeperform)
		{
			return new IMonsterNpcInteractionConfig_UnionUnion
			{
				Type = IMonsterNpcInteractionConfig_Union.IMonsterNpcInteractionGazePerform,
				Value = _imonsternpcinteractiongazeperform
			};
		}

		// Token: 0x060243E7 RID: 148455 RVA: 0x005013D8 File Offset: 0x004FF5D8
		public static int Pack(FlatBufferBuilder builder, IMonsterNpcInteractionConfig_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IMonsterNpcInteractionConfig_Union.IMonsterNpcInteractionConfig:
				return IMonsterNpcInteractionConfig.Pack(builder, _o.AsIMonsterNpcInteractionConfig()).Value;
			case IMonsterNpcInteractionConfig_Union.IMonsterNpcInteractionWallRun:
				return IMonsterNpcInteractionWallRun.Pack(builder, _o.AsIMonsterNpcInteractionWallRun()).Value;
			case IMonsterNpcInteractionConfig_Union.IMonsterNpcInteractionHook:
				return IMonsterNpcInteractionHook.Pack(builder, _o.AsIMonsterNpcInteractionHook()).Value;
			case IMonsterNpcInteractionConfig_Union.IMonsterNpcInteractionSwordRiding:
				return IMonsterNpcInteractionSwordRiding.Pack(builder, _o.AsIMonsterNpcInteractionSwordRiding()).Value;
			case IMonsterNpcInteractionConfig_Union.IMonsterNpcInteractionGazePerform:
				return IMonsterNpcInteractionGazePerform.Pack(builder, _o.AsIMonsterNpcInteractionGazePerform()).Value;
			default:
				return 0;
			}
		}
	}
}
