using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200736A RID: 29546
	public struct IOpenGreatSwordChallengeResult : IFlatbufferObject
	{
		// Token: 0x1700D8B6 RID: 55478
		// (get) Token: 0x06033904 RID: 211204 RVA: 0x006F30B8 File Offset: 0x006F12B8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06033905 RID: 211205 RVA: 0x006F30C5 File Offset: 0x006F12C5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06033906 RID: 211206 RVA: 0x006F30CC File Offset: 0x006F12CC
		public static IOpenGreatSwordChallengeResult GetRootAsIOpenGreatSwordChallengeResult(ByteBuffer _bb)
		{
			return IOpenGreatSwordChallengeResult.GetRootAsIOpenGreatSwordChallengeResult(_bb, default(IOpenGreatSwordChallengeResult));
		}

		// Token: 0x06033907 RID: 211207 RVA: 0x006F30E8 File Offset: 0x006F12E8
		public static IOpenGreatSwordChallengeResult GetRootAsIOpenGreatSwordChallengeResult(ByteBuffer _bb, IOpenGreatSwordChallengeResult obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06033908 RID: 211208 RVA: 0x006F3105 File Offset: 0x006F1305
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06033909 RID: 211209 RVA: 0x006F3114 File Offset: 0x006F1314
		public IOpenGreatSwordChallengeResult __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D8B7 RID: 55479
		// (get) Token: 0x0603390A RID: 211210 RVA: 0x006F3124 File Offset: 0x006F1324
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

		// Token: 0x1700D8B8 RID: 55480
		// (get) Token: 0x0603390B RID: 211211 RVA: 0x006F3160 File Offset: 0x006F1360
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

		// Token: 0x1700D8B9 RID: 55481
		// (get) Token: 0x0603390C RID: 211212 RVA: 0x006F319C File Offset: 0x006F139C
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

		// Token: 0x0603390D RID: 211213 RVA: 0x006F31D8 File Offset: 0x006F13D8
		public TTable? ReturnVar<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0603390E RID: 211214 RVA: 0x006F3220 File Offset: 0x006F1420
		public IConstVarRef ReturnVarAsIConstVarRef()
		{
			return this.ReturnVar<IConstVarRef>().Value;
		}

		// Token: 0x0603390F RID: 211215 RVA: 0x006F323C File Offset: 0x006F143C
		public IGlobalVarRef ReturnVarAsIGlobalVarRef()
		{
			return this.ReturnVar<IGlobalVarRef>().Value;
		}

		// Token: 0x06033910 RID: 211216 RVA: 0x006F3258 File Offset: 0x006F1458
		public IOtherVarRef ReturnVarAsIOtherVarRef()
		{
			return this.ReturnVar<IOtherVarRef>().Value;
		}

		// Token: 0x06033911 RID: 211217 RVA: 0x006F3274 File Offset: 0x006F1474
		public ISelfVarRef ReturnVarAsISelfVarRef()
		{
			return this.ReturnVar<ISelfVarRef>().Value;
		}

		// Token: 0x06033912 RID: 211218 RVA: 0x006F3290 File Offset: 0x006F1490
		public ISystemVarRef ReturnVarAsISystemVarRef()
		{
			return this.ReturnVar<ISystemVarRef>().Value;
		}

		// Token: 0x06033913 RID: 211219 RVA: 0x006F32AB File Offset: 0x006F14AB
		public static Offset<IOpenGreatSwordChallengeResult> CreateIOpenGreatSwordChallengeResult(FlatBufferBuilder builder, ESystemType Type = ESystemType.Shop, int Id = 0, TVarRef ReturnVar_type = TVarRef.NONE, int ReturnVarOffset = 0)
		{
			builder.StartTable(4);
			IOpenGreatSwordChallengeResult.AddReturnVar(builder, ReturnVarOffset);
			IOpenGreatSwordChallengeResult.AddId(builder, Id);
			IOpenGreatSwordChallengeResult.AddReturnVarType(builder, ReturnVar_type);
			IOpenGreatSwordChallengeResult.AddType(builder, Type);
			return IOpenGreatSwordChallengeResult.EndIOpenGreatSwordChallengeResult(builder);
		}

		// Token: 0x06033914 RID: 211220 RVA: 0x006F32D7 File Offset: 0x006F14D7
		public static void StartIOpenGreatSwordChallengeResult(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06033915 RID: 211221 RVA: 0x006F32E0 File Offset: 0x006F14E0
		public static void AddType(FlatBufferBuilder builder, ESystemType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06033916 RID: 211222 RVA: 0x006F32EB File Offset: 0x006F14EB
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x06033917 RID: 211223 RVA: 0x006F32F6 File Offset: 0x006F14F6
		public static void AddReturnVarType(FlatBufferBuilder builder, TVarRef returnVarType)
		{
			builder.AddByte(2, (byte)returnVarType, 0);
		}

		// Token: 0x06033918 RID: 211224 RVA: 0x006F3301 File Offset: 0x006F1501
		public static void AddReturnVar(FlatBufferBuilder builder, int returnVarOffset)
		{
			builder.AddOffset(3, returnVarOffset, 0);
		}

		// Token: 0x06033919 RID: 211225 RVA: 0x006F330C File Offset: 0x006F150C
		public static Offset<IOpenGreatSwordChallengeResult> EndIOpenGreatSwordChallengeResult(FlatBufferBuilder builder)
		{
			return new Offset<IOpenGreatSwordChallengeResult>(builder.EndTable());
		}

		// Token: 0x0603391A RID: 211226 RVA: 0x006F331C File Offset: 0x006F151C
		public IOpenGreatSwordChallengeResultT UnPack()
		{
			IOpenGreatSwordChallengeResultT openGreatSwordChallengeResultT = new IOpenGreatSwordChallengeResultT();
			this.UnPackTo(openGreatSwordChallengeResultT);
			return openGreatSwordChallengeResultT;
		}

		// Token: 0x0603391B RID: 211227 RVA: 0x006F3338 File Offset: 0x006F1538
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

		// Token: 0x0603391C RID: 211228 RVA: 0x006F34B0 File Offset: 0x006F16B0
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

		// Token: 0x04012455 RID: 74837
		private Table __p;
	}
}
