using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004A7B RID: 19067
	public struct ICheckInRangeCondition : IFlatbufferObject
	{
		// Token: 0x17008A19 RID: 35353
		// (get) Token: 0x0601DE24 RID: 122404 RVA: 0x00432856 File Offset: 0x00430A56
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601DE25 RID: 122405 RVA: 0x00432863 File Offset: 0x00430A63
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601DE26 RID: 122406 RVA: 0x0043286C File Offset: 0x00430A6C
		public static ICheckInRangeCondition GetRootAsICheckInRangeCondition(ByteBuffer _bb)
		{
			return ICheckInRangeCondition.GetRootAsICheckInRangeCondition(_bb, default(ICheckInRangeCondition));
		}

		// Token: 0x0601DE27 RID: 122407 RVA: 0x00432888 File Offset: 0x00430A88
		public static ICheckInRangeCondition GetRootAsICheckInRangeCondition(ByteBuffer _bb, ICheckInRangeCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601DE28 RID: 122408 RVA: 0x004328A5 File Offset: 0x00430AA5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601DE29 RID: 122409 RVA: 0x004328B4 File Offset: 0x00430AB4
		public ICheckInRangeCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008A1A RID: 35354
		// (get) Token: 0x0601DE2A RID: 122410 RVA: 0x004328C4 File Offset: 0x00430AC4
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

		// Token: 0x0601DE2B RID: 122411 RVA: 0x00432900 File Offset: 0x00430B00
		public int RangeEntities(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17008A1B RID: 35355
		// (get) Token: 0x0601DE2C RID: 122412 RVA: 0x00432940 File Offset: 0x00430B40
		public int RangeEntitiesLength
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

		// Token: 0x0601DE2D RID: 122413 RVA: 0x0043296B File Offset: 0x00430B6B
		public Span<int> GetRangeEntitiesBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0601DE2E RID: 122414 RVA: 0x0043297A File Offset: 0x00430B7A
		public int[] GetRangeEntitiesArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x17008A1C RID: 35356
		// (get) Token: 0x0601DE2F RID: 122415 RVA: 0x00432988 File Offset: 0x00430B88
		public bool InRange
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008A1D RID: 35357
		// (get) Token: 0x0601DE30 RID: 122416 RVA: 0x004329C8 File Offset: 0x00430BC8
		public TOnlinePlayerConditionTarget OnlinePlayerConditionTargetOptionType
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return TOnlinePlayerConditionTarget.NONE;
				}
				return (TOnlinePlayerConditionTarget)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601DE31 RID: 122417 RVA: 0x00432A08 File Offset: 0x00430C08
		public TTable? OnlinePlayerConditionTargetOption<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601DE32 RID: 122418 RVA: 0x00432A50 File Offset: 0x00430C50
		public IOnlinePlayerConditionTargetHost OnlinePlayerConditionTargetOptionAsIOnlinePlayerConditionTargetHost()
		{
			return this.OnlinePlayerConditionTargetOption<IOnlinePlayerConditionTargetHost>().Value;
		}

		// Token: 0x0601DE33 RID: 122419 RVA: 0x00432A6C File Offset: 0x00430C6C
		public IOnlinePlayerConditionTargetParticipator OnlinePlayerConditionTargetOptionAsIOnlinePlayerConditionTargetParticipator()
		{
			return this.OnlinePlayerConditionTargetOption<IOnlinePlayerConditionTargetParticipator>().Value;
		}

		// Token: 0x0601DE34 RID: 122420 RVA: 0x00432A87 File Offset: 0x00430C87
		public static Offset<ICheckInRangeCondition> CreateICheckInRangeCondition(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, VectorOffset RangeEntitiesOffset = default(VectorOffset), bool InRange = false, TOnlinePlayerConditionTarget OnlinePlayerConditionTargetOption_type = TOnlinePlayerConditionTarget.NONE, int OnlinePlayerConditionTargetOptionOffset = 0)
		{
			builder.StartTable(5);
			ICheckInRangeCondition.AddOnlinePlayerConditionTargetOption(builder, OnlinePlayerConditionTargetOptionOffset);
			ICheckInRangeCondition.AddRangeEntities(builder, RangeEntitiesOffset);
			ICheckInRangeCondition.AddOnlinePlayerConditionTargetOptionType(builder, OnlinePlayerConditionTargetOption_type);
			ICheckInRangeCondition.AddInRange(builder, InRange);
			ICheckInRangeCondition.AddType(builder, Type);
			return ICheckInRangeCondition.EndICheckInRangeCondition(builder);
		}

		// Token: 0x0601DE35 RID: 122421 RVA: 0x00432ABB File Offset: 0x00430CBB
		public static void StartICheckInRangeCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0601DE36 RID: 122422 RVA: 0x00432AC4 File Offset: 0x00430CC4
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601DE37 RID: 122423 RVA: 0x00432ACF File Offset: 0x00430CCF
		public static void AddRangeEntities(FlatBufferBuilder builder, VectorOffset rangeEntitiesOffset)
		{
			builder.AddOffset(1, rangeEntitiesOffset.Value, 0);
		}

		// Token: 0x0601DE38 RID: 122424 RVA: 0x00432AE0 File Offset: 0x00430CE0
		public static VectorOffset CreateRangeEntitiesVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601DE39 RID: 122425 RVA: 0x00432B17 File Offset: 0x00430D17
		public static VectorOffset CreateRangeEntitiesVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601DE3A RID: 122426 RVA: 0x00432B31 File Offset: 0x00430D31
		public static VectorOffset CreateRangeEntitiesVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601DE3B RID: 122427 RVA: 0x00432B4F File Offset: 0x00430D4F
		public static VectorOffset CreateRangeEntitiesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601DE3C RID: 122428 RVA: 0x00432B68 File Offset: 0x00430D68
		public static void StartRangeEntitiesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601DE3D RID: 122429 RVA: 0x00432B73 File Offset: 0x00430D73
		public static void AddInRange(FlatBufferBuilder builder, bool inRange)
		{
			builder.AddBool(2, inRange, false);
		}

		// Token: 0x0601DE3E RID: 122430 RVA: 0x00432B7E File Offset: 0x00430D7E
		public static void AddOnlinePlayerConditionTargetOptionType(FlatBufferBuilder builder, TOnlinePlayerConditionTarget onlinePlayerConditionTargetOptionType)
		{
			builder.AddByte(3, (byte)onlinePlayerConditionTargetOptionType, 0);
		}

		// Token: 0x0601DE3F RID: 122431 RVA: 0x00432B89 File Offset: 0x00430D89
		public static void AddOnlinePlayerConditionTargetOption(FlatBufferBuilder builder, int onlinePlayerConditionTargetOptionOffset)
		{
			builder.AddOffset(4, onlinePlayerConditionTargetOptionOffset, 0);
		}

		// Token: 0x0601DE40 RID: 122432 RVA: 0x00432B94 File Offset: 0x00430D94
		public static Offset<ICheckInRangeCondition> EndICheckInRangeCondition(FlatBufferBuilder builder)
		{
			return new Offset<ICheckInRangeCondition>(builder.EndTable());
		}

		// Token: 0x0601DE41 RID: 122433 RVA: 0x00432BA4 File Offset: 0x00430DA4
		public ICheckInRangeConditionT UnPack()
		{
			ICheckInRangeConditionT checkInRangeConditionT = new ICheckInRangeConditionT();
			this.UnPackTo(checkInRangeConditionT);
			return checkInRangeConditionT;
		}

		// Token: 0x0601DE42 RID: 122434 RVA: 0x00432BC0 File Offset: 0x00430DC0
		public void UnPackTo(ICheckInRangeConditionT _o)
		{
			_o.Type = this.Type;
			_o.RangeEntities = new List<int>();
			for (int i = 0; i < this.RangeEntitiesLength; i++)
			{
				_o.RangeEntities.Add(this.RangeEntities(i));
			}
			_o.InRange = this.InRange;
			_o.OnlinePlayerConditionTargetOption = new TOnlinePlayerConditionTargetUnion();
			_o.OnlinePlayerConditionTargetOption.Type = this.OnlinePlayerConditionTargetOptionType;
			TOnlinePlayerConditionTarget onlinePlayerConditionTargetOptionType = this.OnlinePlayerConditionTargetOptionType;
			if (onlinePlayerConditionTargetOptionType == TOnlinePlayerConditionTarget.IOnlinePlayerConditionTargetHost)
			{
				_o.OnlinePlayerConditionTargetOption.Value = ((this.OnlinePlayerConditionTargetOption<IOnlinePlayerConditionTargetHost>() != null) ? this.OnlinePlayerConditionTargetOption<IOnlinePlayerConditionTargetHost>().Value.UnPack() : null);
				return;
			}
			if (onlinePlayerConditionTargetOptionType != TOnlinePlayerConditionTarget.IOnlinePlayerConditionTargetParticipator)
			{
				return;
			}
			_o.OnlinePlayerConditionTargetOption.Value = ((this.OnlinePlayerConditionTargetOption<IOnlinePlayerConditionTargetParticipator>() != null) ? this.OnlinePlayerConditionTargetOption<IOnlinePlayerConditionTargetParticipator>().Value.UnPack() : null);
		}

		// Token: 0x0601DE43 RID: 122435 RVA: 0x00432CAC File Offset: 0x00430EAC
		public static Offset<ICheckInRangeCondition> Pack(FlatBufferBuilder builder, ICheckInRangeConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckInRangeCondition>);
			}
			VectorOffset rangeEntitiesOffset = default(VectorOffset);
			if (_o.RangeEntities != null)
			{
				int[] data = _o.RangeEntities.ToArray();
				rangeEntitiesOffset = ICheckInRangeCondition.CreateRangeEntitiesVector(builder, data);
			}
			TOnlinePlayerConditionTarget onlinePlayerConditionTargetOption_type = (_o.OnlinePlayerConditionTargetOption == null) ? TOnlinePlayerConditionTarget.NONE : _o.OnlinePlayerConditionTargetOption.Type;
			int onlinePlayerConditionTargetOptionOffset = (_o.OnlinePlayerConditionTargetOption == null) ? 0 : TOnlinePlayerConditionTargetUnion.Pack(builder, _o.OnlinePlayerConditionTargetOption);
			return ICheckInRangeCondition.CreateICheckInRangeCondition(builder, _o.Type, rangeEntitiesOffset, _o.InRange, onlinePlayerConditionTargetOption_type, onlinePlayerConditionTargetOptionOffset);
		}

		// Token: 0x0400D2E4 RID: 53988
		private Table __p;
	}
}
