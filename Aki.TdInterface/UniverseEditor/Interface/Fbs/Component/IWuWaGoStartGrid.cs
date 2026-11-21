using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020061F2 RID: 25074
	public struct IWuWaGoStartGrid : IFlatbufferObject
	{
		// Token: 0x1700BAFD RID: 47869
		// (get) Token: 0x0602AA8D RID: 174733 RVA: 0x005D1266 File Offset: 0x005CF466
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602AA8E RID: 174734 RVA: 0x005D1273 File Offset: 0x005CF473
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602AA8F RID: 174735 RVA: 0x005D127C File Offset: 0x005CF47C
		public static IWuWaGoStartGrid GetRootAsIWuWaGoStartGrid(ByteBuffer _bb)
		{
			return IWuWaGoStartGrid.GetRootAsIWuWaGoStartGrid(_bb, default(IWuWaGoStartGrid));
		}

		// Token: 0x0602AA90 RID: 174736 RVA: 0x005D1298 File Offset: 0x005CF498
		public static IWuWaGoStartGrid GetRootAsIWuWaGoStartGrid(ByteBuffer _bb, IWuWaGoStartGrid obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602AA91 RID: 174737 RVA: 0x005D12B5 File Offset: 0x005CF4B5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602AA92 RID: 174738 RVA: 0x005D12C4 File Offset: 0x005CF4C4
		public IWuWaGoStartGrid __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BAFE RID: 47870
		// (get) Token: 0x0602AA93 RID: 174739 RVA: 0x005D12D4 File Offset: 0x005CF4D4
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

		// Token: 0x1700BAFF RID: 47871
		// (get) Token: 0x0602AA94 RID: 174740 RVA: 0x005D1310 File Offset: 0x005CF510
		public IWuWaGoGridLinkData? LinkData
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IWuWaGoGridLinkData?(default(IWuWaGoGridLinkData).__assign(num + this.__p.bb_pos, this.__p.bb));
			}
		}

		// Token: 0x0602AA95 RID: 174741 RVA: 0x005D1364 File Offset: 0x005CF564
		public TWuWaGoHintStep HintStepsType(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return TWuWaGoHintStep.NONE;
			}
			return (TWuWaGoHintStep)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x1700BB00 RID: 47872
		// (get) Token: 0x0602AA96 RID: 174742 RVA: 0x005D13A4 File Offset: 0x005CF5A4
		public int HintStepsTypeLength
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

		// Token: 0x0602AA97 RID: 174743 RVA: 0x005D13CF File Offset: 0x005CF5CF
		public Span<TWuWaGoHintStep> GetHintStepsTypeBytes()
		{
			return this.__p.__vector_as_span<TWuWaGoHintStep>(8, 1);
		}

		// Token: 0x0602AA98 RID: 174744 RVA: 0x005D13E0 File Offset: 0x005CF5E0
		public TWuWaGoHintStep[] GetHintStepsTypeArray()
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			int num2 = this.__p.__vector(num);
			int num3 = this.__p.__vector_len(num);
			TWuWaGoHintStep[] array = new TWuWaGoHintStep[num3];
			for (int i = 0; i < num3; i++)
			{
				array[i] = (TWuWaGoHintStep)this.__p.bb.Get(num2 + i);
			}
			return array;
		}

		// Token: 0x0602AA99 RID: 174745 RVA: 0x005D144C File Offset: 0x005CF64C
		public TTable? HintSteps<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x1700BB01 RID: 47873
		// (get) Token: 0x0602AA9A RID: 174746 RVA: 0x005D1494 File Offset: 0x005CF694
		public int HintStepsLength
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

		// Token: 0x1700BB02 RID: 47874
		// (get) Token: 0x0602AA9B RID: 174747 RVA: 0x005D14C0 File Offset: 0x005CF6C0
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602AA9C RID: 174748 RVA: 0x005D14FD File Offset: 0x005CF6FD
		public static Offset<IWuWaGoStartGrid> CreateIWuWaGoStartGrid(FlatBufferBuilder builder, EWuWaGoEntityType Type = EWuWaGoEntityType.LevelCenter, IWuWaGoGridLinkDataT LinkData = null, VectorOffset HintSteps_typeOffset = default(VectorOffset), VectorOffset HintStepsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(5);
			IWuWaGoStartGrid.AddHintSteps(builder, HintStepsOffset);
			IWuWaGoStartGrid.AddHintStepsType(builder, HintSteps_typeOffset);
			IWuWaGoStartGrid.AddLinkData(builder, IWuWaGoGridLinkData.Pack(builder, LinkData));
			IWuWaGoStartGrid.AddNullMask(builder, NullMask);
			IWuWaGoStartGrid.AddType(builder, Type);
			return IWuWaGoStartGrid.EndIWuWaGoStartGrid(builder);
		}

		// Token: 0x0602AA9D RID: 174749 RVA: 0x005D1537 File Offset: 0x005CF737
		public static void StartIWuWaGoStartGrid(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0602AA9E RID: 174750 RVA: 0x005D1540 File Offset: 0x005CF740
		public static void AddType(FlatBufferBuilder builder, EWuWaGoEntityType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602AA9F RID: 174751 RVA: 0x005D154B File Offset: 0x005CF74B
		public static void AddLinkData(FlatBufferBuilder builder, Offset<IWuWaGoGridLinkData> linkDataOffset)
		{
			builder.AddStruct(1, linkDataOffset.Value, 0);
		}

		// Token: 0x0602AAA0 RID: 174752 RVA: 0x005D155B File Offset: 0x005CF75B
		public static void AddHintStepsType(FlatBufferBuilder builder, VectorOffset hintStepsTypeOffset)
		{
			builder.AddOffset(2, hintStepsTypeOffset.Value, 0);
		}

		// Token: 0x0602AAA1 RID: 174753 RVA: 0x005D156C File Offset: 0x005CF76C
		public static VectorOffset CreateHintStepsTypeVector(FlatBufferBuilder builder, TWuWaGoHintStep[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602AAA2 RID: 174754 RVA: 0x005D15A3 File Offset: 0x005CF7A3
		public static VectorOffset CreateHintStepsTypeVectorBlock(FlatBufferBuilder builder, TWuWaGoHintStep[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TWuWaGoHintStep>(data);
			return builder.EndVector();
		}

		// Token: 0x0602AAA3 RID: 174755 RVA: 0x005D15BD File Offset: 0x005CF7BD
		public static VectorOffset CreateHintStepsTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TWuWaGoHintStep> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TWuWaGoHintStep>(data);
			return builder.EndVector();
		}

		// Token: 0x0602AAA4 RID: 174756 RVA: 0x005D15DB File Offset: 0x005CF7DB
		public static VectorOffset CreateHintStepsTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TWuWaGoHintStep>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602AAA5 RID: 174757 RVA: 0x005D15F4 File Offset: 0x005CF7F4
		public static void StartHintStepsTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x0602AAA6 RID: 174758 RVA: 0x005D15FF File Offset: 0x005CF7FF
		public static void AddHintSteps(FlatBufferBuilder builder, VectorOffset hintStepsOffset)
		{
			builder.AddOffset(3, hintStepsOffset.Value, 0);
		}

		// Token: 0x0602AAA7 RID: 174759 RVA: 0x005D1610 File Offset: 0x005CF810
		public static VectorOffset CreateHintStepsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602AAA8 RID: 174760 RVA: 0x005D1647 File Offset: 0x005CF847
		public static VectorOffset CreateHintStepsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602AAA9 RID: 174761 RVA: 0x005D1661 File Offset: 0x005CF861
		public static VectorOffset CreateHintStepsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602AAAA RID: 174762 RVA: 0x005D167F File Offset: 0x005CF87F
		public static VectorOffset CreateHintStepsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602AAAB RID: 174763 RVA: 0x005D1698 File Offset: 0x005CF898
		public static void StartHintStepsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602AAAC RID: 174764 RVA: 0x005D16A3 File Offset: 0x005CF8A3
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x0602AAAD RID: 174765 RVA: 0x005D16AE File Offset: 0x005CF8AE
		public static Offset<IWuWaGoStartGrid> EndIWuWaGoStartGrid(FlatBufferBuilder builder)
		{
			return new Offset<IWuWaGoStartGrid>(builder.EndTable());
		}

		// Token: 0x0602AAAE RID: 174766 RVA: 0x005D16BC File Offset: 0x005CF8BC
		public IWuWaGoStartGridT UnPack()
		{
			IWuWaGoStartGridT wuWaGoStartGridT = new IWuWaGoStartGridT();
			this.UnPackTo(wuWaGoStartGridT);
			return wuWaGoStartGridT;
		}

		// Token: 0x0602AAAF RID: 174767 RVA: 0x005D16D8 File Offset: 0x005CF8D8
		public void UnPackTo(IWuWaGoStartGridT _o)
		{
			_o.Type = this.Type;
			_o.LinkData = ((this.LinkData != null) ? this.LinkData.Value.UnPack() : null);
			_o.HintSteps = new List<TWuWaGoHintStepUnion>();
			for (int i = 0; i < this.HintStepsLength; i++)
			{
				TWuWaGoHintStepUnion twuWaGoHintStepUnion = new TWuWaGoHintStepUnion();
				twuWaGoHintStepUnion.Type = this.HintStepsType(i);
				TWuWaGoHintStep twuWaGoHintStep = this.HintStepsType(i);
				if (twuWaGoHintStep != TWuWaGoHintStep.IWuWaGoHintStepInteract)
				{
					if (twuWaGoHintStep == TWuWaGoHintStep.IWuWaGoHintStepMove)
					{
						twuWaGoHintStepUnion.Value = ((this.HintSteps<IWuWaGoHintStepMove>(i) != null) ? this.HintSteps<IWuWaGoHintStepMove>(i).Value.UnPack() : null);
					}
				}
				else
				{
					twuWaGoHintStepUnion.Value = ((this.HintSteps<IWuWaGoHintStepInteract>(i) != null) ? this.HintSteps<IWuWaGoHintStepInteract>(i).Value.UnPack() : null);
				}
				_o.HintSteps.Add(twuWaGoHintStepUnion);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602AAB0 RID: 174768 RVA: 0x005D17EC File Offset: 0x005CF9EC
		public static Offset<IWuWaGoStartGrid> Pack(FlatBufferBuilder builder, IWuWaGoStartGridT _o)
		{
			if (_o == null)
			{
				return default(Offset<IWuWaGoStartGrid>);
			}
			VectorOffset hintSteps_typeOffset = default(VectorOffset);
			if (_o.HintSteps != null)
			{
				TWuWaGoHintStep[] array = new TWuWaGoHintStep[_o.HintSteps.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = _o.HintSteps[i].Type;
				}
				hintSteps_typeOffset = IWuWaGoStartGrid.CreateHintStepsTypeVector(builder, array);
			}
			VectorOffset hintStepsOffset = default(VectorOffset);
			if (_o.HintSteps != null)
			{
				int[] array2 = new int[_o.HintSteps.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = TWuWaGoHintStepUnion.Pack(builder, _o.HintSteps[j]);
				}
				hintStepsOffset = IWuWaGoStartGrid.CreateHintStepsVector(builder, array2);
			}
			return IWuWaGoStartGrid.CreateIWuWaGoStartGrid(builder, _o.Type, _o.LinkData, hintSteps_typeOffset, hintStepsOffset, _o.NullMask);
		}

		// Token: 0x04010063 RID: 65635
		private Table __p;
	}
}
