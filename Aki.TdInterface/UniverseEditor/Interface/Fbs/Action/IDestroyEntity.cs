using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200658B RID: 25995
	public struct IDestroyEntity : IFlatbufferObject
	{
		// Token: 0x1700C10F RID: 49423
		// (get) Token: 0x0602D167 RID: 184679 RVA: 0x0062F646 File Offset: 0x0062D846
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602D168 RID: 184680 RVA: 0x0062F653 File Offset: 0x0062D853
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602D169 RID: 184681 RVA: 0x0062F65C File Offset: 0x0062D85C
		public static IDestroyEntity GetRootAsIDestroyEntity(ByteBuffer _bb)
		{
			return IDestroyEntity.GetRootAsIDestroyEntity(_bb, default(IDestroyEntity));
		}

		// Token: 0x0602D16A RID: 184682 RVA: 0x0062F678 File Offset: 0x0062D878
		public static IDestroyEntity GetRootAsIDestroyEntity(ByteBuffer _bb, IDestroyEntity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602D16B RID: 184683 RVA: 0x0062F695 File Offset: 0x0062D895
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602D16C RID: 184684 RVA: 0x0062F6A4 File Offset: 0x0062D8A4
		public IDestroyEntity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0602D16D RID: 184685 RVA: 0x0062F6B4 File Offset: 0x0062D8B4
		public int EntityIds(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700C110 RID: 49424
		// (get) Token: 0x0602D16E RID: 184686 RVA: 0x0062F6F4 File Offset: 0x0062D8F4
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

		// Token: 0x0602D16F RID: 184687 RVA: 0x0062F71F File Offset: 0x0062D91F
		public Span<int> GetEntityIdsBytes()
		{
			return this.__p.__vector_as_span<int>(4, 4);
		}

		// Token: 0x0602D170 RID: 184688 RVA: 0x0062F72E File Offset: 0x0062D92E
		public int[] GetEntityIdsArray()
		{
			return this.__p.__vector_as_array<int>(4);
		}

		// Token: 0x1700C111 RID: 49425
		// (get) Token: 0x0602D171 RID: 184689 RVA: 0x0062F73C File Offset: 0x0062D93C
		public bool DelayDestroy
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C112 RID: 49426
		// (get) Token: 0x0602D172 RID: 184690 RVA: 0x0062F77C File Offset: 0x0062D97C
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

		// Token: 0x0602D173 RID: 184691 RVA: 0x0062F7B8 File Offset: 0x0062D9B8
		public static Offset<IDestroyEntity> CreateIDestroyEntity(FlatBufferBuilder builder, VectorOffset EntityIdsOffset = default(VectorOffset), bool DelayDestroy = false, byte NullMask = 0)
		{
			builder.StartTable(3);
			IDestroyEntity.AddEntityIds(builder, EntityIdsOffset);
			IDestroyEntity.AddNullMask(builder, NullMask);
			IDestroyEntity.AddDelayDestroy(builder, DelayDestroy);
			return IDestroyEntity.EndIDestroyEntity(builder);
		}

		// Token: 0x0602D174 RID: 184692 RVA: 0x0062F7DC File Offset: 0x0062D9DC
		public static void StartIDestroyEntity(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602D175 RID: 184693 RVA: 0x0062F7E5 File Offset: 0x0062D9E5
		public static void AddEntityIds(FlatBufferBuilder builder, VectorOffset entityIdsOffset)
		{
			builder.AddOffset(0, entityIdsOffset.Value, 0);
		}

		// Token: 0x0602D176 RID: 184694 RVA: 0x0062F7F8 File Offset: 0x0062D9F8
		public static VectorOffset CreateEntityIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602D177 RID: 184695 RVA: 0x0062F82F File Offset: 0x0062DA2F
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602D178 RID: 184696 RVA: 0x0062F849 File Offset: 0x0062DA49
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602D179 RID: 184697 RVA: 0x0062F867 File Offset: 0x0062DA67
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602D17A RID: 184698 RVA: 0x0062F880 File Offset: 0x0062DA80
		public static void StartEntityIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602D17B RID: 184699 RVA: 0x0062F88B File Offset: 0x0062DA8B
		public static void AddDelayDestroy(FlatBufferBuilder builder, bool delayDestroy)
		{
			builder.AddBool(1, delayDestroy, false);
		}

		// Token: 0x0602D17C RID: 184700 RVA: 0x0062F896 File Offset: 0x0062DA96
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x0602D17D RID: 184701 RVA: 0x0062F8A1 File Offset: 0x0062DAA1
		public static Offset<IDestroyEntity> EndIDestroyEntity(FlatBufferBuilder builder)
		{
			return new Offset<IDestroyEntity>(builder.EndTable());
		}

		// Token: 0x0602D17E RID: 184702 RVA: 0x0062F8B0 File Offset: 0x0062DAB0
		public IDestroyEntityT UnPack()
		{
			IDestroyEntityT destroyEntityT = new IDestroyEntityT();
			this.UnPackTo(destroyEntityT);
			return destroyEntityT;
		}

		// Token: 0x0602D17F RID: 184703 RVA: 0x0062F8CC File Offset: 0x0062DACC
		public void UnPackTo(IDestroyEntityT _o)
		{
			_o.EntityIds = new List<int>();
			for (int i = 0; i < this.EntityIdsLength; i++)
			{
				_o.EntityIds.Add(this.EntityIds(i));
			}
			_o.DelayDestroy = this.DelayDestroy;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602D180 RID: 184704 RVA: 0x0062F920 File Offset: 0x0062DB20
		public static Offset<IDestroyEntity> Pack(FlatBufferBuilder builder, IDestroyEntityT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDestroyEntity>);
			}
			VectorOffset entityIdsOffset = default(VectorOffset);
			if (_o.EntityIds != null)
			{
				int[] data = _o.EntityIds.ToArray();
				entityIdsOffset = IDestroyEntity.CreateEntityIdsVector(builder, data);
			}
			return IDestroyEntity.CreateIDestroyEntity(builder, entityIdsOffset, _o.DelayDestroy, _o.NullMask);
		}

		// Token: 0x04010BE4 RID: 68580
		private Table __p;
	}
}
