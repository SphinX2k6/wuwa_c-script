using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020071F0 RID: 29168
	public struct IStopSceneItemMove : IFlatbufferObject
	{
		// Token: 0x1700D898 RID: 55448
		// (get) Token: 0x06033BBE RID: 211902 RVA: 0x006F6EA8 File Offset: 0x006F50A8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06033BBF RID: 211903 RVA: 0x006F6EB5 File Offset: 0x006F50B5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06033BC0 RID: 211904 RVA: 0x006F6EBC File Offset: 0x006F50BC
		public static IStopSceneItemMove GetRootAsIStopSceneItemMove(ByteBuffer _bb)
		{
			return IStopSceneItemMove.GetRootAsIStopSceneItemMove(_bb, default(IStopSceneItemMove));
		}

		// Token: 0x06033BC1 RID: 211905 RVA: 0x006F6ED8 File Offset: 0x006F50D8
		public static IStopSceneItemMove GetRootAsIStopSceneItemMove(ByteBuffer _bb, IStopSceneItemMove obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06033BC2 RID: 211906 RVA: 0x006F6EF5 File Offset: 0x006F50F5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06033BC3 RID: 211907 RVA: 0x006F6F04 File Offset: 0x006F5104
		public IStopSceneItemMove __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x06033BC4 RID: 211908 RVA: 0x006F6F14 File Offset: 0x006F5114
		public int EntityIds(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700D899 RID: 55449
		// (get) Token: 0x06033BC5 RID: 211909 RVA: 0x006F6F54 File Offset: 0x006F5154
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

		// Token: 0x06033BC6 RID: 211910 RVA: 0x006F6F7F File Offset: 0x006F517F
		public Span<int> GetEntityIdsBytes()
		{
			return this.__p.__vector_as_span<int>(4, 4);
		}

		// Token: 0x06033BC7 RID: 211911 RVA: 0x006F6F8E File Offset: 0x006F518E
		public int[] GetEntityIdsArray()
		{
			return this.__p.__vector_as_array<int>(4);
		}

		// Token: 0x1700D89A RID: 55450
		// (get) Token: 0x06033BC8 RID: 211912 RVA: 0x006F6F9C File Offset: 0x006F519C
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

		// Token: 0x1700D89B RID: 55451
		// (get) Token: 0x06033BC9 RID: 211913 RVA: 0x006F6FD8 File Offset: 0x006F51D8
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

		// Token: 0x06033BCA RID: 211914 RVA: 0x006F7014 File Offset: 0x006F5214
		public static Offset<IStopSceneItemMove> CreateIStopSceneItemMove(FlatBufferBuilder builder, VectorOffset EntityIdsOffset = default(VectorOffset), EStopSceneItemMoveType StopType = EStopSceneItemMoveType.StopAtCurrentPos, byte NullMask = 0)
		{
			builder.StartTable(3);
			IStopSceneItemMove.AddEntityIds(builder, EntityIdsOffset);
			IStopSceneItemMove.AddNullMask(builder, NullMask);
			IStopSceneItemMove.AddStopType(builder, StopType);
			return IStopSceneItemMove.EndIStopSceneItemMove(builder);
		}

		// Token: 0x06033BCB RID: 211915 RVA: 0x006F7038 File Offset: 0x006F5238
		public static void StartIStopSceneItemMove(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06033BCC RID: 211916 RVA: 0x006F7041 File Offset: 0x006F5241
		public static void AddEntityIds(FlatBufferBuilder builder, VectorOffset entityIdsOffset)
		{
			builder.AddOffset(0, entityIdsOffset.Value, 0);
		}

		// Token: 0x06033BCD RID: 211917 RVA: 0x006F7054 File Offset: 0x006F5254
		public static VectorOffset CreateEntityIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06033BCE RID: 211918 RVA: 0x006F708B File Offset: 0x006F528B
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06033BCF RID: 211919 RVA: 0x006F70A5 File Offset: 0x006F52A5
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06033BD0 RID: 211920 RVA: 0x006F70C3 File Offset: 0x006F52C3
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06033BD1 RID: 211921 RVA: 0x006F70DC File Offset: 0x006F52DC
		public static void StartEntityIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06033BD2 RID: 211922 RVA: 0x006F70E7 File Offset: 0x006F52E7
		public static void AddStopType(FlatBufferBuilder builder, EStopSceneItemMoveType stopType)
		{
			builder.AddByte(1, (byte)stopType, 0);
		}

		// Token: 0x06033BD3 RID: 211923 RVA: 0x006F70F2 File Offset: 0x006F52F2
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x06033BD4 RID: 211924 RVA: 0x006F70FD File Offset: 0x006F52FD
		public static Offset<IStopSceneItemMove> EndIStopSceneItemMove(FlatBufferBuilder builder)
		{
			return new Offset<IStopSceneItemMove>(builder.EndTable());
		}

		// Token: 0x06033BD5 RID: 211925 RVA: 0x006F710C File Offset: 0x006F530C
		public IStopSceneItemMoveT UnPack()
		{
			IStopSceneItemMoveT stopSceneItemMoveT = new IStopSceneItemMoveT();
			this.UnPackTo(stopSceneItemMoveT);
			return stopSceneItemMoveT;
		}

		// Token: 0x06033BD6 RID: 211926 RVA: 0x006F7128 File Offset: 0x006F5328
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

		// Token: 0x06033BD7 RID: 211927 RVA: 0x006F717C File Offset: 0x006F537C
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

		// Token: 0x04011CD3 RID: 72915
		private Table __p;
	}
}
