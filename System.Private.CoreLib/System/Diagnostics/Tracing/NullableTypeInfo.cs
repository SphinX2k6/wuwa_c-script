using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace System.Diagnostics.Tracing
{
	// Token: 0x02000950 RID: 2384
	internal sealed class NullableTypeInfo : TraceLoggingTypeInfo
	{
		// Token: 0x06008E68 RID: 36456 RVA: 0x0015F3B0 File Offset: 0x0015D5B0
		[RequiresUnreferencedCode("EventSource WriteEvent will serialize the whole object graph. Trimmer will not safely handle this case because properties may be trimmed. This can be suppressed if the object is a primitive type")]
		public NullableTypeInfo(Type type, List<Type> recursionCheck) : base(type)
		{
			Type[] genericTypeArguments = type.GenericTypeArguments;
			this.valueInfo = TraceLoggingTypeInfo.GetInstance(genericTypeArguments[0], recursionCheck);
		}

		// Token: 0x06008E69 RID: 36457 RVA: 0x0015F3DC File Offset: 0x0015D5DC
		public override void WriteMetadata(TraceLoggingMetadataCollector collector, string name, EventFieldFormat format)
		{
			TraceLoggingMetadataCollector traceLoggingMetadataCollector = collector.AddGroup(name);
			traceLoggingMetadataCollector.AddScalar("HasValue", TraceLoggingDataType.Boolean8);
			this.valueInfo.WriteMetadata(traceLoggingMetadataCollector, "Value", format);
		}

		// Token: 0x06008E6A RID: 36458 RVA: 0x0015F414 File Offset: 0x0015D614
		[UnconditionalSuppressMessage("ReflectionAnalysis", "IL2072:UnrecognizedReflectionPattern", Justification = "The underlying type of Nullable<T> must be defaultable")]
		public override void WriteData(PropertyValue value)
		{
			object referenceValue = value.ReferenceValue;
			bool flag = referenceValue != null;
			TraceLoggingDataCollector.AddScalar(flag);
			PropertyValue value2 = this.valueInfo.PropertyValueFactory(flag ? referenceValue : RuntimeHelpers.GetUninitializedObject(this.valueInfo.DataType));
			this.valueInfo.WriteData(value2);
		}

		// Token: 0x04002178 RID: 8568
		private readonly TraceLoggingTypeInfo valueInfo;
	}
}
