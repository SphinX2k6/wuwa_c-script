using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005BE9 RID: 23529
	public class TAttachTargetUnion
	{
		// Token: 0x1700B1C5 RID: 45509
		// (get) Token: 0x0602851F RID: 165151 RVA: 0x0058A28C File Offset: 0x0058848C
		// (set) Token: 0x06028520 RID: 165152 RVA: 0x0058A294 File Offset: 0x00588494
		public TAttachTarget Type { get; set; }

		// Token: 0x1700B1C6 RID: 45510
		// (get) Token: 0x06028521 RID: 165153 RVA: 0x0058A29D File Offset: 0x0058849D
		// (set) Token: 0x06028522 RID: 165154 RVA: 0x0058A2A5 File Offset: 0x005884A5
		public object Value { get; set; }

		// Token: 0x06028523 RID: 165155 RVA: 0x0058A2AE File Offset: 0x005884AE
		public TAttachTargetUnion()
		{
			this.Type = TAttachTarget.NONE;
			this.Value = null;
		}

		// Token: 0x06028524 RID: 165156 RVA: 0x0058A2C4 File Offset: 0x005884C4
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06028525 RID: 165157 RVA: 0x0058A2D6 File Offset: 0x005884D6
		public IActorAttachTargetT AsIActorAttachTarget()
		{
			return this.As<IActorAttachTargetT>();
		}

		// Token: 0x06028526 RID: 165158 RVA: 0x0058A2DE File Offset: 0x005884DE
		public static TAttachTargetUnion FromIActorAttachTarget(IActorAttachTargetT _iactorattachtarget)
		{
			return new TAttachTargetUnion
			{
				Type = TAttachTarget.IActorAttachTarget,
				Value = _iactorattachtarget
			};
		}

		// Token: 0x06028527 RID: 165159 RVA: 0x0058A2F3 File Offset: 0x005884F3
		public IDynamicAttachTargetT AsIDynamicAttachTarget()
		{
			return this.As<IDynamicAttachTargetT>();
		}

		// Token: 0x06028528 RID: 165160 RVA: 0x0058A2FB File Offset: 0x005884FB
		public static TAttachTargetUnion FromIDynamicAttachTarget(IDynamicAttachTargetT _idynamicattachtarget)
		{
			return new TAttachTargetUnion
			{
				Type = TAttachTarget.IDynamicAttachTarget,
				Value = _idynamicattachtarget
			};
		}

		// Token: 0x06028529 RID: 165161 RVA: 0x0058A310 File Offset: 0x00588510
		public IEntityAttachTargetT AsIEntityAttachTarget()
		{
			return this.As<IEntityAttachTargetT>();
		}

		// Token: 0x0602852A RID: 165162 RVA: 0x0058A318 File Offset: 0x00588518
		public static TAttachTargetUnion FromIEntityAttachTarget(IEntityAttachTargetT _ientityattachtarget)
		{
			return new TAttachTargetUnion
			{
				Type = TAttachTarget.IEntityAttachTarget,
				Value = _ientityattachtarget
			};
		}

		// Token: 0x0602852B RID: 165163 RVA: 0x0058A32D File Offset: 0x0058852D
		public IPlayerAttachTargetT AsIPlayerAttachTarget()
		{
			return this.As<IPlayerAttachTargetT>();
		}

		// Token: 0x0602852C RID: 165164 RVA: 0x0058A335 File Offset: 0x00588535
		public static TAttachTargetUnion FromIPlayerAttachTarget(IPlayerAttachTargetT _iplayerattachtarget)
		{
			return new TAttachTargetUnion
			{
				Type = TAttachTarget.IPlayerAttachTarget,
				Value = _iplayerattachtarget
			};
		}

		// Token: 0x0602852D RID: 165165 RVA: 0x0058A34A File Offset: 0x0058854A
		public IPointAttachTargetT AsIPointAttachTarget()
		{
			return this.As<IPointAttachTargetT>();
		}

		// Token: 0x0602852E RID: 165166 RVA: 0x0058A352 File Offset: 0x00588552
		public static TAttachTargetUnion FromIPointAttachTarget(IPointAttachTargetT _ipointattachtarget)
		{
			return new TAttachTargetUnion
			{
				Type = TAttachTarget.IPointAttachTarget,
				Value = _ipointattachtarget
			};
		}

		// Token: 0x0602852F RID: 165167 RVA: 0x0058A368 File Offset: 0x00588568
		public static int Pack(FlatBufferBuilder builder, TAttachTargetUnion _o)
		{
			switch (_o.Type)
			{
			case TAttachTarget.IActorAttachTarget:
				return IActorAttachTarget.Pack(builder, _o.AsIActorAttachTarget()).Value;
			case TAttachTarget.IDynamicAttachTarget:
				return IDynamicAttachTarget.Pack(builder, _o.AsIDynamicAttachTarget()).Value;
			case TAttachTarget.IEntityAttachTarget:
				return IEntityAttachTarget.Pack(builder, _o.AsIEntityAttachTarget()).Value;
			case TAttachTarget.IPlayerAttachTarget:
				return IPlayerAttachTarget.Pack(builder, _o.AsIPlayerAttachTarget()).Value;
			case TAttachTarget.IPointAttachTarget:
				return IPointAttachTarget.Pack(builder, _o.AsIPointAttachTarget()).Value;
			default:
				return 0;
			}
		}
	}
}
