using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Match;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B13 RID: 23315
	public struct IMonsterFormation : IFlatbufferObject
	{
		// Token: 0x1700AA32 RID: 43570
		// (get) Token: 0x06026544 RID: 156996 RVA: 0x005404C1 File Offset: 0x0053E6C1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06026545 RID: 156997 RVA: 0x005404CE File Offset: 0x0053E6CE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06026546 RID: 156998 RVA: 0x005404D8 File Offset: 0x0053E6D8
		public static IMonsterFormation GetRootAsIMonsterFormation(ByteBuffer _bb)
		{
			return IMonsterFormation.GetRootAsIMonsterFormation(_bb, default(IMonsterFormation));
		}

		// Token: 0x06026547 RID: 156999 RVA: 0x005404F4 File Offset: 0x0053E6F4
		public static IMonsterFormation GetRootAsIMonsterFormation(ByteBuffer _bb, IMonsterFormation obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06026548 RID: 157000 RVA: 0x00540511 File Offset: 0x0053E711
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06026549 RID: 157001 RVA: 0x00540520 File Offset: 0x0053E720
		public IMonsterFormation __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0602654A RID: 157002 RVA: 0x00540530 File Offset: 0x0053E730
		public EMonsterMatchType FormationPosConfig(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return EMonsterMatchType.Normal;
			}
			return (EMonsterMatchType)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x1700AA33 RID: 43571
		// (get) Token: 0x0602654B RID: 157003 RVA: 0x00540570 File Offset: 0x0053E770
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

		// Token: 0x0602654C RID: 157004 RVA: 0x0054059B File Offset: 0x0053E79B
		public Span<EMonsterMatchType> GetFormationPosConfigBytes()
		{
			return this.__p.__vector_as_span<EMonsterMatchType>(4, 1);
		}

		// Token: 0x0602654D RID: 157005 RVA: 0x005405AC File Offset: 0x0053E7AC
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

		// Token: 0x0602654E RID: 157006 RVA: 0x00540615 File Offset: 0x0053E815
		public static Offset<IMonsterFormation> CreateIMonsterFormation(FlatBufferBuilder builder, VectorOffset FormationPosConfigOffset = default(VectorOffset))
		{
			builder.StartTable(1);
			IMonsterFormation.AddFormationPosConfig(builder, FormationPosConfigOffset);
			return IMonsterFormation.EndIMonsterFormation(builder);
		}

		// Token: 0x0602654F RID: 157007 RVA: 0x0054062B File Offset: 0x0053E82B
		public static void StartIMonsterFormation(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06026550 RID: 157008 RVA: 0x00540634 File Offset: 0x0053E834
		public static void AddFormationPosConfig(FlatBufferBuilder builder, VectorOffset formationPosConfigOffset)
		{
			builder.AddOffset(0, formationPosConfigOffset.Value, 0);
		}

		// Token: 0x06026551 RID: 157009 RVA: 0x00540644 File Offset: 0x0053E844
		public static VectorOffset CreateFormationPosConfigVector(FlatBufferBuilder builder, EMonsterMatchType[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06026552 RID: 157010 RVA: 0x0054067B File Offset: 0x0053E87B
		public static VectorOffset CreateFormationPosConfigVectorBlock(FlatBufferBuilder builder, EMonsterMatchType[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<EMonsterMatchType>(data);
			return builder.EndVector();
		}

		// Token: 0x06026553 RID: 157011 RVA: 0x00540695 File Offset: 0x0053E895
		public static VectorOffset CreateFormationPosConfigVectorBlock(FlatBufferBuilder builder, ArraySegment<EMonsterMatchType> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<EMonsterMatchType>(data);
			return builder.EndVector();
		}

		// Token: 0x06026554 RID: 157012 RVA: 0x005406B3 File Offset: 0x0053E8B3
		public static VectorOffset CreateFormationPosConfigVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<EMonsterMatchType>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06026555 RID: 157013 RVA: 0x005406CC File Offset: 0x0053E8CC
		public static void StartFormationPosConfigVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x06026556 RID: 157014 RVA: 0x005406D7 File Offset: 0x0053E8D7
		public static Offset<IMonsterFormation> EndIMonsterFormation(FlatBufferBuilder builder)
		{
			return new Offset<IMonsterFormation>(builder.EndTable());
		}

		// Token: 0x06026557 RID: 157015 RVA: 0x005406E4 File Offset: 0x0053E8E4
		public IMonsterFormationT UnPack()
		{
			IMonsterFormationT monsterFormationT = new IMonsterFormationT();
			this.UnPackTo(monsterFormationT);
			return monsterFormationT;
		}

		// Token: 0x06026558 RID: 157016 RVA: 0x00540700 File Offset: 0x0053E900
		public void UnPackTo(IMonsterFormationT _o)
		{
			_o.FormationPosConfig = new List<EMonsterMatchType>();
			for (int i = 0; i < this.FormationPosConfigLength; i++)
			{
				_o.FormationPosConfig.Add(this.FormationPosConfig(i));
			}
		}

		// Token: 0x06026559 RID: 157017 RVA: 0x0054073C File Offset: 0x0053E93C
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

		// Token: 0x0400F502 RID: 62722
		private Table __p;
	}
}
