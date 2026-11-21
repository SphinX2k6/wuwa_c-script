using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace System
{
	// Token: 0x020001EF RID: 495
	[Obsolete("Formatter-based serialization is obsolete and should not be used.", DiagnosticId = "SYSLIB0050", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
	[Serializable]
	public sealed class UnitySerializationHolder : ISerializable, IObjectReference
	{
		// Token: 0x060027B3 RID: 10163 RVA: 0x00078150 File Offset: 0x00076350
		internal static void GetUnitySerializationInfo(SerializationInfo info, int unityType)
		{
			info.SetType(typeof(UnitySerializationHolder));
			info.AddValue("Data", null, typeof(string));
			info.AddValue("UnityType", unityType);
			info.AddValue("AssemblyName", string.Empty);
		}

		// Token: 0x060027B4 RID: 10164 RVA: 0x0007819F File Offset: 0x0007639F
		[NullableContext(1)]
		public UnitySerializationHolder(SerializationInfo info, StreamingContext context)
		{
			ArgumentNullException.ThrowIfNull(info, "info");
			this._unityType = info.GetInt32("UnityType");
			this._data = info.GetString("Data");
		}

		// Token: 0x060027B5 RID: 10165 RVA: 0x000781D4 File Offset: 0x000763D4
		[NullableContext(1)]
		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			throw new NotSupportedException(SR.NotSupported_UnitySerHolder);
		}

		// Token: 0x060027B6 RID: 10166 RVA: 0x000781E0 File Offset: 0x000763E0
		[NullableContext(1)]
		public object GetRealObject(StreamingContext context)
		{
			if (this._unityType != 2)
			{
				throw new ArgumentException(SR.Format(SR.Argument_InvalidUnity, this._data ?? "UnityType"));
			}
			return DBNull.Value;
		}

		// Token: 0x040006F1 RID: 1777
		private readonly int _unityType;

		// Token: 0x040006F2 RID: 1778
		private readonly string _data;
	}
}
