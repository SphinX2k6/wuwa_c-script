using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004A27 RID: 18983
	public struct ICheckFishingPointHasFish : IFlatbufferObject
	{
		// Token: 0x1700896A RID: 35178
		// (get) Token: 0x0601DB45 RID: 121669 RVA: 0x0042DA94 File Offset: 0x0042BC94
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601DB46 RID: 121670 RVA: 0x0042DAA1 File Offset: 0x0042BCA1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601DB47 RID: 121671 RVA: 0x0042DAA8 File Offset: 0x0042BCA8
		public static ICheckFishingPointHasFish GetRootAsICheckFishingPointHasFish(ByteBuffer _bb)
		{
			return ICheckFishingPointHasFish.GetRootAsICheckFishingPointHasFish(_bb, default(ICheckFishingPointHasFish));
		}

		// Token: 0x0601DB48 RID: 121672 RVA: 0x0042DAC4 File Offset: 0x0042BCC4
		public static ICheckFishingPointHasFish GetRootAsICheckFishingPointHasFish(ByteBuffer _bb, ICheckFishingPointHasFish obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601DB49 RID: 121673 RVA: 0x0042DAE1 File Offset: 0x0042BCE1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601DB4A RID: 121674 RVA: 0x0042DAF0 File Offset: 0x0042BCF0
		public ICheckFishingPointHasFish __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700896B RID: 35179
		// (get) Token: 0x0601DB4B RID: 121675 RVA: 0x0042DB00 File Offset: 0x0042BD00
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

		// Token: 0x1700896C RID: 35180
		// (get) Token: 0x0601DB4C RID: 121676 RVA: 0x0042DB3C File Offset: 0x0042BD3C
		public bool HasFish
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0601DB4D RID: 121677 RVA: 0x0042DB7B File Offset: 0x0042BD7B
		public static Offset<ICheckFishingPointHasFish> CreateICheckFishingPointHasFish(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, bool HasFish = false)
		{
			builder.StartTable(2);
			ICheckFishingPointHasFish.AddHasFish(builder, HasFish);
			ICheckFishingPointHasFish.AddType(builder, Type);
			return ICheckFishingPointHasFish.EndICheckFishingPointHasFish(builder);
		}

		// Token: 0x0601DB4E RID: 121678 RVA: 0x0042DB98 File Offset: 0x0042BD98
		public static void StartICheckFishingPointHasFish(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601DB4F RID: 121679 RVA: 0x0042DBA1 File Offset: 0x0042BDA1
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601DB50 RID: 121680 RVA: 0x0042DBAC File Offset: 0x0042BDAC
		public static void AddHasFish(FlatBufferBuilder builder, bool hasFish)
		{
			builder.AddBool(1, hasFish, false);
		}

		// Token: 0x0601DB51 RID: 121681 RVA: 0x0042DBB7 File Offset: 0x0042BDB7
		public static Offset<ICheckFishingPointHasFish> EndICheckFishingPointHasFish(FlatBufferBuilder builder)
		{
			return new Offset<ICheckFishingPointHasFish>(builder.EndTable());
		}

		// Token: 0x0601DB52 RID: 121682 RVA: 0x0042DBC4 File Offset: 0x0042BDC4
		public ICheckFishingPointHasFishT UnPack()
		{
			ICheckFishingPointHasFishT checkFishingPointHasFishT = new ICheckFishingPointHasFishT();
			this.UnPackTo(checkFishingPointHasFishT);
			return checkFishingPointHasFishT;
		}

		// Token: 0x0601DB53 RID: 121683 RVA: 0x0042DBDF File Offset: 0x0042BDDF
		public void UnPackTo(ICheckFishingPointHasFishT _o)
		{
			_o.Type = this.Type;
			_o.HasFish = this.HasFish;
		}

		// Token: 0x0601DB54 RID: 121684 RVA: 0x0042DBFC File Offset: 0x0042BDFC
		public static Offset<ICheckFishingPointHasFish> Pack(FlatBufferBuilder builder, ICheckFishingPointHasFishT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckFishingPointHasFish>);
			}
			return ICheckFishingPointHasFish.CreateICheckFishingPointHasFish(builder, _o.Type, _o.HasFish);
		}

		// Token: 0x0400D279 RID: 53881
		private Table __p;
	}
}
