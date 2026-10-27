using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006DE9 RID: 28137
	public struct IQiuyuanQinggongExploration4 : IFlatbufferObject
	{
		// Token: 0x1700D1B7 RID: 53687
		// (get) Token: 0x06031B25 RID: 203557 RVA: 0x006BAE5D File Offset: 0x006B905D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031B26 RID: 203558 RVA: 0x006BAE6A File Offset: 0x006B906A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06031B27 RID: 203559 RVA: 0x006BAE74 File Offset: 0x006B9074
		public static IQiuyuanQinggongExploration4 GetRootAsIQiuyuanQinggongExploration4(ByteBuffer _bb)
		{
			return IQiuyuanQinggongExploration4.GetRootAsIQiuyuanQinggongExploration4(_bb, default(IQiuyuanQinggongExploration4));
		}

		// Token: 0x06031B28 RID: 203560 RVA: 0x006BAE90 File Offset: 0x006B9090
		public static IQiuyuanQinggongExploration4 GetRootAsIQiuyuanQinggongExploration4(ByteBuffer _bb, IQiuyuanQinggongExploration4 obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06031B29 RID: 203561 RVA: 0x006BAEAD File Offset: 0x006B90AD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031B2A RID: 203562 RVA: 0x006BAEBC File Offset: 0x006B90BC
		public IQiuyuanQinggongExploration4 __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D1B8 RID: 53688
		// (get) Token: 0x06031B2B RID: 203563 RVA: 0x006BAECC File Offset: 0x006B90CC
		public ELeisureInteract Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ELeisureInteract.CustomSkill;
				}
				return (ELeisureInteract)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06031B2C RID: 203564 RVA: 0x006BAF08 File Offset: 0x006B9108
		public static Offset<IQiuyuanQinggongExploration4> CreateIQiuyuanQinggongExploration4(FlatBufferBuilder builder, ELeisureInteract Type = ELeisureInteract.CustomSkill)
		{
			builder.StartTable(1);
			IQiuyuanQinggongExploration4.AddType(builder, Type);
			return IQiuyuanQinggongExploration4.EndIQiuyuanQinggongExploration4(builder);
		}

		// Token: 0x06031B2D RID: 203565 RVA: 0x006BAF1E File Offset: 0x006B911E
		public static void StartIQiuyuanQinggongExploration4(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06031B2E RID: 203566 RVA: 0x006BAF27 File Offset: 0x006B9127
		public static void AddType(FlatBufferBuilder builder, ELeisureInteract type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06031B2F RID: 203567 RVA: 0x006BAF32 File Offset: 0x006B9132
		public static Offset<IQiuyuanQinggongExploration4> EndIQiuyuanQinggongExploration4(FlatBufferBuilder builder)
		{
			return new Offset<IQiuyuanQinggongExploration4>(builder.EndTable());
		}

		// Token: 0x06031B30 RID: 203568 RVA: 0x006BAF40 File Offset: 0x006B9140
		public IQiuyuanQinggongExploration4T UnPack()
		{
			IQiuyuanQinggongExploration4T qiuyuanQinggongExploration4T = new IQiuyuanQinggongExploration4T();
			this.UnPackTo(qiuyuanQinggongExploration4T);
			return qiuyuanQinggongExploration4T;
		}

		// Token: 0x06031B31 RID: 203569 RVA: 0x006BAF5B File Offset: 0x006B915B
		public void UnPackTo(IQiuyuanQinggongExploration4T _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06031B32 RID: 203570 RVA: 0x006BAF6C File Offset: 0x006B916C
		public static Offset<IQiuyuanQinggongExploration4> Pack(FlatBufferBuilder builder, IQiuyuanQinggongExploration4T _o)
		{
			if (_o == null)
			{
				return default(Offset<IQiuyuanQinggongExploration4>);
			}
			return IQiuyuanQinggongExploration4.CreateIQiuyuanQinggongExploration4(builder, _o.Type);
		}

		// Token: 0x040117C6 RID: 71622
		private Table __p;
	}
}
