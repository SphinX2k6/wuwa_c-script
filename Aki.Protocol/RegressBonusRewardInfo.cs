using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000EDB RID: 3803
	public sealed class RegressBonusRewardInfo : IMessage<RegressBonusRewardInfo>, IMessage, IEquatable<RegressBonusRewardInfo>, IDeepCloneable<RegressBonusRewardInfo>, IBufferMessage
	{
		// Token: 0x06014620 RID: 83488 RVA: 0x002F6270 File Offset: 0x002F4470
		[NullableContext(1)]
		public static RegressBonusRewardInfo Create()
		{
			return new RegressBonusRewardInfo();
		}

		// Token: 0x170043C2 RID: 17346
		// (get) Token: 0x06014621 RID: 83489 RVA: 0x002F6277 File Offset: 0x002F4477
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RegressBonusRewardInfo> Parser
		{
			get
			{
				return RegressBonusRewardInfo._parser;
			}
		}

		// Token: 0x170043C3 RID: 17347
		// (get) Token: 0x06014622 RID: 83490 RVA: 0x002F627E File Offset: 0x002F447E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170043C4 RID: 17348
		// (get) Token: 0x06014623 RID: 83491 RVA: 0x002F6281 File Offset: 0x002F4481
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RegressBonusRewardInfo.Descriptor;
			}
		}

		// Token: 0x06014624 RID: 83492 RVA: 0x002F6288 File Offset: 0x002F4488
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RegressBonusRewardInfo()
		{
		}

		// Token: 0x06014625 RID: 83493 RVA: 0x002F6290 File Offset: 0x002F4490
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RegressBonusRewardInfo(RegressBonusRewardInfo other) : this()
		{
			this.id_ = other.id_;
			this.type_ = other.type_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014626 RID: 83494 RVA: 0x002F62C1 File Offset: 0x002F44C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RegressBonusRewardInfo Clone()
		{
			return new RegressBonusRewardInfo(this);
		}

		// Token: 0x170043C5 RID: 17349
		// (get) Token: 0x06014627 RID: 83495 RVA: 0x002F62C9 File Offset: 0x002F44C9
		// (set) Token: 0x06014628 RID: 83496 RVA: 0x002F62D1 File Offset: 0x002F44D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x170043C6 RID: 17350
		// (get) Token: 0x06014629 RID: 83497 RVA: 0x002F62DA File Offset: 0x002F44DA
		// (set) Token: 0x0601462A RID: 83498 RVA: 0x002F62E2 File Offset: 0x002F44E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RegressBonusRewardType Type
		{
			get
			{
				return this.type_;
			}
			set
			{
				this.type_ = value;
			}
		}

		// Token: 0x0601462B RID: 83499 RVA: 0x002F62EB File Offset: 0x002F44EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RegressBonusRewardInfo);
		}

		// Token: 0x0601462C RID: 83500 RVA: 0x002F62F9 File Offset: 0x002F44F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RegressBonusRewardInfo other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.Type == other.Type && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601462D RID: 83501 RVA: 0x002F6338 File Offset: 0x002F4538
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.Type != RegressBonusRewardType.Free)
			{
				num ^= this.Type.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601462E RID: 83502 RVA: 0x002F6396 File Offset: 0x002F4596
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601462F RID: 83503 RVA: 0x002F63A3 File Offset: 0x002F45A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014630 RID: 83504 RVA: 0x002F63AC File Offset: 0x002F45AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			if (this.Type != RegressBonusRewardType.Free)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.Type);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014631 RID: 83505 RVA: 0x002F6404 File Offset: 0x002F4604
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.Type != RegressBonusRewardType.Free)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Type);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06014632 RID: 83506 RVA: 0x002F645C File Offset: 0x002F465C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RegressBonusRewardInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.Type != RegressBonusRewardType.Free)
			{
				this.Type = other.Type;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06014633 RID: 83507 RVA: 0x002F64AC File Offset: 0x002F46AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014634 RID: 83508 RVA: 0x002F64B8 File Offset: 0x002F46B8
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
						this.Type = (RegressBonusRewardType)input.ReadEnum();
					}
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x04007BB5 RID: 31669
		private static readonly MessageParser<RegressBonusRewardInfo> _parser = new MessageParser<RegressBonusRewardInfo>(() => new RegressBonusRewardInfo());

		// Token: 0x04007BB6 RID: 31670
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007BB7 RID: 31671
		public const int IdFieldNumber = 1;

		// Token: 0x04007BB8 RID: 31672
		private int id_;

		// Token: 0x04007BB9 RID: 31673
		public const int TypeFieldNumber = 2;

		// Token: 0x04007BBA RID: 31674
		private RegressBonusRewardType type_;
	}
}
