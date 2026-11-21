using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005169 RID: 20841
	public struct IPhotographCameraCheckAspectRatioType : IFlatbufferObject
	{
		// Token: 0x1700954E RID: 38222
		// (get) Token: 0x06020C97 RID: 134295 RVA: 0x0048A3C0 File Offset: 0x004885C0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06020C98 RID: 134296 RVA: 0x0048A3CD File Offset: 0x004885CD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06020C99 RID: 134297 RVA: 0x0048A3D4 File Offset: 0x004885D4
		public static IPhotographCameraCheckAspectRatioType GetRootAsIPhotographCameraCheckAspectRatioType(ByteBuffer _bb)
		{
			return IPhotographCameraCheckAspectRatioType.GetRootAsIPhotographCameraCheckAspectRatioType(_bb, default(IPhotographCameraCheckAspectRatioType));
		}

		// Token: 0x06020C9A RID: 134298 RVA: 0x0048A3F0 File Offset: 0x004885F0
		public static IPhotographCameraCheckAspectRatioType GetRootAsIPhotographCameraCheckAspectRatioType(ByteBuffer _bb, IPhotographCameraCheckAspectRatioType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06020C9B RID: 134299 RVA: 0x0048A40D File Offset: 0x0048860D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06020C9C RID: 134300 RVA: 0x0048A41C File Offset: 0x0048861C
		public IPhotographCameraCheckAspectRatioType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700954F RID: 38223
		// (get) Token: 0x06020C9D RID: 134301 RVA: 0x0048A42C File Offset: 0x0048862C
		public EPhotographCameraCheckType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EPhotographCameraCheckType.CameraTemplate;
				}
				return (EPhotographCameraCheckType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009550 RID: 38224
		// (get) Token: 0x06020C9E RID: 134302 RVA: 0x0048A468 File Offset: 0x00488668
		public int AspectRatioTypeId
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

		// Token: 0x06020C9F RID: 134303 RVA: 0x0048A4A4 File Offset: 0x004886A4
		public static Offset<IPhotographCameraCheckAspectRatioType> CreateIPhotographCameraCheckAspectRatioType(FlatBufferBuilder builder, EPhotographCameraCheckType Type = EPhotographCameraCheckType.CameraTemplate, int AspectRatioTypeId = 0)
		{
			builder.StartTable(2);
			IPhotographCameraCheckAspectRatioType.AddAspectRatioTypeId(builder, AspectRatioTypeId);
			IPhotographCameraCheckAspectRatioType.AddType(builder, Type);
			return IPhotographCameraCheckAspectRatioType.EndIPhotographCameraCheckAspectRatioType(builder);
		}

		// Token: 0x06020CA0 RID: 134304 RVA: 0x0048A4C1 File Offset: 0x004886C1
		public static void StartIPhotographCameraCheckAspectRatioType(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06020CA1 RID: 134305 RVA: 0x0048A4CA File Offset: 0x004886CA
		public static void AddType(FlatBufferBuilder builder, EPhotographCameraCheckType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06020CA2 RID: 134306 RVA: 0x0048A4D5 File Offset: 0x004886D5
		public static void AddAspectRatioTypeId(FlatBufferBuilder builder, int aspectRatioTypeId)
		{
			builder.AddInt(1, aspectRatioTypeId, 0);
		}

		// Token: 0x06020CA3 RID: 134307 RVA: 0x0048A4E0 File Offset: 0x004886E0
		public static Offset<IPhotographCameraCheckAspectRatioType> EndIPhotographCameraCheckAspectRatioType(FlatBufferBuilder builder)
		{
			return new Offset<IPhotographCameraCheckAspectRatioType>(builder.EndTable());
		}

		// Token: 0x06020CA4 RID: 134308 RVA: 0x0048A4F0 File Offset: 0x004886F0
		public IPhotographCameraCheckAspectRatioTypeT UnPack()
		{
			IPhotographCameraCheckAspectRatioTypeT photographCameraCheckAspectRatioTypeT = new IPhotographCameraCheckAspectRatioTypeT();
			this.UnPackTo(photographCameraCheckAspectRatioTypeT);
			return photographCameraCheckAspectRatioTypeT;
		}

		// Token: 0x06020CA5 RID: 134309 RVA: 0x0048A50B File Offset: 0x0048870B
		public void UnPackTo(IPhotographCameraCheckAspectRatioTypeT _o)
		{
			_o.Type = this.Type;
			_o.AspectRatioTypeId = this.AspectRatioTypeId;
		}

		// Token: 0x06020CA6 RID: 134310 RVA: 0x0048A528 File Offset: 0x00488728
		public static Offset<IPhotographCameraCheckAspectRatioType> Pack(FlatBufferBuilder builder, IPhotographCameraCheckAspectRatioTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPhotographCameraCheckAspectRatioType>);
			}
			return IPhotographCameraCheckAspectRatioType.CreateIPhotographCameraCheckAspectRatioType(builder, _o.Type, _o.AspectRatioTypeId);
		}

		// Token: 0x0400E148 RID: 57672
		private Table __p;
	}
}
