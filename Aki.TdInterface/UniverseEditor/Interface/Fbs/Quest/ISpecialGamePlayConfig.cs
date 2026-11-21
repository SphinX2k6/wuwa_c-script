using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004577 RID: 17783
	public struct ISpecialGamePlayConfig : IFlatbufferObject
	{
		// Token: 0x17007C47 RID: 31815
		// (get) Token: 0x06019E61 RID: 106081 RVA: 0x003B1A5D File Offset: 0x003AFC5D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06019E62 RID: 106082 RVA: 0x003B1A6A File Offset: 0x003AFC6A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06019E63 RID: 106083 RVA: 0x003B1A74 File Offset: 0x003AFC74
		public static ISpecialGamePlayConfig GetRootAsISpecialGamePlayConfig(ByteBuffer _bb)
		{
			return ISpecialGamePlayConfig.GetRootAsISpecialGamePlayConfig(_bb, default(ISpecialGamePlayConfig));
		}

		// Token: 0x06019E64 RID: 106084 RVA: 0x003B1A90 File Offset: 0x003AFC90
		public static ISpecialGamePlayConfig GetRootAsISpecialGamePlayConfig(ByteBuffer _bb, ISpecialGamePlayConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06019E65 RID: 106085 RVA: 0x003B1AAD File Offset: 0x003AFCAD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06019E66 RID: 106086 RVA: 0x003B1ABC File Offset: 0x003AFCBC
		public ISpecialGamePlayConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007C48 RID: 31816
		// (get) Token: 0x06019E67 RID: 106087 RVA: 0x003B1ACC File Offset: 0x003AFCCC
		public ESpecialGamePlayConfigType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESpecialGamePlayConfigType.Stalking;
				}
				return (ESpecialGamePlayConfigType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06019E68 RID: 106088 RVA: 0x003B1B08 File Offset: 0x003AFD08
		public static Offset<ISpecialGamePlayConfig> CreateISpecialGamePlayConfig(FlatBufferBuilder builder, ESpecialGamePlayConfigType Type = ESpecialGamePlayConfigType.Stalking)
		{
			builder.StartTable(1);
			ISpecialGamePlayConfig.AddType(builder, Type);
			return ISpecialGamePlayConfig.EndISpecialGamePlayConfig(builder);
		}

		// Token: 0x06019E69 RID: 106089 RVA: 0x003B1B1E File Offset: 0x003AFD1E
		public static void StartISpecialGamePlayConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06019E6A RID: 106090 RVA: 0x003B1B27 File Offset: 0x003AFD27
		public static void AddType(FlatBufferBuilder builder, ESpecialGamePlayConfigType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06019E6B RID: 106091 RVA: 0x003B1B32 File Offset: 0x003AFD32
		public static Offset<ISpecialGamePlayConfig> EndISpecialGamePlayConfig(FlatBufferBuilder builder)
		{
			return new Offset<ISpecialGamePlayConfig>(builder.EndTable());
		}

		// Token: 0x06019E6C RID: 106092 RVA: 0x003B1B40 File Offset: 0x003AFD40
		public ISpecialGamePlayConfigT UnPack()
		{
			ISpecialGamePlayConfigT specialGamePlayConfigT = new ISpecialGamePlayConfigT();
			this.UnPackTo(specialGamePlayConfigT);
			return specialGamePlayConfigT;
		}

		// Token: 0x06019E6D RID: 106093 RVA: 0x003B1B5B File Offset: 0x003AFD5B
		public void UnPackTo(ISpecialGamePlayConfigT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06019E6E RID: 106094 RVA: 0x003B1B6C File Offset: 0x003AFD6C
		public static Offset<ISpecialGamePlayConfig> Pack(FlatBufferBuilder builder, ISpecialGamePlayConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISpecialGamePlayConfig>);
			}
			return ISpecialGamePlayConfig.CreateISpecialGamePlayConfig(builder, _o.Type);
		}

		// Token: 0x0400C722 RID: 50978
		private Table __p;
	}
}
