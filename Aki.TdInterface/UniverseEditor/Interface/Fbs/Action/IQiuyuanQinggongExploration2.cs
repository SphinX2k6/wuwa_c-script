using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006DE3 RID: 28131
	public struct IQiuyuanQinggongExploration2 : IFlatbufferObject
	{
		// Token: 0x1700D1B1 RID: 53681
		// (get) Token: 0x06031B01 RID: 203521 RVA: 0x006BAB6D File Offset: 0x006B8D6D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031B02 RID: 203522 RVA: 0x006BAB7A File Offset: 0x006B8D7A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06031B03 RID: 203523 RVA: 0x006BAB84 File Offset: 0x006B8D84
		public static IQiuyuanQinggongExploration2 GetRootAsIQiuyuanQinggongExploration2(ByteBuffer _bb)
		{
			return IQiuyuanQinggongExploration2.GetRootAsIQiuyuanQinggongExploration2(_bb, default(IQiuyuanQinggongExploration2));
		}

		// Token: 0x06031B04 RID: 203524 RVA: 0x006BABA0 File Offset: 0x006B8DA0
		public static IQiuyuanQinggongExploration2 GetRootAsIQiuyuanQinggongExploration2(ByteBuffer _bb, IQiuyuanQinggongExploration2 obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06031B05 RID: 203525 RVA: 0x006BABBD File Offset: 0x006B8DBD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031B06 RID: 203526 RVA: 0x006BABCC File Offset: 0x006B8DCC
		public IQiuyuanQinggongExploration2 __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D1B2 RID: 53682
		// (get) Token: 0x06031B07 RID: 203527 RVA: 0x006BABDC File Offset: 0x006B8DDC
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

		// Token: 0x06031B08 RID: 203528 RVA: 0x006BAC18 File Offset: 0x006B8E18
		public static Offset<IQiuyuanQinggongExploration2> CreateIQiuyuanQinggongExploration2(FlatBufferBuilder builder, ELeisureInteract Type = ELeisureInteract.CustomSkill)
		{
			builder.StartTable(1);
			IQiuyuanQinggongExploration2.AddType(builder, Type);
			return IQiuyuanQinggongExploration2.EndIQiuyuanQinggongExploration2(builder);
		}

		// Token: 0x06031B09 RID: 203529 RVA: 0x006BAC2E File Offset: 0x006B8E2E
		public static void StartIQiuyuanQinggongExploration2(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06031B0A RID: 203530 RVA: 0x006BAC37 File Offset: 0x006B8E37
		public static void AddType(FlatBufferBuilder builder, ELeisureInteract type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06031B0B RID: 203531 RVA: 0x006BAC42 File Offset: 0x006B8E42
		public static Offset<IQiuyuanQinggongExploration2> EndIQiuyuanQinggongExploration2(FlatBufferBuilder builder)
		{
			return new Offset<IQiuyuanQinggongExploration2>(builder.EndTable());
		}

		// Token: 0x06031B0C RID: 203532 RVA: 0x006BAC50 File Offset: 0x006B8E50
		public IQiuyuanQinggongExploration2T UnPack()
		{
			IQiuyuanQinggongExploration2T qiuyuanQinggongExploration2T = new IQiuyuanQinggongExploration2T();
			this.UnPackTo(qiuyuanQinggongExploration2T);
			return qiuyuanQinggongExploration2T;
		}

		// Token: 0x06031B0D RID: 203533 RVA: 0x006BAC6B File Offset: 0x006B8E6B
		public void UnPackTo(IQiuyuanQinggongExploration2T _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06031B0E RID: 203534 RVA: 0x006BAC7C File Offset: 0x006B8E7C
		public static Offset<IQiuyuanQinggongExploration2> Pack(FlatBufferBuilder builder, IQiuyuanQinggongExploration2T _o)
		{
			if (_o == null)
			{
				return default(Offset<IQiuyuanQinggongExploration2>);
			}
			return IQiuyuanQinggongExploration2.CreateIQiuyuanQinggongExploration2(builder, _o.Type);
		}

		// Token: 0x040117C2 RID: 71618
		private Table __p;
	}
}
