using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200628C RID: 25228
	public class TMonsterNpcInteractionConfigUnion
	{
		// Token: 0x1700BB74 RID: 47988
		// (get) Token: 0x0602AEA1 RID: 175777 RVA: 0x005DB3DE File Offset: 0x005D95DE
		// (set) Token: 0x0602AEA2 RID: 175778 RVA: 0x005DB3E6 File Offset: 0x005D95E6
		public TMonsterNpcInteractionConfig Type { get; set; }

		// Token: 0x1700BB75 RID: 47989
		// (get) Token: 0x0602AEA3 RID: 175779 RVA: 0x005DB3EF File Offset: 0x005D95EF
		// (set) Token: 0x0602AEA4 RID: 175780 RVA: 0x005DB3F7 File Offset: 0x005D95F7
		public object Value { get; set; }

		// Token: 0x0602AEA5 RID: 175781 RVA: 0x005DB400 File Offset: 0x005D9600
		public TMonsterNpcInteractionConfigUnion()
		{
			this.Type = TMonsterNpcInteractionConfig.NONE;
			this.Value = null;
		}

		// Token: 0x0602AEA6 RID: 175782 RVA: 0x005DB416 File Offset: 0x005D9616
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602AEA7 RID: 175783 RVA: 0x005DB428 File Offset: 0x005D9628
		public IMonsterNpcInteractionGazePerformT AsIMonsterNpcInteractionGazePerform()
		{
			return this.As<IMonsterNpcInteractionGazePerformT>();
		}

		// Token: 0x0602AEA8 RID: 175784 RVA: 0x005DB430 File Offset: 0x005D9630
		public static TMonsterNpcInteractionConfigUnion FromIMonsterNpcInteractionGazePerform(IMonsterNpcInteractionGazePerformT _imonsternpcinteractiongazeperform)
		{
			return new TMonsterNpcInteractionConfigUnion
			{
				Type = TMonsterNpcInteractionConfig.IMonsterNpcInteractionGazePerform,
				Value = _imonsternpcinteractiongazeperform
			};
		}

		// Token: 0x0602AEA9 RID: 175785 RVA: 0x005DB445 File Offset: 0x005D9645
		public IMonsterNpcInteractionHookT AsIMonsterNpcInteractionHook()
		{
			return this.As<IMonsterNpcInteractionHookT>();
		}

		// Token: 0x0602AEAA RID: 175786 RVA: 0x005DB44D File Offset: 0x005D964D
		public static TMonsterNpcInteractionConfigUnion FromIMonsterNpcInteractionHook(IMonsterNpcInteractionHookT _imonsternpcinteractionhook)
		{
			return new TMonsterNpcInteractionConfigUnion
			{
				Type = TMonsterNpcInteractionConfig.IMonsterNpcInteractionHook,
				Value = _imonsternpcinteractionhook
			};
		}

		// Token: 0x0602AEAB RID: 175787 RVA: 0x005DB462 File Offset: 0x005D9662
		public IMonsterNpcInteractionSwordRidingT AsIMonsterNpcInteractionSwordRiding()
		{
			return this.As<IMonsterNpcInteractionSwordRidingT>();
		}

		// Token: 0x0602AEAC RID: 175788 RVA: 0x005DB46A File Offset: 0x005D966A
		public static TMonsterNpcInteractionConfigUnion FromIMonsterNpcInteractionSwordRiding(IMonsterNpcInteractionSwordRidingT _imonsternpcinteractionswordriding)
		{
			return new TMonsterNpcInteractionConfigUnion
			{
				Type = TMonsterNpcInteractionConfig.IMonsterNpcInteractionSwordRiding,
				Value = _imonsternpcinteractionswordriding
			};
		}

		// Token: 0x0602AEAD RID: 175789 RVA: 0x005DB47F File Offset: 0x005D967F
		public IMonsterNpcInteractionWallRunT AsIMonsterNpcInteractionWallRun()
		{
			return this.As<IMonsterNpcInteractionWallRunT>();
		}

		// Token: 0x0602AEAE RID: 175790 RVA: 0x005DB487 File Offset: 0x005D9687
		public static TMonsterNpcInteractionConfigUnion FromIMonsterNpcInteractionWallRun(IMonsterNpcInteractionWallRunT _imonsternpcinteractionwallrun)
		{
			return new TMonsterNpcInteractionConfigUnion
			{
				Type = TMonsterNpcInteractionConfig.IMonsterNpcInteractionWallRun,
				Value = _imonsternpcinteractionwallrun
			};
		}

		// Token: 0x0602AEAF RID: 175791 RVA: 0x005DB49C File Offset: 0x005D969C
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
