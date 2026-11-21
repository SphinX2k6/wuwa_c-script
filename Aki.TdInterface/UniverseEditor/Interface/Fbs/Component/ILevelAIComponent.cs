using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A4D RID: 23117
	public struct ILevelAIComponent : IFlatbufferObject
	{
		// Token: 0x1700A824 RID: 43044
		// (get) Token: 0x06025CEA RID: 154858 RVA: 0x0052EBD8 File Offset: 0x0052CDD8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06025CEB RID: 154859 RVA: 0x0052EBE5 File Offset: 0x0052CDE5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06025CEC RID: 154860 RVA: 0x0052EBEC File Offset: 0x0052CDEC
		public static ILevelAIComponent GetRootAsILevelAIComponent(ByteBuffer _bb)
		{
			return ILevelAIComponent.GetRootAsILevelAIComponent(_bb, default(ILevelAIComponent));
		}

		// Token: 0x06025CED RID: 154861 RVA: 0x0052EC08 File Offset: 0x0052CE08
		public static ILevelAIComponent GetRootAsILevelAIComponent(ByteBuffer _bb, ILevelAIComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06025CEE RID: 154862 RVA: 0x0052EC25 File Offset: 0x0052CE25
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06025CEF RID: 154863 RVA: 0x0052EC34 File Offset: 0x0052CE34
		public ILevelAIComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A825 RID: 43045
		// (get) Token: 0x06025CF0 RID: 154864 RVA: 0x0052EC44 File Offset: 0x0052CE44
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06025CF1 RID: 154865 RVA: 0x0052EC84 File Offset: 0x0052CE84
		public ILevelAIState? States(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new ILevelAIState?(default(ILevelAIState).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A826 RID: 43046
		// (get) Token: 0x06025CF2 RID: 154866 RVA: 0x0052ECE4 File Offset: 0x0052CEE4
		public int StatesLength
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

		// Token: 0x1700A827 RID: 43047
		// (get) Token: 0x06025CF3 RID: 154867 RVA: 0x0052ED10 File Offset: 0x0052CF10
		public string BtTreeAsset
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06025CF4 RID: 154868 RVA: 0x0052ED47 File Offset: 0x0052CF47
		public Span<byte> GetBtTreeAssetBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06025CF5 RID: 154869 RVA: 0x0052ED56 File Offset: 0x0052CF56
		public byte[] GetBtTreeAssetArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x1700A828 RID: 43048
		// (get) Token: 0x06025CF6 RID: 154870 RVA: 0x0052ED64 File Offset: 0x0052CF64
		public ICommonBtOverride? CommonBtOverride
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new ICommonBtOverride?(default(ICommonBtOverride).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700A829 RID: 43049
		// (get) Token: 0x06025CF7 RID: 154871 RVA: 0x0052EDC4 File Offset: 0x0052CFC4
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

		// Token: 0x06025CF8 RID: 154872 RVA: 0x0052EE01 File Offset: 0x0052D001
		public static Offset<ILevelAIComponent> CreateILevelAIComponent(FlatBufferBuilder builder, bool Disabled = false, VectorOffset StatesOffset = default(VectorOffset), StringOffset BtTreeAssetOffset = default(StringOffset), Offset<ICommonBtOverride> CommonBtOverrideOffset = default(Offset<ICommonBtOverride>), byte NullMask = 0)
		{
			builder.StartTable(5);
			ILevelAIComponent.AddCommonBtOverride(builder, CommonBtOverrideOffset);
			ILevelAIComponent.AddBtTreeAsset(builder, BtTreeAssetOffset);
			ILevelAIComponent.AddStates(builder, StatesOffset);
			ILevelAIComponent.AddNullMask(builder, NullMask);
			ILevelAIComponent.AddDisabled(builder, Disabled);
			return ILevelAIComponent.EndILevelAIComponent(builder);
		}

		// Token: 0x06025CF9 RID: 154873 RVA: 0x0052EE35 File Offset: 0x0052D035
		public static void StartILevelAIComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06025CFA RID: 154874 RVA: 0x0052EE3E File Offset: 0x0052D03E
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06025CFB RID: 154875 RVA: 0x0052EE49 File Offset: 0x0052D049
		public static void AddStates(FlatBufferBuilder builder, VectorOffset statesOffset)
		{
			builder.AddOffset(1, statesOffset.Value, 0);
		}

		// Token: 0x06025CFC RID: 154876 RVA: 0x0052EE5C File Offset: 0x0052D05C
		public static VectorOffset CreateStatesVector(FlatBufferBuilder builder, Offset<ILevelAIState>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06025CFD RID: 154877 RVA: 0x0052EE9C File Offset: 0x0052D09C
		public static VectorOffset CreateStatesVectorBlock(FlatBufferBuilder builder, Offset<ILevelAIState>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ILevelAIState>>(data);
			return builder.EndVector();
		}

		// Token: 0x06025CFE RID: 154878 RVA: 0x0052EEB6 File Offset: 0x0052D0B6
		public static VectorOffset CreateStatesVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ILevelAIState>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ILevelAIState>>(data);
			return builder.EndVector();
		}

		// Token: 0x06025CFF RID: 154879 RVA: 0x0052EED4 File Offset: 0x0052D0D4
		public static VectorOffset CreateStatesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ILevelAIState>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06025D00 RID: 154880 RVA: 0x0052EEED File Offset: 0x0052D0ED
		public static void StartStatesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06025D01 RID: 154881 RVA: 0x0052EEF8 File Offset: 0x0052D0F8
		public static void AddBtTreeAsset(FlatBufferBuilder builder, StringOffset btTreeAssetOffset)
		{
			builder.AddOffset(2, btTreeAssetOffset.Value, 0);
		}

		// Token: 0x06025D02 RID: 154882 RVA: 0x0052EF08 File Offset: 0x0052D108
		public static void AddCommonBtOverride(FlatBufferBuilder builder, Offset<ICommonBtOverride> commonBtOverrideOffset)
		{
			builder.AddOffset(3, commonBtOverrideOffset.Value, 0);
		}

		// Token: 0x06025D03 RID: 154883 RVA: 0x0052EF18 File Offset: 0x0052D118
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x06025D04 RID: 154884 RVA: 0x0052EF23 File Offset: 0x0052D123
		public static Offset<ILevelAIComponent> EndILevelAIComponent(FlatBufferBuilder builder)
		{
			return new Offset<ILevelAIComponent>(builder.EndTable());
		}

		// Token: 0x06025D05 RID: 154885 RVA: 0x0052EF30 File Offset: 0x0052D130
		public ILevelAIComponentT UnPack()
		{
			ILevelAIComponentT levelAIComponentT = new ILevelAIComponentT();
			this.UnPackTo(levelAIComponentT);
			return levelAIComponentT;
		}

		// Token: 0x06025D06 RID: 154886 RVA: 0x0052EF4C File Offset: 0x0052D14C
		public void UnPackTo(ILevelAIComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.States = new List<ILevelAIStateT>();
			for (int i = 0; i < this.StatesLength; i++)
			{
				_o.States.Add((this.States(i) != null) ? this.States(i).Value.UnPack() : null);
			}
			_o.BtTreeAsset = this.BtTreeAsset;
			_o.CommonBtOverride = ((this.CommonBtOverride != null) ? this.CommonBtOverride.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06025D07 RID: 154887 RVA: 0x0052F000 File Offset: 0x0052D200
		public static Offset<ILevelAIComponent> Pack(FlatBufferBuilder builder, ILevelAIComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILevelAIComponent>);
			}
			VectorOffset statesOffset = default(VectorOffset);
			if (_o.States != null)
			{
				Offset<ILevelAIState>[] array = new Offset<ILevelAIState>[_o.States.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = ILevelAIState.Pack(builder, _o.States[i]);
				}
				statesOffset = ILevelAIComponent.CreateStatesVector(builder, array);
			}
			StringOffset btTreeAssetOffset = (_o.BtTreeAsset == null) ? default(StringOffset) : builder.CreateString(_o.BtTreeAsset);
			Offset<ICommonBtOverride> commonBtOverrideOffset = (_o.CommonBtOverride == null) ? default(Offset<ICommonBtOverride>) : ICommonBtOverride.Pack(builder, _o.CommonBtOverride);
			return ILevelAIComponent.CreateILevelAIComponent(builder, _o.Disabled, statesOffset, btTreeAssetOffset, commonBtOverrideOffset, _o.NullMask);
		}

		// Token: 0x0400F3B3 RID: 62387
		private Table __p;
	}
}
