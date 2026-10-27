using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020041A8 RID: 16808
	public struct ITakePhotoCondition : IFlatbufferObject
	{
		// Token: 0x1700772F RID: 30511
		// (get) Token: 0x06018BD2 RID: 101330 RVA: 0x0038FD88 File Offset: 0x0038DF88
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06018BD3 RID: 101331 RVA: 0x0038FD95 File Offset: 0x0038DF95
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06018BD4 RID: 101332 RVA: 0x0038FD9C File Offset: 0x0038DF9C
		public static ITakePhotoCondition GetRootAsITakePhotoCondition(ByteBuffer _bb)
		{
			return ITakePhotoCondition.GetRootAsITakePhotoCondition(_bb, default(ITakePhotoCondition));
		}

		// Token: 0x06018BD5 RID: 101333 RVA: 0x0038FDB8 File Offset: 0x0038DFB8
		public static ITakePhotoCondition GetRootAsITakePhotoCondition(ByteBuffer _bb, ITakePhotoCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06018BD6 RID: 101334 RVA: 0x0038FDD5 File Offset: 0x0038DFD5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06018BD7 RID: 101335 RVA: 0x0038FDE4 File Offset: 0x0038DFE4
		public ITakePhotoCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007730 RID: 30512
		// (get) Token: 0x06018BD8 RID: 101336 RVA: 0x0038FDF4 File Offset: 0x0038DFF4
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

		// Token: 0x17007731 RID: 30513
		// (get) Token: 0x06018BD9 RID: 101337 RVA: 0x0038FE30 File Offset: 0x0038E030
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

		// Token: 0x17007732 RID: 30514
		// (get) Token: 0x06018BDA RID: 101338 RVA: 0x0038FE90 File Offset: 0x0038E090
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

		// Token: 0x17007733 RID: 30515
		// (get) Token: 0x06018BDB RID: 101339 RVA: 0x0038FEF0 File Offset: 0x0038E0F0
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

		// Token: 0x06018BDC RID: 101340 RVA: 0x0038FF50 File Offset: 0x0038E150
		public IPhotoTarget? PhotoTargets(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new IPhotoTarget?(default(IPhotoTarget).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17007734 RID: 30516
		// (get) Token: 0x06018BDD RID: 101341 RVA: 0x0038FFB4 File Offset: 0x0038E1B4
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

		// Token: 0x06018BDE RID: 101342 RVA: 0x0038FFE0 File Offset: 0x0038E1E0
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

		// Token: 0x06018BDF RID: 101343 RVA: 0x00390014 File Offset: 0x0038E214
		public static void StartITakePhotoCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06018BE0 RID: 101344 RVA: 0x0039001D File Offset: 0x0038E21D
		public static void AddType(FlatBufferBuilder builder, EChildQuest type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06018BE1 RID: 101345 RVA: 0x00390028 File Offset: 0x0038E228
		public static void AddPreConditions(FlatBufferBuilder builder, Offset<IConditionGroup> preConditionsOffset)
		{
			builder.AddOffset(1, preConditionsOffset.Value, 0);
		}

		// Token: 0x06018BE2 RID: 101346 RVA: 0x00390038 File Offset: 0x0038E238
		public static void AddTimeCondition(FlatBufferBuilder builder, Offset<ITakePhotoTimeCondition> timeConditionOffset)
		{
			builder.AddOffset(2, timeConditionOffset.Value, 0);
		}

		// Token: 0x06018BE3 RID: 101347 RVA: 0x00390048 File Offset: 0x0038E248
		public static void AddPosCondition(FlatBufferBuilder builder, Offset<ITakePhotoPosCondition> posConditionOffset)
		{
			builder.AddOffset(3, posConditionOffset.Value, 0);
		}

		// Token: 0x06018BE4 RID: 101348 RVA: 0x00390058 File Offset: 0x0038E258
		public static void AddPhotoTargets(FlatBufferBuilder builder, VectorOffset photoTargetsOffset)
		{
			builder.AddOffset(4, photoTargetsOffset.Value, 0);
		}

		// Token: 0x06018BE5 RID: 101349 RVA: 0x00390068 File Offset: 0x0038E268
		public static VectorOffset CreatePhotoTargetsVector(FlatBufferBuilder builder, Offset<IPhotoTarget>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06018BE6 RID: 101350 RVA: 0x003900A8 File Offset: 0x0038E2A8
		public static VectorOffset CreatePhotoTargetsVectorBlock(FlatBufferBuilder builder, Offset<IPhotoTarget>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IPhotoTarget>>(data);
			return builder.EndVector();
		}

		// Token: 0x06018BE7 RID: 101351 RVA: 0x003900C2 File Offset: 0x0038E2C2
		public static VectorOffset CreatePhotoTargetsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IPhotoTarget>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IPhotoTarget>>(data);
			return builder.EndVector();
		}

		// Token: 0x06018BE8 RID: 101352 RVA: 0x003900E0 File Offset: 0x0038E2E0
		public static VectorOffset CreatePhotoTargetsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IPhotoTarget>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06018BE9 RID: 101353 RVA: 0x003900F9 File Offset: 0x0038E2F9
		public static void StartPhotoTargetsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06018BEA RID: 101354 RVA: 0x00390104 File Offset: 0x0038E304
		public static Offset<ITakePhotoCondition> EndITakePhotoCondition(FlatBufferBuilder builder)
		{
			return new Offset<ITakePhotoCondition>(builder.EndTable());
		}

		// Token: 0x06018BEB RID: 101355 RVA: 0x00390114 File Offset: 0x0038E314
		public ITakePhotoConditionT UnPack()
		{
			ITakePhotoConditionT takePhotoConditionT = new ITakePhotoConditionT();
			this.UnPackTo(takePhotoConditionT);
			return takePhotoConditionT;
		}

		// Token: 0x06018BEC RID: 101356 RVA: 0x00390130 File Offset: 0x0038E330
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

		// Token: 0x06018BED RID: 101357 RVA: 0x00390234 File Offset: 0x0038E434
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

		// Token: 0x0400BDE5 RID: 48613
		private Table __p;
	}
}
