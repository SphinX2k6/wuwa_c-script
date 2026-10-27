using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020057CC RID: 22476
	public struct IQuickHackLinkEffect : IFlatbufferObject
	{
		// Token: 0x1700A7C9 RID: 42953
		// (get) Token: 0x06025BB0 RID: 154544 RVA: 0x005340EA File Offset: 0x005322EA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06025BB1 RID: 154545 RVA: 0x005340F7 File Offset: 0x005322F7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06025BB2 RID: 154546 RVA: 0x00534100 File Offset: 0x00532300
		public static IQuickHackLinkEffect GetRootAsIQuickHackLinkEffect(ByteBuffer _bb)
		{
			return IQuickHackLinkEffect.GetRootAsIQuickHackLinkEffect(_bb, default(IQuickHackLinkEffect));
		}

		// Token: 0x06025BB3 RID: 154547 RVA: 0x0053411C File Offset: 0x0053231C
		public static IQuickHackLinkEffect GetRootAsIQuickHackLinkEffect(ByteBuffer _bb, IQuickHackLinkEffect obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06025BB4 RID: 154548 RVA: 0x00534139 File Offset: 0x00532339
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06025BB5 RID: 154549 RVA: 0x00534148 File Offset: 0x00532348
		public IQuickHackLinkEffect __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A7CA RID: 42954
		// (get) Token: 0x06025BB6 RID: 154550 RVA: 0x00534158 File Offset: 0x00532358
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

		// Token: 0x06025BB7 RID: 154551 RVA: 0x0053418F File Offset: 0x0053238F
		public Span<byte> GetRequiredStateBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06025BB8 RID: 154552 RVA: 0x0053419E File Offset: 0x0053239E
		public byte[] GetRequiredStateArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700A7CB RID: 42955
		// (get) Token: 0x06025BB9 RID: 154553 RVA: 0x005341AC File Offset: 0x005323AC
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

		// Token: 0x06025BBA RID: 154554 RVA: 0x005341E3 File Offset: 0x005323E3
		public Span<byte> GetEffectPathBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06025BBB RID: 154555 RVA: 0x005341F2 File Offset: 0x005323F2
		public byte[] GetEffectPathArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700A7CC RID: 42956
		// (get) Token: 0x06025BBC RID: 154556 RVA: 0x00534200 File Offset: 0x00532400
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

		// Token: 0x1700A7CD RID: 42957
		// (get) Token: 0x06025BBD RID: 154557 RVA: 0x00534260 File Offset: 0x00532460
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

		// Token: 0x06025BBE RID: 154558 RVA: 0x005342BE File Offset: 0x005324BE
		public static Offset<IQuickHackLinkEffect> CreateIQuickHackLinkEffect(FlatBufferBuilder builder, StringOffset RequiredStateOffset = default(StringOffset), StringOffset EffectPathOffset = default(StringOffset), Offset<IVectorInfo> StartPointOffset = default(Offset<IVectorInfo>), Offset<IVectorInfo> EndPointOffset = default(Offset<IVectorInfo>))
		{
			builder.StartTable(4);
			IQuickHackLinkEffect.AddEndPoint(builder, EndPointOffset);
			IQuickHackLinkEffect.AddStartPoint(builder, StartPointOffset);
			IQuickHackLinkEffect.AddEffectPath(builder, EffectPathOffset);
			IQuickHackLinkEffect.AddRequiredState(builder, RequiredStateOffset);
			return IQuickHackLinkEffect.EndIQuickHackLinkEffect(builder);
		}

		// Token: 0x06025BBF RID: 154559 RVA: 0x005342EA File Offset: 0x005324EA
		public static void StartIQuickHackLinkEffect(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06025BC0 RID: 154560 RVA: 0x005342F3 File Offset: 0x005324F3
		public static void AddRequiredState(FlatBufferBuilder builder, StringOffset requiredStateOffset)
		{
			builder.AddOffset(0, requiredStateOffset.Value, 0);
		}

		// Token: 0x06025BC1 RID: 154561 RVA: 0x00534303 File Offset: 0x00532503
		public static void AddEffectPath(FlatBufferBuilder builder, StringOffset effectPathOffset)
		{
			builder.AddOffset(1, effectPathOffset.Value, 0);
		}

		// Token: 0x06025BC2 RID: 154562 RVA: 0x00534313 File Offset: 0x00532513
		public static void AddStartPoint(FlatBufferBuilder builder, Offset<IVectorInfo> startPointOffset)
		{
			builder.AddOffset(2, startPointOffset.Value, 0);
		}

		// Token: 0x06025BC3 RID: 154563 RVA: 0x00534323 File Offset: 0x00532523
		public static void AddEndPoint(FlatBufferBuilder builder, Offset<IVectorInfo> endPointOffset)
		{
			builder.AddOffset(3, endPointOffset.Value, 0);
		}

		// Token: 0x06025BC4 RID: 154564 RVA: 0x00534333 File Offset: 0x00532533
		public static Offset<IQuickHackLinkEffect> EndIQuickHackLinkEffect(FlatBufferBuilder builder)
		{
			return new Offset<IQuickHackLinkEffect>(builder.EndTable());
		}

		// Token: 0x06025BC5 RID: 154565 RVA: 0x00534340 File Offset: 0x00532540
		public IQuickHackLinkEffectT UnPack()
		{
			IQuickHackLinkEffectT quickHackLinkEffectT = new IQuickHackLinkEffectT();
			this.UnPackTo(quickHackLinkEffectT);
			return quickHackLinkEffectT;
		}

		// Token: 0x06025BC6 RID: 154566 RVA: 0x0053435C File Offset: 0x0053255C
		public void UnPackTo(IQuickHackLinkEffectT _o)
		{
			_o.RequiredState = this.RequiredState;
			_o.EffectPath = this.EffectPath;
			_o.StartPoint = ((this.StartPoint != null) ? this.StartPoint.Value.UnPack() : null);
			_o.EndPoint = ((this.EndPoint != null) ? this.EndPoint.Value.UnPack() : null);
		}

		// Token: 0x06025BC7 RID: 154567 RVA: 0x005343E0 File Offset: 0x005325E0
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

		// Token: 0x0400ECAF RID: 60591
		private Table __p;
	}
}
