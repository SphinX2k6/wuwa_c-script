using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020051B4 RID: 20916
	public class IEntityStateAudioComponentT
	{
		// Token: 0x170098E1 RID: 39137
		// (get) Token: 0x06021DD8 RID: 138712 RVA: 0x004B293A File Offset: 0x004B0B3A
		// (set) Token: 0x06021DD9 RID: 138713 RVA: 0x004B2942 File Offset: 0x004B0B42
		public bool Disabled { get; set; }

		// Token: 0x170098E2 RID: 39138
		// (get) Token: 0x06021DDA RID: 138714 RVA: 0x004B294B File Offset: 0x004B0B4B
		// (set) Token: 0x06021DDB RID: 138715 RVA: 0x004B2953 File Offset: 0x004B0B53
		public TAkEventTypeUnion AkEventType { get; set; }

		// Token: 0x170098E3 RID: 39139
		// (get) Token: 0x06021DDC RID: 138716 RVA: 0x004B295C File Offset: 0x004B0B5C
		// (set) Token: 0x06021DDD RID: 138717 RVA: 0x004B2964 File Offset: 0x004B0B64
		public EAudioRangeType AudioRangeType { get; set; }

		// Token: 0x170098E4 RID: 39140
		// (get) Token: 0x06021DDE RID: 138718 RVA: 0x004B296D File Offset: 0x004B0B6D
		// (set) Token: 0x06021DDF RID: 138719 RVA: 0x004B2975 File Offset: 0x004B0B75
		public List<IEntityStateAudioConfigT> Config { get; set; }

		// Token: 0x170098E5 RID: 39141
		// (get) Token: 0x06021DE0 RID: 138720 RVA: 0x004B297E File Offset: 0x004B0B7E
		// (set) Token: 0x06021DE1 RID: 138721 RVA: 0x004B2986 File Offset: 0x004B0B86
		public byte NullMask { get; set; }

		// Token: 0x06021DE2 RID: 138722 RVA: 0x004B298F File Offset: 0x004B0B8F
		public IEntityStateAudioComponentT()
		{
			this.Disabled = false;
			this.AkEventType = null;
			this.AudioRangeType = EAudioRangeType.SceneActorRefComp;
			this.Config = null;
			this.NullMask = 0;
		}
	}
}
