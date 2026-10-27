using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004C85 RID: 19589
	public struct IPlayerAttributeType : IFlatbufferObject
	{
		// Token: 0x17008E43 RID: 36419
		// (get) Token: 0x0601F11D RID: 127261 RVA: 0x00457A44 File Offset: 0x00455C44
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601F11E RID: 127262 RVA: 0x00457A51 File Offset: 0x00455C51
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601F11F RID: 127263 RVA: 0x00457A58 File Offset: 0x00455C58
		public static IPlayerAttributeType GetRootAsIPlayerAttributeType(ByteBuffer _bb)
		{
			return IPlayerAttributeType.GetRootAsIPlayerAttributeType(_bb, default(IPlayerAttributeType));
		}

		// Token: 0x0601F120 RID: 127264 RVA: 0x00457A74 File Offset: 0x00455C74
		public static IPlayerAttributeType GetRootAsIPlayerAttributeType(ByteBuffer _bb, IPlayerAttributeType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601F121 RID: 127265 RVA: 0x00457A91 File Offset: 0x00455C91
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601F122 RID: 127266 RVA: 0x00457AA0 File Offset: 0x00455CA0
		public IPlayerAttributeType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008E44 RID: 36420
		// (get) Token: 0x0601F123 RID: 127267 RVA: 0x00457AB0 File Offset: 0x00455CB0
		public EPlayerAttributeType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EPlayerAttributeType.Health;
				}
				return (EPlayerAttributeType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601F124 RID: 127268 RVA: 0x00457AEC File Offset: 0x00455CEC
		public static Offset<IPlayerAttributeType> CreateIPlayerAttributeType(FlatBufferBuilder builder, EPlayerAttributeType Type = EPlayerAttributeType.Health)
		{
			builder.StartTable(1);
			IPlayerAttributeType.AddType(builder, Type);
			return IPlayerAttributeType.EndIPlayerAttributeType(builder);
		}

		// Token: 0x0601F125 RID: 127269 RVA: 0x00457B02 File Offset: 0x00455D02
		public static void StartIPlayerAttributeType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601F126 RID: 127270 RVA: 0x00457B0B File Offset: 0x00455D0B
		public static void AddType(FlatBufferBuilder builder, EPlayerAttributeType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601F127 RID: 127271 RVA: 0x00457B16 File Offset: 0x00455D16
		public static Offset<IPlayerAttributeType> EndIPlayerAttributeType(FlatBufferBuilder builder)
		{
			return new Offset<IPlayerAttributeType>(builder.EndTable());
		}

		// Token: 0x0601F128 RID: 127272 RVA: 0x00457B24 File Offset: 0x00455D24
		public IPlayerAttributeTypeT UnPack()
		{
			IPlayerAttributeTypeT playerAttributeTypeT = new IPlayerAttributeTypeT();
			this.UnPackTo(playerAttributeTypeT);
			return playerAttributeTypeT;
		}

		// Token: 0x0601F129 RID: 127273 RVA: 0x00457B3F File Offset: 0x00455D3F
		public void UnPackTo(IPlayerAttributeTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601F12A RID: 127274 RVA: 0x00457B50 File Offset: 0x00455D50
		public static Offset<IPlayerAttributeType> Pack(FlatBufferBuilder builder, IPlayerAttributeTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPlayerAttributeType>);
			}
			return IPlayerAttributeType.CreateIPlayerAttributeType(builder, _o.Type);
		}

		// Token: 0x0400D63C RID: 54844
		private Table __p;
	}
}
