using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005E6E RID: 24174
	public struct IResetSelfPosComponent : IFlatbufferObject
	{
		// Token: 0x1700B251 RID: 45649
		// (get) Token: 0x060286F6 RID: 165622 RVA: 0x005876D6 File Offset: 0x005858D6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060286F7 RID: 165623 RVA: 0x005876E3 File Offset: 0x005858E3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060286F8 RID: 165624 RVA: 0x005876EC File Offset: 0x005858EC
		public static IResetSelfPosComponent GetRootAsIResetSelfPosComponent(ByteBuffer _bb)
		{
			return IResetSelfPosComponent.GetRootAsIResetSelfPosComponent(_bb, default(IResetSelfPosComponent));
		}

		// Token: 0x060286F9 RID: 165625 RVA: 0x00587708 File Offset: 0x00585908
		public static IResetSelfPosComponent GetRootAsIResetSelfPosComponent(ByteBuffer _bb, IResetSelfPosComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060286FA RID: 165626 RVA: 0x00587725 File Offset: 0x00585925
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060286FB RID: 165627 RVA: 0x00587734 File Offset: 0x00585934
		public IResetSelfPosComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B252 RID: 45650
		// (get) Token: 0x060286FC RID: 165628 RVA: 0x00587744 File Offset: 0x00585944
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B253 RID: 45651
		// (get) Token: 0x060286FD RID: 165629 RVA: 0x00587784 File Offset: 0x00585984
		public float ResetRadius
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

		// Token: 0x1700B254 RID: 45652
		// (get) Token: 0x060286FE RID: 165630 RVA: 0x005877C4 File Offset: 0x005859C4
		public bool IsDisableResetPosAfterThrow
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B255 RID: 45653
		// (get) Token: 0x060286FF RID: 165631 RVA: 0x00587804 File Offset: 0x00585A04
		public bool IsResetPosAfterThrow
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B256 RID: 45654
		// (get) Token: 0x06028700 RID: 165632 RVA: 0x00587844 File Offset: 0x00585A44
		public float ResetPosDelayTime
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B257 RID: 45655
		// (get) Token: 0x06028701 RID: 165633 RVA: 0x00587888 File Offset: 0x00585A88
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

		// Token: 0x06028702 RID: 165634 RVA: 0x005878C5 File Offset: 0x00585AC5
		public static Offset<IResetSelfPosComponent> CreateIResetSelfPosComponent(FlatBufferBuilder builder, bool Disabled = false, float ResetRadius = 0f, bool IsDisableResetPosAfterThrow = false, bool IsResetPosAfterThrow = false, float ResetPosDelayTime = 0f, byte NullMask = 0)
		{
			builder.StartTable(6);
			IResetSelfPosComponent.AddResetPosDelayTime(builder, ResetPosDelayTime);
			IResetSelfPosComponent.AddResetRadius(builder, ResetRadius);
			IResetSelfPosComponent.AddNullMask(builder, NullMask);
			IResetSelfPosComponent.AddIsResetPosAfterThrow(builder, IsResetPosAfterThrow);
			IResetSelfPosComponent.AddIsDisableResetPosAfterThrow(builder, IsDisableResetPosAfterThrow);
			IResetSelfPosComponent.AddDisabled(builder, Disabled);
			return IResetSelfPosComponent.EndIResetSelfPosComponent(builder);
		}

		// Token: 0x06028703 RID: 165635 RVA: 0x00587901 File Offset: 0x00585B01
		public static void StartIResetSelfPosComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x06028704 RID: 165636 RVA: 0x0058790A File Offset: 0x00585B0A
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06028705 RID: 165637 RVA: 0x00587915 File Offset: 0x00585B15
		public static void AddResetRadius(FlatBufferBuilder builder, float resetRadius)
		{
			builder.AddFloat(1, resetRadius, 0.0);
		}

		// Token: 0x06028706 RID: 165638 RVA: 0x00587928 File Offset: 0x00585B28
		public static void AddIsDisableResetPosAfterThrow(FlatBufferBuilder builder, bool isDisableResetPosAfterThrow)
		{
			builder.AddBool(2, isDisableResetPosAfterThrow, false);
		}

		// Token: 0x06028707 RID: 165639 RVA: 0x00587933 File Offset: 0x00585B33
		public static void AddIsResetPosAfterThrow(FlatBufferBuilder builder, bool isResetPosAfterThrow)
		{
			builder.AddBool(3, isResetPosAfterThrow, false);
		}

		// Token: 0x06028708 RID: 165640 RVA: 0x0058793E File Offset: 0x00585B3E
		public static void AddResetPosDelayTime(FlatBufferBuilder builder, float resetPosDelayTime)
		{
			builder.AddFloat(4, resetPosDelayTime, 0.0);
		}

		// Token: 0x06028709 RID: 165641 RVA: 0x00587951 File Offset: 0x00585B51
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x0602870A RID: 165642 RVA: 0x0058795C File Offset: 0x00585B5C
		public static Offset<IResetSelfPosComponent> EndIResetSelfPosComponent(FlatBufferBuilder builder)
		{
			return new Offset<IResetSelfPosComponent>(builder.EndTable());
		}

		// Token: 0x0602870B RID: 165643 RVA: 0x0058796C File Offset: 0x00585B6C
		public IResetSelfPosComponentT UnPack()
		{
			IResetSelfPosComponentT resetSelfPosComponentT = new IResetSelfPosComponentT();
			this.UnPackTo(resetSelfPosComponentT);
			return resetSelfPosComponentT;
		}

		// Token: 0x0602870C RID: 165644 RVA: 0x00587988 File Offset: 0x00585B88
		public void UnPackTo(IResetSelfPosComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.ResetRadius = this.ResetRadius;
			_o.IsDisableResetPosAfterThrow = this.IsDisableResetPosAfterThrow;
			_o.IsResetPosAfterThrow = this.IsResetPosAfterThrow;
			_o.ResetPosDelayTime = this.ResetPosDelayTime;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602870D RID: 165645 RVA: 0x005879E0 File Offset: 0x00585BE0
		public static Offset<IResetSelfPosComponent> Pack(FlatBufferBuilder builder, IResetSelfPosComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IResetSelfPosComponent>);
			}
			return IResetSelfPosComponent.CreateIResetSelfPosComponent(builder, _o.Disabled, _o.ResetRadius, _o.IsDisableResetPosAfterThrow, _o.IsResetPosAfterThrow, _o.ResetPosDelayTime, _o.NullMask);
		}

		// Token: 0x0400FA89 RID: 64137
		private Table __p;
	}
}
