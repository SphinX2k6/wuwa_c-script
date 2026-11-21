using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F47 RID: 28487
	public struct IGroupAiCommunicateMode : IFlatbufferObject
	{
		// Token: 0x1700D0CA RID: 53450
		// (get) Token: 0x060314E0 RID: 201952 RVA: 0x006ADBFD File Offset: 0x006ABDFD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060314E1 RID: 201953 RVA: 0x006ADC0A File Offset: 0x006ABE0A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060314E2 RID: 201954 RVA: 0x006ADC14 File Offset: 0x006ABE14
		public static IGroupAiCommunicateMode GetRootAsIGroupAiCommunicateMode(ByteBuffer _bb)
		{
			return IGroupAiCommunicateMode.GetRootAsIGroupAiCommunicateMode(_bb, default(IGroupAiCommunicateMode));
		}

		// Token: 0x060314E3 RID: 201955 RVA: 0x006ADC30 File Offset: 0x006ABE30
		public static IGroupAiCommunicateMode GetRootAsIGroupAiCommunicateMode(ByteBuffer _bb, IGroupAiCommunicateMode obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060314E4 RID: 201956 RVA: 0x006ADC4D File Offset: 0x006ABE4D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060314E5 RID: 201957 RVA: 0x006ADC5C File Offset: 0x006ABE5C
		public IGroupAiCommunicateMode __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D0CB RID: 53451
		// (get) Token: 0x060314E6 RID: 201958 RVA: 0x006ADC6C File Offset: 0x006ABE6C
		public EGroupAiCommunicateType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EGroupAiCommunicateType.AddTag;
				}
				return (EGroupAiCommunicateType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060314E7 RID: 201959 RVA: 0x006ADCA8 File Offset: 0x006ABEA8
		public static Offset<IGroupAiCommunicateMode> CreateIGroupAiCommunicateMode(FlatBufferBuilder builder, EGroupAiCommunicateType Type = EGroupAiCommunicateType.AddTag)
		{
			builder.StartTable(1);
			IGroupAiCommunicateMode.AddType(builder, Type);
			return IGroupAiCommunicateMode.EndIGroupAiCommunicateMode(builder);
		}

		// Token: 0x060314E8 RID: 201960 RVA: 0x006ADCBE File Offset: 0x006ABEBE
		public static void StartIGroupAiCommunicateMode(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060314E9 RID: 201961 RVA: 0x006ADCC7 File Offset: 0x006ABEC7
		public static void AddType(FlatBufferBuilder builder, EGroupAiCommunicateType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060314EA RID: 201962 RVA: 0x006ADCD2 File Offset: 0x006ABED2
		public static Offset<IGroupAiCommunicateMode> EndIGroupAiCommunicateMode(FlatBufferBuilder builder)
		{
			return new Offset<IGroupAiCommunicateMode>(builder.EndTable());
		}

		// Token: 0x060314EB RID: 201963 RVA: 0x006ADCE0 File Offset: 0x006ABEE0
		public IGroupAiCommunicateModeT UnPack()
		{
			IGroupAiCommunicateModeT groupAiCommunicateModeT = new IGroupAiCommunicateModeT();
			this.UnPackTo(groupAiCommunicateModeT);
			return groupAiCommunicateModeT;
		}

		// Token: 0x060314EC RID: 201964 RVA: 0x006ADCFB File Offset: 0x006ABEFB
		public void UnPackTo(IGroupAiCommunicateModeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060314ED RID: 201965 RVA: 0x006ADD0C File Offset: 0x006ABF0C
		public static Offset<IGroupAiCommunicateMode> Pack(FlatBufferBuilder builder, IGroupAiCommunicateModeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGroupAiCommunicateMode>);
			}
			return IGroupAiCommunicateMode.CreateIGroupAiCommunicateMode(builder, _o.Type);
		}

		// Token: 0x04011E4C RID: 73292
		private Table __p;
	}
}
