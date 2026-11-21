using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004E90 RID: 20112
	public struct ICheckDollGrabShowcaseItemComboAchieved : IFlatbufferObject
	{
		// Token: 0x17008F6F RID: 36719
		// (get) Token: 0x0601F28B RID: 127627 RVA: 0x004588A4 File Offset: 0x00456AA4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601F28C RID: 127628 RVA: 0x004588B1 File Offset: 0x00456AB1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601F28D RID: 127629 RVA: 0x004588B8 File Offset: 0x00456AB8
		public static ICheckDollGrabShowcaseItemComboAchieved GetRootAsICheckDollGrabShowcaseItemComboAchieved(ByteBuffer _bb)
		{
			return ICheckDollGrabShowcaseItemComboAchieved.GetRootAsICheckDollGrabShowcaseItemComboAchieved(_bb, default(ICheckDollGrabShowcaseItemComboAchieved));
		}

		// Token: 0x0601F28E RID: 127630 RVA: 0x004588D4 File Offset: 0x00456AD4
		public static ICheckDollGrabShowcaseItemComboAchieved GetRootAsICheckDollGrabShowcaseItemComboAchieved(ByteBuffer _bb, ICheckDollGrabShowcaseItemComboAchieved obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601F28F RID: 127631 RVA: 0x004588F1 File Offset: 0x00456AF1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601F290 RID: 127632 RVA: 0x00458900 File Offset: 0x00456B00
		public ICheckDollGrabShowcaseItemComboAchieved __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008F70 RID: 36720
		// (get) Token: 0x0601F291 RID: 127633 RVA: 0x00458910 File Offset: 0x00456B10
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

		// Token: 0x17008F71 RID: 36721
		// (get) Token: 0x0601F292 RID: 127634 RVA: 0x0045894C File Offset: 0x00456B4C
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

		// Token: 0x17008F72 RID: 36722
		// (get) Token: 0x0601F293 RID: 127635 RVA: 0x00458988 File Offset: 0x00456B88
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

		// Token: 0x17008F73 RID: 36723
		// (get) Token: 0x0601F294 RID: 127636 RVA: 0x004589C4 File Offset: 0x00456BC4
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

		// Token: 0x0601F295 RID: 127637 RVA: 0x00458A01 File Offset: 0x00456C01
		public static Offset<ICheckDollGrabShowcaseItemComboAchieved> CreateICheckDollGrabShowcaseItemComboAchieved(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, int ShowcaseEntityId = 0, ECompare Compare = ECompare.Eq, int Count = 0)
		{
			builder.StartTable(4);
			ICheckDollGrabShowcaseItemComboAchieved.AddCount(builder, Count);
			ICheckDollGrabShowcaseItemComboAchieved.AddShowcaseEntityId(builder, ShowcaseEntityId);
			ICheckDollGrabShowcaseItemComboAchieved.AddCompare(builder, Compare);
			ICheckDollGrabShowcaseItemComboAchieved.AddType(builder, Type);
			return ICheckDollGrabShowcaseItemComboAchieved.EndICheckDollGrabShowcaseItemComboAchieved(builder);
		}

		// Token: 0x0601F296 RID: 127638 RVA: 0x00458A2D File Offset: 0x00456C2D
		public static void StartICheckDollGrabShowcaseItemComboAchieved(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601F297 RID: 127639 RVA: 0x00458A36 File Offset: 0x00456C36
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601F298 RID: 127640 RVA: 0x00458A41 File Offset: 0x00456C41
		public static void AddShowcaseEntityId(FlatBufferBuilder builder, int showcaseEntityId)
		{
			builder.AddInt(1, showcaseEntityId, 0);
		}

		// Token: 0x0601F299 RID: 127641 RVA: 0x00458A4C File Offset: 0x00456C4C
		public static void AddCompare(FlatBufferBuilder builder, ECompare compare)
		{
			builder.AddByte(2, (byte)compare, 0);
		}

		// Token: 0x0601F29A RID: 127642 RVA: 0x00458A57 File Offset: 0x00456C57
		public static void AddCount(FlatBufferBuilder builder, int count)
		{
			builder.AddInt(3, count, 0);
		}

		// Token: 0x0601F29B RID: 127643 RVA: 0x00458A62 File Offset: 0x00456C62
		public static Offset<ICheckDollGrabShowcaseItemComboAchieved> EndICheckDollGrabShowcaseItemComboAchieved(FlatBufferBuilder builder)
		{
			return new Offset<ICheckDollGrabShowcaseItemComboAchieved>(builder.EndTable());
		}

		// Token: 0x0601F29C RID: 127644 RVA: 0x00458A70 File Offset: 0x00456C70
		public ICheckDollGrabShowcaseItemComboAchievedT UnPack()
		{
			ICheckDollGrabShowcaseItemComboAchievedT checkDollGrabShowcaseItemComboAchievedT = new ICheckDollGrabShowcaseItemComboAchievedT();
			this.UnPackTo(checkDollGrabShowcaseItemComboAchievedT);
			return checkDollGrabShowcaseItemComboAchievedT;
		}

		// Token: 0x0601F29D RID: 127645 RVA: 0x00458A8B File Offset: 0x00456C8B
		public void UnPackTo(ICheckDollGrabShowcaseItemComboAchievedT _o)
		{
			_o.Type = this.Type;
			_o.ShowcaseEntityId = this.ShowcaseEntityId;
			_o.Compare = this.Compare;
			_o.Count = this.Count;
		}

		// Token: 0x0601F29E RID: 127646 RVA: 0x00458AC0 File Offset: 0x00456CC0
		public static Offset<ICheckDollGrabShowcaseItemComboAchieved> Pack(FlatBufferBuilder builder, ICheckDollGrabShowcaseItemComboAchievedT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckDollGrabShowcaseItemComboAchieved>);
			}
			return ICheckDollGrabShowcaseItemComboAchieved.CreateICheckDollGrabShowcaseItemComboAchieved(builder, _o.Type, _o.ShowcaseEntityId, _o.Compare, _o.Count);
		}

		// Token: 0x0400DCCE RID: 56526
		private Table __p;
	}
}
