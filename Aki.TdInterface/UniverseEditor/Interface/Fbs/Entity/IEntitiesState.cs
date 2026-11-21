using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x02004BF8 RID: 19448
	public struct IEntitiesState : IFlatbufferObject
	{
		// Token: 0x170089A8 RID: 35240
		// (get) Token: 0x0601DB48 RID: 121672 RVA: 0x0042AE00 File Offset: 0x00429000
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601DB49 RID: 121673 RVA: 0x0042AE0D File Offset: 0x0042900D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601DB4A RID: 121674 RVA: 0x0042AE14 File Offset: 0x00429014
		public static IEntitiesState GetRootAsIEntitiesState(ByteBuffer _bb)
		{
			return IEntitiesState.GetRootAsIEntitiesState(_bb, default(IEntitiesState));
		}

		// Token: 0x0601DB4B RID: 121675 RVA: 0x0042AE30 File Offset: 0x00429030
		public static IEntitiesState GetRootAsIEntitiesState(ByteBuffer _bb, IEntitiesState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601DB4C RID: 121676 RVA: 0x0042AE4D File Offset: 0x0042904D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601DB4D RID: 121677 RVA: 0x0042AE5C File Offset: 0x0042905C
		public IEntitiesState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0601DB4E RID: 121678 RVA: 0x0042AE6C File Offset: 0x0042906C
		public IEntityState? Entities(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			return new IEntityState?(default(IEntityState).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170089A9 RID: 35241
		// (get) Token: 0x0601DB4F RID: 121679 RVA: 0x0042AECC File Offset: 0x004290CC
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

		// Token: 0x170089AA RID: 35242
		// (get) Token: 0x0601DB50 RID: 121680 RVA: 0x0042AEF8 File Offset: 0x004290F8
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

		// Token: 0x170089AB RID: 35243
		// (get) Token: 0x0601DB51 RID: 121681 RVA: 0x0042AF34 File Offset: 0x00429134
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

		// Token: 0x0601DB52 RID: 121682 RVA: 0x0042AF70 File Offset: 0x00429170
		public static Offset<IEntitiesState> CreateIEntitiesState(FlatBufferBuilder builder, VectorOffset EntitiesOffset = default(VectorOffset), int LevelId = 0, byte NullMask = 0)
		{
			builder.StartTable(3);
			IEntitiesState.AddLevelId(builder, LevelId);
			IEntitiesState.AddEntities(builder, EntitiesOffset);
			IEntitiesState.AddNullMask(builder, NullMask);
			return IEntitiesState.EndIEntitiesState(builder);
		}

		// Token: 0x0601DB53 RID: 121683 RVA: 0x0042AF94 File Offset: 0x00429194
		public static void StartIEntitiesState(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601DB54 RID: 121684 RVA: 0x0042AF9D File Offset: 0x0042919D
		public static void AddEntities(FlatBufferBuilder builder, VectorOffset entitiesOffset)
		{
			builder.AddOffset(0, entitiesOffset.Value, 0);
		}

		// Token: 0x0601DB55 RID: 121685 RVA: 0x0042AFB0 File Offset: 0x004291B0
		public static VectorOffset CreateEntitiesVector(FlatBufferBuilder builder, Offset<IEntityState>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601DB56 RID: 121686 RVA: 0x0042AFF0 File Offset: 0x004291F0
		public static VectorOffset CreateEntitiesVectorBlock(FlatBufferBuilder builder, Offset<IEntityState>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IEntityState>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601DB57 RID: 121687 RVA: 0x0042B00A File Offset: 0x0042920A
		public static VectorOffset CreateEntitiesVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IEntityState>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IEntityState>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601DB58 RID: 121688 RVA: 0x0042B028 File Offset: 0x00429228
		public static VectorOffset CreateEntitiesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IEntityState>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601DB59 RID: 121689 RVA: 0x0042B041 File Offset: 0x00429241
		public static void StartEntitiesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601DB5A RID: 121690 RVA: 0x0042B04C File Offset: 0x0042924C
		public static void AddLevelId(FlatBufferBuilder builder, int levelId)
		{
			builder.AddInt(1, levelId, 0);
		}

		// Token: 0x0601DB5B RID: 121691 RVA: 0x0042B057 File Offset: 0x00429257
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x0601DB5C RID: 121692 RVA: 0x0042B062 File Offset: 0x00429262
		public static Offset<IEntitiesState> EndIEntitiesState(FlatBufferBuilder builder)
		{
			return new Offset<IEntitiesState>(builder.EndTable());
		}

		// Token: 0x0601DB5D RID: 121693 RVA: 0x0042B070 File Offset: 0x00429270
		public IEntitiesStateT UnPack()
		{
			IEntitiesStateT entitiesStateT = new IEntitiesStateT();
			this.UnPackTo(entitiesStateT);
			return entitiesStateT;
		}

		// Token: 0x0601DB5E RID: 121694 RVA: 0x0042B08C File Offset: 0x0042928C
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

		// Token: 0x0601DB5F RID: 121695 RVA: 0x0042B104 File Offset: 0x00429304
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

		// Token: 0x0400D62E RID: 54830
		private Table __p;
	}
}
