using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005049 RID: 20553
	public struct ICheckTrafficBlocked : IFlatbufferObject
	{
		// Token: 0x17009317 RID: 37655
		// (get) Token: 0x060201EF RID: 131567 RVA: 0x004748A0 File Offset: 0x00472AA0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060201F0 RID: 131568 RVA: 0x004748AD File Offset: 0x00472AAD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060201F1 RID: 131569 RVA: 0x004748B4 File Offset: 0x00472AB4
		public static ICheckTrafficBlocked GetRootAsICheckTrafficBlocked(ByteBuffer _bb)
		{
			return ICheckTrafficBlocked.GetRootAsICheckTrafficBlocked(_bb, default(ICheckTrafficBlocked));
		}

		// Token: 0x060201F2 RID: 131570 RVA: 0x004748D0 File Offset: 0x00472AD0
		public static ICheckTrafficBlocked GetRootAsICheckTrafficBlocked(ByteBuffer _bb, ICheckTrafficBlocked obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060201F3 RID: 131571 RVA: 0x004748ED File Offset: 0x00472AED
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060201F4 RID: 131572 RVA: 0x004748FC File Offset: 0x00472AFC
		public ICheckTrafficBlocked __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009318 RID: 37656
		// (get) Token: 0x060201F5 RID: 131573 RVA: 0x0047490C File Offset: 0x00472B0C
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

		// Token: 0x17009319 RID: 37657
		// (get) Token: 0x060201F6 RID: 131574 RVA: 0x00474948 File Offset: 0x00472B48
		public bool IsBlocked
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700931A RID: 37658
		// (get) Token: 0x060201F7 RID: 131575 RVA: 0x00474988 File Offset: 0x00472B88
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

		// Token: 0x060201F8 RID: 131576 RVA: 0x004749C4 File Offset: 0x00472BC4
		public TTable? Target<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060201F9 RID: 131577 RVA: 0x00474A0C File Offset: 0x00472C0C
		public IPlayerEntity TargetAsIPlayerEntity()
		{
			return this.Target<IPlayerEntity>().Value;
		}

		// Token: 0x060201FA RID: 131578 RVA: 0x00474A28 File Offset: 0x00472C28
		public ISelfEntity TargetAsISelfEntity()
		{
			return this.Target<ISelfEntity>().Value;
		}

		// Token: 0x060201FB RID: 131579 RVA: 0x00474A44 File Offset: 0x00472C44
		public ITargetEntity TargetAsITargetEntity()
		{
			return this.Target<ITargetEntity>().Value;
		}

		// Token: 0x060201FC RID: 131580 RVA: 0x00474A60 File Offset: 0x00472C60
		public ITriggeredEntity TargetAsITriggeredEntity()
		{
			return this.Target<ITriggeredEntity>().Value;
		}

		// Token: 0x1700931B RID: 37659
		// (get) Token: 0x060201FD RID: 131581 RVA: 0x00474A7C File Offset: 0x00472C7C
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

		// Token: 0x060201FE RID: 131582 RVA: 0x00474ADA File Offset: 0x00472CDA
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

		// Token: 0x060201FF RID: 131583 RVA: 0x00474B0E File Offset: 0x00472D0E
		public static void StartICheckTrafficBlocked(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06020200 RID: 131584 RVA: 0x00474B17 File Offset: 0x00472D17
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06020201 RID: 131585 RVA: 0x00474B22 File Offset: 0x00472D22
		public static void AddIsBlocked(FlatBufferBuilder builder, bool isBlocked)
		{
			builder.AddBool(1, isBlocked, false);
		}

		// Token: 0x06020202 RID: 131586 RVA: 0x00474B2D File Offset: 0x00472D2D
		public static void AddTargetType(FlatBufferBuilder builder, TTargetEntity targetType)
		{
			builder.AddByte(2, (byte)targetType, 0);
		}

		// Token: 0x06020203 RID: 131587 RVA: 0x00474B38 File Offset: 0x00472D38
		public static void AddTarget(FlatBufferBuilder builder, int targetOffset)
		{
			builder.AddOffset(3, targetOffset, 0);
		}

		// Token: 0x06020204 RID: 131588 RVA: 0x00474B43 File Offset: 0x00472D43
		public static void AddMatchTarget(FlatBufferBuilder builder, Offset<ITrafficMatchTarget> matchTargetOffset)
		{
			builder.AddOffset(4, matchTargetOffset.Value, 0);
		}

		// Token: 0x06020205 RID: 131589 RVA: 0x00474B53 File Offset: 0x00472D53
		public static Offset<ICheckTrafficBlocked> EndICheckTrafficBlocked(FlatBufferBuilder builder)
		{
			return new Offset<ICheckTrafficBlocked>(builder.EndTable());
		}

		// Token: 0x06020206 RID: 131590 RVA: 0x00474B60 File Offset: 0x00472D60
		public ICheckTrafficBlockedT UnPack()
		{
			ICheckTrafficBlockedT checkTrafficBlockedT = new ICheckTrafficBlockedT();
			this.UnPackTo(checkTrafficBlockedT);
			return checkTrafficBlockedT;
		}

		// Token: 0x06020207 RID: 131591 RVA: 0x00474B7C File Offset: 0x00472D7C
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

		// Token: 0x06020208 RID: 131592 RVA: 0x00474CF4 File Offset: 0x00472EF4
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

		// Token: 0x0400DF29 RID: 57129
		private Table __p;
	}
}
