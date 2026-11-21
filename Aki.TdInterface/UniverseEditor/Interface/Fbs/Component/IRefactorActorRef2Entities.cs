using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Actor;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005E1B RID: 24091
	public struct IRefactorActorRef2Entities : IFlatbufferObject
	{
		// Token: 0x1700B191 RID: 45457
		// (get) Token: 0x060283A3 RID: 164771 RVA: 0x00580402 File Offset: 0x0057E602
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060283A4 RID: 164772 RVA: 0x0058040F File Offset: 0x0057E60F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060283A5 RID: 164773 RVA: 0x00580418 File Offset: 0x0057E618
		public static IRefactorActorRef2Entities GetRootAsIRefactorActorRef2Entities(ByteBuffer _bb)
		{
			return IRefactorActorRef2Entities.GetRootAsIRefactorActorRef2Entities(_bb, default(IRefactorActorRef2Entities));
		}

		// Token: 0x060283A6 RID: 164774 RVA: 0x00580434 File Offset: 0x0057E634
		public static IRefactorActorRef2Entities GetRootAsIRefactorActorRef2Entities(ByteBuffer _bb, IRefactorActorRef2Entities obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060283A7 RID: 164775 RVA: 0x00580451 File Offset: 0x0057E651
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060283A8 RID: 164776 RVA: 0x00580460 File Offset: 0x0057E660
		public IRefactorActorRef2Entities __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x060283A9 RID: 164777 RVA: 0x00580470 File Offset: 0x0057E670
		public IActorRef? Actors(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			return new IActorRef?(default(IActorRef).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700B192 RID: 45458
		// (get) Token: 0x060283AA RID: 164778 RVA: 0x005804D0 File Offset: 0x0057E6D0
		public int ActorsLength
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

		// Token: 0x060283AB RID: 164779 RVA: 0x005804FC File Offset: 0x0057E6FC
		public int EntityIds(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700B193 RID: 45459
		// (get) Token: 0x060283AC RID: 164780 RVA: 0x0058053C File Offset: 0x0057E73C
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

		// Token: 0x060283AD RID: 164781 RVA: 0x00580567 File Offset: 0x0057E767
		public Span<int> GetEntityIdsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x060283AE RID: 164782 RVA: 0x00580576 File Offset: 0x0057E776
		public int[] GetEntityIdsArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x060283AF RID: 164783 RVA: 0x00580584 File Offset: 0x0057E784
		public static Offset<IRefactorActorRef2Entities> CreateIRefactorActorRef2Entities(FlatBufferBuilder builder, VectorOffset ActorsOffset = default(VectorOffset), VectorOffset EntityIdsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IRefactorActorRef2Entities.AddEntityIds(builder, EntityIdsOffset);
			IRefactorActorRef2Entities.AddActors(builder, ActorsOffset);
			return IRefactorActorRef2Entities.EndIRefactorActorRef2Entities(builder);
		}

		// Token: 0x060283B0 RID: 164784 RVA: 0x005805A1 File Offset: 0x0057E7A1
		public static void StartIRefactorActorRef2Entities(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060283B1 RID: 164785 RVA: 0x005805AA File Offset: 0x0057E7AA
		public static void AddActors(FlatBufferBuilder builder, VectorOffset actorsOffset)
		{
			builder.AddOffset(0, actorsOffset.Value, 0);
		}

		// Token: 0x060283B2 RID: 164786 RVA: 0x005805BC File Offset: 0x0057E7BC
		public static VectorOffset CreateActorsVector(FlatBufferBuilder builder, Offset<IActorRef>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060283B3 RID: 164787 RVA: 0x005805FC File Offset: 0x0057E7FC
		public static VectorOffset CreateActorsVectorBlock(FlatBufferBuilder builder, Offset<IActorRef>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActorRef>>(data);
			return builder.EndVector();
		}

		// Token: 0x060283B4 RID: 164788 RVA: 0x00580616 File Offset: 0x0057E816
		public static VectorOffset CreateActorsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActorRef>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActorRef>>(data);
			return builder.EndVector();
		}

		// Token: 0x060283B5 RID: 164789 RVA: 0x00580634 File Offset: 0x0057E834
		public static VectorOffset CreateActorsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActorRef>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060283B6 RID: 164790 RVA: 0x0058064D File Offset: 0x0057E84D
		public static void StartActorsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060283B7 RID: 164791 RVA: 0x00580658 File Offset: 0x0057E858
		public static void AddEntityIds(FlatBufferBuilder builder, VectorOffset entityIdsOffset)
		{
			builder.AddOffset(1, entityIdsOffset.Value, 0);
		}

		// Token: 0x060283B8 RID: 164792 RVA: 0x00580668 File Offset: 0x0057E868
		public static VectorOffset CreateEntityIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x060283B9 RID: 164793 RVA: 0x0058069F File Offset: 0x0057E89F
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060283BA RID: 164794 RVA: 0x005806B9 File Offset: 0x0057E8B9
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060283BB RID: 164795 RVA: 0x005806D7 File Offset: 0x0057E8D7
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060283BC RID: 164796 RVA: 0x005806F0 File Offset: 0x0057E8F0
		public static void StartEntityIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060283BD RID: 164797 RVA: 0x005806FB File Offset: 0x0057E8FB
		public static Offset<IRefactorActorRef2Entities> EndIRefactorActorRef2Entities(FlatBufferBuilder builder)
		{
			return new Offset<IRefactorActorRef2Entities>(builder.EndTable());
		}

		// Token: 0x060283BE RID: 164798 RVA: 0x00580708 File Offset: 0x0057E908
		public IRefactorActorRef2EntitiesT UnPack()
		{
			IRefactorActorRef2EntitiesT refactorActorRef2EntitiesT = new IRefactorActorRef2EntitiesT();
			this.UnPackTo(refactorActorRef2EntitiesT);
			return refactorActorRef2EntitiesT;
		}

		// Token: 0x060283BF RID: 164799 RVA: 0x00580724 File Offset: 0x0057E924
		public void UnPackTo(IRefactorActorRef2EntitiesT _o)
		{
			_o.Actors = new List<IActorRefT>();
			for (int i = 0; i < this.ActorsLength; i++)
			{
				_o.Actors.Add((this.Actors(i) != null) ? this.Actors(i).Value.UnPack() : null);
			}
			_o.EntityIds = new List<int>();
			for (int j = 0; j < this.EntityIdsLength; j++)
			{
				_o.EntityIds.Add(this.EntityIds(j));
			}
		}

		// Token: 0x060283C0 RID: 164800 RVA: 0x005807B4 File Offset: 0x0057E9B4
		public static Offset<IRefactorActorRef2Entities> Pack(FlatBufferBuilder builder, IRefactorActorRef2EntitiesT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRefactorActorRef2Entities>);
			}
			VectorOffset actorsOffset = default(VectorOffset);
			if (_o.Actors != null)
			{
				Offset<IActorRef>[] array = new Offset<IActorRef>[_o.Actors.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IActorRef.Pack(builder, _o.Actors[i]);
				}
				actorsOffset = IRefactorActorRef2Entities.CreateActorsVector(builder, array);
			}
			VectorOffset entityIdsOffset = default(VectorOffset);
			if (_o.EntityIds != null)
			{
				int[] data = _o.EntityIds.ToArray();
				entityIdsOffset = IRefactorActorRef2Entities.CreateEntityIdsVector(builder, data);
			}
			return IRefactorActorRef2Entities.CreateIRefactorActorRef2Entities(builder, actorsOffset, entityIdsOffset);
		}

		// Token: 0x0400FA01 RID: 64001
		private Table __p;
	}
}
