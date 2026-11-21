using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200730A RID: 29450
	public struct INpcGroupSequenceBindingBase : IFlatbufferObject
	{
		// Token: 0x1700D7E8 RID: 55272
		// (get) Token: 0x060335B1 RID: 210353 RVA: 0x006ECF3E File Offset: 0x006EB13E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060335B2 RID: 210354 RVA: 0x006ECF4B File Offset: 0x006EB14B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060335B3 RID: 210355 RVA: 0x006ECF54 File Offset: 0x006EB154
		public static INpcGroupSequenceBindingBase GetRootAsINpcGroupSequenceBindingBase(ByteBuffer _bb)
		{
			return INpcGroupSequenceBindingBase.GetRootAsINpcGroupSequenceBindingBase(_bb, default(INpcGroupSequenceBindingBase));
		}

		// Token: 0x060335B4 RID: 210356 RVA: 0x006ECF70 File Offset: 0x006EB170
		public static INpcGroupSequenceBindingBase GetRootAsINpcGroupSequenceBindingBase(ByteBuffer _bb, INpcGroupSequenceBindingBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060335B5 RID: 210357 RVA: 0x006ECF8D File Offset: 0x006EB18D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060335B6 RID: 210358 RVA: 0x006ECF9C File Offset: 0x006EB19C
		public INpcGroupSequenceBindingBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D7E9 RID: 55273
		// (get) Token: 0x060335B7 RID: 210359 RVA: 0x006ECFAC File Offset: 0x006EB1AC
		public ENpcGroupSequenceBindingType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ENpcGroupSequenceBindingType.StaticEntity;
				}
				return (ENpcGroupSequenceBindingType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060335B8 RID: 210360 RVA: 0x006ECFE8 File Offset: 0x006EB1E8
		public static Offset<INpcGroupSequenceBindingBase> CreateINpcGroupSequenceBindingBase(FlatBufferBuilder builder, ENpcGroupSequenceBindingType Type = ENpcGroupSequenceBindingType.StaticEntity)
		{
			builder.StartTable(1);
			INpcGroupSequenceBindingBase.AddType(builder, Type);
			return INpcGroupSequenceBindingBase.EndINpcGroupSequenceBindingBase(builder);
		}

		// Token: 0x060335B9 RID: 210361 RVA: 0x006ECFFE File Offset: 0x006EB1FE
		public static void StartINpcGroupSequenceBindingBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060335BA RID: 210362 RVA: 0x006ED007 File Offset: 0x006EB207
		public static void AddType(FlatBufferBuilder builder, ENpcGroupSequenceBindingType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060335BB RID: 210363 RVA: 0x006ED012 File Offset: 0x006EB212
		public static Offset<INpcGroupSequenceBindingBase> EndINpcGroupSequenceBindingBase(FlatBufferBuilder builder)
		{
			return new Offset<INpcGroupSequenceBindingBase>(builder.EndTable());
		}

		// Token: 0x060335BC RID: 210364 RVA: 0x006ED020 File Offset: 0x006EB220
		public INpcGroupSequenceBindingBaseT UnPack()
		{
			INpcGroupSequenceBindingBaseT npcGroupSequenceBindingBaseT = new INpcGroupSequenceBindingBaseT();
			this.UnPackTo(npcGroupSequenceBindingBaseT);
			return npcGroupSequenceBindingBaseT;
		}

		// Token: 0x060335BD RID: 210365 RVA: 0x006ED03B File Offset: 0x006EB23B
		public void UnPackTo(INpcGroupSequenceBindingBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060335BE RID: 210366 RVA: 0x006ED04C File Offset: 0x006EB24C
		public static Offset<INpcGroupSequenceBindingBase> Pack(FlatBufferBuilder builder, INpcGroupSequenceBindingBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<INpcGroupSequenceBindingBase>);
			}
			return INpcGroupSequenceBindingBase.CreateINpcGroupSequenceBindingBase(builder, _o.Type);
		}

		// Token: 0x040123C7 RID: 74695
		private Table __p;
	}
}
