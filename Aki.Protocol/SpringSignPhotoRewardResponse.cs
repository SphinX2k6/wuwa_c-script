using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012F2 RID: 4850
	[NetMessage(EMessageId.SpringSignPhotoRewardResponse)]
	public sealed class SpringSignPhotoRewardResponse : IMessage<SpringSignPhotoRewardResponse>, IMessage, IEquatable<SpringSignPhotoRewardResponse>, IDeepCloneable<SpringSignPhotoRewardResponse>, IBufferMessage
	{
		// Token: 0x06019E07 RID: 105991 RVA: 0x003C650A File Offset: 0x003C470A
		[NullableContext(1)]
		public static SpringSignPhotoRewardResponse Create()
		{
			return new SpringSignPhotoRewardResponse();
		}

		// Token: 0x170057A5 RID: 22437
		// (get) Token: 0x06019E08 RID: 105992 RVA: 0x003C6511 File Offset: 0x003C4711
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170057A6 RID: 22438
		// (get) Token: 0x06019E09 RID: 105993 RVA: 0x003C6514 File Offset: 0x003C4714
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SpringSignPhotoRewardResponse.Descriptor;
			}
		}

		// Token: 0x06019E0A RID: 105994 RVA: 0x003C651B File Offset: 0x003C471B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpringSignPhotoRewardResponse()
		{
		}

		// Token: 0x06019E0B RID: 105995 RVA: 0x003C6523 File Offset: 0x003C4723
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpringSignPhotoRewardResponse(SpringSignPhotoRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019E0C RID: 105996 RVA: 0x003C6548 File Offset: 0x003C4748
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpringSignPhotoRewardResponse Clone()
		{
			return new SpringSignPhotoRewardResponse(this);
		}

		// Token: 0x170057A7 RID: 22439
		// (get) Token: 0x06019E0D RID: 105997 RVA: 0x003C6550 File Offset: 0x003C4750
		// (set) Token: 0x06019E0E RID: 105998 RVA: 0x003C6558 File Offset: 0x003C4758
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

		// Token: 0x06019E0F RID: 105999 RVA: 0x003C6561 File Offset: 0x003C4761
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SpringSignPhotoRewardResponse);
		}

		// Token: 0x06019E10 RID: 106000 RVA: 0x003C656F File Offset: 0x003C476F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SpringSignPhotoRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019E11 RID: 106001 RVA: 0x003C65A0 File Offset: 0x003C47A0
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

		// Token: 0x06019E12 RID: 106002 RVA: 0x003C65E5 File Offset: 0x003C47E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019E13 RID: 106003 RVA: 0x003C65F2 File Offset: 0x003C47F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019E14 RID: 106004 RVA: 0x003C65FB File Offset: 0x003C47FB
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

		// Token: 0x06019E15 RID: 106005 RVA: 0x003C6630 File Offset: 0x003C4830
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

		// Token: 0x06019E16 RID: 106006 RVA: 0x003C666E File Offset: 0x003C486E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SpringSignPhotoRewardResponse other)
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

		// Token: 0x06019E17 RID: 106007 RVA: 0x003C669F File Offset: 0x003C489F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019E18 RID: 106008 RVA: 0x003C66A8 File Offset: 0x003C48A8
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

		// Token: 0x040098A4 RID: 39076
		private UnknownFieldSet _unknownFields;

		// Token: 0x040098A5 RID: 39077
		public const int ErrorCodeFieldNumber = 2;

		// Token: 0x040098A6 RID: 39078
		private ErrorCode errorCode_;
	}
}
