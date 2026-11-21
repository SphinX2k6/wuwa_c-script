using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004EAE RID: 20142
	public struct ICheckEnterTriggerDirTypeForwardAngle : IFlatbufferObject
	{
		// Token: 0x17008FB1 RID: 36785
		// (get) Token: 0x0601F391 RID: 127889 RVA: 0x0045A3BD File Offset: 0x004585BD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601F392 RID: 127890 RVA: 0x0045A3CA File Offset: 0x004585CA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601F393 RID: 127891 RVA: 0x0045A3D4 File Offset: 0x004585D4
		public static ICheckEnterTriggerDirTypeForwardAngle GetRootAsICheckEnterTriggerDirTypeForwardAngle(ByteBuffer _bb)
		{
			return ICheckEnterTriggerDirTypeForwardAngle.GetRootAsICheckEnterTriggerDirTypeForwardAngle(_bb, default(ICheckEnterTriggerDirTypeForwardAngle));
		}

		// Token: 0x0601F394 RID: 127892 RVA: 0x0045A3F0 File Offset: 0x004585F0
		public static ICheckEnterTriggerDirTypeForwardAngle GetRootAsICheckEnterTriggerDirTypeForwardAngle(ByteBuffer _bb, ICheckEnterTriggerDirTypeForwardAngle obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601F395 RID: 127893 RVA: 0x0045A40D File Offset: 0x0045860D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601F396 RID: 127894 RVA: 0x0045A41C File Offset: 0x0045861C
		public ICheckEnterTriggerDirTypeForwardAngle __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008FB2 RID: 36786
		// (get) Token: 0x0601F397 RID: 127895 RVA: 0x0045A42C File Offset: 0x0045862C
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

		// Token: 0x17008FB3 RID: 36787
		// (get) Token: 0x0601F398 RID: 127896 RVA: 0x0045A468 File Offset: 0x00458668
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

		// Token: 0x0601F399 RID: 127897 RVA: 0x0045A4C5 File Offset: 0x004586C5
		public static Offset<ICheckEnterTriggerDirTypeForwardAngle> CreateICheckEnterTriggerDirTypeForwardAngle(FlatBufferBuilder builder, ECheckEnterTriggerDirType Type = ECheckEnterTriggerDirType.ForwardAngle, Offset<IEllipseConeRange> AngleRangeOffset = default(Offset<IEllipseConeRange>))
		{
			builder.StartTable(2);
			ICheckEnterTriggerDirTypeForwardAngle.AddAngleRange(builder, AngleRangeOffset);
			ICheckEnterTriggerDirTypeForwardAngle.AddType(builder, Type);
			return ICheckEnterTriggerDirTypeForwardAngle.EndICheckEnterTriggerDirTypeForwardAngle(builder);
		}

		// Token: 0x0601F39A RID: 127898 RVA: 0x0045A4E2 File Offset: 0x004586E2
		public static void StartICheckEnterTriggerDirTypeForwardAngle(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601F39B RID: 127899 RVA: 0x0045A4EB File Offset: 0x004586EB
		public static void AddType(FlatBufferBuilder builder, ECheckEnterTriggerDirType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601F39C RID: 127900 RVA: 0x0045A4F6 File Offset: 0x004586F6
		public static void AddAngleRange(FlatBufferBuilder builder, Offset<IEllipseConeRange> angleRangeOffset)
		{
			builder.AddOffset(1, angleRangeOffset.Value, 0);
		}

		// Token: 0x0601F39D RID: 127901 RVA: 0x0045A506 File Offset: 0x00458706
		public static Offset<ICheckEnterTriggerDirTypeForwardAngle> EndICheckEnterTriggerDirTypeForwardAngle(FlatBufferBuilder builder)
		{
			return new Offset<ICheckEnterTriggerDirTypeForwardAngle>(builder.EndTable());
		}

		// Token: 0x0601F39E RID: 127902 RVA: 0x0045A514 File Offset: 0x00458714
		public ICheckEnterTriggerDirTypeForwardAngleT UnPack()
		{
			ICheckEnterTriggerDirTypeForwardAngleT checkEnterTriggerDirTypeForwardAngleT = new ICheckEnterTriggerDirTypeForwardAngleT();
			this.UnPackTo(checkEnterTriggerDirTypeForwardAngleT);
			return checkEnterTriggerDirTypeForwardAngleT;
		}

		// Token: 0x0601F39F RID: 127903 RVA: 0x0045A530 File Offset: 0x00458730
		public void UnPackTo(ICheckEnterTriggerDirTypeForwardAngleT _o)
		{
			_o.Type = this.Type;
			_o.AngleRange = ((this.AngleRange != null) ? this.AngleRange.Value.UnPack() : null);
		}

		// Token: 0x0601F3A0 RID: 127904 RVA: 0x0045A578 File Offset: 0x00458778
		public static Offset<ICheckEnterTriggerDirTypeForwardAngle> Pack(FlatBufferBuilder builder, ICheckEnterTriggerDirTypeForwardAngleT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckEnterTriggerDirTypeForwardAngle>);
			}
			Offset<IEllipseConeRange> angleRangeOffset = (_o.AngleRange == null) ? default(Offset<IEllipseConeRange>) : IEllipseConeRange.Pack(builder, _o.AngleRange);
			return ICheckEnterTriggerDirTypeForwardAngle.CreateICheckEnterTriggerDirTypeForwardAngle(builder, _o.Type, angleRangeOffset);
		}

		// Token: 0x0400DCF4 RID: 56564
		private Table __p;
	}
}
