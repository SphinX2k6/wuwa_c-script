using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A92 RID: 23186
	public struct ILockConfig : IFlatbufferObject
	{
		// Token: 0x1700A8FA RID: 43258
		// (get) Token: 0x06026015 RID: 155669 RVA: 0x005359C7 File Offset: 0x00533BC7
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06026016 RID: 155670 RVA: 0x005359D4 File Offset: 0x00533BD4
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06026017 RID: 155671 RVA: 0x005359DC File Offset: 0x00533BDC
		public static ILockConfig GetRootAsILockConfig(ByteBuffer _bb)
		{
			return ILockConfig.GetRootAsILockConfig(_bb, default(ILockConfig));
		}

		// Token: 0x06026018 RID: 155672 RVA: 0x005359F8 File Offset: 0x00533BF8
		public static ILockConfig GetRootAsILockConfig(ByteBuffer _bb, ILockConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06026019 RID: 155673 RVA: 0x00535A15 File Offset: 0x00533C15
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602601A RID: 155674 RVA: 0x00535A24 File Offset: 0x00533C24
		public ILockConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A8FB RID: 43259
		// (get) Token: 0x0602601B RID: 155675 RVA: 0x00535A34 File Offset: 0x00533C34
		public bool IsInitLock
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A8FC RID: 43260
		// (get) Token: 0x0602601C RID: 155676 RVA: 0x00535A74 File Offset: 0x00533C74
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

		// Token: 0x1700A8FD RID: 43261
		// (get) Token: 0x0602601D RID: 155677 RVA: 0x00535AB0 File Offset: 0x00533CB0
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

		// Token: 0x0602601E RID: 155678 RVA: 0x00535AEC File Offset: 0x00533CEC
		public static Offset<ILockConfig> CreateILockConfig(FlatBufferBuilder builder, bool IsInitLock = false, ELockType LockType = ELockType.Default, byte NullMask = 0)
		{
			builder.StartTable(3);
			ILockConfig.AddNullMask(builder, NullMask);
			ILockConfig.AddLockType(builder, LockType);
			ILockConfig.AddIsInitLock(builder, IsInitLock);
			return ILockConfig.EndILockConfig(builder);
		}

		// Token: 0x0602601F RID: 155679 RVA: 0x00535B10 File Offset: 0x00533D10
		public static void StartILockConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06026020 RID: 155680 RVA: 0x00535B19 File Offset: 0x00533D19
		public static void AddIsInitLock(FlatBufferBuilder builder, bool isInitLock)
		{
			builder.AddBool(0, isInitLock, false);
		}

		// Token: 0x06026021 RID: 155681 RVA: 0x00535B24 File Offset: 0x00533D24
		public static void AddLockType(FlatBufferBuilder builder, ELockType lockType)
		{
			builder.AddByte(1, (byte)lockType, 0);
		}

		// Token: 0x06026022 RID: 155682 RVA: 0x00535B2F File Offset: 0x00533D2F
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x06026023 RID: 155683 RVA: 0x00535B3A File Offset: 0x00533D3A
		public static Offset<ILockConfig> EndILockConfig(FlatBufferBuilder builder)
		{
			return new Offset<ILockConfig>(builder.EndTable());
		}

		// Token: 0x06026024 RID: 155684 RVA: 0x00535B48 File Offset: 0x00533D48
		public ILockConfigT UnPack()
		{
			ILockConfigT lockConfigT = new ILockConfigT();
			this.UnPackTo(lockConfigT);
			return lockConfigT;
		}

		// Token: 0x06026025 RID: 155685 RVA: 0x00535B63 File Offset: 0x00533D63
		public void UnPackTo(ILockConfigT _o)
		{
			_o.IsInitLock = this.IsInitLock;
			_o.LockType = this.LockType;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06026026 RID: 155686 RVA: 0x00535B8C File Offset: 0x00533D8C
		public static Offset<ILockConfig> Pack(FlatBufferBuilder builder, ILockConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILockConfig>);
			}
			return ILockConfig.CreateILockConfig(builder, _o.IsInitLock, _o.LockType, _o.NullMask);
		}

		// Token: 0x0400F42E RID: 62510
		private Table __p;
	}
}
