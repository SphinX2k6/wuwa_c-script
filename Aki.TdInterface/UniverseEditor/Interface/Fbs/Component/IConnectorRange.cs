using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200557D RID: 21885
	public struct IConnectorRange : IFlatbufferObject
	{
		// Token: 0x17009C93 RID: 40083
		// (get) Token: 0x06022C43 RID: 142403 RVA: 0x004C9BC8 File Offset: 0x004C7DC8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06022C44 RID: 142404 RVA: 0x004C9BD5 File Offset: 0x004C7DD5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06022C45 RID: 142405 RVA: 0x004C9BDC File Offset: 0x004C7DDC
		public static IConnectorRange GetRootAsIConnectorRange(ByteBuffer _bb)
		{
			return IConnectorRange.GetRootAsIConnectorRange(_bb, default(IConnectorRange));
		}

		// Token: 0x06022C46 RID: 142406 RVA: 0x004C9BF8 File Offset: 0x004C7DF8
		public static IConnectorRange GetRootAsIConnectorRange(ByteBuffer _bb, IConnectorRange obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06022C47 RID: 142407 RVA: 0x004C9C15 File Offset: 0x004C7E15
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06022C48 RID: 142408 RVA: 0x004C9C24 File Offset: 0x004C7E24
		public IConnectorRange __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009C94 RID: 40084
		// (get) Token: 0x06022C49 RID: 142409 RVA: 0x004C9C34 File Offset: 0x004C7E34
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

		// Token: 0x17009C95 RID: 40085
		// (get) Token: 0x06022C4A RID: 142410 RVA: 0x004C9C70 File Offset: 0x004C7E70
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

		// Token: 0x17009C96 RID: 40086
		// (get) Token: 0x06022C4B RID: 142411 RVA: 0x004C9CD0 File Offset: 0x004C7ED0
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

		// Token: 0x06022C4C RID: 142412 RVA: 0x004C9D07 File Offset: 0x004C7F07
		public Span<byte> GetActiveStateBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06022C4D RID: 142413 RVA: 0x004C9D16 File Offset: 0x004C7F16
		public byte[] GetActiveStateArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x17009C97 RID: 40087
		// (get) Token: 0x06022C4E RID: 142414 RVA: 0x004C9D24 File Offset: 0x004C7F24
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

		// Token: 0x17009C98 RID: 40088
		// (get) Token: 0x06022C4F RID: 142415 RVA: 0x004C9D64 File Offset: 0x004C7F64
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

		// Token: 0x06022C50 RID: 142416 RVA: 0x004C9DA4 File Offset: 0x004C7FA4
		public IDynamicEntityMatch? MatchConditions(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new IDynamicEntityMatch?(default(IDynamicEntityMatch).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009C99 RID: 40089
		// (get) Token: 0x06022C51 RID: 142417 RVA: 0x004C9E08 File Offset: 0x004C8008
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

		// Token: 0x06022C52 RID: 142418 RVA: 0x004C9E34 File Offset: 0x004C8034
		public IDynamicEntityMatch? KeepConditions(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return new IDynamicEntityMatch?(default(IDynamicEntityMatch).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009C9A RID: 40090
		// (get) Token: 0x06022C53 RID: 142419 RVA: 0x004C9E98 File Offset: 0x004C8098
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

		// Token: 0x17009C9B RID: 40091
		// (get) Token: 0x06022C54 RID: 142420 RVA: 0x004C9EC4 File Offset: 0x004C80C4
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

		// Token: 0x06022C55 RID: 142421 RVA: 0x004C9EFC File Offset: 0x004C80FC
		public Span<byte> GetConnectedStateBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06022C56 RID: 142422 RVA: 0x004C9F0C File Offset: 0x004C810C
		public byte[] GetConnectedStateArray()
		{
			return this.__p.__vector_as_array<byte>(18);
		}

		// Token: 0x17009C9C RID: 40092
		// (get) Token: 0x06022C57 RID: 142423 RVA: 0x004C9F1C File Offset: 0x004C811C
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

		// Token: 0x06022C58 RID: 142424 RVA: 0x004C9F54 File Offset: 0x004C8154
		public Span<byte> GetDisconnectedStateBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x06022C59 RID: 142425 RVA: 0x004C9F64 File Offset: 0x004C8164
		public byte[] GetDisconnectedStateArray()
		{
			return this.__p.__vector_as_array<byte>(20);
		}

		// Token: 0x17009C9D RID: 40093
		// (get) Token: 0x06022C5A RID: 142426 RVA: 0x004C9F74 File Offset: 0x004C8174
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

		// Token: 0x06022C5B RID: 142427 RVA: 0x004C9FB4 File Offset: 0x004C81B4
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

		// Token: 0x06022C5C RID: 142428 RVA: 0x004CA01C File Offset: 0x004C821C
		public static void StartIConnectorRange(FlatBufferBuilder builder)
		{
			builder.StartTable(10);
		}

		// Token: 0x06022C5D RID: 142429 RVA: 0x004CA026 File Offset: 0x004C8226
		public static void AddType(FlatBufferBuilder builder, EConnectorLogicType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06022C5E RID: 142430 RVA: 0x004CA031 File Offset: 0x004C8231
		public static void AddEffectConfig(FlatBufferBuilder builder, Offset<IConnectorEffectConfig> effectConfigOffset)
		{
			builder.AddOffset(1, effectConfigOffset.Value, 0);
		}

		// Token: 0x06022C5F RID: 142431 RVA: 0x004CA041 File Offset: 0x004C8241
		public static void AddActiveState(FlatBufferBuilder builder, StringOffset activeStateOffset)
		{
			builder.AddOffset(2, activeStateOffset.Value, 0);
		}

		// Token: 0x06022C60 RID: 142432 RVA: 0x004CA051 File Offset: 0x004C8251
		public static void AddEnterRange(FlatBufferBuilder builder, int enterRange)
		{
			builder.AddInt(3, enterRange, 0);
		}

		// Token: 0x06022C61 RID: 142433 RVA: 0x004CA05C File Offset: 0x004C825C
		public static void AddLeaveRange(FlatBufferBuilder builder, int leaveRange)
		{
			builder.AddInt(4, leaveRange, 0);
		}

		// Token: 0x06022C62 RID: 142434 RVA: 0x004CA067 File Offset: 0x004C8267
		public static void AddMatchConditions(FlatBufferBuilder builder, VectorOffset matchConditionsOffset)
		{
			builder.AddOffset(5, matchConditionsOffset.Value, 0);
		}

		// Token: 0x06022C63 RID: 142435 RVA: 0x004CA078 File Offset: 0x004C8278
		public static VectorOffset CreateMatchConditionsVector(FlatBufferBuilder builder, Offset<IDynamicEntityMatch>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06022C64 RID: 142436 RVA: 0x004CA0B8 File Offset: 0x004C82B8
		public static VectorOffset CreateMatchConditionsVectorBlock(FlatBufferBuilder builder, Offset<IDynamicEntityMatch>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IDynamicEntityMatch>>(data);
			return builder.EndVector();
		}

		// Token: 0x06022C65 RID: 142437 RVA: 0x004CA0D2 File Offset: 0x004C82D2
		public static VectorOffset CreateMatchConditionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IDynamicEntityMatch>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IDynamicEntityMatch>>(data);
			return builder.EndVector();
		}

		// Token: 0x06022C66 RID: 142438 RVA: 0x004CA0F0 File Offset: 0x004C82F0
		public static VectorOffset CreateMatchConditionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IDynamicEntityMatch>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06022C67 RID: 142439 RVA: 0x004CA109 File Offset: 0x004C8309
		public static void StartMatchConditionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06022C68 RID: 142440 RVA: 0x004CA114 File Offset: 0x004C8314
		public static void AddKeepConditions(FlatBufferBuilder builder, VectorOffset keepConditionsOffset)
		{
			builder.AddOffset(6, keepConditionsOffset.Value, 0);
		}

		// Token: 0x06022C69 RID: 142441 RVA: 0x004CA124 File Offset: 0x004C8324
		public static VectorOffset CreateKeepConditionsVector(FlatBufferBuilder builder, Offset<IDynamicEntityMatch>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06022C6A RID: 142442 RVA: 0x004CA164 File Offset: 0x004C8364
		public static VectorOffset CreateKeepConditionsVectorBlock(FlatBufferBuilder builder, Offset<IDynamicEntityMatch>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IDynamicEntityMatch>>(data);
			return builder.EndVector();
		}

		// Token: 0x06022C6B RID: 142443 RVA: 0x004CA17E File Offset: 0x004C837E
		public static VectorOffset CreateKeepConditionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IDynamicEntityMatch>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IDynamicEntityMatch>>(data);
			return builder.EndVector();
		}

		// Token: 0x06022C6C RID: 142444 RVA: 0x004CA19C File Offset: 0x004C839C
		public static VectorOffset CreateKeepConditionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IDynamicEntityMatch>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06022C6D RID: 142445 RVA: 0x004CA1B5 File Offset: 0x004C83B5
		public static void StartKeepConditionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06022C6E RID: 142446 RVA: 0x004CA1C0 File Offset: 0x004C83C0
		public static void AddConnectedState(FlatBufferBuilder builder, StringOffset connectedStateOffset)
		{
			builder.AddOffset(7, connectedStateOffset.Value, 0);
		}

		// Token: 0x06022C6F RID: 142447 RVA: 0x004CA1D0 File Offset: 0x004C83D0
		public static void AddDisconnectedState(FlatBufferBuilder builder, StringOffset disconnectedStateOffset)
		{
			builder.AddOffset(8, disconnectedStateOffset.Value, 0);
		}

		// Token: 0x06022C70 RID: 142448 RVA: 0x004CA1E0 File Offset: 0x004C83E0
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(9, nullMask, 0);
		}

		// Token: 0x06022C71 RID: 142449 RVA: 0x004CA1EC File Offset: 0x004C83EC
		public static Offset<IConnectorRange> EndIConnectorRange(FlatBufferBuilder builder)
		{
			return new Offset<IConnectorRange>(builder.EndTable());
		}

		// Token: 0x06022C72 RID: 142450 RVA: 0x004CA1FC File Offset: 0x004C83FC
		public IConnectorRangeT UnPack()
		{
			IConnectorRangeT connectorRangeT = new IConnectorRangeT();
			this.UnPackTo(connectorRangeT);
			return connectorRangeT;
		}

		// Token: 0x06022C73 RID: 142451 RVA: 0x004CA218 File Offset: 0x004C8418
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

		// Token: 0x06022C74 RID: 142452 RVA: 0x004CA354 File Offset: 0x004C8554
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

		// Token: 0x0400EBE9 RID: 60393
		private Table __p;
	}
}
