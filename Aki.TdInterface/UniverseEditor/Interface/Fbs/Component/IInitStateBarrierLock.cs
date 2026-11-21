using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020059A2 RID: 22946
	public struct IInitStateBarrierLock : IFlatbufferObject
	{
		// Token: 0x1700A69E RID: 42654
		// (get) Token: 0x06025687 RID: 153223 RVA: 0x00521DD5 File Offset: 0x0051FFD5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06025688 RID: 153224 RVA: 0x00521DE2 File Offset: 0x0051FFE2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06025689 RID: 153225 RVA: 0x00521DEC File Offset: 0x0051FFEC
		public static IInitStateBarrierLock GetRootAsIInitStateBarrierLock(ByteBuffer _bb)
		{
			return IInitStateBarrierLock.GetRootAsIInitStateBarrierLock(_bb, default(IInitStateBarrierLock));
		}

		// Token: 0x0602568A RID: 153226 RVA: 0x00521E08 File Offset: 0x00520008
		public static IInitStateBarrierLock GetRootAsIInitStateBarrierLock(ByteBuffer _bb, IInitStateBarrierLock obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602568B RID: 153227 RVA: 0x00521E25 File Offset: 0x00520025
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602568C RID: 153228 RVA: 0x00521E34 File Offset: 0x00520034
		public IInitStateBarrierLock __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A69F RID: 42655
		// (get) Token: 0x0602568D RID: 153229 RVA: 0x00521E44 File Offset: 0x00520044
		public EInitStateType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EInitStateType.Birth;
				}
				return (EInitStateType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602568E RID: 153230 RVA: 0x00521E80 File Offset: 0x00520080
		public static Offset<IInitStateBarrierLock> CreateIInitStateBarrierLock(FlatBufferBuilder builder, EInitStateType Type = EInitStateType.Birth)
		{
			builder.StartTable(1);
			IInitStateBarrierLock.AddType(builder, Type);
			return IInitStateBarrierLock.EndIInitStateBarrierLock(builder);
		}

		// Token: 0x0602568F RID: 153231 RVA: 0x00521E96 File Offset: 0x00520096
		public static void StartIInitStateBarrierLock(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06025690 RID: 153232 RVA: 0x00521E9F File Offset: 0x0052009F
		public static void AddType(FlatBufferBuilder builder, EInitStateType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06025691 RID: 153233 RVA: 0x00521EAA File Offset: 0x005200AA
		public static Offset<IInitStateBarrierLock> EndIInitStateBarrierLock(FlatBufferBuilder builder)
		{
			return new Offset<IInitStateBarrierLock>(builder.EndTable());
		}

		// Token: 0x06025692 RID: 153234 RVA: 0x00521EB8 File Offset: 0x005200B8
		public IInitStateBarrierLockT UnPack()
		{
			IInitStateBarrierLockT initStateBarrierLockT = new IInitStateBarrierLockT();
			this.UnPackTo(initStateBarrierLockT);
			return initStateBarrierLockT;
		}

		// Token: 0x06025693 RID: 153235 RVA: 0x00521ED3 File Offset: 0x005200D3
		public void UnPackTo(IInitStateBarrierLockT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06025694 RID: 153236 RVA: 0x00521EE4 File Offset: 0x005200E4
		public static Offset<IInitStateBarrierLock> Pack(FlatBufferBuilder builder, IInitStateBarrierLockT _o)
		{
			if (_o == null)
			{
				return default(Offset<IInitStateBarrierLock>);
			}
			return IInitStateBarrierLock.CreateIInitStateBarrierLock(builder, _o.Type);
		}

		// Token: 0x0400F298 RID: 62104
		private Table __p;
	}
}
