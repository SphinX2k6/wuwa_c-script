using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006DB9 RID: 28089
	public struct IProjectionMachinePhotoFilter : IFlatbufferObject
	{
		// Token: 0x1700D176 RID: 53622
		// (get) Token: 0x060319DD RID: 203229 RVA: 0x006B9103 File Offset: 0x006B7303
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060319DE RID: 203230 RVA: 0x006B9110 File Offset: 0x006B7310
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060319DF RID: 203231 RVA: 0x006B9118 File Offset: 0x006B7318
		public static IProjectionMachinePhotoFilter GetRootAsIProjectionMachinePhotoFilter(ByteBuffer _bb)
		{
			return IProjectionMachinePhotoFilter.GetRootAsIProjectionMachinePhotoFilter(_bb, default(IProjectionMachinePhotoFilter));
		}

		// Token: 0x060319E0 RID: 203232 RVA: 0x006B9134 File Offset: 0x006B7334
		public static IProjectionMachinePhotoFilter GetRootAsIProjectionMachinePhotoFilter(ByteBuffer _bb, IProjectionMachinePhotoFilter obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060319E1 RID: 203233 RVA: 0x006B9151 File Offset: 0x006B7351
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060319E2 RID: 203234 RVA: 0x006B9160 File Offset: 0x006B7360
		public IProjectionMachinePhotoFilter __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D177 RID: 53623
		// (get) Token: 0x060319E3 RID: 203235 RVA: 0x006B9170 File Offset: 0x006B7370
		public float DefaultParam1
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D178 RID: 53624
		// (get) Token: 0x060319E4 RID: 203236 RVA: 0x006B91B0 File Offset: 0x006B73B0
		public float DefaultParam2
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D179 RID: 53625
		// (get) Token: 0x060319E5 RID: 203237 RVA: 0x006B91F0 File Offset: 0x006B73F0
		public float TargetParam1
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D17A RID: 53626
		// (get) Token: 0x060319E6 RID: 203238 RVA: 0x006B9230 File Offset: 0x006B7430
		public float TargetParam2
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060319E7 RID: 203239 RVA: 0x006B9271 File Offset: 0x006B7471
		public static Offset<IProjectionMachinePhotoFilter> CreateIProjectionMachinePhotoFilter(FlatBufferBuilder builder, float DefaultParam1 = 0f, float DefaultParam2 = 0f, float TargetParam1 = 0f, float TargetParam2 = 0f)
		{
			builder.StartTable(4);
			IProjectionMachinePhotoFilter.AddTargetParam2(builder, TargetParam2);
			IProjectionMachinePhotoFilter.AddTargetParam1(builder, TargetParam1);
			IProjectionMachinePhotoFilter.AddDefaultParam2(builder, DefaultParam2);
			IProjectionMachinePhotoFilter.AddDefaultParam1(builder, DefaultParam1);
			return IProjectionMachinePhotoFilter.EndIProjectionMachinePhotoFilter(builder);
		}

		// Token: 0x060319E8 RID: 203240 RVA: 0x006B929D File Offset: 0x006B749D
		public static void StartIProjectionMachinePhotoFilter(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x060319E9 RID: 203241 RVA: 0x006B92A6 File Offset: 0x006B74A6
		public static void AddDefaultParam1(FlatBufferBuilder builder, float defaultParam1)
		{
			builder.AddFloat(0, defaultParam1, 0.0);
		}

		// Token: 0x060319EA RID: 203242 RVA: 0x006B92B9 File Offset: 0x006B74B9
		public static void AddDefaultParam2(FlatBufferBuilder builder, float defaultParam2)
		{
			builder.AddFloat(1, defaultParam2, 0.0);
		}

		// Token: 0x060319EB RID: 203243 RVA: 0x006B92CC File Offset: 0x006B74CC
		public static void AddTargetParam1(FlatBufferBuilder builder, float targetParam1)
		{
			builder.AddFloat(2, targetParam1, 0.0);
		}

		// Token: 0x060319EC RID: 203244 RVA: 0x006B92DF File Offset: 0x006B74DF
		public static void AddTargetParam2(FlatBufferBuilder builder, float targetParam2)
		{
			builder.AddFloat(3, targetParam2, 0.0);
		}

		// Token: 0x060319ED RID: 203245 RVA: 0x006B92F2 File Offset: 0x006B74F2
		public static Offset<IProjectionMachinePhotoFilter> EndIProjectionMachinePhotoFilter(FlatBufferBuilder builder)
		{
			return new Offset<IProjectionMachinePhotoFilter>(builder.EndTable());
		}

		// Token: 0x060319EE RID: 203246 RVA: 0x006B9300 File Offset: 0x006B7500
		public IProjectionMachinePhotoFilterT UnPack()
		{
			IProjectionMachinePhotoFilterT projectionMachinePhotoFilterT = new IProjectionMachinePhotoFilterT();
			this.UnPackTo(projectionMachinePhotoFilterT);
			return projectionMachinePhotoFilterT;
		}

		// Token: 0x060319EF RID: 203247 RVA: 0x006B931B File Offset: 0x006B751B
		public void UnPackTo(IProjectionMachinePhotoFilterT _o)
		{
			_o.DefaultParam1 = this.DefaultParam1;
			_o.DefaultParam2 = this.DefaultParam2;
			_o.TargetParam1 = this.TargetParam1;
			_o.TargetParam2 = this.TargetParam2;
		}

		// Token: 0x060319F0 RID: 203248 RVA: 0x006B9350 File Offset: 0x006B7550
		public static Offset<IProjectionMachinePhotoFilter> Pack(FlatBufferBuilder builder, IProjectionMachinePhotoFilterT _o)
		{
			if (_o == null)
			{
				return default(Offset<IProjectionMachinePhotoFilter>);
			}
			return IProjectionMachinePhotoFilter.CreateIProjectionMachinePhotoFilter(builder, _o.DefaultParam1, _o.DefaultParam2, _o.TargetParam1, _o.TargetParam2);
		}

		// Token: 0x04011796 RID: 71574
		private Table __p;
	}
}
