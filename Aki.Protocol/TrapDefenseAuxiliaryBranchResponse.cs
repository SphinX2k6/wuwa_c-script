using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001477 RID: 5239
	[NetMessage(EMessageId.TrapDefenseAuxiliaryBranchResponse)]
	public sealed class TrapDefenseAuxiliaryBranchResponse : IMessage<TrapDefenseAuxiliaryBranchResponse>, IMessage, IEquatable<TrapDefenseAuxiliaryBranchResponse>, IDeepCloneable<TrapDefenseAuxiliaryBranchResponse>, IBufferMessage
	{
		// Token: 0x0601BD34 RID: 113972 RVA: 0x0040B574 File Offset: 0x00409774
		[NullableContext(1)]
		public static TrapDefenseAuxiliaryBranchResponse Create()
		{
			return new TrapDefenseAuxiliaryBranchResponse();
		}

		// Token: 0x17005E39 RID: 24121
		// (get) Token: 0x0601BD35 RID: 113973 RVA: 0x0040B57B File Offset: 0x0040977B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005E3A RID: 24122
		// (get) Token: 0x0601BD36 RID: 113974 RVA: 0x0040B57E File Offset: 0x0040977E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseAuxiliaryBranchResponse.Descriptor;
			}
		}

		// Token: 0x0601BD37 RID: 113975 RVA: 0x0040B585 File Offset: 0x00409785
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseAuxiliaryBranchResponse()
		{
		}

		// Token: 0x0601BD38 RID: 113976 RVA: 0x0040B58D File Offset: 0x0040978D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseAuxiliaryBranchResponse(TrapDefenseAuxiliaryBranchResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601BD39 RID: 113977 RVA: 0x0040B5B2 File Offset: 0x004097B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseAuxiliaryBranchResponse Clone()
		{
			return new TrapDefenseAuxiliaryBranchResponse(this);
		}

		// Token: 0x17005E3B RID: 24123
		// (get) Token: 0x0601BD3A RID: 113978 RVA: 0x0040B5BA File Offset: 0x004097BA
		// (set) Token: 0x0601BD3B RID: 113979 RVA: 0x0040B5C2 File Offset: 0x004097C2
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

		// Token: 0x0601BD3C RID: 113980 RVA: 0x0040B5CB File Offset: 0x004097CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseAuxiliaryBranchResponse);
		}

		// Token: 0x0601BD3D RID: 113981 RVA: 0x0040B5D9 File Offset: 0x004097D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseAuxiliaryBranchResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601BD3E RID: 113982 RVA: 0x0040B608 File Offset: 0x00409808
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

		// Token: 0x0601BD3F RID: 113983 RVA: 0x0040B64D File Offset: 0x0040984D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601BD40 RID: 113984 RVA: 0x0040B65A File Offset: 0x0040985A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601BD41 RID: 113985 RVA: 0x0040B663 File Offset: 0x00409863
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601BD42 RID: 113986 RVA: 0x0040B698 File Offset: 0x00409898
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

		// Token: 0x0601BD43 RID: 113987 RVA: 0x0040B6D6 File Offset: 0x004098D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrapDefenseAuxiliaryBranchResponse other)
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

		// Token: 0x0601BD44 RID: 113988 RVA: 0x0040B707 File Offset: 0x00409907
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601BD45 RID: 113989 RVA: 0x0040B710 File Offset: 0x00409910
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
				if (num != 24U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400A186 RID: 41350
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A187 RID: 41351
		public const int ErrorCodeFieldNumber = 3;

		// Token: 0x0400A188 RID: 41352
		private ErrorCode errorCode_;
	}
}
