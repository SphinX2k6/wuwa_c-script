using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Typing
{
	// Token: 0x0200011F RID: 287
	[NullableContext(1)]
	[Nullable(0)]
	public class FKuroDataTableFunctionLibrary
	{
		// Token: 0x06000A47 RID: 2631
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern IntPtr GetDataTableAllRowNames(UDataTable Table);

		// Token: 0x06000A48 RID: 2632
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern IntPtr GetDataTableRowFromName(UDataTable Table, string RowName);

		// Token: 0x06000A49 RID: 2633
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern IntPtr[] GetDataTableAllRows(UDataTable Table);

		// Token: 0x06000A4A RID: 2634
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void GetDataTableAllRowWithKeys(UDataTable Table, ref IntPtr OutRowNames, ref IntPtr[] OutRows);
	}
}
