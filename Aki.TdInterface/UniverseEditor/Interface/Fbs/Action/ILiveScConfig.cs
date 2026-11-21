using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200711B RID: 28955
	public struct ILiveScConfig : IFlatbufferObject
	{
		// Token: 0x1700D40E RID: 54286
		// (get) Token: 0x060324C9 RID: 206025 RVA: 0x006CD21A File Offset: 0x006CB41A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060324CA RID: 206026 RVA: 0x006CD227 File Offset: 0x006CB427
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060324CB RID: 206027 RVA: 0x006CD230 File Offset: 0x006CB430
		public static ILiveScConfig GetRootAsILiveScConfig(ByteBuffer _bb)
		{
			return ILiveScConfig.GetRootAsILiveScConfig(_bb, default(ILiveScConfig));
		}

		// Token: 0x060324CC RID: 206028 RVA: 0x006CD24C File Offset: 0x006CB44C
		public static ILiveScConfig GetRootAsILiveScConfig(ByteBuffer _bb, ILiveScConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060324CD RID: 206029 RVA: 0x006CD269 File Offset: 0x006CB469
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060324CE RID: 206030 RVA: 0x006CD278 File Offset: 0x006CB478
		public ILiveScConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D40F RID: 54287
		// (get) Token: 0x060324CF RID: 206031 RVA: 0x006CD288 File Offset: 0x006CB488
		public int ScId
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D410 RID: 54288
		// (get) Token: 0x060324D0 RID: 206032 RVA: 0x006CD2C4 File Offset: 0x006CB4C4
		public float DelayTime
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

		// Token: 0x060324D1 RID: 206033 RVA: 0x006CD304 File Offset: 0x006CB504
		public static Offset<ILiveScConfig> CreateILiveScConfig(FlatBufferBuilder builder, int ScId = 0, float DelayTime = 0f)
		{
			builder.StartTable(2);
			ILiveScConfig.AddDelayTime(builder, DelayTime);
			ILiveScConfig.AddScId(builder, ScId);
			return ILiveScConfig.EndILiveScConfig(builder);
		}

		// Token: 0x060324D2 RID: 206034 RVA: 0x006CD321 File Offset: 0x006CB521
		public static void StartILiveScConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060324D3 RID: 206035 RVA: 0x006CD32A File Offset: 0x006CB52A
		public static void AddScId(FlatBufferBuilder builder, int scId)
		{
			builder.AddInt(0, scId, 0);
		}

		// Token: 0x060324D4 RID: 206036 RVA: 0x006CD335 File Offset: 0x006CB535
		public static void AddDelayTime(FlatBufferBuilder builder, float delayTime)
		{
			builder.AddFloat(1, delayTime, 0.0);
		}

		// Token: 0x060324D5 RID: 206037 RVA: 0x006CD348 File Offset: 0x006CB548
		public static Offset<ILiveScConfig> EndILiveScConfig(FlatBufferBuilder builder)
		{
			return new Offset<ILiveScConfig>(builder.EndTable());
		}

		// Token: 0x060324D6 RID: 206038 RVA: 0x006CD358 File Offset: 0x006CB558
		public ILiveScConfigT UnPack()
		{
			ILiveScConfigT liveScConfigT = new ILiveScConfigT();
			this.UnPackTo(liveScConfigT);
			return liveScConfigT;
		}

		// Token: 0x060324D7 RID: 206039 RVA: 0x006CD373 File Offset: 0x006CB573
		public void UnPackTo(ILiveScConfigT _o)
		{
			_o.ScId = this.ScId;
			_o.DelayTime = this.DelayTime;
		}

		// Token: 0x060324D8 RID: 206040 RVA: 0x006CD390 File Offset: 0x006CB590
		public static Offset<ILiveScConfig> Pack(FlatBufferBuilder builder, ILiveScConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILiveScConfig>);
			}
			return ILiveScConfig.CreateILiveScConfig(builder, _o.ScId, _o.DelayTime);
		}

		// Token: 0x04012100 RID: 73984
		private Table __p;
	}
}
