using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020074D8 RID: 29912
	public struct IUnlockEntity : IFlatbufferObject
	{
		// Token: 0x1700E2FB RID: 58107
		// (get) Token: 0x06036607 RID: 222727 RVA: 0x0076361D File Offset: 0x0076181D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036608 RID: 222728 RVA: 0x0076362A File Offset: 0x0076182A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036609 RID: 222729 RVA: 0x00763634 File Offset: 0x00761834
		public static IUnlockEntity GetRootAsIUnlockEntity(ByteBuffer _bb)
		{
			return IUnlockEntity.GetRootAsIUnlockEntity(_bb, default(IUnlockEntity));
		}

		// Token: 0x0603660A RID: 222730 RVA: 0x00763650 File Offset: 0x00761850
		public static IUnlockEntity GetRootAsIUnlockEntity(ByteBuffer _bb, IUnlockEntity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603660B RID: 222731 RVA: 0x0076366D File Offset: 0x0076186D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603660C RID: 222732 RVA: 0x0076367C File Offset: 0x0076187C
		public IUnlockEntity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0603660D RID: 222733 RVA: 0x0076368C File Offset: 0x0076188C
		public int EntityIds(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700E2FC RID: 58108
		// (get) Token: 0x0603660E RID: 222734 RVA: 0x007636CC File Offset: 0x007618CC
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

		// Token: 0x0603660F RID: 222735 RVA: 0x007636F7 File Offset: 0x007618F7
		public Span<int> GetEntityIdsBytes()
		{
			return this.__p.__vector_as_span<int>(4, 4);
		}

		// Token: 0x06036610 RID: 222736 RVA: 0x00763706 File Offset: 0x00761906
		public int[] GetEntityIdsArray()
		{
			return this.__p.__vector_as_array<int>(4);
		}

		// Token: 0x06036611 RID: 222737 RVA: 0x00763714 File Offset: 0x00761914
		public static Offset<IUnlockEntity> CreateIUnlockEntity(FlatBufferBuilder builder, VectorOffset EntityIdsOffset = default(VectorOffset))
		{
			builder.StartTable(1);
			IUnlockEntity.AddEntityIds(builder, EntityIdsOffset);
			return IUnlockEntity.EndIUnlockEntity(builder);
		}

		// Token: 0x06036612 RID: 222738 RVA: 0x0076372A File Offset: 0x0076192A
		public static void StartIUnlockEntity(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06036613 RID: 222739 RVA: 0x00763733 File Offset: 0x00761933
		public static void AddEntityIds(FlatBufferBuilder builder, VectorOffset entityIdsOffset)
		{
			builder.AddOffset(0, entityIdsOffset.Value, 0);
		}

		// Token: 0x06036614 RID: 222740 RVA: 0x00763744 File Offset: 0x00761944
		public static VectorOffset CreateEntityIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06036615 RID: 222741 RVA: 0x0076377B File Offset: 0x0076197B
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06036616 RID: 222742 RVA: 0x00763795 File Offset: 0x00761995
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06036617 RID: 222743 RVA: 0x007637B3 File Offset: 0x007619B3
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06036618 RID: 222744 RVA: 0x007637CC File Offset: 0x007619CC
		public static void StartEntityIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06036619 RID: 222745 RVA: 0x007637D7 File Offset: 0x007619D7
		public static Offset<IUnlockEntity> EndIUnlockEntity(FlatBufferBuilder builder)
		{
			return new Offset<IUnlockEntity>(builder.EndTable());
		}

		// Token: 0x0603661A RID: 222746 RVA: 0x007637E4 File Offset: 0x007619E4
		public IUnlockEntityT UnPack()
		{
			IUnlockEntityT unlockEntityT = new IUnlockEntityT();
			this.UnPackTo(unlockEntityT);
			return unlockEntityT;
		}

		// Token: 0x0603661B RID: 222747 RVA: 0x00763800 File Offset: 0x00761A00
		public void UnPackTo(IUnlockEntityT _o)
		{
			_o.EntityIds = new List<int>();
			for (int i = 0; i < this.EntityIdsLength; i++)
			{
				_o.EntityIds.Add(this.EntityIds(i));
			}
		}

		// Token: 0x0603661C RID: 222748 RVA: 0x0076383C File Offset: 0x00761A3C
		public static Offset<IUnlockEntity> Pack(FlatBufferBuilder builder, IUnlockEntityT _o)
		{
			if (_o == null)
			{
				return default(Offset<IUnlockEntity>);
			}
			VectorOffset entityIdsOffset = default(VectorOffset);
			if (_o.EntityIds != null)
			{
				int[] data = _o.EntityIds.ToArray();
				entityIdsOffset = IUnlockEntity.CreateEntityIdsVector(builder, data);
			}
			return IUnlockEntity.CreateIUnlockEntity(builder, entityIdsOffset);
		}

		// Token: 0x040123A1 RID: 74657
		private Table __p;
	}
}
