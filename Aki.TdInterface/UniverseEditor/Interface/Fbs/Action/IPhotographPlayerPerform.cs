using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006CC6 RID: 27846
	public struct IPhotographPlayerPerform : IFlatbufferObject
	{
		// Token: 0x1700CF4D RID: 53069
		// (get) Token: 0x0603112F RID: 201007 RVA: 0x006A8EA5 File Offset: 0x006A70A5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031130 RID: 201008 RVA: 0x006A8EB2 File Offset: 0x006A70B2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06031131 RID: 201009 RVA: 0x006A8EBC File Offset: 0x006A70BC
		public static IPhotographPlayerPerform GetRootAsIPhotographPlayerPerform(ByteBuffer _bb)
		{
			return IPhotographPlayerPerform.GetRootAsIPhotographPlayerPerform(_bb, default(IPhotographPlayerPerform));
		}

		// Token: 0x06031132 RID: 201010 RVA: 0x006A8ED8 File Offset: 0x006A70D8
		public static IPhotographPlayerPerform GetRootAsIPhotographPlayerPerform(ByteBuffer _bb, IPhotographPlayerPerform obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06031133 RID: 201011 RVA: 0x006A8EF5 File Offset: 0x006A70F5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031134 RID: 201012 RVA: 0x006A8F04 File Offset: 0x006A7104
		public IPhotographPlayerPerform __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CF4E RID: 53070
		// (get) Token: 0x06031135 RID: 201013 RVA: 0x006A8F14 File Offset: 0x006A7114
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

		// Token: 0x1700CF4F RID: 53071
		// (get) Token: 0x06031136 RID: 201014 RVA: 0x006A8F50 File Offset: 0x006A7150
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

		// Token: 0x1700CF50 RID: 53072
		// (get) Token: 0x06031137 RID: 201015 RVA: 0x006A8F8C File Offset: 0x006A718C
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

		// Token: 0x06031138 RID: 201016 RVA: 0x006A8FC8 File Offset: 0x006A71C8
		public static Offset<IPhotographPlayerPerform> CreateIPhotographPlayerPerform(FlatBufferBuilder builder, int MontageId = 0, int FaceId = 0, byte NullMask = 0)
		{
			builder.StartTable(3);
			IPhotographPlayerPerform.AddFaceId(builder, FaceId);
			IPhotographPlayerPerform.AddMontageId(builder, MontageId);
			IPhotographPlayerPerform.AddNullMask(builder, NullMask);
			return IPhotographPlayerPerform.EndIPhotographPlayerPerform(builder);
		}

		// Token: 0x06031139 RID: 201017 RVA: 0x006A8FEC File Offset: 0x006A71EC
		public static void StartIPhotographPlayerPerform(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0603113A RID: 201018 RVA: 0x006A8FF5 File Offset: 0x006A71F5
		public static void AddMontageId(FlatBufferBuilder builder, int montageId)
		{
			builder.AddInt(0, montageId, 0);
		}

		// Token: 0x0603113B RID: 201019 RVA: 0x006A9000 File Offset: 0x006A7200
		public static void AddFaceId(FlatBufferBuilder builder, int faceId)
		{
			builder.AddInt(1, faceId, 0);
		}

		// Token: 0x0603113C RID: 201020 RVA: 0x006A900B File Offset: 0x006A720B
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x0603113D RID: 201021 RVA: 0x006A9016 File Offset: 0x006A7216
		public static Offset<IPhotographPlayerPerform> EndIPhotographPlayerPerform(FlatBufferBuilder builder)
		{
			return new Offset<IPhotographPlayerPerform>(builder.EndTable());
		}

		// Token: 0x0603113E RID: 201022 RVA: 0x006A9024 File Offset: 0x006A7224
		public IPhotographPlayerPerformT UnPack()
		{
			IPhotographPlayerPerformT photographPlayerPerformT = new IPhotographPlayerPerformT();
			this.UnPackTo(photographPlayerPerformT);
			return photographPlayerPerformT;
		}

		// Token: 0x0603113F RID: 201023 RVA: 0x006A903F File Offset: 0x006A723F
		public void UnPackTo(IPhotographPlayerPerformT _o)
		{
			_o.MontageId = this.MontageId;
			_o.FaceId = this.FaceId;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06031140 RID: 201024 RVA: 0x006A9068 File Offset: 0x006A7268
		public static Offset<IPhotographPlayerPerform> Pack(FlatBufferBuilder builder, IPhotographPlayerPerformT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPhotographPlayerPerform>);
			}
			return IPhotographPlayerPerform.CreateIPhotographPlayerPerform(builder, _o.MontageId, _o.FaceId, _o.NullMask);
		}

		// Token: 0x0401162A RID: 71210
		private Table __p;
	}
}
