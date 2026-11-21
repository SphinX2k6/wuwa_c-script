using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005F6C RID: 24428
	public struct ISpawnMonsterPreDependOnPreceding : IFlatbufferObject
	{
		// Token: 0x1700B4EE RID: 46318
		// (get) Token: 0x06029103 RID: 168195 RVA: 0x0059BD66 File Offset: 0x00599F66
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06029104 RID: 168196 RVA: 0x0059BD73 File Offset: 0x00599F73
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06029105 RID: 168197 RVA: 0x0059BD7C File Offset: 0x00599F7C
		public static ISpawnMonsterPreDependOnPreceding GetRootAsISpawnMonsterPreDependOnPreceding(ByteBuffer _bb)
		{
			return ISpawnMonsterPreDependOnPreceding.GetRootAsISpawnMonsterPreDependOnPreceding(_bb, default(ISpawnMonsterPreDependOnPreceding));
		}

		// Token: 0x06029106 RID: 168198 RVA: 0x0059BD98 File Offset: 0x00599F98
		public static ISpawnMonsterPreDependOnPreceding GetRootAsISpawnMonsterPreDependOnPreceding(ByteBuffer _bb, ISpawnMonsterPreDependOnPreceding obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06029107 RID: 168199 RVA: 0x0059BDB5 File Offset: 0x00599FB5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06029108 RID: 168200 RVA: 0x0059BDC4 File Offset: 0x00599FC4
		public ISpawnMonsterPreDependOnPreceding __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B4EF RID: 46319
		// (get) Token: 0x06029109 RID: 168201 RVA: 0x0059BDD4 File Offset: 0x00599FD4
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

		// Token: 0x0602910A RID: 168202 RVA: 0x0059BE10 File Offset: 0x0059A010
		public int Ids(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700B4F0 RID: 46320
		// (get) Token: 0x0602910B RID: 168203 RVA: 0x0059BE50 File Offset: 0x0059A050
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

		// Token: 0x0602910C RID: 168204 RVA: 0x0059BE7B File Offset: 0x0059A07B
		public Span<int> GetIdsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0602910D RID: 168205 RVA: 0x0059BE8A File Offset: 0x0059A08A
		public int[] GetIdsArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x0602910E RID: 168206 RVA: 0x0059BE98 File Offset: 0x0059A098
		public static Offset<ISpawnMonsterPreDependOnPreceding> CreateISpawnMonsterPreDependOnPreceding(FlatBufferBuilder builder, ESpawnMonsterPreCondition Type = ESpawnMonsterPreCondition.DependOnPreceding, VectorOffset IdsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			ISpawnMonsterPreDependOnPreceding.AddIds(builder, IdsOffset);
			ISpawnMonsterPreDependOnPreceding.AddType(builder, Type);
			return ISpawnMonsterPreDependOnPreceding.EndISpawnMonsterPreDependOnPreceding(builder);
		}

		// Token: 0x0602910F RID: 168207 RVA: 0x0059BEB5 File Offset: 0x0059A0B5
		public static void StartISpawnMonsterPreDependOnPreceding(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06029110 RID: 168208 RVA: 0x0059BEBE File Offset: 0x0059A0BE
		public static void AddType(FlatBufferBuilder builder, ESpawnMonsterPreCondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06029111 RID: 168209 RVA: 0x0059BEC9 File Offset: 0x0059A0C9
		public static void AddIds(FlatBufferBuilder builder, VectorOffset idsOffset)
		{
			builder.AddOffset(1, idsOffset.Value, 0);
		}

		// Token: 0x06029112 RID: 168210 RVA: 0x0059BEDC File Offset: 0x0059A0DC
		public static VectorOffset CreateIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06029113 RID: 168211 RVA: 0x0059BF13 File Offset: 0x0059A113
		public static VectorOffset CreateIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06029114 RID: 168212 RVA: 0x0059BF2D File Offset: 0x0059A12D
		public static VectorOffset CreateIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06029115 RID: 168213 RVA: 0x0059BF4B File Offset: 0x0059A14B
		public static VectorOffset CreateIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06029116 RID: 168214 RVA: 0x0059BF64 File Offset: 0x0059A164
		public static void StartIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06029117 RID: 168215 RVA: 0x0059BF6F File Offset: 0x0059A16F
		public static Offset<ISpawnMonsterPreDependOnPreceding> EndISpawnMonsterPreDependOnPreceding(FlatBufferBuilder builder)
		{
			return new Offset<ISpawnMonsterPreDependOnPreceding>(builder.EndTable());
		}

		// Token: 0x06029118 RID: 168216 RVA: 0x0059BF7C File Offset: 0x0059A17C
		public ISpawnMonsterPreDependOnPrecedingT UnPack()
		{
			ISpawnMonsterPreDependOnPrecedingT spawnMonsterPreDependOnPrecedingT = new ISpawnMonsterPreDependOnPrecedingT();
			this.UnPackTo(spawnMonsterPreDependOnPrecedingT);
			return spawnMonsterPreDependOnPrecedingT;
		}

		// Token: 0x06029119 RID: 168217 RVA: 0x0059BF98 File Offset: 0x0059A198
		public void UnPackTo(ISpawnMonsterPreDependOnPrecedingT _o)
		{
			_o.Type = this.Type;
			_o.Ids = new List<int>();
			for (int i = 0; i < this.IdsLength; i++)
			{
				_o.Ids.Add(this.Ids(i));
			}
		}

		// Token: 0x0602911A RID: 168218 RVA: 0x0059BFE0 File Offset: 0x0059A1E0
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

		// Token: 0x0400FC38 RID: 64568
		private Table __p;
	}
}
