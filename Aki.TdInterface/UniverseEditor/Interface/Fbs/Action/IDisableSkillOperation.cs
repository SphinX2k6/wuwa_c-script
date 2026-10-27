using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020065F4 RID: 26100
	public struct IDisableSkillOperation : IFlatbufferObject
	{
		// Token: 0x1700C1EA RID: 49642
		// (get) Token: 0x0602D4E5 RID: 185573 RVA: 0x00635A43 File Offset: 0x00633C43
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602D4E6 RID: 185574 RVA: 0x00635A50 File Offset: 0x00633C50
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602D4E7 RID: 185575 RVA: 0x00635A58 File Offset: 0x00633C58
		public static IDisableSkillOperation GetRootAsIDisableSkillOperation(ByteBuffer _bb)
		{
			return IDisableSkillOperation.GetRootAsIDisableSkillOperation(_bb, default(IDisableSkillOperation));
		}

		// Token: 0x0602D4E8 RID: 185576 RVA: 0x00635A74 File Offset: 0x00633C74
		public static IDisableSkillOperation GetRootAsIDisableSkillOperation(ByteBuffer _bb, IDisableSkillOperation obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602D4E9 RID: 185577 RVA: 0x00635A91 File Offset: 0x00633C91
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602D4EA RID: 185578 RVA: 0x00635AA0 File Offset: 0x00633CA0
		public IDisableSkillOperation __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C1EB RID: 49643
		// (get) Token: 0x0602D4EB RID: 185579 RVA: 0x00635AB0 File Offset: 0x00633CB0
		public ESkillOperationType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESkillOperationType.Enable;
				}
				return (ESkillOperationType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C1EC RID: 49644
		// (get) Token: 0x0602D4EC RID: 185580 RVA: 0x00635AEC File Offset: 0x00633CEC
		public EDisplayModeInSkillOp DisplayMode
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return EDisplayModeInSkillOp.Ashen;
				}
				return (EDisplayModeInSkillOp)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C1ED RID: 49645
		// (get) Token: 0x0602D4ED RID: 185581 RVA: 0x00635B28 File Offset: 0x00633D28
		public bool DisableSkillWheel
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C1EE RID: 49646
		// (get) Token: 0x0602D4EE RID: 185582 RVA: 0x00635B68 File Offset: 0x00633D68
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

		// Token: 0x0602D4EF RID: 185583 RVA: 0x00635BA5 File Offset: 0x00633DA5
		public static Offset<IDisableSkillOperation> CreateIDisableSkillOperation(FlatBufferBuilder builder, ESkillOperationType Type = ESkillOperationType.Enable, EDisplayModeInSkillOp DisplayMode = EDisplayModeInSkillOp.Ashen, bool DisableSkillWheel = false, byte NullMask = 0)
		{
			builder.StartTable(4);
			IDisableSkillOperation.AddNullMask(builder, NullMask);
			IDisableSkillOperation.AddDisableSkillWheel(builder, DisableSkillWheel);
			IDisableSkillOperation.AddDisplayMode(builder, DisplayMode);
			IDisableSkillOperation.AddType(builder, Type);
			return IDisableSkillOperation.EndIDisableSkillOperation(builder);
		}

		// Token: 0x0602D4F0 RID: 185584 RVA: 0x00635BD1 File Offset: 0x00633DD1
		public static void StartIDisableSkillOperation(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0602D4F1 RID: 185585 RVA: 0x00635BDA File Offset: 0x00633DDA
		public static void AddType(FlatBufferBuilder builder, ESkillOperationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602D4F2 RID: 185586 RVA: 0x00635BE5 File Offset: 0x00633DE5
		public static void AddDisplayMode(FlatBufferBuilder builder, EDisplayModeInSkillOp displayMode)
		{
			builder.AddByte(1, (byte)displayMode, 0);
		}

		// Token: 0x0602D4F3 RID: 185587 RVA: 0x00635BF0 File Offset: 0x00633DF0
		public static void AddDisableSkillWheel(FlatBufferBuilder builder, bool disableSkillWheel)
		{
			builder.AddBool(2, disableSkillWheel, false);
		}

		// Token: 0x0602D4F4 RID: 185588 RVA: 0x00635BFB File Offset: 0x00633DFB
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x0602D4F5 RID: 185589 RVA: 0x00635C06 File Offset: 0x00633E06
		public static Offset<IDisableSkillOperation> EndIDisableSkillOperation(FlatBufferBuilder builder)
		{
			return new Offset<IDisableSkillOperation>(builder.EndTable());
		}

		// Token: 0x0602D4F6 RID: 185590 RVA: 0x00635C14 File Offset: 0x00633E14
		public IDisableSkillOperationT UnPack()
		{
			IDisableSkillOperationT disableSkillOperationT = new IDisableSkillOperationT();
			this.UnPackTo(disableSkillOperationT);
			return disableSkillOperationT;
		}

		// Token: 0x0602D4F7 RID: 185591 RVA: 0x00635C2F File Offset: 0x00633E2F
		public void UnPackTo(IDisableSkillOperationT _o)
		{
			_o.Type = this.Type;
			_o.DisplayMode = this.DisplayMode;
			_o.DisableSkillWheel = this.DisableSkillWheel;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602D4F8 RID: 185592 RVA: 0x00635C64 File Offset: 0x00633E64
		public static Offset<IDisableSkillOperation> Pack(FlatBufferBuilder builder, IDisableSkillOperationT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDisableSkillOperation>);
			}
			return IDisableSkillOperation.CreateIDisableSkillOperation(builder, _o.Type, _o.DisplayMode, _o.DisableSkillWheel, _o.NullMask);
		}

		// Token: 0x04010C76 RID: 68726
		private Table __p;
	}
}
