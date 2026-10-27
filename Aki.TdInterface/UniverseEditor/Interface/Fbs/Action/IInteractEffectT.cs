using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006982 RID: 27010
	public class IInteractEffectT
	{
		// Token: 0x1700C853 RID: 51283
		// (get) Token: 0x0602F2C6 RID: 193222 RVA: 0x0066D11E File Offset: 0x0066B31E
		// (set) Token: 0x0602F2C7 RID: 193223 RVA: 0x0066D126 File Offset: 0x0066B326
		public EInteractEffectType Type { get; set; }

		// Token: 0x1700C854 RID: 51284
		// (get) Token: 0x0602F2C8 RID: 193224 RVA: 0x0066D12F File Offset: 0x0066B32F
		// (set) Token: 0x0602F2C9 RID: 193225 RVA: 0x0066D137 File Offset: 0x0066B337
		public float DelayTime { get; set; }

		// Token: 0x1700C855 RID: 51285
		// (get) Token: 0x0602F2CA RID: 193226 RVA: 0x0066D140 File Offset: 0x0066B340
		// (set) Token: 0x0602F2CB RID: 193227 RVA: 0x0066D148 File Offset: 0x0066B348
		public byte NullMask { get; set; }

		// Token: 0x0602F2CC RID: 193228 RVA: 0x0066D151 File Offset: 0x0066B351
		public IInteractEffectT()
		{
			this.Type = EInteractEffectType.ModifyTipText;
			this.DelayTime = 0f;
			this.NullMask = 0;
		}
	}
}
