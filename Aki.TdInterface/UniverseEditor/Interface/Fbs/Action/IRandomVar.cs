using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007582 RID: 30082
	public struct IRandomVar : IFlatbufferObject
	{
		// Token: 0x1700DD43 RID: 56643
		// (get) Token: 0x06034C35 RID: 216117 RVA: 0x00718242 File Offset: 0x00716442
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06034C36 RID: 216118 RVA: 0x0071824F File Offset: 0x0071644F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06034C37 RID: 216119 RVA: 0x00718258 File Offset: 0x00716458
		public static IRandomVar GetRootAsIRandomVar(ByteBuffer _bb)
		{
			return IRandomVar.GetRootAsIRandomVar(_bb, default(IRandomVar));
		}

		// Token: 0x06034C38 RID: 216120 RVA: 0x00718274 File Offset: 0x00716474
		public static IRandomVar GetRootAsIRandomVar(ByteBuffer _bb, IRandomVar obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06034C39 RID: 216121 RVA: 0x00718291 File Offset: 0x00716491
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06034C3A RID: 216122 RVA: 0x007182A0 File Offset: 0x007164A0
		public IRandomVar __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DD44 RID: 56644
		// (get) Token: 0x06034C3B RID: 216123 RVA: 0x007182B0 File Offset: 0x007164B0
		public TVarRef LeftVarType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return TVarRef.NONE;
				}
				return (TVarRef)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06034C3C RID: 216124 RVA: 0x007182EC File Offset: 0x007164EC
		public TTable? LeftVar<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06034C3D RID: 216125 RVA: 0x00718330 File Offset: 0x00716530
		public IConstVarRef LeftVarAsIConstVarRef()
		{
			return this.LeftVar<IConstVarRef>().Value;
		}

		// Token: 0x06034C3E RID: 216126 RVA: 0x0071834C File Offset: 0x0071654C
		public IGlobalVarRef LeftVarAsIGlobalVarRef()
		{
			return this.LeftVar<IGlobalVarRef>().Value;
		}

		// Token: 0x06034C3F RID: 216127 RVA: 0x00718368 File Offset: 0x00716568
		public IOtherVarRef LeftVarAsIOtherVarRef()
		{
			return this.LeftVar<IOtherVarRef>().Value;
		}

		// Token: 0x06034C40 RID: 216128 RVA: 0x00718384 File Offset: 0x00716584
		public ISelfVarRef LeftVarAsISelfVarRef()
		{
			return this.LeftVar<ISelfVarRef>().Value;
		}

		// Token: 0x06034C41 RID: 216129 RVA: 0x007183A0 File Offset: 0x007165A0
		public ISystemVarRef LeftVarAsISystemVarRef()
		{
			return this.LeftVar<ISystemVarRef>().Value;
		}

		// Token: 0x1700DD45 RID: 56645
		// (get) Token: 0x06034C42 RID: 216130 RVA: 0x007183BC File Offset: 0x007165BC
		public TVarRef RightVarType
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return TVarRef.NONE;
				}
				return (TVarRef)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06034C43 RID: 216131 RVA: 0x007183F8 File Offset: 0x007165F8
		public TTable? RightVar<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06034C44 RID: 216132 RVA: 0x00718440 File Offset: 0x00716640
		public IConstVarRef RightVarAsIConstVarRef()
		{
			return this.RightVar<IConstVarRef>().Value;
		}

		// Token: 0x06034C45 RID: 216133 RVA: 0x0071845C File Offset: 0x0071665C
		public IGlobalVarRef RightVarAsIGlobalVarRef()
		{
			return this.RightVar<IGlobalVarRef>().Value;
		}

		// Token: 0x06034C46 RID: 216134 RVA: 0x00718478 File Offset: 0x00716678
		public IOtherVarRef RightVarAsIOtherVarRef()
		{
			return this.RightVar<IOtherVarRef>().Value;
		}

		// Token: 0x06034C47 RID: 216135 RVA: 0x00718494 File Offset: 0x00716694
		public ISelfVarRef RightVarAsISelfVarRef()
		{
			return this.RightVar<ISelfVarRef>().Value;
		}

		// Token: 0x06034C48 RID: 216136 RVA: 0x007184B0 File Offset: 0x007166B0
		public ISystemVarRef RightVarAsISystemVarRef()
		{
			return this.RightVar<ISystemVarRef>().Value;
		}

		// Token: 0x1700DD46 RID: 56646
		// (get) Token: 0x06034C49 RID: 216137 RVA: 0x007184CC File Offset: 0x007166CC
		public TVarRef ResultType
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return TVarRef.NONE;
				}
				return (TVarRef)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06034C4A RID: 216138 RVA: 0x0071850C File Offset: 0x0071670C
		public TTable? Result<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06034C4B RID: 216139 RVA: 0x00718554 File Offset: 0x00716754
		public IConstVarRef ResultAsIConstVarRef()
		{
			return this.Result<IConstVarRef>().Value;
		}

		// Token: 0x06034C4C RID: 216140 RVA: 0x00718570 File Offset: 0x00716770
		public IGlobalVarRef ResultAsIGlobalVarRef()
		{
			return this.Result<IGlobalVarRef>().Value;
		}

		// Token: 0x06034C4D RID: 216141 RVA: 0x0071858C File Offset: 0x0071678C
		public IOtherVarRef ResultAsIOtherVarRef()
		{
			return this.Result<IOtherVarRef>().Value;
		}

		// Token: 0x06034C4E RID: 216142 RVA: 0x007185A8 File Offset: 0x007167A8
		public ISelfVarRef ResultAsISelfVarRef()
		{
			return this.Result<ISelfVarRef>().Value;
		}

		// Token: 0x06034C4F RID: 216143 RVA: 0x007185C4 File Offset: 0x007167C4
		public ISystemVarRef ResultAsISystemVarRef()
		{
			return this.Result<ISystemVarRef>().Value;
		}

		// Token: 0x06034C50 RID: 216144 RVA: 0x007185DF File Offset: 0x007167DF
		public static Offset<IRandomVar> CreateIRandomVar(FlatBufferBuilder builder, TVarRef LeftVar_type = TVarRef.NONE, int LeftVarOffset = 0, TVarRef RightVar_type = TVarRef.NONE, int RightVarOffset = 0, TVarRef Result_type = TVarRef.NONE, int ResultOffset = 0)
		{
			builder.StartTable(6);
			IRandomVar.AddResult(builder, ResultOffset);
			IRandomVar.AddRightVar(builder, RightVarOffset);
			IRandomVar.AddLeftVar(builder, LeftVarOffset);
			IRandomVar.AddResultType(builder, Result_type);
			IRandomVar.AddRightVarType(builder, RightVar_type);
			IRandomVar.AddLeftVarType(builder, LeftVar_type);
			return IRandomVar.EndIRandomVar(builder);
		}

		// Token: 0x06034C51 RID: 216145 RVA: 0x0071861B File Offset: 0x0071681B
		public static void StartIRandomVar(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x06034C52 RID: 216146 RVA: 0x00718624 File Offset: 0x00716824
		public static void AddLeftVarType(FlatBufferBuilder builder, TVarRef leftVarType)
		{
			builder.AddByte(0, (byte)leftVarType, 0);
		}

		// Token: 0x06034C53 RID: 216147 RVA: 0x0071862F File Offset: 0x0071682F
		public static void AddLeftVar(FlatBufferBuilder builder, int leftVarOffset)
		{
			builder.AddOffset(1, leftVarOffset, 0);
		}

		// Token: 0x06034C54 RID: 216148 RVA: 0x0071863A File Offset: 0x0071683A
		public static void AddRightVarType(FlatBufferBuilder builder, TVarRef rightVarType)
		{
			builder.AddByte(2, (byte)rightVarType, 0);
		}

		// Token: 0x06034C55 RID: 216149 RVA: 0x00718645 File Offset: 0x00716845
		public static void AddRightVar(FlatBufferBuilder builder, int rightVarOffset)
		{
			builder.AddOffset(3, rightVarOffset, 0);
		}

		// Token: 0x06034C56 RID: 216150 RVA: 0x00718650 File Offset: 0x00716850
		public static void AddResultType(FlatBufferBuilder builder, TVarRef resultType)
		{
			builder.AddByte(4, (byte)resultType, 0);
		}

		// Token: 0x06034C57 RID: 216151 RVA: 0x0071865B File Offset: 0x0071685B
		public static void AddResult(FlatBufferBuilder builder, int resultOffset)
		{
			builder.AddOffset(5, resultOffset, 0);
		}

		// Token: 0x06034C58 RID: 216152 RVA: 0x00718666 File Offset: 0x00716866
		public static Offset<IRandomVar> EndIRandomVar(FlatBufferBuilder builder)
		{
			return new Offset<IRandomVar>(builder.EndTable());
		}

		// Token: 0x06034C59 RID: 216153 RVA: 0x00718674 File Offset: 0x00716874
		public IRandomVarT UnPack()
		{
			IRandomVarT randomVarT = new IRandomVarT();
			this.UnPackTo(randomVarT);
			return randomVarT;
		}

		// Token: 0x06034C5A RID: 216154 RVA: 0x00718690 File Offset: 0x00716890
		public void UnPackTo(IRandomVarT _o)
		{
			_o.LeftVar = new TVarRefUnion();
			_o.LeftVar.Type = this.LeftVarType;
			switch (this.LeftVarType)
			{
			case TVarRef.IConstVarRef:
				_o.LeftVar.Value = ((this.LeftVar<IConstVarRef>() != null) ? this.LeftVar<IConstVarRef>().Value.UnPack() : null);
				break;
			case TVarRef.IGlobalVarRef:
				_o.LeftVar.Value = ((this.LeftVar<IGlobalVarRef>() != null) ? this.LeftVar<IGlobalVarRef>().Value.UnPack() : null);
				break;
			case TVarRef.IOtherVarRef:
				_o.LeftVar.Value = ((this.LeftVar<IOtherVarRef>() != null) ? this.LeftVar<IOtherVarRef>().Value.UnPack() : null);
				break;
			case TVarRef.ISelfVarRef:
				_o.LeftVar.Value = ((this.LeftVar<ISelfVarRef>() != null) ? this.LeftVar<ISelfVarRef>().Value.UnPack() : null);
				break;
			case TVarRef.ISystemVarRef:
				_o.LeftVar.Value = ((this.LeftVar<ISystemVarRef>() != null) ? this.LeftVar<ISystemVarRef>().Value.UnPack() : null);
				break;
			}
			_o.RightVar = new TVarRefUnion();
			_o.RightVar.Type = this.RightVarType;
			switch (this.RightVarType)
			{
			case TVarRef.IConstVarRef:
				_o.RightVar.Value = ((this.RightVar<IConstVarRef>() != null) ? this.RightVar<IConstVarRef>().Value.UnPack() : null);
				break;
			case TVarRef.IGlobalVarRef:
				_o.RightVar.Value = ((this.RightVar<IGlobalVarRef>() != null) ? this.RightVar<IGlobalVarRef>().Value.UnPack() : null);
				break;
			case TVarRef.IOtherVarRef:
				_o.RightVar.Value = ((this.RightVar<IOtherVarRef>() != null) ? this.RightVar<IOtherVarRef>().Value.UnPack() : null);
				break;
			case TVarRef.ISelfVarRef:
				_o.RightVar.Value = ((this.RightVar<ISelfVarRef>() != null) ? this.RightVar<ISelfVarRef>().Value.UnPack() : null);
				break;
			case TVarRef.ISystemVarRef:
				_o.RightVar.Value = ((this.RightVar<ISystemVarRef>() != null) ? this.RightVar<ISystemVarRef>().Value.UnPack() : null);
				break;
			}
			_o.Result = new TVarRefUnion();
			_o.Result.Type = this.ResultType;
			switch (this.ResultType)
			{
			case TVarRef.IConstVarRef:
				_o.Result.Value = ((this.Result<IConstVarRef>() != null) ? this.Result<IConstVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.IGlobalVarRef:
				_o.Result.Value = ((this.Result<IGlobalVarRef>() != null) ? this.Result<IGlobalVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.IOtherVarRef:
				_o.Result.Value = ((this.Result<IOtherVarRef>() != null) ? this.Result<IOtherVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.ISelfVarRef:
				_o.Result.Value = ((this.Result<ISelfVarRef>() != null) ? this.Result<ISelfVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.ISystemVarRef:
				_o.Result.Value = ((this.Result<ISystemVarRef>() != null) ? this.Result<ISystemVarRef>().Value.UnPack() : null);
				return;
			default:
				return;
			}
		}

		// Token: 0x06034C5B RID: 216155 RVA: 0x00718AB0 File Offset: 0x00716CB0
		public static Offset<IRandomVar> Pack(FlatBufferBuilder builder, IRandomVarT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRandomVar>);
			}
			TVarRef leftVar_type = (_o.LeftVar == null) ? TVarRef.NONE : _o.LeftVar.Type;
			int leftVarOffset = (_o.LeftVar == null) ? 0 : TVarRefUnion.Pack(builder, _o.LeftVar);
			TVarRef rightVar_type = (_o.RightVar == null) ? TVarRef.NONE : _o.RightVar.Type;
			int rightVarOffset = (_o.RightVar == null) ? 0 : TVarRefUnion.Pack(builder, _o.RightVar);
			TVarRef result_type = (_o.Result == null) ? TVarRef.NONE : _o.Result.Type;
			int resultOffset = (_o.Result == null) ? 0 : TVarRefUnion.Pack(builder, _o.Result);
			return IRandomVar.CreateIRandomVar(builder, leftVar_type, leftVarOffset, rightVar_type, rightVarOffset, result_type, resultOffset);
		}

		// Token: 0x04012769 RID: 75625
		private Table __p;
	}
}
