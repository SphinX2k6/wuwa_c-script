using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014AC RID: 5292
	[NetMessage(EMessageId.UpdateSceneItemBlackboardResponse)]
	public sealed class UpdateSceneItemBlackboardResponse : IMessage<UpdateSceneItemBlackboardResponse>, IMessage, IEquatable<UpdateSceneItemBlackboardResponse>, IDeepCloneable<UpdateSceneItemBlackboardResponse>, IBufferMessage
	{
		// Token: 0x0601BFC9 RID: 114633 RVA: 0x0040B7B8 File Offset: 0x004099B8
		[NullableContext(1)]
		public static UpdateSceneItemBlackboardResponse Create()
		{
			return new UpdateSceneItemBlackboardResponse();
		}

		// Token: 0x17005E50 RID: 24144
		// (get) Token: 0x0601BFCA RID: 114634 RVA: 0x0040B7BF File Offset: 0x004099BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005E51 RID: 24145
		// (get) Token: 0x0601BFCB RID: 114635 RVA: 0x0040B7C2 File Offset: 0x004099C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UpdateSceneItemBlackboardResponse.Descriptor;
			}
		}

		// Token: 0x0601BFCC RID: 114636 RVA: 0x0040B7C9 File Offset: 0x004099C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateSceneItemBlackboardResponse()
		{
		}

		// Token: 0x0601BFCD RID: 114637 RVA: 0x0040B7D1 File Offset: 0x004099D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateSceneItemBlackboardResponse(UpdateSceneItemBlackboardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601BFCE RID: 114638 RVA: 0x0040B7F6 File Offset: 0x004099F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateSceneItemBlackboardResponse Clone()
		{
			return new UpdateSceneItemBlackboardResponse(this);
		}

		// Token: 0x17005E52 RID: 24146
		// (get) Token: 0x0601BFCF RID: 114639 RVA: 0x0040B7FE File Offset: 0x004099FE
		// (set) Token: 0x0601BFD0 RID: 114640 RVA: 0x0040B806 File Offset: 0x00409A06
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

		// Token: 0x0601BFD1 RID: 114641 RVA: 0x0040B80F File Offset: 0x00409A0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UpdateSceneItemBlackboardResponse);
		}

		// Token: 0x0601BFD2 RID: 114642 RVA: 0x0040B81D File Offset: 0x00409A1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UpdateSceneItemBlackboardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601BFD3 RID: 114643 RVA: 0x0040B84C File Offset: 0x00409A4C
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

		// Token: 0x0601BFD4 RID: 114644 RVA: 0x0040B891 File Offset: 0x00409A91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601BFD5 RID: 114645 RVA: 0x0040B89E File Offset: 0x00409A9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601BFD6 RID: 114646 RVA: 0x0040B8A7 File Offset: 0x00409AA7
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

		// Token: 0x0601BFD7 RID: 114647 RVA: 0x0040B8DC File Offset: 0x00409ADC
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

		// Token: 0x0601BFD8 RID: 114648 RVA: 0x0040B91A File Offset: 0x00409B1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(UpdateSceneItemBlackboardResponse other)
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

		// Token: 0x0601BFD9 RID: 114649 RVA: 0x0040B94B File Offset: 0x00409B4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601BFDA RID: 114650 RVA: 0x0040B954 File Offset: 0x00409B54
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

		// Token: 0x0400A0C1 RID: 41153
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A0C2 RID: 41154
		public const int ErrorCodeFieldNumber = 2;

		// Token: 0x0400A0C3 RID: 41155
		private ErrorCode errorCode_;
	}
}
