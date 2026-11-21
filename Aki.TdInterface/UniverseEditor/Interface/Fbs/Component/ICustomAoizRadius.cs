using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020055B3 RID: 21939
	public struct ICustomAoizRadius : IFlatbufferObject
	{
		// Token: 0x17009D14 RID: 40212
		// (get) Token: 0x06022E61 RID: 142945 RVA: 0x004CE3AA File Offset: 0x004CC5AA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06022E62 RID: 142946 RVA: 0x004CE3B7 File Offset: 0x004CC5B7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06022E63 RID: 142947 RVA: 0x004CE3C0 File Offset: 0x004CC5C0
		public static ICustomAoizRadius GetRootAsICustomAoizRadius(ByteBuffer _bb)
		{
			return ICustomAoizRadius.GetRootAsICustomAoizRadius(_bb, default(ICustomAoizRadius));
		}

		// Token: 0x06022E64 RID: 142948 RVA: 0x004CE3DC File Offset: 0x004CC5DC
		public static ICustomAoizRadius GetRootAsICustomAoizRadius(ByteBuffer _bb, ICustomAoizRadius obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06022E65 RID: 142949 RVA: 0x004CE3F9 File Offset: 0x004CC5F9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06022E66 RID: 142950 RVA: 0x004CE408 File Offset: 0x004CC608
		public ICustomAoizRadius __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009D15 RID: 40213
		// (get) Token: 0x06022E67 RID: 142951 RVA: 0x004CE418 File Offset: 0x004CC618
		public int Up
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

		// Token: 0x17009D16 RID: 40214
		// (get) Token: 0x06022E68 RID: 142952 RVA: 0x004CE454 File Offset: 0x004CC654
		public int Down
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

		// Token: 0x17009D17 RID: 40215
		// (get) Token: 0x06022E69 RID: 142953 RVA: 0x004CE490 File Offset: 0x004CC690
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

		// Token: 0x06022E6A RID: 142954 RVA: 0x004CE4CC File Offset: 0x004CC6CC
		public static Offset<ICustomAoizRadius> CreateICustomAoizRadius(FlatBufferBuilder builder, int Up = 0, int Down = 0, byte NullMask = 0)
		{
			builder.StartTable(3);
			ICustomAoizRadius.AddDown(builder, Down);
			ICustomAoizRadius.AddUp(builder, Up);
			ICustomAoizRadius.AddNullMask(builder, NullMask);
			return ICustomAoizRadius.EndICustomAoizRadius(builder);
		}

		// Token: 0x06022E6B RID: 142955 RVA: 0x004CE4F0 File Offset: 0x004CC6F0
		public static void StartICustomAoizRadius(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06022E6C RID: 142956 RVA: 0x004CE4F9 File Offset: 0x004CC6F9
		public static void AddUp(FlatBufferBuilder builder, int up)
		{
			builder.AddInt(0, up, 0);
		}

		// Token: 0x06022E6D RID: 142957 RVA: 0x004CE504 File Offset: 0x004CC704
		public static void AddDown(FlatBufferBuilder builder, int down)
		{
			builder.AddInt(1, down, 0);
		}

		// Token: 0x06022E6E RID: 142958 RVA: 0x004CE50F File Offset: 0x004CC70F
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x06022E6F RID: 142959 RVA: 0x004CE51A File Offset: 0x004CC71A
		public static Offset<ICustomAoizRadius> EndICustomAoizRadius(FlatBufferBuilder builder)
		{
			return new Offset<ICustomAoizRadius>(builder.EndTable());
		}

		// Token: 0x06022E70 RID: 142960 RVA: 0x004CE528 File Offset: 0x004CC728
		public ICustomAoizRadiusT UnPack()
		{
			ICustomAoizRadiusT customAoizRadiusT = new ICustomAoizRadiusT();
			this.UnPackTo(customAoizRadiusT);
			return customAoizRadiusT;
		}

		// Token: 0x06022E71 RID: 142961 RVA: 0x004CE543 File Offset: 0x004CC743
		public void UnPackTo(ICustomAoizRadiusT _o)
		{
			_o.Up = this.Up;
			_o.Down = this.Down;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06022E72 RID: 142962 RVA: 0x004CE56C File Offset: 0x004CC76C
		public static Offset<ICustomAoizRadius> Pack(FlatBufferBuilder builder, ICustomAoizRadiusT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICustomAoizRadius>);
			}
			return ICustomAoizRadius.CreateICustomAoizRadius(builder, _o.Up, _o.Down, _o.NullMask);
		}

		// Token: 0x0400EC41 RID: 60481
		private Table __p;
	}
}
