using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006871 RID: 26737
	public struct IBehaviorTreeFragmentContext : IFlatbufferObject
	{
		// Token: 0x1700C48C RID: 50316
		// (get) Token: 0x0602DB50 RID: 187216 RVA: 0x006401EC File Offset: 0x0063E3EC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602DB51 RID: 187217 RVA: 0x006401F9 File Offset: 0x0063E3F9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602DB52 RID: 187218 RVA: 0x00640200 File Offset: 0x0063E400
		public static IBehaviorTreeFragmentContext GetRootAsIBehaviorTreeFragmentContext(ByteBuffer _bb)
		{
			return IBehaviorTreeFragmentContext.GetRootAsIBehaviorTreeFragmentContext(_bb, default(IBehaviorTreeFragmentContext));
		}

		// Token: 0x0602DB53 RID: 187219 RVA: 0x0064021C File Offset: 0x0063E41C
		public static IBehaviorTreeFragmentContext GetRootAsIBehaviorTreeFragmentContext(ByteBuffer _bb, IBehaviorTreeFragmentContext obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602DB54 RID: 187220 RVA: 0x00640239 File Offset: 0x0063E439
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602DB55 RID: 187221 RVA: 0x00640248 File Offset: 0x0063E448
		public IBehaviorTreeFragmentContext __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C48D RID: 50317
		// (get) Token: 0x0602DB56 RID: 187222 RVA: 0x00640258 File Offset: 0x0063E458
		public EVarContext Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EVarContext.None;
				}
				return (EVarContext)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C48E RID: 50318
		// (get) Token: 0x0602DB57 RID: 187223 RVA: 0x00640294 File Offset: 0x0063E494
		public int Id
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

		// Token: 0x0602DB58 RID: 187224 RVA: 0x006402D0 File Offset: 0x0063E4D0
		public static Offset<IBehaviorTreeFragmentContext> CreateIBehaviorTreeFragmentContext(FlatBufferBuilder builder, EVarContext Type = EVarContext.None, int Id = 0)
		{
			builder.StartTable(2);
			IBehaviorTreeFragmentContext.AddId(builder, Id);
			IBehaviorTreeFragmentContext.AddType(builder, Type);
			return IBehaviorTreeFragmentContext.EndIBehaviorTreeFragmentContext(builder);
		}

		// Token: 0x0602DB59 RID: 187225 RVA: 0x006402ED File Offset: 0x0063E4ED
		public static void StartIBehaviorTreeFragmentContext(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602DB5A RID: 187226 RVA: 0x006402F6 File Offset: 0x0063E4F6
		public static void AddType(FlatBufferBuilder builder, EVarContext type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602DB5B RID: 187227 RVA: 0x00640301 File Offset: 0x0063E501
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x0602DB5C RID: 187228 RVA: 0x0064030C File Offset: 0x0063E50C
		public static Offset<IBehaviorTreeFragmentContext> EndIBehaviorTreeFragmentContext(FlatBufferBuilder builder)
		{
			return new Offset<IBehaviorTreeFragmentContext>(builder.EndTable());
		}

		// Token: 0x0602DB5D RID: 187229 RVA: 0x0064031C File Offset: 0x0063E51C
		public IBehaviorTreeFragmentContextT UnPack()
		{
			IBehaviorTreeFragmentContextT behaviorTreeFragmentContextT = new IBehaviorTreeFragmentContextT();
			this.UnPackTo(behaviorTreeFragmentContextT);
			return behaviorTreeFragmentContextT;
		}

		// Token: 0x0602DB5E RID: 187230 RVA: 0x00640337 File Offset: 0x0063E537
		public void UnPackTo(IBehaviorTreeFragmentContextT _o)
		{
			_o.Type = this.Type;
			_o.Id = this.Id;
		}

		// Token: 0x0602DB5F RID: 187231 RVA: 0x00640354 File Offset: 0x0063E554
		public static Offset<IBehaviorTreeFragmentContext> Pack(FlatBufferBuilder builder, IBehaviorTreeFragmentContextT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBehaviorTreeFragmentContext>);
			}
			return IBehaviorTreeFragmentContext.CreateIBehaviorTreeFragmentContext(builder, _o.Type, _o.Id);
		}

		// Token: 0x0401154E RID: 70990
		private Table __p;
	}
}
