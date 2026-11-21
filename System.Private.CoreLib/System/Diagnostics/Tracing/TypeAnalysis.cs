using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;

namespace System.Diagnostics.Tracing
{
	// Token: 0x0200095B RID: 2395
	internal sealed class TypeAnalysis
	{
		// Token: 0x06008EB7 RID: 36535 RVA: 0x0016070C File Offset: 0x0015E90C
		[RequiresUnreferencedCode("EventSource WriteEvent will serialize the whole object graph. Trimmer will not safely handle this case because properties may be trimmed. This can be suppressed if the object is a primitive type")]
		public TypeAnalysis(Type dataType, EventDataAttribute eventAttrib, List<Type> recursionCheck)
		{
			List<PropertyAnalysis> list = new List<PropertyAnalysis>();
			foreach (PropertyInfo propertyInfo in dataType.GetProperties())
			{
				if (!Statics.HasCustomAttribute(propertyInfo, typeof(EventIgnoreAttribute)) && propertyInfo.CanRead && propertyInfo.GetIndexParameters().Length == 0)
				{
					MethodInfo getMethod = propertyInfo.GetGetMethod();
					if (!(getMethod == null) && !getMethod.IsStatic && getMethod.IsPublic)
					{
						TraceLoggingTypeInfo instance = TraceLoggingTypeInfo.GetInstance(propertyInfo.PropertyType, recursionCheck);
						EventFieldAttribute customAttribute = Statics.GetCustomAttribute<EventFieldAttribute>(propertyInfo);
						string text = (customAttribute != null && customAttribute.Name != null) ? customAttribute.Name : (Statics.ShouldOverrideFieldName(propertyInfo.Name) ? instance.Name : propertyInfo.Name);
						list.Add(new PropertyAnalysis(text, propertyInfo, instance, customAttribute));
					}
				}
			}
			this.properties = list.ToArray();
			PropertyAnalysis[] array2 = this.properties;
			for (int i = 0; i < array2.Length; i++)
			{
				TraceLoggingTypeInfo typeInfo = array2[i].typeInfo;
				this.level = (EventLevel)Statics.Combine((int)typeInfo.Level, (int)this.level);
				this.opcode = (EventOpcode)Statics.Combine((int)typeInfo.Opcode, (int)this.opcode);
				this.keywords |= typeInfo.Keywords;
				this.tags |= typeInfo.Tags;
			}
			if (eventAttrib != null)
			{
				this.level = (EventLevel)Statics.Combine((int)eventAttrib.Level, (int)this.level);
				this.opcode = (EventOpcode)Statics.Combine((int)eventAttrib.Opcode, (int)this.opcode);
				this.keywords |= eventAttrib.Keywords;
				this.tags |= eventAttrib.Tags;
				this.name = eventAttrib.Name;
			}
			if (this.name == null)
			{
				this.name = dataType.Name;
			}
		}

		// Token: 0x040021C4 RID: 8644
		internal readonly PropertyAnalysis[] properties;

		// Token: 0x040021C5 RID: 8645
		internal readonly string name;

		// Token: 0x040021C6 RID: 8646
		internal readonly EventKeywords keywords;

		// Token: 0x040021C7 RID: 8647
		internal readonly EventLevel level = (EventLevel)(-1);

		// Token: 0x040021C8 RID: 8648
		internal readonly EventOpcode opcode = (EventOpcode)(-1);

		// Token: 0x040021C9 RID: 8649
		internal readonly EventTags tags;
	}
}
