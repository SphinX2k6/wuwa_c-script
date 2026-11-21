using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004496 RID: 17558
	public struct IQuestStatisticsType : IFlatbufferObject
	{
		// Token: 0x170079F7 RID: 31223
		// (get) Token: 0x06019488 RID: 103560 RVA: 0x0039BBC4 File Offset: 0x00399DC4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06019489 RID: 103561 RVA: 0x0039BBD1 File Offset: 0x00399DD1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601948A RID: 103562 RVA: 0x0039BBD8 File Offset: 0x00399DD8
		public static IQuestStatisticsType GetRootAsIQuestStatisticsType(ByteBuffer _bb)
		{
			return IQuestStatisticsType.GetRootAsIQuestStatisticsType(_bb, default(IQuestStatisticsType));
		}

		// Token: 0x0601948B RID: 103563 RVA: 0x0039BBF4 File Offset: 0x00399DF4
		public static IQuestStatisticsType GetRootAsIQuestStatisticsType(ByteBuffer _bb, IQuestStatisticsType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601948C RID: 103564 RVA: 0x0039BC11 File Offset: 0x00399E11
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601948D RID: 103565 RVA: 0x0039BC20 File Offset: 0x00399E20
		public IQuestStatisticsType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170079F8 RID: 31224
		// (get) Token: 0x0601948E RID: 103566 RVA: 0x0039BC30 File Offset: 0x00399E30
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

		// Token: 0x170079F9 RID: 31225
		// (get) Token: 0x0601948F RID: 103567 RVA: 0x0039BC6C File Offset: 0x00399E6C
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

		// Token: 0x06019490 RID: 103568 RVA: 0x0039BCA8 File Offset: 0x00399EA8
		public TTable? Var<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06019491 RID: 103569 RVA: 0x0039BCEC File Offset: 0x00399EEC
		public IConstVarRef VarAsIConstVarRef()
		{
			return this.Var<IConstVarRef>().Value;
		}

		// Token: 0x06019492 RID: 103570 RVA: 0x0039BD08 File Offset: 0x00399F08
		public IGlobalVarRef VarAsIGlobalVarRef()
		{
			return this.Var<IGlobalVarRef>().Value;
		}

		// Token: 0x06019493 RID: 103571 RVA: 0x0039BD24 File Offset: 0x00399F24
		public IOtherVarRef VarAsIOtherVarRef()
		{
			return this.Var<IOtherVarRef>().Value;
		}

		// Token: 0x06019494 RID: 103572 RVA: 0x0039BD40 File Offset: 0x00399F40
		public ISelfVarRef VarAsISelfVarRef()
		{
			return this.Var<ISelfVarRef>().Value;
		}

		// Token: 0x06019495 RID: 103573 RVA: 0x0039BD5C File Offset: 0x00399F5C
		public ISystemVarRef VarAsISystemVarRef()
		{
			return this.Var<ISystemVarRef>().Value;
		}

		// Token: 0x06019496 RID: 103574 RVA: 0x0039BD77 File Offset: 0x00399F77
		public static Offset<IQuestStatisticsType> CreateIQuestStatisticsType(FlatBufferBuilder builder, EStatisticsEventType Type = EStatisticsEventType.Collect, TVarRef Var_type = TVarRef.NONE, int VarOffset = 0)
		{
			builder.StartTable(3);
			IQuestStatisticsType.AddVar(builder, VarOffset);
			IQuestStatisticsType.AddVarType(builder, Var_type);
			IQuestStatisticsType.AddType(builder, Type);
			return IQuestStatisticsType.EndIQuestStatisticsType(builder);
		}

		// Token: 0x06019497 RID: 103575 RVA: 0x0039BD9B File Offset: 0x00399F9B
		public static void StartIQuestStatisticsType(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06019498 RID: 103576 RVA: 0x0039BDA4 File Offset: 0x00399FA4
		public static void AddType(FlatBufferBuilder builder, EStatisticsEventType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06019499 RID: 103577 RVA: 0x0039BDAF File Offset: 0x00399FAF
		public static void AddVarType(FlatBufferBuilder builder, TVarRef varType)
		{
			builder.AddByte(1, (byte)varType, 0);
		}

		// Token: 0x0601949A RID: 103578 RVA: 0x0039BDBA File Offset: 0x00399FBA
		public static void AddVar(FlatBufferBuilder builder, int varOffset)
		{
			builder.AddOffset(2, varOffset, 0);
		}

		// Token: 0x0601949B RID: 103579 RVA: 0x0039BDC5 File Offset: 0x00399FC5
		public static Offset<IQuestStatisticsType> EndIQuestStatisticsType(FlatBufferBuilder builder)
		{
			return new Offset<IQuestStatisticsType>(builder.EndTable());
		}

		// Token: 0x0601949C RID: 103580 RVA: 0x0039BDD4 File Offset: 0x00399FD4
		public IQuestStatisticsTypeT UnPack()
		{
			IQuestStatisticsTypeT questStatisticsTypeT = new IQuestStatisticsTypeT();
			this.UnPackTo(questStatisticsTypeT);
			return questStatisticsTypeT;
		}

		// Token: 0x0601949D RID: 103581 RVA: 0x0039BDF0 File Offset: 0x00399FF0
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

		// Token: 0x0601949E RID: 103582 RVA: 0x0039BF5C File Offset: 0x0039A15C
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

		// Token: 0x0400C588 RID: 50568
		private Table __p;
	}
}
