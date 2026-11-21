using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B09 RID: 27401
	public struct ICommonTipId : IFlatbufferObject
	{
		// Token: 0x1700C93A RID: 51514
		// (get) Token: 0x0602F1C0 RID: 192960 RVA: 0x0066CC59 File Offset: 0x0066AE59
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602F1C1 RID: 192961 RVA: 0x0066CC66 File Offset: 0x0066AE66
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602F1C2 RID: 192962 RVA: 0x0066CC70 File Offset: 0x0066AE70
		public static ICommonTipId GetRootAsICommonTipId(ByteBuffer _bb)
		{
			return ICommonTipId.GetRootAsICommonTipId(_bb, default(ICommonTipId));
		}

		// Token: 0x0602F1C3 RID: 192963 RVA: 0x0066CC8C File Offset: 0x0066AE8C
		public static ICommonTipId GetRootAsICommonTipId(ByteBuffer _bb, ICommonTipId obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602F1C4 RID: 192964 RVA: 0x0066CCA9 File Offset: 0x0066AEA9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602F1C5 RID: 192965 RVA: 0x0066CCB8 File Offset: 0x0066AEB8
		public ICommonTipId __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C93B RID: 51515
		// (get) Token: 0x0602F1C6 RID: 192966 RVA: 0x0066CCC8 File Offset: 0x0066AEC8
		public ECommonTipType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECommonTipType.ChallengeCondition;
				}
				return (ECommonTipType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C93C RID: 51516
		// (get) Token: 0x0602F1C7 RID: 192967 RVA: 0x0066CD04 File Offset: 0x0066AF04
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

		// Token: 0x0602F1C8 RID: 192968 RVA: 0x0066CD40 File Offset: 0x0066AF40
		public static Offset<ICommonTipId> CreateICommonTipId(FlatBufferBuilder builder, ECommonTipType Type = ECommonTipType.ChallengeCondition, int Id = 0)
		{
			builder.StartTable(2);
			ICommonTipId.AddId(builder, Id);
			ICommonTipId.AddType(builder, Type);
			return ICommonTipId.EndICommonTipId(builder);
		}

		// Token: 0x0602F1C9 RID: 192969 RVA: 0x0066CD5D File Offset: 0x0066AF5D
		public static void StartICommonTipId(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602F1CA RID: 192970 RVA: 0x0066CD66 File Offset: 0x0066AF66
		public static void AddType(FlatBufferBuilder builder, ECommonTipType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602F1CB RID: 192971 RVA: 0x0066CD71 File Offset: 0x0066AF71
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x0602F1CC RID: 192972 RVA: 0x0066CD7C File Offset: 0x0066AF7C
		public static Offset<ICommonTipId> EndICommonTipId(FlatBufferBuilder builder)
		{
			return new Offset<ICommonTipId>(builder.EndTable());
		}

		// Token: 0x0602F1CD RID: 192973 RVA: 0x0066CD8C File Offset: 0x0066AF8C
		public ICommonTipIdT UnPack()
		{
			ICommonTipIdT commonTipIdT = new ICommonTipIdT();
			this.UnPackTo(commonTipIdT);
			return commonTipIdT;
		}

		// Token: 0x0602F1CE RID: 192974 RVA: 0x0066CDA7 File Offset: 0x0066AFA7
		public void UnPackTo(ICommonTipIdT _o)
		{
			_o.Type = this.Type;
			_o.Id = this.Id;
		}

		// Token: 0x0602F1CF RID: 192975 RVA: 0x0066CDC4 File Offset: 0x0066AFC4
		public static Offset<ICommonTipId> Pack(FlatBufferBuilder builder, ICommonTipIdT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICommonTipId>);
			}
			return ICommonTipId.CreateICommonTipId(builder, _o.Type, _o.Id);
		}

		// Token: 0x040118BC RID: 71868
		private Table __p;
	}
}
