using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200211A RID: 8474
	public class ISubScreenPresetInitData : ISubScreenInitData
	{
		// Token: 0x0600B3F2 RID: 46066 RVA: 0x001938BC File Offset: 0x00191ABC
		private ISubScreenPresetInitData_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISubScreenPresetInitData 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISubScreenPresetInitData_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISubScreenPresetInitData_SetValue());
			}
			return result;
		}

		// Token: 0x0600B3F3 RID: 46067 RVA: 0x001938F4 File Offset: 0x00191AF4
		public static ISubScreenPresetInitData Create([Nullable(2)] ISubScreenPresetInitData instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISubScreenPresetInitData
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B3F4 RID: 46068 RVA: 0x00193907 File Offset: 0x00191B07
		public static ISubScreenPresetInitData CreateFromSetValue([Nullable(2)] ISubScreenPresetInitData_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISubScreenPresetInitData
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B3F5 RID: 46069 RVA: 0x0019391A File Offset: 0x00191B1A
		public new ISubScreenPresetInitData_SetValue ToSetValue()
		{
			return new ISubScreenPresetInitData_SetValue
			{
				Type = this.Type,
				SubScreenKey = this.SubScreenKey,
				AnchorType = this.AnchorType
			};
		}

		// Token: 0x17003661 RID: 13921
		// (get) Token: 0x0600B3F6 RID: 46070 RVA: 0x00193945 File Offset: 0x00191B45
		// (set) Token: 0x0600B3F7 RID: 46071 RVA: 0x00193970 File Offset: 0x00191B70
		public override ESubScreenInitDataType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESubScreenInitDataType.Preset;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17003662 RID: 13922
		// (get) Token: 0x0600B3F8 RID: 46072 RVA: 0x0019397E File Offset: 0x00191B7E
		// (set) Token: 0x0600B3F9 RID: 46073 RVA: 0x001939A9 File Offset: 0x00191BA9
		public override string SubScreenKey
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SubScreenKey;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.SubScreenKey;
			}
			set
			{
				this.GetOrCreatePoco().SubScreenKey = value;
			}
		}

		// Token: 0x17003663 RID: 13923
		// (get) Token: 0x0600B3FA RID: 46074 RVA: 0x001939B7 File Offset: 0x00191BB7
		// (set) Token: 0x0600B3FB RID: 46075 RVA: 0x001939E2 File Offset: 0x00191BE2
		public virtual ESubScreenInitPreset AnchorType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.AnchorType;
				}
				if (this.PocoInterface == null)
				{
					return ESubScreenInitPreset.Left;
				}
				return this.PocoInterface.AnchorType;
			}
			set
			{
				this.GetOrCreatePoco().AnchorType = value;
			}
		}

		// Token: 0x04006A9C RID: 27292
		[Nullable(2)]
		protected new ISubScreenPresetInitData FbInstance;

		// Token: 0x04006A9D RID: 27293
		[Nullable(2)]
		protected new ISubScreenPresetInitData_SetValue PocoInterface;
	}
}
