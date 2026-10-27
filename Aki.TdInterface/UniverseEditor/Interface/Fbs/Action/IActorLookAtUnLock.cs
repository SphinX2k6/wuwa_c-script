using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020060EF RID: 24815
	public struct IActorLookAtUnLock : IFlatbufferObject
	{
		// Token: 0x1700B6E9 RID: 46825
		// (get) Token: 0x0602A64A RID: 173642 RVA: 0x005D75E0 File Offset: 0x005D57E0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602A64B RID: 173643 RVA: 0x005D75ED File Offset: 0x005D57ED
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602A64C RID: 173644 RVA: 0x005D75F4 File Offset: 0x005D57F4
		public static IActorLookAtUnLock GetRootAsIActorLookAtUnLock(ByteBuffer _bb)
		{
			return IActorLookAtUnLock.GetRootAsIActorLookAtUnLock(_bb, default(IActorLookAtUnLock));
		}

		// Token: 0x0602A64D RID: 173645 RVA: 0x005D7610 File Offset: 0x005D5810
		public static IActorLookAtUnLock GetRootAsIActorLookAtUnLock(ByteBuffer _bb, IActorLookAtUnLock obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602A64E RID: 173646 RVA: 0x005D762D File Offset: 0x005D582D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602A64F RID: 173647 RVA: 0x005D763C File Offset: 0x005D583C
		public IActorLookAtUnLock __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B6EA RID: 46826
		// (get) Token: 0x0602A650 RID: 173648 RVA: 0x005D764C File Offset: 0x005D584C
		public EActorLookAtMode Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EActorLookAtMode.Talker;
				}
				return (EActorLookAtMode)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602A651 RID: 173649 RVA: 0x005D7688 File Offset: 0x005D5888
		public static Offset<IActorLookAtUnLock> CreateIActorLookAtUnLock(FlatBufferBuilder builder, EActorLookAtMode Type = EActorLookAtMode.Talker)
		{
			builder.StartTable(1);
			IActorLookAtUnLock.AddType(builder, Type);
			return IActorLookAtUnLock.EndIActorLookAtUnLock(builder);
		}

		// Token: 0x0602A652 RID: 173650 RVA: 0x005D769E File Offset: 0x005D589E
		public static void StartIActorLookAtUnLock(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602A653 RID: 173651 RVA: 0x005D76A7 File Offset: 0x005D58A7
		public static void AddType(FlatBufferBuilder builder, EActorLookAtMode type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602A654 RID: 173652 RVA: 0x005D76B2 File Offset: 0x005D58B2
		public static Offset<IActorLookAtUnLock> EndIActorLookAtUnLock(FlatBufferBuilder builder)
		{
			return new Offset<IActorLookAtUnLock>(builder.EndTable());
		}

		// Token: 0x0602A655 RID: 173653 RVA: 0x005D76C0 File Offset: 0x005D58C0
		public IActorLookAtUnLockT UnPack()
		{
			IActorLookAtUnLockT actorLookAtUnLockT = new IActorLookAtUnLockT();
			this.UnPackTo(actorLookAtUnLockT);
			return actorLookAtUnLockT;
		}

		// Token: 0x0602A656 RID: 173654 RVA: 0x005D76DB File Offset: 0x005D58DB
		public void UnPackTo(IActorLookAtUnLockT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602A657 RID: 173655 RVA: 0x005D76EC File Offset: 0x005D58EC
		public static Offset<IActorLookAtUnLock> Pack(FlatBufferBuilder builder, IActorLookAtUnLockT _o)
		{
			if (_o == null)
			{
				return default(Offset<IActorLookAtUnLock>);
			}
			return IActorLookAtUnLock.CreateIActorLookAtUnLock(builder, _o.Type);
		}

		// Token: 0x040104B2 RID: 66738
		private Table __p;
	}
}
