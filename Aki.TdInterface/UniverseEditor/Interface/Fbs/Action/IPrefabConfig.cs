using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D86 RID: 28038
	public struct IPrefabConfig : IFlatbufferObject
	{
		// Token: 0x1700D12F RID: 53551
		// (get) Token: 0x06031870 RID: 202864 RVA: 0x006B6A74 File Offset: 0x006B4C74
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031871 RID: 202865 RVA: 0x006B6A81 File Offset: 0x006B4C81
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06031872 RID: 202866 RVA: 0x006B6A88 File Offset: 0x006B4C88
		public static IPrefabConfig GetRootAsIPrefabConfig(ByteBuffer _bb)
		{
			return IPrefabConfig.GetRootAsIPrefabConfig(_bb, default(IPrefabConfig));
		}

		// Token: 0x06031873 RID: 202867 RVA: 0x006B6AA4 File Offset: 0x006B4CA4
		public static IPrefabConfig GetRootAsIPrefabConfig(ByteBuffer _bb, IPrefabConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06031874 RID: 202868 RVA: 0x006B6AC1 File Offset: 0x006B4CC1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031875 RID: 202869 RVA: 0x006B6AD0 File Offset: 0x006B4CD0
		public IPrefabConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D130 RID: 53552
		// (get) Token: 0x06031876 RID: 202870 RVA: 0x006B6AE0 File Offset: 0x006B4CE0
		public ECreatePrefabType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECreatePrefabType.PrefabId;
				}
				return (ECreatePrefabType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D131 RID: 53553
		// (get) Token: 0x06031877 RID: 202871 RVA: 0x006B6B1C File Offset: 0x006B4D1C
		public int PrefabId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06031878 RID: 202872 RVA: 0x006B6B58 File Offset: 0x006B4D58
		public static Offset<IPrefabConfig> CreateIPrefabConfig(FlatBufferBuilder builder, ECreatePrefabType Type = ECreatePrefabType.PrefabId, int PrefabId = 0)
		{
			builder.StartTable(2);
			IPrefabConfig.AddPrefabId(builder, PrefabId);
			IPrefabConfig.AddType(builder, Type);
			return IPrefabConfig.EndIPrefabConfig(builder);
		}

		// Token: 0x06031879 RID: 202873 RVA: 0x006B6B75 File Offset: 0x006B4D75
		public static void StartIPrefabConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0603187A RID: 202874 RVA: 0x006B6B7E File Offset: 0x006B4D7E
		public static void AddType(FlatBufferBuilder builder, ECreatePrefabType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603187B RID: 202875 RVA: 0x006B6B89 File Offset: 0x006B4D89
		public static void AddPrefabId(FlatBufferBuilder builder, int prefabId)
		{
			builder.AddInt(1, prefabId, 0);
		}

		// Token: 0x0603187C RID: 202876 RVA: 0x006B6B94 File Offset: 0x006B4D94
		public static Offset<IPrefabConfig> EndIPrefabConfig(FlatBufferBuilder builder)
		{
			return new Offset<IPrefabConfig>(builder.EndTable());
		}

		// Token: 0x0603187D RID: 202877 RVA: 0x006B6BA4 File Offset: 0x006B4DA4
		public IPrefabConfigT UnPack()
		{
			IPrefabConfigT prefabConfigT = new IPrefabConfigT();
			this.UnPackTo(prefabConfigT);
			return prefabConfigT;
		}

		// Token: 0x0603187E RID: 202878 RVA: 0x006B6BBF File Offset: 0x006B4DBF
		public void UnPackTo(IPrefabConfigT _o)
		{
			_o.Type = this.Type;
			_o.PrefabId = this.PrefabId;
		}

		// Token: 0x0603187F RID: 202879 RVA: 0x006B6BDC File Offset: 0x006B4DDC
		public static Offset<IPrefabConfig> Pack(FlatBufferBuilder builder, IPrefabConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPrefabConfig>);
			}
			return IPrefabConfig.CreateIPrefabConfig(builder, _o.Type, _o.PrefabId);
		}

		// Token: 0x04011754 RID: 71508
		private Table __p;
	}
}
