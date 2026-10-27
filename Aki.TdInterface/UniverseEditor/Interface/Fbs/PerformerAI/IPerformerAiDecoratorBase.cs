using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.PerformerAI
{
	// Token: 0x02004363 RID: 17251
	public struct IPerformerAiDecoratorBase : IFlatbufferObject
	{
		// Token: 0x170079C2 RID: 31170
		// (get) Token: 0x0601995C RID: 104796 RVA: 0x003A97EE File Offset: 0x003A79EE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601995D RID: 104797 RVA: 0x003A97FB File Offset: 0x003A79FB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601995E RID: 104798 RVA: 0x003A9804 File Offset: 0x003A7A04
		public static IPerformerAiDecoratorBase GetRootAsIPerformerAiDecoratorBase(ByteBuffer _bb)
		{
			return IPerformerAiDecoratorBase.GetRootAsIPerformerAiDecoratorBase(_bb, default(IPerformerAiDecoratorBase));
		}

		// Token: 0x0601995F RID: 104799 RVA: 0x003A9820 File Offset: 0x003A7A20
		public static IPerformerAiDecoratorBase GetRootAsIPerformerAiDecoratorBase(ByteBuffer _bb, IPerformerAiDecoratorBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06019960 RID: 104800 RVA: 0x003A983D File Offset: 0x003A7A3D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06019961 RID: 104801 RVA: 0x003A984C File Offset: 0x003A7A4C
		public IPerformerAiDecoratorBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170079C3 RID: 31171
		// (get) Token: 0x06019962 RID: 104802 RVA: 0x003A985C File Offset: 0x003A7A5C
		public EPerformerAiDecoratorType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EPerformerAiDecoratorType.Condition;
				}
				return (EPerformerAiDecoratorType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06019963 RID: 104803 RVA: 0x003A9898 File Offset: 0x003A7A98
		public static Offset<IPerformerAiDecoratorBase> CreateIPerformerAiDecoratorBase(FlatBufferBuilder builder, EPerformerAiDecoratorType Type = EPerformerAiDecoratorType.Condition)
		{
			builder.StartTable(1);
			IPerformerAiDecoratorBase.AddType(builder, Type);
			return IPerformerAiDecoratorBase.EndIPerformerAiDecoratorBase(builder);
		}

		// Token: 0x06019964 RID: 104804 RVA: 0x003A98AE File Offset: 0x003A7AAE
		public static void StartIPerformerAiDecoratorBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06019965 RID: 104805 RVA: 0x003A98B7 File Offset: 0x003A7AB7
		public static void AddType(FlatBufferBuilder builder, EPerformerAiDecoratorType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06019966 RID: 104806 RVA: 0x003A98C2 File Offset: 0x003A7AC2
		public static Offset<IPerformerAiDecoratorBase> EndIPerformerAiDecoratorBase(FlatBufferBuilder builder)
		{
			return new Offset<IPerformerAiDecoratorBase>(builder.EndTable());
		}

		// Token: 0x06019967 RID: 104807 RVA: 0x003A98D0 File Offset: 0x003A7AD0
		public IPerformerAiDecoratorBaseT UnPack()
		{
			IPerformerAiDecoratorBaseT performerAiDecoratorBaseT = new IPerformerAiDecoratorBaseT();
			this.UnPackTo(performerAiDecoratorBaseT);
			return performerAiDecoratorBaseT;
		}

		// Token: 0x06019968 RID: 104808 RVA: 0x003A98EB File Offset: 0x003A7AEB
		public void UnPackTo(IPerformerAiDecoratorBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06019969 RID: 104809 RVA: 0x003A98FC File Offset: 0x003A7AFC
		public static Offset<IPerformerAiDecoratorBase> Pack(FlatBufferBuilder builder, IPerformerAiDecoratorBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPerformerAiDecoratorBase>);
			}
			return IPerformerAiDecoratorBase.CreateIPerformerAiDecoratorBase(builder, _o.Type);
		}

		// Token: 0x0400C156 RID: 49494
		private Table __p;
	}
}
