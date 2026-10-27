using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005ACF RID: 23247
	public struct ITrampleTipType : IFlatbufferObject
	{
		// Token: 0x1700AF35 RID: 44853
		// (get) Token: 0x06027A4E RID: 162382 RVA: 0x005741BE File Offset: 0x005723BE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06027A4F RID: 162383 RVA: 0x005741CB File Offset: 0x005723CB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06027A50 RID: 162384 RVA: 0x005741D4 File Offset: 0x005723D4
		public static ITrampleTipType GetRootAsITrampleTipType(ByteBuffer _bb)
		{
			return ITrampleTipType.GetRootAsITrampleTipType(_bb, default(ITrampleTipType));
		}

		// Token: 0x06027A51 RID: 162385 RVA: 0x005741F0 File Offset: 0x005723F0
		public static ITrampleTipType GetRootAsITrampleTipType(ByteBuffer _bb, ITrampleTipType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06027A52 RID: 162386 RVA: 0x0057420D File Offset: 0x0057240D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06027A53 RID: 162387 RVA: 0x0057421C File Offset: 0x0057241C
		public ITrampleTipType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AF36 RID: 44854
		// (get) Token: 0x06027A54 RID: 162388 RVA: 0x0057422C File Offset: 0x0057242C
		public ETrampleTipType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETrampleTipType.CountDownTextTip;
				}
				return (ETrampleTipType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06027A55 RID: 162389 RVA: 0x00574268 File Offset: 0x00572468
		public static Offset<ITrampleTipType> CreateITrampleTipType(FlatBufferBuilder builder, ETrampleTipType Type = ETrampleTipType.CountDownTextTip)
		{
			builder.StartTable(1);
			ITrampleTipType.AddType(builder, Type);
			return ITrampleTipType.EndITrampleTipType(builder);
		}

		// Token: 0x06027A56 RID: 162390 RVA: 0x0057427E File Offset: 0x0057247E
		public static void StartITrampleTipType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06027A57 RID: 162391 RVA: 0x00574287 File Offset: 0x00572487
		public static void AddType(FlatBufferBuilder builder, ETrampleTipType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06027A58 RID: 162392 RVA: 0x00574292 File Offset: 0x00572492
		public static Offset<ITrampleTipType> EndITrampleTipType(FlatBufferBuilder builder)
		{
			return new Offset<ITrampleTipType>(builder.EndTable());
		}

		// Token: 0x06027A59 RID: 162393 RVA: 0x005742A0 File Offset: 0x005724A0
		public ITrampleTipTypeT UnPack()
		{
			ITrampleTipTypeT trampleTipTypeT = new ITrampleTipTypeT();
			this.UnPackTo(trampleTipTypeT);
			return trampleTipTypeT;
		}

		// Token: 0x06027A5A RID: 162394 RVA: 0x005742BB File Offset: 0x005724BB
		public void UnPackTo(ITrampleTipTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06027A5B RID: 162395 RVA: 0x005742CC File Offset: 0x005724CC
		public static Offset<ITrampleTipType> Pack(FlatBufferBuilder builder, ITrampleTipTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITrampleTipType>);
			}
			return ITrampleTipType.CreateITrampleTipType(builder, _o.Type);
		}

		// Token: 0x0400F1AB RID: 61867
		private Table __p;
	}
}
