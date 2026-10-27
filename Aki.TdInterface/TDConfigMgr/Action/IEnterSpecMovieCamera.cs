using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001A06 RID: 6662
	[NullableContext(1)]
	[Nullable(0)]
	public class IEnterSpecMovieCamera : IEnterMovieCameraType
	{
		// Token: 0x06008EB9 RID: 36537 RVA: 0x0014DA74 File Offset: 0x0014BC74
		private IEnterSpecMovieCamera_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IEnterSpecMovieCamera 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IEnterSpecMovieCamera_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IEnterSpecMovieCamera_SetValue());
			}
			return result;
		}

		// Token: 0x06008EBA RID: 36538 RVA: 0x0014DAAC File Offset: 0x0014BCAC
		public static IEnterSpecMovieCamera Create([Nullable(2)] IEnterSpecMovieCamera instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEnterSpecMovieCamera
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008EBB RID: 36539 RVA: 0x0014DABF File Offset: 0x0014BCBF
		public static IEnterSpecMovieCamera CreateFromSetValue([Nullable(2)] IEnterSpecMovieCamera_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IEnterSpecMovieCamera
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008EBC RID: 36540 RVA: 0x0014DAD2 File Offset: 0x0014BCD2
		public new IEnterSpecMovieCamera_SetValue ToSetValue()
		{
			return new IEnterSpecMovieCamera_SetValue
			{
				Type = this.Type,
				RowName = this.RowName
			};
		}

		// Token: 0x17002DA8 RID: 11688
		// (get) Token: 0x06008EBD RID: 36541 RVA: 0x0014DAF1 File Offset: 0x0014BCF1
		// (set) Token: 0x06008EBE RID: 36542 RVA: 0x0014DB1C File Offset: 0x0014BD1C
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

		// Token: 0x17002DA9 RID: 11689
		// (get) Token: 0x06008EBF RID: 36543 RVA: 0x0014DB2A File Offset: 0x0014BD2A
		// (set) Token: 0x06008EC0 RID: 36544 RVA: 0x0014DB55 File Offset: 0x0014BD55
		public virtual string RowName
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.RowName;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.RowName;
			}
			set
			{
				this.GetOrCreatePoco().RowName = value;
			}
		}

		// Token: 0x04005869 RID: 22633
		[Nullable(2)]
		protected new IEnterSpecMovieCamera FbInstance;

		// Token: 0x0400586A RID: 22634
		[Nullable(2)]
		protected new IEnterSpecMovieCamera_SetValue PocoInterface;
	}
}
