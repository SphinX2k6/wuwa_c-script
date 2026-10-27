using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004A33 RID: 18995
	public struct ICheckGameplayTagCondition : IFlatbufferObject
	{
		// Token: 0x17008980 RID: 35200
		// (get) Token: 0x0601DBAA RID: 121770 RVA: 0x0042E5E8 File Offset: 0x0042C7E8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601DBAB RID: 121771 RVA: 0x0042E5F5 File Offset: 0x0042C7F5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601DBAC RID: 121772 RVA: 0x0042E5FC File Offset: 0x0042C7FC
		public static ICheckGameplayTagCondition GetRootAsICheckGameplayTagCondition(ByteBuffer _bb)
		{
			return ICheckGameplayTagCondition.GetRootAsICheckGameplayTagCondition(_bb, default(ICheckGameplayTagCondition));
		}

		// Token: 0x0601DBAD RID: 121773 RVA: 0x0042E618 File Offset: 0x0042C818
		public static ICheckGameplayTagCondition GetRootAsICheckGameplayTagCondition(ByteBuffer _bb, ICheckGameplayTagCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601DBAE RID: 121774 RVA: 0x0042E635 File Offset: 0x0042C835
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601DBAF RID: 121775 RVA: 0x0042E644 File Offset: 0x0042C844
		public ICheckGameplayTagCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008981 RID: 35201
		// (get) Token: 0x0601DBB0 RID: 121776 RVA: 0x0042E654 File Offset: 0x0042C854
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

		// Token: 0x17008982 RID: 35202
		// (get) Token: 0x0601DBB1 RID: 121777 RVA: 0x0042E690 File Offset: 0x0042C890
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

		// Token: 0x0601DBB2 RID: 121778 RVA: 0x0042E6CC File Offset: 0x0042C8CC
		public TTable? Target<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601DBB3 RID: 121779 RVA: 0x0042E710 File Offset: 0x0042C910
		public IPlayerEntity TargetAsIPlayerEntity()
		{
			return this.Target<IPlayerEntity>().Value;
		}

		// Token: 0x0601DBB4 RID: 121780 RVA: 0x0042E72C File Offset: 0x0042C92C
		public ISelfEntity TargetAsISelfEntity()
		{
			return this.Target<ISelfEntity>().Value;
		}

		// Token: 0x0601DBB5 RID: 121781 RVA: 0x0042E748 File Offset: 0x0042C948
		public ITargetEntity TargetAsITargetEntity()
		{
			return this.Target<ITargetEntity>().Value;
		}

		// Token: 0x0601DBB6 RID: 121782 RVA: 0x0042E764 File Offset: 0x0042C964
		public ITriggeredEntity TargetAsITriggeredEntity()
		{
			return this.Target<ITriggeredEntity>().Value;
		}

		// Token: 0x17008983 RID: 35203
		// (get) Token: 0x0601DBB7 RID: 121783 RVA: 0x0042E780 File Offset: 0x0042C980
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

		// Token: 0x0601DBB8 RID: 121784 RVA: 0x0042E7B8 File Offset: 0x0042C9B8
		public Span<byte> GetGameplayTagBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0601DBB9 RID: 121785 RVA: 0x0042E7C8 File Offset: 0x0042C9C8
		public byte[] GetGameplayTagArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x17008984 RID: 35204
		// (get) Token: 0x0601DBBA RID: 121786 RVA: 0x0042E7D8 File Offset: 0x0042C9D8
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

		// Token: 0x0601DBBB RID: 121787 RVA: 0x0042E815 File Offset: 0x0042CA15
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

		// Token: 0x0601DBBC RID: 121788 RVA: 0x0042E849 File Offset: 0x0042CA49
		public static void StartICheckGameplayTagCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0601DBBD RID: 121789 RVA: 0x0042E852 File Offset: 0x0042CA52
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601DBBE RID: 121790 RVA: 0x0042E85D File Offset: 0x0042CA5D
		public static void AddTargetType(FlatBufferBuilder builder, TTargetEntity targetType)
		{
			builder.AddByte(1, (byte)targetType, 0);
		}

		// Token: 0x0601DBBF RID: 121791 RVA: 0x0042E868 File Offset: 0x0042CA68
		public static void AddTarget(FlatBufferBuilder builder, int targetOffset)
		{
			builder.AddOffset(2, targetOffset, 0);
		}

		// Token: 0x0601DBC0 RID: 121792 RVA: 0x0042E873 File Offset: 0x0042CA73
		public static void AddGameplayTag(FlatBufferBuilder builder, StringOffset gameplayTagOffset)
		{
			builder.AddOffset(3, gameplayTagOffset.Value, 0);
		}

		// Token: 0x0601DBC1 RID: 121793 RVA: 0x0042E883 File Offset: 0x0042CA83
		public static void AddCompare(FlatBufferBuilder builder, ECompare compare)
		{
			builder.AddByte(4, (byte)compare, 0);
		}

		// Token: 0x0601DBC2 RID: 121794 RVA: 0x0042E88E File Offset: 0x0042CA8E
		public static Offset<ICheckGameplayTagCondition> EndICheckGameplayTagCondition(FlatBufferBuilder builder)
		{
			return new Offset<ICheckGameplayTagCondition>(builder.EndTable());
		}

		// Token: 0x0601DBC3 RID: 121795 RVA: 0x0042E89C File Offset: 0x0042CA9C
		public ICheckGameplayTagConditionT UnPack()
		{
			ICheckGameplayTagConditionT checkGameplayTagConditionT = new ICheckGameplayTagConditionT();
			this.UnPackTo(checkGameplayTagConditionT);
			return checkGameplayTagConditionT;
		}

		// Token: 0x0601DBC4 RID: 121796 RVA: 0x0042E8B8 File Offset: 0x0042CAB8
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

		// Token: 0x0601DBC5 RID: 121797 RVA: 0x0042EA0C File Offset: 0x0042CC0C
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

		// Token: 0x0400D286 RID: 53894
		private Table __p;
	}
}
