using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200756D RID: 30061
	public struct IQteHourglass : IFlatbufferObject
	{
		// Token: 0x1700DD08 RID: 56584
		// (get) Token: 0x06034B57 RID: 215895 RVA: 0x007169AD File Offset: 0x00714BAD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06034B58 RID: 215896 RVA: 0x007169BA File Offset: 0x00714BBA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06034B59 RID: 215897 RVA: 0x007169C4 File Offset: 0x00714BC4
		public static IQteHourglass GetRootAsIQteHourglass(ByteBuffer _bb)
		{
			return IQteHourglass.GetRootAsIQteHourglass(_bb, default(IQteHourglass));
		}

		// Token: 0x06034B5A RID: 215898 RVA: 0x007169E0 File Offset: 0x00714BE0
		public static IQteHourglass GetRootAsIQteHourglass(ByteBuffer _bb, IQteHourglass obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06034B5B RID: 215899 RVA: 0x007169FD File Offset: 0x00714BFD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06034B5C RID: 215900 RVA: 0x00716A0C File Offset: 0x00714C0C
		public IQteHourglass __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DD09 RID: 56585
		// (get) Token: 0x06034B5D RID: 215901 RVA: 0x00716A1C File Offset: 0x00714C1C
		public ESimpleGameplayType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESimpleGameplayType.Cipher;
				}
				return (ESimpleGameplayType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06034B5E RID: 215902 RVA: 0x00716A58 File Offset: 0x00714C58
		public int QteIds(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700DD0A RID: 56586
		// (get) Token: 0x06034B5F RID: 215903 RVA: 0x00716A98 File Offset: 0x00714C98
		public int QteIdsLength
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

		// Token: 0x06034B60 RID: 215904 RVA: 0x00716AC3 File Offset: 0x00714CC3
		public Span<int> GetQteIdsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x06034B61 RID: 215905 RVA: 0x00716AD2 File Offset: 0x00714CD2
		public int[] GetQteIdsArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x06034B62 RID: 215906 RVA: 0x00716AE0 File Offset: 0x00714CE0
		public IQteHourglassConfig? QteConfigs(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IQteHourglassConfig?(default(IQteHourglassConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700DD0B RID: 56587
		// (get) Token: 0x06034B63 RID: 215907 RVA: 0x00716B40 File Offset: 0x00714D40
		public int QteConfigsLength
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

		// Token: 0x1700DD0C RID: 56588
		// (get) Token: 0x06034B64 RID: 215908 RVA: 0x00716B6C File Offset: 0x00714D6C
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06034B65 RID: 215909 RVA: 0x00716BA9 File Offset: 0x00714DA9
		public static Offset<IQteHourglass> CreateIQteHourglass(FlatBufferBuilder builder, ESimpleGameplayType Type = ESimpleGameplayType.Cipher, VectorOffset QteIdsOffset = default(VectorOffset), VectorOffset QteConfigsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(4);
			IQteHourglass.AddQteConfigs(builder, QteConfigsOffset);
			IQteHourglass.AddQteIds(builder, QteIdsOffset);
			IQteHourglass.AddNullMask(builder, NullMask);
			IQteHourglass.AddType(builder, Type);
			return IQteHourglass.EndIQteHourglass(builder);
		}

		// Token: 0x06034B66 RID: 215910 RVA: 0x00716BD5 File Offset: 0x00714DD5
		public static void StartIQteHourglass(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06034B67 RID: 215911 RVA: 0x00716BDE File Offset: 0x00714DDE
		public static void AddType(FlatBufferBuilder builder, ESimpleGameplayType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06034B68 RID: 215912 RVA: 0x00716BE9 File Offset: 0x00714DE9
		public static void AddQteIds(FlatBufferBuilder builder, VectorOffset qteIdsOffset)
		{
			builder.AddOffset(1, qteIdsOffset.Value, 0);
		}

		// Token: 0x06034B69 RID: 215913 RVA: 0x00716BFC File Offset: 0x00714DFC
		public static VectorOffset CreateQteIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06034B6A RID: 215914 RVA: 0x00716C33 File Offset: 0x00714E33
		public static VectorOffset CreateQteIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06034B6B RID: 215915 RVA: 0x00716C4D File Offset: 0x00714E4D
		public static VectorOffset CreateQteIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06034B6C RID: 215916 RVA: 0x00716C6B File Offset: 0x00714E6B
		public static VectorOffset CreateQteIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06034B6D RID: 215917 RVA: 0x00716C84 File Offset: 0x00714E84
		public static void StartQteIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06034B6E RID: 215918 RVA: 0x00716C8F File Offset: 0x00714E8F
		public static void AddQteConfigs(FlatBufferBuilder builder, VectorOffset qteConfigsOffset)
		{
			builder.AddOffset(2, qteConfigsOffset.Value, 0);
		}

		// Token: 0x06034B6F RID: 215919 RVA: 0x00716CA0 File Offset: 0x00714EA0
		public static VectorOffset CreateQteConfigsVector(FlatBufferBuilder builder, Offset<IQteHourglassConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06034B70 RID: 215920 RVA: 0x00716CE0 File Offset: 0x00714EE0
		public static VectorOffset CreateQteConfigsVectorBlock(FlatBufferBuilder builder, Offset<IQteHourglassConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IQteHourglassConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06034B71 RID: 215921 RVA: 0x00716CFA File Offset: 0x00714EFA
		public static VectorOffset CreateQteConfigsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IQteHourglassConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IQteHourglassConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06034B72 RID: 215922 RVA: 0x00716D18 File Offset: 0x00714F18
		public static VectorOffset CreateQteConfigsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IQteHourglassConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06034B73 RID: 215923 RVA: 0x00716D31 File Offset: 0x00714F31
		public static void StartQteConfigsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06034B74 RID: 215924 RVA: 0x00716D3C File Offset: 0x00714F3C
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06034B75 RID: 215925 RVA: 0x00716D47 File Offset: 0x00714F47
		public static Offset<IQteHourglass> EndIQteHourglass(FlatBufferBuilder builder)
		{
			return new Offset<IQteHourglass>(builder.EndTable());
		}

		// Token: 0x06034B76 RID: 215926 RVA: 0x00716D54 File Offset: 0x00714F54
		public IQteHourglassT UnPack()
		{
			IQteHourglassT qteHourglassT = new IQteHourglassT();
			this.UnPackTo(qteHourglassT);
			return qteHourglassT;
		}

		// Token: 0x06034B77 RID: 215927 RVA: 0x00716D70 File Offset: 0x00714F70
		public void UnPackTo(IQteHourglassT _o)
		{
			_o.Type = this.Type;
			_o.QteIds = new List<int>();
			for (int i = 0; i < this.QteIdsLength; i++)
			{
				_o.QteIds.Add(this.QteIds(i));
			}
			_o.QteConfigs = new List<IQteHourglassConfigT>();
			for (int j = 0; j < this.QteConfigsLength; j++)
			{
				_o.QteConfigs.Add((this.QteConfigs(j) != null) ? this.QteConfigs(j).Value.UnPack() : null);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06034B78 RID: 215928 RVA: 0x00716E18 File Offset: 0x00715018
		public static Offset<IQteHourglass> Pack(FlatBufferBuilder builder, IQteHourglassT _o)
		{
			if (_o == null)
			{
				return default(Offset<IQteHourglass>);
			}
			VectorOffset qteIdsOffset = default(VectorOffset);
			if (_o.QteIds != null)
			{
				int[] data = _o.QteIds.ToArray();
				qteIdsOffset = IQteHourglass.CreateQteIdsVector(builder, data);
			}
			VectorOffset qteConfigsOffset = default(VectorOffset);
			if (_o.QteConfigs != null)
			{
				Offset<IQteHourglassConfig>[] array = new Offset<IQteHourglassConfig>[_o.QteConfigs.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IQteHourglassConfig.Pack(builder, _o.QteConfigs[i]);
				}
				qteConfigsOffset = IQteHourglass.CreateQteConfigsVector(builder, array);
			}
			return IQteHourglass.CreateIQteHourglass(builder, _o.Type, qteIdsOffset, qteConfigsOffset, _o.NullMask);
		}

		// Token: 0x04012748 RID: 75592
		private Table __p;
	}
}
