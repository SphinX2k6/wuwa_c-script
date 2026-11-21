using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004436 RID: 17462
	public struct IQuestMonsterPoint : IFlatbufferObject
	{
		// Token: 0x170078F7 RID: 30967
		// (get) Token: 0x06019014 RID: 102420 RVA: 0x0039112B File Offset: 0x0038F32B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06019015 RID: 102421 RVA: 0x00391138 File Offset: 0x0038F338
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06019016 RID: 102422 RVA: 0x00391140 File Offset: 0x0038F340
		public static IQuestMonsterPoint GetRootAsIQuestMonsterPoint(ByteBuffer _bb)
		{
			return IQuestMonsterPoint.GetRootAsIQuestMonsterPoint(_bb, default(IQuestMonsterPoint));
		}

		// Token: 0x06019017 RID: 102423 RVA: 0x0039115C File Offset: 0x0038F35C
		public static IQuestMonsterPoint GetRootAsIQuestMonsterPoint(ByteBuffer _bb, IQuestMonsterPoint obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06019018 RID: 102424 RVA: 0x00391179 File Offset: 0x0038F379
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06019019 RID: 102425 RVA: 0x00391188 File Offset: 0x0038F388
		public IQuestMonsterPoint __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170078F8 RID: 30968
		// (get) Token: 0x0601901A RID: 102426 RVA: 0x00391198 File Offset: 0x0038F398
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

		// Token: 0x170078F9 RID: 30969
		// (get) Token: 0x0601901B RID: 102427 RVA: 0x003911D4 File Offset: 0x0038F3D4
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

		// Token: 0x0601901C RID: 102428 RVA: 0x00391210 File Offset: 0x0038F410
		public TTable? Var<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601901D RID: 102429 RVA: 0x00391254 File Offset: 0x0038F454
		public IConstVarRef VarAsIConstVarRef()
		{
			return this.Var<IConstVarRef>().Value;
		}

		// Token: 0x0601901E RID: 102430 RVA: 0x00391270 File Offset: 0x0038F470
		public IGlobalVarRef VarAsIGlobalVarRef()
		{
			return this.Var<IGlobalVarRef>().Value;
		}

		// Token: 0x0601901F RID: 102431 RVA: 0x0039128C File Offset: 0x0038F48C
		public IOtherVarRef VarAsIOtherVarRef()
		{
			return this.Var<IOtherVarRef>().Value;
		}

		// Token: 0x06019020 RID: 102432 RVA: 0x003912A8 File Offset: 0x0038F4A8
		public ISelfVarRef VarAsISelfVarRef()
		{
			return this.Var<ISelfVarRef>().Value;
		}

		// Token: 0x06019021 RID: 102433 RVA: 0x003912C4 File Offset: 0x0038F4C4
		public ISystemVarRef VarAsISystemVarRef()
		{
			return this.Var<ISystemVarRef>().Value;
		}

		// Token: 0x170078FA RID: 30970
		// (get) Token: 0x06019022 RID: 102434 RVA: 0x003912E0 File Offset: 0x0038F4E0
		public EElementCategory DamageElementType
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return EElementCategory.Element0;
				}
				return (EElementCategory)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170078FB RID: 30971
		// (get) Token: 0x06019023 RID: 102435 RVA: 0x00391320 File Offset: 0x0038F520
		public ESkillCategory SkillCategory
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return ESkillCategory.Normal;
				}
				return (ESkillCategory)this.__p.bb.GetSbyte(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06019024 RID: 102436 RVA: 0x00391360 File Offset: 0x0038F560
		public int KillByEntities(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170078FC RID: 30972
		// (get) Token: 0x06019025 RID: 102437 RVA: 0x003913A0 File Offset: 0x0038F5A0
		public int KillByEntitiesLength
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

		// Token: 0x06019026 RID: 102438 RVA: 0x003913CC File Offset: 0x0038F5CC
		public Span<int> GetKillByEntitiesBytes()
		{
			return this.__p.__vector_as_span<int>(14, 4);
		}

		// Token: 0x06019027 RID: 102439 RVA: 0x003913DC File Offset: 0x0038F5DC
		public int[] GetKillByEntitiesArray()
		{
			return this.__p.__vector_as_array<int>(14);
		}

		// Token: 0x170078FD RID: 30973
		// (get) Token: 0x06019028 RID: 102440 RVA: 0x003913EC File Offset: 0x0038F5EC
		public bool KilledByAny
		{
			get
			{
				int num = this.__p.__offset(16);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06019029 RID: 102441 RVA: 0x0039142C File Offset: 0x0038F62C
		public IMonsterPointTypeConfig? TypeConfigs(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return new IMonsterPointTypeConfig?(default(IMonsterPointTypeConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170078FE RID: 30974
		// (get) Token: 0x0601902A RID: 102442 RVA: 0x00391490 File Offset: 0x0038F690
		public int TypeConfigsLength
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0601902B RID: 102443 RVA: 0x003914BC File Offset: 0x0038F6BC
		public IMonsterPointEntityConfig? EntityConfigs(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return null;
			}
			return new IMonsterPointEntityConfig?(default(IMonsterPointEntityConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170078FF RID: 30975
		// (get) Token: 0x0601902C RID: 102444 RVA: 0x00391520 File Offset: 0x0038F720
		public int EntityConfigsLength
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17007900 RID: 30976
		// (get) Token: 0x0601902D RID: 102445 RVA: 0x0039154C File Offset: 0x0038F74C
		public bool OnlyCountThisTreeAwakeEntities
		{
			get
			{
				int num = this.__p.__offset(22);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17007901 RID: 30977
		// (get) Token: 0x0601902E RID: 102446 RVA: 0x0039158C File Offset: 0x0038F78C
		public IBindCrossSceneSyncKillMonster? BindCrossSceneSyncKillMonster
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return null;
				}
				return new IBindCrossSceneSyncKillMonster?(default(IBindCrossSceneSyncKillMonster).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17007902 RID: 30978
		// (get) Token: 0x0601902F RID: 102447 RVA: 0x003915EC File Offset: 0x0038F7EC
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06019030 RID: 102448 RVA: 0x0039162C File Offset: 0x0038F82C
		public static Offset<IQuestMonsterPoint> CreateIQuestMonsterPoint(FlatBufferBuilder builder, EStatisticsEventType Type = EStatisticsEventType.Collect, TVarRef Var_type = TVarRef.NONE, int VarOffset = 0, EElementCategory DamageElementType = EElementCategory.Element0, ESkillCategory SkillCategory = ESkillCategory.Normal, VectorOffset KillByEntitiesOffset = default(VectorOffset), bool KilledByAny = false, VectorOffset TypeConfigsOffset = default(VectorOffset), VectorOffset EntityConfigsOffset = default(VectorOffset), bool OnlyCountThisTreeAwakeEntities = false, Offset<IBindCrossSceneSyncKillMonster> BindCrossSceneSyncKillMonsterOffset = default(Offset<IBindCrossSceneSyncKillMonster>), byte NullMask = 0)
		{
			builder.StartTable(12);
			IQuestMonsterPoint.AddBindCrossSceneSyncKillMonster(builder, BindCrossSceneSyncKillMonsterOffset);
			IQuestMonsterPoint.AddEntityConfigs(builder, EntityConfigsOffset);
			IQuestMonsterPoint.AddTypeConfigs(builder, TypeConfigsOffset);
			IQuestMonsterPoint.AddKillByEntities(builder, KillByEntitiesOffset);
			IQuestMonsterPoint.AddVar(builder, VarOffset);
			IQuestMonsterPoint.AddNullMask(builder, NullMask);
			IQuestMonsterPoint.AddOnlyCountThisTreeAwakeEntities(builder, OnlyCountThisTreeAwakeEntities);
			IQuestMonsterPoint.AddKilledByAny(builder, KilledByAny);
			IQuestMonsterPoint.AddSkillCategory(builder, SkillCategory);
			IQuestMonsterPoint.AddDamageElementType(builder, DamageElementType);
			IQuestMonsterPoint.AddVarType(builder, Var_type);
			IQuestMonsterPoint.AddType(builder, Type);
			return IQuestMonsterPoint.EndIQuestMonsterPoint(builder);
		}

		// Token: 0x06019031 RID: 102449 RVA: 0x003916A4 File Offset: 0x0038F8A4
		public static void StartIQuestMonsterPoint(FlatBufferBuilder builder)
		{
			builder.StartTable(12);
		}

		// Token: 0x06019032 RID: 102450 RVA: 0x003916AE File Offset: 0x0038F8AE
		public static void AddType(FlatBufferBuilder builder, EStatisticsEventType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06019033 RID: 102451 RVA: 0x003916B9 File Offset: 0x0038F8B9
		public static void AddVarType(FlatBufferBuilder builder, TVarRef varType)
		{
			builder.AddByte(1, (byte)varType, 0);
		}

		// Token: 0x06019034 RID: 102452 RVA: 0x003916C4 File Offset: 0x0038F8C4
		public static void AddVar(FlatBufferBuilder builder, int varOffset)
		{
			builder.AddOffset(2, varOffset, 0);
		}

		// Token: 0x06019035 RID: 102453 RVA: 0x003916CF File Offset: 0x0038F8CF
		public static void AddDamageElementType(FlatBufferBuilder builder, EElementCategory damageElementType)
		{
			builder.AddByte(3, (byte)damageElementType, 0);
		}

		// Token: 0x06019036 RID: 102454 RVA: 0x003916DA File Offset: 0x0038F8DA
		public static void AddSkillCategory(FlatBufferBuilder builder, ESkillCategory skillCategory)
		{
			builder.AddSbyte(4, (sbyte)skillCategory, 0);
		}

		// Token: 0x06019037 RID: 102455 RVA: 0x003916E5 File Offset: 0x0038F8E5
		public static void AddKillByEntities(FlatBufferBuilder builder, VectorOffset killByEntitiesOffset)
		{
			builder.AddOffset(5, killByEntitiesOffset.Value, 0);
		}

		// Token: 0x06019038 RID: 102456 RVA: 0x003916F8 File Offset: 0x0038F8F8
		public static VectorOffset CreateKillByEntitiesVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06019039 RID: 102457 RVA: 0x0039172F File Offset: 0x0038F92F
		public static VectorOffset CreateKillByEntitiesVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601903A RID: 102458 RVA: 0x00391749 File Offset: 0x0038F949
		public static VectorOffset CreateKillByEntitiesVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601903B RID: 102459 RVA: 0x00391767 File Offset: 0x0038F967
		public static VectorOffset CreateKillByEntitiesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601903C RID: 102460 RVA: 0x00391780 File Offset: 0x0038F980
		public static void StartKillByEntitiesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601903D RID: 102461 RVA: 0x0039178B File Offset: 0x0038F98B
		public static void AddKilledByAny(FlatBufferBuilder builder, bool killedByAny)
		{
			builder.AddBool(6, killedByAny, false);
		}

		// Token: 0x0601903E RID: 102462 RVA: 0x00391796 File Offset: 0x0038F996
		public static void AddTypeConfigs(FlatBufferBuilder builder, VectorOffset typeConfigsOffset)
		{
			builder.AddOffset(7, typeConfigsOffset.Value, 0);
		}

		// Token: 0x0601903F RID: 102463 RVA: 0x003917A8 File Offset: 0x0038F9A8
		public static VectorOffset CreateTypeConfigsVector(FlatBufferBuilder builder, Offset<IMonsterPointTypeConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06019040 RID: 102464 RVA: 0x003917E8 File Offset: 0x0038F9E8
		public static VectorOffset CreateTypeConfigsVectorBlock(FlatBufferBuilder builder, Offset<IMonsterPointTypeConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IMonsterPointTypeConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06019041 RID: 102465 RVA: 0x00391802 File Offset: 0x0038FA02
		public static VectorOffset CreateTypeConfigsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IMonsterPointTypeConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IMonsterPointTypeConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06019042 RID: 102466 RVA: 0x00391820 File Offset: 0x0038FA20
		public static VectorOffset CreateTypeConfigsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IMonsterPointTypeConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06019043 RID: 102467 RVA: 0x00391839 File Offset: 0x0038FA39
		public static void StartTypeConfigsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06019044 RID: 102468 RVA: 0x00391844 File Offset: 0x0038FA44
		public static void AddEntityConfigs(FlatBufferBuilder builder, VectorOffset entityConfigsOffset)
		{
			builder.AddOffset(8, entityConfigsOffset.Value, 0);
		}

		// Token: 0x06019045 RID: 102469 RVA: 0x00391854 File Offset: 0x0038FA54
		public static VectorOffset CreateEntityConfigsVector(FlatBufferBuilder builder, Offset<IMonsterPointEntityConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06019046 RID: 102470 RVA: 0x00391894 File Offset: 0x0038FA94
		public static VectorOffset CreateEntityConfigsVectorBlock(FlatBufferBuilder builder, Offset<IMonsterPointEntityConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IMonsterPointEntityConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06019047 RID: 102471 RVA: 0x003918AE File Offset: 0x0038FAAE
		public static VectorOffset CreateEntityConfigsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IMonsterPointEntityConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IMonsterPointEntityConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06019048 RID: 102472 RVA: 0x003918CC File Offset: 0x0038FACC
		public static VectorOffset CreateEntityConfigsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IMonsterPointEntityConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06019049 RID: 102473 RVA: 0x003918E5 File Offset: 0x0038FAE5
		public static void StartEntityConfigsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601904A RID: 102474 RVA: 0x003918F0 File Offset: 0x0038FAF0
		public static void AddOnlyCountThisTreeAwakeEntities(FlatBufferBuilder builder, bool onlyCountThisTreeAwakeEntities)
		{
			builder.AddBool(9, onlyCountThisTreeAwakeEntities, false);
		}

		// Token: 0x0601904B RID: 102475 RVA: 0x003918FC File Offset: 0x0038FAFC
		public static void AddBindCrossSceneSyncKillMonster(FlatBufferBuilder builder, Offset<IBindCrossSceneSyncKillMonster> bindCrossSceneSyncKillMonsterOffset)
		{
			builder.AddOffset(10, bindCrossSceneSyncKillMonsterOffset.Value, 0);
		}

		// Token: 0x0601904C RID: 102476 RVA: 0x0039190D File Offset: 0x0038FB0D
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(11, nullMask, 0);
		}

		// Token: 0x0601904D RID: 102477 RVA: 0x00391919 File Offset: 0x0038FB19
		public static Offset<IQuestMonsterPoint> EndIQuestMonsterPoint(FlatBufferBuilder builder)
		{
			return new Offset<IQuestMonsterPoint>(builder.EndTable());
		}

		// Token: 0x0601904E RID: 102478 RVA: 0x00391928 File Offset: 0x0038FB28
		public IQuestMonsterPointT UnPack()
		{
			IQuestMonsterPointT questMonsterPointT = new IQuestMonsterPointT();
			this.UnPackTo(questMonsterPointT);
			return questMonsterPointT;
		}

		// Token: 0x0601904F RID: 102479 RVA: 0x00391944 File Offset: 0x0038FB44
		public void UnPackTo(IQuestMonsterPointT _o)
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
			_o.DamageElementType = this.DamageElementType;
			_o.SkillCategory = this.SkillCategory;
			_o.KillByEntities = new List<int>();
			for (int i = 0; i < this.KillByEntitiesLength; i++)
			{
				_o.KillByEntities.Add(this.KillByEntities(i));
			}
			_o.KilledByAny = this.KilledByAny;
			_o.TypeConfigs = new List<IMonsterPointTypeConfigT>();
			for (int j = 0; j < this.TypeConfigsLength; j++)
			{
				_o.TypeConfigs.Add((this.TypeConfigs(j) != null) ? this.TypeConfigs(j).Value.UnPack() : null);
			}
			_o.EntityConfigs = new List<IMonsterPointEntityConfigT>();
			for (int k = 0; k < this.EntityConfigsLength; k++)
			{
				_o.EntityConfigs.Add((this.EntityConfigs(k) != null) ? this.EntityConfigs(k).Value.UnPack() : null);
			}
			_o.OnlyCountThisTreeAwakeEntities = this.OnlyCountThisTreeAwakeEntities;
			_o.BindCrossSceneSyncKillMonster = ((this.BindCrossSceneSyncKillMonster != null) ? this.BindCrossSceneSyncKillMonster.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06019050 RID: 102480 RVA: 0x00391C14 File Offset: 0x0038FE14
		public static Offset<IQuestMonsterPoint> Pack(FlatBufferBuilder builder, IQuestMonsterPointT _o)
		{
			if (_o == null)
			{
				return default(Offset<IQuestMonsterPoint>);
			}
			TVarRef var_type = (_o.Var == null) ? TVarRef.NONE : _o.Var.Type;
			int varOffset = (_o.Var == null) ? 0 : TVarRefUnion.Pack(builder, _o.Var);
			VectorOffset killByEntitiesOffset = default(VectorOffset);
			if (_o.KillByEntities != null)
			{
				int[] data = _o.KillByEntities.ToArray();
				killByEntitiesOffset = IQuestMonsterPoint.CreateKillByEntitiesVector(builder, data);
			}
			VectorOffset typeConfigsOffset = default(VectorOffset);
			if (_o.TypeConfigs != null)
			{
				Offset<IMonsterPointTypeConfig>[] array = new Offset<IMonsterPointTypeConfig>[_o.TypeConfigs.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IMonsterPointTypeConfig.Pack(builder, _o.TypeConfigs[i]);
				}
				typeConfigsOffset = IQuestMonsterPoint.CreateTypeConfigsVector(builder, array);
			}
			VectorOffset entityConfigsOffset = default(VectorOffset);
			if (_o.EntityConfigs != null)
			{
				Offset<IMonsterPointEntityConfig>[] array2 = new Offset<IMonsterPointEntityConfig>[_o.EntityConfigs.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = IMonsterPointEntityConfig.Pack(builder, _o.EntityConfigs[j]);
				}
				entityConfigsOffset = IQuestMonsterPoint.CreateEntityConfigsVector(builder, array2);
			}
			Offset<IBindCrossSceneSyncKillMonster> bindCrossSceneSyncKillMonsterOffset = (_o.BindCrossSceneSyncKillMonster == null) ? default(Offset<IBindCrossSceneSyncKillMonster>) : IBindCrossSceneSyncKillMonster.Pack(builder, _o.BindCrossSceneSyncKillMonster);
			return IQuestMonsterPoint.CreateIQuestMonsterPoint(builder, _o.Type, var_type, varOffset, _o.DamageElementType, _o.SkillCategory, killByEntitiesOffset, _o.KilledByAny, typeConfigsOffset, entityConfigsOffset, _o.OnlyCountThisTreeAwakeEntities, bindCrossSceneSyncKillMonsterOffset, _o.NullMask);
		}

		// Token: 0x0400C4E4 RID: 50404
		private Table __p;
	}
}
