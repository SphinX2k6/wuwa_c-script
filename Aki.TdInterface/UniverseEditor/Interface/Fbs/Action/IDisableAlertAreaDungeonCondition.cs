using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020065CA RID: 26058
	public struct IDisableAlertAreaDungeonCondition : IFlatbufferObject
	{
		// Token: 0x1700C162 RID: 49506
		// (get) Token: 0x0602D30C RID: 185100 RVA: 0x00631F40 File Offset: 0x00630140
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602D30D RID: 185101 RVA: 0x00631F4D File Offset: 0x0063014D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602D30E RID: 185102 RVA: 0x00631F54 File Offset: 0x00630154
		public static IDisableAlertAreaDungeonCondition GetRootAsIDisableAlertAreaDungeonCondition(ByteBuffer _bb)
		{
			return IDisableAlertAreaDungeonCondition.GetRootAsIDisableAlertAreaDungeonCondition(_bb, default(IDisableAlertAreaDungeonCondition));
		}

		// Token: 0x0602D30F RID: 185103 RVA: 0x00631F70 File Offset: 0x00630170
		public static IDisableAlertAreaDungeonCondition GetRootAsIDisableAlertAreaDungeonCondition(ByteBuffer _bb, IDisableAlertAreaDungeonCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602D310 RID: 185104 RVA: 0x00631F8D File Offset: 0x0063018D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602D311 RID: 185105 RVA: 0x00631F9C File Offset: 0x0063019C
		public IDisableAlertAreaDungeonCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C163 RID: 49507
		// (get) Token: 0x0602D312 RID: 185106 RVA: 0x00631FAC File Offset: 0x006301AC
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

		// Token: 0x1700C164 RID: 49508
		// (get) Token: 0x0602D313 RID: 185107 RVA: 0x00631FE8 File Offset: 0x006301E8
		public int RelatedDungeonId
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

		// Token: 0x0602D314 RID: 185108 RVA: 0x00632024 File Offset: 0x00630224
		public static Offset<IDisableAlertAreaDungeonCondition> CreateIDisableAlertAreaDungeonCondition(FlatBufferBuilder builder, EDisableAlertAreaCondition Type = EDisableAlertAreaCondition.DungeonCondition, int RelatedDungeonId = 0)
		{
			builder.StartTable(2);
			IDisableAlertAreaDungeonCondition.AddRelatedDungeonId(builder, RelatedDungeonId);
			IDisableAlertAreaDungeonCondition.AddType(builder, Type);
			return IDisableAlertAreaDungeonCondition.EndIDisableAlertAreaDungeonCondition(builder);
		}

		// Token: 0x0602D315 RID: 185109 RVA: 0x00632041 File Offset: 0x00630241
		public static void StartIDisableAlertAreaDungeonCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602D316 RID: 185110 RVA: 0x0063204A File Offset: 0x0063024A
		public static void AddType(FlatBufferBuilder builder, EDisableAlertAreaCondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602D317 RID: 185111 RVA: 0x00632055 File Offset: 0x00630255
		public static void AddRelatedDungeonId(FlatBufferBuilder builder, int relatedDungeonId)
		{
			builder.AddInt(1, relatedDungeonId, 0);
		}

		// Token: 0x0602D318 RID: 185112 RVA: 0x00632060 File Offset: 0x00630260
		public static Offset<IDisableAlertAreaDungeonCondition> EndIDisableAlertAreaDungeonCondition(FlatBufferBuilder builder)
		{
			return new Offset<IDisableAlertAreaDungeonCondition>(builder.EndTable());
		}

		// Token: 0x0602D319 RID: 185113 RVA: 0x00632070 File Offset: 0x00630270
		public IDisableAlertAreaDungeonConditionT UnPack()
		{
			IDisableAlertAreaDungeonConditionT disableAlertAreaDungeonConditionT = new IDisableAlertAreaDungeonConditionT();
			this.UnPackTo(disableAlertAreaDungeonConditionT);
			return disableAlertAreaDungeonConditionT;
		}

		// Token: 0x0602D31A RID: 185114 RVA: 0x0063208B File Offset: 0x0063028B
		public void UnPackTo(IDisableAlertAreaDungeonConditionT _o)
		{
			_o.Type = this.Type;
			_o.RelatedDungeonId = this.RelatedDungeonId;
		}

		// Token: 0x0602D31B RID: 185115 RVA: 0x006320A8 File Offset: 0x006302A8
		public static Offset<IDisableAlertAreaDungeonCondition> Pack(FlatBufferBuilder builder, IDisableAlertAreaDungeonConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDisableAlertAreaDungeonCondition>);
			}
			return IDisableAlertAreaDungeonCondition.CreateIDisableAlertAreaDungeonCondition(builder, _o.Type, _o.RelatedDungeonId);
		}

		// Token: 0x04010C2B RID: 68651
		private Table __p;
	}
}
