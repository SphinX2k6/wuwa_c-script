using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006855 RID: 26709
	public struct IForceOccupations : IFlatbufferObject
	{
		// Token: 0x1700C65F RID: 50783
		// (get) Token: 0x0602E913 RID: 190739 RVA: 0x0065A472 File Offset: 0x00658672
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E914 RID: 190740 RVA: 0x0065A47F File Offset: 0x0065867F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E915 RID: 190741 RVA: 0x0065A488 File Offset: 0x00658688
		public static IForceOccupations GetRootAsIForceOccupations(ByteBuffer _bb)
		{
			return IForceOccupations.GetRootAsIForceOccupations(_bb, default(IForceOccupations));
		}

		// Token: 0x0602E916 RID: 190742 RVA: 0x0065A4A4 File Offset: 0x006586A4
		public static IForceOccupations GetRootAsIForceOccupations(ByteBuffer _bb, IForceOccupations obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E917 RID: 190743 RVA: 0x0065A4C1 File Offset: 0x006586C1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E918 RID: 190744 RVA: 0x0065A4D0 File Offset: 0x006586D0
		public IForceOccupations __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C660 RID: 50784
		// (get) Token: 0x0602E919 RID: 190745 RVA: 0x0065A4E0 File Offset: 0x006586E0
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

		// Token: 0x0602E91A RID: 190746 RVA: 0x0065A51C File Offset: 0x0065871C
		public string Occupations(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700C661 RID: 50785
		// (get) Token: 0x0602E91B RID: 190747 RVA: 0x0065A558 File Offset: 0x00658758
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

		// Token: 0x0602E91C RID: 190748 RVA: 0x0065A583 File Offset: 0x00658783
		public static Offset<IForceOccupations> CreateIForceOccupations(FlatBufferBuilder builder, EOccupationActionType OccupationType = EOccupationActionType.Request, VectorOffset OccupationsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IForceOccupations.AddOccupations(builder, OccupationsOffset);
			IForceOccupations.AddOccupationType(builder, OccupationType);
			return IForceOccupations.EndIForceOccupations(builder);
		}

		// Token: 0x0602E91D RID: 190749 RVA: 0x0065A5A0 File Offset: 0x006587A0
		public static void StartIForceOccupations(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602E91E RID: 190750 RVA: 0x0065A5A9 File Offset: 0x006587A9
		public static void AddOccupationType(FlatBufferBuilder builder, EOccupationActionType occupationType)
		{
			builder.AddByte(0, (byte)occupationType, 0);
		}

		// Token: 0x0602E91F RID: 190751 RVA: 0x0065A5B4 File Offset: 0x006587B4
		public static void AddOccupations(FlatBufferBuilder builder, VectorOffset occupationsOffset)
		{
			builder.AddOffset(1, occupationsOffset.Value, 0);
		}

		// Token: 0x0602E920 RID: 190752 RVA: 0x0065A5C4 File Offset: 0x006587C4
		public static VectorOffset CreateOccupationsVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602E921 RID: 190753 RVA: 0x0065A604 File Offset: 0x00658804
		public static VectorOffset CreateOccupationsVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0602E922 RID: 190754 RVA: 0x0065A61E File Offset: 0x0065881E
		public static VectorOffset CreateOccupationsVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0602E923 RID: 190755 RVA: 0x0065A63C File Offset: 0x0065883C
		public static VectorOffset CreateOccupationsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602E924 RID: 190756 RVA: 0x0065A655 File Offset: 0x00658855
		public static void StartOccupationsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602E925 RID: 190757 RVA: 0x0065A660 File Offset: 0x00658860
		public static Offset<IForceOccupations> EndIForceOccupations(FlatBufferBuilder builder)
		{
			return new Offset<IForceOccupations>(builder.EndTable());
		}

		// Token: 0x0602E926 RID: 190758 RVA: 0x0065A670 File Offset: 0x00658870
		public IForceOccupationsT UnPack()
		{
			IForceOccupationsT forceOccupationsT = new IForceOccupationsT();
			this.UnPackTo(forceOccupationsT);
			return forceOccupationsT;
		}

		// Token: 0x0602E927 RID: 190759 RVA: 0x0065A68C File Offset: 0x0065888C
		public void UnPackTo(IForceOccupationsT _o)
		{
			_o.OccupationType = this.OccupationType;
			_o.Occupations = new List<string>();
			for (int i = 0; i < this.OccupationsLength; i++)
			{
				_o.Occupations.Add(this.Occupations(i));
			}
		}

		// Token: 0x0602E928 RID: 190760 RVA: 0x0065A6D4 File Offset: 0x006588D4
		public static Offset<IForceOccupations> Pack(FlatBufferBuilder builder, IForceOccupationsT _o)
		{
			if (_o == null)
			{
				return default(Offset<IForceOccupations>);
			}
			VectorOffset occupationsOffset = default(VectorOffset);
			if (_o.Occupations != null)
			{
				StringOffset[] array = new StringOffset[_o.Occupations.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = builder.CreateString(_o.Occupations[i]);
				}
				occupationsOffset = IForceOccupations.CreateOccupationsVector(builder, array);
			}
			return IForceOccupations.CreateIForceOccupations(builder, _o.OccupationType, occupationsOffset);
		}

		// Token: 0x04010FA0 RID: 69536
		private Table __p;
	}
}
