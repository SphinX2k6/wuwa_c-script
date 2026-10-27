using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200579F RID: 22431
	public struct IProgressBarControlComponent : IFlatbufferObject
	{
		// Token: 0x1700A75B RID: 42843
		// (get) Token: 0x060259ED RID: 154093 RVA: 0x005304D4 File Offset: 0x0052E6D4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060259EE RID: 154094 RVA: 0x005304E1 File Offset: 0x0052E6E1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060259EF RID: 154095 RVA: 0x005304E8 File Offset: 0x0052E6E8
		public static IProgressBarControlComponent GetRootAsIProgressBarControlComponent(ByteBuffer _bb)
		{
			return IProgressBarControlComponent.GetRootAsIProgressBarControlComponent(_bb, default(IProgressBarControlComponent));
		}

		// Token: 0x060259F0 RID: 154096 RVA: 0x00530504 File Offset: 0x0052E704
		public static IProgressBarControlComponent GetRootAsIProgressBarControlComponent(ByteBuffer _bb, IProgressBarControlComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060259F1 RID: 154097 RVA: 0x00530521 File Offset: 0x0052E721
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060259F2 RID: 154098 RVA: 0x00530530 File Offset: 0x0052E730
		public IProgressBarControlComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A75C RID: 42844
		// (get) Token: 0x060259F3 RID: 154099 RVA: 0x00530540 File Offset: 0x0052E740
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A75D RID: 42845
		// (get) Token: 0x060259F4 RID: 154100 RVA: 0x00530580 File Offset: 0x0052E780
		public THitBulletType HitBulletType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return THitBulletType.NONE;
				}
				return (THitBulletType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060259F5 RID: 154101 RVA: 0x005305BC File Offset: 0x0052E7BC
		public TTable? HitBullet<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060259F6 RID: 154102 RVA: 0x00530600 File Offset: 0x0052E800
		public IHitBulletTypeAllCharacterAttack HitBulletAsIHitBulletTypeAllCharacterAttack()
		{
			return this.HitBullet<IHitBulletTypeAllCharacterAttack>().Value;
		}

		// Token: 0x060259F7 RID: 154103 RVA: 0x0053061C File Offset: 0x0052E81C
		public IHitBulletTypeCrystalAttack HitBulletAsIHitBulletTypeCrystalAttack()
		{
			return this.HitBullet<IHitBulletTypeCrystalAttack>().Value;
		}

		// Token: 0x060259F8 RID: 154104 RVA: 0x00530638 File Offset: 0x0052E838
		public IHitBulletTypeFixedBulletId HitBulletAsIHitBulletTypeFixedBulletId()
		{
			return this.HitBullet<IHitBulletTypeFixedBulletId>().Value;
		}

		// Token: 0x060259F9 RID: 154105 RVA: 0x00530654 File Offset: 0x0052E854
		public IHitBulletTypeOnlyDropAttack HitBulletAsIHitBulletTypeOnlyDropAttack()
		{
			return this.HitBullet<IHitBulletTypeOnlyDropAttack>().Value;
		}

		// Token: 0x060259FA RID: 154106 RVA: 0x00530670 File Offset: 0x0052E870
		public IHitBulletTypePlayerAttack HitBulletAsIHitBulletTypePlayerAttack()
		{
			return this.HitBullet<IHitBulletTypePlayerAttack>().Value;
		}

		// Token: 0x060259FB RID: 154107 RVA: 0x0053068C File Offset: 0x0052E88C
		public IHitBulletTypePlayerOrThrenodianAttack HitBulletAsIHitBulletTypePlayerOrThrenodianAttack()
		{
			return this.HitBullet<IHitBulletTypePlayerOrThrenodianAttack>().Value;
		}

		// Token: 0x1700A75E RID: 42846
		// (get) Token: 0x060259FC RID: 154108 RVA: 0x005306A8 File Offset: 0x0052E8A8
		public IHitTimeScaleRatio? AttackerHitTimeScaleRatio
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new IHitTimeScaleRatio?(default(IHitTimeScaleRatio).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700A75F RID: 42847
		// (get) Token: 0x060259FD RID: 154109 RVA: 0x00530708 File Offset: 0x0052E908
		public IHitTimeScaleRatio? VictimHitTimeScaleRatio
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return new IHitTimeScaleRatio?(default(IHitTimeScaleRatio).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x060259FE RID: 154110 RVA: 0x00530768 File Offset: 0x0052E968
		public IAimPart? AimParts(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new IAimPart?(default(IAimPart).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A760 RID: 42848
		// (get) Token: 0x060259FF RID: 154111 RVA: 0x005307CC File Offset: 0x0052E9CC
		public int AimPartsLength
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700A761 RID: 42849
		// (get) Token: 0x06025A00 RID: 154112 RVA: 0x005307F8 File Offset: 0x0052E9F8
		public TProgressBarControl ControlType
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return TProgressBarControl.NONE;
				}
				return (TProgressBarControl)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06025A01 RID: 154113 RVA: 0x00530838 File Offset: 0x0052EA38
		public TTable? Control<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06025A02 RID: 154114 RVA: 0x00530880 File Offset: 0x0052EA80
		public ICaptureStrategicPoint ControlAsICaptureStrategicPoint()
		{
			return this.Control<ICaptureStrategicPoint>().Value;
		}

		// Token: 0x06025A03 RID: 154115 RVA: 0x0053089C File Offset: 0x0052EA9C
		public ICaptureStrategicPoint2 ControlAsICaptureStrategicPoint2()
		{
			return this.Control<ICaptureStrategicPoint2>().Value;
		}

		// Token: 0x06025A04 RID: 154116 RVA: 0x005308B8 File Offset: 0x0052EAB8
		public IChargingDevice ControlAsIChargingDevice()
		{
			return this.Control<IChargingDevice>().Value;
		}

		// Token: 0x06025A05 RID: 154117 RVA: 0x005308D4 File Offset: 0x0052EAD4
		public IMatchTargetChargingDevice ControlAsIMatchTargetChargingDevice()
		{
			return this.Control<IMatchTargetChargingDevice>().Value;
		}

		// Token: 0x06025A06 RID: 154118 RVA: 0x005308F0 File Offset: 0x0052EAF0
		public ITimedStrikeDevice ControlAsITimedStrikeDevice()
		{
			return this.Control<ITimedStrikeDevice>().Value;
		}

		// Token: 0x1700A762 RID: 42850
		// (get) Token: 0x06025A07 RID: 154119 RVA: 0x0053090C File Offset: 0x0052EB0C
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06025A08 RID: 154120 RVA: 0x0053094C File Offset: 0x0052EB4C
		public static Offset<IProgressBarControlComponent> CreateIProgressBarControlComponent(FlatBufferBuilder builder, bool Disabled = false, THitBulletType HitBullet_type = THitBulletType.NONE, int HitBulletOffset = 0, Offset<IHitTimeScaleRatio> AttackerHitTimeScaleRatioOffset = default(Offset<IHitTimeScaleRatio>), Offset<IHitTimeScaleRatio> VictimHitTimeScaleRatioOffset = default(Offset<IHitTimeScaleRatio>), VectorOffset AimPartsOffset = default(VectorOffset), TProgressBarControl Control_type = TProgressBarControl.NONE, int ControlOffset = 0, byte NullMask = 0)
		{
			builder.StartTable(9);
			IProgressBarControlComponent.AddControl(builder, ControlOffset);
			IProgressBarControlComponent.AddAimParts(builder, AimPartsOffset);
			IProgressBarControlComponent.AddVictimHitTimeScaleRatio(builder, VictimHitTimeScaleRatioOffset);
			IProgressBarControlComponent.AddAttackerHitTimeScaleRatio(builder, AttackerHitTimeScaleRatioOffset);
			IProgressBarControlComponent.AddHitBullet(builder, HitBulletOffset);
			IProgressBarControlComponent.AddNullMask(builder, NullMask);
			IProgressBarControlComponent.AddControlType(builder, Control_type);
			IProgressBarControlComponent.AddHitBulletType(builder, HitBullet_type);
			IProgressBarControlComponent.AddDisabled(builder, Disabled);
			return IProgressBarControlComponent.EndIProgressBarControlComponent(builder);
		}

		// Token: 0x06025A09 RID: 154121 RVA: 0x005309AC File Offset: 0x0052EBAC
		public static void StartIProgressBarControlComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(9);
		}

		// Token: 0x06025A0A RID: 154122 RVA: 0x005309B6 File Offset: 0x0052EBB6
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06025A0B RID: 154123 RVA: 0x005309C1 File Offset: 0x0052EBC1
		public static void AddHitBulletType(FlatBufferBuilder builder, THitBulletType hitBulletType)
		{
			builder.AddByte(1, (byte)hitBulletType, 0);
		}

		// Token: 0x06025A0C RID: 154124 RVA: 0x005309CC File Offset: 0x0052EBCC
		public static void AddHitBullet(FlatBufferBuilder builder, int hitBulletOffset)
		{
			builder.AddOffset(2, hitBulletOffset, 0);
		}

		// Token: 0x06025A0D RID: 154125 RVA: 0x005309D7 File Offset: 0x0052EBD7
		public static void AddAttackerHitTimeScaleRatio(FlatBufferBuilder builder, Offset<IHitTimeScaleRatio> attackerHitTimeScaleRatioOffset)
		{
			builder.AddOffset(3, attackerHitTimeScaleRatioOffset.Value, 0);
		}

		// Token: 0x06025A0E RID: 154126 RVA: 0x005309E7 File Offset: 0x0052EBE7
		public static void AddVictimHitTimeScaleRatio(FlatBufferBuilder builder, Offset<IHitTimeScaleRatio> victimHitTimeScaleRatioOffset)
		{
			builder.AddOffset(4, victimHitTimeScaleRatioOffset.Value, 0);
		}

		// Token: 0x06025A0F RID: 154127 RVA: 0x005309F7 File Offset: 0x0052EBF7
		public static void AddAimParts(FlatBufferBuilder builder, VectorOffset aimPartsOffset)
		{
			builder.AddOffset(5, aimPartsOffset.Value, 0);
		}

		// Token: 0x06025A10 RID: 154128 RVA: 0x00530A08 File Offset: 0x0052EC08
		public static VectorOffset CreateAimPartsVector(FlatBufferBuilder builder, Offset<IAimPart>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06025A11 RID: 154129 RVA: 0x00530A48 File Offset: 0x0052EC48
		public static VectorOffset CreateAimPartsVectorBlock(FlatBufferBuilder builder, Offset<IAimPart>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IAimPart>>(data);
			return builder.EndVector();
		}

		// Token: 0x06025A12 RID: 154130 RVA: 0x00530A62 File Offset: 0x0052EC62
		public static VectorOffset CreateAimPartsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IAimPart>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IAimPart>>(data);
			return builder.EndVector();
		}

		// Token: 0x06025A13 RID: 154131 RVA: 0x00530A80 File Offset: 0x0052EC80
		public static VectorOffset CreateAimPartsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IAimPart>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06025A14 RID: 154132 RVA: 0x00530A99 File Offset: 0x0052EC99
		public static void StartAimPartsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06025A15 RID: 154133 RVA: 0x00530AA4 File Offset: 0x0052ECA4
		public static void AddControlType(FlatBufferBuilder builder, TProgressBarControl controlType)
		{
			builder.AddByte(6, (byte)controlType, 0);
		}

		// Token: 0x06025A16 RID: 154134 RVA: 0x00530AAF File Offset: 0x0052ECAF
		public static void AddControl(FlatBufferBuilder builder, int controlOffset)
		{
			builder.AddOffset(7, controlOffset, 0);
		}

		// Token: 0x06025A17 RID: 154135 RVA: 0x00530ABA File Offset: 0x0052ECBA
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(8, nullMask, 0);
		}

		// Token: 0x06025A18 RID: 154136 RVA: 0x00530AC5 File Offset: 0x0052ECC5
		public static Offset<IProgressBarControlComponent> EndIProgressBarControlComponent(FlatBufferBuilder builder)
		{
			return new Offset<IProgressBarControlComponent>(builder.EndTable());
		}

		// Token: 0x06025A19 RID: 154137 RVA: 0x00530AD4 File Offset: 0x0052ECD4
		public IProgressBarControlComponentT UnPack()
		{
			IProgressBarControlComponentT progressBarControlComponentT = new IProgressBarControlComponentT();
			this.UnPackTo(progressBarControlComponentT);
			return progressBarControlComponentT;
		}

		// Token: 0x06025A1A RID: 154138 RVA: 0x00530AF0 File Offset: 0x0052ECF0
		public void UnPackTo(IProgressBarControlComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.HitBullet = new THitBulletTypeUnion();
			_o.HitBullet.Type = this.HitBulletType;
			switch (this.HitBulletType)
			{
			case THitBulletType.IHitBulletTypeAllCharacterAttack:
				_o.HitBullet.Value = ((this.HitBullet<IHitBulletTypeAllCharacterAttack>() != null) ? this.HitBullet<IHitBulletTypeAllCharacterAttack>().Value.UnPack() : null);
				break;
			case THitBulletType.IHitBulletTypeCrystalAttack:
				_o.HitBullet.Value = ((this.HitBullet<IHitBulletTypeCrystalAttack>() != null) ? this.HitBullet<IHitBulletTypeCrystalAttack>().Value.UnPack() : null);
				break;
			case THitBulletType.IHitBulletTypeFixedBulletId:
				_o.HitBullet.Value = ((this.HitBullet<IHitBulletTypeFixedBulletId>() != null) ? this.HitBullet<IHitBulletTypeFixedBulletId>().Value.UnPack() : null);
				break;
			case THitBulletType.IHitBulletTypeOnlyDropAttack:
				_o.HitBullet.Value = ((this.HitBullet<IHitBulletTypeOnlyDropAttack>() != null) ? this.HitBullet<IHitBulletTypeOnlyDropAttack>().Value.UnPack() : null);
				break;
			case THitBulletType.IHitBulletTypePlayerAttack:
				_o.HitBullet.Value = ((this.HitBullet<IHitBulletTypePlayerAttack>() != null) ? this.HitBullet<IHitBulletTypePlayerAttack>().Value.UnPack() : null);
				break;
			case THitBulletType.IHitBulletTypePlayerOrThrenodianAttack:
				_o.HitBullet.Value = ((this.HitBullet<IHitBulletTypePlayerOrThrenodianAttack>() != null) ? this.HitBullet<IHitBulletTypePlayerOrThrenodianAttack>().Value.UnPack() : null);
				break;
			}
			_o.AttackerHitTimeScaleRatio = ((this.AttackerHitTimeScaleRatio != null) ? this.AttackerHitTimeScaleRatio.Value.UnPack() : null);
			_o.VictimHitTimeScaleRatio = ((this.VictimHitTimeScaleRatio != null) ? this.VictimHitTimeScaleRatio.Value.UnPack() : null);
			_o.AimParts = new List<IAimPartT>();
			for (int i = 0; i < this.AimPartsLength; i++)
			{
				_o.AimParts.Add((this.AimParts(i) != null) ? this.AimParts(i).Value.UnPack() : null);
			}
			_o.Control = new TProgressBarControlUnion();
			_o.Control.Type = this.ControlType;
			switch (this.ControlType)
			{
			case TProgressBarControl.ICaptureStrategicPoint:
				_o.Control.Value = ((this.Control<ICaptureStrategicPoint>() != null) ? this.Control<ICaptureStrategicPoint>().Value.UnPack() : null);
				break;
			case TProgressBarControl.ICaptureStrategicPoint2:
				_o.Control.Value = ((this.Control<ICaptureStrategicPoint2>() != null) ? this.Control<ICaptureStrategicPoint2>().Value.UnPack() : null);
				break;
			case TProgressBarControl.IChargingDevice:
				_o.Control.Value = ((this.Control<IChargingDevice>() != null) ? this.Control<IChargingDevice>().Value.UnPack() : null);
				break;
			case TProgressBarControl.IMatchTargetChargingDevice:
				_o.Control.Value = ((this.Control<IMatchTargetChargingDevice>() != null) ? this.Control<IMatchTargetChargingDevice>().Value.UnPack() : null);
				break;
			case TProgressBarControl.ITimedStrikeDevice:
				_o.Control.Value = ((this.Control<ITimedStrikeDevice>() != null) ? this.Control<ITimedStrikeDevice>().Value.UnPack() : null);
				break;
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06025A1B RID: 154139 RVA: 0x00530EDC File Offset: 0x0052F0DC
		public static Offset<IProgressBarControlComponent> Pack(FlatBufferBuilder builder, IProgressBarControlComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IProgressBarControlComponent>);
			}
			THitBulletType hitBullet_type = (_o.HitBullet == null) ? THitBulletType.NONE : _o.HitBullet.Type;
			int hitBulletOffset = (_o.HitBullet == null) ? 0 : THitBulletTypeUnion.Pack(builder, _o.HitBullet);
			Offset<IHitTimeScaleRatio> attackerHitTimeScaleRatioOffset = (_o.AttackerHitTimeScaleRatio == null) ? default(Offset<IHitTimeScaleRatio>) : IHitTimeScaleRatio.Pack(builder, _o.AttackerHitTimeScaleRatio);
			Offset<IHitTimeScaleRatio> victimHitTimeScaleRatioOffset = (_o.VictimHitTimeScaleRatio == null) ? default(Offset<IHitTimeScaleRatio>) : IHitTimeScaleRatio.Pack(builder, _o.VictimHitTimeScaleRatio);
			VectorOffset aimPartsOffset = default(VectorOffset);
			if (_o.AimParts != null)
			{
				Offset<IAimPart>[] array = new Offset<IAimPart>[_o.AimParts.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IAimPart.Pack(builder, _o.AimParts[i]);
				}
				aimPartsOffset = IProgressBarControlComponent.CreateAimPartsVector(builder, array);
			}
			TProgressBarControl control_type = (_o.Control == null) ? TProgressBarControl.NONE : _o.Control.Type;
			int controlOffset = (_o.Control == null) ? 0 : TProgressBarControlUnion.Pack(builder, _o.Control);
			return IProgressBarControlComponent.CreateIProgressBarControlComponent(builder, _o.Disabled, hitBullet_type, hitBulletOffset, attackerHitTimeScaleRatioOffset, victimHitTimeScaleRatioOffset, aimPartsOffset, control_type, controlOffset, _o.NullMask);
		}

		// Token: 0x0400EC5F RID: 60511
		private Table __p;
	}
}
