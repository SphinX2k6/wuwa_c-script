using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020049D0 RID: 18896
	public struct ICheckDollGrabShowcaseItemComboAchieved : IFlatbufferObject
	{
		// Token: 0x1700889F RID: 34975
		// (get) Token: 0x0601D818 RID: 120856 RVA: 0x00427C38 File Offset: 0x00425E38
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601D819 RID: 120857 RVA: 0x00427C45 File Offset: 0x00425E45
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601D81A RID: 120858 RVA: 0x00427C4C File Offset: 0x00425E4C
		public static ICheckDollGrabShowcaseItemComboAchieved GetRootAsICheckDollGrabShowcaseItemComboAchieved(ByteBuffer _bb)
		{
			return ICheckDollGrabShowcaseItemComboAchieved.GetRootAsICheckDollGrabShowcaseItemComboAchieved(_bb, default(ICheckDollGrabShowcaseItemComboAchieved));
		}

		// Token: 0x0601D81B RID: 120859 RVA: 0x00427C68 File Offset: 0x00425E68
		public static ICheckDollGrabShowcaseItemComboAchieved GetRootAsICheckDollGrabShowcaseItemComboAchieved(ByteBuffer _bb, ICheckDollGrabShowcaseItemComboAchieved obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601D81C RID: 120860 RVA: 0x00427C85 File Offset: 0x00425E85
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601D81D RID: 120861 RVA: 0x00427C94 File Offset: 0x00425E94
		public ICheckDollGrabShowcaseItemComboAchieved __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170088A0 RID: 34976
		// (get) Token: 0x0601D81E RID: 120862 RVA: 0x00427CA4 File Offset: 0x00425EA4
		public ECondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECondition.CompareVar;
				}
				return (ECondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170088A1 RID: 34977
		// (get) Token: 0x0601D81F RID: 120863 RVA: 0x00427CE0 File Offset: 0x00425EE0
		public int ShowcaseEntityId
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

		// Token: 0x170088A2 RID: 34978
		// (get) Token: 0x0601D820 RID: 120864 RVA: 0x00427D1C File Offset: 0x00425F1C
		public ECompare Compare
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return ECompare.Eq;
				}
				return (ECompare)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170088A3 RID: 34979
		// (get) Token: 0x0601D821 RID: 120865 RVA: 0x00427D58 File Offset: 0x00425F58
		public int Count
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601D822 RID: 120866 RVA: 0x00427D95 File Offset: 0x00425F95
		public static Offset<ICheckDollGrabShowcaseItemComboAchieved> CreateICheckDollGrabShowcaseItemComboAchieved(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, int ShowcaseEntityId = 0, ECompare Compare = ECompare.Eq, int Count = 0)
		{
			builder.StartTable(4);
			ICheckDollGrabShowcaseItemComboAchieved.AddCount(builder, Count);
			ICheckDollGrabShowcaseItemComboAchieved.AddShowcaseEntityId(builder, ShowcaseEntityId);
			ICheckDollGrabShowcaseItemComboAchieved.AddCompare(builder, Compare);
			ICheckDollGrabShowcaseItemComboAchieved.AddType(builder, Type);
			return ICheckDollGrabShowcaseItemComboAchieved.EndICheckDollGrabShowcaseItemComboAchieved(builder);
		}

		// Token: 0x0601D823 RID: 120867 RVA: 0x00427DC1 File Offset: 0x00425FC1
		public static void StartICheckDollGrabShowcaseItemComboAchieved(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601D824 RID: 120868 RVA: 0x00427DCA File Offset: 0x00425FCA
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601D825 RID: 120869 RVA: 0x00427DD5 File Offset: 0x00425FD5
		public static void AddShowcaseEntityId(FlatBufferBuilder builder, int showcaseEntityId)
		{
			builder.AddInt(1, showcaseEntityId, 0);
		}

		// Token: 0x0601D826 RID: 120870 RVA: 0x00427DE0 File Offset: 0x00425FE0
		public static void AddCompare(FlatBufferBuilder builder, ECompare compare)
		{
			builder.AddByte(2, (byte)compare, 0);
		}

		// Token: 0x0601D827 RID: 120871 RVA: 0x00427DEB File Offset: 0x00425FEB
		public static void AddCount(FlatBufferBuilder builder, int count)
		{
			builder.AddInt(3, count, 0);
		}

		// Token: 0x0601D828 RID: 120872 RVA: 0x00427DF6 File Offset: 0x00425FF6
		public static Offset<ICheckDollGrabShowcaseItemComboAchieved> EndICheckDollGrabShowcaseItemComboAchieved(FlatBufferBuilder builder)
		{
			return new Offset<ICheckDollGrabShowcaseItemComboAchieved>(builder.EndTable());
		}

		// Token: 0x0601D829 RID: 120873 RVA: 0x00427E04 File Offset: 0x00426004
		public ICheckDollGrabShowcaseItemComboAchievedT UnPack()
		{
			ICheckDollGrabShowcaseItemComboAchievedT checkDollGrabShowcaseItemComboAchievedT = new ICheckDollGrabShowcaseItemComboAchievedT();
			this.UnPackTo(checkDollGrabShowcaseItemComboAchievedT);
			return checkDollGrabShowcaseItemComboAchievedT;
		}

		// Token: 0x0601D82A RID: 120874 RVA: 0x00427E1F File Offset: 0x0042601F
		public void UnPackTo(ICheckDollGrabShowcaseItemComboAchievedT _o)
		{
			_o.Type = this.Type;
			_o.ShowcaseEntityId = this.ShowcaseEntityId;
			_o.Compare = this.Compare;
			_o.Count = this.Count;
		}

		// Token: 0x0601D82B RID: 120875 RVA: 0x00427E54 File Offset: 0x00426054
		public static Offset<ICheckDollGrabShowcaseItemComboAchieved> Pack(FlatBufferBuilder builder, ICheckDollGrabShowcaseItemComboAchievedT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckDollGrabShowcaseItemComboAchieved>);
			}
			return ICheckDollGrabShowcaseItemComboAchieved.CreateICheckDollGrabShowcaseItemComboAchieved(builder, _o.Type, _o.ShowcaseEntityId, _o.Compare, _o.Count);
		}

		// Token: 0x0400D1FA RID: 53754
		private Table __p;
	}
}
