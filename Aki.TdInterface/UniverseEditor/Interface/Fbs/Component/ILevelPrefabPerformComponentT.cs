using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020054E9 RID: 21737
	public class ILevelPrefabPerformComponentT
	{
		// Token: 0x1700A056 RID: 41046
		// (get) Token: 0x06023DD3 RID: 146899 RVA: 0x004F5778 File Offset: 0x004F3978
		// (set) Token: 0x06023DD4 RID: 146900 RVA: 0x004F5780 File Offset: 0x004F3980
		public bool Disabled { get; set; }

		// Token: 0x1700A057 RID: 41047
		// (get) Token: 0x06023DD5 RID: 146901 RVA: 0x004F5789 File Offset: 0x004F3989
		// (set) Token: 0x06023DD6 RID: 146902 RVA: 0x004F5791 File Offset: 0x004F3991
		public List<ITowardEntityConfigT> TowardEntity { get; set; }

		// Token: 0x1700A058 RID: 41048
		// (get) Token: 0x06023DD7 RID: 146903 RVA: 0x004F579A File Offset: 0x004F399A
		// (set) Token: 0x06023DD8 RID: 146904 RVA: 0x004F57A2 File Offset: 0x004F39A2
		public ILevelPrefabParamsConfigT PrefabParams { get; set; }

		// Token: 0x1700A059 RID: 41049
		// (get) Token: 0x06023DD9 RID: 146905 RVA: 0x004F57AB File Offset: 0x004F39AB
		// (set) Token: 0x06023DDA RID: 146906 RVA: 0x004F57B3 File Offset: 0x004F39B3
		public List<IPrefabCompTransformT> CompTransform { get; set; }

		// Token: 0x1700A05A RID: 41050
		// (get) Token: 0x06023DDB RID: 146907 RVA: 0x004F57BC File Offset: 0x004F39BC
		// (set) Token: 0x06023DDC RID: 146908 RVA: 0x004F57C4 File Offset: 0x004F39C4
		public byte NullMask { get; set; }

		// Token: 0x06023DDD RID: 146909 RVA: 0x004F57CD File Offset: 0x004F39CD
		public ILevelPrefabPerformComponentT()
		{
			this.Disabled = false;
			this.TowardEntity = null;
			this.PrefabParams = null;
			this.CompTransform = null;
			this.NullMask = 0;
		}
	}
}
