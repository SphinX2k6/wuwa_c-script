using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C6B RID: 27755
	public struct IDoCalculate : IFlatbufferObject
	{
		// Token: 0x1700CB94 RID: 52116
		// (get) Token: 0x0602FCE6 RID: 195814 RVA: 0x00682A3D File Offset: 0x00680C3D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602FCE7 RID: 195815 RVA: 0x00682A4A File Offset: 0x00680C4A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602FCE8 RID: 195816 RVA: 0x00682A54 File Offset: 0x00680C54
		public static IDoCalculate GetRootAsIDoCalculate(ByteBuffer _bb)
		{
			return IDoCalculate.GetRootAsIDoCalculate(_bb, default(IDoCalculate));
		}

		// Token: 0x0602FCE9 RID: 195817 RVA: 0x00682A70 File Offset: 0x00680C70
		public static IDoCalculate GetRootAsIDoCalculate(ByteBuffer _bb, IDoCalculate obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602FCEA RID: 195818 RVA: 0x00682A8D File Offset: 0x00680C8D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602FCEB RID: 195819 RVA: 0x00682A9C File Offset: 0x00680C9C
		public IDoCalculate __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CB95 RID: 52117
		// (get) Token: 0x0602FCEC RID: 195820 RVA: 0x00682AAC File Offset: 0x00680CAC
		public TVarValue Var1Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return TVarValue.NONE;
				}
				return (TVarValue)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602FCED RID: 195821 RVA: 0x00682AE8 File Offset: 0x00680CE8
		public TTable? Var1<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602FCEE RID: 195822 RVA: 0x00682B2C File Offset: 0x00680D2C
		public BooleanValue Var1AsBooleanValue()
		{
			return this.Var1<BooleanValue>().Value;
		}

		// Token: 0x0602FCEF RID: 195823 RVA: 0x00682B48 File Offset: 0x00680D48
		public IntValue Var1AsIntValue()
		{
			return this.Var1<IntValue>().Value;
		}

		// Token: 0x0602FCF0 RID: 195824 RVA: 0x00682B64 File Offset: 0x00680D64
		public FloatValue Var1AsFloatValue()
		{
			return this.Var1<FloatValue>().Value;
		}

		// Token: 0x0602FCF1 RID: 195825 RVA: 0x00682B80 File Offset: 0x00680D80
		public StringValue Var1AsStringValue()
		{
			return this.Var1<StringValue>().Value;
		}

		// Token: 0x0602FCF2 RID: 195826 RVA: 0x00682B9C File Offset: 0x00680D9C
		public QuestStateValue Var1AsQuestStateValue()
		{
			return this.Var1<QuestStateValue>().Value;
		}

		// Token: 0x0602FCF3 RID: 195827 RVA: 0x00682BB8 File Offset: 0x00680DB8
		public EntityValue Var1AsEntityValue()
		{
			return this.Var1<EntityValue>().Value;
		}

		// Token: 0x0602FCF4 RID: 195828 RVA: 0x00682BD4 File Offset: 0x00680DD4
		public QuestValue Var1AsQuestValue()
		{
			return this.Var1<QuestValue>().Value;
		}

		// Token: 0x0602FCF5 RID: 195829 RVA: 0x00682BF0 File Offset: 0x00680DF0
		public PrefabValue Var1AsPrefabValue()
		{
			return this.Var1<PrefabValue>().Value;
		}

		// Token: 0x0602FCF6 RID: 195830 RVA: 0x00682C0C File Offset: 0x00680E0C
		public TransformValue Var1AsTransformValue()
		{
			return this.Var1<TransformValue>().Value;
		}

		// Token: 0x1700CB96 RID: 52118
		// (get) Token: 0x0602FCF7 RID: 195831 RVA: 0x00682C28 File Offset: 0x00680E28
		public string Op
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

		// Token: 0x0602FCF8 RID: 195832 RVA: 0x00682C5F File Offset: 0x00680E5F
		public Span<byte> GetOpBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0602FCF9 RID: 195833 RVA: 0x00682C6E File Offset: 0x00680E6E
		public byte[] GetOpArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x1700CB97 RID: 52119
		// (get) Token: 0x0602FCFA RID: 195834 RVA: 0x00682C7C File Offset: 0x00680E7C
		public TVarValue Var2Type
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return TVarValue.NONE;
				}
				return (TVarValue)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602FCFB RID: 195835 RVA: 0x00682CBC File Offset: 0x00680EBC
		public TTable? Var2<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602FCFC RID: 195836 RVA: 0x00682D04 File Offset: 0x00680F04
		public BooleanValue Var2AsBooleanValue()
		{
			return this.Var2<BooleanValue>().Value;
		}

		// Token: 0x0602FCFD RID: 195837 RVA: 0x00682D20 File Offset: 0x00680F20
		public IntValue Var2AsIntValue()
		{
			return this.Var2<IntValue>().Value;
		}

		// Token: 0x0602FCFE RID: 195838 RVA: 0x00682D3C File Offset: 0x00680F3C
		public FloatValue Var2AsFloatValue()
		{
			return this.Var2<FloatValue>().Value;
		}

		// Token: 0x0602FCFF RID: 195839 RVA: 0x00682D58 File Offset: 0x00680F58
		public StringValue Var2AsStringValue()
		{
			return this.Var2<StringValue>().Value;
		}

		// Token: 0x0602FD00 RID: 195840 RVA: 0x00682D74 File Offset: 0x00680F74
		public QuestStateValue Var2AsQuestStateValue()
		{
			return this.Var2<QuestStateValue>().Value;
		}

		// Token: 0x0602FD01 RID: 195841 RVA: 0x00682D90 File Offset: 0x00680F90
		public EntityValue Var2AsEntityValue()
		{
			return this.Var2<EntityValue>().Value;
		}

		// Token: 0x0602FD02 RID: 195842 RVA: 0x00682DAC File Offset: 0x00680FAC
		public QuestValue Var2AsQuestValue()
		{
			return this.Var2<QuestValue>().Value;
		}

		// Token: 0x0602FD03 RID: 195843 RVA: 0x00682DC8 File Offset: 0x00680FC8
		public PrefabValue Var2AsPrefabValue()
		{
			return this.Var2<PrefabValue>().Value;
		}

		// Token: 0x0602FD04 RID: 195844 RVA: 0x00682DE4 File Offset: 0x00680FE4
		public TransformValue Var2AsTransformValue()
		{
			return this.Var2<TransformValue>().Value;
		}

		// Token: 0x1700CB98 RID: 52120
		// (get) Token: 0x0602FD05 RID: 195845 RVA: 0x00682E00 File Offset: 0x00681000
		public string Result
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602FD06 RID: 195846 RVA: 0x00682E38 File Offset: 0x00681038
		public Span<byte> GetResultBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0602FD07 RID: 195847 RVA: 0x00682E48 File Offset: 0x00681048
		public byte[] GetResultArray()
		{
			return this.__p.__vector_as_array<byte>(14);
		}

		// Token: 0x0602FD08 RID: 195848 RVA: 0x00682E57 File Offset: 0x00681057
		public static Offset<IDoCalculate> CreateIDoCalculate(FlatBufferBuilder builder, TVarValue Var1_type = TVarValue.NONE, int Var1Offset = 0, StringOffset OpOffset = default(StringOffset), TVarValue Var2_type = TVarValue.NONE, int Var2Offset = 0, StringOffset ResultOffset = default(StringOffset))
		{
			builder.StartTable(6);
			IDoCalculate.AddResult(builder, ResultOffset);
			IDoCalculate.AddVar2(builder, Var2Offset);
			IDoCalculate.AddOp(builder, OpOffset);
			IDoCalculate.AddVar1(builder, Var1Offset);
			IDoCalculate.AddVar2Type(builder, Var2_type);
			IDoCalculate.AddVar1Type(builder, Var1_type);
			return IDoCalculate.EndIDoCalculate(builder);
		}

		// Token: 0x0602FD09 RID: 195849 RVA: 0x00682E93 File Offset: 0x00681093
		public static void StartIDoCalculate(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x0602FD0A RID: 195850 RVA: 0x00682E9C File Offset: 0x0068109C
		public static void AddVar1Type(FlatBufferBuilder builder, TVarValue var1Type)
		{
			builder.AddByte(0, (byte)var1Type, 0);
		}

		// Token: 0x0602FD0B RID: 195851 RVA: 0x00682EA7 File Offset: 0x006810A7
		public static void AddVar1(FlatBufferBuilder builder, int var1Offset)
		{
			builder.AddOffset(1, var1Offset, 0);
		}

		// Token: 0x0602FD0C RID: 195852 RVA: 0x00682EB2 File Offset: 0x006810B2
		public static void AddOp(FlatBufferBuilder builder, StringOffset opOffset)
		{
			builder.AddOffset(2, opOffset.Value, 0);
		}

		// Token: 0x0602FD0D RID: 195853 RVA: 0x00682EC2 File Offset: 0x006810C2
		public static void AddVar2Type(FlatBufferBuilder builder, TVarValue var2Type)
		{
			builder.AddByte(3, (byte)var2Type, 0);
		}

		// Token: 0x0602FD0E RID: 195854 RVA: 0x00682ECD File Offset: 0x006810CD
		public static void AddVar2(FlatBufferBuilder builder, int var2Offset)
		{
			builder.AddOffset(4, var2Offset, 0);
		}

		// Token: 0x0602FD0F RID: 195855 RVA: 0x00682ED8 File Offset: 0x006810D8
		public static void AddResult(FlatBufferBuilder builder, StringOffset resultOffset)
		{
			builder.AddOffset(5, resultOffset.Value, 0);
		}

		// Token: 0x0602FD10 RID: 195856 RVA: 0x00682EE8 File Offset: 0x006810E8
		public static Offset<IDoCalculate> EndIDoCalculate(FlatBufferBuilder builder)
		{
			return new Offset<IDoCalculate>(builder.EndTable());
		}

		// Token: 0x0602FD11 RID: 195857 RVA: 0x00682EF8 File Offset: 0x006810F8
		public IDoCalculateT UnPack()
		{
			IDoCalculateT doCalculateT = new IDoCalculateT();
			this.UnPackTo(doCalculateT);
			return doCalculateT;
		}

		// Token: 0x0602FD12 RID: 195858 RVA: 0x00682F14 File Offset: 0x00681114
		public void UnPackTo(IDoCalculateT _o)
		{
			_o.Var1 = new TVarValueUnion();
			_o.Var1.Type = this.Var1Type;
			switch (this.Var1Type)
			{
			case TVarValue.BooleanValue:
				_o.Var1.Value = ((this.Var1<BooleanValue>() != null) ? this.Var1<BooleanValue>().Value.UnPack() : null);
				break;
			case TVarValue.IntValue:
				_o.Var1.Value = ((this.Var1<IntValue>() != null) ? this.Var1<IntValue>().Value.UnPack() : null);
				break;
			case TVarValue.FloatValue:
				_o.Var1.Value = ((this.Var1<FloatValue>() != null) ? this.Var1<FloatValue>().Value.UnPack() : null);
				break;
			case TVarValue.StringValue:
				_o.Var1.Value = ((this.Var1<StringValue>() != null) ? this.Var1<StringValue>().Value.UnPack() : null);
				break;
			case TVarValue.QuestStateValue:
				_o.Var1.Value = ((this.Var1<QuestStateValue>() != null) ? this.Var1<QuestStateValue>().Value.UnPack() : null);
				break;
			case TVarValue.EntityValue:
				_o.Var1.Value = ((this.Var1<EntityValue>() != null) ? this.Var1<EntityValue>().Value.UnPack() : null);
				break;
			case TVarValue.QuestValue:
				_o.Var1.Value = ((this.Var1<QuestValue>() != null) ? this.Var1<QuestValue>().Value.UnPack() : null);
				break;
			case TVarValue.PrefabValue:
				_o.Var1.Value = ((this.Var1<PrefabValue>() != null) ? this.Var1<PrefabValue>().Value.UnPack() : null);
				break;
			case TVarValue.TransformValue:
				_o.Var1.Value = ((this.Var1<TransformValue>() != null) ? this.Var1<TransformValue>().Value.UnPack() : null);
				break;
			}
			_o.Op = this.Op;
			_o.Var2 = new TVarValueUnion();
			_o.Var2.Type = this.Var2Type;
			switch (this.Var2Type)
			{
			case TVarValue.BooleanValue:
				_o.Var2.Value = ((this.Var2<BooleanValue>() != null) ? this.Var2<BooleanValue>().Value.UnPack() : null);
				break;
			case TVarValue.IntValue:
				_o.Var2.Value = ((this.Var2<IntValue>() != null) ? this.Var2<IntValue>().Value.UnPack() : null);
				break;
			case TVarValue.FloatValue:
				_o.Var2.Value = ((this.Var2<FloatValue>() != null) ? this.Var2<FloatValue>().Value.UnPack() : null);
				break;
			case TVarValue.StringValue:
				_o.Var2.Value = ((this.Var2<StringValue>() != null) ? this.Var2<StringValue>().Value.UnPack() : null);
				break;
			case TVarValue.QuestStateValue:
				_o.Var2.Value = ((this.Var2<QuestStateValue>() != null) ? this.Var2<QuestStateValue>().Value.UnPack() : null);
				break;
			case TVarValue.EntityValue:
				_o.Var2.Value = ((this.Var2<EntityValue>() != null) ? this.Var2<EntityValue>().Value.UnPack() : null);
				break;
			case TVarValue.QuestValue:
				_o.Var2.Value = ((this.Var2<QuestValue>() != null) ? this.Var2<QuestValue>().Value.UnPack() : null);
				break;
			case TVarValue.PrefabValue:
				_o.Var2.Value = ((this.Var2<PrefabValue>() != null) ? this.Var2<PrefabValue>().Value.UnPack() : null);
				break;
			case TVarValue.TransformValue:
				_o.Var2.Value = ((this.Var2<TransformValue>() != null) ? this.Var2<TransformValue>().Value.UnPack() : null);
				break;
			}
			_o.Result = this.Result;
		}

		// Token: 0x0602FD13 RID: 195859 RVA: 0x006833FC File Offset: 0x006815FC
		public static Offset<IDoCalculate> Pack(FlatBufferBuilder builder, IDoCalculateT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDoCalculate>);
			}
			TVarValue var1_type = (_o.Var1 == null) ? TVarValue.NONE : _o.Var1.Type;
			int var1Offset = (_o.Var1 == null) ? 0 : TVarValueUnion.Pack(builder, _o.Var1);
			StringOffset opOffset = (_o.Op == null) ? default(StringOffset) : builder.CreateString(_o.Op);
			TVarValue var2_type = (_o.Var2 == null) ? TVarValue.NONE : _o.Var2.Type;
			int var2Offset = (_o.Var2 == null) ? 0 : TVarValueUnion.Pack(builder, _o.Var2);
			StringOffset resultOffset = (_o.Result == null) ? default(StringOffset) : builder.CreateString(_o.Result);
			return IDoCalculate.CreateIDoCalculate(builder, var1_type, var1Offset, opOffset, var2_type, var2Offset, resultOffset);
		}

		// Token: 0x04011A98 RID: 72344
		private Table __p;
	}
}
