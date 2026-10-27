using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C8A RID: 3210
	public class IDirectionFill : IFillType
	{
		// Token: 0x06004972 RID: 18802 RVA: 0x000B81BE File Offset: 0x000B63BE
		[NullableContext(1)]
		public static IDirectionFill Create(IDirectionFill? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDirectionFill
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700161B RID: 5659
		// (get) Token: 0x06004973 RID: 18803 RVA: 0x000B81DD File Offset: 0x000B63DD
		public override EFillType Type
		{
			get
			{
				return (EFillType)this.Instance.Type;
			}
		}

		// Token: 0x1700161C RID: 5660
		// (get) Token: 0x06004974 RID: 18804 RVA: 0x000B81EA File Offset: 0x000B63EA
		public virtual bool W
		{
			get
			{
				return this.Instance.W;
			}
		}

		// Token: 0x1700161D RID: 5661
		// (get) Token: 0x06004975 RID: 18805 RVA: 0x000B81F7 File Offset: 0x000B63F7
		public virtual bool S
		{
			get
			{
				return this.Instance.S;
			}
		}

		// Token: 0x1700161E RID: 5662
		// (get) Token: 0x06004976 RID: 18806 RVA: 0x000B8204 File Offset: 0x000B6404
		public virtual bool A
		{
			get
			{
				return this.Instance.A;
			}
		}

		// Token: 0x1700161F RID: 5663
		// (get) Token: 0x06004977 RID: 18807 RVA: 0x000B8211 File Offset: 0x000B6411
		public virtual bool D
		{
			get
			{
				return this.Instance.D;
			}
		}

		// Token: 0x040029E5 RID: 10725
		private IDirectionFill Instance;
	}
}
