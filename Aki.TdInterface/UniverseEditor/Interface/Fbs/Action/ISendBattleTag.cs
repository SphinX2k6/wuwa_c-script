using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007732 RID: 30514
	public struct ISendBattleTag : IFlatbufferObject
	{
		// Token: 0x1700DFB7 RID: 57271
		// (get) Token: 0x0603589B RID: 219291 RVA: 0x0072D29A File Offset: 0x0072B49A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603589C RID: 219292 RVA: 0x0072D2A7 File Offset: 0x0072B4A7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603589D RID: 219293 RVA: 0x0072D2B0 File Offset: 0x0072B4B0
		public static ISendBattleTag GetRootAsISendBattleTag(ByteBuffer _bb)
		{
			return ISendBattleTag.GetRootAsISendBattleTag(_bb, default(ISendBattleTag));
		}

		// Token: 0x0603589E RID: 219294 RVA: 0x0072D2CC File Offset: 0x0072B4CC
		public static ISendBattleTag GetRootAsISendBattleTag(ByteBuffer _bb, ISendBattleTag obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603589F RID: 219295 RVA: 0x0072D2E9 File Offset: 0x0072B4E9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060358A0 RID: 219296 RVA: 0x0072D2F8 File Offset: 0x0072B4F8
		public ISendBattleTag __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DFB8 RID: 57272
		// (get) Token: 0x060358A1 RID: 219297 RVA: 0x0072D308 File Offset: 0x0072B508
		public int TagConfigId
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060358A2 RID: 219298 RVA: 0x0072D344 File Offset: 0x0072B544
		public static Offset<ISendBattleTag> CreateISendBattleTag(FlatBufferBuilder builder, int TagConfigId = 0)
		{
			builder.StartTable(1);
			ISendBattleTag.AddTagConfigId(builder, TagConfigId);
			return ISendBattleTag.EndISendBattleTag(builder);
		}

		// Token: 0x060358A3 RID: 219299 RVA: 0x0072D35A File Offset: 0x0072B55A
		public static void StartISendBattleTag(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060358A4 RID: 219300 RVA: 0x0072D363 File Offset: 0x0072B563
		public static void AddTagConfigId(FlatBufferBuilder builder, int tagConfigId)
		{
			builder.AddInt(0, tagConfigId, 0);
		}

		// Token: 0x060358A5 RID: 219301 RVA: 0x0072D36E File Offset: 0x0072B56E
		public static Offset<ISendBattleTag> EndISendBattleTag(FlatBufferBuilder builder)
		{
			return new Offset<ISendBattleTag>(builder.EndTable());
		}

		// Token: 0x060358A6 RID: 219302 RVA: 0x0072D37C File Offset: 0x0072B57C
		public ISendBattleTagT UnPack()
		{
			ISendBattleTagT sendBattleTagT = new ISendBattleTagT();
			this.UnPackTo(sendBattleTagT);
			return sendBattleTagT;
		}

		// Token: 0x060358A7 RID: 219303 RVA: 0x0072D397 File Offset: 0x0072B597
		public void UnPackTo(ISendBattleTagT _o)
		{
			_o.TagConfigId = this.TagConfigId;
		}

		// Token: 0x060358A8 RID: 219304 RVA: 0x0072D3A8 File Offset: 0x0072B5A8
		public static Offset<ISendBattleTag> Pack(FlatBufferBuilder builder, ISendBattleTagT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISendBattleTag>);
			}
			return ISendBattleTag.CreateISendBattleTag(builder, _o.TagConfigId);
		}

		// Token: 0x0401294D RID: 76109
		private Table __p;
	}
}
