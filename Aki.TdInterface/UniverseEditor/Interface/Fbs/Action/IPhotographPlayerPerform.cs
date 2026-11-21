using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200743C RID: 29756
	public struct IPhotographPlayerPerform : IFlatbufferObject
	{
		// Token: 0x1700DA8A RID: 55946
		// (get) Token: 0x06034106 RID: 213254 RVA: 0x007040D9 File Offset: 0x007022D9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06034107 RID: 213255 RVA: 0x007040E6 File Offset: 0x007022E6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06034108 RID: 213256 RVA: 0x007040F0 File Offset: 0x007022F0
		public static IPhotographPlayerPerform GetRootAsIPhotographPlayerPerform(ByteBuffer _bb)
		{
			return IPhotographPlayerPerform.GetRootAsIPhotographPlayerPerform(_bb, default(IPhotographPlayerPerform));
		}

		// Token: 0x06034109 RID: 213257 RVA: 0x0070410C File Offset: 0x0070230C
		public static IPhotographPlayerPerform GetRootAsIPhotographPlayerPerform(ByteBuffer _bb, IPhotographPlayerPerform obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603410A RID: 213258 RVA: 0x00704129 File Offset: 0x00702329
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603410B RID: 213259 RVA: 0x00704138 File Offset: 0x00702338
		public IPhotographPlayerPerform __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DA8B RID: 55947
		// (get) Token: 0x0603410C RID: 213260 RVA: 0x00704148 File Offset: 0x00702348
		public int MontageId
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

		// Token: 0x1700DA8C RID: 55948
		// (get) Token: 0x0603410D RID: 213261 RVA: 0x00704184 File Offset: 0x00702384
		public int FaceId
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

		// Token: 0x1700DA8D RID: 55949
		// (get) Token: 0x0603410E RID: 213262 RVA: 0x007041C0 File Offset: 0x007023C0
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

		// Token: 0x0603410F RID: 213263 RVA: 0x007041FC File Offset: 0x007023FC
		public static Offset<IPhotographPlayerPerform> CreateIPhotographPlayerPerform(FlatBufferBuilder builder, int MontageId = 0, int FaceId = 0, byte NullMask = 0)
		{
			builder.StartTable(3);
			IPhotographPlayerPerform.AddFaceId(builder, FaceId);
			IPhotographPlayerPerform.AddMontageId(builder, MontageId);
			IPhotographPlayerPerform.AddNullMask(builder, NullMask);
			return IPhotographPlayerPerform.EndIPhotographPlayerPerform(builder);
		}

		// Token: 0x06034110 RID: 213264 RVA: 0x00704220 File Offset: 0x00702420
		public static void StartIPhotographPlayerPerform(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06034111 RID: 213265 RVA: 0x00704229 File Offset: 0x00702429
		public static void AddMontageId(FlatBufferBuilder builder, int montageId)
		{
			builder.AddInt(0, montageId, 0);
		}

		// Token: 0x06034112 RID: 213266 RVA: 0x00704234 File Offset: 0x00702434
		public static void AddFaceId(FlatBufferBuilder builder, int faceId)
		{
			builder.AddInt(1, faceId, 0);
		}

		// Token: 0x06034113 RID: 213267 RVA: 0x0070423F File Offset: 0x0070243F
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x06034114 RID: 213268 RVA: 0x0070424A File Offset: 0x0070244A
		public static Offset<IPhotographPlayerPerform> EndIPhotographPlayerPerform(FlatBufferBuilder builder)
		{
			return new Offset<IPhotographPlayerPerform>(builder.EndTable());
		}

		// Token: 0x06034115 RID: 213269 RVA: 0x00704258 File Offset: 0x00702458
		public IPhotographPlayerPerformT UnPack()
		{
			IPhotographPlayerPerformT photographPlayerPerformT = new IPhotographPlayerPerformT();
			this.UnPackTo(photographPlayerPerformT);
			return photographPlayerPerformT;
		}

		// Token: 0x06034116 RID: 213270 RVA: 0x00704273 File Offset: 0x00702473
		public void UnPackTo(IPhotographPlayerPerformT _o)
		{
			_o.MontageId = this.MontageId;
			_o.FaceId = this.FaceId;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06034117 RID: 213271 RVA: 0x0070429C File Offset: 0x0070249C
		public static Offset<IPhotographPlayerPerform> Pack(FlatBufferBuilder builder, IPhotographPlayerPerformT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPhotographPlayerPerform>);
			}
			return IPhotographPlayerPerform.CreateIPhotographPlayerPerform(builder, _o.MontageId, _o.FaceId, _o.NullMask);
		}

		// Token: 0x0401259A RID: 75162
		private Table __p;
	}
}
