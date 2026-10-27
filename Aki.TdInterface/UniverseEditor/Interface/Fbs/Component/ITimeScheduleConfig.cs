using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A93 RID: 23187
	public struct ITimeScheduleConfig : IFlatbufferObject
	{
		// Token: 0x1700AEAD RID: 44717
		// (get) Token: 0x0602780C RID: 161804 RVA: 0x0056F6AF File Offset: 0x0056D8AF
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602780D RID: 161805 RVA: 0x0056F6BC File Offset: 0x0056D8BC
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602780E RID: 161806 RVA: 0x0056F6C4 File Offset: 0x0056D8C4
		public static ITimeScheduleConfig GetRootAsITimeScheduleConfig(ByteBuffer _bb)
		{
			return ITimeScheduleConfig.GetRootAsITimeScheduleConfig(_bb, default(ITimeScheduleConfig));
		}

		// Token: 0x0602780F RID: 161807 RVA: 0x0056F6E0 File Offset: 0x0056D8E0
		public static ITimeScheduleConfig GetRootAsITimeScheduleConfig(ByteBuffer _bb, ITimeScheduleConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06027810 RID: 161808 RVA: 0x0056F6FD File Offset: 0x0056D8FD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06027811 RID: 161809 RVA: 0x0056F70C File Offset: 0x0056D90C
		public ITimeScheduleConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AEAE RID: 44718
		// (get) Token: 0x06027812 RID: 161810 RVA: 0x0056F71C File Offset: 0x0056D91C
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

		// Token: 0x06027813 RID: 161811 RVA: 0x0056F753 File Offset: 0x0056D953
		public Span<byte> GetTimeScheduleTagBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06027814 RID: 161812 RVA: 0x0056F762 File Offset: 0x0056D962
		public byte[] GetTimeScheduleTagArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x06027815 RID: 161813 RVA: 0x0056F770 File Offset: 0x0056D970
		public int TargetEntityIds(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700AEAF RID: 44719
		// (get) Token: 0x06027816 RID: 161814 RVA: 0x0056F7B0 File Offset: 0x0056D9B0
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

		// Token: 0x06027817 RID: 161815 RVA: 0x0056F7DB File Offset: 0x0056D9DB
		public Span<int> GetTargetEntityIdsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x06027818 RID: 161816 RVA: 0x0056F7EA File Offset: 0x0056D9EA
		public int[] GetTargetEntityIdsArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x1700AEB0 RID: 44720
		// (get) Token: 0x06027819 RID: 161817 RVA: 0x0056F7F8 File Offset: 0x0056D9F8
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

		// Token: 0x1700AEB1 RID: 44721
		// (get) Token: 0x0602781A RID: 161818 RVA: 0x0056F858 File Offset: 0x0056DA58
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

		// Token: 0x0602781B RID: 161819 RVA: 0x0056F8B6 File Offset: 0x0056DAB6
		public static Offset<ITimeScheduleConfig> CreateITimeScheduleConfig(FlatBufferBuilder builder, StringOffset TimeScheduleTagOffset = default(StringOffset), VectorOffset TargetEntityIdsOffset = default(VectorOffset), Offset<ITimeScheduleGenerateDynamicEntity> GenerateDynamicEntityOffset = default(Offset<ITimeScheduleGenerateDynamicEntity>), Offset<IConditionGroup> ConditionsOffset = default(Offset<IConditionGroup>))
		{
			builder.StartTable(4);
			ITimeScheduleConfig.AddConditions(builder, ConditionsOffset);
			ITimeScheduleConfig.AddGenerateDynamicEntity(builder, GenerateDynamicEntityOffset);
			ITimeScheduleConfig.AddTargetEntityIds(builder, TargetEntityIdsOffset);
			ITimeScheduleConfig.AddTimeScheduleTag(builder, TimeScheduleTagOffset);
			return ITimeScheduleConfig.EndITimeScheduleConfig(builder);
		}

		// Token: 0x0602781C RID: 161820 RVA: 0x0056F8E2 File Offset: 0x0056DAE2
		public static void StartITimeScheduleConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0602781D RID: 161821 RVA: 0x0056F8EB File Offset: 0x0056DAEB
		public static void AddTimeScheduleTag(FlatBufferBuilder builder, StringOffset timeScheduleTagOffset)
		{
			builder.AddOffset(0, timeScheduleTagOffset.Value, 0);
		}

		// Token: 0x0602781E RID: 161822 RVA: 0x0056F8FB File Offset: 0x0056DAFB
		public static void AddTargetEntityIds(FlatBufferBuilder builder, VectorOffset targetEntityIdsOffset)
		{
			builder.AddOffset(1, targetEntityIdsOffset.Value, 0);
		}

		// Token: 0x0602781F RID: 161823 RVA: 0x0056F90C File Offset: 0x0056DB0C
		public static VectorOffset CreateTargetEntityIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06027820 RID: 161824 RVA: 0x0056F943 File Offset: 0x0056DB43
		public static VectorOffset CreateTargetEntityIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06027821 RID: 161825 RVA: 0x0056F95D File Offset: 0x0056DB5D
		public static VectorOffset CreateTargetEntityIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06027822 RID: 161826 RVA: 0x0056F97B File Offset: 0x0056DB7B
		public static VectorOffset CreateTargetEntityIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06027823 RID: 161827 RVA: 0x0056F994 File Offset: 0x0056DB94
		public static void StartTargetEntityIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06027824 RID: 161828 RVA: 0x0056F99F File Offset: 0x0056DB9F
		public static void AddGenerateDynamicEntity(FlatBufferBuilder builder, Offset<ITimeScheduleGenerateDynamicEntity> generateDynamicEntityOffset)
		{
			builder.AddOffset(2, generateDynamicEntityOffset.Value, 0);
		}

		// Token: 0x06027825 RID: 161829 RVA: 0x0056F9AF File Offset: 0x0056DBAF
		public static void AddConditions(FlatBufferBuilder builder, Offset<IConditionGroup> conditionsOffset)
		{
			builder.AddOffset(3, conditionsOffset.Value, 0);
		}

		// Token: 0x06027826 RID: 161830 RVA: 0x0056F9BF File Offset: 0x0056DBBF
		public static Offset<ITimeScheduleConfig> EndITimeScheduleConfig(FlatBufferBuilder builder)
		{
			return new Offset<ITimeScheduleConfig>(builder.EndTable());
		}

		// Token: 0x06027827 RID: 161831 RVA: 0x0056F9CC File Offset: 0x0056DBCC
		public ITimeScheduleConfigT UnPack()
		{
			ITimeScheduleConfigT timeScheduleConfigT = new ITimeScheduleConfigT();
			this.UnPackTo(timeScheduleConfigT);
			return timeScheduleConfigT;
		}

		// Token: 0x06027828 RID: 161832 RVA: 0x0056F9E8 File Offset: 0x0056DBE8
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

		// Token: 0x06027829 RID: 161833 RVA: 0x0056FA90 File Offset: 0x0056DC90
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

		// Token: 0x0400F150 RID: 61776
		private Table __p;
	}
}
