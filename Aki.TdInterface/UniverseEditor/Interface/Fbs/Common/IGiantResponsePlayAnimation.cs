using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x020063FE RID: 25598
	public struct IGiantResponsePlayAnimation : IFlatbufferObject
	{
		// Token: 0x1700BD18 RID: 48408
		// (get) Token: 0x0602B7CE RID: 178126 RVA: 0x005EC7A6 File Offset: 0x005EA9A6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602B7CF RID: 178127 RVA: 0x005EC7B3 File Offset: 0x005EA9B3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602B7D0 RID: 178128 RVA: 0x005EC7BC File Offset: 0x005EA9BC
		public static IGiantResponsePlayAnimation GetRootAsIGiantResponsePlayAnimation(ByteBuffer _bb)
		{
			return IGiantResponsePlayAnimation.GetRootAsIGiantResponsePlayAnimation(_bb, default(IGiantResponsePlayAnimation));
		}

		// Token: 0x0602B7D1 RID: 178129 RVA: 0x005EC7D8 File Offset: 0x005EA9D8
		public static IGiantResponsePlayAnimation GetRootAsIGiantResponsePlayAnimation(ByteBuffer _bb, IGiantResponsePlayAnimation obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602B7D2 RID: 178130 RVA: 0x005EC7F5 File Offset: 0x005EA9F5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602B7D3 RID: 178131 RVA: 0x005EC804 File Offset: 0x005EAA04
		public IGiantResponsePlayAnimation __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BD19 RID: 48409
		// (get) Token: 0x0602B7D4 RID: 178132 RVA: 0x005EC814 File Offset: 0x005EAA14
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

		// Token: 0x1700BD1A RID: 48410
		// (get) Token: 0x0602B7D5 RID: 178133 RVA: 0x005EC850 File Offset: 0x005EAA50
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

		// Token: 0x0602B7D6 RID: 178134 RVA: 0x005EC88C File Offset: 0x005EAA8C
		public static Offset<IGiantResponsePlayAnimation> CreateIGiantResponsePlayAnimation(FlatBufferBuilder builder, EGiantResponseType Type = EGiantResponseType.PlayAnimation, int GiantAnimationId = 0)
		{
			builder.StartTable(2);
			IGiantResponsePlayAnimation.AddGiantAnimationId(builder, GiantAnimationId);
			IGiantResponsePlayAnimation.AddType(builder, Type);
			return IGiantResponsePlayAnimation.EndIGiantResponsePlayAnimation(builder);
		}

		// Token: 0x0602B7D7 RID: 178135 RVA: 0x005EC8A9 File Offset: 0x005EAAA9
		public static void StartIGiantResponsePlayAnimation(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602B7D8 RID: 178136 RVA: 0x005EC8B2 File Offset: 0x005EAAB2
		public static void AddType(FlatBufferBuilder builder, EGiantResponseType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602B7D9 RID: 178137 RVA: 0x005EC8BD File Offset: 0x005EAABD
		public static void AddGiantAnimationId(FlatBufferBuilder builder, int giantAnimationId)
		{
			builder.AddInt(1, giantAnimationId, 0);
		}

		// Token: 0x0602B7DA RID: 178138 RVA: 0x005EC8C8 File Offset: 0x005EAAC8
		public static Offset<IGiantResponsePlayAnimation> EndIGiantResponsePlayAnimation(FlatBufferBuilder builder)
		{
			return new Offset<IGiantResponsePlayAnimation>(builder.EndTable());
		}

		// Token: 0x0602B7DB RID: 178139 RVA: 0x005EC8D8 File Offset: 0x005EAAD8
		public IGiantResponsePlayAnimationT UnPack()
		{
			IGiantResponsePlayAnimationT giantResponsePlayAnimationT = new IGiantResponsePlayAnimationT();
			this.UnPackTo(giantResponsePlayAnimationT);
			return giantResponsePlayAnimationT;
		}

		// Token: 0x0602B7DC RID: 178140 RVA: 0x005EC8F3 File Offset: 0x005EAAF3
		public void UnPackTo(IGiantResponsePlayAnimationT _o)
		{
			_o.Type = this.Type;
			_o.GiantAnimationId = this.GiantAnimationId;
		}

		// Token: 0x0602B7DD RID: 178141 RVA: 0x005EC910 File Offset: 0x005EAB10
		public static Offset<IGiantResponsePlayAnimation> Pack(FlatBufferBuilder builder, IGiantResponsePlayAnimationT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGiantResponsePlayAnimation>);
			}
			return IGiantResponsePlayAnimation.CreateIGiantResponsePlayAnimation(builder, _o.Type, _o.GiantAnimationId);
		}

		// Token: 0x040104FD RID: 66813
		private Table __p;
	}
}
