using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020052C1 RID: 21185
	public struct IFoxJumpInteractPoint : IFlatbufferObject
	{
		// Token: 0x17009B5C RID: 39772
		// (get) Token: 0x060228C9 RID: 141513 RVA: 0x004C9E9D File Offset: 0x004C809D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060228CA RID: 141514 RVA: 0x004C9EAA File Offset: 0x004C80AA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060228CB RID: 141515 RVA: 0x004C9EB4 File Offset: 0x004C80B4
		public static IFoxJumpInteractPoint GetRootAsIFoxJumpInteractPoint(ByteBuffer _bb)
		{
			return IFoxJumpInteractPoint.GetRootAsIFoxJumpInteractPoint(_bb, default(IFoxJumpInteractPoint));
		}

		// Token: 0x060228CC RID: 141516 RVA: 0x004C9ED0 File Offset: 0x004C80D0
		public static IFoxJumpInteractPoint GetRootAsIFoxJumpInteractPoint(ByteBuffer _bb, IFoxJumpInteractPoint obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060228CD RID: 141517 RVA: 0x004C9EED File Offset: 0x004C80ED
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060228CE RID: 141518 RVA: 0x004C9EFC File Offset: 0x004C80FC
		public IFoxJumpInteractPoint __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009B5D RID: 39773
		// (get) Token: 0x060228CF RID: 141519 RVA: 0x004C9F0C File Offset: 0x004C810C
		public EExploreSkillInteractType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EExploreSkillInteractType.PullGiant;
				}
				return (EExploreSkillInteractType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009B5E RID: 39774
		// (get) Token: 0x060228D0 RID: 141520 RVA: 0x004C9F48 File Offset: 0x004C8148
		public int LockConfigId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060228D1 RID: 141521 RVA: 0x004C9F84 File Offset: 0x004C8184
		public IActionInfo? Actions(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009B5F RID: 39775
		// (get) Token: 0x060228D2 RID: 141522 RVA: 0x004C9FE4 File Offset: 0x004C81E4
		public int ActionsLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17009B60 RID: 39776
		// (get) Token: 0x060228D3 RID: 141523 RVA: 0x004CA010 File Offset: 0x004C8210
		public TFoxJumpInteractPointRelationType PositionConfigType
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return TFoxJumpInteractPointRelationType.NONE;
				}
				return (TFoxJumpInteractPointRelationType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060228D4 RID: 141524 RVA: 0x004CA050 File Offset: 0x004C8250
		public TTable? PositionConfig<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060228D5 RID: 141525 RVA: 0x004CA098 File Offset: 0x004C8298
		public IFoxJumpPositionOnPathDrivenSpawnedActor PositionConfigAsIFoxJumpPositionOnPathDrivenSpawnedActor()
		{
			return this.PositionConfig<IFoxJumpPositionOnPathDrivenSpawnedActor>().Value;
		}

		// Token: 0x060228D6 RID: 141526 RVA: 0x004CA0B4 File Offset: 0x004C82B4
		public IFoxJumpPositionOnThisEntity PositionConfigAsIFoxJumpPositionOnThisEntity()
		{
			return this.PositionConfig<IFoxJumpPositionOnThisEntity>().Value;
		}

		// Token: 0x060228D7 RID: 141527 RVA: 0x004CA0CF File Offset: 0x004C82CF
		public static Offset<IFoxJumpInteractPoint> CreateIFoxJumpInteractPoint(FlatBufferBuilder builder, EExploreSkillInteractType Type = EExploreSkillInteractType.PullGiant, int LockConfigId = 0, VectorOffset ActionsOffset = default(VectorOffset), TFoxJumpInteractPointRelationType PositionConfig_type = TFoxJumpInteractPointRelationType.NONE, int PositionConfigOffset = 0)
		{
			builder.StartTable(5);
			IFoxJumpInteractPoint.AddPositionConfig(builder, PositionConfigOffset);
			IFoxJumpInteractPoint.AddActions(builder, ActionsOffset);
			IFoxJumpInteractPoint.AddLockConfigId(builder, LockConfigId);
			IFoxJumpInteractPoint.AddPositionConfigType(builder, PositionConfig_type);
			IFoxJumpInteractPoint.AddType(builder, Type);
			return IFoxJumpInteractPoint.EndIFoxJumpInteractPoint(builder);
		}

		// Token: 0x060228D8 RID: 141528 RVA: 0x004CA103 File Offset: 0x004C8303
		public static void StartIFoxJumpInteractPoint(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x060228D9 RID: 141529 RVA: 0x004CA10C File Offset: 0x004C830C
		public static void AddType(FlatBufferBuilder builder, EExploreSkillInteractType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060228DA RID: 141530 RVA: 0x004CA117 File Offset: 0x004C8317
		public static void AddLockConfigId(FlatBufferBuilder builder, int lockConfigId)
		{
			builder.AddInt(1, lockConfigId, 0);
		}

		// Token: 0x060228DB RID: 141531 RVA: 0x004CA122 File Offset: 0x004C8322
		public static void AddActions(FlatBufferBuilder builder, VectorOffset actionsOffset)
		{
			builder.AddOffset(2, actionsOffset.Value, 0);
		}

		// Token: 0x060228DC RID: 141532 RVA: 0x004CA134 File Offset: 0x004C8334
		public static VectorOffset CreateActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060228DD RID: 141533 RVA: 0x004CA174 File Offset: 0x004C8374
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060228DE RID: 141534 RVA: 0x004CA18E File Offset: 0x004C838E
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060228DF RID: 141535 RVA: 0x004CA1AC File Offset: 0x004C83AC
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060228E0 RID: 141536 RVA: 0x004CA1C5 File Offset: 0x004C83C5
		public static void StartActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060228E1 RID: 141537 RVA: 0x004CA1D0 File Offset: 0x004C83D0
		public static void AddPositionConfigType(FlatBufferBuilder builder, TFoxJumpInteractPointRelationType positionConfigType)
		{
			builder.AddByte(3, (byte)positionConfigType, 0);
		}

		// Token: 0x060228E2 RID: 141538 RVA: 0x004CA1DB File Offset: 0x004C83DB
		public static void AddPositionConfig(FlatBufferBuilder builder, int positionConfigOffset)
		{
			builder.AddOffset(4, positionConfigOffset, 0);
		}

		// Token: 0x060228E3 RID: 141539 RVA: 0x004CA1E6 File Offset: 0x004C83E6
		public static Offset<IFoxJumpInteractPoint> EndIFoxJumpInteractPoint(FlatBufferBuilder builder)
		{
			return new Offset<IFoxJumpInteractPoint>(builder.EndTable());
		}

		// Token: 0x060228E4 RID: 141540 RVA: 0x004CA1F4 File Offset: 0x004C83F4
		public IFoxJumpInteractPointT UnPack()
		{
			IFoxJumpInteractPointT foxJumpInteractPointT = new IFoxJumpInteractPointT();
			this.UnPackTo(foxJumpInteractPointT);
			return foxJumpInteractPointT;
		}

		// Token: 0x060228E5 RID: 141541 RVA: 0x004CA210 File Offset: 0x004C8410
		public void UnPackTo(IFoxJumpInteractPointT _o)
		{
			_o.Type = this.Type;
			_o.LockConfigId = this.LockConfigId;
			_o.Actions = new List<IActionInfoT>();
			for (int i = 0; i < this.ActionsLength; i++)
			{
				_o.Actions.Add((this.Actions(i) != null) ? this.Actions(i).Value.UnPack() : null);
			}
			_o.PositionConfig = new TFoxJumpInteractPointRelationTypeUnion();
			_o.PositionConfig.Type = this.PositionConfigType;
			TFoxJumpInteractPointRelationType positionConfigType = this.PositionConfigType;
			if (positionConfigType == TFoxJumpInteractPointRelationType.IFoxJumpPositionOnPathDrivenSpawnedActor)
			{
				_o.PositionConfig.Value = ((this.PositionConfig<IFoxJumpPositionOnPathDrivenSpawnedActor>() != null) ? this.PositionConfig<IFoxJumpPositionOnPathDrivenSpawnedActor>().Value.UnPack() : null);
				return;
			}
			if (positionConfigType != TFoxJumpInteractPointRelationType.IFoxJumpPositionOnThisEntity)
			{
				return;
			}
			_o.PositionConfig.Value = ((this.PositionConfig<IFoxJumpPositionOnThisEntity>() != null) ? this.PositionConfig<IFoxJumpPositionOnThisEntity>().Value.UnPack() : null);
		}

		// Token: 0x060228E6 RID: 141542 RVA: 0x004CA324 File Offset: 0x004C8524
		public static Offset<IFoxJumpInteractPoint> Pack(FlatBufferBuilder builder, IFoxJumpInteractPointT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFoxJumpInteractPoint>);
			}
			VectorOffset actionsOffset = default(VectorOffset);
			if (_o.Actions != null)
			{
				Offset<IActionInfo>[] array = new Offset<IActionInfo>[_o.Actions.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IActionInfo.Pack(builder, _o.Actions[i]);
				}
				actionsOffset = IFoxJumpInteractPoint.CreateActionsVector(builder, array);
			}
			TFoxJumpInteractPointRelationType positionConfig_type = (_o.PositionConfig == null) ? TFoxJumpInteractPointRelationType.NONE : _o.PositionConfig.Type;
			int positionConfigOffset = (_o.PositionConfig == null) ? 0 : TFoxJumpInteractPointRelationTypeUnion.Pack(builder, _o.PositionConfig);
			return IFoxJumpInteractPoint.CreateIFoxJumpInteractPoint(builder, _o.Type, _o.LockConfigId, actionsOffset, positionConfig_type, positionConfigOffset);
		}

		// Token: 0x0400E445 RID: 58437
		private Table __p;
	}
}
