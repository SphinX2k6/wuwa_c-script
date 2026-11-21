using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200018C RID: 396
	[NetMessage(EMessageId.BeControlledEntityHoverResponse)]
	public sealed class BeControlledEntityHoverResponse : IMessage<BeControlledEntityHoverResponse>, IMessage, IEquatable<BeControlledEntityHoverResponse>, IDeepCloneable<BeControlledEntityHoverResponse>, IBufferMessage
	{
		// Token: 0x06002FA8 RID: 12200 RVA: 0x0007A451 File Offset: 0x00078651
		[NullableContext(1)]
		public static BeControlledEntityHoverResponse Create()
		{
			return new BeControlledEntityHoverResponse();
		}

		// Token: 0x1700074C RID: 1868
		// (get) Token: 0x06002FA9 RID: 12201 RVA: 0x0007A458 File Offset: 0x00078658
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700074D RID: 1869
		// (get) Token: 0x06002FAA RID: 12202 RVA: 0x0007A45B File Offset: 0x0007865B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BeControlledEntityHoverResponse.Descriptor;
			}
		}

		// Token: 0x06002FAB RID: 12203 RVA: 0x0007A462 File Offset: 0x00078662
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BeControlledEntityHoverResponse()
		{
		}

		// Token: 0x06002FAC RID: 12204 RVA: 0x0007A46A File Offset: 0x0007866A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BeControlledEntityHoverResponse(BeControlledEntityHoverResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002FAD RID: 12205 RVA: 0x0007A48F File Offset: 0x0007868F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BeControlledEntityHoverResponse Clone()
		{
			return new BeControlledEntityHoverResponse(this);
		}

		// Token: 0x1700074E RID: 1870
		// (get) Token: 0x06002FAE RID: 12206 RVA: 0x0007A497 File Offset: 0x00078697
		// (set) Token: 0x06002FAF RID: 12207 RVA: 0x0007A49F File Offset: 0x0007869F
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

		// Token: 0x06002FB0 RID: 12208 RVA: 0x0007A4A8 File Offset: 0x000786A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BeControlledEntityHoverResponse);
		}

		// Token: 0x06002FB1 RID: 12209 RVA: 0x0007A4B6 File Offset: 0x000786B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BeControlledEntityHoverResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002FB2 RID: 12210 RVA: 0x0007A4E4 File Offset: 0x000786E4
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

		// Token: 0x06002FB3 RID: 12211 RVA: 0x0007A529 File Offset: 0x00078729
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002FB4 RID: 12212 RVA: 0x0007A536 File Offset: 0x00078736
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002FB5 RID: 12213 RVA: 0x0007A53F File Offset: 0x0007873F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002FB6 RID: 12214 RVA: 0x0007A574 File Offset: 0x00078774
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

		// Token: 0x06002FB7 RID: 12215 RVA: 0x0007A5B2 File Offset: 0x000787B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BeControlledEntityHoverResponse other)
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

		// Token: 0x06002FB8 RID: 12216 RVA: 0x0007A5E3 File Offset: 0x000787E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002FB9 RID: 12217 RVA: 0x0007A5EC File Offset: 0x000787EC
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
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04002913 RID: 10515
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002914 RID: 10516
		public const int ErrorCodeFieldNumber = 8;

		// Token: 0x04002915 RID: 10517
		private ErrorCode errorCode_;
	}
}
