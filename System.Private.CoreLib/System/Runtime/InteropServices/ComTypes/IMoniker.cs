using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace System.Runtime.InteropServices.ComTypes
{
	// Token: 0x02000637 RID: 1591
	[NullableContext(1)]
	[Guid("0000000f-0000-0000-C000-000000000046")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[ComImport]
	public interface IMoniker
	{
		// Token: 0x0600726C RID: 29292
		void GetClassID(out Guid pClassID);

		// Token: 0x0600726D RID: 29293
		[PreserveSig]
		int IsDirty();

		// Token: 0x0600726E RID: 29294
		void Load(IStream pStm);

		// Token: 0x0600726F RID: 29295
		void Save(IStream pStm, [MarshalAs(UnmanagedType.Bool)] bool fClearDirty);

		// Token: 0x06007270 RID: 29296
		void GetSizeMax(out long pcbSize);

		// Token: 0x06007271 RID: 29297
		void BindToObject(IBindCtx pbc, [Nullable(2)] IMoniker pmkToLeft, [In] ref Guid riidResult, [MarshalAs(UnmanagedType.Interface)] out object ppvResult);

		// Token: 0x06007272 RID: 29298
		void BindToStorage(IBindCtx pbc, [Nullable(2)] IMoniker pmkToLeft, [In] ref Guid riid, [MarshalAs(UnmanagedType.Interface)] out object ppvObj);

		// Token: 0x06007273 RID: 29299
		[NullableContext(2)]
		void Reduce([Nullable(1)] IBindCtx pbc, int dwReduceHowFar, ref IMoniker ppmkToLeft, out IMoniker ppmkReduced);

		// Token: 0x06007274 RID: 29300
		void ComposeWith(IMoniker pmkRight, [MarshalAs(UnmanagedType.Bool)] bool fOnlyIfNotGeneric, [Nullable(2)] out IMoniker ppmkComposite);

		// Token: 0x06007275 RID: 29301
		[NullableContext(2)]
		void Enum([MarshalAs(UnmanagedType.Bool)] bool fForward, out IEnumMoniker ppenumMoniker);

		// Token: 0x06007276 RID: 29302
		[PreserveSig]
		int IsEqual(IMoniker pmkOtherMoniker);

		// Token: 0x06007277 RID: 29303
		void Hash(out int pdwHash);

		// Token: 0x06007278 RID: 29304
		[NullableContext(2)]
		[PreserveSig]
		int IsRunning([Nullable(1)] IBindCtx pbc, IMoniker pmkToLeft, IMoniker pmkNewlyRunning);

		// Token: 0x06007279 RID: 29305
		void GetTimeOfLastChange(IBindCtx pbc, [Nullable(2)] IMoniker pmkToLeft, out FILETIME pFileTime);

		// Token: 0x0600727A RID: 29306
		void Inverse(out IMoniker ppmk);

		// Token: 0x0600727B RID: 29307
		void CommonPrefixWith(IMoniker pmkOther, [Nullable(2)] out IMoniker ppmkPrefix);

		// Token: 0x0600727C RID: 29308
		void RelativePathTo(IMoniker pmkOther, [Nullable(2)] out IMoniker ppmkRelPath);

		// Token: 0x0600727D RID: 29309
		void GetDisplayName(IBindCtx pbc, [Nullable(2)] IMoniker pmkToLeft, [MarshalAs(UnmanagedType.LPWStr)] out string ppszDisplayName);

		// Token: 0x0600727E RID: 29310
		void ParseDisplayName(IBindCtx pbc, IMoniker pmkToLeft, [MarshalAs(UnmanagedType.LPWStr)] string pszDisplayName, out int pchEaten, out IMoniker ppmkOut);

		// Token: 0x0600727F RID: 29311
		[PreserveSig]
		int IsSystemMoniker(out int pdwMksys);
	}
}
