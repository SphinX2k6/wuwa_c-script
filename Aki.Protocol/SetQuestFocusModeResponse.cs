using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011DD RID: 4573
	[NetMessage(EMessageId.SetQuestFocusModeResponse)]
	public sealed class SetQuestFocusModeResponse : IMessage<SetQuestFocusModeResponse>, IMessage, IEquatable<SetQuestFocusModeResponse>, IDeepCloneable<SetQuestFocusModeResponse>, IBufferMessage
	{
		// Token: 0x06018614 RID: 99860 RVA: 0x0038BA39 File Offset: 0x00389C39
		[NullableContext(1)]
		public static SetQuestFocusModeResponse Create()
		{
			return new SetQuestFocusModeResponse();
		}

		// Token: 0x17005213 RID: 21011
		// (get) Token: 0x06018615 RID: 99861 RVA: 0x0038BA40 File Offset: 0x00389C40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005214 RID: 21012
		// (get) Token: 0x06018616 RID: 99862 RVA: 0x0038BA43 File Offset: 0x00389C43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SetQuestFocusModeResponse.Descriptor;
			}
		}

		// Token: 0x06018617 RID: 99863 RVA: 0x0038BA4A File Offset: 0x00389C4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetQuestFocusModeResponse()
		{
		}

		// Token: 0x06018618 RID: 99864 RVA: 0x0038BA52 File Offset: 0x00389C52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetQuestFocusModeResponse(SetQuestFocusModeResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018619 RID: 99865 RVA: 0x0038BA77 File Offset: 0x00389C77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetQuestFocusModeResponse Clone()
		{
			return new SetQuestFocusModeResponse(this);
		}

		// Token: 0x17005215 RID: 21013
		// (get) Token: 0x0601861A RID: 99866 RVA: 0x0038BA7F File Offset: 0x00389C7F
		// (set) Token: 0x0601861B RID: 99867 RVA: 0x0038BA87 File Offset: 0x00389C87
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

		// Token: 0x0601861C RID: 99868 RVA: 0x0038BA90 File Offset: 0x00389C90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SetQuestFocusModeResponse);
		}

		// Token: 0x0601861D RID: 99869 RVA: 0x0038BA9E File Offset: 0x00389C9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SetQuestFocusModeResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601861E RID: 99870 RVA: 0x0038BACC File Offset: 0x00389CCC
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

		// Token: 0x0601861F RID: 99871 RVA: 0x0038BB11 File Offset: 0x00389D11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018620 RID: 99872 RVA: 0x0038BB1E File Offset: 0x00389D1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018621 RID: 99873 RVA: 0x0038BB27 File Offset: 0x00389D27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(72);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018622 RID: 99874 RVA: 0x0038BB5C File Offset: 0x00389D5C
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

		// Token: 0x06018623 RID: 99875 RVA: 0x0038BB9A File Offset: 0x00389D9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SetQuestFocusModeResponse other)
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

		// Token: 0x06018624 RID: 99876 RVA: 0x0038BBCB File Offset: 0x00389DCB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018625 RID: 99877 RVA: 0x0038BBD4 File Offset: 0x00389DD4
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
				if (num != 72U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04009031 RID: 36913
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009032 RID: 36914
		public const int ErrorCodeFieldNumber = 9;

		// Token: 0x04009033 RID: 36915
		private ErrorCode errorCode_;
	}
}
