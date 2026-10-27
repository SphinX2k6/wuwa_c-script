using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200671A RID: 26394
	public struct IExitDungeon : IFlatbufferObject
	{
		// Token: 0x1700C40F RID: 50191
		// (get) Token: 0x0602DE8D RID: 188045 RVA: 0x00646F0E File Offset: 0x0064510E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602DE8E RID: 188046 RVA: 0x00646F1B File Offset: 0x0064511B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602DE8F RID: 188047 RVA: 0x00646F24 File Offset: 0x00645124
		public static IExitDungeon GetRootAsIExitDungeon(ByteBuffer _bb)
		{
			return IExitDungeon.GetRootAsIExitDungeon(_bb, default(IExitDungeon));
		}

		// Token: 0x0602DE90 RID: 188048 RVA: 0x00646F40 File Offset: 0x00645140
		public static IExitDungeon GetRootAsIExitDungeon(ByteBuffer _bb, IExitDungeon obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602DE91 RID: 188049 RVA: 0x00646F5D File Offset: 0x0064515D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602DE92 RID: 188050 RVA: 0x00646F6C File Offset: 0x0064516C
		public IExitDungeon __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C410 RID: 50192
		// (get) Token: 0x0602DE93 RID: 188051 RVA: 0x00646F7C File Offset: 0x0064517C
		public bool IsNeedSecondaryConfirmation
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C411 RID: 50193
		// (get) Token: 0x0602DE94 RID: 188052 RVA: 0x00646FBC File Offset: 0x006451BC
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602DE95 RID: 188053 RVA: 0x00646FF8 File Offset: 0x006451F8
		public static Offset<IExitDungeon> CreateIExitDungeon(FlatBufferBuilder builder, bool IsNeedSecondaryConfirmation = false, byte NullMask = 0)
		{
			builder.StartTable(2);
			IExitDungeon.AddNullMask(builder, NullMask);
			IExitDungeon.AddIsNeedSecondaryConfirmation(builder, IsNeedSecondaryConfirmation);
			return IExitDungeon.EndIExitDungeon(builder);
		}

		// Token: 0x0602DE96 RID: 188054 RVA: 0x00647015 File Offset: 0x00645215
		public static void StartIExitDungeon(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602DE97 RID: 188055 RVA: 0x0064701E File Offset: 0x0064521E
		public static void AddIsNeedSecondaryConfirmation(FlatBufferBuilder builder, bool isNeedSecondaryConfirmation)
		{
			builder.AddBool(0, isNeedSecondaryConfirmation, false);
		}

		// Token: 0x0602DE98 RID: 188056 RVA: 0x00647029 File Offset: 0x00645229
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(1, nullMask, 0);
		}

		// Token: 0x0602DE99 RID: 188057 RVA: 0x00647034 File Offset: 0x00645234
		public static Offset<IExitDungeon> EndIExitDungeon(FlatBufferBuilder builder)
		{
			return new Offset<IExitDungeon>(builder.EndTable());
		}

		// Token: 0x0602DE9A RID: 188058 RVA: 0x00647044 File Offset: 0x00645244
		public IExitDungeonT UnPack()
		{
			IExitDungeonT exitDungeonT = new IExitDungeonT();
			this.UnPackTo(exitDungeonT);
			return exitDungeonT;
		}

		// Token: 0x0602DE9B RID: 188059 RVA: 0x0064705F File Offset: 0x0064525F
		public void UnPackTo(IExitDungeonT _o)
		{
			_o.IsNeedSecondaryConfirmation = this.IsNeedSecondaryConfirmation;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602DE9C RID: 188060 RVA: 0x0064707C File Offset: 0x0064527C
		public static Offset<IExitDungeon> Pack(FlatBufferBuilder builder, IExitDungeonT _o)
		{
			if (_o == null)
			{
				return default(Offset<IExitDungeon>);
			}
			return IExitDungeon.CreateIExitDungeon(builder, _o.IsNeedSecondaryConfirmation, _o.NullMask);
		}

		// Token: 0x04010E01 RID: 69121
		private Table __p;
	}
}
