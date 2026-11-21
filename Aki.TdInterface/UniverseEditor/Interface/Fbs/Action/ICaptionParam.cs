using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200691C RID: 26908
	public struct ICaptionParam : IFlatbufferObject
	{
		// Token: 0x1700C612 RID: 50706
		// (get) Token: 0x0602E1AA RID: 188842 RVA: 0x0064CC04 File Offset: 0x0064AE04
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E1AB RID: 188843 RVA: 0x0064CC11 File Offset: 0x0064AE11
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E1AC RID: 188844 RVA: 0x0064CC18 File Offset: 0x0064AE18
		public static ICaptionParam GetRootAsICaptionParam(ByteBuffer _bb)
		{
			return ICaptionParam.GetRootAsICaptionParam(_bb, default(ICaptionParam));
		}

		// Token: 0x0602E1AD RID: 188845 RVA: 0x0064CC34 File Offset: 0x0064AE34
		public static ICaptionParam GetRootAsICaptionParam(ByteBuffer _bb, ICaptionParam obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E1AE RID: 188846 RVA: 0x0064CC51 File Offset: 0x0064AE51
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E1AF RID: 188847 RVA: 0x0064CC60 File Offset: 0x0064AE60
		public ICaptionParam __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C613 RID: 50707
		// (get) Token: 0x0602E1B0 RID: 188848 RVA: 0x0064CC70 File Offset: 0x0064AE70
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

		// Token: 0x1700C614 RID: 50708
		// (get) Token: 0x0602E1B1 RID: 188849 RVA: 0x0064CCB0 File Offset: 0x0064AEB0
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

		// Token: 0x1700C615 RID: 50709
		// (get) Token: 0x0602E1B2 RID: 188850 RVA: 0x0064CCF0 File Offset: 0x0064AEF0
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

		// Token: 0x1700C616 RID: 50710
		// (get) Token: 0x0602E1B3 RID: 188851 RVA: 0x0064CD30 File Offset: 0x0064AF30
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

		// Token: 0x0602E1B4 RID: 188852 RVA: 0x0064CD6D File Offset: 0x0064AF6D
		public static Offset<ICaptionParam> CreateICaptionParam(FlatBufferBuilder builder, float StartTime = 0f, float TotalTime = 0f, float IntervalTime = 0f, byte NullMask = 0)
		{
			builder.StartTable(4);
			ICaptionParam.AddIntervalTime(builder, IntervalTime);
			ICaptionParam.AddTotalTime(builder, TotalTime);
			ICaptionParam.AddStartTime(builder, StartTime);
			ICaptionParam.AddNullMask(builder, NullMask);
			return ICaptionParam.EndICaptionParam(builder);
		}

		// Token: 0x0602E1B5 RID: 188853 RVA: 0x0064CD99 File Offset: 0x0064AF99
		public static void StartICaptionParam(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0602E1B6 RID: 188854 RVA: 0x0064CDA2 File Offset: 0x0064AFA2
		public static void AddStartTime(FlatBufferBuilder builder, float startTime)
		{
			builder.AddFloat(0, startTime, 0.0);
		}

		// Token: 0x0602E1B7 RID: 188855 RVA: 0x0064CDB5 File Offset: 0x0064AFB5
		public static void AddTotalTime(FlatBufferBuilder builder, float totalTime)
		{
			builder.AddFloat(1, totalTime, 0.0);
		}

		// Token: 0x0602E1B8 RID: 188856 RVA: 0x0064CDC8 File Offset: 0x0064AFC8
		public static void AddIntervalTime(FlatBufferBuilder builder, float intervalTime)
		{
			builder.AddFloat(2, intervalTime, 0.0);
		}

		// Token: 0x0602E1B9 RID: 188857 RVA: 0x0064CDDB File Offset: 0x0064AFDB
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x0602E1BA RID: 188858 RVA: 0x0064CDE6 File Offset: 0x0064AFE6
		public static Offset<ICaptionParam> EndICaptionParam(FlatBufferBuilder builder)
		{
			return new Offset<ICaptionParam>(builder.EndTable());
		}

		// Token: 0x0602E1BB RID: 188859 RVA: 0x0064CDF4 File Offset: 0x0064AFF4
		public ICaptionParamT UnPack()
		{
			ICaptionParamT captionParamT = new ICaptionParamT();
			this.UnPackTo(captionParamT);
			return captionParamT;
		}

		// Token: 0x0602E1BC RID: 188860 RVA: 0x0064CE0F File Offset: 0x0064B00F
		public void UnPackTo(ICaptionParamT _o)
		{
			_o.StartTime = this.StartTime;
			_o.TotalTime = this.TotalTime;
			_o.IntervalTime = this.IntervalTime;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602E1BD RID: 188861 RVA: 0x0064CE44 File Offset: 0x0064B044
		public static Offset<ICaptionParam> Pack(FlatBufferBuilder builder, ICaptionParamT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICaptionParam>);
			}
			return ICaptionParam.CreateICaptionParam(builder, _o.StartTime, _o.TotalTime, _o.IntervalTime, _o.NullMask);
		}

		// Token: 0x0401165B RID: 71259
		private Table __p;
	}
}
