using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007E00 RID: 32256
	public struct IVisualNovelTransitionTime : IFlatbufferObject
	{
		// Token: 0x1700F197 RID: 61847
		// (get) Token: 0x0603A499 RID: 238745 RVA: 0x007DA6E4 File Offset: 0x007D88E4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603A49A RID: 238746 RVA: 0x007DA6F1 File Offset: 0x007D88F1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603A49B RID: 238747 RVA: 0x007DA6F8 File Offset: 0x007D88F8
		public static IVisualNovelTransitionTime GetRootAsIVisualNovelTransitionTime(ByteBuffer _bb)
		{
			return IVisualNovelTransitionTime.GetRootAsIVisualNovelTransitionTime(_bb, default(IVisualNovelTransitionTime));
		}

		// Token: 0x0603A49C RID: 238748 RVA: 0x007DA714 File Offset: 0x007D8914
		public static IVisualNovelTransitionTime GetRootAsIVisualNovelTransitionTime(ByteBuffer _bb, IVisualNovelTransitionTime obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603A49D RID: 238749 RVA: 0x007DA731 File Offset: 0x007D8931
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603A49E RID: 238750 RVA: 0x007DA740 File Offset: 0x007D8940
		public IVisualNovelTransitionTime __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700F198 RID: 61848
		// (get) Token: 0x0603A49F RID: 238751 RVA: 0x007DA750 File Offset: 0x007D8950
		public EVisualNovelTransitionType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EVisualNovelTransitionType.Location;
				}
				return (EVisualNovelTransitionType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700F199 RID: 61849
		// (get) Token: 0x0603A4A0 RID: 238752 RVA: 0x007DA78C File Offset: 0x007D898C
		public IVisualNovelDate? EndDate
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IVisualNovelDate?(default(IVisualNovelDate).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700F19A RID: 61850
		// (get) Token: 0x0603A4A1 RID: 238753 RVA: 0x007DA7EC File Offset: 0x007D89EC
		public int EndPeriodId
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

		// Token: 0x1700F19B RID: 61851
		// (get) Token: 0x0603A4A2 RID: 238754 RVA: 0x007DA828 File Offset: 0x007D8A28
		public bool IsFullScreen
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700F19C RID: 61852
		// (get) Token: 0x0603A4A3 RID: 238755 RVA: 0x007DA868 File Offset: 0x007D8A68
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603A4A4 RID: 238756 RVA: 0x007DA8A5 File Offset: 0x007D8AA5
		public static Offset<IVisualNovelTransitionTime> CreateIVisualNovelTransitionTime(FlatBufferBuilder builder, EVisualNovelTransitionType Type = EVisualNovelTransitionType.Location, Offset<IVisualNovelDate> EndDateOffset = default(Offset<IVisualNovelDate>), int EndPeriodId = 0, bool IsFullScreen = false, byte NullMask = 0)
		{
			builder.StartTable(5);
			IVisualNovelTransitionTime.AddEndPeriodId(builder, EndPeriodId);
			IVisualNovelTransitionTime.AddEndDate(builder, EndDateOffset);
			IVisualNovelTransitionTime.AddNullMask(builder, NullMask);
			IVisualNovelTransitionTime.AddIsFullScreen(builder, IsFullScreen);
			IVisualNovelTransitionTime.AddType(builder, Type);
			return IVisualNovelTransitionTime.EndIVisualNovelTransitionTime(builder);
		}

		// Token: 0x0603A4A5 RID: 238757 RVA: 0x007DA8D9 File Offset: 0x007D8AD9
		public static void StartIVisualNovelTransitionTime(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0603A4A6 RID: 238758 RVA: 0x007DA8E2 File Offset: 0x007D8AE2
		public static void AddType(FlatBufferBuilder builder, EVisualNovelTransitionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603A4A7 RID: 238759 RVA: 0x007DA8ED File Offset: 0x007D8AED
		public static void AddEndDate(FlatBufferBuilder builder, Offset<IVisualNovelDate> endDateOffset)
		{
			builder.AddOffset(1, endDateOffset.Value, 0);
		}

		// Token: 0x0603A4A8 RID: 238760 RVA: 0x007DA8FD File Offset: 0x007D8AFD
		public static void AddEndPeriodId(FlatBufferBuilder builder, int endPeriodId)
		{
			builder.AddInt(2, endPeriodId, 0);
		}

		// Token: 0x0603A4A9 RID: 238761 RVA: 0x007DA908 File Offset: 0x007D8B08
		public static void AddIsFullScreen(FlatBufferBuilder builder, bool isFullScreen)
		{
			builder.AddBool(3, isFullScreen, false);
		}

		// Token: 0x0603A4AA RID: 238762 RVA: 0x007DA913 File Offset: 0x007D8B13
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x0603A4AB RID: 238763 RVA: 0x007DA91E File Offset: 0x007D8B1E
		public static Offset<IVisualNovelTransitionTime> EndIVisualNovelTransitionTime(FlatBufferBuilder builder)
		{
			return new Offset<IVisualNovelTransitionTime>(builder.EndTable());
		}

		// Token: 0x0603A4AC RID: 238764 RVA: 0x007DA92C File Offset: 0x007D8B2C
		public IVisualNovelTransitionTimeT UnPack()
		{
			IVisualNovelTransitionTimeT visualNovelTransitionTimeT = new IVisualNovelTransitionTimeT();
			this.UnPackTo(visualNovelTransitionTimeT);
			return visualNovelTransitionTimeT;
		}

		// Token: 0x0603A4AD RID: 238765 RVA: 0x007DA948 File Offset: 0x007D8B48
		public void UnPackTo(IVisualNovelTransitionTimeT _o)
		{
			_o.Type = this.Type;
			_o.EndDate = ((this.EndDate != null) ? this.EndDate.Value.UnPack() : null);
			_o.EndPeriodId = this.EndPeriodId;
			_o.IsFullScreen = this.IsFullScreen;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0603A4AE RID: 238766 RVA: 0x007DA9B4 File Offset: 0x007D8BB4
		public static Offset<IVisualNovelTransitionTime> Pack(FlatBufferBuilder builder, IVisualNovelTransitionTimeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVisualNovelTransitionTime>);
			}
			Offset<IVisualNovelDate> endDateOffset = (_o.EndDate == null) ? default(Offset<IVisualNovelDate>) : IVisualNovelDate.Pack(builder, _o.EndDate);
			return IVisualNovelTransitionTime.CreateIVisualNovelTransitionTime(builder, _o.Type, endDateOffset, _o.EndPeriodId, _o.IsFullScreen, _o.NullMask);
		}

		// Token: 0x040135AA RID: 79274
		private Table __p;
	}
}
