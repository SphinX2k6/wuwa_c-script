using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004140 RID: 16704
	public class ISpecialProcess_UnionUnion
	{
		// Token: 0x17007649 RID: 30281
		// (get) Token: 0x060187F4 RID: 100340 RVA: 0x00387F0D File Offset: 0x0038610D
		// (set) Token: 0x060187F5 RID: 100341 RVA: 0x00387F15 File Offset: 0x00386115
		public ISpecialProcess_Union Type { get; set; }

		// Token: 0x1700764A RID: 30282
		// (get) Token: 0x060187F6 RID: 100342 RVA: 0x00387F1E File Offset: 0x0038611E
		// (set) Token: 0x060187F7 RID: 100343 RVA: 0x00387F26 File Offset: 0x00386126
		public object Value { get; set; }

		// Token: 0x060187F8 RID: 100344 RVA: 0x00387F2F File Offset: 0x0038612F
		public ISpecialProcess_UnionUnion()
		{
			this.Type = ISpecialProcess_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060187F9 RID: 100345 RVA: 0x00387F45 File Offset: 0x00386145
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060187FA RID: 100346 RVA: 0x00387F57 File Offset: 0x00386157
		public ISpecialProcessT AsISpecialProcess()
		{
			return this.As<ISpecialProcessT>();
		}

		// Token: 0x060187FB RID: 100347 RVA: 0x00387F5F File Offset: 0x0038615F
		public static ISpecialProcess_UnionUnion FromISpecialProcess(ISpecialProcessT _ispecialprocess)
		{
			return new ISpecialProcess_UnionUnion
			{
				Type = ISpecialProcess_Union.ISpecialProcess,
				Value = _ispecialprocess
			};
		}

		// Token: 0x060187FC RID: 100348 RVA: 0x00387F74 File Offset: 0x00386174
		public ILowMemorySceneSwitchT AsILowMemorySceneSwitch()
		{
			return this.As<ILowMemorySceneSwitchT>();
		}

		// Token: 0x060187FD RID: 100349 RVA: 0x00387F7C File Offset: 0x0038617C
		public static ISpecialProcess_UnionUnion FromILowMemorySceneSwitch(ILowMemorySceneSwitchT _ilowmemorysceneswitch)
		{
			return new ISpecialProcess_UnionUnion
			{
				Type = ISpecialProcess_Union.ILowMemorySceneSwitch,
				Value = _ilowmemorysceneswitch
			};
		}

		// Token: 0x060187FE RID: 100350 RVA: 0x00387F94 File Offset: 0x00386194
		public static int Pack(FlatBufferBuilder builder, ISpecialProcess_UnionUnion _o)
		{
			ISpecialProcess_Union type = _o.Type;
			if (type == ISpecialProcess_Union.ISpecialProcess)
			{
				return ISpecialProcess.Pack(builder, _o.AsISpecialProcess()).Value;
			}
			if (type != ISpecialProcess_Union.ILowMemorySceneSwitch)
			{
				return 0;
			}
			return ILowMemorySceneSwitch.Pack(builder, _o.AsILowMemorySceneSwitch()).Value;
		}
	}
}
