using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x0200509A RID: 20634
	public struct ICompareLiftCondition : IFlatbufferObject
	{
		// Token: 0x170093C2 RID: 37826
		// (get) Token: 0x0602049A RID: 132250 RVA: 0x004790DA File Offset: 0x004772DA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602049B RID: 132251 RVA: 0x004790E7 File Offset: 0x004772E7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602049C RID: 132252 RVA: 0x004790F0 File Offset: 0x004772F0
		public static ICompareLiftCondition GetRootAsICompareLiftCondition(ByteBuffer _bb)
		{
			return ICompareLiftCondition.GetRootAsICompareLiftCondition(_bb, default(ICompareLiftCondition));
		}

		// Token: 0x0602049D RID: 132253 RVA: 0x0047910C File Offset: 0x0047730C
		public static ICompareLiftCondition GetRootAsICompareLiftCondition(ByteBuffer _bb, ICompareLiftCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602049E RID: 132254 RVA: 0x00479129 File Offset: 0x00477329
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602049F RID: 132255 RVA: 0x00479138 File Offset: 0x00477338
		public ICompareLiftCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170093C3 RID: 37827
		// (get) Token: 0x060204A0 RID: 132256 RVA: 0x00479148 File Offset: 0x00477348
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

		// Token: 0x170093C4 RID: 37828
		// (get) Token: 0x060204A1 RID: 132257 RVA: 0x00479184 File Offset: 0x00477384
		public bool IsSelf
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170093C5 RID: 37829
		// (get) Token: 0x060204A2 RID: 132258 RVA: 0x004791C4 File Offset: 0x004773C4
		public int EntityId
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170093C6 RID: 37830
		// (get) Token: 0x060204A3 RID: 132259 RVA: 0x00479200 File Offset: 0x00477400
		public ECompare Compare
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return ECompare.Eq;
				}
				return (ECompare)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170093C7 RID: 37831
		// (get) Token: 0x060204A4 RID: 132260 RVA: 0x00479240 File Offset: 0x00477440
		public int Location
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170093C8 RID: 37832
		// (get) Token: 0x060204A5 RID: 132261 RVA: 0x00479280 File Offset: 0x00477480
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060204A6 RID: 132262 RVA: 0x004792BD File Offset: 0x004774BD
		public static Offset<ICompareLiftCondition> CreateICompareLiftCondition(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, bool IsSelf = false, int EntityId = 0, ECompare Compare = ECompare.Eq, int Location = 0, byte NullMask = 0)
		{
			builder.StartTable(6);
			ICompareLiftCondition.AddLocation(builder, Location);
			ICompareLiftCondition.AddEntityId(builder, EntityId);
			ICompareLiftCondition.AddNullMask(builder, NullMask);
			ICompareLiftCondition.AddCompare(builder, Compare);
			ICompareLiftCondition.AddIsSelf(builder, IsSelf);
			ICompareLiftCondition.AddType(builder, Type);
			return ICompareLiftCondition.EndICompareLiftCondition(builder);
		}

		// Token: 0x060204A7 RID: 132263 RVA: 0x004792F9 File Offset: 0x004774F9
		public static void StartICompareLiftCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x060204A8 RID: 132264 RVA: 0x00479302 File Offset: 0x00477502
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060204A9 RID: 132265 RVA: 0x0047930D File Offset: 0x0047750D
		public static void AddIsSelf(FlatBufferBuilder builder, bool isSelf)
		{
			builder.AddBool(1, isSelf, false);
		}

		// Token: 0x060204AA RID: 132266 RVA: 0x00479318 File Offset: 0x00477518
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(2, entityId, 0);
		}

		// Token: 0x060204AB RID: 132267 RVA: 0x00479323 File Offset: 0x00477523
		public static void AddCompare(FlatBufferBuilder builder, ECompare compare)
		{
			builder.AddByte(3, (byte)compare, 0);
		}

		// Token: 0x060204AC RID: 132268 RVA: 0x0047932E File Offset: 0x0047752E
		public static void AddLocation(FlatBufferBuilder builder, int location)
		{
			builder.AddInt(4, location, 0);
		}

		// Token: 0x060204AD RID: 132269 RVA: 0x00479339 File Offset: 0x00477539
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x060204AE RID: 132270 RVA: 0x00479344 File Offset: 0x00477544
		public static Offset<ICompareLiftCondition> EndICompareLiftCondition(FlatBufferBuilder builder)
		{
			return new Offset<ICompareLiftCondition>(builder.EndTable());
		}

		// Token: 0x060204AF RID: 132271 RVA: 0x00479354 File Offset: 0x00477554
		public ICompareLiftConditionT UnPack()
		{
			ICompareLiftConditionT compareLiftConditionT = new ICompareLiftConditionT();
			this.UnPackTo(compareLiftConditionT);
			return compareLiftConditionT;
		}

		// Token: 0x060204B0 RID: 132272 RVA: 0x00479370 File Offset: 0x00477570
		public void UnPackTo(ICompareLiftConditionT _o)
		{
			_o.Type = this.Type;
			_o.IsSelf = this.IsSelf;
			_o.EntityId = this.EntityId;
			_o.Compare = this.Compare;
			_o.Location = this.Location;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060204B1 RID: 132273 RVA: 0x004793C8 File Offset: 0x004775C8
		public static Offset<ICompareLiftCondition> Pack(FlatBufferBuilder builder, ICompareLiftConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICompareLiftCondition>);
			}
			return ICompareLiftCondition.CreateICompareLiftCondition(builder, _o.Type, _o.IsSelf, _o.EntityId, _o.Compare, _o.Location, _o.NullMask);
		}

		// Token: 0x0400DF97 RID: 57239
		private Table __p;
	}
}
