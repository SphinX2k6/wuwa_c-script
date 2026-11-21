using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A26 RID: 23078
	public struct IJigsawCompleteCondition : IFlatbufferObject
	{
		// Token: 0x1700A7BF RID: 42943
		// (get) Token: 0x06025B3E RID: 154430 RVA: 0x0052B056 File Offset: 0x00529256
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06025B3F RID: 154431 RVA: 0x0052B063 File Offset: 0x00529263
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06025B40 RID: 154432 RVA: 0x0052B06C File Offset: 0x0052926C
		public static IJigsawCompleteCondition GetRootAsIJigsawCompleteCondition(ByteBuffer _bb)
		{
			return IJigsawCompleteCondition.GetRootAsIJigsawCompleteCondition(_bb, default(IJigsawCompleteCondition));
		}

		// Token: 0x06025B41 RID: 154433 RVA: 0x0052B088 File Offset: 0x00529288
		public static IJigsawCompleteCondition GetRootAsIJigsawCompleteCondition(ByteBuffer _bb, IJigsawCompleteCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06025B42 RID: 154434 RVA: 0x0052B0A5 File Offset: 0x005292A5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06025B43 RID: 154435 RVA: 0x0052B0B4 File Offset: 0x005292B4
		public IJigsawCompleteCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A7C0 RID: 42944
		// (get) Token: 0x06025B44 RID: 154436 RVA: 0x0052B0C4 File Offset: 0x005292C4
		public EJigsawCompleteCondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EJigsawCompleteCondition.ActivateAllCorrectPiece;
				}
				return (EJigsawCompleteCondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06025B45 RID: 154437 RVA: 0x0052B100 File Offset: 0x00529300
		public static Offset<IJigsawCompleteCondition> CreateIJigsawCompleteCondition(FlatBufferBuilder builder, EJigsawCompleteCondition Type = EJigsawCompleteCondition.ActivateAllCorrectPiece)
		{
			builder.StartTable(1);
			IJigsawCompleteCondition.AddType(builder, Type);
			return IJigsawCompleteCondition.EndIJigsawCompleteCondition(builder);
		}

		// Token: 0x06025B46 RID: 154438 RVA: 0x0052B116 File Offset: 0x00529316
		public static void StartIJigsawCompleteCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06025B47 RID: 154439 RVA: 0x0052B11F File Offset: 0x0052931F
		public static void AddType(FlatBufferBuilder builder, EJigsawCompleteCondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06025B48 RID: 154440 RVA: 0x0052B12A File Offset: 0x0052932A
		public static Offset<IJigsawCompleteCondition> EndIJigsawCompleteCondition(FlatBufferBuilder builder)
		{
			return new Offset<IJigsawCompleteCondition>(builder.EndTable());
		}

		// Token: 0x06025B49 RID: 154441 RVA: 0x0052B138 File Offset: 0x00529338
		public IJigsawCompleteConditionT UnPack()
		{
			IJigsawCompleteConditionT jigsawCompleteConditionT = new IJigsawCompleteConditionT();
			this.UnPackTo(jigsawCompleteConditionT);
			return jigsawCompleteConditionT;
		}

		// Token: 0x06025B4A RID: 154442 RVA: 0x0052B153 File Offset: 0x00529353
		public void UnPackTo(IJigsawCompleteConditionT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06025B4B RID: 154443 RVA: 0x0052B164 File Offset: 0x00529364
		public static Offset<IJigsawCompleteCondition> Pack(FlatBufferBuilder builder, IJigsawCompleteConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IJigsawCompleteCondition>);
			}
			return IJigsawCompleteCondition.CreateIJigsawCompleteCondition(builder, _o.Type);
		}

		// Token: 0x0400F36D RID: 62317
		private Table __p;
	}
}
