using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020050B1 RID: 20657
	public struct IDoubleViewBossStateViewStyle : IFlatbufferObject
	{
		// Token: 0x1700961E RID: 38430
		// (get) Token: 0x060212F9 RID: 135929 RVA: 0x0049C50A File Offset: 0x0049A70A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060212FA RID: 135930 RVA: 0x0049C517 File Offset: 0x0049A717
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060212FB RID: 135931 RVA: 0x0049C520 File Offset: 0x0049A720
		public static IDoubleViewBossStateViewStyle GetRootAsIDoubleViewBossStateViewStyle(ByteBuffer _bb)
		{
			return IDoubleViewBossStateViewStyle.GetRootAsIDoubleViewBossStateViewStyle(_bb, default(IDoubleViewBossStateViewStyle));
		}

		// Token: 0x060212FC RID: 135932 RVA: 0x0049C53C File Offset: 0x0049A73C
		public static IDoubleViewBossStateViewStyle GetRootAsIDoubleViewBossStateViewStyle(ByteBuffer _bb, IDoubleViewBossStateViewStyle obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060212FD RID: 135933 RVA: 0x0049C559 File Offset: 0x0049A759
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060212FE RID: 135934 RVA: 0x0049C568 File Offset: 0x0049A768
		public IDoubleViewBossStateViewStyle __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700961F RID: 38431
		// (get) Token: 0x060212FF RID: 135935 RVA: 0x0049C578 File Offset: 0x0049A778
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

		// Token: 0x17009620 RID: 38432
		// (get) Token: 0x06021300 RID: 135936 RVA: 0x0049C5B4 File Offset: 0x0049A7B4
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

		// Token: 0x17009621 RID: 38433
		// (get) Token: 0x06021301 RID: 135937 RVA: 0x0049C5F0 File Offset: 0x0049A7F0
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

		// Token: 0x17009622 RID: 38434
		// (get) Token: 0x06021302 RID: 135938 RVA: 0x0049C650 File Offset: 0x0049A850
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

		// Token: 0x17009623 RID: 38435
		// (get) Token: 0x06021303 RID: 135939 RVA: 0x0049C690 File Offset: 0x0049A890
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

		// Token: 0x06021304 RID: 135940 RVA: 0x0049C6CD File Offset: 0x0049A8CD
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

		// Token: 0x06021305 RID: 135941 RVA: 0x0049C701 File Offset: 0x0049A901
		public static void StartIDoubleViewBossStateViewStyle(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06021306 RID: 135942 RVA: 0x0049C70A File Offset: 0x0049A90A
		public static void AddType(FlatBufferBuilder builder, EBossStateViewStyle type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06021307 RID: 135943 RVA: 0x0049C715 File Offset: 0x0049A915
		public static void AddSlot(FlatBufferBuilder builder, EDoubleViewSlot slot)
		{
			builder.AddByte(1, (byte)slot, 0);
		}

		// Token: 0x06021308 RID: 135944 RVA: 0x0049C720 File Offset: 0x0049A920
		public static void AddMainStateTextTarget(FlatBufferBuilder builder, Offset<IMarkMainStateTextTarget> mainStateTextTargetOffset)
		{
			builder.AddOffset(2, mainStateTextTargetOffset.Value, 0);
		}

		// Token: 0x06021309 RID: 135945 RVA: 0x0049C730 File Offset: 0x0049A930
		public static void AddBindMonsterEntityId(FlatBufferBuilder builder, int bindMonsterEntityId)
		{
			builder.AddInt(3, bindMonsterEntityId, 0);
		}

		// Token: 0x0602130A RID: 135946 RVA: 0x0049C73B File Offset: 0x0049A93B
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x0602130B RID: 135947 RVA: 0x0049C746 File Offset: 0x0049A946
		public static Offset<IDoubleViewBossStateViewStyle> EndIDoubleViewBossStateViewStyle(FlatBufferBuilder builder)
		{
			return new Offset<IDoubleViewBossStateViewStyle>(builder.EndTable());
		}

		// Token: 0x0602130C RID: 135948 RVA: 0x0049C754 File Offset: 0x0049A954
		public IDoubleViewBossStateViewStyleT UnPack()
		{
			IDoubleViewBossStateViewStyleT doubleViewBossStateViewStyleT = new IDoubleViewBossStateViewStyleT();
			this.UnPackTo(doubleViewBossStateViewStyleT);
			return doubleViewBossStateViewStyleT;
		}

		// Token: 0x0602130D RID: 135949 RVA: 0x0049C770 File Offset: 0x0049A970
		public void UnPackTo(IDoubleViewBossStateViewStyleT _o)
		{
			_o.Type = this.Type;
			_o.Slot = this.Slot;
			_o.MainStateTextTarget = ((this.MainStateTextTarget != null) ? this.MainStateTextTarget.Value.UnPack() : null);
			_o.BindMonsterEntityId = this.BindMonsterEntityId;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602130E RID: 135950 RVA: 0x0049C7DC File Offset: 0x0049A9DC
		public static Offset<IDoubleViewBossStateViewStyle> Pack(FlatBufferBuilder builder, IDoubleViewBossStateViewStyleT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDoubleViewBossStateViewStyle>);
			}
			Offset<IMarkMainStateTextTarget> mainStateTextTargetOffset = (_o.MainStateTextTarget == null) ? default(Offset<IMarkMainStateTextTarget>) : IMarkMainStateTextTarget.Pack(builder, _o.MainStateTextTarget);
			return IDoubleViewBossStateViewStyle.CreateIDoubleViewBossStateViewStyle(builder, _o.Type, _o.Slot, mainStateTextTargetOffset, _o.BindMonsterEntityId, _o.NullMask);
		}

		// Token: 0x0400E0D9 RID: 57561
		private Table __p;
	}
}
