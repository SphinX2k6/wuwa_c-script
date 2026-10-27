using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004028 RID: 16424
	public struct IQuestScheduleMeetCondition : IFlatbufferObject
	{
		// Token: 0x17007386 RID: 29574
		// (get) Token: 0x06017BDE RID: 97246 RVA: 0x0036CC28 File Offset: 0x0036AE28
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06017BDF RID: 97247 RVA: 0x0036CC35 File Offset: 0x0036AE35
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06017BE0 RID: 97248 RVA: 0x0036CC3C File Offset: 0x0036AE3C
		public static IQuestScheduleMeetCondition GetRootAsIQuestScheduleMeetCondition(ByteBuffer _bb)
		{
			return IQuestScheduleMeetCondition.GetRootAsIQuestScheduleMeetCondition(_bb, default(IQuestScheduleMeetCondition));
		}

		// Token: 0x06017BE1 RID: 97249 RVA: 0x0036CC58 File Offset: 0x0036AE58
		public static IQuestScheduleMeetCondition GetRootAsIQuestScheduleMeetCondition(ByteBuffer _bb, IQuestScheduleMeetCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06017BE2 RID: 97250 RVA: 0x0036CC75 File Offset: 0x0036AE75
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06017BE3 RID: 97251 RVA: 0x0036CC84 File Offset: 0x0036AE84
		public IQuestScheduleMeetCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007387 RID: 29575
		// (get) Token: 0x06017BE4 RID: 97252 RVA: 0x0036CC94 File Offset: 0x0036AE94
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

		// Token: 0x17007388 RID: 29576
		// (get) Token: 0x06017BE5 RID: 97253 RVA: 0x0036CCD0 File Offset: 0x0036AED0
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

		// Token: 0x06017BE6 RID: 97254 RVA: 0x0036CD30 File Offset: 0x0036AF30
		public TVarRef VarsType(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return TVarRef.NONE;
			}
			return (TVarRef)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x17007389 RID: 29577
		// (get) Token: 0x06017BE7 RID: 97255 RVA: 0x0036CD70 File Offset: 0x0036AF70
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

		// Token: 0x06017BE8 RID: 97256 RVA: 0x0036CD9B File Offset: 0x0036AF9B
		public Span<TVarRef> GetVarsTypeBytes()
		{
			return this.__p.__vector_as_span<TVarRef>(8, 1);
		}

		// Token: 0x06017BE9 RID: 97257 RVA: 0x0036CDAC File Offset: 0x0036AFAC
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

		// Token: 0x06017BEA RID: 97258 RVA: 0x0036CE18 File Offset: 0x0036B018
		public TTable? Vars<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x1700738A RID: 29578
		// (get) Token: 0x06017BEB RID: 97259 RVA: 0x0036CE60 File Offset: 0x0036B060
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

		// Token: 0x1700738B RID: 29579
		// (get) Token: 0x06017BEC RID: 97260 RVA: 0x0036CE8C File Offset: 0x0036B08C
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

		// Token: 0x1700738C RID: 29580
		// (get) Token: 0x06017BED RID: 97261 RVA: 0x0036CECC File Offset: 0x0036B0CC
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

		// Token: 0x06017BEE RID: 97262 RVA: 0x0036CF09 File Offset: 0x0036B109
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

		// Token: 0x06017BEF RID: 97263 RVA: 0x0036CF45 File Offset: 0x0036B145
		public static void StartIQuestScheduleMeetCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x06017BF0 RID: 97264 RVA: 0x0036CF4E File Offset: 0x0036B14E
		public static void AddType(FlatBufferBuilder builder, EQuestScheduleType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06017BF1 RID: 97265 RVA: 0x0036CF59 File Offset: 0x0036B159
		public static void AddCondition(FlatBufferBuilder builder, Offset<IConditionGroup> conditionOffset)
		{
			builder.AddOffset(1, conditionOffset.Value, 0);
		}

		// Token: 0x06017BF2 RID: 97266 RVA: 0x0036CF69 File Offset: 0x0036B169
		public static void AddVarsType(FlatBufferBuilder builder, VectorOffset varsTypeOffset)
		{
			builder.AddOffset(2, varsTypeOffset.Value, 0);
		}

		// Token: 0x06017BF3 RID: 97267 RVA: 0x0036CF7C File Offset: 0x0036B17C
		public static VectorOffset CreateVarsTypeVector(FlatBufferBuilder builder, TVarRef[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06017BF4 RID: 97268 RVA: 0x0036CFB3 File Offset: 0x0036B1B3
		public static VectorOffset CreateVarsTypeVectorBlock(FlatBufferBuilder builder, TVarRef[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TVarRef>(data);
			return builder.EndVector();
		}

		// Token: 0x06017BF5 RID: 97269 RVA: 0x0036CFCD File Offset: 0x0036B1CD
		public static VectorOffset CreateVarsTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TVarRef> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TVarRef>(data);
			return builder.EndVector();
		}

		// Token: 0x06017BF6 RID: 97270 RVA: 0x0036CFEB File Offset: 0x0036B1EB
		public static VectorOffset CreateVarsTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TVarRef>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06017BF7 RID: 97271 RVA: 0x0036D004 File Offset: 0x0036B204
		public static void StartVarsTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x06017BF8 RID: 97272 RVA: 0x0036D00F File Offset: 0x0036B20F
		public static void AddVars(FlatBufferBuilder builder, VectorOffset varsOffset)
		{
			builder.AddOffset(3, varsOffset.Value, 0);
		}

		// Token: 0x06017BF9 RID: 97273 RVA: 0x0036D020 File Offset: 0x0036B220
		public static VectorOffset CreateVarsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06017BFA RID: 97274 RVA: 0x0036D057 File Offset: 0x0036B257
		public static VectorOffset CreateVarsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06017BFB RID: 97275 RVA: 0x0036D071 File Offset: 0x0036B271
		public static VectorOffset CreateVarsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06017BFC RID: 97276 RVA: 0x0036D08F File Offset: 0x0036B28F
		public static VectorOffset CreateVarsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06017BFD RID: 97277 RVA: 0x0036D0A8 File Offset: 0x0036B2A8
		public static void StartVarsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06017BFE RID: 97278 RVA: 0x0036D0B3 File Offset: 0x0036B2B3
		public static void AddIconType(FlatBufferBuilder builder, ETimeLeftIconType iconType)
		{
			builder.AddByte(4, (byte)iconType, 0);
		}

		// Token: 0x06017BFF RID: 97279 RVA: 0x0036D0BE File Offset: 0x0036B2BE
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x06017C00 RID: 97280 RVA: 0x0036D0C9 File Offset: 0x0036B2C9
		public static Offset<IQuestScheduleMeetCondition> EndIQuestScheduleMeetCondition(FlatBufferBuilder builder)
		{
			return new Offset<IQuestScheduleMeetCondition>(builder.EndTable());
		}

		// Token: 0x06017C01 RID: 97281 RVA: 0x0036D0D8 File Offset: 0x0036B2D8
		public IQuestScheduleMeetConditionT UnPack()
		{
			IQuestScheduleMeetConditionT questScheduleMeetConditionT = new IQuestScheduleMeetConditionT();
			this.UnPackTo(questScheduleMeetConditionT);
			return questScheduleMeetConditionT;
		}

		// Token: 0x06017C02 RID: 97282 RVA: 0x0036D0F4 File Offset: 0x0036B2F4
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

		// Token: 0x06017C03 RID: 97283 RVA: 0x0036D2D4 File Offset: 0x0036B4D4
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

		// Token: 0x0400BB53 RID: 47955
		private Table __p;
	}
}
