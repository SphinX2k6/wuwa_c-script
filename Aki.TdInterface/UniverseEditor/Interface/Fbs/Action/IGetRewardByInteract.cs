using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F29 RID: 28457
	public struct IGetRewardByInteract : IFlatbufferObject
	{
		// Token: 0x1700D09F RID: 53407
		// (get) Token: 0x060313F3 RID: 201715 RVA: 0x006AC2D9 File Offset: 0x006AA4D9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060313F4 RID: 201716 RVA: 0x006AC2E6 File Offset: 0x006AA4E6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060313F5 RID: 201717 RVA: 0x006AC2F0 File Offset: 0x006AA4F0
		public static IGetRewardByInteract GetRootAsIGetRewardByInteract(ByteBuffer _bb)
		{
			return IGetRewardByInteract.GetRootAsIGetRewardByInteract(_bb, default(IGetRewardByInteract));
		}

		// Token: 0x060313F6 RID: 201718 RVA: 0x006AC30C File Offset: 0x006AA50C
		public static IGetRewardByInteract GetRootAsIGetRewardByInteract(ByteBuffer _bb, IGetRewardByInteract obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060313F7 RID: 201719 RVA: 0x006AC329 File Offset: 0x006AA529
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060313F8 RID: 201720 RVA: 0x006AC338 File Offset: 0x006AA538
		public IGetRewardByInteract __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x060313F9 RID: 201721 RVA: 0x006AC348 File Offset: 0x006AA548
		public static void StartIGetRewardByInteract(FlatBufferBuilder builder)
		{
			builder.StartTable(0);
		}

		// Token: 0x060313FA RID: 201722 RVA: 0x006AC351 File Offset: 0x006AA551
		public static Offset<IGetRewardByInteract> EndIGetRewardByInteract(FlatBufferBuilder builder)
		{
			return new Offset<IGetRewardByInteract>(builder.EndTable());
		}

		// Token: 0x060313FB RID: 201723 RVA: 0x006AC360 File Offset: 0x006AA560
		public IGetRewardByInteractT UnPack()
		{
			IGetRewardByInteractT getRewardByInteractT = new IGetRewardByInteractT();
			this.UnPackTo(getRewardByInteractT);
			return getRewardByInteractT;
		}

		// Token: 0x060313FC RID: 201724 RVA: 0x006AC37B File Offset: 0x006AA57B
		public void UnPackTo(IGetRewardByInteractT _o)
		{
		}

		// Token: 0x060313FD RID: 201725 RVA: 0x006AC380 File Offset: 0x006AA580
		public static Offset<IGetRewardByInteract> Pack(FlatBufferBuilder builder, IGetRewardByInteractT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGetRewardByInteract>);
			}
			IGetRewardByInteract.StartIGetRewardByInteract(builder);
			return IGetRewardByInteract.EndIGetRewardByInteract(builder);
		}

		// Token: 0x04011E32 RID: 73266
		private Table __p;
	}
}
