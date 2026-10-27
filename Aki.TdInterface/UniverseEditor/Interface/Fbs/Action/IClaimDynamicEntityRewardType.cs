using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006376 RID: 25462
	public struct IClaimDynamicEntityRewardType : IFlatbufferObject
	{
		// Token: 0x1700BDE7 RID: 48615
		// (get) Token: 0x0602C0B6 RID: 180406 RVA: 0x0060D137 File Offset: 0x0060B337
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602C0B7 RID: 180407 RVA: 0x0060D144 File Offset: 0x0060B344
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602C0B8 RID: 180408 RVA: 0x0060D14C File Offset: 0x0060B34C
		public static IClaimDynamicEntityRewardType GetRootAsIClaimDynamicEntityRewardType(ByteBuffer _bb)
		{
			return IClaimDynamicEntityRewardType.GetRootAsIClaimDynamicEntityRewardType(_bb, default(IClaimDynamicEntityRewardType));
		}

		// Token: 0x0602C0B9 RID: 180409 RVA: 0x0060D168 File Offset: 0x0060B368
		public static IClaimDynamicEntityRewardType GetRootAsIClaimDynamicEntityRewardType(ByteBuffer _bb, IClaimDynamicEntityRewardType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602C0BA RID: 180410 RVA: 0x0060D185 File Offset: 0x0060B385
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602C0BB RID: 180411 RVA: 0x0060D194 File Offset: 0x0060B394
		public IClaimDynamicEntityRewardType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BDE8 RID: 48616
		// (get) Token: 0x0602C0BC RID: 180412 RVA: 0x0060D1A4 File Offset: 0x0060B3A4
		public EDynamicEntityRewardType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EDynamicEntityRewardType.Traffic;
				}
				return (EDynamicEntityRewardType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602C0BD RID: 180413 RVA: 0x0060D1E0 File Offset: 0x0060B3E0
		public static Offset<IClaimDynamicEntityRewardType> CreateIClaimDynamicEntityRewardType(FlatBufferBuilder builder, EDynamicEntityRewardType Type = EDynamicEntityRewardType.Traffic)
		{
			builder.StartTable(1);
			IClaimDynamicEntityRewardType.AddType(builder, Type);
			return IClaimDynamicEntityRewardType.EndIClaimDynamicEntityRewardType(builder);
		}

		// Token: 0x0602C0BE RID: 180414 RVA: 0x0060D1F6 File Offset: 0x0060B3F6
		public static void StartIClaimDynamicEntityRewardType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602C0BF RID: 180415 RVA: 0x0060D1FF File Offset: 0x0060B3FF
		public static void AddType(FlatBufferBuilder builder, EDynamicEntityRewardType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602C0C0 RID: 180416 RVA: 0x0060D20A File Offset: 0x0060B40A
		public static Offset<IClaimDynamicEntityRewardType> EndIClaimDynamicEntityRewardType(FlatBufferBuilder builder)
		{
			return new Offset<IClaimDynamicEntityRewardType>(builder.EndTable());
		}

		// Token: 0x0602C0C1 RID: 180417 RVA: 0x0060D218 File Offset: 0x0060B418
		public IClaimDynamicEntityRewardTypeT UnPack()
		{
			IClaimDynamicEntityRewardTypeT claimDynamicEntityRewardTypeT = new IClaimDynamicEntityRewardTypeT();
			this.UnPackTo(claimDynamicEntityRewardTypeT);
			return claimDynamicEntityRewardTypeT;
		}

		// Token: 0x0602C0C2 RID: 180418 RVA: 0x0060D233 File Offset: 0x0060B433
		public void UnPackTo(IClaimDynamicEntityRewardTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602C0C3 RID: 180419 RVA: 0x0060D244 File Offset: 0x0060B444
		public static Offset<IClaimDynamicEntityRewardType> Pack(FlatBufferBuilder builder, IClaimDynamicEntityRewardTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IClaimDynamicEntityRewardType>);
			}
			return IClaimDynamicEntityRewardType.CreateIClaimDynamicEntityRewardType(builder, _o.Type);
		}

		// Token: 0x04010943 RID: 67907
		private Table __p;
	}
}
