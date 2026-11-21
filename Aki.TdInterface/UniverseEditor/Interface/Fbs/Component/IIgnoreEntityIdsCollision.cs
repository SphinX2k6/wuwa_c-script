using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005969 RID: 22889
	public struct IIgnoreEntityIdsCollision : IFlatbufferObject
	{
		// Token: 0x1700A64E RID: 42574
		// (get) Token: 0x060254E5 RID: 152805 RVA: 0x0051F097 File Offset: 0x0051D297
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060254E6 RID: 152806 RVA: 0x0051F0A4 File Offset: 0x0051D2A4
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060254E7 RID: 152807 RVA: 0x0051F0AC File Offset: 0x0051D2AC
		public static IIgnoreEntityIdsCollision GetRootAsIIgnoreEntityIdsCollision(ByteBuffer _bb)
		{
			return IIgnoreEntityIdsCollision.GetRootAsIIgnoreEntityIdsCollision(_bb, default(IIgnoreEntityIdsCollision));
		}

		// Token: 0x060254E8 RID: 152808 RVA: 0x0051F0C8 File Offset: 0x0051D2C8
		public static IIgnoreEntityIdsCollision GetRootAsIIgnoreEntityIdsCollision(ByteBuffer _bb, IIgnoreEntityIdsCollision obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060254E9 RID: 152809 RVA: 0x0051F0E5 File Offset: 0x0051D2E5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060254EA RID: 152810 RVA: 0x0051F0F4 File Offset: 0x0051D2F4
		public IIgnoreEntityIdsCollision __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x060254EB RID: 152811 RVA: 0x0051F104 File Offset: 0x0051D304
		public int EntityIds(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700A64F RID: 42575
		// (get) Token: 0x060254EC RID: 152812 RVA: 0x0051F144 File Offset: 0x0051D344
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

		// Token: 0x060254ED RID: 152813 RVA: 0x0051F16F File Offset: 0x0051D36F
		public Span<int> GetEntityIdsBytes()
		{
			return this.__p.__vector_as_span<int>(4, 4);
		}

		// Token: 0x060254EE RID: 152814 RVA: 0x0051F17E File Offset: 0x0051D37E
		public int[] GetEntityIdsArray()
		{
			return this.__p.__vector_as_array<int>(4);
		}

		// Token: 0x060254EF RID: 152815 RVA: 0x0051F18C File Offset: 0x0051D38C
		public static Offset<IIgnoreEntityIdsCollision> CreateIIgnoreEntityIdsCollision(FlatBufferBuilder builder, VectorOffset EntityIdsOffset = default(VectorOffset))
		{
			builder.StartTable(1);
			IIgnoreEntityIdsCollision.AddEntityIds(builder, EntityIdsOffset);
			return IIgnoreEntityIdsCollision.EndIIgnoreEntityIdsCollision(builder);
		}

		// Token: 0x060254F0 RID: 152816 RVA: 0x0051F1A2 File Offset: 0x0051D3A2
		public static void StartIIgnoreEntityIdsCollision(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060254F1 RID: 152817 RVA: 0x0051F1AB File Offset: 0x0051D3AB
		public static void AddEntityIds(FlatBufferBuilder builder, VectorOffset entityIdsOffset)
		{
			builder.AddOffset(0, entityIdsOffset.Value, 0);
		}

		// Token: 0x060254F2 RID: 152818 RVA: 0x0051F1BC File Offset: 0x0051D3BC
		public static VectorOffset CreateEntityIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x060254F3 RID: 152819 RVA: 0x0051F1F3 File Offset: 0x0051D3F3
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060254F4 RID: 152820 RVA: 0x0051F20D File Offset: 0x0051D40D
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060254F5 RID: 152821 RVA: 0x0051F22B File Offset: 0x0051D42B
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060254F6 RID: 152822 RVA: 0x0051F244 File Offset: 0x0051D444
		public static void StartEntityIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060254F7 RID: 152823 RVA: 0x0051F24F File Offset: 0x0051D44F
		public static Offset<IIgnoreEntityIdsCollision> EndIIgnoreEntityIdsCollision(FlatBufferBuilder builder)
		{
			return new Offset<IIgnoreEntityIdsCollision>(builder.EndTable());
		}

		// Token: 0x060254F8 RID: 152824 RVA: 0x0051F25C File Offset: 0x0051D45C
		public IIgnoreEntityIdsCollisionT UnPack()
		{
			IIgnoreEntityIdsCollisionT ignoreEntityIdsCollisionT = new IIgnoreEntityIdsCollisionT();
			this.UnPackTo(ignoreEntityIdsCollisionT);
			return ignoreEntityIdsCollisionT;
		}

		// Token: 0x060254F9 RID: 152825 RVA: 0x0051F278 File Offset: 0x0051D478
		public void UnPackTo(IIgnoreEntityIdsCollisionT _o)
		{
			_o.EntityIds = new List<int>();
			for (int i = 0; i < this.EntityIdsLength; i++)
			{
				_o.EntityIds.Add(this.EntityIds(i));
			}
		}

		// Token: 0x060254FA RID: 152826 RVA: 0x0051F2B4 File Offset: 0x0051D4B4
		public static Offset<IIgnoreEntityIdsCollision> Pack(FlatBufferBuilder builder, IIgnoreEntityIdsCollisionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IIgnoreEntityIdsCollision>);
			}
			VectorOffset entityIdsOffset = default(VectorOffset);
			if (_o.EntityIds != null)
			{
				int[] data = _o.EntityIds.ToArray();
				entityIdsOffset = IIgnoreEntityIdsCollision.CreateEntityIdsVector(builder, data);
			}
			return IIgnoreEntityIdsCollision.CreateIIgnoreEntityIdsCollision(builder, entityIdsOffset);
		}

		// Token: 0x0400F257 RID: 62039
		private Table __p;
	}
}
