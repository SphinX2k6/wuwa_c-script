using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005DC1 RID: 24001
	public struct IGiantResponsePlayAnimation : IFlatbufferObject
	{
		// Token: 0x1700B3B2 RID: 46002
		// (get) Token: 0x06029144 RID: 168260 RVA: 0x005A3A76 File Offset: 0x005A1C76
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06029145 RID: 168261 RVA: 0x005A3A83 File Offset: 0x005A1C83
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06029146 RID: 168262 RVA: 0x005A3A8C File Offset: 0x005A1C8C
		public static IGiantResponsePlayAnimation GetRootAsIGiantResponsePlayAnimation(ByteBuffer _bb)
		{
			return IGiantResponsePlayAnimation.GetRootAsIGiantResponsePlayAnimation(_bb, default(IGiantResponsePlayAnimation));
		}

		// Token: 0x06029147 RID: 168263 RVA: 0x005A3AA8 File Offset: 0x005A1CA8
		public static IGiantResponsePlayAnimation GetRootAsIGiantResponsePlayAnimation(ByteBuffer _bb, IGiantResponsePlayAnimation obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06029148 RID: 168264 RVA: 0x005A3AC5 File Offset: 0x005A1CC5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06029149 RID: 168265 RVA: 0x005A3AD4 File Offset: 0x005A1CD4
		public IGiantResponsePlayAnimation __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B3B3 RID: 46003
		// (get) Token: 0x0602914A RID: 168266 RVA: 0x005A3AE4 File Offset: 0x005A1CE4
		public EGiantResponseType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EGiantResponseType.PlayAnimation;
				}
				return (EGiantResponseType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B3B4 RID: 46004
		// (get) Token: 0x0602914B RID: 168267 RVA: 0x005A3B20 File Offset: 0x005A1D20
		public int GiantAnimationId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602914C RID: 168268 RVA: 0x005A3B5C File Offset: 0x005A1D5C
		public static Offset<IGiantResponsePlayAnimation> CreateIGiantResponsePlayAnimation(FlatBufferBuilder builder, EGiantResponseType Type = EGiantResponseType.PlayAnimation, int GiantAnimationId = 0)
		{
			builder.StartTable(2);
			IGiantResponsePlayAnimation.AddGiantAnimationId(builder, GiantAnimationId);
			IGiantResponsePlayAnimation.AddType(builder, Type);
			return IGiantResponsePlayAnimation.EndIGiantResponsePlayAnimation(builder);
		}

		// Token: 0x0602914D RID: 168269 RVA: 0x005A3B79 File Offset: 0x005A1D79
		public static void StartIGiantResponsePlayAnimation(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602914E RID: 168270 RVA: 0x005A3B82 File Offset: 0x005A1D82
		public static void AddType(FlatBufferBuilder builder, EGiantResponseType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602914F RID: 168271 RVA: 0x005A3B8D File Offset: 0x005A1D8D
		public static void AddGiantAnimationId(FlatBufferBuilder builder, int giantAnimationId)
		{
			builder.AddInt(1, giantAnimationId, 0);
		}

		// Token: 0x06029150 RID: 168272 RVA: 0x005A3B98 File Offset: 0x005A1D98
		public static Offset<IGiantResponsePlayAnimation> EndIGiantResponsePlayAnimation(FlatBufferBuilder builder)
		{
			return new Offset<IGiantResponsePlayAnimation>(builder.EndTable());
		}

		// Token: 0x06029151 RID: 168273 RVA: 0x005A3BA8 File Offset: 0x005A1DA8
		public IGiantResponsePlayAnimationT UnPack()
		{
			IGiantResponsePlayAnimationT giantResponsePlayAnimationT = new IGiantResponsePlayAnimationT();
			this.UnPackTo(giantResponsePlayAnimationT);
			return giantResponsePlayAnimationT;
		}

		// Token: 0x06029152 RID: 168274 RVA: 0x005A3BC3 File Offset: 0x005A1DC3
		public void UnPackTo(IGiantResponsePlayAnimationT _o)
		{
			_o.Type = this.Type;
			_o.GiantAnimationId = this.GiantAnimationId;
		}

		// Token: 0x06029153 RID: 168275 RVA: 0x005A3BE0 File Offset: 0x005A1DE0
		public static Offset<IGiantResponsePlayAnimation> Pack(FlatBufferBuilder builder, IGiantResponsePlayAnimationT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGiantResponsePlayAnimation>);
			}
			return IGiantResponsePlayAnimation.CreateIGiantResponsePlayAnimation(builder, _o.Type, _o.GiantAnimationId);
		}

		// Token: 0x0400F7A2 RID: 63394
		private Table __p;
	}
}
