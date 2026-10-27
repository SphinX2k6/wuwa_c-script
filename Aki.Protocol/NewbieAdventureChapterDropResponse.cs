using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000AF8 RID: 2808
	[NetMessage(EMessageId.NewbieAdventureChapterDropResponse)]
	public sealed class NewbieAdventureChapterDropResponse : IMessage<NewbieAdventureChapterDropResponse>, IMessage, IEquatable<NewbieAdventureChapterDropResponse>, IDeepCloneable<NewbieAdventureChapterDropResponse>, IBufferMessage
	{
		// Token: 0x0600F427 RID: 62503 RVA: 0x0023A608 File Offset: 0x00238808
		[NullableContext(1)]
		public static NewbieAdventureChapterDropResponse Create()
		{
			return new NewbieAdventureChapterDropResponse();
		}

		// Token: 0x170031BC RID: 12732
		// (get) Token: 0x0600F428 RID: 62504 RVA: 0x0023A60F File Offset: 0x0023880F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170031BD RID: 12733
		// (get) Token: 0x0600F429 RID: 62505 RVA: 0x0023A612 File Offset: 0x00238812
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewbieAdventureChapterDropResponse.Descriptor;
			}
		}

		// Token: 0x0600F42A RID: 62506 RVA: 0x0023A619 File Offset: 0x00238819
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewbieAdventureChapterDropResponse()
		{
		}

		// Token: 0x0600F42B RID: 62507 RVA: 0x0023A621 File Offset: 0x00238821
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewbieAdventureChapterDropResponse(NewbieAdventureChapterDropResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F42C RID: 62508 RVA: 0x0023A646 File Offset: 0x00238846
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewbieAdventureChapterDropResponse Clone()
		{
			return new NewbieAdventureChapterDropResponse(this);
		}

		// Token: 0x170031BE RID: 12734
		// (get) Token: 0x0600F42D RID: 62509 RVA: 0x0023A64E File Offset: 0x0023884E
		// (set) Token: 0x0600F42E RID: 62510 RVA: 0x0023A656 File Offset: 0x00238856
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

		// Token: 0x0600F42F RID: 62511 RVA: 0x0023A65F File Offset: 0x0023885F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewbieAdventureChapterDropResponse);
		}

		// Token: 0x0600F430 RID: 62512 RVA: 0x0023A66D File Offset: 0x0023886D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewbieAdventureChapterDropResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F431 RID: 62513 RVA: 0x0023A69C File Offset: 0x0023889C
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

		// Token: 0x0600F432 RID: 62514 RVA: 0x0023A6E1 File Offset: 0x002388E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F433 RID: 62515 RVA: 0x0023A6EE File Offset: 0x002388EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F434 RID: 62516 RVA: 0x0023A6F7 File Offset: 0x002388F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(88);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F435 RID: 62517 RVA: 0x0023A72C File Offset: 0x0023892C
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

		// Token: 0x0600F436 RID: 62518 RVA: 0x0023A76A File Offset: 0x0023896A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NewbieAdventureChapterDropResponse other)
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

		// Token: 0x0600F437 RID: 62519 RVA: 0x0023A79B File Offset: 0x0023899B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F438 RID: 62520 RVA: 0x0023A7A4 File Offset: 0x002389A4
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
				if (num != 88U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400625A RID: 25178
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400625B RID: 25179
		public const int ErrorCodeFieldNumber = 11;

		// Token: 0x0400625C RID: 25180
		private ErrorCode errorCode_;
	}
}
