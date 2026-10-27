using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011CC RID: 4556
	[NetMessage(EMessageId.SetBtObjYuXueModeResponse)]
	public sealed class SetBtObjYuXueModeResponse : IMessage<SetBtObjYuXueModeResponse>, IMessage, IEquatable<SetBtObjYuXueModeResponse>, IDeepCloneable<SetBtObjYuXueModeResponse>, IBufferMessage
	{
		// Token: 0x060184D8 RID: 99544 RVA: 0x0038962F File Offset: 0x0038782F
		[NullableContext(1)]
		public static SetBtObjYuXueModeResponse Create()
		{
			return new SetBtObjYuXueModeResponse();
		}

		// Token: 0x170051DB RID: 20955
		// (get) Token: 0x060184D9 RID: 99545 RVA: 0x00389636 File Offset: 0x00387836
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170051DC RID: 20956
		// (get) Token: 0x060184DA RID: 99546 RVA: 0x00389639 File Offset: 0x00387839
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SetBtObjYuXueModeResponse.Descriptor;
			}
		}

		// Token: 0x060184DB RID: 99547 RVA: 0x00389640 File Offset: 0x00387840
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetBtObjYuXueModeResponse()
		{
		}

		// Token: 0x060184DC RID: 99548 RVA: 0x00389648 File Offset: 0x00387848
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetBtObjYuXueModeResponse(SetBtObjYuXueModeResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060184DD RID: 99549 RVA: 0x0038966D File Offset: 0x0038786D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetBtObjYuXueModeResponse Clone()
		{
			return new SetBtObjYuXueModeResponse(this);
		}

		// Token: 0x170051DD RID: 20957
		// (get) Token: 0x060184DE RID: 99550 RVA: 0x00389675 File Offset: 0x00387875
		// (set) Token: 0x060184DF RID: 99551 RVA: 0x0038967D File Offset: 0x0038787D
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

		// Token: 0x060184E0 RID: 99552 RVA: 0x00389686 File Offset: 0x00387886
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SetBtObjYuXueModeResponse);
		}

		// Token: 0x060184E1 RID: 99553 RVA: 0x00389694 File Offset: 0x00387894
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SetBtObjYuXueModeResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060184E2 RID: 99554 RVA: 0x003896C4 File Offset: 0x003878C4
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

		// Token: 0x060184E3 RID: 99555 RVA: 0x00389709 File Offset: 0x00387909
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060184E4 RID: 99556 RVA: 0x00389716 File Offset: 0x00387916
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060184E5 RID: 99557 RVA: 0x0038971F File Offset: 0x0038791F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060184E6 RID: 99558 RVA: 0x00389754 File Offset: 0x00387954
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

		// Token: 0x060184E7 RID: 99559 RVA: 0x00389792 File Offset: 0x00387992
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SetBtObjYuXueModeResponse other)
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

		// Token: 0x060184E8 RID: 99560 RVA: 0x003897C3 File Offset: 0x003879C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060184E9 RID: 99561 RVA: 0x003897CC File Offset: 0x003879CC
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
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04008FF4 RID: 36852
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008FF5 RID: 36853
		public const int ErrorCodeFieldNumber = 2;

		// Token: 0x04008FF6 RID: 36854
		private ErrorCode errorCode_;
	}
}
