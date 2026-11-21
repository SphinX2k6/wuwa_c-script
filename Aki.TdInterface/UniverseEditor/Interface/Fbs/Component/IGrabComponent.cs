using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200587D RID: 22653
	public struct IGrabComponent : IFlatbufferObject
	{
		// Token: 0x1700A428 RID: 42024
		// (get) Token: 0x06024BAC RID: 150444 RVA: 0x0050B876 File Offset: 0x00509A76
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06024BAD RID: 150445 RVA: 0x0050B883 File Offset: 0x00509A83
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06024BAE RID: 150446 RVA: 0x0050B88C File Offset: 0x00509A8C
		public static IGrabComponent GetRootAsIGrabComponent(ByteBuffer _bb)
		{
			return IGrabComponent.GetRootAsIGrabComponent(_bb, default(IGrabComponent));
		}

		// Token: 0x06024BAF RID: 150447 RVA: 0x0050B8A8 File Offset: 0x00509AA8
		public static IGrabComponent GetRootAsIGrabComponent(ByteBuffer _bb, IGrabComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06024BB0 RID: 150448 RVA: 0x0050B8C5 File Offset: 0x00509AC5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06024BB1 RID: 150449 RVA: 0x0050B8D4 File Offset: 0x00509AD4
		public IGrabComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A429 RID: 42025
		// (get) Token: 0x06024BB2 RID: 150450 RVA: 0x0050B8E4 File Offset: 0x00509AE4
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A42A RID: 42026
		// (get) Token: 0x06024BB3 RID: 150451 RVA: 0x0050B924 File Offset: 0x00509B24
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

		// Token: 0x1700A42B RID: 42027
		// (get) Token: 0x06024BB4 RID: 150452 RVA: 0x0050B984 File Offset: 0x00509B84
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

		// Token: 0x1700A42C RID: 42028
		// (get) Token: 0x06024BB5 RID: 150453 RVA: 0x0050B9C0 File Offset: 0x00509BC0
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

		// Token: 0x1700A42D RID: 42029
		// (get) Token: 0x06024BB6 RID: 150454 RVA: 0x0050BA00 File Offset: 0x00509C00
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

		// Token: 0x06024BB7 RID: 150455 RVA: 0x0050BA3D File Offset: 0x00509C3D
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

		// Token: 0x06024BB8 RID: 150456 RVA: 0x0050BA71 File Offset: 0x00509C71
		public static void StartIGrabComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06024BB9 RID: 150457 RVA: 0x0050BA7A File Offset: 0x00509C7A
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06024BBA RID: 150458 RVA: 0x0050BA85 File Offset: 0x00509C85
		public static void AddGrabPos(FlatBufferBuilder builder, Offset<IVectorInfo> grabPosOffset)
		{
			builder.AddOffset(1, grabPosOffset.Value, 0);
		}

		// Token: 0x06024BBB RID: 150459 RVA: 0x0050BA95 File Offset: 0x00509C95
		public static void AddThrowPow(FlatBufferBuilder builder, int throwPow)
		{
			builder.AddInt(2, throwPow, 0);
		}

		// Token: 0x06024BBC RID: 150460 RVA: 0x0050BAA0 File Offset: 0x00509CA0
		public static void AddThrowHight(FlatBufferBuilder builder, int throwHight)
		{
			builder.AddInt(3, throwHight, 0);
		}

		// Token: 0x06024BBD RID: 150461 RVA: 0x0050BAAB File Offset: 0x00509CAB
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x06024BBE RID: 150462 RVA: 0x0050BAB6 File Offset: 0x00509CB6
		public static Offset<IGrabComponent> EndIGrabComponent(FlatBufferBuilder builder)
		{
			return new Offset<IGrabComponent>(builder.EndTable());
		}

		// Token: 0x06024BBF RID: 150463 RVA: 0x0050BAC4 File Offset: 0x00509CC4
		public IGrabComponentT UnPack()
		{
			IGrabComponentT grabComponentT = new IGrabComponentT();
			this.UnPackTo(grabComponentT);
			return grabComponentT;
		}

		// Token: 0x06024BC0 RID: 150464 RVA: 0x0050BAE0 File Offset: 0x00509CE0
		public void UnPackTo(IGrabComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.GrabPos = ((this.GrabPos != null) ? this.GrabPos.Value.UnPack() : null);
			_o.ThrowPow = this.ThrowPow;
			_o.ThrowHight = this.ThrowHight;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06024BC1 RID: 150465 RVA: 0x0050BB4C File Offset: 0x00509D4C
		public static Offset<IGrabComponent> Pack(FlatBufferBuilder builder, IGrabComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGrabComponent>);
			}
			Offset<IVectorInfo> grabPosOffset = (_o.GrabPos == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.GrabPos);
			return IGrabComponent.CreateIGrabComponent(builder, _o.Disabled, grabPosOffset, _o.ThrowPow, _o.ThrowHight, _o.NullMask);
		}

		// Token: 0x0400F0D2 RID: 61650
		private Table __p;
	}
}
