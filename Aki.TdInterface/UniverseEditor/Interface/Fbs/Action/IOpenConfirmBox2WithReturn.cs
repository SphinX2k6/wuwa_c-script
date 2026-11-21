using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007358 RID: 29528
	public struct IOpenConfirmBox2WithReturn : IFlatbufferObject
	{
		// Token: 0x1700D88A RID: 55434
		// (get) Token: 0x06033848 RID: 211016 RVA: 0x006F167E File Offset: 0x006EF87E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06033849 RID: 211017 RVA: 0x006F168B File Offset: 0x006EF88B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603384A RID: 211018 RVA: 0x006F1694 File Offset: 0x006EF894
		public static IOpenConfirmBox2WithReturn GetRootAsIOpenConfirmBox2WithReturn(ByteBuffer _bb)
		{
			return IOpenConfirmBox2WithReturn.GetRootAsIOpenConfirmBox2WithReturn(_bb, default(IOpenConfirmBox2WithReturn));
		}

		// Token: 0x0603384B RID: 211019 RVA: 0x006F16B0 File Offset: 0x006EF8B0
		public static IOpenConfirmBox2WithReturn GetRootAsIOpenConfirmBox2WithReturn(ByteBuffer _bb, IOpenConfirmBox2WithReturn obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603384C RID: 211020 RVA: 0x006F16CD File Offset: 0x006EF8CD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603384D RID: 211021 RVA: 0x006F16DC File Offset: 0x006EF8DC
		public IOpenConfirmBox2WithReturn __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D88B RID: 55435
		// (get) Token: 0x0603384E RID: 211022 RVA: 0x006F16EC File Offset: 0x006EF8EC
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

		// Token: 0x1700D88C RID: 55436
		// (get) Token: 0x0603384F RID: 211023 RVA: 0x006F1728 File Offset: 0x006EF928
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

		// Token: 0x1700D88D RID: 55437
		// (get) Token: 0x06033850 RID: 211024 RVA: 0x006F1764 File Offset: 0x006EF964
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

		// Token: 0x06033851 RID: 211025 RVA: 0x006F17A0 File Offset: 0x006EF9A0
		public TTable? ReturnVar<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06033852 RID: 211026 RVA: 0x006F17E8 File Offset: 0x006EF9E8
		public IConstVarRef ReturnVarAsIConstVarRef()
		{
			return this.ReturnVar<IConstVarRef>().Value;
		}

		// Token: 0x06033853 RID: 211027 RVA: 0x006F1804 File Offset: 0x006EFA04
		public IGlobalVarRef ReturnVarAsIGlobalVarRef()
		{
			return this.ReturnVar<IGlobalVarRef>().Value;
		}

		// Token: 0x06033854 RID: 211028 RVA: 0x006F1820 File Offset: 0x006EFA20
		public IOtherVarRef ReturnVarAsIOtherVarRef()
		{
			return this.ReturnVar<IOtherVarRef>().Value;
		}

		// Token: 0x06033855 RID: 211029 RVA: 0x006F183C File Offset: 0x006EFA3C
		public ISelfVarRef ReturnVarAsISelfVarRef()
		{
			return this.ReturnVar<ISelfVarRef>().Value;
		}

		// Token: 0x06033856 RID: 211030 RVA: 0x006F1858 File Offset: 0x006EFA58
		public ISystemVarRef ReturnVarAsISystemVarRef()
		{
			return this.ReturnVar<ISystemVarRef>().Value;
		}

		// Token: 0x06033857 RID: 211031 RVA: 0x006F1873 File Offset: 0x006EFA73
		public static Offset<IOpenConfirmBox2WithReturn> CreateIOpenConfirmBox2WithReturn(FlatBufferBuilder builder, ESystemType Type = ESystemType.Shop, int Id = 0, TVarRef ReturnVar_type = TVarRef.NONE, int ReturnVarOffset = 0)
		{
			builder.StartTable(4);
			IOpenConfirmBox2WithReturn.AddReturnVar(builder, ReturnVarOffset);
			IOpenConfirmBox2WithReturn.AddId(builder, Id);
			IOpenConfirmBox2WithReturn.AddReturnVarType(builder, ReturnVar_type);
			IOpenConfirmBox2WithReturn.AddType(builder, Type);
			return IOpenConfirmBox2WithReturn.EndIOpenConfirmBox2WithReturn(builder);
		}

		// Token: 0x06033858 RID: 211032 RVA: 0x006F189F File Offset: 0x006EFA9F
		public static void StartIOpenConfirmBox2WithReturn(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06033859 RID: 211033 RVA: 0x006F18A8 File Offset: 0x006EFAA8
		public static void AddType(FlatBufferBuilder builder, ESystemType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603385A RID: 211034 RVA: 0x006F18B3 File Offset: 0x006EFAB3
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x0603385B RID: 211035 RVA: 0x006F18BE File Offset: 0x006EFABE
		public static void AddReturnVarType(FlatBufferBuilder builder, TVarRef returnVarType)
		{
			builder.AddByte(2, (byte)returnVarType, 0);
		}

		// Token: 0x0603385C RID: 211036 RVA: 0x006F18C9 File Offset: 0x006EFAC9
		public static void AddReturnVar(FlatBufferBuilder builder, int returnVarOffset)
		{
			builder.AddOffset(3, returnVarOffset, 0);
		}

		// Token: 0x0603385D RID: 211037 RVA: 0x006F18D4 File Offset: 0x006EFAD4
		public static Offset<IOpenConfirmBox2WithReturn> EndIOpenConfirmBox2WithReturn(FlatBufferBuilder builder)
		{
			return new Offset<IOpenConfirmBox2WithReturn>(builder.EndTable());
		}

		// Token: 0x0603385E RID: 211038 RVA: 0x006F18E4 File Offset: 0x006EFAE4
		public IOpenConfirmBox2WithReturnT UnPack()
		{
			IOpenConfirmBox2WithReturnT openConfirmBox2WithReturnT = new IOpenConfirmBox2WithReturnT();
			this.UnPackTo(openConfirmBox2WithReturnT);
			return openConfirmBox2WithReturnT;
		}

		// Token: 0x0603385F RID: 211039 RVA: 0x006F1900 File Offset: 0x006EFB00
		public void UnPackTo(IOpenConfirmBox2WithReturnT _o)
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

		// Token: 0x06033860 RID: 211040 RVA: 0x006F1A78 File Offset: 0x006EFC78
		public static Offset<IOpenConfirmBox2WithReturn> Pack(FlatBufferBuilder builder, IOpenConfirmBox2WithReturnT _o)
		{
			if (_o == null)
			{
				return default(Offset<IOpenConfirmBox2WithReturn>);
			}
			TVarRef returnVar_type = (_o.ReturnVar == null) ? TVarRef.NONE : _o.ReturnVar.Type;
			int returnVarOffset = (_o.ReturnVar == null) ? 0 : TVarRefUnion.Pack(builder, _o.ReturnVar);
			return IOpenConfirmBox2WithReturn.CreateIOpenConfirmBox2WithReturn(builder, _o.Type, _o.Id, returnVar_type, returnVarOffset);
		}

		// Token: 0x0401243C RID: 74812
		private Table __p;
	}
}
