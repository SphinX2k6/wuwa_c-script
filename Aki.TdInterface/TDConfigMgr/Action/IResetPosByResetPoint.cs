using System;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001FC7 RID: 8135
	[JsonConverter(typeof(IResetPosByResetPointConverter))]
	public class IResetPosByResetPoint : IResetPosType
	{
		// Token: 0x0600ACDF RID: 44255 RVA: 0x0018690C File Offset: 0x00184B0C
		private IResetPosByResetPoint_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IResetPosByResetPoint 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IResetPosByResetPoint_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IResetPosByResetPoint_SetValue());
			}
			return result;
		}

		// Token: 0x0600ACE0 RID: 44256 RVA: 0x00186944 File Offset: 0x00184B44
		public static IResetPosByResetPoint Create([Nullable(2)] IResetPosByResetPoint instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IResetPosByResetPoint
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600ACE1 RID: 44257 RVA: 0x00186957 File Offset: 0x00184B57
		public static IResetPosByResetPoint CreateFromSetValue([Nullable(2)] IResetPosByResetPoint_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IResetPosByResetPoint
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600ACE2 RID: 44258 RVA: 0x0018696A File Offset: 0x00184B6A
		public new IResetPosByResetPoint_SetValue ToSetValue()
		{
			return new IResetPosByResetPoint_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170034D3 RID: 13523
		// (get) Token: 0x0600ACE3 RID: 44259 RVA: 0x0018697D File Offset: 0x00184B7D
		// (set) Token: 0x0600ACE4 RID: 44260 RVA: 0x001869A8 File Offset: 0x00184BA8
		public override EResetPosType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EResetPosType.PosEntity;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04006746 RID: 26438
		[Nullable(2)]
		protected new IResetPosByResetPoint FbInstance;

		// Token: 0x04006747 RID: 26439
		[Nullable(2)]
		protected new IResetPosByResetPoint_SetValue PocoInterface;
	}
}
