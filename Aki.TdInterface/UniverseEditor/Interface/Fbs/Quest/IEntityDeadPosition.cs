using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004241 RID: 16961
	public struct IEntityDeadPosition : IFlatbufferObject
	{
		// Token: 0x1700739D RID: 29597
		// (get) Token: 0x06017988 RID: 96648 RVA: 0x0035DB40 File Offset: 0x0035BD40
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06017989 RID: 96649 RVA: 0x0035DB4D File Offset: 0x0035BD4D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601798A RID: 96650 RVA: 0x0035DB54 File Offset: 0x0035BD54
		public static IEntityDeadPosition GetRootAsIEntityDeadPosition(ByteBuffer _bb)
		{
			return IEntityDeadPosition.GetRootAsIEntityDeadPosition(_bb, default(IEntityDeadPosition));
		}

		// Token: 0x0601798B RID: 96651 RVA: 0x0035DB70 File Offset: 0x0035BD70
		public static IEntityDeadPosition GetRootAsIEntityDeadPosition(ByteBuffer _bb, IEntityDeadPosition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601798C RID: 96652 RVA: 0x0035DB8D File Offset: 0x0035BD8D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601798D RID: 96653 RVA: 0x0035DB9C File Offset: 0x0035BD9C
		public IEntityDeadPosition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700739E RID: 29598
		// (get) Token: 0x0601798E RID: 96654 RVA: 0x0035DBAC File Offset: 0x0035BDAC
		public int EntityId
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700739F RID: 29599
		// (get) Token: 0x0601798F RID: 96655 RVA: 0x0035DBE8 File Offset: 0x0035BDE8
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

		// Token: 0x06017990 RID: 96656 RVA: 0x0035DC24 File Offset: 0x0035BE24
		public TTable? Var<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06017991 RID: 96657 RVA: 0x0035DC68 File Offset: 0x0035BE68
		public IConstVarRef VarAsIConstVarRef()
		{
			return this.Var<IConstVarRef>().Value;
		}

		// Token: 0x06017992 RID: 96658 RVA: 0x0035DC84 File Offset: 0x0035BE84
		public IGlobalVarRef VarAsIGlobalVarRef()
		{
			return this.Var<IGlobalVarRef>().Value;
		}

		// Token: 0x06017993 RID: 96659 RVA: 0x0035DCA0 File Offset: 0x0035BEA0
		public IOtherVarRef VarAsIOtherVarRef()
		{
			return this.Var<IOtherVarRef>().Value;
		}

		// Token: 0x06017994 RID: 96660 RVA: 0x0035DCBC File Offset: 0x0035BEBC
		public ISelfVarRef VarAsISelfVarRef()
		{
			return this.Var<ISelfVarRef>().Value;
		}

		// Token: 0x06017995 RID: 96661 RVA: 0x0035DCD8 File Offset: 0x0035BED8
		public ISystemVarRef VarAsISystemVarRef()
		{
			return this.Var<ISystemVarRef>().Value;
		}

		// Token: 0x170073A0 RID: 29600
		// (get) Token: 0x06017996 RID: 96662 RVA: 0x0035DCF4 File Offset: 0x0035BEF4
		public bool IsIgnoreRot
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170073A1 RID: 29601
		// (get) Token: 0x06017997 RID: 96663 RVA: 0x0035DD34 File Offset: 0x0035BF34
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06017998 RID: 96664 RVA: 0x0035DD71 File Offset: 0x0035BF71
		public static Offset<IEntityDeadPosition> CreateIEntityDeadPosition(FlatBufferBuilder builder, int EntityId = 0, TVarRef Var_type = TVarRef.NONE, int VarOffset = 0, bool IsIgnoreRot = false, byte NullMask = 0)
		{
			builder.StartTable(5);
			IEntityDeadPosition.AddVar(builder, VarOffset);
			IEntityDeadPosition.AddEntityId(builder, EntityId);
			IEntityDeadPosition.AddNullMask(builder, NullMask);
			IEntityDeadPosition.AddIsIgnoreRot(builder, IsIgnoreRot);
			IEntityDeadPosition.AddVarType(builder, Var_type);
			return IEntityDeadPosition.EndIEntityDeadPosition(builder);
		}

		// Token: 0x06017999 RID: 96665 RVA: 0x0035DDA5 File Offset: 0x0035BFA5
		public static void StartIEntityDeadPosition(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0601799A RID: 96666 RVA: 0x0035DDAE File Offset: 0x0035BFAE
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(0, entityId, 0);
		}

		// Token: 0x0601799B RID: 96667 RVA: 0x0035DDB9 File Offset: 0x0035BFB9
		public static void AddVarType(FlatBufferBuilder builder, TVarRef varType)
		{
			builder.AddByte(1, (byte)varType, 0);
		}

		// Token: 0x0601799C RID: 96668 RVA: 0x0035DDC4 File Offset: 0x0035BFC4
		public static void AddVar(FlatBufferBuilder builder, int varOffset)
		{
			builder.AddOffset(2, varOffset, 0);
		}

		// Token: 0x0601799D RID: 96669 RVA: 0x0035DDCF File Offset: 0x0035BFCF
		public static void AddIsIgnoreRot(FlatBufferBuilder builder, bool isIgnoreRot)
		{
			builder.AddBool(3, isIgnoreRot, false);
		}

		// Token: 0x0601799E RID: 96670 RVA: 0x0035DDDA File Offset: 0x0035BFDA
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x0601799F RID: 96671 RVA: 0x0035DDE5 File Offset: 0x0035BFE5
		public static Offset<IEntityDeadPosition> EndIEntityDeadPosition(FlatBufferBuilder builder)
		{
			return new Offset<IEntityDeadPosition>(builder.EndTable());
		}

		// Token: 0x060179A0 RID: 96672 RVA: 0x0035DDF4 File Offset: 0x0035BFF4
		public IEntityDeadPositionT UnPack()
		{
			IEntityDeadPositionT entityDeadPositionT = new IEntityDeadPositionT();
			this.UnPackTo(entityDeadPositionT);
			return entityDeadPositionT;
		}

		// Token: 0x060179A1 RID: 96673 RVA: 0x0035DE10 File Offset: 0x0035C010
		public void UnPackTo(IEntityDeadPositionT _o)
		{
			_o.EntityId = this.EntityId;
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
			_o.IsIgnoreRot = this.IsIgnoreRot;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060179A2 RID: 96674 RVA: 0x0035DFA4 File Offset: 0x0035C1A4
		public static Offset<IEntityDeadPosition> Pack(FlatBufferBuilder builder, IEntityDeadPositionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEntityDeadPosition>);
			}
			TVarRef var_type = (_o.Var == null) ? TVarRef.NONE : _o.Var.Type;
			int varOffset = (_o.Var == null) ? 0 : TVarRefUnion.Pack(builder, _o.Var);
			return IEntityDeadPosition.CreateIEntityDeadPosition(builder, _o.EntityId, var_type, varOffset, _o.IsIgnoreRot, _o.NullMask);
		}

		// Token: 0x0400C14D RID: 49485
		private Table __p;
	}
}
