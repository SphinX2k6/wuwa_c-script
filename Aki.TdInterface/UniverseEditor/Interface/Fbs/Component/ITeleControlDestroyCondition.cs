using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A40 RID: 23104
	public struct ITeleControlDestroyCondition : IFlatbufferObject
	{
		// Token: 0x1700ADD4 RID: 44500
		// (get) Token: 0x060274A2 RID: 160930 RVA: 0x005682A0 File Offset: 0x005664A0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060274A3 RID: 160931 RVA: 0x005682AD File Offset: 0x005664AD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060274A4 RID: 160932 RVA: 0x005682B4 File Offset: 0x005664B4
		public static ITeleControlDestroyCondition GetRootAsITeleControlDestroyCondition(ByteBuffer _bb)
		{
			return ITeleControlDestroyCondition.GetRootAsITeleControlDestroyCondition(_bb, default(ITeleControlDestroyCondition));
		}

		// Token: 0x060274A5 RID: 160933 RVA: 0x005682D0 File Offset: 0x005664D0
		public static ITeleControlDestroyCondition GetRootAsITeleControlDestroyCondition(ByteBuffer _bb, ITeleControlDestroyCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060274A6 RID: 160934 RVA: 0x005682ED File Offset: 0x005664ED
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060274A7 RID: 160935 RVA: 0x005682FC File Offset: 0x005664FC
		public ITeleControlDestroyCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700ADD5 RID: 44501
		// (get) Token: 0x060274A8 RID: 160936 RVA: 0x0056830C File Offset: 0x0056650C
		public ETeleControlDestroyCondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETeleControlDestroyCondition.LetGo;
				}
				return (ETeleControlDestroyCondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060274A9 RID: 160937 RVA: 0x00568348 File Offset: 0x00566548
		public static Offset<ITeleControlDestroyCondition> CreateITeleControlDestroyCondition(FlatBufferBuilder builder, ETeleControlDestroyCondition Type = ETeleControlDestroyCondition.LetGo)
		{
			builder.StartTable(1);
			ITeleControlDestroyCondition.AddType(builder, Type);
			return ITeleControlDestroyCondition.EndITeleControlDestroyCondition(builder);
		}

		// Token: 0x060274AA RID: 160938 RVA: 0x0056835E File Offset: 0x0056655E
		public static void StartITeleControlDestroyCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060274AB RID: 160939 RVA: 0x00568367 File Offset: 0x00566567
		public static void AddType(FlatBufferBuilder builder, ETeleControlDestroyCondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060274AC RID: 160940 RVA: 0x00568372 File Offset: 0x00566572
		public static Offset<ITeleControlDestroyCondition> EndITeleControlDestroyCondition(FlatBufferBuilder builder)
		{
			return new Offset<ITeleControlDestroyCondition>(builder.EndTable());
		}

		// Token: 0x060274AD RID: 160941 RVA: 0x00568380 File Offset: 0x00566580
		public ITeleControlDestroyConditionT UnPack()
		{
			ITeleControlDestroyConditionT teleControlDestroyConditionT = new ITeleControlDestroyConditionT();
			this.UnPackTo(teleControlDestroyConditionT);
			return teleControlDestroyConditionT;
		}

		// Token: 0x060274AE RID: 160942 RVA: 0x0056839B File Offset: 0x0056659B
		public void UnPackTo(ITeleControlDestroyConditionT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060274AF RID: 160943 RVA: 0x005683AC File Offset: 0x005665AC
		public static Offset<ITeleControlDestroyCondition> Pack(FlatBufferBuilder builder, ITeleControlDestroyConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITeleControlDestroyCondition>);
			}
			return ITeleControlDestroyCondition.CreateITeleControlDestroyCondition(builder, _o.Type);
		}

		// Token: 0x0400F0BC RID: 61628
		private Table __p;
	}
}
