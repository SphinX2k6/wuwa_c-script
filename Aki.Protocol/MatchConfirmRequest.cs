using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009A7 RID: 2471
	[NetMessage(EMessageId.MatchConfirmRequest)]
	public sealed class MatchConfirmRequest : IMessage<MatchConfirmRequest>, IMessage, IEquatable<MatchConfirmRequest>, IDeepCloneable<MatchConfirmRequest>, IBufferMessage
	{
		// Token: 0x0600D931 RID: 55601 RVA: 0x001FEAE9 File Offset: 0x001FCCE9
		[NullableContext(1)]
		public static MatchConfirmRequest Create()
		{
			return new MatchConfirmRequest();
		}

		// Token: 0x17002BF7 RID: 11255
		// (get) Token: 0x0600D932 RID: 55602 RVA: 0x001FEAF0 File Offset: 0x001FCCF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002BF8 RID: 11256
		// (get) Token: 0x0600D933 RID: 55603 RVA: 0x001FEAF3 File Offset: 0x001FCCF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MatchConfirmRequest.Descriptor;
			}
		}

		// Token: 0x0600D934 RID: 55604 RVA: 0x001FEAFA File Offset: 0x001FCCFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchConfirmRequest()
		{
		}

		// Token: 0x0600D935 RID: 55605 RVA: 0x001FEB02 File Offset: 0x001FCD02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchConfirmRequest(MatchConfirmRequest other) : this()
		{
			this.isAccept_ = other.isAccept_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D936 RID: 55606 RVA: 0x001FEB27 File Offset: 0x001FCD27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchConfirmRequest Clone()
		{
			return new MatchConfirmRequest(this);
		}

		// Token: 0x17002BF9 RID: 11257
		// (get) Token: 0x0600D937 RID: 55607 RVA: 0x001FEB2F File Offset: 0x001FCD2F
		// (set) Token: 0x0600D938 RID: 55608 RVA: 0x001FEB37 File Offset: 0x001FCD37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsAccept
		{
			get
			{
				return this.isAccept_;
			}
			set
			{
				this.isAccept_ = value;
			}
		}

		// Token: 0x0600D939 RID: 55609 RVA: 0x001FEB40 File Offset: 0x001FCD40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MatchConfirmRequest);
		}

		// Token: 0x0600D93A RID: 55610 RVA: 0x001FEB4E File Offset: 0x001FCD4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MatchConfirmRequest other)
		{
			return other != null && (other == this || (this.IsAccept == other.IsAccept && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D93B RID: 55611 RVA: 0x001FEB7C File Offset: 0x001FCD7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IsAccept)
			{
				num ^= this.IsAccept.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D93C RID: 55612 RVA: 0x001FEBBB File Offset: 0x001FCDBB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D93D RID: 55613 RVA: 0x001FEBC8 File Offset: 0x001FCDC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D93E RID: 55614 RVA: 0x001FEBD1 File Offset: 0x001FCDD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsAccept)
			{
				output.WriteRawTag(64);
				output.WriteBool(this.IsAccept);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D93F RID: 55615 RVA: 0x001FEC04 File Offset: 0x001FCE04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IsAccept)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D940 RID: 55616 RVA: 0x001FEC36 File Offset: 0x001FCE36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MatchConfirmRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IsAccept)
			{
				this.IsAccept = other.IsAccept;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D941 RID: 55617 RVA: 0x001FEC67 File Offset: 0x001FCE67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D942 RID: 55618 RVA: 0x001FEC70 File Offset: 0x001FCE70
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
					this.IsAccept = input.ReadBool();
				}
			}
		}

		// Token: 0x04005AB5 RID: 23221
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005AB6 RID: 23222
		public const int IsAcceptFieldNumber = 8;

		// Token: 0x04005AB7 RID: 23223
		private bool isAccept_;
	}
}
