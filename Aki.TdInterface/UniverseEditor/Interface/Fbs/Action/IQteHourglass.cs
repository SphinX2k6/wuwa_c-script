using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006DF2 RID: 28146
	public struct IQteHourglass : IFlatbufferObject
	{
		// Token: 0x1700D1C0 RID: 53696
		// (get) Token: 0x06031B5B RID: 203611 RVA: 0x006BB2C5 File Offset: 0x006B94C5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031B5C RID: 203612 RVA: 0x006BB2D2 File Offset: 0x006B94D2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06031B5D RID: 203613 RVA: 0x006BB2DC File Offset: 0x006B94DC
		public static IQteHourglass GetRootAsIQteHourglass(ByteBuffer _bb)
		{
			return IQteHourglass.GetRootAsIQteHourglass(_bb, default(IQteHourglass));
		}

		// Token: 0x06031B5E RID: 203614 RVA: 0x006BB2F8 File Offset: 0x006B94F8
		public static IQteHourglass GetRootAsIQteHourglass(ByteBuffer _bb, IQteHourglass obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06031B5F RID: 203615 RVA: 0x006BB315 File Offset: 0x006B9515
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031B60 RID: 203616 RVA: 0x006BB324 File Offset: 0x006B9524
		public IQteHourglass __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D1C1 RID: 53697
		// (get) Token: 0x06031B61 RID: 203617 RVA: 0x006BB334 File Offset: 0x006B9534
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

		// Token: 0x06031B62 RID: 203618 RVA: 0x006BB370 File Offset: 0x006B9570
		public int QteIds(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700D1C2 RID: 53698
		// (get) Token: 0x06031B63 RID: 203619 RVA: 0x006BB3B0 File Offset: 0x006B95B0
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

		// Token: 0x06031B64 RID: 203620 RVA: 0x006BB3DB File Offset: 0x006B95DB
		public Span<int> GetQteIdsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x06031B65 RID: 203621 RVA: 0x006BB3EA File Offset: 0x006B95EA
		public int[] GetQteIdsArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x06031B66 RID: 203622 RVA: 0x006BB3F8 File Offset: 0x006B95F8
		public IQteHourglassConfig? QteConfigs(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IQteHourglassConfig?(default(IQteHourglassConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700D1C3 RID: 53699
		// (get) Token: 0x06031B67 RID: 203623 RVA: 0x006BB458 File Offset: 0x006B9658
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

		// Token: 0x1700D1C4 RID: 53700
		// (get) Token: 0x06031B68 RID: 203624 RVA: 0x006BB484 File Offset: 0x006B9684
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

		// Token: 0x06031B69 RID: 203625 RVA: 0x006BB4C1 File Offset: 0x006B96C1
		public static Offset<IQteHourglass> CreateIQteHourglass(FlatBufferBuilder builder, ESimpleGameplayType Type = ESimpleGameplayType.Cipher, VectorOffset QteIdsOffset = default(VectorOffset), VectorOffset QteConfigsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(4);
			IQteHourglass.AddQteConfigs(builder, QteConfigsOffset);
			IQteHourglass.AddQteIds(builder, QteIdsOffset);
			IQteHourglass.AddNullMask(builder, NullMask);
			IQteHourglass.AddType(builder, Type);
			return IQteHourglass.EndIQteHourglass(builder);
		}

		// Token: 0x06031B6A RID: 203626 RVA: 0x006BB4ED File Offset: 0x006B96ED
		public static void StartIQteHourglass(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06031B6B RID: 203627 RVA: 0x006BB4F6 File Offset: 0x006B96F6
		public static void AddType(FlatBufferBuilder builder, ESimpleGameplayType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06031B6C RID: 203628 RVA: 0x006BB501 File Offset: 0x006B9701
		public static void AddQteIds(FlatBufferBuilder builder, VectorOffset qteIdsOffset)
		{
			builder.AddOffset(1, qteIdsOffset.Value, 0);
		}

		// Token: 0x06031B6D RID: 203629 RVA: 0x006BB514 File Offset: 0x006B9714
		public static VectorOffset CreateQteIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06031B6E RID: 203630 RVA: 0x006BB54B File Offset: 0x006B974B
		public static VectorOffset CreateQteIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06031B6F RID: 203631 RVA: 0x006BB565 File Offset: 0x006B9765
		public static VectorOffset CreateQteIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06031B70 RID: 203632 RVA: 0x006BB583 File Offset: 0x006B9783
		public static VectorOffset CreateQteIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06031B71 RID: 203633 RVA: 0x006BB59C File Offset: 0x006B979C
		public static void StartQteIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06031B72 RID: 203634 RVA: 0x006BB5A7 File Offset: 0x006B97A7
		public static void AddQteConfigs(FlatBufferBuilder builder, VectorOffset qteConfigsOffset)
		{
			builder.AddOffset(2, qteConfigsOffset.Value, 0);
		}

		// Token: 0x06031B73 RID: 203635 RVA: 0x006BB5B8 File Offset: 0x006B97B8
		public static VectorOffset CreateQteConfigsVector(FlatBufferBuilder builder, Offset<IQteHourglassConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06031B74 RID: 203636 RVA: 0x006BB5F8 File Offset: 0x006B97F8
		public static VectorOffset CreateQteConfigsVectorBlock(FlatBufferBuilder builder, Offset<IQteHourglassConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IQteHourglassConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06031B75 RID: 203637 RVA: 0x006BB612 File Offset: 0x006B9812
		public static VectorOffset CreateQteConfigsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IQteHourglassConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IQteHourglassConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06031B76 RID: 203638 RVA: 0x006BB630 File Offset: 0x006B9830
		public static VectorOffset CreateQteConfigsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IQteHourglassConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06031B77 RID: 203639 RVA: 0x006BB649 File Offset: 0x006B9849
		public static void StartQteConfigsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06031B78 RID: 203640 RVA: 0x006BB654 File Offset: 0x006B9854
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06031B79 RID: 203641 RVA: 0x006BB65F File Offset: 0x006B985F
		public static Offset<IQteHourglass> EndIQteHourglass(FlatBufferBuilder builder)
		{
			return new Offset<IQteHourglass>(builder.EndTable());
		}

		// Token: 0x06031B7A RID: 203642 RVA: 0x006BB66C File Offset: 0x006B986C
		public IQteHourglassT UnPack()
		{
			IQteHourglassT qteHourglassT = new IQteHourglassT();
			this.UnPackTo(qteHourglassT);
			return qteHourglassT;
		}

		// Token: 0x06031B7B RID: 203643 RVA: 0x006BB688 File Offset: 0x006B9888
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

		// Token: 0x06031B7C RID: 203644 RVA: 0x006BB730 File Offset: 0x006B9930
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

		// Token: 0x040117CC RID: 71628
		private Table __p;
	}
}
