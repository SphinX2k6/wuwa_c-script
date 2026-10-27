using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020071FF RID: 29183
	public struct ISubScreen : IFlatbufferObject
	{
		// Token: 0x1700D8AA RID: 55466
		// (get) Token: 0x06033C24 RID: 212004 RVA: 0x006F77ED File Offset: 0x006F59ED
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06033C25 RID: 212005 RVA: 0x006F77FA File Offset: 0x006F59FA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06033C26 RID: 212006 RVA: 0x006F7804 File Offset: 0x006F5A04
		public static ISubScreen GetRootAsISubScreen(ByteBuffer _bb)
		{
			return ISubScreen.GetRootAsISubScreen(_bb, default(ISubScreen));
		}

		// Token: 0x06033C27 RID: 212007 RVA: 0x006F7820 File Offset: 0x006F5A20
		public static ISubScreen GetRootAsISubScreen(ByteBuffer _bb, ISubScreen obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06033C28 RID: 212008 RVA: 0x006F783D File Offset: 0x006F5A3D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06033C29 RID: 212009 RVA: 0x006F784C File Offset: 0x006F5A4C
		public ISubScreen __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D8AB RID: 55467
		// (get) Token: 0x06033C2A RID: 212010 RVA: 0x006F785C File Offset: 0x006F5A5C
		public EScreenType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EScreenType.Main;
				}
				return (EScreenType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D8AC RID: 55468
		// (get) Token: 0x06033C2B RID: 212011 RVA: 0x006F7898 File Offset: 0x006F5A98
		public string SubScreenKey
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06033C2C RID: 212012 RVA: 0x006F78CF File Offset: 0x006F5ACF
		public Span<byte> GetSubScreenKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06033C2D RID: 212013 RVA: 0x006F78DE File Offset: 0x006F5ADE
		public byte[] GetSubScreenKeyArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x06033C2E RID: 212014 RVA: 0x006F78EC File Offset: 0x006F5AEC
		public static Offset<ISubScreen> CreateISubScreen(FlatBufferBuilder builder, EScreenType Type = EScreenType.Main, StringOffset SubScreenKeyOffset = default(StringOffset))
		{
			builder.StartTable(2);
			ISubScreen.AddSubScreenKey(builder, SubScreenKeyOffset);
			ISubScreen.AddType(builder, Type);
			return ISubScreen.EndISubScreen(builder);
		}

		// Token: 0x06033C2F RID: 212015 RVA: 0x006F7909 File Offset: 0x006F5B09
		public static void StartISubScreen(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06033C30 RID: 212016 RVA: 0x006F7912 File Offset: 0x006F5B12
		public static void AddType(FlatBufferBuilder builder, EScreenType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06033C31 RID: 212017 RVA: 0x006F791D File Offset: 0x006F5B1D
		public static void AddSubScreenKey(FlatBufferBuilder builder, StringOffset subScreenKeyOffset)
		{
			builder.AddOffset(1, subScreenKeyOffset.Value, 0);
		}

		// Token: 0x06033C32 RID: 212018 RVA: 0x006F792D File Offset: 0x006F5B2D
		public static Offset<ISubScreen> EndISubScreen(FlatBufferBuilder builder)
		{
			return new Offset<ISubScreen>(builder.EndTable());
		}

		// Token: 0x06033C33 RID: 212019 RVA: 0x006F793C File Offset: 0x006F5B3C
		public ISubScreenT UnPack()
		{
			ISubScreenT subScreenT = new ISubScreenT();
			this.UnPackTo(subScreenT);
			return subScreenT;
		}

		// Token: 0x06033C34 RID: 212020 RVA: 0x006F7957 File Offset: 0x006F5B57
		public void UnPackTo(ISubScreenT _o)
		{
			_o.Type = this.Type;
			_o.SubScreenKey = this.SubScreenKey;
		}

		// Token: 0x06033C35 RID: 212021 RVA: 0x006F7974 File Offset: 0x006F5B74
		public static Offset<ISubScreen> Pack(FlatBufferBuilder builder, ISubScreenT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISubScreen>);
			}
			StringOffset subScreenKeyOffset = (_o.SubScreenKey == null) ? default(StringOffset) : builder.CreateString(_o.SubScreenKey);
			return ISubScreen.CreateISubScreen(builder, _o.Type, subScreenKeyOffset);
		}

		// Token: 0x04011CE3 RID: 72931
		private Table __p;
	}
}
