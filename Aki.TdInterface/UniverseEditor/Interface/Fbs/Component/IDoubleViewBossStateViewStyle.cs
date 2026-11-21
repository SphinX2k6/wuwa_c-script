using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005616 RID: 22038
	public struct IDoubleViewBossStateViewStyle : IFlatbufferObject
	{
		// Token: 0x17009E0B RID: 40459
		// (get) Token: 0x0602324D RID: 143949 RVA: 0x004D6496 File Offset: 0x004D4696
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602324E RID: 143950 RVA: 0x004D64A3 File Offset: 0x004D46A3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602324F RID: 143951 RVA: 0x004D64AC File Offset: 0x004D46AC
		public static IDoubleViewBossStateViewStyle GetRootAsIDoubleViewBossStateViewStyle(ByteBuffer _bb)
		{
			return IDoubleViewBossStateViewStyle.GetRootAsIDoubleViewBossStateViewStyle(_bb, default(IDoubleViewBossStateViewStyle));
		}

		// Token: 0x06023250 RID: 143952 RVA: 0x004D64C8 File Offset: 0x004D46C8
		public static IDoubleViewBossStateViewStyle GetRootAsIDoubleViewBossStateViewStyle(ByteBuffer _bb, IDoubleViewBossStateViewStyle obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06023251 RID: 143953 RVA: 0x004D64E5 File Offset: 0x004D46E5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06023252 RID: 143954 RVA: 0x004D64F4 File Offset: 0x004D46F4
		public IDoubleViewBossStateViewStyle __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009E0C RID: 40460
		// (get) Token: 0x06023253 RID: 143955 RVA: 0x004D6504 File Offset: 0x004D4704
		public EBossStateViewStyle Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EBossStateViewStyle.DoubleView;
				}
				return (EBossStateViewStyle)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009E0D RID: 40461
		// (get) Token: 0x06023254 RID: 143956 RVA: 0x004D6540 File Offset: 0x004D4740
		public EDoubleViewSlot Slot
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return EDoubleViewSlot.Left;
				}
				return (EDoubleViewSlot)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009E0E RID: 40462
		// (get) Token: 0x06023255 RID: 143957 RVA: 0x004D657C File Offset: 0x004D477C
		public IMarkMainStateTextTarget? MainStateTextTarget
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IMarkMainStateTextTarget?(default(IMarkMainStateTextTarget).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17009E0F RID: 40463
		// (get) Token: 0x06023256 RID: 143958 RVA: 0x004D65DC File Offset: 0x004D47DC
		public int BindMonsterEntityId
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

		// Token: 0x17009E10 RID: 40464
		// (get) Token: 0x06023257 RID: 143959 RVA: 0x004D661C File Offset: 0x004D481C
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06023258 RID: 143960 RVA: 0x004D6659 File Offset: 0x004D4859
		public static Offset<IDoubleViewBossStateViewStyle> CreateIDoubleViewBossStateViewStyle(FlatBufferBuilder builder, EBossStateViewStyle Type = EBossStateViewStyle.DoubleView, EDoubleViewSlot Slot = EDoubleViewSlot.Left, Offset<IMarkMainStateTextTarget> MainStateTextTargetOffset = default(Offset<IMarkMainStateTextTarget>), int BindMonsterEntityId = 0, byte NullMask = 0)
		{
			builder.StartTable(5);
			IDoubleViewBossStateViewStyle.AddBindMonsterEntityId(builder, BindMonsterEntityId);
			IDoubleViewBossStateViewStyle.AddMainStateTextTarget(builder, MainStateTextTargetOffset);
			IDoubleViewBossStateViewStyle.AddNullMask(builder, NullMask);
			IDoubleViewBossStateViewStyle.AddSlot(builder, Slot);
			IDoubleViewBossStateViewStyle.AddType(builder, Type);
			return IDoubleViewBossStateViewStyle.EndIDoubleViewBossStateViewStyle(builder);
		}

		// Token: 0x06023259 RID: 143961 RVA: 0x004D668D File Offset: 0x004D488D
		public static void StartIDoubleViewBossStateViewStyle(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0602325A RID: 143962 RVA: 0x004D6696 File Offset: 0x004D4896
		public static void AddType(FlatBufferBuilder builder, EBossStateViewStyle type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602325B RID: 143963 RVA: 0x004D66A1 File Offset: 0x004D48A1
		public static void AddSlot(FlatBufferBuilder builder, EDoubleViewSlot slot)
		{
			builder.AddByte(1, (byte)slot, 0);
		}

		// Token: 0x0602325C RID: 143964 RVA: 0x004D66AC File Offset: 0x004D48AC
		public static void AddMainStateTextTarget(FlatBufferBuilder builder, Offset<IMarkMainStateTextTarget> mainStateTextTargetOffset)
		{
			builder.AddOffset(2, mainStateTextTargetOffset.Value, 0);
		}

		// Token: 0x0602325D RID: 143965 RVA: 0x004D66BC File Offset: 0x004D48BC
		public static void AddBindMonsterEntityId(FlatBufferBuilder builder, int bindMonsterEntityId)
		{
			builder.AddInt(3, bindMonsterEntityId, 0);
		}

		// Token: 0x0602325E RID: 143966 RVA: 0x004D66C7 File Offset: 0x004D48C7
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x0602325F RID: 143967 RVA: 0x004D66D2 File Offset: 0x004D48D2
		public static Offset<IDoubleViewBossStateViewStyle> EndIDoubleViewBossStateViewStyle(FlatBufferBuilder builder)
		{
			return new Offset<IDoubleViewBossStateViewStyle>(builder.EndTable());
		}

		// Token: 0x06023260 RID: 143968 RVA: 0x004D66E0 File Offset: 0x004D48E0
		public IDoubleViewBossStateViewStyleT UnPack()
		{
			IDoubleViewBossStateViewStyleT doubleViewBossStateViewStyleT = new IDoubleViewBossStateViewStyleT();
			this.UnPackTo(doubleViewBossStateViewStyleT);
			return doubleViewBossStateViewStyleT;
		}

		// Token: 0x06023261 RID: 143969 RVA: 0x004D66FC File Offset: 0x004D48FC
		public void UnPackTo(IDoubleViewBossStateViewStyleT _o)
		{
			_o.Type = this.Type;
			_o.Slot = this.Slot;
			_o.MainStateTextTarget = ((this.MainStateTextTarget != null) ? this.MainStateTextTarget.Value.UnPack() : null);
			_o.BindMonsterEntityId = this.BindMonsterEntityId;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06023262 RID: 143970 RVA: 0x004D6768 File Offset: 0x004D4968
		public static Offset<IDoubleViewBossStateViewStyle> Pack(FlatBufferBuilder builder, IDoubleViewBossStateViewStyleT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDoubleViewBossStateViewStyle>);
			}
			Offset<IMarkMainStateTextTarget> mainStateTextTargetOffset = (_o.MainStateTextTarget == null) ? default(Offset<IMarkMainStateTextTarget>) : IMarkMainStateTextTarget.Pack(builder, _o.MainStateTextTarget);
			return IDoubleViewBossStateViewStyle.CreateIDoubleViewBossStateViewStyle(builder, _o.Type, _o.Slot, mainStateTextTargetOffset, _o.BindMonsterEntityId, _o.NullMask);
		}

		// Token: 0x0400ECD6 RID: 60630
		private Table __p;
	}
}
