using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005DA6 RID: 23974
	public struct IProgressBarControlComponent : IFlatbufferObject
	{
		// Token: 0x1700B07F RID: 45183
		// (get) Token: 0x06027F0D RID: 163597 RVA: 0x00576660 File Offset: 0x00574860
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06027F0E RID: 163598 RVA: 0x0057666D File Offset: 0x0057486D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06027F0F RID: 163599 RVA: 0x00576674 File Offset: 0x00574874
		public static IProgressBarControlComponent GetRootAsIProgressBarControlComponent(ByteBuffer _bb)
		{
			return IProgressBarControlComponent.GetRootAsIProgressBarControlComponent(_bb, default(IProgressBarControlComponent));
		}

		// Token: 0x06027F10 RID: 163600 RVA: 0x00576690 File Offset: 0x00574890
		public static IProgressBarControlComponent GetRootAsIProgressBarControlComponent(ByteBuffer _bb, IProgressBarControlComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06027F11 RID: 163601 RVA: 0x005766AD File Offset: 0x005748AD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06027F12 RID: 163602 RVA: 0x005766BC File Offset: 0x005748BC
		public IProgressBarControlComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B080 RID: 45184
		// (get) Token: 0x06027F13 RID: 163603 RVA: 0x005766CC File Offset: 0x005748CC
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B081 RID: 45185
		// (get) Token: 0x06027F14 RID: 163604 RVA: 0x0057670C File Offset: 0x0057490C
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

		// Token: 0x06027F15 RID: 163605 RVA: 0x00576748 File Offset: 0x00574948
		public TTable? HitBullet<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06027F16 RID: 163606 RVA: 0x0057678C File Offset: 0x0057498C
		public IHitBulletTypeAllCharacterAttack HitBulletAsIHitBulletTypeAllCharacterAttack()
		{
			return this.HitBullet<IHitBulletTypeAllCharacterAttack>().Value;
		}

		// Token: 0x06027F17 RID: 163607 RVA: 0x005767A8 File Offset: 0x005749A8
		public IHitBulletTypeCrystalAttack HitBulletAsIHitBulletTypeCrystalAttack()
		{
			return this.HitBullet<IHitBulletTypeCrystalAttack>().Value;
		}

		// Token: 0x06027F18 RID: 163608 RVA: 0x005767C4 File Offset: 0x005749C4
		public IHitBulletTypeFixedBulletId HitBulletAsIHitBulletTypeFixedBulletId()
		{
			return this.HitBullet<IHitBulletTypeFixedBulletId>().Value;
		}

		// Token: 0x06027F19 RID: 163609 RVA: 0x005767E0 File Offset: 0x005749E0
		public IHitBulletTypeOnlyDropAttack HitBulletAsIHitBulletTypeOnlyDropAttack()
		{
			return this.HitBullet<IHitBulletTypeOnlyDropAttack>().Value;
		}

		// Token: 0x06027F1A RID: 163610 RVA: 0x005767FC File Offset: 0x005749FC
		public IHitBulletTypePlayerAttack HitBulletAsIHitBulletTypePlayerAttack()
		{
			return this.HitBullet<IHitBulletTypePlayerAttack>().Value;
		}

		// Token: 0x06027F1B RID: 163611 RVA: 0x00576818 File Offset: 0x00574A18
		public IHitBulletTypePlayerOrThrenodianAttack HitBulletAsIHitBulletTypePlayerOrThrenodianAttack()
		{
			return this.HitBullet<IHitBulletTypePlayerOrThrenodianAttack>().Value;
		}

		// Token: 0x1700B082 RID: 45186
		// (get) Token: 0x06027F1C RID: 163612 RVA: 0x00576834 File Offset: 0x00574A34
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

		// Token: 0x1700B083 RID: 45187
		// (get) Token: 0x06027F1D RID: 163613 RVA: 0x00576894 File Offset: 0x00574A94
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

		// Token: 0x06027F1E RID: 163614 RVA: 0x005768F4 File Offset: 0x00574AF4
		public IAimPart? AimParts(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new IAimPart?(default(IAimPart).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700B084 RID: 45188
		// (get) Token: 0x06027F1F RID: 163615 RVA: 0x00576958 File Offset: 0x00574B58
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

		// Token: 0x1700B085 RID: 45189
		// (get) Token: 0x06027F20 RID: 163616 RVA: 0x00576984 File Offset: 0x00574B84
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

		// Token: 0x06027F21 RID: 163617 RVA: 0x005769C4 File Offset: 0x00574BC4
		public TTable? Control<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06027F22 RID: 163618 RVA: 0x00576A0C File Offset: 0x00574C0C
		public ICaptureStrategicPoint ControlAsICaptureStrategicPoint()
		{
			return this.Control<ICaptureStrategicPoint>().Value;
		}

		// Token: 0x06027F23 RID: 163619 RVA: 0x00576A28 File Offset: 0x00574C28
		public ICaptureStrategicPoint2 ControlAsICaptureStrategicPoint2()
		{
			return this.Control<ICaptureStrategicPoint2>().Value;
		}

		// Token: 0x06027F24 RID: 163620 RVA: 0x00576A44 File Offset: 0x00574C44
		public IChargingDevice ControlAsIChargingDevice()
		{
			return this.Control<IChargingDevice>().Value;
		}

		// Token: 0x06027F25 RID: 163621 RVA: 0x00576A60 File Offset: 0x00574C60
		public IMatchTargetChargingDevice ControlAsIMatchTargetChargingDevice()
		{
			return this.Control<IMatchTargetChargingDevice>().Value;
		}

		// Token: 0x06027F26 RID: 163622 RVA: 0x00576A7C File Offset: 0x00574C7C
		public ITimedStrikeDevice ControlAsITimedStrikeDevice()
		{
			return this.Control<ITimedStrikeDevice>().Value;
		}

		// Token: 0x1700B086 RID: 45190
		// (get) Token: 0x06027F27 RID: 163623 RVA: 0x00576A98 File Offset: 0x00574C98
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

		// Token: 0x06027F28 RID: 163624 RVA: 0x00576AD8 File Offset: 0x00574CD8
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

		// Token: 0x06027F29 RID: 163625 RVA: 0x00576B38 File Offset: 0x00574D38
		public static void StartIProgressBarControlComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(9);
		}

		// Token: 0x06027F2A RID: 163626 RVA: 0x00576B42 File Offset: 0x00574D42
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06027F2B RID: 163627 RVA: 0x00576B4D File Offset: 0x00574D4D
		public static void AddHitBulletType(FlatBufferBuilder builder, THitBulletType hitBulletType)
		{
			builder.AddByte(1, (byte)hitBulletType, 0);
		}

		// Token: 0x06027F2C RID: 163628 RVA: 0x00576B58 File Offset: 0x00574D58
		public static void AddHitBullet(FlatBufferBuilder builder, int hitBulletOffset)
		{
			builder.AddOffset(2, hitBulletOffset, 0);
		}

		// Token: 0x06027F2D RID: 163629 RVA: 0x00576B63 File Offset: 0x00574D63
		public static void AddAttackerHitTimeScaleRatio(FlatBufferBuilder builder, Offset<IHitTimeScaleRatio> attackerHitTimeScaleRatioOffset)
		{
			builder.AddOffset(3, attackerHitTimeScaleRatioOffset.Value, 0);
		}

		// Token: 0x06027F2E RID: 163630 RVA: 0x00576B73 File Offset: 0x00574D73
		public static void AddVictimHitTimeScaleRatio(FlatBufferBuilder builder, Offset<IHitTimeScaleRatio> victimHitTimeScaleRatioOffset)
		{
			builder.AddOffset(4, victimHitTimeScaleRatioOffset.Value, 0);
		}

		// Token: 0x06027F2F RID: 163631 RVA: 0x00576B83 File Offset: 0x00574D83
		public static void AddAimParts(FlatBufferBuilder builder, VectorOffset aimPartsOffset)
		{
			builder.AddOffset(5, aimPartsOffset.Value, 0);
		}

		// Token: 0x06027F30 RID: 163632 RVA: 0x00576B94 File Offset: 0x00574D94
		public static VectorOffset CreateAimPartsVector(FlatBufferBuilder builder, Offset<IAimPart>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06027F31 RID: 163633 RVA: 0x00576BD4 File Offset: 0x00574DD4
		public static VectorOffset CreateAimPartsVectorBlock(FlatBufferBuilder builder, Offset<IAimPart>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IAimPart>>(data);
			return builder.EndVector();
		}

		// Token: 0x06027F32 RID: 163634 RVA: 0x00576BEE File Offset: 0x00574DEE
		public static VectorOffset CreateAimPartsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IAimPart>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IAimPart>>(data);
			return builder.EndVector();
		}

		// Token: 0x06027F33 RID: 163635 RVA: 0x00576C0C File Offset: 0x00574E0C
		public static VectorOffset CreateAimPartsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IAimPart>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06027F34 RID: 163636 RVA: 0x00576C25 File Offset: 0x00574E25
		public static void StartAimPartsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06027F35 RID: 163637 RVA: 0x00576C30 File Offset: 0x00574E30
		public static void AddControlType(FlatBufferBuilder builder, TProgressBarControl controlType)
		{
			builder.AddByte(6, (byte)controlType, 0);
		}

		// Token: 0x06027F36 RID: 163638 RVA: 0x00576C3B File Offset: 0x00574E3B
		public static void AddControl(FlatBufferBuilder builder, int controlOffset)
		{
			builder.AddOffset(7, controlOffset, 0);
		}

		// Token: 0x06027F37 RID: 163639 RVA: 0x00576C46 File Offset: 0x00574E46
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(8, nullMask, 0);
		}

		// Token: 0x06027F38 RID: 163640 RVA: 0x00576C51 File Offset: 0x00574E51
		public static Offset<IProgressBarControlComponent> EndIProgressBarControlComponent(FlatBufferBuilder builder)
		{
			return new Offset<IProgressBarControlComponent>(builder.EndTable());
		}

		// Token: 0x06027F39 RID: 163641 RVA: 0x00576C60 File Offset: 0x00574E60
		public IProgressBarControlComponentT UnPack()
		{
			IProgressBarControlComponentT progressBarControlComponentT = new IProgressBarControlComponentT();
			this.UnPackTo(progressBarControlComponentT);
			return progressBarControlComponentT;
		}

		// Token: 0x06027F3A RID: 163642 RVA: 0x00576C7C File Offset: 0x00574E7C
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

		// Token: 0x06027F3B RID: 163643 RVA: 0x00577068 File Offset: 0x00575268
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

		// Token: 0x0400F94A RID: 63818
		private Table __p;
	}
}
