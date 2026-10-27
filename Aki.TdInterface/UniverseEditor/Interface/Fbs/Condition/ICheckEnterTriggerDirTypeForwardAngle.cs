using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020049EE RID: 18926
	public struct ICheckEnterTriggerDirTypeForwardAngle : IFlatbufferObject
	{
		// Token: 0x170088E1 RID: 35041
		// (get) Token: 0x0601D91E RID: 121118 RVA: 0x00429751 File Offset: 0x00427951
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601D91F RID: 121119 RVA: 0x0042975E File Offset: 0x0042795E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601D920 RID: 121120 RVA: 0x00429768 File Offset: 0x00427968
		public static ICheckEnterTriggerDirTypeForwardAngle GetRootAsICheckEnterTriggerDirTypeForwardAngle(ByteBuffer _bb)
		{
			return ICheckEnterTriggerDirTypeForwardAngle.GetRootAsICheckEnterTriggerDirTypeForwardAngle(_bb, default(ICheckEnterTriggerDirTypeForwardAngle));
		}

		// Token: 0x0601D921 RID: 121121 RVA: 0x00429784 File Offset: 0x00427984
		public static ICheckEnterTriggerDirTypeForwardAngle GetRootAsICheckEnterTriggerDirTypeForwardAngle(ByteBuffer _bb, ICheckEnterTriggerDirTypeForwardAngle obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601D922 RID: 121122 RVA: 0x004297A1 File Offset: 0x004279A1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601D923 RID: 121123 RVA: 0x004297B0 File Offset: 0x004279B0
		public ICheckEnterTriggerDirTypeForwardAngle __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170088E2 RID: 35042
		// (get) Token: 0x0601D924 RID: 121124 RVA: 0x004297C0 File Offset: 0x004279C0
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

		// Token: 0x170088E3 RID: 35043
		// (get) Token: 0x0601D925 RID: 121125 RVA: 0x004297FC File Offset: 0x004279FC
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

		// Token: 0x0601D926 RID: 121126 RVA: 0x00429859 File Offset: 0x00427A59
		public static Offset<ICheckEnterTriggerDirTypeForwardAngle> CreateICheckEnterTriggerDirTypeForwardAngle(FlatBufferBuilder builder, ECheckEnterTriggerDirType Type = ECheckEnterTriggerDirType.ForwardAngle, Offset<IEllipseConeRange> AngleRangeOffset = default(Offset<IEllipseConeRange>))
		{
			builder.StartTable(2);
			ICheckEnterTriggerDirTypeForwardAngle.AddAngleRange(builder, AngleRangeOffset);
			ICheckEnterTriggerDirTypeForwardAngle.AddType(builder, Type);
			return ICheckEnterTriggerDirTypeForwardAngle.EndICheckEnterTriggerDirTypeForwardAngle(builder);
		}

		// Token: 0x0601D927 RID: 121127 RVA: 0x00429876 File Offset: 0x00427A76
		public static void StartICheckEnterTriggerDirTypeForwardAngle(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601D928 RID: 121128 RVA: 0x0042987F File Offset: 0x00427A7F
		public static void AddType(FlatBufferBuilder builder, ECheckEnterTriggerDirType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601D929 RID: 121129 RVA: 0x0042988A File Offset: 0x00427A8A
		public static void AddAngleRange(FlatBufferBuilder builder, Offset<IEllipseConeRange> angleRangeOffset)
		{
			builder.AddOffset(1, angleRangeOffset.Value, 0);
		}

		// Token: 0x0601D92A RID: 121130 RVA: 0x0042989A File Offset: 0x00427A9A
		public static Offset<ICheckEnterTriggerDirTypeForwardAngle> EndICheckEnterTriggerDirTypeForwardAngle(FlatBufferBuilder builder)
		{
			return new Offset<ICheckEnterTriggerDirTypeForwardAngle>(builder.EndTable());
		}

		// Token: 0x0601D92B RID: 121131 RVA: 0x004298A8 File Offset: 0x00427AA8
		public ICheckEnterTriggerDirTypeForwardAngleT UnPack()
		{
			ICheckEnterTriggerDirTypeForwardAngleT checkEnterTriggerDirTypeForwardAngleT = new ICheckEnterTriggerDirTypeForwardAngleT();
			this.UnPackTo(checkEnterTriggerDirTypeForwardAngleT);
			return checkEnterTriggerDirTypeForwardAngleT;
		}

		// Token: 0x0601D92C RID: 121132 RVA: 0x004298C4 File Offset: 0x00427AC4
		public void UnPackTo(ICheckEnterTriggerDirTypeForwardAngleT _o)
		{
			_o.Type = this.Type;
			_o.AngleRange = ((this.AngleRange != null) ? this.AngleRange.Value.UnPack() : null);
		}

		// Token: 0x0601D92D RID: 121133 RVA: 0x0042990C File Offset: 0x00427B0C
		public static Offset<ICheckEnterTriggerDirTypeForwardAngle> Pack(FlatBufferBuilder builder, ICheckEnterTriggerDirTypeForwardAngleT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckEnterTriggerDirTypeForwardAngle>);
			}
			Offset<IEllipseConeRange> angleRangeOffset = (_o.AngleRange == null) ? default(Offset<IEllipseConeRange>) : IEllipseConeRange.Pack(builder, _o.AngleRange);
			return ICheckEnterTriggerDirTypeForwardAngle.CreateICheckEnterTriggerDirTypeForwardAngle(builder, _o.Type, angleRangeOffset);
		}

		// Token: 0x0400D220 RID: 53792
		private Table __p;
	}
}
