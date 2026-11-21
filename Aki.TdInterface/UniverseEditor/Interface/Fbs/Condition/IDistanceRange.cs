using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020050E5 RID: 20709
	public struct IDistanceRange : IFlatbufferObject
	{
		// Token: 0x17009468 RID: 37992
		// (get) Token: 0x06020891 RID: 133265 RVA: 0x00483971 File Offset: 0x00481B71
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06020892 RID: 133266 RVA: 0x0048397E File Offset: 0x00481B7E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06020893 RID: 133267 RVA: 0x00483988 File Offset: 0x00481B88
		public static IDistanceRange GetRootAsIDistanceRange(ByteBuffer _bb)
		{
			return IDistanceRange.GetRootAsIDistanceRange(_bb, default(IDistanceRange));
		}

		// Token: 0x06020894 RID: 133268 RVA: 0x004839A4 File Offset: 0x00481BA4
		public static IDistanceRange GetRootAsIDistanceRange(ByteBuffer _bb, IDistanceRange obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06020895 RID: 133269 RVA: 0x004839C1 File Offset: 0x00481BC1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06020896 RID: 133270 RVA: 0x004839D0 File Offset: 0x00481BD0
		public IDistanceRange __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009469 RID: 37993
		// (get) Token: 0x06020897 RID: 133271 RVA: 0x004839E0 File Offset: 0x00481BE0
		public float Min
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

		// Token: 0x1700946A RID: 37994
		// (get) Token: 0x06020898 RID: 133272 RVA: 0x00483A20 File Offset: 0x00481C20
		public float Max
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

		// Token: 0x1700946B RID: 37995
		// (get) Token: 0x06020899 RID: 133273 RVA: 0x00483A60 File Offset: 0x00481C60
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

		// Token: 0x0602089A RID: 133274 RVA: 0x00483A9C File Offset: 0x00481C9C
		public static Offset<IDistanceRange> CreateIDistanceRange(FlatBufferBuilder builder, float Min = 0f, float Max = 0f, byte NullMask = 0)
		{
			builder.StartTable(3);
			IDistanceRange.AddMax(builder, Max);
			IDistanceRange.AddMin(builder, Min);
			IDistanceRange.AddNullMask(builder, NullMask);
			return IDistanceRange.EndIDistanceRange(builder);
		}

		// Token: 0x0602089B RID: 133275 RVA: 0x00483AC0 File Offset: 0x00481CC0
		public static void StartIDistanceRange(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602089C RID: 133276 RVA: 0x00483AC9 File Offset: 0x00481CC9
		public static void AddMin(FlatBufferBuilder builder, float min)
		{
			builder.AddFloat(0, min, 0.0);
		}

		// Token: 0x0602089D RID: 133277 RVA: 0x00483ADC File Offset: 0x00481CDC
		public static void AddMax(FlatBufferBuilder builder, float max)
		{
			builder.AddFloat(1, max, 0.0);
		}

		// Token: 0x0602089E RID: 133278 RVA: 0x00483AEF File Offset: 0x00481CEF
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x0602089F RID: 133279 RVA: 0x00483AFA File Offset: 0x00481CFA
		public static Offset<IDistanceRange> EndIDistanceRange(FlatBufferBuilder builder)
		{
			return new Offset<IDistanceRange>(builder.EndTable());
		}

		// Token: 0x060208A0 RID: 133280 RVA: 0x00483B08 File Offset: 0x00481D08
		public IDistanceRangeT UnPack()
		{
			IDistanceRangeT distanceRangeT = new IDistanceRangeT();
			this.UnPackTo(distanceRangeT);
			return distanceRangeT;
		}

		// Token: 0x060208A1 RID: 133281 RVA: 0x00483B23 File Offset: 0x00481D23
		public void UnPackTo(IDistanceRangeT _o)
		{
			_o.Min = this.Min;
			_o.Max = this.Max;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060208A2 RID: 133282 RVA: 0x00483B4C File Offset: 0x00481D4C
		public static Offset<IDistanceRange> Pack(FlatBufferBuilder builder, IDistanceRangeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDistanceRange>);
			}
			return IDistanceRange.CreateIDistanceRange(builder, _o.Min, _o.Max, _o.NullMask);
		}

		// Token: 0x0400E09B RID: 57499
		private Table __p;
	}
}
