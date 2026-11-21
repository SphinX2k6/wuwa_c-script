using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004601 RID: 17921
	public struct ITakePhotoCondition : IFlatbufferObject
	{
		// Token: 0x17007D5B RID: 32091
		// (get) Token: 0x0601A328 RID: 107304 RVA: 0x003BB1DC File Offset: 0x003B93DC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601A329 RID: 107305 RVA: 0x003BB1E9 File Offset: 0x003B93E9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601A32A RID: 107306 RVA: 0x003BB1F0 File Offset: 0x003B93F0
		public static ITakePhotoCondition GetRootAsITakePhotoCondition(ByteBuffer _bb)
		{
			return ITakePhotoCondition.GetRootAsITakePhotoCondition(_bb, default(ITakePhotoCondition));
		}

		// Token: 0x0601A32B RID: 107307 RVA: 0x003BB20C File Offset: 0x003B940C
		public static ITakePhotoCondition GetRootAsITakePhotoCondition(ByteBuffer _bb, ITakePhotoCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601A32C RID: 107308 RVA: 0x003BB229 File Offset: 0x003B9429
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601A32D RID: 107309 RVA: 0x003BB238 File Offset: 0x003B9438
		public ITakePhotoCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007D5C RID: 32092
		// (get) Token: 0x0601A32E RID: 107310 RVA: 0x003BB248 File Offset: 0x003B9448
		public EChildQuest Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EChildQuest.DoInteract;
				}
				return (EChildQuest)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007D5D RID: 32093
		// (get) Token: 0x0601A32F RID: 107311 RVA: 0x003BB284 File Offset: 0x003B9484
		public IConditionGroup? PreConditions
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IConditionGroup?(default(IConditionGroup).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17007D5E RID: 32094
		// (get) Token: 0x0601A330 RID: 107312 RVA: 0x003BB2E4 File Offset: 0x003B94E4
		public ITakePhotoTimeCondition? TimeCondition
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new ITakePhotoTimeCondition?(default(ITakePhotoTimeCondition).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17007D5F RID: 32095
		// (get) Token: 0x0601A331 RID: 107313 RVA: 0x003BB344 File Offset: 0x003B9544
		public ITakePhotoPosCondition? PosCondition
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new ITakePhotoPosCondition?(default(ITakePhotoPosCondition).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0601A332 RID: 107314 RVA: 0x003BB3A4 File Offset: 0x003B95A4
		public IPhotoTarget? PhotoTargets(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new IPhotoTarget?(default(IPhotoTarget).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17007D60 RID: 32096
		// (get) Token: 0x0601A333 RID: 107315 RVA: 0x003BB408 File Offset: 0x003B9608
		public int PhotoTargetsLength
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0601A334 RID: 107316 RVA: 0x003BB434 File Offset: 0x003B9634
		public static Offset<ITakePhotoCondition> CreateITakePhotoCondition(FlatBufferBuilder builder, EChildQuest Type = EChildQuest.DoInteract, Offset<IConditionGroup> PreConditionsOffset = default(Offset<IConditionGroup>), Offset<ITakePhotoTimeCondition> TimeConditionOffset = default(Offset<ITakePhotoTimeCondition>), Offset<ITakePhotoPosCondition> PosConditionOffset = default(Offset<ITakePhotoPosCondition>), VectorOffset PhotoTargetsOffset = default(VectorOffset))
		{
			builder.StartTable(5);
			ITakePhotoCondition.AddPhotoTargets(builder, PhotoTargetsOffset);
			ITakePhotoCondition.AddPosCondition(builder, PosConditionOffset);
			ITakePhotoCondition.AddTimeCondition(builder, TimeConditionOffset);
			ITakePhotoCondition.AddPreConditions(builder, PreConditionsOffset);
			ITakePhotoCondition.AddType(builder, Type);
			return ITakePhotoCondition.EndITakePhotoCondition(builder);
		}

		// Token: 0x0601A335 RID: 107317 RVA: 0x003BB468 File Offset: 0x003B9668
		public static void StartITakePhotoCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0601A336 RID: 107318 RVA: 0x003BB471 File Offset: 0x003B9671
		public static void AddType(FlatBufferBuilder builder, EChildQuest type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601A337 RID: 107319 RVA: 0x003BB47C File Offset: 0x003B967C
		public static void AddPreConditions(FlatBufferBuilder builder, Offset<IConditionGroup> preConditionsOffset)
		{
			builder.AddOffset(1, preConditionsOffset.Value, 0);
		}

		// Token: 0x0601A338 RID: 107320 RVA: 0x003BB48C File Offset: 0x003B968C
		public static void AddTimeCondition(FlatBufferBuilder builder, Offset<ITakePhotoTimeCondition> timeConditionOffset)
		{
			builder.AddOffset(2, timeConditionOffset.Value, 0);
		}

		// Token: 0x0601A339 RID: 107321 RVA: 0x003BB49C File Offset: 0x003B969C
		public static void AddPosCondition(FlatBufferBuilder builder, Offset<ITakePhotoPosCondition> posConditionOffset)
		{
			builder.AddOffset(3, posConditionOffset.Value, 0);
		}

		// Token: 0x0601A33A RID: 107322 RVA: 0x003BB4AC File Offset: 0x003B96AC
		public static void AddPhotoTargets(FlatBufferBuilder builder, VectorOffset photoTargetsOffset)
		{
			builder.AddOffset(4, photoTargetsOffset.Value, 0);
		}

		// Token: 0x0601A33B RID: 107323 RVA: 0x003BB4BC File Offset: 0x003B96BC
		public static VectorOffset CreatePhotoTargetsVector(FlatBufferBuilder builder, Offset<IPhotoTarget>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601A33C RID: 107324 RVA: 0x003BB4FC File Offset: 0x003B96FC
		public static VectorOffset CreatePhotoTargetsVectorBlock(FlatBufferBuilder builder, Offset<IPhotoTarget>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IPhotoTarget>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601A33D RID: 107325 RVA: 0x003BB516 File Offset: 0x003B9716
		public static VectorOffset CreatePhotoTargetsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IPhotoTarget>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IPhotoTarget>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601A33E RID: 107326 RVA: 0x003BB534 File Offset: 0x003B9734
		public static VectorOffset CreatePhotoTargetsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IPhotoTarget>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601A33F RID: 107327 RVA: 0x003BB54D File Offset: 0x003B974D
		public static void StartPhotoTargetsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601A340 RID: 107328 RVA: 0x003BB558 File Offset: 0x003B9758
		public static Offset<ITakePhotoCondition> EndITakePhotoCondition(FlatBufferBuilder builder)
		{
			return new Offset<ITakePhotoCondition>(builder.EndTable());
		}

		// Token: 0x0601A341 RID: 107329 RVA: 0x003BB568 File Offset: 0x003B9768
		public ITakePhotoConditionT UnPack()
		{
			ITakePhotoConditionT takePhotoConditionT = new ITakePhotoConditionT();
			this.UnPackTo(takePhotoConditionT);
			return takePhotoConditionT;
		}

		// Token: 0x0601A342 RID: 107330 RVA: 0x003BB584 File Offset: 0x003B9784
		public void UnPackTo(ITakePhotoConditionT _o)
		{
			_o.Type = this.Type;
			_o.PreConditions = ((this.PreConditions != null) ? this.PreConditions.Value.UnPack() : null);
			_o.TimeCondition = ((this.TimeCondition != null) ? this.TimeCondition.Value.UnPack() : null);
			_o.PosCondition = ((this.PosCondition != null) ? this.PosCondition.Value.UnPack() : null);
			_o.PhotoTargets = new List<IPhotoTargetT>();
			for (int i = 0; i < this.PhotoTargetsLength; i++)
			{
				_o.PhotoTargets.Add((this.PhotoTargets(i) != null) ? this.PhotoTargets(i).Value.UnPack() : null);
			}
		}

		// Token: 0x0601A343 RID: 107331 RVA: 0x003BB688 File Offset: 0x003B9888
		public static Offset<ITakePhotoCondition> Pack(FlatBufferBuilder builder, ITakePhotoConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITakePhotoCondition>);
			}
			Offset<IConditionGroup> preConditionsOffset = (_o.PreConditions == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.PreConditions);
			Offset<ITakePhotoTimeCondition> timeConditionOffset = (_o.TimeCondition == null) ? default(Offset<ITakePhotoTimeCondition>) : ITakePhotoTimeCondition.Pack(builder, _o.TimeCondition);
			Offset<ITakePhotoPosCondition> posConditionOffset = (_o.PosCondition == null) ? default(Offset<ITakePhotoPosCondition>) : ITakePhotoPosCondition.Pack(builder, _o.PosCondition);
			VectorOffset photoTargetsOffset = default(VectorOffset);
			if (_o.PhotoTargets != null)
			{
				Offset<IPhotoTarget>[] array = new Offset<IPhotoTarget>[_o.PhotoTargets.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IPhotoTarget.Pack(builder, _o.PhotoTargets[i]);
				}
				photoTargetsOffset = ITakePhotoCondition.CreatePhotoTargetsVector(builder, array);
			}
			return ITakePhotoCondition.CreateITakePhotoCondition(builder, _o.Type, preConditionsOffset, timeConditionOffset, posConditionOffset, photoTargetsOffset);
		}

		// Token: 0x0400C7EF RID: 51183
		private Table __p;
	}
}
