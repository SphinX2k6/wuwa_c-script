using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D0A RID: 3338
	public struct GongduolaPassengerVoiceConfig : IFlatbufferObject
	{
		// Token: 0x170015F3 RID: 5619
		// (get) Token: 0x06007B7B RID: 31611 RVA: 0x0024D5BD File Offset: 0x0024B7BD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007B7C RID: 31612 RVA: 0x0024D5CA File Offset: 0x0024B7CA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007B7D RID: 31613 RVA: 0x0024D5D4 File Offset: 0x0024B7D4
		public static GongduolaPassengerVoiceConfig GetRootAsGongduolaPassengerVoiceConfig(ByteBuffer _bb)
		{
			return GongduolaPassengerVoiceConfig.GetRootAsGongduolaPassengerVoiceConfig(_bb, default(GongduolaPassengerVoiceConfig));
		}

		// Token: 0x06007B7E RID: 31614 RVA: 0x0024D5F0 File Offset: 0x0024B7F0
		public static GongduolaPassengerVoiceConfig GetRootAsGongduolaPassengerVoiceConfig(ByteBuffer _bb, GongduolaPassengerVoiceConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007B7F RID: 31615 RVA: 0x0024D60D File Offset: 0x0024B80D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007B80 RID: 31616 RVA: 0x0024D61C File Offset: 0x0024B81C
		public GongduolaPassengerVoiceConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170015F4 RID: 5620
		// (get) Token: 0x06007B81 RID: 31617 RVA: 0x0024D62C File Offset: 0x0024B82C
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

		// Token: 0x170015F5 RID: 5621
		// (get) Token: 0x06007B82 RID: 31618 RVA: 0x0024D668 File Offset: 0x0024B868
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

		// Token: 0x170015F6 RID: 5622
		// (get) Token: 0x06007B83 RID: 31619 RVA: 0x0024D6A4 File Offset: 0x0024B8A4
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

		// Token: 0x06007B84 RID: 31620 RVA: 0x0024D6DB File Offset: 0x0024B8DB
		public Span<byte> GetVehicleTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06007B85 RID: 31621 RVA: 0x0024D6EA File Offset: 0x0024B8EA
		public byte[] GetVehicleTypeArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170015F7 RID: 5623
		// (get) Token: 0x06007B86 RID: 31622 RVA: 0x0024D704 File Offset: 0x0024B904
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

		// Token: 0x170015F8 RID: 5624
		// (get) Token: 0x06007B87 RID: 31623 RVA: 0x0024D744 File Offset: 0x0024B944
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

		// Token: 0x06007B88 RID: 31624 RVA: 0x0024D784 File Offset: 0x0024B984
		public int TriggerWeatherIds(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170015F9 RID: 5625
		// (get) Token: 0x06007B89 RID: 31625 RVA: 0x0024D7C4 File Offset: 0x0024B9C4
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

		// Token: 0x06007B8A RID: 31626 RVA: 0x0024D7F0 File Offset: 0x0024B9F0
		public Span<int> GetTriggerWeatherIdsBytes()
		{
			return this.__p.__vector_as_span<int>(14, 4);
		}

		// Token: 0x06007B8B RID: 31627 RVA: 0x0024D800 File Offset: 0x0024BA00
		public int[] GetTriggerWeatherIdsArray()
		{
			return this.__p.__vector_as_array<int>(14) ?? Array.Empty<int>();
		}

		// Token: 0x06007B8C RID: 31628 RVA: 0x0024D818 File Offset: 0x0024BA18
		public string TriggerTimePeriod(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170015FA RID: 5626
		// (get) Token: 0x06007B8D RID: 31629 RVA: 0x0024D854 File Offset: 0x0024BA54
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

		// Token: 0x06007B8E RID: 31630 RVA: 0x0024D880 File Offset: 0x0024BA80
		public float ConditionParam(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170015FB RID: 5627
		// (get) Token: 0x06007B8F RID: 31631 RVA: 0x0024D8C4 File Offset: 0x0024BAC4
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

		// Token: 0x06007B90 RID: 31632 RVA: 0x0024D8F0 File Offset: 0x0024BAF0
		public Span<float> GetConditionParamBytes()
		{
			return this.__p.__vector_as_span<float>(18, 4);
		}

		// Token: 0x06007B91 RID: 31633 RVA: 0x0024D900 File Offset: 0x0024BB00
		public float[] GetConditionParamArray()
		{
			return this.__p.__vector_as_array<float>(18) ?? Array.Empty<float>();
		}

		// Token: 0x06007B92 RID: 31634 RVA: 0x0024D918 File Offset: 0x0024BB18
		public string PlotFlow(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170015FC RID: 5628
		// (get) Token: 0x06007B93 RID: 31635 RVA: 0x0024D954 File Offset: 0x0024BB54
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

		// Token: 0x170015FD RID: 5629
		// (get) Token: 0x06007B94 RID: 31636 RVA: 0x0024D980 File Offset: 0x0024BB80
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

		// Token: 0x06007B95 RID: 31637 RVA: 0x0024D9B8 File Offset: 0x0024BBB8
		public Span<byte> GetVoiceBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x06007B96 RID: 31638 RVA: 0x0024D9C8 File Offset: 0x0024BBC8
		public byte[] GetVoiceArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x06007B97 RID: 31639 RVA: 0x0024D9E0 File Offset: 0x0024BBE0
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ConditionParamIter()或GetConditionParamBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly float[] ConditionParam()
		{
			GongduolaPassengerVoiceConfig gongduolaPassengerVoiceConfig = this;
			return gongduolaPassengerVoiceConfig.GetConditionParamArray() ?? Array.Empty<float>();
		}

		// Token: 0x06007B98 RID: 31640 RVA: 0x0024DA04 File Offset: 0x0024BC04
		[NullableContext(1)]
		public readonly IEnumerable<float> ConditionParamIter()
		{
			GongduolaPassengerVoiceConfig.<ConditionParamIter>d__41 <ConditionParamIter>d__ = new GongduolaPassengerVoiceConfig.<ConditionParamIter>d__41(-2);
			<ConditionParamIter>d__.<>3__<>4__this = this;
			return <ConditionParamIter>d__;
		}

		// Token: 0x06007B99 RID: 31641 RVA: 0x0024DA19 File Offset: 0x0024BC19
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用PlotFlowIter()或GetPlotFlowBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] PlotFlow()
		{
			return this.PlotFlowIter().ToArray<string>();
		}

		// Token: 0x06007B9A RID: 31642 RVA: 0x0024DA26 File Offset: 0x0024BC26
		[NullableContext(1)]
		public readonly IEnumerable<string> PlotFlowIter()
		{
			GongduolaPassengerVoiceConfig.<PlotFlowIter>d__43 <PlotFlowIter>d__ = new GongduolaPassengerVoiceConfig.<PlotFlowIter>d__43(-2);
			<PlotFlowIter>d__.<>3__<>4__this = this;
			return <PlotFlowIter>d__;
		}

		// Token: 0x06007B9B RID: 31643 RVA: 0x0024DA3B File Offset: 0x0024BC3B
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用TriggerTimePeriodIter()或GetTriggerTimePeriodBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] TriggerTimePeriod()
		{
			return this.TriggerTimePeriodIter().ToArray<string>();
		}

		// Token: 0x06007B9C RID: 31644 RVA: 0x0024DA48 File Offset: 0x0024BC48
		[NullableContext(1)]
		public readonly IEnumerable<string> TriggerTimePeriodIter()
		{
			GongduolaPassengerVoiceConfig.<TriggerTimePeriodIter>d__45 <TriggerTimePeriodIter>d__ = new GongduolaPassengerVoiceConfig.<TriggerTimePeriodIter>d__45(-2);
			<TriggerTimePeriodIter>d__.<>3__<>4__this = this;
			return <TriggerTimePeriodIter>d__;
		}

		// Token: 0x06007B9D RID: 31645 RVA: 0x0024DA60 File Offset: 0x0024BC60
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用TriggerWeatherIdsIter()或GetTriggerWeatherIdsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] TriggerWeatherIds()
		{
			GongduolaPassengerVoiceConfig gongduolaPassengerVoiceConfig = this;
			return gongduolaPassengerVoiceConfig.GetTriggerWeatherIdsArray() ?? Array.Empty<int>();
		}

		// Token: 0x06007B9E RID: 31646 RVA: 0x0024DA84 File Offset: 0x0024BC84
		[NullableContext(1)]
		public readonly IEnumerable<int> TriggerWeatherIdsIter()
		{
			GongduolaPassengerVoiceConfig.<TriggerWeatherIdsIter>d__47 <TriggerWeatherIdsIter>d__ = new GongduolaPassengerVoiceConfig.<TriggerWeatherIdsIter>d__47(-2);
			<TriggerWeatherIdsIter>d__.<>3__<>4__this = this;
			return <TriggerWeatherIdsIter>d__;
		}

		// Token: 0x04004D80 RID: 19840
		private Table __p;
	}
}
