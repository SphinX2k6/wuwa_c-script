using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020070E5 RID: 28901
	public struct ILiveDanmakuIntervalParam : IFlatbufferObject
	{
		// Token: 0x1700D3A9 RID: 54185
		// (get) Token: 0x06032308 RID: 205576 RVA: 0x006CA27D File Offset: 0x006C847D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06032309 RID: 205577 RVA: 0x006CA28A File Offset: 0x006C848A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603230A RID: 205578 RVA: 0x006CA294 File Offset: 0x006C8494
		public static ILiveDanmakuIntervalParam GetRootAsILiveDanmakuIntervalParam(ByteBuffer _bb)
		{
			return ILiveDanmakuIntervalParam.GetRootAsILiveDanmakuIntervalParam(_bb, default(ILiveDanmakuIntervalParam));
		}

		// Token: 0x0603230B RID: 205579 RVA: 0x006CA2B0 File Offset: 0x006C84B0
		public static ILiveDanmakuIntervalParam GetRootAsILiveDanmakuIntervalParam(ByteBuffer _bb, ILiveDanmakuIntervalParam obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603230C RID: 205580 RVA: 0x006CA2CD File Offset: 0x006C84CD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603230D RID: 205581 RVA: 0x006CA2DC File Offset: 0x006C84DC
		public ILiveDanmakuIntervalParam __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D3AA RID: 54186
		// (get) Token: 0x0603230E RID: 205582 RVA: 0x006CA2EC File Offset: 0x006C84EC
		public ELiveParamType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ELiveParamType.Heat;
				}
				return (ELiveParamType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D3AB RID: 54187
		// (get) Token: 0x0603230F RID: 205583 RVA: 0x006CA328 File Offset: 0x006C8528
		public float SendInterval
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06032310 RID: 205584 RVA: 0x006CA368 File Offset: 0x006C8568
		public static Offset<ILiveDanmakuIntervalParam> CreateILiveDanmakuIntervalParam(FlatBufferBuilder builder, ELiveParamType Type = ELiveParamType.Heat, float SendInterval = 0f)
		{
			builder.StartTable(2);
			ILiveDanmakuIntervalParam.AddSendInterval(builder, SendInterval);
			ILiveDanmakuIntervalParam.AddType(builder, Type);
			return ILiveDanmakuIntervalParam.EndILiveDanmakuIntervalParam(builder);
		}

		// Token: 0x06032311 RID: 205585 RVA: 0x006CA385 File Offset: 0x006C8585
		public static void StartILiveDanmakuIntervalParam(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06032312 RID: 205586 RVA: 0x006CA38E File Offset: 0x006C858E
		public static void AddType(FlatBufferBuilder builder, ELiveParamType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06032313 RID: 205587 RVA: 0x006CA399 File Offset: 0x006C8599
		public static void AddSendInterval(FlatBufferBuilder builder, float sendInterval)
		{
			builder.AddFloat(1, sendInterval, 0.0);
		}

		// Token: 0x06032314 RID: 205588 RVA: 0x006CA3AC File Offset: 0x006C85AC
		public static Offset<ILiveDanmakuIntervalParam> EndILiveDanmakuIntervalParam(FlatBufferBuilder builder)
		{
			return new Offset<ILiveDanmakuIntervalParam>(builder.EndTable());
		}

		// Token: 0x06032315 RID: 205589 RVA: 0x006CA3BC File Offset: 0x006C85BC
		public ILiveDanmakuIntervalParamT UnPack()
		{
			ILiveDanmakuIntervalParamT liveDanmakuIntervalParamT = new ILiveDanmakuIntervalParamT();
			this.UnPackTo(liveDanmakuIntervalParamT);
			return liveDanmakuIntervalParamT;
		}

		// Token: 0x06032316 RID: 205590 RVA: 0x006CA3D7 File Offset: 0x006C85D7
		public void UnPackTo(ILiveDanmakuIntervalParamT _o)
		{
			_o.Type = this.Type;
			_o.SendInterval = this.SendInterval;
		}

		// Token: 0x06032317 RID: 205591 RVA: 0x006CA3F4 File Offset: 0x006C85F4
		public static Offset<ILiveDanmakuIntervalParam> Pack(FlatBufferBuilder builder, ILiveDanmakuIntervalParamT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILiveDanmakuIntervalParam>);
			}
			return ILiveDanmakuIntervalParam.CreateILiveDanmakuIntervalParam(builder, _o.Type, _o.SendInterval);
		}

		// Token: 0x040120AE RID: 73902
		private Table __p;
	}
}
