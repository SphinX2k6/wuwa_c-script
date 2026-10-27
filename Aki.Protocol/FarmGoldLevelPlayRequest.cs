using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000524 RID: 1316
	[NetMessage(EMessageId.FarmGoldLevelPlayRequest)]
	public sealed class FarmGoldLevelPlayRequest : IMessage<FarmGoldLevelPlayRequest>, IMessage, IEquatable<FarmGoldLevelPlayRequest>, IDeepCloneable<FarmGoldLevelPlayRequest>, IBufferMessage
	{
		// Token: 0x06007B80 RID: 31616 RVA: 0x0012B989 File Offset: 0x00129B89
		[NullableContext(1)]
		public static FarmGoldLevelPlayRequest Create()
		{
			return new FarmGoldLevelPlayRequest();
		}

		// Token: 0x170017F6 RID: 6134
		// (get) Token: 0x06007B81 RID: 31617 RVA: 0x0012B990 File Offset: 0x00129B90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170017F7 RID: 6135
		// (get) Token: 0x06007B82 RID: 31618 RVA: 0x0012B993 File Offset: 0x00129B93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FarmGoldLevelPlayRequest.Descriptor;
			}
		}

		// Token: 0x06007B83 RID: 31619 RVA: 0x0012B99A File Offset: 0x00129B9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FarmGoldLevelPlayRequest()
		{
		}

		// Token: 0x06007B84 RID: 31620 RVA: 0x0012B9A2 File Offset: 0x00129BA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FarmGoldLevelPlayRequest(FarmGoldLevelPlayRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.instId_ = other.instId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007B85 RID: 31621 RVA: 0x0012B9D3 File Offset: 0x00129BD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FarmGoldLevelPlayRequest Clone()
		{
			return new FarmGoldLevelPlayRequest(this);
		}

		// Token: 0x170017F8 RID: 6136
		// (get) Token: 0x06007B86 RID: 31622 RVA: 0x0012B9DB File Offset: 0x00129BDB
		// (set) Token: 0x06007B87 RID: 31623 RVA: 0x0012B9E3 File Offset: 0x00129BE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ActivityId
		{
			get
			{
				return this.activityId_;
			}
			set
			{
				this.activityId_ = value;
			}
		}

		// Token: 0x170017F9 RID: 6137
		// (get) Token: 0x06007B88 RID: 31624 RVA: 0x0012B9EC File Offset: 0x00129BEC
		// (set) Token: 0x06007B89 RID: 31625 RVA: 0x0012B9F4 File Offset: 0x00129BF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int InstId
		{
			get
			{
				return this.instId_;
			}
			set
			{
				this.instId_ = value;
			}
		}

		// Token: 0x06007B8A RID: 31626 RVA: 0x0012B9FD File Offset: 0x00129BFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FarmGoldLevelPlayRequest);
		}

		// Token: 0x06007B8B RID: 31627 RVA: 0x0012BA0B File Offset: 0x00129C0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FarmGoldLevelPlayRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.InstId == other.InstId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007B8C RID: 31628 RVA: 0x0012BA4C File Offset: 0x00129C4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this.InstId != 0)
			{
				num ^= this.InstId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007B8D RID: 31629 RVA: 0x0012BAA4 File Offset: 0x00129CA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007B8E RID: 31630 RVA: 0x0012BAB1 File Offset: 0x00129CB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007B8F RID: 31631 RVA: 0x0012BABC File Offset: 0x00129CBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.InstId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.InstId);
			}
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007B90 RID: 31632 RVA: 0x0012BB18 File Offset: 0x00129D18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this.InstId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.InstId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007B91 RID: 31633 RVA: 0x0012BB70 File Offset: 0x00129D70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FarmGoldLevelPlayRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			if (other.InstId != 0)
			{
				this.InstId = other.InstId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007B92 RID: 31634 RVA: 0x0012BBC0 File Offset: 0x00129DC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007B93 RID: 31635 RVA: 0x0012BBCC File Offset: 0x00129DCC
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
				if (num != 56U)
				{
					if (num != 80U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ActivityId = input.ReadInt32();
					}
				}
				else
				{
					this.InstId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04003F33 RID: 16179
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003F34 RID: 16180
		public const int ActivityIdFieldNumber = 10;

		// Token: 0x04003F35 RID: 16181
		private int activityId_;

		// Token: 0x04003F36 RID: 16182
		public const int InstIdFieldNumber = 7;

		// Token: 0x04003F37 RID: 16183
		private int instId_;
	}
}
