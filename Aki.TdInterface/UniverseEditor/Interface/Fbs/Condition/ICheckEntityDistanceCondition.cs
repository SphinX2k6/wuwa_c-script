using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020049FD RID: 18941
	public struct ICheckEntityDistanceCondition : IFlatbufferObject
	{
		// Token: 0x17008903 RID: 35075
		// (get) Token: 0x0601D9A4 RID: 121252 RVA: 0x0042A6CB File Offset: 0x004288CB
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601D9A5 RID: 121253 RVA: 0x0042A6D8 File Offset: 0x004288D8
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601D9A6 RID: 121254 RVA: 0x0042A6E0 File Offset: 0x004288E0
		public static ICheckEntityDistanceCondition GetRootAsICheckEntityDistanceCondition(ByteBuffer _bb)
		{
			return ICheckEntityDistanceCondition.GetRootAsICheckEntityDistanceCondition(_bb, default(ICheckEntityDistanceCondition));
		}

		// Token: 0x0601D9A7 RID: 121255 RVA: 0x0042A6FC File Offset: 0x004288FC
		public static ICheckEntityDistanceCondition GetRootAsICheckEntityDistanceCondition(ByteBuffer _bb, ICheckEntityDistanceCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601D9A8 RID: 121256 RVA: 0x0042A719 File Offset: 0x00428919
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601D9A9 RID: 121257 RVA: 0x0042A728 File Offset: 0x00428928
		public ICheckEntityDistanceCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008904 RID: 35076
		// (get) Token: 0x0601D9AA RID: 121258 RVA: 0x0042A738 File Offset: 0x00428938
		public ECondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECondition.CompareVar;
				}
				return (ECondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008905 RID: 35077
		// (get) Token: 0x0601D9AB RID: 121259 RVA: 0x0042A774 File Offset: 0x00428974
		public TTargetEntity TargetAType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TTargetEntity.NONE;
				}
				return (TTargetEntity)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601D9AC RID: 121260 RVA: 0x0042A7B0 File Offset: 0x004289B0
		public TTable? TargetA<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601D9AD RID: 121261 RVA: 0x0042A7F4 File Offset: 0x004289F4
		public IPlayerEntity TargetAAsIPlayerEntity()
		{
			return this.TargetA<IPlayerEntity>().Value;
		}

		// Token: 0x0601D9AE RID: 121262 RVA: 0x0042A810 File Offset: 0x00428A10
		public ISelfEntity TargetAAsISelfEntity()
		{
			return this.TargetA<ISelfEntity>().Value;
		}

		// Token: 0x0601D9AF RID: 121263 RVA: 0x0042A82C File Offset: 0x00428A2C
		public ITargetEntity TargetAAsITargetEntity()
		{
			return this.TargetA<ITargetEntity>().Value;
		}

		// Token: 0x0601D9B0 RID: 121264 RVA: 0x0042A848 File Offset: 0x00428A48
		public ITriggeredEntity TargetAAsITriggeredEntity()
		{
			return this.TargetA<ITriggeredEntity>().Value;
		}

		// Token: 0x17008906 RID: 35078
		// (get) Token: 0x0601D9B1 RID: 121265 RVA: 0x0042A864 File Offset: 0x00428A64
		public TTargetEntity TargetBType
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return TTargetEntity.NONE;
				}
				return (TTargetEntity)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601D9B2 RID: 121266 RVA: 0x0042A8A4 File Offset: 0x00428AA4
		public TTable? TargetB<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601D9B3 RID: 121267 RVA: 0x0042A8EC File Offset: 0x00428AEC
		public IPlayerEntity TargetBAsIPlayerEntity()
		{
			return this.TargetB<IPlayerEntity>().Value;
		}

		// Token: 0x0601D9B4 RID: 121268 RVA: 0x0042A908 File Offset: 0x00428B08
		public ISelfEntity TargetBAsISelfEntity()
		{
			return this.TargetB<ISelfEntity>().Value;
		}

		// Token: 0x0601D9B5 RID: 121269 RVA: 0x0042A924 File Offset: 0x00428B24
		public ITargetEntity TargetBAsITargetEntity()
		{
			return this.TargetB<ITargetEntity>().Value;
		}

		// Token: 0x0601D9B6 RID: 121270 RVA: 0x0042A940 File Offset: 0x00428B40
		public ITriggeredEntity TargetBAsITriggeredEntity()
		{
			return this.TargetB<ITriggeredEntity>().Value;
		}

		// Token: 0x17008907 RID: 35079
		// (get) Token: 0x0601D9B7 RID: 121271 RVA: 0x0042A95C File Offset: 0x00428B5C
		public ECompare Compare
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return ECompare.Eq;
				}
				return (ECompare)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008908 RID: 35080
		// (get) Token: 0x0601D9B8 RID: 121272 RVA: 0x0042A99C File Offset: 0x00428B9C
		public int Distance
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

		// Token: 0x0601D9B9 RID: 121273 RVA: 0x0042A9DC File Offset: 0x00428BDC
		public static Offset<ICheckEntityDistanceCondition> CreateICheckEntityDistanceCondition(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, TTargetEntity TargetA_type = TTargetEntity.NONE, int TargetAOffset = 0, TTargetEntity TargetB_type = TTargetEntity.NONE, int TargetBOffset = 0, ECompare Compare = ECompare.Eq, int Distance = 0)
		{
			builder.StartTable(7);
			ICheckEntityDistanceCondition.AddDistance(builder, Distance);
			ICheckEntityDistanceCondition.AddTargetB(builder, TargetBOffset);
			ICheckEntityDistanceCondition.AddTargetA(builder, TargetAOffset);
			ICheckEntityDistanceCondition.AddCompare(builder, Compare);
			ICheckEntityDistanceCondition.AddTargetBType(builder, TargetB_type);
			ICheckEntityDistanceCondition.AddTargetAType(builder, TargetA_type);
			ICheckEntityDistanceCondition.AddType(builder, Type);
			return ICheckEntityDistanceCondition.EndICheckEntityDistanceCondition(builder);
		}

		// Token: 0x0601D9BA RID: 121274 RVA: 0x0042AA2B File Offset: 0x00428C2B
		public static void StartICheckEntityDistanceCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x0601D9BB RID: 121275 RVA: 0x0042AA34 File Offset: 0x00428C34
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601D9BC RID: 121276 RVA: 0x0042AA3F File Offset: 0x00428C3F
		public static void AddTargetAType(FlatBufferBuilder builder, TTargetEntity targetAType)
		{
			builder.AddByte(1, (byte)targetAType, 0);
		}

		// Token: 0x0601D9BD RID: 121277 RVA: 0x0042AA4A File Offset: 0x00428C4A
		public static void AddTargetA(FlatBufferBuilder builder, int targetAOffset)
		{
			builder.AddOffset(2, targetAOffset, 0);
		}

		// Token: 0x0601D9BE RID: 121278 RVA: 0x0042AA55 File Offset: 0x00428C55
		public static void AddTargetBType(FlatBufferBuilder builder, TTargetEntity targetBType)
		{
			builder.AddByte(3, (byte)targetBType, 0);
		}

		// Token: 0x0601D9BF RID: 121279 RVA: 0x0042AA60 File Offset: 0x00428C60
		public static void AddTargetB(FlatBufferBuilder builder, int targetBOffset)
		{
			builder.AddOffset(4, targetBOffset, 0);
		}

		// Token: 0x0601D9C0 RID: 121280 RVA: 0x0042AA6B File Offset: 0x00428C6B
		public static void AddCompare(FlatBufferBuilder builder, ECompare compare)
		{
			builder.AddByte(5, (byte)compare, 0);
		}

		// Token: 0x0601D9C1 RID: 121281 RVA: 0x0042AA76 File Offset: 0x00428C76
		public static void AddDistance(FlatBufferBuilder builder, int distance)
		{
			builder.AddInt(6, distance, 0);
		}

		// Token: 0x0601D9C2 RID: 121282 RVA: 0x0042AA81 File Offset: 0x00428C81
		public static Offset<ICheckEntityDistanceCondition> EndICheckEntityDistanceCondition(FlatBufferBuilder builder)
		{
			return new Offset<ICheckEntityDistanceCondition>(builder.EndTable());
		}

		// Token: 0x0601D9C3 RID: 121283 RVA: 0x0042AA90 File Offset: 0x00428C90
		public ICheckEntityDistanceConditionT UnPack()
		{
			ICheckEntityDistanceConditionT checkEntityDistanceConditionT = new ICheckEntityDistanceConditionT();
			this.UnPackTo(checkEntityDistanceConditionT);
			return checkEntityDistanceConditionT;
		}

		// Token: 0x0601D9C4 RID: 121284 RVA: 0x0042AAAC File Offset: 0x00428CAC
		public void UnPackTo(ICheckEntityDistanceConditionT _o)
		{
			_o.Type = this.Type;
			_o.TargetA = new TTargetEntityUnion();
			_o.TargetA.Type = this.TargetAType;
			switch (this.TargetAType)
			{
			case TTargetEntity.IPlayerEntity:
				_o.TargetA.Value = ((this.TargetA<IPlayerEntity>() != null) ? this.TargetA<IPlayerEntity>().Value.UnPack() : null);
				break;
			case TTargetEntity.ISelfEntity:
				_o.TargetA.Value = ((this.TargetA<ISelfEntity>() != null) ? this.TargetA<ISelfEntity>().Value.UnPack() : null);
				break;
			case TTargetEntity.ITargetEntity:
				_o.TargetA.Value = ((this.TargetA<ITargetEntity>() != null) ? this.TargetA<ITargetEntity>().Value.UnPack() : null);
				break;
			case TTargetEntity.ITriggeredEntity:
				_o.TargetA.Value = ((this.TargetA<ITriggeredEntity>() != null) ? this.TargetA<ITriggeredEntity>().Value.UnPack() : null);
				break;
			}
			_o.TargetB = new TTargetEntityUnion();
			_o.TargetB.Type = this.TargetBType;
			switch (this.TargetBType)
			{
			case TTargetEntity.IPlayerEntity:
				_o.TargetB.Value = ((this.TargetB<IPlayerEntity>() != null) ? this.TargetB<IPlayerEntity>().Value.UnPack() : null);
				break;
			case TTargetEntity.ISelfEntity:
				_o.TargetB.Value = ((this.TargetB<ISelfEntity>() != null) ? this.TargetB<ISelfEntity>().Value.UnPack() : null);
				break;
			case TTargetEntity.ITargetEntity:
				_o.TargetB.Value = ((this.TargetB<ITargetEntity>() != null) ? this.TargetB<ITargetEntity>().Value.UnPack() : null);
				break;
			case TTargetEntity.ITriggeredEntity:
				_o.TargetB.Value = ((this.TargetB<ITriggeredEntity>() != null) ? this.TargetB<ITriggeredEntity>().Value.UnPack() : null);
				break;
			}
			_o.Compare = this.Compare;
			_o.Distance = this.Distance;
		}

		// Token: 0x0601D9C5 RID: 121285 RVA: 0x0042AD20 File Offset: 0x00428F20
		public static Offset<ICheckEntityDistanceCondition> Pack(FlatBufferBuilder builder, ICheckEntityDistanceConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckEntityDistanceCondition>);
			}
			TTargetEntity targetA_type = (_o.TargetA == null) ? TTargetEntity.NONE : _o.TargetA.Type;
			int targetAOffset = (_o.TargetA == null) ? 0 : TTargetEntityUnion.Pack(builder, _o.TargetA);
			TTargetEntity targetB_type = (_o.TargetB == null) ? TTargetEntity.NONE : _o.TargetB.Type;
			int targetBOffset = (_o.TargetB == null) ? 0 : TTargetEntityUnion.Pack(builder, _o.TargetB);
			return ICheckEntityDistanceCondition.CreateICheckEntityDistanceCondition(builder, _o.Type, targetA_type, targetAOffset, targetB_type, targetBOffset, _o.Compare, _o.Distance);
		}

		// Token: 0x0400D239 RID: 53817
		private Table __p;
	}
}
