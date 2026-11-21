using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005457 RID: 21591
	public struct IBubbleComponent : IFlatbufferObject
	{
		// Token: 0x17009971 RID: 39281
		// (get) Token: 0x06021E24 RID: 138788 RVA: 0x004AB9F4 File Offset: 0x004A9BF4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06021E25 RID: 138789 RVA: 0x004ABA01 File Offset: 0x004A9C01
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06021E26 RID: 138790 RVA: 0x004ABA08 File Offset: 0x004A9C08
		public static IBubbleComponent GetRootAsIBubbleComponent(ByteBuffer _bb)
		{
			return IBubbleComponent.GetRootAsIBubbleComponent(_bb, default(IBubbleComponent));
		}

		// Token: 0x06021E27 RID: 138791 RVA: 0x004ABA24 File Offset: 0x004A9C24
		public static IBubbleComponent GetRootAsIBubbleComponent(ByteBuffer _bb, IBubbleComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06021E28 RID: 138792 RVA: 0x004ABA41 File Offset: 0x004A9C41
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06021E29 RID: 138793 RVA: 0x004ABA50 File Offset: 0x004A9C50
		public IBubbleComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009972 RID: 39282
		// (get) Token: 0x06021E2A RID: 138794 RVA: 0x004ABA60 File Offset: 0x004A9C60
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06021E2B RID: 138795 RVA: 0x004ABAA0 File Offset: 0x004A9CA0
		public int NpcIds(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17009973 RID: 39283
		// (get) Token: 0x06021E2C RID: 138796 RVA: 0x004ABAE0 File Offset: 0x004A9CE0
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

		// Token: 0x06021E2D RID: 138797 RVA: 0x004ABB0B File Offset: 0x004A9D0B
		public Span<int> GetNpcIdsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x06021E2E RID: 138798 RVA: 0x004ABB1A File Offset: 0x004A9D1A
		public int[] GetNpcIdsArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x17009974 RID: 39284
		// (get) Token: 0x06021E2F RID: 138799 RVA: 0x004ABB28 File Offset: 0x004A9D28
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

		// Token: 0x17009975 RID: 39285
		// (get) Token: 0x06021E30 RID: 138800 RVA: 0x004ABB68 File Offset: 0x004A9D68
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

		// Token: 0x17009976 RID: 39286
		// (get) Token: 0x06021E31 RID: 138801 RVA: 0x004ABBAC File Offset: 0x004A9DAC
		public bool IsRangeFollowEntity
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06021E32 RID: 138802 RVA: 0x004ABBEC File Offset: 0x004A9DEC
		public IConditionBubbleData? Flows(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new IConditionBubbleData?(default(IConditionBubbleData).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009977 RID: 39287
		// (get) Token: 0x06021E33 RID: 138803 RVA: 0x004ABC50 File Offset: 0x004A9E50
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

		// Token: 0x17009978 RID: 39288
		// (get) Token: 0x06021E34 RID: 138804 RVA: 0x004ABC7C File Offset: 0x004A9E7C
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

		// Token: 0x17009979 RID: 39289
		// (get) Token: 0x06021E35 RID: 138805 RVA: 0x004ABCBC File Offset: 0x004A9EBC
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

		// Token: 0x1700997A RID: 39290
		// (get) Token: 0x06021E36 RID: 138806 RVA: 0x004ABD00 File Offset: 0x004A9F00
		public bool IsAudioOccludedByScene
		{
			get
			{
				int num = this.__p.__offset(20);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700997B RID: 39291
		// (get) Token: 0x06021E37 RID: 138807 RVA: 0x004ABD40 File Offset: 0x004A9F40
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

		// Token: 0x1700997C RID: 39292
		// (get) Token: 0x06021E38 RID: 138808 RVA: 0x004ABDA0 File Offset: 0x004A9FA0
		public bool IsPlayMouthAnim
		{
			get
			{
				int num = this.__p.__offset(24);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700997D RID: 39293
		// (get) Token: 0x06021E39 RID: 138809 RVA: 0x004ABDE0 File Offset: 0x004A9FE0
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

		// Token: 0x06021E3A RID: 138810 RVA: 0x004ABE20 File Offset: 0x004AA020
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

		// Token: 0x06021E3B RID: 138811 RVA: 0x004ABE98 File Offset: 0x004AA098
		public static void StartIBubbleComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(12);
		}

		// Token: 0x06021E3C RID: 138812 RVA: 0x004ABEA2 File Offset: 0x004AA0A2
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06021E3D RID: 138813 RVA: 0x004ABEAD File Offset: 0x004AA0AD
		public static void AddNpcIds(FlatBufferBuilder builder, VectorOffset npcIdsOffset)
		{
			builder.AddOffset(1, npcIdsOffset.Value, 0);
		}

		// Token: 0x06021E3E RID: 138814 RVA: 0x004ABEC0 File Offset: 0x004AA0C0
		public static VectorOffset CreateNpcIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06021E3F RID: 138815 RVA: 0x004ABEF7 File Offset: 0x004AA0F7
		public static VectorOffset CreateNpcIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06021E40 RID: 138816 RVA: 0x004ABF11 File Offset: 0x004AA111
		public static VectorOffset CreateNpcIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06021E41 RID: 138817 RVA: 0x004ABF2F File Offset: 0x004AA12F
		public static VectorOffset CreateNpcIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06021E42 RID: 138818 RVA: 0x004ABF48 File Offset: 0x004AA148
		public static void StartNpcIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06021E43 RID: 138819 RVA: 0x004ABF53 File Offset: 0x004AA153
		public static void AddEnterRange(FlatBufferBuilder builder, float enterRange)
		{
			builder.AddFloat(2, enterRange, 0.0);
		}

		// Token: 0x06021E44 RID: 138820 RVA: 0x004ABF66 File Offset: 0x004AA166
		public static void AddLeaveRange(FlatBufferBuilder builder, float leaveRange)
		{
			builder.AddFloat(3, leaveRange, 0.0);
		}

		// Token: 0x06021E45 RID: 138821 RVA: 0x004ABF79 File Offset: 0x004AA179
		public static void AddIsRangeFollowEntity(FlatBufferBuilder builder, bool isRangeFollowEntity)
		{
			builder.AddBool(4, isRangeFollowEntity, false);
		}

		// Token: 0x06021E46 RID: 138822 RVA: 0x004ABF84 File Offset: 0x004AA184
		public static void AddFlows(FlatBufferBuilder builder, VectorOffset flowsOffset)
		{
			builder.AddOffset(5, flowsOffset.Value, 0);
		}

		// Token: 0x06021E47 RID: 138823 RVA: 0x004ABF94 File Offset: 0x004AA194
		public static VectorOffset CreateFlowsVector(FlatBufferBuilder builder, Offset<IConditionBubbleData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06021E48 RID: 138824 RVA: 0x004ABFD4 File Offset: 0x004AA1D4
		public static VectorOffset CreateFlowsVectorBlock(FlatBufferBuilder builder, Offset<IConditionBubbleData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IConditionBubbleData>>(data);
			return builder.EndVector();
		}

		// Token: 0x06021E49 RID: 138825 RVA: 0x004ABFEE File Offset: 0x004AA1EE
		public static VectorOffset CreateFlowsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IConditionBubbleData>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IConditionBubbleData>>(data);
			return builder.EndVector();
		}

		// Token: 0x06021E4A RID: 138826 RVA: 0x004AC00C File Offset: 0x004AA20C
		public static VectorOffset CreateFlowsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IConditionBubbleData>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06021E4B RID: 138827 RVA: 0x004AC025 File Offset: 0x004AA225
		public static void StartFlowsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06021E4C RID: 138828 RVA: 0x004AC030 File Offset: 0x004AA230
		public static void AddTimberId(FlatBufferBuilder builder, int timberId)
		{
			builder.AddInt(6, timberId, 0);
		}

		// Token: 0x06021E4D RID: 138829 RVA: 0x004AC03B File Offset: 0x004AA23B
		public static void AddScale(FlatBufferBuilder builder, float scale)
		{
			builder.AddFloat(7, scale, 0.0);
		}

		// Token: 0x06021E4E RID: 138830 RVA: 0x004AC04E File Offset: 0x004AA24E
		public static void AddIsAudioOccludedByScene(FlatBufferBuilder builder, bool isAudioOccludedByScene)
		{
			builder.AddBool(8, isAudioOccludedByScene, false);
		}

		// Token: 0x06021E4F RID: 138831 RVA: 0x004AC059 File Offset: 0x004AA259
		public static void AddTriggerCylinderConfig(FlatBufferBuilder builder, Offset<IBubbleRangeCylinderConfig> triggerCylinderConfigOffset)
		{
			builder.AddOffset(9, triggerCylinderConfigOffset.Value, 0);
		}

		// Token: 0x06021E50 RID: 138832 RVA: 0x004AC06A File Offset: 0x004AA26A
		public static void AddIsPlayMouthAnim(FlatBufferBuilder builder, bool isPlayMouthAnim)
		{
			builder.AddBool(10, isPlayMouthAnim, false);
		}

		// Token: 0x06021E51 RID: 138833 RVA: 0x004AC076 File Offset: 0x004AA276
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(11, nullMask, 0);
		}

		// Token: 0x06021E52 RID: 138834 RVA: 0x004AC082 File Offset: 0x004AA282
		public static Offset<IBubbleComponent> EndIBubbleComponent(FlatBufferBuilder builder)
		{
			return new Offset<IBubbleComponent>(builder.EndTable());
		}

		// Token: 0x06021E53 RID: 138835 RVA: 0x004AC090 File Offset: 0x004AA290
		public IBubbleComponentT UnPack()
		{
			IBubbleComponentT bubbleComponentT = new IBubbleComponentT();
			this.UnPackTo(bubbleComponentT);
			return bubbleComponentT;
		}

		// Token: 0x06021E54 RID: 138836 RVA: 0x004AC0AC File Offset: 0x004AA2AC
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

		// Token: 0x06021E55 RID: 138837 RVA: 0x004AC1D8 File Offset: 0x004AA3D8
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

		// Token: 0x0400E92C RID: 59692
		private Table __p;
	}
}
