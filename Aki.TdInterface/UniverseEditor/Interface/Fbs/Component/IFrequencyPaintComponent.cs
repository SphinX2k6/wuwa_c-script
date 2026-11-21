using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Shape;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005844 RID: 22596
	public struct IFrequencyPaintComponent : IFlatbufferObject
	{
		// Token: 0x1700A3A6 RID: 41894
		// (get) Token: 0x06024983 RID: 149891 RVA: 0x00507247 File Offset: 0x00505447
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06024984 RID: 149892 RVA: 0x00507254 File Offset: 0x00505454
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06024985 RID: 149893 RVA: 0x0050725C File Offset: 0x0050545C
		public static IFrequencyPaintComponent GetRootAsIFrequencyPaintComponent(ByteBuffer _bb)
		{
			return IFrequencyPaintComponent.GetRootAsIFrequencyPaintComponent(_bb, default(IFrequencyPaintComponent));
		}

		// Token: 0x06024986 RID: 149894 RVA: 0x00507278 File Offset: 0x00505478
		public static IFrequencyPaintComponent GetRootAsIFrequencyPaintComponent(ByteBuffer _bb, IFrequencyPaintComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06024987 RID: 149895 RVA: 0x00507295 File Offset: 0x00505495
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06024988 RID: 149896 RVA: 0x005072A4 File Offset: 0x005054A4
		public IFrequencyPaintComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A3A7 RID: 41895
		// (get) Token: 0x06024989 RID: 149897 RVA: 0x005072B4 File Offset: 0x005054B4
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A3A8 RID: 41896
		// (get) Token: 0x0602498A RID: 149898 RVA: 0x005072F4 File Offset: 0x005054F4
		public bool EnableGuide
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0602498B RID: 149899 RVA: 0x00507334 File Offset: 0x00505534
		public TFrequencyPaintRange RangesType(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return TFrequencyPaintRange.NONE;
			}
			return (TFrequencyPaintRange)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x1700A3A9 RID: 41897
		// (get) Token: 0x0602498C RID: 149900 RVA: 0x00507374 File Offset: 0x00505574
		public int RangesTypeLength
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

		// Token: 0x0602498D RID: 149901 RVA: 0x0050739F File Offset: 0x0050559F
		public Span<TFrequencyPaintRange> GetRangesTypeBytes()
		{
			return this.__p.__vector_as_span<TFrequencyPaintRange>(8, 1);
		}

		// Token: 0x0602498E RID: 149902 RVA: 0x005073B0 File Offset: 0x005055B0
		public TFrequencyPaintRange[] GetRangesTypeArray()
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			int num2 = this.__p.__vector(num);
			int num3 = this.__p.__vector_len(num);
			TFrequencyPaintRange[] array = new TFrequencyPaintRange[num3];
			for (int i = 0; i < num3; i++)
			{
				array[i] = (TFrequencyPaintRange)this.__p.bb.Get(num2 + i);
			}
			return array;
		}

		// Token: 0x0602498F RID: 149903 RVA: 0x0050741C File Offset: 0x0050561C
		public TTable? Ranges<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x1700A3AA RID: 41898
		// (get) Token: 0x06024990 RID: 149904 RVA: 0x00507464 File Offset: 0x00505664
		public int RangesLength
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06024991 RID: 149905 RVA: 0x00507490 File Offset: 0x00505690
		public IFrequencyPaintConfig? PaintConfigs(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new IFrequencyPaintConfig?(default(IFrequencyPaintConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A3AB RID: 41899
		// (get) Token: 0x06024992 RID: 149906 RVA: 0x005074F4 File Offset: 0x005056F4
		public int PaintConfigsLength
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700A3AC RID: 41900
		// (get) Token: 0x06024993 RID: 149907 RVA: 0x00507520 File Offset: 0x00505720
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06024994 RID: 149908 RVA: 0x0050755D File Offset: 0x0050575D
		public static Offset<IFrequencyPaintComponent> CreateIFrequencyPaintComponent(FlatBufferBuilder builder, bool Disabled = false, bool EnableGuide = false, VectorOffset Ranges_typeOffset = default(VectorOffset), VectorOffset RangesOffset = default(VectorOffset), VectorOffset PaintConfigsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(6);
			IFrequencyPaintComponent.AddPaintConfigs(builder, PaintConfigsOffset);
			IFrequencyPaintComponent.AddRanges(builder, RangesOffset);
			IFrequencyPaintComponent.AddRangesType(builder, Ranges_typeOffset);
			IFrequencyPaintComponent.AddNullMask(builder, NullMask);
			IFrequencyPaintComponent.AddEnableGuide(builder, EnableGuide);
			IFrequencyPaintComponent.AddDisabled(builder, Disabled);
			return IFrequencyPaintComponent.EndIFrequencyPaintComponent(builder);
		}

		// Token: 0x06024995 RID: 149909 RVA: 0x00507599 File Offset: 0x00505799
		public static void StartIFrequencyPaintComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x06024996 RID: 149910 RVA: 0x005075A2 File Offset: 0x005057A2
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06024997 RID: 149911 RVA: 0x005075AD File Offset: 0x005057AD
		public static void AddEnableGuide(FlatBufferBuilder builder, bool enableGuide)
		{
			builder.AddBool(1, enableGuide, false);
		}

		// Token: 0x06024998 RID: 149912 RVA: 0x005075B8 File Offset: 0x005057B8
		public static void AddRangesType(FlatBufferBuilder builder, VectorOffset rangesTypeOffset)
		{
			builder.AddOffset(2, rangesTypeOffset.Value, 0);
		}

		// Token: 0x06024999 RID: 149913 RVA: 0x005075C8 File Offset: 0x005057C8
		public static VectorOffset CreateRangesTypeVector(FlatBufferBuilder builder, TFrequencyPaintRange[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602499A RID: 149914 RVA: 0x005075FF File Offset: 0x005057FF
		public static VectorOffset CreateRangesTypeVectorBlock(FlatBufferBuilder builder, TFrequencyPaintRange[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TFrequencyPaintRange>(data);
			return builder.EndVector();
		}

		// Token: 0x0602499B RID: 149915 RVA: 0x00507619 File Offset: 0x00505819
		public static VectorOffset CreateRangesTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TFrequencyPaintRange> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TFrequencyPaintRange>(data);
			return builder.EndVector();
		}

		// Token: 0x0602499C RID: 149916 RVA: 0x00507637 File Offset: 0x00505837
		public static VectorOffset CreateRangesTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TFrequencyPaintRange>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602499D RID: 149917 RVA: 0x00507650 File Offset: 0x00505850
		public static void StartRangesTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x0602499E RID: 149918 RVA: 0x0050765B File Offset: 0x0050585B
		public static void AddRanges(FlatBufferBuilder builder, VectorOffset rangesOffset)
		{
			builder.AddOffset(3, rangesOffset.Value, 0);
		}

		// Token: 0x0602499F RID: 149919 RVA: 0x0050766C File Offset: 0x0050586C
		public static VectorOffset CreateRangesVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x060249A0 RID: 149920 RVA: 0x005076A3 File Offset: 0x005058A3
		public static VectorOffset CreateRangesVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060249A1 RID: 149921 RVA: 0x005076BD File Offset: 0x005058BD
		public static VectorOffset CreateRangesVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060249A2 RID: 149922 RVA: 0x005076DB File Offset: 0x005058DB
		public static VectorOffset CreateRangesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060249A3 RID: 149923 RVA: 0x005076F4 File Offset: 0x005058F4
		public static void StartRangesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060249A4 RID: 149924 RVA: 0x005076FF File Offset: 0x005058FF
		public static void AddPaintConfigs(FlatBufferBuilder builder, VectorOffset paintConfigsOffset)
		{
			builder.AddOffset(4, paintConfigsOffset.Value, 0);
		}

		// Token: 0x060249A5 RID: 149925 RVA: 0x00507710 File Offset: 0x00505910
		public static VectorOffset CreatePaintConfigsVector(FlatBufferBuilder builder, Offset<IFrequencyPaintConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060249A6 RID: 149926 RVA: 0x00507750 File Offset: 0x00505950
		public static VectorOffset CreatePaintConfigsVectorBlock(FlatBufferBuilder builder, Offset<IFrequencyPaintConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IFrequencyPaintConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x060249A7 RID: 149927 RVA: 0x0050776A File Offset: 0x0050596A
		public static VectorOffset CreatePaintConfigsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IFrequencyPaintConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IFrequencyPaintConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x060249A8 RID: 149928 RVA: 0x00507788 File Offset: 0x00505988
		public static VectorOffset CreatePaintConfigsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IFrequencyPaintConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060249A9 RID: 149929 RVA: 0x005077A1 File Offset: 0x005059A1
		public static void StartPaintConfigsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060249AA RID: 149930 RVA: 0x005077AC File Offset: 0x005059AC
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x060249AB RID: 149931 RVA: 0x005077B7 File Offset: 0x005059B7
		public static Offset<IFrequencyPaintComponent> EndIFrequencyPaintComponent(FlatBufferBuilder builder)
		{
			return new Offset<IFrequencyPaintComponent>(builder.EndTable());
		}

		// Token: 0x060249AC RID: 149932 RVA: 0x005077C4 File Offset: 0x005059C4
		public IFrequencyPaintComponentT UnPack()
		{
			IFrequencyPaintComponentT frequencyPaintComponentT = new IFrequencyPaintComponentT();
			this.UnPackTo(frequencyPaintComponentT);
			return frequencyPaintComponentT;
		}

		// Token: 0x060249AD RID: 149933 RVA: 0x005077E0 File Offset: 0x005059E0
		public void UnPackTo(IFrequencyPaintComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.EnableGuide = this.EnableGuide;
			_o.Ranges = new List<TFrequencyPaintRangeUnion>();
			for (int i = 0; i < this.RangesLength; i++)
			{
				TFrequencyPaintRangeUnion tfrequencyPaintRangeUnion = new TFrequencyPaintRangeUnion();
				tfrequencyPaintRangeUnion.Type = this.RangesType(i);
				TFrequencyPaintRange tfrequencyPaintRange = this.RangesType(i);
				if (tfrequencyPaintRange != TFrequencyPaintRange.Aki_UniverseEditor_Interface_Fbs_Shape_IBoxTriggerShape)
				{
					if (tfrequencyPaintRange == TFrequencyPaintRange.Aki_UniverseEditor_Interface_Fbs_Shape_ISphereTriggerShape)
					{
						tfrequencyPaintRangeUnion.Value = ((this.Ranges<ISphereTriggerShape>(i) != null) ? this.Ranges<ISphereTriggerShape>(i).Value.UnPack() : null);
					}
				}
				else
				{
					tfrequencyPaintRangeUnion.Value = ((this.Ranges<IBoxTriggerShape>(i) != null) ? this.Ranges<IBoxTriggerShape>(i).Value.UnPack() : null);
				}
				_o.Ranges.Add(tfrequencyPaintRangeUnion);
			}
			_o.PaintConfigs = new List<IFrequencyPaintConfigT>();
			for (int j = 0; j < this.PaintConfigsLength; j++)
			{
				_o.PaintConfigs.Add((this.PaintConfigs(j) != null) ? this.PaintConfigs(j).Value.UnPack() : null);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060249AE RID: 149934 RVA: 0x00507928 File Offset: 0x00505B28
		public static Offset<IFrequencyPaintComponent> Pack(FlatBufferBuilder builder, IFrequencyPaintComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFrequencyPaintComponent>);
			}
			VectorOffset ranges_typeOffset = default(VectorOffset);
			if (_o.Ranges != null)
			{
				TFrequencyPaintRange[] array = new TFrequencyPaintRange[_o.Ranges.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = _o.Ranges[i].Type;
				}
				ranges_typeOffset = IFrequencyPaintComponent.CreateRangesTypeVector(builder, array);
			}
			VectorOffset rangesOffset = default(VectorOffset);
			if (_o.Ranges != null)
			{
				int[] array2 = new int[_o.Ranges.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = TFrequencyPaintRangeUnion.Pack(builder, _o.Ranges[j]);
				}
				rangesOffset = IFrequencyPaintComponent.CreateRangesVector(builder, array2);
			}
			VectorOffset paintConfigsOffset = default(VectorOffset);
			if (_o.PaintConfigs != null)
			{
				Offset<IFrequencyPaintConfig>[] array3 = new Offset<IFrequencyPaintConfig>[_o.PaintConfigs.Count];
				for (int k = 0; k < array3.Length; k++)
				{
					array3[k] = IFrequencyPaintConfig.Pack(builder, _o.PaintConfigs[k]);
				}
				paintConfigsOffset = IFrequencyPaintComponent.CreatePaintConfigsVector(builder, array3);
			}
			return IFrequencyPaintComponent.CreateIFrequencyPaintComponent(builder, _o.Disabled, _o.EnableGuide, ranges_typeOffset, rangesOffset, paintConfigsOffset, _o.NullMask);
		}

		// Token: 0x0400F07C RID: 61564
		private Table __p;
	}
}
