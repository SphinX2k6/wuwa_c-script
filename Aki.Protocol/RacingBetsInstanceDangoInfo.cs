using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E62 RID: 3682
	public sealed class RacingBetsInstanceDangoInfo : IMessage<RacingBetsInstanceDangoInfo>, IMessage, IEquatable<RacingBetsInstanceDangoInfo>, IDeepCloneable<RacingBetsInstanceDangoInfo>, IBufferMessage
	{
		// Token: 0x06013C54 RID: 80980 RVA: 0x002E0211 File Offset: 0x002DE411
		[NullableContext(1)]
		public static RacingBetsInstanceDangoInfo Create()
		{
			return new RacingBetsInstanceDangoInfo();
		}

		// Token: 0x170041A9 RID: 16809
		// (get) Token: 0x06013C55 RID: 80981 RVA: 0x002E0218 File Offset: 0x002DE418
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RacingBetsInstanceDangoInfo> Parser
		{
			get
			{
				return RacingBetsInstanceDangoInfo._parser;
			}
		}

		// Token: 0x170041AA RID: 16810
		// (get) Token: 0x06013C56 RID: 80982 RVA: 0x002E021F File Offset: 0x002DE41F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170041AB RID: 16811
		// (get) Token: 0x06013C57 RID: 80983 RVA: 0x002E0222 File Offset: 0x002DE422
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RacingBetsInstanceDangoInfo.Descriptor;
			}
		}

		// Token: 0x06013C58 RID: 80984 RVA: 0x002E0229 File Offset: 0x002DE429
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsInstanceDangoInfo()
		{
		}

		// Token: 0x06013C59 RID: 80985 RVA: 0x002E0234 File Offset: 0x002DE434
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsInstanceDangoInfo(RacingBetsInstanceDangoInfo other) : this()
		{
			this.dangoId_ = other.dangoId_;
			this.curPoint_ = other.curPoint_;
			this.diceId_ = other.diceId_;
			this.high_ = other.high_;
			this.entityId_ = other.entityId_;
			this.bpId_ = other.bpId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013C5A RID: 80986 RVA: 0x002E02A0 File Offset: 0x002DE4A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsInstanceDangoInfo Clone()
		{
			return new RacingBetsInstanceDangoInfo(this);
		}

		// Token: 0x170041AC RID: 16812
		// (get) Token: 0x06013C5B RID: 80987 RVA: 0x002E02A8 File Offset: 0x002DE4A8
		// (set) Token: 0x06013C5C RID: 80988 RVA: 0x002E02B0 File Offset: 0x002DE4B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int DangoId
		{
			get
			{
				return this.dangoId_;
			}
			set
			{
				this.dangoId_ = value;
			}
		}

		// Token: 0x170041AD RID: 16813
		// (get) Token: 0x06013C5D RID: 80989 RVA: 0x002E02B9 File Offset: 0x002DE4B9
		// (set) Token: 0x06013C5E RID: 80990 RVA: 0x002E02C1 File Offset: 0x002DE4C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CurPoint
		{
			get
			{
				return this.curPoint_;
			}
			set
			{
				this.curPoint_ = value;
			}
		}

		// Token: 0x170041AE RID: 16814
		// (get) Token: 0x06013C5F RID: 80991 RVA: 0x002E02CA File Offset: 0x002DE4CA
		// (set) Token: 0x06013C60 RID: 80992 RVA: 0x002E02D2 File Offset: 0x002DE4D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int DiceId
		{
			get
			{
				return this.diceId_;
			}
			set
			{
				this.diceId_ = value;
			}
		}

		// Token: 0x170041AF RID: 16815
		// (get) Token: 0x06013C61 RID: 80993 RVA: 0x002E02DB File Offset: 0x002DE4DB
		// (set) Token: 0x06013C62 RID: 80994 RVA: 0x002E02E3 File Offset: 0x002DE4E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int High
		{
			get
			{
				return this.high_;
			}
			set
			{
				this.high_ = value;
			}
		}

		// Token: 0x170041B0 RID: 16816
		// (get) Token: 0x06013C63 RID: 80995 RVA: 0x002E02EC File Offset: 0x002DE4EC
		// (set) Token: 0x06013C64 RID: 80996 RVA: 0x002E02F4 File Offset: 0x002DE4F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EntityId
		{
			get
			{
				return this.entityId_;
			}
			set
			{
				this.entityId_ = value;
			}
		}

		// Token: 0x170041B1 RID: 16817
		// (get) Token: 0x06013C65 RID: 80997 RVA: 0x002E02FD File Offset: 0x002DE4FD
		// (set) Token: 0x06013C66 RID: 80998 RVA: 0x002E0305 File Offset: 0x002DE505
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BpId
		{
			get
			{
				return this.bpId_;
			}
			set
			{
				this.bpId_ = value;
			}
		}

		// Token: 0x06013C67 RID: 80999 RVA: 0x002E030E File Offset: 0x002DE50E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RacingBetsInstanceDangoInfo);
		}

		// Token: 0x06013C68 RID: 81000 RVA: 0x002E031C File Offset: 0x002DE51C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RacingBetsInstanceDangoInfo other)
		{
			return other != null && (other == this || (this.DangoId == other.DangoId && this.CurPoint == other.CurPoint && this.DiceId == other.DiceId && this.High == other.High && this.EntityId == other.EntityId && this.BpId == other.BpId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013C69 RID: 81001 RVA: 0x002E03A8 File Offset: 0x002DE5A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.DangoId != 0)
			{
				num ^= this.DangoId.GetHashCode();
			}
			if (this.CurPoint != 0)
			{
				num ^= this.CurPoint.GetHashCode();
			}
			if (this.DiceId != 0)
			{
				num ^= this.DiceId.GetHashCode();
			}
			if (this.High != 0)
			{
				num ^= this.High.GetHashCode();
			}
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.BpId != 0)
			{
				num ^= this.BpId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06013C6A RID: 81002 RVA: 0x002E0464 File Offset: 0x002DE664
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013C6B RID: 81003 RVA: 0x002E0471 File Offset: 0x002DE671
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013C6C RID: 81004 RVA: 0x002E047C File Offset: 0x002DE67C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.DangoId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.DangoId);
			}
			if (this.CurPoint != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.CurPoint);
			}
			if (this.DiceId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.DiceId);
			}
			if (this.High != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.High);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(40);
				output.WriteInt64(this.EntityId);
			}
			if (this.BpId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.BpId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013C6D RID: 81005 RVA: 0x002E0544 File Offset: 0x002DE744
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.DangoId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.DangoId);
			}
			if (this.CurPoint != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CurPoint);
			}
			if (this.DiceId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.DiceId);
			}
			if (this.High != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.High);
			}
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.BpId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BpId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06013C6E RID: 81006 RVA: 0x002E05FC File Offset: 0x002DE7FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RacingBetsInstanceDangoInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.DangoId != 0)
			{
				this.DangoId = other.DangoId;
			}
			if (other.CurPoint != 0)
			{
				this.CurPoint = other.CurPoint;
			}
			if (other.DiceId != 0)
			{
				this.DiceId = other.DiceId;
			}
			if (other.High != 0)
			{
				this.High = other.High;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.BpId != 0)
			{
				this.BpId = other.BpId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06013C6F RID: 81007 RVA: 0x002E069C File Offset: 0x002DE89C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013C70 RID: 81008 RVA: 0x002E06A8 File Offset: 0x002DE8A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if ((num & 7U) == 4U)
				{
					return;
				}
				if (num <= 24U)
				{
					if (num == 8U)
					{
						this.DangoId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.CurPoint = input.ReadInt32();
						continue;
					}
					if (num == 24U)
					{
						this.DiceId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 32U)
					{
						this.High = input.ReadInt32();
						continue;
					}
					if (num == 40U)
					{
						this.EntityId = input.ReadInt64();
						continue;
					}
					if (num == 48U)
					{
						this.BpId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040078E8 RID: 30952
		private static readonly MessageParser<RacingBetsInstanceDangoInfo> _parser = new MessageParser<RacingBetsInstanceDangoInfo>(() => new RacingBetsInstanceDangoInfo());

		// Token: 0x040078E9 RID: 30953
		private UnknownFieldSet _unknownFields;

		// Token: 0x040078EA RID: 30954
		public const int DangoIdFieldNumber = 1;

		// Token: 0x040078EB RID: 30955
		private int dangoId_;

		// Token: 0x040078EC RID: 30956
		public const int CurPointFieldNumber = 2;

		// Token: 0x040078ED RID: 30957
		private int curPoint_;

		// Token: 0x040078EE RID: 30958
		public const int DiceIdFieldNumber = 3;

		// Token: 0x040078EF RID: 30959
		private int diceId_;

		// Token: 0x040078F0 RID: 30960
		public const int HighFieldNumber = 4;

		// Token: 0x040078F1 RID: 30961
		private int high_;

		// Token: 0x040078F2 RID: 30962
		public const int EntityIdFieldNumber = 5;

		// Token: 0x040078F3 RID: 30963
		private long entityId_;

		// Token: 0x040078F4 RID: 30964
		public const int BpIdFieldNumber = 6;

		// Token: 0x040078F5 RID: 30965
		private int bpId_;
	}
}
