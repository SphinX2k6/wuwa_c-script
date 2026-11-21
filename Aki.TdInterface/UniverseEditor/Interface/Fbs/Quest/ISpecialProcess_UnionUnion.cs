using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004581 RID: 17793
	public class ISpecialProcess_UnionUnion
	{
		// Token: 0x17007C4F RID: 31823
		// (get) Token: 0x06019E97 RID: 106135 RVA: 0x003B1F15 File Offset: 0x003B0115
		// (set) Token: 0x06019E98 RID: 106136 RVA: 0x003B1F1D File Offset: 0x003B011D
		public ISpecialProcess_Union Type { get; set; }

		// Token: 0x17007C50 RID: 31824
		// (get) Token: 0x06019E99 RID: 106137 RVA: 0x003B1F26 File Offset: 0x003B0126
		// (set) Token: 0x06019E9A RID: 106138 RVA: 0x003B1F2E File Offset: 0x003B012E
		public object Value { get; set; }

		// Token: 0x06019E9B RID: 106139 RVA: 0x003B1F37 File Offset: 0x003B0137
		public ISpecialProcess_UnionUnion()
		{
			this.Type = ISpecialProcess_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06019E9C RID: 106140 RVA: 0x003B1F4D File Offset: 0x003B014D
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06019E9D RID: 106141 RVA: 0x003B1F5F File Offset: 0x003B015F
		public ISpecialProcessT AsISpecialProcess()
		{
			return this.As<ISpecialProcessT>();
		}

		// Token: 0x06019E9E RID: 106142 RVA: 0x003B1F67 File Offset: 0x003B0167
		public static ISpecialProcess_UnionUnion FromISpecialProcess(ISpecialProcessT _ispecialprocess)
		{
			return new ISpecialProcess_UnionUnion
			{
				Type = ISpecialProcess_Union.ISpecialProcess,
				Value = _ispecialprocess
			};
		}

		// Token: 0x06019E9F RID: 106143 RVA: 0x003B1F7C File Offset: 0x003B017C
		public ILowMemorySceneSwitchT AsILowMemorySceneSwitch()
		{
			return this.As<ILowMemorySceneSwitchT>();
		}

		// Token: 0x06019EA0 RID: 106144 RVA: 0x003B1F84 File Offset: 0x003B0184
		public static ISpecialProcess_UnionUnion FromILowMemorySceneSwitch(ILowMemorySceneSwitchT _ilowmemorysceneswitch)
		{
			return new ISpecialProcess_UnionUnion
			{
				Type = ISpecialProcess_Union.ILowMemorySceneSwitch,
				Value = _ilowmemorysceneswitch
			};
		}

		// Token: 0x06019EA1 RID: 106145 RVA: 0x003B1F9C File Offset: 0x003B019C
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
