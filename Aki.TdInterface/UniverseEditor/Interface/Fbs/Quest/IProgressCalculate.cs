using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004403 RID: 17411
	public struct IProgressCalculate : IFlatbufferObject
	{
		// Token: 0x170077F6 RID: 30710
		// (get) Token: 0x06018BF7 RID: 101367 RVA: 0x00386D68 File Offset: 0x00384F68
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06018BF8 RID: 101368 RVA: 0x00386D75 File Offset: 0x00384F75
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06018BF9 RID: 101369 RVA: 0x00386D7C File Offset: 0x00384F7C
		public static IProgressCalculate GetRootAsIProgressCalculate(ByteBuffer _bb)
		{
			return IProgressCalculate.GetRootAsIProgressCalculate(_bb, default(IProgressCalculate));
		}

		// Token: 0x06018BFA RID: 101370 RVA: 0x00386D98 File Offset: 0x00384F98
		public static IProgressCalculate GetRootAsIProgressCalculate(ByteBuffer _bb, IProgressCalculate obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06018BFB RID: 101371 RVA: 0x00386DB5 File Offset: 0x00384FB5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06018BFC RID: 101372 RVA: 0x00386DC4 File Offset: 0x00384FC4
		public IProgressCalculate __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170077F7 RID: 30711
		// (get) Token: 0x06018BFD RID: 101373 RVA: 0x00386DD4 File Offset: 0x00384FD4
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

		// Token: 0x06018BFE RID: 101374 RVA: 0x00386E10 File Offset: 0x00385010
		public TTable? VarLeft<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06018BFF RID: 101375 RVA: 0x00386E54 File Offset: 0x00385054
		public IUseCount VarLeftAsIUseCount()
		{
			return this.VarLeft<IUseCount>().Value;
		}

		// Token: 0x06018C00 RID: 101376 RVA: 0x00386E70 File Offset: 0x00385070
		public IUseVar VarLeftAsIUseVar()
		{
			return this.VarLeft<IUseVar>().Value;
		}

		// Token: 0x170077F8 RID: 30712
		// (get) Token: 0x06018C01 RID: 101377 RVA: 0x00386E8C File Offset: 0x0038508C
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

		// Token: 0x06018C02 RID: 101378 RVA: 0x00386EC8 File Offset: 0x003850C8
		public TTable? VarRight<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06018C03 RID: 101379 RVA: 0x00386F10 File Offset: 0x00385110
		public IConstVarRef VarRightAsIConstVarRef()
		{
			return this.VarRight<IConstVarRef>().Value;
		}

		// Token: 0x06018C04 RID: 101380 RVA: 0x00386F2C File Offset: 0x0038512C
		public IGlobalVarRef VarRightAsIGlobalVarRef()
		{
			return this.VarRight<IGlobalVarRef>().Value;
		}

		// Token: 0x06018C05 RID: 101381 RVA: 0x00386F48 File Offset: 0x00385148
		public IOtherVarRef VarRightAsIOtherVarRef()
		{
			return this.VarRight<IOtherVarRef>().Value;
		}

		// Token: 0x06018C06 RID: 101382 RVA: 0x00386F64 File Offset: 0x00385164
		public ISelfVarRef VarRightAsISelfVarRef()
		{
			return this.VarRight<ISelfVarRef>().Value;
		}

		// Token: 0x06018C07 RID: 101383 RVA: 0x00386F80 File Offset: 0x00385180
		public ISystemVarRef VarRightAsISystemVarRef()
		{
			return this.VarRight<ISystemVarRef>().Value;
		}

		// Token: 0x06018C08 RID: 101384 RVA: 0x00386F9B File Offset: 0x0038519B
		public static Offset<IProgressCalculate> CreateIProgressCalculate(FlatBufferBuilder builder, TProgressBarLeftType VarLeft_type = TProgressBarLeftType.NONE, int VarLeftOffset = 0, TVarRef VarRight_type = TVarRef.NONE, int VarRightOffset = 0)
		{
			builder.StartTable(4);
			IProgressCalculate.AddVarRight(builder, VarRightOffset);
			IProgressCalculate.AddVarLeft(builder, VarLeftOffset);
			IProgressCalculate.AddVarRightType(builder, VarRight_type);
			IProgressCalculate.AddVarLeftType(builder, VarLeft_type);
			return IProgressCalculate.EndIProgressCalculate(builder);
		}

		// Token: 0x06018C09 RID: 101385 RVA: 0x00386FC7 File Offset: 0x003851C7
		public static void StartIProgressCalculate(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06018C0A RID: 101386 RVA: 0x00386FD0 File Offset: 0x003851D0
		public static void AddVarLeftType(FlatBufferBuilder builder, TProgressBarLeftType varLeftType)
		{
			builder.AddByte(0, (byte)varLeftType, 0);
		}

		// Token: 0x06018C0B RID: 101387 RVA: 0x00386FDB File Offset: 0x003851DB
		public static void AddVarLeft(FlatBufferBuilder builder, int varLeftOffset)
		{
			builder.AddOffset(1, varLeftOffset, 0);
		}

		// Token: 0x06018C0C RID: 101388 RVA: 0x00386FE6 File Offset: 0x003851E6
		public static void AddVarRightType(FlatBufferBuilder builder, TVarRef varRightType)
		{
			builder.AddByte(2, (byte)varRightType, 0);
		}

		// Token: 0x06018C0D RID: 101389 RVA: 0x00386FF1 File Offset: 0x003851F1
		public static void AddVarRight(FlatBufferBuilder builder, int varRightOffset)
		{
			builder.AddOffset(3, varRightOffset, 0);
		}

		// Token: 0x06018C0E RID: 101390 RVA: 0x00386FFC File Offset: 0x003851FC
		public static Offset<IProgressCalculate> EndIProgressCalculate(FlatBufferBuilder builder)
		{
			return new Offset<IProgressCalculate>(builder.EndTable());
		}

		// Token: 0x06018C0F RID: 101391 RVA: 0x0038700C File Offset: 0x0038520C
		public IProgressCalculateT UnPack()
		{
			IProgressCalculateT progressCalculateT = new IProgressCalculateT();
			this.UnPackTo(progressCalculateT);
			return progressCalculateT;
		}

		// Token: 0x06018C10 RID: 101392 RVA: 0x00387028 File Offset: 0x00385228
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

		// Token: 0x06018C11 RID: 101393 RVA: 0x00387228 File Offset: 0x00385428
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

		// Token: 0x0400C417 RID: 50199
		private Table __p;
	}
}
