using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006BF3 RID: 27635
	public struct IDestroyEntity : IFlatbufferObject
	{
		// Token: 0x1700CA9E RID: 51870
		// (get) Token: 0x0602F8EB RID: 194795 RVA: 0x0067B80A File Offset: 0x00679A0A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602F8EC RID: 194796 RVA: 0x0067B817 File Offset: 0x00679A17
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602F8ED RID: 194797 RVA: 0x0067B820 File Offset: 0x00679A20
		public static IDestroyEntity GetRootAsIDestroyEntity(ByteBuffer _bb)
		{
			return IDestroyEntity.GetRootAsIDestroyEntity(_bb, default(IDestroyEntity));
		}

		// Token: 0x0602F8EE RID: 194798 RVA: 0x0067B83C File Offset: 0x00679A3C
		public static IDestroyEntity GetRootAsIDestroyEntity(ByteBuffer _bb, IDestroyEntity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602F8EF RID: 194799 RVA: 0x0067B859 File Offset: 0x00679A59
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602F8F0 RID: 194800 RVA: 0x0067B868 File Offset: 0x00679A68
		public IDestroyEntity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0602F8F1 RID: 194801 RVA: 0x0067B878 File Offset: 0x00679A78
		public int EntityIds(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700CA9F RID: 51871
		// (get) Token: 0x0602F8F2 RID: 194802 RVA: 0x0067B8B8 File Offset: 0x00679AB8
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

		// Token: 0x0602F8F3 RID: 194803 RVA: 0x0067B8E3 File Offset: 0x00679AE3
		public Span<int> GetEntityIdsBytes()
		{
			return this.__p.__vector_as_span<int>(4, 4);
		}

		// Token: 0x0602F8F4 RID: 194804 RVA: 0x0067B8F2 File Offset: 0x00679AF2
		public int[] GetEntityIdsArray()
		{
			return this.__p.__vector_as_array<int>(4);
		}

		// Token: 0x1700CAA0 RID: 51872
		// (get) Token: 0x0602F8F5 RID: 194805 RVA: 0x0067B900 File Offset: 0x00679B00
		public bool DelayDestroy
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700CAA1 RID: 51873
		// (get) Token: 0x0602F8F6 RID: 194806 RVA: 0x0067B940 File Offset: 0x00679B40
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

		// Token: 0x0602F8F7 RID: 194807 RVA: 0x0067B97C File Offset: 0x00679B7C
		public static Offset<IDestroyEntity> CreateIDestroyEntity(FlatBufferBuilder builder, VectorOffset EntityIdsOffset = default(VectorOffset), bool DelayDestroy = false, byte NullMask = 0)
		{
			builder.StartTable(3);
			IDestroyEntity.AddEntityIds(builder, EntityIdsOffset);
			IDestroyEntity.AddNullMask(builder, NullMask);
			IDestroyEntity.AddDelayDestroy(builder, DelayDestroy);
			return IDestroyEntity.EndIDestroyEntity(builder);
		}

		// Token: 0x0602F8F8 RID: 194808 RVA: 0x0067B9A0 File Offset: 0x00679BA0
		public static void StartIDestroyEntity(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602F8F9 RID: 194809 RVA: 0x0067B9A9 File Offset: 0x00679BA9
		public static void AddEntityIds(FlatBufferBuilder builder, VectorOffset entityIdsOffset)
		{
			builder.AddOffset(0, entityIdsOffset.Value, 0);
		}

		// Token: 0x0602F8FA RID: 194810 RVA: 0x0067B9BC File Offset: 0x00679BBC
		public static VectorOffset CreateEntityIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602F8FB RID: 194811 RVA: 0x0067B9F3 File Offset: 0x00679BF3
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602F8FC RID: 194812 RVA: 0x0067BA0D File Offset: 0x00679C0D
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602F8FD RID: 194813 RVA: 0x0067BA2B File Offset: 0x00679C2B
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602F8FE RID: 194814 RVA: 0x0067BA44 File Offset: 0x00679C44
		public static void StartEntityIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602F8FF RID: 194815 RVA: 0x0067BA4F File Offset: 0x00679C4F
		public static void AddDelayDestroy(FlatBufferBuilder builder, bool delayDestroy)
		{
			builder.AddBool(1, delayDestroy, false);
		}

		// Token: 0x0602F900 RID: 194816 RVA: 0x0067BA5A File Offset: 0x00679C5A
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x0602F901 RID: 194817 RVA: 0x0067BA65 File Offset: 0x00679C65
		public static Offset<IDestroyEntity> EndIDestroyEntity(FlatBufferBuilder builder)
		{
			return new Offset<IDestroyEntity>(builder.EndTable());
		}

		// Token: 0x0602F902 RID: 194818 RVA: 0x0067BA74 File Offset: 0x00679C74
		public IDestroyEntityT UnPack()
		{
			IDestroyEntityT destroyEntityT = new IDestroyEntityT();
			this.UnPackTo(destroyEntityT);
			return destroyEntityT;
		}

		// Token: 0x0602F903 RID: 194819 RVA: 0x0067BA90 File Offset: 0x00679C90
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

		// Token: 0x0602F904 RID: 194820 RVA: 0x0067BAE4 File Offset: 0x00679CE4
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

		// Token: 0x040119F6 RID: 72182
		private Table __p;
	}
}
