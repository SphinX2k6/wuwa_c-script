using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005BC1 RID: 23489
	public struct IWuWaGoLevelCenter : IFlatbufferObject
	{
		// Token: 0x1700B175 RID: 45429
		// (get) Token: 0x0602839D RID: 164765 RVA: 0x00586E48 File Offset: 0x00585048
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602839E RID: 164766 RVA: 0x00586E55 File Offset: 0x00585055
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602839F RID: 164767 RVA: 0x00586E5C File Offset: 0x0058505C
		public static IWuWaGoLevelCenter GetRootAsIWuWaGoLevelCenter(ByteBuffer _bb)
		{
			return IWuWaGoLevelCenter.GetRootAsIWuWaGoLevelCenter(_bb, default(IWuWaGoLevelCenter));
		}

		// Token: 0x060283A0 RID: 164768 RVA: 0x00586E78 File Offset: 0x00585078
		public static IWuWaGoLevelCenter GetRootAsIWuWaGoLevelCenter(ByteBuffer _bb, IWuWaGoLevelCenter obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060283A1 RID: 164769 RVA: 0x00586E95 File Offset: 0x00585095
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060283A2 RID: 164770 RVA: 0x00586EA4 File Offset: 0x005850A4
		public IWuWaGoLevelCenter __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B176 RID: 45430
		// (get) Token: 0x060283A3 RID: 164771 RVA: 0x00586EB4 File Offset: 0x005850B4
		public EWuWaGoEntityType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EWuWaGoEntityType.LevelCenter;
				}
				return (EWuWaGoEntityType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B177 RID: 45431
		// (get) Token: 0x060283A4 RID: 164772 RVA: 0x00586EF0 File Offset: 0x005850F0
		public string LevelKey
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060283A5 RID: 164773 RVA: 0x00586F27 File Offset: 0x00585127
		public Span<byte> GetLevelKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060283A6 RID: 164774 RVA: 0x00586F36 File Offset: 0x00585136
		public byte[] GetLevelKeyArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x060283A7 RID: 164775 RVA: 0x00586F44 File Offset: 0x00585144
		public int LevelEntityIds(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700B178 RID: 45432
		// (get) Token: 0x060283A8 RID: 164776 RVA: 0x00586F84 File Offset: 0x00585184
		public int LevelEntityIdsLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060283A9 RID: 164777 RVA: 0x00586FAF File Offset: 0x005851AF
		public Span<int> GetLevelEntityIdsBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x060283AA RID: 164778 RVA: 0x00586FBE File Offset: 0x005851BE
		public int[] GetLevelEntityIdsArray()
		{
			return this.__p.__vector_as_array<int>(8);
		}

		// Token: 0x060283AB RID: 164779 RVA: 0x00586FCC File Offset: 0x005851CC
		public static Offset<IWuWaGoLevelCenter> CreateIWuWaGoLevelCenter(FlatBufferBuilder builder, EWuWaGoEntityType Type = EWuWaGoEntityType.LevelCenter, StringOffset LevelKeyOffset = default(StringOffset), VectorOffset LevelEntityIdsOffset = default(VectorOffset))
		{
			builder.StartTable(3);
			IWuWaGoLevelCenter.AddLevelEntityIds(builder, LevelEntityIdsOffset);
			IWuWaGoLevelCenter.AddLevelKey(builder, LevelKeyOffset);
			IWuWaGoLevelCenter.AddType(builder, Type);
			return IWuWaGoLevelCenter.EndIWuWaGoLevelCenter(builder);
		}

		// Token: 0x060283AC RID: 164780 RVA: 0x00586FF0 File Offset: 0x005851F0
		public static void StartIWuWaGoLevelCenter(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060283AD RID: 164781 RVA: 0x00586FF9 File Offset: 0x005851F9
		public static void AddType(FlatBufferBuilder builder, EWuWaGoEntityType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060283AE RID: 164782 RVA: 0x00587004 File Offset: 0x00585204
		public static void AddLevelKey(FlatBufferBuilder builder, StringOffset levelKeyOffset)
		{
			builder.AddOffset(1, levelKeyOffset.Value, 0);
		}

		// Token: 0x060283AF RID: 164783 RVA: 0x00587014 File Offset: 0x00585214
		public static void AddLevelEntityIds(FlatBufferBuilder builder, VectorOffset levelEntityIdsOffset)
		{
			builder.AddOffset(2, levelEntityIdsOffset.Value, 0);
		}

		// Token: 0x060283B0 RID: 164784 RVA: 0x00587024 File Offset: 0x00585224
		public static VectorOffset CreateLevelEntityIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x060283B1 RID: 164785 RVA: 0x0058705B File Offset: 0x0058525B
		public static VectorOffset CreateLevelEntityIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060283B2 RID: 164786 RVA: 0x00587075 File Offset: 0x00585275
		public static VectorOffset CreateLevelEntityIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060283B3 RID: 164787 RVA: 0x00587093 File Offset: 0x00585293
		public static VectorOffset CreateLevelEntityIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060283B4 RID: 164788 RVA: 0x005870AC File Offset: 0x005852AC
		public static void StartLevelEntityIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060283B5 RID: 164789 RVA: 0x005870B7 File Offset: 0x005852B7
		public static Offset<IWuWaGoLevelCenter> EndIWuWaGoLevelCenter(FlatBufferBuilder builder)
		{
			return new Offset<IWuWaGoLevelCenter>(builder.EndTable());
		}

		// Token: 0x060283B6 RID: 164790 RVA: 0x005870C4 File Offset: 0x005852C4
		public IWuWaGoLevelCenterT UnPack()
		{
			IWuWaGoLevelCenterT wuWaGoLevelCenterT = new IWuWaGoLevelCenterT();
			this.UnPackTo(wuWaGoLevelCenterT);
			return wuWaGoLevelCenterT;
		}

		// Token: 0x060283B7 RID: 164791 RVA: 0x005870E0 File Offset: 0x005852E0
		public void UnPackTo(IWuWaGoLevelCenterT _o)
		{
			_o.Type = this.Type;
			_o.LevelKey = this.LevelKey;
			_o.LevelEntityIds = new List<int>();
			for (int i = 0; i < this.LevelEntityIdsLength; i++)
			{
				_o.LevelEntityIds.Add(this.LevelEntityIds(i));
			}
		}

		// Token: 0x060283B8 RID: 164792 RVA: 0x00587134 File Offset: 0x00585334
		public static Offset<IWuWaGoLevelCenter> Pack(FlatBufferBuilder builder, IWuWaGoLevelCenterT _o)
		{
			if (_o == null)
			{
				return default(Offset<IWuWaGoLevelCenter>);
			}
			StringOffset levelKeyOffset = (_o.LevelKey == null) ? default(StringOffset) : builder.CreateString(_o.LevelKey);
			VectorOffset levelEntityIdsOffset = default(VectorOffset);
			if (_o.LevelEntityIds != null)
			{
				int[] data = _o.LevelEntityIds.ToArray();
				levelEntityIdsOffset = IWuWaGoLevelCenter.CreateLevelEntityIdsVector(builder, data);
			}
			return IWuWaGoLevelCenter.CreateIWuWaGoLevelCenter(builder, _o.Type, levelKeyOffset, levelEntityIdsOffset);
		}

		// Token: 0x0400F339 RID: 62265
		private Table __p;
	}
}
