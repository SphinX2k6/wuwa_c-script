using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A53 RID: 27219
	public struct IClientModifySelfTarget : IFlatbufferObject
	{
		// Token: 0x1700C7FC RID: 51196
		// (get) Token: 0x0602EB19 RID: 191257 RVA: 0x0065D6B9 File Offset: 0x0065B8B9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602EB1A RID: 191258 RVA: 0x0065D6C6 File Offset: 0x0065B8C6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602EB1B RID: 191259 RVA: 0x0065D6D0 File Offset: 0x0065B8D0
		public static IClientModifySelfTarget GetRootAsIClientModifySelfTarget(ByteBuffer _bb)
		{
			return IClientModifySelfTarget.GetRootAsIClientModifySelfTarget(_bb, default(IClientModifySelfTarget));
		}

		// Token: 0x0602EB1C RID: 191260 RVA: 0x0065D6EC File Offset: 0x0065B8EC
		public static IClientModifySelfTarget GetRootAsIClientModifySelfTarget(ByteBuffer _bb, IClientModifySelfTarget obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602EB1D RID: 191261 RVA: 0x0065D709 File Offset: 0x0065B909
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602EB1E RID: 191262 RVA: 0x0065D718 File Offset: 0x0065B918
		public IClientModifySelfTarget __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C7FD RID: 51197
		// (get) Token: 0x0602EB1F RID: 191263 RVA: 0x0065D728 File Offset: 0x0065B928
		public EClientModifyTargetType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EClientModifyTargetType.Self;
				}
				return (EClientModifyTargetType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602EB20 RID: 191264 RVA: 0x0065D764 File Offset: 0x0065B964
		public static Offset<IClientModifySelfTarget> CreateIClientModifySelfTarget(FlatBufferBuilder builder, EClientModifyTargetType Type = EClientModifyTargetType.Self)
		{
			builder.StartTable(1);
			IClientModifySelfTarget.AddType(builder, Type);
			return IClientModifySelfTarget.EndIClientModifySelfTarget(builder);
		}

		// Token: 0x0602EB21 RID: 191265 RVA: 0x0065D77A File Offset: 0x0065B97A
		public static void StartIClientModifySelfTarget(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602EB22 RID: 191266 RVA: 0x0065D783 File Offset: 0x0065B983
		public static void AddType(FlatBufferBuilder builder, EClientModifyTargetType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602EB23 RID: 191267 RVA: 0x0065D78E File Offset: 0x0065B98E
		public static Offset<IClientModifySelfTarget> EndIClientModifySelfTarget(FlatBufferBuilder builder)
		{
			return new Offset<IClientModifySelfTarget>(builder.EndTable());
		}

		// Token: 0x0602EB24 RID: 191268 RVA: 0x0065D79C File Offset: 0x0065B99C
		public IClientModifySelfTargetT UnPack()
		{
			IClientModifySelfTargetT clientModifySelfTargetT = new IClientModifySelfTargetT();
			this.UnPackTo(clientModifySelfTargetT);
			return clientModifySelfTargetT;
		}

		// Token: 0x0602EB25 RID: 191269 RVA: 0x0065D7B7 File Offset: 0x0065B9B7
		public void UnPackTo(IClientModifySelfTargetT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602EB26 RID: 191270 RVA: 0x0065D7C8 File Offset: 0x0065B9C8
		public static Offset<IClientModifySelfTarget> Pack(FlatBufferBuilder builder, IClientModifySelfTargetT _o)
		{
			if (_o == null)
			{
				return default(Offset<IClientModifySelfTarget>);
			}
			return IClientModifySelfTarget.CreateIClientModifySelfTarget(builder, _o.Type);
		}

		// Token: 0x040117D5 RID: 71637
		private Table __p;
	}
}
