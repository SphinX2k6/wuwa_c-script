using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Actor;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005814 RID: 22548
	public struct IRefactorActorRef2Entities : IFlatbufferObject
	{
		// Token: 0x1700A86D RID: 43117
		// (get) Token: 0x06025E83 RID: 155267 RVA: 0x0053A276 File Offset: 0x00538476
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06025E84 RID: 155268 RVA: 0x0053A283 File Offset: 0x00538483
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06025E85 RID: 155269 RVA: 0x0053A28C File Offset: 0x0053848C
		public static IRefactorActorRef2Entities GetRootAsIRefactorActorRef2Entities(ByteBuffer _bb)
		{
			return IRefactorActorRef2Entities.GetRootAsIRefactorActorRef2Entities(_bb, default(IRefactorActorRef2Entities));
		}

		// Token: 0x06025E86 RID: 155270 RVA: 0x0053A2A8 File Offset: 0x005384A8
		public static IRefactorActorRef2Entities GetRootAsIRefactorActorRef2Entities(ByteBuffer _bb, IRefactorActorRef2Entities obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06025E87 RID: 155271 RVA: 0x0053A2C5 File Offset: 0x005384C5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06025E88 RID: 155272 RVA: 0x0053A2D4 File Offset: 0x005384D4
		public IRefactorActorRef2Entities __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x06025E89 RID: 155273 RVA: 0x0053A2E4 File Offset: 0x005384E4
		public IActorRef? Actors(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			return new IActorRef?(default(IActorRef).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A86E RID: 43118
		// (get) Token: 0x06025E8A RID: 155274 RVA: 0x0053A344 File Offset: 0x00538544
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

		// Token: 0x06025E8B RID: 155275 RVA: 0x0053A370 File Offset: 0x00538570
		public int EntityIds(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700A86F RID: 43119
		// (get) Token: 0x06025E8C RID: 155276 RVA: 0x0053A3B0 File Offset: 0x005385B0
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

		// Token: 0x06025E8D RID: 155277 RVA: 0x0053A3DB File Offset: 0x005385DB
		public Span<int> GetEntityIdsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x06025E8E RID: 155278 RVA: 0x0053A3EA File Offset: 0x005385EA
		public int[] GetEntityIdsArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x06025E8F RID: 155279 RVA: 0x0053A3F8 File Offset: 0x005385F8
		public static Offset<IRefactorActorRef2Entities> CreateIRefactorActorRef2Entities(FlatBufferBuilder builder, VectorOffset ActorsOffset = default(VectorOffset), VectorOffset EntityIdsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IRefactorActorRef2Entities.AddEntityIds(builder, EntityIdsOffset);
			IRefactorActorRef2Entities.AddActors(builder, ActorsOffset);
			return IRefactorActorRef2Entities.EndIRefactorActorRef2Entities(builder);
		}

		// Token: 0x06025E90 RID: 155280 RVA: 0x0053A415 File Offset: 0x00538615
		public static void StartIRefactorActorRef2Entities(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06025E91 RID: 155281 RVA: 0x0053A41E File Offset: 0x0053861E
		public static void AddActors(FlatBufferBuilder builder, VectorOffset actorsOffset)
		{
			builder.AddOffset(0, actorsOffset.Value, 0);
		}

		// Token: 0x06025E92 RID: 155282 RVA: 0x0053A430 File Offset: 0x00538630
		public static VectorOffset CreateActorsVector(FlatBufferBuilder builder, Offset<IActorRef>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06025E93 RID: 155283 RVA: 0x0053A470 File Offset: 0x00538670
		public static VectorOffset CreateActorsVectorBlock(FlatBufferBuilder builder, Offset<IActorRef>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActorRef>>(data);
			return builder.EndVector();
		}

		// Token: 0x06025E94 RID: 155284 RVA: 0x0053A48A File Offset: 0x0053868A
		public static VectorOffset CreateActorsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActorRef>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActorRef>>(data);
			return builder.EndVector();
		}

		// Token: 0x06025E95 RID: 155285 RVA: 0x0053A4A8 File Offset: 0x005386A8
		public static VectorOffset CreateActorsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActorRef>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06025E96 RID: 155286 RVA: 0x0053A4C1 File Offset: 0x005386C1
		public static void StartActorsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06025E97 RID: 155287 RVA: 0x0053A4CC File Offset: 0x005386CC
		public static void AddEntityIds(FlatBufferBuilder builder, VectorOffset entityIdsOffset)
		{
			builder.AddOffset(1, entityIdsOffset.Value, 0);
		}

		// Token: 0x06025E98 RID: 155288 RVA: 0x0053A4DC File Offset: 0x005386DC
		public static VectorOffset CreateEntityIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06025E99 RID: 155289 RVA: 0x0053A513 File Offset: 0x00538713
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06025E9A RID: 155290 RVA: 0x0053A52D File Offset: 0x0053872D
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06025E9B RID: 155291 RVA: 0x0053A54B File Offset: 0x0053874B
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06025E9C RID: 155292 RVA: 0x0053A564 File Offset: 0x00538764
		public static void StartEntityIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06025E9D RID: 155293 RVA: 0x0053A56F File Offset: 0x0053876F
		public static Offset<IRefactorActorRef2Entities> EndIRefactorActorRef2Entities(FlatBufferBuilder builder)
		{
			return new Offset<IRefactorActorRef2Entities>(builder.EndTable());
		}

		// Token: 0x06025E9E RID: 155294 RVA: 0x0053A57C File Offset: 0x0053877C
		public IRefactorActorRef2EntitiesT UnPack()
		{
			IRefactorActorRef2EntitiesT refactorActorRef2EntitiesT = new IRefactorActorRef2EntitiesT();
			this.UnPackTo(refactorActorRef2EntitiesT);
			return refactorActorRef2EntitiesT;
		}

		// Token: 0x06025E9F RID: 155295 RVA: 0x0053A598 File Offset: 0x00538798
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

		// Token: 0x06025EA0 RID: 155296 RVA: 0x0053A628 File Offset: 0x00538828
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

		// Token: 0x0400ED16 RID: 60694
		private Table __p;
	}
}
