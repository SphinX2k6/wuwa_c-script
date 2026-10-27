using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006418 RID: 25624
	public struct ICloseDragActor : IFlatbufferObject
	{
		// Token: 0x1700BEC9 RID: 48841
		// (get) Token: 0x0602C55F RID: 181599 RVA: 0x00615A3D File Offset: 0x00613C3D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602C560 RID: 181600 RVA: 0x00615A4A File Offset: 0x00613C4A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602C561 RID: 181601 RVA: 0x00615A54 File Offset: 0x00613C54
		public static ICloseDragActor GetRootAsICloseDragActor(ByteBuffer _bb)
		{
			return ICloseDragActor.GetRootAsICloseDragActor(_bb, default(ICloseDragActor));
		}

		// Token: 0x0602C562 RID: 181602 RVA: 0x00615A70 File Offset: 0x00613C70
		public static ICloseDragActor GetRootAsICloseDragActor(ByteBuffer _bb, ICloseDragActor obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602C563 RID: 181603 RVA: 0x00615A8D File Offset: 0x00613C8D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602C564 RID: 181604 RVA: 0x00615A9C File Offset: 0x00613C9C
		public ICloseDragActor __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BECA RID: 48842
		// (get) Token: 0x0602C565 RID: 181605 RVA: 0x00615AAC File Offset: 0x00613CAC
		public ESimpleGameplayType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESimpleGameplayType.Cipher;
				}
				return (ESimpleGameplayType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700BECB RID: 48843
		// (get) Token: 0x0602C566 RID: 181606 RVA: 0x00615AE8 File Offset: 0x00613CE8
		public int TargetEntityId
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

		// Token: 0x0602C567 RID: 181607 RVA: 0x00615B24 File Offset: 0x00613D24
		public static Offset<ICloseDragActor> CreateICloseDragActor(FlatBufferBuilder builder, ESimpleGameplayType Type = ESimpleGameplayType.Cipher, int TargetEntityId = 0)
		{
			builder.StartTable(2);
			ICloseDragActor.AddTargetEntityId(builder, TargetEntityId);
			ICloseDragActor.AddType(builder, Type);
			return ICloseDragActor.EndICloseDragActor(builder);
		}

		// Token: 0x0602C568 RID: 181608 RVA: 0x00615B41 File Offset: 0x00613D41
		public static void StartICloseDragActor(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602C569 RID: 181609 RVA: 0x00615B4A File Offset: 0x00613D4A
		public static void AddType(FlatBufferBuilder builder, ESimpleGameplayType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602C56A RID: 181610 RVA: 0x00615B55 File Offset: 0x00613D55
		public static void AddTargetEntityId(FlatBufferBuilder builder, int targetEntityId)
		{
			builder.AddInt(1, targetEntityId, 0);
		}

		// Token: 0x0602C56B RID: 181611 RVA: 0x00615B60 File Offset: 0x00613D60
		public static Offset<ICloseDragActor> EndICloseDragActor(FlatBufferBuilder builder)
		{
			return new Offset<ICloseDragActor>(builder.EndTable());
		}

		// Token: 0x0602C56C RID: 181612 RVA: 0x00615B70 File Offset: 0x00613D70
		public ICloseDragActorT UnPack()
		{
			ICloseDragActorT closeDragActorT = new ICloseDragActorT();
			this.UnPackTo(closeDragActorT);
			return closeDragActorT;
		}

		// Token: 0x0602C56D RID: 181613 RVA: 0x00615B8B File Offset: 0x00613D8B
		public void UnPackTo(ICloseDragActorT _o)
		{
			_o.Type = this.Type;
			_o.TargetEntityId = this.TargetEntityId;
		}

		// Token: 0x0602C56E RID: 181614 RVA: 0x00615BA8 File Offset: 0x00613DA8
		public static Offset<ICloseDragActor> Pack(FlatBufferBuilder builder, ICloseDragActorT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICloseDragActor>);
			}
			return ICloseDragActor.CreateICloseDragActor(builder, _o.Type, _o.TargetEntityId);
		}

		// Token: 0x04010A05 RID: 68101
		private Table __p;
	}
}
