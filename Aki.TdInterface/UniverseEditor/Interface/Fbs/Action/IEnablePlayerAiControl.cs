using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006CEF RID: 27887
	public struct IEnablePlayerAiControl : IFlatbufferObject
	{
		// Token: 0x1700CC83 RID: 52355
		// (get) Token: 0x0603012A RID: 196906 RVA: 0x0068A34C File Offset: 0x0068854C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603012B RID: 196907 RVA: 0x0068A359 File Offset: 0x00688559
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603012C RID: 196908 RVA: 0x0068A360 File Offset: 0x00688560
		public static IEnablePlayerAiControl GetRootAsIEnablePlayerAiControl(ByteBuffer _bb)
		{
			return IEnablePlayerAiControl.GetRootAsIEnablePlayerAiControl(_bb, default(IEnablePlayerAiControl));
		}

		// Token: 0x0603012D RID: 196909 RVA: 0x0068A37C File Offset: 0x0068857C
		public static IEnablePlayerAiControl GetRootAsIEnablePlayerAiControl(ByteBuffer _bb, IEnablePlayerAiControl obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603012E RID: 196910 RVA: 0x0068A399 File Offset: 0x00688599
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603012F RID: 196911 RVA: 0x0068A3A8 File Offset: 0x006885A8
		public IEnablePlayerAiControl __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CC84 RID: 52356
		// (get) Token: 0x06030130 RID: 196912 RVA: 0x0068A3B8 File Offset: 0x006885B8
		public EPlayerAiControlType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EPlayerAiControlType.Enable;
				}
				return (EPlayerAiControlType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700CC85 RID: 52357
		// (get) Token: 0x06030131 RID: 196913 RVA: 0x0068A3F4 File Offset: 0x006885F4
		public int BehaviorTree
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

		// Token: 0x06030132 RID: 196914 RVA: 0x0068A430 File Offset: 0x00688630
		public static Offset<IEnablePlayerAiControl> CreateIEnablePlayerAiControl(FlatBufferBuilder builder, EPlayerAiControlType Type = EPlayerAiControlType.Enable, int BehaviorTree = 0)
		{
			builder.StartTable(2);
			IEnablePlayerAiControl.AddBehaviorTree(builder, BehaviorTree);
			IEnablePlayerAiControl.AddType(builder, Type);
			return IEnablePlayerAiControl.EndIEnablePlayerAiControl(builder);
		}

		// Token: 0x06030133 RID: 196915 RVA: 0x0068A44D File Offset: 0x0068864D
		public static void StartIEnablePlayerAiControl(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06030134 RID: 196916 RVA: 0x0068A456 File Offset: 0x00688656
		public static void AddType(FlatBufferBuilder builder, EPlayerAiControlType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06030135 RID: 196917 RVA: 0x0068A461 File Offset: 0x00688661
		public static void AddBehaviorTree(FlatBufferBuilder builder, int behaviorTree)
		{
			builder.AddInt(1, behaviorTree, 0);
		}

		// Token: 0x06030136 RID: 196918 RVA: 0x0068A46C File Offset: 0x0068866C
		public static Offset<IEnablePlayerAiControl> EndIEnablePlayerAiControl(FlatBufferBuilder builder)
		{
			return new Offset<IEnablePlayerAiControl>(builder.EndTable());
		}

		// Token: 0x06030137 RID: 196919 RVA: 0x0068A47C File Offset: 0x0068867C
		public IEnablePlayerAiControlT UnPack()
		{
			IEnablePlayerAiControlT enablePlayerAiControlT = new IEnablePlayerAiControlT();
			this.UnPackTo(enablePlayerAiControlT);
			return enablePlayerAiControlT;
		}

		// Token: 0x06030138 RID: 196920 RVA: 0x0068A497 File Offset: 0x00688697
		public void UnPackTo(IEnablePlayerAiControlT _o)
		{
			_o.Type = this.Type;
			_o.BehaviorTree = this.BehaviorTree;
		}

		// Token: 0x06030139 RID: 196921 RVA: 0x0068A4B4 File Offset: 0x006886B4
		public static Offset<IEnablePlayerAiControl> Pack(FlatBufferBuilder builder, IEnablePlayerAiControlT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEnablePlayerAiControl>);
			}
			return IEnablePlayerAiControl.CreateIEnablePlayerAiControl(builder, _o.Type, _o.BehaviorTree);
		}

		// Token: 0x04011B40 RID: 72512
		private Table __p;
	}
}
