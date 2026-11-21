using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007CDD RID: 31965
	public struct IUnlockTeleportTrigger : IFlatbufferObject
	{
		// Token: 0x1700EF35 RID: 61237
		// (get) Token: 0x06039A8B RID: 236171 RVA: 0x007C74A2 File Offset: 0x007C56A2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06039A8C RID: 236172 RVA: 0x007C74AF File Offset: 0x007C56AF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06039A8D RID: 236173 RVA: 0x007C74B8 File Offset: 0x007C56B8
		public static IUnlockTeleportTrigger GetRootAsIUnlockTeleportTrigger(ByteBuffer _bb)
		{
			return IUnlockTeleportTrigger.GetRootAsIUnlockTeleportTrigger(_bb, default(IUnlockTeleportTrigger));
		}

		// Token: 0x06039A8E RID: 236174 RVA: 0x007C74D4 File Offset: 0x007C56D4
		public static IUnlockTeleportTrigger GetRootAsIUnlockTeleportTrigger(ByteBuffer _bb, IUnlockTeleportTrigger obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06039A8F RID: 236175 RVA: 0x007C74F1 File Offset: 0x007C56F1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06039A90 RID: 236176 RVA: 0x007C7500 File Offset: 0x007C5700
		public IUnlockTeleportTrigger __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700EF36 RID: 61238
		// (get) Token: 0x06039A91 RID: 236177 RVA: 0x007C7510 File Offset: 0x007C5710
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

		// Token: 0x06039A92 RID: 236178 RVA: 0x007C754C File Offset: 0x007C574C
		public static Offset<IUnlockTeleportTrigger> CreateIUnlockTeleportTrigger(FlatBufferBuilder builder, int TeleportId = 0)
		{
			builder.StartTable(1);
			IUnlockTeleportTrigger.AddTeleportId(builder, TeleportId);
			return IUnlockTeleportTrigger.EndIUnlockTeleportTrigger(builder);
		}

		// Token: 0x06039A93 RID: 236179 RVA: 0x007C7562 File Offset: 0x007C5762
		public static void StartIUnlockTeleportTrigger(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06039A94 RID: 236180 RVA: 0x007C756B File Offset: 0x007C576B
		public static void AddTeleportId(FlatBufferBuilder builder, int teleportId)
		{
			builder.AddInt(0, teleportId, 0);
		}

		// Token: 0x06039A95 RID: 236181 RVA: 0x007C7576 File Offset: 0x007C5776
		public static Offset<IUnlockTeleportTrigger> EndIUnlockTeleportTrigger(FlatBufferBuilder builder)
		{
			return new Offset<IUnlockTeleportTrigger>(builder.EndTable());
		}

		// Token: 0x06039A96 RID: 236182 RVA: 0x007C7584 File Offset: 0x007C5784
		public IUnlockTeleportTriggerT UnPack()
		{
			IUnlockTeleportTriggerT unlockTeleportTriggerT = new IUnlockTeleportTriggerT();
			this.UnPackTo(unlockTeleportTriggerT);
			return unlockTeleportTriggerT;
		}

		// Token: 0x06039A97 RID: 236183 RVA: 0x007C759F File Offset: 0x007C579F
		public void UnPackTo(IUnlockTeleportTriggerT _o)
		{
			_o.TeleportId = this.TeleportId;
		}

		// Token: 0x06039A98 RID: 236184 RVA: 0x007C75B0 File Offset: 0x007C57B0
		public static Offset<IUnlockTeleportTrigger> Pack(FlatBufferBuilder builder, IUnlockTeleportTriggerT _o)
		{
			if (_o == null)
			{
				return default(Offset<IUnlockTeleportTrigger>);
			}
			return IUnlockTeleportTrigger.CreateIUnlockTeleportTrigger(builder, _o.TeleportId);
		}

		// Token: 0x040133E5 RID: 78821
		private Table __p;
	}
}
