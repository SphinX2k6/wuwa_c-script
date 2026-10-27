using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200738E RID: 29582
	public struct ITeleportToLatestResetPointDirectly : IFlatbufferObject
	{
		// Token: 0x1700E092 RID: 57490
		// (get) Token: 0x06035B1F RID: 219935 RVA: 0x0074F7D7 File Offset: 0x0074D9D7
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06035B20 RID: 219936 RVA: 0x0074F7E4 File Offset: 0x0074D9E4
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06035B21 RID: 219937 RVA: 0x0074F7EC File Offset: 0x0074D9EC
		public static ITeleportToLatestResetPointDirectly GetRootAsITeleportToLatestResetPointDirectly(ByteBuffer _bb)
		{
			return ITeleportToLatestResetPointDirectly.GetRootAsITeleportToLatestResetPointDirectly(_bb, default(ITeleportToLatestResetPointDirectly));
		}

		// Token: 0x06035B22 RID: 219938 RVA: 0x0074F808 File Offset: 0x0074DA08
		public static ITeleportToLatestResetPointDirectly GetRootAsITeleportToLatestResetPointDirectly(ByteBuffer _bb, ITeleportToLatestResetPointDirectly obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06035B23 RID: 219939 RVA: 0x0074F825 File Offset: 0x0074DA25
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06035B24 RID: 219940 RVA: 0x0074F834 File Offset: 0x0074DA34
		public ITeleportToLatestResetPointDirectly __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E093 RID: 57491
		// (get) Token: 0x06035B25 RID: 219941 RVA: 0x0074F844 File Offset: 0x0074DA44
		public ETeleportToLatestResetPointType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETeleportToLatestResetPointType.Directly;
				}
				return (ETeleportToLatestResetPointType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06035B26 RID: 219942 RVA: 0x0074F880 File Offset: 0x0074DA80
		public static Offset<ITeleportToLatestResetPointDirectly> CreateITeleportToLatestResetPointDirectly(FlatBufferBuilder builder, ETeleportToLatestResetPointType Type = ETeleportToLatestResetPointType.Directly)
		{
			builder.StartTable(1);
			ITeleportToLatestResetPointDirectly.AddType(builder, Type);
			return ITeleportToLatestResetPointDirectly.EndITeleportToLatestResetPointDirectly(builder);
		}

		// Token: 0x06035B27 RID: 219943 RVA: 0x0074F896 File Offset: 0x0074DA96
		public static void StartITeleportToLatestResetPointDirectly(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06035B28 RID: 219944 RVA: 0x0074F89F File Offset: 0x0074DA9F
		public static void AddType(FlatBufferBuilder builder, ETeleportToLatestResetPointType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06035B29 RID: 219945 RVA: 0x0074F8AA File Offset: 0x0074DAAA
		public static Offset<ITeleportToLatestResetPointDirectly> EndITeleportToLatestResetPointDirectly(FlatBufferBuilder builder)
		{
			return new Offset<ITeleportToLatestResetPointDirectly>(builder.EndTable());
		}

		// Token: 0x06035B2A RID: 219946 RVA: 0x0074F8B8 File Offset: 0x0074DAB8
		public ITeleportToLatestResetPointDirectlyT UnPack()
		{
			ITeleportToLatestResetPointDirectlyT teleportToLatestResetPointDirectlyT = new ITeleportToLatestResetPointDirectlyT();
			this.UnPackTo(teleportToLatestResetPointDirectlyT);
			return teleportToLatestResetPointDirectlyT;
		}

		// Token: 0x06035B2B RID: 219947 RVA: 0x0074F8D3 File Offset: 0x0074DAD3
		public void UnPackTo(ITeleportToLatestResetPointDirectlyT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06035B2C RID: 219948 RVA: 0x0074F8E4 File Offset: 0x0074DAE4
		public static Offset<ITeleportToLatestResetPointDirectly> Pack(FlatBufferBuilder builder, ITeleportToLatestResetPointDirectlyT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITeleportToLatestResetPointDirectly>);
			}
			return ITeleportToLatestResetPointDirectly.CreateITeleportToLatestResetPointDirectly(builder, _o.Type);
		}

		// Token: 0x040121A8 RID: 74152
		private Table __p;
	}
}
