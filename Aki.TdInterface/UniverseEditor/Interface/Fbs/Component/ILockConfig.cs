using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200550C RID: 21772
	public struct ILockConfig : IFlatbufferObject
	{
		// Token: 0x1700A0C0 RID: 41152
		// (get) Token: 0x06023F5B RID: 147291 RVA: 0x004F88A3 File Offset: 0x004F6AA3
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06023F5C RID: 147292 RVA: 0x004F88B0 File Offset: 0x004F6AB0
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06023F5D RID: 147293 RVA: 0x004F88B8 File Offset: 0x004F6AB8
		public static ILockConfig GetRootAsILockConfig(ByteBuffer _bb)
		{
			return ILockConfig.GetRootAsILockConfig(_bb, default(ILockConfig));
		}

		// Token: 0x06023F5E RID: 147294 RVA: 0x004F88D4 File Offset: 0x004F6AD4
		public static ILockConfig GetRootAsILockConfig(ByteBuffer _bb, ILockConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06023F5F RID: 147295 RVA: 0x004F88F1 File Offset: 0x004F6AF1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06023F60 RID: 147296 RVA: 0x004F8900 File Offset: 0x004F6B00
		public ILockConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A0C1 RID: 41153
		// (get) Token: 0x06023F61 RID: 147297 RVA: 0x004F8910 File Offset: 0x004F6B10
		public bool IsInitLock
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A0C2 RID: 41154
		// (get) Token: 0x06023F62 RID: 147298 RVA: 0x004F8950 File Offset: 0x004F6B50
		public ELockType LockType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return ELockType.Default;
				}
				return (ELockType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A0C3 RID: 41155
		// (get) Token: 0x06023F63 RID: 147299 RVA: 0x004F898C File Offset: 0x004F6B8C
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06023F64 RID: 147300 RVA: 0x004F89C8 File Offset: 0x004F6BC8
		public static Offset<ILockConfig> CreateILockConfig(FlatBufferBuilder builder, bool IsInitLock = false, ELockType LockType = ELockType.Default, byte NullMask = 0)
		{
			builder.StartTable(3);
			ILockConfig.AddNullMask(builder, NullMask);
			ILockConfig.AddLockType(builder, LockType);
			ILockConfig.AddIsInitLock(builder, IsInitLock);
			return ILockConfig.EndILockConfig(builder);
		}

		// Token: 0x06023F65 RID: 147301 RVA: 0x004F89EC File Offset: 0x004F6BEC
		public static void StartILockConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06023F66 RID: 147302 RVA: 0x004F89F5 File Offset: 0x004F6BF5
		public static void AddIsInitLock(FlatBufferBuilder builder, bool isInitLock)
		{
			builder.AddBool(0, isInitLock, false);
		}

		// Token: 0x06023F67 RID: 147303 RVA: 0x004F8A00 File Offset: 0x004F6C00
		public static void AddLockType(FlatBufferBuilder builder, ELockType lockType)
		{
			builder.AddByte(1, (byte)lockType, 0);
		}

		// Token: 0x06023F68 RID: 147304 RVA: 0x004F8A0B File Offset: 0x004F6C0B
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x06023F69 RID: 147305 RVA: 0x004F8A16 File Offset: 0x004F6C16
		public static Offset<ILockConfig> EndILockConfig(FlatBufferBuilder builder)
		{
			return new Offset<ILockConfig>(builder.EndTable());
		}

		// Token: 0x06023F6A RID: 147306 RVA: 0x004F8A24 File Offset: 0x004F6C24
		public ILockConfigT UnPack()
		{
			ILockConfigT lockConfigT = new ILockConfigT();
			this.UnPackTo(lockConfigT);
			return lockConfigT;
		}

		// Token: 0x06023F6B RID: 147307 RVA: 0x004F8A3F File Offset: 0x004F6C3F
		public void UnPackTo(ILockConfigT _o)
		{
			_o.IsInitLock = this.IsInitLock;
			_o.LockType = this.LockType;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06023F6C RID: 147308 RVA: 0x004F8A68 File Offset: 0x004F6C68
		public static Offset<ILockConfig> Pack(FlatBufferBuilder builder, ILockConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILockConfig>);
			}
			return ILockConfig.CreateILockConfig(builder, _o.IsInitLock, _o.LockType, _o.NullMask);
		}

		// Token: 0x0400E7FD RID: 59389
		private Table __p;
	}
}
