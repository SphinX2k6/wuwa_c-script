using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005882 RID: 22658
	public struct IRollBlockComponent : IFlatbufferObject
	{
		// Token: 0x1700A972 RID: 43378
		// (get) Token: 0x060262D0 RID: 156368 RVA: 0x00543532 File Offset: 0x00541732
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060262D1 RID: 156369 RVA: 0x0054353F File Offset: 0x0054173F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060262D2 RID: 156370 RVA: 0x00543548 File Offset: 0x00541748
		public static IRollBlockComponent GetRootAsIRollBlockComponent(ByteBuffer _bb)
		{
			return IRollBlockComponent.GetRootAsIRollBlockComponent(_bb, default(IRollBlockComponent));
		}

		// Token: 0x060262D3 RID: 156371 RVA: 0x00543564 File Offset: 0x00541764
		public static IRollBlockComponent GetRootAsIRollBlockComponent(ByteBuffer _bb, IRollBlockComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060262D4 RID: 156372 RVA: 0x00543581 File Offset: 0x00541781
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060262D5 RID: 156373 RVA: 0x00543590 File Offset: 0x00541790
		public IRollBlockComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A973 RID: 43379
		// (get) Token: 0x060262D6 RID: 156374 RVA: 0x005435A0 File Offset: 0x005417A0
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A974 RID: 43380
		// (get) Token: 0x060262D7 RID: 156375 RVA: 0x005435E0 File Offset: 0x005417E0
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060262D8 RID: 156376 RVA: 0x0054361C File Offset: 0x0054181C
		public static Offset<IRollBlockComponent> CreateIRollBlockComponent(FlatBufferBuilder builder, bool Disabled = false, byte NullMask = 0)
		{
			builder.StartTable(2);
			IRollBlockComponent.AddNullMask(builder, NullMask);
			IRollBlockComponent.AddDisabled(builder, Disabled);
			return IRollBlockComponent.EndIRollBlockComponent(builder);
		}

		// Token: 0x060262D9 RID: 156377 RVA: 0x00543639 File Offset: 0x00541839
		public static void StartIRollBlockComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060262DA RID: 156378 RVA: 0x00543642 File Offset: 0x00541842
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x060262DB RID: 156379 RVA: 0x0054364D File Offset: 0x0054184D
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(1, nullMask, 0);
		}

		// Token: 0x060262DC RID: 156380 RVA: 0x00543658 File Offset: 0x00541858
		public static Offset<IRollBlockComponent> EndIRollBlockComponent(FlatBufferBuilder builder)
		{
			return new Offset<IRollBlockComponent>(builder.EndTable());
		}

		// Token: 0x060262DD RID: 156381 RVA: 0x00543668 File Offset: 0x00541868
		public IRollBlockComponentT UnPack()
		{
			IRollBlockComponentT rollBlockComponentT = new IRollBlockComponentT();
			this.UnPackTo(rollBlockComponentT);
			return rollBlockComponentT;
		}

		// Token: 0x060262DE RID: 156382 RVA: 0x00543683 File Offset: 0x00541883
		public void UnPackTo(IRollBlockComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060262DF RID: 156383 RVA: 0x005436A0 File Offset: 0x005418A0
		public static Offset<IRollBlockComponent> Pack(FlatBufferBuilder builder, IRollBlockComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRollBlockComponent>);
			}
			return IRollBlockComponent.CreateIRollBlockComponent(builder, _o.Disabled, _o.NullMask);
		}

		// Token: 0x0400EDCD RID: 60877
		private Table __p;
	}
}
