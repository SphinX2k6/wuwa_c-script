using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A6A RID: 2666
	public sealed class MotorOnlineRankPlayerInfo : IMessage<MotorOnlineRankPlayerInfo>, IMessage, IEquatable<MotorOnlineRankPlayerInfo>, IDeepCloneable<MotorOnlineRankPlayerInfo>, IBufferMessage
	{
		// Token: 0x0600E8BC RID: 59580 RVA: 0x0022010F File Offset: 0x0021E30F
		[NullableContext(1)]
		public static MotorOnlineRankPlayerInfo Create()
		{
			return new MotorOnlineRankPlayerInfo();
		}

		// Token: 0x17002F35 RID: 12085
		// (get) Token: 0x0600E8BD RID: 59581 RVA: 0x00220116 File Offset: 0x0021E316
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MotorOnlineRankPlayerInfo> Parser
		{
			get
			{
				return MotorOnlineRankPlayerInfo._parser;
			}
		}

		// Token: 0x17002F36 RID: 12086
		// (get) Token: 0x0600E8BE RID: 59582 RVA: 0x0022011D File Offset: 0x0021E31D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002F37 RID: 12087
		// (get) Token: 0x0600E8BF RID: 59583 RVA: 0x00220120 File Offset: 0x0021E320
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorOnlineRankPlayerInfo.Descriptor;
			}
		}

		// Token: 0x0600E8C0 RID: 59584 RVA: 0x00220127 File Offset: 0x0021E327
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorOnlineRankPlayerInfo()
		{
		}

		// Token: 0x0600E8C1 RID: 59585 RVA: 0x0022012F File Offset: 0x0021E32F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorOnlineRankPlayerInfo(MotorOnlineRankPlayerInfo other) : this()
		{
			this.playerId_ = other.playerId_;
			this.rank_ = other.rank_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E8C2 RID: 59586 RVA: 0x00220160 File Offset: 0x0021E360
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorOnlineRankPlayerInfo Clone()
		{
			return new MotorOnlineRankPlayerInfo(this);
		}

		// Token: 0x17002F38 RID: 12088
		// (get) Token: 0x0600E8C3 RID: 59587 RVA: 0x00220168 File Offset: 0x0021E368
		// (set) Token: 0x0600E8C4 RID: 59588 RVA: 0x00220170 File Offset: 0x0021E370
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PlayerId
		{
			get
			{
				return this.playerId_;
			}
			set
			{
				this.playerId_ = value;
			}
		}

		// Token: 0x17002F39 RID: 12089
		// (get) Token: 0x0600E8C5 RID: 59589 RVA: 0x00220179 File Offset: 0x0021E379
		// (set) Token: 0x0600E8C6 RID: 59590 RVA: 0x00220181 File Offset: 0x0021E381
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Rank
		{
			get
			{
				return this.rank_;
			}
			set
			{
				this.rank_ = value;
			}
		}

		// Token: 0x0600E8C7 RID: 59591 RVA: 0x0022018A File Offset: 0x0021E38A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorOnlineRankPlayerInfo);
		}

		// Token: 0x0600E8C8 RID: 59592 RVA: 0x00220198 File Offset: 0x0021E398
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorOnlineRankPlayerInfo other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && this.Rank == other.Rank && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E8C9 RID: 59593 RVA: 0x002201D8 File Offset: 0x0021E3D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PlayerId != 0)
			{
				num ^= this.PlayerId.GetHashCode();
			}
			if (this.Rank != 0)
			{
				num ^= this.Rank.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E8CA RID: 59594 RVA: 0x00220230 File Offset: 0x0021E430
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E8CB RID: 59595 RVA: 0x0022023D File Offset: 0x0021E43D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E8CC RID: 59596 RVA: 0x00220248 File Offset: 0x0021E448
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.PlayerId);
			}
			if (this.Rank != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Rank);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E8CD RID: 59597 RVA: 0x002202A0 File Offset: 0x0021E4A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PlayerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerId);
			}
			if (this.Rank != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Rank);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E8CE RID: 59598 RVA: 0x002202F8 File Offset: 0x0021E4F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorOnlineRankPlayerInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PlayerId != 0)
			{
				this.PlayerId = other.PlayerId;
			}
			if (other.Rank != 0)
			{
				this.Rank = other.Rank;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E8CF RID: 59599 RVA: 0x00220348 File Offset: 0x0021E548
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E8D0 RID: 59600 RVA: 0x00220354 File Offset: 0x0021E554
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
				if (num != 8U)
				{
					if (num != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Rank = input.ReadInt32();
					}
				}
				else
				{
					this.PlayerId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04005F0F RID: 24335
		private static readonly MessageParser<MotorOnlineRankPlayerInfo> _parser = new MessageParser<MotorOnlineRankPlayerInfo>(() => new MotorOnlineRankPlayerInfo());

		// Token: 0x04005F10 RID: 24336
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005F11 RID: 24337
		public const int PlayerIdFieldNumber = 1;

		// Token: 0x04005F12 RID: 24338
		private int playerId_;

		// Token: 0x04005F13 RID: 24339
		public const int RankFieldNumber = 2;

		// Token: 0x04005F14 RID: 24340
		private int rank_;
	}
}
