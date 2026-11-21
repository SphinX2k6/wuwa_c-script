using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007B96 RID: 31638
	public struct ITeleportTransitionWithCustomLoading : IFlatbufferObject
	{
		// Token: 0x1700ECDE RID: 60638
		// (get) Token: 0x06038FCC RID: 233420 RVA: 0x007B3AB6 File Offset: 0x007B1CB6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06038FCD RID: 233421 RVA: 0x007B3AC3 File Offset: 0x007B1CC3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06038FCE RID: 233422 RVA: 0x007B3ACC File Offset: 0x007B1CCC
		public static ITeleportTransitionWithCustomLoading GetRootAsITeleportTransitionWithCustomLoading(ByteBuffer _bb)
		{
			return ITeleportTransitionWithCustomLoading.GetRootAsITeleportTransitionWithCustomLoading(_bb, default(ITeleportTransitionWithCustomLoading));
		}

		// Token: 0x06038FCF RID: 233423 RVA: 0x007B3AE8 File Offset: 0x007B1CE8
		public static ITeleportTransitionWithCustomLoading GetRootAsITeleportTransitionWithCustomLoading(ByteBuffer _bb, ITeleportTransitionWithCustomLoading obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06038FD0 RID: 233424 RVA: 0x007B3B05 File Offset: 0x007B1D05
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06038FD1 RID: 233425 RVA: 0x007B3B14 File Offset: 0x007B1D14
		public ITeleportTransitionWithCustomLoading __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700ECDF RID: 60639
		// (get) Token: 0x06038FD2 RID: 233426 RVA: 0x007B3B24 File Offset: 0x007B1D24
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

		// Token: 0x1700ECE0 RID: 60640
		// (get) Token: 0x06038FD3 RID: 233427 RVA: 0x007B3B60 File Offset: 0x007B1D60
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

		// Token: 0x06038FD4 RID: 233428 RVA: 0x007B3B9C File Offset: 0x007B1D9C
		public static Offset<ITeleportTransitionWithCustomLoading> CreateITeleportTransitionWithCustomLoading(FlatBufferBuilder builder, ETeleportTransitionType Type = ETeleportTransitionType.PlayMp4, int ConfigId = 0)
		{
			builder.StartTable(2);
			ITeleportTransitionWithCustomLoading.AddConfigId(builder, ConfigId);
			ITeleportTransitionWithCustomLoading.AddType(builder, Type);
			return ITeleportTransitionWithCustomLoading.EndITeleportTransitionWithCustomLoading(builder);
		}

		// Token: 0x06038FD5 RID: 233429 RVA: 0x007B3BB9 File Offset: 0x007B1DB9
		public static void StartITeleportTransitionWithCustomLoading(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06038FD6 RID: 233430 RVA: 0x007B3BC2 File Offset: 0x007B1DC2
		public static void AddType(FlatBufferBuilder builder, ETeleportTransitionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06038FD7 RID: 233431 RVA: 0x007B3BCD File Offset: 0x007B1DCD
		public static void AddConfigId(FlatBufferBuilder builder, int configId)
		{
			builder.AddInt(1, configId, 0);
		}

		// Token: 0x06038FD8 RID: 233432 RVA: 0x007B3BD8 File Offset: 0x007B1DD8
		public static Offset<ITeleportTransitionWithCustomLoading> EndITeleportTransitionWithCustomLoading(FlatBufferBuilder builder)
		{
			return new Offset<ITeleportTransitionWithCustomLoading>(builder.EndTable());
		}

		// Token: 0x06038FD9 RID: 233433 RVA: 0x007B3BE8 File Offset: 0x007B1DE8
		public ITeleportTransitionWithCustomLoadingT UnPack()
		{
			ITeleportTransitionWithCustomLoadingT teleportTransitionWithCustomLoadingT = new ITeleportTransitionWithCustomLoadingT();
			this.UnPackTo(teleportTransitionWithCustomLoadingT);
			return teleportTransitionWithCustomLoadingT;
		}

		// Token: 0x06038FDA RID: 233434 RVA: 0x007B3C03 File Offset: 0x007B1E03
		public void UnPackTo(ITeleportTransitionWithCustomLoadingT _o)
		{
			_o.Type = this.Type;
			_o.ConfigId = this.ConfigId;
		}

		// Token: 0x06038FDB RID: 233435 RVA: 0x007B3C20 File Offset: 0x007B1E20
		public static Offset<ITeleportTransitionWithCustomLoading> Pack(FlatBufferBuilder builder, ITeleportTransitionWithCustomLoadingT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITeleportTransitionWithCustomLoading>);
			}
			return ITeleportTransitionWithCustomLoading.CreateITeleportTransitionWithCustomLoading(builder, _o.Type, _o.ConfigId);
		}

		// Token: 0x040131FC RID: 78332
		private Table __p;
	}
}
