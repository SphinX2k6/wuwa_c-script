using System;
using System.ComponentModel;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace System.Collections
{
	// Token: 0x0200096A RID: 2410
	[NullableContext(1)]
	[Nullable(0)]
	[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	public sealed class Comparer : IComparer, ISerializable
	{
		// Token: 0x06008FFA RID: 36858 RVA: 0x00163D6D File Offset: 0x00161F6D
		public Comparer(CultureInfo culture)
		{
			ArgumentNullException.ThrowIfNull(culture, "culture");
			this._compareInfo = culture.CompareInfo;
		}

		// Token: 0x06008FFB RID: 36859 RVA: 0x00163D8C File Offset: 0x00161F8C
		private Comparer(SerializationInfo info, StreamingContext context)
		{
			ArgumentNullException.ThrowIfNull(info, "info");
			this._compareInfo = (CompareInfo)info.GetValue("CompareInfo", typeof(CompareInfo));
		}

		// Token: 0x06008FFC RID: 36860 RVA: 0x00163DBF File Offset: 0x00161FBF
		[Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			ArgumentNullException.ThrowIfNull(info, "info");
			info.AddValue("CompareInfo", this._compareInfo);
		}

		// Token: 0x06008FFD RID: 36861 RVA: 0x00163DE0 File Offset: 0x00161FE0
		[NullableContext(2)]
		public int Compare(object a, object b)
		{
			if (a == b)
			{
				return 0;
			}
			if (a == null)
			{
				return -1;
			}
			if (b == null)
			{
				return 1;
			}
			string text = a as string;
			if (text != null)
			{
				string text2 = b as string;
				if (text2 != null)
				{
					return this._compareInfo.Compare(text, text2);
				}
			}
			IComparable comparable = a as IComparable;
			if (comparable != null)
			{
				return comparable.CompareTo(b);
			}
			IComparable comparable2 = b as IComparable;
			if (comparable2 != null)
			{
				return -comparable2.CompareTo(a);
			}
			throw new ArgumentException(SR.Argument_ImplementIComparable);
		}

		// Token: 0x040021F0 RID: 8688
		private readonly CompareInfo _compareInfo;

		// Token: 0x040021F1 RID: 8689
		public static readonly Comparer Default = new Comparer(CultureInfo.CurrentCulture);

		// Token: 0x040021F2 RID: 8690
		public static readonly Comparer DefaultInvariant = new Comparer(CultureInfo.InvariantCulture);
	}
}
