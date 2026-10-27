using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E07 RID: 28167
	public struct IRandomVar : IFlatbufferObject
	{
		// Token: 0x1700D1FB RID: 53755
		// (get) Token: 0x06031C39 RID: 203833 RVA: 0x006BCB5A File Offset: 0x006BAD5A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031C3A RID: 203834 RVA: 0x006BCB67 File Offset: 0x006BAD67
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06031C3B RID: 203835 RVA: 0x006BCB70 File Offset: 0x006BAD70
		public static IRandomVar GetRootAsIRandomVar(ByteBuffer _bb)
		{
			return IRandomVar.GetRootAsIRandomVar(_bb, default(IRandomVar));
		}

		// Token: 0x06031C3C RID: 203836 RVA: 0x006BCB8C File Offset: 0x006BAD8C
		public static IRandomVar GetRootAsIRandomVar(ByteBuffer _bb, IRandomVar obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06031C3D RID: 203837 RVA: 0x006BCBA9 File Offset: 0x006BADA9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031C3E RID: 203838 RVA: 0x006BCBB8 File Offset: 0x006BADB8
		public IRandomVar __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D1FC RID: 53756
		// (get) Token: 0x06031C3F RID: 203839 RVA: 0x006BCBC8 File Offset: 0x006BADC8
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

		// Token: 0x06031C40 RID: 203840 RVA: 0x006BCC04 File Offset: 0x006BAE04
		public TTable? LeftVar<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06031C41 RID: 203841 RVA: 0x006BCC48 File Offset: 0x006BAE48
		public IConstVarRef LeftVarAsIConstVarRef()
		{
			return this.LeftVar<IConstVarRef>().Value;
		}

		// Token: 0x06031C42 RID: 203842 RVA: 0x006BCC64 File Offset: 0x006BAE64
		public IGlobalVarRef LeftVarAsIGlobalVarRef()
		{
			return this.LeftVar<IGlobalVarRef>().Value;
		}

		// Token: 0x06031C43 RID: 203843 RVA: 0x006BCC80 File Offset: 0x006BAE80
		public IOtherVarRef LeftVarAsIOtherVarRef()
		{
			return this.LeftVar<IOtherVarRef>().Value;
		}

		// Token: 0x06031C44 RID: 203844 RVA: 0x006BCC9C File Offset: 0x006BAE9C
		public ISelfVarRef LeftVarAsISelfVarRef()
		{
			return this.LeftVar<ISelfVarRef>().Value;
		}

		// Token: 0x06031C45 RID: 203845 RVA: 0x006BCCB8 File Offset: 0x006BAEB8
		public ISystemVarRef LeftVarAsISystemVarRef()
		{
			return this.LeftVar<ISystemVarRef>().Value;
		}

		// Token: 0x1700D1FD RID: 53757
		// (get) Token: 0x06031C46 RID: 203846 RVA: 0x006BCCD4 File Offset: 0x006BAED4
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

		// Token: 0x06031C47 RID: 203847 RVA: 0x006BCD10 File Offset: 0x006BAF10
		public TTable? RightVar<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06031C48 RID: 203848 RVA: 0x006BCD58 File Offset: 0x006BAF58
		public IConstVarRef RightVarAsIConstVarRef()
		{
			return this.RightVar<IConstVarRef>().Value;
		}

		// Token: 0x06031C49 RID: 203849 RVA: 0x006BCD74 File Offset: 0x006BAF74
		public IGlobalVarRef RightVarAsIGlobalVarRef()
		{
			return this.RightVar<IGlobalVarRef>().Value;
		}

		// Token: 0x06031C4A RID: 203850 RVA: 0x006BCD90 File Offset: 0x006BAF90
		public IOtherVarRef RightVarAsIOtherVarRef()
		{
			return this.RightVar<IOtherVarRef>().Value;
		}

		// Token: 0x06031C4B RID: 203851 RVA: 0x006BCDAC File Offset: 0x006BAFAC
		public ISelfVarRef RightVarAsISelfVarRef()
		{
			return this.RightVar<ISelfVarRef>().Value;
		}

		// Token: 0x06031C4C RID: 203852 RVA: 0x006BCDC8 File Offset: 0x006BAFC8
		public ISystemVarRef RightVarAsISystemVarRef()
		{
			return this.RightVar<ISystemVarRef>().Value;
		}

		// Token: 0x1700D1FE RID: 53758
		// (get) Token: 0x06031C4D RID: 203853 RVA: 0x006BCDE4 File Offset: 0x006BAFE4
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

		// Token: 0x06031C4E RID: 203854 RVA: 0x006BCE24 File Offset: 0x006BB024
		public TTable? Result<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06031C4F RID: 203855 RVA: 0x006BCE6C File Offset: 0x006BB06C
		public IConstVarRef ResultAsIConstVarRef()
		{
			return this.Result<IConstVarRef>().Value;
		}

		// Token: 0x06031C50 RID: 203856 RVA: 0x006BCE88 File Offset: 0x006BB088
		public IGlobalVarRef ResultAsIGlobalVarRef()
		{
			return this.Result<IGlobalVarRef>().Value;
		}

		// Token: 0x06031C51 RID: 203857 RVA: 0x006BCEA4 File Offset: 0x006BB0A4
		public IOtherVarRef ResultAsIOtherVarRef()
		{
			return this.Result<IOtherVarRef>().Value;
		}

		// Token: 0x06031C52 RID: 203858 RVA: 0x006BCEC0 File Offset: 0x006BB0C0
		public ISelfVarRef ResultAsISelfVarRef()
		{
			return this.Result<ISelfVarRef>().Value;
		}

		// Token: 0x06031C53 RID: 203859 RVA: 0x006BCEDC File Offset: 0x006BB0DC
		public ISystemVarRef ResultAsISystemVarRef()
		{
			return this.Result<ISystemVarRef>().Value;
		}

		// Token: 0x06031C54 RID: 203860 RVA: 0x006BCEF7 File Offset: 0x006BB0F7
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

		// Token: 0x06031C55 RID: 203861 RVA: 0x006BCF33 File Offset: 0x006BB133
		public static void StartIRandomVar(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x06031C56 RID: 203862 RVA: 0x006BCF3C File Offset: 0x006BB13C
		public static void AddLeftVarType(FlatBufferBuilder builder, TVarRef leftVarType)
		{
			builder.AddByte(0, (byte)leftVarType, 0);
		}

		// Token: 0x06031C57 RID: 203863 RVA: 0x006BCF47 File Offset: 0x006BB147
		public static void AddLeftVar(FlatBufferBuilder builder, int leftVarOffset)
		{
			builder.AddOffset(1, leftVarOffset, 0);
		}

		// Token: 0x06031C58 RID: 203864 RVA: 0x006BCF52 File Offset: 0x006BB152
		public static void AddRightVarType(FlatBufferBuilder builder, TVarRef rightVarType)
		{
			builder.AddByte(2, (byte)rightVarType, 0);
		}

		// Token: 0x06031C59 RID: 203865 RVA: 0x006BCF5D File Offset: 0x006BB15D
		public static void AddRightVar(FlatBufferBuilder builder, int rightVarOffset)
		{
			builder.AddOffset(3, rightVarOffset, 0);
		}

		// Token: 0x06031C5A RID: 203866 RVA: 0x006BCF68 File Offset: 0x006BB168
		public static void AddResultType(FlatBufferBuilder builder, TVarRef resultType)
		{
			builder.AddByte(4, (byte)resultType, 0);
		}

		// Token: 0x06031C5B RID: 203867 RVA: 0x006BCF73 File Offset: 0x006BB173
		public static void AddResult(FlatBufferBuilder builder, int resultOffset)
		{
			builder.AddOffset(5, resultOffset, 0);
		}

		// Token: 0x06031C5C RID: 203868 RVA: 0x006BCF7E File Offset: 0x006BB17E
		public static Offset<IRandomVar> EndIRandomVar(FlatBufferBuilder builder)
		{
			return new Offset<IRandomVar>(builder.EndTable());
		}

		// Token: 0x06031C5D RID: 203869 RVA: 0x006BCF8C File Offset: 0x006BB18C
		public IRandomVarT UnPack()
		{
			IRandomVarT randomVarT = new IRandomVarT();
			this.UnPackTo(randomVarT);
			return randomVarT;
		}

		// Token: 0x06031C5E RID: 203870 RVA: 0x006BCFA8 File Offset: 0x006BB1A8
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

		// Token: 0x06031C5F RID: 203871 RVA: 0x006BD3C8 File Offset: 0x006BB5C8
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

		// Token: 0x040117ED RID: 71661
		private Table __p;
	}
}
