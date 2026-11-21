using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004B28 RID: 19240
	public struct ITeleportToLevelPlayCenter : IFlatbufferObject
	{
		// Token: 0x170086F2 RID: 34546
		// (get) Token: 0x0601D054 RID: 118868 RVA: 0x004144B4 File Offset: 0x004126B4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601D055 RID: 118869 RVA: 0x004144C1 File Offset: 0x004126C1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601D056 RID: 118870 RVA: 0x004144C8 File Offset: 0x004126C8
		public static ITeleportToLevelPlayCenter GetRootAsITeleportToLevelPlayCenter(ByteBuffer _bb)
		{
			return ITeleportToLevelPlayCenter.GetRootAsITeleportToLevelPlayCenter(_bb, default(ITeleportToLevelPlayCenter));
		}

		// Token: 0x0601D057 RID: 118871 RVA: 0x004144E4 File Offset: 0x004126E4
		public static ITeleportToLevelPlayCenter GetRootAsITeleportToLevelPlayCenter(ByteBuffer _bb, ITeleportToLevelPlayCenter obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601D058 RID: 118872 RVA: 0x00414501 File Offset: 0x00412701
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601D059 RID: 118873 RVA: 0x00414510 File Offset: 0x00412710
		public ITeleportToLevelPlayCenter __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170086F3 RID: 34547
		// (get) Token: 0x0601D05A RID: 118874 RVA: 0x00414520 File Offset: 0x00412720
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

		// Token: 0x170086F4 RID: 34548
		// (get) Token: 0x0601D05B RID: 118875 RVA: 0x0041455C File Offset: 0x0041275C
		public int LevelPlayId
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

		// Token: 0x0601D05C RID: 118876 RVA: 0x00414598 File Offset: 0x00412798
		public static Offset<ITeleportToLevelPlayCenter> CreateITeleportToLevelPlayCenter(FlatBufferBuilder builder, EGmCommand Type = EGmCommand.SkipToLevelPlayNode, int LevelPlayId = 0)
		{
			builder.StartTable(2);
			ITeleportToLevelPlayCenter.AddLevelPlayId(builder, LevelPlayId);
			ITeleportToLevelPlayCenter.AddType(builder, Type);
			return ITeleportToLevelPlayCenter.EndITeleportToLevelPlayCenter(builder);
		}

		// Token: 0x0601D05D RID: 118877 RVA: 0x004145B5 File Offset: 0x004127B5
		public static void StartITeleportToLevelPlayCenter(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601D05E RID: 118878 RVA: 0x004145BE File Offset: 0x004127BE
		public static void AddType(FlatBufferBuilder builder, EGmCommand type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601D05F RID: 118879 RVA: 0x004145C9 File Offset: 0x004127C9
		public static void AddLevelPlayId(FlatBufferBuilder builder, int levelPlayId)
		{
			builder.AddInt(1, levelPlayId, 0);
		}

		// Token: 0x0601D060 RID: 118880 RVA: 0x004145D4 File Offset: 0x004127D4
		public static Offset<ITeleportToLevelPlayCenter> EndITeleportToLevelPlayCenter(FlatBufferBuilder builder)
		{
			return new Offset<ITeleportToLevelPlayCenter>(builder.EndTable());
		}

		// Token: 0x0601D061 RID: 118881 RVA: 0x004145E4 File Offset: 0x004127E4
		public ITeleportToLevelPlayCenterT UnPack()
		{
			ITeleportToLevelPlayCenterT teleportToLevelPlayCenterT = new ITeleportToLevelPlayCenterT();
			this.UnPackTo(teleportToLevelPlayCenterT);
			return teleportToLevelPlayCenterT;
		}

		// Token: 0x0601D062 RID: 118882 RVA: 0x004145FF File Offset: 0x004127FF
		public void UnPackTo(ITeleportToLevelPlayCenterT _o)
		{
			_o.Type = this.Type;
			_o.LevelPlayId = this.LevelPlayId;
		}

		// Token: 0x0601D063 RID: 118883 RVA: 0x0041461C File Offset: 0x0041281C
		public static Offset<ITeleportToLevelPlayCenter> Pack(FlatBufferBuilder builder, ITeleportToLevelPlayCenterT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITeleportToLevelPlayCenter>);
			}
			return ITeleportToLevelPlayCenter.CreateITeleportToLevelPlayCenter(builder, _o.Type, _o.LevelPlayId);
		}

		// Token: 0x0400D2C1 RID: 53953
		private Table __p;
	}
}
