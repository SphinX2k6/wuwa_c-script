using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020065CD RID: 26061
	public struct IDisableAlertAreaQuestCondition : IFlatbufferObject
	{
		// Token: 0x1700C167 RID: 49511
		// (get) Token: 0x0602D322 RID: 185122 RVA: 0x0063213E File Offset: 0x0063033E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602D323 RID: 185123 RVA: 0x0063214B File Offset: 0x0063034B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602D324 RID: 185124 RVA: 0x00632154 File Offset: 0x00630354
		public static IDisableAlertAreaQuestCondition GetRootAsIDisableAlertAreaQuestCondition(ByteBuffer _bb)
		{
			return IDisableAlertAreaQuestCondition.GetRootAsIDisableAlertAreaQuestCondition(_bb, default(IDisableAlertAreaQuestCondition));
		}

		// Token: 0x0602D325 RID: 185125 RVA: 0x00632170 File Offset: 0x00630370
		public static IDisableAlertAreaQuestCondition GetRootAsIDisableAlertAreaQuestCondition(ByteBuffer _bb, IDisableAlertAreaQuestCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602D326 RID: 185126 RVA: 0x0063218D File Offset: 0x0063038D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602D327 RID: 185127 RVA: 0x0063219C File Offset: 0x0063039C
		public IDisableAlertAreaQuestCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C168 RID: 49512
		// (get) Token: 0x0602D328 RID: 185128 RVA: 0x006321AC File Offset: 0x006303AC
		public EDisableAlertAreaCondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EDisableAlertAreaCondition.DungeonCondition;
				}
				return (EDisableAlertAreaCondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C169 RID: 49513
		// (get) Token: 0x0602D329 RID: 185129 RVA: 0x006321E8 File Offset: 0x006303E8
		public int RelatedQuestId
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

		// Token: 0x0602D32A RID: 185130 RVA: 0x00632224 File Offset: 0x00630424
		public static Offset<IDisableAlertAreaQuestCondition> CreateIDisableAlertAreaQuestCondition(FlatBufferBuilder builder, EDisableAlertAreaCondition Type = EDisableAlertAreaCondition.DungeonCondition, int RelatedQuestId = 0)
		{
			builder.StartTable(2);
			IDisableAlertAreaQuestCondition.AddRelatedQuestId(builder, RelatedQuestId);
			IDisableAlertAreaQuestCondition.AddType(builder, Type);
			return IDisableAlertAreaQuestCondition.EndIDisableAlertAreaQuestCondition(builder);
		}

		// Token: 0x0602D32B RID: 185131 RVA: 0x00632241 File Offset: 0x00630441
		public static void StartIDisableAlertAreaQuestCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602D32C RID: 185132 RVA: 0x0063224A File Offset: 0x0063044A
		public static void AddType(FlatBufferBuilder builder, EDisableAlertAreaCondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602D32D RID: 185133 RVA: 0x00632255 File Offset: 0x00630455
		public static void AddRelatedQuestId(FlatBufferBuilder builder, int relatedQuestId)
		{
			builder.AddInt(1, relatedQuestId, 0);
		}

		// Token: 0x0602D32E RID: 185134 RVA: 0x00632260 File Offset: 0x00630460
		public static Offset<IDisableAlertAreaQuestCondition> EndIDisableAlertAreaQuestCondition(FlatBufferBuilder builder)
		{
			return new Offset<IDisableAlertAreaQuestCondition>(builder.EndTable());
		}

		// Token: 0x0602D32F RID: 185135 RVA: 0x00632270 File Offset: 0x00630470
		public IDisableAlertAreaQuestConditionT UnPack()
		{
			IDisableAlertAreaQuestConditionT disableAlertAreaQuestConditionT = new IDisableAlertAreaQuestConditionT();
			this.UnPackTo(disableAlertAreaQuestConditionT);
			return disableAlertAreaQuestConditionT;
		}

		// Token: 0x0602D330 RID: 185136 RVA: 0x0063228B File Offset: 0x0063048B
		public void UnPackTo(IDisableAlertAreaQuestConditionT _o)
		{
			_o.Type = this.Type;
			_o.RelatedQuestId = this.RelatedQuestId;
		}

		// Token: 0x0602D331 RID: 185137 RVA: 0x006322A8 File Offset: 0x006304A8
		public static Offset<IDisableAlertAreaQuestCondition> Pack(FlatBufferBuilder builder, IDisableAlertAreaQuestConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDisableAlertAreaQuestCondition>);
			}
			return IDisableAlertAreaQuestCondition.CreateIDisableAlertAreaQuestCondition(builder, _o.Type, _o.RelatedQuestId);
		}

		// Token: 0x04010C2E RID: 68654
		private Table __p;
	}
}
