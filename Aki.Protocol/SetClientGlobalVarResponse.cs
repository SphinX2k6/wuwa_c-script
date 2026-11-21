using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001208 RID: 4616
	[NetMessage(EMessageId.SetClientGlobalVarResponse)]
	public sealed class SetClientGlobalVarResponse : IMessage<SetClientGlobalVarResponse>, IMessage, IEquatable<SetClientGlobalVarResponse>, IDeepCloneable<SetClientGlobalVarResponse>, IBufferMessage
	{
		// Token: 0x06018A9F RID: 101023 RVA: 0x00398E5F File Offset: 0x0039705F
		[NullableContext(1)]
		public static SetClientGlobalVarResponse Create()
		{
			return new SetClientGlobalVarResponse();
		}

		// Token: 0x1700534E RID: 21326
		// (get) Token: 0x06018AA0 RID: 101024 RVA: 0x00398E66 File Offset: 0x00397066
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700534F RID: 21327
		// (get) Token: 0x06018AA1 RID: 101025 RVA: 0x00398E69 File Offset: 0x00397069
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SetClientGlobalVarResponse.Descriptor;
			}
		}

		// Token: 0x06018AA2 RID: 101026 RVA: 0x00398E70 File Offset: 0x00397070
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetClientGlobalVarResponse()
		{
		}

		// Token: 0x06018AA3 RID: 101027 RVA: 0x00398E78 File Offset: 0x00397078
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetClientGlobalVarResponse(SetClientGlobalVarResponse other) : this()
		{
			this.errorId_ = other.errorId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018AA4 RID: 101028 RVA: 0x00398E9D File Offset: 0x0039709D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetClientGlobalVarResponse Clone()
		{
			return new SetClientGlobalVarResponse(this);
		}

		// Token: 0x17005350 RID: 21328
		// (get) Token: 0x06018AA5 RID: 101029 RVA: 0x00398EA5 File Offset: 0x003970A5
		// (set) Token: 0x06018AA6 RID: 101030 RVA: 0x00398EAD File Offset: 0x003970AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorId
		{
			get
			{
				return this.errorId_;
			}
			set
			{
				this.errorId_ = value;
			}
		}

		// Token: 0x06018AA7 RID: 101031 RVA: 0x00398EB6 File Offset: 0x003970B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SetClientGlobalVarResponse);
		}

		// Token: 0x06018AA8 RID: 101032 RVA: 0x00398EC4 File Offset: 0x003970C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SetClientGlobalVarResponse other)
		{
			return other != null && (other == this || (this.ErrorId == other.ErrorId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018AA9 RID: 101033 RVA: 0x00398EF4 File Offset: 0x003970F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorId != ErrorCode.Success)
			{
				num ^= this.ErrorId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06018AAA RID: 101034 RVA: 0x00398F39 File Offset: 0x00397139
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018AAB RID: 101035 RVA: 0x00398F46 File Offset: 0x00397146
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018AAC RID: 101036 RVA: 0x00398F4F File Offset: 0x0039714F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorId != ErrorCode.Success)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.ErrorId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018AAD RID: 101037 RVA: 0x00398F84 File Offset: 0x00397184
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorId != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06018AAE RID: 101038 RVA: 0x00398FC2 File Offset: 0x003971C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SetClientGlobalVarResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorId != ErrorCode.Success)
			{
				this.ErrorId = other.ErrorId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06018AAF RID: 101039 RVA: 0x00398FF3 File Offset: 0x003971F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018AB0 RID: 101040 RVA: 0x00398FFC File Offset: 0x003971FC
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
					this.ErrorId = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400928F RID: 37519
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009290 RID: 37520
		public const int ErrorIdFieldNumber = 8;

		// Token: 0x04009291 RID: 37521
		private ErrorCode errorId_;
	}
}
