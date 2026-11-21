using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B23 RID: 23331
	public class IMonsterNpcInteractionConfig_UnionUnion
	{
		// Token: 0x1700AA51 RID: 43601
		// (get) Token: 0x060265E4 RID: 157156 RVA: 0x00541875 File Offset: 0x0053FA75
		// (set) Token: 0x060265E5 RID: 157157 RVA: 0x0054187D File Offset: 0x0053FA7D
		public IMonsterNpcInteractionConfig_Union Type { get; set; }

		// Token: 0x1700AA52 RID: 43602
		// (get) Token: 0x060265E6 RID: 157158 RVA: 0x00541886 File Offset: 0x0053FA86
		// (set) Token: 0x060265E7 RID: 157159 RVA: 0x0054188E File Offset: 0x0053FA8E
		public object Value { get; set; }

		// Token: 0x060265E8 RID: 157160 RVA: 0x00541897 File Offset: 0x0053FA97
		public IMonsterNpcInteractionConfig_UnionUnion()
		{
			this.Type = IMonsterNpcInteractionConfig_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060265E9 RID: 157161 RVA: 0x005418AD File Offset: 0x0053FAAD
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060265EA RID: 157162 RVA: 0x005418BF File Offset: 0x0053FABF
		public IMonsterNpcInteractionConfigT AsIMonsterNpcInteractionConfig()
		{
			return this.As<IMonsterNpcInteractionConfigT>();
		}

		// Token: 0x060265EB RID: 157163 RVA: 0x005418C7 File Offset: 0x0053FAC7
		public static IMonsterNpcInteractionConfig_UnionUnion FromIMonsterNpcInteractionConfig(IMonsterNpcInteractionConfigT _imonsternpcinteractionconfig)
		{
			return new IMonsterNpcInteractionConfig_UnionUnion
			{
				Type = IMonsterNpcInteractionConfig_Union.IMonsterNpcInteractionConfig,
				Value = _imonsternpcinteractionconfig
			};
		}

		// Token: 0x060265EC RID: 157164 RVA: 0x005418DC File Offset: 0x0053FADC
		public IMonsterNpcInteractionWallRunT AsIMonsterNpcInteractionWallRun()
		{
			return this.As<IMonsterNpcInteractionWallRunT>();
		}

		// Token: 0x060265ED RID: 157165 RVA: 0x005418E4 File Offset: 0x0053FAE4
		public static IMonsterNpcInteractionConfig_UnionUnion FromIMonsterNpcInteractionWallRun(IMonsterNpcInteractionWallRunT _imonsternpcinteractionwallrun)
		{
			return new IMonsterNpcInteractionConfig_UnionUnion
			{
				Type = IMonsterNpcInteractionConfig_Union.IMonsterNpcInteractionWallRun,
				Value = _imonsternpcinteractionwallrun
			};
		}

		// Token: 0x060265EE RID: 157166 RVA: 0x005418F9 File Offset: 0x0053FAF9
		public IMonsterNpcInteractionHookT AsIMonsterNpcInteractionHook()
		{
			return this.As<IMonsterNpcInteractionHookT>();
		}

		// Token: 0x060265EF RID: 157167 RVA: 0x00541901 File Offset: 0x0053FB01
		public static IMonsterNpcInteractionConfig_UnionUnion FromIMonsterNpcInteractionHook(IMonsterNpcInteractionHookT _imonsternpcinteractionhook)
		{
			return new IMonsterNpcInteractionConfig_UnionUnion
			{
				Type = IMonsterNpcInteractionConfig_Union.IMonsterNpcInteractionHook,
				Value = _imonsternpcinteractionhook
			};
		}

		// Token: 0x060265F0 RID: 157168 RVA: 0x00541916 File Offset: 0x0053FB16
		public IMonsterNpcInteractionSwordRidingT AsIMonsterNpcInteractionSwordRiding()
		{
			return this.As<IMonsterNpcInteractionSwordRidingT>();
		}

		// Token: 0x060265F1 RID: 157169 RVA: 0x0054191E File Offset: 0x0053FB1E
		public static IMonsterNpcInteractionConfig_UnionUnion FromIMonsterNpcInteractionSwordRiding(IMonsterNpcInteractionSwordRidingT _imonsternpcinteractionswordriding)
		{
			return new IMonsterNpcInteractionConfig_UnionUnion
			{
				Type = IMonsterNpcInteractionConfig_Union.IMonsterNpcInteractionSwordRiding,
				Value = _imonsternpcinteractionswordriding
			};
		}

		// Token: 0x060265F2 RID: 157170 RVA: 0x00541933 File Offset: 0x0053FB33
		public IMonsterNpcInteractionGazePerformT AsIMonsterNpcInteractionGazePerform()
		{
			return this.As<IMonsterNpcInteractionGazePerformT>();
		}

		// Token: 0x060265F3 RID: 157171 RVA: 0x0054193B File Offset: 0x0053FB3B
		public static IMonsterNpcInteractionConfig_UnionUnion FromIMonsterNpcInteractionGazePerform(IMonsterNpcInteractionGazePerformT _imonsternpcinteractiongazeperform)
		{
			return new IMonsterNpcInteractionConfig_UnionUnion
			{
				Type = IMonsterNpcInteractionConfig_Union.IMonsterNpcInteractionGazePerform,
				Value = _imonsternpcinteractiongazeperform
			};
		}

		// Token: 0x060265F4 RID: 157172 RVA: 0x00541950 File Offset: 0x0053FB50
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
