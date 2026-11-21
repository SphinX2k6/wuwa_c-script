using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol.Ai
{
	// Token: 0x02001729 RID: 5929
	[NetMessage(EMessageId.AiControlSwitchResponse)]
	public sealed class AiControlSwitchResponse : IMessage<AiControlSwitchResponse>, IMessage, IEquatable<AiControlSwitchResponse>, IDeepCloneable<AiControlSwitchResponse>, IBufferMessage
	{
		// Token: 0x0601DC30 RID: 121904 RVA: 0x0045D721 File Offset: 0x0045B921
		[NullableContext(1)]
		public static AiControlSwitchResponse Create()
		{
			return new AiControlSwitchResponse();
		}

		// Token: 0x17006554 RID: 25940
		// (get) Token: 0x0601DC31 RID: 121905 RVA: 0x0045D728 File Offset: 0x0045B928
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17006555 RID: 25941
		// (get) Token: 0x0601DC32 RID: 121906 RVA: 0x0045D72B File Offset: 0x0045B92B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AiControlSwitchResponse.Descriptor;
			}
		}

		// Token: 0x0601DC33 RID: 121907 RVA: 0x0045D732 File Offset: 0x0045B932
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AiControlSwitchResponse()
		{
		}

		// Token: 0x0601DC34 RID: 121908 RVA: 0x0045D73A File Offset: 0x0045B93A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AiControlSwitchResponse(AiControlSwitchResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601DC35 RID: 121909 RVA: 0x0045D75F File Offset: 0x0045B95F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AiControlSwitchResponse Clone()
		{
			return new AiControlSwitchResponse(this);
		}

		// Token: 0x17006556 RID: 25942
		// (get) Token: 0x0601DC36 RID: 121910 RVA: 0x0045D767 File Offset: 0x0045B967
		// (set) Token: 0x0601DC37 RID: 121911 RVA: 0x0045D76F File Offset: 0x0045B96F
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

		// Token: 0x0601DC38 RID: 121912 RVA: 0x0045D778 File Offset: 0x0045B978
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AiControlSwitchResponse);
		}

		// Token: 0x0601DC39 RID: 121913 RVA: 0x0045D786 File Offset: 0x0045B986
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AiControlSwitchResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601DC3A RID: 121914 RVA: 0x0045D7B4 File Offset: 0x0045B9B4
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

		// Token: 0x0601DC3B RID: 121915 RVA: 0x0045D7F9 File Offset: 0x0045B9F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601DC3C RID: 121916 RVA: 0x0045D806 File Offset: 0x0045BA06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601DC3D RID: 121917 RVA: 0x0045D80F File Offset: 0x0045BA0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601DC3E RID: 121918 RVA: 0x0045D844 File Offset: 0x0045BA44
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

		// Token: 0x0601DC3F RID: 121919 RVA: 0x0045D882 File Offset: 0x0045BA82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AiControlSwitchResponse other)
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

		// Token: 0x0601DC40 RID: 121920 RVA: 0x0045D8B3 File Offset: 0x0045BAB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601DC41 RID: 121921 RVA: 0x0045D8BC File Offset: 0x0045BABC
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
				if (num != 40U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400C966 RID: 51558
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400C967 RID: 51559
		public const int ErrorCodeFieldNumber = 5;

		// Token: 0x0400C968 RID: 51560
		private ErrorCode errorCode_;
	}
}
