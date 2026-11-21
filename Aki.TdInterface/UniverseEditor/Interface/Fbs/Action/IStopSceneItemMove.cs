using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020079C5 RID: 31173
	public struct IStopSceneItemMove : IFlatbufferObject
	{
		// Token: 0x1700E491 RID: 58513
		// (get) Token: 0x06036EC0 RID: 224960 RVA: 0x00758208 File Offset: 0x00756408
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036EC1 RID: 224961 RVA: 0x00758215 File Offset: 0x00756415
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036EC2 RID: 224962 RVA: 0x0075821C File Offset: 0x0075641C
		public static IStopSceneItemMove GetRootAsIStopSceneItemMove(ByteBuffer _bb)
		{
			return IStopSceneItemMove.GetRootAsIStopSceneItemMove(_bb, default(IStopSceneItemMove));
		}

		// Token: 0x06036EC3 RID: 224963 RVA: 0x00758238 File Offset: 0x00756438
		public static IStopSceneItemMove GetRootAsIStopSceneItemMove(ByteBuffer _bb, IStopSceneItemMove obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06036EC4 RID: 224964 RVA: 0x00758255 File Offset: 0x00756455
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06036EC5 RID: 224965 RVA: 0x00758264 File Offset: 0x00756464
		public IStopSceneItemMove __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x06036EC6 RID: 224966 RVA: 0x00758274 File Offset: 0x00756474
		public int EntityIds(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700E492 RID: 58514
		// (get) Token: 0x06036EC7 RID: 224967 RVA: 0x007582B4 File Offset: 0x007564B4
		public int EntityIdsLength
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06036EC8 RID: 224968 RVA: 0x007582DF File Offset: 0x007564DF
		public Span<int> GetEntityIdsBytes()
		{
			return this.__p.__vector_as_span<int>(4, 4);
		}

		// Token: 0x06036EC9 RID: 224969 RVA: 0x007582EE File Offset: 0x007564EE
		public int[] GetEntityIdsArray()
		{
			return this.__p.__vector_as_array<int>(4);
		}

		// Token: 0x1700E493 RID: 58515
		// (get) Token: 0x06036ECA RID: 224970 RVA: 0x007582FC File Offset: 0x007564FC
		public EStopSceneItemMoveType StopType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return EStopSceneItemMoveType.StopAtCurrentPos;
				}
				return (EStopSceneItemMoveType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700E494 RID: 58516
		// (get) Token: 0x06036ECB RID: 224971 RVA: 0x00758338 File Offset: 0x00756538
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06036ECC RID: 224972 RVA: 0x00758374 File Offset: 0x00756574
		public static Offset<IStopSceneItemMove> CreateIStopSceneItemMove(FlatBufferBuilder builder, VectorOffset EntityIdsOffset = default(VectorOffset), EStopSceneItemMoveType StopType = EStopSceneItemMoveType.StopAtCurrentPos, byte NullMask = 0)
		{
			builder.StartTable(3);
			IStopSceneItemMove.AddEntityIds(builder, EntityIdsOffset);
			IStopSceneItemMove.AddNullMask(builder, NullMask);
			IStopSceneItemMove.AddStopType(builder, StopType);
			return IStopSceneItemMove.EndIStopSceneItemMove(builder);
		}

		// Token: 0x06036ECD RID: 224973 RVA: 0x00758398 File Offset: 0x00756598
		public static void StartIStopSceneItemMove(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06036ECE RID: 224974 RVA: 0x007583A1 File Offset: 0x007565A1
		public static void AddEntityIds(FlatBufferBuilder builder, VectorOffset entityIdsOffset)
		{
			builder.AddOffset(0, entityIdsOffset.Value, 0);
		}

		// Token: 0x06036ECF RID: 224975 RVA: 0x007583B4 File Offset: 0x007565B4
		public static VectorOffset CreateEntityIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06036ED0 RID: 224976 RVA: 0x007583EB File Offset: 0x007565EB
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06036ED1 RID: 224977 RVA: 0x00758405 File Offset: 0x00756605
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06036ED2 RID: 224978 RVA: 0x00758423 File Offset: 0x00756623
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06036ED3 RID: 224979 RVA: 0x0075843C File Offset: 0x0075663C
		public static void StartEntityIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06036ED4 RID: 224980 RVA: 0x00758447 File Offset: 0x00756647
		public static void AddStopType(FlatBufferBuilder builder, EStopSceneItemMoveType stopType)
		{
			builder.AddByte(1, (byte)stopType, 0);
		}

		// Token: 0x06036ED5 RID: 224981 RVA: 0x00758452 File Offset: 0x00756652
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x06036ED6 RID: 224982 RVA: 0x0075845D File Offset: 0x0075665D
		public static Offset<IStopSceneItemMove> EndIStopSceneItemMove(FlatBufferBuilder builder)
		{
			return new Offset<IStopSceneItemMove>(builder.EndTable());
		}

		// Token: 0x06036ED7 RID: 224983 RVA: 0x0075846C File Offset: 0x0075666C
		public IStopSceneItemMoveT UnPack()
		{
			IStopSceneItemMoveT stopSceneItemMoveT = new IStopSceneItemMoveT();
			this.UnPackTo(stopSceneItemMoveT);
			return stopSceneItemMoveT;
		}

		// Token: 0x06036ED8 RID: 224984 RVA: 0x00758488 File Offset: 0x00756688
		public void UnPackTo(IStopSceneItemMoveT _o)
		{
			_o.EntityIds = new List<int>();
			for (int i = 0; i < this.EntityIdsLength; i++)
			{
				_o.EntityIds.Add(this.EntityIds(i));
			}
			_o.StopType = this.StopType;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06036ED9 RID: 224985 RVA: 0x007584DC File Offset: 0x007566DC
		public static Offset<IStopSceneItemMove> Pack(FlatBufferBuilder builder, IStopSceneItemMoveT _o)
		{
			if (_o == null)
			{
				return default(Offset<IStopSceneItemMove>);
			}
			VectorOffset entityIdsOffset = default(VectorOffset);
			if (_o.EntityIds != null)
			{
				int[] data = _o.EntityIds.ToArray();
				entityIdsOffset = IStopSceneItemMove.CreateEntityIdsVector(builder, data);
			}
			return IStopSceneItemMove.CreateIStopSceneItemMove(builder, entityIdsOffset, _o.StopType, _o.NullMask);
		}

		// Token: 0x04012CD5 RID: 77013
		private Table __p;
	}
}
