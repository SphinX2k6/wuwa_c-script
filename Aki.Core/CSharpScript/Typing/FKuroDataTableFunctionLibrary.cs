using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Typing
{
	// Token: 0x02000120 RID: 288
	[NullableContext(1)]
	[Nullable(0)]
	public class FKuroDataTableFunctionLibrary
	{
		// Token: 0x06000A9E RID: 2718
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern IntPtr GetDataTableAllRowNames(UDataTable Table);

		// Token: 0x06000A9F RID: 2719
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern IntPtr GetDataTableRowFromName(UDataTable Table, string RowName);

		// Token: 0x06000AA0 RID: 2720
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern IntPtr[] GetDataTableAllRows(UDataTable Table);

		// Token: 0x06000AA1 RID: 2721
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void GetDataTableAllRowWithKeys(UDataTable Table, ref IntPtr OutRowNames, ref IntPtr[] OutRows);
	}
}
