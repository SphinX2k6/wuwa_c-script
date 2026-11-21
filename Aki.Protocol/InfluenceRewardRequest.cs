using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007BE RID: 1982
	[NetMessage(EMessageId.InfluenceRewardRequest)]
	public sealed class InfluenceRewardRequest : IMessage<InfluenceRewardRequest>, IMessage, IEquatable<InfluenceRewardRequest>, IDeepCloneable<InfluenceRewardRequest>, IBufferMessage
	{
		// Token: 0x0600B29A RID: 45722 RVA: 0x001ABCE5 File Offset: 0x001A9EE5
		[NullableContext(1)]
		public static InfluenceRewardRequest Create()
		{
			return new InfluenceRewardRequest();
		}

		// Token: 0x17002404 RID: 9220
		// (get) Token: 0x0600B29B RID: 45723 RVA: 0x001ABCEC File Offset: 0x001A9EEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002405 RID: 9221
		// (get) Token: 0x0600B29C RID: 45724 RVA: 0x001ABCEF File Offset: 0x001A9EEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InfluenceRewardRequest.Descriptor;
			}
		}

		// Token: 0x0600B29D RID: 45725 RVA: 0x001ABCF6 File Offset: 0x001A9EF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfluenceRewardRequest()
		{
		}

		// Token: 0x0600B29E RID: 45726 RVA: 0x001ABCFE File Offset: 0x001A9EFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfluenceRewardRequest(InfluenceRewardRequest other) : this()
		{
			this.influenceId_ = other.influenceId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B29F RID: 45727 RVA: 0x001ABD23 File Offset: 0x001A9F23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfluenceRewardRequest Clone()
		{
			return new InfluenceRewardRequest(this);
		}

		// Token: 0x17002406 RID: 9222
		// (get) Token: 0x0600B2A0 RID: 45728 RVA: 0x001ABD2B File Offset: 0x001A9F2B
		// (set) Token: 0x0600B2A1 RID: 45729 RVA: 0x001ABD33 File Offset: 0x001A9F33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int InfluenceId
		{
			get
			{
				return this.influenceId_;
			}
			set
			{
				this.influenceId_ = value;
			}
		}

		// Token: 0x0600B2A2 RID: 45730 RVA: 0x001ABD3C File Offset: 0x001A9F3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InfluenceRewardRequest);
		}

		// Token: 0x0600B2A3 RID: 45731 RVA: 0x001ABD4A File Offset: 0x001A9F4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InfluenceRewardRequest other)
		{
			return other != null && (other == this || (this.InfluenceId == other.InfluenceId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B2A4 RID: 45732 RVA: 0x001ABD78 File Offset: 0x001A9F78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.InfluenceId != 0)
			{
				num ^= this.InfluenceId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B2A5 RID: 45733 RVA: 0x001ABDB7 File Offset: 0x001A9FB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B2A6 RID: 45734 RVA: 0x001ABDC4 File Offset: 0x001A9FC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B2A7 RID: 45735 RVA: 0x001ABDCD File Offset: 0x001A9FCD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.InfluenceId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.InfluenceId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B2A8 RID: 45736 RVA: 0x001ABE00 File Offset: 0x001AA000
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.InfluenceId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.InfluenceId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B2A9 RID: 45737 RVA: 0x001ABE3E File Offset: 0x001AA03E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InfluenceRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.InfluenceId != 0)
			{
				this.InfluenceId = other.InfluenceId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B2AA RID: 45738 RVA: 0x001ABE6F File Offset: 0x001AA06F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B2AB RID: 45739 RVA: 0x001ABE78 File Offset: 0x001AA078
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
				if (num != 48U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.InfluenceId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04005026 RID: 20518
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005027 RID: 20519
		public const int InfluenceIdFieldNumber = 6;

		// Token: 0x04005028 RID: 20520
		private int influenceId_;
	}
}
