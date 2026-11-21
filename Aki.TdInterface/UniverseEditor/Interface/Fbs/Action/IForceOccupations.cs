using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006EEA RID: 28394
	public struct IForceOccupations : IFlatbufferObject
	{
		// Token: 0x1700D033 RID: 53299
		// (get) Token: 0x060311F9 RID: 201209 RVA: 0x006A8CDE File Offset: 0x006A6EDE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060311FA RID: 201210 RVA: 0x006A8CEB File Offset: 0x006A6EEB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060311FB RID: 201211 RVA: 0x006A8CF4 File Offset: 0x006A6EF4
		public static IForceOccupations GetRootAsIForceOccupations(ByteBuffer _bb)
		{
			return IForceOccupations.GetRootAsIForceOccupations(_bb, default(IForceOccupations));
		}

		// Token: 0x060311FC RID: 201212 RVA: 0x006A8D10 File Offset: 0x006A6F10
		public static IForceOccupations GetRootAsIForceOccupations(ByteBuffer _bb, IForceOccupations obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060311FD RID: 201213 RVA: 0x006A8D2D File Offset: 0x006A6F2D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060311FE RID: 201214 RVA: 0x006A8D3C File Offset: 0x006A6F3C
		public IForceOccupations __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D034 RID: 53300
		// (get) Token: 0x060311FF RID: 201215 RVA: 0x006A8D4C File Offset: 0x006A6F4C
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

		// Token: 0x06031200 RID: 201216 RVA: 0x006A8D88 File Offset: 0x006A6F88
		public string Occupations(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700D035 RID: 53301
		// (get) Token: 0x06031201 RID: 201217 RVA: 0x006A8DC4 File Offset: 0x006A6FC4
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

		// Token: 0x06031202 RID: 201218 RVA: 0x006A8DEF File Offset: 0x006A6FEF
		public static Offset<IForceOccupations> CreateIForceOccupations(FlatBufferBuilder builder, EOccupationActionType OccupationType = EOccupationActionType.Request, VectorOffset OccupationsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IForceOccupations.AddOccupations(builder, OccupationsOffset);
			IForceOccupations.AddOccupationType(builder, OccupationType);
			return IForceOccupations.EndIForceOccupations(builder);
		}

		// Token: 0x06031203 RID: 201219 RVA: 0x006A8E0C File Offset: 0x006A700C
		public static void StartIForceOccupations(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06031204 RID: 201220 RVA: 0x006A8E15 File Offset: 0x006A7015
		public static void AddOccupationType(FlatBufferBuilder builder, EOccupationActionType occupationType)
		{
			builder.AddByte(0, (byte)occupationType, 0);
		}

		// Token: 0x06031205 RID: 201221 RVA: 0x006A8E20 File Offset: 0x006A7020
		public static void AddOccupations(FlatBufferBuilder builder, VectorOffset occupationsOffset)
		{
			builder.AddOffset(1, occupationsOffset.Value, 0);
		}

		// Token: 0x06031206 RID: 201222 RVA: 0x006A8E30 File Offset: 0x006A7030
		public static VectorOffset CreateOccupationsVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06031207 RID: 201223 RVA: 0x006A8E70 File Offset: 0x006A7070
		public static VectorOffset CreateOccupationsVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x06031208 RID: 201224 RVA: 0x006A8E8A File Offset: 0x006A708A
		public static VectorOffset CreateOccupationsVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x06031209 RID: 201225 RVA: 0x006A8EA8 File Offset: 0x006A70A8
		public static VectorOffset CreateOccupationsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0603120A RID: 201226 RVA: 0x006A8EC1 File Offset: 0x006A70C1
		public static void StartOccupationsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0603120B RID: 201227 RVA: 0x006A8ECC File Offset: 0x006A70CC
		public static Offset<IForceOccupations> EndIForceOccupations(FlatBufferBuilder builder)
		{
			return new Offset<IForceOccupations>(builder.EndTable());
		}

		// Token: 0x0603120C RID: 201228 RVA: 0x006A8EDC File Offset: 0x006A70DC
		public IForceOccupationsT UnPack()
		{
			IForceOccupationsT forceOccupationsT = new IForceOccupationsT();
			this.UnPackTo(forceOccupationsT);
			return forceOccupationsT;
		}

		// Token: 0x0603120D RID: 201229 RVA: 0x006A8EF8 File Offset: 0x006A70F8
		public void UnPackTo(IForceOccupationsT _o)
		{
			_o.OccupationType = this.OccupationType;
			_o.Occupations = new List<string>();
			for (int i = 0; i < this.OccupationsLength; i++)
			{
				_o.Occupations.Add(this.Occupations(i));
			}
		}

		// Token: 0x0603120E RID: 201230 RVA: 0x006A8F40 File Offset: 0x006A7140
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

		// Token: 0x04011DEA RID: 73194
		private Table __p;
	}
}
