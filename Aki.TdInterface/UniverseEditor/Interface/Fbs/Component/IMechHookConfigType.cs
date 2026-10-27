using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005542 RID: 21826
	public struct IMechHookConfigType : IFlatbufferObject
	{
		// Token: 0x1700A128 RID: 41256
		// (get) Token: 0x06024123 RID: 147747 RVA: 0x004FBCD1 File Offset: 0x004F9ED1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06024124 RID: 147748 RVA: 0x004FBCDE File Offset: 0x004F9EDE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06024125 RID: 147749 RVA: 0x004FBCE8 File Offset: 0x004F9EE8
		public static IMechHookConfigType GetRootAsIMechHookConfigType(ByteBuffer _bb)
		{
			return IMechHookConfigType.GetRootAsIMechHookConfigType(_bb, default(IMechHookConfigType));
		}

		// Token: 0x06024126 RID: 147750 RVA: 0x004FBD04 File Offset: 0x004F9F04
		public static IMechHookConfigType GetRootAsIMechHookConfigType(ByteBuffer _bb, IMechHookConfigType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06024127 RID: 147751 RVA: 0x004FBD21 File Offset: 0x004F9F21
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06024128 RID: 147752 RVA: 0x004FBD30 File Offset: 0x004F9F30
		public IMechHookConfigType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A129 RID: 41257
		// (get) Token: 0x06024129 RID: 147753 RVA: 0x004FBD40 File Offset: 0x004F9F40
		public EMechHookConfigType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EMechHookConfigType.BurrowHook;
				}
				return (EMechHookConfigType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602412A RID: 147754 RVA: 0x004FBD7C File Offset: 0x004F9F7C
		public static Offset<IMechHookConfigType> CreateIMechHookConfigType(FlatBufferBuilder builder, EMechHookConfigType Type = EMechHookConfigType.BurrowHook)
		{
			builder.StartTable(1);
			IMechHookConfigType.AddType(builder, Type);
			return IMechHookConfigType.EndIMechHookConfigType(builder);
		}

		// Token: 0x0602412B RID: 147755 RVA: 0x004FBD92 File Offset: 0x004F9F92
		public static void StartIMechHookConfigType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602412C RID: 147756 RVA: 0x004FBD9B File Offset: 0x004F9F9B
		public static void AddType(FlatBufferBuilder builder, EMechHookConfigType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602412D RID: 147757 RVA: 0x004FBDA6 File Offset: 0x004F9FA6
		public static Offset<IMechHookConfigType> EndIMechHookConfigType(FlatBufferBuilder builder)
		{
			return new Offset<IMechHookConfigType>(builder.EndTable());
		}

		// Token: 0x0602412E RID: 147758 RVA: 0x004FBDB4 File Offset: 0x004F9FB4
		public IMechHookConfigTypeT UnPack()
		{
			IMechHookConfigTypeT mechHookConfigTypeT = new IMechHookConfigTypeT();
			this.UnPackTo(mechHookConfigTypeT);
			return mechHookConfigTypeT;
		}

		// Token: 0x0602412F RID: 147759 RVA: 0x004FBDCF File Offset: 0x004F9FCF
		public void UnPackTo(IMechHookConfigTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06024130 RID: 147760 RVA: 0x004FBDE0 File Offset: 0x004F9FE0
		public static Offset<IMechHookConfigType> Pack(FlatBufferBuilder builder, IMechHookConfigTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMechHookConfigType>);
			}
			return IMechHookConfigType.CreateIMechHookConfigType(builder, _o.Type);
		}

		// Token: 0x0400E845 RID: 59461
		private Table __p;
	}
}
