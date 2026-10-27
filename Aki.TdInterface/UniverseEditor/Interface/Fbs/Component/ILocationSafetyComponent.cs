using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005509 RID: 21769
	public struct ILocationSafetyComponent : IFlatbufferObject
	{
		// Token: 0x1700A0B7 RID: 41143
		// (get) Token: 0x06023F3D RID: 147261 RVA: 0x004F84FD File Offset: 0x004F66FD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06023F3E RID: 147262 RVA: 0x004F850A File Offset: 0x004F670A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06023F3F RID: 147263 RVA: 0x004F8514 File Offset: 0x004F6714
		public static ILocationSafetyComponent GetRootAsILocationSafetyComponent(ByteBuffer _bb)
		{
			return ILocationSafetyComponent.GetRootAsILocationSafetyComponent(_bb, default(ILocationSafetyComponent));
		}

		// Token: 0x06023F40 RID: 147264 RVA: 0x004F8530 File Offset: 0x004F6730
		public static ILocationSafetyComponent GetRootAsILocationSafetyComponent(ByteBuffer _bb, ILocationSafetyComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06023F41 RID: 147265 RVA: 0x004F854D File Offset: 0x004F674D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06023F42 RID: 147266 RVA: 0x004F855C File Offset: 0x004F675C
		public ILocationSafetyComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A0B8 RID: 41144
		// (get) Token: 0x06023F43 RID: 147267 RVA: 0x004F856C File Offset: 0x004F676C
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A0B9 RID: 41145
		// (get) Token: 0x06023F44 RID: 147268 RVA: 0x004F85AC File Offset: 0x004F67AC
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

		// Token: 0x1700A0BA RID: 41146
		// (get) Token: 0x06023F45 RID: 147269 RVA: 0x004F85E8 File Offset: 0x004F67E8
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

		// Token: 0x1700A0BB RID: 41147
		// (get) Token: 0x06023F46 RID: 147270 RVA: 0x004F8648 File Offset: 0x004F6848
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

		// Token: 0x06023F47 RID: 147271 RVA: 0x004F8685 File Offset: 0x004F6885
		public static Offset<ILocationSafetyComponent> CreateILocationSafetyComponent(FlatBufferBuilder builder, bool Disabled = false, EDetectionFrequency DetectionFrequency = EDetectionFrequency.Low, Offset<IVectorInfo> SafeLocationOffset = default(Offset<IVectorInfo>), byte NullMask = 0)
		{
			builder.StartTable(4);
			ILocationSafetyComponent.AddSafeLocation(builder, SafeLocationOffset);
			ILocationSafetyComponent.AddNullMask(builder, NullMask);
			ILocationSafetyComponent.AddDetectionFrequency(builder, DetectionFrequency);
			ILocationSafetyComponent.AddDisabled(builder, Disabled);
			return ILocationSafetyComponent.EndILocationSafetyComponent(builder);
		}

		// Token: 0x06023F48 RID: 147272 RVA: 0x004F86B1 File Offset: 0x004F68B1
		public static void StartILocationSafetyComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06023F49 RID: 147273 RVA: 0x004F86BA File Offset: 0x004F68BA
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06023F4A RID: 147274 RVA: 0x004F86C5 File Offset: 0x004F68C5
		public static void AddDetectionFrequency(FlatBufferBuilder builder, EDetectionFrequency detectionFrequency)
		{
			builder.AddByte(1, (byte)detectionFrequency, 0);
		}

		// Token: 0x06023F4B RID: 147275 RVA: 0x004F86D0 File Offset: 0x004F68D0
		public static void AddSafeLocation(FlatBufferBuilder builder, Offset<IVectorInfo> safeLocationOffset)
		{
			builder.AddOffset(2, safeLocationOffset.Value, 0);
		}

		// Token: 0x06023F4C RID: 147276 RVA: 0x004F86E0 File Offset: 0x004F68E0
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06023F4D RID: 147277 RVA: 0x004F86EB File Offset: 0x004F68EB
		public static Offset<ILocationSafetyComponent> EndILocationSafetyComponent(FlatBufferBuilder builder)
		{
			return new Offset<ILocationSafetyComponent>(builder.EndTable());
		}

		// Token: 0x06023F4E RID: 147278 RVA: 0x004F86F8 File Offset: 0x004F68F8
		public ILocationSafetyComponentT UnPack()
		{
			ILocationSafetyComponentT locationSafetyComponentT = new ILocationSafetyComponentT();
			this.UnPackTo(locationSafetyComponentT);
			return locationSafetyComponentT;
		}

		// Token: 0x06023F4F RID: 147279 RVA: 0x004F8714 File Offset: 0x004F6914
		public void UnPackTo(ILocationSafetyComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.DetectionFrequency = this.DetectionFrequency;
			_o.SafeLocation = ((this.SafeLocation != null) ? this.SafeLocation.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06023F50 RID: 147280 RVA: 0x004F8774 File Offset: 0x004F6974
		public static Offset<ILocationSafetyComponent> Pack(FlatBufferBuilder builder, ILocationSafetyComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILocationSafetyComponent>);
			}
			Offset<IVectorInfo> safeLocationOffset = (_o.SafeLocation == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.SafeLocation);
			return ILocationSafetyComponent.CreateILocationSafetyComponent(builder, _o.Disabled, _o.DetectionFrequency, safeLocationOffset, _o.NullMask);
		}

		// Token: 0x0400E7F8 RID: 59384
		private Table __p;
	}
}
