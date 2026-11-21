using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004F41 RID: 20289
	public struct ICheckInRangeCondition : IFlatbufferObject
	{
		// Token: 0x170090F5 RID: 37109
		// (get) Token: 0x0601F8C7 RID: 129223 RVA: 0x004639E2 File Offset: 0x00461BE2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601F8C8 RID: 129224 RVA: 0x004639EF File Offset: 0x00461BEF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601F8C9 RID: 129225 RVA: 0x004639F8 File Offset: 0x00461BF8
		public static ICheckInRangeCondition GetRootAsICheckInRangeCondition(ByteBuffer _bb)
		{
			return ICheckInRangeCondition.GetRootAsICheckInRangeCondition(_bb, default(ICheckInRangeCondition));
		}

		// Token: 0x0601F8CA RID: 129226 RVA: 0x00463A14 File Offset: 0x00461C14
		public static ICheckInRangeCondition GetRootAsICheckInRangeCondition(ByteBuffer _bb, ICheckInRangeCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601F8CB RID: 129227 RVA: 0x00463A31 File Offset: 0x00461C31
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601F8CC RID: 129228 RVA: 0x00463A40 File Offset: 0x00461C40
		public ICheckInRangeCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170090F6 RID: 37110
		// (get) Token: 0x0601F8CD RID: 129229 RVA: 0x00463A50 File Offset: 0x00461C50
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

		// Token: 0x0601F8CE RID: 129230 RVA: 0x00463A8C File Offset: 0x00461C8C
		public int RangeEntities(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170090F7 RID: 37111
		// (get) Token: 0x0601F8CF RID: 129231 RVA: 0x00463ACC File Offset: 0x00461CCC
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

		// Token: 0x0601F8D0 RID: 129232 RVA: 0x00463AF7 File Offset: 0x00461CF7
		public Span<int> GetRangeEntitiesBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0601F8D1 RID: 129233 RVA: 0x00463B06 File Offset: 0x00461D06
		public int[] GetRangeEntitiesArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x170090F8 RID: 37112
		// (get) Token: 0x0601F8D2 RID: 129234 RVA: 0x00463B14 File Offset: 0x00461D14
		public bool InRange
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170090F9 RID: 37113
		// (get) Token: 0x0601F8D3 RID: 129235 RVA: 0x00463B54 File Offset: 0x00461D54
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

		// Token: 0x0601F8D4 RID: 129236 RVA: 0x00463B94 File Offset: 0x00461D94
		public TTable? OnlinePlayerConditionTargetOption<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601F8D5 RID: 129237 RVA: 0x00463BDC File Offset: 0x00461DDC
		public IOnlinePlayerConditionTargetHost OnlinePlayerConditionTargetOptionAsIOnlinePlayerConditionTargetHost()
		{
			return this.OnlinePlayerConditionTargetOption<IOnlinePlayerConditionTargetHost>().Value;
		}

		// Token: 0x0601F8D6 RID: 129238 RVA: 0x00463BF8 File Offset: 0x00461DF8
		public IOnlinePlayerConditionTargetParticipator OnlinePlayerConditionTargetOptionAsIOnlinePlayerConditionTargetParticipator()
		{
			return this.OnlinePlayerConditionTargetOption<IOnlinePlayerConditionTargetParticipator>().Value;
		}

		// Token: 0x0601F8D7 RID: 129239 RVA: 0x00463C13 File Offset: 0x00461E13
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

		// Token: 0x0601F8D8 RID: 129240 RVA: 0x00463C47 File Offset: 0x00461E47
		public static void StartICheckInRangeCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0601F8D9 RID: 129241 RVA: 0x00463C50 File Offset: 0x00461E50
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601F8DA RID: 129242 RVA: 0x00463C5B File Offset: 0x00461E5B
		public static void AddRangeEntities(FlatBufferBuilder builder, VectorOffset rangeEntitiesOffset)
		{
			builder.AddOffset(1, rangeEntitiesOffset.Value, 0);
		}

		// Token: 0x0601F8DB RID: 129243 RVA: 0x00463C6C File Offset: 0x00461E6C
		public static VectorOffset CreateRangeEntitiesVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601F8DC RID: 129244 RVA: 0x00463CA3 File Offset: 0x00461EA3
		public static VectorOffset CreateRangeEntitiesVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601F8DD RID: 129245 RVA: 0x00463CBD File Offset: 0x00461EBD
		public static VectorOffset CreateRangeEntitiesVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601F8DE RID: 129246 RVA: 0x00463CDB File Offset: 0x00461EDB
		public static VectorOffset CreateRangeEntitiesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601F8DF RID: 129247 RVA: 0x00463CF4 File Offset: 0x00461EF4
		public static void StartRangeEntitiesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601F8E0 RID: 129248 RVA: 0x00463CFF File Offset: 0x00461EFF
		public static void AddInRange(FlatBufferBuilder builder, bool inRange)
		{
			builder.AddBool(2, inRange, false);
		}

		// Token: 0x0601F8E1 RID: 129249 RVA: 0x00463D0A File Offset: 0x00461F0A
		public static void AddOnlinePlayerConditionTargetOptionType(FlatBufferBuilder builder, TOnlinePlayerConditionTarget onlinePlayerConditionTargetOptionType)
		{
			builder.AddByte(3, (byte)onlinePlayerConditionTargetOptionType, 0);
		}

		// Token: 0x0601F8E2 RID: 129250 RVA: 0x00463D15 File Offset: 0x00461F15
		public static void AddOnlinePlayerConditionTargetOption(FlatBufferBuilder builder, int onlinePlayerConditionTargetOptionOffset)
		{
			builder.AddOffset(4, onlinePlayerConditionTargetOptionOffset, 0);
		}

		// Token: 0x0601F8E3 RID: 129251 RVA: 0x00463D20 File Offset: 0x00461F20
		public static Offset<ICheckInRangeCondition> EndICheckInRangeCondition(FlatBufferBuilder builder)
		{
			return new Offset<ICheckInRangeCondition>(builder.EndTable());
		}

		// Token: 0x0601F8E4 RID: 129252 RVA: 0x00463D30 File Offset: 0x00461F30
		public ICheckInRangeConditionT UnPack()
		{
			ICheckInRangeConditionT checkInRangeConditionT = new ICheckInRangeConditionT();
			this.UnPackTo(checkInRangeConditionT);
			return checkInRangeConditionT;
		}

		// Token: 0x0601F8E5 RID: 129253 RVA: 0x00463D4C File Offset: 0x00461F4C
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

		// Token: 0x0601F8E6 RID: 129254 RVA: 0x00463E38 File Offset: 0x00462038
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

		// Token: 0x0400DDBF RID: 56767
		private Table __p;
	}
}
