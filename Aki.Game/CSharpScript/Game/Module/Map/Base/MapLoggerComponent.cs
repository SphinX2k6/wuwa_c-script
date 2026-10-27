using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Map.Misc;

namespace CSharpScript.Game.Module.Map.Base
{
	// Token: 0x02005599 RID: 21913
	[NullableContext(1)]
	[Nullable(0)]
	public class MapLoggerComponent : MapComponent
	{
		// Token: 0x06037DB7 RID: 228791 RVA: 0x00D3CCAD File Offset: 0x00D3AEAD
		public MapLoggerComponent([Nullable(new byte[]
		{
			0,
			1,
			1,
			1
		})] OneOf<MapComponent, MapComponentContainer, MapEntity> parent) : base(parent)
		{
		}

		// Token: 0x1700867B RID: 34427
		// (get) Token: 0x06037DB8 RID: 228792 RVA: 0x00D3CCB6 File Offset: 0x00D3AEB6
		public override EMapComponent ComponentType
		{
			get
			{
				return EMapComponent.MapLogger;
			}
		}

		// Token: 0x1700867C RID: 34428
		// (get) Token: 0x06037DB9 RID: 228793 RVA: 0x00D3CCBC File Offset: 0x00D3AEBC
		// (set) Token: 0x06037DBA RID: 228794 RVA: 0x00D3CCED File Offset: 0x00D3AEED
		public bool EnableLog
		{
			get
			{
				return base.PropertyMap.TryGet("EnableLog", true, true).AsT2;
			}
			set
			{
				base.PropertyMap.Set("EnableLog", value);
			}
		}

		// Token: 0x06037DBB RID: 228795 RVA: 0x00D3CD0B File Offset: 0x00D3AF0B
		public new void LogInfo(ELogAuthor author, string message, [ParamCollection] [ScopedRef] [Nullable(new byte[]
		{
			0,
			0,
			1,
			2
		})] ReadOnlySpan<ValueTuple<string, object>> pairs)
		{
			if (this.EnableLog)
			{
				MapLogger.Info(author, message, pairs);
			}
		}

		// Token: 0x06037DBC RID: 228796 RVA: 0x00D3CD1D File Offset: 0x00D3AF1D
		public new void LogWarn(ELogAuthor author, string message, [ParamCollection] [ScopedRef] [Nullable(new byte[]
		{
			0,
			0,
			1,
			2
		})] ReadOnlySpan<ValueTuple<string, object>> pairs)
		{
			if (this.EnableLog)
			{
				MapLogger.Warn(author, message, pairs);
			}
		}

		// Token: 0x06037DBD RID: 228797 RVA: 0x00D3CD2F File Offset: 0x00D3AF2F
		public new void LogError(ELogAuthor author, string message, [ParamCollection] [ScopedRef] [Nullable(new byte[]
		{
			0,
			0,
			1,
			2
		})] ReadOnlySpan<ValueTuple<string, object>> pairs)
		{
			if (this.EnableLog)
			{
				MapLogger.Error(author, message, pairs);
			}
		}

		// Token: 0x0401D581 RID: 120193
		private const string EnableLogKey = "EnableLog";
	}
}
