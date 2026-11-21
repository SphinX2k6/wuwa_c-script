using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000AE7 RID: 2791
	[NetMessage(EMessageId.NewbieAdventureChapterDropResponse)]
	public sealed class NewbieAdventureChapterDropResponse : IMessage<NewbieAdventureChapterDropResponse>, IMessage, IEquatable<NewbieAdventureChapterDropResponse>, IDeepCloneable<NewbieAdventureChapterDropResponse>, IBufferMessage
	{
		// Token: 0x0600F30D RID: 62221 RVA: 0x00238400 File Offset: 0x00236600
		[NullableContext(1)]
		public static NewbieAdventureChapterDropResponse Create()
		{
			return new NewbieAdventureChapterDropResponse();
		}

		// Token: 0x1700317E RID: 12670
		// (get) Token: 0x0600F30E RID: 62222 RVA: 0x00238407 File Offset: 0x00236607
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700317F RID: 12671
		// (get) Token: 0x0600F30F RID: 62223 RVA: 0x0023840A File Offset: 0x0023660A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewbieAdventureChapterDropResponse.Descriptor;
			}
		}

		// Token: 0x0600F310 RID: 62224 RVA: 0x00238411 File Offset: 0x00236611
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewbieAdventureChapterDropResponse()
		{
		}

		// Token: 0x0600F311 RID: 62225 RVA: 0x00238419 File Offset: 0x00236619
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewbieAdventureChapterDropResponse(NewbieAdventureChapterDropResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F312 RID: 62226 RVA: 0x0023843E File Offset: 0x0023663E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewbieAdventureChapterDropResponse Clone()
		{
			return new NewbieAdventureChapterDropResponse(this);
		}

		// Token: 0x17003180 RID: 12672
		// (get) Token: 0x0600F313 RID: 62227 RVA: 0x00238446 File Offset: 0x00236646
		// (set) Token: 0x0600F314 RID: 62228 RVA: 0x0023844E File Offset: 0x0023664E
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

		// Token: 0x0600F315 RID: 62229 RVA: 0x00238457 File Offset: 0x00236657
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewbieAdventureChapterDropResponse);
		}

		// Token: 0x0600F316 RID: 62230 RVA: 0x00238465 File Offset: 0x00236665
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewbieAdventureChapterDropResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F317 RID: 62231 RVA: 0x00238494 File Offset: 0x00236694
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

		// Token: 0x0600F318 RID: 62232 RVA: 0x002384D9 File Offset: 0x002366D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F319 RID: 62233 RVA: 0x002384E6 File Offset: 0x002366E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F31A RID: 62234 RVA: 0x002384EF File Offset: 0x002366EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F31B RID: 62235 RVA: 0x00238520 File Offset: 0x00236720
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

		// Token: 0x0600F31C RID: 62236 RVA: 0x0023855E File Offset: 0x0023675E
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

		// Token: 0x0600F31D RID: 62237 RVA: 0x0023858F File Offset: 0x0023678F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F31E RID: 62238 RVA: 0x00238598 File Offset: 0x00236798
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
				if (num != 8U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04006263 RID: 25187
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006264 RID: 25188
		public const int ErrorCodeFieldNumber = 1;

		// Token: 0x04006265 RID: 25189
		private ErrorCode errorCode_;
	}
}
