using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006816 RID: 26646
	public struct IFlowInfo : IFlatbufferObject
	{
		// Token: 0x1700C5C4 RID: 50628
		// (get) Token: 0x0602E680 RID: 190080 RVA: 0x006551F5 File Offset: 0x006533F5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E681 RID: 190081 RVA: 0x00655202 File Offset: 0x00653402
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E682 RID: 190082 RVA: 0x0065520C File Offset: 0x0065340C
		public static IFlowInfo GetRootAsIFlowInfo(ByteBuffer _bb)
		{
			return IFlowInfo.GetRootAsIFlowInfo(_bb, default(IFlowInfo));
		}

		// Token: 0x0602E683 RID: 190083 RVA: 0x00655228 File Offset: 0x00653428
		public static IFlowInfo GetRootAsIFlowInfo(ByteBuffer _bb, IFlowInfo obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E684 RID: 190084 RVA: 0x00655245 File Offset: 0x00653445
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E685 RID: 190085 RVA: 0x00655254 File Offset: 0x00653454
		public IFlowInfo __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C5C5 RID: 50629
		// (get) Token: 0x0602E686 RID: 190086 RVA: 0x00655264 File Offset: 0x00653464
		public string ObjType
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

		// Token: 0x0602E687 RID: 190087 RVA: 0x0065529B File Offset: 0x0065349B
		public Span<byte> GetObjTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0602E688 RID: 190088 RVA: 0x006552AA File Offset: 0x006534AA
		public byte[] GetObjTypeArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x0602E689 RID: 190089 RVA: 0x006552B8 File Offset: 0x006534B8
		public string Children(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700C5C6 RID: 50630
		// (get) Token: 0x0602E68A RID: 190090 RVA: 0x006552F4 File Offset: 0x006534F4
		public int ChildrenLength
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

		// Token: 0x0602E68B RID: 190091 RVA: 0x00655320 File Offset: 0x00653520
		public string Reference(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700C5C7 RID: 50631
		// (get) Token: 0x0602E68C RID: 190092 RVA: 0x0065535C File Offset: 0x0065355C
		public int ReferenceLength
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

		// Token: 0x0602E68D RID: 190093 RVA: 0x00655388 File Offset: 0x00653588
		public string WeakReference(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700C5C8 RID: 50632
		// (get) Token: 0x0602E68E RID: 190094 RVA: 0x006553C4 File Offset: 0x006535C4
		public int WeakReferenceLength
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

		// Token: 0x1700C5C9 RID: 50633
		// (get) Token: 0x0602E68F RID: 190095 RVA: 0x006553F0 File Offset: 0x006535F0
		public int Id
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C5CA RID: 50634
		// (get) Token: 0x0602E690 RID: 190096 RVA: 0x00655430 File Offset: 0x00653630
		public string Name
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

		// Token: 0x0602E691 RID: 190097 RVA: 0x00655468 File Offset: 0x00653668
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0602E692 RID: 190098 RVA: 0x00655478 File Offset: 0x00653678
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(14);
		}

		// Token: 0x1700C5CB RID: 50635
		// (get) Token: 0x0602E693 RID: 190099 RVA: 0x00655488 File Offset: 0x00653688
		public int DungeonId
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C5CC RID: 50636
		// (get) Token: 0x0602E694 RID: 190100 RVA: 0x006554C8 File Offset: 0x006536C8
		public bool _Folded
		{
			get
			{
				int num = this.__p.__offset(18);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C5CD RID: 50637
		// (get) Token: 0x0602E695 RID: 190101 RVA: 0x00655508 File Offset: 0x00653708
		public int _SelectedStateId
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C5CE RID: 50638
		// (get) Token: 0x0602E696 RID: 190102 RVA: 0x00655548 File Offset: 0x00653748
		public TVarContext VarContextType
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return TVarContext.NONE;
				}
				return (TVarContext)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602E697 RID: 190103 RVA: 0x00655588 File Offset: 0x00653788
		public TTable? VarContext<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602E698 RID: 190104 RVA: 0x006555D0 File Offset: 0x006537D0
		public IBehaviorTreeFragmentContext VarContextAsIBehaviorTreeFragmentContext()
		{
			return this.VarContext<IBehaviorTreeFragmentContext>().Value;
		}

		// Token: 0x0602E699 RID: 190105 RVA: 0x006555EC File Offset: 0x006537EC
		public ICommonBtContext VarContextAsICommonBtContext()
		{
			return this.VarContext<ICommonBtContext>().Value;
		}

		// Token: 0x0602E69A RID: 190106 RVA: 0x00655608 File Offset: 0x00653808
		public IEntityTemplateContext VarContextAsIEntityTemplateContext()
		{
			return this.VarContext<IEntityTemplateContext>().Value;
		}

		// Token: 0x0602E69B RID: 190107 RVA: 0x00655624 File Offset: 0x00653824
		public IEntityVarContext VarContextAsIEntityVarContext()
		{
			return this.VarContext<IEntityVarContext>().Value;
		}

		// Token: 0x0602E69C RID: 190108 RVA: 0x00655640 File Offset: 0x00653840
		public ILevelPlayVarContext VarContextAsILevelPlayVarContext()
		{
			return this.VarContext<ILevelPlayVarContext>().Value;
		}

		// Token: 0x0602E69D RID: 190109 RVA: 0x0065565C File Offset: 0x0065385C
		public IQuestVarContext VarContextAsIQuestVarContext()
		{
			return this.VarContext<IQuestVarContext>().Value;
		}

		// Token: 0x0602E69E RID: 190110 RVA: 0x00655678 File Offset: 0x00653878
		public IStateInfo? States(int j)
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return null;
			}
			return new IStateInfo?(default(IStateInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700C5CF RID: 50639
		// (get) Token: 0x0602E69F RID: 190111 RVA: 0x006556DC File Offset: 0x006538DC
		public int StatesLength
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700C5D0 RID: 50640
		// (get) Token: 0x0602E6A0 RID: 190112 RVA: 0x00655708 File Offset: 0x00653908
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602E6A1 RID: 190113 RVA: 0x00655748 File Offset: 0x00653948
		public static Offset<IFlowInfo> CreateIFlowInfo(FlatBufferBuilder builder, StringOffset ObjTypeOffset = default(StringOffset), VectorOffset ChildrenOffset = default(VectorOffset), VectorOffset ReferenceOffset = default(VectorOffset), VectorOffset WeakReferenceOffset = default(VectorOffset), int Id = 0, StringOffset NameOffset = default(StringOffset), int DungeonId = 0, bool _folded = false, int _selectedStateId = 0, TVarContext VarContext_type = TVarContext.NONE, int VarContextOffset = 0, VectorOffset StatesOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(13);
			IFlowInfo.AddStates(builder, StatesOffset);
			IFlowInfo.AddVarContext(builder, VarContextOffset);
			IFlowInfo.Add_SelectedStateId(builder, _selectedStateId);
			IFlowInfo.AddDungeonId(builder, DungeonId);
			IFlowInfo.AddName(builder, NameOffset);
			IFlowInfo.AddId(builder, Id);
			IFlowInfo.AddWeakReference(builder, WeakReferenceOffset);
			IFlowInfo.AddReference(builder, ReferenceOffset);
			IFlowInfo.AddChildren(builder, ChildrenOffset);
			IFlowInfo.AddObjType(builder, ObjTypeOffset);
			IFlowInfo.AddNullMask(builder, NullMask);
			IFlowInfo.AddVarContextType(builder, VarContext_type);
			IFlowInfo.Add_Folded(builder, _folded);
			return IFlowInfo.EndIFlowInfo(builder);
		}

		// Token: 0x0602E6A2 RID: 190114 RVA: 0x006557C8 File Offset: 0x006539C8
		public static void StartIFlowInfo(FlatBufferBuilder builder)
		{
			builder.StartTable(13);
		}

		// Token: 0x0602E6A3 RID: 190115 RVA: 0x006557D2 File Offset: 0x006539D2
		public static void AddObjType(FlatBufferBuilder builder, StringOffset objTypeOffset)
		{
			builder.AddOffset(0, objTypeOffset.Value, 0);
		}

		// Token: 0x0602E6A4 RID: 190116 RVA: 0x006557E2 File Offset: 0x006539E2
		public static void AddChildren(FlatBufferBuilder builder, VectorOffset childrenOffset)
		{
			builder.AddOffset(1, childrenOffset.Value, 0);
		}

		// Token: 0x0602E6A5 RID: 190117 RVA: 0x006557F4 File Offset: 0x006539F4
		public static VectorOffset CreateChildrenVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602E6A6 RID: 190118 RVA: 0x00655834 File Offset: 0x00653A34
		public static VectorOffset CreateChildrenVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0602E6A7 RID: 190119 RVA: 0x0065584E File Offset: 0x00653A4E
		public static VectorOffset CreateChildrenVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0602E6A8 RID: 190120 RVA: 0x0065586C File Offset: 0x00653A6C
		public static VectorOffset CreateChildrenVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602E6A9 RID: 190121 RVA: 0x00655885 File Offset: 0x00653A85
		public static void StartChildrenVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602E6AA RID: 190122 RVA: 0x00655890 File Offset: 0x00653A90
		public static void AddReference(FlatBufferBuilder builder, VectorOffset referenceOffset)
		{
			builder.AddOffset(2, referenceOffset.Value, 0);
		}

		// Token: 0x0602E6AB RID: 190123 RVA: 0x006558A0 File Offset: 0x00653AA0
		public static VectorOffset CreateReferenceVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602E6AC RID: 190124 RVA: 0x006558E0 File Offset: 0x00653AE0
		public static VectorOffset CreateReferenceVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0602E6AD RID: 190125 RVA: 0x006558FA File Offset: 0x00653AFA
		public static VectorOffset CreateReferenceVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0602E6AE RID: 190126 RVA: 0x00655918 File Offset: 0x00653B18
		public static VectorOffset CreateReferenceVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602E6AF RID: 190127 RVA: 0x00655931 File Offset: 0x00653B31
		public static void StartReferenceVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602E6B0 RID: 190128 RVA: 0x0065593C File Offset: 0x00653B3C
		public static void AddWeakReference(FlatBufferBuilder builder, VectorOffset weakReferenceOffset)
		{
			builder.AddOffset(3, weakReferenceOffset.Value, 0);
		}

		// Token: 0x0602E6B1 RID: 190129 RVA: 0x0065594C File Offset: 0x00653B4C
		public static VectorOffset CreateWeakReferenceVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602E6B2 RID: 190130 RVA: 0x0065598C File Offset: 0x00653B8C
		public static VectorOffset CreateWeakReferenceVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0602E6B3 RID: 190131 RVA: 0x006559A6 File Offset: 0x00653BA6
		public static VectorOffset CreateWeakReferenceVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0602E6B4 RID: 190132 RVA: 0x006559C4 File Offset: 0x00653BC4
		public static VectorOffset CreateWeakReferenceVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602E6B5 RID: 190133 RVA: 0x006559DD File Offset: 0x00653BDD
		public static void StartWeakReferenceVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602E6B6 RID: 190134 RVA: 0x006559E8 File Offset: 0x00653BE8
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(4, id, 0);
		}

		// Token: 0x0602E6B7 RID: 190135 RVA: 0x006559F3 File Offset: 0x00653BF3
		public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset)
		{
			builder.AddOffset(5, nameOffset.Value, 0);
		}

		// Token: 0x0602E6B8 RID: 190136 RVA: 0x00655A03 File Offset: 0x00653C03
		public static void AddDungeonId(FlatBufferBuilder builder, int dungeonId)
		{
			builder.AddInt(6, dungeonId, 0);
		}

		// Token: 0x0602E6B9 RID: 190137 RVA: 0x00655A0E File Offset: 0x00653C0E
		public static void Add_Folded(FlatBufferBuilder builder, bool _Folded)
		{
			builder.AddBool(7, _Folded, false);
		}

		// Token: 0x0602E6BA RID: 190138 RVA: 0x00655A19 File Offset: 0x00653C19
		public static void Add_SelectedStateId(FlatBufferBuilder builder, int _SelectedStateId)
		{
			builder.AddInt(8, _SelectedStateId, 0);
		}

		// Token: 0x0602E6BB RID: 190139 RVA: 0x00655A24 File Offset: 0x00653C24
		public static void AddVarContextType(FlatBufferBuilder builder, TVarContext varContextType)
		{
			builder.AddByte(9, (byte)varContextType, 0);
		}

		// Token: 0x0602E6BC RID: 190140 RVA: 0x00655A30 File Offset: 0x00653C30
		public static void AddVarContext(FlatBufferBuilder builder, int varContextOffset)
		{
			builder.AddOffset(10, varContextOffset, 0);
		}

		// Token: 0x0602E6BD RID: 190141 RVA: 0x00655A3C File Offset: 0x00653C3C
		public static void AddStates(FlatBufferBuilder builder, VectorOffset statesOffset)
		{
			builder.AddOffset(11, statesOffset.Value, 0);
		}

		// Token: 0x0602E6BE RID: 190142 RVA: 0x00655A50 File Offset: 0x00653C50
		public static VectorOffset CreateStatesVector(FlatBufferBuilder builder, Offset<IStateInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602E6BF RID: 190143 RVA: 0x00655A90 File Offset: 0x00653C90
		public static VectorOffset CreateStatesVectorBlock(FlatBufferBuilder builder, Offset<IStateInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IStateInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602E6C0 RID: 190144 RVA: 0x00655AAA File Offset: 0x00653CAA
		public static VectorOffset CreateStatesVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IStateInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IStateInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602E6C1 RID: 190145 RVA: 0x00655AC8 File Offset: 0x00653CC8
		public static VectorOffset CreateStatesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IStateInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602E6C2 RID: 190146 RVA: 0x00655AE1 File Offset: 0x00653CE1
		public static void StartStatesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602E6C3 RID: 190147 RVA: 0x00655AEC File Offset: 0x00653CEC
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(12, nullMask, 0);
		}

		// Token: 0x0602E6C4 RID: 190148 RVA: 0x00655AF8 File Offset: 0x00653CF8
		public static Offset<IFlowInfo> EndIFlowInfo(FlatBufferBuilder builder)
		{
			return new Offset<IFlowInfo>(builder.EndTable());
		}

		// Token: 0x0602E6C5 RID: 190149 RVA: 0x00655B08 File Offset: 0x00653D08
		public IFlowInfoT UnPack()
		{
			IFlowInfoT flowInfoT = new IFlowInfoT();
			this.UnPackTo(flowInfoT);
			return flowInfoT;
		}

		// Token: 0x0602E6C6 RID: 190150 RVA: 0x00655B24 File Offset: 0x00653D24
		public void UnPackTo(IFlowInfoT _o)
		{
			_o.ObjType = this.ObjType;
			_o.Children = new List<string>();
			for (int i = 0; i < this.ChildrenLength; i++)
			{
				_o.Children.Add(this.Children(i));
			}
			_o.Reference = new List<string>();
			for (int j = 0; j < this.ReferenceLength; j++)
			{
				_o.Reference.Add(this.Reference(j));
			}
			_o.WeakReference = new List<string>();
			for (int k = 0; k < this.WeakReferenceLength; k++)
			{
				_o.WeakReference.Add(this.WeakReference(k));
			}
			_o.Id = this.Id;
			_o.Name = this.Name;
			_o.DungeonId = this.DungeonId;
			_o._Folded = this._Folded;
			_o._SelectedStateId = this._SelectedStateId;
			_o.VarContext = new TVarContextUnion();
			_o.VarContext.Type = this.VarContextType;
			switch (this.VarContextType)
			{
			case TVarContext.IBehaviorTreeFragmentContext:
				_o.VarContext.Value = ((this.VarContext<IBehaviorTreeFragmentContext>() != null) ? this.VarContext<IBehaviorTreeFragmentContext>().Value.UnPack() : null);
				break;
			case TVarContext.ICommonBtContext:
				_o.VarContext.Value = ((this.VarContext<ICommonBtContext>() != null) ? this.VarContext<ICommonBtContext>().Value.UnPack() : null);
				break;
			case TVarContext.IEntityTemplateContext:
				_o.VarContext.Value = ((this.VarContext<IEntityTemplateContext>() != null) ? this.VarContext<IEntityTemplateContext>().Value.UnPack() : null);
				break;
			case TVarContext.IEntityVarContext:
				_o.VarContext.Value = ((this.VarContext<IEntityVarContext>() != null) ? this.VarContext<IEntityVarContext>().Value.UnPack() : null);
				break;
			case TVarContext.ILevelPlayVarContext:
				_o.VarContext.Value = ((this.VarContext<ILevelPlayVarContext>() != null) ? this.VarContext<ILevelPlayVarContext>().Value.UnPack() : null);
				break;
			case TVarContext.IQuestVarContext:
				_o.VarContext.Value = ((this.VarContext<IQuestVarContext>() != null) ? this.VarContext<IQuestVarContext>().Value.UnPack() : null);
				break;
			}
			_o.States = new List<IStateInfoT>();
			for (int l = 0; l < this.StatesLength; l++)
			{
				_o.States.Add((this.States(l) != null) ? this.States(l).Value.UnPack() : null);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602E6C7 RID: 190151 RVA: 0x00655E10 File Offset: 0x00654010
		public static Offset<IFlowInfo> Pack(FlatBufferBuilder builder, IFlowInfoT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFlowInfo>);
			}
			StringOffset objTypeOffset = (_o.ObjType == null) ? default(StringOffset) : builder.CreateString(_o.ObjType);
			VectorOffset childrenOffset = default(VectorOffset);
			if (_o.Children != null)
			{
				StringOffset[] array = new StringOffset[_o.Children.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = builder.CreateString(_o.Children[i]);
				}
				childrenOffset = IFlowInfo.CreateChildrenVector(builder, array);
			}
			VectorOffset referenceOffset = default(VectorOffset);
			if (_o.Reference != null)
			{
				StringOffset[] array2 = new StringOffset[_o.Reference.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = builder.CreateString(_o.Reference[j]);
				}
				referenceOffset = IFlowInfo.CreateReferenceVector(builder, array2);
			}
			VectorOffset weakReferenceOffset = default(VectorOffset);
			if (_o.WeakReference != null)
			{
				StringOffset[] array3 = new StringOffset[_o.WeakReference.Count];
				for (int k = 0; k < array3.Length; k++)
				{
					array3[k] = builder.CreateString(_o.WeakReference[k]);
				}
				weakReferenceOffset = IFlowInfo.CreateWeakReferenceVector(builder, array3);
			}
			StringOffset nameOffset = (_o.Name == null) ? default(StringOffset) : builder.CreateString(_o.Name);
			TVarContext varContext_type = (_o.VarContext == null) ? TVarContext.NONE : _o.VarContext.Type;
			int varContextOffset = (_o.VarContext == null) ? 0 : TVarContextUnion.Pack(builder, _o.VarContext);
			VectorOffset statesOffset = default(VectorOffset);
			if (_o.States != null)
			{
				Offset<IStateInfo>[] array4 = new Offset<IStateInfo>[_o.States.Count];
				for (int l = 0; l < array4.Length; l++)
				{
					array4[l] = IStateInfo.Pack(builder, _o.States[l]);
				}
				statesOffset = IFlowInfo.CreateStatesVector(builder, array4);
			}
			return IFlowInfo.CreateIFlowInfo(builder, objTypeOffset, childrenOffset, referenceOffset, weakReferenceOffset, _o.Id, nameOffset, _o.DungeonId, _o._Folded, _o._SelectedStateId, varContext_type, varContextOffset, statesOffset, _o.NullMask);
		}

		// Token: 0x04010F3E RID: 69438
		private Table __p;
	}
}
