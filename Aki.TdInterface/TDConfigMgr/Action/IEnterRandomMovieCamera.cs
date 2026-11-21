using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B97 RID: 7063
	public class IEnterRandomMovieCamera : IEnterMovieCameraType
	{
		// Token: 0x06009611 RID: 38417 RVA: 0x0015D7E8 File Offset: 0x0015B9E8
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

		// Token: 0x06009612 RID: 38418 RVA: 0x0015D820 File Offset: 0x0015BA20
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

		// Token: 0x06009613 RID: 38419 RVA: 0x0015D833 File Offset: 0x0015BA33
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

		// Token: 0x06009614 RID: 38420 RVA: 0x0015D846 File Offset: 0x0015BA46
		public new IEnterRandomMovieCamera_SetValue ToSetValue()
		{
			return new IEnterRandomMovieCamera_SetValue
			{
				Type = this.Type,
				RowNames = this.RowNames
			};
		}

		// Token: 0x17002FB2 RID: 12210
		// (get) Token: 0x06009615 RID: 38421 RVA: 0x0015D865 File Offset: 0x0015BA65
		// (set) Token: 0x06009616 RID: 38422 RVA: 0x0015D890 File Offset: 0x0015BA90
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

		// Token: 0x17002FB3 RID: 12211
		// (get) Token: 0x06009617 RID: 38423 RVA: 0x0015D89E File Offset: 0x0015BA9E
		// (set) Token: 0x06009618 RID: 38424 RVA: 0x0015D8C5 File Offset: 0x0015BAC5
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

		// Token: 0x04005CC7 RID: 23751
		[Nullable(2)]
		protected new IEnterRandomMovieCamera FbInstance;

		// Token: 0x04005CC8 RID: 23752
		[Nullable(2)]
		protected new IEnterRandomMovieCamera_SetValue PocoInterface;
	}
}
