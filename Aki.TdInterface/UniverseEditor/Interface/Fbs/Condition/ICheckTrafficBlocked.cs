using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004B62 RID: 19298
	public struct ICheckTrafficBlocked : IFlatbufferObject
	{
		// Token: 0x17008C07 RID: 35847
		// (get) Token: 0x0601E661 RID: 124513 RVA: 0x00442054 File Offset: 0x00440254
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601E662 RID: 124514 RVA: 0x00442061 File Offset: 0x00440261
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601E663 RID: 124515 RVA: 0x00442068 File Offset: 0x00440268
		public static ICheckTrafficBlocked GetRootAsICheckTrafficBlocked(ByteBuffer _bb)
		{
			return ICheckTrafficBlocked.GetRootAsICheckTrafficBlocked(_bb, default(ICheckTrafficBlocked));
		}

		// Token: 0x0601E664 RID: 124516 RVA: 0x00442084 File Offset: 0x00440284
		public static ICheckTrafficBlocked GetRootAsICheckTrafficBlocked(ByteBuffer _bb, ICheckTrafficBlocked obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601E665 RID: 124517 RVA: 0x004420A1 File Offset: 0x004402A1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601E666 RID: 124518 RVA: 0x004420B0 File Offset: 0x004402B0
		public ICheckTrafficBlocked __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008C08 RID: 35848
		// (get) Token: 0x0601E667 RID: 124519 RVA: 0x004420C0 File Offset: 0x004402C0
		public ECondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECondition.CompareVar;
				}
				return (ECondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008C09 RID: 35849
		// (get) Token: 0x0601E668 RID: 124520 RVA: 0x004420FC File Offset: 0x004402FC
		public bool IsBlocked
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008C0A RID: 35850
		// (get) Token: 0x0601E669 RID: 124521 RVA: 0x0044213C File Offset: 0x0044033C
		public TTargetEntity TargetType
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return TTargetEntity.NONE;
				}
				return (TTargetEntity)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601E66A RID: 124522 RVA: 0x00442178 File Offset: 0x00440378
		public TTable? Target<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601E66B RID: 124523 RVA: 0x004421C0 File Offset: 0x004403C0
		public IPlayerEntity TargetAsIPlayerEntity()
		{
			return this.Target<IPlayerEntity>().Value;
		}

		// Token: 0x0601E66C RID: 124524 RVA: 0x004421DC File Offset: 0x004403DC
		public ISelfEntity TargetAsISelfEntity()
		{
			return this.Target<ISelfEntity>().Value;
		}

		// Token: 0x0601E66D RID: 124525 RVA: 0x004421F8 File Offset: 0x004403F8
		public ITargetEntity TargetAsITargetEntity()
		{
			return this.Target<ITargetEntity>().Value;
		}

		// Token: 0x0601E66E RID: 124526 RVA: 0x00442214 File Offset: 0x00440414
		public ITriggeredEntity TargetAsITriggeredEntity()
		{
			return this.Target<ITriggeredEntity>().Value;
		}

		// Token: 0x17008C0B RID: 35851
		// (get) Token: 0x0601E66F RID: 124527 RVA: 0x00442230 File Offset: 0x00440430
		public ITrafficMatchTarget? MatchTarget
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return new ITrafficMatchTarget?(default(ITrafficMatchTarget).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0601E670 RID: 124528 RVA: 0x0044228E File Offset: 0x0044048E
		public static Offset<ICheckTrafficBlocked> CreateICheckTrafficBlocked(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, bool IsBlocked = false, TTargetEntity Target_type = TTargetEntity.NONE, int TargetOffset = 0, Offset<ITrafficMatchTarget> MatchTargetOffset = default(Offset<ITrafficMatchTarget>))
		{
			builder.StartTable(5);
			ICheckTrafficBlocked.AddMatchTarget(builder, MatchTargetOffset);
			ICheckTrafficBlocked.AddTarget(builder, TargetOffset);
			ICheckTrafficBlocked.AddTargetType(builder, Target_type);
			ICheckTrafficBlocked.AddIsBlocked(builder, IsBlocked);
			ICheckTrafficBlocked.AddType(builder, Type);
			return ICheckTrafficBlocked.EndICheckTrafficBlocked(builder);
		}

		// Token: 0x0601E671 RID: 124529 RVA: 0x004422C2 File Offset: 0x004404C2
		public static void StartICheckTrafficBlocked(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0601E672 RID: 124530 RVA: 0x004422CB File Offset: 0x004404CB
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601E673 RID: 124531 RVA: 0x004422D6 File Offset: 0x004404D6
		public static void AddIsBlocked(FlatBufferBuilder builder, bool isBlocked)
		{
			builder.AddBool(1, isBlocked, false);
		}

		// Token: 0x0601E674 RID: 124532 RVA: 0x004422E1 File Offset: 0x004404E1
		public static void AddTargetType(FlatBufferBuilder builder, TTargetEntity targetType)
		{
			builder.AddByte(2, (byte)targetType, 0);
		}

		// Token: 0x0601E675 RID: 124533 RVA: 0x004422EC File Offset: 0x004404EC
		public static void AddTarget(FlatBufferBuilder builder, int targetOffset)
		{
			builder.AddOffset(3, targetOffset, 0);
		}

		// Token: 0x0601E676 RID: 124534 RVA: 0x004422F7 File Offset: 0x004404F7
		public static void AddMatchTarget(FlatBufferBuilder builder, Offset<ITrafficMatchTarget> matchTargetOffset)
		{
			builder.AddOffset(4, matchTargetOffset.Value, 0);
		}

		// Token: 0x0601E677 RID: 124535 RVA: 0x00442307 File Offset: 0x00440507
		public static Offset<ICheckTrafficBlocked> EndICheckTrafficBlocked(FlatBufferBuilder builder)
		{
			return new Offset<ICheckTrafficBlocked>(builder.EndTable());
		}

		// Token: 0x0601E678 RID: 124536 RVA: 0x00442314 File Offset: 0x00440514
		public ICheckTrafficBlockedT UnPack()
		{
			ICheckTrafficBlockedT checkTrafficBlockedT = new ICheckTrafficBlockedT();
			this.UnPackTo(checkTrafficBlockedT);
			return checkTrafficBlockedT;
		}

		// Token: 0x0601E679 RID: 124537 RVA: 0x00442330 File Offset: 0x00440530
		public void UnPackTo(ICheckTrafficBlockedT _o)
		{
			_o.Type = this.Type;
			_o.IsBlocked = this.IsBlocked;
			_o.Target = new TTargetEntityUnion();
			_o.Target.Type = this.TargetType;
			switch (this.TargetType)
			{
			case TTargetEntity.IPlayerEntity:
				_o.Target.Value = ((this.Target<IPlayerEntity>() != null) ? this.Target<IPlayerEntity>().Value.UnPack() : null);
				break;
			case TTargetEntity.ISelfEntity:
				_o.Target.Value = ((this.Target<ISelfEntity>() != null) ? this.Target<ISelfEntity>().Value.UnPack() : null);
				break;
			case TTargetEntity.ITargetEntity:
				_o.Target.Value = ((this.Target<ITargetEntity>() != null) ? this.Target<ITargetEntity>().Value.UnPack() : null);
				break;
			case TTargetEntity.ITriggeredEntity:
				_o.Target.Value = ((this.Target<ITriggeredEntity>() != null) ? this.Target<ITriggeredEntity>().Value.UnPack() : null);
				break;
			}
			_o.MatchTarget = ((this.MatchTarget != null) ? this.MatchTarget.Value.UnPack() : null);
		}

		// Token: 0x0601E67A RID: 124538 RVA: 0x004424A8 File Offset: 0x004406A8
		public static Offset<ICheckTrafficBlocked> Pack(FlatBufferBuilder builder, ICheckTrafficBlockedT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckTrafficBlocked>);
			}
			TTargetEntity target_type = (_o.Target == null) ? TTargetEntity.NONE : _o.Target.Type;
			int targetOffset = (_o.Target == null) ? 0 : TTargetEntityUnion.Pack(builder, _o.Target);
			Offset<ITrafficMatchTarget> matchTargetOffset = (_o.MatchTarget == null) ? default(Offset<ITrafficMatchTarget>) : ITrafficMatchTarget.Pack(builder, _o.MatchTarget);
			return ICheckTrafficBlocked.CreateICheckTrafficBlocked(builder, _o.Type, _o.IsBlocked, target_type, targetOffset, matchTargetOffset);
		}

		// Token: 0x0400D429 RID: 54313
		private Table __p;
	}
}
