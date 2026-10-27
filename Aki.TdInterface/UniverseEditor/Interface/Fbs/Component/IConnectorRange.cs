using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200501E RID: 20510
	public struct IConnectorRange : IFlatbufferObject
	{
		// Token: 0x170094B2 RID: 38066
		// (get) Token: 0x06020D23 RID: 134435 RVA: 0x00490178 File Offset: 0x0048E378
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06020D24 RID: 134436 RVA: 0x00490185 File Offset: 0x0048E385
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06020D25 RID: 134437 RVA: 0x0049018C File Offset: 0x0048E38C
		public static IConnectorRange GetRootAsIConnectorRange(ByteBuffer _bb)
		{
			return IConnectorRange.GetRootAsIConnectorRange(_bb, default(IConnectorRange));
		}

		// Token: 0x06020D26 RID: 134438 RVA: 0x004901A8 File Offset: 0x0048E3A8
		public static IConnectorRange GetRootAsIConnectorRange(ByteBuffer _bb, IConnectorRange obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06020D27 RID: 134439 RVA: 0x004901C5 File Offset: 0x0048E3C5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06020D28 RID: 134440 RVA: 0x004901D4 File Offset: 0x0048E3D4
		public IConnectorRange __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170094B3 RID: 38067
		// (get) Token: 0x06020D29 RID: 134441 RVA: 0x004901E4 File Offset: 0x0048E3E4
		public EConnectorLogicType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EConnectorLogicType.Range;
				}
				return (EConnectorLogicType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170094B4 RID: 38068
		// (get) Token: 0x06020D2A RID: 134442 RVA: 0x00490220 File Offset: 0x0048E420
		public IConnectorEffectConfig? EffectConfig
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IConnectorEffectConfig?(default(IConnectorEffectConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x170094B5 RID: 38069
		// (get) Token: 0x06020D2B RID: 134443 RVA: 0x00490280 File Offset: 0x0048E480
		public string ActiveState
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06020D2C RID: 134444 RVA: 0x004902B7 File Offset: 0x0048E4B7
		public Span<byte> GetActiveStateBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06020D2D RID: 134445 RVA: 0x004902C6 File Offset: 0x0048E4C6
		public byte[] GetActiveStateArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x170094B6 RID: 38070
		// (get) Token: 0x06020D2E RID: 134446 RVA: 0x004902D4 File Offset: 0x0048E4D4
		public int EnterRange
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170094B7 RID: 38071
		// (get) Token: 0x06020D2F RID: 134447 RVA: 0x00490314 File Offset: 0x0048E514
		public int LeaveRange
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06020D30 RID: 134448 RVA: 0x00490354 File Offset: 0x0048E554
		public IDynamicEntityMatch? MatchConditions(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new IDynamicEntityMatch?(default(IDynamicEntityMatch).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170094B8 RID: 38072
		// (get) Token: 0x06020D31 RID: 134449 RVA: 0x004903B8 File Offset: 0x0048E5B8
		public int MatchConditionsLength
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06020D32 RID: 134450 RVA: 0x004903E4 File Offset: 0x0048E5E4
		public IDynamicEntityMatch? KeepConditions(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return new IDynamicEntityMatch?(default(IDynamicEntityMatch).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170094B9 RID: 38073
		// (get) Token: 0x06020D33 RID: 134451 RVA: 0x00490448 File Offset: 0x0048E648
		public int KeepConditionsLength
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x170094BA RID: 38074
		// (get) Token: 0x06020D34 RID: 134452 RVA: 0x00490474 File Offset: 0x0048E674
		public string ConnectedState
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06020D35 RID: 134453 RVA: 0x004904AC File Offset: 0x0048E6AC
		public Span<byte> GetConnectedStateBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06020D36 RID: 134454 RVA: 0x004904BC File Offset: 0x0048E6BC
		public byte[] GetConnectedStateArray()
		{
			return this.__p.__vector_as_array<byte>(18);
		}

		// Token: 0x170094BB RID: 38075
		// (get) Token: 0x06020D37 RID: 134455 RVA: 0x004904CC File Offset: 0x0048E6CC
		public string DisconnectedState
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06020D38 RID: 134456 RVA: 0x00490504 File Offset: 0x0048E704
		public Span<byte> GetDisconnectedStateBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x06020D39 RID: 134457 RVA: 0x00490514 File Offset: 0x0048E714
		public byte[] GetDisconnectedStateArray()
		{
			return this.__p.__vector_as_array<byte>(20);
		}

		// Token: 0x170094BC RID: 38076
		// (get) Token: 0x06020D3A RID: 134458 RVA: 0x00490524 File Offset: 0x0048E724
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06020D3B RID: 134459 RVA: 0x00490564 File Offset: 0x0048E764
		public static Offset<IConnectorRange> CreateIConnectorRange(FlatBufferBuilder builder, EConnectorLogicType Type = EConnectorLogicType.Range, Offset<IConnectorEffectConfig> EffectConfigOffset = default(Offset<IConnectorEffectConfig>), StringOffset ActiveStateOffset = default(StringOffset), int EnterRange = 0, int LeaveRange = 0, VectorOffset MatchConditionsOffset = default(VectorOffset), VectorOffset KeepConditionsOffset = default(VectorOffset), StringOffset ConnectedStateOffset = default(StringOffset), StringOffset DisconnectedStateOffset = default(StringOffset), byte NullMask = 0)
		{
			builder.StartTable(10);
			IConnectorRange.AddDisconnectedState(builder, DisconnectedStateOffset);
			IConnectorRange.AddConnectedState(builder, ConnectedStateOffset);
			IConnectorRange.AddKeepConditions(builder, KeepConditionsOffset);
			IConnectorRange.AddMatchConditions(builder, MatchConditionsOffset);
			IConnectorRange.AddLeaveRange(builder, LeaveRange);
			IConnectorRange.AddEnterRange(builder, EnterRange);
			IConnectorRange.AddActiveState(builder, ActiveStateOffset);
			IConnectorRange.AddEffectConfig(builder, EffectConfigOffset);
			IConnectorRange.AddNullMask(builder, NullMask);
			IConnectorRange.AddType(builder, Type);
			return IConnectorRange.EndIConnectorRange(builder);
		}

		// Token: 0x06020D3C RID: 134460 RVA: 0x004905CC File Offset: 0x0048E7CC
		public static void StartIConnectorRange(FlatBufferBuilder builder)
		{
			builder.StartTable(10);
		}

		// Token: 0x06020D3D RID: 134461 RVA: 0x004905D6 File Offset: 0x0048E7D6
		public static void AddType(FlatBufferBuilder builder, EConnectorLogicType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06020D3E RID: 134462 RVA: 0x004905E1 File Offset: 0x0048E7E1
		public static void AddEffectConfig(FlatBufferBuilder builder, Offset<IConnectorEffectConfig> effectConfigOffset)
		{
			builder.AddOffset(1, effectConfigOffset.Value, 0);
		}

		// Token: 0x06020D3F RID: 134463 RVA: 0x004905F1 File Offset: 0x0048E7F1
		public static void AddActiveState(FlatBufferBuilder builder, StringOffset activeStateOffset)
		{
			builder.AddOffset(2, activeStateOffset.Value, 0);
		}

		// Token: 0x06020D40 RID: 134464 RVA: 0x00490601 File Offset: 0x0048E801
		public static void AddEnterRange(FlatBufferBuilder builder, int enterRange)
		{
			builder.AddInt(3, enterRange, 0);
		}

		// Token: 0x06020D41 RID: 134465 RVA: 0x0049060C File Offset: 0x0048E80C
		public static void AddLeaveRange(FlatBufferBuilder builder, int leaveRange)
		{
			builder.AddInt(4, leaveRange, 0);
		}

		// Token: 0x06020D42 RID: 134466 RVA: 0x00490617 File Offset: 0x0048E817
		public static void AddMatchConditions(FlatBufferBuilder builder, VectorOffset matchConditionsOffset)
		{
			builder.AddOffset(5, matchConditionsOffset.Value, 0);
		}

		// Token: 0x06020D43 RID: 134467 RVA: 0x00490628 File Offset: 0x0048E828
		public static VectorOffset CreateMatchConditionsVector(FlatBufferBuilder builder, Offset<IDynamicEntityMatch>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06020D44 RID: 134468 RVA: 0x00490668 File Offset: 0x0048E868
		public static VectorOffset CreateMatchConditionsVectorBlock(FlatBufferBuilder builder, Offset<IDynamicEntityMatch>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IDynamicEntityMatch>>(data);
			return builder.EndVector();
		}

		// Token: 0x06020D45 RID: 134469 RVA: 0x00490682 File Offset: 0x0048E882
		public static VectorOffset CreateMatchConditionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IDynamicEntityMatch>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IDynamicEntityMatch>>(data);
			return builder.EndVector();
		}

		// Token: 0x06020D46 RID: 134470 RVA: 0x004906A0 File Offset: 0x0048E8A0
		public static VectorOffset CreateMatchConditionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IDynamicEntityMatch>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06020D47 RID: 134471 RVA: 0x004906B9 File Offset: 0x0048E8B9
		public static void StartMatchConditionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06020D48 RID: 134472 RVA: 0x004906C4 File Offset: 0x0048E8C4
		public static void AddKeepConditions(FlatBufferBuilder builder, VectorOffset keepConditionsOffset)
		{
			builder.AddOffset(6, keepConditionsOffset.Value, 0);
		}

		// Token: 0x06020D49 RID: 134473 RVA: 0x004906D4 File Offset: 0x0048E8D4
		public static VectorOffset CreateKeepConditionsVector(FlatBufferBuilder builder, Offset<IDynamicEntityMatch>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06020D4A RID: 134474 RVA: 0x00490714 File Offset: 0x0048E914
		public static VectorOffset CreateKeepConditionsVectorBlock(FlatBufferBuilder builder, Offset<IDynamicEntityMatch>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IDynamicEntityMatch>>(data);
			return builder.EndVector();
		}

		// Token: 0x06020D4B RID: 134475 RVA: 0x0049072E File Offset: 0x0048E92E
		public static VectorOffset CreateKeepConditionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IDynamicEntityMatch>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IDynamicEntityMatch>>(data);
			return builder.EndVector();
		}

		// Token: 0x06020D4C RID: 134476 RVA: 0x0049074C File Offset: 0x0048E94C
		public static VectorOffset CreateKeepConditionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IDynamicEntityMatch>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06020D4D RID: 134477 RVA: 0x00490765 File Offset: 0x0048E965
		public static void StartKeepConditionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06020D4E RID: 134478 RVA: 0x00490770 File Offset: 0x0048E970
		public static void AddConnectedState(FlatBufferBuilder builder, StringOffset connectedStateOffset)
		{
			builder.AddOffset(7, connectedStateOffset.Value, 0);
		}

		// Token: 0x06020D4F RID: 134479 RVA: 0x00490780 File Offset: 0x0048E980
		public static void AddDisconnectedState(FlatBufferBuilder builder, StringOffset disconnectedStateOffset)
		{
			builder.AddOffset(8, disconnectedStateOffset.Value, 0);
		}

		// Token: 0x06020D50 RID: 134480 RVA: 0x00490790 File Offset: 0x0048E990
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(9, nullMask, 0);
		}

		// Token: 0x06020D51 RID: 134481 RVA: 0x0049079C File Offset: 0x0048E99C
		public static Offset<IConnectorRange> EndIConnectorRange(FlatBufferBuilder builder)
		{
			return new Offset<IConnectorRange>(builder.EndTable());
		}

		// Token: 0x06020D52 RID: 134482 RVA: 0x004907AC File Offset: 0x0048E9AC
		public IConnectorRangeT UnPack()
		{
			IConnectorRangeT connectorRangeT = new IConnectorRangeT();
			this.UnPackTo(connectorRangeT);
			return connectorRangeT;
		}

		// Token: 0x06020D53 RID: 134483 RVA: 0x004907C8 File Offset: 0x0048E9C8
		public void UnPackTo(IConnectorRangeT _o)
		{
			_o.Type = this.Type;
			_o.EffectConfig = ((this.EffectConfig != null) ? this.EffectConfig.Value.UnPack() : null);
			_o.ActiveState = this.ActiveState;
			_o.EnterRange = this.EnterRange;
			_o.LeaveRange = this.LeaveRange;
			_o.MatchConditions = new List<IDynamicEntityMatchT>();
			for (int i = 0; i < this.MatchConditionsLength; i++)
			{
				_o.MatchConditions.Add((this.MatchConditions(i) != null) ? this.MatchConditions(i).Value.UnPack() : null);
			}
			_o.KeepConditions = new List<IDynamicEntityMatchT>();
			for (int j = 0; j < this.KeepConditionsLength; j++)
			{
				_o.KeepConditions.Add((this.KeepConditions(j) != null) ? this.KeepConditions(j).Value.UnPack() : null);
			}
			_o.ConnectedState = this.ConnectedState;
			_o.DisconnectedState = this.DisconnectedState;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06020D54 RID: 134484 RVA: 0x00490904 File Offset: 0x0048EB04
		public static Offset<IConnectorRange> Pack(FlatBufferBuilder builder, IConnectorRangeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IConnectorRange>);
			}
			Offset<IConnectorEffectConfig> effectConfigOffset = (_o.EffectConfig == null) ? default(Offset<IConnectorEffectConfig>) : IConnectorEffectConfig.Pack(builder, _o.EffectConfig);
			StringOffset activeStateOffset = (_o.ActiveState == null) ? default(StringOffset) : builder.CreateString(_o.ActiveState);
			VectorOffset matchConditionsOffset = default(VectorOffset);
			if (_o.MatchConditions != null)
			{
				Offset<IDynamicEntityMatch>[] array = new Offset<IDynamicEntityMatch>[_o.MatchConditions.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IDynamicEntityMatch.Pack(builder, _o.MatchConditions[i]);
				}
				matchConditionsOffset = IConnectorRange.CreateMatchConditionsVector(builder, array);
			}
			VectorOffset keepConditionsOffset = default(VectorOffset);
			if (_o.KeepConditions != null)
			{
				Offset<IDynamicEntityMatch>[] array2 = new Offset<IDynamicEntityMatch>[_o.KeepConditions.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = IDynamicEntityMatch.Pack(builder, _o.KeepConditions[j]);
				}
				keepConditionsOffset = IConnectorRange.CreateKeepConditionsVector(builder, array2);
			}
			StringOffset connectedStateOffset = (_o.ConnectedState == null) ? default(StringOffset) : builder.CreateString(_o.ConnectedState);
			StringOffset disconnectedStateOffset = (_o.DisconnectedState == null) ? default(StringOffset) : builder.CreateString(_o.DisconnectedState);
			return IConnectorRange.CreateIConnectorRange(builder, _o.Type, effectConfigOffset, activeStateOffset, _o.EnterRange, _o.LeaveRange, matchConditionsOffset, keepConditionsOffset, connectedStateOffset, disconnectedStateOffset, _o.NullMask);
		}

		// Token: 0x0400DFF3 RID: 57331
		private Table __p;
	}
}
