using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020041FA RID: 16890
	public class IDarkTideModule_UnionUnion
	{
		// Token: 0x17007301 RID: 29441
		// (get) Token: 0x06017706 RID: 96006 RVA: 0x00359381 File Offset: 0x00357581
		// (set) Token: 0x06017707 RID: 96007 RVA: 0x00359389 File Offset: 0x00357589
		public IDarkTideModule_Union Type { get; set; }

		// Token: 0x17007302 RID: 29442
		// (get) Token: 0x06017708 RID: 96008 RVA: 0x00359392 File Offset: 0x00357592
		// (set) Token: 0x06017709 RID: 96009 RVA: 0x0035939A File Offset: 0x0035759A
		public object Value { get; set; }

		// Token: 0x0601770A RID: 96010 RVA: 0x003593A3 File Offset: 0x003575A3
		public IDarkTideModule_UnionUnion()
		{
			this.Type = IDarkTideModule_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0601770B RID: 96011 RVA: 0x003593B9 File Offset: 0x003575B9
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601770C RID: 96012 RVA: 0x003593CB File Offset: 0x003575CB
		public IDarkTideModuleT AsIDarkTideModule()
		{
			return this.As<IDarkTideModuleT>();
		}

		// Token: 0x0601770D RID: 96013 RVA: 0x003593D3 File Offset: 0x003575D3
		public static IDarkTideModule_UnionUnion FromIDarkTideModule(IDarkTideModuleT _idarktidemodule)
		{
			return new IDarkTideModule_UnionUnion
			{
				Type = IDarkTideModule_Union.IDarkTideModule,
				Value = _idarktidemodule
			};
		}

		// Token: 0x0601770E RID: 96014 RVA: 0x003593E8 File Offset: 0x003575E8
		public IDarkTideBossEventModuleT AsIDarkTideBossEventModule()
		{
			return this.As<IDarkTideBossEventModuleT>();
		}

		// Token: 0x0601770F RID: 96015 RVA: 0x003593F0 File Offset: 0x003575F0
		public static IDarkTideModule_UnionUnion FromIDarkTideBossEventModule(IDarkTideBossEventModuleT _idarktidebosseventmodule)
		{
			return new IDarkTideModule_UnionUnion
			{
				Type = IDarkTideModule_Union.IDarkTideBossEventModule,
				Value = _idarktidebosseventmodule
			};
		}

		// Token: 0x06017710 RID: 96016 RVA: 0x00359408 File Offset: 0x00357608
		public static int Pack(FlatBufferBuilder builder, IDarkTideModule_UnionUnion _o)
		{
			IDarkTideModule_Union type = _o.Type;
			if (type == IDarkTideModule_Union.IDarkTideModule)
			{
				return IDarkTideModule.Pack(builder, _o.AsIDarkTideModule()).Value;
			}
			if (type != IDarkTideModule_Union.IDarkTideBossEventModule)
			{
				return 0;
			}
			return IDarkTideBossEventModule.Pack(builder, _o.AsIDarkTideBossEventModule()).Value;
		}
	}
}
