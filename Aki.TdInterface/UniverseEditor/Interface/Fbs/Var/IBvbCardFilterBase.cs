using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003A27 RID: 14887
	public struct IBvbCardFilterBase : IFlatbufferObject
	{
		// Token: 0x17006609 RID: 26121
		// (get) Token: 0x06014223 RID: 82467 RVA: 0x002F1EC5 File Offset: 0x002F00C5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06014224 RID: 82468 RVA: 0x002F1ED2 File Offset: 0x002F00D2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06014225 RID: 82469 RVA: 0x002F1EDC File Offset: 0x002F00DC
		public static IBvbCardFilterBase GetRootAsIBvbCardFilterBase(ByteBuffer _bb)
		{
			return IBvbCardFilterBase.GetRootAsIBvbCardFilterBase(_bb, default(IBvbCardFilterBase));
		}

		// Token: 0x06014226 RID: 82470 RVA: 0x002F1EF8 File Offset: 0x002F00F8
		public static IBvbCardFilterBase GetRootAsIBvbCardFilterBase(ByteBuffer _bb, IBvbCardFilterBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06014227 RID: 82471 RVA: 0x002F1F15 File Offset: 0x002F0115
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06014228 RID: 82472 RVA: 0x002F1F24 File Offset: 0x002F0124
		public IBvbCardFilterBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700660A RID: 26122
		// (get) Token: 0x06014229 RID: 82473 RVA: 0x002F1F34 File Offset: 0x002F0134
		public EBvbCardFilterType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EBvbCardFilterType.CompareCost;
				}
				return (EBvbCardFilterType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601422A RID: 82474 RVA: 0x002F1F70 File Offset: 0x002F0170
		public static Offset<IBvbCardFilterBase> CreateIBvbCardFilterBase(FlatBufferBuilder builder, EBvbCardFilterType Type = EBvbCardFilterType.CompareCost)
		{
			builder.StartTable(1);
			IBvbCardFilterBase.AddType(builder, Type);
			return IBvbCardFilterBase.EndIBvbCardFilterBase(builder);
		}

		// Token: 0x0601422B RID: 82475 RVA: 0x002F1F86 File Offset: 0x002F0186
		public static void StartIBvbCardFilterBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601422C RID: 82476 RVA: 0x002F1F8F File Offset: 0x002F018F
		public static void AddType(FlatBufferBuilder builder, EBvbCardFilterType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601422D RID: 82477 RVA: 0x002F1F9A File Offset: 0x002F019A
		public static Offset<IBvbCardFilterBase> EndIBvbCardFilterBase(FlatBufferBuilder builder)
		{
			return new Offset<IBvbCardFilterBase>(builder.EndTable());
		}

		// Token: 0x0601422E RID: 82478 RVA: 0x002F1FA8 File Offset: 0x002F01A8
		public IBvbCardFilterBaseT UnPack()
		{
			IBvbCardFilterBaseT bvbCardFilterBaseT = new IBvbCardFilterBaseT();
			this.UnPackTo(bvbCardFilterBaseT);
			return bvbCardFilterBaseT;
		}

		// Token: 0x0601422F RID: 82479 RVA: 0x002F1FC3 File Offset: 0x002F01C3
		public void UnPackTo(IBvbCardFilterBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06014230 RID: 82480 RVA: 0x002F1FD4 File Offset: 0x002F01D4
		public static Offset<IBvbCardFilterBase> Pack(FlatBufferBuilder builder, IBvbCardFilterBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBvbCardFilterBase>);
			}
			return IBvbCardFilterBase.CreateIBvbCardFilterBase(builder, _o.Type);
		}

		// Token: 0x0400AE9E RID: 44702
		private Table __p;
	}
}
