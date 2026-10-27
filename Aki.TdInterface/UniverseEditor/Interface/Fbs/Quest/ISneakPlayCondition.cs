using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004133 RID: 16691
	public struct ISneakPlayCondition : IFlatbufferObject
	{
		// Token: 0x1700763E RID: 30270
		// (get) Token: 0x060187AC RID: 100268 RVA: 0x003878DD File Offset: 0x00385ADD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060187AD RID: 100269 RVA: 0x003878EA File Offset: 0x00385AEA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060187AE RID: 100270 RVA: 0x003878F4 File Offset: 0x00385AF4
		public static ISneakPlayCondition GetRootAsISneakPlayCondition(ByteBuffer _bb)
		{
			return ISneakPlayCondition.GetRootAsISneakPlayCondition(_bb, default(ISneakPlayCondition));
		}

		// Token: 0x060187AF RID: 100271 RVA: 0x00387910 File Offset: 0x00385B10
		public static ISneakPlayCondition GetRootAsISneakPlayCondition(ByteBuffer _bb, ISneakPlayCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060187B0 RID: 100272 RVA: 0x0038792D File Offset: 0x00385B2D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060187B1 RID: 100273 RVA: 0x0038793C File Offset: 0x00385B3C
		public ISneakPlayCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700763F RID: 30271
		// (get) Token: 0x060187B2 RID: 100274 RVA: 0x0038794C File Offset: 0x00385B4C
		public int Time
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060187B3 RID: 100275 RVA: 0x00387988 File Offset: 0x00385B88
		public static Offset<ISneakPlayCondition> CreateISneakPlayCondition(FlatBufferBuilder builder, int Time = 0)
		{
			builder.StartTable(1);
			ISneakPlayCondition.AddTime(builder, Time);
			return ISneakPlayCondition.EndISneakPlayCondition(builder);
		}

		// Token: 0x060187B4 RID: 100276 RVA: 0x0038799E File Offset: 0x00385B9E
		public static void StartISneakPlayCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060187B5 RID: 100277 RVA: 0x003879A7 File Offset: 0x00385BA7
		public static void AddTime(FlatBufferBuilder builder, int time)
		{
			builder.AddInt(0, time, 0);
		}

		// Token: 0x060187B6 RID: 100278 RVA: 0x003879B2 File Offset: 0x00385BB2
		public static Offset<ISneakPlayCondition> EndISneakPlayCondition(FlatBufferBuilder builder)
		{
			return new Offset<ISneakPlayCondition>(builder.EndTable());
		}

		// Token: 0x060187B7 RID: 100279 RVA: 0x003879C0 File Offset: 0x00385BC0
		public ISneakPlayConditionT UnPack()
		{
			ISneakPlayConditionT sneakPlayConditionT = new ISneakPlayConditionT();
			this.UnPackTo(sneakPlayConditionT);
			return sneakPlayConditionT;
		}

		// Token: 0x060187B8 RID: 100280 RVA: 0x003879DB File Offset: 0x00385BDB
		public void UnPackTo(ISneakPlayConditionT _o)
		{
			_o.Time = this.Time;
		}

		// Token: 0x060187B9 RID: 100281 RVA: 0x003879EC File Offset: 0x00385BEC
		public static Offset<ISneakPlayCondition> Pack(FlatBufferBuilder builder, ISneakPlayConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISneakPlayCondition>);
			}
			return ISneakPlayCondition.CreateISneakPlayCondition(builder, _o.Time);
		}

		// Token: 0x0400BD37 RID: 48439
		private Table __p;
	}
}
