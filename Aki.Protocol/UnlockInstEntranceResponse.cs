using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200148B RID: 5259
	[NetMessage(EMessageId.UnlockInstEntranceResponse)]
	public sealed class UnlockInstEntranceResponse : IMessage<UnlockInstEntranceResponse>, IMessage, IEquatable<UnlockInstEntranceResponse>, IDeepCloneable<UnlockInstEntranceResponse>, IBufferMessage
	{
		// Token: 0x0601BD3D RID: 113981 RVA: 0x00406475 File Offset: 0x00404675
		[NullableContext(1)]
		public static UnlockInstEntranceResponse Create()
		{
			return new UnlockInstEntranceResponse();
		}

		// Token: 0x17005DD0 RID: 24016
		// (get) Token: 0x0601BD3E RID: 113982 RVA: 0x0040647C File Offset: 0x0040467C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005DD1 RID: 24017
		// (get) Token: 0x0601BD3F RID: 113983 RVA: 0x0040647F File Offset: 0x0040467F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UnlockInstEntranceResponse.Descriptor;
			}
		}

		// Token: 0x0601BD40 RID: 113984 RVA: 0x00406486 File Offset: 0x00404686
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UnlockInstEntranceResponse()
		{
		}

		// Token: 0x0601BD41 RID: 113985 RVA: 0x0040648E File Offset: 0x0040468E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UnlockInstEntranceResponse(UnlockInstEntranceResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601BD42 RID: 113986 RVA: 0x004064B3 File Offset: 0x004046B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UnlockInstEntranceResponse Clone()
		{
			return new UnlockInstEntranceResponse(this);
		}

		// Token: 0x17005DD2 RID: 24018
		// (get) Token: 0x0601BD43 RID: 113987 RVA: 0x004064BB File Offset: 0x004046BB
		// (set) Token: 0x0601BD44 RID: 113988 RVA: 0x004064C3 File Offset: 0x004046C3
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

		// Token: 0x0601BD45 RID: 113989 RVA: 0x004064CC File Offset: 0x004046CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UnlockInstEntranceResponse);
		}

		// Token: 0x0601BD46 RID: 113990 RVA: 0x004064DA File Offset: 0x004046DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UnlockInstEntranceResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601BD47 RID: 113991 RVA: 0x00406508 File Offset: 0x00404708
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

		// Token: 0x0601BD48 RID: 113992 RVA: 0x0040654D File Offset: 0x0040474D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601BD49 RID: 113993 RVA: 0x0040655A File Offset: 0x0040475A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601BD4A RID: 113994 RVA: 0x00406563 File Offset: 0x00404763
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

		// Token: 0x0601BD4B RID: 113995 RVA: 0x00406594 File Offset: 0x00404794
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

		// Token: 0x0601BD4C RID: 113996 RVA: 0x004065D2 File Offset: 0x004047D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(UnlockInstEntranceResponse other)
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

		// Token: 0x0601BD4D RID: 113997 RVA: 0x00406603 File Offset: 0x00404803
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601BD4E RID: 113998 RVA: 0x0040660C File Offset: 0x0040480C
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

		// Token: 0x0400A016 RID: 40982
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A017 RID: 40983
		public const int ErrorCodeFieldNumber = 1;

		// Token: 0x0400A018 RID: 40984
		private ErrorCode errorCode_;
	}
}
