using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006751 RID: 26449
	public struct IActorLookAtUnLock : IFlatbufferObject
	{
		// Token: 0x1700C054 RID: 49236
		// (get) Token: 0x0602CD2B RID: 183595 RVA: 0x00621588 File Offset: 0x0061F788
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602CD2C RID: 183596 RVA: 0x00621595 File Offset: 0x0061F795
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602CD2D RID: 183597 RVA: 0x0062159C File Offset: 0x0061F79C
		public static IActorLookAtUnLock GetRootAsIActorLookAtUnLock(ByteBuffer _bb)
		{
			return IActorLookAtUnLock.GetRootAsIActorLookAtUnLock(_bb, default(IActorLookAtUnLock));
		}

		// Token: 0x0602CD2E RID: 183598 RVA: 0x006215B8 File Offset: 0x0061F7B8
		public static IActorLookAtUnLock GetRootAsIActorLookAtUnLock(ByteBuffer _bb, IActorLookAtUnLock obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602CD2F RID: 183599 RVA: 0x006215D5 File Offset: 0x0061F7D5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602CD30 RID: 183600 RVA: 0x006215E4 File Offset: 0x0061F7E4
		public IActorLookAtUnLock __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C055 RID: 49237
		// (get) Token: 0x0602CD31 RID: 183601 RVA: 0x006215F4 File Offset: 0x0061F7F4
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

		// Token: 0x0602CD32 RID: 183602 RVA: 0x00621630 File Offset: 0x0061F830
		public static Offset<IActorLookAtUnLock> CreateIActorLookAtUnLock(FlatBufferBuilder builder, EActorLookAtMode Type = EActorLookAtMode.Talker)
		{
			builder.StartTable(1);
			IActorLookAtUnLock.AddType(builder, Type);
			return IActorLookAtUnLock.EndIActorLookAtUnLock(builder);
		}

		// Token: 0x0602CD33 RID: 183603 RVA: 0x00621646 File Offset: 0x0061F846
		public static void StartIActorLookAtUnLock(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602CD34 RID: 183604 RVA: 0x0062164F File Offset: 0x0061F84F
		public static void AddType(FlatBufferBuilder builder, EActorLookAtMode type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602CD35 RID: 183605 RVA: 0x0062165A File Offset: 0x0061F85A
		public static Offset<IActorLookAtUnLock> EndIActorLookAtUnLock(FlatBufferBuilder builder)
		{
			return new Offset<IActorLookAtUnLock>(builder.EndTable());
		}

		// Token: 0x0602CD36 RID: 183606 RVA: 0x00621668 File Offset: 0x0061F868
		public IActorLookAtUnLockT UnPack()
		{
			IActorLookAtUnLockT actorLookAtUnLockT = new IActorLookAtUnLockT();
			this.UnPackTo(actorLookAtUnLockT);
			return actorLookAtUnLockT;
		}

		// Token: 0x0602CD37 RID: 183607 RVA: 0x00621683 File Offset: 0x0061F883
		public void UnPackTo(IActorLookAtUnLockT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602CD38 RID: 183608 RVA: 0x00621694 File Offset: 0x0061F894
		public static Offset<IActorLookAtUnLock> Pack(FlatBufferBuilder builder, IActorLookAtUnLockT _o)
		{
			if (_o == null)
			{
				return default(Offset<IActorLookAtUnLock>);
			}
			return IActorLookAtUnLock.CreateIActorLookAtUnLock(builder, _o.Type);
		}

		// Token: 0x040112B6 RID: 70326
		private Table __p;
	}
}
