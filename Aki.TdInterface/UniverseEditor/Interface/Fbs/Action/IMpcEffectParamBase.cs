using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020072D1 RID: 29393
	public struct IMpcEffectParamBase : IFlatbufferObject
	{
		// Token: 0x1700D78E RID: 55182
		// (get) Token: 0x060333F9 RID: 209913 RVA: 0x006E9FB1 File Offset: 0x006E81B1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060333FA RID: 209914 RVA: 0x006E9FBE File Offset: 0x006E81BE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060333FB RID: 209915 RVA: 0x006E9FC8 File Offset: 0x006E81C8
		public static IMpcEffectParamBase GetRootAsIMpcEffectParamBase(ByteBuffer _bb)
		{
			return IMpcEffectParamBase.GetRootAsIMpcEffectParamBase(_bb, default(IMpcEffectParamBase));
		}

		// Token: 0x060333FC RID: 209916 RVA: 0x006E9FE4 File Offset: 0x006E81E4
		public static IMpcEffectParamBase GetRootAsIMpcEffectParamBase(ByteBuffer _bb, IMpcEffectParamBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060333FD RID: 209917 RVA: 0x006EA001 File Offset: 0x006E8201
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060333FE RID: 209918 RVA: 0x006EA010 File Offset: 0x006E8210
		public IMpcEffectParamBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D78F RID: 55183
		// (get) Token: 0x060333FF RID: 209919 RVA: 0x006EA020 File Offset: 0x006E8220
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

		// Token: 0x06033400 RID: 209920 RVA: 0x006EA05C File Offset: 0x006E825C
		public static Offset<IMpcEffectParamBase> CreateIMpcEffectParamBase(FlatBufferBuilder builder, EMpcEffectParamType Type = EMpcEffectParamType.PostProcessVolumeCenterPosition)
		{
			builder.StartTable(1);
			IMpcEffectParamBase.AddType(builder, Type);
			return IMpcEffectParamBase.EndIMpcEffectParamBase(builder);
		}

		// Token: 0x06033401 RID: 209921 RVA: 0x006EA072 File Offset: 0x006E8272
		public static void StartIMpcEffectParamBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06033402 RID: 209922 RVA: 0x006EA07B File Offset: 0x006E827B
		public static void AddType(FlatBufferBuilder builder, EMpcEffectParamType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06033403 RID: 209923 RVA: 0x006EA086 File Offset: 0x006E8286
		public static Offset<IMpcEffectParamBase> EndIMpcEffectParamBase(FlatBufferBuilder builder)
		{
			return new Offset<IMpcEffectParamBase>(builder.EndTable());
		}

		// Token: 0x06033404 RID: 209924 RVA: 0x006EA094 File Offset: 0x006E8294
		public IMpcEffectParamBaseT UnPack()
		{
			IMpcEffectParamBaseT mpcEffectParamBaseT = new IMpcEffectParamBaseT();
			this.UnPackTo(mpcEffectParamBaseT);
			return mpcEffectParamBaseT;
		}

		// Token: 0x06033405 RID: 209925 RVA: 0x006EA0AF File Offset: 0x006E82AF
		public void UnPackTo(IMpcEffectParamBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06033406 RID: 209926 RVA: 0x006EA0C0 File Offset: 0x006E82C0
		public static Offset<IMpcEffectParamBase> Pack(FlatBufferBuilder builder, IMpcEffectParamBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMpcEffectParamBase>);
			}
			return IMpcEffectParamBase.CreateIMpcEffectParamBase(builder, _o.Type);
		}

		// Token: 0x04012374 RID: 74612
		private Table __p;
	}
}
