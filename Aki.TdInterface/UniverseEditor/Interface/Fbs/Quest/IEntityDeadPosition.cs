using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003E06 RID: 15878
	public struct IEntityDeadPosition : IFlatbufferObject
	{
		// Token: 0x17006DB7 RID: 28087
		// (get) Token: 0x0601635B RID: 90971 RVA: 0x00334F48 File Offset: 0x00333148
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601635C RID: 90972 RVA: 0x00334F55 File Offset: 0x00333155
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601635D RID: 90973 RVA: 0x00334F5C File Offset: 0x0033315C
		public static IEntityDeadPosition GetRootAsIEntityDeadPosition(ByteBuffer _bb)
		{
			return IEntityDeadPosition.GetRootAsIEntityDeadPosition(_bb, default(IEntityDeadPosition));
		}

		// Token: 0x0601635E RID: 90974 RVA: 0x00334F78 File Offset: 0x00333178
		public static IEntityDeadPosition GetRootAsIEntityDeadPosition(ByteBuffer _bb, IEntityDeadPosition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601635F RID: 90975 RVA: 0x00334F95 File Offset: 0x00333195
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06016360 RID: 90976 RVA: 0x00334FA4 File Offset: 0x003331A4
		public IEntityDeadPosition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006DB8 RID: 28088
		// (get) Token: 0x06016361 RID: 90977 RVA: 0x00334FB4 File Offset: 0x003331B4
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

		// Token: 0x17006DB9 RID: 28089
		// (get) Token: 0x06016362 RID: 90978 RVA: 0x00334FF0 File Offset: 0x003331F0
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

		// Token: 0x06016363 RID: 90979 RVA: 0x0033502C File Offset: 0x0033322C
		public TTable? Var<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06016364 RID: 90980 RVA: 0x00335070 File Offset: 0x00333270
		public IConstVarRef VarAsIConstVarRef()
		{
			return this.Var<IConstVarRef>().Value;
		}

		// Token: 0x06016365 RID: 90981 RVA: 0x0033508C File Offset: 0x0033328C
		public IGlobalVarRef VarAsIGlobalVarRef()
		{
			return this.Var<IGlobalVarRef>().Value;
		}

		// Token: 0x06016366 RID: 90982 RVA: 0x003350A8 File Offset: 0x003332A8
		public IOtherVarRef VarAsIOtherVarRef()
		{
			return this.Var<IOtherVarRef>().Value;
		}

		// Token: 0x06016367 RID: 90983 RVA: 0x003350C4 File Offset: 0x003332C4
		public ISelfVarRef VarAsISelfVarRef()
		{
			return this.Var<ISelfVarRef>().Value;
		}

		// Token: 0x06016368 RID: 90984 RVA: 0x003350E0 File Offset: 0x003332E0
		public ISystemVarRef VarAsISystemVarRef()
		{
			return this.Var<ISystemVarRef>().Value;
		}

		// Token: 0x17006DBA RID: 28090
		// (get) Token: 0x06016369 RID: 90985 RVA: 0x003350FC File Offset: 0x003332FC
		public bool IsIgnoreRot
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17006DBB RID: 28091
		// (get) Token: 0x0601636A RID: 90986 RVA: 0x0033513C File Offset: 0x0033333C
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

		// Token: 0x0601636B RID: 90987 RVA: 0x00335179 File Offset: 0x00333379
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

		// Token: 0x0601636C RID: 90988 RVA: 0x003351AD File Offset: 0x003333AD
		public static void StartIEntityDeadPosition(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0601636D RID: 90989 RVA: 0x003351B6 File Offset: 0x003333B6
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(0, entityId, 0);
		}

		// Token: 0x0601636E RID: 90990 RVA: 0x003351C1 File Offset: 0x003333C1
		public static void AddVarType(FlatBufferBuilder builder, TVarRef varType)
		{
			builder.AddByte(1, (byte)varType, 0);
		}

		// Token: 0x0601636F RID: 90991 RVA: 0x003351CC File Offset: 0x003333CC
		public static void AddVar(FlatBufferBuilder builder, int varOffset)
		{
			builder.AddOffset(2, varOffset, 0);
		}

		// Token: 0x06016370 RID: 90992 RVA: 0x003351D7 File Offset: 0x003333D7
		public static void AddIsIgnoreRot(FlatBufferBuilder builder, bool isIgnoreRot)
		{
			builder.AddBool(3, isIgnoreRot, false);
		}

		// Token: 0x06016371 RID: 90993 RVA: 0x003351E2 File Offset: 0x003333E2
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x06016372 RID: 90994 RVA: 0x003351ED File Offset: 0x003333ED
		public static Offset<IEntityDeadPosition> EndIEntityDeadPosition(FlatBufferBuilder builder)
		{
			return new Offset<IEntityDeadPosition>(builder.EndTable());
		}

		// Token: 0x06016373 RID: 90995 RVA: 0x003351FC File Offset: 0x003333FC
		public IEntityDeadPositionT UnPack()
		{
			IEntityDeadPositionT entityDeadPositionT = new IEntityDeadPositionT();
			this.UnPackTo(entityDeadPositionT);
			return entityDeadPositionT;
		}

		// Token: 0x06016374 RID: 90996 RVA: 0x00335218 File Offset: 0x00333418
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

		// Token: 0x06016375 RID: 90997 RVA: 0x003353AC File Offset: 0x003335AC
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

		// Token: 0x0400B775 RID: 46965
		private Table __p;
	}
}
