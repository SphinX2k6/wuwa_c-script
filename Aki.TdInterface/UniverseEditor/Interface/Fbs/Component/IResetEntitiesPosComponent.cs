using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Shape;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005E6B RID: 24171
	public struct IResetEntitiesPosComponent : IFlatbufferObject
	{
		// Token: 0x1700B248 RID: 45640
		// (get) Token: 0x060286C3 RID: 165571 RVA: 0x00586DCF File Offset: 0x00584FCF
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060286C4 RID: 165572 RVA: 0x00586DDC File Offset: 0x00584FDC
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060286C5 RID: 165573 RVA: 0x00586DE4 File Offset: 0x00584FE4
		public static IResetEntitiesPosComponent GetRootAsIResetEntitiesPosComponent(ByteBuffer _bb)
		{
			return IResetEntitiesPosComponent.GetRootAsIResetEntitiesPosComponent(_bb, default(IResetEntitiesPosComponent));
		}

		// Token: 0x060286C6 RID: 165574 RVA: 0x00586E00 File Offset: 0x00585000
		public static IResetEntitiesPosComponent GetRootAsIResetEntitiesPosComponent(ByteBuffer _bb, IResetEntitiesPosComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060286C7 RID: 165575 RVA: 0x00586E1D File Offset: 0x0058501D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060286C8 RID: 165576 RVA: 0x00586E2C File Offset: 0x0058502C
		public IResetEntitiesPosComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B249 RID: 45641
		// (get) Token: 0x060286C9 RID: 165577 RVA: 0x00586E3C File Offset: 0x0058503C
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B24A RID: 45642
		// (get) Token: 0x060286CA RID: 165578 RVA: 0x00586E7C File Offset: 0x0058507C
		public TTriggerShape RangeType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TTriggerShape.NONE;
				}
				return (TTriggerShape)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060286CB RID: 165579 RVA: 0x00586EB8 File Offset: 0x005850B8
		public TTable? Range<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060286CC RID: 165580 RVA: 0x00586EFC File Offset: 0x005850FC
		public IActorCollisionTriggerShape RangeAsIActorCollisionTriggerShape()
		{
			return this.Range<IActorCollisionTriggerShape>().Value;
		}

		// Token: 0x060286CD RID: 165581 RVA: 0x00586F18 File Offset: 0x00585118
		public IActorRefVolume RangeAsIActorRefVolume()
		{
			return this.Range<IActorRefVolume>().Value;
		}

		// Token: 0x060286CE RID: 165582 RVA: 0x00586F34 File Offset: 0x00585134
		public IBoxTriggerShape RangeAsIBoxTriggerShape()
		{
			return this.Range<IBoxTriggerShape>().Value;
		}

		// Token: 0x060286CF RID: 165583 RVA: 0x00586F50 File Offset: 0x00585150
		public ICombinationTriggerShape RangeAsICombinationTriggerShape()
		{
			return this.Range<ICombinationTriggerShape>().Value;
		}

		// Token: 0x060286D0 RID: 165584 RVA: 0x00586F6C File Offset: 0x0058516C
		public IConeTriggerShape RangeAsIConeTriggerShape()
		{
			return this.Range<IConeTriggerShape>().Value;
		}

		// Token: 0x060286D1 RID: 165585 RVA: 0x00586F88 File Offset: 0x00585188
		public ICylinderTriggerShape RangeAsICylinderTriggerShape()
		{
			return this.Range<ICylinderTriggerShape>().Value;
		}

		// Token: 0x060286D2 RID: 165586 RVA: 0x00586FA4 File Offset: 0x005851A4
		public IHollowCylinderTriggerShape RangeAsIHollowCylinderTriggerShape()
		{
			return this.Range<IHollowCylinderTriggerShape>().Value;
		}

		// Token: 0x060286D3 RID: 165587 RVA: 0x00586FC0 File Offset: 0x005851C0
		public IHollowSphereTriggerShape RangeAsIHollowSphereTriggerShape()
		{
			return this.Range<IHollowSphereTriggerShape>().Value;
		}

		// Token: 0x060286D4 RID: 165588 RVA: 0x00586FDC File Offset: 0x005851DC
		public ISphereTriggerShape RangeAsISphereTriggerShape()
		{
			return this.Range<ISphereTriggerShape>().Value;
		}

		// Token: 0x060286D5 RID: 165589 RVA: 0x00586FF8 File Offset: 0x005851F8
		public ISpotlightTriggerShape RangeAsISpotlightTriggerShape()
		{
			return this.Range<ISpotlightTriggerShape>().Value;
		}

		// Token: 0x060286D6 RID: 165590 RVA: 0x00587014 File Offset: 0x00585214
		public IVolumeTriggerShape RangeAsIVolumeTriggerShape()
		{
			return this.Range<IVolumeTriggerShape>().Value;
		}

		// Token: 0x060286D7 RID: 165591 RVA: 0x00587030 File Offset: 0x00585230
		public int EntityIds(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700B24B RID: 45643
		// (get) Token: 0x060286D8 RID: 165592 RVA: 0x00587070 File Offset: 0x00585270
		public int EntityIdsLength
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060286D9 RID: 165593 RVA: 0x0058709C File Offset: 0x0058529C
		public Span<int> GetEntityIdsBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x060286DA RID: 165594 RVA: 0x005870AC File Offset: 0x005852AC
		public int[] GetEntityIdsArray()
		{
			return this.__p.__vector_as_array<int>(10);
		}

		// Token: 0x1700B24C RID: 45644
		// (get) Token: 0x060286DB RID: 165595 RVA: 0x005870BC File Offset: 0x005852BC
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060286DC RID: 165596 RVA: 0x005870F9 File Offset: 0x005852F9
		public static Offset<IResetEntitiesPosComponent> CreateIResetEntitiesPosComponent(FlatBufferBuilder builder, bool Disabled = false, TTriggerShape Range_type = TTriggerShape.NONE, int RangeOffset = 0, VectorOffset EntityIdsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(5);
			IResetEntitiesPosComponent.AddEntityIds(builder, EntityIdsOffset);
			IResetEntitiesPosComponent.AddRange(builder, RangeOffset);
			IResetEntitiesPosComponent.AddNullMask(builder, NullMask);
			IResetEntitiesPosComponent.AddRangeType(builder, Range_type);
			IResetEntitiesPosComponent.AddDisabled(builder, Disabled);
			return IResetEntitiesPosComponent.EndIResetEntitiesPosComponent(builder);
		}

		// Token: 0x060286DD RID: 165597 RVA: 0x0058712D File Offset: 0x0058532D
		public static void StartIResetEntitiesPosComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x060286DE RID: 165598 RVA: 0x00587136 File Offset: 0x00585336
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x060286DF RID: 165599 RVA: 0x00587141 File Offset: 0x00585341
		public static void AddRangeType(FlatBufferBuilder builder, TTriggerShape rangeType)
		{
			builder.AddByte(1, (byte)rangeType, 0);
		}

		// Token: 0x060286E0 RID: 165600 RVA: 0x0058714C File Offset: 0x0058534C
		public static void AddRange(FlatBufferBuilder builder, int rangeOffset)
		{
			builder.AddOffset(2, rangeOffset, 0);
		}

		// Token: 0x060286E1 RID: 165601 RVA: 0x00587157 File Offset: 0x00585357
		public static void AddEntityIds(FlatBufferBuilder builder, VectorOffset entityIdsOffset)
		{
			builder.AddOffset(3, entityIdsOffset.Value, 0);
		}

		// Token: 0x060286E2 RID: 165602 RVA: 0x00587168 File Offset: 0x00585368
		public static VectorOffset CreateEntityIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x060286E3 RID: 165603 RVA: 0x0058719F File Offset: 0x0058539F
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060286E4 RID: 165604 RVA: 0x005871B9 File Offset: 0x005853B9
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060286E5 RID: 165605 RVA: 0x005871D7 File Offset: 0x005853D7
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060286E6 RID: 165606 RVA: 0x005871F0 File Offset: 0x005853F0
		public static void StartEntityIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060286E7 RID: 165607 RVA: 0x005871FB File Offset: 0x005853FB
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x060286E8 RID: 165608 RVA: 0x00587206 File Offset: 0x00585406
		public static Offset<IResetEntitiesPosComponent> EndIResetEntitiesPosComponent(FlatBufferBuilder builder)
		{
			return new Offset<IResetEntitiesPosComponent>(builder.EndTable());
		}

		// Token: 0x060286E9 RID: 165609 RVA: 0x00587214 File Offset: 0x00585414
		public IResetEntitiesPosComponentT UnPack()
		{
			IResetEntitiesPosComponentT resetEntitiesPosComponentT = new IResetEntitiesPosComponentT();
			this.UnPackTo(resetEntitiesPosComponentT);
			return resetEntitiesPosComponentT;
		}

		// Token: 0x060286EA RID: 165610 RVA: 0x00587230 File Offset: 0x00585430
		public void UnPackTo(IResetEntitiesPosComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.Range = new TTriggerShapeUnion();
			_o.Range.Type = this.RangeType;
			switch (this.RangeType)
			{
			case TTriggerShape.IActorCollisionTriggerShape:
				_o.Range.Value = ((this.Range<IActorCollisionTriggerShape>() != null) ? this.Range<IActorCollisionTriggerShape>().Value.UnPack() : null);
				break;
			case TTriggerShape.IActorRefVolume:
				_o.Range.Value = ((this.Range<IActorRefVolume>() != null) ? this.Range<IActorRefVolume>().Value.UnPack() : null);
				break;
			case TTriggerShape.IBoxTriggerShape:
				_o.Range.Value = ((this.Range<IBoxTriggerShape>() != null) ? this.Range<IBoxTriggerShape>().Value.UnPack() : null);
				break;
			case TTriggerShape.ICombinationTriggerShape:
				_o.Range.Value = ((this.Range<ICombinationTriggerShape>() != null) ? this.Range<ICombinationTriggerShape>().Value.UnPack() : null);
				break;
			case TTriggerShape.IConeTriggerShape:
				_o.Range.Value = ((this.Range<IConeTriggerShape>() != null) ? this.Range<IConeTriggerShape>().Value.UnPack() : null);
				break;
			case TTriggerShape.ICylinderTriggerShape:
				_o.Range.Value = ((this.Range<ICylinderTriggerShape>() != null) ? this.Range<ICylinderTriggerShape>().Value.UnPack() : null);
				break;
			case TTriggerShape.IHollowCylinderTriggerShape:
				_o.Range.Value = ((this.Range<IHollowCylinderTriggerShape>() != null) ? this.Range<IHollowCylinderTriggerShape>().Value.UnPack() : null);
				break;
			case TTriggerShape.IHollowSphereTriggerShape:
				_o.Range.Value = ((this.Range<IHollowSphereTriggerShape>() != null) ? this.Range<IHollowSphereTriggerShape>().Value.UnPack() : null);
				break;
			case TTriggerShape.ISphereTriggerShape:
				_o.Range.Value = ((this.Range<ISphereTriggerShape>() != null) ? this.Range<ISphereTriggerShape>().Value.UnPack() : null);
				break;
			case TTriggerShape.ISpotlightTriggerShape:
				_o.Range.Value = ((this.Range<ISpotlightTriggerShape>() != null) ? this.Range<ISpotlightTriggerShape>().Value.UnPack() : null);
				break;
			case TTriggerShape.IVolumeTriggerShape:
				_o.Range.Value = ((this.Range<IVolumeTriggerShape>() != null) ? this.Range<IVolumeTriggerShape>().Value.UnPack() : null);
				break;
			}
			_o.EntityIds = new List<int>();
			for (int i = 0; i < this.EntityIdsLength; i++)
			{
				_o.EntityIds.Add(this.EntityIds(i));
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060286EB RID: 165611 RVA: 0x00587568 File Offset: 0x00585768
		public static Offset<IResetEntitiesPosComponent> Pack(FlatBufferBuilder builder, IResetEntitiesPosComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IResetEntitiesPosComponent>);
			}
			TTriggerShape range_type = (_o.Range == null) ? TTriggerShape.NONE : _o.Range.Type;
			int rangeOffset = (_o.Range == null) ? 0 : TTriggerShapeUnion.Pack(builder, _o.Range);
			VectorOffset entityIdsOffset = default(VectorOffset);
			if (_o.EntityIds != null)
			{
				int[] data = _o.EntityIds.ToArray();
				entityIdsOffset = IResetEntitiesPosComponent.CreateEntityIdsVector(builder, data);
			}
			return IResetEntitiesPosComponent.CreateIResetEntitiesPosComponent(builder, _o.Disabled, range_type, rangeOffset, entityIdsOffset, _o.NullMask);
		}

		// Token: 0x0400FA84 RID: 64132
		private Table __p;
	}
}
