using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020073AF RID: 29615
	public struct ITeleportTransitionWithCustomLoading : IFlatbufferObject
	{
		// Token: 0x1700E0CE RID: 57550
		// (get) Token: 0x06035C31 RID: 220209 RVA: 0x00751576 File Offset: 0x0074F776
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06035C32 RID: 220210 RVA: 0x00751583 File Offset: 0x0074F783
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06035C33 RID: 220211 RVA: 0x0075158C File Offset: 0x0074F78C
		public static ITeleportTransitionWithCustomLoading GetRootAsITeleportTransitionWithCustomLoading(ByteBuffer _bb)
		{
			return ITeleportTransitionWithCustomLoading.GetRootAsITeleportTransitionWithCustomLoading(_bb, default(ITeleportTransitionWithCustomLoading));
		}

		// Token: 0x06035C34 RID: 220212 RVA: 0x007515A8 File Offset: 0x0074F7A8
		public static ITeleportTransitionWithCustomLoading GetRootAsITeleportTransitionWithCustomLoading(ByteBuffer _bb, ITeleportTransitionWithCustomLoading obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06035C35 RID: 220213 RVA: 0x007515C5 File Offset: 0x0074F7C5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06035C36 RID: 220214 RVA: 0x007515D4 File Offset: 0x0074F7D4
		public ITeleportTransitionWithCustomLoading __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E0CF RID: 57551
		// (get) Token: 0x06035C37 RID: 220215 RVA: 0x007515E4 File Offset: 0x0074F7E4
		public ETeleportTransitionType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETeleportTransitionType.PlayMp4;
				}
				return (ETeleportTransitionType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700E0D0 RID: 57552
		// (get) Token: 0x06035C38 RID: 220216 RVA: 0x00751620 File Offset: 0x0074F820
		public int ConfigId
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

		// Token: 0x06035C39 RID: 220217 RVA: 0x0075165C File Offset: 0x0074F85C
		public static Offset<ITeleportTransitionWithCustomLoading> CreateITeleportTransitionWithCustomLoading(FlatBufferBuilder builder, ETeleportTransitionType Type = ETeleportTransitionType.PlayMp4, int ConfigId = 0)
		{
			builder.StartTable(2);
			ITeleportTransitionWithCustomLoading.AddConfigId(builder, ConfigId);
			ITeleportTransitionWithCustomLoading.AddType(builder, Type);
			return ITeleportTransitionWithCustomLoading.EndITeleportTransitionWithCustomLoading(builder);
		}

		// Token: 0x06035C3A RID: 220218 RVA: 0x00751679 File Offset: 0x0074F879
		public static void StartITeleportTransitionWithCustomLoading(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06035C3B RID: 220219 RVA: 0x00751682 File Offset: 0x0074F882
		public static void AddType(FlatBufferBuilder builder, ETeleportTransitionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06035C3C RID: 220220 RVA: 0x0075168D File Offset: 0x0074F88D
		public static void AddConfigId(FlatBufferBuilder builder, int configId)
		{
			builder.AddInt(1, configId, 0);
		}

		// Token: 0x06035C3D RID: 220221 RVA: 0x00751698 File Offset: 0x0074F898
		public static Offset<ITeleportTransitionWithCustomLoading> EndITeleportTransitionWithCustomLoading(FlatBufferBuilder builder)
		{
			return new Offset<ITeleportTransitionWithCustomLoading>(builder.EndTable());
		}

		// Token: 0x06035C3E RID: 220222 RVA: 0x007516A8 File Offset: 0x0074F8A8
		public ITeleportTransitionWithCustomLoadingT UnPack()
		{
			ITeleportTransitionWithCustomLoadingT teleportTransitionWithCustomLoadingT = new ITeleportTransitionWithCustomLoadingT();
			this.UnPackTo(teleportTransitionWithCustomLoadingT);
			return teleportTransitionWithCustomLoadingT;
		}

		// Token: 0x06035C3F RID: 220223 RVA: 0x007516C3 File Offset: 0x0074F8C3
		public void UnPackTo(ITeleportTransitionWithCustomLoadingT _o)
		{
			_o.Type = this.Type;
			_o.ConfigId = this.ConfigId;
		}

		// Token: 0x06035C40 RID: 220224 RVA: 0x007516E0 File Offset: 0x0074F8E0
		public static Offset<ITeleportTransitionWithCustomLoading> Pack(FlatBufferBuilder builder, ITeleportTransitionWithCustomLoadingT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITeleportTransitionWithCustomLoading>);
			}
			return ITeleportTransitionWithCustomLoading.CreateITeleportTransitionWithCustomLoading(builder, _o.Type, _o.ConfigId);
		}

		// Token: 0x040121E3 RID: 74211
		private Table __p;
	}
}
