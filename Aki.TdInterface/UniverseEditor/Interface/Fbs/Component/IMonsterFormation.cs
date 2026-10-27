using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Match;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005575 RID: 21877
	public struct IMonsterFormation : IFlatbufferObject
	{
		// Token: 0x1700A1AA RID: 41386
		// (get) Token: 0x06024337 RID: 148279 RVA: 0x004FFF4B File Offset: 0x004FE14B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06024338 RID: 148280 RVA: 0x004FFF58 File Offset: 0x004FE158
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06024339 RID: 148281 RVA: 0x004FFF60 File Offset: 0x004FE160
		public static IMonsterFormation GetRootAsIMonsterFormation(ByteBuffer _bb)
		{
			return IMonsterFormation.GetRootAsIMonsterFormation(_bb, default(IMonsterFormation));
		}

		// Token: 0x0602433A RID: 148282 RVA: 0x004FFF7C File Offset: 0x004FE17C
		public static IMonsterFormation GetRootAsIMonsterFormation(ByteBuffer _bb, IMonsterFormation obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602433B RID: 148283 RVA: 0x004FFF99 File Offset: 0x004FE199
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602433C RID: 148284 RVA: 0x004FFFA8 File Offset: 0x004FE1A8
		public IMonsterFormation __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0602433D RID: 148285 RVA: 0x004FFFB8 File Offset: 0x004FE1B8
		public EMonsterMatchType FormationPosConfig(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return EMonsterMatchType.Normal;
			}
			return (EMonsterMatchType)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x1700A1AB RID: 41387
		// (get) Token: 0x0602433E RID: 148286 RVA: 0x004FFFF8 File Offset: 0x004FE1F8
		public int FormationPosConfigLength
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

		// Token: 0x0602433F RID: 148287 RVA: 0x00500023 File Offset: 0x004FE223
		public Span<EMonsterMatchType> GetFormationPosConfigBytes()
		{
			return this.__p.__vector_as_span<EMonsterMatchType>(4, 1);
		}

		// Token: 0x06024340 RID: 148288 RVA: 0x00500034 File Offset: 0x004FE234
		public EMonsterMatchType[] GetFormationPosConfigArray()
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			int num2 = this.__p.__vector(num);
			int num3 = this.__p.__vector_len(num);
			EMonsterMatchType[] array = new EMonsterMatchType[num3];
			for (int i = 0; i < num3; i++)
			{
				array[i] = (EMonsterMatchType)this.__p.bb.Get(num2 + i);
			}
			return array;
		}

		// Token: 0x06024341 RID: 148289 RVA: 0x0050009D File Offset: 0x004FE29D
		public static Offset<IMonsterFormation> CreateIMonsterFormation(FlatBufferBuilder builder, VectorOffset FormationPosConfigOffset = default(VectorOffset))
		{
			builder.StartTable(1);
			IMonsterFormation.AddFormationPosConfig(builder, FormationPosConfigOffset);
			return IMonsterFormation.EndIMonsterFormation(builder);
		}

		// Token: 0x06024342 RID: 148290 RVA: 0x005000B3 File Offset: 0x004FE2B3
		public static void StartIMonsterFormation(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06024343 RID: 148291 RVA: 0x005000BC File Offset: 0x004FE2BC
		public static void AddFormationPosConfig(FlatBufferBuilder builder, VectorOffset formationPosConfigOffset)
		{
			builder.AddOffset(0, formationPosConfigOffset.Value, 0);
		}

		// Token: 0x06024344 RID: 148292 RVA: 0x005000CC File Offset: 0x004FE2CC
		public static VectorOffset CreateFormationPosConfigVector(FlatBufferBuilder builder, EMonsterMatchType[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06024345 RID: 148293 RVA: 0x00500103 File Offset: 0x004FE303
		public static VectorOffset CreateFormationPosConfigVectorBlock(FlatBufferBuilder builder, EMonsterMatchType[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<EMonsterMatchType>(data);
			return builder.EndVector();
		}

		// Token: 0x06024346 RID: 148294 RVA: 0x0050011D File Offset: 0x004FE31D
		public static VectorOffset CreateFormationPosConfigVectorBlock(FlatBufferBuilder builder, ArraySegment<EMonsterMatchType> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<EMonsterMatchType>(data);
			return builder.EndVector();
		}

		// Token: 0x06024347 RID: 148295 RVA: 0x0050013B File Offset: 0x004FE33B
		public static VectorOffset CreateFormationPosConfigVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<EMonsterMatchType>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06024348 RID: 148296 RVA: 0x00500154 File Offset: 0x004FE354
		public static void StartFormationPosConfigVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x06024349 RID: 148297 RVA: 0x0050015F File Offset: 0x004FE35F
		public static Offset<IMonsterFormation> EndIMonsterFormation(FlatBufferBuilder builder)
		{
			return new Offset<IMonsterFormation>(builder.EndTable());
		}

		// Token: 0x0602434A RID: 148298 RVA: 0x0050016C File Offset: 0x004FE36C
		public IMonsterFormationT UnPack()
		{
			IMonsterFormationT monsterFormationT = new IMonsterFormationT();
			this.UnPackTo(monsterFormationT);
			return monsterFormationT;
		}

		// Token: 0x0602434B RID: 148299 RVA: 0x00500188 File Offset: 0x004FE388
		public void UnPackTo(IMonsterFormationT _o)
		{
			_o.FormationPosConfig = new List<EMonsterMatchType>();
			for (int i = 0; i < this.FormationPosConfigLength; i++)
			{
				_o.FormationPosConfig.Add(this.FormationPosConfig(i));
			}
		}

		// Token: 0x0602434C RID: 148300 RVA: 0x005001C4 File Offset: 0x004FE3C4
		public static Offset<IMonsterFormation> Pack(FlatBufferBuilder builder, IMonsterFormationT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMonsterFormation>);
			}
			VectorOffset formationPosConfigOffset = default(VectorOffset);
			if (_o.FormationPosConfig != null)
			{
				EMonsterMatchType[] data = _o.FormationPosConfig.ToArray();
				formationPosConfigOffset = IMonsterFormation.CreateFormationPosConfigVector(builder, data);
			}
			return IMonsterFormation.CreateIMonsterFormation(builder, formationPosConfigOffset);
		}

		// Token: 0x0400E8A0 RID: 59552
		private Table __p;
	}
}
