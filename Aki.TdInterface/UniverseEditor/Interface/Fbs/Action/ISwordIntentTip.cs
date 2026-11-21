using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007A4C RID: 31308
	public struct ISwordIntentTip : IFlatbufferObject
	{
		// Token: 0x1700E565 RID: 58725
		// (get) Token: 0x060372DD RID: 226013 RVA: 0x0075F164 File Offset: 0x0075D364
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060372DE RID: 226014 RVA: 0x0075F171 File Offset: 0x0075D371
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060372DF RID: 226015 RVA: 0x0075F178 File Offset: 0x0075D378
		public static ISwordIntentTip GetRootAsISwordIntentTip(ByteBuffer _bb)
		{
			return ISwordIntentTip.GetRootAsISwordIntentTip(_bb, default(ISwordIntentTip));
		}

		// Token: 0x060372E0 RID: 226016 RVA: 0x0075F194 File Offset: 0x0075D394
		public static ISwordIntentTip GetRootAsISwordIntentTip(ByteBuffer _bb, ISwordIntentTip obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060372E1 RID: 226017 RVA: 0x0075F1B1 File Offset: 0x0075D3B1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060372E2 RID: 226018 RVA: 0x0075F1C0 File Offset: 0x0075D3C0
		public ISwordIntentTip __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E566 RID: 58726
		// (get) Token: 0x060372E3 RID: 226019 RVA: 0x0075F1D0 File Offset: 0x0075D3D0
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

		// Token: 0x060372E4 RID: 226020 RVA: 0x0075F20C File Offset: 0x0075D40C
		public static Offset<ISwordIntentTip> CreateISwordIntentTip(FlatBufferBuilder builder, ECommonTipType Type = ECommonTipType.ChallengeCondition)
		{
			builder.StartTable(1);
			ISwordIntentTip.AddType(builder, Type);
			return ISwordIntentTip.EndISwordIntentTip(builder);
		}

		// Token: 0x060372E5 RID: 226021 RVA: 0x0075F222 File Offset: 0x0075D422
		public static void StartISwordIntentTip(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060372E6 RID: 226022 RVA: 0x0075F22B File Offset: 0x0075D42B
		public static void AddType(FlatBufferBuilder builder, ECommonTipType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060372E7 RID: 226023 RVA: 0x0075F236 File Offset: 0x0075D436
		public static Offset<ISwordIntentTip> EndISwordIntentTip(FlatBufferBuilder builder)
		{
			return new Offset<ISwordIntentTip>(builder.EndTable());
		}

		// Token: 0x060372E8 RID: 226024 RVA: 0x0075F244 File Offset: 0x0075D444
		public ISwordIntentTipT UnPack()
		{
			ISwordIntentTipT swordIntentTipT = new ISwordIntentTipT();
			this.UnPackTo(swordIntentTipT);
			return swordIntentTipT;
		}

		// Token: 0x060372E9 RID: 226025 RVA: 0x0075F25F File Offset: 0x0075D45F
		public void UnPackTo(ISwordIntentTipT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060372EA RID: 226026 RVA: 0x0075F270 File Offset: 0x0075D470
		public static Offset<ISwordIntentTip> Pack(FlatBufferBuilder builder, ISwordIntentTipT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISwordIntentTip>);
			}
			return ISwordIntentTip.CreateISwordIntentTip(builder, _o.Type);
		}

		// Token: 0x04012D80 RID: 77184
		private Table __p;
	}
}
