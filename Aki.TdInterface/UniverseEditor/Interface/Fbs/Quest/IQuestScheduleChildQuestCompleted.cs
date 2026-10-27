using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004016 RID: 16406
	public struct IQuestScheduleChildQuestCompleted : IFlatbufferObject
	{
		// Token: 0x1700734D RID: 29517
		// (get) Token: 0x06017AF7 RID: 97015 RVA: 0x0036A937 File Offset: 0x00368B37
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06017AF8 RID: 97016 RVA: 0x0036A944 File Offset: 0x00368B44
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06017AF9 RID: 97017 RVA: 0x0036A94C File Offset: 0x00368B4C
		public static IQuestScheduleChildQuestCompleted GetRootAsIQuestScheduleChildQuestCompleted(ByteBuffer _bb)
		{
			return IQuestScheduleChildQuestCompleted.GetRootAsIQuestScheduleChildQuestCompleted(_bb, default(IQuestScheduleChildQuestCompleted));
		}

		// Token: 0x06017AFA RID: 97018 RVA: 0x0036A968 File Offset: 0x00368B68
		public static IQuestScheduleChildQuestCompleted GetRootAsIQuestScheduleChildQuestCompleted(ByteBuffer _bb, IQuestScheduleChildQuestCompleted obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06017AFB RID: 97019 RVA: 0x0036A985 File Offset: 0x00368B85
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06017AFC RID: 97020 RVA: 0x0036A994 File Offset: 0x00368B94
		public IQuestScheduleChildQuestCompleted __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700734E RID: 29518
		// (get) Token: 0x06017AFD RID: 97021 RVA: 0x0036A9A4 File Offset: 0x00368BA4
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

		// Token: 0x1700734F RID: 29519
		// (get) Token: 0x06017AFE RID: 97022 RVA: 0x0036A9E0 File Offset: 0x00368BE0
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

		// Token: 0x17007350 RID: 29520
		// (get) Token: 0x06017AFF RID: 97023 RVA: 0x0036AA1C File Offset: 0x00368C1C
		public bool ShowTracking
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17007351 RID: 29521
		// (get) Token: 0x06017B00 RID: 97024 RVA: 0x0036AA5C File Offset: 0x00368C5C
		public bool ShowComplete
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17007352 RID: 29522
		// (get) Token: 0x06017B01 RID: 97025 RVA: 0x0036AA9C File Offset: 0x00368C9C
		public bool OnlyShowWhileRunning
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06017B02 RID: 97026 RVA: 0x0036AADC File Offset: 0x00368CDC
		public TVarRef VarsType(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return TVarRef.NONE;
			}
			return (TVarRef)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x17007353 RID: 29523
		// (get) Token: 0x06017B03 RID: 97027 RVA: 0x0036AB1C File Offset: 0x00368D1C
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

		// Token: 0x06017B04 RID: 97028 RVA: 0x0036AB48 File Offset: 0x00368D48
		public Span<TVarRef> GetVarsTypeBytes()
		{
			return this.__p.__vector_as_span<TVarRef>(14, 1);
		}

		// Token: 0x06017B05 RID: 97029 RVA: 0x0036AB58 File Offset: 0x00368D58
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

		// Token: 0x06017B06 RID: 97030 RVA: 0x0036ABC4 File Offset: 0x00368DC4
		public TTable? Vars<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x17007354 RID: 29524
		// (get) Token: 0x06017B07 RID: 97031 RVA: 0x0036AC0C File Offset: 0x00368E0C
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

		// Token: 0x17007355 RID: 29525
		// (get) Token: 0x06017B08 RID: 97032 RVA: 0x0036AC38 File Offset: 0x00368E38
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

		// Token: 0x17007356 RID: 29526
		// (get) Token: 0x06017B09 RID: 97033 RVA: 0x0036AC78 File Offset: 0x00368E78
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

		// Token: 0x17007357 RID: 29527
		// (get) Token: 0x06017B0A RID: 97034 RVA: 0x0036ACD8 File Offset: 0x00368ED8
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

		// Token: 0x06017B0B RID: 97035 RVA: 0x0036AD18 File Offset: 0x00368F18
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

		// Token: 0x06017B0C RID: 97036 RVA: 0x0036AD80 File Offset: 0x00368F80
		public static void StartIQuestScheduleChildQuestCompleted(FlatBufferBuilder builder)
		{
			builder.StartTable(10);
		}

		// Token: 0x06017B0D RID: 97037 RVA: 0x0036AD8A File Offset: 0x00368F8A
		public static void AddType(FlatBufferBuilder builder, EQuestScheduleType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06017B0E RID: 97038 RVA: 0x0036AD95 File Offset: 0x00368F95
		public static void AddChildQuestId(FlatBufferBuilder builder, int childQuestId)
		{
			builder.AddInt(1, childQuestId, 0);
		}

		// Token: 0x06017B0F RID: 97039 RVA: 0x0036ADA0 File Offset: 0x00368FA0
		public static void AddShowTracking(FlatBufferBuilder builder, bool showTracking)
		{
			builder.AddBool(2, showTracking, false);
		}

		// Token: 0x06017B10 RID: 97040 RVA: 0x0036ADAB File Offset: 0x00368FAB
		public static void AddShowComplete(FlatBufferBuilder builder, bool showComplete)
		{
			builder.AddBool(3, showComplete, false);
		}

		// Token: 0x06017B11 RID: 97041 RVA: 0x0036ADB6 File Offset: 0x00368FB6
		public static void AddOnlyShowWhileRunning(FlatBufferBuilder builder, bool onlyShowWhileRunning)
		{
			builder.AddBool(4, onlyShowWhileRunning, false);
		}

		// Token: 0x06017B12 RID: 97042 RVA: 0x0036ADC1 File Offset: 0x00368FC1
		public static void AddVarsType(FlatBufferBuilder builder, VectorOffset varsTypeOffset)
		{
			builder.AddOffset(5, varsTypeOffset.Value, 0);
		}

		// Token: 0x06017B13 RID: 97043 RVA: 0x0036ADD4 File Offset: 0x00368FD4
		public static VectorOffset CreateVarsTypeVector(FlatBufferBuilder builder, TVarRef[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06017B14 RID: 97044 RVA: 0x0036AE0B File Offset: 0x0036900B
		public static VectorOffset CreateVarsTypeVectorBlock(FlatBufferBuilder builder, TVarRef[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TVarRef>(data);
			return builder.EndVector();
		}

		// Token: 0x06017B15 RID: 97045 RVA: 0x0036AE25 File Offset: 0x00369025
		public static VectorOffset CreateVarsTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TVarRef> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TVarRef>(data);
			return builder.EndVector();
		}

		// Token: 0x06017B16 RID: 97046 RVA: 0x0036AE43 File Offset: 0x00369043
		public static VectorOffset CreateVarsTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TVarRef>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06017B17 RID: 97047 RVA: 0x0036AE5C File Offset: 0x0036905C
		public static void StartVarsTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x06017B18 RID: 97048 RVA: 0x0036AE67 File Offset: 0x00369067
		public static void AddVars(FlatBufferBuilder builder, VectorOffset varsOffset)
		{
			builder.AddOffset(6, varsOffset.Value, 0);
		}

		// Token: 0x06017B19 RID: 97049 RVA: 0x0036AE78 File Offset: 0x00369078
		public static VectorOffset CreateVarsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06017B1A RID: 97050 RVA: 0x0036AEAF File Offset: 0x003690AF
		public static VectorOffset CreateVarsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06017B1B RID: 97051 RVA: 0x0036AEC9 File Offset: 0x003690C9
		public static VectorOffset CreateVarsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06017B1C RID: 97052 RVA: 0x0036AEE7 File Offset: 0x003690E7
		public static VectorOffset CreateVarsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06017B1D RID: 97053 RVA: 0x0036AF00 File Offset: 0x00369100
		public static void StartVarsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06017B1E RID: 97054 RVA: 0x0036AF0B File Offset: 0x0036910B
		public static void AddCustomIcon(FlatBufferBuilder builder, int customIcon)
		{
			builder.AddInt(7, customIcon, 0);
		}

		// Token: 0x06017B1F RID: 97055 RVA: 0x0036AF16 File Offset: 0x00369116
		public static void AddTitlePreState(FlatBufferBuilder builder, Offset<ITitlePreState> titlePreStateOffset)
		{
			builder.AddOffset(8, titlePreStateOffset.Value, 0);
		}

		// Token: 0x06017B20 RID: 97056 RVA: 0x0036AF26 File Offset: 0x00369126
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(9, nullMask, 0);
		}

		// Token: 0x06017B21 RID: 97057 RVA: 0x0036AF32 File Offset: 0x00369132
		public static Offset<IQuestScheduleChildQuestCompleted> EndIQuestScheduleChildQuestCompleted(FlatBufferBuilder builder)
		{
			return new Offset<IQuestScheduleChildQuestCompleted>(builder.EndTable());
		}

		// Token: 0x06017B22 RID: 97058 RVA: 0x0036AF40 File Offset: 0x00369140
		public IQuestScheduleChildQuestCompletedT UnPack()
		{
			IQuestScheduleChildQuestCompletedT questScheduleChildQuestCompletedT = new IQuestScheduleChildQuestCompletedT();
			this.UnPackTo(questScheduleChildQuestCompletedT);
			return questScheduleChildQuestCompletedT;
		}

		// Token: 0x06017B23 RID: 97059 RVA: 0x0036AF5C File Offset: 0x0036915C
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

		// Token: 0x06017B24 RID: 97060 RVA: 0x0036B16C File Offset: 0x0036936C
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

		// Token: 0x0400BB34 RID: 47924
		private Table __p;
	}
}
