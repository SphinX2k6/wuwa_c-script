using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005736 RID: 22326
	public struct IExhibitEffect : IFlatbufferObject
	{
		// Token: 0x1700A13A RID: 41274
		// (get) Token: 0x06023EC0 RID: 147136 RVA: 0x004F0388 File Offset: 0x004EE588
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06023EC1 RID: 147137 RVA: 0x004F0395 File Offset: 0x004EE595
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06023EC2 RID: 147138 RVA: 0x004F039C File Offset: 0x004EE59C
		public static IExhibitEffect GetRootAsIExhibitEffect(ByteBuffer _bb)
		{
			return IExhibitEffect.GetRootAsIExhibitEffect(_bb, default(IExhibitEffect));
		}

		// Token: 0x06023EC3 RID: 147139 RVA: 0x004F03B8 File Offset: 0x004EE5B8
		public static IExhibitEffect GetRootAsIExhibitEffect(ByteBuffer _bb, IExhibitEffect obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06023EC4 RID: 147140 RVA: 0x004F03D5 File Offset: 0x004EE5D5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06023EC5 RID: 147141 RVA: 0x004F03E4 File Offset: 0x004EE5E4
		public IExhibitEffect __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A13B RID: 41275
		// (get) Token: 0x06023EC6 RID: 147142 RVA: 0x004F03F4 File Offset: 0x004EE5F4
		public string Path
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06023EC7 RID: 147143 RVA: 0x004F042B File Offset: 0x004EE62B
		public Span<byte> GetPathBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06023EC8 RID: 147144 RVA: 0x004F043A File Offset: 0x004EE63A
		public byte[] GetPathArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700A13C RID: 41276
		// (get) Token: 0x06023EC9 RID: 147145 RVA: 0x004F0448 File Offset: 0x004EE648
		public float Scale
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

		// Token: 0x1700A13D RID: 41277
		// (get) Token: 0x06023ECA RID: 147146 RVA: 0x004F0488 File Offset: 0x004EE688
		public IVectorInfo? Offset
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06023ECB RID: 147147 RVA: 0x004F04E5 File Offset: 0x004EE6E5
		public static Offset<IExhibitEffect> CreateIExhibitEffect(FlatBufferBuilder builder, StringOffset PathOffset = default(StringOffset), float Scale = 0f, Offset<IVectorInfo> OffsetOffset = default(Offset<IVectorInfo>))
		{
			builder.StartTable(3);
			IExhibitEffect.AddOffset(builder, OffsetOffset);
			IExhibitEffect.AddScale(builder, Scale);
			IExhibitEffect.AddPath(builder, PathOffset);
			return IExhibitEffect.EndIExhibitEffect(builder);
		}

		// Token: 0x06023ECC RID: 147148 RVA: 0x004F0509 File Offset: 0x004EE709
		public static void StartIExhibitEffect(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06023ECD RID: 147149 RVA: 0x004F0512 File Offset: 0x004EE712
		public static void AddPath(FlatBufferBuilder builder, StringOffset pathOffset)
		{
			builder.AddOffset(0, pathOffset.Value, 0);
		}

		// Token: 0x06023ECE RID: 147150 RVA: 0x004F0522 File Offset: 0x004EE722
		public static void AddScale(FlatBufferBuilder builder, float scale)
		{
			builder.AddFloat(1, scale, 0.0);
		}

		// Token: 0x06023ECF RID: 147151 RVA: 0x004F0535 File Offset: 0x004EE735
		public static void AddOffset(FlatBufferBuilder builder, Offset<IVectorInfo> offsetOffset)
		{
			builder.AddOffset(2, offsetOffset.Value, 0);
		}

		// Token: 0x06023ED0 RID: 147152 RVA: 0x004F0545 File Offset: 0x004EE745
		public static Offset<IExhibitEffect> EndIExhibitEffect(FlatBufferBuilder builder)
		{
			return new Offset<IExhibitEffect>(builder.EndTable());
		}

		// Token: 0x06023ED1 RID: 147153 RVA: 0x004F0554 File Offset: 0x004EE754
		public IExhibitEffectT UnPack()
		{
			IExhibitEffectT exhibitEffectT = new IExhibitEffectT();
			this.UnPackTo(exhibitEffectT);
			return exhibitEffectT;
		}

		// Token: 0x06023ED2 RID: 147154 RVA: 0x004F0570 File Offset: 0x004EE770
		public void UnPackTo(IExhibitEffectT _o)
		{
			_o.Path = this.Path;
			_o.Scale = this.Scale;
			_o.Offset = ((this.Offset != null) ? this.Offset.Value.UnPack() : null);
		}

		// Token: 0x06023ED3 RID: 147155 RVA: 0x004F05C4 File Offset: 0x004EE7C4
		public static Offset<IExhibitEffect> Pack(FlatBufferBuilder builder, IExhibitEffectT _o)
		{
			if (_o == null)
			{
				return default(Offset<IExhibitEffect>);
			}
			StringOffset pathOffset = (_o.Path == null) ? default(StringOffset) : builder.CreateString(_o.Path);
			Offset<IVectorInfo> offsetOffset = (_o.Offset == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Offset);
			return IExhibitEffect.CreateIExhibitEffect(builder, pathOffset, _o.Scale, offsetOffset);
		}

		// Token: 0x0400EED4 RID: 61140
		private Table __p;
	}
}
