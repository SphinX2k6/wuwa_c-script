using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007004 RID: 28676
	public struct ISetInteractionLockState : IFlatbufferObject
	{
		// Token: 0x1700D500 RID: 54528
		// (get) Token: 0x06032B9D RID: 207773 RVA: 0x006D83C8 File Offset: 0x006D65C8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06032B9E RID: 207774 RVA: 0x006D83D5 File Offset: 0x006D65D5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06032B9F RID: 207775 RVA: 0x006D83DC File Offset: 0x006D65DC
		public static ISetInteractionLockState GetRootAsISetInteractionLockState(ByteBuffer _bb)
		{
			return ISetInteractionLockState.GetRootAsISetInteractionLockState(_bb, default(ISetInteractionLockState));
		}

		// Token: 0x06032BA0 RID: 207776 RVA: 0x006D83F8 File Offset: 0x006D65F8
		public static ISetInteractionLockState GetRootAsISetInteractionLockState(ByteBuffer _bb, ISetInteractionLockState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06032BA1 RID: 207777 RVA: 0x006D8415 File Offset: 0x006D6615
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06032BA2 RID: 207778 RVA: 0x006D8424 File Offset: 0x006D6624
		public ISetInteractionLockState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D501 RID: 54529
		// (get) Token: 0x06032BA3 RID: 207779 RVA: 0x006D8434 File Offset: 0x006D6634
		public bool IsLock
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06032BA4 RID: 207780 RVA: 0x006D8473 File Offset: 0x006D6673
		public static Offset<ISetInteractionLockState> CreateISetInteractionLockState(FlatBufferBuilder builder, bool IsLock = false)
		{
			builder.StartTable(1);
			ISetInteractionLockState.AddIsLock(builder, IsLock);
			return ISetInteractionLockState.EndISetInteractionLockState(builder);
		}

		// Token: 0x06032BA5 RID: 207781 RVA: 0x006D8489 File Offset: 0x006D6689
		public static void StartISetInteractionLockState(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06032BA6 RID: 207782 RVA: 0x006D8492 File Offset: 0x006D6692
		public static void AddIsLock(FlatBufferBuilder builder, bool isLock)
		{
			builder.AddBool(0, isLock, false);
		}

		// Token: 0x06032BA7 RID: 207783 RVA: 0x006D849D File Offset: 0x006D669D
		public static Offset<ISetInteractionLockState> EndISetInteractionLockState(FlatBufferBuilder builder)
		{
			return new Offset<ISetInteractionLockState>(builder.EndTable());
		}

		// Token: 0x06032BA8 RID: 207784 RVA: 0x006D84AC File Offset: 0x006D66AC
		public ISetInteractionLockStateT UnPack()
		{
			ISetInteractionLockStateT setInteractionLockStateT = new ISetInteractionLockStateT();
			this.UnPackTo(setInteractionLockStateT);
			return setInteractionLockStateT;
		}

		// Token: 0x06032BA9 RID: 207785 RVA: 0x006D84C7 File Offset: 0x006D66C7
		public void UnPackTo(ISetInteractionLockStateT _o)
		{
			_o.IsLock = this.IsLock;
		}

		// Token: 0x06032BAA RID: 207786 RVA: 0x006D84D8 File Offset: 0x006D66D8
		public static Offset<ISetInteractionLockState> Pack(FlatBufferBuilder builder, ISetInteractionLockStateT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISetInteractionLockState>);
			}
			return ISetInteractionLockState.CreateISetInteractionLockState(builder, _o.IsLock);
		}

		// Token: 0x04011A29 RID: 72233
		private Table __p;
	}
}
