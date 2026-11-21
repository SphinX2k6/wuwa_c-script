using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004AEC RID: 19180
	public struct IResetCurrentDungeon : IFlatbufferObject
	{
		// Token: 0x1700866E RID: 34414
		// (get) Token: 0x0601CE54 RID: 118356 RVA: 0x00411239 File Offset: 0x0040F439
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601CE55 RID: 118357 RVA: 0x00411246 File Offset: 0x0040F446
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601CE56 RID: 118358 RVA: 0x00411250 File Offset: 0x0040F450
		public static IResetCurrentDungeon GetRootAsIResetCurrentDungeon(ByteBuffer _bb)
		{
			return IResetCurrentDungeon.GetRootAsIResetCurrentDungeon(_bb, default(IResetCurrentDungeon));
		}

		// Token: 0x0601CE57 RID: 118359 RVA: 0x0041126C File Offset: 0x0040F46C
		public static IResetCurrentDungeon GetRootAsIResetCurrentDungeon(ByteBuffer _bb, IResetCurrentDungeon obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601CE58 RID: 118360 RVA: 0x00411289 File Offset: 0x0040F489
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601CE59 RID: 118361 RVA: 0x00411298 File Offset: 0x0040F498
		public IResetCurrentDungeon __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700866F RID: 34415
		// (get) Token: 0x0601CE5A RID: 118362 RVA: 0x004112A8 File Offset: 0x0040F4A8
		public EGmCommand Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EGmCommand.SkipToLevelPlayNode;
				}
				return (EGmCommand)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601CE5B RID: 118363 RVA: 0x004112E4 File Offset: 0x0040F4E4
		public static Offset<IResetCurrentDungeon> CreateIResetCurrentDungeon(FlatBufferBuilder builder, EGmCommand Type = EGmCommand.SkipToLevelPlayNode)
		{
			builder.StartTable(1);
			IResetCurrentDungeon.AddType(builder, Type);
			return IResetCurrentDungeon.EndIResetCurrentDungeon(builder);
		}

		// Token: 0x0601CE5C RID: 118364 RVA: 0x004112FA File Offset: 0x0040F4FA
		public static void StartIResetCurrentDungeon(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601CE5D RID: 118365 RVA: 0x00411303 File Offset: 0x0040F503
		public static void AddType(FlatBufferBuilder builder, EGmCommand type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601CE5E RID: 118366 RVA: 0x0041130E File Offset: 0x0040F50E
		public static Offset<IResetCurrentDungeon> EndIResetCurrentDungeon(FlatBufferBuilder builder)
		{
			return new Offset<IResetCurrentDungeon>(builder.EndTable());
		}

		// Token: 0x0601CE5F RID: 118367 RVA: 0x0041131C File Offset: 0x0040F51C
		public IResetCurrentDungeonT UnPack()
		{
			IResetCurrentDungeonT resetCurrentDungeonT = new IResetCurrentDungeonT();
			this.UnPackTo(resetCurrentDungeonT);
			return resetCurrentDungeonT;
		}

		// Token: 0x0601CE60 RID: 118368 RVA: 0x00411337 File Offset: 0x0040F537
		public void UnPackTo(IResetCurrentDungeonT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601CE61 RID: 118369 RVA: 0x00411348 File Offset: 0x0040F548
		public static Offset<IResetCurrentDungeon> Pack(FlatBufferBuilder builder, IResetCurrentDungeonT _o)
		{
			if (_o == null)
			{
				return default(Offset<IResetCurrentDungeon>);
			}
			return IResetCurrentDungeon.CreateIResetCurrentDungeon(builder, _o.Type);
		}

		// Token: 0x0400D275 RID: 53877
		private Table __p;
	}
}
