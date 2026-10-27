using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007178 RID: 29048
	public struct ISpecificScanEffect : IFlatbufferObject
	{
		// Token: 0x1700D7CC RID: 55244
		// (get) Token: 0x06033805 RID: 210949 RVA: 0x006F0166 File Offset: 0x006EE366
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06033806 RID: 210950 RVA: 0x006F0173 File Offset: 0x006EE373
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06033807 RID: 210951 RVA: 0x006F017C File Offset: 0x006EE37C
		public static ISpecificScanEffect GetRootAsISpecificScanEffect(ByteBuffer _bb)
		{
			return ISpecificScanEffect.GetRootAsISpecificScanEffect(_bb, default(ISpecificScanEffect));
		}

		// Token: 0x06033808 RID: 210952 RVA: 0x006F0198 File Offset: 0x006EE398
		public static ISpecificScanEffect GetRootAsISpecificScanEffect(ByteBuffer _bb, ISpecificScanEffect obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06033809 RID: 210953 RVA: 0x006F01B5 File Offset: 0x006EE3B5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603380A RID: 210954 RVA: 0x006F01C4 File Offset: 0x006EE3C4
		public ISpecificScanEffect __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D7CD RID: 55245
		// (get) Token: 0x0603380B RID: 210955 RVA: 0x006F01D4 File Offset: 0x006EE3D4
		public ESpecificScanType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESpecificScanType.None;
				}
				return (ESpecificScanType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603380C RID: 210956 RVA: 0x006F0210 File Offset: 0x006EE410
		public static Offset<ISpecificScanEffect> CreateISpecificScanEffect(FlatBufferBuilder builder, ESpecificScanType Type = ESpecificScanType.None)
		{
			builder.StartTable(1);
			ISpecificScanEffect.AddType(builder, Type);
			return ISpecificScanEffect.EndISpecificScanEffect(builder);
		}

		// Token: 0x0603380D RID: 210957 RVA: 0x006F0226 File Offset: 0x006EE426
		public static void StartISpecificScanEffect(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0603380E RID: 210958 RVA: 0x006F022F File Offset: 0x006EE42F
		public static void AddType(FlatBufferBuilder builder, ESpecificScanType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603380F RID: 210959 RVA: 0x006F023A File Offset: 0x006EE43A
		public static Offset<ISpecificScanEffect> EndISpecificScanEffect(FlatBufferBuilder builder)
		{
			return new Offset<ISpecificScanEffect>(builder.EndTable());
		}

		// Token: 0x06033810 RID: 210960 RVA: 0x006F0248 File Offset: 0x006EE448
		public ISpecificScanEffectT UnPack()
		{
			ISpecificScanEffectT specificScanEffectT = new ISpecificScanEffectT();
			this.UnPackTo(specificScanEffectT);
			return specificScanEffectT;
		}

		// Token: 0x06033811 RID: 210961 RVA: 0x006F0263 File Offset: 0x006EE463
		public void UnPackTo(ISpecificScanEffectT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06033812 RID: 210962 RVA: 0x006F0274 File Offset: 0x006EE474
		public static Offset<ISpecificScanEffect> Pack(FlatBufferBuilder builder, ISpecificScanEffectT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISpecificScanEffect>);
			}
			return ISpecificScanEffect.CreateISpecificScanEffect(builder, _o.Type);
		}

		// Token: 0x04011C1E RID: 72734
		private Table __p;
	}
}
