using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004986 RID: 18822
	public struct ILevelPlayZaxis : IFlatbufferObject
	{
		// Token: 0x170083AE RID: 33710
		// (get) Token: 0x0601C14C RID: 115020 RVA: 0x003F8108 File Offset: 0x003F6308
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601C14D RID: 115021 RVA: 0x003F8115 File Offset: 0x003F6315
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601C14E RID: 115022 RVA: 0x003F811C File Offset: 0x003F631C
		public static ILevelPlayZaxis GetRootAsILevelPlayZaxis(ByteBuffer _bb)
		{
			return ILevelPlayZaxis.GetRootAsILevelPlayZaxis(_bb, default(ILevelPlayZaxis));
		}

		// Token: 0x0601C14F RID: 115023 RVA: 0x003F8138 File Offset: 0x003F6338
		public static ILevelPlayZaxis GetRootAsILevelPlayZaxis(ByteBuffer _bb, ILevelPlayZaxis obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601C150 RID: 115024 RVA: 0x003F8155 File Offset: 0x003F6355
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601C151 RID: 115025 RVA: 0x003F8164 File Offset: 0x003F6364
		public ILevelPlayZaxis __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170083AF RID: 33711
		// (get) Token: 0x0601C152 RID: 115026 RVA: 0x003F8174 File Offset: 0x003F6374
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

		// Token: 0x170083B0 RID: 33712
		// (get) Token: 0x0601C153 RID: 115027 RVA: 0x003F81B0 File Offset: 0x003F63B0
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

		// Token: 0x170083B1 RID: 33713
		// (get) Token: 0x0601C154 RID: 115028 RVA: 0x003F81EC File Offset: 0x003F63EC
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

		// Token: 0x0601C155 RID: 115029 RVA: 0x003F8228 File Offset: 0x003F6428
		public static Offset<ILevelPlayZaxis> CreateILevelPlayZaxis(FlatBufferBuilder builder, int Up = 0, int Down = 0, byte NullMask = 0)
		{
			builder.StartTable(3);
			ILevelPlayZaxis.AddDown(builder, Down);
			ILevelPlayZaxis.AddUp(builder, Up);
			ILevelPlayZaxis.AddNullMask(builder, NullMask);
			return ILevelPlayZaxis.EndILevelPlayZaxis(builder);
		}

		// Token: 0x0601C156 RID: 115030 RVA: 0x003F824C File Offset: 0x003F644C
		public static void StartILevelPlayZaxis(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601C157 RID: 115031 RVA: 0x003F8255 File Offset: 0x003F6455
		public static void AddUp(FlatBufferBuilder builder, int up)
		{
			builder.AddInt(0, up, 0);
		}

		// Token: 0x0601C158 RID: 115032 RVA: 0x003F8260 File Offset: 0x003F6460
		public static void AddDown(FlatBufferBuilder builder, int down)
		{
			builder.AddInt(1, down, 0);
		}

		// Token: 0x0601C159 RID: 115033 RVA: 0x003F826B File Offset: 0x003F646B
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x0601C15A RID: 115034 RVA: 0x003F8276 File Offset: 0x003F6476
		public static Offset<ILevelPlayZaxis> EndILevelPlayZaxis(FlatBufferBuilder builder)
		{
			return new Offset<ILevelPlayZaxis>(builder.EndTable());
		}

		// Token: 0x0601C15B RID: 115035 RVA: 0x003F8284 File Offset: 0x003F6484
		public ILevelPlayZaxisT UnPack()
		{
			ILevelPlayZaxisT levelPlayZaxisT = new ILevelPlayZaxisT();
			this.UnPackTo(levelPlayZaxisT);
			return levelPlayZaxisT;
		}

		// Token: 0x0601C15C RID: 115036 RVA: 0x003F829F File Offset: 0x003F649F
		public void UnPackTo(ILevelPlayZaxisT _o)
		{
			_o.Up = this.Up;
			_o.Down = this.Down;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601C15D RID: 115037 RVA: 0x003F82C8 File Offset: 0x003F64C8
		public static Offset<ILevelPlayZaxis> Pack(FlatBufferBuilder builder, ILevelPlayZaxisT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILevelPlayZaxis>);
			}
			return ILevelPlayZaxis.CreateILevelPlayZaxis(builder, _o.Up, _o.Down, _o.NullMask);
		}

		// Token: 0x0400CFC7 RID: 53191
		private Table __p;
	}
}
