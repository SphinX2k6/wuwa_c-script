using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003FDA RID: 16346
	public struct IQuestFailedConditionEntityAlert : IFlatbufferObject
	{
		// Token: 0x170072BB RID: 29371
		// (get) Token: 0x06017851 RID: 96337 RVA: 0x003649CB File Offset: 0x00362BCB
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06017852 RID: 96338 RVA: 0x003649D8 File Offset: 0x00362BD8
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06017853 RID: 96339 RVA: 0x003649E0 File Offset: 0x00362BE0
		public static IQuestFailedConditionEntityAlert GetRootAsIQuestFailedConditionEntityAlert(ByteBuffer _bb)
		{
			return IQuestFailedConditionEntityAlert.GetRootAsIQuestFailedConditionEntityAlert(_bb, default(IQuestFailedConditionEntityAlert));
		}

		// Token: 0x06017854 RID: 96340 RVA: 0x003649FC File Offset: 0x00362BFC
		public static IQuestFailedConditionEntityAlert GetRootAsIQuestFailedConditionEntityAlert(ByteBuffer _bb, IQuestFailedConditionEntityAlert obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06017855 RID: 96341 RVA: 0x00364A19 File Offset: 0x00362C19
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06017856 RID: 96342 RVA: 0x00364A28 File Offset: 0x00362C28
		public IQuestFailedConditionEntityAlert __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x06017857 RID: 96343 RVA: 0x00364A38 File Offset: 0x00362C38
		public int EntityIds(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170072BC RID: 29372
		// (get) Token: 0x06017858 RID: 96344 RVA: 0x00364A78 File Offset: 0x00362C78
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

		// Token: 0x06017859 RID: 96345 RVA: 0x00364AA3 File Offset: 0x00362CA3
		public Span<int> GetEntityIdsBytes()
		{
			return this.__p.__vector_as_span<int>(4, 4);
		}

		// Token: 0x0601785A RID: 96346 RVA: 0x00364AB2 File Offset: 0x00362CB2
		public int[] GetEntityIdsArray()
		{
			return this.__p.__vector_as_array<int>(4);
		}

		// Token: 0x0601785B RID: 96347 RVA: 0x00364AC0 File Offset: 0x00362CC0
		public static Offset<IQuestFailedConditionEntityAlert> CreateIQuestFailedConditionEntityAlert(FlatBufferBuilder builder, VectorOffset EntityIdsOffset = default(VectorOffset))
		{
			builder.StartTable(1);
			IQuestFailedConditionEntityAlert.AddEntityIds(builder, EntityIdsOffset);
			return IQuestFailedConditionEntityAlert.EndIQuestFailedConditionEntityAlert(builder);
		}

		// Token: 0x0601785C RID: 96348 RVA: 0x00364AD6 File Offset: 0x00362CD6
		public static void StartIQuestFailedConditionEntityAlert(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601785D RID: 96349 RVA: 0x00364ADF File Offset: 0x00362CDF
		public static void AddEntityIds(FlatBufferBuilder builder, VectorOffset entityIdsOffset)
		{
			builder.AddOffset(0, entityIdsOffset.Value, 0);
		}

		// Token: 0x0601785E RID: 96350 RVA: 0x00364AF0 File Offset: 0x00362CF0
		public static VectorOffset CreateEntityIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601785F RID: 96351 RVA: 0x00364B27 File Offset: 0x00362D27
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06017860 RID: 96352 RVA: 0x00364B41 File Offset: 0x00362D41
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06017861 RID: 96353 RVA: 0x00364B5F File Offset: 0x00362D5F
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06017862 RID: 96354 RVA: 0x00364B78 File Offset: 0x00362D78
		public static void StartEntityIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06017863 RID: 96355 RVA: 0x00364B83 File Offset: 0x00362D83
		public static Offset<IQuestFailedConditionEntityAlert> EndIQuestFailedConditionEntityAlert(FlatBufferBuilder builder)
		{
			return new Offset<IQuestFailedConditionEntityAlert>(builder.EndTable());
		}

		// Token: 0x06017864 RID: 96356 RVA: 0x00364B90 File Offset: 0x00362D90
		public IQuestFailedConditionEntityAlertT UnPack()
		{
			IQuestFailedConditionEntityAlertT questFailedConditionEntityAlertT = new IQuestFailedConditionEntityAlertT();
			this.UnPackTo(questFailedConditionEntityAlertT);
			return questFailedConditionEntityAlertT;
		}

		// Token: 0x06017865 RID: 96357 RVA: 0x00364BAC File Offset: 0x00362DAC
		public void UnPackTo(IQuestFailedConditionEntityAlertT _o)
		{
			_o.EntityIds = new List<int>();
			for (int i = 0; i < this.EntityIdsLength; i++)
			{
				_o.EntityIds.Add(this.EntityIds(i));
			}
		}

		// Token: 0x06017866 RID: 96358 RVA: 0x00364BE8 File Offset: 0x00362DE8
		public static Offset<IQuestFailedConditionEntityAlert> Pack(FlatBufferBuilder builder, IQuestFailedConditionEntityAlertT _o)
		{
			if (_o == null)
			{
				return default(Offset<IQuestFailedConditionEntityAlert>);
			}
			VectorOffset entityIdsOffset = default(VectorOffset);
			if (_o.EntityIds != null)
			{
				int[] data = _o.EntityIds.ToArray();
				entityIdsOffset = IQuestFailedConditionEntityAlert.CreateEntityIdsVector(builder, data);
			}
			return IQuestFailedConditionEntityAlert.CreateIQuestFailedConditionEntityAlert(builder, entityIdsOffset);
		}

		// Token: 0x0400BADC RID: 47836
		private Table __p;
	}
}
