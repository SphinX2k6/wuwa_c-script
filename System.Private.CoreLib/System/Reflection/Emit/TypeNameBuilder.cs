using System;
using System.Collections.Generic;
using System.Text;

namespace System.Reflection.Emit
{
	// Token: 0x020007D5 RID: 2005
	internal sealed class TypeNameBuilder
	{
		// Token: 0x0600808D RID: 32909 RVA: 0x0012F918 File Offset: 0x0012DB18
		private TypeNameBuilder()
		{
		}

		// Token: 0x0600808E RID: 32910 RVA: 0x0012F936 File Offset: 0x0012DB36
		private void OpenGenericArguments()
		{
			this._instNesting++;
			this._firstInstArg = true;
			this.Append('[');
		}

		// Token: 0x0600808F RID: 32911 RVA: 0x0012F955 File Offset: 0x0012DB55
		private void CloseGenericArguments()
		{
			this._instNesting--;
			if (this._firstInstArg)
			{
				this._str.Remove(this._str.Length - 1, 1);
				return;
			}
			this.Append(']');
		}

		// Token: 0x06008090 RID: 32912 RVA: 0x0012F990 File Offset: 0x0012DB90
		private void OpenGenericArgument()
		{
			this._nestedName = false;
			if (!this._firstInstArg)
			{
				this.Append(',');
			}
			this._firstInstArg = false;
			this.Append('[');
			this.PushOpenGenericArgument();
		}

		// Token: 0x06008091 RID: 32913 RVA: 0x0012F9BE File Offset: 0x0012DBBE
		private void CloseGenericArgument()
		{
			if (this._hasAssemblySpec)
			{
				this.Append(']');
			}
			this.PopOpenGenericArgument();
		}

		// Token: 0x06008092 RID: 32914 RVA: 0x0012F9D6 File Offset: 0x0012DBD6
		private void AddName(string name)
		{
			if (this._nestedName)
			{
				this.Append('+');
			}
			this._nestedName = true;
			this.EscapeName(name);
		}

		// Token: 0x06008093 RID: 32915 RVA: 0x0012F9F8 File Offset: 0x0012DBF8
		private void AddArray(int rank)
		{
			if (rank == 1)
			{
				this.Append("[*]");
				return;
			}
			if (rank > 64)
			{
				this._str.Append('[').Append(rank).Append(']');
				return;
			}
			this.Append('[');
			for (int i = 1; i < rank; i++)
			{
				this.Append(',');
			}
			this.Append(']');
		}

		// Token: 0x06008094 RID: 32916 RVA: 0x0012FA5A File Offset: 0x0012DC5A
		private void AddAssemblySpec(string assemblySpec)
		{
			if (assemblySpec != null && !assemblySpec.Equals(""))
			{
				this.Append(", ");
				if (this._instNesting > 0)
				{
					this.EscapeEmbeddedAssemblyName(assemblySpec);
				}
				else
				{
					this.EscapeAssemblyName(assemblySpec);
				}
				this._hasAssemblySpec = true;
			}
		}

		// Token: 0x06008095 RID: 32917 RVA: 0x0012FA97 File Offset: 0x0012DC97
		public override string ToString()
		{
			return this._str.ToString();
		}

		// Token: 0x06008096 RID: 32918 RVA: 0x0012FAA4 File Offset: 0x0012DCA4
		private static bool ContainsReservedChar(string name)
		{
			foreach (char c in name)
			{
				if (c == '\0')
				{
					break;
				}
				if (TypeNameBuilder.IsTypeNameReservedChar(c))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06008097 RID: 32919 RVA: 0x0012FADC File Offset: 0x0012DCDC
		private static bool IsTypeNameReservedChar(char ch)
		{
			switch (ch)
			{
			case '&':
			case '*':
			case '+':
			case ',':
				break;
			case '\'':
			case '(':
			case ')':
				goto IL_40;
			default:
				switch (ch)
				{
				case '[':
				case '\\':
				case ']':
					break;
				default:
					goto IL_40;
				}
				break;
			}
			return true;
			IL_40:
			return false;
		}

		// Token: 0x06008098 RID: 32920 RVA: 0x0012FB2C File Offset: 0x0012DD2C
		private void EscapeName(string name)
		{
			if (TypeNameBuilder.ContainsReservedChar(name))
			{
				foreach (char c in name)
				{
					if (c == '\0')
					{
						return;
					}
					if (TypeNameBuilder.IsTypeNameReservedChar(c))
					{
						this._str.Append('\\');
					}
					this._str.Append(c);
				}
				return;
			}
			this.Append(name);
		}

		// Token: 0x06008099 RID: 32921 RVA: 0x0012FB8A File Offset: 0x0012DD8A
		private void EscapeAssemblyName(string name)
		{
			this.Append(name);
		}

		// Token: 0x0600809A RID: 32922 RVA: 0x0012FB94 File Offset: 0x0012DD94
		private void EscapeEmbeddedAssemblyName(string name)
		{
			if (name.Contains(']'))
			{
				foreach (char c in name)
				{
					if (c == ']')
					{
						this.Append('\\');
					}
					this.Append(c);
				}
				return;
			}
			this.Append(name);
		}

		// Token: 0x0600809B RID: 32923 RVA: 0x0012FBE2 File Offset: 0x0012DDE2
		private void PushOpenGenericArgument()
		{
			this._stack.Add(this._str.Length);
			this._stackIdx++;
		}

		// Token: 0x0600809C RID: 32924 RVA: 0x0012FC08 File Offset: 0x0012DE08
		private void PopOpenGenericArgument()
		{
			List<int> stack = this._stack;
			int num = this._stackIdx - 1;
			this._stackIdx = num;
			int num2 = stack[num];
			this._stack.RemoveAt(this._stackIdx);
			if (!this._hasAssemblySpec)
			{
				this._str.Remove(num2 - 1, 1);
			}
			this._hasAssemblySpec = false;
		}

		// Token: 0x0600809D RID: 32925 RVA: 0x0012FC64 File Offset: 0x0012DE64
		private void Append(string pStr)
		{
			int num = pStr.IndexOf('\0');
			if (num < 0)
			{
				this._str.Append(pStr);
				return;
			}
			if (num > 0)
			{
				this._str.Append(pStr.AsSpan(0, num));
			}
		}

		// Token: 0x0600809E RID: 32926 RVA: 0x0012FCA3 File Offset: 0x0012DEA3
		private void Append(char c)
		{
			this._str.Append(c);
		}

		// Token: 0x0600809F RID: 32927 RVA: 0x0012FCB2 File Offset: 0x0012DEB2
		internal static string ToString(Type type, TypeNameBuilder.Format format)
		{
			if ((format == TypeNameBuilder.Format.FullName || format == TypeNameBuilder.Format.AssemblyQualifiedName) && !type.IsGenericTypeDefinition && type.ContainsGenericParameters)
			{
				return null;
			}
			TypeNameBuilder typeNameBuilder = new TypeNameBuilder();
			typeNameBuilder.AddAssemblyQualifiedName(type, format);
			return typeNameBuilder.ToString();
		}

		// Token: 0x060080A0 RID: 32928 RVA: 0x0012FCE0 File Offset: 0x0012DEE0
		private void AddElementType(Type type)
		{
			if (!type.HasElementType)
			{
				return;
			}
			this.AddElementType(type.GetElementType());
			if (type.IsPointer)
			{
				this.Append('*');
				return;
			}
			if (type.IsByRef)
			{
				this.Append('&');
				return;
			}
			if (type.IsSZArray)
			{
				this.Append("[]");
				return;
			}
			if (type.IsArray)
			{
				this.AddArray(type.GetArrayRank());
			}
		}

		// Token: 0x060080A1 RID: 32929 RVA: 0x0012FD4C File Offset: 0x0012DF4C
		private void AddAssemblyQualifiedName(Type type, TypeNameBuilder.Format format)
		{
			Type type2 = type;
			while (type2.HasElementType)
			{
				type2 = type2.GetElementType();
			}
			List<Type> list = new List<Type>();
			Type type3 = type2;
			while (type3 != null)
			{
				list.Add(type3);
				type3 = (type3.IsGenericParameter ? null : type3.DeclaringType);
			}
			for (int i = list.Count - 1; i >= 0; i--)
			{
				Type type4 = list[i];
				string text = type4.Name;
				if (i == list.Count - 1 && !string.IsNullOrEmpty(type4.Namespace))
				{
					text = type4.Namespace + "." + text;
				}
				this.AddName(text);
			}
			if (type2.IsGenericType && (!type2.IsGenericTypeDefinition || format == TypeNameBuilder.Format.ToString))
			{
				Type[] genericArguments = type2.GetGenericArguments();
				this.OpenGenericArguments();
				for (int j = 0; j < genericArguments.Length; j++)
				{
					TypeNameBuilder.Format format2 = (format == TypeNameBuilder.Format.FullName) ? TypeNameBuilder.Format.AssemblyQualifiedName : format;
					this.OpenGenericArgument();
					this.AddAssemblyQualifiedName(genericArguments[j], format2);
					this.CloseGenericArgument();
				}
				this.CloseGenericArguments();
			}
			this.AddElementType(type);
			if (format == TypeNameBuilder.Format.AssemblyQualifiedName)
			{
				this.AddAssemblySpec(type.Module.Assembly.FullName);
			}
		}

		// Token: 0x04001AC5 RID: 6853
		private readonly StringBuilder _str = new StringBuilder();

		// Token: 0x04001AC6 RID: 6854
		private int _instNesting;

		// Token: 0x04001AC7 RID: 6855
		private bool _firstInstArg;

		// Token: 0x04001AC8 RID: 6856
		private bool _nestedName;

		// Token: 0x04001AC9 RID: 6857
		private bool _hasAssemblySpec;

		// Token: 0x04001ACA RID: 6858
		private readonly List<int> _stack = new List<int>();

		// Token: 0x04001ACB RID: 6859
		private int _stackIdx;

		// Token: 0x020007D6 RID: 2006
		internal enum Format
		{
			// Token: 0x04001ACD RID: 6861
			ToString,
			// Token: 0x04001ACE RID: 6862
			FullName,
			// Token: 0x04001ACF RID: 6863
			AssemblyQualifiedName
		}
	}
}
