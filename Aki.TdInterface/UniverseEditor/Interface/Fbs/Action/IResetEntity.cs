using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E7C RID: 28284
	public struct IResetEntity : IFlatbufferObject
	{
		// Token: 0x1700D2A9 RID: 53929
		// (get) Token: 0x06031FD3 RID: 204755 RVA: 0x006C324B File Offset: 0x006C144B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031FD4 RID: 204756 RVA: 0x006C3258 File Offset: 0x006C1458
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06031FD5 RID: 204757 RVA: 0x006C3260 File Offset: 0x006C1460
		public static IResetEntity GetRootAsIResetEntity(ByteBuffer _bb)
		{
			return IResetEntity.GetRootAsIResetEntity(_bb, default(IResetEntity));
		}

		// Token: 0x06031FD6 RID: 204758 RVA: 0x006C327C File Offset: 0x006C147C
		public static IResetEntity GetRootAsIResetEntity(ByteBuffer _bb, IResetEntity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06031FD7 RID: 204759 RVA: 0x006C3299 File Offset: 0x006C1499
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031FD8 RID: 204760 RVA: 0x006C32A8 File Offset: 0x006C14A8
		public IResetEntity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D2AA RID: 53930
		// (get) Token: 0x06031FD9 RID: 204761 RVA: 0x006C32B8 File Offset: 0x006C14B8
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

		// Token: 0x06031FDA RID: 204762 RVA: 0x006C32F4 File Offset: 0x006C14F4
		public TTable? ResetEntityConfig<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06031FDB RID: 204763 RVA: 0x006C3338 File Offset: 0x006C1538
		public IJigsawItemEntity ResetEntityConfigAsIJigsawItemEntity()
		{
			return this.ResetEntityConfig<IJigsawItemEntity>().Value;
		}

		// Token: 0x06031FDC RID: 204764 RVA: 0x006C3354 File Offset: 0x006C1554
		public IResetTeleControlEntity ResetEntityConfigAsIResetTeleControlEntity()
		{
			return this.ResetEntityConfig<IResetTeleControlEntity>().Value;
		}

		// Token: 0x06031FDD RID: 204765 RVA: 0x006C336F File Offset: 0x006C156F
		public static Offset<IResetEntity> CreateIResetEntity(FlatBufferBuilder builder, TResetEntityConfig ResetEntityConfig_type = TResetEntityConfig.NONE, int ResetEntityConfigOffset = 0)
		{
			builder.StartTable(2);
			IResetEntity.AddResetEntityConfig(builder, ResetEntityConfigOffset);
			IResetEntity.AddResetEntityConfigType(builder, ResetEntityConfig_type);
			return IResetEntity.EndIResetEntity(builder);
		}

		// Token: 0x06031FDE RID: 204766 RVA: 0x006C338C File Offset: 0x006C158C
		public static void StartIResetEntity(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06031FDF RID: 204767 RVA: 0x006C3395 File Offset: 0x006C1595
		public static void AddResetEntityConfigType(FlatBufferBuilder builder, TResetEntityConfig resetEntityConfigType)
		{
			builder.AddByte(0, (byte)resetEntityConfigType, 0);
		}

		// Token: 0x06031FE0 RID: 204768 RVA: 0x006C33A0 File Offset: 0x006C15A0
		public static void AddResetEntityConfig(FlatBufferBuilder builder, int resetEntityConfigOffset)
		{
			builder.AddOffset(1, resetEntityConfigOffset, 0);
		}

		// Token: 0x06031FE1 RID: 204769 RVA: 0x006C33AB File Offset: 0x006C15AB
		public static Offset<IResetEntity> EndIResetEntity(FlatBufferBuilder builder)
		{
			return new Offset<IResetEntity>(builder.EndTable());
		}

		// Token: 0x06031FE2 RID: 204770 RVA: 0x006C33B8 File Offset: 0x006C15B8
		public IResetEntityT UnPack()
		{
			IResetEntityT resetEntityT = new IResetEntityT();
			this.UnPackTo(resetEntityT);
			return resetEntityT;
		}

		// Token: 0x06031FE3 RID: 204771 RVA: 0x006C33D4 File Offset: 0x006C15D4
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

		// Token: 0x06031FE4 RID: 204772 RVA: 0x006C3478 File Offset: 0x006C1678
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

		// Token: 0x04011868 RID: 71784
		private Table __p;
	}
}
