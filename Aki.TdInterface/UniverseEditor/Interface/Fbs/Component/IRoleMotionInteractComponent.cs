using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005879 RID: 22649
	public struct IRoleMotionInteractComponent : IFlatbufferObject
	{
		// Token: 0x1700A966 RID: 43366
		// (get) Token: 0x06026298 RID: 156312 RVA: 0x00542FA1 File Offset: 0x005411A1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06026299 RID: 156313 RVA: 0x00542FAE File Offset: 0x005411AE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602629A RID: 156314 RVA: 0x00542FB8 File Offset: 0x005411B8
		public static IRoleMotionInteractComponent GetRootAsIRoleMotionInteractComponent(ByteBuffer _bb)
		{
			return IRoleMotionInteractComponent.GetRootAsIRoleMotionInteractComponent(_bb, default(IRoleMotionInteractComponent));
		}

		// Token: 0x0602629B RID: 156315 RVA: 0x00542FD4 File Offset: 0x005411D4
		public static IRoleMotionInteractComponent GetRootAsIRoleMotionInteractComponent(ByteBuffer _bb, IRoleMotionInteractComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602629C RID: 156316 RVA: 0x00542FF1 File Offset: 0x005411F1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602629D RID: 156317 RVA: 0x00543000 File Offset: 0x00541200
		public IRoleMotionInteractComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A967 RID: 43367
		// (get) Token: 0x0602629E RID: 156318 RVA: 0x00543010 File Offset: 0x00541210
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A968 RID: 43368
		// (get) Token: 0x0602629F RID: 156319 RVA: 0x00543050 File Offset: 0x00541250
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

		// Token: 0x1700A969 RID: 43369
		// (get) Token: 0x060262A0 RID: 156320 RVA: 0x005430B0 File Offset: 0x005412B0
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

		// Token: 0x060262A1 RID: 156321 RVA: 0x005430EC File Offset: 0x005412EC
		public static Offset<IRoleMotionInteractComponent> CreateIRoleMotionInteractComponent(FlatBufferBuilder builder, bool Disabled = false, Offset<IPetalGrabRoleMotionInteract> MotionInteractConfigOffset = default(Offset<IPetalGrabRoleMotionInteract>), byte NullMask = 0)
		{
			builder.StartTable(3);
			IRoleMotionInteractComponent.AddMotionInteractConfig(builder, MotionInteractConfigOffset);
			IRoleMotionInteractComponent.AddNullMask(builder, NullMask);
			IRoleMotionInteractComponent.AddDisabled(builder, Disabled);
			return IRoleMotionInteractComponent.EndIRoleMotionInteractComponent(builder);
		}

		// Token: 0x060262A2 RID: 156322 RVA: 0x00543110 File Offset: 0x00541310
		public static void StartIRoleMotionInteractComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060262A3 RID: 156323 RVA: 0x00543119 File Offset: 0x00541319
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x060262A4 RID: 156324 RVA: 0x00543124 File Offset: 0x00541324
		public static void AddMotionInteractConfig(FlatBufferBuilder builder, Offset<IPetalGrabRoleMotionInteract> motionInteractConfigOffset)
		{
			builder.AddOffset(1, motionInteractConfigOffset.Value, 0);
		}

		// Token: 0x060262A5 RID: 156325 RVA: 0x00543134 File Offset: 0x00541334
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x060262A6 RID: 156326 RVA: 0x0054313F File Offset: 0x0054133F
		public static Offset<IRoleMotionInteractComponent> EndIRoleMotionInteractComponent(FlatBufferBuilder builder)
		{
			return new Offset<IRoleMotionInteractComponent>(builder.EndTable());
		}

		// Token: 0x060262A7 RID: 156327 RVA: 0x0054314C File Offset: 0x0054134C
		public IRoleMotionInteractComponentT UnPack()
		{
			IRoleMotionInteractComponentT roleMotionInteractComponentT = new IRoleMotionInteractComponentT();
			this.UnPackTo(roleMotionInteractComponentT);
			return roleMotionInteractComponentT;
		}

		// Token: 0x060262A8 RID: 156328 RVA: 0x00543168 File Offset: 0x00541368
		public void UnPackTo(IRoleMotionInteractComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.MotionInteractConfig = ((this.MotionInteractConfig != null) ? this.MotionInteractConfig.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060262A9 RID: 156329 RVA: 0x005431BC File Offset: 0x005413BC
		public static Offset<IRoleMotionInteractComponent> Pack(FlatBufferBuilder builder, IRoleMotionInteractComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRoleMotionInteractComponent>);
			}
			Offset<IPetalGrabRoleMotionInteract> motionInteractConfigOffset = (_o.MotionInteractConfig == null) ? default(Offset<IPetalGrabRoleMotionInteract>) : IPetalGrabRoleMotionInteract.Pack(builder, _o.MotionInteractConfig);
			return IRoleMotionInteractComponent.CreateIRoleMotionInteractComponent(builder, _o.Disabled, motionInteractConfigOffset, _o.NullMask);
		}

		// Token: 0x0400EDC1 RID: 60865
		private Table __p;
	}
}
