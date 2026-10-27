using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004A7E RID: 19070
	public struct ICheckInRangeProperlyCondition : IFlatbufferObject
	{
		// Token: 0x17008A22 RID: 35362
		// (get) Token: 0x0601DE4E RID: 122446 RVA: 0x00432E1B File Offset: 0x0043101B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601DE4F RID: 122447 RVA: 0x00432E28 File Offset: 0x00431028
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601DE50 RID: 122448 RVA: 0x00432E30 File Offset: 0x00431030
		public static ICheckInRangeProperlyCondition GetRootAsICheckInRangeProperlyCondition(ByteBuffer _bb)
		{
			return ICheckInRangeProperlyCondition.GetRootAsICheckInRangeProperlyCondition(_bb, default(ICheckInRangeProperlyCondition));
		}

		// Token: 0x0601DE51 RID: 122449 RVA: 0x00432E4C File Offset: 0x0043104C
		public static ICheckInRangeProperlyCondition GetRootAsICheckInRangeProperlyCondition(ByteBuffer _bb, ICheckInRangeProperlyCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601DE52 RID: 122450 RVA: 0x00432E69 File Offset: 0x00431069
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601DE53 RID: 122451 RVA: 0x00432E78 File Offset: 0x00431078
		public ICheckInRangeProperlyCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008A23 RID: 35363
		// (get) Token: 0x0601DE54 RID: 122452 RVA: 0x00432E88 File Offset: 0x00431088
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

		// Token: 0x0601DE55 RID: 122453 RVA: 0x00432EC4 File Offset: 0x004310C4
		public int RangeEntities(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17008A24 RID: 35364
		// (get) Token: 0x0601DE56 RID: 122454 RVA: 0x00432F04 File Offset: 0x00431104
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

		// Token: 0x0601DE57 RID: 122455 RVA: 0x00432F2F File Offset: 0x0043112F
		public Span<int> GetRangeEntitiesBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0601DE58 RID: 122456 RVA: 0x00432F3E File Offset: 0x0043113E
		public int[] GetRangeEntitiesArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x17008A25 RID: 35365
		// (get) Token: 0x0601DE59 RID: 122457 RVA: 0x00432F4C File Offset: 0x0043114C
		public bool InRange
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008A26 RID: 35366
		// (get) Token: 0x0601DE5A RID: 122458 RVA: 0x00432F8C File Offset: 0x0043118C
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

		// Token: 0x0601DE5B RID: 122459 RVA: 0x00432FCC File Offset: 0x004311CC
		public TTable? OnlinePlayerConditionTargetOption<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601DE5C RID: 122460 RVA: 0x00433014 File Offset: 0x00431214
		public IOnlinePlayerConditionTargetHost OnlinePlayerConditionTargetOptionAsIOnlinePlayerConditionTargetHost()
		{
			return this.OnlinePlayerConditionTargetOption<IOnlinePlayerConditionTargetHost>().Value;
		}

		// Token: 0x0601DE5D RID: 122461 RVA: 0x00433030 File Offset: 0x00431230
		public IOnlinePlayerConditionTargetParticipator OnlinePlayerConditionTargetOptionAsIOnlinePlayerConditionTargetParticipator()
		{
			return this.OnlinePlayerConditionTargetOption<IOnlinePlayerConditionTargetParticipator>().Value;
		}

		// Token: 0x0601DE5E RID: 122462 RVA: 0x0043304B File Offset: 0x0043124B
		public static Offset<ICheckInRangeProperlyCondition> CreateICheckInRangeProperlyCondition(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, VectorOffset RangeEntitiesOffset = default(VectorOffset), bool InRange = false, TOnlinePlayerConditionTarget OnlinePlayerConditionTargetOption_type = TOnlinePlayerConditionTarget.NONE, int OnlinePlayerConditionTargetOptionOffset = 0)
		{
			builder.StartTable(5);
			ICheckInRangeProperlyCondition.AddOnlinePlayerConditionTargetOption(builder, OnlinePlayerConditionTargetOptionOffset);
			ICheckInRangeProperlyCondition.AddRangeEntities(builder, RangeEntitiesOffset);
			ICheckInRangeProperlyCondition.AddOnlinePlayerConditionTargetOptionType(builder, OnlinePlayerConditionTargetOption_type);
			ICheckInRangeProperlyCondition.AddInRange(builder, InRange);
			ICheckInRangeProperlyCondition.AddType(builder, Type);
			return ICheckInRangeProperlyCondition.EndICheckInRangeProperlyCondition(builder);
		}

		// Token: 0x0601DE5F RID: 122463 RVA: 0x0043307F File Offset: 0x0043127F
		public static void StartICheckInRangeProperlyCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0601DE60 RID: 122464 RVA: 0x00433088 File Offset: 0x00431288
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601DE61 RID: 122465 RVA: 0x00433093 File Offset: 0x00431293
		public static void AddRangeEntities(FlatBufferBuilder builder, VectorOffset rangeEntitiesOffset)
		{
			builder.AddOffset(1, rangeEntitiesOffset.Value, 0);
		}

		// Token: 0x0601DE62 RID: 122466 RVA: 0x004330A4 File Offset: 0x004312A4
		public static VectorOffset CreateRangeEntitiesVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601DE63 RID: 122467 RVA: 0x004330DB File Offset: 0x004312DB
		public static VectorOffset CreateRangeEntitiesVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601DE64 RID: 122468 RVA: 0x004330F5 File Offset: 0x004312F5
		public static VectorOffset CreateRangeEntitiesVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601DE65 RID: 122469 RVA: 0x00433113 File Offset: 0x00431313
		public static VectorOffset CreateRangeEntitiesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601DE66 RID: 122470 RVA: 0x0043312C File Offset: 0x0043132C
		public static void StartRangeEntitiesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601DE67 RID: 122471 RVA: 0x00433137 File Offset: 0x00431337
		public static void AddInRange(FlatBufferBuilder builder, bool inRange)
		{
			builder.AddBool(2, inRange, false);
		}

		// Token: 0x0601DE68 RID: 122472 RVA: 0x00433142 File Offset: 0x00431342
		public static void AddOnlinePlayerConditionTargetOptionType(FlatBufferBuilder builder, TOnlinePlayerConditionTarget onlinePlayerConditionTargetOptionType)
		{
			builder.AddByte(3, (byte)onlinePlayerConditionTargetOptionType, 0);
		}

		// Token: 0x0601DE69 RID: 122473 RVA: 0x0043314D File Offset: 0x0043134D
		public static void AddOnlinePlayerConditionTargetOption(FlatBufferBuilder builder, int onlinePlayerConditionTargetOptionOffset)
		{
			builder.AddOffset(4, onlinePlayerConditionTargetOptionOffset, 0);
		}

		// Token: 0x0601DE6A RID: 122474 RVA: 0x00433158 File Offset: 0x00431358
		public static Offset<ICheckInRangeProperlyCondition> EndICheckInRangeProperlyCondition(FlatBufferBuilder builder)
		{
			return new Offset<ICheckInRangeProperlyCondition>(builder.EndTable());
		}

		// Token: 0x0601DE6B RID: 122475 RVA: 0x00433168 File Offset: 0x00431368
		public ICheckInRangeProperlyConditionT UnPack()
		{
			ICheckInRangeProperlyConditionT checkInRangeProperlyConditionT = new ICheckInRangeProperlyConditionT();
			this.UnPackTo(checkInRangeProperlyConditionT);
			return checkInRangeProperlyConditionT;
		}

		// Token: 0x0601DE6C RID: 122476 RVA: 0x00433184 File Offset: 0x00431384
		public void UnPackTo(ICheckInRangeProperlyConditionT _o)
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

		// Token: 0x0601DE6D RID: 122477 RVA: 0x00433270 File Offset: 0x00431470
		public static Offset<ICheckInRangeProperlyCondition> Pack(FlatBufferBuilder builder, ICheckInRangeProperlyConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckInRangeProperlyCondition>);
			}
			VectorOffset rangeEntitiesOffset = default(VectorOffset);
			if (_o.RangeEntities != null)
			{
				int[] data = _o.RangeEntities.ToArray();
				rangeEntitiesOffset = ICheckInRangeProperlyCondition.CreateRangeEntitiesVector(builder, data);
			}
			TOnlinePlayerConditionTarget onlinePlayerConditionTargetOption_type = (_o.OnlinePlayerConditionTargetOption == null) ? TOnlinePlayerConditionTarget.NONE : _o.OnlinePlayerConditionTargetOption.Type;
			int onlinePlayerConditionTargetOptionOffset = (_o.OnlinePlayerConditionTargetOption == null) ? 0 : TOnlinePlayerConditionTargetUnion.Pack(builder, _o.OnlinePlayerConditionTargetOption);
			return ICheckInRangeProperlyCondition.CreateICheckInRangeProperlyCondition(builder, _o.Type, rangeEntitiesOffset, _o.InRange, onlinePlayerConditionTargetOption_type, onlinePlayerConditionTargetOptionOffset);
		}

		// Token: 0x0400D2E9 RID: 53993
		private Table __p;
	}
}
