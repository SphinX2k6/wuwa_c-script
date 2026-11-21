using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004EBD RID: 20157
	public struct ICheckEntityDistanceCondition : IFlatbufferObject
	{
		// Token: 0x17008FD3 RID: 36819
		// (get) Token: 0x0601F417 RID: 128023 RVA: 0x0045B337 File Offset: 0x00459537
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601F418 RID: 128024 RVA: 0x0045B344 File Offset: 0x00459544
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601F419 RID: 128025 RVA: 0x0045B34C File Offset: 0x0045954C
		public static ICheckEntityDistanceCondition GetRootAsICheckEntityDistanceCondition(ByteBuffer _bb)
		{
			return ICheckEntityDistanceCondition.GetRootAsICheckEntityDistanceCondition(_bb, default(ICheckEntityDistanceCondition));
		}

		// Token: 0x0601F41A RID: 128026 RVA: 0x0045B368 File Offset: 0x00459568
		public static ICheckEntityDistanceCondition GetRootAsICheckEntityDistanceCondition(ByteBuffer _bb, ICheckEntityDistanceCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601F41B RID: 128027 RVA: 0x0045B385 File Offset: 0x00459585
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601F41C RID: 128028 RVA: 0x0045B394 File Offset: 0x00459594
		public ICheckEntityDistanceCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008FD4 RID: 36820
		// (get) Token: 0x0601F41D RID: 128029 RVA: 0x0045B3A4 File Offset: 0x004595A4
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

		// Token: 0x17008FD5 RID: 36821
		// (get) Token: 0x0601F41E RID: 128030 RVA: 0x0045B3E0 File Offset: 0x004595E0
		public TTargetEntity TargetAType
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

		// Token: 0x0601F41F RID: 128031 RVA: 0x0045B41C File Offset: 0x0045961C
		public TTable? TargetA<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601F420 RID: 128032 RVA: 0x0045B460 File Offset: 0x00459660
		public IPlayerEntity TargetAAsIPlayerEntity()
		{
			return this.TargetA<IPlayerEntity>().Value;
		}

		// Token: 0x0601F421 RID: 128033 RVA: 0x0045B47C File Offset: 0x0045967C
		public ISelfEntity TargetAAsISelfEntity()
		{
			return this.TargetA<ISelfEntity>().Value;
		}

		// Token: 0x0601F422 RID: 128034 RVA: 0x0045B498 File Offset: 0x00459698
		public ITargetEntity TargetAAsITargetEntity()
		{
			return this.TargetA<ITargetEntity>().Value;
		}

		// Token: 0x0601F423 RID: 128035 RVA: 0x0045B4B4 File Offset: 0x004596B4
		public ITriggeredEntity TargetAAsITriggeredEntity()
		{
			return this.TargetA<ITriggeredEntity>().Value;
		}

		// Token: 0x17008FD6 RID: 36822
		// (get) Token: 0x0601F424 RID: 128036 RVA: 0x0045B4D0 File Offset: 0x004596D0
		public TTargetEntity TargetBType
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return TTargetEntity.NONE;
				}
				return (TTargetEntity)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601F425 RID: 128037 RVA: 0x0045B510 File Offset: 0x00459710
		public TTable? TargetB<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601F426 RID: 128038 RVA: 0x0045B558 File Offset: 0x00459758
		public IPlayerEntity TargetBAsIPlayerEntity()
		{
			return this.TargetB<IPlayerEntity>().Value;
		}

		// Token: 0x0601F427 RID: 128039 RVA: 0x0045B574 File Offset: 0x00459774
		public ISelfEntity TargetBAsISelfEntity()
		{
			return this.TargetB<ISelfEntity>().Value;
		}

		// Token: 0x0601F428 RID: 128040 RVA: 0x0045B590 File Offset: 0x00459790
		public ITargetEntity TargetBAsITargetEntity()
		{
			return this.TargetB<ITargetEntity>().Value;
		}

		// Token: 0x0601F429 RID: 128041 RVA: 0x0045B5AC File Offset: 0x004597AC
		public ITriggeredEntity TargetBAsITriggeredEntity()
		{
			return this.TargetB<ITriggeredEntity>().Value;
		}

		// Token: 0x17008FD7 RID: 36823
		// (get) Token: 0x0601F42A RID: 128042 RVA: 0x0045B5C8 File Offset: 0x004597C8
		public ECompare Compare
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return ECompare.Eq;
				}
				return (ECompare)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008FD8 RID: 36824
		// (get) Token: 0x0601F42B RID: 128043 RVA: 0x0045B608 File Offset: 0x00459808
		public int Distance
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601F42C RID: 128044 RVA: 0x0045B648 File Offset: 0x00459848
		public static Offset<ICheckEntityDistanceCondition> CreateICheckEntityDistanceCondition(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, TTargetEntity TargetA_type = TTargetEntity.NONE, int TargetAOffset = 0, TTargetEntity TargetB_type = TTargetEntity.NONE, int TargetBOffset = 0, ECompare Compare = ECompare.Eq, int Distance = 0)
		{
			builder.StartTable(7);
			ICheckEntityDistanceCondition.AddDistance(builder, Distance);
			ICheckEntityDistanceCondition.AddTargetB(builder, TargetBOffset);
			ICheckEntityDistanceCondition.AddTargetA(builder, TargetAOffset);
			ICheckEntityDistanceCondition.AddCompare(builder, Compare);
			ICheckEntityDistanceCondition.AddTargetBType(builder, TargetB_type);
			ICheckEntityDistanceCondition.AddTargetAType(builder, TargetA_type);
			ICheckEntityDistanceCondition.AddType(builder, Type);
			return ICheckEntityDistanceCondition.EndICheckEntityDistanceCondition(builder);
		}

		// Token: 0x0601F42D RID: 128045 RVA: 0x0045B697 File Offset: 0x00459897
		public static void StartICheckEntityDistanceCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x0601F42E RID: 128046 RVA: 0x0045B6A0 File Offset: 0x004598A0
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601F42F RID: 128047 RVA: 0x0045B6AB File Offset: 0x004598AB
		public static void AddTargetAType(FlatBufferBuilder builder, TTargetEntity targetAType)
		{
			builder.AddByte(1, (byte)targetAType, 0);
		}

		// Token: 0x0601F430 RID: 128048 RVA: 0x0045B6B6 File Offset: 0x004598B6
		public static void AddTargetA(FlatBufferBuilder builder, int targetAOffset)
		{
			builder.AddOffset(2, targetAOffset, 0);
		}

		// Token: 0x0601F431 RID: 128049 RVA: 0x0045B6C1 File Offset: 0x004598C1
		public static void AddTargetBType(FlatBufferBuilder builder, TTargetEntity targetBType)
		{
			builder.AddByte(3, (byte)targetBType, 0);
		}

		// Token: 0x0601F432 RID: 128050 RVA: 0x0045B6CC File Offset: 0x004598CC
		public static void AddTargetB(FlatBufferBuilder builder, int targetBOffset)
		{
			builder.AddOffset(4, targetBOffset, 0);
		}

		// Token: 0x0601F433 RID: 128051 RVA: 0x0045B6D7 File Offset: 0x004598D7
		public static void AddCompare(FlatBufferBuilder builder, ECompare compare)
		{
			builder.AddByte(5, (byte)compare, 0);
		}

		// Token: 0x0601F434 RID: 128052 RVA: 0x0045B6E2 File Offset: 0x004598E2
		public static void AddDistance(FlatBufferBuilder builder, int distance)
		{
			builder.AddInt(6, distance, 0);
		}

		// Token: 0x0601F435 RID: 128053 RVA: 0x0045B6ED File Offset: 0x004598ED
		public static Offset<ICheckEntityDistanceCondition> EndICheckEntityDistanceCondition(FlatBufferBuilder builder)
		{
			return new Offset<ICheckEntityDistanceCondition>(builder.EndTable());
		}

		// Token: 0x0601F436 RID: 128054 RVA: 0x0045B6FC File Offset: 0x004598FC
		public ICheckEntityDistanceConditionT UnPack()
		{
			ICheckEntityDistanceConditionT checkEntityDistanceConditionT = new ICheckEntityDistanceConditionT();
			this.UnPackTo(checkEntityDistanceConditionT);
			return checkEntityDistanceConditionT;
		}

		// Token: 0x0601F437 RID: 128055 RVA: 0x0045B718 File Offset: 0x00459918
		public void UnPackTo(ICheckEntityDistanceConditionT _o)
		{
			_o.Type = this.Type;
			_o.TargetA = new TTargetEntityUnion();
			_o.TargetA.Type = this.TargetAType;
			switch (this.TargetAType)
			{
			case TTargetEntity.IPlayerEntity:
				_o.TargetA.Value = ((this.TargetA<IPlayerEntity>() != null) ? this.TargetA<IPlayerEntity>().Value.UnPack() : null);
				break;
			case TTargetEntity.ISelfEntity:
				_o.TargetA.Value = ((this.TargetA<ISelfEntity>() != null) ? this.TargetA<ISelfEntity>().Value.UnPack() : null);
				break;
			case TTargetEntity.ITargetEntity:
				_o.TargetA.Value = ((this.TargetA<ITargetEntity>() != null) ? this.TargetA<ITargetEntity>().Value.UnPack() : null);
				break;
			case TTargetEntity.ITriggeredEntity:
				_o.TargetA.Value = ((this.TargetA<ITriggeredEntity>() != null) ? this.TargetA<ITriggeredEntity>().Value.UnPack() : null);
				break;
			}
			_o.TargetB = new TTargetEntityUnion();
			_o.TargetB.Type = this.TargetBType;
			switch (this.TargetBType)
			{
			case TTargetEntity.IPlayerEntity:
				_o.TargetB.Value = ((this.TargetB<IPlayerEntity>() != null) ? this.TargetB<IPlayerEntity>().Value.UnPack() : null);
				break;
			case TTargetEntity.ISelfEntity:
				_o.TargetB.Value = ((this.TargetB<ISelfEntity>() != null) ? this.TargetB<ISelfEntity>().Value.UnPack() : null);
				break;
			case TTargetEntity.ITargetEntity:
				_o.TargetB.Value = ((this.TargetB<ITargetEntity>() != null) ? this.TargetB<ITargetEntity>().Value.UnPack() : null);
				break;
			case TTargetEntity.ITriggeredEntity:
				_o.TargetB.Value = ((this.TargetB<ITriggeredEntity>() != null) ? this.TargetB<ITriggeredEntity>().Value.UnPack() : null);
				break;
			}
			_o.Compare = this.Compare;
			_o.Distance = this.Distance;
		}

		// Token: 0x0601F438 RID: 128056 RVA: 0x0045B98C File Offset: 0x00459B8C
		public static Offset<ICheckEntityDistanceCondition> Pack(FlatBufferBuilder builder, ICheckEntityDistanceConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckEntityDistanceCondition>);
			}
			TTargetEntity targetA_type = (_o.TargetA == null) ? TTargetEntity.NONE : _o.TargetA.Type;
			int targetAOffset = (_o.TargetA == null) ? 0 : TTargetEntityUnion.Pack(builder, _o.TargetA);
			TTargetEntity targetB_type = (_o.TargetB == null) ? TTargetEntity.NONE : _o.TargetB.Type;
			int targetBOffset = (_o.TargetB == null) ? 0 : TTargetEntityUnion.Pack(builder, _o.TargetB);
			return ICheckEntityDistanceCondition.CreateICheckEntityDistanceCondition(builder, _o.Type, targetA_type, targetAOffset, targetB_type, targetBOffset, _o.Compare, _o.Distance);
		}

		// Token: 0x0400DD0D RID: 56589
		private Table __p;
	}
}
