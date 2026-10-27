using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020049F1 RID: 18929
	public struct ICheckEnterTriggerDirTypeVelocityDirAngle : IFlatbufferObject
	{
		// Token: 0x170088E6 RID: 35046
		// (get) Token: 0x0601D934 RID: 121140 RVA: 0x004299E0 File Offset: 0x00427BE0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601D935 RID: 121141 RVA: 0x004299ED File Offset: 0x00427BED
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601D936 RID: 121142 RVA: 0x004299F4 File Offset: 0x00427BF4
		public static ICheckEnterTriggerDirTypeVelocityDirAngle GetRootAsICheckEnterTriggerDirTypeVelocityDirAngle(ByteBuffer _bb)
		{
			return ICheckEnterTriggerDirTypeVelocityDirAngle.GetRootAsICheckEnterTriggerDirTypeVelocityDirAngle(_bb, default(ICheckEnterTriggerDirTypeVelocityDirAngle));
		}

		// Token: 0x0601D937 RID: 121143 RVA: 0x00429A10 File Offset: 0x00427C10
		public static ICheckEnterTriggerDirTypeVelocityDirAngle GetRootAsICheckEnterTriggerDirTypeVelocityDirAngle(ByteBuffer _bb, ICheckEnterTriggerDirTypeVelocityDirAngle obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601D938 RID: 121144 RVA: 0x00429A2D File Offset: 0x00427C2D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601D939 RID: 121145 RVA: 0x00429A3C File Offset: 0x00427C3C
		public ICheckEnterTriggerDirTypeVelocityDirAngle __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170088E7 RID: 35047
		// (get) Token: 0x0601D93A RID: 121146 RVA: 0x00429A4C File Offset: 0x00427C4C
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

		// Token: 0x170088E8 RID: 35048
		// (get) Token: 0x0601D93B RID: 121147 RVA: 0x00429A88 File Offset: 0x00427C88
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

		// Token: 0x0601D93C RID: 121148 RVA: 0x00429AE5 File Offset: 0x00427CE5
		public static Offset<ICheckEnterTriggerDirTypeVelocityDirAngle> CreateICheckEnterTriggerDirTypeVelocityDirAngle(FlatBufferBuilder builder, ECheckEnterTriggerDirType Type = ECheckEnterTriggerDirType.ForwardAngle, Offset<IEllipseConeRange> AngleRangeOffset = default(Offset<IEllipseConeRange>))
		{
			builder.StartTable(2);
			ICheckEnterTriggerDirTypeVelocityDirAngle.AddAngleRange(builder, AngleRangeOffset);
			ICheckEnterTriggerDirTypeVelocityDirAngle.AddType(builder, Type);
			return ICheckEnterTriggerDirTypeVelocityDirAngle.EndICheckEnterTriggerDirTypeVelocityDirAngle(builder);
		}

		// Token: 0x0601D93D RID: 121149 RVA: 0x00429B02 File Offset: 0x00427D02
		public static void StartICheckEnterTriggerDirTypeVelocityDirAngle(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601D93E RID: 121150 RVA: 0x00429B0B File Offset: 0x00427D0B
		public static void AddType(FlatBufferBuilder builder, ECheckEnterTriggerDirType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601D93F RID: 121151 RVA: 0x00429B16 File Offset: 0x00427D16
		public static void AddAngleRange(FlatBufferBuilder builder, Offset<IEllipseConeRange> angleRangeOffset)
		{
			builder.AddOffset(1, angleRangeOffset.Value, 0);
		}

		// Token: 0x0601D940 RID: 121152 RVA: 0x00429B26 File Offset: 0x00427D26
		public static Offset<ICheckEnterTriggerDirTypeVelocityDirAngle> EndICheckEnterTriggerDirTypeVelocityDirAngle(FlatBufferBuilder builder)
		{
			return new Offset<ICheckEnterTriggerDirTypeVelocityDirAngle>(builder.EndTable());
		}

		// Token: 0x0601D941 RID: 121153 RVA: 0x00429B34 File Offset: 0x00427D34
		public ICheckEnterTriggerDirTypeVelocityDirAngleT UnPack()
		{
			ICheckEnterTriggerDirTypeVelocityDirAngleT checkEnterTriggerDirTypeVelocityDirAngleT = new ICheckEnterTriggerDirTypeVelocityDirAngleT();
			this.UnPackTo(checkEnterTriggerDirTypeVelocityDirAngleT);
			return checkEnterTriggerDirTypeVelocityDirAngleT;
		}

		// Token: 0x0601D942 RID: 121154 RVA: 0x00429B50 File Offset: 0x00427D50
		public void UnPackTo(ICheckEnterTriggerDirTypeVelocityDirAngleT _o)
		{
			_o.Type = this.Type;
			_o.AngleRange = ((this.AngleRange != null) ? this.AngleRange.Value.UnPack() : null);
		}

		// Token: 0x0601D943 RID: 121155 RVA: 0x00429B98 File Offset: 0x00427D98
		public static Offset<ICheckEnterTriggerDirTypeVelocityDirAngle> Pack(FlatBufferBuilder builder, ICheckEnterTriggerDirTypeVelocityDirAngleT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckEnterTriggerDirTypeVelocityDirAngle>);
			}
			Offset<IEllipseConeRange> angleRangeOffset = (_o.AngleRange == null) ? default(Offset<IEllipseConeRange>) : IEllipseConeRange.Pack(builder, _o.AngleRange);
			return ICheckEnterTriggerDirTypeVelocityDirAngle.CreateICheckEnterTriggerDirTypeVelocityDirAngle(builder, _o.Type, angleRangeOffset);
		}

		// Token: 0x0400D223 RID: 53795
		private Table __p;
	}
}
