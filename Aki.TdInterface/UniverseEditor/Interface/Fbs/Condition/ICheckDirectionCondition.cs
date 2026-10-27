using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020049C7 RID: 18887
	public struct ICheckDirectionCondition : IFlatbufferObject
	{
		// Token: 0x1700888E RID: 34958
		// (get) Token: 0x0601D7CC RID: 120780 RVA: 0x004272EC File Offset: 0x004254EC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601D7CD RID: 120781 RVA: 0x004272F9 File Offset: 0x004254F9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601D7CE RID: 120782 RVA: 0x00427300 File Offset: 0x00425500
		public static ICheckDirectionCondition GetRootAsICheckDirectionCondition(ByteBuffer _bb)
		{
			return ICheckDirectionCondition.GetRootAsICheckDirectionCondition(_bb, default(ICheckDirectionCondition));
		}

		// Token: 0x0601D7CF RID: 120783 RVA: 0x0042731C File Offset: 0x0042551C
		public static ICheckDirectionCondition GetRootAsICheckDirectionCondition(ByteBuffer _bb, ICheckDirectionCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601D7D0 RID: 120784 RVA: 0x00427339 File Offset: 0x00425539
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601D7D1 RID: 120785 RVA: 0x00427348 File Offset: 0x00425548
		public ICheckDirectionCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700888F RID: 34959
		// (get) Token: 0x0601D7D2 RID: 120786 RVA: 0x00427358 File Offset: 0x00425558
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

		// Token: 0x17008890 RID: 34960
		// (get) Token: 0x0601D7D3 RID: 120787 RVA: 0x00427394 File Offset: 0x00425594
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

		// Token: 0x17008891 RID: 34961
		// (get) Token: 0x0601D7D4 RID: 120788 RVA: 0x004273F4 File Offset: 0x004255F4
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

		// Token: 0x0601D7D5 RID: 120789 RVA: 0x00427430 File Offset: 0x00425630
		public static Offset<ICheckDirectionCondition> CreateICheckDirectionCondition(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, Offset<IVectorInfo> DirectionOffset = default(Offset<IVectorInfo>), int AngleInterval = 0)
		{
			builder.StartTable(3);
			ICheckDirectionCondition.AddAngleInterval(builder, AngleInterval);
			ICheckDirectionCondition.AddDirection(builder, DirectionOffset);
			ICheckDirectionCondition.AddType(builder, Type);
			return ICheckDirectionCondition.EndICheckDirectionCondition(builder);
		}

		// Token: 0x0601D7D6 RID: 120790 RVA: 0x00427454 File Offset: 0x00425654
		public static void StartICheckDirectionCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601D7D7 RID: 120791 RVA: 0x0042745D File Offset: 0x0042565D
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601D7D8 RID: 120792 RVA: 0x00427468 File Offset: 0x00425668
		public static void AddDirection(FlatBufferBuilder builder, Offset<IVectorInfo> directionOffset)
		{
			builder.AddOffset(1, directionOffset.Value, 0);
		}

		// Token: 0x0601D7D9 RID: 120793 RVA: 0x00427478 File Offset: 0x00425678
		public static void AddAngleInterval(FlatBufferBuilder builder, int angleInterval)
		{
			builder.AddInt(2, angleInterval, 0);
		}

		// Token: 0x0601D7DA RID: 120794 RVA: 0x00427483 File Offset: 0x00425683
		public static Offset<ICheckDirectionCondition> EndICheckDirectionCondition(FlatBufferBuilder builder)
		{
			return new Offset<ICheckDirectionCondition>(builder.EndTable());
		}

		// Token: 0x0601D7DB RID: 120795 RVA: 0x00427490 File Offset: 0x00425690
		public ICheckDirectionConditionT UnPack()
		{
			ICheckDirectionConditionT checkDirectionConditionT = new ICheckDirectionConditionT();
			this.UnPackTo(checkDirectionConditionT);
			return checkDirectionConditionT;
		}

		// Token: 0x0601D7DC RID: 120796 RVA: 0x004274AC File Offset: 0x004256AC
		public void UnPackTo(ICheckDirectionConditionT _o)
		{
			_o.Type = this.Type;
			_o.Direction = ((this.Direction != null) ? this.Direction.Value.UnPack() : null);
			_o.AngleInterval = this.AngleInterval;
		}

		// Token: 0x0601D7DD RID: 120797 RVA: 0x00427500 File Offset: 0x00425700
		public static Offset<ICheckDirectionCondition> Pack(FlatBufferBuilder builder, ICheckDirectionConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckDirectionCondition>);
			}
			Offset<IVectorInfo> directionOffset = (_o.Direction == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Direction);
			return ICheckDirectionCondition.CreateICheckDirectionCondition(builder, _o.Type, directionOffset, _o.AngleInterval);
		}

		// Token: 0x0400D1F0 RID: 53744
		private Table __p;
	}
}
