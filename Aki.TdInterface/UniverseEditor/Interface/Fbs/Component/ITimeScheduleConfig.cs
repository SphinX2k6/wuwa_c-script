using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020060A0 RID: 24736
	public struct ITimeScheduleConfig : IFlatbufferObject
	{
		// Token: 0x1700B7E5 RID: 47077
		// (get) Token: 0x06029D84 RID: 171396 RVA: 0x005B66BB File Offset: 0x005B48BB
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06029D85 RID: 171397 RVA: 0x005B66C8 File Offset: 0x005B48C8
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06029D86 RID: 171398 RVA: 0x005B66D0 File Offset: 0x005B48D0
		public static ITimeScheduleConfig GetRootAsITimeScheduleConfig(ByteBuffer _bb)
		{
			return ITimeScheduleConfig.GetRootAsITimeScheduleConfig(_bb, default(ITimeScheduleConfig));
		}

		// Token: 0x06029D87 RID: 171399 RVA: 0x005B66EC File Offset: 0x005B48EC
		public static ITimeScheduleConfig GetRootAsITimeScheduleConfig(ByteBuffer _bb, ITimeScheduleConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06029D88 RID: 171400 RVA: 0x005B6709 File Offset: 0x005B4909
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06029D89 RID: 171401 RVA: 0x005B6718 File Offset: 0x005B4918
		public ITimeScheduleConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B7E6 RID: 47078
		// (get) Token: 0x06029D8A RID: 171402 RVA: 0x005B6728 File Offset: 0x005B4928
		public string TimeScheduleTag
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06029D8B RID: 171403 RVA: 0x005B675F File Offset: 0x005B495F
		public Span<byte> GetTimeScheduleTagBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06029D8C RID: 171404 RVA: 0x005B676E File Offset: 0x005B496E
		public byte[] GetTimeScheduleTagArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x06029D8D RID: 171405 RVA: 0x005B677C File Offset: 0x005B497C
		public int TargetEntityIds(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700B7E7 RID: 47079
		// (get) Token: 0x06029D8E RID: 171406 RVA: 0x005B67BC File Offset: 0x005B49BC
		public int TargetEntityIdsLength
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

		// Token: 0x06029D8F RID: 171407 RVA: 0x005B67E7 File Offset: 0x005B49E7
		public Span<int> GetTargetEntityIdsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x06029D90 RID: 171408 RVA: 0x005B67F6 File Offset: 0x005B49F6
		public int[] GetTargetEntityIdsArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x1700B7E8 RID: 47080
		// (get) Token: 0x06029D91 RID: 171409 RVA: 0x005B6804 File Offset: 0x005B4A04
		public ITimeScheduleGenerateDynamicEntity? GenerateDynamicEntity
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new ITimeScheduleGenerateDynamicEntity?(default(ITimeScheduleGenerateDynamicEntity).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700B7E9 RID: 47081
		// (get) Token: 0x06029D92 RID: 171410 RVA: 0x005B6864 File Offset: 0x005B4A64
		public IConditionGroup? Conditions
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new IConditionGroup?(default(IConditionGroup).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06029D93 RID: 171411 RVA: 0x005B68C2 File Offset: 0x005B4AC2
		public static Offset<ITimeScheduleConfig> CreateITimeScheduleConfig(FlatBufferBuilder builder, StringOffset TimeScheduleTagOffset = default(StringOffset), VectorOffset TargetEntityIdsOffset = default(VectorOffset), Offset<ITimeScheduleGenerateDynamicEntity> GenerateDynamicEntityOffset = default(Offset<ITimeScheduleGenerateDynamicEntity>), Offset<IConditionGroup> ConditionsOffset = default(Offset<IConditionGroup>))
		{
			builder.StartTable(4);
			ITimeScheduleConfig.AddConditions(builder, ConditionsOffset);
			ITimeScheduleConfig.AddGenerateDynamicEntity(builder, GenerateDynamicEntityOffset);
			ITimeScheduleConfig.AddTargetEntityIds(builder, TargetEntityIdsOffset);
			ITimeScheduleConfig.AddTimeScheduleTag(builder, TimeScheduleTagOffset);
			return ITimeScheduleConfig.EndITimeScheduleConfig(builder);
		}

		// Token: 0x06029D94 RID: 171412 RVA: 0x005B68EE File Offset: 0x005B4AEE
		public static void StartITimeScheduleConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06029D95 RID: 171413 RVA: 0x005B68F7 File Offset: 0x005B4AF7
		public static void AddTimeScheduleTag(FlatBufferBuilder builder, StringOffset timeScheduleTagOffset)
		{
			builder.AddOffset(0, timeScheduleTagOffset.Value, 0);
		}

		// Token: 0x06029D96 RID: 171414 RVA: 0x005B6907 File Offset: 0x005B4B07
		public static void AddTargetEntityIds(FlatBufferBuilder builder, VectorOffset targetEntityIdsOffset)
		{
			builder.AddOffset(1, targetEntityIdsOffset.Value, 0);
		}

		// Token: 0x06029D97 RID: 171415 RVA: 0x005B6918 File Offset: 0x005B4B18
		public static VectorOffset CreateTargetEntityIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06029D98 RID: 171416 RVA: 0x005B694F File Offset: 0x005B4B4F
		public static VectorOffset CreateTargetEntityIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06029D99 RID: 171417 RVA: 0x005B6969 File Offset: 0x005B4B69
		public static VectorOffset CreateTargetEntityIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06029D9A RID: 171418 RVA: 0x005B6987 File Offset: 0x005B4B87
		public static VectorOffset CreateTargetEntityIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06029D9B RID: 171419 RVA: 0x005B69A0 File Offset: 0x005B4BA0
		public static void StartTargetEntityIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06029D9C RID: 171420 RVA: 0x005B69AB File Offset: 0x005B4BAB
		public static void AddGenerateDynamicEntity(FlatBufferBuilder builder, Offset<ITimeScheduleGenerateDynamicEntity> generateDynamicEntityOffset)
		{
			builder.AddOffset(2, generateDynamicEntityOffset.Value, 0);
		}

		// Token: 0x06029D9D RID: 171421 RVA: 0x005B69BB File Offset: 0x005B4BBB
		public static void AddConditions(FlatBufferBuilder builder, Offset<IConditionGroup> conditionsOffset)
		{
			builder.AddOffset(3, conditionsOffset.Value, 0);
		}

		// Token: 0x06029D9E RID: 171422 RVA: 0x005B69CB File Offset: 0x005B4BCB
		public static Offset<ITimeScheduleConfig> EndITimeScheduleConfig(FlatBufferBuilder builder)
		{
			return new Offset<ITimeScheduleConfig>(builder.EndTable());
		}

		// Token: 0x06029D9F RID: 171423 RVA: 0x005B69D8 File Offset: 0x005B4BD8
		public ITimeScheduleConfigT UnPack()
		{
			ITimeScheduleConfigT timeScheduleConfigT = new ITimeScheduleConfigT();
			this.UnPackTo(timeScheduleConfigT);
			return timeScheduleConfigT;
		}

		// Token: 0x06029DA0 RID: 171424 RVA: 0x005B69F4 File Offset: 0x005B4BF4
		public void UnPackTo(ITimeScheduleConfigT _o)
		{
			_o.TimeScheduleTag = this.TimeScheduleTag;
			_o.TargetEntityIds = new List<int>();
			for (int i = 0; i < this.TargetEntityIdsLength; i++)
			{
				_o.TargetEntityIds.Add(this.TargetEntityIds(i));
			}
			_o.GenerateDynamicEntity = ((this.GenerateDynamicEntity != null) ? this.GenerateDynamicEntity.Value.UnPack() : null);
			_o.Conditions = ((this.Conditions != null) ? this.Conditions.Value.UnPack() : null);
		}

		// Token: 0x06029DA1 RID: 171425 RVA: 0x005B6A9C File Offset: 0x005B4C9C
		public static Offset<ITimeScheduleConfig> Pack(FlatBufferBuilder builder, ITimeScheduleConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITimeScheduleConfig>);
			}
			StringOffset timeScheduleTagOffset = (_o.TimeScheduleTag == null) ? default(StringOffset) : builder.CreateString(_o.TimeScheduleTag);
			VectorOffset targetEntityIdsOffset = default(VectorOffset);
			if (_o.TargetEntityIds != null)
			{
				int[] data = _o.TargetEntityIds.ToArray();
				targetEntityIdsOffset = ITimeScheduleConfig.CreateTargetEntityIdsVector(builder, data);
			}
			Offset<ITimeScheduleGenerateDynamicEntity> generateDynamicEntityOffset = (_o.GenerateDynamicEntity == null) ? default(Offset<ITimeScheduleGenerateDynamicEntity>) : ITimeScheduleGenerateDynamicEntity.Pack(builder, _o.GenerateDynamicEntity);
			Offset<IConditionGroup> conditionsOffset = (_o.Conditions == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.Conditions);
			return ITimeScheduleConfig.CreateITimeScheduleConfig(builder, timeScheduleTagOffset, targetEntityIdsOffset, generateDynamicEntityOffset, conditionsOffset);
		}

		// Token: 0x0400FE47 RID: 65095
		private Table __p;
	}
}
