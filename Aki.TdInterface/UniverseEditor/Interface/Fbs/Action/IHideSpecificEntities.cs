using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006FAD RID: 28589
	public struct IHideSpecificEntities : IFlatbufferObject
	{
		// Token: 0x1700D161 RID: 53601
		// (get) Token: 0x060317E5 RID: 202725 RVA: 0x006B562E File Offset: 0x006B382E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060317E6 RID: 202726 RVA: 0x006B563B File Offset: 0x006B383B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060317E7 RID: 202727 RVA: 0x006B5644 File Offset: 0x006B3844
		public static IHideSpecificEntities GetRootAsIHideSpecificEntities(ByteBuffer _bb)
		{
			return IHideSpecificEntities.GetRootAsIHideSpecificEntities(_bb, default(IHideSpecificEntities));
		}

		// Token: 0x060317E8 RID: 202728 RVA: 0x006B5660 File Offset: 0x006B3860
		public static IHideSpecificEntities GetRootAsIHideSpecificEntities(ByteBuffer _bb, IHideSpecificEntities obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060317E9 RID: 202729 RVA: 0x006B567D File Offset: 0x006B387D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060317EA RID: 202730 RVA: 0x006B568C File Offset: 0x006B388C
		public IHideSpecificEntities __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x060317EB RID: 202731 RVA: 0x006B569C File Offset: 0x006B389C
		public int EntityIds(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700D162 RID: 53602
		// (get) Token: 0x060317EC RID: 202732 RVA: 0x006B56DC File Offset: 0x006B38DC
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

		// Token: 0x060317ED RID: 202733 RVA: 0x006B5707 File Offset: 0x006B3907
		public Span<int> GetEntityIdsBytes()
		{
			return this.__p.__vector_as_span<int>(4, 4);
		}

		// Token: 0x060317EE RID: 202734 RVA: 0x006B5716 File Offset: 0x006B3916
		public int[] GetEntityIdsArray()
		{
			return this.__p.__vector_as_array<int>(4);
		}

		// Token: 0x060317EF RID: 202735 RVA: 0x006B5724 File Offset: 0x006B3924
		public static Offset<IHideSpecificEntities> CreateIHideSpecificEntities(FlatBufferBuilder builder, VectorOffset EntityIdsOffset = default(VectorOffset))
		{
			builder.StartTable(1);
			IHideSpecificEntities.AddEntityIds(builder, EntityIdsOffset);
			return IHideSpecificEntities.EndIHideSpecificEntities(builder);
		}

		// Token: 0x060317F0 RID: 202736 RVA: 0x006B573A File Offset: 0x006B393A
		public static void StartIHideSpecificEntities(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060317F1 RID: 202737 RVA: 0x006B5743 File Offset: 0x006B3943
		public static void AddEntityIds(FlatBufferBuilder builder, VectorOffset entityIdsOffset)
		{
			builder.AddOffset(0, entityIdsOffset.Value, 0);
		}

		// Token: 0x060317F2 RID: 202738 RVA: 0x006B5754 File Offset: 0x006B3954
		public static VectorOffset CreateEntityIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x060317F3 RID: 202739 RVA: 0x006B578B File Offset: 0x006B398B
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060317F4 RID: 202740 RVA: 0x006B57A5 File Offset: 0x006B39A5
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060317F5 RID: 202741 RVA: 0x006B57C3 File Offset: 0x006B39C3
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060317F6 RID: 202742 RVA: 0x006B57DC File Offset: 0x006B39DC
		public static void StartEntityIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060317F7 RID: 202743 RVA: 0x006B57E7 File Offset: 0x006B39E7
		public static Offset<IHideSpecificEntities> EndIHideSpecificEntities(FlatBufferBuilder builder)
		{
			return new Offset<IHideSpecificEntities>(builder.EndTable());
		}

		// Token: 0x060317F8 RID: 202744 RVA: 0x006B57F4 File Offset: 0x006B39F4
		public IHideSpecificEntitiesT UnPack()
		{
			IHideSpecificEntitiesT hideSpecificEntitiesT = new IHideSpecificEntitiesT();
			this.UnPackTo(hideSpecificEntitiesT);
			return hideSpecificEntitiesT;
		}

		// Token: 0x060317F9 RID: 202745 RVA: 0x006B5810 File Offset: 0x006B3A10
		public void UnPackTo(IHideSpecificEntitiesT _o)
		{
			_o.EntityIds = new List<int>();
			for (int i = 0; i < this.EntityIdsLength; i++)
			{
				_o.EntityIds.Add(this.EntityIds(i));
			}
		}

		// Token: 0x060317FA RID: 202746 RVA: 0x006B584C File Offset: 0x006B3A4C
		public static Offset<IHideSpecificEntities> Pack(FlatBufferBuilder builder, IHideSpecificEntitiesT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHideSpecificEntities>);
			}
			VectorOffset entityIdsOffset = default(VectorOffset);
			if (_o.EntityIds != null)
			{
				int[] data = _o.EntityIds.ToArray();
				entityIdsOffset = IHideSpecificEntities.CreateEntityIdsVector(builder, data);
			}
			return IHideSpecificEntities.CreateIHideSpecificEntities(builder, entityIdsOffset);
		}

		// Token: 0x04011EDA RID: 73434
		private Table __p;
	}
}
