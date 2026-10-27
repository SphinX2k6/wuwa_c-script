using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x02004790 RID: 18320
	public struct IEntitiesState : IFlatbufferObject
	{
		// Token: 0x17008367 RID: 33639
		// (get) Token: 0x0601C373 RID: 115571 RVA: 0x003FEB64 File Offset: 0x003FCD64
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601C374 RID: 115572 RVA: 0x003FEB71 File Offset: 0x003FCD71
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601C375 RID: 115573 RVA: 0x003FEB78 File Offset: 0x003FCD78
		public static IEntitiesState GetRootAsIEntitiesState(ByteBuffer _bb)
		{
			return IEntitiesState.GetRootAsIEntitiesState(_bb, default(IEntitiesState));
		}

		// Token: 0x0601C376 RID: 115574 RVA: 0x003FEB94 File Offset: 0x003FCD94
		public static IEntitiesState GetRootAsIEntitiesState(ByteBuffer _bb, IEntitiesState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601C377 RID: 115575 RVA: 0x003FEBB1 File Offset: 0x003FCDB1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601C378 RID: 115576 RVA: 0x003FEBC0 File Offset: 0x003FCDC0
		public IEntitiesState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0601C379 RID: 115577 RVA: 0x003FEBD0 File Offset: 0x003FCDD0
		public IEntityState? Entities(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			return new IEntityState?(default(IEntityState).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17008368 RID: 33640
		// (get) Token: 0x0601C37A RID: 115578 RVA: 0x003FEC30 File Offset: 0x003FCE30
		public int EntitiesLength
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

		// Token: 0x17008369 RID: 33641
		// (get) Token: 0x0601C37B RID: 115579 RVA: 0x003FEC5C File Offset: 0x003FCE5C
		public int LevelId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700836A RID: 33642
		// (get) Token: 0x0601C37C RID: 115580 RVA: 0x003FEC98 File Offset: 0x003FCE98
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

		// Token: 0x0601C37D RID: 115581 RVA: 0x003FECD4 File Offset: 0x003FCED4
		public static Offset<IEntitiesState> CreateIEntitiesState(FlatBufferBuilder builder, VectorOffset EntitiesOffset = default(VectorOffset), int LevelId = 0, byte NullMask = 0)
		{
			builder.StartTable(3);
			IEntitiesState.AddLevelId(builder, LevelId);
			IEntitiesState.AddEntities(builder, EntitiesOffset);
			IEntitiesState.AddNullMask(builder, NullMask);
			return IEntitiesState.EndIEntitiesState(builder);
		}

		// Token: 0x0601C37E RID: 115582 RVA: 0x003FECF8 File Offset: 0x003FCEF8
		public static void StartIEntitiesState(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601C37F RID: 115583 RVA: 0x003FED01 File Offset: 0x003FCF01
		public static void AddEntities(FlatBufferBuilder builder, VectorOffset entitiesOffset)
		{
			builder.AddOffset(0, entitiesOffset.Value, 0);
		}

		// Token: 0x0601C380 RID: 115584 RVA: 0x003FED14 File Offset: 0x003FCF14
		public static VectorOffset CreateEntitiesVector(FlatBufferBuilder builder, Offset<IEntityState>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601C381 RID: 115585 RVA: 0x003FED54 File Offset: 0x003FCF54
		public static VectorOffset CreateEntitiesVectorBlock(FlatBufferBuilder builder, Offset<IEntityState>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IEntityState>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C382 RID: 115586 RVA: 0x003FED6E File Offset: 0x003FCF6E
		public static VectorOffset CreateEntitiesVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IEntityState>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IEntityState>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C383 RID: 115587 RVA: 0x003FED8C File Offset: 0x003FCF8C
		public static VectorOffset CreateEntitiesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IEntityState>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601C384 RID: 115588 RVA: 0x003FEDA5 File Offset: 0x003FCFA5
		public static void StartEntitiesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601C385 RID: 115589 RVA: 0x003FEDB0 File Offset: 0x003FCFB0
		public static void AddLevelId(FlatBufferBuilder builder, int levelId)
		{
			builder.AddInt(1, levelId, 0);
		}

		// Token: 0x0601C386 RID: 115590 RVA: 0x003FEDBB File Offset: 0x003FCFBB
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x0601C387 RID: 115591 RVA: 0x003FEDC6 File Offset: 0x003FCFC6
		public static Offset<IEntitiesState> EndIEntitiesState(FlatBufferBuilder builder)
		{
			return new Offset<IEntitiesState>(builder.EndTable());
		}

		// Token: 0x0601C388 RID: 115592 RVA: 0x003FEDD4 File Offset: 0x003FCFD4
		public IEntitiesStateT UnPack()
		{
			IEntitiesStateT entitiesStateT = new IEntitiesStateT();
			this.UnPackTo(entitiesStateT);
			return entitiesStateT;
		}

		// Token: 0x0601C389 RID: 115593 RVA: 0x003FEDF0 File Offset: 0x003FCFF0
		public void UnPackTo(IEntitiesStateT _o)
		{
			_o.Entities = new List<IEntityStateT>();
			for (int i = 0; i < this.EntitiesLength; i++)
			{
				_o.Entities.Add((this.Entities(i) != null) ? this.Entities(i).Value.UnPack() : null);
			}
			_o.LevelId = this.LevelId;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601C38A RID: 115594 RVA: 0x003FEE68 File Offset: 0x003FD068
		public static Offset<IEntitiesState> Pack(FlatBufferBuilder builder, IEntitiesStateT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEntitiesState>);
			}
			VectorOffset entitiesOffset = default(VectorOffset);
			if (_o.Entities != null)
			{
				Offset<IEntityState>[] array = new Offset<IEntityState>[_o.Entities.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IEntityState.Pack(builder, _o.Entities[i]);
				}
				entitiesOffset = IEntitiesState.CreateEntitiesVector(builder, array);
			}
			return IEntitiesState.CreateIEntitiesState(builder, entitiesOffset, _o.LevelId, _o.NullMask);
		}

		// Token: 0x0400CBF8 RID: 52216
		private Table __p;
	}
}
