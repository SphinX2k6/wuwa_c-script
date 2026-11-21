using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DEF RID: 3567
	public struct GongduolaPassengerVoiceConfig : IFlatbufferObject
	{
		// Token: 0x17001654 RID: 5716
		// (get) Token: 0x06008193 RID: 33171 RVA: 0x0026C0D5 File Offset: 0x0026A2D5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008194 RID: 33172 RVA: 0x0026C0E2 File Offset: 0x0026A2E2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008195 RID: 33173 RVA: 0x0026C0EC File Offset: 0x0026A2EC
		public static GongduolaPassengerVoiceConfig GetRootAsGongduolaPassengerVoiceConfig(ByteBuffer _bb)
		{
			return GongduolaPassengerVoiceConfig.GetRootAsGongduolaPassengerVoiceConfig(_bb, default(GongduolaPassengerVoiceConfig));
		}

		// Token: 0x06008196 RID: 33174 RVA: 0x0026C108 File Offset: 0x0026A308
		public static GongduolaPassengerVoiceConfig GetRootAsGongduolaPassengerVoiceConfig(ByteBuffer _bb, GongduolaPassengerVoiceConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008197 RID: 33175 RVA: 0x0026C125 File Offset: 0x0026A325
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008198 RID: 33176 RVA: 0x0026C134 File Offset: 0x0026A334
		public GongduolaPassengerVoiceConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001655 RID: 5717
		// (get) Token: 0x06008199 RID: 33177 RVA: 0x0026C144 File Offset: 0x0026A344
		public int Id
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

		// Token: 0x17001656 RID: 5718
		// (get) Token: 0x0600819A RID: 33178 RVA: 0x0026C180 File Offset: 0x0026A380
		public int RoleId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001657 RID: 5719
		// (get) Token: 0x0600819B RID: 33179 RVA: 0x0026C1BC File Offset: 0x0026A3BC
		public string VehicleType
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600819C RID: 33180 RVA: 0x0026C1F3 File Offset: 0x0026A3F3
		public Span<byte> GetVehicleTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600819D RID: 33181 RVA: 0x0026C202 File Offset: 0x0026A402
		public byte[] GetVehicleTypeArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17001658 RID: 5720
		// (get) Token: 0x0600819E RID: 33182 RVA: 0x0026C21C File Offset: 0x0026A41C
		public int TriggerType
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001659 RID: 5721
		// (get) Token: 0x0600819F RID: 33183 RVA: 0x0026C25C File Offset: 0x0026A45C
		public int Priority
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060081A0 RID: 33184 RVA: 0x0026C29C File Offset: 0x0026A49C
		public int TriggerWeatherIds(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700165A RID: 5722
		// (get) Token: 0x060081A1 RID: 33185 RVA: 0x0026C2DC File Offset: 0x0026A4DC
		public int TriggerWeatherIdsLength
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060081A2 RID: 33186 RVA: 0x0026C308 File Offset: 0x0026A508
		public Span<int> GetTriggerWeatherIdsBytes()
		{
			return this.__p.__vector_as_span<int>(14, 4);
		}

		// Token: 0x060081A3 RID: 33187 RVA: 0x0026C318 File Offset: 0x0026A518
		public int[] GetTriggerWeatherIdsArray()
		{
			return this.__p.__vector_as_array<int>(14) ?? Array.Empty<int>();
		}

		// Token: 0x060081A4 RID: 33188 RVA: 0x0026C330 File Offset: 0x0026A530
		public string TriggerTimePeriod(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700165B RID: 5723
		// (get) Token: 0x060081A5 RID: 33189 RVA: 0x0026C36C File Offset: 0x0026A56C
		public int TriggerTimePeriodLength
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060081A6 RID: 33190 RVA: 0x0026C398 File Offset: 0x0026A598
		public float ConditionParam(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700165C RID: 5724
		// (get) Token: 0x060081A7 RID: 33191 RVA: 0x0026C3DC File Offset: 0x0026A5DC
		public int ConditionParamLength
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060081A8 RID: 33192 RVA: 0x0026C408 File Offset: 0x0026A608
		public Span<float> GetConditionParamBytes()
		{
			return this.__p.__vector_as_span<float>(18, 4);
		}

		// Token: 0x060081A9 RID: 33193 RVA: 0x0026C418 File Offset: 0x0026A618
		public float[] GetConditionParamArray()
		{
			return this.__p.__vector_as_array<float>(18) ?? Array.Empty<float>();
		}

		// Token: 0x060081AA RID: 33194 RVA: 0x0026C430 File Offset: 0x0026A630
		public string PlotFlow(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700165D RID: 5725
		// (get) Token: 0x060081AB RID: 33195 RVA: 0x0026C46C File Offset: 0x0026A66C
		public int PlotFlowLength
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700165E RID: 5726
		// (get) Token: 0x060081AC RID: 33196 RVA: 0x0026C498 File Offset: 0x0026A698
		public string Voice
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060081AD RID: 33197 RVA: 0x0026C4D0 File Offset: 0x0026A6D0
		public Span<byte> GetVoiceBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x060081AE RID: 33198 RVA: 0x0026C4E0 File Offset: 0x0026A6E0
		public byte[] GetVoiceArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x060081AF RID: 33199 RVA: 0x0026C4F8 File Offset: 0x0026A6F8
		[NullableContext(1)]
		public float[] ConditionParam()
		{
			return this.GetConditionParamArray();
		}

		// Token: 0x060081B0 RID: 33200 RVA: 0x0026C500 File Offset: 0x0026A700
		[NullableContext(1)]
		public IEnumerable<float> ConditionParamIter()
		{
			GongduolaPassengerVoiceConfig.<ConditionParamIter>d__41 <ConditionParamIter>d__ = new GongduolaPassengerVoiceConfig.<ConditionParamIter>d__41(-2);
			<ConditionParamIter>d__.<>3__<>4__this = this;
			return <ConditionParamIter>d__;
		}

		// Token: 0x060081B1 RID: 33201 RVA: 0x0026C515 File Offset: 0x0026A715
		[NullableContext(1)]
		public string[] PlotFlow()
		{
			return this.PlotFlowIter().ToArray<string>();
		}

		// Token: 0x060081B2 RID: 33202 RVA: 0x0026C522 File Offset: 0x0026A722
		[NullableContext(1)]
		public IEnumerable<string> PlotFlowIter()
		{
			GongduolaPassengerVoiceConfig.<PlotFlowIter>d__43 <PlotFlowIter>d__ = new GongduolaPassengerVoiceConfig.<PlotFlowIter>d__43(-2);
			<PlotFlowIter>d__.<>3__<>4__this = this;
			return <PlotFlowIter>d__;
		}

		// Token: 0x060081B3 RID: 33203 RVA: 0x0026C537 File Offset: 0x0026A737
		[NullableContext(1)]
		public string[] TriggerTimePeriod()
		{
			return this.TriggerTimePeriodIter().ToArray<string>();
		}

		// Token: 0x060081B4 RID: 33204 RVA: 0x0026C544 File Offset: 0x0026A744
		[NullableContext(1)]
		public IEnumerable<string> TriggerTimePeriodIter()
		{
			GongduolaPassengerVoiceConfig.<TriggerTimePeriodIter>d__45 <TriggerTimePeriodIter>d__ = new GongduolaPassengerVoiceConfig.<TriggerTimePeriodIter>d__45(-2);
			<TriggerTimePeriodIter>d__.<>3__<>4__this = this;
			return <TriggerTimePeriodIter>d__;
		}

		// Token: 0x060081B5 RID: 33205 RVA: 0x0026C559 File Offset: 0x0026A759
		[NullableContext(1)]
		public int[] TriggerWeatherIds()
		{
			return this.GetTriggerWeatherIdsArray();
		}

		// Token: 0x060081B6 RID: 33206 RVA: 0x0026C561 File Offset: 0x0026A761
		[NullableContext(1)]
		public IEnumerable<int> TriggerWeatherIdsIter()
		{
			GongduolaPassengerVoiceConfig.<TriggerWeatherIdsIter>d__47 <TriggerWeatherIdsIter>d__ = new GongduolaPassengerVoiceConfig.<TriggerWeatherIdsIter>d__47(-2);
			<TriggerWeatherIdsIter>d__.<>3__<>4__this = this;
			return <TriggerWeatherIdsIter>d__;
		}

		// Token: 0x04005365 RID: 21349
		private Table __p;
	}
}
