using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005847 RID: 22599
	public struct IFrequencyPaintConfig : IFlatbufferObject
	{
		// Token: 0x1700A3B2 RID: 41906
		// (get) Token: 0x060249BB RID: 149947 RVA: 0x00507B65 File Offset: 0x00505D65
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060249BC RID: 149948 RVA: 0x00507B72 File Offset: 0x00505D72
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060249BD RID: 149949 RVA: 0x00507B7C File Offset: 0x00505D7C
		public static IFrequencyPaintConfig GetRootAsIFrequencyPaintConfig(ByteBuffer _bb)
		{
			return IFrequencyPaintConfig.GetRootAsIFrequencyPaintConfig(_bb, default(IFrequencyPaintConfig));
		}

		// Token: 0x060249BE RID: 149950 RVA: 0x00507B98 File Offset: 0x00505D98
		public static IFrequencyPaintConfig GetRootAsIFrequencyPaintConfig(ByteBuffer _bb, IFrequencyPaintConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060249BF RID: 149951 RVA: 0x00507BB5 File Offset: 0x00505DB5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060249C0 RID: 149952 RVA: 0x00507BC4 File Offset: 0x00505DC4
		public IFrequencyPaintConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A3B3 RID: 41907
		// (get) Token: 0x060249C1 RID: 149953 RVA: 0x00507BD4 File Offset: 0x00505DD4
		public string EntityState
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060249C2 RID: 149954 RVA: 0x00507C0B File Offset: 0x00505E0B
		public Span<byte> GetEntityStateBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x060249C3 RID: 149955 RVA: 0x00507C1A File Offset: 0x00505E1A
		public byte[] GetEntityStateArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700A3B4 RID: 41908
		// (get) Token: 0x060249C4 RID: 149956 RVA: 0x00507C28 File Offset: 0x00505E28
		public TFrequencyPaintLineOption LineTypeType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TFrequencyPaintLineOption.NONE;
				}
				return (TFrequencyPaintLineOption)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060249C5 RID: 149957 RVA: 0x00507C64 File Offset: 0x00505E64
		public TTable? LineType<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060249C6 RID: 149958 RVA: 0x00507CA8 File Offset: 0x00505EA8
		public IFrequencyPaintConnectLine LineTypeAsIFrequencyPaintConnectLine()
		{
			return this.LineType<IFrequencyPaintConnectLine>().Value;
		}

		// Token: 0x060249C7 RID: 149959 RVA: 0x00507CC4 File Offset: 0x00505EC4
		public IFrequencyPaintEncloseLine LineTypeAsIFrequencyPaintEncloseLine()
		{
			return this.LineType<IFrequencyPaintEncloseLine>().Value;
		}

		// Token: 0x060249C8 RID: 149960 RVA: 0x00507CE0 File Offset: 0x00505EE0
		public IFrequencyPaintStraightLine LineTypeAsIFrequencyPaintStraightLine()
		{
			return this.LineType<IFrequencyPaintStraightLine>().Value;
		}

		// Token: 0x060249C9 RID: 149961 RVA: 0x00507CFC File Offset: 0x00505EFC
		public IFrequencyPaintStrokeLine LineTypeAsIFrequencyPaintStrokeLine()
		{
			return this.LineType<IFrequencyPaintStrokeLine>().Value;
		}

		// Token: 0x060249CA RID: 149962 RVA: 0x00507D18 File Offset: 0x00505F18
		public IActionInfo? SuccessActions(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A3B5 RID: 41909
		// (get) Token: 0x060249CB RID: 149963 RVA: 0x00507D7C File Offset: 0x00505F7C
		public int SuccessActionsLength
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

		// Token: 0x060249CC RID: 149964 RVA: 0x00507DA8 File Offset: 0x00505FA8
		public static Offset<IFrequencyPaintConfig> CreateIFrequencyPaintConfig(FlatBufferBuilder builder, StringOffset EntityStateOffset = default(StringOffset), TFrequencyPaintLineOption LineType_type = TFrequencyPaintLineOption.NONE, int LineTypeOffset = 0, VectorOffset SuccessActionsOffset = default(VectorOffset))
		{
			builder.StartTable(4);
			IFrequencyPaintConfig.AddSuccessActions(builder, SuccessActionsOffset);
			IFrequencyPaintConfig.AddLineType(builder, LineTypeOffset);
			IFrequencyPaintConfig.AddEntityState(builder, EntityStateOffset);
			IFrequencyPaintConfig.AddLineTypeType(builder, LineType_type);
			return IFrequencyPaintConfig.EndIFrequencyPaintConfig(builder);
		}

		// Token: 0x060249CD RID: 149965 RVA: 0x00507DD4 File Offset: 0x00505FD4
		public static void StartIFrequencyPaintConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x060249CE RID: 149966 RVA: 0x00507DDD File Offset: 0x00505FDD
		public static void AddEntityState(FlatBufferBuilder builder, StringOffset entityStateOffset)
		{
			builder.AddOffset(0, entityStateOffset.Value, 0);
		}

		// Token: 0x060249CF RID: 149967 RVA: 0x00507DED File Offset: 0x00505FED
		public static void AddLineTypeType(FlatBufferBuilder builder, TFrequencyPaintLineOption lineTypeType)
		{
			builder.AddByte(1, (byte)lineTypeType, 0);
		}

		// Token: 0x060249D0 RID: 149968 RVA: 0x00507DF8 File Offset: 0x00505FF8
		public static void AddLineType(FlatBufferBuilder builder, int lineTypeOffset)
		{
			builder.AddOffset(2, lineTypeOffset, 0);
		}

		// Token: 0x060249D1 RID: 149969 RVA: 0x00507E03 File Offset: 0x00506003
		public static void AddSuccessActions(FlatBufferBuilder builder, VectorOffset successActionsOffset)
		{
			builder.AddOffset(3, successActionsOffset.Value, 0);
		}

		// Token: 0x060249D2 RID: 149970 RVA: 0x00507E14 File Offset: 0x00506014
		public static VectorOffset CreateSuccessActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060249D3 RID: 149971 RVA: 0x00507E54 File Offset: 0x00506054
		public static VectorOffset CreateSuccessActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060249D4 RID: 149972 RVA: 0x00507E6E File Offset: 0x0050606E
		public static VectorOffset CreateSuccessActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060249D5 RID: 149973 RVA: 0x00507E8C File Offset: 0x0050608C
		public static VectorOffset CreateSuccessActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060249D6 RID: 149974 RVA: 0x00507EA5 File Offset: 0x005060A5
		public static void StartSuccessActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060249D7 RID: 149975 RVA: 0x00507EB0 File Offset: 0x005060B0
		public static Offset<IFrequencyPaintConfig> EndIFrequencyPaintConfig(FlatBufferBuilder builder)
		{
			return new Offset<IFrequencyPaintConfig>(builder.EndTable());
		}

		// Token: 0x060249D8 RID: 149976 RVA: 0x00507EC0 File Offset: 0x005060C0
		public IFrequencyPaintConfigT UnPack()
		{
			IFrequencyPaintConfigT frequencyPaintConfigT = new IFrequencyPaintConfigT();
			this.UnPackTo(frequencyPaintConfigT);
			return frequencyPaintConfigT;
		}

		// Token: 0x060249D9 RID: 149977 RVA: 0x00507EDC File Offset: 0x005060DC
		public void UnPackTo(IFrequencyPaintConfigT _o)
		{
			_o.EntityState = this.EntityState;
			_o.LineType = new TFrequencyPaintLineOptionUnion();
			_o.LineType.Type = this.LineTypeType;
			switch (this.LineTypeType)
			{
			case TFrequencyPaintLineOption.IFrequencyPaintConnectLine:
				_o.LineType.Value = ((this.LineType<IFrequencyPaintConnectLine>() != null) ? this.LineType<IFrequencyPaintConnectLine>().Value.UnPack() : null);
				break;
			case TFrequencyPaintLineOption.IFrequencyPaintEncloseLine:
				_o.LineType.Value = ((this.LineType<IFrequencyPaintEncloseLine>() != null) ? this.LineType<IFrequencyPaintEncloseLine>().Value.UnPack() : null);
				break;
			case TFrequencyPaintLineOption.IFrequencyPaintStraightLine:
				_o.LineType.Value = ((this.LineType<IFrequencyPaintStraightLine>() != null) ? this.LineType<IFrequencyPaintStraightLine>().Value.UnPack() : null);
				break;
			case TFrequencyPaintLineOption.IFrequencyPaintStrokeLine:
				_o.LineType.Value = ((this.LineType<IFrequencyPaintStrokeLine>() != null) ? this.LineType<IFrequencyPaintStrokeLine>().Value.UnPack() : null);
				break;
			}
			_o.SuccessActions = new List<IActionInfoT>();
			for (int i = 0; i < this.SuccessActionsLength; i++)
			{
				_o.SuccessActions.Add((this.SuccessActions(i) != null) ? this.SuccessActions(i).Value.UnPack() : null);
			}
		}

		// Token: 0x060249DA RID: 149978 RVA: 0x00508070 File Offset: 0x00506270
		public static Offset<IFrequencyPaintConfig> Pack(FlatBufferBuilder builder, IFrequencyPaintConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFrequencyPaintConfig>);
			}
			StringOffset entityStateOffset = (_o.EntityState == null) ? default(StringOffset) : builder.CreateString(_o.EntityState);
			TFrequencyPaintLineOption lineType_type = (_o.LineType == null) ? TFrequencyPaintLineOption.NONE : _o.LineType.Type;
			int lineTypeOffset = (_o.LineType == null) ? 0 : TFrequencyPaintLineOptionUnion.Pack(builder, _o.LineType);
			VectorOffset successActionsOffset = default(VectorOffset);
			if (_o.SuccessActions != null)
			{
				Offset<IActionInfo>[] array = new Offset<IActionInfo>[_o.SuccessActions.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IActionInfo.Pack(builder, _o.SuccessActions[i]);
				}
				successActionsOffset = IFrequencyPaintConfig.CreateSuccessActionsVector(builder, array);
			}
			return IFrequencyPaintConfig.CreateIFrequencyPaintConfig(builder, entityStateOffset, lineType_type, lineTypeOffset, successActionsOffset);
		}

		// Token: 0x0400F082 RID: 61570
		private Table __p;
	}
}
