using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004055 RID: 16469
	public struct IQuestStatisticsType : IFlatbufferObject
	{
		// Token: 0x170073F5 RID: 29685
		// (get) Token: 0x06017DEF RID: 97775 RVA: 0x00371DD0 File Offset: 0x0036FFD0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06017DF0 RID: 97776 RVA: 0x00371DDD File Offset: 0x0036FFDD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06017DF1 RID: 97777 RVA: 0x00371DE4 File Offset: 0x0036FFE4
		public static IQuestStatisticsType GetRootAsIQuestStatisticsType(ByteBuffer _bb)
		{
			return IQuestStatisticsType.GetRootAsIQuestStatisticsType(_bb, default(IQuestStatisticsType));
		}

		// Token: 0x06017DF2 RID: 97778 RVA: 0x00371E00 File Offset: 0x00370000
		public static IQuestStatisticsType GetRootAsIQuestStatisticsType(ByteBuffer _bb, IQuestStatisticsType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06017DF3 RID: 97779 RVA: 0x00371E1D File Offset: 0x0037001D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06017DF4 RID: 97780 RVA: 0x00371E2C File Offset: 0x0037002C
		public IQuestStatisticsType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170073F6 RID: 29686
		// (get) Token: 0x06017DF5 RID: 97781 RVA: 0x00371E3C File Offset: 0x0037003C
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

		// Token: 0x170073F7 RID: 29687
		// (get) Token: 0x06017DF6 RID: 97782 RVA: 0x00371E78 File Offset: 0x00370078
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

		// Token: 0x06017DF7 RID: 97783 RVA: 0x00371EB4 File Offset: 0x003700B4
		public TTable? Var<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06017DF8 RID: 97784 RVA: 0x00371EF8 File Offset: 0x003700F8
		public IConstVarRef VarAsIConstVarRef()
		{
			return this.Var<IConstVarRef>().Value;
		}

		// Token: 0x06017DF9 RID: 97785 RVA: 0x00371F14 File Offset: 0x00370114
		public IGlobalVarRef VarAsIGlobalVarRef()
		{
			return this.Var<IGlobalVarRef>().Value;
		}

		// Token: 0x06017DFA RID: 97786 RVA: 0x00371F30 File Offset: 0x00370130
		public IOtherVarRef VarAsIOtherVarRef()
		{
			return this.Var<IOtherVarRef>().Value;
		}

		// Token: 0x06017DFB RID: 97787 RVA: 0x00371F4C File Offset: 0x0037014C
		public ISelfVarRef VarAsISelfVarRef()
		{
			return this.Var<ISelfVarRef>().Value;
		}

		// Token: 0x06017DFC RID: 97788 RVA: 0x00371F68 File Offset: 0x00370168
		public ISystemVarRef VarAsISystemVarRef()
		{
			return this.Var<ISystemVarRef>().Value;
		}

		// Token: 0x06017DFD RID: 97789 RVA: 0x00371F83 File Offset: 0x00370183
		public static Offset<IQuestStatisticsType> CreateIQuestStatisticsType(FlatBufferBuilder builder, EStatisticsEventType Type = EStatisticsEventType.Collect, TVarRef Var_type = TVarRef.NONE, int VarOffset = 0)
		{
			builder.StartTable(3);
			IQuestStatisticsType.AddVar(builder, VarOffset);
			IQuestStatisticsType.AddVarType(builder, Var_type);
			IQuestStatisticsType.AddType(builder, Type);
			return IQuestStatisticsType.EndIQuestStatisticsType(builder);
		}

		// Token: 0x06017DFE RID: 97790 RVA: 0x00371FA7 File Offset: 0x003701A7
		public static void StartIQuestStatisticsType(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06017DFF RID: 97791 RVA: 0x00371FB0 File Offset: 0x003701B0
		public static void AddType(FlatBufferBuilder builder, EStatisticsEventType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06017E00 RID: 97792 RVA: 0x00371FBB File Offset: 0x003701BB
		public static void AddVarType(FlatBufferBuilder builder, TVarRef varType)
		{
			builder.AddByte(1, (byte)varType, 0);
		}

		// Token: 0x06017E01 RID: 97793 RVA: 0x00371FC6 File Offset: 0x003701C6
		public static void AddVar(FlatBufferBuilder builder, int varOffset)
		{
			builder.AddOffset(2, varOffset, 0);
		}

		// Token: 0x06017E02 RID: 97794 RVA: 0x00371FD1 File Offset: 0x003701D1
		public static Offset<IQuestStatisticsType> EndIQuestStatisticsType(FlatBufferBuilder builder)
		{
			return new Offset<IQuestStatisticsType>(builder.EndTable());
		}

		// Token: 0x06017E03 RID: 97795 RVA: 0x00371FE0 File Offset: 0x003701E0
		public IQuestStatisticsTypeT UnPack()
		{
			IQuestStatisticsTypeT questStatisticsTypeT = new IQuestStatisticsTypeT();
			this.UnPackTo(questStatisticsTypeT);
			return questStatisticsTypeT;
		}

		// Token: 0x06017E04 RID: 97796 RVA: 0x00371FFC File Offset: 0x003701FC
		public void UnPackTo(IQuestStatisticsTypeT _o)
		{
			_o.Type = this.Type;
			_o.Var = new TVarRefUnion();
			_o.Var.Type = this.VarType;
			switch (this.VarType)
			{
			case TVarRef.IConstVarRef:
				_o.Var.Value = ((this.Var<IConstVarRef>() != null) ? this.Var<IConstVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.IGlobalVarRef:
				_o.Var.Value = ((this.Var<IGlobalVarRef>() != null) ? this.Var<IGlobalVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.IOtherVarRef:
				_o.Var.Value = ((this.Var<IOtherVarRef>() != null) ? this.Var<IOtherVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.ISelfVarRef:
				_o.Var.Value = ((this.Var<ISelfVarRef>() != null) ? this.Var<ISelfVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.ISystemVarRef:
				_o.Var.Value = ((this.Var<ISystemVarRef>() != null) ? this.Var<ISystemVarRef>().Value.UnPack() : null);
				return;
			default:
				return;
			}
		}

		// Token: 0x06017E05 RID: 97797 RVA: 0x00372168 File Offset: 0x00370368
		public static Offset<IQuestStatisticsType> Pack(FlatBufferBuilder builder, IQuestStatisticsTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IQuestStatisticsType>);
			}
			TVarRef var_type = (_o.Var == null) ? TVarRef.NONE : _o.Var.Type;
			int varOffset = (_o.Var == null) ? 0 : TVarRefUnion.Pack(builder, _o.Var);
			return IQuestStatisticsType.CreateIQuestStatisticsType(builder, _o.Type, var_type, varOffset);
		}

		// Token: 0x0400BBA1 RID: 48033
		private Table __p;
	}
}
