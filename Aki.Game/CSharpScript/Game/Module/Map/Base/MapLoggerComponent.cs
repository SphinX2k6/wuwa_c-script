using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Map.Misc;

namespace CSharpScript.Game.Module.Map.Base
{
	// Token: 0x0200456F RID: 17775
	[NullableContext(1)]
	[Nullable(0)]
	public class MapLoggerComponent : MapComponent
	{
		// Token: 0x0602CCB5 RID: 183477 RVA: 0x00C8A9F5 File Offset: 0x00C88BF5
		public MapLoggerComponent([Nullable(new byte[]
		{
			0,
			1,
			1,
			1
		})] OneOf<MapComponent, MapComponentContainer, MapEntity> parent) : base(parent)
		{
		}

		// Token: 0x17005A42 RID: 23106
		// (get) Token: 0x0602CCB6 RID: 183478 RVA: 0x00C8A9FE File Offset: 0x00C88BFE
		public override EMapComponent ComponentType
		{
			get
			{
				return EMapComponent.MapLogger;
			}
		}

		// Token: 0x17005A43 RID: 23107
		// (get) Token: 0x0602CCB7 RID: 183479 RVA: 0x00C8AA04 File Offset: 0x00C88C04
		// (set) Token: 0x0602CCB8 RID: 183480 RVA: 0x00C8AA35 File Offset: 0x00C88C35
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

		// Token: 0x0602CCB9 RID: 183481 RVA: 0x00C8AA53 File Offset: 0x00C88C53
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

		// Token: 0x0602CCBA RID: 183482 RVA: 0x00C8AA65 File Offset: 0x00C88C65
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

		// Token: 0x0602CCBB RID: 183483 RVA: 0x00C8AA77 File Offset: 0x00C88C77
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

		// Token: 0x0401800C RID: 98316
		private const string EnableLogKey = "EnableLog";
	}
}
