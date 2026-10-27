using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002523 RID: 9507
	public class ITalkBackgroundSpineImage : ITalkBackground
	{
		// Token: 0x0600D403 RID: 54275 RVA: 0x001F6705 File Offset: 0x001F4905
		[NullableContext(1)]
		public static ITalkBackgroundSpineImage Create(ITalkBackgroundSpineImage? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITalkBackgroundSpineImage
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003B7F RID: 15231
		// (get) Token: 0x0600D404 RID: 54276 RVA: 0x001F6724 File Offset: 0x001F4924
		public override ETalkBackgroundType Type
		{
			get
			{
				return (ETalkBackgroundType)this.Instance.Type;
			}
		}

		// Token: 0x17003B80 RID: 15232
		// (get) Token: 0x0600D405 RID: 54277 RVA: 0x001F6731 File Offset: 0x001F4931
		public virtual int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x17003B81 RID: 15233
		// (get) Token: 0x0600D406 RID: 54278 RVA: 0x001F6740 File Offset: 0x001F4940
		public virtual bool? IsLoop
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsLoop);
			}
		}

		// Token: 0x04007429 RID: 29737
		private ITalkBackgroundSpineImage Instance;
	}
}
