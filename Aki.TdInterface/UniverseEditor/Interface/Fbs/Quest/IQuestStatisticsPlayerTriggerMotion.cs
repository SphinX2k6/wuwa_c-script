using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004493 RID: 17555
	public struct IQuestStatisticsPlayerTriggerMotion : IFlatbufferObject
	{
		// Token: 0x170079F0 RID: 31216
		// (get) Token: 0x06019467 RID: 103527 RVA: 0x0039B69C File Offset: 0x0039989C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06019468 RID: 103528 RVA: 0x0039B6A9 File Offset: 0x003998A9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06019469 RID: 103529 RVA: 0x0039B6B0 File Offset: 0x003998B0
		public static IQuestStatisticsPlayerTriggerMotion GetRootAsIQuestStatisticsPlayerTriggerMotion(ByteBuffer _bb)
		{
			return IQuestStatisticsPlayerTriggerMotion.GetRootAsIQuestStatisticsPlayerTriggerMotion(_bb, default(IQuestStatisticsPlayerTriggerMotion));
		}

		// Token: 0x0601946A RID: 103530 RVA: 0x0039B6CC File Offset: 0x003998CC
		public static IQuestStatisticsPlayerTriggerMotion GetRootAsIQuestStatisticsPlayerTriggerMotion(ByteBuffer _bb, IQuestStatisticsPlayerTriggerMotion obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601946B RID: 103531 RVA: 0x0039B6E9 File Offset: 0x003998E9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601946C RID: 103532 RVA: 0x0039B6F8 File Offset: 0x003998F8
		public IQuestStatisticsPlayerTriggerMotion __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170079F1 RID: 31217
		// (get) Token: 0x0601946D RID: 103533 RVA: 0x0039B708 File Offset: 0x00399908
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

		// Token: 0x170079F2 RID: 31218
		// (get) Token: 0x0601946E RID: 103534 RVA: 0x0039B744 File Offset: 0x00399944
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

		// Token: 0x0601946F RID: 103535 RVA: 0x0039B780 File Offset: 0x00399980
		public TTable? Var<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06019470 RID: 103536 RVA: 0x0039B7C4 File Offset: 0x003999C4
		public IConstVarRef VarAsIConstVarRef()
		{
			return this.Var<IConstVarRef>().Value;
		}

		// Token: 0x06019471 RID: 103537 RVA: 0x0039B7E0 File Offset: 0x003999E0
		public IGlobalVarRef VarAsIGlobalVarRef()
		{
			return this.Var<IGlobalVarRef>().Value;
		}

		// Token: 0x06019472 RID: 103538 RVA: 0x0039B7FC File Offset: 0x003999FC
		public IOtherVarRef VarAsIOtherVarRef()
		{
			return this.Var<IOtherVarRef>().Value;
		}

		// Token: 0x06019473 RID: 103539 RVA: 0x0039B818 File Offset: 0x00399A18
		public ISelfVarRef VarAsISelfVarRef()
		{
			return this.Var<ISelfVarRef>().Value;
		}

		// Token: 0x06019474 RID: 103540 RVA: 0x0039B834 File Offset: 0x00399A34
		public ISystemVarRef VarAsISystemVarRef()
		{
			return this.Var<ISystemVarRef>().Value;
		}

		// Token: 0x170079F3 RID: 31219
		// (get) Token: 0x06019475 RID: 103541 RVA: 0x0039B850 File Offset: 0x00399A50
		public EPlayerTriggerMotion MotionType
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return EPlayerTriggerMotion.GroundSprint;
				}
				return (EPlayerTriggerMotion)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06019476 RID: 103542 RVA: 0x0039B88D File Offset: 0x00399A8D
		public static Offset<IQuestStatisticsPlayerTriggerMotion> CreateIQuestStatisticsPlayerTriggerMotion(FlatBufferBuilder builder, EStatisticsEventType Type = EStatisticsEventType.Collect, TVarRef Var_type = TVarRef.NONE, int VarOffset = 0, EPlayerTriggerMotion MotionType = EPlayerTriggerMotion.GroundSprint)
		{
			builder.StartTable(4);
			IQuestStatisticsPlayerTriggerMotion.AddVar(builder, VarOffset);
			IQuestStatisticsPlayerTriggerMotion.AddMotionType(builder, MotionType);
			IQuestStatisticsPlayerTriggerMotion.AddVarType(builder, Var_type);
			IQuestStatisticsPlayerTriggerMotion.AddType(builder, Type);
			return IQuestStatisticsPlayerTriggerMotion.EndIQuestStatisticsPlayerTriggerMotion(builder);
		}

		// Token: 0x06019477 RID: 103543 RVA: 0x0039B8B9 File Offset: 0x00399AB9
		public static void StartIQuestStatisticsPlayerTriggerMotion(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06019478 RID: 103544 RVA: 0x0039B8C2 File Offset: 0x00399AC2
		public static void AddType(FlatBufferBuilder builder, EStatisticsEventType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06019479 RID: 103545 RVA: 0x0039B8CD File Offset: 0x00399ACD
		public static void AddVarType(FlatBufferBuilder builder, TVarRef varType)
		{
			builder.AddByte(1, (byte)varType, 0);
		}

		// Token: 0x0601947A RID: 103546 RVA: 0x0039B8D8 File Offset: 0x00399AD8
		public static void AddVar(FlatBufferBuilder builder, int varOffset)
		{
			builder.AddOffset(2, varOffset, 0);
		}

		// Token: 0x0601947B RID: 103547 RVA: 0x0039B8E3 File Offset: 0x00399AE3
		public static void AddMotionType(FlatBufferBuilder builder, EPlayerTriggerMotion motionType)
		{
			builder.AddByte(3, (byte)motionType, 0);
		}

		// Token: 0x0601947C RID: 103548 RVA: 0x0039B8EE File Offset: 0x00399AEE
		public static Offset<IQuestStatisticsPlayerTriggerMotion> EndIQuestStatisticsPlayerTriggerMotion(FlatBufferBuilder builder)
		{
			return new Offset<IQuestStatisticsPlayerTriggerMotion>(builder.EndTable());
		}

		// Token: 0x0601947D RID: 103549 RVA: 0x0039B8FC File Offset: 0x00399AFC
		public IQuestStatisticsPlayerTriggerMotionT UnPack()
		{
			IQuestStatisticsPlayerTriggerMotionT questStatisticsPlayerTriggerMotionT = new IQuestStatisticsPlayerTriggerMotionT();
			this.UnPackTo(questStatisticsPlayerTriggerMotionT);
			return questStatisticsPlayerTriggerMotionT;
		}

		// Token: 0x0601947E RID: 103550 RVA: 0x0039B918 File Offset: 0x00399B18
		public void UnPackTo(IQuestStatisticsPlayerTriggerMotionT _o)
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
			_o.MotionType = this.MotionType;
		}

		// Token: 0x0601947F RID: 103551 RVA: 0x0039BAA0 File Offset: 0x00399CA0
		public static Offset<IQuestStatisticsPlayerTriggerMotion> Pack(FlatBufferBuilder builder, IQuestStatisticsPlayerTriggerMotionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IQuestStatisticsPlayerTriggerMotion>);
			}
			TVarRef var_type = (_o.Var == null) ? TVarRef.NONE : _o.Var.Type;
			int varOffset = (_o.Var == null) ? 0 : TVarRefUnion.Pack(builder, _o.Var);
			return IQuestStatisticsPlayerTriggerMotion.CreateIQuestStatisticsPlayerTriggerMotion(builder, _o.Type, var_type, varOffset, _o.MotionType);
		}

		// Token: 0x0400C584 RID: 50564
		private Table __p;
	}
}
