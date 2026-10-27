using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003AC RID: 940
	[NetMessage(EMessageId.DarkTideMapMarkUpdateNotify)]
	public sealed class DarkTideMapMarkUpdateNotify : IMessage<DarkTideMapMarkUpdateNotify>, IMessage, IEquatable<DarkTideMapMarkUpdateNotify>, IDeepCloneable<DarkTideMapMarkUpdateNotify>, IBufferMessage
	{
		// Token: 0x06005C5B RID: 23643 RVA: 0x000E0585 File Offset: 0x000DE785
		[NullableContext(1)]
		public static DarkTideMapMarkUpdateNotify Create()
		{
			return new DarkTideMapMarkUpdateNotify();
		}

		// Token: 0x1700111F RID: 4383
		// (get) Token: 0x06005C5C RID: 23644 RVA: 0x000E058C File Offset: 0x000DE78C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001120 RID: 4384
		// (get) Token: 0x06005C5D RID: 23645 RVA: 0x000E058F File Offset: 0x000DE78F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DarkTideMapMarkUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06005C5E RID: 23646 RVA: 0x000E0596 File Offset: 0x000DE796
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DarkTideMapMarkUpdateNotify()
		{
		}

		// Token: 0x06005C5F RID: 23647 RVA: 0x000E05A0 File Offset: 0x000DE7A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DarkTideMapMarkUpdateNotify(DarkTideMapMarkUpdateNotify other) : this()
		{
			this.playerId_ = other.playerId_;
			this.changeType_ = other.changeType_;
			this.markInfo_ = ((other.markInfo_ != null) ? other.markInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005C60 RID: 23648 RVA: 0x000E05F8 File Offset: 0x000DE7F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DarkTideMapMarkUpdateNotify Clone()
		{
			return new DarkTideMapMarkUpdateNotify(this);
		}

		// Token: 0x17001121 RID: 4385
		// (get) Token: 0x06005C61 RID: 23649 RVA: 0x000E0600 File Offset: 0x000DE800
		// (set) Token: 0x06005C62 RID: 23650 RVA: 0x000E0608 File Offset: 0x000DE808
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

		// Token: 0x17001122 RID: 4386
		// (get) Token: 0x06005C63 RID: 23651 RVA: 0x000E0611 File Offset: 0x000DE811
		// (set) Token: 0x06005C64 RID: 23652 RVA: 0x000E0619 File Offset: 0x000DE819
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DarkTideMapMarkChangeType ChangeType
		{
			get
			{
				return this.changeType_;
			}
			set
			{
				this.changeType_ = value;
			}
		}

		// Token: 0x17001123 RID: 4387
		// (get) Token: 0x06005C65 RID: 23653 RVA: 0x000E0622 File Offset: 0x000DE822
		// (set) Token: 0x06005C66 RID: 23654 RVA: 0x000E062A File Offset: 0x000DE82A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DarkTideMarkInfo MarkInfo
		{
			get
			{
				return this.markInfo_;
			}
			set
			{
				this.markInfo_ = value;
			}
		}

		// Token: 0x06005C67 RID: 23655 RVA: 0x000E0633 File Offset: 0x000DE833
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DarkTideMapMarkUpdateNotify);
		}

		// Token: 0x06005C68 RID: 23656 RVA: 0x000E0644 File Offset: 0x000DE844
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DarkTideMapMarkUpdateNotify other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && this.ChangeType == other.ChangeType && object.Equals(this.MarkInfo, other.MarkInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005C69 RID: 23657 RVA: 0x000E06A4 File Offset: 0x000DE8A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PlayerId != 0)
			{
				num ^= this.PlayerId.GetHashCode();
			}
			if (this.ChangeType != DarkTideMapMarkChangeType.DarkTideMapMarkAdd)
			{
				num ^= this.ChangeType.GetHashCode();
			}
			if (this.markInfo_ != null)
			{
				num ^= this.MarkInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005C6A RID: 23658 RVA: 0x000E0718 File Offset: 0x000DE918
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005C6B RID: 23659 RVA: 0x000E0725 File Offset: 0x000DE925
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005C6C RID: 23660 RVA: 0x000E0730 File Offset: 0x000DE930
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.markInfo_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.MarkInfo);
			}
			if (this.ChangeType != DarkTideMapMarkChangeType.DarkTideMapMarkAdd)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.ChangeType);
			}
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.PlayerId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005C6D RID: 23661 RVA: 0x000E07A8 File Offset: 0x000DE9A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PlayerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerId);
			}
			if (this.ChangeType != DarkTideMapMarkChangeType.DarkTideMapMarkAdd)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ChangeType);
			}
			if (this.markInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.MarkInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005C6E RID: 23662 RVA: 0x000E0818 File Offset: 0x000DEA18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DarkTideMapMarkUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PlayerId != 0)
			{
				this.PlayerId = other.PlayerId;
			}
			if (other.ChangeType != DarkTideMapMarkChangeType.DarkTideMapMarkAdd)
			{
				this.ChangeType = other.ChangeType;
			}
			if (other.markInfo_ != null)
			{
				if (this.markInfo_ == null)
				{
					this.MarkInfo = new DarkTideMarkInfo();
				}
				this.MarkInfo.MergeFrom(other.MarkInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005C6F RID: 23663 RVA: 0x000E0894 File Offset: 0x000DEA94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005C70 RID: 23664 RVA: 0x000E08A0 File Offset: 0x000DEAA0
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
				if (num != 18U)
				{
					if (num != 32U)
					{
						if (num != 112U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.PlayerId = input.ReadInt32();
						}
					}
					else
					{
						this.ChangeType = (DarkTideMapMarkChangeType)input.ReadEnum();
					}
				}
				else
				{
					if (this.markInfo_ == null)
					{
						this.MarkInfo = new DarkTideMarkInfo();
					}
					input.ReadMessage(this.MarkInfo);
				}
			}
		}

		// Token: 0x0400363F RID: 13887
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003640 RID: 13888
		public const int PlayerIdFieldNumber = 14;

		// Token: 0x04003641 RID: 13889
		private int playerId_;

		// Token: 0x04003642 RID: 13890
		public const int ChangeTypeFieldNumber = 4;

		// Token: 0x04003643 RID: 13891
		private DarkTideMapMarkChangeType changeType_;

		// Token: 0x04003644 RID: 13892
		public const int MarkInfoFieldNumber = 2;

		// Token: 0x04003645 RID: 13893
		private DarkTideMarkInfo markInfo_;
	}
}
