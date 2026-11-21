using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007600 RID: 30208
	public struct IResetEntity : IFlatbufferObject
	{
		// Token: 0x1700DE00 RID: 56832
		// (get) Token: 0x06035013 RID: 217107 RVA: 0x0071EF7F File Offset: 0x0071D17F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06035014 RID: 217108 RVA: 0x0071EF8C File Offset: 0x0071D18C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06035015 RID: 217109 RVA: 0x0071EF94 File Offset: 0x0071D194
		public static IResetEntity GetRootAsIResetEntity(ByteBuffer _bb)
		{
			return IResetEntity.GetRootAsIResetEntity(_bb, default(IResetEntity));
		}

		// Token: 0x06035016 RID: 217110 RVA: 0x0071EFB0 File Offset: 0x0071D1B0
		public static IResetEntity GetRootAsIResetEntity(ByteBuffer _bb, IResetEntity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06035017 RID: 217111 RVA: 0x0071EFCD File Offset: 0x0071D1CD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06035018 RID: 217112 RVA: 0x0071EFDC File Offset: 0x0071D1DC
		public IResetEntity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DE01 RID: 56833
		// (get) Token: 0x06035019 RID: 217113 RVA: 0x0071EFEC File Offset: 0x0071D1EC
		public TResetEntityConfig ResetEntityConfigType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return TResetEntityConfig.NONE;
				}
				return (TResetEntityConfig)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603501A RID: 217114 RVA: 0x0071F028 File Offset: 0x0071D228
		public TTable? ResetEntityConfig<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0603501B RID: 217115 RVA: 0x0071F06C File Offset: 0x0071D26C
		public IJigsawItemEntity ResetEntityConfigAsIJigsawItemEntity()
		{
			return this.ResetEntityConfig<IJigsawItemEntity>().Value;
		}

		// Token: 0x0603501C RID: 217116 RVA: 0x0071F088 File Offset: 0x0071D288
		public IResetTeleControlEntity ResetEntityConfigAsIResetTeleControlEntity()
		{
			return this.ResetEntityConfig<IResetTeleControlEntity>().Value;
		}

		// Token: 0x0603501D RID: 217117 RVA: 0x0071F0A3 File Offset: 0x0071D2A3
		public static Offset<IResetEntity> CreateIResetEntity(FlatBufferBuilder builder, TResetEntityConfig ResetEntityConfig_type = TResetEntityConfig.NONE, int ResetEntityConfigOffset = 0)
		{
			builder.StartTable(2);
			IResetEntity.AddResetEntityConfig(builder, ResetEntityConfigOffset);
			IResetEntity.AddResetEntityConfigType(builder, ResetEntityConfig_type);
			return IResetEntity.EndIResetEntity(builder);
		}

		// Token: 0x0603501E RID: 217118 RVA: 0x0071F0C0 File Offset: 0x0071D2C0
		public static void StartIResetEntity(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0603501F RID: 217119 RVA: 0x0071F0C9 File Offset: 0x0071D2C9
		public static void AddResetEntityConfigType(FlatBufferBuilder builder, TResetEntityConfig resetEntityConfigType)
		{
			builder.AddByte(0, (byte)resetEntityConfigType, 0);
		}

		// Token: 0x06035020 RID: 217120 RVA: 0x0071F0D4 File Offset: 0x0071D2D4
		public static void AddResetEntityConfig(FlatBufferBuilder builder, int resetEntityConfigOffset)
		{
			builder.AddOffset(1, resetEntityConfigOffset, 0);
		}

		// Token: 0x06035021 RID: 217121 RVA: 0x0071F0DF File Offset: 0x0071D2DF
		public static Offset<IResetEntity> EndIResetEntity(FlatBufferBuilder builder)
		{
			return new Offset<IResetEntity>(builder.EndTable());
		}

		// Token: 0x06035022 RID: 217122 RVA: 0x0071F0EC File Offset: 0x0071D2EC
		public IResetEntityT UnPack()
		{
			IResetEntityT resetEntityT = new IResetEntityT();
			this.UnPackTo(resetEntityT);
			return resetEntityT;
		}

		// Token: 0x06035023 RID: 217123 RVA: 0x0071F108 File Offset: 0x0071D308
		public void UnPackTo(IResetEntityT _o)
		{
			_o.ResetEntityConfig = new TResetEntityConfigUnion();
			_o.ResetEntityConfig.Type = this.ResetEntityConfigType;
			TResetEntityConfig resetEntityConfigType = this.ResetEntityConfigType;
			if (resetEntityConfigType == TResetEntityConfig.IJigsawItemEntity)
			{
				_o.ResetEntityConfig.Value = ((this.ResetEntityConfig<IJigsawItemEntity>() != null) ? this.ResetEntityConfig<IJigsawItemEntity>().Value.UnPack() : null);
				return;
			}
			if (resetEntityConfigType != TResetEntityConfig.IResetTeleControlEntity)
			{
				return;
			}
			_o.ResetEntityConfig.Value = ((this.ResetEntityConfig<IResetTeleControlEntity>() != null) ? this.ResetEntityConfig<IResetTeleControlEntity>().Value.UnPack() : null);
		}

		// Token: 0x06035024 RID: 217124 RVA: 0x0071F1AC File Offset: 0x0071D3AC
		public static Offset<IResetEntity> Pack(FlatBufferBuilder builder, IResetEntityT _o)
		{
			if (_o == null)
			{
				return default(Offset<IResetEntity>);
			}
			TResetEntityConfig resetEntityConfig_type = (_o.ResetEntityConfig == null) ? TResetEntityConfig.NONE : _o.ResetEntityConfig.Type;
			int resetEntityConfigOffset = (_o.ResetEntityConfig == null) ? 0 : TResetEntityConfigUnion.Pack(builder, _o.ResetEntityConfig);
			return IResetEntity.CreateIResetEntity(builder, resetEntityConfig_type, resetEntityConfigOffset);
		}

		// Token: 0x040127ED RID: 75757
		private Table __p;
	}
}
