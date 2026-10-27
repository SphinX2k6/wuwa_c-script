using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Text;

namespace CSharpScript.Core.Common
{
	// Token: 0x02000015 RID: 21
	[NullableContext(1)]
	[Nullable(0)]
	public static class StringBuilderExtension
	{
		// Token: 0x060000A9 RID: 169 RVA: 0x0000A9FC File Offset: 0x00008BFC
		public static void AppendObject(this StringBuilder sb, [Nullable(2)] object o)
		{
			if (o != null)
			{
				string text = o as string;
				if (text != null)
				{
					sb.Append(text);
					return;
				}
				IEnumerable enumerable = o as IEnumerable;
				if (enumerable != null)
				{
					sb.Append('(');
					foreach (object o2 in enumerable)
					{
						sb.AppendObject(o2);
						sb.Append(',');
					}
					if (sb[sb.Length - 1] == ',')
					{
						sb.Remove(sb.Length - 1, 1);
					}
					sb.Append(')');
					return;
				}
				sb.Append(o);
			}
		}

		// Token: 0x060000AA RID: 170 RVA: 0x0000AAB8 File Offset: 0x00008CB8
		public unsafe static void AppendParams(this StringBuilder sb, [ParamCollection] [ScopedRef] [Nullable(new byte[]
		{
			0,
			0,
			1,
			2
		})] ReadOnlySpan<ValueTuple<string, object>> p)
		{
			if (!p.IsEmpty)
			{
				ReadOnlySpan<ValueTuple<string, object>> readOnlySpan = p;
				for (int i = 0; i < readOnlySpan.Length; i++)
				{
					ValueTuple<string, object> valueTuple = *readOnlySpan[i];
					string item = valueTuple.Item1;
					object item2 = valueTuple.Item2;
					sb.Append('[');
					sb.Append(item);
					sb.Append(": ");
					if (item2 != null)
					{
						sb.AppendObject(item2);
					}
					sb.Append(']');
				}
			}
		}
	}
}
