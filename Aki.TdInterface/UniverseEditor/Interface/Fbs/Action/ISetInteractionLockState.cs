using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020077CD RID: 30669
	public struct ISetInteractionLockState : IFlatbufferObject
	{
		// Token: 0x1700E0D4 RID: 57556
		// (get) Token: 0x06035E03 RID: 220675 RVA: 0x0073800C File Offset: 0x0073620C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06035E04 RID: 220676 RVA: 0x00738019 File Offset: 0x00736219
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06035E05 RID: 220677 RVA: 0x00738020 File Offset: 0x00736220
		public static ISetInteractionLockState GetRootAsISetInteractionLockState(ByteBuffer _bb)
		{
			return ISetInteractionLockState.GetRootAsISetInteractionLockState(_bb, default(ISetInteractionLockState));
		}

		// Token: 0x06035E06 RID: 220678 RVA: 0x0073803C File Offset: 0x0073623C
		public static ISetInteractionLockState GetRootAsISetInteractionLockState(ByteBuffer _bb, ISetInteractionLockState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06035E07 RID: 220679 RVA: 0x00738059 File Offset: 0x00736259
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06035E08 RID: 220680 RVA: 0x00738068 File Offset: 0x00736268
		public ISetInteractionLockState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E0D5 RID: 57557
		// (get) Token: 0x06035E09 RID: 220681 RVA: 0x00738078 File Offset: 0x00736278
		public bool IsLock
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06035E0A RID: 220682 RVA: 0x007380B7 File Offset: 0x007362B7
		public static Offset<ISetInteractionLockState> CreateISetInteractionLockState(FlatBufferBuilder builder, bool IsLock = false)
		{
			builder.StartTable(1);
			ISetInteractionLockState.AddIsLock(builder, IsLock);
			return ISetInteractionLockState.EndISetInteractionLockState(builder);
		}

		// Token: 0x06035E0B RID: 220683 RVA: 0x007380CD File Offset: 0x007362CD
		public static void StartISetInteractionLockState(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06035E0C RID: 220684 RVA: 0x007380D6 File Offset: 0x007362D6
		public static void AddIsLock(FlatBufferBuilder builder, bool isLock)
		{
			builder.AddBool(0, isLock, false);
		}

		// Token: 0x06035E0D RID: 220685 RVA: 0x007380E1 File Offset: 0x007362E1
		public static Offset<ISetInteractionLockState> EndISetInteractionLockState(FlatBufferBuilder builder)
		{
			return new Offset<ISetInteractionLockState>(builder.EndTable());
		}

		// Token: 0x06035E0E RID: 220686 RVA: 0x007380F0 File Offset: 0x007362F0
		public ISetInteractionLockStateT UnPack()
		{
			ISetInteractionLockStateT setInteractionLockStateT = new ISetInteractionLockStateT();
			this.UnPackTo(setInteractionLockStateT);
			return setInteractionLockStateT;
		}

		// Token: 0x06035E0F RID: 220687 RVA: 0x0073810B File Offset: 0x0073630B
		public void UnPackTo(ISetInteractionLockStateT _o)
		{
			_o.IsLock = this.IsLock;
		}

		// Token: 0x06035E10 RID: 220688 RVA: 0x0073811C File Offset: 0x0073631C
		public static Offset<ISetInteractionLockState> Pack(FlatBufferBuilder builder, ISetInteractionLockStateT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISetInteractionLockState>);
			}
			return ISetInteractionLockState.CreateISetInteractionLockState(builder, _o.IsLock);
		}

		// Token: 0x04012A0E RID: 76302
		private Table __p;
	}
}
