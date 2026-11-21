using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005406 RID: 21510
	public struct IAudioPointNearbyTracking : IFlatbufferObject
	{
		// Token: 0x17009850 RID: 38992
		// (get) Token: 0x06021A31 RID: 137777 RVA: 0x004A3182 File Offset: 0x004A1382
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06021A32 RID: 137778 RVA: 0x004A318F File Offset: 0x004A138F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06021A33 RID: 137779 RVA: 0x004A3198 File Offset: 0x004A1398
		public static IAudioPointNearbyTracking GetRootAsIAudioPointNearbyTracking(ByteBuffer _bb)
		{
			return IAudioPointNearbyTracking.GetRootAsIAudioPointNearbyTracking(_bb, default(IAudioPointNearbyTracking));
		}

		// Token: 0x06021A34 RID: 137780 RVA: 0x004A31B4 File Offset: 0x004A13B4
		public static IAudioPointNearbyTracking GetRootAsIAudioPointNearbyTracking(ByteBuffer _bb, IAudioPointNearbyTracking obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06021A35 RID: 137781 RVA: 0x004A31D1 File Offset: 0x004A13D1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06021A36 RID: 137782 RVA: 0x004A31E0 File Offset: 0x004A13E0
		public IAudioPointNearbyTracking __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009851 RID: 38993
		// (get) Token: 0x06021A37 RID: 137783 RVA: 0x004A31F0 File Offset: 0x004A13F0
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

		// Token: 0x17009852 RID: 38994
		// (get) Token: 0x06021A38 RID: 137784 RVA: 0x004A322C File Offset: 0x004A142C
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

		// Token: 0x17009853 RID: 38995
		// (get) Token: 0x06021A39 RID: 137785 RVA: 0x004A3268 File Offset: 0x004A1468
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

		// Token: 0x17009854 RID: 38996
		// (get) Token: 0x06021A3A RID: 137786 RVA: 0x004A32A4 File Offset: 0x004A14A4
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

		// Token: 0x06021A3B RID: 137787 RVA: 0x004A32E1 File Offset: 0x004A14E1
		public static Offset<IAudioPointNearbyTracking> CreateIAudioPointNearbyTracking(FlatBufferBuilder builder, ENearbyTrackingType Type = ENearbyTrackingType.Icon, int NearRadius = 0, int MiddleRadius = 0, int FarRadius = 0)
		{
			builder.StartTable(4);
			IAudioPointNearbyTracking.AddFarRadius(builder, FarRadius);
			IAudioPointNearbyTracking.AddMiddleRadius(builder, MiddleRadius);
			IAudioPointNearbyTracking.AddNearRadius(builder, NearRadius);
			IAudioPointNearbyTracking.AddType(builder, Type);
			return IAudioPointNearbyTracking.EndIAudioPointNearbyTracking(builder);
		}

		// Token: 0x06021A3C RID: 137788 RVA: 0x004A330D File Offset: 0x004A150D
		public static void StartIAudioPointNearbyTracking(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06021A3D RID: 137789 RVA: 0x004A3316 File Offset: 0x004A1516
		public static void AddType(FlatBufferBuilder builder, ENearbyTrackingType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06021A3E RID: 137790 RVA: 0x004A3321 File Offset: 0x004A1521
		public static void AddNearRadius(FlatBufferBuilder builder, int nearRadius)
		{
			builder.AddInt(1, nearRadius, 0);
		}

		// Token: 0x06021A3F RID: 137791 RVA: 0x004A332C File Offset: 0x004A152C
		public static void AddMiddleRadius(FlatBufferBuilder builder, int middleRadius)
		{
			builder.AddInt(2, middleRadius, 0);
		}

		// Token: 0x06021A40 RID: 137792 RVA: 0x004A3337 File Offset: 0x004A1537
		public static void AddFarRadius(FlatBufferBuilder builder, int farRadius)
		{
			builder.AddInt(3, farRadius, 0);
		}

		// Token: 0x06021A41 RID: 137793 RVA: 0x004A3342 File Offset: 0x004A1542
		public static Offset<IAudioPointNearbyTracking> EndIAudioPointNearbyTracking(FlatBufferBuilder builder)
		{
			return new Offset<IAudioPointNearbyTracking>(builder.EndTable());
		}

		// Token: 0x06021A42 RID: 137794 RVA: 0x004A3350 File Offset: 0x004A1550
		public IAudioPointNearbyTrackingT UnPack()
		{
			IAudioPointNearbyTrackingT audioPointNearbyTrackingT = new IAudioPointNearbyTrackingT();
			this.UnPackTo(audioPointNearbyTrackingT);
			return audioPointNearbyTrackingT;
		}

		// Token: 0x06021A43 RID: 137795 RVA: 0x004A336B File Offset: 0x004A156B
		public void UnPackTo(IAudioPointNearbyTrackingT _o)
		{
			_o.Type = this.Type;
			_o.NearRadius = this.NearRadius;
			_o.MiddleRadius = this.MiddleRadius;
			_o.FarRadius = this.FarRadius;
		}

		// Token: 0x06021A44 RID: 137796 RVA: 0x004A33A0 File Offset: 0x004A15A0
		public static Offset<IAudioPointNearbyTracking> Pack(FlatBufferBuilder builder, IAudioPointNearbyTrackingT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAudioPointNearbyTracking>);
			}
			return IAudioPointNearbyTracking.CreateIAudioPointNearbyTracking(builder, _o.Type, _o.NearRadius, _o.MiddleRadius, _o.FarRadius);
		}

		// Token: 0x0400E885 RID: 59525
		private Table __p;
	}
}
