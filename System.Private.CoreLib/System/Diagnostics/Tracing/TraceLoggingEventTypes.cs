using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;

namespace System.Diagnostics.Tracing
{
	// Token: 0x02000957 RID: 2391
	internal sealed class TraceLoggingEventTypes
	{
		// Token: 0x06008E89 RID: 36489 RVA: 0x0015FE73 File Offset: 0x0015E073
		[RequiresUnreferencedCode("EventSource WriteEvent will serialize the whole object graph. Trimmer will not safely handle this case because properties may be trimmed. This can be suppressed if the object is a primitive type")]
		internal TraceLoggingEventTypes(string name, EventTags tags, params Type[] types) : this(tags, name, TraceLoggingEventTypes.MakeArray(types))
		{
		}

		// Token: 0x06008E8A RID: 36490 RVA: 0x0015FE83 File Offset: 0x0015E083
		internal TraceLoggingEventTypes(string name, EventTags tags, params TraceLoggingTypeInfo[] typeInfos) : this(tags, name, TraceLoggingEventTypes.MakeArray(typeInfos))
		{
		}

		// Token: 0x06008E8B RID: 36491 RVA: 0x0015FE94 File Offset: 0x0015E094
		[RequiresUnreferencedCode("EventSource WriteEvent will serialize the whole object graph. Trimmer will not safely handle this case because properties may be trimmed. This can be suppressed if the object is a primitive type")]
		internal TraceLoggingEventTypes(string name, EventTags tags, ParameterInfo[] paramInfos)
		{
			ArgumentNullException.ThrowIfNull(name, "name");
			this.typeInfos = TraceLoggingEventTypes.MakeArray(paramInfos);
			this.paramNames = TraceLoggingEventTypes.MakeParamNameArray(paramInfos);
			this.name = name;
			this.tags = tags;
			this.level = 5;
			TraceLoggingMetadataCollector traceLoggingMetadataCollector = new TraceLoggingMetadataCollector();
			for (int i = 0; i < this.typeInfos.Length; i++)
			{
				TraceLoggingTypeInfo traceLoggingTypeInfo = this.typeInfos[i];
				this.level = Statics.Combine((int)traceLoggingTypeInfo.Level, this.level);
				this.opcode = Statics.Combine((int)traceLoggingTypeInfo.Opcode, this.opcode);
				this.keywords |= traceLoggingTypeInfo.Keywords;
				string fieldName = paramInfos[i].Name;
				if (Statics.ShouldOverrideFieldName(fieldName))
				{
					fieldName = traceLoggingTypeInfo.Name;
				}
				traceLoggingTypeInfo.WriteMetadata(traceLoggingMetadataCollector, fieldName, EventFieldFormat.Default);
			}
			this.typeMetadata = traceLoggingMetadataCollector.GetMetadata();
			this.scratchSize = traceLoggingMetadataCollector.ScratchSize;
			this.dataCount = traceLoggingMetadataCollector.DataCount;
			this.pinCount = traceLoggingMetadataCollector.PinCount;
		}

		// Token: 0x06008E8C RID: 36492 RVA: 0x0015FF94 File Offset: 0x0015E194
		private TraceLoggingEventTypes(EventTags tags, string defaultName, TraceLoggingTypeInfo[] typeInfos)
		{
			ArgumentNullException.ThrowIfNull(defaultName, "defaultName");
			this.typeInfos = typeInfos;
			this.name = defaultName;
			this.tags = tags;
			this.level = 5;
			TraceLoggingMetadataCollector traceLoggingMetadataCollector = new TraceLoggingMetadataCollector();
			foreach (TraceLoggingTypeInfo traceLoggingTypeInfo in typeInfos)
			{
				this.level = Statics.Combine((int)traceLoggingTypeInfo.Level, this.level);
				this.opcode = Statics.Combine((int)traceLoggingTypeInfo.Opcode, this.opcode);
				this.keywords |= traceLoggingTypeInfo.Keywords;
				traceLoggingTypeInfo.WriteMetadata(traceLoggingMetadataCollector, null, EventFieldFormat.Default);
			}
			this.typeMetadata = traceLoggingMetadataCollector.GetMetadata();
			this.scratchSize = traceLoggingMetadataCollector.ScratchSize;
			this.dataCount = traceLoggingMetadataCollector.DataCount;
			this.pinCount = traceLoggingMetadataCollector.PinCount;
		}

		// Token: 0x170012FA RID: 4858
		// (get) Token: 0x06008E8D RID: 36493 RVA: 0x00160062 File Offset: 0x0015E262
		internal string Name
		{
			get
			{
				return this.name;
			}
		}

		// Token: 0x170012FB RID: 4859
		// (get) Token: 0x06008E8E RID: 36494 RVA: 0x0016006A File Offset: 0x0015E26A
		internal EventTags Tags
		{
			get
			{
				return this.tags;
			}
		}

		// Token: 0x06008E8F RID: 36495 RVA: 0x00160072 File Offset: 0x0015E272
		internal NameInfo GetNameInfo(string name, EventTags tags)
		{
			return this.nameInfos.TryGet(new KeyValuePair<string, EventTags>(name, tags)) ?? this.nameInfos.GetOrAdd(new NameInfo(name, tags, this.typeMetadata.Length));
		}

		// Token: 0x06008E90 RID: 36496 RVA: 0x001600A4 File Offset: 0x0015E2A4
		[RequiresUnreferencedCode("EventSource WriteEvent will serialize the whole object graph. Trimmer will not safely handle this case because properties may be trimmed. This can be suppressed if the object is a primitive type")]
		private static TraceLoggingTypeInfo[] MakeArray(ParameterInfo[] paramInfos)
		{
			ArgumentNullException.ThrowIfNull(paramInfos, "paramInfos");
			List<Type> recursionCheck = new List<Type>(paramInfos.Length);
			TraceLoggingTypeInfo[] array = new TraceLoggingTypeInfo[paramInfos.Length];
			for (int i = 0; i < paramInfos.Length; i++)
			{
				array[i] = TraceLoggingTypeInfo.GetInstance(paramInfos[i].ParameterType, recursionCheck);
			}
			return array;
		}

		// Token: 0x06008E91 RID: 36497 RVA: 0x001600F0 File Offset: 0x0015E2F0
		[RequiresUnreferencedCode("EventSource WriteEvent will serialize the whole object graph. Trimmer will not safely handle this case because properties may be trimmed. This can be suppressed if the object is a primitive type")]
		private static TraceLoggingTypeInfo[] MakeArray(Type[] types)
		{
			ArgumentNullException.ThrowIfNull(types, "types");
			List<Type> recursionCheck = new List<Type>(types.Length);
			TraceLoggingTypeInfo[] array = new TraceLoggingTypeInfo[types.Length];
			for (int i = 0; i < types.Length; i++)
			{
				array[i] = TraceLoggingTypeInfo.GetInstance(types[i], recursionCheck);
			}
			return array;
		}

		// Token: 0x06008E92 RID: 36498 RVA: 0x00160135 File Offset: 0x0015E335
		private static TraceLoggingTypeInfo[] MakeArray(TraceLoggingTypeInfo[] typeInfos)
		{
			ArgumentNullException.ThrowIfNull(typeInfos, "typeInfos");
			return (TraceLoggingTypeInfo[])typeInfos.Clone();
		}

		// Token: 0x06008E93 RID: 36499 RVA: 0x00160150 File Offset: 0x0015E350
		private static string[] MakeParamNameArray(ParameterInfo[] paramInfos)
		{
			string[] array = new string[paramInfos.Length];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = paramInfos[i].Name;
			}
			return array;
		}

		// Token: 0x040021A6 RID: 8614
		internal readonly TraceLoggingTypeInfo[] typeInfos;

		// Token: 0x040021A7 RID: 8615
		internal readonly string[] paramNames;

		// Token: 0x040021A8 RID: 8616
		internal readonly string name;

		// Token: 0x040021A9 RID: 8617
		internal readonly EventTags tags;

		// Token: 0x040021AA RID: 8618
		internal readonly byte level;

		// Token: 0x040021AB RID: 8619
		internal readonly byte opcode;

		// Token: 0x040021AC RID: 8620
		internal readonly EventKeywords keywords;

		// Token: 0x040021AD RID: 8621
		internal readonly byte[] typeMetadata;

		// Token: 0x040021AE RID: 8622
		internal readonly int scratchSize;

		// Token: 0x040021AF RID: 8623
		internal readonly int dataCount;

		// Token: 0x040021B0 RID: 8624
		internal readonly int pinCount;

		// Token: 0x040021B1 RID: 8625
		private ConcurrentSet<KeyValuePair<string, EventTags>, NameInfo> nameInfos;
	}
}
