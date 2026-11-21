using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A8F RID: 23183
	public struct ILocationSafetyComponent : IFlatbufferObject
	{
		// Token: 0x1700A8F1 RID: 43249
		// (get) Token: 0x06025FF7 RID: 155639 RVA: 0x00535621 File Offset: 0x00533821
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06025FF8 RID: 155640 RVA: 0x0053562E File Offset: 0x0053382E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06025FF9 RID: 155641 RVA: 0x00535638 File Offset: 0x00533838
		public static ILocationSafetyComponent GetRootAsILocationSafetyComponent(ByteBuffer _bb)
		{
			return ILocationSafetyComponent.GetRootAsILocationSafetyComponent(_bb, default(ILocationSafetyComponent));
		}

		// Token: 0x06025FFA RID: 155642 RVA: 0x00535654 File Offset: 0x00533854
		public static ILocationSafetyComponent GetRootAsILocationSafetyComponent(ByteBuffer _bb, ILocationSafetyComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06025FFB RID: 155643 RVA: 0x00535671 File Offset: 0x00533871
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06025FFC RID: 155644 RVA: 0x00535680 File Offset: 0x00533880
		public ILocationSafetyComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A8F2 RID: 43250
		// (get) Token: 0x06025FFD RID: 155645 RVA: 0x00535690 File Offset: 0x00533890
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A8F3 RID: 43251
		// (get) Token: 0x06025FFE RID: 155646 RVA: 0x005356D0 File Offset: 0x005338D0
		public EDetectionFrequency DetectionFrequency
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return EDetectionFrequency.Low;
				}
				return (EDetectionFrequency)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A8F4 RID: 43252
		// (get) Token: 0x06025FFF RID: 155647 RVA: 0x0053570C File Offset: 0x0053390C
		public IVectorInfo? SafeLocation
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700A8F5 RID: 43253
		// (get) Token: 0x06026000 RID: 155648 RVA: 0x0053576C File Offset: 0x0053396C
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06026001 RID: 155649 RVA: 0x005357A9 File Offset: 0x005339A9
		public static Offset<ILocationSafetyComponent> CreateILocationSafetyComponent(FlatBufferBuilder builder, bool Disabled = false, EDetectionFrequency DetectionFrequency = EDetectionFrequency.Low, Offset<IVectorInfo> SafeLocationOffset = default(Offset<IVectorInfo>), byte NullMask = 0)
		{
			builder.StartTable(4);
			ILocationSafetyComponent.AddSafeLocation(builder, SafeLocationOffset);
			ILocationSafetyComponent.AddNullMask(builder, NullMask);
			ILocationSafetyComponent.AddDetectionFrequency(builder, DetectionFrequency);
			ILocationSafetyComponent.AddDisabled(builder, Disabled);
			return ILocationSafetyComponent.EndILocationSafetyComponent(builder);
		}

		// Token: 0x06026002 RID: 155650 RVA: 0x005357D5 File Offset: 0x005339D5
		public static void StartILocationSafetyComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06026003 RID: 155651 RVA: 0x005357DE File Offset: 0x005339DE
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06026004 RID: 155652 RVA: 0x005357E9 File Offset: 0x005339E9
		public static void AddDetectionFrequency(FlatBufferBuilder builder, EDetectionFrequency detectionFrequency)
		{
			builder.AddByte(1, (byte)detectionFrequency, 0);
		}

		// Token: 0x06026005 RID: 155653 RVA: 0x005357F4 File Offset: 0x005339F4
		public static void AddSafeLocation(FlatBufferBuilder builder, Offset<IVectorInfo> safeLocationOffset)
		{
			builder.AddOffset(2, safeLocationOffset.Value, 0);
		}

		// Token: 0x06026006 RID: 155654 RVA: 0x00535804 File Offset: 0x00533A04
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06026007 RID: 155655 RVA: 0x0053580F File Offset: 0x00533A0F
		public static Offset<ILocationSafetyComponent> EndILocationSafetyComponent(FlatBufferBuilder builder)
		{
			return new Offset<ILocationSafetyComponent>(builder.EndTable());
		}

		// Token: 0x06026008 RID: 155656 RVA: 0x0053581C File Offset: 0x00533A1C
		public ILocationSafetyComponentT UnPack()
		{
			ILocationSafetyComponentT locationSafetyComponentT = new ILocationSafetyComponentT();
			this.UnPackTo(locationSafetyComponentT);
			return locationSafetyComponentT;
		}

		// Token: 0x06026009 RID: 155657 RVA: 0x00535838 File Offset: 0x00533A38
		public void UnPackTo(ILocationSafetyComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.DetectionFrequency = this.DetectionFrequency;
			_o.SafeLocation = ((this.SafeLocation != null) ? this.SafeLocation.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602600A RID: 155658 RVA: 0x00535898 File Offset: 0x00533A98
		public static Offset<ILocationSafetyComponent> Pack(FlatBufferBuilder builder, ILocationSafetyComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILocationSafetyComponent>);
			}
			Offset<IVectorInfo> safeLocationOffset = (_o.SafeLocation == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.SafeLocation);
			return ILocationSafetyComponent.CreateILocationSafetyComponent(builder, _o.Disabled, _o.DetectionFrequency, safeLocationOffset, _o.NullMask);
		}

		// Token: 0x0400F429 RID: 62505
		private Table __p;
	}
}
