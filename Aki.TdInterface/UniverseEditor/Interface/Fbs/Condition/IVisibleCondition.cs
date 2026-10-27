using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004D12 RID: 19730
	public struct IVisibleCondition : IFlatbufferObject
	{
		// Token: 0x17008F16 RID: 36630
		// (get) Token: 0x0601F508 RID: 128264 RVA: 0x0045E030 File Offset: 0x0045C230
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601F509 RID: 128265 RVA: 0x0045E03D File Offset: 0x0045C23D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601F50A RID: 128266 RVA: 0x0045E044 File Offset: 0x0045C244
		public static IVisibleCondition GetRootAsIVisibleCondition(ByteBuffer _bb)
		{
			return IVisibleCondition.GetRootAsIVisibleCondition(_bb, default(IVisibleCondition));
		}

		// Token: 0x0601F50B RID: 128267 RVA: 0x0045E060 File Offset: 0x0045C260
		public static IVisibleCondition GetRootAsIVisibleCondition(ByteBuffer _bb, IVisibleCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601F50C RID: 128268 RVA: 0x0045E07D File Offset: 0x0045C27D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601F50D RID: 128269 RVA: 0x0045E08C File Offset: 0x0045C28C
		public IVisibleCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008F17 RID: 36631
		// (get) Token: 0x0601F50E RID: 128270 RVA: 0x0045E09C File Offset: 0x0045C29C
		public EVisibleCondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EVisibleCondition.Weather;
				}
				return (EVisibleCondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008F18 RID: 36632
		// (get) Token: 0x0601F50F RID: 128271 RVA: 0x0045E0D8 File Offset: 0x0045C2D8
		public ECompare Compare
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return ECompare.Eq;
				}
				return (ECompare)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601F510 RID: 128272 RVA: 0x0045E114 File Offset: 0x0045C314
		public static Offset<IVisibleCondition> CreateIVisibleCondition(FlatBufferBuilder builder, EVisibleCondition Type = EVisibleCondition.Weather, ECompare Compare = ECompare.Eq)
		{
			builder.StartTable(2);
			IVisibleCondition.AddCompare(builder, Compare);
			IVisibleCondition.AddType(builder, Type);
			return IVisibleCondition.EndIVisibleCondition(builder);
		}

		// Token: 0x0601F511 RID: 128273 RVA: 0x0045E131 File Offset: 0x0045C331
		public static void StartIVisibleCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601F512 RID: 128274 RVA: 0x0045E13A File Offset: 0x0045C33A
		public static void AddType(FlatBufferBuilder builder, EVisibleCondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601F513 RID: 128275 RVA: 0x0045E145 File Offset: 0x0045C345
		public static void AddCompare(FlatBufferBuilder builder, ECompare compare)
		{
			builder.AddByte(1, (byte)compare, 0);
		}

		// Token: 0x0601F514 RID: 128276 RVA: 0x0045E150 File Offset: 0x0045C350
		public static Offset<IVisibleCondition> EndIVisibleCondition(FlatBufferBuilder builder)
		{
			return new Offset<IVisibleCondition>(builder.EndTable());
		}

		// Token: 0x0601F515 RID: 128277 RVA: 0x0045E160 File Offset: 0x0045C360
		public IVisibleConditionT UnPack()
		{
			IVisibleConditionT visibleConditionT = new IVisibleConditionT();
			this.UnPackTo(visibleConditionT);
			return visibleConditionT;
		}

		// Token: 0x0601F516 RID: 128278 RVA: 0x0045E17B File Offset: 0x0045C37B
		public void UnPackTo(IVisibleConditionT _o)
		{
			_o.Type = this.Type;
			_o.Compare = this.Compare;
		}

		// Token: 0x0601F517 RID: 128279 RVA: 0x0045E198 File Offset: 0x0045C398
		public static Offset<IVisibleCondition> Pack(FlatBufferBuilder builder, IVisibleConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVisibleCondition>);
			}
			return IVisibleCondition.CreateIVisibleCondition(builder, _o.Type, _o.Compare);
		}

		// Token: 0x0400D6F3 RID: 55027
		private Table __p;
	}
}
