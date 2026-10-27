using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005BD6 RID: 23510
	public struct IWuWaGoSaveGrid : IFlatbufferObject
	{
		// Token: 0x1700B1A6 RID: 45478
		// (get) Token: 0x06028485 RID: 164997 RVA: 0x00588E5E File Offset: 0x0058705E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06028486 RID: 164998 RVA: 0x00588E6B File Offset: 0x0058706B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06028487 RID: 164999 RVA: 0x00588E74 File Offset: 0x00587074
		public static IWuWaGoSaveGrid GetRootAsIWuWaGoSaveGrid(ByteBuffer _bb)
		{
			return IWuWaGoSaveGrid.GetRootAsIWuWaGoSaveGrid(_bb, default(IWuWaGoSaveGrid));
		}

		// Token: 0x06028488 RID: 165000 RVA: 0x00588E90 File Offset: 0x00587090
		public static IWuWaGoSaveGrid GetRootAsIWuWaGoSaveGrid(ByteBuffer _bb, IWuWaGoSaveGrid obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06028489 RID: 165001 RVA: 0x00588EAD File Offset: 0x005870AD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602848A RID: 165002 RVA: 0x00588EBC File Offset: 0x005870BC
		public IWuWaGoSaveGrid __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B1A7 RID: 45479
		// (get) Token: 0x0602848B RID: 165003 RVA: 0x00588ECC File Offset: 0x005870CC
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

		// Token: 0x1700B1A8 RID: 45480
		// (get) Token: 0x0602848C RID: 165004 RVA: 0x00588F08 File Offset: 0x00587108
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

		// Token: 0x0602848D RID: 165005 RVA: 0x00588F5C File Offset: 0x0058715C
		public TWuWaGoHintStep HintStepsType(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return TWuWaGoHintStep.NONE;
			}
			return (TWuWaGoHintStep)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x1700B1A9 RID: 45481
		// (get) Token: 0x0602848E RID: 165006 RVA: 0x00588F9C File Offset: 0x0058719C
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

		// Token: 0x0602848F RID: 165007 RVA: 0x00588FC7 File Offset: 0x005871C7
		public Span<TWuWaGoHintStep> GetHintStepsTypeBytes()
		{
			return this.__p.__vector_as_span<TWuWaGoHintStep>(8, 1);
		}

		// Token: 0x06028490 RID: 165008 RVA: 0x00588FD8 File Offset: 0x005871D8
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

		// Token: 0x06028491 RID: 165009 RVA: 0x00589044 File Offset: 0x00587244
		public TTable? HintSteps<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x1700B1AA RID: 45482
		// (get) Token: 0x06028492 RID: 165010 RVA: 0x0058908C File Offset: 0x0058728C
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

		// Token: 0x1700B1AB RID: 45483
		// (get) Token: 0x06028493 RID: 165011 RVA: 0x005890B8 File Offset: 0x005872B8
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

		// Token: 0x06028494 RID: 165012 RVA: 0x005890F5 File Offset: 0x005872F5
		public static Offset<IWuWaGoSaveGrid> CreateIWuWaGoSaveGrid(FlatBufferBuilder builder, EWuWaGoEntityType Type = EWuWaGoEntityType.LevelCenter, IWuWaGoGridLinkDataT LinkData = null, VectorOffset HintSteps_typeOffset = default(VectorOffset), VectorOffset HintStepsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(5);
			IWuWaGoSaveGrid.AddHintSteps(builder, HintStepsOffset);
			IWuWaGoSaveGrid.AddHintStepsType(builder, HintSteps_typeOffset);
			IWuWaGoSaveGrid.AddLinkData(builder, IWuWaGoGridLinkData.Pack(builder, LinkData));
			IWuWaGoSaveGrid.AddNullMask(builder, NullMask);
			IWuWaGoSaveGrid.AddType(builder, Type);
			return IWuWaGoSaveGrid.EndIWuWaGoSaveGrid(builder);
		}

		// Token: 0x06028495 RID: 165013 RVA: 0x0058912F File Offset: 0x0058732F
		public static void StartIWuWaGoSaveGrid(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06028496 RID: 165014 RVA: 0x00589138 File Offset: 0x00587338
		public static void AddType(FlatBufferBuilder builder, EWuWaGoEntityType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06028497 RID: 165015 RVA: 0x00589143 File Offset: 0x00587343
		public static void AddLinkData(FlatBufferBuilder builder, Offset<IWuWaGoGridLinkData> linkDataOffset)
		{
			builder.AddStruct(1, linkDataOffset.Value, 0);
		}

		// Token: 0x06028498 RID: 165016 RVA: 0x00589153 File Offset: 0x00587353
		public static void AddHintStepsType(FlatBufferBuilder builder, VectorOffset hintStepsTypeOffset)
		{
			builder.AddOffset(2, hintStepsTypeOffset.Value, 0);
		}

		// Token: 0x06028499 RID: 165017 RVA: 0x00589164 File Offset: 0x00587364
		public static VectorOffset CreateHintStepsTypeVector(FlatBufferBuilder builder, TWuWaGoHintStep[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602849A RID: 165018 RVA: 0x0058919B File Offset: 0x0058739B
		public static VectorOffset CreateHintStepsTypeVectorBlock(FlatBufferBuilder builder, TWuWaGoHintStep[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TWuWaGoHintStep>(data);
			return builder.EndVector();
		}

		// Token: 0x0602849B RID: 165019 RVA: 0x005891B5 File Offset: 0x005873B5
		public static VectorOffset CreateHintStepsTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TWuWaGoHintStep> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TWuWaGoHintStep>(data);
			return builder.EndVector();
		}

		// Token: 0x0602849C RID: 165020 RVA: 0x005891D3 File Offset: 0x005873D3
		public static VectorOffset CreateHintStepsTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TWuWaGoHintStep>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602849D RID: 165021 RVA: 0x005891EC File Offset: 0x005873EC
		public static void StartHintStepsTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x0602849E RID: 165022 RVA: 0x005891F7 File Offset: 0x005873F7
		public static void AddHintSteps(FlatBufferBuilder builder, VectorOffset hintStepsOffset)
		{
			builder.AddOffset(3, hintStepsOffset.Value, 0);
		}

		// Token: 0x0602849F RID: 165023 RVA: 0x00589208 File Offset: 0x00587408
		public static VectorOffset CreateHintStepsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x060284A0 RID: 165024 RVA: 0x0058923F File Offset: 0x0058743F
		public static VectorOffset CreateHintStepsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060284A1 RID: 165025 RVA: 0x00589259 File Offset: 0x00587459
		public static VectorOffset CreateHintStepsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060284A2 RID: 165026 RVA: 0x00589277 File Offset: 0x00587477
		public static VectorOffset CreateHintStepsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060284A3 RID: 165027 RVA: 0x00589290 File Offset: 0x00587490
		public static void StartHintStepsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060284A4 RID: 165028 RVA: 0x0058929B File Offset: 0x0058749B
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x060284A5 RID: 165029 RVA: 0x005892A6 File Offset: 0x005874A6
		public static Offset<IWuWaGoSaveGrid> EndIWuWaGoSaveGrid(FlatBufferBuilder builder)
		{
			return new Offset<IWuWaGoSaveGrid>(builder.EndTable());
		}

		// Token: 0x060284A6 RID: 165030 RVA: 0x005892B4 File Offset: 0x005874B4
		public IWuWaGoSaveGridT UnPack()
		{
			IWuWaGoSaveGridT wuWaGoSaveGridT = new IWuWaGoSaveGridT();
			this.UnPackTo(wuWaGoSaveGridT);
			return wuWaGoSaveGridT;
		}

		// Token: 0x060284A7 RID: 165031 RVA: 0x005892D0 File Offset: 0x005874D0
		public void UnPackTo(IWuWaGoSaveGridT _o)
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

		// Token: 0x060284A8 RID: 165032 RVA: 0x005893E4 File Offset: 0x005875E4
		public static Offset<IWuWaGoSaveGrid> Pack(FlatBufferBuilder builder, IWuWaGoSaveGridT _o)
		{
			if (_o == null)
			{
				return default(Offset<IWuWaGoSaveGrid>);
			}
			VectorOffset hintSteps_typeOffset = default(VectorOffset);
			if (_o.HintSteps != null)
			{
				TWuWaGoHintStep[] array = new TWuWaGoHintStep[_o.HintSteps.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = _o.HintSteps[i].Type;
				}
				hintSteps_typeOffset = IWuWaGoSaveGrid.CreateHintStepsTypeVector(builder, array);
			}
			VectorOffset hintStepsOffset = default(VectorOffset);
			if (_o.HintSteps != null)
			{
				int[] array2 = new int[_o.HintSteps.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = TWuWaGoHintStepUnion.Pack(builder, _o.HintSteps[j]);
				}
				hintStepsOffset = IWuWaGoSaveGrid.CreateHintStepsVector(builder, array2);
			}
			return IWuWaGoSaveGrid.CreateIWuWaGoSaveGrid(builder, _o.Type, _o.LinkData, hintSteps_typeOffset, hintStepsOffset, _o.NullMask);
		}

		// Token: 0x0400F355 RID: 62293
		private Table __p;
	}
}
