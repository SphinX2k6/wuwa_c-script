using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006BAC RID: 27564
	public struct INotifyMonsterPerception : IFlatbufferObject
	{
		// Token: 0x1700CCDD RID: 52445
		// (get) Token: 0x060306A3 RID: 198307 RVA: 0x00693421 File Offset: 0x00691621
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060306A4 RID: 198308 RVA: 0x0069342E File Offset: 0x0069162E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060306A5 RID: 198309 RVA: 0x00693438 File Offset: 0x00691638
		public static INotifyMonsterPerception GetRootAsINotifyMonsterPerception(ByteBuffer _bb)
		{
			return INotifyMonsterPerception.GetRootAsINotifyMonsterPerception(_bb, default(INotifyMonsterPerception));
		}

		// Token: 0x060306A6 RID: 198310 RVA: 0x00693454 File Offset: 0x00691654
		public static INotifyMonsterPerception GetRootAsINotifyMonsterPerception(ByteBuffer _bb, INotifyMonsterPerception obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060306A7 RID: 198311 RVA: 0x00693471 File Offset: 0x00691671
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060306A8 RID: 198312 RVA: 0x00693480 File Offset: 0x00691680
		public INotifyMonsterPerception __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CCDE RID: 52446
		// (get) Token: 0x060306A9 RID: 198313 RVA: 0x00693490 File Offset: 0x00691690
		public ESetBattleStateType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESetBattleStateType.SetBattleTag;
				}
				return (ESetBattleStateType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060306AA RID: 198314 RVA: 0x006934CC File Offset: 0x006916CC
		public int EntityIds(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700CCDF RID: 52447
		// (get) Token: 0x060306AB RID: 198315 RVA: 0x0069350C File Offset: 0x0069170C
		public int EntityIdsLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060306AC RID: 198316 RVA: 0x00693537 File Offset: 0x00691737
		public Span<int> GetEntityIdsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x060306AD RID: 198317 RVA: 0x00693546 File Offset: 0x00691746
		public int[] GetEntityIdsArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x1700CCE0 RID: 52448
		// (get) Token: 0x060306AE RID: 198318 RVA: 0x00693554 File Offset: 0x00691754
		public TBattleStatePerceptionBehavior PerceptionBehaviorOptionType
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return TBattleStatePerceptionBehavior.NONE;
				}
				return (TBattleStatePerceptionBehavior)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060306AF RID: 198319 RVA: 0x00693590 File Offset: 0x00691790
		public TTable? PerceptionBehaviorOption<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060306B0 RID: 198320 RVA: 0x006935D8 File Offset: 0x006917D8
		public IPerceptionNotifyGatherToEntity PerceptionBehaviorOptionAsIPerceptionNotifyGatherToEntity()
		{
			return this.PerceptionBehaviorOption<IPerceptionNotifyGatherToEntity>().Value;
		}

		// Token: 0x060306B1 RID: 198321 RVA: 0x006935F4 File Offset: 0x006917F4
		public IPerceptionNotifyGatherToPlayer PerceptionBehaviorOptionAsIPerceptionNotifyGatherToPlayer()
		{
			return this.PerceptionBehaviorOption<IPerceptionNotifyGatherToPlayer>().Value;
		}

		// Token: 0x060306B2 RID: 198322 RVA: 0x0069360F File Offset: 0x0069180F
		public static Offset<INotifyMonsterPerception> CreateINotifyMonsterPerception(FlatBufferBuilder builder, ESetBattleStateType Type = ESetBattleStateType.SetBattleTag, VectorOffset EntityIdsOffset = default(VectorOffset), TBattleStatePerceptionBehavior PerceptionBehaviorOption_type = TBattleStatePerceptionBehavior.NONE, int PerceptionBehaviorOptionOffset = 0)
		{
			builder.StartTable(4);
			INotifyMonsterPerception.AddPerceptionBehaviorOption(builder, PerceptionBehaviorOptionOffset);
			INotifyMonsterPerception.AddEntityIds(builder, EntityIdsOffset);
			INotifyMonsterPerception.AddPerceptionBehaviorOptionType(builder, PerceptionBehaviorOption_type);
			INotifyMonsterPerception.AddType(builder, Type);
			return INotifyMonsterPerception.EndINotifyMonsterPerception(builder);
		}

		// Token: 0x060306B3 RID: 198323 RVA: 0x0069363B File Offset: 0x0069183B
		public static void StartINotifyMonsterPerception(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x060306B4 RID: 198324 RVA: 0x00693644 File Offset: 0x00691844
		public static void AddType(FlatBufferBuilder builder, ESetBattleStateType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060306B5 RID: 198325 RVA: 0x0069364F File Offset: 0x0069184F
		public static void AddEntityIds(FlatBufferBuilder builder, VectorOffset entityIdsOffset)
		{
			builder.AddOffset(1, entityIdsOffset.Value, 0);
		}

		// Token: 0x060306B6 RID: 198326 RVA: 0x00693660 File Offset: 0x00691860
		public static VectorOffset CreateEntityIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x060306B7 RID: 198327 RVA: 0x00693697 File Offset: 0x00691897
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060306B8 RID: 198328 RVA: 0x006936B1 File Offset: 0x006918B1
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060306B9 RID: 198329 RVA: 0x006936CF File Offset: 0x006918CF
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060306BA RID: 198330 RVA: 0x006936E8 File Offset: 0x006918E8
		public static void StartEntityIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060306BB RID: 198331 RVA: 0x006936F3 File Offset: 0x006918F3
		public static void AddPerceptionBehaviorOptionType(FlatBufferBuilder builder, TBattleStatePerceptionBehavior perceptionBehaviorOptionType)
		{
			builder.AddByte(2, (byte)perceptionBehaviorOptionType, 0);
		}

		// Token: 0x060306BC RID: 198332 RVA: 0x006936FE File Offset: 0x006918FE
		public static void AddPerceptionBehaviorOption(FlatBufferBuilder builder, int perceptionBehaviorOptionOffset)
		{
			builder.AddOffset(3, perceptionBehaviorOptionOffset, 0);
		}

		// Token: 0x060306BD RID: 198333 RVA: 0x00693709 File Offset: 0x00691909
		public static Offset<INotifyMonsterPerception> EndINotifyMonsterPerception(FlatBufferBuilder builder)
		{
			return new Offset<INotifyMonsterPerception>(builder.EndTable());
		}

		// Token: 0x060306BE RID: 198334 RVA: 0x00693718 File Offset: 0x00691918
		public INotifyMonsterPerceptionT UnPack()
		{
			INotifyMonsterPerceptionT notifyMonsterPerceptionT = new INotifyMonsterPerceptionT();
			this.UnPackTo(notifyMonsterPerceptionT);
			return notifyMonsterPerceptionT;
		}

		// Token: 0x060306BF RID: 198335 RVA: 0x00693734 File Offset: 0x00691934
		public void UnPackTo(INotifyMonsterPerceptionT _o)
		{
			_o.Type = this.Type;
			_o.EntityIds = new List<int>();
			for (int i = 0; i < this.EntityIdsLength; i++)
			{
				_o.EntityIds.Add(this.EntityIds(i));
			}
			_o.PerceptionBehaviorOption = new TBattleStatePerceptionBehaviorUnion();
			_o.PerceptionBehaviorOption.Type = this.PerceptionBehaviorOptionType;
			TBattleStatePerceptionBehavior perceptionBehaviorOptionType = this.PerceptionBehaviorOptionType;
			if (perceptionBehaviorOptionType == TBattleStatePerceptionBehavior.IPerceptionNotifyGatherToEntity)
			{
				_o.PerceptionBehaviorOption.Value = ((this.PerceptionBehaviorOption<IPerceptionNotifyGatherToEntity>() != null) ? this.PerceptionBehaviorOption<IPerceptionNotifyGatherToEntity>().Value.UnPack() : null);
				return;
			}
			if (perceptionBehaviorOptionType != TBattleStatePerceptionBehavior.IPerceptionNotifyGatherToPlayer)
			{
				return;
			}
			_o.PerceptionBehaviorOption.Value = ((this.PerceptionBehaviorOption<IPerceptionNotifyGatherToPlayer>() != null) ? this.PerceptionBehaviorOption<IPerceptionNotifyGatherToPlayer>().Value.UnPack() : null);
		}

		// Token: 0x060306C0 RID: 198336 RVA: 0x00693814 File Offset: 0x00691A14
		public static Offset<INotifyMonsterPerception> Pack(FlatBufferBuilder builder, INotifyMonsterPerceptionT _o)
		{
			if (_o == null)
			{
				return default(Offset<INotifyMonsterPerception>);
			}
			VectorOffset entityIdsOffset = default(VectorOffset);
			if (_o.EntityIds != null)
			{
				int[] data = _o.EntityIds.ToArray();
				entityIdsOffset = INotifyMonsterPerception.CreateEntityIdsVector(builder, data);
			}
			TBattleStatePerceptionBehavior perceptionBehaviorOption_type = (_o.PerceptionBehaviorOption == null) ? TBattleStatePerceptionBehavior.NONE : _o.PerceptionBehaviorOption.Type;
			int perceptionBehaviorOptionOffset = (_o.PerceptionBehaviorOption == null) ? 0 : TBattleStatePerceptionBehaviorUnion.Pack(builder, _o.PerceptionBehaviorOption);
			return INotifyMonsterPerception.CreateINotifyMonsterPerception(builder, _o.Type, entityIdsOffset, perceptionBehaviorOption_type, perceptionBehaviorOptionOffset);
		}

		// Token: 0x0401147E RID: 70782
		private Table __p;
	}
}
