using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.ShowTimeline
{
	// Token: 0x02003FCD RID: 16333
	public struct IShowTimelineMonsterState : IFlatbufferObject
	{
		// Token: 0x17006E96 RID: 28310
		// (get) Token: 0x060164F1 RID: 91377 RVA: 0x00332305 File Offset: 0x00330505
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060164F2 RID: 91378 RVA: 0x00332312 File Offset: 0x00330512
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060164F3 RID: 91379 RVA: 0x0033231C File Offset: 0x0033051C
		public static IShowTimelineMonsterState GetRootAsIShowTimelineMonsterState(ByteBuffer _bb)
		{
			return IShowTimelineMonsterState.GetRootAsIShowTimelineMonsterState(_bb, default(IShowTimelineMonsterState));
		}

		// Token: 0x060164F4 RID: 91380 RVA: 0x00332338 File Offset: 0x00330538
		public static IShowTimelineMonsterState GetRootAsIShowTimelineMonsterState(ByteBuffer _bb, IShowTimelineMonsterState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060164F5 RID: 91381 RVA: 0x00332355 File Offset: 0x00330555
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060164F6 RID: 91382 RVA: 0x00332364 File Offset: 0x00330564
		public IShowTimelineMonsterState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006E97 RID: 28311
		// (get) Token: 0x060164F7 RID: 91383 RVA: 0x00332374 File Offset: 0x00330574
		public int MonsterEntityId
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17006E98 RID: 28312
		// (get) Token: 0x060164F8 RID: 91384 RVA: 0x003323B0 File Offset: 0x003305B0
		public ITransform? Transform
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new ITransform?(default(ITransform).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x060164F9 RID: 91385 RVA: 0x00332410 File Offset: 0x00330610
		public int Attributes(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17006E99 RID: 28313
		// (get) Token: 0x060164FA RID: 91386 RVA: 0x00332450 File Offset: 0x00330650
		public int AttributesLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060164FB RID: 91387 RVA: 0x0033247B File Offset: 0x0033067B
		public Span<int> GetAttributesBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x060164FC RID: 91388 RVA: 0x0033248A File Offset: 0x0033068A
		public int[] GetAttributesArray()
		{
			return this.__p.__vector_as_array<int>(8);
		}

		// Token: 0x060164FD RID: 91389 RVA: 0x00332498 File Offset: 0x00330698
		public int Buffs(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17006E9A RID: 28314
		// (get) Token: 0x060164FE RID: 91390 RVA: 0x003324D8 File Offset: 0x003306D8
		public int BuffsLength
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060164FF RID: 91391 RVA: 0x00332504 File Offset: 0x00330704
		public Span<int> GetBuffsBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x06016500 RID: 91392 RVA: 0x00332514 File Offset: 0x00330714
		public int[] GetBuffsArray()
		{
			return this.__p.__vector_as_array<int>(10);
		}

		// Token: 0x06016501 RID: 91393 RVA: 0x00332524 File Offset: 0x00330724
		public long BuffIds(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0L;
			}
			return this.__p.bb.GetLong(this.__p.__vector(num) + j * 8);
		}

		// Token: 0x17006E9B RID: 28315
		// (get) Token: 0x06016502 RID: 91394 RVA: 0x00332568 File Offset: 0x00330768
		public int BuffIdsLength
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06016503 RID: 91395 RVA: 0x00332594 File Offset: 0x00330794
		public Span<long> GetBuffIdsBytes()
		{
			return this.__p.__vector_as_span<long>(12, 8);
		}

		// Token: 0x06016504 RID: 91396 RVA: 0x003325A4 File Offset: 0x003307A4
		public long[] GetBuffIdsArray()
		{
			return this.__p.__vector_as_array<long>(12);
		}

		// Token: 0x06016505 RID: 91397 RVA: 0x003325B4 File Offset: 0x003307B4
		public string Tags(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17006E9C RID: 28316
		// (get) Token: 0x06016506 RID: 91398 RVA: 0x003325F0 File Offset: 0x003307F0
		public int TagsLength
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06016507 RID: 91399 RVA: 0x0033261C File Offset: 0x0033081C
		public static Offset<IShowTimelineMonsterState> CreateIShowTimelineMonsterState(FlatBufferBuilder builder, int MonsterEntityId = 0, Offset<ITransform> TransformOffset = default(Offset<ITransform>), VectorOffset AttributesOffset = default(VectorOffset), VectorOffset BuffsOffset = default(VectorOffset), VectorOffset BuffIdsOffset = default(VectorOffset), VectorOffset TagsOffset = default(VectorOffset))
		{
			builder.StartTable(6);
			IShowTimelineMonsterState.AddTags(builder, TagsOffset);
			IShowTimelineMonsterState.AddBuffIds(builder, BuffIdsOffset);
			IShowTimelineMonsterState.AddBuffs(builder, BuffsOffset);
			IShowTimelineMonsterState.AddAttributes(builder, AttributesOffset);
			IShowTimelineMonsterState.AddTransform(builder, TransformOffset);
			IShowTimelineMonsterState.AddMonsterEntityId(builder, MonsterEntityId);
			return IShowTimelineMonsterState.EndIShowTimelineMonsterState(builder);
		}

		// Token: 0x06016508 RID: 91400 RVA: 0x00332658 File Offset: 0x00330858
		public static void StartIShowTimelineMonsterState(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x06016509 RID: 91401 RVA: 0x00332661 File Offset: 0x00330861
		public static void AddMonsterEntityId(FlatBufferBuilder builder, int monsterEntityId)
		{
			builder.AddInt(0, monsterEntityId, 0);
		}

		// Token: 0x0601650A RID: 91402 RVA: 0x0033266C File Offset: 0x0033086C
		public static void AddTransform(FlatBufferBuilder builder, Offset<ITransform> transformOffset)
		{
			builder.AddOffset(1, transformOffset.Value, 0);
		}

		// Token: 0x0601650B RID: 91403 RVA: 0x0033267C File Offset: 0x0033087C
		public static void AddAttributes(FlatBufferBuilder builder, VectorOffset attributesOffset)
		{
			builder.AddOffset(2, attributesOffset.Value, 0);
		}

		// Token: 0x0601650C RID: 91404 RVA: 0x0033268C File Offset: 0x0033088C
		public static VectorOffset CreateAttributesVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601650D RID: 91405 RVA: 0x003326C3 File Offset: 0x003308C3
		public static VectorOffset CreateAttributesVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601650E RID: 91406 RVA: 0x003326DD File Offset: 0x003308DD
		public static VectorOffset CreateAttributesVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601650F RID: 91407 RVA: 0x003326FB File Offset: 0x003308FB
		public static VectorOffset CreateAttributesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06016510 RID: 91408 RVA: 0x00332714 File Offset: 0x00330914
		public static void StartAttributesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06016511 RID: 91409 RVA: 0x0033271F File Offset: 0x0033091F
		public static void AddBuffs(FlatBufferBuilder builder, VectorOffset buffsOffset)
		{
			builder.AddOffset(3, buffsOffset.Value, 0);
		}

		// Token: 0x06016512 RID: 91410 RVA: 0x00332730 File Offset: 0x00330930
		public static VectorOffset CreateBuffsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06016513 RID: 91411 RVA: 0x00332767 File Offset: 0x00330967
		public static VectorOffset CreateBuffsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06016514 RID: 91412 RVA: 0x00332781 File Offset: 0x00330981
		public static VectorOffset CreateBuffsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06016515 RID: 91413 RVA: 0x0033279F File Offset: 0x0033099F
		public static VectorOffset CreateBuffsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06016516 RID: 91414 RVA: 0x003327B8 File Offset: 0x003309B8
		public static void StartBuffsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06016517 RID: 91415 RVA: 0x003327C3 File Offset: 0x003309C3
		public static void AddBuffIds(FlatBufferBuilder builder, VectorOffset buffIdsOffset)
		{
			builder.AddOffset(4, buffIdsOffset.Value, 0);
		}

		// Token: 0x06016518 RID: 91416 RVA: 0x003327D4 File Offset: 0x003309D4
		public static VectorOffset CreateBuffIdsVector(FlatBufferBuilder builder, long[] data)
		{
			builder.StartVector(8, data.Length, 8);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddLong(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06016519 RID: 91417 RVA: 0x0033280B File Offset: 0x00330A0B
		public static VectorOffset CreateBuffIdsVectorBlock(FlatBufferBuilder builder, long[] data)
		{
			builder.StartVector(8, data.Length, 8);
			builder.Add<long>(data);
			return builder.EndVector();
		}

		// Token: 0x0601651A RID: 91418 RVA: 0x00332825 File Offset: 0x00330A25
		public static VectorOffset CreateBuffIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data)
		{
			builder.StartVector(8, data.Count, 8);
			builder.Add<long>(data);
			return builder.EndVector();
		}

		// Token: 0x0601651B RID: 91419 RVA: 0x00332843 File Offset: 0x00330A43
		public static VectorOffset CreateBuffIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<long>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601651C RID: 91420 RVA: 0x0033285C File Offset: 0x00330A5C
		public static void StartBuffIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(8, numElems, 8);
		}

		// Token: 0x0601651D RID: 91421 RVA: 0x00332867 File Offset: 0x00330A67
		public static void AddTags(FlatBufferBuilder builder, VectorOffset tagsOffset)
		{
			builder.AddOffset(5, tagsOffset.Value, 0);
		}

		// Token: 0x0601651E RID: 91422 RVA: 0x00332878 File Offset: 0x00330A78
		public static VectorOffset CreateTagsVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601651F RID: 91423 RVA: 0x003328B8 File Offset: 0x00330AB8
		public static VectorOffset CreateTagsVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x06016520 RID: 91424 RVA: 0x003328D2 File Offset: 0x00330AD2
		public static VectorOffset CreateTagsVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x06016521 RID: 91425 RVA: 0x003328F0 File Offset: 0x00330AF0
		public static VectorOffset CreateTagsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06016522 RID: 91426 RVA: 0x00332909 File Offset: 0x00330B09
		public static void StartTagsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06016523 RID: 91427 RVA: 0x00332914 File Offset: 0x00330B14
		public static Offset<IShowTimelineMonsterState> EndIShowTimelineMonsterState(FlatBufferBuilder builder)
		{
			return new Offset<IShowTimelineMonsterState>(builder.EndTable());
		}

		// Token: 0x06016524 RID: 91428 RVA: 0x00332924 File Offset: 0x00330B24
		public IShowTimelineMonsterStateT UnPack()
		{
			IShowTimelineMonsterStateT showTimelineMonsterStateT = new IShowTimelineMonsterStateT();
			this.UnPackTo(showTimelineMonsterStateT);
			return showTimelineMonsterStateT;
		}

		// Token: 0x06016525 RID: 91429 RVA: 0x00332940 File Offset: 0x00330B40
		public void UnPackTo(IShowTimelineMonsterStateT _o)
		{
			_o.MonsterEntityId = this.MonsterEntityId;
			_o.Transform = ((this.Transform != null) ? this.Transform.Value.UnPack() : null);
			_o.Attributes = new List<int>();
			for (int i = 0; i < this.AttributesLength; i++)
			{
				_o.Attributes.Add(this.Attributes(i));
			}
			_o.Buffs = new List<int>();
			for (int j = 0; j < this.BuffsLength; j++)
			{
				_o.Buffs.Add(this.Buffs(j));
			}
			_o.BuffIds = new List<long>();
			for (int k = 0; k < this.BuffIdsLength; k++)
			{
				_o.BuffIds.Add(this.BuffIds(k));
			}
			_o.Tags = new List<string>();
			for (int l = 0; l < this.TagsLength; l++)
			{
				_o.Tags.Add(this.Tags(l));
			}
		}

		// Token: 0x06016526 RID: 91430 RVA: 0x00332A4C File Offset: 0x00330C4C
		public static Offset<IShowTimelineMonsterState> Pack(FlatBufferBuilder builder, IShowTimelineMonsterStateT _o)
		{
			if (_o == null)
			{
				return default(Offset<IShowTimelineMonsterState>);
			}
			Offset<ITransform> transformOffset = (_o.Transform == null) ? default(Offset<ITransform>) : ITransform.Pack(builder, _o.Transform);
			VectorOffset attributesOffset = default(VectorOffset);
			if (_o.Attributes != null)
			{
				int[] data = _o.Attributes.ToArray();
				attributesOffset = IShowTimelineMonsterState.CreateAttributesVector(builder, data);
			}
			VectorOffset buffsOffset = default(VectorOffset);
			if (_o.Buffs != null)
			{
				int[] data2 = _o.Buffs.ToArray();
				buffsOffset = IShowTimelineMonsterState.CreateBuffsVector(builder, data2);
			}
			VectorOffset buffIdsOffset = default(VectorOffset);
			if (_o.BuffIds != null)
			{
				long[] data3 = _o.BuffIds.ToArray();
				buffIdsOffset = IShowTimelineMonsterState.CreateBuffIdsVector(builder, data3);
			}
			VectorOffset tagsOffset = default(VectorOffset);
			if (_o.Tags != null)
			{
				StringOffset[] array = new StringOffset[_o.Tags.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = builder.CreateString(_o.Tags[i]);
				}
				tagsOffset = IShowTimelineMonsterState.CreateTagsVector(builder, array);
			}
			return IShowTimelineMonsterState.CreateIShowTimelineMonsterState(builder, _o.MonsterEntityId, transformOffset, attributesOffset, buffsOffset, buffIdsOffset, tagsOffset);
		}

		// Token: 0x0400BACC RID: 47820
		private Table __p;
	}
}
