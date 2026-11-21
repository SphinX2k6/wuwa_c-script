using System;
using System.Collections;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Text;

namespace System.Security
{
	// Token: 0x02000261 RID: 609
	[NullableContext(2)]
	[Nullable(0)]
	public sealed class SecurityElement
	{
		// Token: 0x06002D9D RID: 11677 RVA: 0x0009300D File Offset: 0x0009120D
		[NullableContext(1)]
		public SecurityElement(string tag)
		{
			ArgumentNullException.ThrowIfNull(tag, "tag");
			if (!SecurityElement.IsValidTag(tag))
			{
				throw new ArgumentException(SR.Format(SR.Argument_InvalidElementTag, tag));
			}
			this._tag = tag;
		}

		// Token: 0x06002D9E RID: 11678 RVA: 0x00093040 File Offset: 0x00091240
		[NullableContext(1)]
		public SecurityElement(string tag, [Nullable(2)] string text)
		{
			ArgumentNullException.ThrowIfNull(tag, "tag");
			if (!SecurityElement.IsValidTag(tag))
			{
				throw new ArgumentException(SR.Format(SR.Argument_InvalidElementTag, tag));
			}
			if (text != null && !SecurityElement.IsValidText(text))
			{
				throw new ArgumentException(SR.Format(SR.Argument_InvalidElementText, text));
			}
			this._tag = tag;
			this._text = text;
		}

		// Token: 0x170008BB RID: 2235
		// (get) Token: 0x06002D9F RID: 11679 RVA: 0x000930A1 File Offset: 0x000912A1
		// (set) Token: 0x06002DA0 RID: 11680 RVA: 0x000930A9 File Offset: 0x000912A9
		[Nullable(1)]
		public string Tag
		{
			[NullableContext(1)]
			get
			{
				return this._tag;
			}
			[NullableContext(1)]
			set
			{
				ArgumentNullException.ThrowIfNull(value, "Tag");
				if (!SecurityElement.IsValidTag(value))
				{
					throw new ArgumentException(SR.Format(SR.Argument_InvalidElementTag, value));
				}
				this._tag = value;
			}
		}

		// Token: 0x170008BC RID: 2236
		// (get) Token: 0x06002DA1 RID: 11681 RVA: 0x000930D8 File Offset: 0x000912D8
		// (set) Token: 0x06002DA2 RID: 11682 RVA: 0x00093148 File Offset: 0x00091348
		public Hashtable Attributes
		{
			get
			{
				if (this._attributes == null || this._attributes.Count == 0)
				{
					return null;
				}
				Hashtable hashtable = new Hashtable(this._attributes.Count / 2);
				int count = this._attributes.Count;
				for (int i = 0; i < count; i += 2)
				{
					hashtable.Add(this._attributes[i], this._attributes[i + 1]);
				}
				return hashtable;
			}
			set
			{
				if (value == null || value.Count == 0)
				{
					this._attributes = null;
					return;
				}
				ArrayList arrayList = new ArrayList(value.Count);
				IDictionaryEnumerator enumerator = value.GetEnumerator();
				while (enumerator.MoveNext())
				{
					string text = (string)enumerator.Key;
					string text2 = (string)enumerator.Value;
					if (!SecurityElement.IsValidAttributeName(text))
					{
						throw new ArgumentException(SR.Format(SR.Argument_InvalidElementName, text));
					}
					if (!SecurityElement.IsValidAttributeValue(text2))
					{
						throw new ArgumentException(SR.Format(SR.Argument_InvalidElementValue, text2));
					}
					arrayList.Add(text);
					arrayList.Add(text2);
				}
				this._attributes = arrayList;
			}
		}

		// Token: 0x170008BD RID: 2237
		// (get) Token: 0x06002DA3 RID: 11683 RVA: 0x000931E6 File Offset: 0x000913E6
		// (set) Token: 0x06002DA4 RID: 11684 RVA: 0x000931F3 File Offset: 0x000913F3
		public string Text
		{
			get
			{
				return SecurityElement.Unescape(this._text);
			}
			set
			{
				if (value == null)
				{
					this._text = null;
					return;
				}
				if (!SecurityElement.IsValidText(value))
				{
					throw new ArgumentException(SR.Format(SR.Argument_InvalidElementTag, value));
				}
				this._text = value;
			}
		}

		// Token: 0x170008BE RID: 2238
		// (get) Token: 0x06002DA5 RID: 11685 RVA: 0x00093220 File Offset: 0x00091420
		// (set) Token: 0x06002DA6 RID: 11686 RVA: 0x00093228 File Offset: 0x00091428
		public ArrayList Children
		{
			get
			{
				return this._children;
			}
			set
			{
				if (value != null && value.Contains(null))
				{
					throw new ArgumentException(SR.ArgumentNull_Child);
				}
				this._children = value;
			}
		}

		// Token: 0x06002DA7 RID: 11687 RVA: 0x00093248 File Offset: 0x00091448
		internal void AddAttributeSafe(string name, string value)
		{
			if (this._attributes == null)
			{
				this._attributes = new ArrayList(8);
			}
			else
			{
				int count = this._attributes.Count;
				for (int i = 0; i < count; i += 2)
				{
					if (string.Equals((string)this._attributes[i], name))
					{
						throw new ArgumentException(SR.Argument_AttributeNamesMustBeUnique);
					}
				}
			}
			this._attributes.Add(name);
			this._attributes.Add(value);
		}

		// Token: 0x06002DA8 RID: 11688 RVA: 0x000932C4 File Offset: 0x000914C4
		[NullableContext(1)]
		public void AddAttribute(string name, string value)
		{
			ArgumentNullException.ThrowIfNull(name, "name");
			ArgumentNullException.ThrowIfNull(value, "value");
			if (!SecurityElement.IsValidAttributeName(name))
			{
				throw new ArgumentException(SR.Format(SR.Argument_InvalidElementName, name));
			}
			if (!SecurityElement.IsValidAttributeValue(value))
			{
				throw new ArgumentException(SR.Format(SR.Argument_InvalidElementValue, value));
			}
			this.AddAttributeSafe(name, value);
		}

		// Token: 0x06002DA9 RID: 11689 RVA: 0x00093321 File Offset: 0x00091521
		[NullableContext(1)]
		public void AddChild(SecurityElement child)
		{
			ArgumentNullException.ThrowIfNull(child, "child");
			if (this._children == null)
			{
				this._children = new ArrayList(1);
			}
			this._children.Add(child);
		}

		// Token: 0x06002DAA RID: 11690 RVA: 0x00093350 File Offset: 0x00091550
		public bool Equal([NotNullWhen(true)] SecurityElement other)
		{
			if (other == null)
			{
				return false;
			}
			if (!string.Equals(this._tag, other._tag))
			{
				return false;
			}
			if (!string.Equals(this._text, other._text))
			{
				return false;
			}
			if (this._attributes == null || other._attributes == null)
			{
				if (this._attributes != other._attributes)
				{
					return false;
				}
			}
			else
			{
				int count = this._attributes.Count;
				if (count != other._attributes.Count)
				{
					return false;
				}
				for (int i = 0; i < count; i++)
				{
					string a = (string)this._attributes[i];
					string b = (string)other._attributes[i];
					if (!string.Equals(a, b))
					{
						return false;
					}
				}
			}
			if (this._children == null || other._children == null)
			{
				if (this._children != other._children)
				{
					return false;
				}
			}
			else
			{
				if (this._children.Count != other._children.Count)
				{
					return false;
				}
				IEnumerator enumerator = this._children.GetEnumerator();
				IEnumerator enumerator2 = other._children.GetEnumerator();
				while (enumerator.MoveNext())
				{
					enumerator2.MoveNext();
					SecurityElement securityElement = (SecurityElement)enumerator.Current;
					SecurityElement other2 = (SecurityElement)enumerator2.Current;
					if (securityElement == null || !securityElement.Equal(other2))
					{
						return false;
					}
				}
			}
			return true;
		}

		// Token: 0x06002DAB RID: 11691 RVA: 0x00093494 File Offset: 0x00091694
		[NullableContext(1)]
		public SecurityElement Copy()
		{
			return new SecurityElement(this._tag, this._text)
			{
				_children = ((this._children == null) ? null : new ArrayList(this._children)),
				_attributes = ((this._attributes == null) ? null : new ArrayList(this._attributes))
			};
		}

		// Token: 0x06002DAC RID: 11692 RVA: 0x000934EA File Offset: 0x000916EA
		public static bool IsValidTag([NotNullWhen(true)] string tag)
		{
			return tag != null && !tag.AsSpan().ContainsAny(' ', '<', '>');
		}

		// Token: 0x06002DAD RID: 11693 RVA: 0x00093505 File Offset: 0x00091705
		public static bool IsValidText([NotNullWhen(true)] string text)
		{
			return text != null && !text.AsSpan().ContainsAny('<', '>');
		}

		// Token: 0x06002DAE RID: 11694 RVA: 0x0009351E File Offset: 0x0009171E
		public static bool IsValidAttributeName([NotNullWhen(true)] string name)
		{
			return SecurityElement.IsValidTag(name);
		}

		// Token: 0x06002DAF RID: 11695 RVA: 0x00093526 File Offset: 0x00091726
		public static bool IsValidAttributeValue([NotNullWhen(true)] string value)
		{
			return value != null && !value.AsSpan().ContainsAny('<', '>', '"');
		}

		// Token: 0x06002DB0 RID: 11696 RVA: 0x00093544 File Offset: 0x00091744
		private static string GetEscapeSequence(char c)
		{
			int num = SecurityElement.s_escapeStringPairs.Length;
			for (int i = 0; i < num; i += 2)
			{
				string text = SecurityElement.s_escapeStringPairs[i];
				string result = SecurityElement.s_escapeStringPairs[i + 1];
				if (text[0] == c)
				{
					return result;
				}
			}
			return c.ToString();
		}

		// Token: 0x06002DB1 RID: 11697 RVA: 0x00093588 File Offset: 0x00091788
		[return: NotNullIfNotNull("str")]
		public unsafe static string Escape(string str)
		{
			if (str == null)
			{
				return null;
			}
			StringBuilder stringBuilder = null;
			ReadOnlySpan<char> readOnlySpan = str;
			int num;
			while ((num = readOnlySpan.IndexOfAny("<>\"'&")) >= 0)
			{
				if (stringBuilder == null)
				{
					stringBuilder = new StringBuilder();
				}
				stringBuilder.Append(readOnlySpan.Slice(0, num)).Append(SecurityElement.GetEscapeSequence((char)(*readOnlySpan[num])));
				readOnlySpan = readOnlySpan.Slice(num + 1);
			}
			if (stringBuilder != null)
			{
				return stringBuilder.Append(readOnlySpan).ToString();
			}
			return str;
		}

		// Token: 0x06002DB2 RID: 11698 RVA: 0x00093604 File Offset: 0x00091804
		private static string GetUnescapeSequence(string str, int index, out int newIndex)
		{
			int num = str.Length - index;
			int num2 = SecurityElement.s_escapeStringPairs.Length;
			for (int i = 0; i < num2; i += 2)
			{
				string result = SecurityElement.s_escapeStringPairs[i];
				string text = SecurityElement.s_escapeStringPairs[i + 1];
				int length = text.Length;
				if (length <= num && string.Compare(text, 0, str, index, length, StringComparison.Ordinal) == 0)
				{
					newIndex = index + text.Length;
					return result;
				}
			}
			newIndex = index + 1;
			return str[index].ToString();
		}

		// Token: 0x06002DB3 RID: 11699 RVA: 0x00093680 File Offset: 0x00091880
		private static string Unescape(string str)
		{
			if (str == null)
			{
				return null;
			}
			StringBuilder stringBuilder = null;
			int length = str.Length;
			int num = 0;
			for (;;)
			{
				int num2 = str.IndexOf('&', num);
				if (num2 < 0)
				{
					break;
				}
				if (stringBuilder == null)
				{
					stringBuilder = new StringBuilder();
				}
				stringBuilder.Append(str, num, num2 - num);
				stringBuilder.Append(SecurityElement.GetUnescapeSequence(str, num2, out num));
			}
			if (stringBuilder == null)
			{
				return str;
			}
			stringBuilder.Append(str, num, length - num);
			return stringBuilder.ToString();
		}

		// Token: 0x06002DB4 RID: 11700 RVA: 0x000936EC File Offset: 0x000918EC
		[NullableContext(1)]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			this.ToString(stringBuilder, delegate(object obj, string str)
			{
				((StringBuilder)obj).Append(str);
			});
			return stringBuilder.ToString();
		}

		// Token: 0x06002DB5 RID: 11701 RVA: 0x0009372C File Offset: 0x0009192C
		private void ToString(object obj, Action<object, string> write)
		{
			write(obj, "<");
			write(obj, this._tag);
			if (this._attributes != null && this._attributes.Count > 0)
			{
				write(obj, " ");
				int count = this._attributes.Count;
				for (int i = 0; i < count; i += 2)
				{
					string arg = (string)this._attributes[i];
					string arg2 = (string)this._attributes[i + 1];
					write(obj, arg);
					write(obj, "=\"");
					write(obj, arg2);
					write(obj, "\"");
					if (i != this._attributes.Count - 2)
					{
						write(obj, "\r\n");
					}
				}
			}
			if (this._text == null && (this._children == null || this._children.Count == 0))
			{
				write(obj, "/>");
				write(obj, "\r\n");
				return;
			}
			write(obj, ">");
			write(obj, this._text);
			if (this._children != null)
			{
				write(obj, "\r\n");
				for (int j = 0; j < this._children.Count; j++)
				{
					((SecurityElement)this._children[j]).ToString(obj, write);
				}
			}
			write(obj, "</");
			write(obj, this._tag);
			write(obj, ">");
			write(obj, "\r\n");
		}

		// Token: 0x06002DB6 RID: 11702 RVA: 0x000938C4 File Offset: 0x00091AC4
		[NullableContext(1)]
		[return: Nullable(2)]
		public string Attribute(string name)
		{
			ArgumentNullException.ThrowIfNull(name, "name");
			if (this._attributes == null)
			{
				return null;
			}
			int count = this._attributes.Count;
			for (int i = 0; i < count; i += 2)
			{
				if (string.Equals((string)this._attributes[i], name))
				{
					return SecurityElement.Unescape((string)this._attributes[i + 1]);
				}
			}
			return null;
		}

		// Token: 0x06002DB7 RID: 11703 RVA: 0x00093934 File Offset: 0x00091B34
		[NullableContext(1)]
		[return: Nullable(2)]
		public SecurityElement SearchForChildByTag(string tag)
		{
			ArgumentNullException.ThrowIfNull(tag, "tag");
			if (this._children == null)
			{
				return null;
			}
			foreach (object obj in this._children)
			{
				SecurityElement securityElement = (SecurityElement)obj;
				if (securityElement != null && string.Equals(securityElement.Tag, tag))
				{
					return securityElement;
				}
			}
			return null;
		}

		// Token: 0x06002DB8 RID: 11704 RVA: 0x000939B4 File Offset: 0x00091BB4
		[NullableContext(1)]
		[return: Nullable(2)]
		public string SearchForTextOfTag(string tag)
		{
			ArgumentNullException.ThrowIfNull(tag, "tag");
			if (string.Equals(this._tag, tag))
			{
				return SecurityElement.Unescape(this._text);
			}
			if (this._children == null)
			{
				return null;
			}
			foreach (object obj in this.Children)
			{
				SecurityElement securityElement = (SecurityElement)obj;
				string text = (securityElement != null) ? securityElement.SearchForTextOfTag(tag) : null;
				if (text != null)
				{
					return text;
				}
			}
			return null;
		}

		// Token: 0x06002DB9 RID: 11705 RVA: 0x00093A4C File Offset: 0x00091C4C
		[NullableContext(1)]
		[return: Nullable(2)]
		public static SecurityElement FromString(string xml)
		{
			ArgumentNullException.ThrowIfNull(xml, "xml");
			return null;
		}

		// Token: 0x0400081C RID: 2076
		internal string _tag;

		// Token: 0x0400081D RID: 2077
		internal string _text;

		// Token: 0x0400081E RID: 2078
		private ArrayList _children;

		// Token: 0x0400081F RID: 2079
		internal ArrayList _attributes;

		// Token: 0x04000820 RID: 2080
		private static readonly string[] s_escapeStringPairs = new string[]
		{
			"<",
			"&lt;",
			">",
			"&gt;",
			"\"",
			"&quot;",
			"'",
			"&apos;",
			"&",
			"&amp;"
		};
	}
}
