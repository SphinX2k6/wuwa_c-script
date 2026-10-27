using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002516 RID: 9494
	public class ITalkOptionRogueRandomEvent : ITalkOptionParamType
	{
		// Token: 0x0600D3BC RID: 54204 RVA: 0x001F5E48 File Offset: 0x001F4048
		[NullableContext(1)]
		public static ITalkOptionRogueRandomEvent Create(ITalkOptionRogueRandomEvent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITalkOptionRogueRandomEvent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003B52 RID: 15186
		// (get) Token: 0x0600D3BD RID: 54205 RVA: 0x001F5E67 File Offset: 0x001F4067
		public override ETalkOptionParamType Type
		{
			get
			{
				return (ETalkOptionParamType)this.Instance.Type;
			}
		}

		// Token: 0x17003B53 RID: 15187
		// (get) Token: 0x0600D3BE RID: 54206 RVA: 0x001F5E74 File Offset: 0x001F4074
		public virtual int? OptionId
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new int?(this.Instance.OptionId);
			}
		}

		// Token: 0x04007408 RID: 29704
		private ITalkOptionRogueRandomEvent Instance;
	}
}
