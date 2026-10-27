using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020055D5 RID: 21973
	public struct IMoveComponent : IFlatbufferObject
	{
		// Token: 0x1700A28B RID: 41611
		// (get) Token: 0x060246EB RID: 149227 RVA: 0x00507818 File Offset: 0x00505A18
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060246EC RID: 149228 RVA: 0x00507825 File Offset: 0x00505A25
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060246ED RID: 149229 RVA: 0x0050782C File Offset: 0x00505A2C
		public static IMoveComponent GetRootAsIMoveComponent(ByteBuffer _bb)
		{
			return IMoveComponent.GetRootAsIMoveComponent(_bb, default(IMoveComponent));
		}

		// Token: 0x060246EE RID: 149230 RVA: 0x00507848 File Offset: 0x00505A48
		public static IMoveComponent GetRootAsIMoveComponent(ByteBuffer _bb, IMoveComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060246EF RID: 149231 RVA: 0x00507865 File Offset: 0x00505A65
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060246F0 RID: 149232 RVA: 0x00507874 File Offset: 0x00505A74
		public IMoveComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A28C RID: 41612
		// (get) Token: 0x060246F1 RID: 149233 RVA: 0x00507884 File Offset: 0x00505A84
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A28D RID: 41613
		// (get) Token: 0x060246F2 RID: 149234 RVA: 0x005078C4 File Offset: 0x00505AC4
		public float InitSpeed
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A28E RID: 41614
		// (get) Token: 0x060246F3 RID: 149235 RVA: 0x00507904 File Offset: 0x00505B04
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060246F4 RID: 149236 RVA: 0x00507940 File Offset: 0x00505B40
		public static Offset<IMoveComponent> CreateIMoveComponent(FlatBufferBuilder builder, bool Disabled = false, float InitSpeed = 0f, byte NullMask = 0)
		{
			builder.StartTable(3);
			IMoveComponent.AddInitSpeed(builder, InitSpeed);
			IMoveComponent.AddNullMask(builder, NullMask);
			IMoveComponent.AddDisabled(builder, Disabled);
			return IMoveComponent.EndIMoveComponent(builder);
		}

		// Token: 0x060246F5 RID: 149237 RVA: 0x00507964 File Offset: 0x00505B64
		public static void StartIMoveComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060246F6 RID: 149238 RVA: 0x0050796D File Offset: 0x00505B6D
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x060246F7 RID: 149239 RVA: 0x00507978 File Offset: 0x00505B78
		public static void AddInitSpeed(FlatBufferBuilder builder, float initSpeed)
		{
			builder.AddFloat(1, initSpeed, 0.0);
		}

		// Token: 0x060246F8 RID: 149240 RVA: 0x0050798B File Offset: 0x00505B8B
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x060246F9 RID: 149241 RVA: 0x00507996 File Offset: 0x00505B96
		public static Offset<IMoveComponent> EndIMoveComponent(FlatBufferBuilder builder)
		{
			return new Offset<IMoveComponent>(builder.EndTable());
		}

		// Token: 0x060246FA RID: 149242 RVA: 0x005079A4 File Offset: 0x00505BA4
		public IMoveComponentT UnPack()
		{
			IMoveComponentT moveComponentT = new IMoveComponentT();
			this.UnPackTo(moveComponentT);
			return moveComponentT;
		}

		// Token: 0x060246FB RID: 149243 RVA: 0x005079BF File Offset: 0x00505BBF
		public void UnPackTo(IMoveComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.InitSpeed = this.InitSpeed;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060246FC RID: 149244 RVA: 0x005079E8 File Offset: 0x00505BE8
		public static Offset<IMoveComponent> Pack(FlatBufferBuilder builder, IMoveComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMoveComponent>);
			}
			return IMoveComponent.CreateIMoveComponent(builder, _o.Disabled, _o.InitSpeed, _o.NullMask);
		}

		// Token: 0x0400E936 RID: 59702
		private Table __p;
	}
}
