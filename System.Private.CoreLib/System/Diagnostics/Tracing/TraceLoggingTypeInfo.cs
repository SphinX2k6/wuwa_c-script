using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace System.Diagnostics.Tracing
{
	// Token: 0x0200095A RID: 2394
	internal abstract class TraceLoggingTypeInfo
	{
		// Token: 0x06008EAA RID: 36522 RVA: 0x001605BB File Offset: 0x0015E7BB
		internal TraceLoggingTypeInfo(Type dataType)
		{
			ArgumentNullException.ThrowIfNull(dataType, "dataType");
			this.name = dataType.Name;
			this.dataType = dataType;
			this.propertyValueFactory = PropertyValue.GetFactory(dataType);
		}

		// Token: 0x06008EAB RID: 36523 RVA: 0x001605FC File Offset: 0x0015E7FC
		internal TraceLoggingTypeInfo(Type dataType, string name, EventLevel level, EventOpcode opcode, EventKeywords keywords, EventTags tags)
		{
			ArgumentNullException.ThrowIfNull(dataType, "dataType");
			ArgumentNullException.ThrowIfNull(name, "name");
			Statics.CheckName(name);
			this.name = name;
			this.keywords = keywords;
			this.level = level;
			this.opcode = opcode;
			this.tags = tags;
			this.dataType = dataType;
			this.propertyValueFactory = PropertyValue.GetFactory(dataType);
		}

		// Token: 0x17001301 RID: 4865
		// (get) Token: 0x06008EAC RID: 36524 RVA: 0x00160672 File Offset: 0x0015E872
		public string Name
		{
			get
			{
				return this.name;
			}
		}

		// Token: 0x17001302 RID: 4866
		// (get) Token: 0x06008EAD RID: 36525 RVA: 0x0016067A File Offset: 0x0015E87A
		public EventLevel Level
		{
			get
			{
				return this.level;
			}
		}

		// Token: 0x17001303 RID: 4867
		// (get) Token: 0x06008EAE RID: 36526 RVA: 0x00160682 File Offset: 0x0015E882
		public EventOpcode Opcode
		{
			get
			{
				return this.opcode;
			}
		}

		// Token: 0x17001304 RID: 4868
		// (get) Token: 0x06008EAF RID: 36527 RVA: 0x0016068A File Offset: 0x0015E88A
		public EventKeywords Keywords
		{
			get
			{
				return this.keywords;
			}
		}

		// Token: 0x17001305 RID: 4869
		// (get) Token: 0x06008EB0 RID: 36528 RVA: 0x00160692 File Offset: 0x0015E892
		public EventTags Tags
		{
			get
			{
				return this.tags;
			}
		}

		// Token: 0x17001306 RID: 4870
		// (get) Token: 0x06008EB1 RID: 36529 RVA: 0x0016069A File Offset: 0x0015E89A
		internal Type DataType
		{
			get
			{
				return this.dataType;
			}
		}

		// Token: 0x17001307 RID: 4871
		// (get) Token: 0x06008EB2 RID: 36530 RVA: 0x001606A2 File Offset: 0x0015E8A2
		internal Func<object, PropertyValue> PropertyValueFactory
		{
			get
			{
				return this.propertyValueFactory;
			}
		}

		// Token: 0x06008EB3 RID: 36531
		public abstract void WriteMetadata(TraceLoggingMetadataCollector collector, string name, EventFieldFormat format);

		// Token: 0x06008EB4 RID: 36532
		public abstract void WriteData(PropertyValue value);

		// Token: 0x06008EB5 RID: 36533 RVA: 0x000A77F6 File Offset: 0x000A59F6
		public virtual object GetData(object value)
		{
			return value;
		}

		// Token: 0x06008EB6 RID: 36534 RVA: 0x001606AC File Offset: 0x0015E8AC
		[RequiresUnreferencedCode("EventSource WriteEvent will serialize the whole object graph. Trimmer will not safely handle this case because properties may be trimmed. This can be suppressed if the object is a primitive type")]
		public static TraceLoggingTypeInfo GetInstance(Type type, List<Type> recursionCheck)
		{
			Dictionary<Type, TraceLoggingTypeInfo> dictionary;
			if ((dictionary = TraceLoggingTypeInfo.threadCache) == null)
			{
				dictionary = (TraceLoggingTypeInfo.threadCache = new Dictionary<Type, TraceLoggingTypeInfo>());
			}
			Dictionary<Type, TraceLoggingTypeInfo> dictionary2 = dictionary;
			TraceLoggingTypeInfo traceLoggingTypeInfo;
			if (!dictionary2.TryGetValue(type, out traceLoggingTypeInfo))
			{
				if (recursionCheck == null)
				{
					recursionCheck = new List<Type>();
				}
				int count = recursionCheck.Count;
				traceLoggingTypeInfo = Statics.CreateDefaultTypeInfo(type, recursionCheck);
				dictionary2[type] = traceLoggingTypeInfo;
				recursionCheck.RemoveRange(count, recursionCheck.Count - count);
			}
			return traceLoggingTypeInfo;
		}

		// Token: 0x040021BC RID: 8636
		private readonly string name;

		// Token: 0x040021BD RID: 8637
		private readonly EventKeywords keywords;

		// Token: 0x040021BE RID: 8638
		private readonly EventLevel level = (EventLevel)(-1);

		// Token: 0x040021BF RID: 8639
		private readonly EventOpcode opcode = (EventOpcode)(-1);

		// Token: 0x040021C0 RID: 8640
		private readonly EventTags tags;

		// Token: 0x040021C1 RID: 8641
		private readonly Type dataType;

		// Token: 0x040021C2 RID: 8642
		private readonly Func<object, PropertyValue> propertyValueFactory;

		// Token: 0x040021C3 RID: 8643
		[ThreadStatic]
		private static Dictionary<Type, TraceLoggingTypeInfo> threadCache;
	}
}
