using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001086 RID: 4230
	[NetMessage(EMessageId.RoleIllustratedInfoRequest)]
	public sealed class RoleIllustratedInfoRequest : IMessage<RoleIllustratedInfoRequest>, IMessage, IEquatable<RoleIllustratedInfoRequest>, IDeepCloneable<RoleIllustratedInfoRequest>, IBufferMessage
	{
		// Token: 0x0601697E RID: 92542 RVA: 0x003485B3 File Offset: 0x003467B3
		[NullableContext(1)]
		public static RoleIllustratedInfoRequest Create()
		{
			return new RoleIllustratedInfoRequest();
		}

		// Token: 0x17004BA1 RID: 19361
		// (get) Token: 0x0601697F RID: 92543 RVA: 0x003485BA File Offset: 0x003467BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004BA2 RID: 19362
		// (get) Token: 0x06016980 RID: 92544 RVA: 0x003485BD File Offset: 0x003467BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleIllustratedInfoRequest.Descriptor;
			}
		}

		// Token: 0x06016981 RID: 92545 RVA: 0x003485C4 File Offset: 0x003467C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleIllustratedInfoRequest()
		{
		}

		// Token: 0x06016982 RID: 92546 RVA: 0x003485CC File Offset: 0x003467CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleIllustratedInfoRequest(RoleIllustratedInfoRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016983 RID: 92547 RVA: 0x003485E5 File Offset: 0x003467E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleIllustratedInfoRequest Clone()
		{
			return new RoleIllustratedInfoRequest(this);
		}

		// Token: 0x06016984 RID: 92548 RVA: 0x003485ED File Offset: 0x003467ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleIllustratedInfoRequest);
		}

		// Token: 0x06016985 RID: 92549 RVA: 0x003485FB File Offset: 0x003467FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleIllustratedInfoRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06016986 RID: 92550 RVA: 0x0034861C File Offset: 0x0034681C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06016987 RID: 92551 RVA: 0x00348642 File Offset: 0x00346842
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016988 RID: 92552 RVA: 0x0034864F File Offset: 0x0034684F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016989 RID: 92553 RVA: 0x00348658 File Offset: 0x00346858
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601698A RID: 92554 RVA: 0x00348670 File Offset: 0x00346870
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601698B RID: 92555 RVA: 0x00348696 File Offset: 0x00346896
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleIllustratedInfoRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601698C RID: 92556 RVA: 0x003486B3 File Offset: 0x003468B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601698D RID: 92557 RVA: 0x003486BC File Offset: 0x003468BC
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
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040086EF RID: 34543
		private UnknownFieldSet _unknownFields;
	}
}
