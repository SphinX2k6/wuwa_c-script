using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200464C RID: 17996
	public struct ITrackEffectAutoChange : IFlatbufferObject
	{
		// Token: 0x17007E02 RID: 32258
		// (get) Token: 0x0601A5DC RID: 107996 RVA: 0x003C0E4F File Offset: 0x003BF04F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601A5DD RID: 107997 RVA: 0x003C0E5C File Offset: 0x003BF05C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601A5DE RID: 107998 RVA: 0x003C0E64 File Offset: 0x003BF064
		public static ITrackEffectAutoChange GetRootAsITrackEffectAutoChange(ByteBuffer _bb)
		{
			return ITrackEffectAutoChange.GetRootAsITrackEffectAutoChange(_bb, default(ITrackEffectAutoChange));
		}

		// Token: 0x0601A5DF RID: 107999 RVA: 0x003C0E80 File Offset: 0x003BF080
		public static ITrackEffectAutoChange GetRootAsITrackEffectAutoChange(ByteBuffer _bb, ITrackEffectAutoChange obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601A5E0 RID: 108000 RVA: 0x003C0E9D File Offset: 0x003BF09D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601A5E1 RID: 108001 RVA: 0x003C0EAC File Offset: 0x003BF0AC
		public ITrackEffectAutoChange __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007E03 RID: 32259
		// (get) Token: 0x0601A5E2 RID: 108002 RVA: 0x003C0EBC File Offset: 0x003BF0BC
		public ETrackEffectType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETrackEffectType.AutoChange;
				}
				return (ETrackEffectType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007E04 RID: 32260
		// (get) Token: 0x0601A5E3 RID: 108003 RVA: 0x003C0EF8 File Offset: 0x003BF0F8
		public int EnterRange
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

		// Token: 0x17007E05 RID: 32261
		// (get) Token: 0x0601A5E4 RID: 108004 RVA: 0x003C0F34 File Offset: 0x003BF134
		public int LeaveRange
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

		// Token: 0x0601A5E5 RID: 108005 RVA: 0x003C0F70 File Offset: 0x003BF170
		public static Offset<ITrackEffectAutoChange> CreateITrackEffectAutoChange(FlatBufferBuilder builder, ETrackEffectType Type = ETrackEffectType.AutoChange, int EnterRange = 0, int LeaveRange = 0)
		{
			builder.StartTable(3);
			ITrackEffectAutoChange.AddLeaveRange(builder, LeaveRange);
			ITrackEffectAutoChange.AddEnterRange(builder, EnterRange);
			ITrackEffectAutoChange.AddType(builder, Type);
			return ITrackEffectAutoChange.EndITrackEffectAutoChange(builder);
		}

		// Token: 0x0601A5E6 RID: 108006 RVA: 0x003C0F94 File Offset: 0x003BF194
		public static void StartITrackEffectAutoChange(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601A5E7 RID: 108007 RVA: 0x003C0F9D File Offset: 0x003BF19D
		public static void AddType(FlatBufferBuilder builder, ETrackEffectType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601A5E8 RID: 108008 RVA: 0x003C0FA8 File Offset: 0x003BF1A8
		public static void AddEnterRange(FlatBufferBuilder builder, int enterRange)
		{
			builder.AddInt(1, enterRange, 0);
		}

		// Token: 0x0601A5E9 RID: 108009 RVA: 0x003C0FB3 File Offset: 0x003BF1B3
		public static void AddLeaveRange(FlatBufferBuilder builder, int leaveRange)
		{
			builder.AddInt(2, leaveRange, 0);
		}

		// Token: 0x0601A5EA RID: 108010 RVA: 0x003C0FBE File Offset: 0x003BF1BE
		public static Offset<ITrackEffectAutoChange> EndITrackEffectAutoChange(FlatBufferBuilder builder)
		{
			return new Offset<ITrackEffectAutoChange>(builder.EndTable());
		}

		// Token: 0x0601A5EB RID: 108011 RVA: 0x003C0FCC File Offset: 0x003BF1CC
		public ITrackEffectAutoChangeT UnPack()
		{
			ITrackEffectAutoChangeT trackEffectAutoChangeT = new ITrackEffectAutoChangeT();
			this.UnPackTo(trackEffectAutoChangeT);
			return trackEffectAutoChangeT;
		}

		// Token: 0x0601A5EC RID: 108012 RVA: 0x003C0FE7 File Offset: 0x003BF1E7
		public void UnPackTo(ITrackEffectAutoChangeT _o)
		{
			_o.Type = this.Type;
			_o.EnterRange = this.EnterRange;
			_o.LeaveRange = this.LeaveRange;
		}

		// Token: 0x0601A5ED RID: 108013 RVA: 0x003C1010 File Offset: 0x003BF210
		public static Offset<ITrackEffectAutoChange> Pack(FlatBufferBuilder builder, ITrackEffectAutoChangeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITrackEffectAutoChange>);
			}
			return ITrackEffectAutoChange.CreateITrackEffectAutoChange(builder, _o.Type, _o.EnterRange, _o.LeaveRange);
		}

		// Token: 0x0400C85B RID: 51291
		private Table __p;
	}
}
