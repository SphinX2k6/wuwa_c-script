using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004E9E RID: 20126
	public struct IAngleWeight : IFlatbufferObject
	{
		// Token: 0x17009054 RID: 36948
		// (get) Token: 0x0601FACA RID: 129738 RVA: 0x00469143 File Offset: 0x00467343
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601FACB RID: 129739 RVA: 0x00469150 File Offset: 0x00467350
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601FACC RID: 129740 RVA: 0x00469158 File Offset: 0x00467358
		public static IAngleWeight GetRootAsIAngleWeight(ByteBuffer _bb)
		{
			return IAngleWeight.GetRootAsIAngleWeight(_bb, default(IAngleWeight));
		}

		// Token: 0x0601FACD RID: 129741 RVA: 0x00469174 File Offset: 0x00467374
		public static IAngleWeight GetRootAsIAngleWeight(ByteBuffer _bb, IAngleWeight obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601FACE RID: 129742 RVA: 0x00469191 File Offset: 0x00467391
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601FACF RID: 129743 RVA: 0x004691A0 File Offset: 0x004673A0
		public IAngleWeight __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009055 RID: 36949
		// (get) Token: 0x0601FAD0 RID: 129744 RVA: 0x004691B0 File Offset: 0x004673B0
		public EExploreSkillSearchTargetCfg Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EExploreSkillSearchTargetCfg.AngleWeight;
				}
				return (EExploreSkillSearchTargetCfg)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601FAD1 RID: 129745 RVA: 0x004691EC File Offset: 0x004673EC
		public IEntityAngleWeight? AngleWeight(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IEntityAngleWeight?(default(IEntityAngleWeight).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009056 RID: 36950
		// (get) Token: 0x0601FAD2 RID: 129746 RVA: 0x0046924C File Offset: 0x0046744C
		public int AngleWeightLength
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

		// Token: 0x0601FAD3 RID: 129747 RVA: 0x00469277 File Offset: 0x00467477
		public static Offset<IAngleWeight> CreateIAngleWeight(FlatBufferBuilder builder, EExploreSkillSearchTargetCfg Type = EExploreSkillSearchTargetCfg.AngleWeight, VectorOffset AngleWeightOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IAngleWeight.AddAngleWeight(builder, AngleWeightOffset);
			IAngleWeight.AddType(builder, Type);
			return IAngleWeight.EndIAngleWeight(builder);
		}

		// Token: 0x0601FAD4 RID: 129748 RVA: 0x00469294 File Offset: 0x00467494
		public static void StartIAngleWeight(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601FAD5 RID: 129749 RVA: 0x0046929D File Offset: 0x0046749D
		public static void AddType(FlatBufferBuilder builder, EExploreSkillSearchTargetCfg type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601FAD6 RID: 129750 RVA: 0x004692A8 File Offset: 0x004674A8
		public static void AddAngleWeight(FlatBufferBuilder builder, VectorOffset angleWeightOffset)
		{
			builder.AddOffset(1, angleWeightOffset.Value, 0);
		}

		// Token: 0x0601FAD7 RID: 129751 RVA: 0x004692B8 File Offset: 0x004674B8
		public static VectorOffset CreateAngleWeightVector(FlatBufferBuilder builder, Offset<IEntityAngleWeight>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601FAD8 RID: 129752 RVA: 0x004692F8 File Offset: 0x004674F8
		public static VectorOffset CreateAngleWeightVectorBlock(FlatBufferBuilder builder, Offset<IEntityAngleWeight>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IEntityAngleWeight>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601FAD9 RID: 129753 RVA: 0x00469312 File Offset: 0x00467512
		public static VectorOffset CreateAngleWeightVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IEntityAngleWeight>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IEntityAngleWeight>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601FADA RID: 129754 RVA: 0x00469330 File Offset: 0x00467530
		public static VectorOffset CreateAngleWeightVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IEntityAngleWeight>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601FADB RID: 129755 RVA: 0x00469349 File Offset: 0x00467549
		public static void StartAngleWeightVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601FADC RID: 129756 RVA: 0x00469354 File Offset: 0x00467554
		public static Offset<IAngleWeight> EndIAngleWeight(FlatBufferBuilder builder)
		{
			return new Offset<IAngleWeight>(builder.EndTable());
		}

		// Token: 0x0601FADD RID: 129757 RVA: 0x00469364 File Offset: 0x00467564
		public IAngleWeightT UnPack()
		{
			IAngleWeightT angleWeightT = new IAngleWeightT();
			this.UnPackTo(angleWeightT);
			return angleWeightT;
		}

		// Token: 0x0601FADE RID: 129758 RVA: 0x00469380 File Offset: 0x00467580
		public void UnPackTo(IAngleWeightT _o)
		{
			_o.Type = this.Type;
			_o.AngleWeight = new List<IEntityAngleWeightT>();
			for (int i = 0; i < this.AngleWeightLength; i++)
			{
				_o.AngleWeight.Add((this.AngleWeight(i) != null) ? this.AngleWeight(i).Value.UnPack() : null);
			}
		}

		// Token: 0x0601FADF RID: 129759 RVA: 0x004693EC File Offset: 0x004675EC
		public static Offset<IAngleWeight> Pack(FlatBufferBuilder builder, IAngleWeightT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAngleWeight>);
			}
			VectorOffset angleWeightOffset = default(VectorOffset);
			if (_o.AngleWeight != null)
			{
				Offset<IEntityAngleWeight>[] array = new Offset<IEntityAngleWeight>[_o.AngleWeight.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IEntityAngleWeight.Pack(builder, _o.AngleWeight[i]);
				}
				angleWeightOffset = IAngleWeight.CreateAngleWeightVector(builder, array);
			}
			return IAngleWeight.CreateIAngleWeight(builder, _o.Type, angleWeightOffset);
		}

		// Token: 0x0400DC78 RID: 56440
		private Table __p;
	}
}
