using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020055AD RID: 21933
	public struct ICurveControlConfig : IFlatbufferObject
	{
		// Token: 0x17009D0F RID: 40207
		// (get) Token: 0x06022E43 RID: 142915 RVA: 0x004CE137 File Offset: 0x004CC337
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06022E44 RID: 142916 RVA: 0x004CE144 File Offset: 0x004CC344
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06022E45 RID: 142917 RVA: 0x004CE14C File Offset: 0x004CC34C
		public static ICurveControlConfig GetRootAsICurveControlConfig(ByteBuffer _bb)
		{
			return ICurveControlConfig.GetRootAsICurveControlConfig(_bb, default(ICurveControlConfig));
		}

		// Token: 0x06022E46 RID: 142918 RVA: 0x004CE168 File Offset: 0x004CC368
		public static ICurveControlConfig GetRootAsICurveControlConfig(ByteBuffer _bb, ICurveControlConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06022E47 RID: 142919 RVA: 0x004CE185 File Offset: 0x004CC385
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06022E48 RID: 142920 RVA: 0x004CE194 File Offset: 0x004CC394
		public ICurveControlConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009D10 RID: 40208
		// (get) Token: 0x06022E49 RID: 142921 RVA: 0x004CE1A4 File Offset: 0x004CC3A4
		public ECurveControlType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECurveControlType.ChargeSlash;
				}
				return (ECurveControlType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06022E4A RID: 142922 RVA: 0x004CE1E0 File Offset: 0x004CC3E0
		public static Offset<ICurveControlConfig> CreateICurveControlConfig(FlatBufferBuilder builder, ECurveControlType Type = ECurveControlType.ChargeSlash)
		{
			builder.StartTable(1);
			ICurveControlConfig.AddType(builder, Type);
			return ICurveControlConfig.EndICurveControlConfig(builder);
		}

		// Token: 0x06022E4B RID: 142923 RVA: 0x004CE1F6 File Offset: 0x004CC3F6
		public static void StartICurveControlConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06022E4C RID: 142924 RVA: 0x004CE1FF File Offset: 0x004CC3FF
		public static void AddType(FlatBufferBuilder builder, ECurveControlType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06022E4D RID: 142925 RVA: 0x004CE20A File Offset: 0x004CC40A
		public static Offset<ICurveControlConfig> EndICurveControlConfig(FlatBufferBuilder builder)
		{
			return new Offset<ICurveControlConfig>(builder.EndTable());
		}

		// Token: 0x06022E4E RID: 142926 RVA: 0x004CE218 File Offset: 0x004CC418
		public ICurveControlConfigT UnPack()
		{
			ICurveControlConfigT curveControlConfigT = new ICurveControlConfigT();
			this.UnPackTo(curveControlConfigT);
			return curveControlConfigT;
		}

		// Token: 0x06022E4F RID: 142927 RVA: 0x004CE233 File Offset: 0x004CC433
		public void UnPackTo(ICurveControlConfigT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06022E50 RID: 142928 RVA: 0x004CE244 File Offset: 0x004CC444
		public static Offset<ICurveControlConfig> Pack(FlatBufferBuilder builder, ICurveControlConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICurveControlConfig>);
			}
			return ICurveControlConfig.CreateICurveControlConfig(builder, _o.Type);
		}

		// Token: 0x0400EC39 RID: 60473
		private Table __p;
	}
}
