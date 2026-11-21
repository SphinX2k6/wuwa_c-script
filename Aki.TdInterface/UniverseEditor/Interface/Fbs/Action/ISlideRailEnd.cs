using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007911 RID: 30993
	public struct ISlideRailEnd : IFlatbufferObject
	{
		// Token: 0x1700E35A RID: 58202
		// (get) Token: 0x06036926 RID: 223526 RVA: 0x0074DE0B File Offset: 0x0074C00B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036927 RID: 223527 RVA: 0x0074DE18 File Offset: 0x0074C018
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036928 RID: 223528 RVA: 0x0074DE20 File Offset: 0x0074C020
		public static ISlideRailEnd GetRootAsISlideRailEnd(ByteBuffer _bb)
		{
			return ISlideRailEnd.GetRootAsISlideRailEnd(_bb, default(ISlideRailEnd));
		}

		// Token: 0x06036929 RID: 223529 RVA: 0x0074DE3C File Offset: 0x0074C03C
		public static ISlideRailEnd GetRootAsISlideRailEnd(ByteBuffer _bb, ISlideRailEnd obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603692A RID: 223530 RVA: 0x0074DE59 File Offset: 0x0074C059
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603692B RID: 223531 RVA: 0x0074DE68 File Offset: 0x0074C068
		public ISlideRailEnd __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E35B RID: 58203
		// (get) Token: 0x0603692C RID: 223532 RVA: 0x0074DE78 File Offset: 0x0074C078
		public TSlideRailEnd EndTargetType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return TSlideRailEnd.NONE;
				}
				return (TSlideRailEnd)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603692D RID: 223533 RVA: 0x0074DEB4 File Offset: 0x0074C0B4
		public TTable? EndTarget<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0603692E RID: 223534 RVA: 0x0074DEF8 File Offset: 0x0074C0F8
		public IAiFollowerSlideRailEnd EndTargetAsIAiFollowerSlideRailEnd()
		{
			return this.EndTarget<IAiFollowerSlideRailEnd>().Value;
		}

		// Token: 0x0603692F RID: 223535 RVA: 0x0074DF14 File Offset: 0x0074C114
		public IPlayerSlideRailEnd EndTargetAsIPlayerSlideRailEnd()
		{
			return this.EndTarget<IPlayerSlideRailEnd>().Value;
		}

		// Token: 0x06036930 RID: 223536 RVA: 0x0074DF2F File Offset: 0x0074C12F
		public static Offset<ISlideRailEnd> CreateISlideRailEnd(FlatBufferBuilder builder, TSlideRailEnd EndTarget_type = TSlideRailEnd.NONE, int EndTargetOffset = 0)
		{
			builder.StartTable(2);
			ISlideRailEnd.AddEndTarget(builder, EndTargetOffset);
			ISlideRailEnd.AddEndTargetType(builder, EndTarget_type);
			return ISlideRailEnd.EndISlideRailEnd(builder);
		}

		// Token: 0x06036931 RID: 223537 RVA: 0x0074DF4C File Offset: 0x0074C14C
		public static void StartISlideRailEnd(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06036932 RID: 223538 RVA: 0x0074DF55 File Offset: 0x0074C155
		public static void AddEndTargetType(FlatBufferBuilder builder, TSlideRailEnd endTargetType)
		{
			builder.AddByte(0, (byte)endTargetType, 0);
		}

		// Token: 0x06036933 RID: 223539 RVA: 0x0074DF60 File Offset: 0x0074C160
		public static void AddEndTarget(FlatBufferBuilder builder, int endTargetOffset)
		{
			builder.AddOffset(1, endTargetOffset, 0);
		}

		// Token: 0x06036934 RID: 223540 RVA: 0x0074DF6B File Offset: 0x0074C16B
		public static Offset<ISlideRailEnd> EndISlideRailEnd(FlatBufferBuilder builder)
		{
			return new Offset<ISlideRailEnd>(builder.EndTable());
		}

		// Token: 0x06036935 RID: 223541 RVA: 0x0074DF78 File Offset: 0x0074C178
		public ISlideRailEndT UnPack()
		{
			ISlideRailEndT slideRailEndT = new ISlideRailEndT();
			this.UnPackTo(slideRailEndT);
			return slideRailEndT;
		}

		// Token: 0x06036936 RID: 223542 RVA: 0x0074DF94 File Offset: 0x0074C194
		public void UnPackTo(ISlideRailEndT _o)
		{
			_o.EndTarget = new TSlideRailEndUnion();
			_o.EndTarget.Type = this.EndTargetType;
			TSlideRailEnd endTargetType = this.EndTargetType;
			if (endTargetType == TSlideRailEnd.IAiFollowerSlideRailEnd)
			{
				_o.EndTarget.Value = ((this.EndTarget<IAiFollowerSlideRailEnd>() != null) ? this.EndTarget<IAiFollowerSlideRailEnd>().Value.UnPack() : null);
				return;
			}
			if (endTargetType != TSlideRailEnd.IPlayerSlideRailEnd)
			{
				return;
			}
			_o.EndTarget.Value = ((this.EndTarget<IPlayerSlideRailEnd>() != null) ? this.EndTarget<IPlayerSlideRailEnd>().Value.UnPack() : null);
		}

		// Token: 0x06036937 RID: 223543 RVA: 0x0074E038 File Offset: 0x0074C238
		public static Offset<ISlideRailEnd> Pack(FlatBufferBuilder builder, ISlideRailEndT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISlideRailEnd>);
			}
			TSlideRailEnd endTarget_type = (_o.EndTarget == null) ? TSlideRailEnd.NONE : _o.EndTarget.Type;
			int endTargetOffset = (_o.EndTarget == null) ? 0 : TSlideRailEndUnion.Pack(builder, _o.EndTarget);
			return ISlideRailEnd.CreateISlideRailEnd(builder, endTarget_type, endTargetOffset);
		}

		// Token: 0x04012BCF RID: 76751
		private Table __p;
	}
}
