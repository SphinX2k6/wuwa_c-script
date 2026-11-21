using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001E47 RID: 7751
	public class IMp4UiReplaceMaterial : IProgramSpecialConfigBase
	{
		// Token: 0x0600A4D5 RID: 42197 RVA: 0x00178580 File Offset: 0x00176780
		private IMp4UiReplaceMaterial_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IMp4UiReplaceMaterial 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IMp4UiReplaceMaterial_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IMp4UiReplaceMaterial_SetValue());
			}
			return result;
		}

		// Token: 0x0600A4D6 RID: 42198 RVA: 0x001785B8 File Offset: 0x001767B8
		public static IMp4UiReplaceMaterial Create([Nullable(2)] IMp4UiReplaceMaterial instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMp4UiReplaceMaterial
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A4D7 RID: 42199 RVA: 0x001785CB File Offset: 0x001767CB
		public static IMp4UiReplaceMaterial CreateFromSetValue([Nullable(2)] IMp4UiReplaceMaterial_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IMp4UiReplaceMaterial
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A4D8 RID: 42200 RVA: 0x001785DE File Offset: 0x001767DE
		public new IMp4UiReplaceMaterial_SetValue ToSetValue()
		{
			return new IMp4UiReplaceMaterial_SetValue
			{
				Type = this.Type,
				Mp4UiReplaceMaterial = this.Mp4UiReplaceMaterial
			};
		}

		// Token: 0x1700330E RID: 13070
		// (get) Token: 0x0600A4D9 RID: 42201 RVA: 0x001785FD File Offset: 0x001767FD
		// (set) Token: 0x0600A4DA RID: 42202 RVA: 0x00178628 File Offset: 0x00176828
		public override EPlayMovieProgramSpecialConfigType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EPlayMovieProgramSpecialConfigType.Mp4UiReplaceMaterial;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x1700330F RID: 13071
		// (get) Token: 0x0600A4DB RID: 42203 RVA: 0x00178636 File Offset: 0x00176836
		// (set) Token: 0x0600A4DC RID: 42204 RVA: 0x00178661 File Offset: 0x00176861
		public virtual string Mp4UiReplaceMaterial
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Mp4UiReplaceMaterial;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.Mp4UiReplaceMaterial;
			}
			set
			{
				this.GetOrCreatePoco().Mp4UiReplaceMaterial = value;
			}
		}

		// Token: 0x040063A7 RID: 25511
		[Nullable(2)]
		protected new IMp4UiReplaceMaterial FbInstance;

		// Token: 0x040063A8 RID: 25512
		[Nullable(2)]
		protected new IMp4UiReplaceMaterial_SetValue PocoInterface;
	}
}
