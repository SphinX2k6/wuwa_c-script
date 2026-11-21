using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200786F RID: 30831
	public struct ISetVar : IFlatbufferObject
	{
		// Token: 0x1700E21C RID: 57884
		// (get) Token: 0x0603638D RID: 222093 RVA: 0x00743446 File Offset: 0x00741646
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603638E RID: 222094 RVA: 0x00743453 File Offset: 0x00741653
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603638F RID: 222095 RVA: 0x0074345C File Offset: 0x0074165C
		public static ISetVar GetRootAsISetVar(ByteBuffer _bb)
		{
			return ISetVar.GetRootAsISetVar(_bb, default(ISetVar));
		}

		// Token: 0x06036390 RID: 222096 RVA: 0x00743478 File Offset: 0x00741678
		public static ISetVar GetRootAsISetVar(ByteBuffer _bb, ISetVar obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06036391 RID: 222097 RVA: 0x00743495 File Offset: 0x00741695
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06036392 RID: 222098 RVA: 0x007434A4 File Offset: 0x007416A4
		public ISetVar __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E21D RID: 57885
		// (get) Token: 0x06036393 RID: 222099 RVA: 0x007434B4 File Offset: 0x007416B4
		public TVarRef VarLeftType
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

		// Token: 0x06036394 RID: 222100 RVA: 0x007434F0 File Offset: 0x007416F0
		public TTable? VarLeft<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06036395 RID: 222101 RVA: 0x00743534 File Offset: 0x00741734
		public IConstVarRef VarLeftAsIConstVarRef()
		{
			return this.VarLeft<IConstVarRef>().Value;
		}

		// Token: 0x06036396 RID: 222102 RVA: 0x00743550 File Offset: 0x00741750
		public IGlobalVarRef VarLeftAsIGlobalVarRef()
		{
			return this.VarLeft<IGlobalVarRef>().Value;
		}

		// Token: 0x06036397 RID: 222103 RVA: 0x0074356C File Offset: 0x0074176C
		public IOtherVarRef VarLeftAsIOtherVarRef()
		{
			return this.VarLeft<IOtherVarRef>().Value;
		}

		// Token: 0x06036398 RID: 222104 RVA: 0x00743588 File Offset: 0x00741788
		public ISelfVarRef VarLeftAsISelfVarRef()
		{
			return this.VarLeft<ISelfVarRef>().Value;
		}

		// Token: 0x06036399 RID: 222105 RVA: 0x007435A4 File Offset: 0x007417A4
		public ISystemVarRef VarLeftAsISystemVarRef()
		{
			return this.VarLeft<ISystemVarRef>().Value;
		}

		// Token: 0x1700E21E RID: 57886
		// (get) Token: 0x0603639A RID: 222106 RVA: 0x007435C0 File Offset: 0x007417C0
		public TVarRef VarRightType
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

		// Token: 0x0603639B RID: 222107 RVA: 0x007435FC File Offset: 0x007417FC
		public TTable? VarRight<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0603639C RID: 222108 RVA: 0x00743644 File Offset: 0x00741844
		public IConstVarRef VarRightAsIConstVarRef()
		{
			return this.VarRight<IConstVarRef>().Value;
		}

		// Token: 0x0603639D RID: 222109 RVA: 0x00743660 File Offset: 0x00741860
		public IGlobalVarRef VarRightAsIGlobalVarRef()
		{
			return this.VarRight<IGlobalVarRef>().Value;
		}

		// Token: 0x0603639E RID: 222110 RVA: 0x0074367C File Offset: 0x0074187C
		public IOtherVarRef VarRightAsIOtherVarRef()
		{
			return this.VarRight<IOtherVarRef>().Value;
		}

		// Token: 0x0603639F RID: 222111 RVA: 0x00743698 File Offset: 0x00741898
		public ISelfVarRef VarRightAsISelfVarRef()
		{
			return this.VarRight<ISelfVarRef>().Value;
		}

		// Token: 0x060363A0 RID: 222112 RVA: 0x007436B4 File Offset: 0x007418B4
		public ISystemVarRef VarRightAsISystemVarRef()
		{
			return this.VarRight<ISystemVarRef>().Value;
		}

		// Token: 0x060363A1 RID: 222113 RVA: 0x007436CF File Offset: 0x007418CF
		public static Offset<ISetVar> CreateISetVar(FlatBufferBuilder builder, TVarRef VarLeft_type = TVarRef.NONE, int VarLeftOffset = 0, TVarRef VarRight_type = TVarRef.NONE, int VarRightOffset = 0)
		{
			builder.StartTable(4);
			ISetVar.AddVarRight(builder, VarRightOffset);
			ISetVar.AddVarLeft(builder, VarLeftOffset);
			ISetVar.AddVarRightType(builder, VarRight_type);
			ISetVar.AddVarLeftType(builder, VarLeft_type);
			return ISetVar.EndISetVar(builder);
		}

		// Token: 0x060363A2 RID: 222114 RVA: 0x007436FB File Offset: 0x007418FB
		public static void StartISetVar(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x060363A3 RID: 222115 RVA: 0x00743704 File Offset: 0x00741904
		public static void AddVarLeftType(FlatBufferBuilder builder, TVarRef varLeftType)
		{
			builder.AddByte(0, (byte)varLeftType, 0);
		}

		// Token: 0x060363A4 RID: 222116 RVA: 0x0074370F File Offset: 0x0074190F
		public static void AddVarLeft(FlatBufferBuilder builder, int varLeftOffset)
		{
			builder.AddOffset(1, varLeftOffset, 0);
		}

		// Token: 0x060363A5 RID: 222117 RVA: 0x0074371A File Offset: 0x0074191A
		public static void AddVarRightType(FlatBufferBuilder builder, TVarRef varRightType)
		{
			builder.AddByte(2, (byte)varRightType, 0);
		}

		// Token: 0x060363A6 RID: 222118 RVA: 0x00743725 File Offset: 0x00741925
		public static void AddVarRight(FlatBufferBuilder builder, int varRightOffset)
		{
			builder.AddOffset(3, varRightOffset, 0);
		}

		// Token: 0x060363A7 RID: 222119 RVA: 0x00743730 File Offset: 0x00741930
		public static Offset<ISetVar> EndISetVar(FlatBufferBuilder builder)
		{
			return new Offset<ISetVar>(builder.EndTable());
		}

		// Token: 0x060363A8 RID: 222120 RVA: 0x00743740 File Offset: 0x00741940
		public ISetVarT UnPack()
		{
			ISetVarT setVarT = new ISetVarT();
			this.UnPackTo(setVarT);
			return setVarT;
		}

		// Token: 0x060363A9 RID: 222121 RVA: 0x0074375C File Offset: 0x0074195C
		public void UnPackTo(ISetVarT _o)
		{
			_o.VarLeft = new TVarRefUnion();
			_o.VarLeft.Type = this.VarLeftType;
			switch (this.VarLeftType)
			{
			case TVarRef.IConstVarRef:
				_o.VarLeft.Value = ((this.VarLeft<IConstVarRef>() != null) ? this.VarLeft<IConstVarRef>().Value.UnPack() : null);
				break;
			case TVarRef.IGlobalVarRef:
				_o.VarLeft.Value = ((this.VarLeft<IGlobalVarRef>() != null) ? this.VarLeft<IGlobalVarRef>().Value.UnPack() : null);
				break;
			case TVarRef.IOtherVarRef:
				_o.VarLeft.Value = ((this.VarLeft<IOtherVarRef>() != null) ? this.VarLeft<IOtherVarRef>().Value.UnPack() : null);
				break;
			case TVarRef.ISelfVarRef:
				_o.VarLeft.Value = ((this.VarLeft<ISelfVarRef>() != null) ? this.VarLeft<ISelfVarRef>().Value.UnPack() : null);
				break;
			case TVarRef.ISystemVarRef:
				_o.VarLeft.Value = ((this.VarLeft<ISystemVarRef>() != null) ? this.VarLeft<ISystemVarRef>().Value.UnPack() : null);
				break;
			}
			_o.VarRight = new TVarRefUnion();
			_o.VarRight.Type = this.VarRightType;
			switch (this.VarRightType)
			{
			case TVarRef.IConstVarRef:
				_o.VarRight.Value = ((this.VarRight<IConstVarRef>() != null) ? this.VarRight<IConstVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.IGlobalVarRef:
				_o.VarRight.Value = ((this.VarRight<IGlobalVarRef>() != null) ? this.VarRight<IGlobalVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.IOtherVarRef:
				_o.VarRight.Value = ((this.VarRight<IOtherVarRef>() != null) ? this.VarRight<IOtherVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.ISelfVarRef:
				_o.VarRight.Value = ((this.VarRight<ISelfVarRef>() != null) ? this.VarRight<ISelfVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.ISystemVarRef:
				_o.VarRight.Value = ((this.VarRight<ISystemVarRef>() != null) ? this.VarRight<ISystemVarRef>().Value.UnPack() : null);
				return;
			default:
				return;
			}
		}

		// Token: 0x060363AA RID: 222122 RVA: 0x00743A1C File Offset: 0x00741C1C
		public static Offset<ISetVar> Pack(FlatBufferBuilder builder, ISetVarT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISetVar>);
			}
			TVarRef varLeft_type = (_o.VarLeft == null) ? TVarRef.NONE : _o.VarLeft.Type;
			int varLeftOffset = (_o.VarLeft == null) ? 0 : TVarRefUnion.Pack(builder, _o.VarLeft);
			TVarRef varRight_type = (_o.VarRight == null) ? TVarRef.NONE : _o.VarRight.Type;
			int varRightOffset = (_o.VarRight == null) ? 0 : TVarRefUnion.Pack(builder, _o.VarRight);
			return ISetVar.CreateISetVar(builder, varLeft_type, varLeftOffset, varRight_type, varRightOffset);
		}

		// Token: 0x04012AF9 RID: 76537
		private Table __p;
	}
}
