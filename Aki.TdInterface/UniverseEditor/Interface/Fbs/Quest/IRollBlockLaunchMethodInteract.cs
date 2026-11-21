using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200452C RID: 17708
	public struct IRollBlockLaunchMethodInteract : IFlatbufferObject
	{
		// Token: 0x17007B29 RID: 31529
		// (get) Token: 0x06019A20 RID: 104992 RVA: 0x003A6B71 File Offset: 0x003A4D71
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06019A21 RID: 104993 RVA: 0x003A6B7E File Offset: 0x003A4D7E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06019A22 RID: 104994 RVA: 0x003A6B88 File Offset: 0x003A4D88
		public static IRollBlockLaunchMethodInteract GetRootAsIRollBlockLaunchMethodInteract(ByteBuffer _bb)
		{
			return IRollBlockLaunchMethodInteract.GetRootAsIRollBlockLaunchMethodInteract(_bb, default(IRollBlockLaunchMethodInteract));
		}

		// Token: 0x06019A23 RID: 104995 RVA: 0x003A6BA4 File Offset: 0x003A4DA4
		public static IRollBlockLaunchMethodInteract GetRootAsIRollBlockLaunchMethodInteract(ByteBuffer _bb, IRollBlockLaunchMethodInteract obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06019A24 RID: 104996 RVA: 0x003A6BC1 File Offset: 0x003A4DC1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06019A25 RID: 104997 RVA: 0x003A6BD0 File Offset: 0x003A4DD0
		public IRollBlockLaunchMethodInteract __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007B2A RID: 31530
		// (get) Token: 0x06019A26 RID: 104998 RVA: 0x003A6BE0 File Offset: 0x003A4DE0
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

		// Token: 0x17007B2B RID: 31531
		// (get) Token: 0x06019A27 RID: 104999 RVA: 0x003A6C1C File Offset: 0x003A4E1C
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

		// Token: 0x06019A28 RID: 105000 RVA: 0x003A6C58 File Offset: 0x003A4E58
		public static Offset<IRollBlockLaunchMethodInteract> CreateIRollBlockLaunchMethodInteract(FlatBufferBuilder builder, ERollBlockLaunchMethod Type = ERollBlockLaunchMethod.Interact, int TargetId = 0)
		{
			builder.StartTable(2);
			IRollBlockLaunchMethodInteract.AddTargetId(builder, TargetId);
			IRollBlockLaunchMethodInteract.AddType(builder, Type);
			return IRollBlockLaunchMethodInteract.EndIRollBlockLaunchMethodInteract(builder);
		}

		// Token: 0x06019A29 RID: 105001 RVA: 0x003A6C75 File Offset: 0x003A4E75
		public static void StartIRollBlockLaunchMethodInteract(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06019A2A RID: 105002 RVA: 0x003A6C7E File Offset: 0x003A4E7E
		public static void AddType(FlatBufferBuilder builder, ERollBlockLaunchMethod type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06019A2B RID: 105003 RVA: 0x003A6C89 File Offset: 0x003A4E89
		public static void AddTargetId(FlatBufferBuilder builder, int targetId)
		{
			builder.AddInt(1, targetId, 0);
		}

		// Token: 0x06019A2C RID: 105004 RVA: 0x003A6C94 File Offset: 0x003A4E94
		public static Offset<IRollBlockLaunchMethodInteract> EndIRollBlockLaunchMethodInteract(FlatBufferBuilder builder)
		{
			return new Offset<IRollBlockLaunchMethodInteract>(builder.EndTable());
		}

		// Token: 0x06019A2D RID: 105005 RVA: 0x003A6CA4 File Offset: 0x003A4EA4
		public IRollBlockLaunchMethodInteractT UnPack()
		{
			IRollBlockLaunchMethodInteractT rollBlockLaunchMethodInteractT = new IRollBlockLaunchMethodInteractT();
			this.UnPackTo(rollBlockLaunchMethodInteractT);
			return rollBlockLaunchMethodInteractT;
		}

		// Token: 0x06019A2E RID: 105006 RVA: 0x003A6CBF File Offset: 0x003A4EBF
		public void UnPackTo(IRollBlockLaunchMethodInteractT _o)
		{
			_o.Type = this.Type;
			_o.TargetId = this.TargetId;
		}

		// Token: 0x06019A2F RID: 105007 RVA: 0x003A6CDC File Offset: 0x003A4EDC
		public static Offset<IRollBlockLaunchMethodInteract> Pack(FlatBufferBuilder builder, IRollBlockLaunchMethodInteractT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRollBlockLaunchMethodInteract>);
			}
			return IRollBlockLaunchMethodInteract.CreateIRollBlockLaunchMethodInteract(builder, _o.Type, _o.TargetId);
		}

		// Token: 0x0400C66B RID: 50795
		private Table __p;
	}
}
