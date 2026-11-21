using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004433 RID: 17459
	public struct IQuestMonsterHealthScore : IFlatbufferObject
	{
		// Token: 0x170078EA RID: 30954
		// (get) Token: 0x06018FDB RID: 102363 RVA: 0x003906EA File Offset: 0x0038E8EA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06018FDC RID: 102364 RVA: 0x003906F7 File Offset: 0x0038E8F7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06018FDD RID: 102365 RVA: 0x00390700 File Offset: 0x0038E900
		public static IQuestMonsterHealthScore GetRootAsIQuestMonsterHealthScore(ByteBuffer _bb)
		{
			return IQuestMonsterHealthScore.GetRootAsIQuestMonsterHealthScore(_bb, default(IQuestMonsterHealthScore));
		}

		// Token: 0x06018FDE RID: 102366 RVA: 0x0039071C File Offset: 0x0038E91C
		public static IQuestMonsterHealthScore GetRootAsIQuestMonsterHealthScore(ByteBuffer _bb, IQuestMonsterHealthScore obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06018FDF RID: 102367 RVA: 0x00390739 File Offset: 0x0038E939
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06018FE0 RID: 102368 RVA: 0x00390748 File Offset: 0x0038E948
		public IQuestMonsterHealthScore __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170078EB RID: 30955
		// (get) Token: 0x06018FE1 RID: 102369 RVA: 0x00390758 File Offset: 0x0038E958
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

		// Token: 0x170078EC RID: 30956
		// (get) Token: 0x06018FE2 RID: 102370 RVA: 0x00390794 File Offset: 0x0038E994
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

		// Token: 0x06018FE3 RID: 102371 RVA: 0x003907D0 File Offset: 0x0038E9D0
		public TTable? Var<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06018FE4 RID: 102372 RVA: 0x00390814 File Offset: 0x0038EA14
		public IConstVarRef VarAsIConstVarRef()
		{
			return this.Var<IConstVarRef>().Value;
		}

		// Token: 0x06018FE5 RID: 102373 RVA: 0x00390830 File Offset: 0x0038EA30
		public IGlobalVarRef VarAsIGlobalVarRef()
		{
			return this.Var<IGlobalVarRef>().Value;
		}

		// Token: 0x06018FE6 RID: 102374 RVA: 0x0039084C File Offset: 0x0038EA4C
		public IOtherVarRef VarAsIOtherVarRef()
		{
			return this.Var<IOtherVarRef>().Value;
		}

		// Token: 0x06018FE7 RID: 102375 RVA: 0x00390868 File Offset: 0x0038EA68
		public ISelfVarRef VarAsISelfVarRef()
		{
			return this.Var<ISelfVarRef>().Value;
		}

		// Token: 0x06018FE8 RID: 102376 RVA: 0x00390884 File Offset: 0x0038EA84
		public ISystemVarRef VarAsISystemVarRef()
		{
			return this.Var<ISystemVarRef>().Value;
		}

		// Token: 0x06018FE9 RID: 102377 RVA: 0x003908A0 File Offset: 0x0038EAA0
		public IMonsterHpPointTypeConfig? TypeConfigs(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new IMonsterHpPointTypeConfig?(default(IMonsterHpPointTypeConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170078ED RID: 30957
		// (get) Token: 0x06018FEA RID: 102378 RVA: 0x00390904 File Offset: 0x0038EB04
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

		// Token: 0x06018FEB RID: 102379 RVA: 0x00390930 File Offset: 0x0038EB30
		public IMonsterHpPointEntityConfig? EntityConfigs(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new IMonsterHpPointEntityConfig?(default(IMonsterHpPointEntityConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170078EE RID: 30958
		// (get) Token: 0x06018FEC RID: 102380 RVA: 0x00390994 File Offset: 0x0038EB94
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

		// Token: 0x170078EF RID: 30959
		// (get) Token: 0x06018FED RID: 102381 RVA: 0x003909C0 File Offset: 0x0038EBC0
		public bool IsStatisticsRecoveredHp
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170078F0 RID: 30960
		// (get) Token: 0x06018FEE RID: 102382 RVA: 0x00390A00 File Offset: 0x0038EC00
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

		// Token: 0x06018FEF RID: 102383 RVA: 0x00390A40 File Offset: 0x0038EC40
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

		// Token: 0x06018FF0 RID: 102384 RVA: 0x00390A8F File Offset: 0x0038EC8F
		public static void StartIQuestMonsterHealthScore(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x06018FF1 RID: 102385 RVA: 0x00390A98 File Offset: 0x0038EC98
		public static void AddType(FlatBufferBuilder builder, EStatisticsEventType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06018FF2 RID: 102386 RVA: 0x00390AA3 File Offset: 0x0038ECA3
		public static void AddVarType(FlatBufferBuilder builder, TVarRef varType)
		{
			builder.AddByte(1, (byte)varType, 0);
		}

		// Token: 0x06018FF3 RID: 102387 RVA: 0x00390AAE File Offset: 0x0038ECAE
		public static void AddVar(FlatBufferBuilder builder, int varOffset)
		{
			builder.AddOffset(2, varOffset, 0);
		}

		// Token: 0x06018FF4 RID: 102388 RVA: 0x00390AB9 File Offset: 0x0038ECB9
		public static void AddTypeConfigs(FlatBufferBuilder builder, VectorOffset typeConfigsOffset)
		{
			builder.AddOffset(3, typeConfigsOffset.Value, 0);
		}

		// Token: 0x06018FF5 RID: 102389 RVA: 0x00390ACC File Offset: 0x0038ECCC
		public static VectorOffset CreateTypeConfigsVector(FlatBufferBuilder builder, Offset<IMonsterHpPointTypeConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06018FF6 RID: 102390 RVA: 0x00390B0C File Offset: 0x0038ED0C
		public static VectorOffset CreateTypeConfigsVectorBlock(FlatBufferBuilder builder, Offset<IMonsterHpPointTypeConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IMonsterHpPointTypeConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06018FF7 RID: 102391 RVA: 0x00390B26 File Offset: 0x0038ED26
		public static VectorOffset CreateTypeConfigsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IMonsterHpPointTypeConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IMonsterHpPointTypeConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06018FF8 RID: 102392 RVA: 0x00390B44 File Offset: 0x0038ED44
		public static VectorOffset CreateTypeConfigsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IMonsterHpPointTypeConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06018FF9 RID: 102393 RVA: 0x00390B5D File Offset: 0x0038ED5D
		public static void StartTypeConfigsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06018FFA RID: 102394 RVA: 0x00390B68 File Offset: 0x0038ED68
		public static void AddEntityConfigs(FlatBufferBuilder builder, VectorOffset entityConfigsOffset)
		{
			builder.AddOffset(4, entityConfigsOffset.Value, 0);
		}

		// Token: 0x06018FFB RID: 102395 RVA: 0x00390B78 File Offset: 0x0038ED78
		public static VectorOffset CreateEntityConfigsVector(FlatBufferBuilder builder, Offset<IMonsterHpPointEntityConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06018FFC RID: 102396 RVA: 0x00390BB8 File Offset: 0x0038EDB8
		public static VectorOffset CreateEntityConfigsVectorBlock(FlatBufferBuilder builder, Offset<IMonsterHpPointEntityConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IMonsterHpPointEntityConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06018FFD RID: 102397 RVA: 0x00390BD2 File Offset: 0x0038EDD2
		public static VectorOffset CreateEntityConfigsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IMonsterHpPointEntityConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IMonsterHpPointEntityConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06018FFE RID: 102398 RVA: 0x00390BF0 File Offset: 0x0038EDF0
		public static VectorOffset CreateEntityConfigsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IMonsterHpPointEntityConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06018FFF RID: 102399 RVA: 0x00390C09 File Offset: 0x0038EE09
		public static void StartEntityConfigsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06019000 RID: 102400 RVA: 0x00390C14 File Offset: 0x0038EE14
		public static void AddIsStatisticsRecoveredHp(FlatBufferBuilder builder, bool isStatisticsRecoveredHp)
		{
			builder.AddBool(5, isStatisticsRecoveredHp, false);
		}

		// Token: 0x06019001 RID: 102401 RVA: 0x00390C1F File Offset: 0x0038EE1F
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x06019002 RID: 102402 RVA: 0x00390C2A File Offset: 0x0038EE2A
		public static Offset<IQuestMonsterHealthScore> EndIQuestMonsterHealthScore(FlatBufferBuilder builder)
		{
			return new Offset<IQuestMonsterHealthScore>(builder.EndTable());
		}

		// Token: 0x06019003 RID: 102403 RVA: 0x00390C38 File Offset: 0x0038EE38
		public IQuestMonsterHealthScoreT UnPack()
		{
			IQuestMonsterHealthScoreT questMonsterHealthScoreT = new IQuestMonsterHealthScoreT();
			this.UnPackTo(questMonsterHealthScoreT);
			return questMonsterHealthScoreT;
		}

		// Token: 0x06019004 RID: 102404 RVA: 0x00390C54 File Offset: 0x0038EE54
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

		// Token: 0x06019005 RID: 102405 RVA: 0x00390E9C File Offset: 0x0038F09C
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

		// Token: 0x0400C4DD RID: 50397
		private Table __p;
	}
}
