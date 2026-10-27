using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005BDC RID: 23516
	public struct IWuWaGoStartGrid : IFlatbufferObject
	{
		// Token: 0x1700B1B5 RID: 45493
		// (get) Token: 0x060284C9 RID: 165065 RVA: 0x005897D6 File Offset: 0x005879D6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060284CA RID: 165066 RVA: 0x005897E3 File Offset: 0x005879E3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060284CB RID: 165067 RVA: 0x005897EC File Offset: 0x005879EC
		public static IWuWaGoStartGrid GetRootAsIWuWaGoStartGrid(ByteBuffer _bb)
		{
			return IWuWaGoStartGrid.GetRootAsIWuWaGoStartGrid(_bb, default(IWuWaGoStartGrid));
		}

		// Token: 0x060284CC RID: 165068 RVA: 0x00589808 File Offset: 0x00587A08
		public static IWuWaGoStartGrid GetRootAsIWuWaGoStartGrid(ByteBuffer _bb, IWuWaGoStartGrid obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060284CD RID: 165069 RVA: 0x00589825 File Offset: 0x00587A25
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060284CE RID: 165070 RVA: 0x00589834 File Offset: 0x00587A34
		public IWuWaGoStartGrid __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B1B6 RID: 45494
		// (get) Token: 0x060284CF RID: 165071 RVA: 0x00589844 File Offset: 0x00587A44
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

		// Token: 0x1700B1B7 RID: 45495
		// (get) Token: 0x060284D0 RID: 165072 RVA: 0x00589880 File Offset: 0x00587A80
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

		// Token: 0x060284D1 RID: 165073 RVA: 0x005898D4 File Offset: 0x00587AD4
		public TWuWaGoHintStep HintStepsType(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return TWuWaGoHintStep.NONE;
			}
			return (TWuWaGoHintStep)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x1700B1B8 RID: 45496
		// (get) Token: 0x060284D2 RID: 165074 RVA: 0x00589914 File Offset: 0x00587B14
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

		// Token: 0x060284D3 RID: 165075 RVA: 0x0058993F File Offset: 0x00587B3F
		public Span<TWuWaGoHintStep> GetHintStepsTypeBytes()
		{
			return this.__p.__vector_as_span<TWuWaGoHintStep>(8, 1);
		}

		// Token: 0x060284D4 RID: 165076 RVA: 0x00589950 File Offset: 0x00587B50
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

		// Token: 0x060284D5 RID: 165077 RVA: 0x005899BC File Offset: 0x00587BBC
		public TTable? HintSteps<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x1700B1B9 RID: 45497
		// (get) Token: 0x060284D6 RID: 165078 RVA: 0x00589A04 File Offset: 0x00587C04
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

		// Token: 0x1700B1BA RID: 45498
		// (get) Token: 0x060284D7 RID: 165079 RVA: 0x00589A30 File Offset: 0x00587C30
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

		// Token: 0x060284D8 RID: 165080 RVA: 0x00589A6D File Offset: 0x00587C6D
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

		// Token: 0x060284D9 RID: 165081 RVA: 0x00589AA7 File Offset: 0x00587CA7
		public static void StartIWuWaGoStartGrid(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x060284DA RID: 165082 RVA: 0x00589AB0 File Offset: 0x00587CB0
		public static void AddType(FlatBufferBuilder builder, EWuWaGoEntityType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060284DB RID: 165083 RVA: 0x00589ABB File Offset: 0x00587CBB
		public static void AddLinkData(FlatBufferBuilder builder, Offset<IWuWaGoGridLinkData> linkDataOffset)
		{
			builder.AddStruct(1, linkDataOffset.Value, 0);
		}

		// Token: 0x060284DC RID: 165084 RVA: 0x00589ACB File Offset: 0x00587CCB
		public static void AddHintStepsType(FlatBufferBuilder builder, VectorOffset hintStepsTypeOffset)
		{
			builder.AddOffset(2, hintStepsTypeOffset.Value, 0);
		}

		// Token: 0x060284DD RID: 165085 RVA: 0x00589ADC File Offset: 0x00587CDC
		public static VectorOffset CreateHintStepsTypeVector(FlatBufferBuilder builder, TWuWaGoHintStep[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x060284DE RID: 165086 RVA: 0x00589B13 File Offset: 0x00587D13
		public static VectorOffset CreateHintStepsTypeVectorBlock(FlatBufferBuilder builder, TWuWaGoHintStep[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TWuWaGoHintStep>(data);
			return builder.EndVector();
		}

		// Token: 0x060284DF RID: 165087 RVA: 0x00589B2D File Offset: 0x00587D2D
		public static VectorOffset CreateHintStepsTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TWuWaGoHintStep> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TWuWaGoHintStep>(data);
			return builder.EndVector();
		}

		// Token: 0x060284E0 RID: 165088 RVA: 0x00589B4B File Offset: 0x00587D4B
		public static VectorOffset CreateHintStepsTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TWuWaGoHintStep>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060284E1 RID: 165089 RVA: 0x00589B64 File Offset: 0x00587D64
		public static void StartHintStepsTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x060284E2 RID: 165090 RVA: 0x00589B6F File Offset: 0x00587D6F
		public static void AddHintSteps(FlatBufferBuilder builder, VectorOffset hintStepsOffset)
		{
			builder.AddOffset(3, hintStepsOffset.Value, 0);
		}

		// Token: 0x060284E3 RID: 165091 RVA: 0x00589B80 File Offset: 0x00587D80
		public static VectorOffset CreateHintStepsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x060284E4 RID: 165092 RVA: 0x00589BB7 File Offset: 0x00587DB7
		public static VectorOffset CreateHintStepsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060284E5 RID: 165093 RVA: 0x00589BD1 File Offset: 0x00587DD1
		public static VectorOffset CreateHintStepsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060284E6 RID: 165094 RVA: 0x00589BEF File Offset: 0x00587DEF
		public static VectorOffset CreateHintStepsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060284E7 RID: 165095 RVA: 0x00589C08 File Offset: 0x00587E08
		public static void StartHintStepsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060284E8 RID: 165096 RVA: 0x00589C13 File Offset: 0x00587E13
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x060284E9 RID: 165097 RVA: 0x00589C1E File Offset: 0x00587E1E
		public static Offset<IWuWaGoStartGrid> EndIWuWaGoStartGrid(FlatBufferBuilder builder)
		{
			return new Offset<IWuWaGoStartGrid>(builder.EndTable());
		}

		// Token: 0x060284EA RID: 165098 RVA: 0x00589C2C File Offset: 0x00587E2C
		public IWuWaGoStartGridT UnPack()
		{
			IWuWaGoStartGridT wuWaGoStartGridT = new IWuWaGoStartGridT();
			this.UnPackTo(wuWaGoStartGridT);
			return wuWaGoStartGridT;
		}

		// Token: 0x060284EB RID: 165099 RVA: 0x00589C48 File Offset: 0x00587E48
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

		// Token: 0x060284EC RID: 165100 RVA: 0x00589D5C File Offset: 0x00587F5C
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

		// Token: 0x0400F35D RID: 62301
		private Table __p;
	}
}
