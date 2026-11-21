using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A8C RID: 27276
	public struct IClientUnlockAchievementSystemItem : IFlatbufferObject
	{
		// Token: 0x1700C853 RID: 51283
		// (get) Token: 0x0602ECE5 RID: 191717 RVA: 0x006611C4 File Offset: 0x0065F3C4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602ECE6 RID: 191718 RVA: 0x006611D1 File Offset: 0x0065F3D1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602ECE7 RID: 191719 RVA: 0x006611D8 File Offset: 0x0065F3D8
		public static IClientUnlockAchievementSystemItem GetRootAsIClientUnlockAchievementSystemItem(ByteBuffer _bb)
		{
			return IClientUnlockAchievementSystemItem.GetRootAsIClientUnlockAchievementSystemItem(_bb, default(IClientUnlockAchievementSystemItem));
		}

		// Token: 0x0602ECE8 RID: 191720 RVA: 0x006611F4 File Offset: 0x0065F3F4
		public static IClientUnlockAchievementSystemItem GetRootAsIClientUnlockAchievementSystemItem(ByteBuffer _bb, IClientUnlockAchievementSystemItem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602ECE9 RID: 191721 RVA: 0x00661211 File Offset: 0x0065F411
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602ECEA RID: 191722 RVA: 0x00661220 File Offset: 0x0065F420
		public IClientUnlockAchievementSystemItem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C854 RID: 51284
		// (get) Token: 0x0602ECEB RID: 191723 RVA: 0x00661230 File Offset: 0x0065F430
		public int Id
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

		// Token: 0x0602ECEC RID: 191724 RVA: 0x0066126C File Offset: 0x0065F46C
		public static Offset<IClientUnlockAchievementSystemItem> CreateIClientUnlockAchievementSystemItem(FlatBufferBuilder builder, int Id = 0)
		{
			builder.StartTable(1);
			IClientUnlockAchievementSystemItem.AddId(builder, Id);
			return IClientUnlockAchievementSystemItem.EndIClientUnlockAchievementSystemItem(builder);
		}

		// Token: 0x0602ECED RID: 191725 RVA: 0x00661282 File Offset: 0x0065F482
		public static void StartIClientUnlockAchievementSystemItem(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602ECEE RID: 191726 RVA: 0x0066128B File Offset: 0x0065F48B
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(0, id, 0);
		}

		// Token: 0x0602ECEF RID: 191727 RVA: 0x00661296 File Offset: 0x0065F496
		public static Offset<IClientUnlockAchievementSystemItem> EndIClientUnlockAchievementSystemItem(FlatBufferBuilder builder)
		{
			return new Offset<IClientUnlockAchievementSystemItem>(builder.EndTable());
		}

		// Token: 0x0602ECF0 RID: 191728 RVA: 0x006612A4 File Offset: 0x0065F4A4
		public IClientUnlockAchievementSystemItemT UnPack()
		{
			IClientUnlockAchievementSystemItemT clientUnlockAchievementSystemItemT = new IClientUnlockAchievementSystemItemT();
			this.UnPackTo(clientUnlockAchievementSystemItemT);
			return clientUnlockAchievementSystemItemT;
		}

		// Token: 0x0602ECF1 RID: 191729 RVA: 0x006612BF File Offset: 0x0065F4BF
		public void UnPackTo(IClientUnlockAchievementSystemItemT _o)
		{
			_o.Id = this.Id;
		}

		// Token: 0x0602ECF2 RID: 191730 RVA: 0x006612D0 File Offset: 0x0065F4D0
		public static Offset<IClientUnlockAchievementSystemItem> Pack(FlatBufferBuilder builder, IClientUnlockAchievementSystemItemT _o)
		{
			if (_o == null)
			{
				return default(Offset<IClientUnlockAchievementSystemItem>);
			}
			return IClientUnlockAchievementSystemItem.CreateIClientUnlockAchievementSystemItem(builder, _o.Id);
		}

		// Token: 0x04011821 RID: 71713
		private Table __p;
	}
}
