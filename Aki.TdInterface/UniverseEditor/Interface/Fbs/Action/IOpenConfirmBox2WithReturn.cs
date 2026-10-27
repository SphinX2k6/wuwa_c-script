using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006BF4 RID: 27636
	public struct IOpenConfirmBox2WithReturn : IFlatbufferObject
	{
		// Token: 0x1700CD7C RID: 52604
		// (get) Token: 0x06030928 RID: 198952 RVA: 0x00697CEB File Offset: 0x00695EEB
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06030929 RID: 198953 RVA: 0x00697CF8 File Offset: 0x00695EF8
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603092A RID: 198954 RVA: 0x00697D00 File Offset: 0x00695F00
		public static IOpenConfirmBox2WithReturn GetRootAsIOpenConfirmBox2WithReturn(ByteBuffer _bb)
		{
			return IOpenConfirmBox2WithReturn.GetRootAsIOpenConfirmBox2WithReturn(_bb, default(IOpenConfirmBox2WithReturn));
		}

		// Token: 0x0603092B RID: 198955 RVA: 0x00697D1C File Offset: 0x00695F1C
		public static IOpenConfirmBox2WithReturn GetRootAsIOpenConfirmBox2WithReturn(ByteBuffer _bb, IOpenConfirmBox2WithReturn obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603092C RID: 198956 RVA: 0x00697D39 File Offset: 0x00695F39
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603092D RID: 198957 RVA: 0x00697D48 File Offset: 0x00695F48
		public IOpenConfirmBox2WithReturn __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CD7D RID: 52605
		// (get) Token: 0x0603092E RID: 198958 RVA: 0x00697D58 File Offset: 0x00695F58
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

		// Token: 0x1700CD7E RID: 52606
		// (get) Token: 0x0603092F RID: 198959 RVA: 0x00697D94 File Offset: 0x00695F94
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

		// Token: 0x1700CD7F RID: 52607
		// (get) Token: 0x06030930 RID: 198960 RVA: 0x00697DD0 File Offset: 0x00695FD0
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

		// Token: 0x06030931 RID: 198961 RVA: 0x00697E0C File Offset: 0x0069600C
		public TTable? ReturnVar<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06030932 RID: 198962 RVA: 0x00697E54 File Offset: 0x00696054
		public IConstVarRef ReturnVarAsIConstVarRef()
		{
			return this.ReturnVar<IConstVarRef>().Value;
		}

		// Token: 0x06030933 RID: 198963 RVA: 0x00697E70 File Offset: 0x00696070
		public IGlobalVarRef ReturnVarAsIGlobalVarRef()
		{
			return this.ReturnVar<IGlobalVarRef>().Value;
		}

		// Token: 0x06030934 RID: 198964 RVA: 0x00697E8C File Offset: 0x0069608C
		public IOtherVarRef ReturnVarAsIOtherVarRef()
		{
			return this.ReturnVar<IOtherVarRef>().Value;
		}

		// Token: 0x06030935 RID: 198965 RVA: 0x00697EA8 File Offset: 0x006960A8
		public ISelfVarRef ReturnVarAsISelfVarRef()
		{
			return this.ReturnVar<ISelfVarRef>().Value;
		}

		// Token: 0x06030936 RID: 198966 RVA: 0x00697EC4 File Offset: 0x006960C4
		public ISystemVarRef ReturnVarAsISystemVarRef()
		{
			return this.ReturnVar<ISystemVarRef>().Value;
		}

		// Token: 0x06030937 RID: 198967 RVA: 0x00697EDF File Offset: 0x006960DF
		public static Offset<IOpenConfirmBox2WithReturn> CreateIOpenConfirmBox2WithReturn(FlatBufferBuilder builder, ESystemType Type = ESystemType.Shop, int Id = 0, TVarRef ReturnVar_type = TVarRef.NONE, int ReturnVarOffset = 0)
		{
			builder.StartTable(4);
			IOpenConfirmBox2WithReturn.AddReturnVar(builder, ReturnVarOffset);
			IOpenConfirmBox2WithReturn.AddId(builder, Id);
			IOpenConfirmBox2WithReturn.AddReturnVarType(builder, ReturnVar_type);
			IOpenConfirmBox2WithReturn.AddType(builder, Type);
			return IOpenConfirmBox2WithReturn.EndIOpenConfirmBox2WithReturn(builder);
		}

		// Token: 0x06030938 RID: 198968 RVA: 0x00697F0B File Offset: 0x0069610B
		public static void StartIOpenConfirmBox2WithReturn(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06030939 RID: 198969 RVA: 0x00697F14 File Offset: 0x00696114
		public static void AddType(FlatBufferBuilder builder, ESystemType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603093A RID: 198970 RVA: 0x00697F1F File Offset: 0x0069611F
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x0603093B RID: 198971 RVA: 0x00697F2A File Offset: 0x0069612A
		public static void AddReturnVarType(FlatBufferBuilder builder, TVarRef returnVarType)
		{
			builder.AddByte(2, (byte)returnVarType, 0);
		}

		// Token: 0x0603093C RID: 198972 RVA: 0x00697F35 File Offset: 0x00696135
		public static void AddReturnVar(FlatBufferBuilder builder, int returnVarOffset)
		{
			builder.AddOffset(3, returnVarOffset, 0);
		}

		// Token: 0x0603093D RID: 198973 RVA: 0x00697F40 File Offset: 0x00696140
		public static Offset<IOpenConfirmBox2WithReturn> EndIOpenConfirmBox2WithReturn(FlatBufferBuilder builder)
		{
			return new Offset<IOpenConfirmBox2WithReturn>(builder.EndTable());
		}

		// Token: 0x0603093E RID: 198974 RVA: 0x00697F50 File Offset: 0x00696150
		public IOpenConfirmBox2WithReturnT UnPack()
		{
			IOpenConfirmBox2WithReturnT openConfirmBox2WithReturnT = new IOpenConfirmBox2WithReturnT();
			this.UnPackTo(openConfirmBox2WithReturnT);
			return openConfirmBox2WithReturnT;
		}

		// Token: 0x0603093F RID: 198975 RVA: 0x00697F6C File Offset: 0x0069616C
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

		// Token: 0x06030940 RID: 198976 RVA: 0x006980E4 File Offset: 0x006962E4
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

		// Token: 0x040114EC RID: 70892
		private Table __p;
	}
}
