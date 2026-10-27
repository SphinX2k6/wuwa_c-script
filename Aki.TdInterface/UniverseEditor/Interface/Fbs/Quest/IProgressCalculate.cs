using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003FC2 RID: 16322
	public struct IProgressCalculate : IFlatbufferObject
	{
		// Token: 0x170071F8 RID: 29176
		// (get) Token: 0x06017568 RID: 95592 RVA: 0x0035D150 File Offset: 0x0035B350
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06017569 RID: 95593 RVA: 0x0035D15D File Offset: 0x0035B35D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601756A RID: 95594 RVA: 0x0035D164 File Offset: 0x0035B364
		public static IProgressCalculate GetRootAsIProgressCalculate(ByteBuffer _bb)
		{
			return IProgressCalculate.GetRootAsIProgressCalculate(_bb, default(IProgressCalculate));
		}

		// Token: 0x0601756B RID: 95595 RVA: 0x0035D180 File Offset: 0x0035B380
		public static IProgressCalculate GetRootAsIProgressCalculate(ByteBuffer _bb, IProgressCalculate obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601756C RID: 95596 RVA: 0x0035D19D File Offset: 0x0035B39D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601756D RID: 95597 RVA: 0x0035D1AC File Offset: 0x0035B3AC
		public IProgressCalculate __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170071F9 RID: 29177
		// (get) Token: 0x0601756E RID: 95598 RVA: 0x0035D1BC File Offset: 0x0035B3BC
		public TProgressBarLeftType VarLeftType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return TProgressBarLeftType.NONE;
				}
				return (TProgressBarLeftType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601756F RID: 95599 RVA: 0x0035D1F8 File Offset: 0x0035B3F8
		public TTable? VarLeft<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06017570 RID: 95600 RVA: 0x0035D23C File Offset: 0x0035B43C
		public IUseCount VarLeftAsIUseCount()
		{
			return this.VarLeft<IUseCount>().Value;
		}

		// Token: 0x06017571 RID: 95601 RVA: 0x0035D258 File Offset: 0x0035B458
		public IUseVar VarLeftAsIUseVar()
		{
			return this.VarLeft<IUseVar>().Value;
		}

		// Token: 0x170071FA RID: 29178
		// (get) Token: 0x06017572 RID: 95602 RVA: 0x0035D274 File Offset: 0x0035B474
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

		// Token: 0x06017573 RID: 95603 RVA: 0x0035D2B0 File Offset: 0x0035B4B0
		public TTable? VarRight<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06017574 RID: 95604 RVA: 0x0035D2F8 File Offset: 0x0035B4F8
		public IConstVarRef VarRightAsIConstVarRef()
		{
			return this.VarRight<IConstVarRef>().Value;
		}

		// Token: 0x06017575 RID: 95605 RVA: 0x0035D314 File Offset: 0x0035B514
		public IGlobalVarRef VarRightAsIGlobalVarRef()
		{
			return this.VarRight<IGlobalVarRef>().Value;
		}

		// Token: 0x06017576 RID: 95606 RVA: 0x0035D330 File Offset: 0x0035B530
		public IOtherVarRef VarRightAsIOtherVarRef()
		{
			return this.VarRight<IOtherVarRef>().Value;
		}

		// Token: 0x06017577 RID: 95607 RVA: 0x0035D34C File Offset: 0x0035B54C
		public ISelfVarRef VarRightAsISelfVarRef()
		{
			return this.VarRight<ISelfVarRef>().Value;
		}

		// Token: 0x06017578 RID: 95608 RVA: 0x0035D368 File Offset: 0x0035B568
		public ISystemVarRef VarRightAsISystemVarRef()
		{
			return this.VarRight<ISystemVarRef>().Value;
		}

		// Token: 0x06017579 RID: 95609 RVA: 0x0035D383 File Offset: 0x0035B583
		public static Offset<IProgressCalculate> CreateIProgressCalculate(FlatBufferBuilder builder, TProgressBarLeftType VarLeft_type = TProgressBarLeftType.NONE, int VarLeftOffset = 0, TVarRef VarRight_type = TVarRef.NONE, int VarRightOffset = 0)
		{
			builder.StartTable(4);
			IProgressCalculate.AddVarRight(builder, VarRightOffset);
			IProgressCalculate.AddVarLeft(builder, VarLeftOffset);
			IProgressCalculate.AddVarRightType(builder, VarRight_type);
			IProgressCalculate.AddVarLeftType(builder, VarLeft_type);
			return IProgressCalculate.EndIProgressCalculate(builder);
		}

		// Token: 0x0601757A RID: 95610 RVA: 0x0035D3AF File Offset: 0x0035B5AF
		public static void StartIProgressCalculate(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601757B RID: 95611 RVA: 0x0035D3B8 File Offset: 0x0035B5B8
		public static void AddVarLeftType(FlatBufferBuilder builder, TProgressBarLeftType varLeftType)
		{
			builder.AddByte(0, (byte)varLeftType, 0);
		}

		// Token: 0x0601757C RID: 95612 RVA: 0x0035D3C3 File Offset: 0x0035B5C3
		public static void AddVarLeft(FlatBufferBuilder builder, int varLeftOffset)
		{
			builder.AddOffset(1, varLeftOffset, 0);
		}

		// Token: 0x0601757D RID: 95613 RVA: 0x0035D3CE File Offset: 0x0035B5CE
		public static void AddVarRightType(FlatBufferBuilder builder, TVarRef varRightType)
		{
			builder.AddByte(2, (byte)varRightType, 0);
		}

		// Token: 0x0601757E RID: 95614 RVA: 0x0035D3D9 File Offset: 0x0035B5D9
		public static void AddVarRight(FlatBufferBuilder builder, int varRightOffset)
		{
			builder.AddOffset(3, varRightOffset, 0);
		}

		// Token: 0x0601757F RID: 95615 RVA: 0x0035D3E4 File Offset: 0x0035B5E4
		public static Offset<IProgressCalculate> EndIProgressCalculate(FlatBufferBuilder builder)
		{
			return new Offset<IProgressCalculate>(builder.EndTable());
		}

		// Token: 0x06017580 RID: 95616 RVA: 0x0035D3F4 File Offset: 0x0035B5F4
		public IProgressCalculateT UnPack()
		{
			IProgressCalculateT progressCalculateT = new IProgressCalculateT();
			this.UnPackTo(progressCalculateT);
			return progressCalculateT;
		}

		// Token: 0x06017581 RID: 95617 RVA: 0x0035D410 File Offset: 0x0035B610
		public void UnPackTo(IProgressCalculateT _o)
		{
			_o.VarLeft = new TProgressBarLeftTypeUnion();
			_o.VarLeft.Type = this.VarLeftType;
			TProgressBarLeftType varLeftType = this.VarLeftType;
			if (varLeftType != TProgressBarLeftType.IUseCount)
			{
				if (varLeftType == TProgressBarLeftType.IUseVar)
				{
					_o.VarLeft.Value = ((this.VarLeft<IUseVar>() != null) ? this.VarLeft<IUseVar>().Value.UnPack() : null);
				}
			}
			else
			{
				_o.VarLeft.Value = ((this.VarLeft<IUseCount>() != null) ? this.VarLeft<IUseCount>().Value.UnPack() : null);
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

		// Token: 0x06017582 RID: 95618 RVA: 0x0035D610 File Offset: 0x0035B810
		public static Offset<IProgressCalculate> Pack(FlatBufferBuilder builder, IProgressCalculateT _o)
		{
			if (_o == null)
			{
				return default(Offset<IProgressCalculate>);
			}
			TProgressBarLeftType varLeft_type = (_o.VarLeft == null) ? TProgressBarLeftType.NONE : _o.VarLeft.Type;
			int varLeftOffset = (_o.VarLeft == null) ? 0 : TProgressBarLeftTypeUnion.Pack(builder, _o.VarLeft);
			TVarRef varRight_type = (_o.VarRight == null) ? TVarRef.NONE : _o.VarRight.Type;
			int varRightOffset = (_o.VarRight == null) ? 0 : TVarRefUnion.Pack(builder, _o.VarRight);
			return IProgressCalculate.CreateIProgressCalculate(builder, varLeft_type, varLeftOffset, varRight_type, varRightOffset);
		}

		// Token: 0x0400BA32 RID: 47666
		private Table __p;
	}
}
