using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004853 RID: 18515
	public struct IDisableEntities : IFlatbufferObject
	{
		// Token: 0x170084F8 RID: 34040
		// (get) Token: 0x0601CA88 RID: 117384 RVA: 0x0040D32F File Offset: 0x0040B52F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601CA89 RID: 117385 RVA: 0x0040D33C File Offset: 0x0040B53C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601CA8A RID: 117386 RVA: 0x0040D344 File Offset: 0x0040B544
		public static IDisableEntities GetRootAsIDisableEntities(ByteBuffer _bb)
		{
			return IDisableEntities.GetRootAsIDisableEntities(_bb, default(IDisableEntities));
		}

		// Token: 0x0601CA8B RID: 117387 RVA: 0x0040D360 File Offset: 0x0040B560
		public static IDisableEntities GetRootAsIDisableEntities(ByteBuffer _bb, IDisableEntities obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601CA8C RID: 117388 RVA: 0x0040D37D File Offset: 0x0040B57D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601CA8D RID: 117389 RVA: 0x0040D38C File Offset: 0x0040B58C
		public IDisableEntities __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170084F9 RID: 34041
		// (get) Token: 0x0601CA8E RID: 117390 RVA: 0x0040D39C File Offset: 0x0040B59C
		public bool IsDisabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0601CA8F RID: 117391 RVA: 0x0040D3DC File Offset: 0x0040B5DC
		public int EntityIds(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170084FA RID: 34042
		// (get) Token: 0x0601CA90 RID: 117392 RVA: 0x0040D41C File Offset: 0x0040B61C
		public int EntityIdsLength
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

		// Token: 0x0601CA91 RID: 117393 RVA: 0x0040D447 File Offset: 0x0040B647
		public Span<int> GetEntityIdsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0601CA92 RID: 117394 RVA: 0x0040D456 File Offset: 0x0040B656
		public int[] GetEntityIdsArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x0601CA93 RID: 117395 RVA: 0x0040D464 File Offset: 0x0040B664
		public static Offset<IDisableEntities> CreateIDisableEntities(FlatBufferBuilder builder, bool IsDisabled = false, VectorOffset EntityIdsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IDisableEntities.AddEntityIds(builder, EntityIdsOffset);
			IDisableEntities.AddIsDisabled(builder, IsDisabled);
			return IDisableEntities.EndIDisableEntities(builder);
		}

		// Token: 0x0601CA94 RID: 117396 RVA: 0x0040D481 File Offset: 0x0040B681
		public static void StartIDisableEntities(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601CA95 RID: 117397 RVA: 0x0040D48A File Offset: 0x0040B68A
		public static void AddIsDisabled(FlatBufferBuilder builder, bool isDisabled)
		{
			builder.AddBool(0, isDisabled, false);
		}

		// Token: 0x0601CA96 RID: 117398 RVA: 0x0040D495 File Offset: 0x0040B695
		public static void AddEntityIds(FlatBufferBuilder builder, VectorOffset entityIdsOffset)
		{
			builder.AddOffset(1, entityIdsOffset.Value, 0);
		}

		// Token: 0x0601CA97 RID: 117399 RVA: 0x0040D4A8 File Offset: 0x0040B6A8
		public static VectorOffset CreateEntityIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601CA98 RID: 117400 RVA: 0x0040D4DF File Offset: 0x0040B6DF
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601CA99 RID: 117401 RVA: 0x0040D4F9 File Offset: 0x0040B6F9
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601CA9A RID: 117402 RVA: 0x0040D517 File Offset: 0x0040B717
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601CA9B RID: 117403 RVA: 0x0040D530 File Offset: 0x0040B730
		public static void StartEntityIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601CA9C RID: 117404 RVA: 0x0040D53B File Offset: 0x0040B73B
		public static Offset<IDisableEntities> EndIDisableEntities(FlatBufferBuilder builder)
		{
			return new Offset<IDisableEntities>(builder.EndTable());
		}

		// Token: 0x0601CA9D RID: 117405 RVA: 0x0040D548 File Offset: 0x0040B748
		public IDisableEntitiesT UnPack()
		{
			IDisableEntitiesT disableEntitiesT = new IDisableEntitiesT();
			this.UnPackTo(disableEntitiesT);
			return disableEntitiesT;
		}

		// Token: 0x0601CA9E RID: 117406 RVA: 0x0040D564 File Offset: 0x0040B764
		public void UnPackTo(IDisableEntitiesT _o)
		{
			_o.IsDisabled = this.IsDisabled;
			_o.EntityIds = new List<int>();
			for (int i = 0; i < this.EntityIdsLength; i++)
			{
				_o.EntityIds.Add(this.EntityIds(i));
			}
		}

		// Token: 0x0601CA9F RID: 117407 RVA: 0x0040D5AC File Offset: 0x0040B7AC
		public static Offset<IDisableEntities> Pack(FlatBufferBuilder builder, IDisableEntitiesT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDisableEntities>);
			}
			VectorOffset entityIdsOffset = default(VectorOffset);
			if (_o.EntityIds != null)
			{
				int[] data = _o.EntityIds.ToArray();
				entityIdsOffset = IDisableEntities.CreateEntityIdsVector(builder, data);
			}
			return IDisableEntities.CreateIDisableEntities(builder, _o.IsDisabled, entityIdsOffset);
		}

		// Token: 0x0400CD8E RID: 52622
		private Table __p;
	}
}
