using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006349 RID: 25417
	public struct ICharacterLookAtPlayerData : IFlatbufferObject
	{
		// Token: 0x1700BDA5 RID: 48549
		// (get) Token: 0x0602BF6E RID: 180078 RVA: 0x0060AC62 File Offset: 0x00608E62
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602BF6F RID: 180079 RVA: 0x0060AC6F File Offset: 0x00608E6F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602BF70 RID: 180080 RVA: 0x0060AC78 File Offset: 0x00608E78
		public static ICharacterLookAtPlayerData GetRootAsICharacterLookAtPlayerData(ByteBuffer _bb)
		{
			return ICharacterLookAtPlayerData.GetRootAsICharacterLookAtPlayerData(_bb, default(ICharacterLookAtPlayerData));
		}

		// Token: 0x0602BF71 RID: 180081 RVA: 0x0060AC94 File Offset: 0x00608E94
		public static ICharacterLookAtPlayerData GetRootAsICharacterLookAtPlayerData(ByteBuffer _bb, ICharacterLookAtPlayerData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602BF72 RID: 180082 RVA: 0x0060ACB1 File Offset: 0x00608EB1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602BF73 RID: 180083 RVA: 0x0060ACC0 File Offset: 0x00608EC0
		public ICharacterLookAtPlayerData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BDA6 RID: 48550
		// (get) Token: 0x0602BF74 RID: 180084 RVA: 0x0060ACD0 File Offset: 0x00608ED0
		public ECharacterLookAt Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECharacterLookAt.Empty;
				}
				return (ECharacterLookAt)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602BF75 RID: 180085 RVA: 0x0060AD0C File Offset: 0x00608F0C
		public static Offset<ICharacterLookAtPlayerData> CreateICharacterLookAtPlayerData(FlatBufferBuilder builder, ECharacterLookAt Type = ECharacterLookAt.Empty)
		{
			builder.StartTable(1);
			ICharacterLookAtPlayerData.AddType(builder, Type);
			return ICharacterLookAtPlayerData.EndICharacterLookAtPlayerData(builder);
		}

		// Token: 0x0602BF76 RID: 180086 RVA: 0x0060AD22 File Offset: 0x00608F22
		public static void StartICharacterLookAtPlayerData(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602BF77 RID: 180087 RVA: 0x0060AD2B File Offset: 0x00608F2B
		public static void AddType(FlatBufferBuilder builder, ECharacterLookAt type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602BF78 RID: 180088 RVA: 0x0060AD36 File Offset: 0x00608F36
		public static Offset<ICharacterLookAtPlayerData> EndICharacterLookAtPlayerData(FlatBufferBuilder builder)
		{
			return new Offset<ICharacterLookAtPlayerData>(builder.EndTable());
		}

		// Token: 0x0602BF79 RID: 180089 RVA: 0x0060AD44 File Offset: 0x00608F44
		public ICharacterLookAtPlayerDataT UnPack()
		{
			ICharacterLookAtPlayerDataT characterLookAtPlayerDataT = new ICharacterLookAtPlayerDataT();
			this.UnPackTo(characterLookAtPlayerDataT);
			return characterLookAtPlayerDataT;
		}

		// Token: 0x0602BF7A RID: 180090 RVA: 0x0060AD5F File Offset: 0x00608F5F
		public void UnPackTo(ICharacterLookAtPlayerDataT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602BF7B RID: 180091 RVA: 0x0060AD70 File Offset: 0x00608F70
		public static Offset<ICharacterLookAtPlayerData> Pack(FlatBufferBuilder builder, ICharacterLookAtPlayerDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICharacterLookAtPlayerData>);
			}
			return ICharacterLookAtPlayerData.CreateICharacterLookAtPlayerData(builder, _o.Type);
		}

		// Token: 0x04010915 RID: 67861
		private Table __p;
	}
}
