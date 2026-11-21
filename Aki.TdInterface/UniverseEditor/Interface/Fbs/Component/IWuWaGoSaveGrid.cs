using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020061EC RID: 25068
	public struct IWuWaGoSaveGrid : IFlatbufferObject
	{
		// Token: 0x1700BAEE RID: 47854
		// (get) Token: 0x0602AA49 RID: 174665 RVA: 0x005D08EE File Offset: 0x005CEAEE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602AA4A RID: 174666 RVA: 0x005D08FB File Offset: 0x005CEAFB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602AA4B RID: 174667 RVA: 0x005D0904 File Offset: 0x005CEB04
		public static IWuWaGoSaveGrid GetRootAsIWuWaGoSaveGrid(ByteBuffer _bb)
		{
			return IWuWaGoSaveGrid.GetRootAsIWuWaGoSaveGrid(_bb, default(IWuWaGoSaveGrid));
		}

		// Token: 0x0602AA4C RID: 174668 RVA: 0x005D0920 File Offset: 0x005CEB20
		public static IWuWaGoSaveGrid GetRootAsIWuWaGoSaveGrid(ByteBuffer _bb, IWuWaGoSaveGrid obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602AA4D RID: 174669 RVA: 0x005D093D File Offset: 0x005CEB3D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602AA4E RID: 174670 RVA: 0x005D094C File Offset: 0x005CEB4C
		public IWuWaGoSaveGrid __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BAEF RID: 47855
		// (get) Token: 0x0602AA4F RID: 174671 RVA: 0x005D095C File Offset: 0x005CEB5C
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

		// Token: 0x1700BAF0 RID: 47856
		// (get) Token: 0x0602AA50 RID: 174672 RVA: 0x005D0998 File Offset: 0x005CEB98
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

		// Token: 0x0602AA51 RID: 174673 RVA: 0x005D09EC File Offset: 0x005CEBEC
		public TWuWaGoHintStep HintStepsType(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return TWuWaGoHintStep.NONE;
			}
			return (TWuWaGoHintStep)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x1700BAF1 RID: 47857
		// (get) Token: 0x0602AA52 RID: 174674 RVA: 0x005D0A2C File Offset: 0x005CEC2C
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

		// Token: 0x0602AA53 RID: 174675 RVA: 0x005D0A57 File Offset: 0x005CEC57
		public Span<TWuWaGoHintStep> GetHintStepsTypeBytes()
		{
			return this.__p.__vector_as_span<TWuWaGoHintStep>(8, 1);
		}

		// Token: 0x0602AA54 RID: 174676 RVA: 0x005D0A68 File Offset: 0x005CEC68
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

		// Token: 0x0602AA55 RID: 174677 RVA: 0x005D0AD4 File Offset: 0x005CECD4
		public TTable? HintSteps<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x1700BAF2 RID: 47858
		// (get) Token: 0x0602AA56 RID: 174678 RVA: 0x005D0B1C File Offset: 0x005CED1C
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

		// Token: 0x1700BAF3 RID: 47859
		// (get) Token: 0x0602AA57 RID: 174679 RVA: 0x005D0B48 File Offset: 0x005CED48
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

		// Token: 0x0602AA58 RID: 174680 RVA: 0x005D0B85 File Offset: 0x005CED85
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

		// Token: 0x0602AA59 RID: 174681 RVA: 0x005D0BBF File Offset: 0x005CEDBF
		public static void StartIWuWaGoSaveGrid(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0602AA5A RID: 174682 RVA: 0x005D0BC8 File Offset: 0x005CEDC8
		public static void AddType(FlatBufferBuilder builder, EWuWaGoEntityType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602AA5B RID: 174683 RVA: 0x005D0BD3 File Offset: 0x005CEDD3
		public static void AddLinkData(FlatBufferBuilder builder, Offset<IWuWaGoGridLinkData> linkDataOffset)
		{
			builder.AddStruct(1, linkDataOffset.Value, 0);
		}

		// Token: 0x0602AA5C RID: 174684 RVA: 0x005D0BE3 File Offset: 0x005CEDE3
		public static void AddHintStepsType(FlatBufferBuilder builder, VectorOffset hintStepsTypeOffset)
		{
			builder.AddOffset(2, hintStepsTypeOffset.Value, 0);
		}

		// Token: 0x0602AA5D RID: 174685 RVA: 0x005D0BF4 File Offset: 0x005CEDF4
		public static VectorOffset CreateHintStepsTypeVector(FlatBufferBuilder builder, TWuWaGoHintStep[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602AA5E RID: 174686 RVA: 0x005D0C2B File Offset: 0x005CEE2B
		public static VectorOffset CreateHintStepsTypeVectorBlock(FlatBufferBuilder builder, TWuWaGoHintStep[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TWuWaGoHintStep>(data);
			return builder.EndVector();
		}

		// Token: 0x0602AA5F RID: 174687 RVA: 0x005D0C45 File Offset: 0x005CEE45
		public static VectorOffset CreateHintStepsTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TWuWaGoHintStep> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TWuWaGoHintStep>(data);
			return builder.EndVector();
		}

		// Token: 0x0602AA60 RID: 174688 RVA: 0x005D0C63 File Offset: 0x005CEE63
		public static VectorOffset CreateHintStepsTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TWuWaGoHintStep>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602AA61 RID: 174689 RVA: 0x005D0C7C File Offset: 0x005CEE7C
		public static void StartHintStepsTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x0602AA62 RID: 174690 RVA: 0x005D0C87 File Offset: 0x005CEE87
		public static void AddHintSteps(FlatBufferBuilder builder, VectorOffset hintStepsOffset)
		{
			builder.AddOffset(3, hintStepsOffset.Value, 0);
		}

		// Token: 0x0602AA63 RID: 174691 RVA: 0x005D0C98 File Offset: 0x005CEE98
		public static VectorOffset CreateHintStepsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602AA64 RID: 174692 RVA: 0x005D0CCF File Offset: 0x005CEECF
		public static VectorOffset CreateHintStepsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602AA65 RID: 174693 RVA: 0x005D0CE9 File Offset: 0x005CEEE9
		public static VectorOffset CreateHintStepsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602AA66 RID: 174694 RVA: 0x005D0D07 File Offset: 0x005CEF07
		public static VectorOffset CreateHintStepsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602AA67 RID: 174695 RVA: 0x005D0D20 File Offset: 0x005CEF20
		public static void StartHintStepsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602AA68 RID: 174696 RVA: 0x005D0D2B File Offset: 0x005CEF2B
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x0602AA69 RID: 174697 RVA: 0x005D0D36 File Offset: 0x005CEF36
		public static Offset<IWuWaGoSaveGrid> EndIWuWaGoSaveGrid(FlatBufferBuilder builder)
		{
			return new Offset<IWuWaGoSaveGrid>(builder.EndTable());
		}

		// Token: 0x0602AA6A RID: 174698 RVA: 0x005D0D44 File Offset: 0x005CEF44
		public IWuWaGoSaveGridT UnPack()
		{
			IWuWaGoSaveGridT wuWaGoSaveGridT = new IWuWaGoSaveGridT();
			this.UnPackTo(wuWaGoSaveGridT);
			return wuWaGoSaveGridT;
		}

		// Token: 0x0602AA6B RID: 174699 RVA: 0x005D0D60 File Offset: 0x005CEF60
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

		// Token: 0x0602AA6C RID: 174700 RVA: 0x005D0E74 File Offset: 0x005CF074
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

		// Token: 0x0401005B RID: 65627
		private Table __p;
	}
}
