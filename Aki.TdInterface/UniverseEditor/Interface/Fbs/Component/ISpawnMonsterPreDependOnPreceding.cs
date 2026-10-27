using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200595F RID: 22879
	public struct ISpawnMonsterPreDependOnPreceding : IFlatbufferObject
	{
		// Token: 0x1700ABBA RID: 43962
		// (get) Token: 0x06026B99 RID: 158617 RVA: 0x005550FA File Offset: 0x005532FA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06026B9A RID: 158618 RVA: 0x00555107 File Offset: 0x00553307
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06026B9B RID: 158619 RVA: 0x00555110 File Offset: 0x00553310
		public static ISpawnMonsterPreDependOnPreceding GetRootAsISpawnMonsterPreDependOnPreceding(ByteBuffer _bb)
		{
			return ISpawnMonsterPreDependOnPreceding.GetRootAsISpawnMonsterPreDependOnPreceding(_bb, default(ISpawnMonsterPreDependOnPreceding));
		}

		// Token: 0x06026B9C RID: 158620 RVA: 0x0055512C File Offset: 0x0055332C
		public static ISpawnMonsterPreDependOnPreceding GetRootAsISpawnMonsterPreDependOnPreceding(ByteBuffer _bb, ISpawnMonsterPreDependOnPreceding obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06026B9D RID: 158621 RVA: 0x00555149 File Offset: 0x00553349
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06026B9E RID: 158622 RVA: 0x00555158 File Offset: 0x00553358
		public ISpawnMonsterPreDependOnPreceding __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700ABBB RID: 43963
		// (get) Token: 0x06026B9F RID: 158623 RVA: 0x00555168 File Offset: 0x00553368
		public ESpawnMonsterPreCondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESpawnMonsterPreCondition.DependOnPreceding;
				}
				return (ESpawnMonsterPreCondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06026BA0 RID: 158624 RVA: 0x005551A4 File Offset: 0x005533A4
		public int Ids(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700ABBC RID: 43964
		// (get) Token: 0x06026BA1 RID: 158625 RVA: 0x005551E4 File Offset: 0x005533E4
		public int IdsLength
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

		// Token: 0x06026BA2 RID: 158626 RVA: 0x0055520F File Offset: 0x0055340F
		public Span<int> GetIdsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x06026BA3 RID: 158627 RVA: 0x0055521E File Offset: 0x0055341E
		public int[] GetIdsArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x06026BA4 RID: 158628 RVA: 0x0055522C File Offset: 0x0055342C
		public static Offset<ISpawnMonsterPreDependOnPreceding> CreateISpawnMonsterPreDependOnPreceding(FlatBufferBuilder builder, ESpawnMonsterPreCondition Type = ESpawnMonsterPreCondition.DependOnPreceding, VectorOffset IdsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			ISpawnMonsterPreDependOnPreceding.AddIds(builder, IdsOffset);
			ISpawnMonsterPreDependOnPreceding.AddType(builder, Type);
			return ISpawnMonsterPreDependOnPreceding.EndISpawnMonsterPreDependOnPreceding(builder);
		}

		// Token: 0x06026BA5 RID: 158629 RVA: 0x00555249 File Offset: 0x00553449
		public static void StartISpawnMonsterPreDependOnPreceding(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06026BA6 RID: 158630 RVA: 0x00555252 File Offset: 0x00553452
		public static void AddType(FlatBufferBuilder builder, ESpawnMonsterPreCondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06026BA7 RID: 158631 RVA: 0x0055525D File Offset: 0x0055345D
		public static void AddIds(FlatBufferBuilder builder, VectorOffset idsOffset)
		{
			builder.AddOffset(1, idsOffset.Value, 0);
		}

		// Token: 0x06026BA8 RID: 158632 RVA: 0x00555270 File Offset: 0x00553470
		public static VectorOffset CreateIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06026BA9 RID: 158633 RVA: 0x005552A7 File Offset: 0x005534A7
		public static VectorOffset CreateIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06026BAA RID: 158634 RVA: 0x005552C1 File Offset: 0x005534C1
		public static VectorOffset CreateIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06026BAB RID: 158635 RVA: 0x005552DF File Offset: 0x005534DF
		public static VectorOffset CreateIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06026BAC RID: 158636 RVA: 0x005552F8 File Offset: 0x005534F8
		public static void StartIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06026BAD RID: 158637 RVA: 0x00555303 File Offset: 0x00553503
		public static Offset<ISpawnMonsterPreDependOnPreceding> EndISpawnMonsterPreDependOnPreceding(FlatBufferBuilder builder)
		{
			return new Offset<ISpawnMonsterPreDependOnPreceding>(builder.EndTable());
		}

		// Token: 0x06026BAE RID: 158638 RVA: 0x00555310 File Offset: 0x00553510
		public ISpawnMonsterPreDependOnPrecedingT UnPack()
		{
			ISpawnMonsterPreDependOnPrecedingT spawnMonsterPreDependOnPrecedingT = new ISpawnMonsterPreDependOnPrecedingT();
			this.UnPackTo(spawnMonsterPreDependOnPrecedingT);
			return spawnMonsterPreDependOnPrecedingT;
		}

		// Token: 0x06026BAF RID: 158639 RVA: 0x0055532C File Offset: 0x0055352C
		public void UnPackTo(ISpawnMonsterPreDependOnPrecedingT _o)
		{
			_o.Type = this.Type;
			_o.Ids = new List<int>();
			for (int i = 0; i < this.IdsLength; i++)
			{
				_o.Ids.Add(this.Ids(i));
			}
		}

		// Token: 0x06026BB0 RID: 158640 RVA: 0x00555374 File Offset: 0x00553574
		public static Offset<ISpawnMonsterPreDependOnPreceding> Pack(FlatBufferBuilder builder, ISpawnMonsterPreDependOnPrecedingT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISpawnMonsterPreDependOnPreceding>);
			}
			VectorOffset idsOffset = default(VectorOffset);
			if (_o.Ids != null)
			{
				int[] data = _o.Ids.ToArray();
				idsOffset = ISpawnMonsterPreDependOnPreceding.CreateIdsVector(builder, data);
			}
			return ISpawnMonsterPreDependOnPreceding.CreateISpawnMonsterPreDependOnPreceding(builder, _o.Type, idsOffset);
		}

		// Token: 0x0400EF43 RID: 61251
		private Table __p;
	}
}
