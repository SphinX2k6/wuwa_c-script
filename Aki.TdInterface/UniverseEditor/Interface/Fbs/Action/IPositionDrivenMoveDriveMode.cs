using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D68 RID: 28008
	public struct IPositionDrivenMoveDriveMode : IFlatbufferObject
	{
		// Token: 0x1700D0EA RID: 53482
		// (get) Token: 0x0603175C RID: 202588 RVA: 0x006B4AE0 File Offset: 0x006B2CE0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603175D RID: 202589 RVA: 0x006B4AED File Offset: 0x006B2CED
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603175E RID: 202590 RVA: 0x006B4AF4 File Offset: 0x006B2CF4
		public static IPositionDrivenMoveDriveMode GetRootAsIPositionDrivenMoveDriveMode(ByteBuffer _bb)
		{
			return IPositionDrivenMoveDriveMode.GetRootAsIPositionDrivenMoveDriveMode(_bb, default(IPositionDrivenMoveDriveMode));
		}

		// Token: 0x0603175F RID: 202591 RVA: 0x006B4B10 File Offset: 0x006B2D10
		public static IPositionDrivenMoveDriveMode GetRootAsIPositionDrivenMoveDriveMode(ByteBuffer _bb, IPositionDrivenMoveDriveMode obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06031760 RID: 202592 RVA: 0x006B4B2D File Offset: 0x006B2D2D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031761 RID: 202593 RVA: 0x006B4B3C File Offset: 0x006B2D3C
		public IPositionDrivenMoveDriveMode __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D0EB RID: 53483
		// (get) Token: 0x06031762 RID: 202594 RVA: 0x006B4B4C File Offset: 0x006B2D4C
		public ESplineMoveDriveMode Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESplineMoveDriveMode.InputDriven;
				}
				return (ESplineMoveDriveMode)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D0EC RID: 53484
		// (get) Token: 0x06031763 RID: 202595 RVA: 0x006B4B88 File Offset: 0x006B2D88
		public bool IsFixedPitch
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700D0ED RID: 53485
		// (get) Token: 0x06031764 RID: 202596 RVA: 0x006B4BC8 File Offset: 0x006B2DC8
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06031765 RID: 202597 RVA: 0x006B4C04 File Offset: 0x006B2E04
		public static Offset<IPositionDrivenMoveDriveMode> CreateIPositionDrivenMoveDriveMode(FlatBufferBuilder builder, ESplineMoveDriveMode Type = ESplineMoveDriveMode.InputDriven, bool IsFixedPitch = false, byte NullMask = 0)
		{
			builder.StartTable(3);
			IPositionDrivenMoveDriveMode.AddNullMask(builder, NullMask);
			IPositionDrivenMoveDriveMode.AddIsFixedPitch(builder, IsFixedPitch);
			IPositionDrivenMoveDriveMode.AddType(builder, Type);
			return IPositionDrivenMoveDriveMode.EndIPositionDrivenMoveDriveMode(builder);
		}

		// Token: 0x06031766 RID: 202598 RVA: 0x006B4C28 File Offset: 0x006B2E28
		public static void StartIPositionDrivenMoveDriveMode(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06031767 RID: 202599 RVA: 0x006B4C31 File Offset: 0x006B2E31
		public static void AddType(FlatBufferBuilder builder, ESplineMoveDriveMode type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06031768 RID: 202600 RVA: 0x006B4C3C File Offset: 0x006B2E3C
		public static void AddIsFixedPitch(FlatBufferBuilder builder, bool isFixedPitch)
		{
			builder.AddBool(1, isFixedPitch, false);
		}

		// Token: 0x06031769 RID: 202601 RVA: 0x006B4C47 File Offset: 0x006B2E47
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x0603176A RID: 202602 RVA: 0x006B4C52 File Offset: 0x006B2E52
		public static Offset<IPositionDrivenMoveDriveMode> EndIPositionDrivenMoveDriveMode(FlatBufferBuilder builder)
		{
			return new Offset<IPositionDrivenMoveDriveMode>(builder.EndTable());
		}

		// Token: 0x0603176B RID: 202603 RVA: 0x006B4C60 File Offset: 0x006B2E60
		public IPositionDrivenMoveDriveModeT UnPack()
		{
			IPositionDrivenMoveDriveModeT positionDrivenMoveDriveModeT = new IPositionDrivenMoveDriveModeT();
			this.UnPackTo(positionDrivenMoveDriveModeT);
			return positionDrivenMoveDriveModeT;
		}

		// Token: 0x0603176C RID: 202604 RVA: 0x006B4C7B File Offset: 0x006B2E7B
		public void UnPackTo(IPositionDrivenMoveDriveModeT _o)
		{
			_o.Type = this.Type;
			_o.IsFixedPitch = this.IsFixedPitch;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0603176D RID: 202605 RVA: 0x006B4CA4 File Offset: 0x006B2EA4
		public static Offset<IPositionDrivenMoveDriveMode> Pack(FlatBufferBuilder builder, IPositionDrivenMoveDriveModeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPositionDrivenMoveDriveMode>);
			}
			return IPositionDrivenMoveDriveMode.CreateIPositionDrivenMoveDriveMode(builder, _o.Type, _o.IsFixedPitch, _o.NullMask);
		}

		// Token: 0x04011725 RID: 71461
		private Table __p;
	}
}
