using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005E86 RID: 24198
	public struct IRoleMotionInteractComponent : IFlatbufferObject
	{
		// Token: 0x1700B296 RID: 45718
		// (get) Token: 0x060287FA RID: 165882 RVA: 0x00589AED File Offset: 0x00587CED
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060287FB RID: 165883 RVA: 0x00589AFA File Offset: 0x00587CFA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060287FC RID: 165884 RVA: 0x00589B04 File Offset: 0x00587D04
		public static IRoleMotionInteractComponent GetRootAsIRoleMotionInteractComponent(ByteBuffer _bb)
		{
			return IRoleMotionInteractComponent.GetRootAsIRoleMotionInteractComponent(_bb, default(IRoleMotionInteractComponent));
		}

		// Token: 0x060287FD RID: 165885 RVA: 0x00589B20 File Offset: 0x00587D20
		public static IRoleMotionInteractComponent GetRootAsIRoleMotionInteractComponent(ByteBuffer _bb, IRoleMotionInteractComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060287FE RID: 165886 RVA: 0x00589B3D File Offset: 0x00587D3D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060287FF RID: 165887 RVA: 0x00589B4C File Offset: 0x00587D4C
		public IRoleMotionInteractComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B297 RID: 45719
		// (get) Token: 0x06028800 RID: 165888 RVA: 0x00589B5C File Offset: 0x00587D5C
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B298 RID: 45720
		// (get) Token: 0x06028801 RID: 165889 RVA: 0x00589B9C File Offset: 0x00587D9C
		public IPetalGrabRoleMotionInteract? MotionInteractConfig
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IPetalGrabRoleMotionInteract?(default(IPetalGrabRoleMotionInteract).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700B299 RID: 45721
		// (get) Token: 0x06028802 RID: 165890 RVA: 0x00589BFC File Offset: 0x00587DFC
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

		// Token: 0x06028803 RID: 165891 RVA: 0x00589C38 File Offset: 0x00587E38
		public static Offset<IRoleMotionInteractComponent> CreateIRoleMotionInteractComponent(FlatBufferBuilder builder, bool Disabled = false, Offset<IPetalGrabRoleMotionInteract> MotionInteractConfigOffset = default(Offset<IPetalGrabRoleMotionInteract>), byte NullMask = 0)
		{
			builder.StartTable(3);
			IRoleMotionInteractComponent.AddMotionInteractConfig(builder, MotionInteractConfigOffset);
			IRoleMotionInteractComponent.AddNullMask(builder, NullMask);
			IRoleMotionInteractComponent.AddDisabled(builder, Disabled);
			return IRoleMotionInteractComponent.EndIRoleMotionInteractComponent(builder);
		}

		// Token: 0x06028804 RID: 165892 RVA: 0x00589C5C File Offset: 0x00587E5C
		public static void StartIRoleMotionInteractComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06028805 RID: 165893 RVA: 0x00589C65 File Offset: 0x00587E65
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06028806 RID: 165894 RVA: 0x00589C70 File Offset: 0x00587E70
		public static void AddMotionInteractConfig(FlatBufferBuilder builder, Offset<IPetalGrabRoleMotionInteract> motionInteractConfigOffset)
		{
			builder.AddOffset(1, motionInteractConfigOffset.Value, 0);
		}

		// Token: 0x06028807 RID: 165895 RVA: 0x00589C80 File Offset: 0x00587E80
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x06028808 RID: 165896 RVA: 0x00589C8B File Offset: 0x00587E8B
		public static Offset<IRoleMotionInteractComponent> EndIRoleMotionInteractComponent(FlatBufferBuilder builder)
		{
			return new Offset<IRoleMotionInteractComponent>(builder.EndTable());
		}

		// Token: 0x06028809 RID: 165897 RVA: 0x00589C98 File Offset: 0x00587E98
		public IRoleMotionInteractComponentT UnPack()
		{
			IRoleMotionInteractComponentT roleMotionInteractComponentT = new IRoleMotionInteractComponentT();
			this.UnPackTo(roleMotionInteractComponentT);
			return roleMotionInteractComponentT;
		}

		// Token: 0x0602880A RID: 165898 RVA: 0x00589CB4 File Offset: 0x00587EB4
		public void UnPackTo(IRoleMotionInteractComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.MotionInteractConfig = ((this.MotionInteractConfig != null) ? this.MotionInteractConfig.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602880B RID: 165899 RVA: 0x00589D08 File Offset: 0x00587F08
		public static Offset<IRoleMotionInteractComponent> Pack(FlatBufferBuilder builder, IRoleMotionInteractComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRoleMotionInteractComponent>);
			}
			Offset<IPetalGrabRoleMotionInteract> motionInteractConfigOffset = (_o.MotionInteractConfig == null) ? default(Offset<IPetalGrabRoleMotionInteract>) : IPetalGrabRoleMotionInteract.Pack(builder, _o.MotionInteractConfig);
			return IRoleMotionInteractComponent.CreateIRoleMotionInteractComponent(builder, _o.Disabled, motionInteractConfigOffset, _o.NullMask);
		}

		// Token: 0x0400FAB4 RID: 64180
		private Table __p;
	}
}
