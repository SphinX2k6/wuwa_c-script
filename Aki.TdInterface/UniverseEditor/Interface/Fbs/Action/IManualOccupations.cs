using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007190 RID: 29072
	public struct IManualOccupations : IFlatbufferObject
	{
		// Token: 0x1700D4CE RID: 54478
		// (get) Token: 0x060328A0 RID: 207008 RVA: 0x006D4612 File Offset: 0x006D2812
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060328A1 RID: 207009 RVA: 0x006D461F File Offset: 0x006D281F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060328A2 RID: 207010 RVA: 0x006D4628 File Offset: 0x006D2828
		public static IManualOccupations GetRootAsIManualOccupations(ByteBuffer _bb)
		{
			return IManualOccupations.GetRootAsIManualOccupations(_bb, default(IManualOccupations));
		}

		// Token: 0x060328A3 RID: 207011 RVA: 0x006D4644 File Offset: 0x006D2844
		public static IManualOccupations GetRootAsIManualOccupations(ByteBuffer _bb, IManualOccupations obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060328A4 RID: 207012 RVA: 0x006D4661 File Offset: 0x006D2861
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060328A5 RID: 207013 RVA: 0x006D4670 File Offset: 0x006D2870
		public IManualOccupations __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D4CF RID: 54479
		// (get) Token: 0x060328A6 RID: 207014 RVA: 0x006D4680 File Offset: 0x006D2880
		public EOccupationActionType OccupationType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EOccupationActionType.Request;
				}
				return (EOccupationActionType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060328A7 RID: 207015 RVA: 0x006D46BC File Offset: 0x006D28BC
		public string Occupations(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700D4D0 RID: 54480
		// (get) Token: 0x060328A8 RID: 207016 RVA: 0x006D46F8 File Offset: 0x006D28F8
		public int OccupationsLength
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

		// Token: 0x060328A9 RID: 207017 RVA: 0x006D4723 File Offset: 0x006D2923
		public static Offset<IManualOccupations> CreateIManualOccupations(FlatBufferBuilder builder, EOccupationActionType OccupationType = EOccupationActionType.Request, VectorOffset OccupationsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IManualOccupations.AddOccupations(builder, OccupationsOffset);
			IManualOccupations.AddOccupationType(builder, OccupationType);
			return IManualOccupations.EndIManualOccupations(builder);
		}

		// Token: 0x060328AA RID: 207018 RVA: 0x006D4740 File Offset: 0x006D2940
		public static void StartIManualOccupations(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060328AB RID: 207019 RVA: 0x006D4749 File Offset: 0x006D2949
		public static void AddOccupationType(FlatBufferBuilder builder, EOccupationActionType occupationType)
		{
			builder.AddByte(0, (byte)occupationType, 0);
		}

		// Token: 0x060328AC RID: 207020 RVA: 0x006D4754 File Offset: 0x006D2954
		public static void AddOccupations(FlatBufferBuilder builder, VectorOffset occupationsOffset)
		{
			builder.AddOffset(1, occupationsOffset.Value, 0);
		}

		// Token: 0x060328AD RID: 207021 RVA: 0x006D4764 File Offset: 0x006D2964
		public static VectorOffset CreateOccupationsVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060328AE RID: 207022 RVA: 0x006D47A4 File Offset: 0x006D29A4
		public static VectorOffset CreateOccupationsVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x060328AF RID: 207023 RVA: 0x006D47BE File Offset: 0x006D29BE
		public static VectorOffset CreateOccupationsVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x060328B0 RID: 207024 RVA: 0x006D47DC File Offset: 0x006D29DC
		public static VectorOffset CreateOccupationsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060328B1 RID: 207025 RVA: 0x006D47F5 File Offset: 0x006D29F5
		public static void StartOccupationsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060328B2 RID: 207026 RVA: 0x006D4800 File Offset: 0x006D2A00
		public static Offset<IManualOccupations> EndIManualOccupations(FlatBufferBuilder builder)
		{
			return new Offset<IManualOccupations>(builder.EndTable());
		}

		// Token: 0x060328B3 RID: 207027 RVA: 0x006D4810 File Offset: 0x006D2A10
		public IManualOccupationsT UnPack()
		{
			IManualOccupationsT manualOccupationsT = new IManualOccupationsT();
			this.UnPackTo(manualOccupationsT);
			return manualOccupationsT;
		}

		// Token: 0x060328B4 RID: 207028 RVA: 0x006D482C File Offset: 0x006D2A2C
		public void UnPackTo(IManualOccupationsT _o)
		{
			_o.OccupationType = this.OccupationType;
			_o.Occupations = new List<string>();
			for (int i = 0; i < this.OccupationsLength; i++)
			{
				_o.Occupations.Add(this.Occupations(i));
			}
		}

		// Token: 0x060328B5 RID: 207029 RVA: 0x006D4874 File Offset: 0x006D2A74
		public static Offset<IManualOccupations> Pack(FlatBufferBuilder builder, IManualOccupationsT _o)
		{
			if (_o == null)
			{
				return default(Offset<IManualOccupations>);
			}
			VectorOffset occupationsOffset = default(VectorOffset);
			if (_o.Occupations != null)
			{
				StringOffset[] array = new StringOffset[_o.Occupations.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = builder.CreateString(_o.Occupations[i]);
				}
				occupationsOffset = IManualOccupations.CreateOccupationsVector(builder, array);
			}
			return IManualOccupations.CreateIManualOccupations(builder, _o.OccupationType, occupationsOffset);
		}

		// Token: 0x0401218A RID: 74122
		private Table __p;
	}
}
