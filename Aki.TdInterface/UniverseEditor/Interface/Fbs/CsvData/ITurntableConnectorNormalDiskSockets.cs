using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.CsvData
{
	// Token: 0x02004DC1 RID: 19905
	public struct ITurntableConnectorNormalDiskSockets : IFlatbufferObject
	{
		// Token: 0x17008E63 RID: 36451
		// (get) Token: 0x0601EE1D RID: 126493 RVA: 0x0045092E File Offset: 0x0044EB2E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601EE1E RID: 126494 RVA: 0x0045093B File Offset: 0x0044EB3B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601EE1F RID: 126495 RVA: 0x00450944 File Offset: 0x0044EB44
		public static ITurntableConnectorNormalDiskSockets GetRootAsITurntableConnectorNormalDiskSockets(ByteBuffer _bb)
		{
			return ITurntableConnectorNormalDiskSockets.GetRootAsITurntableConnectorNormalDiskSockets(_bb, default(ITurntableConnectorNormalDiskSockets));
		}

		// Token: 0x0601EE20 RID: 126496 RVA: 0x00450960 File Offset: 0x0044EB60
		public static ITurntableConnectorNormalDiskSockets GetRootAsITurntableConnectorNormalDiskSockets(ByteBuffer _bb, ITurntableConnectorNormalDiskSockets obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601EE21 RID: 126497 RVA: 0x0045097D File Offset: 0x0044EB7D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601EE22 RID: 126498 RVA: 0x0045098C File Offset: 0x0044EB8C
		public ITurntableConnectorNormalDiskSockets __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008E64 RID: 36452
		// (get) Token: 0x0601EE23 RID: 126499 RVA: 0x0045099C File Offset: 0x0044EB9C
		public ETurntableConnectorDiskLayout Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETurntableConnectorDiskLayout.Normal;
				}
				return (ETurntableConnectorDiskLayout)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601EE24 RID: 126500 RVA: 0x004509D8 File Offset: 0x0044EBD8
		public ITurntableConnectorDiskSocket? Sockets(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new ITurntableConnectorDiskSocket?(default(ITurntableConnectorDiskSocket).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17008E65 RID: 36453
		// (get) Token: 0x0601EE25 RID: 126501 RVA: 0x00450A38 File Offset: 0x0044EC38
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

		// Token: 0x0601EE26 RID: 126502 RVA: 0x00450A63 File Offset: 0x0044EC63
		public static Offset<ITurntableConnectorNormalDiskSockets> CreateITurntableConnectorNormalDiskSockets(FlatBufferBuilder builder, ETurntableConnectorDiskLayout Type = ETurntableConnectorDiskLayout.Normal, VectorOffset SocketsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			ITurntableConnectorNormalDiskSockets.AddSockets(builder, SocketsOffset);
			ITurntableConnectorNormalDiskSockets.AddType(builder, Type);
			return ITurntableConnectorNormalDiskSockets.EndITurntableConnectorNormalDiskSockets(builder);
		}

		// Token: 0x0601EE27 RID: 126503 RVA: 0x00450A80 File Offset: 0x0044EC80
		public static void StartITurntableConnectorNormalDiskSockets(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601EE28 RID: 126504 RVA: 0x00450A89 File Offset: 0x0044EC89
		public static void AddType(FlatBufferBuilder builder, ETurntableConnectorDiskLayout type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601EE29 RID: 126505 RVA: 0x00450A94 File Offset: 0x0044EC94
		public static void AddSockets(FlatBufferBuilder builder, VectorOffset socketsOffset)
		{
			builder.AddOffset(1, socketsOffset.Value, 0);
		}

		// Token: 0x0601EE2A RID: 126506 RVA: 0x00450AA4 File Offset: 0x0044ECA4
		public static VectorOffset CreateSocketsVector(FlatBufferBuilder builder, Offset<ITurntableConnectorDiskSocket>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601EE2B RID: 126507 RVA: 0x00450AE4 File Offset: 0x0044ECE4
		public static VectorOffset CreateSocketsVectorBlock(FlatBufferBuilder builder, Offset<ITurntableConnectorDiskSocket>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ITurntableConnectorDiskSocket>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601EE2C RID: 126508 RVA: 0x00450AFE File Offset: 0x0044ECFE
		public static VectorOffset CreateSocketsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ITurntableConnectorDiskSocket>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ITurntableConnectorDiskSocket>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601EE2D RID: 126509 RVA: 0x00450B1C File Offset: 0x0044ED1C
		public static VectorOffset CreateSocketsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ITurntableConnectorDiskSocket>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601EE2E RID: 126510 RVA: 0x00450B35 File Offset: 0x0044ED35
		public static void StartSocketsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601EE2F RID: 126511 RVA: 0x00450B40 File Offset: 0x0044ED40
		public static Offset<ITurntableConnectorNormalDiskSockets> EndITurntableConnectorNormalDiskSockets(FlatBufferBuilder builder)
		{
			return new Offset<ITurntableConnectorNormalDiskSockets>(builder.EndTable());
		}

		// Token: 0x0601EE30 RID: 126512 RVA: 0x00450B50 File Offset: 0x0044ED50
		public ITurntableConnectorNormalDiskSocketsT UnPack()
		{
			ITurntableConnectorNormalDiskSocketsT turntableConnectorNormalDiskSocketsT = new ITurntableConnectorNormalDiskSocketsT();
			this.UnPackTo(turntableConnectorNormalDiskSocketsT);
			return turntableConnectorNormalDiskSocketsT;
		}

		// Token: 0x0601EE31 RID: 126513 RVA: 0x00450B6C File Offset: 0x0044ED6C
		public void UnPackTo(ITurntableConnectorNormalDiskSocketsT _o)
		{
			_o.Type = this.Type;
			_o.Sockets = new List<ITurntableConnectorDiskSocketT>();
			for (int i = 0; i < this.SocketsLength; i++)
			{
				_o.Sockets.Add((this.Sockets(i) != null) ? this.Sockets(i).Value.UnPack() : null);
			}
		}

		// Token: 0x0601EE32 RID: 126514 RVA: 0x00450BD8 File Offset: 0x0044EDD8
		public static Offset<ITurntableConnectorNormalDiskSockets> Pack(FlatBufferBuilder builder, ITurntableConnectorNormalDiskSocketsT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITurntableConnectorNormalDiskSockets>);
			}
			VectorOffset socketsOffset = default(VectorOffset);
			if (_o.Sockets != null)
			{
				Offset<ITurntableConnectorDiskSocket>[] array = new Offset<ITurntableConnectorDiskSocket>[_o.Sockets.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = ITurntableConnectorDiskSocket.Pack(builder, _o.Sockets[i]);
				}
				socketsOffset = ITurntableConnectorNormalDiskSockets.CreateSocketsVector(builder, array);
			}
			return ITurntableConnectorNormalDiskSockets.CreateITurntableConnectorNormalDiskSockets(builder, _o.Type, socketsOffset);
		}

		// Token: 0x0400DA2F RID: 55855
		private Table __p;
	}
}
