using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Move
{
	// Token: 0x020070F6 RID: 28918
	[NullableContext(2)]
	[Nullable(0)]
	public class RailDataImpl : IRailData
	{
		// Token: 0x17009CE9 RID: 40169
		// (get) Token: 0x0604698D RID: 289165 RVA: 0x011C2A9F File Offset: 0x011C0C9F
		// (set) Token: 0x0604698E RID: 289166 RVA: 0x011C2AA7 File Offset: 0x011C0CA7
		public int RailSplineEntityId { get; set; }

		// Token: 0x17009CEA RID: 40170
		// (get) Token: 0x0604698F RID: 289167 RVA: 0x011C2AB0 File Offset: 0x011C0CB0
		// (set) Token: 0x06046990 RID: 289168 RVA: 0x011C2AB8 File Offset: 0x011C0CB8
		public float? SlideSpeed { get; set; }

		// Token: 0x17009CEB RID: 40171
		// (get) Token: 0x06046991 RID: 289169 RVA: 0x011C2AC1 File Offset: 0x011C0CC1
		// (set) Token: 0x06046992 RID: 289170 RVA: 0x011C2AC9 File Offset: 0x011C0CC9
		public float? UpSpeed { get; set; }

		// Token: 0x17009CEC RID: 40172
		// (get) Token: 0x06046993 RID: 289171 RVA: 0x011C2AD2 File Offset: 0x011C0CD2
		// (set) Token: 0x06046994 RID: 289172 RVA: 0x011C2ADA File Offset: 0x011C0CDA
		public float? DownSpeed { get; set; }

		// Token: 0x17009CED RID: 40173
		// (get) Token: 0x06046995 RID: 289173 RVA: 0x011C2AE3 File Offset: 0x011C0CE3
		// (set) Token: 0x06046996 RID: 289174 RVA: 0x011C2AEB File Offset: 0x011C0CEB
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public IExchangeSlideRailConfig[] ExchangeRailConfigs { [return: Nullable(new byte[]
		{
			2,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1
		})] set; }

		// Token: 0x17009CEE RID: 40174
		// (get) Token: 0x06046997 RID: 289175 RVA: 0x011C2AF4 File Offset: 0x011C0CF4
		// (set) Token: 0x06046998 RID: 289176 RVA: 0x011C2AFC File Offset: 0x011C0CFC
		public ISlopeSlidePerform SlidePerformConfig { get; set; }

		// Token: 0x06046999 RID: 289177 RVA: 0x011C2B08 File Offset: 0x011C0D08
		[NullableContext(1)]
		public static RailDataImpl FromSlideRailComponent(SlideRailComponent comp)
		{
			RailDataImpl railDataImpl = new RailDataImpl();
			railDataImpl.RailSplineEntityId = comp.RailSplineEntityId;
			int? num = comp.SlideSpeed;
			railDataImpl.SlideSpeed = ((num != null) ? new float?((float)num.GetValueOrDefault()) : null);
			num = comp.UpSpeed;
			railDataImpl.UpSpeed = ((num != null) ? new float?((float)num.GetValueOrDefault()) : null);
			num = comp.DownSpeed;
			railDataImpl.DownSpeed = ((num != null) ? new float?((float)num.GetValueOrDefault()) : null);
			List<IExchangeSlideRailConfig> exchangeRailConfigs = comp.ExchangeRailConfigs;
			railDataImpl.ExchangeRailConfigs = ((exchangeRailConfigs != null) ? exchangeRailConfigs.ToArray() : null);
			railDataImpl.SlidePerformConfig = null;
			return railDataImpl;
		}

		// Token: 0x0604699A RID: 289178 RVA: 0x011C2BD0 File Offset: 0x011C0DD0
		[NullableContext(1)]
		public static RailDataImpl FromSlidePerformComponent(SlidePerformComponent comp)
		{
			RailDataImpl railDataImpl = new RailDataImpl();
			railDataImpl.RailSplineEntityId = comp.RailSplineEntityId;
			int? num = comp.SlideSpeed;
			railDataImpl.SlideSpeed = ((num != null) ? new float?((float)num.GetValueOrDefault()) : null);
			num = comp.UpSpeed;
			railDataImpl.UpSpeed = ((num != null) ? new float?((float)num.GetValueOrDefault()) : null);
			num = comp.DownSpeed;
			railDataImpl.DownSpeed = ((num != null) ? new float?((float)num.GetValueOrDefault()) : null);
			List<IExchangeSlideRailConfig> exchangeRailConfigs = comp.ExchangeRailConfigs;
			railDataImpl.ExchangeRailConfigs = ((exchangeRailConfigs != null) ? exchangeRailConfigs.ToArray() : null);
			railDataImpl.SlidePerformConfig = comp.SlidePerformConfig;
			return railDataImpl;
		}
	}
}
