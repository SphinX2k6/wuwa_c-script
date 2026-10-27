using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020074E7 RID: 29927
	public struct IUnlockTeleportTrigger : IFlatbufferObject
	{
		// Token: 0x1700E30B RID: 58123
		// (get) Token: 0x06036676 RID: 222838 RVA: 0x00764252 File Offset: 0x00762452
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036677 RID: 222839 RVA: 0x0076425F File Offset: 0x0076245F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036678 RID: 222840 RVA: 0x00764268 File Offset: 0x00762468
		public static IUnlockTeleportTrigger GetRootAsIUnlockTeleportTrigger(ByteBuffer _bb)
		{
			return IUnlockTeleportTrigger.GetRootAsIUnlockTeleportTrigger(_bb, default(IUnlockTeleportTrigger));
		}

		// Token: 0x06036679 RID: 222841 RVA: 0x00764284 File Offset: 0x00762484
		public static IUnlockTeleportTrigger GetRootAsIUnlockTeleportTrigger(ByteBuffer _bb, IUnlockTeleportTrigger obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603667A RID: 222842 RVA: 0x007642A1 File Offset: 0x007624A1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603667B RID: 222843 RVA: 0x007642B0 File Offset: 0x007624B0
		public IUnlockTeleportTrigger __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E30C RID: 58124
		// (get) Token: 0x0603667C RID: 222844 RVA: 0x007642C0 File Offset: 0x007624C0
		public int TeleportId
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

		// Token: 0x0603667D RID: 222845 RVA: 0x007642FC File Offset: 0x007624FC
		public static Offset<IUnlockTeleportTrigger> CreateIUnlockTeleportTrigger(FlatBufferBuilder builder, int TeleportId = 0)
		{
			builder.StartTable(1);
			IUnlockTeleportTrigger.AddTeleportId(builder, TeleportId);
			return IUnlockTeleportTrigger.EndIUnlockTeleportTrigger(builder);
		}

		// Token: 0x0603667E RID: 222846 RVA: 0x00764312 File Offset: 0x00762512
		public static void StartIUnlockTeleportTrigger(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0603667F RID: 222847 RVA: 0x0076431B File Offset: 0x0076251B
		public static void AddTeleportId(FlatBufferBuilder builder, int teleportId)
		{
			builder.AddInt(0, teleportId, 0);
		}

		// Token: 0x06036680 RID: 222848 RVA: 0x00764326 File Offset: 0x00762526
		public static Offset<IUnlockTeleportTrigger> EndIUnlockTeleportTrigger(FlatBufferBuilder builder)
		{
			return new Offset<IUnlockTeleportTrigger>(builder.EndTable());
		}

		// Token: 0x06036681 RID: 222849 RVA: 0x00764334 File Offset: 0x00762534
		public IUnlockTeleportTriggerT UnPack()
		{
			IUnlockTeleportTriggerT unlockTeleportTriggerT = new IUnlockTeleportTriggerT();
			this.UnPackTo(unlockTeleportTriggerT);
			return unlockTeleportTriggerT;
		}

		// Token: 0x06036682 RID: 222850 RVA: 0x0076434F File Offset: 0x0076254F
		public void UnPackTo(IUnlockTeleportTriggerT _o)
		{
			_o.TeleportId = this.TeleportId;
		}

		// Token: 0x06036683 RID: 222851 RVA: 0x00764360 File Offset: 0x00762560
		public static Offset<IUnlockTeleportTrigger> Pack(FlatBufferBuilder builder, IUnlockTeleportTriggerT _o)
		{
			if (_o == null)
			{
				return default(Offset<IUnlockTeleportTrigger>);
			}
			return IUnlockTeleportTrigger.CreateIUnlockTeleportTrigger(builder, _o.TeleportId);
		}

		// Token: 0x040123B4 RID: 74676
		private Table __p;
	}
}
