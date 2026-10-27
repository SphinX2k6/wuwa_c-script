using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200543D RID: 21565
	public struct IInteractCameraOffsetConfig : IFlatbufferObject
	{
		// Token: 0x17009E97 RID: 40599
		// (get) Token: 0x060236D7 RID: 145111 RVA: 0x004E6A1C File Offset: 0x004E4C1C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060236D8 RID: 145112 RVA: 0x004E6A29 File Offset: 0x004E4C29
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060236D9 RID: 145113 RVA: 0x004E6A30 File Offset: 0x004E4C30
		public static IInteractCameraOffsetConfig GetRootAsIInteractCameraOffsetConfig(ByteBuffer _bb)
		{
			return IInteractCameraOffsetConfig.GetRootAsIInteractCameraOffsetConfig(_bb, default(IInteractCameraOffsetConfig));
		}

		// Token: 0x060236DA RID: 145114 RVA: 0x004E6A4C File Offset: 0x004E4C4C
		public static IInteractCameraOffsetConfig GetRootAsIInteractCameraOffsetConfig(ByteBuffer _bb, IInteractCameraOffsetConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060236DB RID: 145115 RVA: 0x004E6A69 File Offset: 0x004E4C69
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060236DC RID: 145116 RVA: 0x004E6A78 File Offset: 0x004E4C78
		public IInteractCameraOffsetConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009E98 RID: 40600
		// (get) Token: 0x060236DD RID: 145117 RVA: 0x004E6A88 File Offset: 0x004E4C88
		public int CenterOffsetPercent
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009E99 RID: 40601
		// (get) Token: 0x060236DE RID: 145118 RVA: 0x004E6AC4 File Offset: 0x004E4CC4
		public float OffsetZ
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009E9A RID: 40602
		// (get) Token: 0x060236DF RID: 145119 RVA: 0x004E6B04 File Offset: 0x004E4D04
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

		// Token: 0x060236E0 RID: 145120 RVA: 0x004E6B40 File Offset: 0x004E4D40
		public static Offset<IInteractCameraOffsetConfig> CreateIInteractCameraOffsetConfig(FlatBufferBuilder builder, int CenterOffsetPercent = 0, float OffsetZ = 0f, byte NullMask = 0)
		{
			builder.StartTable(3);
			IInteractCameraOffsetConfig.AddOffsetZ(builder, OffsetZ);
			IInteractCameraOffsetConfig.AddCenterOffsetPercent(builder, CenterOffsetPercent);
			IInteractCameraOffsetConfig.AddNullMask(builder, NullMask);
			return IInteractCameraOffsetConfig.EndIInteractCameraOffsetConfig(builder);
		}

		// Token: 0x060236E1 RID: 145121 RVA: 0x004E6B64 File Offset: 0x004E4D64
		public static void StartIInteractCameraOffsetConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060236E2 RID: 145122 RVA: 0x004E6B6D File Offset: 0x004E4D6D
		public static void AddCenterOffsetPercent(FlatBufferBuilder builder, int centerOffsetPercent)
		{
			builder.AddInt(0, centerOffsetPercent, 0);
		}

		// Token: 0x060236E3 RID: 145123 RVA: 0x004E6B78 File Offset: 0x004E4D78
		public static void AddOffsetZ(FlatBufferBuilder builder, float offsetZ)
		{
			builder.AddFloat(1, offsetZ, 0.0);
		}

		// Token: 0x060236E4 RID: 145124 RVA: 0x004E6B8B File Offset: 0x004E4D8B
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x060236E5 RID: 145125 RVA: 0x004E6B96 File Offset: 0x004E4D96
		public static Offset<IInteractCameraOffsetConfig> EndIInteractCameraOffsetConfig(FlatBufferBuilder builder)
		{
			return new Offset<IInteractCameraOffsetConfig>(builder.EndTable());
		}

		// Token: 0x060236E6 RID: 145126 RVA: 0x004E6BA4 File Offset: 0x004E4DA4
		public IInteractCameraOffsetConfigT UnPack()
		{
			IInteractCameraOffsetConfigT interactCameraOffsetConfigT = new IInteractCameraOffsetConfigT();
			this.UnPackTo(interactCameraOffsetConfigT);
			return interactCameraOffsetConfigT;
		}

		// Token: 0x060236E7 RID: 145127 RVA: 0x004E6BBF File Offset: 0x004E4DBF
		public void UnPackTo(IInteractCameraOffsetConfigT _o)
		{
			_o.CenterOffsetPercent = this.CenterOffsetPercent;
			_o.OffsetZ = this.OffsetZ;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060236E8 RID: 145128 RVA: 0x004E6BE8 File Offset: 0x004E4DE8
		public static Offset<IInteractCameraOffsetConfig> Pack(FlatBufferBuilder builder, IInteractCameraOffsetConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IInteractCameraOffsetConfig>);
			}
			return IInteractCameraOffsetConfig.CreateIInteractCameraOffsetConfig(builder, _o.CenterOffsetPercent, _o.OffsetZ, _o.NullMask);
		}

		// Token: 0x0400E694 RID: 59028
		private Table __p;
	}
}
