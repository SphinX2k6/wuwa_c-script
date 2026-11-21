using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200062F RID: 1583
	[NetMessage(EMessageId.FragileChangeResponse)]
	public sealed class FragileChangeResponse : IMessage<FragileChangeResponse>, IMessage, IEquatable<FragileChangeResponse>, IDeepCloneable<FragileChangeResponse>, IBufferMessage
	{
		// Token: 0x06009245 RID: 37445 RVA: 0x00162608 File Offset: 0x00160808
		[NullableContext(1)]
		public static FragileChangeResponse Create()
		{
			return new FragileChangeResponse();
		}

		// Token: 0x17001D19 RID: 7449
		// (get) Token: 0x06009246 RID: 37446 RVA: 0x0016260F File Offset: 0x0016080F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001D1A RID: 7450
		// (get) Token: 0x06009247 RID: 37447 RVA: 0x00162612 File Offset: 0x00160812
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FragileChangeResponse.Descriptor;
			}
		}

		// Token: 0x06009248 RID: 37448 RVA: 0x00162619 File Offset: 0x00160819
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FragileChangeResponse()
		{
		}

		// Token: 0x06009249 RID: 37449 RVA: 0x00162621 File Offset: 0x00160821
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FragileChangeResponse(FragileChangeResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600924A RID: 37450 RVA: 0x00162646 File Offset: 0x00160846
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FragileChangeResponse Clone()
		{
			return new FragileChangeResponse(this);
		}

		// Token: 0x17001D1B RID: 7451
		// (get) Token: 0x0600924B RID: 37451 RVA: 0x0016264E File Offset: 0x0016084E
		// (set) Token: 0x0600924C RID: 37452 RVA: 0x00162656 File Offset: 0x00160856
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

		// Token: 0x0600924D RID: 37453 RVA: 0x0016265F File Offset: 0x0016085F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FragileChangeResponse);
		}

		// Token: 0x0600924E RID: 37454 RVA: 0x0016266D File Offset: 0x0016086D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FragileChangeResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600924F RID: 37455 RVA: 0x0016269C File Offset: 0x0016089C
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

		// Token: 0x06009250 RID: 37456 RVA: 0x001626E1 File Offset: 0x001608E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009251 RID: 37457 RVA: 0x001626EE File Offset: 0x001608EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009252 RID: 37458 RVA: 0x001626F7 File Offset: 0x001608F7
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

		// Token: 0x06009253 RID: 37459 RVA: 0x00162728 File Offset: 0x00160928
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

		// Token: 0x06009254 RID: 37460 RVA: 0x00162766 File Offset: 0x00160966
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FragileChangeResponse other)
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

		// Token: 0x06009255 RID: 37461 RVA: 0x00162797 File Offset: 0x00160997
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009256 RID: 37462 RVA: 0x001627A0 File Offset: 0x001609A0
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

		// Token: 0x040046EA RID: 18154
		private UnknownFieldSet _unknownFields;

		// Token: 0x040046EB RID: 18155
		public const int ErrorCodeFieldNumber = 1;

		// Token: 0x040046EC RID: 18156
		private ErrorCode errorCode_;
	}
}
