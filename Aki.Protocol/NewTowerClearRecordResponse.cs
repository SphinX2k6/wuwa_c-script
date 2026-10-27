using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B2D RID: 2861
	[NetMessage(EMessageId.NewTowerClearRecordResponse)]
	public sealed class NewTowerClearRecordResponse : IMessage<NewTowerClearRecordResponse>, IMessage, IEquatable<NewTowerClearRecordResponse>, IDeepCloneable<NewTowerClearRecordResponse>, IBufferMessage
	{
		// Token: 0x0600F852 RID: 63570 RVA: 0x00243501 File Offset: 0x00241701
		[NullableContext(1)]
		public static NewTowerClearRecordResponse Create()
		{
			return new NewTowerClearRecordResponse();
		}

		// Token: 0x17003297 RID: 12951
		// (get) Token: 0x0600F853 RID: 63571 RVA: 0x00243508 File Offset: 0x00241708
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003298 RID: 12952
		// (get) Token: 0x0600F854 RID: 63572 RVA: 0x0024350B File Offset: 0x0024170B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewTowerClearRecordResponse.Descriptor;
			}
		}

		// Token: 0x0600F855 RID: 63573 RVA: 0x00243512 File Offset: 0x00241712
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerClearRecordResponse()
		{
		}

		// Token: 0x0600F856 RID: 63574 RVA: 0x0024351A File Offset: 0x0024171A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerClearRecordResponse(NewTowerClearRecordResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F857 RID: 63575 RVA: 0x0024353F File Offset: 0x0024173F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerClearRecordResponse Clone()
		{
			return new NewTowerClearRecordResponse(this);
		}

		// Token: 0x17003299 RID: 12953
		// (get) Token: 0x0600F858 RID: 63576 RVA: 0x00243547 File Offset: 0x00241747
		// (set) Token: 0x0600F859 RID: 63577 RVA: 0x0024354F File Offset: 0x0024174F
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

		// Token: 0x0600F85A RID: 63578 RVA: 0x00243558 File Offset: 0x00241758
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewTowerClearRecordResponse);
		}

		// Token: 0x0600F85B RID: 63579 RVA: 0x00243566 File Offset: 0x00241766
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewTowerClearRecordResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F85C RID: 63580 RVA: 0x00243594 File Offset: 0x00241794
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

		// Token: 0x0600F85D RID: 63581 RVA: 0x002435D9 File Offset: 0x002417D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F85E RID: 63582 RVA: 0x002435E6 File Offset: 0x002417E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F85F RID: 63583 RVA: 0x002435EF File Offset: 0x002417EF
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

		// Token: 0x0600F860 RID: 63584 RVA: 0x00243624 File Offset: 0x00241824
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

		// Token: 0x0600F861 RID: 63585 RVA: 0x00243662 File Offset: 0x00241862
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NewTowerClearRecordResponse other)
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

		// Token: 0x0600F862 RID: 63586 RVA: 0x00243693 File Offset: 0x00241893
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F863 RID: 63587 RVA: 0x0024369C File Offset: 0x0024189C
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

		// Token: 0x0400638B RID: 25483
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400638C RID: 25484
		public const int ErrorCodeFieldNumber = 14;

		// Token: 0x0400638D RID: 25485
		private ErrorCode errorCode_;
	}
}
