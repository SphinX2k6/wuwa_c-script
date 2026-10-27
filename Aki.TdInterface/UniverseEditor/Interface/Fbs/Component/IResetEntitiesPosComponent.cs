using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Shape;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200585E RID: 22622
	public struct IResetEntitiesPosComponent : IFlatbufferObject
	{
		// Token: 0x1700A918 RID: 43288
		// (get) Token: 0x06026161 RID: 156001 RVA: 0x00540283 File Offset: 0x0053E483
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06026162 RID: 156002 RVA: 0x00540290 File Offset: 0x0053E490
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06026163 RID: 156003 RVA: 0x00540298 File Offset: 0x0053E498
		public static IResetEntitiesPosComponent GetRootAsIResetEntitiesPosComponent(ByteBuffer _bb)
		{
			return IResetEntitiesPosComponent.GetRootAsIResetEntitiesPosComponent(_bb, default(IResetEntitiesPosComponent));
		}

		// Token: 0x06026164 RID: 156004 RVA: 0x005402B4 File Offset: 0x0053E4B4
		public static IResetEntitiesPosComponent GetRootAsIResetEntitiesPosComponent(ByteBuffer _bb, IResetEntitiesPosComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06026165 RID: 156005 RVA: 0x005402D1 File Offset: 0x0053E4D1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06026166 RID: 156006 RVA: 0x005402E0 File Offset: 0x0053E4E0
		public IResetEntitiesPosComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A919 RID: 43289
		// (get) Token: 0x06026167 RID: 156007 RVA: 0x005402F0 File Offset: 0x0053E4F0
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A91A RID: 43290
		// (get) Token: 0x06026168 RID: 156008 RVA: 0x00540330 File Offset: 0x0053E530
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

		// Token: 0x06026169 RID: 156009 RVA: 0x0054036C File Offset: 0x0053E56C
		public TTable? Range<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602616A RID: 156010 RVA: 0x005403B0 File Offset: 0x0053E5B0
		public IActorCollisionTriggerShape RangeAsIActorCollisionTriggerShape()
		{
			return this.Range<IActorCollisionTriggerShape>().Value;
		}

		// Token: 0x0602616B RID: 156011 RVA: 0x005403CC File Offset: 0x0053E5CC
		public IActorRefVolume RangeAsIActorRefVolume()
		{
			return this.Range<IActorRefVolume>().Value;
		}

		// Token: 0x0602616C RID: 156012 RVA: 0x005403E8 File Offset: 0x0053E5E8
		public IBoxTriggerShape RangeAsIBoxTriggerShape()
		{
			return this.Range<IBoxTriggerShape>().Value;
		}

		// Token: 0x0602616D RID: 156013 RVA: 0x00540404 File Offset: 0x0053E604
		public ICombinationTriggerShape RangeAsICombinationTriggerShape()
		{
			return this.Range<ICombinationTriggerShape>().Value;
		}

		// Token: 0x0602616E RID: 156014 RVA: 0x00540420 File Offset: 0x0053E620
		public IConeTriggerShape RangeAsIConeTriggerShape()
		{
			return this.Range<IConeTriggerShape>().Value;
		}

		// Token: 0x0602616F RID: 156015 RVA: 0x0054043C File Offset: 0x0053E63C
		public ICylinderTriggerShape RangeAsICylinderTriggerShape()
		{
			return this.Range<ICylinderTriggerShape>().Value;
		}

		// Token: 0x06026170 RID: 156016 RVA: 0x00540458 File Offset: 0x0053E658
		public IHollowCylinderTriggerShape RangeAsIHollowCylinderTriggerShape()
		{
			return this.Range<IHollowCylinderTriggerShape>().Value;
		}

		// Token: 0x06026171 RID: 156017 RVA: 0x00540474 File Offset: 0x0053E674
		public IHollowSphereTriggerShape RangeAsIHollowSphereTriggerShape()
		{
			return this.Range<IHollowSphereTriggerShape>().Value;
		}

		// Token: 0x06026172 RID: 156018 RVA: 0x00540490 File Offset: 0x0053E690
		public ISphereTriggerShape RangeAsISphereTriggerShape()
		{
			return this.Range<ISphereTriggerShape>().Value;
		}

		// Token: 0x06026173 RID: 156019 RVA: 0x005404AC File Offset: 0x0053E6AC
		public ISpotlightTriggerShape RangeAsISpotlightTriggerShape()
		{
			return this.Range<ISpotlightTriggerShape>().Value;
		}

		// Token: 0x06026174 RID: 156020 RVA: 0x005404C8 File Offset: 0x0053E6C8
		public IVolumeTriggerShape RangeAsIVolumeTriggerShape()
		{
			return this.Range<IVolumeTriggerShape>().Value;
		}

		// Token: 0x06026175 RID: 156021 RVA: 0x005404E4 File Offset: 0x0053E6E4
		public int EntityIds(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700A91B RID: 43291
		// (get) Token: 0x06026176 RID: 156022 RVA: 0x00540524 File Offset: 0x0053E724
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

		// Token: 0x06026177 RID: 156023 RVA: 0x00540550 File Offset: 0x0053E750
		public Span<int> GetEntityIdsBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x06026178 RID: 156024 RVA: 0x00540560 File Offset: 0x0053E760
		public int[] GetEntityIdsArray()
		{
			return this.__p.__vector_as_array<int>(10);
		}

		// Token: 0x1700A91C RID: 43292
		// (get) Token: 0x06026179 RID: 156025 RVA: 0x00540570 File Offset: 0x0053E770
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

		// Token: 0x0602617A RID: 156026 RVA: 0x005405AD File Offset: 0x0053E7AD
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

		// Token: 0x0602617B RID: 156027 RVA: 0x005405E1 File Offset: 0x0053E7E1
		public static void StartIResetEntitiesPosComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0602617C RID: 156028 RVA: 0x005405EA File Offset: 0x0053E7EA
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x0602617D RID: 156029 RVA: 0x005405F5 File Offset: 0x0053E7F5
		public static void AddRangeType(FlatBufferBuilder builder, TTriggerShape rangeType)
		{
			builder.AddByte(1, (byte)rangeType, 0);
		}

		// Token: 0x0602617E RID: 156030 RVA: 0x00540600 File Offset: 0x0053E800
		public static void AddRange(FlatBufferBuilder builder, int rangeOffset)
		{
			builder.AddOffset(2, rangeOffset, 0);
		}

		// Token: 0x0602617F RID: 156031 RVA: 0x0054060B File Offset: 0x0053E80B
		public static void AddEntityIds(FlatBufferBuilder builder, VectorOffset entityIdsOffset)
		{
			builder.AddOffset(3, entityIdsOffset.Value, 0);
		}

		// Token: 0x06026180 RID: 156032 RVA: 0x0054061C File Offset: 0x0053E81C
		public static VectorOffset CreateEntityIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06026181 RID: 156033 RVA: 0x00540653 File Offset: 0x0053E853
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06026182 RID: 156034 RVA: 0x0054066D File Offset: 0x0053E86D
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06026183 RID: 156035 RVA: 0x0054068B File Offset: 0x0053E88B
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06026184 RID: 156036 RVA: 0x005406A4 File Offset: 0x0053E8A4
		public static void StartEntityIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06026185 RID: 156037 RVA: 0x005406AF File Offset: 0x0053E8AF
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x06026186 RID: 156038 RVA: 0x005406BA File Offset: 0x0053E8BA
		public static Offset<IResetEntitiesPosComponent> EndIResetEntitiesPosComponent(FlatBufferBuilder builder)
		{
			return new Offset<IResetEntitiesPosComponent>(builder.EndTable());
		}

		// Token: 0x06026187 RID: 156039 RVA: 0x005406C8 File Offset: 0x0053E8C8
		public IResetEntitiesPosComponentT UnPack()
		{
			IResetEntitiesPosComponentT resetEntitiesPosComponentT = new IResetEntitiesPosComponentT();
			this.UnPackTo(resetEntitiesPosComponentT);
			return resetEntitiesPosComponentT;
		}

		// Token: 0x06026188 RID: 156040 RVA: 0x005406E4 File Offset: 0x0053E8E4
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

		// Token: 0x06026189 RID: 156041 RVA: 0x00540A1C File Offset: 0x0053EC1C
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

		// Token: 0x0400ED91 RID: 60817
		private Table __p;
	}
}
