using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004457 RID: 17495
	public struct IQuestScheduleChildQuestCompleted : IFlatbufferObject
	{
		// Token: 0x1700794F RID: 31055
		// (get) Token: 0x06019190 RID: 102800 RVA: 0x0039472B File Offset: 0x0039292B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06019191 RID: 102801 RVA: 0x00394738 File Offset: 0x00392938
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06019192 RID: 102802 RVA: 0x00394740 File Offset: 0x00392940
		public static IQuestScheduleChildQuestCompleted GetRootAsIQuestScheduleChildQuestCompleted(ByteBuffer _bb)
		{
			return IQuestScheduleChildQuestCompleted.GetRootAsIQuestScheduleChildQuestCompleted(_bb, default(IQuestScheduleChildQuestCompleted));
		}

		// Token: 0x06019193 RID: 102803 RVA: 0x0039475C File Offset: 0x0039295C
		public static IQuestScheduleChildQuestCompleted GetRootAsIQuestScheduleChildQuestCompleted(ByteBuffer _bb, IQuestScheduleChildQuestCompleted obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06019194 RID: 102804 RVA: 0x00394779 File Offset: 0x00392979
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06019195 RID: 102805 RVA: 0x00394788 File Offset: 0x00392988
		public IQuestScheduleChildQuestCompleted __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007950 RID: 31056
		// (get) Token: 0x06019196 RID: 102806 RVA: 0x00394798 File Offset: 0x00392998
		public EQuestScheduleType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EQuestScheduleType.None;
				}
				return (EQuestScheduleType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007951 RID: 31057
		// (get) Token: 0x06019197 RID: 102807 RVA: 0x003947D4 File Offset: 0x003929D4
		public int ChildQuestId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007952 RID: 31058
		// (get) Token: 0x06019198 RID: 102808 RVA: 0x00394810 File Offset: 0x00392A10
		public bool ShowTracking
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17007953 RID: 31059
		// (get) Token: 0x06019199 RID: 102809 RVA: 0x00394850 File Offset: 0x00392A50
		public bool ShowComplete
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17007954 RID: 31060
		// (get) Token: 0x0601919A RID: 102810 RVA: 0x00394890 File Offset: 0x00392A90
		public bool OnlyShowWhileRunning
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0601919B RID: 102811 RVA: 0x003948D0 File Offset: 0x00392AD0
		public TVarRef VarsType(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return TVarRef.NONE;
			}
			return (TVarRef)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x17007955 RID: 31061
		// (get) Token: 0x0601919C RID: 102812 RVA: 0x00394910 File Offset: 0x00392B10
		public int VarsTypeLength
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0601919D RID: 102813 RVA: 0x0039493C File Offset: 0x00392B3C
		public Span<TVarRef> GetVarsTypeBytes()
		{
			return this.__p.__vector_as_span<TVarRef>(14, 1);
		}

		// Token: 0x0601919E RID: 102814 RVA: 0x0039494C File Offset: 0x00392B4C
		public TVarRef[] GetVarsTypeArray()
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			int num2 = this.__p.__vector(num);
			int num3 = this.__p.__vector_len(num);
			TVarRef[] array = new TVarRef[num3];
			for (int i = 0; i < num3; i++)
			{
				array[i] = (TVarRef)this.__p.bb.Get(num2 + i);
			}
			return array;
		}

		// Token: 0x0601919F RID: 102815 RVA: 0x003949B8 File Offset: 0x00392BB8
		public TTable? Vars<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x17007956 RID: 31062
		// (get) Token: 0x060191A0 RID: 102816 RVA: 0x00394A00 File Offset: 0x00392C00
		public int VarsLength
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17007957 RID: 31063
		// (get) Token: 0x060191A1 RID: 102817 RVA: 0x00394A2C File Offset: 0x00392C2C
		public int CustomIcon
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007958 RID: 31064
		// (get) Token: 0x060191A2 RID: 102818 RVA: 0x00394A6C File Offset: 0x00392C6C
		public ITitlePreState? TitlePreState
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return null;
				}
				return new ITitlePreState?(default(ITitlePreState).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17007959 RID: 31065
		// (get) Token: 0x060191A3 RID: 102819 RVA: 0x00394ACC File Offset: 0x00392CCC
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060191A4 RID: 102820 RVA: 0x00394B0C File Offset: 0x00392D0C
		public static Offset<IQuestScheduleChildQuestCompleted> CreateIQuestScheduleChildQuestCompleted(FlatBufferBuilder builder, EQuestScheduleType Type = EQuestScheduleType.None, int ChildQuestId = 0, bool ShowTracking = false, bool ShowComplete = false, bool OnlyShowWhileRunning = false, VectorOffset Vars_typeOffset = default(VectorOffset), VectorOffset VarsOffset = default(VectorOffset), int CustomIcon = 0, Offset<ITitlePreState> TitlePreStateOffset = default(Offset<ITitlePreState>), byte NullMask = 0)
		{
			builder.StartTable(10);
			IQuestScheduleChildQuestCompleted.AddTitlePreState(builder, TitlePreStateOffset);
			IQuestScheduleChildQuestCompleted.AddCustomIcon(builder, CustomIcon);
			IQuestScheduleChildQuestCompleted.AddVars(builder, VarsOffset);
			IQuestScheduleChildQuestCompleted.AddVarsType(builder, Vars_typeOffset);
			IQuestScheduleChildQuestCompleted.AddChildQuestId(builder, ChildQuestId);
			IQuestScheduleChildQuestCompleted.AddNullMask(builder, NullMask);
			IQuestScheduleChildQuestCompleted.AddOnlyShowWhileRunning(builder, OnlyShowWhileRunning);
			IQuestScheduleChildQuestCompleted.AddShowComplete(builder, ShowComplete);
			IQuestScheduleChildQuestCompleted.AddShowTracking(builder, ShowTracking);
			IQuestScheduleChildQuestCompleted.AddType(builder, Type);
			return IQuestScheduleChildQuestCompleted.EndIQuestScheduleChildQuestCompleted(builder);
		}

		// Token: 0x060191A5 RID: 102821 RVA: 0x00394B74 File Offset: 0x00392D74
		public static void StartIQuestScheduleChildQuestCompleted(FlatBufferBuilder builder)
		{
			builder.StartTable(10);
		}

		// Token: 0x060191A6 RID: 102822 RVA: 0x00394B7E File Offset: 0x00392D7E
		public static void AddType(FlatBufferBuilder builder, EQuestScheduleType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060191A7 RID: 102823 RVA: 0x00394B89 File Offset: 0x00392D89
		public static void AddChildQuestId(FlatBufferBuilder builder, int childQuestId)
		{
			builder.AddInt(1, childQuestId, 0);
		}

		// Token: 0x060191A8 RID: 102824 RVA: 0x00394B94 File Offset: 0x00392D94
		public static void AddShowTracking(FlatBufferBuilder builder, bool showTracking)
		{
			builder.AddBool(2, showTracking, false);
		}

		// Token: 0x060191A9 RID: 102825 RVA: 0x00394B9F File Offset: 0x00392D9F
		public static void AddShowComplete(FlatBufferBuilder builder, bool showComplete)
		{
			builder.AddBool(3, showComplete, false);
		}

		// Token: 0x060191AA RID: 102826 RVA: 0x00394BAA File Offset: 0x00392DAA
		public static void AddOnlyShowWhileRunning(FlatBufferBuilder builder, bool onlyShowWhileRunning)
		{
			builder.AddBool(4, onlyShowWhileRunning, false);
		}

		// Token: 0x060191AB RID: 102827 RVA: 0x00394BB5 File Offset: 0x00392DB5
		public static void AddVarsType(FlatBufferBuilder builder, VectorOffset varsTypeOffset)
		{
			builder.AddOffset(5, varsTypeOffset.Value, 0);
		}

		// Token: 0x060191AC RID: 102828 RVA: 0x00394BC8 File Offset: 0x00392DC8
		public static VectorOffset CreateVarsTypeVector(FlatBufferBuilder builder, TVarRef[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x060191AD RID: 102829 RVA: 0x00394BFF File Offset: 0x00392DFF
		public static VectorOffset CreateVarsTypeVectorBlock(FlatBufferBuilder builder, TVarRef[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TVarRef>(data);
			return builder.EndVector();
		}

		// Token: 0x060191AE RID: 102830 RVA: 0x00394C19 File Offset: 0x00392E19
		public static VectorOffset CreateVarsTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TVarRef> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TVarRef>(data);
			return builder.EndVector();
		}

		// Token: 0x060191AF RID: 102831 RVA: 0x00394C37 File Offset: 0x00392E37
		public static VectorOffset CreateVarsTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TVarRef>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060191B0 RID: 102832 RVA: 0x00394C50 File Offset: 0x00392E50
		public static void StartVarsTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x060191B1 RID: 102833 RVA: 0x00394C5B File Offset: 0x00392E5B
		public static void AddVars(FlatBufferBuilder builder, VectorOffset varsOffset)
		{
			builder.AddOffset(6, varsOffset.Value, 0);
		}

		// Token: 0x060191B2 RID: 102834 RVA: 0x00394C6C File Offset: 0x00392E6C
		public static VectorOffset CreateVarsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x060191B3 RID: 102835 RVA: 0x00394CA3 File Offset: 0x00392EA3
		public static VectorOffset CreateVarsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060191B4 RID: 102836 RVA: 0x00394CBD File Offset: 0x00392EBD
		public static VectorOffset CreateVarsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060191B5 RID: 102837 RVA: 0x00394CDB File Offset: 0x00392EDB
		public static VectorOffset CreateVarsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060191B6 RID: 102838 RVA: 0x00394CF4 File Offset: 0x00392EF4
		public static void StartVarsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060191B7 RID: 102839 RVA: 0x00394CFF File Offset: 0x00392EFF
		public static void AddCustomIcon(FlatBufferBuilder builder, int customIcon)
		{
			builder.AddInt(7, customIcon, 0);
		}

		// Token: 0x060191B8 RID: 102840 RVA: 0x00394D0A File Offset: 0x00392F0A
		public static void AddTitlePreState(FlatBufferBuilder builder, Offset<ITitlePreState> titlePreStateOffset)
		{
			builder.AddOffset(8, titlePreStateOffset.Value, 0);
		}

		// Token: 0x060191B9 RID: 102841 RVA: 0x00394D1A File Offset: 0x00392F1A
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(9, nullMask, 0);
		}

		// Token: 0x060191BA RID: 102842 RVA: 0x00394D26 File Offset: 0x00392F26
		public static Offset<IQuestScheduleChildQuestCompleted> EndIQuestScheduleChildQuestCompleted(FlatBufferBuilder builder)
		{
			return new Offset<IQuestScheduleChildQuestCompleted>(builder.EndTable());
		}

		// Token: 0x060191BB RID: 102843 RVA: 0x00394D34 File Offset: 0x00392F34
		public IQuestScheduleChildQuestCompletedT UnPack()
		{
			IQuestScheduleChildQuestCompletedT questScheduleChildQuestCompletedT = new IQuestScheduleChildQuestCompletedT();
			this.UnPackTo(questScheduleChildQuestCompletedT);
			return questScheduleChildQuestCompletedT;
		}

		// Token: 0x060191BC RID: 102844 RVA: 0x00394D50 File Offset: 0x00392F50
		public void UnPackTo(IQuestScheduleChildQuestCompletedT _o)
		{
			_o.Type = this.Type;
			_o.ChildQuestId = this.ChildQuestId;
			_o.ShowTracking = this.ShowTracking;
			_o.ShowComplete = this.ShowComplete;
			_o.OnlyShowWhileRunning = this.OnlyShowWhileRunning;
			_o.Vars = new List<TVarRefUnion>();
			for (int i = 0; i < this.VarsLength; i++)
			{
				TVarRefUnion tvarRefUnion = new TVarRefUnion();
				tvarRefUnion.Type = this.VarsType(i);
				switch (this.VarsType(i))
				{
				case TVarRef.IConstVarRef:
					tvarRefUnion.Value = ((this.Vars<IConstVarRef>(i) != null) ? this.Vars<IConstVarRef>(i).Value.UnPack() : null);
					break;
				case TVarRef.IGlobalVarRef:
					tvarRefUnion.Value = ((this.Vars<IGlobalVarRef>(i) != null) ? this.Vars<IGlobalVarRef>(i).Value.UnPack() : null);
					break;
				case TVarRef.IOtherVarRef:
					tvarRefUnion.Value = ((this.Vars<IOtherVarRef>(i) != null) ? this.Vars<IOtherVarRef>(i).Value.UnPack() : null);
					break;
				case TVarRef.ISelfVarRef:
					tvarRefUnion.Value = ((this.Vars<ISelfVarRef>(i) != null) ? this.Vars<ISelfVarRef>(i).Value.UnPack() : null);
					break;
				case TVarRef.ISystemVarRef:
					tvarRefUnion.Value = ((this.Vars<ISystemVarRef>(i) != null) ? this.Vars<ISystemVarRef>(i).Value.UnPack() : null);
					break;
				}
				_o.Vars.Add(tvarRefUnion);
			}
			_o.CustomIcon = this.CustomIcon;
			_o.TitlePreState = ((this.TitlePreState != null) ? this.TitlePreState.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060191BD RID: 102845 RVA: 0x00394F60 File Offset: 0x00393160
		public static Offset<IQuestScheduleChildQuestCompleted> Pack(FlatBufferBuilder builder, IQuestScheduleChildQuestCompletedT _o)
		{
			if (_o == null)
			{
				return default(Offset<IQuestScheduleChildQuestCompleted>);
			}
			VectorOffset vars_typeOffset = default(VectorOffset);
			if (_o.Vars != null)
			{
				TVarRef[] array = new TVarRef[_o.Vars.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = _o.Vars[i].Type;
				}
				vars_typeOffset = IQuestScheduleChildQuestCompleted.CreateVarsTypeVector(builder, array);
			}
			VectorOffset varsOffset = default(VectorOffset);
			if (_o.Vars != null)
			{
				int[] array2 = new int[_o.Vars.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = TVarRefUnion.Pack(builder, _o.Vars[j]);
				}
				varsOffset = IQuestScheduleChildQuestCompleted.CreateVarsVector(builder, array2);
			}
			Offset<ITitlePreState> titlePreStateOffset = (_o.TitlePreState == null) ? default(Offset<ITitlePreState>) : ITitlePreState.Pack(builder, _o.TitlePreState);
			return IQuestScheduleChildQuestCompleted.CreateIQuestScheduleChildQuestCompleted(builder, _o.Type, _o.ChildQuestId, _o.ShowTracking, _o.ShowComplete, _o.OnlyShowWhileRunning, vars_typeOffset, varsOffset, _o.CustomIcon, titlePreStateOffset, _o.NullMask);
		}

		// Token: 0x0400C51B RID: 50459
		private Table __p;
	}
}
