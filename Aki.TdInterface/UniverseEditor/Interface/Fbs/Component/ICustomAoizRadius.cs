using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005051 RID: 20561
	public struct ICustomAoizRadius : IFlatbufferObject
	{
		// Token: 0x1700952E RID: 38190
		// (get) Token: 0x06020F27 RID: 134951 RVA: 0x004946F6 File Offset: 0x004928F6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06020F28 RID: 134952 RVA: 0x00494703 File Offset: 0x00492903
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06020F29 RID: 134953 RVA: 0x0049470C File Offset: 0x0049290C
		public static ICustomAoizRadius GetRootAsICustomAoizRadius(ByteBuffer _bb)
		{
			return ICustomAoizRadius.GetRootAsICustomAoizRadius(_bb, default(ICustomAoizRadius));
		}

		// Token: 0x06020F2A RID: 134954 RVA: 0x00494728 File Offset: 0x00492928
		public static ICustomAoizRadius GetRootAsICustomAoizRadius(ByteBuffer _bb, ICustomAoizRadius obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06020F2B RID: 134955 RVA: 0x00494745 File Offset: 0x00492945
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06020F2C RID: 134956 RVA: 0x00494754 File Offset: 0x00492954
		public ICustomAoizRadius __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700952F RID: 38191
		// (get) Token: 0x06020F2D RID: 134957 RVA: 0x00494764 File Offset: 0x00492964
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

		// Token: 0x17009530 RID: 38192
		// (get) Token: 0x06020F2E RID: 134958 RVA: 0x004947A0 File Offset: 0x004929A0
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

		// Token: 0x17009531 RID: 38193
		// (get) Token: 0x06020F2F RID: 134959 RVA: 0x004947DC File Offset: 0x004929DC
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

		// Token: 0x06020F30 RID: 134960 RVA: 0x00494818 File Offset: 0x00492A18
		public static Offset<ICustomAoizRadius> CreateICustomAoizRadius(FlatBufferBuilder builder, int Up = 0, int Down = 0, byte NullMask = 0)
		{
			builder.StartTable(3);
			ICustomAoizRadius.AddDown(builder, Down);
			ICustomAoizRadius.AddUp(builder, Up);
			ICustomAoizRadius.AddNullMask(builder, NullMask);
			return ICustomAoizRadius.EndICustomAoizRadius(builder);
		}

		// Token: 0x06020F31 RID: 134961 RVA: 0x0049483C File Offset: 0x00492A3C
		public static void StartICustomAoizRadius(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06020F32 RID: 134962 RVA: 0x00494845 File Offset: 0x00492A45
		public static void AddUp(FlatBufferBuilder builder, int up)
		{
			builder.AddInt(0, up, 0);
		}

		// Token: 0x06020F33 RID: 134963 RVA: 0x00494850 File Offset: 0x00492A50
		public static void AddDown(FlatBufferBuilder builder, int down)
		{
			builder.AddInt(1, down, 0);
		}

		// Token: 0x06020F34 RID: 134964 RVA: 0x0049485B File Offset: 0x00492A5B
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x06020F35 RID: 134965 RVA: 0x00494866 File Offset: 0x00492A66
		public static Offset<ICustomAoizRadius> EndICustomAoizRadius(FlatBufferBuilder builder)
		{
			return new Offset<ICustomAoizRadius>(builder.EndTable());
		}

		// Token: 0x06020F36 RID: 134966 RVA: 0x00494874 File Offset: 0x00492A74
		public ICustomAoizRadiusT UnPack()
		{
			ICustomAoizRadiusT customAoizRadiusT = new ICustomAoizRadiusT();
			this.UnPackTo(customAoizRadiusT);
			return customAoizRadiusT;
		}

		// Token: 0x06020F37 RID: 134967 RVA: 0x0049488F File Offset: 0x00492A8F
		public void UnPackTo(ICustomAoizRadiusT _o)
		{
			_o.Up = this.Up;
			_o.Down = this.Down;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06020F38 RID: 134968 RVA: 0x004948B8 File Offset: 0x00492AB8
		public static Offset<ICustomAoizRadius> Pack(FlatBufferBuilder builder, ICustomAoizRadiusT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICustomAoizRadius>);
			}
			return ICustomAoizRadius.CreateICustomAoizRadius(builder, _o.Up, _o.Down, _o.NullMask);
		}

		// Token: 0x0400E048 RID: 57416
		private Table __p;
	}
}
