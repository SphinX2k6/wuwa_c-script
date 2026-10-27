using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006167 RID: 24935
	public struct IAdjustPlayerCamera : IFlatbufferObject
	{
		// Token: 0x1700B996 RID: 47510
		// (get) Token: 0x0602AE47 RID: 175687 RVA: 0x005EAA3C File Offset: 0x005E8C3C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602AE48 RID: 175688 RVA: 0x005EAA49 File Offset: 0x005E8C49
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602AE49 RID: 175689 RVA: 0x005EAA50 File Offset: 0x005E8C50
		public static IAdjustPlayerCamera GetRootAsIAdjustPlayerCamera(ByteBuffer _bb)
		{
			return IAdjustPlayerCamera.GetRootAsIAdjustPlayerCamera(_bb, default(IAdjustPlayerCamera));
		}

		// Token: 0x0602AE4A RID: 175690 RVA: 0x005EAA6C File Offset: 0x005E8C6C
		public static IAdjustPlayerCamera GetRootAsIAdjustPlayerCamera(ByteBuffer _bb, IAdjustPlayerCamera obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602AE4B RID: 175691 RVA: 0x005EAA89 File Offset: 0x005E8C89
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602AE4C RID: 175692 RVA: 0x005EAA98 File Offset: 0x005E8C98
		public IAdjustPlayerCamera __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B997 RID: 47511
		// (get) Token: 0x0602AE4D RID: 175693 RVA: 0x005EAAA8 File Offset: 0x005E8CA8
		public TAdjustPlayerCameraOption OptionType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return TAdjustPlayerCameraOption.NONE;
				}
				return (TAdjustPlayerCameraOption)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602AE4E RID: 175694 RVA: 0x005EAAE4 File Offset: 0x005E8CE4
		public TTable? Option<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602AE4F RID: 175695 RVA: 0x005EAB28 File Offset: 0x005E8D28
		public IAdjustAxisLockCamera OptionAsIAdjustAxisLockCamera()
		{
			return this.Option<IAdjustAxisLockCamera>().Value;
		}

		// Token: 0x0602AE50 RID: 175696 RVA: 0x005EAB44 File Offset: 0x005E8D44
		public IAdjustBasicCamera OptionAsIAdjustBasicCamera()
		{
			return this.Option<IAdjustBasicCamera>().Value;
		}

		// Token: 0x0602AE51 RID: 175697 RVA: 0x005EAB60 File Offset: 0x005E8D60
		public IAdjustDialogCamera OptionAsIAdjustDialogCamera()
		{
			return this.Option<IAdjustDialogCamera>().Value;
		}

		// Token: 0x0602AE52 RID: 175698 RVA: 0x005EAB7C File Offset: 0x005E8D7C
		public IAdjustFirstPersonCamera OptionAsIAdjustFirstPersonCamera()
		{
			return this.Option<IAdjustFirstPersonCamera>().Value;
		}

		// Token: 0x0602AE53 RID: 175699 RVA: 0x005EAB98 File Offset: 0x005E8D98
		public IAdjustFixedCamera OptionAsIAdjustFixedCamera()
		{
			return this.Option<IAdjustFixedCamera>().Value;
		}

		// Token: 0x0602AE54 RID: 175700 RVA: 0x005EABB4 File Offset: 0x005E8DB4
		public IAdjustFixedLookAtCamera OptionAsIAdjustFixedLookAtCamera()
		{
			return this.Option<IAdjustFixedLookAtCamera>().Value;
		}

		// Token: 0x0602AE55 RID: 175701 RVA: 0x005EABD0 File Offset: 0x005E8DD0
		public IAdjustFixedSurveillanceCamera OptionAsIAdjustFixedSurveillanceCamera()
		{
			return this.Option<IAdjustFixedSurveillanceCamera>().Value;
		}

		// Token: 0x0602AE56 RID: 175702 RVA: 0x005EABEC File Offset: 0x005E8DEC
		public IAdjustHorizontalCamera OptionAsIAdjustHorizontalCamera()
		{
			return this.Option<IAdjustHorizontalCamera>().Value;
		}

		// Token: 0x0602AE57 RID: 175703 RVA: 0x005EAC08 File Offset: 0x005E8E08
		public IAdjustZoneFollowCamera OptionAsIAdjustZoneFollowCamera()
		{
			return this.Option<IAdjustZoneFollowCamera>().Value;
		}

		// Token: 0x0602AE58 RID: 175704 RVA: 0x005EAC23 File Offset: 0x005E8E23
		public static Offset<IAdjustPlayerCamera> CreateIAdjustPlayerCamera(FlatBufferBuilder builder, TAdjustPlayerCameraOption Option_type = TAdjustPlayerCameraOption.NONE, int OptionOffset = 0)
		{
			builder.StartTable(2);
			IAdjustPlayerCamera.AddOption(builder, OptionOffset);
			IAdjustPlayerCamera.AddOptionType(builder, Option_type);
			return IAdjustPlayerCamera.EndIAdjustPlayerCamera(builder);
		}

		// Token: 0x0602AE59 RID: 175705 RVA: 0x005EAC40 File Offset: 0x005E8E40
		public static void StartIAdjustPlayerCamera(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602AE5A RID: 175706 RVA: 0x005EAC49 File Offset: 0x005E8E49
		public static void AddOptionType(FlatBufferBuilder builder, TAdjustPlayerCameraOption optionType)
		{
			builder.AddByte(0, (byte)optionType, 0);
		}

		// Token: 0x0602AE5B RID: 175707 RVA: 0x005EAC54 File Offset: 0x005E8E54
		public static void AddOption(FlatBufferBuilder builder, int optionOffset)
		{
			builder.AddOffset(1, optionOffset, 0);
		}

		// Token: 0x0602AE5C RID: 175708 RVA: 0x005EAC5F File Offset: 0x005E8E5F
		public static Offset<IAdjustPlayerCamera> EndIAdjustPlayerCamera(FlatBufferBuilder builder)
		{
			return new Offset<IAdjustPlayerCamera>(builder.EndTable());
		}

		// Token: 0x0602AE5D RID: 175709 RVA: 0x005EAC6C File Offset: 0x005E8E6C
		public IAdjustPlayerCameraT UnPack()
		{
			IAdjustPlayerCameraT adjustPlayerCameraT = new IAdjustPlayerCameraT();
			this.UnPackTo(adjustPlayerCameraT);
			return adjustPlayerCameraT;
		}

		// Token: 0x0602AE5E RID: 175710 RVA: 0x005EAC88 File Offset: 0x005E8E88
		public void UnPackTo(IAdjustPlayerCameraT _o)
		{
			_o.Option = new TAdjustPlayerCameraOptionUnion();
			_o.Option.Type = this.OptionType;
			switch (this.OptionType)
			{
			case TAdjustPlayerCameraOption.IAdjustAxisLockCamera:
				_o.Option.Value = ((this.Option<IAdjustAxisLockCamera>() != null) ? this.Option<IAdjustAxisLockCamera>().Value.UnPack() : null);
				return;
			case TAdjustPlayerCameraOption.IAdjustBasicCamera:
				_o.Option.Value = ((this.Option<IAdjustBasicCamera>() != null) ? this.Option<IAdjustBasicCamera>().Value.UnPack() : null);
				return;
			case TAdjustPlayerCameraOption.IAdjustDialogCamera:
				_o.Option.Value = ((this.Option<IAdjustDialogCamera>() != null) ? this.Option<IAdjustDialogCamera>().Value.UnPack() : null);
				return;
			case TAdjustPlayerCameraOption.IAdjustFirstPersonCamera:
				_o.Option.Value = ((this.Option<IAdjustFirstPersonCamera>() != null) ? this.Option<IAdjustFirstPersonCamera>().Value.UnPack() : null);
				return;
			case TAdjustPlayerCameraOption.IAdjustFixedCamera:
				_o.Option.Value = ((this.Option<IAdjustFixedCamera>() != null) ? this.Option<IAdjustFixedCamera>().Value.UnPack() : null);
				return;
			case TAdjustPlayerCameraOption.IAdjustFixedLookAtCamera:
				_o.Option.Value = ((this.Option<IAdjustFixedLookAtCamera>() != null) ? this.Option<IAdjustFixedLookAtCamera>().Value.UnPack() : null);
				return;
			case TAdjustPlayerCameraOption.IAdjustFixedSurveillanceCamera:
				_o.Option.Value = ((this.Option<IAdjustFixedSurveillanceCamera>() != null) ? this.Option<IAdjustFixedSurveillanceCamera>().Value.UnPack() : null);
				return;
			case TAdjustPlayerCameraOption.IAdjustHorizontalCamera:
				_o.Option.Value = ((this.Option<IAdjustHorizontalCamera>() != null) ? this.Option<IAdjustHorizontalCamera>().Value.UnPack() : null);
				return;
			case TAdjustPlayerCameraOption.IAdjustZoneFollowCamera:
				_o.Option.Value = ((this.Option<IAdjustZoneFollowCamera>() != null) ? this.Option<IAdjustZoneFollowCamera>().Value.UnPack() : null);
				return;
			default:
				return;
			}
		}

		// Token: 0x0602AE5F RID: 175711 RVA: 0x005EAED8 File Offset: 0x005E90D8
		public static Offset<IAdjustPlayerCamera> Pack(FlatBufferBuilder builder, IAdjustPlayerCameraT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAdjustPlayerCamera>);
			}
			TAdjustPlayerCameraOption option_type = (_o.Option == null) ? TAdjustPlayerCameraOption.NONE : _o.Option.Type;
			int optionOffset = (_o.Option == null) ? 0 : TAdjustPlayerCameraOptionUnion.Pack(builder, _o.Option);
			return IAdjustPlayerCamera.CreateIAdjustPlayerCamera(builder, option_type, optionOffset);
		}

		// Token: 0x0401062E RID: 67118
		private Table __p;
	}
}
