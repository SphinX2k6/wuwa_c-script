using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020062AB RID: 25259
	public struct ICaptionParam : IFlatbufferObject
	{
		// Token: 0x1700BC8A RID: 48266
		// (get) Token: 0x0602BA49 RID: 178761 RVA: 0x00601DFC File Offset: 0x005FFFFC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602BA4A RID: 178762 RVA: 0x00601E09 File Offset: 0x00600009
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602BA4B RID: 178763 RVA: 0x00601E10 File Offset: 0x00600010
		public static ICaptionParam GetRootAsICaptionParam(ByteBuffer _bb)
		{
			return ICaptionParam.GetRootAsICaptionParam(_bb, default(ICaptionParam));
		}

		// Token: 0x0602BA4C RID: 178764 RVA: 0x00601E2C File Offset: 0x0060002C
		public static ICaptionParam GetRootAsICaptionParam(ByteBuffer _bb, ICaptionParam obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602BA4D RID: 178765 RVA: 0x00601E49 File Offset: 0x00600049
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602BA4E RID: 178766 RVA: 0x00601E58 File Offset: 0x00600058
		public ICaptionParam __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BC8B RID: 48267
		// (get) Token: 0x0602BA4F RID: 178767 RVA: 0x00601E68 File Offset: 0x00600068
		public float StartTime
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700BC8C RID: 48268
		// (get) Token: 0x0602BA50 RID: 178768 RVA: 0x00601EA8 File Offset: 0x006000A8
		public float TotalTime
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700BC8D RID: 48269
		// (get) Token: 0x0602BA51 RID: 178769 RVA: 0x00601EE8 File Offset: 0x006000E8
		public float IntervalTime
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700BC8E RID: 48270
		// (get) Token: 0x0602BA52 RID: 178770 RVA: 0x00601F28 File Offset: 0x00600128
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

		// Token: 0x0602BA53 RID: 178771 RVA: 0x00601F65 File Offset: 0x00600165
		public static Offset<ICaptionParam> CreateICaptionParam(FlatBufferBuilder builder, float StartTime = 0f, float TotalTime = 0f, float IntervalTime = 0f, byte NullMask = 0)
		{
			builder.StartTable(4);
			ICaptionParam.AddIntervalTime(builder, IntervalTime);
			ICaptionParam.AddTotalTime(builder, TotalTime);
			ICaptionParam.AddStartTime(builder, StartTime);
			ICaptionParam.AddNullMask(builder, NullMask);
			return ICaptionParam.EndICaptionParam(builder);
		}

		// Token: 0x0602BA54 RID: 178772 RVA: 0x00601F91 File Offset: 0x00600191
		public static void StartICaptionParam(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0602BA55 RID: 178773 RVA: 0x00601F9A File Offset: 0x0060019A
		public static void AddStartTime(FlatBufferBuilder builder, float startTime)
		{
			builder.AddFloat(0, startTime, 0.0);
		}

		// Token: 0x0602BA56 RID: 178774 RVA: 0x00601FAD File Offset: 0x006001AD
		public static void AddTotalTime(FlatBufferBuilder builder, float totalTime)
		{
			builder.AddFloat(1, totalTime, 0.0);
		}

		// Token: 0x0602BA57 RID: 178775 RVA: 0x00601FC0 File Offset: 0x006001C0
		public static void AddIntervalTime(FlatBufferBuilder builder, float intervalTime)
		{
			builder.AddFloat(2, intervalTime, 0.0);
		}

		// Token: 0x0602BA58 RID: 178776 RVA: 0x00601FD3 File Offset: 0x006001D3
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x0602BA59 RID: 178777 RVA: 0x00601FDE File Offset: 0x006001DE
		public static Offset<ICaptionParam> EndICaptionParam(FlatBufferBuilder builder)
		{
			return new Offset<ICaptionParam>(builder.EndTable());
		}

		// Token: 0x0602BA5A RID: 178778 RVA: 0x00601FEC File Offset: 0x006001EC
		public ICaptionParamT UnPack()
		{
			ICaptionParamT captionParamT = new ICaptionParamT();
			this.UnPackTo(captionParamT);
			return captionParamT;
		}

		// Token: 0x0602BA5B RID: 178779 RVA: 0x00602007 File Offset: 0x00600207
		public void UnPackTo(ICaptionParamT _o)
		{
			_o.StartTime = this.StartTime;
			_o.TotalTime = this.TotalTime;
			_o.IntervalTime = this.IntervalTime;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602BA5C RID: 178780 RVA: 0x0060203C File Offset: 0x0060023C
		public static Offset<ICaptionParam> Pack(FlatBufferBuilder builder, ICaptionParamT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICaptionParam>);
			}
			return ICaptionParam.CreateICaptionParam(builder, _o.StartTime, _o.TotalTime, _o.IntervalTime, _o.NullMask);
		}

		// Token: 0x04010846 RID: 67654
		private Table __p;
	}
}
