using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004F44 RID: 20292
	public struct ICheckInRangeProperlyCondition : IFlatbufferObject
	{
		// Token: 0x170090FE RID: 37118
		// (get) Token: 0x0601F8F1 RID: 129265 RVA: 0x00463FA7 File Offset: 0x004621A7
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601F8F2 RID: 129266 RVA: 0x00463FB4 File Offset: 0x004621B4
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601F8F3 RID: 129267 RVA: 0x00463FBC File Offset: 0x004621BC
		public static ICheckInRangeProperlyCondition GetRootAsICheckInRangeProperlyCondition(ByteBuffer _bb)
		{
			return ICheckInRangeProperlyCondition.GetRootAsICheckInRangeProperlyCondition(_bb, default(ICheckInRangeProperlyCondition));
		}

		// Token: 0x0601F8F4 RID: 129268 RVA: 0x00463FD8 File Offset: 0x004621D8
		public static ICheckInRangeProperlyCondition GetRootAsICheckInRangeProperlyCondition(ByteBuffer _bb, ICheckInRangeProperlyCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601F8F5 RID: 129269 RVA: 0x00463FF5 File Offset: 0x004621F5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601F8F6 RID: 129270 RVA: 0x00464004 File Offset: 0x00462204
		public ICheckInRangeProperlyCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170090FF RID: 37119
		// (get) Token: 0x0601F8F7 RID: 129271 RVA: 0x00464014 File Offset: 0x00462214
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

		// Token: 0x0601F8F8 RID: 129272 RVA: 0x00464050 File Offset: 0x00462250
		public int RangeEntities(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17009100 RID: 37120
		// (get) Token: 0x0601F8F9 RID: 129273 RVA: 0x00464090 File Offset: 0x00462290
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

		// Token: 0x0601F8FA RID: 129274 RVA: 0x004640BB File Offset: 0x004622BB
		public Span<int> GetRangeEntitiesBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0601F8FB RID: 129275 RVA: 0x004640CA File Offset: 0x004622CA
		public int[] GetRangeEntitiesArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x17009101 RID: 37121
		// (get) Token: 0x0601F8FC RID: 129276 RVA: 0x004640D8 File Offset: 0x004622D8
		public bool InRange
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17009102 RID: 37122
		// (get) Token: 0x0601F8FD RID: 129277 RVA: 0x00464118 File Offset: 0x00462318
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

		// Token: 0x0601F8FE RID: 129278 RVA: 0x00464158 File Offset: 0x00462358
		public TTable? OnlinePlayerConditionTargetOption<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601F8FF RID: 129279 RVA: 0x004641A0 File Offset: 0x004623A0
		public IOnlinePlayerConditionTargetHost OnlinePlayerConditionTargetOptionAsIOnlinePlayerConditionTargetHost()
		{
			return this.OnlinePlayerConditionTargetOption<IOnlinePlayerConditionTargetHost>().Value;
		}

		// Token: 0x0601F900 RID: 129280 RVA: 0x004641BC File Offset: 0x004623BC
		public IOnlinePlayerConditionTargetParticipator OnlinePlayerConditionTargetOptionAsIOnlinePlayerConditionTargetParticipator()
		{
			return this.OnlinePlayerConditionTargetOption<IOnlinePlayerConditionTargetParticipator>().Value;
		}

		// Token: 0x0601F901 RID: 129281 RVA: 0x004641D7 File Offset: 0x004623D7
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

		// Token: 0x0601F902 RID: 129282 RVA: 0x0046420B File Offset: 0x0046240B
		public static void StartICheckInRangeProperlyCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0601F903 RID: 129283 RVA: 0x00464214 File Offset: 0x00462414
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601F904 RID: 129284 RVA: 0x0046421F File Offset: 0x0046241F
		public static void AddRangeEntities(FlatBufferBuilder builder, VectorOffset rangeEntitiesOffset)
		{
			builder.AddOffset(1, rangeEntitiesOffset.Value, 0);
		}

		// Token: 0x0601F905 RID: 129285 RVA: 0x00464230 File Offset: 0x00462430
		public static VectorOffset CreateRangeEntitiesVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601F906 RID: 129286 RVA: 0x00464267 File Offset: 0x00462467
		public static VectorOffset CreateRangeEntitiesVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601F907 RID: 129287 RVA: 0x00464281 File Offset: 0x00462481
		public static VectorOffset CreateRangeEntitiesVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601F908 RID: 129288 RVA: 0x0046429F File Offset: 0x0046249F
		public static VectorOffset CreateRangeEntitiesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601F909 RID: 129289 RVA: 0x004642B8 File Offset: 0x004624B8
		public static void StartRangeEntitiesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601F90A RID: 129290 RVA: 0x004642C3 File Offset: 0x004624C3
		public static void AddInRange(FlatBufferBuilder builder, bool inRange)
		{
			builder.AddBool(2, inRange, false);
		}

		// Token: 0x0601F90B RID: 129291 RVA: 0x004642CE File Offset: 0x004624CE
		public static void AddOnlinePlayerConditionTargetOptionType(FlatBufferBuilder builder, TOnlinePlayerConditionTarget onlinePlayerConditionTargetOptionType)
		{
			builder.AddByte(3, (byte)onlinePlayerConditionTargetOptionType, 0);
		}

		// Token: 0x0601F90C RID: 129292 RVA: 0x004642D9 File Offset: 0x004624D9
		public static void AddOnlinePlayerConditionTargetOption(FlatBufferBuilder builder, int onlinePlayerConditionTargetOptionOffset)
		{
			builder.AddOffset(4, onlinePlayerConditionTargetOptionOffset, 0);
		}

		// Token: 0x0601F90D RID: 129293 RVA: 0x004642E4 File Offset: 0x004624E4
		public static Offset<ICheckInRangeProperlyCondition> EndICheckInRangeProperlyCondition(FlatBufferBuilder builder)
		{
			return new Offset<ICheckInRangeProperlyCondition>(builder.EndTable());
		}

		// Token: 0x0601F90E RID: 129294 RVA: 0x004642F4 File Offset: 0x004624F4
		public ICheckInRangeProperlyConditionT UnPack()
		{
			ICheckInRangeProperlyConditionT checkInRangeProperlyConditionT = new ICheckInRangeProperlyConditionT();
			this.UnPackTo(checkInRangeProperlyConditionT);
			return checkInRangeProperlyConditionT;
		}

		// Token: 0x0601F90F RID: 129295 RVA: 0x00464310 File Offset: 0x00462510
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

		// Token: 0x0601F910 RID: 129296 RVA: 0x004643FC File Offset: 0x004625FC
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

		// Token: 0x0400DDC4 RID: 56772
		private Table __p;
	}
}
