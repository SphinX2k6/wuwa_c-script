using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001CF1 RID: 7409
	public class IInstrumentQteGameplay : IUiGame
	{
		// Token: 0x06009D3F RID: 40255 RVA: 0x0016A174 File Offset: 0x00168374
		private IInstrumentQteGameplay_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IInstrumentQteGameplay 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IInstrumentQteGameplay_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IInstrumentQteGameplay_SetValue());
			}
			return result;
		}

		// Token: 0x06009D40 RID: 40256 RVA: 0x0016A1AC File Offset: 0x001683AC
		public static IInstrumentQteGameplay Create([Nullable(2)] IInstrumentQteGameplay instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInstrumentQteGameplay
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009D41 RID: 40257 RVA: 0x0016A1BF File Offset: 0x001683BF
		public static IInstrumentQteGameplay CreateFromSetValue([Nullable(2)] IInstrumentQteGameplay_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IInstrumentQteGameplay
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009D42 RID: 40258 RVA: 0x0016A1D2 File Offset: 0x001683D2
		public new IInstrumentQteGameplay_SetValue ToSetValue()
		{
			return new IInstrumentQteGameplay_SetValue
			{
				Type = this.Type,
				InstrumentType = this.InstrumentType,
				Id = this.Id
			};
		}

		// Token: 0x17003144 RID: 12612
		// (get) Token: 0x06009D43 RID: 40259 RVA: 0x0016A1FD File Offset: 0x001683FD
		// (set) Token: 0x06009D44 RID: 40260 RVA: 0x0016A228 File Offset: 0x00168428
		public override ESimpleGameplayType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESimpleGameplayType.Cipher;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17003145 RID: 12613
		// (get) Token: 0x06009D45 RID: 40261 RVA: 0x0016A236 File Offset: 0x00168436
		// (set) Token: 0x06009D46 RID: 40262 RVA: 0x0016A261 File Offset: 0x00168461
		public virtual EInstrumentType InstrumentType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.InstrumentType;
				}
				if (this.PocoInterface == null)
				{
					return EInstrumentType.ChineseZither;
				}
				return this.PocoInterface.InstrumentType;
			}
			set
			{
				this.GetOrCreatePoco().InstrumentType = value;
			}
		}

		// Token: 0x17003146 RID: 12614
		// (get) Token: 0x06009D47 RID: 40263 RVA: 0x0016A26F File Offset: 0x0016846F
		// (set) Token: 0x06009D48 RID: 40264 RVA: 0x0016A29A File Offset: 0x0016849A
		public virtual int Id
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Id;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Id;
			}
			set
			{
				this.GetOrCreatePoco().Id = value;
			}
		}

		// Token: 0x04006003 RID: 24579
		[Nullable(2)]
		protected new IInstrumentQteGameplay FbInstance;

		// Token: 0x04006004 RID: 24580
		[Nullable(2)]
		protected new IInstrumentQteGameplay_SetValue PocoInterface;
	}
}
