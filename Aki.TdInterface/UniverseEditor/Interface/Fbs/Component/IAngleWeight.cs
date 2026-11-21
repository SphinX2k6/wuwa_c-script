using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020053C7 RID: 21447
	public struct IAngleWeight : IFlatbufferObject
	{
		// Token: 0x170097B3 RID: 38835
		// (get) Token: 0x060217BF RID: 137151 RVA: 0x0049E3A7 File Offset: 0x0049C5A7
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060217C0 RID: 137152 RVA: 0x0049E3B4 File Offset: 0x0049C5B4
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060217C1 RID: 137153 RVA: 0x0049E3BC File Offset: 0x0049C5BC
		public static IAngleWeight GetRootAsIAngleWeight(ByteBuffer _bb)
		{
			return IAngleWeight.GetRootAsIAngleWeight(_bb, default(IAngleWeight));
		}

		// Token: 0x060217C2 RID: 137154 RVA: 0x0049E3D8 File Offset: 0x0049C5D8
		public static IAngleWeight GetRootAsIAngleWeight(ByteBuffer _bb, IAngleWeight obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060217C3 RID: 137155 RVA: 0x0049E3F5 File Offset: 0x0049C5F5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060217C4 RID: 137156 RVA: 0x0049E404 File Offset: 0x0049C604
		public IAngleWeight __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170097B4 RID: 38836
		// (get) Token: 0x060217C5 RID: 137157 RVA: 0x0049E414 File Offset: 0x0049C614
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

		// Token: 0x060217C6 RID: 137158 RVA: 0x0049E450 File Offset: 0x0049C650
		public IEntityAngleWeight? AngleWeight(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IEntityAngleWeight?(default(IEntityAngleWeight).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170097B5 RID: 38837
		// (get) Token: 0x060217C7 RID: 137159 RVA: 0x0049E4B0 File Offset: 0x0049C6B0
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

		// Token: 0x060217C8 RID: 137160 RVA: 0x0049E4DB File Offset: 0x0049C6DB
		public static Offset<IAngleWeight> CreateIAngleWeight(FlatBufferBuilder builder, EExploreSkillSearchTargetCfg Type = EExploreSkillSearchTargetCfg.AngleWeight, VectorOffset AngleWeightOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IAngleWeight.AddAngleWeight(builder, AngleWeightOffset);
			IAngleWeight.AddType(builder, Type);
			return IAngleWeight.EndIAngleWeight(builder);
		}

		// Token: 0x060217C9 RID: 137161 RVA: 0x0049E4F8 File Offset: 0x0049C6F8
		public static void StartIAngleWeight(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060217CA RID: 137162 RVA: 0x0049E501 File Offset: 0x0049C701
		public static void AddType(FlatBufferBuilder builder, EExploreSkillSearchTargetCfg type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060217CB RID: 137163 RVA: 0x0049E50C File Offset: 0x0049C70C
		public static void AddAngleWeight(FlatBufferBuilder builder, VectorOffset angleWeightOffset)
		{
			builder.AddOffset(1, angleWeightOffset.Value, 0);
		}

		// Token: 0x060217CC RID: 137164 RVA: 0x0049E51C File Offset: 0x0049C71C
		public static VectorOffset CreateAngleWeightVector(FlatBufferBuilder builder, Offset<IEntityAngleWeight>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060217CD RID: 137165 RVA: 0x0049E55C File Offset: 0x0049C75C
		public static VectorOffset CreateAngleWeightVectorBlock(FlatBufferBuilder builder, Offset<IEntityAngleWeight>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IEntityAngleWeight>>(data);
			return builder.EndVector();
		}

		// Token: 0x060217CE RID: 137166 RVA: 0x0049E576 File Offset: 0x0049C776
		public static VectorOffset CreateAngleWeightVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IEntityAngleWeight>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IEntityAngleWeight>>(data);
			return builder.EndVector();
		}

		// Token: 0x060217CF RID: 137167 RVA: 0x0049E594 File Offset: 0x0049C794
		public static VectorOffset CreateAngleWeightVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IEntityAngleWeight>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060217D0 RID: 137168 RVA: 0x0049E5AD File Offset: 0x0049C7AD
		public static void StartAngleWeightVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060217D1 RID: 137169 RVA: 0x0049E5B8 File Offset: 0x0049C7B8
		public static Offset<IAngleWeight> EndIAngleWeight(FlatBufferBuilder builder)
		{
			return new Offset<IAngleWeight>(builder.EndTable());
		}

		// Token: 0x060217D2 RID: 137170 RVA: 0x0049E5C8 File Offset: 0x0049C7C8
		public IAngleWeightT UnPack()
		{
			IAngleWeightT angleWeightT = new IAngleWeightT();
			this.UnPackTo(angleWeightT);
			return angleWeightT;
		}

		// Token: 0x060217D3 RID: 137171 RVA: 0x0049E5E4 File Offset: 0x0049C7E4
		public void UnPackTo(IAngleWeightT _o)
		{
			_o.Type = this.Type;
			_o.AngleWeight = new List<IEntityAngleWeightT>();
			for (int i = 0; i < this.AngleWeightLength; i++)
			{
				_o.AngleWeight.Add((this.AngleWeight(i) != null) ? this.AngleWeight(i).Value.UnPack() : null);
			}
		}

		// Token: 0x060217D4 RID: 137172 RVA: 0x0049E650 File Offset: 0x0049C850
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

		// Token: 0x0400E813 RID: 59411
		private Table __p;
	}
}
