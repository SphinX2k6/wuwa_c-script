using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006CD5 RID: 27861
	public struct IPlayBubble : IFlatbufferObject
	{
		// Token: 0x1700CF6A RID: 53098
		// (get) Token: 0x060311A9 RID: 201129 RVA: 0x006A9B59 File Offset: 0x006A7D59
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060311AA RID: 201130 RVA: 0x006A9B66 File Offset: 0x006A7D66
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060311AB RID: 201131 RVA: 0x006A9B70 File Offset: 0x006A7D70
		public static IPlayBubble GetRootAsIPlayBubble(ByteBuffer _bb)
		{
			return IPlayBubble.GetRootAsIPlayBubble(_bb, default(IPlayBubble));
		}

		// Token: 0x060311AC RID: 201132 RVA: 0x006A9B8C File Offset: 0x006A7D8C
		public static IPlayBubble GetRootAsIPlayBubble(ByteBuffer _bb, IPlayBubble obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060311AD RID: 201133 RVA: 0x006A9BA9 File Offset: 0x006A7DA9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060311AE RID: 201134 RVA: 0x006A9BB8 File Offset: 0x006A7DB8
		public IPlayBubble __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CF6B RID: 53099
		// (get) Token: 0x060311AF RID: 201135 RVA: 0x006A9BC8 File Offset: 0x006A7DC8
		public int EntityId
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700CF6C RID: 53100
		// (get) Token: 0x060311B0 RID: 201136 RVA: 0x006A9C04 File Offset: 0x006A7E04
		public IBubbleIndex? Flow
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IBubbleIndex?(default(IBubbleIndex).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700CF6D RID: 53101
		// (get) Token: 0x060311B1 RID: 201137 RVA: 0x006A9C64 File Offset: 0x006A7E64
		public bool IsRangeFollowEntity
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700CF6E RID: 53102
		// (get) Token: 0x060311B2 RID: 201138 RVA: 0x006A9CA4 File Offset: 0x006A7EA4
		public bool IsAudioOccludedByScene
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700CF6F RID: 53103
		// (get) Token: 0x060311B3 RID: 201139 RVA: 0x006A9CE4 File Offset: 0x006A7EE4
		public IBubbleRangeCylinderConfig? TriggerCylinderConfig
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return new IBubbleRangeCylinderConfig?(default(IBubbleRangeCylinderConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700CF70 RID: 53104
		// (get) Token: 0x060311B4 RID: 201140 RVA: 0x006A9D44 File Offset: 0x006A7F44
		public bool IsPlayMouthAnim
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700CF71 RID: 53105
		// (get) Token: 0x060311B5 RID: 201141 RVA: 0x006A9D84 File Offset: 0x006A7F84
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060311B6 RID: 201142 RVA: 0x006A9DC4 File Offset: 0x006A7FC4
		public static Offset<IPlayBubble> CreateIPlayBubble(FlatBufferBuilder builder, int EntityId = 0, Offset<IBubbleIndex> FlowOffset = default(Offset<IBubbleIndex>), bool IsRangeFollowEntity = false, bool IsAudioOccludedByScene = false, Offset<IBubbleRangeCylinderConfig> TriggerCylinderConfigOffset = default(Offset<IBubbleRangeCylinderConfig>), bool IsPlayMouthAnim = false, byte NullMask = 0)
		{
			builder.StartTable(7);
			IPlayBubble.AddTriggerCylinderConfig(builder, TriggerCylinderConfigOffset);
			IPlayBubble.AddFlow(builder, FlowOffset);
			IPlayBubble.AddEntityId(builder, EntityId);
			IPlayBubble.AddNullMask(builder, NullMask);
			IPlayBubble.AddIsPlayMouthAnim(builder, IsPlayMouthAnim);
			IPlayBubble.AddIsAudioOccludedByScene(builder, IsAudioOccludedByScene);
			IPlayBubble.AddIsRangeFollowEntity(builder, IsRangeFollowEntity);
			return IPlayBubble.EndIPlayBubble(builder);
		}

		// Token: 0x060311B7 RID: 201143 RVA: 0x006A9E13 File Offset: 0x006A8013
		public static void StartIPlayBubble(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x060311B8 RID: 201144 RVA: 0x006A9E1C File Offset: 0x006A801C
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(0, entityId, 0);
		}

		// Token: 0x060311B9 RID: 201145 RVA: 0x006A9E27 File Offset: 0x006A8027
		public static void AddFlow(FlatBufferBuilder builder, Offset<IBubbleIndex> flowOffset)
		{
			builder.AddOffset(1, flowOffset.Value, 0);
		}

		// Token: 0x060311BA RID: 201146 RVA: 0x006A9E37 File Offset: 0x006A8037
		public static void AddIsRangeFollowEntity(FlatBufferBuilder builder, bool isRangeFollowEntity)
		{
			builder.AddBool(2, isRangeFollowEntity, false);
		}

		// Token: 0x060311BB RID: 201147 RVA: 0x006A9E42 File Offset: 0x006A8042
		public static void AddIsAudioOccludedByScene(FlatBufferBuilder builder, bool isAudioOccludedByScene)
		{
			builder.AddBool(3, isAudioOccludedByScene, false);
		}

		// Token: 0x060311BC RID: 201148 RVA: 0x006A9E4D File Offset: 0x006A804D
		public static void AddTriggerCylinderConfig(FlatBufferBuilder builder, Offset<IBubbleRangeCylinderConfig> triggerCylinderConfigOffset)
		{
			builder.AddOffset(4, triggerCylinderConfigOffset.Value, 0);
		}

		// Token: 0x060311BD RID: 201149 RVA: 0x006A9E5D File Offset: 0x006A805D
		public static void AddIsPlayMouthAnim(FlatBufferBuilder builder, bool isPlayMouthAnim)
		{
			builder.AddBool(5, isPlayMouthAnim, false);
		}

		// Token: 0x060311BE RID: 201150 RVA: 0x006A9E68 File Offset: 0x006A8068
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x060311BF RID: 201151 RVA: 0x006A9E73 File Offset: 0x006A8073
		public static Offset<IPlayBubble> EndIPlayBubble(FlatBufferBuilder builder)
		{
			return new Offset<IPlayBubble>(builder.EndTable());
		}

		// Token: 0x060311C0 RID: 201152 RVA: 0x006A9E80 File Offset: 0x006A8080
		public IPlayBubbleT UnPack()
		{
			IPlayBubbleT playBubbleT = new IPlayBubbleT();
			this.UnPackTo(playBubbleT);
			return playBubbleT;
		}

		// Token: 0x060311C1 RID: 201153 RVA: 0x006A9E9C File Offset: 0x006A809C
		public void UnPackTo(IPlayBubbleT _o)
		{
			_o.EntityId = this.EntityId;
			_o.Flow = ((this.Flow != null) ? this.Flow.Value.UnPack() : null);
			_o.IsRangeFollowEntity = this.IsRangeFollowEntity;
			_o.IsAudioOccludedByScene = this.IsAudioOccludedByScene;
			_o.TriggerCylinderConfig = ((this.TriggerCylinderConfig != null) ? this.TriggerCylinderConfig.Value.UnPack() : null);
			_o.IsPlayMouthAnim = this.IsPlayMouthAnim;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060311C2 RID: 201154 RVA: 0x006A9F44 File Offset: 0x006A8144
		public static Offset<IPlayBubble> Pack(FlatBufferBuilder builder, IPlayBubbleT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPlayBubble>);
			}
			Offset<IBubbleIndex> flowOffset = (_o.Flow == null) ? default(Offset<IBubbleIndex>) : IBubbleIndex.Pack(builder, _o.Flow);
			Offset<IBubbleRangeCylinderConfig> triggerCylinderConfigOffset = (_o.TriggerCylinderConfig == null) ? default(Offset<IBubbleRangeCylinderConfig>) : IBubbleRangeCylinderConfig.Pack(builder, _o.TriggerCylinderConfig);
			return IPlayBubble.CreateIPlayBubble(builder, _o.EntityId, flowOffset, _o.IsRangeFollowEntity, _o.IsAudioOccludedByScene, triggerCylinderConfigOffset, _o.IsPlayMouthAnim, _o.NullMask);
		}

		// Token: 0x0401163B RID: 71227
		private Table __p;
	}
}
