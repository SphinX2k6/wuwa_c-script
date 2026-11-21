using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004EB1 RID: 20145
	public struct ICheckEnterTriggerDirTypeVelocityDirAngle : IFlatbufferObject
	{
		// Token: 0x17008FB6 RID: 36790
		// (get) Token: 0x0601F3A7 RID: 127911 RVA: 0x0045A64C File Offset: 0x0045884C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601F3A8 RID: 127912 RVA: 0x0045A659 File Offset: 0x00458859
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601F3A9 RID: 127913 RVA: 0x0045A660 File Offset: 0x00458860
		public static ICheckEnterTriggerDirTypeVelocityDirAngle GetRootAsICheckEnterTriggerDirTypeVelocityDirAngle(ByteBuffer _bb)
		{
			return ICheckEnterTriggerDirTypeVelocityDirAngle.GetRootAsICheckEnterTriggerDirTypeVelocityDirAngle(_bb, default(ICheckEnterTriggerDirTypeVelocityDirAngle));
		}

		// Token: 0x0601F3AA RID: 127914 RVA: 0x0045A67C File Offset: 0x0045887C
		public static ICheckEnterTriggerDirTypeVelocityDirAngle GetRootAsICheckEnterTriggerDirTypeVelocityDirAngle(ByteBuffer _bb, ICheckEnterTriggerDirTypeVelocityDirAngle obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601F3AB RID: 127915 RVA: 0x0045A699 File Offset: 0x00458899
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601F3AC RID: 127916 RVA: 0x0045A6A8 File Offset: 0x004588A8
		public ICheckEnterTriggerDirTypeVelocityDirAngle __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008FB7 RID: 36791
		// (get) Token: 0x0601F3AD RID: 127917 RVA: 0x0045A6B8 File Offset: 0x004588B8
		public ECheckEnterTriggerDirType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECheckEnterTriggerDirType.ForwardAngle;
				}
				return (ECheckEnterTriggerDirType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008FB8 RID: 36792
		// (get) Token: 0x0601F3AE RID: 127918 RVA: 0x0045A6F4 File Offset: 0x004588F4
		public IEllipseConeRange? AngleRange
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IEllipseConeRange?(default(IEllipseConeRange).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0601F3AF RID: 127919 RVA: 0x0045A751 File Offset: 0x00458951
		public static Offset<ICheckEnterTriggerDirTypeVelocityDirAngle> CreateICheckEnterTriggerDirTypeVelocityDirAngle(FlatBufferBuilder builder, ECheckEnterTriggerDirType Type = ECheckEnterTriggerDirType.ForwardAngle, Offset<IEllipseConeRange> AngleRangeOffset = default(Offset<IEllipseConeRange>))
		{
			builder.StartTable(2);
			ICheckEnterTriggerDirTypeVelocityDirAngle.AddAngleRange(builder, AngleRangeOffset);
			ICheckEnterTriggerDirTypeVelocityDirAngle.AddType(builder, Type);
			return ICheckEnterTriggerDirTypeVelocityDirAngle.EndICheckEnterTriggerDirTypeVelocityDirAngle(builder);
		}

		// Token: 0x0601F3B0 RID: 127920 RVA: 0x0045A76E File Offset: 0x0045896E
		public static void StartICheckEnterTriggerDirTypeVelocityDirAngle(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601F3B1 RID: 127921 RVA: 0x0045A777 File Offset: 0x00458977
		public static void AddType(FlatBufferBuilder builder, ECheckEnterTriggerDirType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601F3B2 RID: 127922 RVA: 0x0045A782 File Offset: 0x00458982
		public static void AddAngleRange(FlatBufferBuilder builder, Offset<IEllipseConeRange> angleRangeOffset)
		{
			builder.AddOffset(1, angleRangeOffset.Value, 0);
		}

		// Token: 0x0601F3B3 RID: 127923 RVA: 0x0045A792 File Offset: 0x00458992
		public static Offset<ICheckEnterTriggerDirTypeVelocityDirAngle> EndICheckEnterTriggerDirTypeVelocityDirAngle(FlatBufferBuilder builder)
		{
			return new Offset<ICheckEnterTriggerDirTypeVelocityDirAngle>(builder.EndTable());
		}

		// Token: 0x0601F3B4 RID: 127924 RVA: 0x0045A7A0 File Offset: 0x004589A0
		public ICheckEnterTriggerDirTypeVelocityDirAngleT UnPack()
		{
			ICheckEnterTriggerDirTypeVelocityDirAngleT checkEnterTriggerDirTypeVelocityDirAngleT = new ICheckEnterTriggerDirTypeVelocityDirAngleT();
			this.UnPackTo(checkEnterTriggerDirTypeVelocityDirAngleT);
			return checkEnterTriggerDirTypeVelocityDirAngleT;
		}

		// Token: 0x0601F3B5 RID: 127925 RVA: 0x0045A7BC File Offset: 0x004589BC
		public void UnPackTo(ICheckEnterTriggerDirTypeVelocityDirAngleT _o)
		{
			_o.Type = this.Type;
			_o.AngleRange = ((this.AngleRange != null) ? this.AngleRange.Value.UnPack() : null);
		}

		// Token: 0x0601F3B6 RID: 127926 RVA: 0x0045A804 File Offset: 0x00458A04
		public static Offset<ICheckEnterTriggerDirTypeVelocityDirAngle> Pack(FlatBufferBuilder builder, ICheckEnterTriggerDirTypeVelocityDirAngleT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckEnterTriggerDirTypeVelocityDirAngle>);
			}
			Offset<IEllipseConeRange> angleRangeOffset = (_o.AngleRange == null) ? default(Offset<IEllipseConeRange>) : IEllipseConeRange.Pack(builder, _o.AngleRange);
			return ICheckEnterTriggerDirTypeVelocityDirAngle.CreateICheckEnterTriggerDirTypeVelocityDirAngle(builder, _o.Type, angleRangeOffset);
		}

		// Token: 0x0400DCF7 RID: 56567
		private Table __p;
	}
}
