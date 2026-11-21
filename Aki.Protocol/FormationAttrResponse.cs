using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000614 RID: 1556
	[NetMessage(EMessageId.FormationAttrResponse)]
	public sealed class FormationAttrResponse : IMessage<FormationAttrResponse>, IMessage, IEquatable<FormationAttrResponse>, IDeepCloneable<FormationAttrResponse>, IBufferMessage
	{
		// Token: 0x0600900C RID: 36876 RVA: 0x0015D438 File Offset: 0x0015B638
		[NullableContext(1)]
		public static FormationAttrResponse Create()
		{
			return new FormationAttrResponse();
		}

		// Token: 0x17001C9D RID: 7325
		// (get) Token: 0x0600900D RID: 36877 RVA: 0x0015D43F File Offset: 0x0015B63F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001C9E RID: 7326
		// (get) Token: 0x0600900E RID: 36878 RVA: 0x0015D442 File Offset: 0x0015B642
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FormationAttrResponse.Descriptor;
			}
		}

		// Token: 0x0600900F RID: 36879 RVA: 0x0015D449 File Offset: 0x0015B649
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FormationAttrResponse()
		{
		}

		// Token: 0x06009010 RID: 36880 RVA: 0x0015D451 File Offset: 0x0015B651
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FormationAttrResponse(FormationAttrResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009011 RID: 36881 RVA: 0x0015D476 File Offset: 0x0015B676
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FormationAttrResponse Clone()
		{
			return new FormationAttrResponse(this);
		}

		// Token: 0x17001C9F RID: 7327
		// (get) Token: 0x06009012 RID: 36882 RVA: 0x0015D47E File Offset: 0x0015B67E
		// (set) Token: 0x06009013 RID: 36883 RVA: 0x0015D486 File Offset: 0x0015B686
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x06009014 RID: 36884 RVA: 0x0015D48F File Offset: 0x0015B68F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FormationAttrResponse);
		}

		// Token: 0x06009015 RID: 36885 RVA: 0x0015D49D File Offset: 0x0015B69D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FormationAttrResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009016 RID: 36886 RVA: 0x0015D4CC File Offset: 0x0015B6CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009017 RID: 36887 RVA: 0x0015D511 File Offset: 0x0015B711
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009018 RID: 36888 RVA: 0x0015D51E File Offset: 0x0015B71E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009019 RID: 36889 RVA: 0x0015D527 File Offset: 0x0015B727
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600901A RID: 36890 RVA: 0x0015D55C File Offset: 0x0015B75C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600901B RID: 36891 RVA: 0x0015D59A File Offset: 0x0015B79A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FormationAttrResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600901C RID: 36892 RVA: 0x0015D5CB File Offset: 0x0015B7CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600901D RID: 36893 RVA: 0x0015D5D4 File Offset: 0x0015B7D4
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
				if (num != 80U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400463C RID: 17980
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400463D RID: 17981
		public const int ErrorCodeFieldNumber = 10;

		// Token: 0x0400463E RID: 17982
		private ErrorCode errorCode_;
	}
}
