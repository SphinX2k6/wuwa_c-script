using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020053F1 RID: 21489
	public struct IAttachTimingLinkEffect : IFlatbufferObject
	{
		// Token: 0x17009815 RID: 38933
		// (get) Token: 0x06021957 RID: 137559 RVA: 0x004A173E File Offset: 0x0049F93E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06021958 RID: 137560 RVA: 0x004A174B File Offset: 0x0049F94B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06021959 RID: 137561 RVA: 0x004A1754 File Offset: 0x0049F954
		public static IAttachTimingLinkEffect GetRootAsIAttachTimingLinkEffect(ByteBuffer _bb)
		{
			return IAttachTimingLinkEffect.GetRootAsIAttachTimingLinkEffect(_bb, default(IAttachTimingLinkEffect));
		}

		// Token: 0x0602195A RID: 137562 RVA: 0x004A1770 File Offset: 0x0049F970
		public static IAttachTimingLinkEffect GetRootAsIAttachTimingLinkEffect(ByteBuffer _bb, IAttachTimingLinkEffect obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602195B RID: 137563 RVA: 0x004A178D File Offset: 0x0049F98D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602195C RID: 137564 RVA: 0x004A179C File Offset: 0x0049F99C
		public IAttachTimingLinkEffect __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009816 RID: 38934
		// (get) Token: 0x0602195D RID: 137565 RVA: 0x004A17AC File Offset: 0x0049F9AC
		public string EffectPath
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

		// Token: 0x0602195E RID: 137566 RVA: 0x004A17E3 File Offset: 0x0049F9E3
		public Span<byte> GetEffectPathBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0602195F RID: 137567 RVA: 0x004A17F2 File Offset: 0x0049F9F2
		public byte[] GetEffectPathArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x17009817 RID: 38935
		// (get) Token: 0x06021960 RID: 137568 RVA: 0x004A1800 File Offset: 0x0049FA00
		public IVectorInfo? StartPoint
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17009818 RID: 38936
		// (get) Token: 0x06021961 RID: 137569 RVA: 0x004A1860 File Offset: 0x0049FA60
		public IVectorInfo? EndPoint
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

		// Token: 0x06021962 RID: 137570 RVA: 0x004A18BD File Offset: 0x0049FABD
		public static Offset<IAttachTimingLinkEffect> CreateIAttachTimingLinkEffect(FlatBufferBuilder builder, StringOffset EffectPathOffset = default(StringOffset), Offset<IVectorInfo> StartPointOffset = default(Offset<IVectorInfo>), Offset<IVectorInfo> EndPointOffset = default(Offset<IVectorInfo>))
		{
			builder.StartTable(3);
			IAttachTimingLinkEffect.AddEndPoint(builder, EndPointOffset);
			IAttachTimingLinkEffect.AddStartPoint(builder, StartPointOffset);
			IAttachTimingLinkEffect.AddEffectPath(builder, EffectPathOffset);
			return IAttachTimingLinkEffect.EndIAttachTimingLinkEffect(builder);
		}

		// Token: 0x06021963 RID: 137571 RVA: 0x004A18E1 File Offset: 0x0049FAE1
		public static void StartIAttachTimingLinkEffect(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06021964 RID: 137572 RVA: 0x004A18EA File Offset: 0x0049FAEA
		public static void AddEffectPath(FlatBufferBuilder builder, StringOffset effectPathOffset)
		{
			builder.AddOffset(0, effectPathOffset.Value, 0);
		}

		// Token: 0x06021965 RID: 137573 RVA: 0x004A18FA File Offset: 0x0049FAFA
		public static void AddStartPoint(FlatBufferBuilder builder, Offset<IVectorInfo> startPointOffset)
		{
			builder.AddOffset(1, startPointOffset.Value, 0);
		}

		// Token: 0x06021966 RID: 137574 RVA: 0x004A190A File Offset: 0x0049FB0A
		public static void AddEndPoint(FlatBufferBuilder builder, Offset<IVectorInfo> endPointOffset)
		{
			builder.AddOffset(2, endPointOffset.Value, 0);
		}

		// Token: 0x06021967 RID: 137575 RVA: 0x004A191A File Offset: 0x0049FB1A
		public static Offset<IAttachTimingLinkEffect> EndIAttachTimingLinkEffect(FlatBufferBuilder builder)
		{
			return new Offset<IAttachTimingLinkEffect>(builder.EndTable());
		}

		// Token: 0x06021968 RID: 137576 RVA: 0x004A1928 File Offset: 0x0049FB28
		public IAttachTimingLinkEffectT UnPack()
		{
			IAttachTimingLinkEffectT attachTimingLinkEffectT = new IAttachTimingLinkEffectT();
			this.UnPackTo(attachTimingLinkEffectT);
			return attachTimingLinkEffectT;
		}

		// Token: 0x06021969 RID: 137577 RVA: 0x004A1944 File Offset: 0x0049FB44
		public void UnPackTo(IAttachTimingLinkEffectT _o)
		{
			_o.EffectPath = this.EffectPath;
			_o.StartPoint = ((this.StartPoint != null) ? this.StartPoint.Value.UnPack() : null);
			_o.EndPoint = ((this.EndPoint != null) ? this.EndPoint.Value.UnPack() : null);
		}

		// Token: 0x0602196A RID: 137578 RVA: 0x004A19BC File Offset: 0x0049FBBC
		public static Offset<IAttachTimingLinkEffect> Pack(FlatBufferBuilder builder, IAttachTimingLinkEffectT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAttachTimingLinkEffect>);
			}
			StringOffset effectPathOffset = (_o.EffectPath == null) ? default(StringOffset) : builder.CreateString(_o.EffectPath);
			Offset<IVectorInfo> startPointOffset = (_o.StartPoint == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.StartPoint);
			Offset<IVectorInfo> endPointOffset = (_o.EndPoint == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.EndPoint);
			return IAttachTimingLinkEffect.CreateIAttachTimingLinkEffect(builder, effectPathOffset, startPointOffset, endPointOffset);
		}

		// Token: 0x0400E858 RID: 59480
		private Table __p;
	}
}
