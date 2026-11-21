using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006A4 RID: 1700
	[NetMessage(EMessageId.GatherActivityRewardRequest)]
	public sealed class GatherActivityRewardRequest : IMessage<GatherActivityRewardRequest>, IMessage, IEquatable<GatherActivityRewardRequest>, IDeepCloneable<GatherActivityRewardRequest>, IBufferMessage
	{
		// Token: 0x06009C40 RID: 40000 RVA: 0x0017C539 File Offset: 0x0017A739
		[NullableContext(1)]
		public static GatherActivityRewardRequest Create()
		{
			return new GatherActivityRewardRequest();
		}

		// Token: 0x17001F63 RID: 8035
		// (get) Token: 0x06009C41 RID: 40001 RVA: 0x0017C540 File Offset: 0x0017A740
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001F64 RID: 8036
		// (get) Token: 0x06009C42 RID: 40002 RVA: 0x0017C543 File Offset: 0x0017A743
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GatherActivityRewardRequest.Descriptor;
			}
		}

		// Token: 0x06009C43 RID: 40003 RVA: 0x0017C54A File Offset: 0x0017A74A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GatherActivityRewardRequest()
		{
		}

		// Token: 0x06009C44 RID: 40004 RVA: 0x0017C552 File Offset: 0x0017A752
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GatherActivityRewardRequest(GatherActivityRewardRequest other) : this()
		{
			this.gatherTaskId_ = other.gatherTaskId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009C45 RID: 40005 RVA: 0x0017C577 File Offset: 0x0017A777
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GatherActivityRewardRequest Clone()
		{
			return new GatherActivityRewardRequest(this);
		}

		// Token: 0x17001F65 RID: 8037
		// (get) Token: 0x06009C46 RID: 40006 RVA: 0x0017C57F File Offset: 0x0017A77F
		// (set) Token: 0x06009C47 RID: 40007 RVA: 0x0017C587 File Offset: 0x0017A787
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int GatherTaskId
		{
			get
			{
				return this.gatherTaskId_;
			}
			set
			{
				this.gatherTaskId_ = value;
			}
		}

		// Token: 0x06009C48 RID: 40008 RVA: 0x0017C590 File Offset: 0x0017A790
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GatherActivityRewardRequest);
		}

		// Token: 0x06009C49 RID: 40009 RVA: 0x0017C59E File Offset: 0x0017A79E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GatherActivityRewardRequest other)
		{
			return other != null && (other == this || (this.GatherTaskId == other.GatherTaskId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009C4A RID: 40010 RVA: 0x0017C5CC File Offset: 0x0017A7CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.GatherTaskId != 0)
			{
				num ^= this.GatherTaskId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009C4B RID: 40011 RVA: 0x0017C60B File Offset: 0x0017A80B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009C4C RID: 40012 RVA: 0x0017C618 File Offset: 0x0017A818
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009C4D RID: 40013 RVA: 0x0017C621 File Offset: 0x0017A821
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.GatherTaskId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.GatherTaskId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009C4E RID: 40014 RVA: 0x0017C654 File Offset: 0x0017A854
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.GatherTaskId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.GatherTaskId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009C4F RID: 40015 RVA: 0x0017C692 File Offset: 0x0017A892
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GatherActivityRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.GatherTaskId != 0)
			{
				this.GatherTaskId = other.GatherTaskId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009C50 RID: 40016 RVA: 0x0017C6C3 File Offset: 0x0017A8C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009C51 RID: 40017 RVA: 0x0017C6CC File Offset: 0x0017A8CC
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.GatherTaskId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040049F9 RID: 18937
		private UnknownFieldSet _unknownFields;

		// Token: 0x040049FA RID: 18938
		public const int GatherTaskIdFieldNumber = 7;

		// Token: 0x040049FB RID: 18939
		private int gatherTaskId_;
	}
}
