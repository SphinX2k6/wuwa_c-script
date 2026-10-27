using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020060B9 RID: 24761
	public struct IActorFxEmoteStopSockets : IFlatbufferObject
	{
		// Token: 0x1700B67E RID: 46718
		// (get) Token: 0x0602A46C RID: 173164 RVA: 0x005D3DFD File Offset: 0x005D1FFD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602A46D RID: 173165 RVA: 0x005D3E0A File Offset: 0x005D200A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602A46E RID: 173166 RVA: 0x005D3E14 File Offset: 0x005D2014
		public static IActorFxEmoteStopSockets GetRootAsIActorFxEmoteStopSockets(ByteBuffer _bb)
		{
			return IActorFxEmoteStopSockets.GetRootAsIActorFxEmoteStopSockets(_bb, default(IActorFxEmoteStopSockets));
		}

		// Token: 0x0602A46F RID: 173167 RVA: 0x005D3E30 File Offset: 0x005D2030
		public static IActorFxEmoteStopSockets GetRootAsIActorFxEmoteStopSockets(ByteBuffer _bb, IActorFxEmoteStopSockets obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602A470 RID: 173168 RVA: 0x005D3E4D File Offset: 0x005D204D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602A471 RID: 173169 RVA: 0x005D3E5C File Offset: 0x005D205C
		public IActorFxEmoteStopSockets __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B67F RID: 46719
		// (get) Token: 0x0602A472 RID: 173170 RVA: 0x005D3E6C File Offset: 0x005D206C
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

		// Token: 0x0602A473 RID: 173171 RVA: 0x005D3EA8 File Offset: 0x005D20A8
		public string Sockets(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700B680 RID: 46720
		// (get) Token: 0x0602A474 RID: 173172 RVA: 0x005D3EE4 File Offset: 0x005D20E4
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

		// Token: 0x0602A475 RID: 173173 RVA: 0x005D3F0F File Offset: 0x005D210F
		public static Offset<IActorFxEmoteStopSockets> CreateIActorFxEmoteStopSockets(FlatBufferBuilder builder, EActorFxEmoteStopSubType Type = EActorFxEmoteStopSubType.StopAll, VectorOffset SocketsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IActorFxEmoteStopSockets.AddSockets(builder, SocketsOffset);
			IActorFxEmoteStopSockets.AddType(builder, Type);
			return IActorFxEmoteStopSockets.EndIActorFxEmoteStopSockets(builder);
		}

		// Token: 0x0602A476 RID: 173174 RVA: 0x005D3F2C File Offset: 0x005D212C
		public static void StartIActorFxEmoteStopSockets(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602A477 RID: 173175 RVA: 0x005D3F35 File Offset: 0x005D2135
		public static void AddType(FlatBufferBuilder builder, EActorFxEmoteStopSubType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602A478 RID: 173176 RVA: 0x005D3F40 File Offset: 0x005D2140
		public static void AddSockets(FlatBufferBuilder builder, VectorOffset socketsOffset)
		{
			builder.AddOffset(1, socketsOffset.Value, 0);
		}

		// Token: 0x0602A479 RID: 173177 RVA: 0x005D3F50 File Offset: 0x005D2150
		public static VectorOffset CreateSocketsVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602A47A RID: 173178 RVA: 0x005D3F90 File Offset: 0x005D2190
		public static VectorOffset CreateSocketsVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0602A47B RID: 173179 RVA: 0x005D3FAA File Offset: 0x005D21AA
		public static VectorOffset CreateSocketsVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0602A47C RID: 173180 RVA: 0x005D3FC8 File Offset: 0x005D21C8
		public static VectorOffset CreateSocketsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602A47D RID: 173181 RVA: 0x005D3FE1 File Offset: 0x005D21E1
		public static void StartSocketsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602A47E RID: 173182 RVA: 0x005D3FEC File Offset: 0x005D21EC
		public static Offset<IActorFxEmoteStopSockets> EndIActorFxEmoteStopSockets(FlatBufferBuilder builder)
		{
			return new Offset<IActorFxEmoteStopSockets>(builder.EndTable());
		}

		// Token: 0x0602A47F RID: 173183 RVA: 0x005D3FFC File Offset: 0x005D21FC
		public IActorFxEmoteStopSocketsT UnPack()
		{
			IActorFxEmoteStopSocketsT actorFxEmoteStopSocketsT = new IActorFxEmoteStopSocketsT();
			this.UnPackTo(actorFxEmoteStopSocketsT);
			return actorFxEmoteStopSocketsT;
		}

		// Token: 0x0602A480 RID: 173184 RVA: 0x005D4018 File Offset: 0x005D2218
		public void UnPackTo(IActorFxEmoteStopSocketsT _o)
		{
			_o.Type = this.Type;
			_o.Sockets = new List<string>();
			for (int i = 0; i < this.SocketsLength; i++)
			{
				_o.Sockets.Add(this.Sockets(i));
			}
		}

		// Token: 0x0602A481 RID: 173185 RVA: 0x005D4060 File Offset: 0x005D2260
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

		// Token: 0x0401045D RID: 66653
		private Table __p;
	}
}
