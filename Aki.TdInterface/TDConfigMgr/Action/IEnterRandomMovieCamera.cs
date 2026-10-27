using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001A04 RID: 6660
	[NullableContext(1)]
	[Nullable(0)]
	public class IEnterRandomMovieCamera : IEnterMovieCameraType
	{
		// Token: 0x06008EAF RID: 36527 RVA: 0x0014D978 File Offset: 0x0014BB78
		private IEnterRandomMovieCamera_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IEnterRandomMovieCamera 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IEnterRandomMovieCamera_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IEnterRandomMovieCamera_SetValue());
			}
			return result;
		}

		// Token: 0x06008EB0 RID: 36528 RVA: 0x0014D9B0 File Offset: 0x0014BBB0
		public static IEnterRandomMovieCamera Create([Nullable(2)] IEnterRandomMovieCamera instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEnterRandomMovieCamera
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008EB1 RID: 36529 RVA: 0x0014D9C3 File Offset: 0x0014BBC3
		public static IEnterRandomMovieCamera CreateFromSetValue([Nullable(2)] IEnterRandomMovieCamera_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IEnterRandomMovieCamera
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008EB2 RID: 36530 RVA: 0x0014D9D6 File Offset: 0x0014BBD6
		public new IEnterRandomMovieCamera_SetValue ToSetValue()
		{
			return new IEnterRandomMovieCamera_SetValue
			{
				Type = this.Type,
				RowNames = this.RowNames
			};
		}

		// Token: 0x17002DA6 RID: 11686
		// (get) Token: 0x06008EB3 RID: 36531 RVA: 0x0014D9F5 File Offset: 0x0014BBF5
		// (set) Token: 0x06008EB4 RID: 36532 RVA: 0x0014DA20 File Offset: 0x0014BC20
		public override EMovieCameraType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EMovieCameraType.Common;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002DA7 RID: 11687
		// (get) Token: 0x06008EB5 RID: 36533 RVA: 0x0014DA2E File Offset: 0x0014BC2E
		// (set) Token: 0x06008EB6 RID: 36534 RVA: 0x0014DA55 File Offset: 0x0014BC55
		public virtual List<string> RowNames
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.RowNames;
				}
				IEnterRandomMovieCamera_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.RowNames;
			}
			set
			{
				this.GetOrCreatePoco().RowNames = value;
			}
		}

		// Token: 0x04005865 RID: 22629
		[Nullable(2)]
		protected new IEnterRandomMovieCamera FbInstance;

		// Token: 0x04005866 RID: 22630
		[Nullable(2)]
		protected new IEnterRandomMovieCamera_SetValue PocoInterface;
	}
}
