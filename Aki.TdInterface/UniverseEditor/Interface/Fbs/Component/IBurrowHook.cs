using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004F43 RID: 20291
	public struct IBurrowHook : IFlatbufferObject
	{
		// Token: 0x1700923D RID: 37437
		// (get) Token: 0x06020205 RID: 131589 RVA: 0x00478475 File Offset: 0x00476675
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06020206 RID: 131590 RVA: 0x00478482 File Offset: 0x00476682
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06020207 RID: 131591 RVA: 0x0047848C File Offset: 0x0047668C
		public static IBurrowHook GetRootAsIBurrowHook(ByteBuffer _bb)
		{
			return IBurrowHook.GetRootAsIBurrowHook(_bb, default(IBurrowHook));
		}

		// Token: 0x06020208 RID: 131592 RVA: 0x004784A8 File Offset: 0x004766A8
		public static IBurrowHook GetRootAsIBurrowHook(ByteBuffer _bb, IBurrowHook obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06020209 RID: 131593 RVA: 0x004784C5 File Offset: 0x004766C5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602020A RID: 131594 RVA: 0x004784D4 File Offset: 0x004766D4
		public IBurrowHook __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700923E RID: 37438
		// (get) Token: 0x0602020B RID: 131595 RVA: 0x004784E4 File Offset: 0x004766E4
		public EMechHookConfigType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EMechHookConfigType.BurrowHook;
				}
				return (EMechHookConfigType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700923F RID: 37439
		// (get) Token: 0x0602020C RID: 131596 RVA: 0x00478520 File Offset: 0x00476720
		public IVectorInfo? TargetPos
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

		// Token: 0x17009240 RID: 37440
		// (get) Token: 0x0602020D RID: 131597 RVA: 0x00478580 File Offset: 0x00476780
		public bool CanInterrupt
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17009241 RID: 37441
		// (get) Token: 0x0602020E RID: 131598 RVA: 0x004785C0 File Offset: 0x004767C0
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602020F RID: 131599 RVA: 0x004785FD File Offset: 0x004767FD
		public static Offset<IBurrowHook> CreateIBurrowHook(FlatBufferBuilder builder, EMechHookConfigType Type = EMechHookConfigType.BurrowHook, Offset<IVectorInfo> TargetPosOffset = default(Offset<IVectorInfo>), bool CanInterrupt = false, byte NullMask = 0)
		{
			builder.StartTable(4);
			IBurrowHook.AddTargetPos(builder, TargetPosOffset);
			IBurrowHook.AddNullMask(builder, NullMask);
			IBurrowHook.AddCanInterrupt(builder, CanInterrupt);
			IBurrowHook.AddType(builder, Type);
			return IBurrowHook.EndIBurrowHook(builder);
		}

		// Token: 0x06020210 RID: 131600 RVA: 0x00478629 File Offset: 0x00476829
		public static void StartIBurrowHook(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06020211 RID: 131601 RVA: 0x00478632 File Offset: 0x00476832
		public static void AddType(FlatBufferBuilder builder, EMechHookConfigType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06020212 RID: 131602 RVA: 0x0047863D File Offset: 0x0047683D
		public static void AddTargetPos(FlatBufferBuilder builder, Offset<IVectorInfo> targetPosOffset)
		{
			builder.AddOffset(1, targetPosOffset.Value, 0);
		}

		// Token: 0x06020213 RID: 131603 RVA: 0x0047864D File Offset: 0x0047684D
		public static void AddCanInterrupt(FlatBufferBuilder builder, bool canInterrupt)
		{
			builder.AddBool(2, canInterrupt, false);
		}

		// Token: 0x06020214 RID: 131604 RVA: 0x00478658 File Offset: 0x00476858
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06020215 RID: 131605 RVA: 0x00478663 File Offset: 0x00476863
		public static Offset<IBurrowHook> EndIBurrowHook(FlatBufferBuilder builder)
		{
			return new Offset<IBurrowHook>(builder.EndTable());
		}

		// Token: 0x06020216 RID: 131606 RVA: 0x00478670 File Offset: 0x00476870
		public IBurrowHookT UnPack()
		{
			IBurrowHookT burrowHookT = new IBurrowHookT();
			this.UnPackTo(burrowHookT);
			return burrowHookT;
		}

		// Token: 0x06020217 RID: 131607 RVA: 0x0047868C File Offset: 0x0047688C
		public void UnPackTo(IBurrowHookT _o)
		{
			_o.Type = this.Type;
			_o.TargetPos = ((this.TargetPos != null) ? this.TargetPos.Value.UnPack() : null);
			_o.CanInterrupt = this.CanInterrupt;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06020218 RID: 131608 RVA: 0x004786EC File Offset: 0x004768EC
		public static Offset<IBurrowHook> Pack(FlatBufferBuilder builder, IBurrowHookT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBurrowHook>);
			}
			Offset<IVectorInfo> targetPosOffset = (_o.TargetPos == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.TargetPos);
			return IBurrowHook.CreateIBurrowHook(builder, _o.Type, targetPosOffset, _o.CanInterrupt, _o.NullMask);
		}

		// Token: 0x0400DDB1 RID: 56753
		private Table __p;
	}
}
