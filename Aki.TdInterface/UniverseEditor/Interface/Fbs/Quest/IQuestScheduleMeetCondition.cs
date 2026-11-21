using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004469 RID: 17513
	public struct IQuestScheduleMeetCondition : IFlatbufferObject
	{
		// Token: 0x17007988 RID: 31112
		// (get) Token: 0x06019277 RID: 103031 RVA: 0x00396A1C File Offset: 0x00394C1C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06019278 RID: 103032 RVA: 0x00396A29 File Offset: 0x00394C29
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06019279 RID: 103033 RVA: 0x00396A30 File Offset: 0x00394C30
		public static IQuestScheduleMeetCondition GetRootAsIQuestScheduleMeetCondition(ByteBuffer _bb)
		{
			return IQuestScheduleMeetCondition.GetRootAsIQuestScheduleMeetCondition(_bb, default(IQuestScheduleMeetCondition));
		}

		// Token: 0x0601927A RID: 103034 RVA: 0x00396A4C File Offset: 0x00394C4C
		public static IQuestScheduleMeetCondition GetRootAsIQuestScheduleMeetCondition(ByteBuffer _bb, IQuestScheduleMeetCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601927B RID: 103035 RVA: 0x00396A69 File Offset: 0x00394C69
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601927C RID: 103036 RVA: 0x00396A78 File Offset: 0x00394C78
		public IQuestScheduleMeetCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007989 RID: 31113
		// (get) Token: 0x0601927D RID: 103037 RVA: 0x00396A88 File Offset: 0x00394C88
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

		// Token: 0x1700798A RID: 31114
		// (get) Token: 0x0601927E RID: 103038 RVA: 0x00396AC4 File Offset: 0x00394CC4
		public IConditionGroup? Condition
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IConditionGroup?(default(IConditionGroup).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0601927F RID: 103039 RVA: 0x00396B24 File Offset: 0x00394D24
		public TVarRef VarsType(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return TVarRef.NONE;
			}
			return (TVarRef)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x1700798B RID: 31115
		// (get) Token: 0x06019280 RID: 103040 RVA: 0x00396B64 File Offset: 0x00394D64
		public int VarsTypeLength
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

		// Token: 0x06019281 RID: 103041 RVA: 0x00396B8F File Offset: 0x00394D8F
		public Span<TVarRef> GetVarsTypeBytes()
		{
			return this.__p.__vector_as_span<TVarRef>(8, 1);
		}

		// Token: 0x06019282 RID: 103042 RVA: 0x00396BA0 File Offset: 0x00394DA0
		public TVarRef[] GetVarsTypeArray()
		{
			int num = this.__p.__offset(8);
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

		// Token: 0x06019283 RID: 103043 RVA: 0x00396C0C File Offset: 0x00394E0C
		public TTable? Vars<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x1700798C RID: 31116
		// (get) Token: 0x06019284 RID: 103044 RVA: 0x00396C54 File Offset: 0x00394E54
		public int VarsLength
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

		// Token: 0x1700798D RID: 31117
		// (get) Token: 0x06019285 RID: 103045 RVA: 0x00396C80 File Offset: 0x00394E80
		public ETimeLeftIconType IconType
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return ETimeLeftIconType.AkiWorld;
				}
				return (ETimeLeftIconType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700798E RID: 31118
		// (get) Token: 0x06019286 RID: 103046 RVA: 0x00396CC0 File Offset: 0x00394EC0
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06019287 RID: 103047 RVA: 0x00396CFD File Offset: 0x00394EFD
		public static Offset<IQuestScheduleMeetCondition> CreateIQuestScheduleMeetCondition(FlatBufferBuilder builder, EQuestScheduleType Type = EQuestScheduleType.None, Offset<IConditionGroup> ConditionOffset = default(Offset<IConditionGroup>), VectorOffset Vars_typeOffset = default(VectorOffset), VectorOffset VarsOffset = default(VectorOffset), ETimeLeftIconType IconType = ETimeLeftIconType.AkiWorld, byte NullMask = 0)
		{
			builder.StartTable(6);
			IQuestScheduleMeetCondition.AddVars(builder, VarsOffset);
			IQuestScheduleMeetCondition.AddVarsType(builder, Vars_typeOffset);
			IQuestScheduleMeetCondition.AddCondition(builder, ConditionOffset);
			IQuestScheduleMeetCondition.AddNullMask(builder, NullMask);
			IQuestScheduleMeetCondition.AddIconType(builder, IconType);
			IQuestScheduleMeetCondition.AddType(builder, Type);
			return IQuestScheduleMeetCondition.EndIQuestScheduleMeetCondition(builder);
		}

		// Token: 0x06019288 RID: 103048 RVA: 0x00396D39 File Offset: 0x00394F39
		public static void StartIQuestScheduleMeetCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x06019289 RID: 103049 RVA: 0x00396D42 File Offset: 0x00394F42
		public static void AddType(FlatBufferBuilder builder, EQuestScheduleType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601928A RID: 103050 RVA: 0x00396D4D File Offset: 0x00394F4D
		public static void AddCondition(FlatBufferBuilder builder, Offset<IConditionGroup> conditionOffset)
		{
			builder.AddOffset(1, conditionOffset.Value, 0);
		}

		// Token: 0x0601928B RID: 103051 RVA: 0x00396D5D File Offset: 0x00394F5D
		public static void AddVarsType(FlatBufferBuilder builder, VectorOffset varsTypeOffset)
		{
			builder.AddOffset(2, varsTypeOffset.Value, 0);
		}

		// Token: 0x0601928C RID: 103052 RVA: 0x00396D70 File Offset: 0x00394F70
		public static VectorOffset CreateVarsTypeVector(FlatBufferBuilder builder, TVarRef[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601928D RID: 103053 RVA: 0x00396DA7 File Offset: 0x00394FA7
		public static VectorOffset CreateVarsTypeVectorBlock(FlatBufferBuilder builder, TVarRef[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TVarRef>(data);
			return builder.EndVector();
		}

		// Token: 0x0601928E RID: 103054 RVA: 0x00396DC1 File Offset: 0x00394FC1
		public static VectorOffset CreateVarsTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TVarRef> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TVarRef>(data);
			return builder.EndVector();
		}

		// Token: 0x0601928F RID: 103055 RVA: 0x00396DDF File Offset: 0x00394FDF
		public static VectorOffset CreateVarsTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TVarRef>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06019290 RID: 103056 RVA: 0x00396DF8 File Offset: 0x00394FF8
		public static void StartVarsTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x06019291 RID: 103057 RVA: 0x00396E03 File Offset: 0x00395003
		public static void AddVars(FlatBufferBuilder builder, VectorOffset varsOffset)
		{
			builder.AddOffset(3, varsOffset.Value, 0);
		}

		// Token: 0x06019292 RID: 103058 RVA: 0x00396E14 File Offset: 0x00395014
		public static VectorOffset CreateVarsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06019293 RID: 103059 RVA: 0x00396E4B File Offset: 0x0039504B
		public static VectorOffset CreateVarsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06019294 RID: 103060 RVA: 0x00396E65 File Offset: 0x00395065
		public static VectorOffset CreateVarsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06019295 RID: 103061 RVA: 0x00396E83 File Offset: 0x00395083
		public static VectorOffset CreateVarsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06019296 RID: 103062 RVA: 0x00396E9C File Offset: 0x0039509C
		public static void StartVarsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06019297 RID: 103063 RVA: 0x00396EA7 File Offset: 0x003950A7
		public static void AddIconType(FlatBufferBuilder builder, ETimeLeftIconType iconType)
		{
			builder.AddByte(4, (byte)iconType, 0);
		}

		// Token: 0x06019298 RID: 103064 RVA: 0x00396EB2 File Offset: 0x003950B2
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x06019299 RID: 103065 RVA: 0x00396EBD File Offset: 0x003950BD
		public static Offset<IQuestScheduleMeetCondition> EndIQuestScheduleMeetCondition(FlatBufferBuilder builder)
		{
			return new Offset<IQuestScheduleMeetCondition>(builder.EndTable());
		}

		// Token: 0x0601929A RID: 103066 RVA: 0x00396ECC File Offset: 0x003950CC
		public IQuestScheduleMeetConditionT UnPack()
		{
			IQuestScheduleMeetConditionT questScheduleMeetConditionT = new IQuestScheduleMeetConditionT();
			this.UnPackTo(questScheduleMeetConditionT);
			return questScheduleMeetConditionT;
		}

		// Token: 0x0601929B RID: 103067 RVA: 0x00396EE8 File Offset: 0x003950E8
		public void UnPackTo(IQuestScheduleMeetConditionT _o)
		{
			_o.Type = this.Type;
			_o.Condition = ((this.Condition != null) ? this.Condition.Value.UnPack() : null);
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
			_o.IconType = this.IconType;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601929C RID: 103068 RVA: 0x003970C8 File Offset: 0x003952C8
		public static Offset<IQuestScheduleMeetCondition> Pack(FlatBufferBuilder builder, IQuestScheduleMeetConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IQuestScheduleMeetCondition>);
			}
			Offset<IConditionGroup> conditionOffset = (_o.Condition == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.Condition);
			VectorOffset vars_typeOffset = default(VectorOffset);
			if (_o.Vars != null)
			{
				TVarRef[] array = new TVarRef[_o.Vars.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = _o.Vars[i].Type;
				}
				vars_typeOffset = IQuestScheduleMeetCondition.CreateVarsTypeVector(builder, array);
			}
			VectorOffset varsOffset = default(VectorOffset);
			if (_o.Vars != null)
			{
				int[] array2 = new int[_o.Vars.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = TVarRefUnion.Pack(builder, _o.Vars[j]);
				}
				varsOffset = IQuestScheduleMeetCondition.CreateVarsVector(builder, array2);
			}
			return IQuestScheduleMeetCondition.CreateIQuestScheduleMeetCondition(builder, _o.Type, conditionOffset, vars_typeOffset, varsOffset, _o.IconType, _o.NullMask);
		}

		// Token: 0x0400C53A RID: 50490
		private Table __p;
	}
}
