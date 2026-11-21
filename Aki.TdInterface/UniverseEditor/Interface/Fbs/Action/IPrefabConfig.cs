using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007501 RID: 29953
	public struct IPrefabConfig : IFlatbufferObject
	{
		// Token: 0x1700DC77 RID: 56439
		// (get) Token: 0x0603486C RID: 215148 RVA: 0x0071215C File Offset: 0x0071035C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603486D RID: 215149 RVA: 0x00712169 File Offset: 0x00710369
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603486E RID: 215150 RVA: 0x00712170 File Offset: 0x00710370
		public static IPrefabConfig GetRootAsIPrefabConfig(ByteBuffer _bb)
		{
			return IPrefabConfig.GetRootAsIPrefabConfig(_bb, default(IPrefabConfig));
		}

		// Token: 0x0603486F RID: 215151 RVA: 0x0071218C File Offset: 0x0071038C
		public static IPrefabConfig GetRootAsIPrefabConfig(ByteBuffer _bb, IPrefabConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06034870 RID: 215152 RVA: 0x007121A9 File Offset: 0x007103A9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06034871 RID: 215153 RVA: 0x007121B8 File Offset: 0x007103B8
		public IPrefabConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DC78 RID: 56440
		// (get) Token: 0x06034872 RID: 215154 RVA: 0x007121C8 File Offset: 0x007103C8
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

		// Token: 0x1700DC79 RID: 56441
		// (get) Token: 0x06034873 RID: 215155 RVA: 0x00712204 File Offset: 0x00710404
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

		// Token: 0x06034874 RID: 215156 RVA: 0x00712240 File Offset: 0x00710440
		public static Offset<IPrefabConfig> CreateIPrefabConfig(FlatBufferBuilder builder, ECreatePrefabType Type = ECreatePrefabType.PrefabId, int PrefabId = 0)
		{
			builder.StartTable(2);
			IPrefabConfig.AddPrefabId(builder, PrefabId);
			IPrefabConfig.AddType(builder, Type);
			return IPrefabConfig.EndIPrefabConfig(builder);
		}

		// Token: 0x06034875 RID: 215157 RVA: 0x0071225D File Offset: 0x0071045D
		public static void StartIPrefabConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06034876 RID: 215158 RVA: 0x00712266 File Offset: 0x00710466
		public static void AddType(FlatBufferBuilder builder, ECreatePrefabType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06034877 RID: 215159 RVA: 0x00712271 File Offset: 0x00710471
		public static void AddPrefabId(FlatBufferBuilder builder, int prefabId)
		{
			builder.AddInt(1, prefabId, 0);
		}

		// Token: 0x06034878 RID: 215160 RVA: 0x0071227C File Offset: 0x0071047C
		public static Offset<IPrefabConfig> EndIPrefabConfig(FlatBufferBuilder builder)
		{
			return new Offset<IPrefabConfig>(builder.EndTable());
		}

		// Token: 0x06034879 RID: 215161 RVA: 0x0071228C File Offset: 0x0071048C
		public IPrefabConfigT UnPack()
		{
			IPrefabConfigT prefabConfigT = new IPrefabConfigT();
			this.UnPackTo(prefabConfigT);
			return prefabConfigT;
		}

		// Token: 0x0603487A RID: 215162 RVA: 0x007122A7 File Offset: 0x007104A7
		public void UnPackTo(IPrefabConfigT _o)
		{
			_o.Type = this.Type;
			_o.PrefabId = this.PrefabId;
		}

		// Token: 0x0603487B RID: 215163 RVA: 0x007122C4 File Offset: 0x007104C4
		public static Offset<IPrefabConfig> Pack(FlatBufferBuilder builder, IPrefabConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPrefabConfig>);
			}
			return IPrefabConfig.CreateIPrefabConfig(builder, _o.Type, _o.PrefabId);
		}

		// Token: 0x040126D0 RID: 75472
		private Table __p;
	}
}
