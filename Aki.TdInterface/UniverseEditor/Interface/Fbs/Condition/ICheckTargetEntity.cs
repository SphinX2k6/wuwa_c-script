using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004B4D RID: 19277
	public struct ICheckTargetEntity : IFlatbufferObject
	{
		// Token: 0x17008BD7 RID: 35799
		// (get) Token: 0x0601E5A7 RID: 124327 RVA: 0x00440B33 File Offset: 0x0043ED33
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601E5A8 RID: 124328 RVA: 0x00440B40 File Offset: 0x0043ED40
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601E5A9 RID: 124329 RVA: 0x00440B48 File Offset: 0x0043ED48
		public static ICheckTargetEntity GetRootAsICheckTargetEntity(ByteBuffer _bb)
		{
			return ICheckTargetEntity.GetRootAsICheckTargetEntity(_bb, default(ICheckTargetEntity));
		}

		// Token: 0x0601E5AA RID: 124330 RVA: 0x00440B64 File Offset: 0x0043ED64
		public static ICheckTargetEntity GetRootAsICheckTargetEntity(ByteBuffer _bb, ICheckTargetEntity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601E5AB RID: 124331 RVA: 0x00440B81 File Offset: 0x0043ED81
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601E5AC RID: 124332 RVA: 0x00440B90 File Offset: 0x0043ED90
		public ICheckTargetEntity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008BD8 RID: 35800
		// (get) Token: 0x0601E5AD RID: 124333 RVA: 0x00440BA0 File Offset: 0x0043EDA0
		public ECheckEntity Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECheckEntity.OnlinePlayer;
				}
				return (ECheckEntity)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008BD9 RID: 35801
		// (get) Token: 0x0601E5AE RID: 124334 RVA: 0x00440BDC File Offset: 0x0043EDDC
		public TTargetEntity TargetEntityType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TTargetEntity.NONE;
				}
				return (TTargetEntity)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601E5AF RID: 124335 RVA: 0x00440C18 File Offset: 0x0043EE18
		public TTable? TargetEntity<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601E5B0 RID: 124336 RVA: 0x00440C5C File Offset: 0x0043EE5C
		public IPlayerEntity TargetEntityAsIPlayerEntity()
		{
			return this.TargetEntity<IPlayerEntity>().Value;
		}

		// Token: 0x0601E5B1 RID: 124337 RVA: 0x00440C78 File Offset: 0x0043EE78
		public ISelfEntity TargetEntityAsISelfEntity()
		{
			return this.TargetEntity<ISelfEntity>().Value;
		}

		// Token: 0x0601E5B2 RID: 124338 RVA: 0x00440C94 File Offset: 0x0043EE94
		public ITargetEntity TargetEntityAsITargetEntity()
		{
			return this.TargetEntity<ITargetEntity>().Value;
		}

		// Token: 0x0601E5B3 RID: 124339 RVA: 0x00440CB0 File Offset: 0x0043EEB0
		public ITriggeredEntity TargetEntityAsITriggeredEntity()
		{
			return this.TargetEntity<ITriggeredEntity>().Value;
		}

		// Token: 0x0601E5B4 RID: 124340 RVA: 0x00440CCB File Offset: 0x0043EECB
		public static Offset<ICheckTargetEntity> CreateICheckTargetEntity(FlatBufferBuilder builder, ECheckEntity Type = ECheckEntity.OnlinePlayer, TTargetEntity TargetEntity_type = TTargetEntity.NONE, int TargetEntityOffset = 0)
		{
			builder.StartTable(3);
			ICheckTargetEntity.AddTargetEntity(builder, TargetEntityOffset);
			ICheckTargetEntity.AddTargetEntityType(builder, TargetEntity_type);
			ICheckTargetEntity.AddType(builder, Type);
			return ICheckTargetEntity.EndICheckTargetEntity(builder);
		}

		// Token: 0x0601E5B5 RID: 124341 RVA: 0x00440CEF File Offset: 0x0043EEEF
		public static void StartICheckTargetEntity(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601E5B6 RID: 124342 RVA: 0x00440CF8 File Offset: 0x0043EEF8
		public static void AddType(FlatBufferBuilder builder, ECheckEntity type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601E5B7 RID: 124343 RVA: 0x00440D03 File Offset: 0x0043EF03
		public static void AddTargetEntityType(FlatBufferBuilder builder, TTargetEntity targetEntityType)
		{
			builder.AddByte(1, (byte)targetEntityType, 0);
		}

		// Token: 0x0601E5B8 RID: 124344 RVA: 0x00440D0E File Offset: 0x0043EF0E
		public static void AddTargetEntity(FlatBufferBuilder builder, int targetEntityOffset)
		{
			builder.AddOffset(2, targetEntityOffset, 0);
		}

		// Token: 0x0601E5B9 RID: 124345 RVA: 0x00440D19 File Offset: 0x0043EF19
		public static Offset<ICheckTargetEntity> EndICheckTargetEntity(FlatBufferBuilder builder)
		{
			return new Offset<ICheckTargetEntity>(builder.EndTable());
		}

		// Token: 0x0601E5BA RID: 124346 RVA: 0x00440D28 File Offset: 0x0043EF28
		public ICheckTargetEntityT UnPack()
		{
			ICheckTargetEntityT checkTargetEntityT = new ICheckTargetEntityT();
			this.UnPackTo(checkTargetEntityT);
			return checkTargetEntityT;
		}

		// Token: 0x0601E5BB RID: 124347 RVA: 0x00440D44 File Offset: 0x0043EF44
		public void UnPackTo(ICheckTargetEntityT _o)
		{
			_o.Type = this.Type;
			_o.TargetEntity = new TTargetEntityUnion();
			_o.TargetEntity.Type = this.TargetEntityType;
			switch (this.TargetEntityType)
			{
			case TTargetEntity.IPlayerEntity:
				_o.TargetEntity.Value = ((this.TargetEntity<IPlayerEntity>() != null) ? this.TargetEntity<IPlayerEntity>().Value.UnPack() : null);
				return;
			case TTargetEntity.ISelfEntity:
				_o.TargetEntity.Value = ((this.TargetEntity<ISelfEntity>() != null) ? this.TargetEntity<ISelfEntity>().Value.UnPack() : null);
				return;
			case TTargetEntity.ITargetEntity:
				_o.TargetEntity.Value = ((this.TargetEntity<ITargetEntity>() != null) ? this.TargetEntity<ITargetEntity>().Value.UnPack() : null);
				return;
			case TTargetEntity.ITriggeredEntity:
				_o.TargetEntity.Value = ((this.TargetEntity<ITriggeredEntity>() != null) ? this.TargetEntity<ITriggeredEntity>().Value.UnPack() : null);
				return;
			default:
				return;
			}
		}

		// Token: 0x0601E5BC RID: 124348 RVA: 0x00440E74 File Offset: 0x0043F074
		public static Offset<ICheckTargetEntity> Pack(FlatBufferBuilder builder, ICheckTargetEntityT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckTargetEntity>);
			}
			TTargetEntity targetEntity_type = (_o.TargetEntity == null) ? TTargetEntity.NONE : _o.TargetEntity.Type;
			int targetEntityOffset = (_o.TargetEntity == null) ? 0 : TTargetEntityUnion.Pack(builder, _o.TargetEntity);
			return ICheckTargetEntity.CreateICheckTargetEntity(builder, _o.Type, targetEntity_type, targetEntityOffset);
		}

		// Token: 0x0400D409 RID: 54281
		private Table __p;
	}
}
