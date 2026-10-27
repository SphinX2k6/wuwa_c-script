using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200640C RID: 25612
	public struct IClientUnlockAchievementSystemItem : IFlatbufferObject
	{
		// Token: 0x1700BEB9 RID: 48825
		// (get) Token: 0x0602C50F RID: 181519 RVA: 0x00615338 File Offset: 0x00613538
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602C510 RID: 181520 RVA: 0x00615345 File Offset: 0x00613545
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602C511 RID: 181521 RVA: 0x0061534C File Offset: 0x0061354C
		public static IClientUnlockAchievementSystemItem GetRootAsIClientUnlockAchievementSystemItem(ByteBuffer _bb)
		{
			return IClientUnlockAchievementSystemItem.GetRootAsIClientUnlockAchievementSystemItem(_bb, default(IClientUnlockAchievementSystemItem));
		}

		// Token: 0x0602C512 RID: 181522 RVA: 0x00615368 File Offset: 0x00613568
		public static IClientUnlockAchievementSystemItem GetRootAsIClientUnlockAchievementSystemItem(ByteBuffer _bb, IClientUnlockAchievementSystemItem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602C513 RID: 181523 RVA: 0x00615385 File Offset: 0x00613585
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602C514 RID: 181524 RVA: 0x00615394 File Offset: 0x00613594
		public IClientUnlockAchievementSystemItem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BEBA RID: 48826
		// (get) Token: 0x0602C515 RID: 181525 RVA: 0x006153A4 File Offset: 0x006135A4
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

		// Token: 0x0602C516 RID: 181526 RVA: 0x006153E0 File Offset: 0x006135E0
		public static Offset<IClientUnlockAchievementSystemItem> CreateIClientUnlockAchievementSystemItem(FlatBufferBuilder builder, int Id = 0)
		{
			builder.StartTable(1);
			IClientUnlockAchievementSystemItem.AddId(builder, Id);
			return IClientUnlockAchievementSystemItem.EndIClientUnlockAchievementSystemItem(builder);
		}

		// Token: 0x0602C517 RID: 181527 RVA: 0x006153F6 File Offset: 0x006135F6
		public static void StartIClientUnlockAchievementSystemItem(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602C518 RID: 181528 RVA: 0x006153FF File Offset: 0x006135FF
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(0, id, 0);
		}

		// Token: 0x0602C519 RID: 181529 RVA: 0x0061540A File Offset: 0x0061360A
		public static Offset<IClientUnlockAchievementSystemItem> EndIClientUnlockAchievementSystemItem(FlatBufferBuilder builder)
		{
			return new Offset<IClientUnlockAchievementSystemItem>(builder.EndTable());
		}

		// Token: 0x0602C51A RID: 181530 RVA: 0x00615418 File Offset: 0x00613618
		public IClientUnlockAchievementSystemItemT UnPack()
		{
			IClientUnlockAchievementSystemItemT clientUnlockAchievementSystemItemT = new IClientUnlockAchievementSystemItemT();
			this.UnPackTo(clientUnlockAchievementSystemItemT);
			return clientUnlockAchievementSystemItemT;
		}

		// Token: 0x0602C51B RID: 181531 RVA: 0x00615433 File Offset: 0x00613633
		public void UnPackTo(IClientUnlockAchievementSystemItemT _o)
		{
			_o.Id = this.Id;
		}

		// Token: 0x0602C51C RID: 181532 RVA: 0x00615444 File Offset: 0x00613644
		public static Offset<IClientUnlockAchievementSystemItem> Pack(FlatBufferBuilder builder, IClientUnlockAchievementSystemItemT _o)
		{
			if (_o == null)
			{
				return default(Offset<IClientUnlockAchievementSystemItem>);
			}
			return IClientUnlockAchievementSystemItem.CreateIClientUnlockAchievementSystemItem(builder, _o.Id);
		}

		// Token: 0x040109FB RID: 68091
		private Table __p;
	}
}
