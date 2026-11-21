using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007267 RID: 29287
	public struct IMotorRadioDisableRange : IFlatbufferObject
	{
		// Token: 0x1700D6BF RID: 54975
		// (get) Token: 0x0603308C RID: 209036 RVA: 0x006E382B File Offset: 0x006E1A2B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603308D RID: 209037 RVA: 0x006E3838 File Offset: 0x006E1A38
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603308E RID: 209038 RVA: 0x006E3840 File Offset: 0x006E1A40
		public static IMotorRadioDisableRange GetRootAsIMotorRadioDisableRange(ByteBuffer _bb)
		{
			return IMotorRadioDisableRange.GetRootAsIMotorRadioDisableRange(_bb, default(IMotorRadioDisableRange));
		}

		// Token: 0x0603308F RID: 209039 RVA: 0x006E385C File Offset: 0x006E1A5C
		public static IMotorRadioDisableRange GetRootAsIMotorRadioDisableRange(ByteBuffer _bb, IMotorRadioDisableRange obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06033090 RID: 209040 RVA: 0x006E3879 File Offset: 0x006E1A79
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06033091 RID: 209041 RVA: 0x006E3888 File Offset: 0x006E1A88
		public IMotorRadioDisableRange __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D6C0 RID: 54976
		// (get) Token: 0x06033092 RID: 209042 RVA: 0x006E3898 File Offset: 0x006E1A98
		public EMotorRadioDisableRangeType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EMotorRadioDisableRangeType.ByAreaId;
				}
				return (EMotorRadioDisableRangeType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06033093 RID: 209043 RVA: 0x006E38D4 File Offset: 0x006E1AD4
		public static Offset<IMotorRadioDisableRange> CreateIMotorRadioDisableRange(FlatBufferBuilder builder, EMotorRadioDisableRangeType Type = EMotorRadioDisableRangeType.ByAreaId)
		{
			builder.StartTable(1);
			IMotorRadioDisableRange.AddType(builder, Type);
			return IMotorRadioDisableRange.EndIMotorRadioDisableRange(builder);
		}

		// Token: 0x06033094 RID: 209044 RVA: 0x006E38EA File Offset: 0x006E1AEA
		public static void StartIMotorRadioDisableRange(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06033095 RID: 209045 RVA: 0x006E38F3 File Offset: 0x006E1AF3
		public static void AddType(FlatBufferBuilder builder, EMotorRadioDisableRangeType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06033096 RID: 209046 RVA: 0x006E38FE File Offset: 0x006E1AFE
		public static Offset<IMotorRadioDisableRange> EndIMotorRadioDisableRange(FlatBufferBuilder builder)
		{
			return new Offset<IMotorRadioDisableRange>(builder.EndTable());
		}

		// Token: 0x06033097 RID: 209047 RVA: 0x006E390C File Offset: 0x006E1B0C
		public IMotorRadioDisableRangeT UnPack()
		{
			IMotorRadioDisableRangeT motorRadioDisableRangeT = new IMotorRadioDisableRangeT();
			this.UnPackTo(motorRadioDisableRangeT);
			return motorRadioDisableRangeT;
		}

		// Token: 0x06033098 RID: 209048 RVA: 0x006E3927 File Offset: 0x006E1B27
		public void UnPackTo(IMotorRadioDisableRangeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06033099 RID: 209049 RVA: 0x006E3938 File Offset: 0x006E1B38
		public static Offset<IMotorRadioDisableRange> Pack(FlatBufferBuilder builder, IMotorRadioDisableRangeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMotorRadioDisableRange>);
			}
			return IMotorRadioDisableRange.CreateIMotorRadioDisableRange(builder, _o.Type);
		}

		// Token: 0x040122DA RID: 74458
		private Table __p;
	}
}
