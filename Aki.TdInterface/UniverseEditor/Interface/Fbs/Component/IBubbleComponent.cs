using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004F25 RID: 20261
	public struct IBubbleComponent : IFlatbufferObject
	{
		// Token: 0x170091EF RID: 37359
		// (get) Token: 0x060200B4 RID: 131252 RVA: 0x00475660 File Offset: 0x00473860
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060200B5 RID: 131253 RVA: 0x0047566D File Offset: 0x0047386D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060200B6 RID: 131254 RVA: 0x00475674 File Offset: 0x00473874
		public static IBubbleComponent GetRootAsIBubbleComponent(ByteBuffer _bb)
		{
			return IBubbleComponent.GetRootAsIBubbleComponent(_bb, default(IBubbleComponent));
		}

		// Token: 0x060200B7 RID: 131255 RVA: 0x00475690 File Offset: 0x00473890
		public static IBubbleComponent GetRootAsIBubbleComponent(ByteBuffer _bb, IBubbleComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060200B8 RID: 131256 RVA: 0x004756AD File Offset: 0x004738AD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060200B9 RID: 131257 RVA: 0x004756BC File Offset: 0x004738BC
		public IBubbleComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170091F0 RID: 37360
		// (get) Token: 0x060200BA RID: 131258 RVA: 0x004756CC File Offset: 0x004738CC
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x060200BB RID: 131259 RVA: 0x0047570C File Offset: 0x0047390C
		public int NpcIds(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170091F1 RID: 37361
		// (get) Token: 0x060200BC RID: 131260 RVA: 0x0047574C File Offset: 0x0047394C
		public int NpcIdsLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060200BD RID: 131261 RVA: 0x00475777 File Offset: 0x00473977
		public Span<int> GetNpcIdsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x060200BE RID: 131262 RVA: 0x00475786 File Offset: 0x00473986
		public int[] GetNpcIdsArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x170091F2 RID: 37362
		// (get) Token: 0x060200BF RID: 131263 RVA: 0x00475794 File Offset: 0x00473994
		public float EnterRange
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

		// Token: 0x170091F3 RID: 37363
		// (get) Token: 0x060200C0 RID: 131264 RVA: 0x004757D4 File Offset: 0x004739D4
		public float LeaveRange
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170091F4 RID: 37364
		// (get) Token: 0x060200C1 RID: 131265 RVA: 0x00475818 File Offset: 0x00473A18
		public bool IsRangeFollowEntity
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x060200C2 RID: 131266 RVA: 0x00475858 File Offset: 0x00473A58
		public IConditionBubbleData? Flows(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new IConditionBubbleData?(default(IConditionBubbleData).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170091F5 RID: 37365
		// (get) Token: 0x060200C3 RID: 131267 RVA: 0x004758BC File Offset: 0x00473ABC
		public int FlowsLength
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x170091F6 RID: 37366
		// (get) Token: 0x060200C4 RID: 131268 RVA: 0x004758E8 File Offset: 0x00473AE8
		public int TimberId
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170091F7 RID: 37367
		// (get) Token: 0x060200C5 RID: 131269 RVA: 0x00475928 File Offset: 0x00473B28
		public float Scale
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170091F8 RID: 37368
		// (get) Token: 0x060200C6 RID: 131270 RVA: 0x0047596C File Offset: 0x00473B6C
		public bool IsAudioOccludedByScene
		{
			get
			{
				int num = this.__p.__offset(20);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170091F9 RID: 37369
		// (get) Token: 0x060200C7 RID: 131271 RVA: 0x004759AC File Offset: 0x00473BAC
		public IBubbleRangeCylinderConfig? TriggerCylinderConfig
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return null;
				}
				return new IBubbleRangeCylinderConfig?(default(IBubbleRangeCylinderConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x170091FA RID: 37370
		// (get) Token: 0x060200C8 RID: 131272 RVA: 0x00475A0C File Offset: 0x00473C0C
		public bool IsPlayMouthAnim
		{
			get
			{
				int num = this.__p.__offset(24);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170091FB RID: 37371
		// (get) Token: 0x060200C9 RID: 131273 RVA: 0x00475A4C File Offset: 0x00473C4C
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060200CA RID: 131274 RVA: 0x00475A8C File Offset: 0x00473C8C
		public static Offset<IBubbleComponent> CreateIBubbleComponent(FlatBufferBuilder builder, bool Disabled = false, VectorOffset NpcIdsOffset = default(VectorOffset), float EnterRange = 0f, float LeaveRange = 0f, bool IsRangeFollowEntity = false, VectorOffset FlowsOffset = default(VectorOffset), int TimberId = 0, float Scale = 0f, bool IsAudioOccludedByScene = false, Offset<IBubbleRangeCylinderConfig> TriggerCylinderConfigOffset = default(Offset<IBubbleRangeCylinderConfig>), bool IsPlayMouthAnim = false, byte NullMask = 0)
		{
			builder.StartTable(12);
			IBubbleComponent.AddTriggerCylinderConfig(builder, TriggerCylinderConfigOffset);
			IBubbleComponent.AddScale(builder, Scale);
			IBubbleComponent.AddTimberId(builder, TimberId);
			IBubbleComponent.AddFlows(builder, FlowsOffset);
			IBubbleComponent.AddLeaveRange(builder, LeaveRange);
			IBubbleComponent.AddEnterRange(builder, EnterRange);
			IBubbleComponent.AddNpcIds(builder, NpcIdsOffset);
			IBubbleComponent.AddNullMask(builder, NullMask);
			IBubbleComponent.AddIsPlayMouthAnim(builder, IsPlayMouthAnim);
			IBubbleComponent.AddIsAudioOccludedByScene(builder, IsAudioOccludedByScene);
			IBubbleComponent.AddIsRangeFollowEntity(builder, IsRangeFollowEntity);
			IBubbleComponent.AddDisabled(builder, Disabled);
			return IBubbleComponent.EndIBubbleComponent(builder);
		}

		// Token: 0x060200CB RID: 131275 RVA: 0x00475B04 File Offset: 0x00473D04
		public static void StartIBubbleComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(12);
		}

		// Token: 0x060200CC RID: 131276 RVA: 0x00475B0E File Offset: 0x00473D0E
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x060200CD RID: 131277 RVA: 0x00475B19 File Offset: 0x00473D19
		public static void AddNpcIds(FlatBufferBuilder builder, VectorOffset npcIdsOffset)
		{
			builder.AddOffset(1, npcIdsOffset.Value, 0);
		}

		// Token: 0x060200CE RID: 131278 RVA: 0x00475B2C File Offset: 0x00473D2C
		public static VectorOffset CreateNpcIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x060200CF RID: 131279 RVA: 0x00475B63 File Offset: 0x00473D63
		public static VectorOffset CreateNpcIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060200D0 RID: 131280 RVA: 0x00475B7D File Offset: 0x00473D7D
		public static VectorOffset CreateNpcIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060200D1 RID: 131281 RVA: 0x00475B9B File Offset: 0x00473D9B
		public static VectorOffset CreateNpcIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060200D2 RID: 131282 RVA: 0x00475BB4 File Offset: 0x00473DB4
		public static void StartNpcIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060200D3 RID: 131283 RVA: 0x00475BBF File Offset: 0x00473DBF
		public static void AddEnterRange(FlatBufferBuilder builder, float enterRange)
		{
			builder.AddFloat(2, enterRange, 0.0);
		}

		// Token: 0x060200D4 RID: 131284 RVA: 0x00475BD2 File Offset: 0x00473DD2
		public static void AddLeaveRange(FlatBufferBuilder builder, float leaveRange)
		{
			builder.AddFloat(3, leaveRange, 0.0);
		}

		// Token: 0x060200D5 RID: 131285 RVA: 0x00475BE5 File Offset: 0x00473DE5
		public static void AddIsRangeFollowEntity(FlatBufferBuilder builder, bool isRangeFollowEntity)
		{
			builder.AddBool(4, isRangeFollowEntity, false);
		}

		// Token: 0x060200D6 RID: 131286 RVA: 0x00475BF0 File Offset: 0x00473DF0
		public static void AddFlows(FlatBufferBuilder builder, VectorOffset flowsOffset)
		{
			builder.AddOffset(5, flowsOffset.Value, 0);
		}

		// Token: 0x060200D7 RID: 131287 RVA: 0x00475C00 File Offset: 0x00473E00
		public static VectorOffset CreateFlowsVector(FlatBufferBuilder builder, Offset<IConditionBubbleData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060200D8 RID: 131288 RVA: 0x00475C40 File Offset: 0x00473E40
		public static VectorOffset CreateFlowsVectorBlock(FlatBufferBuilder builder, Offset<IConditionBubbleData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IConditionBubbleData>>(data);
			return builder.EndVector();
		}

		// Token: 0x060200D9 RID: 131289 RVA: 0x00475C5A File Offset: 0x00473E5A
		public static VectorOffset CreateFlowsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IConditionBubbleData>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IConditionBubbleData>>(data);
			return builder.EndVector();
		}

		// Token: 0x060200DA RID: 131290 RVA: 0x00475C78 File Offset: 0x00473E78
		public static VectorOffset CreateFlowsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IConditionBubbleData>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060200DB RID: 131291 RVA: 0x00475C91 File Offset: 0x00473E91
		public static void StartFlowsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060200DC RID: 131292 RVA: 0x00475C9C File Offset: 0x00473E9C
		public static void AddTimberId(FlatBufferBuilder builder, int timberId)
		{
			builder.AddInt(6, timberId, 0);
		}

		// Token: 0x060200DD RID: 131293 RVA: 0x00475CA7 File Offset: 0x00473EA7
		public static void AddScale(FlatBufferBuilder builder, float scale)
		{
			builder.AddFloat(7, scale, 0.0);
		}

		// Token: 0x060200DE RID: 131294 RVA: 0x00475CBA File Offset: 0x00473EBA
		public static void AddIsAudioOccludedByScene(FlatBufferBuilder builder, bool isAudioOccludedByScene)
		{
			builder.AddBool(8, isAudioOccludedByScene, false);
		}

		// Token: 0x060200DF RID: 131295 RVA: 0x00475CC5 File Offset: 0x00473EC5
		public static void AddTriggerCylinderConfig(FlatBufferBuilder builder, Offset<IBubbleRangeCylinderConfig> triggerCylinderConfigOffset)
		{
			builder.AddOffset(9, triggerCylinderConfigOffset.Value, 0);
		}

		// Token: 0x060200E0 RID: 131296 RVA: 0x00475CD6 File Offset: 0x00473ED6
		public static void AddIsPlayMouthAnim(FlatBufferBuilder builder, bool isPlayMouthAnim)
		{
			builder.AddBool(10, isPlayMouthAnim, false);
		}

		// Token: 0x060200E1 RID: 131297 RVA: 0x00475CE2 File Offset: 0x00473EE2
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(11, nullMask, 0);
		}

		// Token: 0x060200E2 RID: 131298 RVA: 0x00475CEE File Offset: 0x00473EEE
		public static Offset<IBubbleComponent> EndIBubbleComponent(FlatBufferBuilder builder)
		{
			return new Offset<IBubbleComponent>(builder.EndTable());
		}

		// Token: 0x060200E3 RID: 131299 RVA: 0x00475CFC File Offset: 0x00473EFC
		public IBubbleComponentT UnPack()
		{
			IBubbleComponentT bubbleComponentT = new IBubbleComponentT();
			this.UnPackTo(bubbleComponentT);
			return bubbleComponentT;
		}

		// Token: 0x060200E4 RID: 131300 RVA: 0x00475D18 File Offset: 0x00473F18
		public void UnPackTo(IBubbleComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.NpcIds = new List<int>();
			for (int i = 0; i < this.NpcIdsLength; i++)
			{
				_o.NpcIds.Add(this.NpcIds(i));
			}
			_o.EnterRange = this.EnterRange;
			_o.LeaveRange = this.LeaveRange;
			_o.IsRangeFollowEntity = this.IsRangeFollowEntity;
			_o.Flows = new List<IConditionBubbleDataT>();
			for (int j = 0; j < this.FlowsLength; j++)
			{
				_o.Flows.Add((this.Flows(j) != null) ? this.Flows(j).Value.UnPack() : null);
			}
			_o.TimberId = this.TimberId;
			_o.Scale = this.Scale;
			_o.IsAudioOccludedByScene = this.IsAudioOccludedByScene;
			_o.TriggerCylinderConfig = ((this.TriggerCylinderConfig != null) ? this.TriggerCylinderConfig.Value.UnPack() : null);
			_o.IsPlayMouthAnim = this.IsPlayMouthAnim;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060200E5 RID: 131301 RVA: 0x00475E44 File Offset: 0x00474044
		public static Offset<IBubbleComponent> Pack(FlatBufferBuilder builder, IBubbleComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBubbleComponent>);
			}
			VectorOffset npcIdsOffset = default(VectorOffset);
			if (_o.NpcIds != null)
			{
				int[] data = _o.NpcIds.ToArray();
				npcIdsOffset = IBubbleComponent.CreateNpcIdsVector(builder, data);
			}
			VectorOffset flowsOffset = default(VectorOffset);
			if (_o.Flows != null)
			{
				Offset<IConditionBubbleData>[] array = new Offset<IConditionBubbleData>[_o.Flows.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IConditionBubbleData.Pack(builder, _o.Flows[i]);
				}
				flowsOffset = IBubbleComponent.CreateFlowsVector(builder, array);
			}
			Offset<IBubbleRangeCylinderConfig> triggerCylinderConfigOffset = (_o.TriggerCylinderConfig == null) ? default(Offset<IBubbleRangeCylinderConfig>) : IBubbleRangeCylinderConfig.Pack(builder, _o.TriggerCylinderConfig);
			return IBubbleComponent.CreateIBubbleComponent(builder, _o.Disabled, npcIdsOffset, _o.EnterRange, _o.LeaveRange, _o.IsRangeFollowEntity, flowsOffset, _o.TimberId, _o.Scale, _o.IsAudioOccludedByScene, triggerCylinderConfigOffset, _o.IsPlayMouthAnim, _o.NullMask);
		}

		// Token: 0x0400DD7D RID: 56701
		private Table __p;
	}
}
