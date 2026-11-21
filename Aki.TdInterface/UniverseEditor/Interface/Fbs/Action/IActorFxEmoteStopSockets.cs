using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200671B RID: 26395
	public struct IActorFxEmoteStopSockets : IFlatbufferObject
	{
		// Token: 0x1700BFE9 RID: 49129
		// (get) Token: 0x0602CB4D RID: 183117 RVA: 0x0061DDA5 File Offset: 0x0061BFA5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602CB4E RID: 183118 RVA: 0x0061DDB2 File Offset: 0x0061BFB2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602CB4F RID: 183119 RVA: 0x0061DDBC File Offset: 0x0061BFBC
		public static IActorFxEmoteStopSockets GetRootAsIActorFxEmoteStopSockets(ByteBuffer _bb)
		{
			return IActorFxEmoteStopSockets.GetRootAsIActorFxEmoteStopSockets(_bb, default(IActorFxEmoteStopSockets));
		}

		// Token: 0x0602CB50 RID: 183120 RVA: 0x0061DDD8 File Offset: 0x0061BFD8
		public static IActorFxEmoteStopSockets GetRootAsIActorFxEmoteStopSockets(ByteBuffer _bb, IActorFxEmoteStopSockets obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602CB51 RID: 183121 RVA: 0x0061DDF5 File Offset: 0x0061BFF5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602CB52 RID: 183122 RVA: 0x0061DE04 File Offset: 0x0061C004
		public IActorFxEmoteStopSockets __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BFEA RID: 49130
		// (get) Token: 0x0602CB53 RID: 183123 RVA: 0x0061DE14 File Offset: 0x0061C014
		public EActorFxEmoteStopSubType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EActorFxEmoteStopSubType.StopAll;
				}
				return (EActorFxEmoteStopSubType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602CB54 RID: 183124 RVA: 0x0061DE50 File Offset: 0x0061C050
		public string Sockets(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700BFEB RID: 49131
		// (get) Token: 0x0602CB55 RID: 183125 RVA: 0x0061DE8C File Offset: 0x0061C08C
		public int SocketsLength
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

		// Token: 0x0602CB56 RID: 183126 RVA: 0x0061DEB7 File Offset: 0x0061C0B7
		public static Offset<IActorFxEmoteStopSockets> CreateIActorFxEmoteStopSockets(FlatBufferBuilder builder, EActorFxEmoteStopSubType Type = EActorFxEmoteStopSubType.StopAll, VectorOffset SocketsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IActorFxEmoteStopSockets.AddSockets(builder, SocketsOffset);
			IActorFxEmoteStopSockets.AddType(builder, Type);
			return IActorFxEmoteStopSockets.EndIActorFxEmoteStopSockets(builder);
		}

		// Token: 0x0602CB57 RID: 183127 RVA: 0x0061DED4 File Offset: 0x0061C0D4
		public static void StartIActorFxEmoteStopSockets(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602CB58 RID: 183128 RVA: 0x0061DEDD File Offset: 0x0061C0DD
		public static void AddType(FlatBufferBuilder builder, EActorFxEmoteStopSubType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602CB59 RID: 183129 RVA: 0x0061DEE8 File Offset: 0x0061C0E8
		public static void AddSockets(FlatBufferBuilder builder, VectorOffset socketsOffset)
		{
			builder.AddOffset(1, socketsOffset.Value, 0);
		}

		// Token: 0x0602CB5A RID: 183130 RVA: 0x0061DEF8 File Offset: 0x0061C0F8
		public static VectorOffset CreateSocketsVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602CB5B RID: 183131 RVA: 0x0061DF38 File Offset: 0x0061C138
		public static VectorOffset CreateSocketsVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0602CB5C RID: 183132 RVA: 0x0061DF52 File Offset: 0x0061C152
		public static VectorOffset CreateSocketsVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0602CB5D RID: 183133 RVA: 0x0061DF70 File Offset: 0x0061C170
		public static VectorOffset CreateSocketsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602CB5E RID: 183134 RVA: 0x0061DF89 File Offset: 0x0061C189
		public static void StartSocketsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602CB5F RID: 183135 RVA: 0x0061DF94 File Offset: 0x0061C194
		public static Offset<IActorFxEmoteStopSockets> EndIActorFxEmoteStopSockets(FlatBufferBuilder builder)
		{
			return new Offset<IActorFxEmoteStopSockets>(builder.EndTable());
		}

		// Token: 0x0602CB60 RID: 183136 RVA: 0x0061DFA4 File Offset: 0x0061C1A4
		public IActorFxEmoteStopSocketsT UnPack()
		{
			IActorFxEmoteStopSocketsT actorFxEmoteStopSocketsT = new IActorFxEmoteStopSocketsT();
			this.UnPackTo(actorFxEmoteStopSocketsT);
			return actorFxEmoteStopSocketsT;
		}

		// Token: 0x0602CB61 RID: 183137 RVA: 0x0061DFC0 File Offset: 0x0061C1C0
		public void UnPackTo(IActorFxEmoteStopSocketsT _o)
		{
			_o.Type = this.Type;
			_o.Sockets = new List<string>();
			for (int i = 0; i < this.SocketsLength; i++)
			{
				_o.Sockets.Add(this.Sockets(i));
			}
		}

		// Token: 0x0602CB62 RID: 183138 RVA: 0x0061E008 File Offset: 0x0061C208
		public static Offset<IActorFxEmoteStopSockets> Pack(FlatBufferBuilder builder, IActorFxEmoteStopSocketsT _o)
		{
			if (_o == null)
			{
				return default(Offset<IActorFxEmoteStopSockets>);
			}
			VectorOffset socketsOffset = default(VectorOffset);
			if (_o.Sockets != null)
			{
				StringOffset[] array = new StringOffset[_o.Sockets.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = builder.CreateString(_o.Sockets[i]);
				}
				socketsOffset = IActorFxEmoteStopSockets.CreateSocketsVector(builder, array);
			}
			return IActorFxEmoteStopSockets.CreateIActorFxEmoteStopSockets(builder, _o.Type, socketsOffset);
		}

		// Token: 0x04011261 RID: 70241
		private Table __p;
	}
}
