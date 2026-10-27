using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020052FA RID: 21242
	public struct IGrabComponent : IFlatbufferObject
	{
		// Token: 0x17009BF7 RID: 39927
		// (get) Token: 0x06022B12 RID: 142098 RVA: 0x004CED4A File Offset: 0x004CCF4A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06022B13 RID: 142099 RVA: 0x004CED57 File Offset: 0x004CCF57
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06022B14 RID: 142100 RVA: 0x004CED60 File Offset: 0x004CCF60
		public static IGrabComponent GetRootAsIGrabComponent(ByteBuffer _bb)
		{
			return IGrabComponent.GetRootAsIGrabComponent(_bb, default(IGrabComponent));
		}

		// Token: 0x06022B15 RID: 142101 RVA: 0x004CED7C File Offset: 0x004CCF7C
		public static IGrabComponent GetRootAsIGrabComponent(ByteBuffer _bb, IGrabComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06022B16 RID: 142102 RVA: 0x004CED99 File Offset: 0x004CCF99
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06022B17 RID: 142103 RVA: 0x004CEDA8 File Offset: 0x004CCFA8
		public IGrabComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009BF8 RID: 39928
		// (get) Token: 0x06022B18 RID: 142104 RVA: 0x004CEDB8 File Offset: 0x004CCFB8
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17009BF9 RID: 39929
		// (get) Token: 0x06022B19 RID: 142105 RVA: 0x004CEDF8 File Offset: 0x004CCFF8
		public IVectorInfo? GrabPos
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17009BFA RID: 39930
		// (get) Token: 0x06022B1A RID: 142106 RVA: 0x004CEE58 File Offset: 0x004CD058
		public int ThrowPow
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

		// Token: 0x17009BFB RID: 39931
		// (get) Token: 0x06022B1B RID: 142107 RVA: 0x004CEE94 File Offset: 0x004CD094
		public int ThrowHight
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

		// Token: 0x17009BFC RID: 39932
		// (get) Token: 0x06022B1C RID: 142108 RVA: 0x004CEED4 File Offset: 0x004CD0D4
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

		// Token: 0x06022B1D RID: 142109 RVA: 0x004CEF11 File Offset: 0x004CD111
		public static Offset<IGrabComponent> CreateIGrabComponent(FlatBufferBuilder builder, bool Disabled = false, Offset<IVectorInfo> GrabPosOffset = default(Offset<IVectorInfo>), int ThrowPow = 0, int ThrowHight = 0, byte NullMask = 0)
		{
			builder.StartTable(5);
			IGrabComponent.AddThrowHight(builder, ThrowHight);
			IGrabComponent.AddThrowPow(builder, ThrowPow);
			IGrabComponent.AddGrabPos(builder, GrabPosOffset);
			IGrabComponent.AddNullMask(builder, NullMask);
			IGrabComponent.AddDisabled(builder, Disabled);
			return IGrabComponent.EndIGrabComponent(builder);
		}

		// Token: 0x06022B1E RID: 142110 RVA: 0x004CEF45 File Offset: 0x004CD145
		public static void StartIGrabComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06022B1F RID: 142111 RVA: 0x004CEF4E File Offset: 0x004CD14E
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06022B20 RID: 142112 RVA: 0x004CEF59 File Offset: 0x004CD159
		public static void AddGrabPos(FlatBufferBuilder builder, Offset<IVectorInfo> grabPosOffset)
		{
			builder.AddOffset(1, grabPosOffset.Value, 0);
		}

		// Token: 0x06022B21 RID: 142113 RVA: 0x004CEF69 File Offset: 0x004CD169
		public static void AddThrowPow(FlatBufferBuilder builder, int throwPow)
		{
			builder.AddInt(2, throwPow, 0);
		}

		// Token: 0x06022B22 RID: 142114 RVA: 0x004CEF74 File Offset: 0x004CD174
		public static void AddThrowHight(FlatBufferBuilder builder, int throwHight)
		{
			builder.AddInt(3, throwHight, 0);
		}

		// Token: 0x06022B23 RID: 142115 RVA: 0x004CEF7F File Offset: 0x004CD17F
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x06022B24 RID: 142116 RVA: 0x004CEF8A File Offset: 0x004CD18A
		public static Offset<IGrabComponent> EndIGrabComponent(FlatBufferBuilder builder)
		{
			return new Offset<IGrabComponent>(builder.EndTable());
		}

		// Token: 0x06022B25 RID: 142117 RVA: 0x004CEF98 File Offset: 0x004CD198
		public IGrabComponentT UnPack()
		{
			IGrabComponentT grabComponentT = new IGrabComponentT();
			this.UnPackTo(grabComponentT);
			return grabComponentT;
		}

		// Token: 0x06022B26 RID: 142118 RVA: 0x004CEFB4 File Offset: 0x004CD1B4
		public void UnPackTo(IGrabComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.GrabPos = ((this.GrabPos != null) ? this.GrabPos.Value.UnPack() : null);
			_o.ThrowPow = this.ThrowPow;
			_o.ThrowHight = this.ThrowHight;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06022B27 RID: 142119 RVA: 0x004CF020 File Offset: 0x004CD220
		public static Offset<IGrabComponent> Pack(FlatBufferBuilder builder, IGrabComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGrabComponent>);
			}
			Offset<IVectorInfo> grabPosOffset = (_o.GrabPos == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.GrabPos);
			return IGrabComponent.CreateIGrabComponent(builder, _o.Disabled, grabPosOffset, _o.ThrowPow, _o.ThrowHight, _o.NullMask);
		}

		// Token: 0x0400E4A6 RID: 58534
		private Table __p;
	}
}
