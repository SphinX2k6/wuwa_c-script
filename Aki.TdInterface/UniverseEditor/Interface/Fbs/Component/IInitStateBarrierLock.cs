using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200541C RID: 21532
	public struct IInitStateBarrierLock : IFlatbufferObject
	{
		// Token: 0x17009E64 RID: 40548
		// (get) Token: 0x060235CF RID: 144847 RVA: 0x004E4DA9 File Offset: 0x004E2FA9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060235D0 RID: 144848 RVA: 0x004E4DB6 File Offset: 0x004E2FB6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060235D1 RID: 144849 RVA: 0x004E4DC0 File Offset: 0x004E2FC0
		public static IInitStateBarrierLock GetRootAsIInitStateBarrierLock(ByteBuffer _bb)
		{
			return IInitStateBarrierLock.GetRootAsIInitStateBarrierLock(_bb, default(IInitStateBarrierLock));
		}

		// Token: 0x060235D2 RID: 144850 RVA: 0x004E4DDC File Offset: 0x004E2FDC
		public static IInitStateBarrierLock GetRootAsIInitStateBarrierLock(ByteBuffer _bb, IInitStateBarrierLock obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060235D3 RID: 144851 RVA: 0x004E4DF9 File Offset: 0x004E2FF9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060235D4 RID: 144852 RVA: 0x004E4E08 File Offset: 0x004E3008
		public IInitStateBarrierLock __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009E65 RID: 40549
		// (get) Token: 0x060235D5 RID: 144853 RVA: 0x004E4E18 File Offset: 0x004E3018
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

		// Token: 0x060235D6 RID: 144854 RVA: 0x004E4E54 File Offset: 0x004E3054
		public static Offset<IInitStateBarrierLock> CreateIInitStateBarrierLock(FlatBufferBuilder builder, EInitStateType Type = EInitStateType.Birth)
		{
			builder.StartTable(1);
			IInitStateBarrierLock.AddType(builder, Type);
			return IInitStateBarrierLock.EndIInitStateBarrierLock(builder);
		}

		// Token: 0x060235D7 RID: 144855 RVA: 0x004E4E6A File Offset: 0x004E306A
		public static void StartIInitStateBarrierLock(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060235D8 RID: 144856 RVA: 0x004E4E73 File Offset: 0x004E3073
		public static void AddType(FlatBufferBuilder builder, EInitStateType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060235D9 RID: 144857 RVA: 0x004E4E7E File Offset: 0x004E307E
		public static Offset<IInitStateBarrierLock> EndIInitStateBarrierLock(FlatBufferBuilder builder)
		{
			return new Offset<IInitStateBarrierLock>(builder.EndTable());
		}

		// Token: 0x060235DA RID: 144858 RVA: 0x004E4E8C File Offset: 0x004E308C
		public IInitStateBarrierLockT UnPack()
		{
			IInitStateBarrierLockT initStateBarrierLockT = new IInitStateBarrierLockT();
			this.UnPackTo(initStateBarrierLockT);
			return initStateBarrierLockT;
		}

		// Token: 0x060235DB RID: 144859 RVA: 0x004E4EA7 File Offset: 0x004E30A7
		public void UnPackTo(IInitStateBarrierLockT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060235DC RID: 144860 RVA: 0x004E4EB8 File Offset: 0x004E30B8
		public static Offset<IInitStateBarrierLock> Pack(FlatBufferBuilder builder, IInitStateBarrierLockT _o)
		{
			if (_o == null)
			{
				return default(Offset<IInitStateBarrierLock>);
			}
			return IInitStateBarrierLock.CreateIInitStateBarrierLock(builder, _o.Type);
		}

		// Token: 0x0400E667 RID: 58983
		private Table __p;
	}
}
