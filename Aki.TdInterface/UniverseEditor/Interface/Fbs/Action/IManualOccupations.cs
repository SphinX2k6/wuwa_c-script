using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A6E RID: 27246
	public struct IManualOccupations : IFlatbufferObject
	{
		// Token: 0x1700CA23 RID: 51747
		// (get) Token: 0x0602FB7A RID: 195450 RVA: 0x0067E552 File Offset: 0x0067C752
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602FB7B RID: 195451 RVA: 0x0067E55F File Offset: 0x0067C75F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602FB7C RID: 195452 RVA: 0x0067E568 File Offset: 0x0067C768
		public static IManualOccupations GetRootAsIManualOccupations(ByteBuffer _bb)
		{
			return IManualOccupations.GetRootAsIManualOccupations(_bb, default(IManualOccupations));
		}

		// Token: 0x0602FB7D RID: 195453 RVA: 0x0067E584 File Offset: 0x0067C784
		public static IManualOccupations GetRootAsIManualOccupations(ByteBuffer _bb, IManualOccupations obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602FB7E RID: 195454 RVA: 0x0067E5A1 File Offset: 0x0067C7A1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602FB7F RID: 195455 RVA: 0x0067E5B0 File Offset: 0x0067C7B0
		public IManualOccupations __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CA24 RID: 51748
		// (get) Token: 0x0602FB80 RID: 195456 RVA: 0x0067E5C0 File Offset: 0x0067C7C0
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

		// Token: 0x0602FB81 RID: 195457 RVA: 0x0067E5FC File Offset: 0x0067C7FC
		public string Occupations(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700CA25 RID: 51749
		// (get) Token: 0x0602FB82 RID: 195458 RVA: 0x0067E638 File Offset: 0x0067C838
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

		// Token: 0x0602FB83 RID: 195459 RVA: 0x0067E663 File Offset: 0x0067C863
		public static Offset<IManualOccupations> CreateIManualOccupations(FlatBufferBuilder builder, EOccupationActionType OccupationType = EOccupationActionType.Request, VectorOffset OccupationsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IManualOccupations.AddOccupations(builder, OccupationsOffset);
			IManualOccupations.AddOccupationType(builder, OccupationType);
			return IManualOccupations.EndIManualOccupations(builder);
		}

		// Token: 0x0602FB84 RID: 195460 RVA: 0x0067E680 File Offset: 0x0067C880
		public static void StartIManualOccupations(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602FB85 RID: 195461 RVA: 0x0067E689 File Offset: 0x0067C889
		public static void AddOccupationType(FlatBufferBuilder builder, EOccupationActionType occupationType)
		{
			builder.AddByte(0, (byte)occupationType, 0);
		}

		// Token: 0x0602FB86 RID: 195462 RVA: 0x0067E694 File Offset: 0x0067C894
		public static void AddOccupations(FlatBufferBuilder builder, VectorOffset occupationsOffset)
		{
			builder.AddOffset(1, occupationsOffset.Value, 0);
		}

		// Token: 0x0602FB87 RID: 195463 RVA: 0x0067E6A4 File Offset: 0x0067C8A4
		public static VectorOffset CreateOccupationsVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602FB88 RID: 195464 RVA: 0x0067E6E4 File Offset: 0x0067C8E4
		public static VectorOffset CreateOccupationsVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0602FB89 RID: 195465 RVA: 0x0067E6FE File Offset: 0x0067C8FE
		public static VectorOffset CreateOccupationsVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0602FB8A RID: 195466 RVA: 0x0067E71C File Offset: 0x0067C91C
		public static VectorOffset CreateOccupationsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602FB8B RID: 195467 RVA: 0x0067E735 File Offset: 0x0067C935
		public static void StartOccupationsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602FB8C RID: 195468 RVA: 0x0067E740 File Offset: 0x0067C940
		public static Offset<IManualOccupations> EndIManualOccupations(FlatBufferBuilder builder)
		{
			return new Offset<IManualOccupations>(builder.EndTable());
		}

		// Token: 0x0602FB8D RID: 195469 RVA: 0x0067E750 File Offset: 0x0067C950
		public IManualOccupationsT UnPack()
		{
			IManualOccupationsT manualOccupationsT = new IManualOccupationsT();
			this.UnPackTo(manualOccupationsT);
			return manualOccupationsT;
		}

		// Token: 0x0602FB8E RID: 195470 RVA: 0x0067E76C File Offset: 0x0067C96C
		public void UnPackTo(IManualOccupationsT _o)
		{
			_o.OccupationType = this.OccupationType;
			_o.Occupations = new List<string>();
			for (int i = 0; i < this.OccupationsLength; i++)
			{
				_o.Occupations.Add(this.Occupations(i));
			}
		}

		// Token: 0x0602FB8F RID: 195471 RVA: 0x0067E7B4 File Offset: 0x0067C9B4
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

		// Token: 0x04011292 RID: 70290
		private Table __p;
	}
}
