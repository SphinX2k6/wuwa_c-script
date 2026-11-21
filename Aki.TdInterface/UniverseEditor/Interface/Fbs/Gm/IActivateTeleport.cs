using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004A92 RID: 19090
	public struct IActivateTeleport : IFlatbufferObject
	{
		// Token: 0x170085BD RID: 34237
		// (get) Token: 0x0601CB10 RID: 117520 RVA: 0x0040BCA2 File Offset: 0x00409EA2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601CB11 RID: 117521 RVA: 0x0040BCAF File Offset: 0x00409EAF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601CB12 RID: 117522 RVA: 0x0040BCB8 File Offset: 0x00409EB8
		public static IActivateTeleport GetRootAsIActivateTeleport(ByteBuffer _bb)
		{
			return IActivateTeleport.GetRootAsIActivateTeleport(_bb, default(IActivateTeleport));
		}

		// Token: 0x0601CB13 RID: 117523 RVA: 0x0040BCD4 File Offset: 0x00409ED4
		public static IActivateTeleport GetRootAsIActivateTeleport(ByteBuffer _bb, IActivateTeleport obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601CB14 RID: 117524 RVA: 0x0040BCF1 File Offset: 0x00409EF1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601CB15 RID: 117525 RVA: 0x0040BD00 File Offset: 0x00409F00
		public IActivateTeleport __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170085BE RID: 34238
		// (get) Token: 0x0601CB16 RID: 117526 RVA: 0x0040BD10 File Offset: 0x00409F10
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

		// Token: 0x170085BF RID: 34239
		// (get) Token: 0x0601CB17 RID: 117527 RVA: 0x0040BD4C File Offset: 0x00409F4C
		public int TeleportId
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

		// Token: 0x0601CB18 RID: 117528 RVA: 0x0040BD88 File Offset: 0x00409F88
		public static Offset<IActivateTeleport> CreateIActivateTeleport(FlatBufferBuilder builder, EGmCommand Type = EGmCommand.SkipToLevelPlayNode, int TeleportId = 0)
		{
			builder.StartTable(2);
			IActivateTeleport.AddTeleportId(builder, TeleportId);
			IActivateTeleport.AddType(builder, Type);
			return IActivateTeleport.EndIActivateTeleport(builder);
		}

		// Token: 0x0601CB19 RID: 117529 RVA: 0x0040BDA5 File Offset: 0x00409FA5
		public static void StartIActivateTeleport(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601CB1A RID: 117530 RVA: 0x0040BDAE File Offset: 0x00409FAE
		public static void AddType(FlatBufferBuilder builder, EGmCommand type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601CB1B RID: 117531 RVA: 0x0040BDB9 File Offset: 0x00409FB9
		public static void AddTeleportId(FlatBufferBuilder builder, int teleportId)
		{
			builder.AddInt(1, teleportId, 0);
		}

		// Token: 0x0601CB1C RID: 117532 RVA: 0x0040BDC4 File Offset: 0x00409FC4
		public static Offset<IActivateTeleport> EndIActivateTeleport(FlatBufferBuilder builder)
		{
			return new Offset<IActivateTeleport>(builder.EndTable());
		}

		// Token: 0x0601CB1D RID: 117533 RVA: 0x0040BDD4 File Offset: 0x00409FD4
		public IActivateTeleportT UnPack()
		{
			IActivateTeleportT activateTeleportT = new IActivateTeleportT();
			this.UnPackTo(activateTeleportT);
			return activateTeleportT;
		}

		// Token: 0x0601CB1E RID: 117534 RVA: 0x0040BDEF File Offset: 0x00409FEF
		public void UnPackTo(IActivateTeleportT _o)
		{
			_o.Type = this.Type;
			_o.TeleportId = this.TeleportId;
		}

		// Token: 0x0601CB1F RID: 117535 RVA: 0x0040BE0C File Offset: 0x0040A00C
		public static Offset<IActivateTeleport> Pack(FlatBufferBuilder builder, IActivateTeleportT _o)
		{
			if (_o == null)
			{
				return default(Offset<IActivateTeleport>);
			}
			return IActivateTeleport.CreateIActivateTeleport(builder, _o.Type, _o.TeleportId);
		}

		// Token: 0x0400D1D2 RID: 53714
		private Table __p;
	}
}
