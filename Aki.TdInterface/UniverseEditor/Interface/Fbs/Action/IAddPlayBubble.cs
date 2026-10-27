using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006134 RID: 24884
	public struct IAddPlayBubble : IFlatbufferObject
	{
		// Token: 0x1700B766 RID: 46950
		// (get) Token: 0x0602A89B RID: 174235 RVA: 0x005DB6CE File Offset: 0x005D98CE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602A89C RID: 174236 RVA: 0x005DB6DB File Offset: 0x005D98DB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602A89D RID: 174237 RVA: 0x005DB6E4 File Offset: 0x005D98E4
		public static IAddPlayBubble GetRootAsIAddPlayBubble(ByteBuffer _bb)
		{
			return IAddPlayBubble.GetRootAsIAddPlayBubble(_bb, default(IAddPlayBubble));
		}

		// Token: 0x0602A89E RID: 174238 RVA: 0x005DB700 File Offset: 0x005D9900
		public static IAddPlayBubble GetRootAsIAddPlayBubble(ByteBuffer _bb, IAddPlayBubble obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602A89F RID: 174239 RVA: 0x005DB71D File Offset: 0x005D991D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602A8A0 RID: 174240 RVA: 0x005DB72C File Offset: 0x005D992C
		public IAddPlayBubble __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0602A8A1 RID: 174241 RVA: 0x005DB73C File Offset: 0x005D993C
		public int EntityIds(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700B767 RID: 46951
		// (get) Token: 0x0602A8A2 RID: 174242 RVA: 0x005DB77C File Offset: 0x005D997C
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

		// Token: 0x0602A8A3 RID: 174243 RVA: 0x005DB7A7 File Offset: 0x005D99A7
		public Span<int> GetEntityIdsBytes()
		{
			return this.__p.__vector_as_span<int>(4, 4);
		}

		// Token: 0x0602A8A4 RID: 174244 RVA: 0x005DB7B6 File Offset: 0x005D99B6
		public int[] GetEntityIdsArray()
		{
			return this.__p.__vector_as_array<int>(4);
		}

		// Token: 0x1700B768 RID: 46952
		// (get) Token: 0x0602A8A5 RID: 174245 RVA: 0x005DB7C4 File Offset: 0x005D99C4
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

		// Token: 0x1700B769 RID: 46953
		// (get) Token: 0x0602A8A6 RID: 174246 RVA: 0x005DB804 File Offset: 0x005D9A04
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

		// Token: 0x1700B76A RID: 46954
		// (get) Token: 0x0602A8A7 RID: 174247 RVA: 0x005DB844 File Offset: 0x005D9A44
		public bool IsRangeFollowEntity
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B76B RID: 46955
		// (get) Token: 0x0602A8A8 RID: 174248 RVA: 0x005DB884 File Offset: 0x005D9A84
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

		// Token: 0x1700B76C RID: 46956
		// (get) Token: 0x0602A8A9 RID: 174249 RVA: 0x005DB8E4 File Offset: 0x005D9AE4
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

		// Token: 0x1700B76D RID: 46957
		// (get) Token: 0x0602A8AA RID: 174250 RVA: 0x005DB924 File Offset: 0x005D9B24
		public bool RedDot
		{
			get
			{
				int num = this.__p.__offset(16);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B76E RID: 46958
		// (get) Token: 0x0602A8AB RID: 174251 RVA: 0x005DB964 File Offset: 0x005D9B64
		public bool IsAudioOccludedByScene
		{
			get
			{
				int num = this.__p.__offset(18);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B76F RID: 46959
		// (get) Token: 0x0602A8AC RID: 174252 RVA: 0x005DB9A4 File Offset: 0x005D9BA4
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

		// Token: 0x1700B770 RID: 46960
		// (get) Token: 0x0602A8AD RID: 174253 RVA: 0x005DBA04 File Offset: 0x005D9C04
		public bool IsPlayMouthAnim
		{
			get
			{
				int num = this.__p.__offset(22);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B771 RID: 46961
		// (get) Token: 0x0602A8AE RID: 174254 RVA: 0x005DBA44 File Offset: 0x005D9C44
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

		// Token: 0x0602A8AF RID: 174255 RVA: 0x005DBA84 File Offset: 0x005D9C84
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

		// Token: 0x0602A8B0 RID: 174256 RVA: 0x005DBAF4 File Offset: 0x005D9CF4
		public static void StartIAddPlayBubble(FlatBufferBuilder builder)
		{
			builder.StartTable(11);
		}

		// Token: 0x0602A8B1 RID: 174257 RVA: 0x005DBAFE File Offset: 0x005D9CFE
		public static void AddEntityIds(FlatBufferBuilder builder, VectorOffset entityIdsOffset)
		{
			builder.AddOffset(0, entityIdsOffset.Value, 0);
		}

		// Token: 0x0602A8B2 RID: 174258 RVA: 0x005DBB10 File Offset: 0x005D9D10
		public static VectorOffset CreateEntityIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602A8B3 RID: 174259 RVA: 0x005DBB47 File Offset: 0x005D9D47
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602A8B4 RID: 174260 RVA: 0x005DBB61 File Offset: 0x005D9D61
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602A8B5 RID: 174261 RVA: 0x005DBB7F File Offset: 0x005D9D7F
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602A8B6 RID: 174262 RVA: 0x005DBB98 File Offset: 0x005D9D98
		public static void StartEntityIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602A8B7 RID: 174263 RVA: 0x005DBBA3 File Offset: 0x005D9DA3
		public static void AddEnterRadius(FlatBufferBuilder builder, float enterRadius)
		{
			builder.AddFloat(1, enterRadius, 0.0);
		}

		// Token: 0x0602A8B8 RID: 174264 RVA: 0x005DBBB6 File Offset: 0x005D9DB6
		public static void AddLeaveRadius(FlatBufferBuilder builder, float leaveRadius)
		{
			builder.AddFloat(2, leaveRadius, 0.0);
		}

		// Token: 0x0602A8B9 RID: 174265 RVA: 0x005DBBC9 File Offset: 0x005D9DC9
		public static void AddIsRangeFollowEntity(FlatBufferBuilder builder, bool isRangeFollowEntity)
		{
			builder.AddBool(3, isRangeFollowEntity, false);
		}

		// Token: 0x0602A8BA RID: 174266 RVA: 0x005DBBD4 File Offset: 0x005D9DD4
		public static void AddFlow(FlatBufferBuilder builder, Offset<IBubbleIndex> flowOffset)
		{
			builder.AddOffset(4, flowOffset.Value, 0);
		}

		// Token: 0x0602A8BB RID: 174267 RVA: 0x005DBBE4 File Offset: 0x005D9DE4
		public static void AddWaitTime(FlatBufferBuilder builder, int waitTime)
		{
			builder.AddInt(5, waitTime, 0);
		}

		// Token: 0x0602A8BC RID: 174268 RVA: 0x005DBBEF File Offset: 0x005D9DEF
		public static void AddRedDot(FlatBufferBuilder builder, bool redDot)
		{
			builder.AddBool(6, redDot, false);
		}

		// Token: 0x0602A8BD RID: 174269 RVA: 0x005DBBFA File Offset: 0x005D9DFA
		public static void AddIsAudioOccludedByScene(FlatBufferBuilder builder, bool isAudioOccludedByScene)
		{
			builder.AddBool(7, isAudioOccludedByScene, false);
		}

		// Token: 0x0602A8BE RID: 174270 RVA: 0x005DBC05 File Offset: 0x005D9E05
		public static void AddTriggerCylinderConfig(FlatBufferBuilder builder, Offset<IBubbleRangeCylinderConfig> triggerCylinderConfigOffset)
		{
			builder.AddOffset(8, triggerCylinderConfigOffset.Value, 0);
		}

		// Token: 0x0602A8BF RID: 174271 RVA: 0x005DBC15 File Offset: 0x005D9E15
		public static void AddIsPlayMouthAnim(FlatBufferBuilder builder, bool isPlayMouthAnim)
		{
			builder.AddBool(9, isPlayMouthAnim, false);
		}

		// Token: 0x0602A8C0 RID: 174272 RVA: 0x005DBC21 File Offset: 0x005D9E21
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(10, nullMask, 0);
		}

		// Token: 0x0602A8C1 RID: 174273 RVA: 0x005DBC2D File Offset: 0x005D9E2D
		public static Offset<IAddPlayBubble> EndIAddPlayBubble(FlatBufferBuilder builder)
		{
			return new Offset<IAddPlayBubble>(builder.EndTable());
		}

		// Token: 0x0602A8C2 RID: 174274 RVA: 0x005DBC3C File Offset: 0x005D9E3C
		public IAddPlayBubbleT UnPack()
		{
			IAddPlayBubbleT addPlayBubbleT = new IAddPlayBubbleT();
			this.UnPackTo(addPlayBubbleT);
			return addPlayBubbleT;
		}

		// Token: 0x0602A8C3 RID: 174275 RVA: 0x005DBC58 File Offset: 0x005D9E58
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

		// Token: 0x0602A8C4 RID: 174276 RVA: 0x005DBD54 File Offset: 0x005D9F54
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

		// Token: 0x04010509 RID: 66825
		private Table __p;
	}
}
