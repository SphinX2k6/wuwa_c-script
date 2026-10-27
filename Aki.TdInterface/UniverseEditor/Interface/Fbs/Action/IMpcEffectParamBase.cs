using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B8B RID: 27531
	public struct IMpcEffectParamBase : IFlatbufferObject
	{
		// Token: 0x1700CCA9 RID: 52393
		// (get) Token: 0x060305A1 RID: 198049 RVA: 0x00691991 File Offset: 0x0068FB91
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060305A2 RID: 198050 RVA: 0x0069199E File Offset: 0x0068FB9E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060305A3 RID: 198051 RVA: 0x006919A8 File Offset: 0x0068FBA8
		public static IMpcEffectParamBase GetRootAsIMpcEffectParamBase(ByteBuffer _bb)
		{
			return IMpcEffectParamBase.GetRootAsIMpcEffectParamBase(_bb, default(IMpcEffectParamBase));
		}

		// Token: 0x060305A4 RID: 198052 RVA: 0x006919C4 File Offset: 0x0068FBC4
		public static IMpcEffectParamBase GetRootAsIMpcEffectParamBase(ByteBuffer _bb, IMpcEffectParamBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060305A5 RID: 198053 RVA: 0x006919E1 File Offset: 0x0068FBE1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060305A6 RID: 198054 RVA: 0x006919F0 File Offset: 0x0068FBF0
		public IMpcEffectParamBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CCAA RID: 52394
		// (get) Token: 0x060305A7 RID: 198055 RVA: 0x00691A00 File Offset: 0x0068FC00
		public EMpcEffectParamType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EMpcEffectParamType.PostProcessVolumeCenterPosition;
				}
				return (EMpcEffectParamType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060305A8 RID: 198056 RVA: 0x00691A3C File Offset: 0x0068FC3C
		public static Offset<IMpcEffectParamBase> CreateIMpcEffectParamBase(FlatBufferBuilder builder, EMpcEffectParamType Type = EMpcEffectParamType.PostProcessVolumeCenterPosition)
		{
			builder.StartTable(1);
			IMpcEffectParamBase.AddType(builder, Type);
			return IMpcEffectParamBase.EndIMpcEffectParamBase(builder);
		}

		// Token: 0x060305A9 RID: 198057 RVA: 0x00691A52 File Offset: 0x0068FC52
		public static void StartIMpcEffectParamBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060305AA RID: 198058 RVA: 0x00691A5B File Offset: 0x0068FC5B
		public static void AddType(FlatBufferBuilder builder, EMpcEffectParamType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060305AB RID: 198059 RVA: 0x00691A66 File Offset: 0x0068FC66
		public static Offset<IMpcEffectParamBase> EndIMpcEffectParamBase(FlatBufferBuilder builder)
		{
			return new Offset<IMpcEffectParamBase>(builder.EndTable());
		}

		// Token: 0x060305AC RID: 198060 RVA: 0x00691A74 File Offset: 0x0068FC74
		public IMpcEffectParamBaseT UnPack()
		{
			IMpcEffectParamBaseT mpcEffectParamBaseT = new IMpcEffectParamBaseT();
			this.UnPackTo(mpcEffectParamBaseT);
			return mpcEffectParamBaseT;
		}

		// Token: 0x060305AD RID: 198061 RVA: 0x00691A8F File Offset: 0x0068FC8F
		public void UnPackTo(IMpcEffectParamBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060305AE RID: 198062 RVA: 0x00691AA0 File Offset: 0x0068FCA0
		public static Offset<IMpcEffectParamBase> Pack(FlatBufferBuilder builder, IMpcEffectParamBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMpcEffectParamBase>);
			}
			return IMpcEffectParamBase.CreateIMpcEffectParamBase(builder, _o.Type);
		}

		// Token: 0x0401144B RID: 70731
		private Table __p;
	}
}
