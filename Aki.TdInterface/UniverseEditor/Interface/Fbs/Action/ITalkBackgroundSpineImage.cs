using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020072A1 RID: 29345
	public struct ITalkBackgroundSpineImage : IFlatbufferObject
	{
		// Token: 0x1700D9A4 RID: 55716
		// (get) Token: 0x06034105 RID: 213253 RVA: 0x006FFAF1 File Offset: 0x006FDCF1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06034106 RID: 213254 RVA: 0x006FFAFE File Offset: 0x006FDCFE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06034107 RID: 213255 RVA: 0x006FFB08 File Offset: 0x006FDD08
		public static ITalkBackgroundSpineImage GetRootAsITalkBackgroundSpineImage(ByteBuffer _bb)
		{
			return ITalkBackgroundSpineImage.GetRootAsITalkBackgroundSpineImage(_bb, default(ITalkBackgroundSpineImage));
		}

		// Token: 0x06034108 RID: 213256 RVA: 0x006FFB24 File Offset: 0x006FDD24
		public static ITalkBackgroundSpineImage GetRootAsITalkBackgroundSpineImage(ByteBuffer _bb, ITalkBackgroundSpineImage obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06034109 RID: 213257 RVA: 0x006FFB41 File Offset: 0x006FDD41
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603410A RID: 213258 RVA: 0x006FFB50 File Offset: 0x006FDD50
		public ITalkBackgroundSpineImage __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D9A5 RID: 55717
		// (get) Token: 0x0603410B RID: 213259 RVA: 0x006FFB60 File Offset: 0x006FDD60
		public ETalkBackgroundType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETalkBackgroundType.Clean;
				}
				return (ETalkBackgroundType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D9A6 RID: 55718
		// (get) Token: 0x0603410C RID: 213260 RVA: 0x006FFB9C File Offset: 0x006FDD9C
		public int Id
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

		// Token: 0x1700D9A7 RID: 55719
		// (get) Token: 0x0603410D RID: 213261 RVA: 0x006FFBD8 File Offset: 0x006FDDD8
		public bool IsLoop
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700D9A8 RID: 55720
		// (get) Token: 0x0603410E RID: 213262 RVA: 0x006FFC18 File Offset: 0x006FDE18
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

		// Token: 0x0603410F RID: 213263 RVA: 0x006FFC55 File Offset: 0x006FDE55
		public static Offset<ITalkBackgroundSpineImage> CreateITalkBackgroundSpineImage(FlatBufferBuilder builder, ETalkBackgroundType Type = ETalkBackgroundType.Clean, int Id = 0, bool IsLoop = false, byte NullMask = 0)
		{
			builder.StartTable(4);
			ITalkBackgroundSpineImage.AddId(builder, Id);
			ITalkBackgroundSpineImage.AddNullMask(builder, NullMask);
			ITalkBackgroundSpineImage.AddIsLoop(builder, IsLoop);
			ITalkBackgroundSpineImage.AddType(builder, Type);
			return ITalkBackgroundSpineImage.EndITalkBackgroundSpineImage(builder);
		}

		// Token: 0x06034110 RID: 213264 RVA: 0x006FFC81 File Offset: 0x006FDE81
		public static void StartITalkBackgroundSpineImage(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06034111 RID: 213265 RVA: 0x006FFC8A File Offset: 0x006FDE8A
		public static void AddType(FlatBufferBuilder builder, ETalkBackgroundType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06034112 RID: 213266 RVA: 0x006FFC95 File Offset: 0x006FDE95
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x06034113 RID: 213267 RVA: 0x006FFCA0 File Offset: 0x006FDEA0
		public static void AddIsLoop(FlatBufferBuilder builder, bool isLoop)
		{
			builder.AddBool(2, isLoop, false);
		}

		// Token: 0x06034114 RID: 213268 RVA: 0x006FFCAB File Offset: 0x006FDEAB
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06034115 RID: 213269 RVA: 0x006FFCB6 File Offset: 0x006FDEB6
		public static Offset<ITalkBackgroundSpineImage> EndITalkBackgroundSpineImage(FlatBufferBuilder builder)
		{
			return new Offset<ITalkBackgroundSpineImage>(builder.EndTable());
		}

		// Token: 0x06034116 RID: 213270 RVA: 0x006FFCC4 File Offset: 0x006FDEC4
		public ITalkBackgroundSpineImageT UnPack()
		{
			ITalkBackgroundSpineImageT talkBackgroundSpineImageT = new ITalkBackgroundSpineImageT();
			this.UnPackTo(talkBackgroundSpineImageT);
			return talkBackgroundSpineImageT;
		}

		// Token: 0x06034117 RID: 213271 RVA: 0x006FFCDF File Offset: 0x006FDEDF
		public void UnPackTo(ITalkBackgroundSpineImageT _o)
		{
			_o.Type = this.Type;
			_o.Id = this.Id;
			_o.IsLoop = this.IsLoop;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06034118 RID: 213272 RVA: 0x006FFD14 File Offset: 0x006FDF14
		public static Offset<ITalkBackgroundSpineImage> Pack(FlatBufferBuilder builder, ITalkBackgroundSpineImageT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITalkBackgroundSpineImage>);
			}
			return ITalkBackgroundSpineImage.CreateITalkBackgroundSpineImage(builder, _o.Type, _o.Id, _o.IsLoop, _o.NullMask);
		}

		// Token: 0x04011DAC RID: 73132
		private Table __p;
	}
}
