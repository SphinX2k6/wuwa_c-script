using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C64 RID: 23652
	public class TMonsterNpcInteractionConfigUnion
	{
		// Token: 0x1700B220 RID: 45600
		// (get) Token: 0x06028885 RID: 166021 RVA: 0x0059307A File Offset: 0x0059127A
		// (set) Token: 0x06028886 RID: 166022 RVA: 0x00593082 File Offset: 0x00591282
		public TMonsterNpcInteractionConfig Type { get; set; }

		// Token: 0x1700B221 RID: 45601
		// (get) Token: 0x06028887 RID: 166023 RVA: 0x0059308B File Offset: 0x0059128B
		// (set) Token: 0x06028888 RID: 166024 RVA: 0x00593093 File Offset: 0x00591293
		public object Value { get; set; }

		// Token: 0x06028889 RID: 166025 RVA: 0x0059309C File Offset: 0x0059129C
		public TMonsterNpcInteractionConfigUnion()
		{
			this.Type = TMonsterNpcInteractionConfig.NONE;
			this.Value = null;
		}

		// Token: 0x0602888A RID: 166026 RVA: 0x005930B2 File Offset: 0x005912B2
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602888B RID: 166027 RVA: 0x005930C4 File Offset: 0x005912C4
		public IMonsterNpcInteractionGazePerformT AsIMonsterNpcInteractionGazePerform()
		{
			return this.As<IMonsterNpcInteractionGazePerformT>();
		}

		// Token: 0x0602888C RID: 166028 RVA: 0x005930CC File Offset: 0x005912CC
		public static TMonsterNpcInteractionConfigUnion FromIMonsterNpcInteractionGazePerform(IMonsterNpcInteractionGazePerformT _imonsternpcinteractiongazeperform)
		{
			return new TMonsterNpcInteractionConfigUnion
			{
				Type = TMonsterNpcInteractionConfig.IMonsterNpcInteractionGazePerform,
				Value = _imonsternpcinteractiongazeperform
			};
		}

		// Token: 0x0602888D RID: 166029 RVA: 0x005930E1 File Offset: 0x005912E1
		public IMonsterNpcInteractionHookT AsIMonsterNpcInteractionHook()
		{
			return this.As<IMonsterNpcInteractionHookT>();
		}

		// Token: 0x0602888E RID: 166030 RVA: 0x005930E9 File Offset: 0x005912E9
		public static TMonsterNpcInteractionConfigUnion FromIMonsterNpcInteractionHook(IMonsterNpcInteractionHookT _imonsternpcinteractionhook)
		{
			return new TMonsterNpcInteractionConfigUnion
			{
				Type = TMonsterNpcInteractionConfig.IMonsterNpcInteractionHook,
				Value = _imonsternpcinteractionhook
			};
		}

		// Token: 0x0602888F RID: 166031 RVA: 0x005930FE File Offset: 0x005912FE
		public IMonsterNpcInteractionSwordRidingT AsIMonsterNpcInteractionSwordRiding()
		{
			return this.As<IMonsterNpcInteractionSwordRidingT>();
		}

		// Token: 0x06028890 RID: 166032 RVA: 0x00593106 File Offset: 0x00591306
		public static TMonsterNpcInteractionConfigUnion FromIMonsterNpcInteractionSwordRiding(IMonsterNpcInteractionSwordRidingT _imonsternpcinteractionswordriding)
		{
			return new TMonsterNpcInteractionConfigUnion
			{
				Type = TMonsterNpcInteractionConfig.IMonsterNpcInteractionSwordRiding,
				Value = _imonsternpcinteractionswordriding
			};
		}

		// Token: 0x06028891 RID: 166033 RVA: 0x0059311B File Offset: 0x0059131B
		public IMonsterNpcInteractionWallRunT AsIMonsterNpcInteractionWallRun()
		{
			return this.As<IMonsterNpcInteractionWallRunT>();
		}

		// Token: 0x06028892 RID: 166034 RVA: 0x00593123 File Offset: 0x00591323
		public static TMonsterNpcInteractionConfigUnion FromIMonsterNpcInteractionWallRun(IMonsterNpcInteractionWallRunT _imonsternpcinteractionwallrun)
		{
			return new TMonsterNpcInteractionConfigUnion
			{
				Type = TMonsterNpcInteractionConfig.IMonsterNpcInteractionWallRun,
				Value = _imonsternpcinteractionwallrun
			};
		}

		// Token: 0x06028893 RID: 166035 RVA: 0x00593138 File Offset: 0x00591338
		public static int Pack(FlatBufferBuilder builder, TMonsterNpcInteractionConfigUnion _o)
		{
			switch (_o.Type)
			{
			case TMonsterNpcInteractionConfig.IMonsterNpcInteractionGazePerform:
				return IMonsterNpcInteractionGazePerform.Pack(builder, _o.AsIMonsterNpcInteractionGazePerform()).Value;
			case TMonsterNpcInteractionConfig.IMonsterNpcInteractionHook:
				return IMonsterNpcInteractionHook.Pack(builder, _o.AsIMonsterNpcInteractionHook()).Value;
			case TMonsterNpcInteractionConfig.IMonsterNpcInteractionSwordRiding:
				return IMonsterNpcInteractionSwordRiding.Pack(builder, _o.AsIMonsterNpcInteractionSwordRiding()).Value;
			case TMonsterNpcInteractionConfig.IMonsterNpcInteractionWallRun:
				return IMonsterNpcInteractionWallRun.Pack(builder, _o.AsIMonsterNpcInteractionWallRun()).Value;
			default:
				return 0;
			}
		}
	}
}
