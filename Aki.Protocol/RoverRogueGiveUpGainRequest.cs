using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200113B RID: 4411
	[NetMessage(EMessageId.RoverRogueGiveUpGainRequest)]
	public sealed class RoverRogueGiveUpGainRequest : IMessage<RoverRogueGiveUpGainRequest>, IMessage, IEquatable<RoverRogueGiveUpGainRequest>, IDeepCloneable<RoverRogueGiveUpGainRequest>, IBufferMessage
	{
		// Token: 0x06017908 RID: 96520 RVA: 0x0036DBC6 File Offset: 0x0036BDC6
		[NullableContext(1)]
		public static RoverRogueGiveUpGainRequest Create()
		{
			return new RoverRogueGiveUpGainRequest();
		}

		// Token: 0x17004F38 RID: 20280
		// (get) Token: 0x06017909 RID: 96521 RVA: 0x0036DBCD File Offset: 0x0036BDCD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004F39 RID: 20281
		// (get) Token: 0x0601790A RID: 96522 RVA: 0x0036DBD0 File Offset: 0x0036BDD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoverRogueGiveUpGainRequest.Descriptor;
			}
		}

		// Token: 0x0601790B RID: 96523 RVA: 0x0036DBD7 File Offset: 0x0036BDD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueGiveUpGainRequest()
		{
		}

		// Token: 0x0601790C RID: 96524 RVA: 0x0036DBDF File Offset: 0x0036BDDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueGiveUpGainRequest(RoverRogueGiveUpGainRequest other) : this()
		{
			this.bindId_ = other.bindId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601790D RID: 96525 RVA: 0x0036DC04 File Offset: 0x0036BE04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueGiveUpGainRequest Clone()
		{
			return new RoverRogueGiveUpGainRequest(this);
		}

		// Token: 0x17004F3A RID: 20282
		// (get) Token: 0x0601790E RID: 96526 RVA: 0x0036DC0C File Offset: 0x0036BE0C
		// (set) Token: 0x0601790F RID: 96527 RVA: 0x0036DC14 File Offset: 0x0036BE14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BindId
		{
			get
			{
				return this.bindId_;
			}
			set
			{
				this.bindId_ = value;
			}
		}

		// Token: 0x06017910 RID: 96528 RVA: 0x0036DC1D File Offset: 0x0036BE1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoverRogueGiveUpGainRequest);
		}

		// Token: 0x06017911 RID: 96529 RVA: 0x0036DC2B File Offset: 0x0036BE2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoverRogueGiveUpGainRequest other)
		{
			return other != null && (other == this || (this.BindId == other.BindId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017912 RID: 96530 RVA: 0x0036DC5C File Offset: 0x0036BE5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.BindId != 0)
			{
				num ^= this.BindId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06017913 RID: 96531 RVA: 0x0036DC9B File Offset: 0x0036BE9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017914 RID: 96532 RVA: 0x0036DCA8 File Offset: 0x0036BEA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017915 RID: 96533 RVA: 0x0036DCB1 File Offset: 0x0036BEB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.BindId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.BindId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017916 RID: 96534 RVA: 0x0036DCE4 File Offset: 0x0036BEE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.BindId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BindId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06017917 RID: 96535 RVA: 0x0036DD22 File Offset: 0x0036BF22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoverRogueGiveUpGainRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.BindId != 0)
			{
				this.BindId = other.BindId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06017918 RID: 96536 RVA: 0x0036DD53 File Offset: 0x0036BF53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017919 RID: 96537 RVA: 0x0036DD5C File Offset: 0x0036BF5C
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
				if (num != 16U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.BindId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04008CA3 RID: 36003
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008CA4 RID: 36004
		public const int BindIdFieldNumber = 2;

		// Token: 0x04008CA5 RID: 36005
		private int bindId_;
	}
}
