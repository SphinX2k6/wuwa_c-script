using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006118 RID: 24856
	public struct IUnUseComponent : IFlatbufferObject
	{
		// Token: 0x1700B90D RID: 47373
		// (get) Token: 0x0602A23A RID: 172602 RVA: 0x005C04E8 File Offset: 0x005BE6E8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602A23B RID: 172603 RVA: 0x005C04F5 File Offset: 0x005BE6F5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602A23C RID: 172604 RVA: 0x005C04FC File Offset: 0x005BE6FC
		public static IUnUseComponent GetRootAsIUnUseComponent(ByteBuffer _bb)
		{
			return IUnUseComponent.GetRootAsIUnUseComponent(_bb, default(IUnUseComponent));
		}

		// Token: 0x0602A23D RID: 172605 RVA: 0x005C0518 File Offset: 0x005BE718
		public static IUnUseComponent GetRootAsIUnUseComponent(ByteBuffer _bb, IUnUseComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602A23E RID: 172606 RVA: 0x005C0535 File Offset: 0x005BE735
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602A23F RID: 172607 RVA: 0x005C0544 File Offset: 0x005BE744
		public IUnUseComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B90E RID: 47374
		// (get) Token: 0x0602A240 RID: 172608 RVA: 0x005C0554 File Offset: 0x005BE754
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B90F RID: 47375
		// (get) Token: 0x0602A241 RID: 172609 RVA: 0x005C0594 File Offset: 0x005BE794
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

		// Token: 0x0602A242 RID: 172610 RVA: 0x005C05D0 File Offset: 0x005BE7D0
		public static Offset<IUnUseComponent> CreateIUnUseComponent(FlatBufferBuilder builder, bool Disabled = false, byte NullMask = 0)
		{
			builder.StartTable(2);
			IUnUseComponent.AddNullMask(builder, NullMask);
			IUnUseComponent.AddDisabled(builder, Disabled);
			return IUnUseComponent.EndIUnUseComponent(builder);
		}

		// Token: 0x0602A243 RID: 172611 RVA: 0x005C05ED File Offset: 0x005BE7ED
		public static void StartIUnUseComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602A244 RID: 172612 RVA: 0x005C05F6 File Offset: 0x005BE7F6
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x0602A245 RID: 172613 RVA: 0x005C0601 File Offset: 0x005BE801
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(1, nullMask, 0);
		}

		// Token: 0x0602A246 RID: 172614 RVA: 0x005C060C File Offset: 0x005BE80C
		public static Offset<IUnUseComponent> EndIUnUseComponent(FlatBufferBuilder builder)
		{
			return new Offset<IUnUseComponent>(builder.EndTable());
		}

		// Token: 0x0602A247 RID: 172615 RVA: 0x005C061C File Offset: 0x005BE81C
		public IUnUseComponentT UnPack()
		{
			IUnUseComponentT unUseComponentT = new IUnUseComponentT();
			this.UnPackTo(unUseComponentT);
			return unUseComponentT;
		}

		// Token: 0x0602A248 RID: 172616 RVA: 0x005C0637 File Offset: 0x005BE837
		public void UnPackTo(IUnUseComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602A249 RID: 172617 RVA: 0x005C0654 File Offset: 0x005BE854
		public static Offset<IUnUseComponent> Pack(FlatBufferBuilder builder, IUnUseComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IUnUseComponent>);
			}
			return IUnUseComponent.CreateIUnUseComponent(builder, _o.Disabled, _o.NullMask);
		}

		// Token: 0x0400FF0B RID: 65291
		private Table __p;
	}
}
