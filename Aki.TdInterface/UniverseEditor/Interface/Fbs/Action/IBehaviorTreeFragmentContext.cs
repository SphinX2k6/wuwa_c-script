using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006200 RID: 25088
	public struct IBehaviorTreeFragmentContext : IFlatbufferObject
	{
		// Token: 0x1700BB06 RID: 47878
		// (get) Token: 0x0602B3F7 RID: 177143 RVA: 0x005F5600 File Offset: 0x005F3800
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602B3F8 RID: 177144 RVA: 0x005F560D File Offset: 0x005F380D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602B3F9 RID: 177145 RVA: 0x005F5614 File Offset: 0x005F3814
		public static IBehaviorTreeFragmentContext GetRootAsIBehaviorTreeFragmentContext(ByteBuffer _bb)
		{
			return IBehaviorTreeFragmentContext.GetRootAsIBehaviorTreeFragmentContext(_bb, default(IBehaviorTreeFragmentContext));
		}

		// Token: 0x0602B3FA RID: 177146 RVA: 0x005F5630 File Offset: 0x005F3830
		public static IBehaviorTreeFragmentContext GetRootAsIBehaviorTreeFragmentContext(ByteBuffer _bb, IBehaviorTreeFragmentContext obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602B3FB RID: 177147 RVA: 0x005F564D File Offset: 0x005F384D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602B3FC RID: 177148 RVA: 0x005F565C File Offset: 0x005F385C
		public IBehaviorTreeFragmentContext __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BB07 RID: 47879
		// (get) Token: 0x0602B3FD RID: 177149 RVA: 0x005F566C File Offset: 0x005F386C
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

		// Token: 0x1700BB08 RID: 47880
		// (get) Token: 0x0602B3FE RID: 177150 RVA: 0x005F56A8 File Offset: 0x005F38A8
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

		// Token: 0x0602B3FF RID: 177151 RVA: 0x005F56E4 File Offset: 0x005F38E4
		public static Offset<IBehaviorTreeFragmentContext> CreateIBehaviorTreeFragmentContext(FlatBufferBuilder builder, EVarContext Type = EVarContext.None, int Id = 0)
		{
			builder.StartTable(2);
			IBehaviorTreeFragmentContext.AddId(builder, Id);
			IBehaviorTreeFragmentContext.AddType(builder, Type);
			return IBehaviorTreeFragmentContext.EndIBehaviorTreeFragmentContext(builder);
		}

		// Token: 0x0602B400 RID: 177152 RVA: 0x005F5701 File Offset: 0x005F3901
		public static void StartIBehaviorTreeFragmentContext(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602B401 RID: 177153 RVA: 0x005F570A File Offset: 0x005F390A
		public static void AddType(FlatBufferBuilder builder, EVarContext type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602B402 RID: 177154 RVA: 0x005F5715 File Offset: 0x005F3915
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x0602B403 RID: 177155 RVA: 0x005F5720 File Offset: 0x005F3920
		public static Offset<IBehaviorTreeFragmentContext> EndIBehaviorTreeFragmentContext(FlatBufferBuilder builder)
		{
			return new Offset<IBehaviorTreeFragmentContext>(builder.EndTable());
		}

		// Token: 0x0602B404 RID: 177156 RVA: 0x005F5730 File Offset: 0x005F3930
		public IBehaviorTreeFragmentContextT UnPack()
		{
			IBehaviorTreeFragmentContextT behaviorTreeFragmentContextT = new IBehaviorTreeFragmentContextT();
			this.UnPackTo(behaviorTreeFragmentContextT);
			return behaviorTreeFragmentContextT;
		}

		// Token: 0x0602B405 RID: 177157 RVA: 0x005F574B File Offset: 0x005F394B
		public void UnPackTo(IBehaviorTreeFragmentContextT _o)
		{
			_o.Type = this.Type;
			_o.Id = this.Id;
		}

		// Token: 0x0602B406 RID: 177158 RVA: 0x005F5768 File Offset: 0x005F3968
		public static Offset<IBehaviorTreeFragmentContext> Pack(FlatBufferBuilder builder, IBehaviorTreeFragmentContextT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBehaviorTreeFragmentContext>);
			}
			return IBehaviorTreeFragmentContext.CreateIBehaviorTreeFragmentContext(builder, _o.Type, _o.Id);
		}

		// Token: 0x0401073A RID: 67386
		private Table __p;
	}
}
