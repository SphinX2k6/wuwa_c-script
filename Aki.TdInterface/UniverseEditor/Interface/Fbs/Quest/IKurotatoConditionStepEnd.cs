using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200431C RID: 17180
	public struct IKurotatoConditionStepEnd : IFlatbufferObject
	{
		// Token: 0x170075A1 RID: 30113
		// (get) Token: 0x06018296 RID: 98966 RVA: 0x00372315 File Offset: 0x00370515
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06018297 RID: 98967 RVA: 0x00372322 File Offset: 0x00370522
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06018298 RID: 98968 RVA: 0x0037232C File Offset: 0x0037052C
		public static IKurotatoConditionStepEnd GetRootAsIKurotatoConditionStepEnd(ByteBuffer _bb)
		{
			return IKurotatoConditionStepEnd.GetRootAsIKurotatoConditionStepEnd(_bb, default(IKurotatoConditionStepEnd));
		}

		// Token: 0x06018299 RID: 98969 RVA: 0x00372348 File Offset: 0x00370548
		public static IKurotatoConditionStepEnd GetRootAsIKurotatoConditionStepEnd(ByteBuffer _bb, IKurotatoConditionStepEnd obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601829A RID: 98970 RVA: 0x00372365 File Offset: 0x00370565
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601829B RID: 98971 RVA: 0x00372374 File Offset: 0x00370574
		public IKurotatoConditionStepEnd __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170075A2 RID: 30114
		// (get) Token: 0x0601829C RID: 98972 RVA: 0x00372384 File Offset: 0x00370584
		public EKurotatoConditionStep Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EKurotatoConditionStep.Prepare;
				}
				return (EKurotatoConditionStep)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601829D RID: 98973 RVA: 0x003723C0 File Offset: 0x003705C0
		public static Offset<IKurotatoConditionStepEnd> CreateIKurotatoConditionStepEnd(FlatBufferBuilder builder, EKurotatoConditionStep Type = EKurotatoConditionStep.Prepare)
		{
			builder.StartTable(1);
			IKurotatoConditionStepEnd.AddType(builder, Type);
			return IKurotatoConditionStepEnd.EndIKurotatoConditionStepEnd(builder);
		}

		// Token: 0x0601829E RID: 98974 RVA: 0x003723D6 File Offset: 0x003705D6
		public static void StartIKurotatoConditionStepEnd(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601829F RID: 98975 RVA: 0x003723DF File Offset: 0x003705DF
		public static void AddType(FlatBufferBuilder builder, EKurotatoConditionStep type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060182A0 RID: 98976 RVA: 0x003723EA File Offset: 0x003705EA
		public static Offset<IKurotatoConditionStepEnd> EndIKurotatoConditionStepEnd(FlatBufferBuilder builder)
		{
			return new Offset<IKurotatoConditionStepEnd>(builder.EndTable());
		}

		// Token: 0x060182A1 RID: 98977 RVA: 0x003723F8 File Offset: 0x003705F8
		public IKurotatoConditionStepEndT UnPack()
		{
			IKurotatoConditionStepEndT kurotatoConditionStepEndT = new IKurotatoConditionStepEndT();
			this.UnPackTo(kurotatoConditionStepEndT);
			return kurotatoConditionStepEndT;
		}

		// Token: 0x060182A2 RID: 98978 RVA: 0x00372413 File Offset: 0x00370613
		public void UnPackTo(IKurotatoConditionStepEndT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060182A3 RID: 98979 RVA: 0x00372424 File Offset: 0x00370624
		public static Offset<IKurotatoConditionStepEnd> Pack(FlatBufferBuilder builder, IKurotatoConditionStepEndT _o)
		{
			if (_o == null)
			{
				return default(Offset<IKurotatoConditionStepEnd>);
			}
			return IKurotatoConditionStepEnd.CreateIKurotatoConditionStepEnd(builder, _o.Type);
		}

		// Token: 0x0400C29E RID: 49822
		private Table __p;
	}
}
