using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000248 RID: 584
	[NetMessage(EMessageId.ChangeDataLayerFinishRequest)]
	public sealed class ChangeDataLayerFinishRequest : IMessage<ChangeDataLayerFinishRequest>, IMessage, IEquatable<ChangeDataLayerFinishRequest>, IDeepCloneable<ChangeDataLayerFinishRequest>, IBufferMessage
	{
		// Token: 0x06003E83 RID: 16003 RVA: 0x0009A461 File Offset: 0x00098661
		[NullableContext(1)]
		public static ChangeDataLayerFinishRequest Create()
		{
			return new ChangeDataLayerFinishRequest();
		}

		// Token: 0x17000A72 RID: 2674
		// (get) Token: 0x06003E84 RID: 16004 RVA: 0x0009A468 File Offset: 0x00098668
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000A73 RID: 2675
		// (get) Token: 0x06003E85 RID: 16005 RVA: 0x0009A46B File Offset: 0x0009866B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChangeDataLayerFinishRequest.Descriptor;
			}
		}

		// Token: 0x06003E86 RID: 16006 RVA: 0x0009A472 File Offset: 0x00098672
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeDataLayerFinishRequest()
		{
		}

		// Token: 0x06003E87 RID: 16007 RVA: 0x0009A47A File Offset: 0x0009867A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeDataLayerFinishRequest(ChangeDataLayerFinishRequest other) : this()
		{
			this.instId_ = other.instId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003E88 RID: 16008 RVA: 0x0009A49F File Offset: 0x0009869F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeDataLayerFinishRequest Clone()
		{
			return new ChangeDataLayerFinishRequest(this);
		}

		// Token: 0x17000A74 RID: 2676
		// (get) Token: 0x06003E89 RID: 16009 RVA: 0x0009A4A7 File Offset: 0x000986A7
		// (set) Token: 0x06003E8A RID: 16010 RVA: 0x0009A4AF File Offset: 0x000986AF
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

		// Token: 0x06003E8B RID: 16011 RVA: 0x0009A4B8 File Offset: 0x000986B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChangeDataLayerFinishRequest);
		}

		// Token: 0x06003E8C RID: 16012 RVA: 0x0009A4C6 File Offset: 0x000986C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChangeDataLayerFinishRequest other)
		{
			return other != null && (other == this || (this.InstId == other.InstId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003E8D RID: 16013 RVA: 0x0009A4F4 File Offset: 0x000986F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
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

		// Token: 0x06003E8E RID: 16014 RVA: 0x0009A533 File Offset: 0x00098733
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003E8F RID: 16015 RVA: 0x0009A540 File Offset: 0x00098740
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003E90 RID: 16016 RVA: 0x0009A549 File Offset: 0x00098749
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.InstId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.InstId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003E91 RID: 16017 RVA: 0x0009A57C File Offset: 0x0009877C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
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

		// Token: 0x06003E92 RID: 16018 RVA: 0x0009A5BA File Offset: 0x000987BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChangeDataLayerFinishRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.InstId != 0)
			{
				this.InstId = other.InstId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003E93 RID: 16019 RVA: 0x0009A5EB File Offset: 0x000987EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003E94 RID: 16020 RVA: 0x0009A5F4 File Offset: 0x000987F4
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
				if (num != 64U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.InstId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04002CE8 RID: 11496
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002CE9 RID: 11497
		public const int InstIdFieldNumber = 8;

		// Token: 0x04002CEA RID: 11498
		private int instId_;
	}
}
