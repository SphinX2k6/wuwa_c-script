using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004439 RID: 17465
	public struct IQuestMonsterRemainingHealth : IFlatbufferObject
	{
		// Token: 0x1700790E RID: 30990
		// (get) Token: 0x06019069 RID: 102505 RVA: 0x00391FF7 File Offset: 0x003901F7
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601906A RID: 102506 RVA: 0x00392004 File Offset: 0x00390204
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601906B RID: 102507 RVA: 0x0039200C File Offset: 0x0039020C
		public static IQuestMonsterRemainingHealth GetRootAsIQuestMonsterRemainingHealth(ByteBuffer _bb)
		{
			return IQuestMonsterRemainingHealth.GetRootAsIQuestMonsterRemainingHealth(_bb, default(IQuestMonsterRemainingHealth));
		}

		// Token: 0x0601906C RID: 102508 RVA: 0x00392028 File Offset: 0x00390228
		public static IQuestMonsterRemainingHealth GetRootAsIQuestMonsterRemainingHealth(ByteBuffer _bb, IQuestMonsterRemainingHealth obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601906D RID: 102509 RVA: 0x00392045 File Offset: 0x00390245
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601906E RID: 102510 RVA: 0x00392054 File Offset: 0x00390254
		public IQuestMonsterRemainingHealth __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700790F RID: 30991
		// (get) Token: 0x0601906F RID: 102511 RVA: 0x00392064 File Offset: 0x00390264
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

		// Token: 0x17007910 RID: 30992
		// (get) Token: 0x06019070 RID: 102512 RVA: 0x003920A0 File Offset: 0x003902A0
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

		// Token: 0x06019071 RID: 102513 RVA: 0x003920DC File Offset: 0x003902DC
		public TTable? Var<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06019072 RID: 102514 RVA: 0x00392120 File Offset: 0x00390320
		public IConstVarRef VarAsIConstVarRef()
		{
			return this.Var<IConstVarRef>().Value;
		}

		// Token: 0x06019073 RID: 102515 RVA: 0x0039213C File Offset: 0x0039033C
		public IGlobalVarRef VarAsIGlobalVarRef()
		{
			return this.Var<IGlobalVarRef>().Value;
		}

		// Token: 0x06019074 RID: 102516 RVA: 0x00392158 File Offset: 0x00390358
		public IOtherVarRef VarAsIOtherVarRef()
		{
			return this.Var<IOtherVarRef>().Value;
		}

		// Token: 0x06019075 RID: 102517 RVA: 0x00392174 File Offset: 0x00390374
		public ISelfVarRef VarAsISelfVarRef()
		{
			return this.Var<ISelfVarRef>().Value;
		}

		// Token: 0x06019076 RID: 102518 RVA: 0x00392190 File Offset: 0x00390390
		public ISystemVarRef VarAsISystemVarRef()
		{
			return this.Var<ISystemVarRef>().Value;
		}

		// Token: 0x17007911 RID: 30993
		// (get) Token: 0x06019077 RID: 102519 RVA: 0x003921AC File Offset: 0x003903AC
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

		// Token: 0x17007912 RID: 30994
		// (get) Token: 0x06019078 RID: 102520 RVA: 0x003921EC File Offset: 0x003903EC
		public bool IsStatisticsAdd
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06019079 RID: 102521 RVA: 0x0039222C File Offset: 0x0039042C
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

		// Token: 0x0601907A RID: 102522 RVA: 0x00392260 File Offset: 0x00390460
		public static void StartIQuestMonsterRemainingHealth(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0601907B RID: 102523 RVA: 0x00392269 File Offset: 0x00390469
		public static void AddType(FlatBufferBuilder builder, EStatisticsEventType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601907C RID: 102524 RVA: 0x00392274 File Offset: 0x00390474
		public static void AddVarType(FlatBufferBuilder builder, TVarRef varType)
		{
			builder.AddByte(1, (byte)varType, 0);
		}

		// Token: 0x0601907D RID: 102525 RVA: 0x0039227F File Offset: 0x0039047F
		public static void AddVar(FlatBufferBuilder builder, int varOffset)
		{
			builder.AddOffset(2, varOffset, 0);
		}

		// Token: 0x0601907E RID: 102526 RVA: 0x0039228A File Offset: 0x0039048A
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(3, entityId, 0);
		}

		// Token: 0x0601907F RID: 102527 RVA: 0x00392295 File Offset: 0x00390495
		public static void AddIsStatisticsAdd(FlatBufferBuilder builder, bool isStatisticsAdd)
		{
			builder.AddBool(4, isStatisticsAdd, false);
		}

		// Token: 0x06019080 RID: 102528 RVA: 0x003922A0 File Offset: 0x003904A0
		public static Offset<IQuestMonsterRemainingHealth> EndIQuestMonsterRemainingHealth(FlatBufferBuilder builder)
		{
			return new Offset<IQuestMonsterRemainingHealth>(builder.EndTable());
		}

		// Token: 0x06019081 RID: 102529 RVA: 0x003922B0 File Offset: 0x003904B0
		public IQuestMonsterRemainingHealthT UnPack()
		{
			IQuestMonsterRemainingHealthT questMonsterRemainingHealthT = new IQuestMonsterRemainingHealthT();
			this.UnPackTo(questMonsterRemainingHealthT);
			return questMonsterRemainingHealthT;
		}

		// Token: 0x06019082 RID: 102530 RVA: 0x003922CC File Offset: 0x003904CC
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

		// Token: 0x06019083 RID: 102531 RVA: 0x00392460 File Offset: 0x00390660
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

		// Token: 0x0400C4F0 RID: 50416
		private Table __p;
	}
}
