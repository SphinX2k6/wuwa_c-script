using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004E87 RID: 20103
	public struct ICheckDirectionCondition : IFlatbufferObject
	{
		// Token: 0x17008F5E RID: 36702
		// (get) Token: 0x0601F23F RID: 127551 RVA: 0x00457F58 File Offset: 0x00456158
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601F240 RID: 127552 RVA: 0x00457F65 File Offset: 0x00456165
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601F241 RID: 127553 RVA: 0x00457F6C File Offset: 0x0045616C
		public static ICheckDirectionCondition GetRootAsICheckDirectionCondition(ByteBuffer _bb)
		{
			return ICheckDirectionCondition.GetRootAsICheckDirectionCondition(_bb, default(ICheckDirectionCondition));
		}

		// Token: 0x0601F242 RID: 127554 RVA: 0x00457F88 File Offset: 0x00456188
		public static ICheckDirectionCondition GetRootAsICheckDirectionCondition(ByteBuffer _bb, ICheckDirectionCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601F243 RID: 127555 RVA: 0x00457FA5 File Offset: 0x004561A5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601F244 RID: 127556 RVA: 0x00457FB4 File Offset: 0x004561B4
		public ICheckDirectionCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008F5F RID: 36703
		// (get) Token: 0x0601F245 RID: 127557 RVA: 0x00457FC4 File Offset: 0x004561C4
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

		// Token: 0x17008F60 RID: 36704
		// (get) Token: 0x0601F246 RID: 127558 RVA: 0x00458000 File Offset: 0x00456200
		public IVectorInfo? Direction
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17008F61 RID: 36705
		// (get) Token: 0x0601F247 RID: 127559 RVA: 0x00458060 File Offset: 0x00456260
		public int AngleInterval
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601F248 RID: 127560 RVA: 0x0045809C File Offset: 0x0045629C
		public static Offset<ICheckDirectionCondition> CreateICheckDirectionCondition(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, Offset<IVectorInfo> DirectionOffset = default(Offset<IVectorInfo>), int AngleInterval = 0)
		{
			builder.StartTable(3);
			ICheckDirectionCondition.AddAngleInterval(builder, AngleInterval);
			ICheckDirectionCondition.AddDirection(builder, DirectionOffset);
			ICheckDirectionCondition.AddType(builder, Type);
			return ICheckDirectionCondition.EndICheckDirectionCondition(builder);
		}

		// Token: 0x0601F249 RID: 127561 RVA: 0x004580C0 File Offset: 0x004562C0
		public static void StartICheckDirectionCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601F24A RID: 127562 RVA: 0x004580C9 File Offset: 0x004562C9
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601F24B RID: 127563 RVA: 0x004580D4 File Offset: 0x004562D4
		public static void AddDirection(FlatBufferBuilder builder, Offset<IVectorInfo> directionOffset)
		{
			builder.AddOffset(1, directionOffset.Value, 0);
		}

		// Token: 0x0601F24C RID: 127564 RVA: 0x004580E4 File Offset: 0x004562E4
		public static void AddAngleInterval(FlatBufferBuilder builder, int angleInterval)
		{
			builder.AddInt(2, angleInterval, 0);
		}

		// Token: 0x0601F24D RID: 127565 RVA: 0x004580EF File Offset: 0x004562EF
		public static Offset<ICheckDirectionCondition> EndICheckDirectionCondition(FlatBufferBuilder builder)
		{
			return new Offset<ICheckDirectionCondition>(builder.EndTable());
		}

		// Token: 0x0601F24E RID: 127566 RVA: 0x004580FC File Offset: 0x004562FC
		public ICheckDirectionConditionT UnPack()
		{
			ICheckDirectionConditionT checkDirectionConditionT = new ICheckDirectionConditionT();
			this.UnPackTo(checkDirectionConditionT);
			return checkDirectionConditionT;
		}

		// Token: 0x0601F24F RID: 127567 RVA: 0x00458118 File Offset: 0x00456318
		public void UnPackTo(ICheckDirectionConditionT _o)
		{
			_o.Type = this.Type;
			_o.Direction = ((this.Direction != null) ? this.Direction.Value.UnPack() : null);
			_o.AngleInterval = this.AngleInterval;
		}

		// Token: 0x0601F250 RID: 127568 RVA: 0x0045816C File Offset: 0x0045636C
		public static Offset<ICheckDirectionCondition> Pack(FlatBufferBuilder builder, ICheckDirectionConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckDirectionCondition>);
			}
			Offset<IVectorInfo> directionOffset = (_o.Direction == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Direction);
			return ICheckDirectionCondition.CreateICheckDirectionCondition(builder, _o.Type, directionOffset, _o.AngleInterval);
		}

		// Token: 0x0400DCC4 RID: 56516
		private Table __p;
	}
}
