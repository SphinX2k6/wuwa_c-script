using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007CCB RID: 31947
	public struct IUnlockDungeonEntry : IFlatbufferObject
	{
		// Token: 0x1700EF22 RID: 61218
		// (get) Token: 0x06039A0A RID: 236042 RVA: 0x007C66F6 File Offset: 0x007C48F6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06039A0B RID: 236043 RVA: 0x007C6703 File Offset: 0x007C4903
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06039A0C RID: 236044 RVA: 0x007C670C File Offset: 0x007C490C
		public static IUnlockDungeonEntry GetRootAsIUnlockDungeonEntry(ByteBuffer _bb)
		{
			return IUnlockDungeonEntry.GetRootAsIUnlockDungeonEntry(_bb, default(IUnlockDungeonEntry));
		}

		// Token: 0x06039A0D RID: 236045 RVA: 0x007C6728 File Offset: 0x007C4928
		public static IUnlockDungeonEntry GetRootAsIUnlockDungeonEntry(ByteBuffer _bb, IUnlockDungeonEntry obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06039A0E RID: 236046 RVA: 0x007C6745 File Offset: 0x007C4945
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06039A0F RID: 236047 RVA: 0x007C6754 File Offset: 0x007C4954
		public IUnlockDungeonEntry __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700EF23 RID: 61219
		// (get) Token: 0x06039A10 RID: 236048 RVA: 0x007C6764 File Offset: 0x007C4964
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

		// Token: 0x06039A11 RID: 236049 RVA: 0x007C67A0 File Offset: 0x007C49A0
		public static Offset<IUnlockDungeonEntry> CreateIUnlockDungeonEntry(FlatBufferBuilder builder, int DungeonEntryId = 0)
		{
			builder.StartTable(1);
			IUnlockDungeonEntry.AddDungeonEntryId(builder, DungeonEntryId);
			return IUnlockDungeonEntry.EndIUnlockDungeonEntry(builder);
		}

		// Token: 0x06039A12 RID: 236050 RVA: 0x007C67B6 File Offset: 0x007C49B6
		public static void StartIUnlockDungeonEntry(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06039A13 RID: 236051 RVA: 0x007C67BF File Offset: 0x007C49BF
		public static void AddDungeonEntryId(FlatBufferBuilder builder, int dungeonEntryId)
		{
			builder.AddInt(0, dungeonEntryId, 0);
		}

		// Token: 0x06039A14 RID: 236052 RVA: 0x007C67CA File Offset: 0x007C49CA
		public static Offset<IUnlockDungeonEntry> EndIUnlockDungeonEntry(FlatBufferBuilder builder)
		{
			return new Offset<IUnlockDungeonEntry>(builder.EndTable());
		}

		// Token: 0x06039A15 RID: 236053 RVA: 0x007C67D8 File Offset: 0x007C49D8
		public IUnlockDungeonEntryT UnPack()
		{
			IUnlockDungeonEntryT unlockDungeonEntryT = new IUnlockDungeonEntryT();
			this.UnPackTo(unlockDungeonEntryT);
			return unlockDungeonEntryT;
		}

		// Token: 0x06039A16 RID: 236054 RVA: 0x007C67F3 File Offset: 0x007C49F3
		public void UnPackTo(IUnlockDungeonEntryT _o)
		{
			_o.DungeonEntryId = this.DungeonEntryId;
		}

		// Token: 0x06039A17 RID: 236055 RVA: 0x007C6804 File Offset: 0x007C4A04
		public static Offset<IUnlockDungeonEntry> Pack(FlatBufferBuilder builder, IUnlockDungeonEntryT _o)
		{
			if (_o == null)
			{
				return default(Offset<IUnlockDungeonEntry>);
			}
			return IUnlockDungeonEntry.CreateIUnlockDungeonEntry(builder, _o.DungeonEntryId);
		}

		// Token: 0x040133D0 RID: 78800
		private Table __p;
	}
}
