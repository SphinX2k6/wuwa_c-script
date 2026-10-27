using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004052 RID: 16466
	public struct IQuestStatisticsPlayerTriggerMotion : IFlatbufferObject
	{
		// Token: 0x170073EE RID: 29678
		// (get) Token: 0x06017DCE RID: 97742 RVA: 0x003718A8 File Offset: 0x0036FAA8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06017DCF RID: 97743 RVA: 0x003718B5 File Offset: 0x0036FAB5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06017DD0 RID: 97744 RVA: 0x003718BC File Offset: 0x0036FABC
		public static IQuestStatisticsPlayerTriggerMotion GetRootAsIQuestStatisticsPlayerTriggerMotion(ByteBuffer _bb)
		{
			return IQuestStatisticsPlayerTriggerMotion.GetRootAsIQuestStatisticsPlayerTriggerMotion(_bb, default(IQuestStatisticsPlayerTriggerMotion));
		}

		// Token: 0x06017DD1 RID: 97745 RVA: 0x003718D8 File Offset: 0x0036FAD8
		public static IQuestStatisticsPlayerTriggerMotion GetRootAsIQuestStatisticsPlayerTriggerMotion(ByteBuffer _bb, IQuestStatisticsPlayerTriggerMotion obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06017DD2 RID: 97746 RVA: 0x003718F5 File Offset: 0x0036FAF5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06017DD3 RID: 97747 RVA: 0x00371904 File Offset: 0x0036FB04
		public IQuestStatisticsPlayerTriggerMotion __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170073EF RID: 29679
		// (get) Token: 0x06017DD4 RID: 97748 RVA: 0x00371914 File Offset: 0x0036FB14
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

		// Token: 0x170073F0 RID: 29680
		// (get) Token: 0x06017DD5 RID: 97749 RVA: 0x00371950 File Offset: 0x0036FB50
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

		// Token: 0x06017DD6 RID: 97750 RVA: 0x0037198C File Offset: 0x0036FB8C
		public TTable? Var<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06017DD7 RID: 97751 RVA: 0x003719D0 File Offset: 0x0036FBD0
		public IConstVarRef VarAsIConstVarRef()
		{
			return this.Var<IConstVarRef>().Value;
		}

		// Token: 0x06017DD8 RID: 97752 RVA: 0x003719EC File Offset: 0x0036FBEC
		public IGlobalVarRef VarAsIGlobalVarRef()
		{
			return this.Var<IGlobalVarRef>().Value;
		}

		// Token: 0x06017DD9 RID: 97753 RVA: 0x00371A08 File Offset: 0x0036FC08
		public IOtherVarRef VarAsIOtherVarRef()
		{
			return this.Var<IOtherVarRef>().Value;
		}

		// Token: 0x06017DDA RID: 97754 RVA: 0x00371A24 File Offset: 0x0036FC24
		public ISelfVarRef VarAsISelfVarRef()
		{
			return this.Var<ISelfVarRef>().Value;
		}

		// Token: 0x06017DDB RID: 97755 RVA: 0x00371A40 File Offset: 0x0036FC40
		public ISystemVarRef VarAsISystemVarRef()
		{
			return this.Var<ISystemVarRef>().Value;
		}

		// Token: 0x170073F1 RID: 29681
		// (get) Token: 0x06017DDC RID: 97756 RVA: 0x00371A5C File Offset: 0x0036FC5C
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

		// Token: 0x06017DDD RID: 97757 RVA: 0x00371A99 File Offset: 0x0036FC99
		public static Offset<IQuestStatisticsPlayerTriggerMotion> CreateIQuestStatisticsPlayerTriggerMotion(FlatBufferBuilder builder, EStatisticsEventType Type = EStatisticsEventType.Collect, TVarRef Var_type = TVarRef.NONE, int VarOffset = 0, EPlayerTriggerMotion MotionType = EPlayerTriggerMotion.GroundSprint)
		{
			builder.StartTable(4);
			IQuestStatisticsPlayerTriggerMotion.AddVar(builder, VarOffset);
			IQuestStatisticsPlayerTriggerMotion.AddMotionType(builder, MotionType);
			IQuestStatisticsPlayerTriggerMotion.AddVarType(builder, Var_type);
			IQuestStatisticsPlayerTriggerMotion.AddType(builder, Type);
			return IQuestStatisticsPlayerTriggerMotion.EndIQuestStatisticsPlayerTriggerMotion(builder);
		}

		// Token: 0x06017DDE RID: 97758 RVA: 0x00371AC5 File Offset: 0x0036FCC5
		public static void StartIQuestStatisticsPlayerTriggerMotion(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06017DDF RID: 97759 RVA: 0x00371ACE File Offset: 0x0036FCCE
		public static void AddType(FlatBufferBuilder builder, EStatisticsEventType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06017DE0 RID: 97760 RVA: 0x00371AD9 File Offset: 0x0036FCD9
		public static void AddVarType(FlatBufferBuilder builder, TVarRef varType)
		{
			builder.AddByte(1, (byte)varType, 0);
		}

		// Token: 0x06017DE1 RID: 97761 RVA: 0x00371AE4 File Offset: 0x0036FCE4
		public static void AddVar(FlatBufferBuilder builder, int varOffset)
		{
			builder.AddOffset(2, varOffset, 0);
		}

		// Token: 0x06017DE2 RID: 97762 RVA: 0x00371AEF File Offset: 0x0036FCEF
		public static void AddMotionType(FlatBufferBuilder builder, EPlayerTriggerMotion motionType)
		{
			builder.AddByte(3, (byte)motionType, 0);
		}

		// Token: 0x06017DE3 RID: 97763 RVA: 0x00371AFA File Offset: 0x0036FCFA
		public static Offset<IQuestStatisticsPlayerTriggerMotion> EndIQuestStatisticsPlayerTriggerMotion(FlatBufferBuilder builder)
		{
			return new Offset<IQuestStatisticsPlayerTriggerMotion>(builder.EndTable());
		}

		// Token: 0x06017DE4 RID: 97764 RVA: 0x00371B08 File Offset: 0x0036FD08
		public IQuestStatisticsPlayerTriggerMotionT UnPack()
		{
			IQuestStatisticsPlayerTriggerMotionT questStatisticsPlayerTriggerMotionT = new IQuestStatisticsPlayerTriggerMotionT();
			this.UnPackTo(questStatisticsPlayerTriggerMotionT);
			return questStatisticsPlayerTriggerMotionT;
		}

		// Token: 0x06017DE5 RID: 97765 RVA: 0x00371B24 File Offset: 0x0036FD24
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

		// Token: 0x06017DE6 RID: 97766 RVA: 0x00371CAC File Offset: 0x0036FEAC
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

		// Token: 0x0400BB9D RID: 48029
		private Table __p;
	}
}
