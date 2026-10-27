using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004C10 RID: 19472
	public struct IEllipseConeRange : IFlatbufferObject
	{
		// Token: 0x17008D6D RID: 36205
		// (get) Token: 0x0601ED67 RID: 126311 RVA: 0x00451560 File Offset: 0x0044F760
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601ED68 RID: 126312 RVA: 0x0045156D File Offset: 0x0044F76D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601ED69 RID: 126313 RVA: 0x00451574 File Offset: 0x0044F774
		public static IEllipseConeRange GetRootAsIEllipseConeRange(ByteBuffer _bb)
		{
			return IEllipseConeRange.GetRootAsIEllipseConeRange(_bb, default(IEllipseConeRange));
		}

		// Token: 0x0601ED6A RID: 126314 RVA: 0x00451590 File Offset: 0x0044F790
		public static IEllipseConeRange GetRootAsIEllipseConeRange(ByteBuffer _bb, IEllipseConeRange obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601ED6B RID: 126315 RVA: 0x004515AD File Offset: 0x0044F7AD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601ED6C RID: 126316 RVA: 0x004515BC File Offset: 0x0044F7BC
		public IEllipseConeRange __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008D6E RID: 36206
		// (get) Token: 0x0601ED6D RID: 126317 RVA: 0x004515CC File Offset: 0x0044F7CC
		public float HorizontalAngle
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

		// Token: 0x17008D6F RID: 36207
		// (get) Token: 0x0601ED6E RID: 126318 RVA: 0x0045160C File Offset: 0x0044F80C
		public float VerticalAngle
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

		// Token: 0x0601ED6F RID: 126319 RVA: 0x0045164C File Offset: 0x0044F84C
		public static Offset<IEllipseConeRange> CreateIEllipseConeRange(FlatBufferBuilder builder, float HorizontalAngle = 0f, float VerticalAngle = 0f)
		{
			builder.StartTable(2);
			IEllipseConeRange.AddVerticalAngle(builder, VerticalAngle);
			IEllipseConeRange.AddHorizontalAngle(builder, HorizontalAngle);
			return IEllipseConeRange.EndIEllipseConeRange(builder);
		}

		// Token: 0x0601ED70 RID: 126320 RVA: 0x00451669 File Offset: 0x0044F869
		public static void StartIEllipseConeRange(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601ED71 RID: 126321 RVA: 0x00451672 File Offset: 0x0044F872
		public static void AddHorizontalAngle(FlatBufferBuilder builder, float horizontalAngle)
		{
			builder.AddFloat(0, horizontalAngle, 0.0);
		}

		// Token: 0x0601ED72 RID: 126322 RVA: 0x00451685 File Offset: 0x0044F885
		public static void AddVerticalAngle(FlatBufferBuilder builder, float verticalAngle)
		{
			builder.AddFloat(1, verticalAngle, 0.0);
		}

		// Token: 0x0601ED73 RID: 126323 RVA: 0x00451698 File Offset: 0x0044F898
		public static Offset<IEllipseConeRange> EndIEllipseConeRange(FlatBufferBuilder builder)
		{
			return new Offset<IEllipseConeRange>(builder.EndTable());
		}

		// Token: 0x0601ED74 RID: 126324 RVA: 0x004516A8 File Offset: 0x0044F8A8
		public IEllipseConeRangeT UnPack()
		{
			IEllipseConeRangeT ellipseConeRangeT = new IEllipseConeRangeT();
			this.UnPackTo(ellipseConeRangeT);
			return ellipseConeRangeT;
		}

		// Token: 0x0601ED75 RID: 126325 RVA: 0x004516C3 File Offset: 0x0044F8C3
		public void UnPackTo(IEllipseConeRangeT _o)
		{
			_o.HorizontalAngle = this.HorizontalAngle;
			_o.VerticalAngle = this.VerticalAngle;
		}

		// Token: 0x0601ED76 RID: 126326 RVA: 0x004516E0 File Offset: 0x0044F8E0
		public static Offset<IEllipseConeRange> Pack(FlatBufferBuilder builder, IEllipseConeRangeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEllipseConeRange>);
			}
			return IEllipseConeRange.CreateIEllipseConeRange(builder, _o.HorizontalAngle, _o.VerticalAngle);
		}

		// Token: 0x0400D5A4 RID: 54692
		private Table __p;
	}
}
