using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007277 RID: 29303
	public struct ISwordIntentTip : IFlatbufferObject
	{
		// Token: 0x1700D96C RID: 55660
		// (get) Token: 0x06033FDB RID: 212955 RVA: 0x006FDE04 File Offset: 0x006FC004
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06033FDC RID: 212956 RVA: 0x006FDE11 File Offset: 0x006FC011
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06033FDD RID: 212957 RVA: 0x006FDE18 File Offset: 0x006FC018
		public static ISwordIntentTip GetRootAsISwordIntentTip(ByteBuffer _bb)
		{
			return ISwordIntentTip.GetRootAsISwordIntentTip(_bb, default(ISwordIntentTip));
		}

		// Token: 0x06033FDE RID: 212958 RVA: 0x006FDE34 File Offset: 0x006FC034
		public static ISwordIntentTip GetRootAsISwordIntentTip(ByteBuffer _bb, ISwordIntentTip obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06033FDF RID: 212959 RVA: 0x006FDE51 File Offset: 0x006FC051
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06033FE0 RID: 212960 RVA: 0x006FDE60 File Offset: 0x006FC060
		public ISwordIntentTip __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D96D RID: 55661
		// (get) Token: 0x06033FE1 RID: 212961 RVA: 0x006FDE70 File Offset: 0x006FC070
		public ECommonTipType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECommonTipType.ChallengeCondition;
				}
				return (ECommonTipType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06033FE2 RID: 212962 RVA: 0x006FDEAC File Offset: 0x006FC0AC
		public static Offset<ISwordIntentTip> CreateISwordIntentTip(FlatBufferBuilder builder, ECommonTipType Type = ECommonTipType.ChallengeCondition)
		{
			builder.StartTable(1);
			ISwordIntentTip.AddType(builder, Type);
			return ISwordIntentTip.EndISwordIntentTip(builder);
		}

		// Token: 0x06033FE3 RID: 212963 RVA: 0x006FDEC2 File Offset: 0x006FC0C2
		public static void StartISwordIntentTip(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06033FE4 RID: 212964 RVA: 0x006FDECB File Offset: 0x006FC0CB
		public static void AddType(FlatBufferBuilder builder, ECommonTipType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06033FE5 RID: 212965 RVA: 0x006FDED6 File Offset: 0x006FC0D6
		public static Offset<ISwordIntentTip> EndISwordIntentTip(FlatBufferBuilder builder)
		{
			return new Offset<ISwordIntentTip>(builder.EndTable());
		}

		// Token: 0x06033FE6 RID: 212966 RVA: 0x006FDEE4 File Offset: 0x006FC0E4
		public ISwordIntentTipT UnPack()
		{
			ISwordIntentTipT swordIntentTipT = new ISwordIntentTipT();
			this.UnPackTo(swordIntentTipT);
			return swordIntentTipT;
		}

		// Token: 0x06033FE7 RID: 212967 RVA: 0x006FDEFF File Offset: 0x006FC0FF
		public void UnPackTo(ISwordIntentTipT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06033FE8 RID: 212968 RVA: 0x006FDF10 File Offset: 0x006FC110
		public static Offset<ISwordIntentTip> Pack(FlatBufferBuilder builder, ISwordIntentTipT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISwordIntentTip>);
			}
			return ISwordIntentTip.CreateISwordIntentTip(builder, _o.Type);
		}

		// Token: 0x04011D7E RID: 73086
		private Table __p;
	}
}
