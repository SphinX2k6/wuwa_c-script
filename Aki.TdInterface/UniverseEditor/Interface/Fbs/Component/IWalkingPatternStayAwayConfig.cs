using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B4A RID: 23370
	public struct IWalkingPatternStayAwayConfig : IFlatbufferObject
	{
		// Token: 0x1700B074 RID: 45172
		// (get) Token: 0x06027F59 RID: 163673 RVA: 0x0057E7E3 File Offset: 0x0057C9E3
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06027F5A RID: 163674 RVA: 0x0057E7F0 File Offset: 0x0057C9F0
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06027F5B RID: 163675 RVA: 0x0057E7F8 File Offset: 0x0057C9F8
		public static IWalkingPatternStayAwayConfig GetRootAsIWalkingPatternStayAwayConfig(ByteBuffer _bb)
		{
			return IWalkingPatternStayAwayConfig.GetRootAsIWalkingPatternStayAwayConfig(_bb, default(IWalkingPatternStayAwayConfig));
		}

		// Token: 0x06027F5C RID: 163676 RVA: 0x0057E814 File Offset: 0x0057CA14
		public static IWalkingPatternStayAwayConfig GetRootAsIWalkingPatternStayAwayConfig(ByteBuffer _bb, IWalkingPatternStayAwayConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06027F5D RID: 163677 RVA: 0x0057E831 File Offset: 0x0057CA31
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06027F5E RID: 163678 RVA: 0x0057E840 File Offset: 0x0057CA40
		public IWalkingPatternStayAwayConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B075 RID: 45173
		// (get) Token: 0x06027F5F RID: 163679 RVA: 0x0057E850 File Offset: 0x0057CA50
		public int SplineDistance
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B076 RID: 45174
		// (get) Token: 0x06027F60 RID: 163680 RVA: 0x0057E88C File Offset: 0x0057CA8C
		public int StayAwayTime
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

		// Token: 0x1700B077 RID: 45175
		// (get) Token: 0x06027F61 RID: 163681 RVA: 0x0057E8C8 File Offset: 0x0057CAC8
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

		// Token: 0x06027F62 RID: 163682 RVA: 0x0057E904 File Offset: 0x0057CB04
		public static Offset<IWalkingPatternStayAwayConfig> CreateIWalkingPatternStayAwayConfig(FlatBufferBuilder builder, int SplineDistance = 0, int StayAwayTime = 0, byte NullMask = 0)
		{
			builder.StartTable(3);
			IWalkingPatternStayAwayConfig.AddStayAwayTime(builder, StayAwayTime);
			IWalkingPatternStayAwayConfig.AddSplineDistance(builder, SplineDistance);
			IWalkingPatternStayAwayConfig.AddNullMask(builder, NullMask);
			return IWalkingPatternStayAwayConfig.EndIWalkingPatternStayAwayConfig(builder);
		}

		// Token: 0x06027F63 RID: 163683 RVA: 0x0057E928 File Offset: 0x0057CB28
		public static void StartIWalkingPatternStayAwayConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06027F64 RID: 163684 RVA: 0x0057E931 File Offset: 0x0057CB31
		public static void AddSplineDistance(FlatBufferBuilder builder, int splineDistance)
		{
			builder.AddInt(0, splineDistance, 0);
		}

		// Token: 0x06027F65 RID: 163685 RVA: 0x0057E93C File Offset: 0x0057CB3C
		public static void AddStayAwayTime(FlatBufferBuilder builder, int stayAwayTime)
		{
			builder.AddInt(1, stayAwayTime, 0);
		}

		// Token: 0x06027F66 RID: 163686 RVA: 0x0057E947 File Offset: 0x0057CB47
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x06027F67 RID: 163687 RVA: 0x0057E952 File Offset: 0x0057CB52
		public static Offset<IWalkingPatternStayAwayConfig> EndIWalkingPatternStayAwayConfig(FlatBufferBuilder builder)
		{
			return new Offset<IWalkingPatternStayAwayConfig>(builder.EndTable());
		}

		// Token: 0x06027F68 RID: 163688 RVA: 0x0057E960 File Offset: 0x0057CB60
		public IWalkingPatternStayAwayConfigT UnPack()
		{
			IWalkingPatternStayAwayConfigT walkingPatternStayAwayConfigT = new IWalkingPatternStayAwayConfigT();
			this.UnPackTo(walkingPatternStayAwayConfigT);
			return walkingPatternStayAwayConfigT;
		}

		// Token: 0x06027F69 RID: 163689 RVA: 0x0057E97B File Offset: 0x0057CB7B
		public void UnPackTo(IWalkingPatternStayAwayConfigT _o)
		{
			_o.SplineDistance = this.SplineDistance;
			_o.StayAwayTime = this.StayAwayTime;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06027F6A RID: 163690 RVA: 0x0057E9A4 File Offset: 0x0057CBA4
		public static Offset<IWalkingPatternStayAwayConfig> Pack(FlatBufferBuilder builder, IWalkingPatternStayAwayConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IWalkingPatternStayAwayConfig>);
			}
			return IWalkingPatternStayAwayConfig.CreateIWalkingPatternStayAwayConfig(builder, _o.SplineDistance, _o.StayAwayTime, _o.NullMask);
		}

		// Token: 0x0400F282 RID: 62082
		private Table __p;
	}
}
