using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020040EB RID: 16619
	public struct IRollBlockLaunchMethodInteract : IFlatbufferObject
	{
		// Token: 0x17007523 RID: 29987
		// (get) Token: 0x0601837F RID: 99199 RVA: 0x0037CC21 File Offset: 0x0037AE21
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06018380 RID: 99200 RVA: 0x0037CC2E File Offset: 0x0037AE2E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06018381 RID: 99201 RVA: 0x0037CC38 File Offset: 0x0037AE38
		public static IRollBlockLaunchMethodInteract GetRootAsIRollBlockLaunchMethodInteract(ByteBuffer _bb)
		{
			return IRollBlockLaunchMethodInteract.GetRootAsIRollBlockLaunchMethodInteract(_bb, default(IRollBlockLaunchMethodInteract));
		}

		// Token: 0x06018382 RID: 99202 RVA: 0x0037CC54 File Offset: 0x0037AE54
		public static IRollBlockLaunchMethodInteract GetRootAsIRollBlockLaunchMethodInteract(ByteBuffer _bb, IRollBlockLaunchMethodInteract obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06018383 RID: 99203 RVA: 0x0037CC71 File Offset: 0x0037AE71
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06018384 RID: 99204 RVA: 0x0037CC80 File Offset: 0x0037AE80
		public IRollBlockLaunchMethodInteract __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007524 RID: 29988
		// (get) Token: 0x06018385 RID: 99205 RVA: 0x0037CC90 File Offset: 0x0037AE90
		public ERollBlockLaunchMethod Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ERollBlockLaunchMethod.Interact;
				}
				return (ERollBlockLaunchMethod)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007525 RID: 29989
		// (get) Token: 0x06018386 RID: 99206 RVA: 0x0037CCCC File Offset: 0x0037AECC
		public int TargetId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06018387 RID: 99207 RVA: 0x0037CD08 File Offset: 0x0037AF08
		public static Offset<IRollBlockLaunchMethodInteract> CreateIRollBlockLaunchMethodInteract(FlatBufferBuilder builder, ERollBlockLaunchMethod Type = ERollBlockLaunchMethod.Interact, int TargetId = 0)
		{
			builder.StartTable(2);
			IRollBlockLaunchMethodInteract.AddTargetId(builder, TargetId);
			IRollBlockLaunchMethodInteract.AddType(builder, Type);
			return IRollBlockLaunchMethodInteract.EndIRollBlockLaunchMethodInteract(builder);
		}

		// Token: 0x06018388 RID: 99208 RVA: 0x0037CD25 File Offset: 0x0037AF25
		public static void StartIRollBlockLaunchMethodInteract(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06018389 RID: 99209 RVA: 0x0037CD2E File Offset: 0x0037AF2E
		public static void AddType(FlatBufferBuilder builder, ERollBlockLaunchMethod type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601838A RID: 99210 RVA: 0x0037CD39 File Offset: 0x0037AF39
		public static void AddTargetId(FlatBufferBuilder builder, int targetId)
		{
			builder.AddInt(1, targetId, 0);
		}

		// Token: 0x0601838B RID: 99211 RVA: 0x0037CD44 File Offset: 0x0037AF44
		public static Offset<IRollBlockLaunchMethodInteract> EndIRollBlockLaunchMethodInteract(FlatBufferBuilder builder)
		{
			return new Offset<IRollBlockLaunchMethodInteract>(builder.EndTable());
		}

		// Token: 0x0601838C RID: 99212 RVA: 0x0037CD54 File Offset: 0x0037AF54
		public IRollBlockLaunchMethodInteractT UnPack()
		{
			IRollBlockLaunchMethodInteractT rollBlockLaunchMethodInteractT = new IRollBlockLaunchMethodInteractT();
			this.UnPackTo(rollBlockLaunchMethodInteractT);
			return rollBlockLaunchMethodInteractT;
		}

		// Token: 0x0601838D RID: 99213 RVA: 0x0037CD6F File Offset: 0x0037AF6F
		public void UnPackTo(IRollBlockLaunchMethodInteractT _o)
		{
			_o.Type = this.Type;
			_o.TargetId = this.TargetId;
		}

		// Token: 0x0601838E RID: 99214 RVA: 0x0037CD8C File Offset: 0x0037AF8C
		public static Offset<IRollBlockLaunchMethodInteract> Pack(FlatBufferBuilder builder, IRollBlockLaunchMethodInteractT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRollBlockLaunchMethodInteract>);
			}
			return IRollBlockLaunchMethodInteract.CreateIRollBlockLaunchMethodInteract(builder, _o.Type, _o.TargetId);
		}

		// Token: 0x0400BC82 RID: 48258
		private Table __p;
	}
}
