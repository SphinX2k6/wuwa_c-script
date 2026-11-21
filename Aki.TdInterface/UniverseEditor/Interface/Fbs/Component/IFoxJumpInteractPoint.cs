using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200582C RID: 22572
	public struct IFoxJumpInteractPoint : IFlatbufferObject
	{
		// Token: 0x1700A365 RID: 41829
		// (get) Token: 0x0602488D RID: 149645 RVA: 0x00504F99 File Offset: 0x00503199
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602488E RID: 149646 RVA: 0x00504FA6 File Offset: 0x005031A6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602488F RID: 149647 RVA: 0x00504FB0 File Offset: 0x005031B0
		public static IFoxJumpInteractPoint GetRootAsIFoxJumpInteractPoint(ByteBuffer _bb)
		{
			return IFoxJumpInteractPoint.GetRootAsIFoxJumpInteractPoint(_bb, default(IFoxJumpInteractPoint));
		}

		// Token: 0x06024890 RID: 149648 RVA: 0x00504FCC File Offset: 0x005031CC
		public static IFoxJumpInteractPoint GetRootAsIFoxJumpInteractPoint(ByteBuffer _bb, IFoxJumpInteractPoint obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06024891 RID: 149649 RVA: 0x00504FE9 File Offset: 0x005031E9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06024892 RID: 149650 RVA: 0x00504FF8 File Offset: 0x005031F8
		public IFoxJumpInteractPoint __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A366 RID: 41830
		// (get) Token: 0x06024893 RID: 149651 RVA: 0x00505008 File Offset: 0x00503208
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

		// Token: 0x1700A367 RID: 41831
		// (get) Token: 0x06024894 RID: 149652 RVA: 0x00505044 File Offset: 0x00503244
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

		// Token: 0x06024895 RID: 149653 RVA: 0x00505080 File Offset: 0x00503280
		public IActionInfo? Actions(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A368 RID: 41832
		// (get) Token: 0x06024896 RID: 149654 RVA: 0x005050E0 File Offset: 0x005032E0
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

		// Token: 0x1700A369 RID: 41833
		// (get) Token: 0x06024897 RID: 149655 RVA: 0x0050510C File Offset: 0x0050330C
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

		// Token: 0x06024898 RID: 149656 RVA: 0x0050514C File Offset: 0x0050334C
		public TTable? PositionConfig<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06024899 RID: 149657 RVA: 0x00505194 File Offset: 0x00503394
		public IFoxJumpPositionOnPathDrivenSpawnedActor PositionConfigAsIFoxJumpPositionOnPathDrivenSpawnedActor()
		{
			return this.PositionConfig<IFoxJumpPositionOnPathDrivenSpawnedActor>().Value;
		}

		// Token: 0x0602489A RID: 149658 RVA: 0x005051B0 File Offset: 0x005033B0
		public IFoxJumpPositionOnThisEntity PositionConfigAsIFoxJumpPositionOnThisEntity()
		{
			return this.PositionConfig<IFoxJumpPositionOnThisEntity>().Value;
		}

		// Token: 0x0602489B RID: 149659 RVA: 0x005051CB File Offset: 0x005033CB
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

		// Token: 0x0602489C RID: 149660 RVA: 0x005051FF File Offset: 0x005033FF
		public static void StartIFoxJumpInteractPoint(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0602489D RID: 149661 RVA: 0x00505208 File Offset: 0x00503408
		public static void AddType(FlatBufferBuilder builder, EExploreSkillInteractType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602489E RID: 149662 RVA: 0x00505213 File Offset: 0x00503413
		public static void AddLockConfigId(FlatBufferBuilder builder, int lockConfigId)
		{
			builder.AddInt(1, lockConfigId, 0);
		}

		// Token: 0x0602489F RID: 149663 RVA: 0x0050521E File Offset: 0x0050341E
		public static void AddActions(FlatBufferBuilder builder, VectorOffset actionsOffset)
		{
			builder.AddOffset(2, actionsOffset.Value, 0);
		}

		// Token: 0x060248A0 RID: 149664 RVA: 0x00505230 File Offset: 0x00503430
		public static VectorOffset CreateActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060248A1 RID: 149665 RVA: 0x00505270 File Offset: 0x00503470
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060248A2 RID: 149666 RVA: 0x0050528A File Offset: 0x0050348A
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060248A3 RID: 149667 RVA: 0x005052A8 File Offset: 0x005034A8
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060248A4 RID: 149668 RVA: 0x005052C1 File Offset: 0x005034C1
		public static void StartActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060248A5 RID: 149669 RVA: 0x005052CC File Offset: 0x005034CC
		public static void AddPositionConfigType(FlatBufferBuilder builder, TFoxJumpInteractPointRelationType positionConfigType)
		{
			builder.AddByte(3, (byte)positionConfigType, 0);
		}

		// Token: 0x060248A6 RID: 149670 RVA: 0x005052D7 File Offset: 0x005034D7
		public static void AddPositionConfig(FlatBufferBuilder builder, int positionConfigOffset)
		{
			builder.AddOffset(4, positionConfigOffset, 0);
		}

		// Token: 0x060248A7 RID: 149671 RVA: 0x005052E2 File Offset: 0x005034E2
		public static Offset<IFoxJumpInteractPoint> EndIFoxJumpInteractPoint(FlatBufferBuilder builder)
		{
			return new Offset<IFoxJumpInteractPoint>(builder.EndTable());
		}

		// Token: 0x060248A8 RID: 149672 RVA: 0x005052F0 File Offset: 0x005034F0
		public IFoxJumpInteractPointT UnPack()
		{
			IFoxJumpInteractPointT foxJumpInteractPointT = new IFoxJumpInteractPointT();
			this.UnPackTo(foxJumpInteractPointT);
			return foxJumpInteractPointT;
		}

		// Token: 0x060248A9 RID: 149673 RVA: 0x0050530C File Offset: 0x0050350C
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

		// Token: 0x060248AA RID: 149674 RVA: 0x00505420 File Offset: 0x00503620
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

		// Token: 0x0400F052 RID: 61522
		private Table __p;
	}
}
