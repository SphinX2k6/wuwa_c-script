using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200152F RID: 5423
	[NetMessage(EMessageId.XboxSettingUpdateResponse)]
	public sealed class XboxSettingUpdateResponse : IMessage<XboxSettingUpdateResponse>, IMessage, IEquatable<XboxSettingUpdateResponse>, IDeepCloneable<XboxSettingUpdateResponse>, IBufferMessage
	{
		// Token: 0x0601CA72 RID: 117362 RVA: 0x00422FA1 File Offset: 0x004211A1
		[NullableContext(1)]
		public static XboxSettingUpdateResponse Create()
		{
			return new XboxSettingUpdateResponse();
		}

		// Token: 0x17006096 RID: 24726
		// (get) Token: 0x0601CA73 RID: 117363 RVA: 0x00422FA8 File Offset: 0x004211A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17006097 RID: 24727
		// (get) Token: 0x0601CA74 RID: 117364 RVA: 0x00422FAB File Offset: 0x004211AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return XboxSettingUpdateResponse.Descriptor;
			}
		}

		// Token: 0x0601CA75 RID: 117365 RVA: 0x00422FB2 File Offset: 0x004211B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public XboxSettingUpdateResponse()
		{
		}

		// Token: 0x0601CA76 RID: 117366 RVA: 0x00422FBA File Offset: 0x004211BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public XboxSettingUpdateResponse(XboxSettingUpdateResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601CA77 RID: 117367 RVA: 0x00422FDF File Offset: 0x004211DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public XboxSettingUpdateResponse Clone()
		{
			return new XboxSettingUpdateResponse(this);
		}

		// Token: 0x17006098 RID: 24728
		// (get) Token: 0x0601CA78 RID: 117368 RVA: 0x00422FE7 File Offset: 0x004211E7
		// (set) Token: 0x0601CA79 RID: 117369 RVA: 0x00422FEF File Offset: 0x004211EF
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

		// Token: 0x0601CA7A RID: 117370 RVA: 0x00422FF8 File Offset: 0x004211F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as XboxSettingUpdateResponse);
		}

		// Token: 0x0601CA7B RID: 117371 RVA: 0x00423006 File Offset: 0x00421206
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(XboxSettingUpdateResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601CA7C RID: 117372 RVA: 0x00423034 File Offset: 0x00421234
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

		// Token: 0x0601CA7D RID: 117373 RVA: 0x00423079 File Offset: 0x00421279
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601CA7E RID: 117374 RVA: 0x00423086 File Offset: 0x00421286
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601CA7F RID: 117375 RVA: 0x0042308F File Offset: 0x0042128F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601CA80 RID: 117376 RVA: 0x004230C4 File Offset: 0x004212C4
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

		// Token: 0x0601CA81 RID: 117377 RVA: 0x00423102 File Offset: 0x00421302
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(XboxSettingUpdateResponse other)
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

		// Token: 0x0601CA82 RID: 117378 RVA: 0x00423133 File Offset: 0x00421333
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601CA83 RID: 117379 RVA: 0x0042313C File Offset: 0x0042133C
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
				if (num != 112U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400A3C5 RID: 41925
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A3C6 RID: 41926
		public const int ErrorCodeFieldNumber = 14;

		// Token: 0x0400A3C7 RID: 41927
		private ErrorCode errorCode_;
	}
}
