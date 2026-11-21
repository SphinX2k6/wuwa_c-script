using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020055DA RID: 21978
	public struct IDarkTideNearbyTracking : IFlatbufferObject
	{
		// Token: 0x17009D5B RID: 40283
		// (get) Token: 0x06022F99 RID: 143257 RVA: 0x004D034E File Offset: 0x004CE54E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06022F9A RID: 143258 RVA: 0x004D035B File Offset: 0x004CE55B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06022F9B RID: 143259 RVA: 0x004D0364 File Offset: 0x004CE564
		public static IDarkTideNearbyTracking GetRootAsIDarkTideNearbyTracking(ByteBuffer _bb)
		{
			return IDarkTideNearbyTracking.GetRootAsIDarkTideNearbyTracking(_bb, default(IDarkTideNearbyTracking));
		}

		// Token: 0x06022F9C RID: 143260 RVA: 0x004D0380 File Offset: 0x004CE580
		public static IDarkTideNearbyTracking GetRootAsIDarkTideNearbyTracking(ByteBuffer _bb, IDarkTideNearbyTracking obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06022F9D RID: 143261 RVA: 0x004D039D File Offset: 0x004CE59D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06022F9E RID: 143262 RVA: 0x004D03AC File Offset: 0x004CE5AC
		public IDarkTideNearbyTracking __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009D5C RID: 40284
		// (get) Token: 0x06022F9F RID: 143263 RVA: 0x004D03BC File Offset: 0x004CE5BC
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

		// Token: 0x17009D5D RID: 40285
		// (get) Token: 0x06022FA0 RID: 143264 RVA: 0x004D03F8 File Offset: 0x004CE5F8
		public int ShowRange
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

		// Token: 0x17009D5E RID: 40286
		// (get) Token: 0x06022FA1 RID: 143265 RVA: 0x004D0434 File Offset: 0x004CE634
		public int HideRange
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

		// Token: 0x06022FA2 RID: 143266 RVA: 0x004D0470 File Offset: 0x004CE670
		public static Offset<IDarkTideNearbyTracking> CreateIDarkTideNearbyTracking(FlatBufferBuilder builder, ENearbyTrackingType Type = ENearbyTrackingType.Icon, int ShowRange = 0, int HideRange = 0)
		{
			builder.StartTable(3);
			IDarkTideNearbyTracking.AddHideRange(builder, HideRange);
			IDarkTideNearbyTracking.AddShowRange(builder, ShowRange);
			IDarkTideNearbyTracking.AddType(builder, Type);
			return IDarkTideNearbyTracking.EndIDarkTideNearbyTracking(builder);
		}

		// Token: 0x06022FA3 RID: 143267 RVA: 0x004D0494 File Offset: 0x004CE694
		public static void StartIDarkTideNearbyTracking(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06022FA4 RID: 143268 RVA: 0x004D049D File Offset: 0x004CE69D
		public static void AddType(FlatBufferBuilder builder, ENearbyTrackingType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06022FA5 RID: 143269 RVA: 0x004D04A8 File Offset: 0x004CE6A8
		public static void AddShowRange(FlatBufferBuilder builder, int showRange)
		{
			builder.AddInt(1, showRange, 0);
		}

		// Token: 0x06022FA6 RID: 143270 RVA: 0x004D04B3 File Offset: 0x004CE6B3
		public static void AddHideRange(FlatBufferBuilder builder, int hideRange)
		{
			builder.AddInt(2, hideRange, 0);
		}

		// Token: 0x06022FA7 RID: 143271 RVA: 0x004D04BE File Offset: 0x004CE6BE
		public static Offset<IDarkTideNearbyTracking> EndIDarkTideNearbyTracking(FlatBufferBuilder builder)
		{
			return new Offset<IDarkTideNearbyTracking>(builder.EndTable());
		}

		// Token: 0x06022FA8 RID: 143272 RVA: 0x004D04CC File Offset: 0x004CE6CC
		public IDarkTideNearbyTrackingT UnPack()
		{
			IDarkTideNearbyTrackingT darkTideNearbyTrackingT = new IDarkTideNearbyTrackingT();
			this.UnPackTo(darkTideNearbyTrackingT);
			return darkTideNearbyTrackingT;
		}

		// Token: 0x06022FA9 RID: 143273 RVA: 0x004D04E7 File Offset: 0x004CE6E7
		public void UnPackTo(IDarkTideNearbyTrackingT _o)
		{
			_o.Type = this.Type;
			_o.ShowRange = this.ShowRange;
			_o.HideRange = this.HideRange;
		}

		// Token: 0x06022FAA RID: 143274 RVA: 0x004D0510 File Offset: 0x004CE710
		public static Offset<IDarkTideNearbyTracking> Pack(FlatBufferBuilder builder, IDarkTideNearbyTrackingT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDarkTideNearbyTracking>);
			}
			return IDarkTideNearbyTracking.CreateIDarkTideNearbyTracking(builder, _o.Type, _o.ShowRange, _o.HideRange);
		}

		// Token: 0x0400EC75 RID: 60533
		private Table __p;
	}
}
