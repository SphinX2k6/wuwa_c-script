using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C35 RID: 27701
	public struct IDisableAlertAreaQuestCondition : IFlatbufferObject
	{
		// Token: 0x1700CAF6 RID: 51958
		// (get) Token: 0x0602FAA6 RID: 195238 RVA: 0x0067E302 File Offset: 0x0067C502
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602FAA7 RID: 195239 RVA: 0x0067E30F File Offset: 0x0067C50F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602FAA8 RID: 195240 RVA: 0x0067E318 File Offset: 0x0067C518
		public static IDisableAlertAreaQuestCondition GetRootAsIDisableAlertAreaQuestCondition(ByteBuffer _bb)
		{
			return IDisableAlertAreaQuestCondition.GetRootAsIDisableAlertAreaQuestCondition(_bb, default(IDisableAlertAreaQuestCondition));
		}

		// Token: 0x0602FAA9 RID: 195241 RVA: 0x0067E334 File Offset: 0x0067C534
		public static IDisableAlertAreaQuestCondition GetRootAsIDisableAlertAreaQuestCondition(ByteBuffer _bb, IDisableAlertAreaQuestCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602FAAA RID: 195242 RVA: 0x0067E351 File Offset: 0x0067C551
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602FAAB RID: 195243 RVA: 0x0067E360 File Offset: 0x0067C560
		public IDisableAlertAreaQuestCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CAF7 RID: 51959
		// (get) Token: 0x0602FAAC RID: 195244 RVA: 0x0067E370 File Offset: 0x0067C570
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

		// Token: 0x1700CAF8 RID: 51960
		// (get) Token: 0x0602FAAD RID: 195245 RVA: 0x0067E3AC File Offset: 0x0067C5AC
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

		// Token: 0x0602FAAE RID: 195246 RVA: 0x0067E3E8 File Offset: 0x0067C5E8
		public static Offset<IDisableAlertAreaQuestCondition> CreateIDisableAlertAreaQuestCondition(FlatBufferBuilder builder, EDisableAlertAreaCondition Type = EDisableAlertAreaCondition.DungeonCondition, int RelatedQuestId = 0)
		{
			builder.StartTable(2);
			IDisableAlertAreaQuestCondition.AddRelatedQuestId(builder, RelatedQuestId);
			IDisableAlertAreaQuestCondition.AddType(builder, Type);
			return IDisableAlertAreaQuestCondition.EndIDisableAlertAreaQuestCondition(builder);
		}

		// Token: 0x0602FAAF RID: 195247 RVA: 0x0067E405 File Offset: 0x0067C605
		public static void StartIDisableAlertAreaQuestCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602FAB0 RID: 195248 RVA: 0x0067E40E File Offset: 0x0067C60E
		public static void AddType(FlatBufferBuilder builder, EDisableAlertAreaCondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602FAB1 RID: 195249 RVA: 0x0067E419 File Offset: 0x0067C619
		public static void AddRelatedQuestId(FlatBufferBuilder builder, int relatedQuestId)
		{
			builder.AddInt(1, relatedQuestId, 0);
		}

		// Token: 0x0602FAB2 RID: 195250 RVA: 0x0067E424 File Offset: 0x0067C624
		public static Offset<IDisableAlertAreaQuestCondition> EndIDisableAlertAreaQuestCondition(FlatBufferBuilder builder)
		{
			return new Offset<IDisableAlertAreaQuestCondition>(builder.EndTable());
		}

		// Token: 0x0602FAB3 RID: 195251 RVA: 0x0067E434 File Offset: 0x0067C634
		public IDisableAlertAreaQuestConditionT UnPack()
		{
			IDisableAlertAreaQuestConditionT disableAlertAreaQuestConditionT = new IDisableAlertAreaQuestConditionT();
			this.UnPackTo(disableAlertAreaQuestConditionT);
			return disableAlertAreaQuestConditionT;
		}

		// Token: 0x0602FAB4 RID: 195252 RVA: 0x0067E44F File Offset: 0x0067C64F
		public void UnPackTo(IDisableAlertAreaQuestConditionT _o)
		{
			_o.Type = this.Type;
			_o.RelatedQuestId = this.RelatedQuestId;
		}

		// Token: 0x0602FAB5 RID: 195253 RVA: 0x0067E46C File Offset: 0x0067C66C
		public static Offset<IDisableAlertAreaQuestCondition> Pack(FlatBufferBuilder builder, IDisableAlertAreaQuestConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDisableAlertAreaQuestCondition>);
			}
			return IDisableAlertAreaQuestCondition.CreateIDisableAlertAreaQuestCondition(builder, _o.Type, _o.RelatedQuestId);
		}

		// Token: 0x04011A40 RID: 72256
		private Table __p;
	}
}
