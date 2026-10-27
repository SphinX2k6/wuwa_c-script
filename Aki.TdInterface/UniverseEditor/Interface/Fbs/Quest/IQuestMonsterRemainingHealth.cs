using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003FF8 RID: 16376
	public struct IQuestMonsterRemainingHealth : IFlatbufferObject
	{
		// Token: 0x1700730C RID: 29452
		// (get) Token: 0x060179D0 RID: 96720 RVA: 0x00368203 File Offset: 0x00366403
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060179D1 RID: 96721 RVA: 0x00368210 File Offset: 0x00366410
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060179D2 RID: 96722 RVA: 0x00368218 File Offset: 0x00366418
		public static IQuestMonsterRemainingHealth GetRootAsIQuestMonsterRemainingHealth(ByteBuffer _bb)
		{
			return IQuestMonsterRemainingHealth.GetRootAsIQuestMonsterRemainingHealth(_bb, default(IQuestMonsterRemainingHealth));
		}

		// Token: 0x060179D3 RID: 96723 RVA: 0x00368234 File Offset: 0x00366434
		public static IQuestMonsterRemainingHealth GetRootAsIQuestMonsterRemainingHealth(ByteBuffer _bb, IQuestMonsterRemainingHealth obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060179D4 RID: 96724 RVA: 0x00368251 File Offset: 0x00366451
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060179D5 RID: 96725 RVA: 0x00368260 File Offset: 0x00366460
		public IQuestMonsterRemainingHealth __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700730D RID: 29453
		// (get) Token: 0x060179D6 RID: 96726 RVA: 0x00368270 File Offset: 0x00366470
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

		// Token: 0x1700730E RID: 29454
		// (get) Token: 0x060179D7 RID: 96727 RVA: 0x003682AC File Offset: 0x003664AC
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

		// Token: 0x060179D8 RID: 96728 RVA: 0x003682E8 File Offset: 0x003664E8
		public TTable? Var<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060179D9 RID: 96729 RVA: 0x0036832C File Offset: 0x0036652C
		public IConstVarRef VarAsIConstVarRef()
		{
			return this.Var<IConstVarRef>().Value;
		}

		// Token: 0x060179DA RID: 96730 RVA: 0x00368348 File Offset: 0x00366548
		public IGlobalVarRef VarAsIGlobalVarRef()
		{
			return this.Var<IGlobalVarRef>().Value;
		}

		// Token: 0x060179DB RID: 96731 RVA: 0x00368364 File Offset: 0x00366564
		public IOtherVarRef VarAsIOtherVarRef()
		{
			return this.Var<IOtherVarRef>().Value;
		}

		// Token: 0x060179DC RID: 96732 RVA: 0x00368380 File Offset: 0x00366580
		public ISelfVarRef VarAsISelfVarRef()
		{
			return this.Var<ISelfVarRef>().Value;
		}

		// Token: 0x060179DD RID: 96733 RVA: 0x0036839C File Offset: 0x0036659C
		public ISystemVarRef VarAsISystemVarRef()
		{
			return this.Var<ISystemVarRef>().Value;
		}

		// Token: 0x1700730F RID: 29455
		// (get) Token: 0x060179DE RID: 96734 RVA: 0x003683B8 File Offset: 0x003665B8
		public int EntityId
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007310 RID: 29456
		// (get) Token: 0x060179DF RID: 96735 RVA: 0x003683F8 File Offset: 0x003665F8
		public bool IsStatisticsAdd
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x060179E0 RID: 96736 RVA: 0x00368438 File Offset: 0x00366638
		public static Offset<IQuestMonsterRemainingHealth> CreateIQuestMonsterRemainingHealth(FlatBufferBuilder builder, EStatisticsEventType Type = EStatisticsEventType.Collect, TVarRef Var_type = TVarRef.NONE, int VarOffset = 0, int EntityId = 0, bool IsStatisticsAdd = false)
		{
			builder.StartTable(5);
			IQuestMonsterRemainingHealth.AddEntityId(builder, EntityId);
			IQuestMonsterRemainingHealth.AddVar(builder, VarOffset);
			IQuestMonsterRemainingHealth.AddIsStatisticsAdd(builder, IsStatisticsAdd);
			IQuestMonsterRemainingHealth.AddVarType(builder, Var_type);
			IQuestMonsterRemainingHealth.AddType(builder, Type);
			return IQuestMonsterRemainingHealth.EndIQuestMonsterRemainingHealth(builder);
		}

		// Token: 0x060179E1 RID: 96737 RVA: 0x0036846C File Offset: 0x0036666C
		public static void StartIQuestMonsterRemainingHealth(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x060179E2 RID: 96738 RVA: 0x00368475 File Offset: 0x00366675
		public static void AddType(FlatBufferBuilder builder, EStatisticsEventType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060179E3 RID: 96739 RVA: 0x00368480 File Offset: 0x00366680
		public static void AddVarType(FlatBufferBuilder builder, TVarRef varType)
		{
			builder.AddByte(1, (byte)varType, 0);
		}

		// Token: 0x060179E4 RID: 96740 RVA: 0x0036848B File Offset: 0x0036668B
		public static void AddVar(FlatBufferBuilder builder, int varOffset)
		{
			builder.AddOffset(2, varOffset, 0);
		}

		// Token: 0x060179E5 RID: 96741 RVA: 0x00368496 File Offset: 0x00366696
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(3, entityId, 0);
		}

		// Token: 0x060179E6 RID: 96742 RVA: 0x003684A1 File Offset: 0x003666A1
		public static void AddIsStatisticsAdd(FlatBufferBuilder builder, bool isStatisticsAdd)
		{
			builder.AddBool(4, isStatisticsAdd, false);
		}

		// Token: 0x060179E7 RID: 96743 RVA: 0x003684AC File Offset: 0x003666AC
		public static Offset<IQuestMonsterRemainingHealth> EndIQuestMonsterRemainingHealth(FlatBufferBuilder builder)
		{
			return new Offset<IQuestMonsterRemainingHealth>(builder.EndTable());
		}

		// Token: 0x060179E8 RID: 96744 RVA: 0x003684BC File Offset: 0x003666BC
		public IQuestMonsterRemainingHealthT UnPack()
		{
			IQuestMonsterRemainingHealthT questMonsterRemainingHealthT = new IQuestMonsterRemainingHealthT();
			this.UnPackTo(questMonsterRemainingHealthT);
			return questMonsterRemainingHealthT;
		}

		// Token: 0x060179E9 RID: 96745 RVA: 0x003684D8 File Offset: 0x003666D8
		public void UnPackTo(IQuestMonsterRemainingHealthT _o)
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
			_o.EntityId = this.EntityId;
			_o.IsStatisticsAdd = this.IsStatisticsAdd;
		}

		// Token: 0x060179EA RID: 96746 RVA: 0x0036866C File Offset: 0x0036686C
		public static Offset<IQuestMonsterRemainingHealth> Pack(FlatBufferBuilder builder, IQuestMonsterRemainingHealthT _o)
		{
			if (_o == null)
			{
				return default(Offset<IQuestMonsterRemainingHealth>);
			}
			TVarRef var_type = (_o.Var == null) ? TVarRef.NONE : _o.Var.Type;
			int varOffset = (_o.Var == null) ? 0 : TVarRefUnion.Pack(builder, _o.Var);
			return IQuestMonsterRemainingHealth.CreateIQuestMonsterRemainingHealth(builder, _o.Type, var_type, varOffset, _o.EntityId, _o.IsStatisticsAdd);
		}

		// Token: 0x0400BB09 RID: 47881
		private Table __p;
	}
}
