using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003FF2 RID: 16370
	public struct IQuestMonsterHealthScore : IFlatbufferObject
	{
		// Token: 0x170072E8 RID: 29416
		// (get) Token: 0x06017942 RID: 96578 RVA: 0x003668F6 File Offset: 0x00364AF6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06017943 RID: 96579 RVA: 0x00366903 File Offset: 0x00364B03
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06017944 RID: 96580 RVA: 0x0036690C File Offset: 0x00364B0C
		public static IQuestMonsterHealthScore GetRootAsIQuestMonsterHealthScore(ByteBuffer _bb)
		{
			return IQuestMonsterHealthScore.GetRootAsIQuestMonsterHealthScore(_bb, default(IQuestMonsterHealthScore));
		}

		// Token: 0x06017945 RID: 96581 RVA: 0x00366928 File Offset: 0x00364B28
		public static IQuestMonsterHealthScore GetRootAsIQuestMonsterHealthScore(ByteBuffer _bb, IQuestMonsterHealthScore obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06017946 RID: 96582 RVA: 0x00366945 File Offset: 0x00364B45
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06017947 RID: 96583 RVA: 0x00366954 File Offset: 0x00364B54
		public IQuestMonsterHealthScore __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170072E9 RID: 29417
		// (get) Token: 0x06017948 RID: 96584 RVA: 0x00366964 File Offset: 0x00364B64
		public EStatisticsEventType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EStatisticsEventType.Collect;
				}
				return (EStatisticsEventType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170072EA RID: 29418
		// (get) Token: 0x06017949 RID: 96585 RVA: 0x003669A0 File Offset: 0x00364BA0
		public TVarRef VarType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TVarRef.NONE;
				}
				return (TVarRef)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601794A RID: 96586 RVA: 0x003669DC File Offset: 0x00364BDC
		public TTable? Var<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601794B RID: 96587 RVA: 0x00366A20 File Offset: 0x00364C20
		public IConstVarRef VarAsIConstVarRef()
		{
			return this.Var<IConstVarRef>().Value;
		}

		// Token: 0x0601794C RID: 96588 RVA: 0x00366A3C File Offset: 0x00364C3C
		public IGlobalVarRef VarAsIGlobalVarRef()
		{
			return this.Var<IGlobalVarRef>().Value;
		}

		// Token: 0x0601794D RID: 96589 RVA: 0x00366A58 File Offset: 0x00364C58
		public IOtherVarRef VarAsIOtherVarRef()
		{
			return this.Var<IOtherVarRef>().Value;
		}

		// Token: 0x0601794E RID: 96590 RVA: 0x00366A74 File Offset: 0x00364C74
		public ISelfVarRef VarAsISelfVarRef()
		{
			return this.Var<ISelfVarRef>().Value;
		}

		// Token: 0x0601794F RID: 96591 RVA: 0x00366A90 File Offset: 0x00364C90
		public ISystemVarRef VarAsISystemVarRef()
		{
			return this.Var<ISystemVarRef>().Value;
		}

		// Token: 0x06017950 RID: 96592 RVA: 0x00366AAC File Offset: 0x00364CAC
		public IMonsterHpPointTypeConfig? TypeConfigs(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new IMonsterHpPointTypeConfig?(default(IMonsterHpPointTypeConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170072EB RID: 29419
		// (get) Token: 0x06017951 RID: 96593 RVA: 0x00366B10 File Offset: 0x00364D10
		public int TypeConfigsLength
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

		// Token: 0x06017952 RID: 96594 RVA: 0x00366B3C File Offset: 0x00364D3C
		public IMonsterHpPointEntityConfig? EntityConfigs(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new IMonsterHpPointEntityConfig?(default(IMonsterHpPointEntityConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170072EC RID: 29420
		// (get) Token: 0x06017953 RID: 96595 RVA: 0x00366BA0 File Offset: 0x00364DA0
		public int EntityConfigsLength
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x170072ED RID: 29421
		// (get) Token: 0x06017954 RID: 96596 RVA: 0x00366BCC File Offset: 0x00364DCC
		public bool IsStatisticsRecoveredHp
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170072EE RID: 29422
		// (get) Token: 0x06017955 RID: 96597 RVA: 0x00366C0C File Offset: 0x00364E0C
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06017956 RID: 96598 RVA: 0x00366C4C File Offset: 0x00364E4C
		public static Offset<IQuestMonsterHealthScore> CreateIQuestMonsterHealthScore(FlatBufferBuilder builder, EStatisticsEventType Type = EStatisticsEventType.Collect, TVarRef Var_type = TVarRef.NONE, int VarOffset = 0, VectorOffset TypeConfigsOffset = default(VectorOffset), VectorOffset EntityConfigsOffset = default(VectorOffset), bool IsStatisticsRecoveredHp = false, byte NullMask = 0)
		{
			builder.StartTable(7);
			IQuestMonsterHealthScore.AddEntityConfigs(builder, EntityConfigsOffset);
			IQuestMonsterHealthScore.AddTypeConfigs(builder, TypeConfigsOffset);
			IQuestMonsterHealthScore.AddVar(builder, VarOffset);
			IQuestMonsterHealthScore.AddNullMask(builder, NullMask);
			IQuestMonsterHealthScore.AddIsStatisticsRecoveredHp(builder, IsStatisticsRecoveredHp);
			IQuestMonsterHealthScore.AddVarType(builder, Var_type);
			IQuestMonsterHealthScore.AddType(builder, Type);
			return IQuestMonsterHealthScore.EndIQuestMonsterHealthScore(builder);
		}

		// Token: 0x06017957 RID: 96599 RVA: 0x00366C9B File Offset: 0x00364E9B
		public static void StartIQuestMonsterHealthScore(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x06017958 RID: 96600 RVA: 0x00366CA4 File Offset: 0x00364EA4
		public static void AddType(FlatBufferBuilder builder, EStatisticsEventType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06017959 RID: 96601 RVA: 0x00366CAF File Offset: 0x00364EAF
		public static void AddVarType(FlatBufferBuilder builder, TVarRef varType)
		{
			builder.AddByte(1, (byte)varType, 0);
		}

		// Token: 0x0601795A RID: 96602 RVA: 0x00366CBA File Offset: 0x00364EBA
		public static void AddVar(FlatBufferBuilder builder, int varOffset)
		{
			builder.AddOffset(2, varOffset, 0);
		}

		// Token: 0x0601795B RID: 96603 RVA: 0x00366CC5 File Offset: 0x00364EC5
		public static void AddTypeConfigs(FlatBufferBuilder builder, VectorOffset typeConfigsOffset)
		{
			builder.AddOffset(3, typeConfigsOffset.Value, 0);
		}

		// Token: 0x0601795C RID: 96604 RVA: 0x00366CD8 File Offset: 0x00364ED8
		public static VectorOffset CreateTypeConfigsVector(FlatBufferBuilder builder, Offset<IMonsterHpPointTypeConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601795D RID: 96605 RVA: 0x00366D18 File Offset: 0x00364F18
		public static VectorOffset CreateTypeConfigsVectorBlock(FlatBufferBuilder builder, Offset<IMonsterHpPointTypeConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IMonsterHpPointTypeConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601795E RID: 96606 RVA: 0x00366D32 File Offset: 0x00364F32
		public static VectorOffset CreateTypeConfigsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IMonsterHpPointTypeConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IMonsterHpPointTypeConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601795F RID: 96607 RVA: 0x00366D50 File Offset: 0x00364F50
		public static VectorOffset CreateTypeConfigsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IMonsterHpPointTypeConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06017960 RID: 96608 RVA: 0x00366D69 File Offset: 0x00364F69
		public static void StartTypeConfigsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06017961 RID: 96609 RVA: 0x00366D74 File Offset: 0x00364F74
		public static void AddEntityConfigs(FlatBufferBuilder builder, VectorOffset entityConfigsOffset)
		{
			builder.AddOffset(4, entityConfigsOffset.Value, 0);
		}

		// Token: 0x06017962 RID: 96610 RVA: 0x00366D84 File Offset: 0x00364F84
		public static VectorOffset CreateEntityConfigsVector(FlatBufferBuilder builder, Offset<IMonsterHpPointEntityConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06017963 RID: 96611 RVA: 0x00366DC4 File Offset: 0x00364FC4
		public static VectorOffset CreateEntityConfigsVectorBlock(FlatBufferBuilder builder, Offset<IMonsterHpPointEntityConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IMonsterHpPointEntityConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06017964 RID: 96612 RVA: 0x00366DDE File Offset: 0x00364FDE
		public static VectorOffset CreateEntityConfigsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IMonsterHpPointEntityConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IMonsterHpPointEntityConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06017965 RID: 96613 RVA: 0x00366DFC File Offset: 0x00364FFC
		public static VectorOffset CreateEntityConfigsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IMonsterHpPointEntityConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06017966 RID: 96614 RVA: 0x00366E15 File Offset: 0x00365015
		public static void StartEntityConfigsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06017967 RID: 96615 RVA: 0x00366E20 File Offset: 0x00365020
		public static void AddIsStatisticsRecoveredHp(FlatBufferBuilder builder, bool isStatisticsRecoveredHp)
		{
			builder.AddBool(5, isStatisticsRecoveredHp, false);
		}

		// Token: 0x06017968 RID: 96616 RVA: 0x00366E2B File Offset: 0x0036502B
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x06017969 RID: 96617 RVA: 0x00366E36 File Offset: 0x00365036
		public static Offset<IQuestMonsterHealthScore> EndIQuestMonsterHealthScore(FlatBufferBuilder builder)
		{
			return new Offset<IQuestMonsterHealthScore>(builder.EndTable());
		}

		// Token: 0x0601796A RID: 96618 RVA: 0x00366E44 File Offset: 0x00365044
		public IQuestMonsterHealthScoreT UnPack()
		{
			IQuestMonsterHealthScoreT questMonsterHealthScoreT = new IQuestMonsterHealthScoreT();
			this.UnPackTo(questMonsterHealthScoreT);
			return questMonsterHealthScoreT;
		}

		// Token: 0x0601796B RID: 96619 RVA: 0x00366E60 File Offset: 0x00365060
		public void UnPackTo(IQuestMonsterHealthScoreT _o)
		{
			_o.Type = this.Type;
			_o.Var = new TVarRefUnion();
			_o.Var.Type = this.VarType;
			switch (this.VarType)
			{
			case TVarRef.IConstVarRef:
				_o.Var.Value = ((this.Var<IConstVarRef>() != null) ? this.Var<IConstVarRef>().Value.UnPack() : null);
				break;
			case TVarRef.IGlobalVarRef:
				_o.Var.Value = ((this.Var<IGlobalVarRef>() != null) ? this.Var<IGlobalVarRef>().Value.UnPack() : null);
				break;
			case TVarRef.IOtherVarRef:
				_o.Var.Value = ((this.Var<IOtherVarRef>() != null) ? this.Var<IOtherVarRef>().Value.UnPack() : null);
				break;
			case TVarRef.ISelfVarRef:
				_o.Var.Value = ((this.Var<ISelfVarRef>() != null) ? this.Var<ISelfVarRef>().Value.UnPack() : null);
				break;
			case TVarRef.ISystemVarRef:
				_o.Var.Value = ((this.Var<ISystemVarRef>() != null) ? this.Var<ISystemVarRef>().Value.UnPack() : null);
				break;
			}
			_o.TypeConfigs = new List<IMonsterHpPointTypeConfigT>();
			for (int i = 0; i < this.TypeConfigsLength; i++)
			{
				_o.TypeConfigs.Add((this.TypeConfigs(i) != null) ? this.TypeConfigs(i).Value.UnPack() : null);
			}
			_o.EntityConfigs = new List<IMonsterHpPointEntityConfigT>();
			for (int j = 0; j < this.EntityConfigsLength; j++)
			{
				_o.EntityConfigs.Add((this.EntityConfigs(j) != null) ? this.EntityConfigs(j).Value.UnPack() : null);
			}
			_o.IsStatisticsRecoveredHp = this.IsStatisticsRecoveredHp;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601796C RID: 96620 RVA: 0x003670A8 File Offset: 0x003652A8
		public static Offset<IQuestMonsterHealthScore> Pack(FlatBufferBuilder builder, IQuestMonsterHealthScoreT _o)
		{
			if (_o == null)
			{
				return default(Offset<IQuestMonsterHealthScore>);
			}
			TVarRef var_type = (_o.Var == null) ? TVarRef.NONE : _o.Var.Type;
			int varOffset = (_o.Var == null) ? 0 : TVarRefUnion.Pack(builder, _o.Var);
			VectorOffset typeConfigsOffset = default(VectorOffset);
			if (_o.TypeConfigs != null)
			{
				Offset<IMonsterHpPointTypeConfig>[] array = new Offset<IMonsterHpPointTypeConfig>[_o.TypeConfigs.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IMonsterHpPointTypeConfig.Pack(builder, _o.TypeConfigs[i]);
				}
				typeConfigsOffset = IQuestMonsterHealthScore.CreateTypeConfigsVector(builder, array);
			}
			VectorOffset entityConfigsOffset = default(VectorOffset);
			if (_o.EntityConfigs != null)
			{
				Offset<IMonsterHpPointEntityConfig>[] array2 = new Offset<IMonsterHpPointEntityConfig>[_o.EntityConfigs.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = IMonsterHpPointEntityConfig.Pack(builder, _o.EntityConfigs[j]);
				}
				entityConfigsOffset = IQuestMonsterHealthScore.CreateEntityConfigsVector(builder, array2);
			}
			return IQuestMonsterHealthScore.CreateIQuestMonsterHealthScore(builder, _o.Type, var_type, varOffset, typeConfigsOffset, entityConfigsOffset, _o.IsStatisticsRecoveredHp, _o.NullMask);
		}

		// Token: 0x0400BAF6 RID: 47862
		private Table __p;
	}
}
