using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004EF6 RID: 20214
	public struct ICheckGameplayTagCondition : IFlatbufferObject
	{
		// Token: 0x17009055 RID: 36949
		// (get) Token: 0x0601F633 RID: 128563 RVA: 0x0045F4E0 File Offset: 0x0045D6E0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601F634 RID: 128564 RVA: 0x0045F4ED File Offset: 0x0045D6ED
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601F635 RID: 128565 RVA: 0x0045F4F4 File Offset: 0x0045D6F4
		public static ICheckGameplayTagCondition GetRootAsICheckGameplayTagCondition(ByteBuffer _bb)
		{
			return ICheckGameplayTagCondition.GetRootAsICheckGameplayTagCondition(_bb, default(ICheckGameplayTagCondition));
		}

		// Token: 0x0601F636 RID: 128566 RVA: 0x0045F510 File Offset: 0x0045D710
		public static ICheckGameplayTagCondition GetRootAsICheckGameplayTagCondition(ByteBuffer _bb, ICheckGameplayTagCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601F637 RID: 128567 RVA: 0x0045F52D File Offset: 0x0045D72D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601F638 RID: 128568 RVA: 0x0045F53C File Offset: 0x0045D73C
		public ICheckGameplayTagCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009056 RID: 36950
		// (get) Token: 0x0601F639 RID: 128569 RVA: 0x0045F54C File Offset: 0x0045D74C
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

		// Token: 0x17009057 RID: 36951
		// (get) Token: 0x0601F63A RID: 128570 RVA: 0x0045F588 File Offset: 0x0045D788
		public TTargetEntity TargetType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TTargetEntity.NONE;
				}
				return (TTargetEntity)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601F63B RID: 128571 RVA: 0x0045F5C4 File Offset: 0x0045D7C4
		public TTable? Target<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601F63C RID: 128572 RVA: 0x0045F608 File Offset: 0x0045D808
		public IPlayerEntity TargetAsIPlayerEntity()
		{
			return this.Target<IPlayerEntity>().Value;
		}

		// Token: 0x0601F63D RID: 128573 RVA: 0x0045F624 File Offset: 0x0045D824
		public ISelfEntity TargetAsISelfEntity()
		{
			return this.Target<ISelfEntity>().Value;
		}

		// Token: 0x0601F63E RID: 128574 RVA: 0x0045F640 File Offset: 0x0045D840
		public ITargetEntity TargetAsITargetEntity()
		{
			return this.Target<ITargetEntity>().Value;
		}

		// Token: 0x0601F63F RID: 128575 RVA: 0x0045F65C File Offset: 0x0045D85C
		public ITriggeredEntity TargetAsITriggeredEntity()
		{
			return this.Target<ITriggeredEntity>().Value;
		}

		// Token: 0x17009058 RID: 36952
		// (get) Token: 0x0601F640 RID: 128576 RVA: 0x0045F678 File Offset: 0x0045D878
		public string GameplayTag
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601F641 RID: 128577 RVA: 0x0045F6B0 File Offset: 0x0045D8B0
		public Span<byte> GetGameplayTagBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0601F642 RID: 128578 RVA: 0x0045F6C0 File Offset: 0x0045D8C0
		public byte[] GetGameplayTagArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x17009059 RID: 36953
		// (get) Token: 0x0601F643 RID: 128579 RVA: 0x0045F6D0 File Offset: 0x0045D8D0
		public ECompare Compare
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return ECompare.Eq;
				}
				return (ECompare)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601F644 RID: 128580 RVA: 0x0045F70D File Offset: 0x0045D90D
		public static Offset<ICheckGameplayTagCondition> CreateICheckGameplayTagCondition(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, TTargetEntity Target_type = TTargetEntity.NONE, int TargetOffset = 0, StringOffset GameplayTagOffset = default(StringOffset), ECompare Compare = ECompare.Eq)
		{
			builder.StartTable(5);
			ICheckGameplayTagCondition.AddGameplayTag(builder, GameplayTagOffset);
			ICheckGameplayTagCondition.AddTarget(builder, TargetOffset);
			ICheckGameplayTagCondition.AddCompare(builder, Compare);
			ICheckGameplayTagCondition.AddTargetType(builder, Target_type);
			ICheckGameplayTagCondition.AddType(builder, Type);
			return ICheckGameplayTagCondition.EndICheckGameplayTagCondition(builder);
		}

		// Token: 0x0601F645 RID: 128581 RVA: 0x0045F741 File Offset: 0x0045D941
		public static void StartICheckGameplayTagCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0601F646 RID: 128582 RVA: 0x0045F74A File Offset: 0x0045D94A
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601F647 RID: 128583 RVA: 0x0045F755 File Offset: 0x0045D955
		public static void AddTargetType(FlatBufferBuilder builder, TTargetEntity targetType)
		{
			builder.AddByte(1, (byte)targetType, 0);
		}

		// Token: 0x0601F648 RID: 128584 RVA: 0x0045F760 File Offset: 0x0045D960
		public static void AddTarget(FlatBufferBuilder builder, int targetOffset)
		{
			builder.AddOffset(2, targetOffset, 0);
		}

		// Token: 0x0601F649 RID: 128585 RVA: 0x0045F76B File Offset: 0x0045D96B
		public static void AddGameplayTag(FlatBufferBuilder builder, StringOffset gameplayTagOffset)
		{
			builder.AddOffset(3, gameplayTagOffset.Value, 0);
		}

		// Token: 0x0601F64A RID: 128586 RVA: 0x0045F77B File Offset: 0x0045D97B
		public static void AddCompare(FlatBufferBuilder builder, ECompare compare)
		{
			builder.AddByte(4, (byte)compare, 0);
		}

		// Token: 0x0601F64B RID: 128587 RVA: 0x0045F786 File Offset: 0x0045D986
		public static Offset<ICheckGameplayTagCondition> EndICheckGameplayTagCondition(FlatBufferBuilder builder)
		{
			return new Offset<ICheckGameplayTagCondition>(builder.EndTable());
		}

		// Token: 0x0601F64C RID: 128588 RVA: 0x0045F794 File Offset: 0x0045D994
		public ICheckGameplayTagConditionT UnPack()
		{
			ICheckGameplayTagConditionT checkGameplayTagConditionT = new ICheckGameplayTagConditionT();
			this.UnPackTo(checkGameplayTagConditionT);
			return checkGameplayTagConditionT;
		}

		// Token: 0x0601F64D RID: 128589 RVA: 0x0045F7B0 File Offset: 0x0045D9B0
		public void UnPackTo(ICheckGameplayTagConditionT _o)
		{
			_o.Type = this.Type;
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
			_o.GameplayTag = this.GameplayTag;
			_o.Compare = this.Compare;
		}

		// Token: 0x0601F64E RID: 128590 RVA: 0x0045F904 File Offset: 0x0045DB04
		public static Offset<ICheckGameplayTagCondition> Pack(FlatBufferBuilder builder, ICheckGameplayTagConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckGameplayTagCondition>);
			}
			TTargetEntity target_type = (_o.Target == null) ? TTargetEntity.NONE : _o.Target.Type;
			int targetOffset = (_o.Target == null) ? 0 : TTargetEntityUnion.Pack(builder, _o.Target);
			StringOffset gameplayTagOffset = (_o.GameplayTag == null) ? default(StringOffset) : builder.CreateString(_o.GameplayTag);
			return ICheckGameplayTagCondition.CreateICheckGameplayTagCondition(builder, _o.Type, target_type, targetOffset, gameplayTagOffset, _o.Compare);
		}

		// Token: 0x0400DD5D RID: 56669
		private Table __p;
	}
}
