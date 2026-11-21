using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007448 RID: 29768
	public struct IPlayBubble : IFlatbufferObject
	{
		// Token: 0x1700DAA4 RID: 55972
		// (get) Token: 0x0603416E RID: 213358 RVA: 0x00704C16 File Offset: 0x00702E16
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603416F RID: 213359 RVA: 0x00704C23 File Offset: 0x00702E23
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06034170 RID: 213360 RVA: 0x00704C2C File Offset: 0x00702E2C
		public static IPlayBubble GetRootAsIPlayBubble(ByteBuffer _bb)
		{
			return IPlayBubble.GetRootAsIPlayBubble(_bb, default(IPlayBubble));
		}

		// Token: 0x06034171 RID: 213361 RVA: 0x00704C48 File Offset: 0x00702E48
		public static IPlayBubble GetRootAsIPlayBubble(ByteBuffer _bb, IPlayBubble obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06034172 RID: 213362 RVA: 0x00704C65 File Offset: 0x00702E65
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06034173 RID: 213363 RVA: 0x00704C74 File Offset: 0x00702E74
		public IPlayBubble __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DAA5 RID: 55973
		// (get) Token: 0x06034174 RID: 213364 RVA: 0x00704C84 File Offset: 0x00702E84
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

		// Token: 0x1700DAA6 RID: 55974
		// (get) Token: 0x06034175 RID: 213365 RVA: 0x00704CC0 File Offset: 0x00702EC0
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

		// Token: 0x1700DAA7 RID: 55975
		// (get) Token: 0x06034176 RID: 213366 RVA: 0x00704D20 File Offset: 0x00702F20
		public bool IsRangeFollowEntity
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700DAA8 RID: 55976
		// (get) Token: 0x06034177 RID: 213367 RVA: 0x00704D60 File Offset: 0x00702F60
		public bool IsAudioOccludedByScene
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700DAA9 RID: 55977
		// (get) Token: 0x06034178 RID: 213368 RVA: 0x00704DA0 File Offset: 0x00702FA0
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

		// Token: 0x1700DAAA RID: 55978
		// (get) Token: 0x06034179 RID: 213369 RVA: 0x00704E00 File Offset: 0x00703000
		public bool IsPlayMouthAnim
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700DAAB RID: 55979
		// (get) Token: 0x0603417A RID: 213370 RVA: 0x00704E40 File Offset: 0x00703040
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

		// Token: 0x0603417B RID: 213371 RVA: 0x00704E80 File Offset: 0x00703080
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

		// Token: 0x0603417C RID: 213372 RVA: 0x00704ECF File Offset: 0x007030CF
		public static void StartIPlayBubble(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x0603417D RID: 213373 RVA: 0x00704ED8 File Offset: 0x007030D8
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(0, entityId, 0);
		}

		// Token: 0x0603417E RID: 213374 RVA: 0x00704EE3 File Offset: 0x007030E3
		public static void AddFlow(FlatBufferBuilder builder, Offset<IBubbleIndex> flowOffset)
		{
			builder.AddOffset(1, flowOffset.Value, 0);
		}

		// Token: 0x0603417F RID: 213375 RVA: 0x00704EF3 File Offset: 0x007030F3
		public static void AddIsRangeFollowEntity(FlatBufferBuilder builder, bool isRangeFollowEntity)
		{
			builder.AddBool(2, isRangeFollowEntity, false);
		}

		// Token: 0x06034180 RID: 213376 RVA: 0x00704EFE File Offset: 0x007030FE
		public static void AddIsAudioOccludedByScene(FlatBufferBuilder builder, bool isAudioOccludedByScene)
		{
			builder.AddBool(3, isAudioOccludedByScene, false);
		}

		// Token: 0x06034181 RID: 213377 RVA: 0x00704F09 File Offset: 0x00703109
		public static void AddTriggerCylinderConfig(FlatBufferBuilder builder, Offset<IBubbleRangeCylinderConfig> triggerCylinderConfigOffset)
		{
			builder.AddOffset(4, triggerCylinderConfigOffset.Value, 0);
		}

		// Token: 0x06034182 RID: 213378 RVA: 0x00704F19 File Offset: 0x00703119
		public static void AddIsPlayMouthAnim(FlatBufferBuilder builder, bool isPlayMouthAnim)
		{
			builder.AddBool(5, isPlayMouthAnim, false);
		}

		// Token: 0x06034183 RID: 213379 RVA: 0x00704F24 File Offset: 0x00703124
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x06034184 RID: 213380 RVA: 0x00704F2F File Offset: 0x0070312F
		public static Offset<IPlayBubble> EndIPlayBubble(FlatBufferBuilder builder)
		{
			return new Offset<IPlayBubble>(builder.EndTable());
		}

		// Token: 0x06034185 RID: 213381 RVA: 0x00704F3C File Offset: 0x0070313C
		public IPlayBubbleT UnPack()
		{
			IPlayBubbleT playBubbleT = new IPlayBubbleT();
			this.UnPackTo(playBubbleT);
			return playBubbleT;
		}

		// Token: 0x06034186 RID: 213382 RVA: 0x00704F58 File Offset: 0x00703158
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

		// Token: 0x06034187 RID: 213383 RVA: 0x00705000 File Offset: 0x00703200
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

		// Token: 0x040125A9 RID: 75177
		private Table __p;
	}
}
