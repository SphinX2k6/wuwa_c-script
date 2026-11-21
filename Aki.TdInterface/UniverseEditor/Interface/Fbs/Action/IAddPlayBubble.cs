using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006799 RID: 26521
	public struct IAddPlayBubble : IFlatbufferObject
	{
		// Token: 0x1700C0D6 RID: 49366
		// (get) Token: 0x0602CF94 RID: 184212 RVA: 0x006258AA File Offset: 0x00623AAA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602CF95 RID: 184213 RVA: 0x006258B7 File Offset: 0x00623AB7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602CF96 RID: 184214 RVA: 0x006258C0 File Offset: 0x00623AC0
		public static IAddPlayBubble GetRootAsIAddPlayBubble(ByteBuffer _bb)
		{
			return IAddPlayBubble.GetRootAsIAddPlayBubble(_bb, default(IAddPlayBubble));
		}

		// Token: 0x0602CF97 RID: 184215 RVA: 0x006258DC File Offset: 0x00623ADC
		public static IAddPlayBubble GetRootAsIAddPlayBubble(ByteBuffer _bb, IAddPlayBubble obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602CF98 RID: 184216 RVA: 0x006258F9 File Offset: 0x00623AF9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602CF99 RID: 184217 RVA: 0x00625908 File Offset: 0x00623B08
		public IAddPlayBubble __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0602CF9A RID: 184218 RVA: 0x00625918 File Offset: 0x00623B18
		public int EntityIds(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700C0D7 RID: 49367
		// (get) Token: 0x0602CF9B RID: 184219 RVA: 0x00625958 File Offset: 0x00623B58
		public int EntityIdsLength
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0602CF9C RID: 184220 RVA: 0x00625983 File Offset: 0x00623B83
		public Span<int> GetEntityIdsBytes()
		{
			return this.__p.__vector_as_span<int>(4, 4);
		}

		// Token: 0x0602CF9D RID: 184221 RVA: 0x00625992 File Offset: 0x00623B92
		public int[] GetEntityIdsArray()
		{
			return this.__p.__vector_as_array<int>(4);
		}

		// Token: 0x1700C0D8 RID: 49368
		// (get) Token: 0x0602CF9E RID: 184222 RVA: 0x006259A0 File Offset: 0x00623BA0
		public float EnterRadius
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C0D9 RID: 49369
		// (get) Token: 0x0602CF9F RID: 184223 RVA: 0x006259E0 File Offset: 0x00623BE0
		public float LeaveRadius
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C0DA RID: 49370
		// (get) Token: 0x0602CFA0 RID: 184224 RVA: 0x00625A20 File Offset: 0x00623C20
		public bool IsRangeFollowEntity
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C0DB RID: 49371
		// (get) Token: 0x0602CFA1 RID: 184225 RVA: 0x00625A60 File Offset: 0x00623C60
		public IBubbleIndex? Flow
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return new IBubbleIndex?(default(IBubbleIndex).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700C0DC RID: 49372
		// (get) Token: 0x0602CFA2 RID: 184226 RVA: 0x00625AC0 File Offset: 0x00623CC0
		public int WaitTime
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C0DD RID: 49373
		// (get) Token: 0x0602CFA3 RID: 184227 RVA: 0x00625B00 File Offset: 0x00623D00
		public bool RedDot
		{
			get
			{
				int num = this.__p.__offset(16);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C0DE RID: 49374
		// (get) Token: 0x0602CFA4 RID: 184228 RVA: 0x00625B40 File Offset: 0x00623D40
		public bool IsAudioOccludedByScene
		{
			get
			{
				int num = this.__p.__offset(18);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C0DF RID: 49375
		// (get) Token: 0x0602CFA5 RID: 184229 RVA: 0x00625B80 File Offset: 0x00623D80
		public IBubbleRangeCylinderConfig? TriggerCylinderConfig
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return null;
				}
				return new IBubbleRangeCylinderConfig?(default(IBubbleRangeCylinderConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700C0E0 RID: 49376
		// (get) Token: 0x0602CFA6 RID: 184230 RVA: 0x00625BE0 File Offset: 0x00623DE0
		public bool IsPlayMouthAnim
		{
			get
			{
				int num = this.__p.__offset(22);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C0E1 RID: 49377
		// (get) Token: 0x0602CFA7 RID: 184231 RVA: 0x00625C20 File Offset: 0x00623E20
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602CFA8 RID: 184232 RVA: 0x00625C60 File Offset: 0x00623E60
		public static Offset<IAddPlayBubble> CreateIAddPlayBubble(FlatBufferBuilder builder, VectorOffset EntityIdsOffset = default(VectorOffset), float EnterRadius = 0f, float LeaveRadius = 0f, bool IsRangeFollowEntity = false, Offset<IBubbleIndex> FlowOffset = default(Offset<IBubbleIndex>), int WaitTime = 0, bool RedDot = false, bool IsAudioOccludedByScene = false, Offset<IBubbleRangeCylinderConfig> TriggerCylinderConfigOffset = default(Offset<IBubbleRangeCylinderConfig>), bool IsPlayMouthAnim = false, byte NullMask = 0)
		{
			builder.StartTable(11);
			IAddPlayBubble.AddTriggerCylinderConfig(builder, TriggerCylinderConfigOffset);
			IAddPlayBubble.AddWaitTime(builder, WaitTime);
			IAddPlayBubble.AddFlow(builder, FlowOffset);
			IAddPlayBubble.AddLeaveRadius(builder, LeaveRadius);
			IAddPlayBubble.AddEnterRadius(builder, EnterRadius);
			IAddPlayBubble.AddEntityIds(builder, EntityIdsOffset);
			IAddPlayBubble.AddNullMask(builder, NullMask);
			IAddPlayBubble.AddIsPlayMouthAnim(builder, IsPlayMouthAnim);
			IAddPlayBubble.AddIsAudioOccludedByScene(builder, IsAudioOccludedByScene);
			IAddPlayBubble.AddRedDot(builder, RedDot);
			IAddPlayBubble.AddIsRangeFollowEntity(builder, IsRangeFollowEntity);
			return IAddPlayBubble.EndIAddPlayBubble(builder);
		}

		// Token: 0x0602CFA9 RID: 184233 RVA: 0x00625CD0 File Offset: 0x00623ED0
		public static void StartIAddPlayBubble(FlatBufferBuilder builder)
		{
			builder.StartTable(11);
		}

		// Token: 0x0602CFAA RID: 184234 RVA: 0x00625CDA File Offset: 0x00623EDA
		public static void AddEntityIds(FlatBufferBuilder builder, VectorOffset entityIdsOffset)
		{
			builder.AddOffset(0, entityIdsOffset.Value, 0);
		}

		// Token: 0x0602CFAB RID: 184235 RVA: 0x00625CEC File Offset: 0x00623EEC
		public static VectorOffset CreateEntityIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602CFAC RID: 184236 RVA: 0x00625D23 File Offset: 0x00623F23
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602CFAD RID: 184237 RVA: 0x00625D3D File Offset: 0x00623F3D
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602CFAE RID: 184238 RVA: 0x00625D5B File Offset: 0x00623F5B
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602CFAF RID: 184239 RVA: 0x00625D74 File Offset: 0x00623F74
		public static void StartEntityIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602CFB0 RID: 184240 RVA: 0x00625D7F File Offset: 0x00623F7F
		public static void AddEnterRadius(FlatBufferBuilder builder, float enterRadius)
		{
			builder.AddFloat(1, enterRadius, 0.0);
		}

		// Token: 0x0602CFB1 RID: 184241 RVA: 0x00625D92 File Offset: 0x00623F92
		public static void AddLeaveRadius(FlatBufferBuilder builder, float leaveRadius)
		{
			builder.AddFloat(2, leaveRadius, 0.0);
		}

		// Token: 0x0602CFB2 RID: 184242 RVA: 0x00625DA5 File Offset: 0x00623FA5
		public static void AddIsRangeFollowEntity(FlatBufferBuilder builder, bool isRangeFollowEntity)
		{
			builder.AddBool(3, isRangeFollowEntity, false);
		}

		// Token: 0x0602CFB3 RID: 184243 RVA: 0x00625DB0 File Offset: 0x00623FB0
		public static void AddFlow(FlatBufferBuilder builder, Offset<IBubbleIndex> flowOffset)
		{
			builder.AddOffset(4, flowOffset.Value, 0);
		}

		// Token: 0x0602CFB4 RID: 184244 RVA: 0x00625DC0 File Offset: 0x00623FC0
		public static void AddWaitTime(FlatBufferBuilder builder, int waitTime)
		{
			builder.AddInt(5, waitTime, 0);
		}

		// Token: 0x0602CFB5 RID: 184245 RVA: 0x00625DCB File Offset: 0x00623FCB
		public static void AddRedDot(FlatBufferBuilder builder, bool redDot)
		{
			builder.AddBool(6, redDot, false);
		}

		// Token: 0x0602CFB6 RID: 184246 RVA: 0x00625DD6 File Offset: 0x00623FD6
		public static void AddIsAudioOccludedByScene(FlatBufferBuilder builder, bool isAudioOccludedByScene)
		{
			builder.AddBool(7, isAudioOccludedByScene, false);
		}

		// Token: 0x0602CFB7 RID: 184247 RVA: 0x00625DE1 File Offset: 0x00623FE1
		public static void AddTriggerCylinderConfig(FlatBufferBuilder builder, Offset<IBubbleRangeCylinderConfig> triggerCylinderConfigOffset)
		{
			builder.AddOffset(8, triggerCylinderConfigOffset.Value, 0);
		}

		// Token: 0x0602CFB8 RID: 184248 RVA: 0x00625DF1 File Offset: 0x00623FF1
		public static void AddIsPlayMouthAnim(FlatBufferBuilder builder, bool isPlayMouthAnim)
		{
			builder.AddBool(9, isPlayMouthAnim, false);
		}

		// Token: 0x0602CFB9 RID: 184249 RVA: 0x00625DFD File Offset: 0x00623FFD
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(10, nullMask, 0);
		}

		// Token: 0x0602CFBA RID: 184250 RVA: 0x00625E09 File Offset: 0x00624009
		public static Offset<IAddPlayBubble> EndIAddPlayBubble(FlatBufferBuilder builder)
		{
			return new Offset<IAddPlayBubble>(builder.EndTable());
		}

		// Token: 0x0602CFBB RID: 184251 RVA: 0x00625E18 File Offset: 0x00624018
		public IAddPlayBubbleT UnPack()
		{
			IAddPlayBubbleT addPlayBubbleT = new IAddPlayBubbleT();
			this.UnPackTo(addPlayBubbleT);
			return addPlayBubbleT;
		}

		// Token: 0x0602CFBC RID: 184252 RVA: 0x00625E34 File Offset: 0x00624034
		public void UnPackTo(IAddPlayBubbleT _o)
		{
			_o.EntityIds = new List<int>();
			for (int i = 0; i < this.EntityIdsLength; i++)
			{
				_o.EntityIds.Add(this.EntityIds(i));
			}
			_o.EnterRadius = this.EnterRadius;
			_o.LeaveRadius = this.LeaveRadius;
			_o.IsRangeFollowEntity = this.IsRangeFollowEntity;
			_o.Flow = ((this.Flow != null) ? this.Flow.Value.UnPack() : null);
			_o.WaitTime = this.WaitTime;
			_o.RedDot = this.RedDot;
			_o.IsAudioOccludedByScene = this.IsAudioOccludedByScene;
			_o.TriggerCylinderConfig = ((this.TriggerCylinderConfig != null) ? this.TriggerCylinderConfig.Value.UnPack() : null);
			_o.IsPlayMouthAnim = this.IsPlayMouthAnim;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602CFBD RID: 184253 RVA: 0x00625F30 File Offset: 0x00624130
		public static Offset<IAddPlayBubble> Pack(FlatBufferBuilder builder, IAddPlayBubbleT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAddPlayBubble>);
			}
			VectorOffset entityIdsOffset = default(VectorOffset);
			if (_o.EntityIds != null)
			{
				int[] data = _o.EntityIds.ToArray();
				entityIdsOffset = IAddPlayBubble.CreateEntityIdsVector(builder, data);
			}
			Offset<IBubbleIndex> flowOffset = (_o.Flow == null) ? default(Offset<IBubbleIndex>) : IBubbleIndex.Pack(builder, _o.Flow);
			Offset<IBubbleRangeCylinderConfig> triggerCylinderConfigOffset = (_o.TriggerCylinderConfig == null) ? default(Offset<IBubbleRangeCylinderConfig>) : IBubbleRangeCylinderConfig.Pack(builder, _o.TriggerCylinderConfig);
			return IAddPlayBubble.CreateIAddPlayBubble(builder, entityIdsOffset, _o.EnterRadius, _o.LeaveRadius, _o.IsRangeFollowEntity, flowOffset, _o.WaitTime, _o.RedDot, _o.IsAudioOccludedByScene, triggerCylinderConfigOffset, _o.IsPlayMouthAnim, _o.NullMask);
		}

		// Token: 0x04011310 RID: 70416
		private Table __p;
	}
}
