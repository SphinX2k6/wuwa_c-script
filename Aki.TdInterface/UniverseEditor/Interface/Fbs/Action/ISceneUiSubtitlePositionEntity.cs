using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020076EA RID: 30442
	public struct ISceneUiSubtitlePositionEntity : IFlatbufferObject
	{
		// Token: 0x1700DF43 RID: 57155
		// (get) Token: 0x06035683 RID: 218755 RVA: 0x00729A68 File Offset: 0x00727C68
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06035684 RID: 218756 RVA: 0x00729A75 File Offset: 0x00727C75
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06035685 RID: 218757 RVA: 0x00729A7C File Offset: 0x00727C7C
		public static ISceneUiSubtitlePositionEntity GetRootAsISceneUiSubtitlePositionEntity(ByteBuffer _bb)
		{
			return ISceneUiSubtitlePositionEntity.GetRootAsISceneUiSubtitlePositionEntity(_bb, default(ISceneUiSubtitlePositionEntity));
		}

		// Token: 0x06035686 RID: 218758 RVA: 0x00729A98 File Offset: 0x00727C98
		public static ISceneUiSubtitlePositionEntity GetRootAsISceneUiSubtitlePositionEntity(ByteBuffer _bb, ISceneUiSubtitlePositionEntity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06035687 RID: 218759 RVA: 0x00729AB5 File Offset: 0x00727CB5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06035688 RID: 218760 RVA: 0x00729AC4 File Offset: 0x00727CC4
		public ISceneUiSubtitlePositionEntity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DF44 RID: 57156
		// (get) Token: 0x06035689 RID: 218761 RVA: 0x00729AD4 File Offset: 0x00727CD4
		public ESceneUiSubtitlePositionType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESceneUiSubtitlePositionType.Position;
				}
				return (ESceneUiSubtitlePositionType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700DF45 RID: 57157
		// (get) Token: 0x0603568A RID: 218762 RVA: 0x00729B10 File Offset: 0x00727D10
		public int EntityId
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

		// Token: 0x0603568B RID: 218763 RVA: 0x00729B4C File Offset: 0x00727D4C
		public static Offset<ISceneUiSubtitlePositionEntity> CreateISceneUiSubtitlePositionEntity(FlatBufferBuilder builder, ESceneUiSubtitlePositionType Type = ESceneUiSubtitlePositionType.Position, int EntityId = 0)
		{
			builder.StartTable(2);
			ISceneUiSubtitlePositionEntity.AddEntityId(builder, EntityId);
			ISceneUiSubtitlePositionEntity.AddType(builder, Type);
			return ISceneUiSubtitlePositionEntity.EndISceneUiSubtitlePositionEntity(builder);
		}

		// Token: 0x0603568C RID: 218764 RVA: 0x00729B69 File Offset: 0x00727D69
		public static void StartISceneUiSubtitlePositionEntity(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0603568D RID: 218765 RVA: 0x00729B72 File Offset: 0x00727D72
		public static void AddType(FlatBufferBuilder builder, ESceneUiSubtitlePositionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603568E RID: 218766 RVA: 0x00729B7D File Offset: 0x00727D7D
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(1, entityId, 0);
		}

		// Token: 0x0603568F RID: 218767 RVA: 0x00729B88 File Offset: 0x00727D88
		public static Offset<ISceneUiSubtitlePositionEntity> EndISceneUiSubtitlePositionEntity(FlatBufferBuilder builder)
		{
			return new Offset<ISceneUiSubtitlePositionEntity>(builder.EndTable());
		}

		// Token: 0x06035690 RID: 218768 RVA: 0x00729B98 File Offset: 0x00727D98
		public ISceneUiSubtitlePositionEntityT UnPack()
		{
			ISceneUiSubtitlePositionEntityT sceneUiSubtitlePositionEntityT = new ISceneUiSubtitlePositionEntityT();
			this.UnPackTo(sceneUiSubtitlePositionEntityT);
			return sceneUiSubtitlePositionEntityT;
		}

		// Token: 0x06035691 RID: 218769 RVA: 0x00729BB3 File Offset: 0x00727DB3
		public void UnPackTo(ISceneUiSubtitlePositionEntityT _o)
		{
			_o.Type = this.Type;
			_o.EntityId = this.EntityId;
		}

		// Token: 0x06035692 RID: 218770 RVA: 0x00729BD0 File Offset: 0x00727DD0
		public static Offset<ISceneUiSubtitlePositionEntity> Pack(FlatBufferBuilder builder, ISceneUiSubtitlePositionEntityT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISceneUiSubtitlePositionEntity>);
			}
			return ISceneUiSubtitlePositionEntity.CreateISceneUiSubtitlePositionEntity(builder, _o.Type, _o.EntityId);
		}

		// Token: 0x040128F0 RID: 76016
		private Table __p;
	}
}
