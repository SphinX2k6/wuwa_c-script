using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009B1 RID: 2481
	[NetMessage(EMessageId.MatchChangeReadyRequest)]
	public sealed class MatchChangeReadyRequest : IMessage<MatchChangeReadyRequest>, IMessage, IEquatable<MatchChangeReadyRequest>, IDeepCloneable<MatchChangeReadyRequest>, IBufferMessage
	{
		// Token: 0x0600D9C5 RID: 55749 RVA: 0x001FFBF4 File Offset: 0x001FDDF4
		[NullableContext(1)]
		public static MatchChangeReadyRequest Create()
		{
			return new MatchChangeReadyRequest();
		}

		// Token: 0x17002C1B RID: 11291
		// (get) Token: 0x0600D9C6 RID: 55750 RVA: 0x001FFBFB File Offset: 0x001FDDFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002C1C RID: 11292
		// (get) Token: 0x0600D9C7 RID: 55751 RVA: 0x001FFBFE File Offset: 0x001FDDFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MatchChangeReadyRequest.Descriptor;
			}
		}

		// Token: 0x0600D9C8 RID: 55752 RVA: 0x001FFC05 File Offset: 0x001FDE05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchChangeReadyRequest()
		{
		}

		// Token: 0x0600D9C9 RID: 55753 RVA: 0x001FFC0D File Offset: 0x001FDE0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchChangeReadyRequest(MatchChangeReadyRequest other) : this()
		{
			this.isReady_ = other.isReady_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D9CA RID: 55754 RVA: 0x001FFC32 File Offset: 0x001FDE32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchChangeReadyRequest Clone()
		{
			return new MatchChangeReadyRequest(this);
		}

		// Token: 0x17002C1D RID: 11293
		// (get) Token: 0x0600D9CB RID: 55755 RVA: 0x001FFC3A File Offset: 0x001FDE3A
		// (set) Token: 0x0600D9CC RID: 55756 RVA: 0x001FFC42 File Offset: 0x001FDE42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsReady
		{
			get
			{
				return this.isReady_;
			}
			set
			{
				this.isReady_ = value;
			}
		}

		// Token: 0x0600D9CD RID: 55757 RVA: 0x001FFC4B File Offset: 0x001FDE4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MatchChangeReadyRequest);
		}

		// Token: 0x0600D9CE RID: 55758 RVA: 0x001FFC59 File Offset: 0x001FDE59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MatchChangeReadyRequest other)
		{
			return other != null && (other == this || (this.IsReady == other.IsReady && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D9CF RID: 55759 RVA: 0x001FFC88 File Offset: 0x001FDE88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IsReady)
			{
				num ^= this.IsReady.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D9D0 RID: 55760 RVA: 0x001FFCC7 File Offset: 0x001FDEC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D9D1 RID: 55761 RVA: 0x001FFCD4 File Offset: 0x001FDED4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D9D2 RID: 55762 RVA: 0x001FFCDD File Offset: 0x001FDEDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsReady)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.IsReady);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D9D3 RID: 55763 RVA: 0x001FFD10 File Offset: 0x001FDF10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IsReady)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D9D4 RID: 55764 RVA: 0x001FFD42 File Offset: 0x001FDF42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MatchChangeReadyRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IsReady)
			{
				this.IsReady = other.IsReady;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D9D5 RID: 55765 RVA: 0x001FFD73 File Offset: 0x001FDF73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D9D6 RID: 55766 RVA: 0x001FFD7C File Offset: 0x001FDF7C
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
				if (num != 24U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.IsReady = input.ReadBool();
				}
			}
		}

		// Token: 0x04005A8A RID: 23178
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005A8B RID: 23179
		public const int IsReadyFieldNumber = 3;

		// Token: 0x04005A8C RID: 23180
		private bool isReady_;
	}
}
