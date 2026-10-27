using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C06 RID: 27654
	public struct IOpenGreatSwordChallengeResult : IFlatbufferObject
	{
		// Token: 0x1700CDA8 RID: 52648
		// (get) Token: 0x060309E4 RID: 199140 RVA: 0x00699724 File Offset: 0x00697924
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060309E5 RID: 199141 RVA: 0x00699731 File Offset: 0x00697931
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060309E6 RID: 199142 RVA: 0x00699738 File Offset: 0x00697938
		public static IOpenGreatSwordChallengeResult GetRootAsIOpenGreatSwordChallengeResult(ByteBuffer _bb)
		{
			return IOpenGreatSwordChallengeResult.GetRootAsIOpenGreatSwordChallengeResult(_bb, default(IOpenGreatSwordChallengeResult));
		}

		// Token: 0x060309E7 RID: 199143 RVA: 0x00699754 File Offset: 0x00697954
		public static IOpenGreatSwordChallengeResult GetRootAsIOpenGreatSwordChallengeResult(ByteBuffer _bb, IOpenGreatSwordChallengeResult obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060309E8 RID: 199144 RVA: 0x00699771 File Offset: 0x00697971
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060309E9 RID: 199145 RVA: 0x00699780 File Offset: 0x00697980
		public IOpenGreatSwordChallengeResult __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CDA9 RID: 52649
		// (get) Token: 0x060309EA RID: 199146 RVA: 0x00699790 File Offset: 0x00697990
		public ESystemType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESystemType.Shop;
				}
				return (ESystemType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700CDAA RID: 52650
		// (get) Token: 0x060309EB RID: 199147 RVA: 0x006997CC File Offset: 0x006979CC
		public int Id
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700CDAB RID: 52651
		// (get) Token: 0x060309EC RID: 199148 RVA: 0x00699808 File Offset: 0x00697A08
		public TVarRef ReturnVarType
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

		// Token: 0x060309ED RID: 199149 RVA: 0x00699844 File Offset: 0x00697A44
		public TTable? ReturnVar<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060309EE RID: 199150 RVA: 0x0069988C File Offset: 0x00697A8C
		public IConstVarRef ReturnVarAsIConstVarRef()
		{
			return this.ReturnVar<IConstVarRef>().Value;
		}

		// Token: 0x060309EF RID: 199151 RVA: 0x006998A8 File Offset: 0x00697AA8
		public IGlobalVarRef ReturnVarAsIGlobalVarRef()
		{
			return this.ReturnVar<IGlobalVarRef>().Value;
		}

		// Token: 0x060309F0 RID: 199152 RVA: 0x006998C4 File Offset: 0x00697AC4
		public IOtherVarRef ReturnVarAsIOtherVarRef()
		{
			return this.ReturnVar<IOtherVarRef>().Value;
		}

		// Token: 0x060309F1 RID: 199153 RVA: 0x006998E0 File Offset: 0x00697AE0
		public ISelfVarRef ReturnVarAsISelfVarRef()
		{
			return this.ReturnVar<ISelfVarRef>().Value;
		}

		// Token: 0x060309F2 RID: 199154 RVA: 0x006998FC File Offset: 0x00697AFC
		public ISystemVarRef ReturnVarAsISystemVarRef()
		{
			return this.ReturnVar<ISystemVarRef>().Value;
		}

		// Token: 0x060309F3 RID: 199155 RVA: 0x00699917 File Offset: 0x00697B17
		public static Offset<IOpenGreatSwordChallengeResult> CreateIOpenGreatSwordChallengeResult(FlatBufferBuilder builder, ESystemType Type = ESystemType.Shop, int Id = 0, TVarRef ReturnVar_type = TVarRef.NONE, int ReturnVarOffset = 0)
		{
			builder.StartTable(4);
			IOpenGreatSwordChallengeResult.AddReturnVar(builder, ReturnVarOffset);
			IOpenGreatSwordChallengeResult.AddId(builder, Id);
			IOpenGreatSwordChallengeResult.AddReturnVarType(builder, ReturnVar_type);
			IOpenGreatSwordChallengeResult.AddType(builder, Type);
			return IOpenGreatSwordChallengeResult.EndIOpenGreatSwordChallengeResult(builder);
		}

		// Token: 0x060309F4 RID: 199156 RVA: 0x00699943 File Offset: 0x00697B43
		public static void StartIOpenGreatSwordChallengeResult(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x060309F5 RID: 199157 RVA: 0x0069994C File Offset: 0x00697B4C
		public static void AddType(FlatBufferBuilder builder, ESystemType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060309F6 RID: 199158 RVA: 0x00699957 File Offset: 0x00697B57
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x060309F7 RID: 199159 RVA: 0x00699962 File Offset: 0x00697B62
		public static void AddReturnVarType(FlatBufferBuilder builder, TVarRef returnVarType)
		{
			builder.AddByte(2, (byte)returnVarType, 0);
		}

		// Token: 0x060309F8 RID: 199160 RVA: 0x0069996D File Offset: 0x00697B6D
		public static void AddReturnVar(FlatBufferBuilder builder, int returnVarOffset)
		{
			builder.AddOffset(3, returnVarOffset, 0);
		}

		// Token: 0x060309F9 RID: 199161 RVA: 0x00699978 File Offset: 0x00697B78
		public static Offset<IOpenGreatSwordChallengeResult> EndIOpenGreatSwordChallengeResult(FlatBufferBuilder builder)
		{
			return new Offset<IOpenGreatSwordChallengeResult>(builder.EndTable());
		}

		// Token: 0x060309FA RID: 199162 RVA: 0x00699988 File Offset: 0x00697B88
		public IOpenGreatSwordChallengeResultT UnPack()
		{
			IOpenGreatSwordChallengeResultT openGreatSwordChallengeResultT = new IOpenGreatSwordChallengeResultT();
			this.UnPackTo(openGreatSwordChallengeResultT);
			return openGreatSwordChallengeResultT;
		}

		// Token: 0x060309FB RID: 199163 RVA: 0x006999A4 File Offset: 0x00697BA4
		public void UnPackTo(IOpenGreatSwordChallengeResultT _o)
		{
			_o.Type = this.Type;
			_o.Id = this.Id;
			_o.ReturnVar = new TVarRefUnion();
			_o.ReturnVar.Type = this.ReturnVarType;
			switch (this.ReturnVarType)
			{
			case TVarRef.IConstVarRef:
				_o.ReturnVar.Value = ((this.ReturnVar<IConstVarRef>() != null) ? this.ReturnVar<IConstVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.IGlobalVarRef:
				_o.ReturnVar.Value = ((this.ReturnVar<IGlobalVarRef>() != null) ? this.ReturnVar<IGlobalVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.IOtherVarRef:
				_o.ReturnVar.Value = ((this.ReturnVar<IOtherVarRef>() != null) ? this.ReturnVar<IOtherVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.ISelfVarRef:
				_o.ReturnVar.Value = ((this.ReturnVar<ISelfVarRef>() != null) ? this.ReturnVar<ISelfVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.ISystemVarRef:
				_o.ReturnVar.Value = ((this.ReturnVar<ISystemVarRef>() != null) ? this.ReturnVar<ISystemVarRef>().Value.UnPack() : null);
				return;
			default:
				return;
			}
		}

		// Token: 0x060309FC RID: 199164 RVA: 0x00699B1C File Offset: 0x00697D1C
		public static Offset<IOpenGreatSwordChallengeResult> Pack(FlatBufferBuilder builder, IOpenGreatSwordChallengeResultT _o)
		{
			if (_o == null)
			{
				return default(Offset<IOpenGreatSwordChallengeResult>);
			}
			TVarRef returnVar_type = (_o.ReturnVar == null) ? TVarRef.NONE : _o.ReturnVar.Type;
			int returnVarOffset = (_o.ReturnVar == null) ? 0 : TVarRefUnion.Pack(builder, _o.ReturnVar);
			return IOpenGreatSwordChallengeResult.CreateIOpenGreatSwordChallengeResult(builder, _o.Type, _o.Id, returnVar_type, returnVarOffset);
		}

		// Token: 0x04011505 RID: 70917
		private Table __p;
	}
}
