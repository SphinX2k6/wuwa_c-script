using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004ED7 RID: 20183
	public struct IAudioPointNearbyTracking : IFlatbufferObject
	{
		// Token: 0x170090DD RID: 37085
		// (get) Token: 0x0601FCED RID: 130285 RVA: 0x0046D3B2 File Offset: 0x0046B5B2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601FCEE RID: 130286 RVA: 0x0046D3BF File Offset: 0x0046B5BF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601FCEF RID: 130287 RVA: 0x0046D3C8 File Offset: 0x0046B5C8
		public static IAudioPointNearbyTracking GetRootAsIAudioPointNearbyTracking(ByteBuffer _bb)
		{
			return IAudioPointNearbyTracking.GetRootAsIAudioPointNearbyTracking(_bb, default(IAudioPointNearbyTracking));
		}

		// Token: 0x0601FCF0 RID: 130288 RVA: 0x0046D3E4 File Offset: 0x0046B5E4
		public static IAudioPointNearbyTracking GetRootAsIAudioPointNearbyTracking(ByteBuffer _bb, IAudioPointNearbyTracking obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601FCF1 RID: 130289 RVA: 0x0046D401 File Offset: 0x0046B601
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601FCF2 RID: 130290 RVA: 0x0046D410 File Offset: 0x0046B610
		public IAudioPointNearbyTracking __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170090DE RID: 37086
		// (get) Token: 0x0601FCF3 RID: 130291 RVA: 0x0046D420 File Offset: 0x0046B620
		public ENearbyTrackingType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ENearbyTrackingType.Icon;
				}
				return (ENearbyTrackingType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170090DF RID: 37087
		// (get) Token: 0x0601FCF4 RID: 130292 RVA: 0x0046D45C File Offset: 0x0046B65C
		public int NearRadius
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170090E0 RID: 37088
		// (get) Token: 0x0601FCF5 RID: 130293 RVA: 0x0046D498 File Offset: 0x0046B698
		public int MiddleRadius
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170090E1 RID: 37089
		// (get) Token: 0x0601FCF6 RID: 130294 RVA: 0x0046D4D4 File Offset: 0x0046B6D4
		public int FarRadius
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601FCF7 RID: 130295 RVA: 0x0046D511 File Offset: 0x0046B711
		public static Offset<IAudioPointNearbyTracking> CreateIAudioPointNearbyTracking(FlatBufferBuilder builder, ENearbyTrackingType Type = ENearbyTrackingType.Icon, int NearRadius = 0, int MiddleRadius = 0, int FarRadius = 0)
		{
			builder.StartTable(4);
			IAudioPointNearbyTracking.AddFarRadius(builder, FarRadius);
			IAudioPointNearbyTracking.AddMiddleRadius(builder, MiddleRadius);
			IAudioPointNearbyTracking.AddNearRadius(builder, NearRadius);
			IAudioPointNearbyTracking.AddType(builder, Type);
			return IAudioPointNearbyTracking.EndIAudioPointNearbyTracking(builder);
		}

		// Token: 0x0601FCF8 RID: 130296 RVA: 0x0046D53D File Offset: 0x0046B73D
		public static void StartIAudioPointNearbyTracking(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601FCF9 RID: 130297 RVA: 0x0046D546 File Offset: 0x0046B746
		public static void AddType(FlatBufferBuilder builder, ENearbyTrackingType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601FCFA RID: 130298 RVA: 0x0046D551 File Offset: 0x0046B751
		public static void AddNearRadius(FlatBufferBuilder builder, int nearRadius)
		{
			builder.AddInt(1, nearRadius, 0);
		}

		// Token: 0x0601FCFB RID: 130299 RVA: 0x0046D55C File Offset: 0x0046B75C
		public static void AddMiddleRadius(FlatBufferBuilder builder, int middleRadius)
		{
			builder.AddInt(2, middleRadius, 0);
		}

		// Token: 0x0601FCFC RID: 130300 RVA: 0x0046D567 File Offset: 0x0046B767
		public static void AddFarRadius(FlatBufferBuilder builder, int farRadius)
		{
			builder.AddInt(3, farRadius, 0);
		}

		// Token: 0x0601FCFD RID: 130301 RVA: 0x0046D572 File Offset: 0x0046B772
		public static Offset<IAudioPointNearbyTracking> EndIAudioPointNearbyTracking(FlatBufferBuilder builder)
		{
			return new Offset<IAudioPointNearbyTracking>(builder.EndTable());
		}

		// Token: 0x0601FCFE RID: 130302 RVA: 0x0046D580 File Offset: 0x0046B780
		public IAudioPointNearbyTrackingT UnPack()
		{
			IAudioPointNearbyTrackingT audioPointNearbyTrackingT = new IAudioPointNearbyTrackingT();
			this.UnPackTo(audioPointNearbyTrackingT);
			return audioPointNearbyTrackingT;
		}

		// Token: 0x0601FCFF RID: 130303 RVA: 0x0046D59B File Offset: 0x0046B79B
		public void UnPackTo(IAudioPointNearbyTrackingT _o)
		{
			_o.Type = this.Type;
			_o.NearRadius = this.NearRadius;
			_o.MiddleRadius = this.MiddleRadius;
			_o.FarRadius = this.FarRadius;
		}

		// Token: 0x0601FD00 RID: 130304 RVA: 0x0046D5D0 File Offset: 0x0046B7D0
		public static Offset<IAudioPointNearbyTracking> Pack(FlatBufferBuilder builder, IAudioPointNearbyTrackingT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAudioPointNearbyTracking>);
			}
			return IAudioPointNearbyTracking.CreateIAudioPointNearbyTracking(builder, _o.Type, _o.NearRadius, _o.MiddleRadius, _o.FarRadius);
		}

		// Token: 0x0400DCDE RID: 56542
		private Table __p;
	}
}
