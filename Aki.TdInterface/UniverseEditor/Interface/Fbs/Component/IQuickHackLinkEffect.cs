using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005DD3 RID: 24019
	public struct IQuickHackLinkEffect : IFlatbufferObject
	{
		// Token: 0x1700B0ED RID: 45293
		// (get) Token: 0x060280D0 RID: 164048 RVA: 0x0057A276 File Offset: 0x00578476
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060280D1 RID: 164049 RVA: 0x0057A283 File Offset: 0x00578483
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060280D2 RID: 164050 RVA: 0x0057A28C File Offset: 0x0057848C
		public static IQuickHackLinkEffect GetRootAsIQuickHackLinkEffect(ByteBuffer _bb)
		{
			return IQuickHackLinkEffect.GetRootAsIQuickHackLinkEffect(_bb, default(IQuickHackLinkEffect));
		}

		// Token: 0x060280D3 RID: 164051 RVA: 0x0057A2A8 File Offset: 0x005784A8
		public static IQuickHackLinkEffect GetRootAsIQuickHackLinkEffect(ByteBuffer _bb, IQuickHackLinkEffect obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060280D4 RID: 164052 RVA: 0x0057A2C5 File Offset: 0x005784C5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060280D5 RID: 164053 RVA: 0x0057A2D4 File Offset: 0x005784D4
		public IQuickHackLinkEffect __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B0EE RID: 45294
		// (get) Token: 0x060280D6 RID: 164054 RVA: 0x0057A2E4 File Offset: 0x005784E4
		public string RequiredState
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

		// Token: 0x060280D7 RID: 164055 RVA: 0x0057A31B File Offset: 0x0057851B
		public Span<byte> GetRequiredStateBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x060280D8 RID: 164056 RVA: 0x0057A32A File Offset: 0x0057852A
		public byte[] GetRequiredStateArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700B0EF RID: 45295
		// (get) Token: 0x060280D9 RID: 164057 RVA: 0x0057A338 File Offset: 0x00578538
		public string EffectPath
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060280DA RID: 164058 RVA: 0x0057A36F File Offset: 0x0057856F
		public Span<byte> GetEffectPathBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060280DB RID: 164059 RVA: 0x0057A37E File Offset: 0x0057857E
		public byte[] GetEffectPathArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700B0F0 RID: 45296
		// (get) Token: 0x060280DC RID: 164060 RVA: 0x0057A38C File Offset: 0x0057858C
		public IVectorInfo? StartPoint
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

		// Token: 0x1700B0F1 RID: 45297
		// (get) Token: 0x060280DD RID: 164061 RVA: 0x0057A3EC File Offset: 0x005785EC
		public IVectorInfo? EndPoint
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x060280DE RID: 164062 RVA: 0x0057A44A File Offset: 0x0057864A
		public static Offset<IQuickHackLinkEffect> CreateIQuickHackLinkEffect(FlatBufferBuilder builder, StringOffset RequiredStateOffset = default(StringOffset), StringOffset EffectPathOffset = default(StringOffset), Offset<IVectorInfo> StartPointOffset = default(Offset<IVectorInfo>), Offset<IVectorInfo> EndPointOffset = default(Offset<IVectorInfo>))
		{
			builder.StartTable(4);
			IQuickHackLinkEffect.AddEndPoint(builder, EndPointOffset);
			IQuickHackLinkEffect.AddStartPoint(builder, StartPointOffset);
			IQuickHackLinkEffect.AddEffectPath(builder, EffectPathOffset);
			IQuickHackLinkEffect.AddRequiredState(builder, RequiredStateOffset);
			return IQuickHackLinkEffect.EndIQuickHackLinkEffect(builder);
		}

		// Token: 0x060280DF RID: 164063 RVA: 0x0057A476 File Offset: 0x00578676
		public static void StartIQuickHackLinkEffect(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x060280E0 RID: 164064 RVA: 0x0057A47F File Offset: 0x0057867F
		public static void AddRequiredState(FlatBufferBuilder builder, StringOffset requiredStateOffset)
		{
			builder.AddOffset(0, requiredStateOffset.Value, 0);
		}

		// Token: 0x060280E1 RID: 164065 RVA: 0x0057A48F File Offset: 0x0057868F
		public static void AddEffectPath(FlatBufferBuilder builder, StringOffset effectPathOffset)
		{
			builder.AddOffset(1, effectPathOffset.Value, 0);
		}

		// Token: 0x060280E2 RID: 164066 RVA: 0x0057A49F File Offset: 0x0057869F
		public static void AddStartPoint(FlatBufferBuilder builder, Offset<IVectorInfo> startPointOffset)
		{
			builder.AddOffset(2, startPointOffset.Value, 0);
		}

		// Token: 0x060280E3 RID: 164067 RVA: 0x0057A4AF File Offset: 0x005786AF
		public static void AddEndPoint(FlatBufferBuilder builder, Offset<IVectorInfo> endPointOffset)
		{
			builder.AddOffset(3, endPointOffset.Value, 0);
		}

		// Token: 0x060280E4 RID: 164068 RVA: 0x0057A4BF File Offset: 0x005786BF
		public static Offset<IQuickHackLinkEffect> EndIQuickHackLinkEffect(FlatBufferBuilder builder)
		{
			return new Offset<IQuickHackLinkEffect>(builder.EndTable());
		}

		// Token: 0x060280E5 RID: 164069 RVA: 0x0057A4CC File Offset: 0x005786CC
		public IQuickHackLinkEffectT UnPack()
		{
			IQuickHackLinkEffectT quickHackLinkEffectT = new IQuickHackLinkEffectT();
			this.UnPackTo(quickHackLinkEffectT);
			return quickHackLinkEffectT;
		}

		// Token: 0x060280E6 RID: 164070 RVA: 0x0057A4E8 File Offset: 0x005786E8
		public void UnPackTo(IQuickHackLinkEffectT _o)
		{
			_o.RequiredState = this.RequiredState;
			_o.EffectPath = this.EffectPath;
			_o.StartPoint = ((this.StartPoint != null) ? this.StartPoint.Value.UnPack() : null);
			_o.EndPoint = ((this.EndPoint != null) ? this.EndPoint.Value.UnPack() : null);
		}

		// Token: 0x060280E7 RID: 164071 RVA: 0x0057A56C File Offset: 0x0057876C
		public static Offset<IQuickHackLinkEffect> Pack(FlatBufferBuilder builder, IQuickHackLinkEffectT _o)
		{
			if (_o == null)
			{
				return default(Offset<IQuickHackLinkEffect>);
			}
			StringOffset requiredStateOffset = (_o.RequiredState == null) ? default(StringOffset) : builder.CreateString(_o.RequiredState);
			StringOffset effectPathOffset = (_o.EffectPath == null) ? default(StringOffset) : builder.CreateString(_o.EffectPath);
			Offset<IVectorInfo> startPointOffset = (_o.StartPoint == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.StartPoint);
			Offset<IVectorInfo> endPointOffset = (_o.EndPoint == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.EndPoint);
			return IQuickHackLinkEffect.CreateIQuickHackLinkEffect(builder, requiredStateOffset, effectPathOffset, startPointOffset, endPointOffset);
		}

		// Token: 0x0400F99A RID: 63898
		private Table __p;
	}
}
