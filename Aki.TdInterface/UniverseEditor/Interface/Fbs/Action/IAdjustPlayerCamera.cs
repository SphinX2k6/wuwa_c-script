using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020067CC RID: 26572
	public struct IAdjustPlayerCamera : IFlatbufferObject
	{
		// Token: 0x1700C306 RID: 49926
		// (get) Token: 0x0602D540 RID: 185664 RVA: 0x00634C18 File Offset: 0x00632E18
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602D541 RID: 185665 RVA: 0x00634C25 File Offset: 0x00632E25
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602D542 RID: 185666 RVA: 0x00634C2C File Offset: 0x00632E2C
		public static IAdjustPlayerCamera GetRootAsIAdjustPlayerCamera(ByteBuffer _bb)
		{
			return IAdjustPlayerCamera.GetRootAsIAdjustPlayerCamera(_bb, default(IAdjustPlayerCamera));
		}

		// Token: 0x0602D543 RID: 185667 RVA: 0x00634C48 File Offset: 0x00632E48
		public static IAdjustPlayerCamera GetRootAsIAdjustPlayerCamera(ByteBuffer _bb, IAdjustPlayerCamera obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602D544 RID: 185668 RVA: 0x00634C65 File Offset: 0x00632E65
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602D545 RID: 185669 RVA: 0x00634C74 File Offset: 0x00632E74
		public IAdjustPlayerCamera __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C307 RID: 49927
		// (get) Token: 0x0602D546 RID: 185670 RVA: 0x00634C84 File Offset: 0x00632E84
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

		// Token: 0x0602D547 RID: 185671 RVA: 0x00634CC0 File Offset: 0x00632EC0
		public TTable? Option<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602D548 RID: 185672 RVA: 0x00634D04 File Offset: 0x00632F04
		public IAdjustAxisLockCamera OptionAsIAdjustAxisLockCamera()
		{
			return this.Option<IAdjustAxisLockCamera>().Value;
		}

		// Token: 0x0602D549 RID: 185673 RVA: 0x00634D20 File Offset: 0x00632F20
		public IAdjustBasicCamera OptionAsIAdjustBasicCamera()
		{
			return this.Option<IAdjustBasicCamera>().Value;
		}

		// Token: 0x0602D54A RID: 185674 RVA: 0x00634D3C File Offset: 0x00632F3C
		public IAdjustDialogCamera OptionAsIAdjustDialogCamera()
		{
			return this.Option<IAdjustDialogCamera>().Value;
		}

		// Token: 0x0602D54B RID: 185675 RVA: 0x00634D58 File Offset: 0x00632F58
		public IAdjustFirstPersonCamera OptionAsIAdjustFirstPersonCamera()
		{
			return this.Option<IAdjustFirstPersonCamera>().Value;
		}

		// Token: 0x0602D54C RID: 185676 RVA: 0x00634D74 File Offset: 0x00632F74
		public IAdjustFixedCamera OptionAsIAdjustFixedCamera()
		{
			return this.Option<IAdjustFixedCamera>().Value;
		}

		// Token: 0x0602D54D RID: 185677 RVA: 0x00634D90 File Offset: 0x00632F90
		public IAdjustFixedLookAtCamera OptionAsIAdjustFixedLookAtCamera()
		{
			return this.Option<IAdjustFixedLookAtCamera>().Value;
		}

		// Token: 0x0602D54E RID: 185678 RVA: 0x00634DAC File Offset: 0x00632FAC
		public IAdjustFixedSurveillanceCamera OptionAsIAdjustFixedSurveillanceCamera()
		{
			return this.Option<IAdjustFixedSurveillanceCamera>().Value;
		}

		// Token: 0x0602D54F RID: 185679 RVA: 0x00634DC8 File Offset: 0x00632FC8
		public IAdjustHorizontalCamera OptionAsIAdjustHorizontalCamera()
		{
			return this.Option<IAdjustHorizontalCamera>().Value;
		}

		// Token: 0x0602D550 RID: 185680 RVA: 0x00634DE4 File Offset: 0x00632FE4
		public IAdjustZoneFollowCamera OptionAsIAdjustZoneFollowCamera()
		{
			return this.Option<IAdjustZoneFollowCamera>().Value;
		}

		// Token: 0x0602D551 RID: 185681 RVA: 0x00634DFF File Offset: 0x00632FFF
		public static Offset<IAdjustPlayerCamera> CreateIAdjustPlayerCamera(FlatBufferBuilder builder, TAdjustPlayerCameraOption Option_type = TAdjustPlayerCameraOption.NONE, int OptionOffset = 0)
		{
			builder.StartTable(2);
			IAdjustPlayerCamera.AddOption(builder, OptionOffset);
			IAdjustPlayerCamera.AddOptionType(builder, Option_type);
			return IAdjustPlayerCamera.EndIAdjustPlayerCamera(builder);
		}

		// Token: 0x0602D552 RID: 185682 RVA: 0x00634E1C File Offset: 0x0063301C
		public static void StartIAdjustPlayerCamera(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602D553 RID: 185683 RVA: 0x00634E25 File Offset: 0x00633025
		public static void AddOptionType(FlatBufferBuilder builder, TAdjustPlayerCameraOption optionType)
		{
			builder.AddByte(0, (byte)optionType, 0);
		}

		// Token: 0x0602D554 RID: 185684 RVA: 0x00634E30 File Offset: 0x00633030
		public static void AddOption(FlatBufferBuilder builder, int optionOffset)
		{
			builder.AddOffset(1, optionOffset, 0);
		}

		// Token: 0x0602D555 RID: 185685 RVA: 0x00634E3B File Offset: 0x0063303B
		public static Offset<IAdjustPlayerCamera> EndIAdjustPlayerCamera(FlatBufferBuilder builder)
		{
			return new Offset<IAdjustPlayerCamera>(builder.EndTable());
		}

		// Token: 0x0602D556 RID: 185686 RVA: 0x00634E48 File Offset: 0x00633048
		public IAdjustPlayerCameraT UnPack()
		{
			IAdjustPlayerCameraT adjustPlayerCameraT = new IAdjustPlayerCameraT();
			this.UnPackTo(adjustPlayerCameraT);
			return adjustPlayerCameraT;
		}

		// Token: 0x0602D557 RID: 185687 RVA: 0x00634E64 File Offset: 0x00633064
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

		// Token: 0x0602D558 RID: 185688 RVA: 0x006350B4 File Offset: 0x006332B4
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

		// Token: 0x04011435 RID: 70709
		private Table __p;
	}
}
