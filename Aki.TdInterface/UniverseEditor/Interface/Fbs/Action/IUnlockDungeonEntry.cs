using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020074D5 RID: 29909
	public struct IUnlockDungeonEntry : IFlatbufferObject
	{
		// Token: 0x1700E2F8 RID: 58104
		// (get) Token: 0x060365F5 RID: 222709 RVA: 0x007634A6 File Offset: 0x007616A6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060365F6 RID: 222710 RVA: 0x007634B3 File Offset: 0x007616B3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060365F7 RID: 222711 RVA: 0x007634BC File Offset: 0x007616BC
		public static IUnlockDungeonEntry GetRootAsIUnlockDungeonEntry(ByteBuffer _bb)
		{
			return IUnlockDungeonEntry.GetRootAsIUnlockDungeonEntry(_bb, default(IUnlockDungeonEntry));
		}

		// Token: 0x060365F8 RID: 222712 RVA: 0x007634D8 File Offset: 0x007616D8
		public static IUnlockDungeonEntry GetRootAsIUnlockDungeonEntry(ByteBuffer _bb, IUnlockDungeonEntry obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060365F9 RID: 222713 RVA: 0x007634F5 File Offset: 0x007616F5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060365FA RID: 222714 RVA: 0x00763504 File Offset: 0x00761704
		public IUnlockDungeonEntry __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E2F9 RID: 58105
		// (get) Token: 0x060365FB RID: 222715 RVA: 0x00763514 File Offset: 0x00761714
		public int DungeonEntryId
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

		// Token: 0x060365FC RID: 222716 RVA: 0x00763550 File Offset: 0x00761750
		public static Offset<IUnlockDungeonEntry> CreateIUnlockDungeonEntry(FlatBufferBuilder builder, int DungeonEntryId = 0)
		{
			builder.StartTable(1);
			IUnlockDungeonEntry.AddDungeonEntryId(builder, DungeonEntryId);
			return IUnlockDungeonEntry.EndIUnlockDungeonEntry(builder);
		}

		// Token: 0x060365FD RID: 222717 RVA: 0x00763566 File Offset: 0x00761766
		public static void StartIUnlockDungeonEntry(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060365FE RID: 222718 RVA: 0x0076356F File Offset: 0x0076176F
		public static void AddDungeonEntryId(FlatBufferBuilder builder, int dungeonEntryId)
		{
			builder.AddInt(0, dungeonEntryId, 0);
		}

		// Token: 0x060365FF RID: 222719 RVA: 0x0076357A File Offset: 0x0076177A
		public static Offset<IUnlockDungeonEntry> EndIUnlockDungeonEntry(FlatBufferBuilder builder)
		{
			return new Offset<IUnlockDungeonEntry>(builder.EndTable());
		}

		// Token: 0x06036600 RID: 222720 RVA: 0x00763588 File Offset: 0x00761788
		public IUnlockDungeonEntryT UnPack()
		{
			IUnlockDungeonEntryT unlockDungeonEntryT = new IUnlockDungeonEntryT();
			this.UnPackTo(unlockDungeonEntryT);
			return unlockDungeonEntryT;
		}

		// Token: 0x06036601 RID: 222721 RVA: 0x007635A3 File Offset: 0x007617A3
		public void UnPackTo(IUnlockDungeonEntryT _o)
		{
			_o.DungeonEntryId = this.DungeonEntryId;
		}

		// Token: 0x06036602 RID: 222722 RVA: 0x007635B4 File Offset: 0x007617B4
		public static Offset<IUnlockDungeonEntry> Pack(FlatBufferBuilder builder, IUnlockDungeonEntryT _o)
		{
			if (_o == null)
			{
				return default(Offset<IUnlockDungeonEntry>);
			}
			return IUnlockDungeonEntry.CreateIUnlockDungeonEntry(builder, _o.DungeonEntryId);
		}

		// Token: 0x0401239F RID: 74655
		private Table __p;
	}
}
