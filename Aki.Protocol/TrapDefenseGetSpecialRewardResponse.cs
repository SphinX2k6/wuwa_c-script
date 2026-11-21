using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200149D RID: 5277
	[NetMessage(EMessageId.TrapDefenseGetSpecialRewardResponse)]
	public sealed class TrapDefenseGetSpecialRewardResponse : IMessage<TrapDefenseGetSpecialRewardResponse>, IMessage, IEquatable<TrapDefenseGetSpecialRewardResponse>, IDeepCloneable<TrapDefenseGetSpecialRewardResponse>, IBufferMessage
	{
		// Token: 0x0601C032 RID: 114738 RVA: 0x0041185D File Offset: 0x0040FA5D
		[NullableContext(1)]
		public static TrapDefenseGetSpecialRewardResponse Create()
		{
			return new TrapDefenseGetSpecialRewardResponse();
		}

		// Token: 0x17005ED5 RID: 24277
		// (get) Token: 0x0601C033 RID: 114739 RVA: 0x00411864 File Offset: 0x0040FA64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005ED6 RID: 24278
		// (get) Token: 0x0601C034 RID: 114740 RVA: 0x00411867 File Offset: 0x0040FA67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseGetSpecialRewardResponse.Descriptor;
			}
		}

		// Token: 0x0601C035 RID: 114741 RVA: 0x0041186E File Offset: 0x0040FA6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseGetSpecialRewardResponse()
		{
		}

		// Token: 0x0601C036 RID: 114742 RVA: 0x00411876 File Offset: 0x0040FA76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseGetSpecialRewardResponse(TrapDefenseGetSpecialRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C037 RID: 114743 RVA: 0x0041189B File Offset: 0x0040FA9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseGetSpecialRewardResponse Clone()
		{
			return new TrapDefenseGetSpecialRewardResponse(this);
		}

		// Token: 0x17005ED7 RID: 24279
		// (get) Token: 0x0601C038 RID: 114744 RVA: 0x004118A3 File Offset: 0x0040FAA3
		// (set) Token: 0x0601C039 RID: 114745 RVA: 0x004118AB File Offset: 0x0040FAAB
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

		// Token: 0x0601C03A RID: 114746 RVA: 0x004118B4 File Offset: 0x0040FAB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseGetSpecialRewardResponse);
		}

		// Token: 0x0601C03B RID: 114747 RVA: 0x004118C2 File Offset: 0x0040FAC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseGetSpecialRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C03C RID: 114748 RVA: 0x004118F0 File Offset: 0x0040FAF0
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

		// Token: 0x0601C03D RID: 114749 RVA: 0x00411935 File Offset: 0x0040FB35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C03E RID: 114750 RVA: 0x00411942 File Offset: 0x0040FB42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C03F RID: 114751 RVA: 0x0041194B File Offset: 0x0040FB4B
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

		// Token: 0x0601C040 RID: 114752 RVA: 0x00411980 File Offset: 0x0040FB80
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

		// Token: 0x0601C041 RID: 114753 RVA: 0x004119BE File Offset: 0x0040FBBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrapDefenseGetSpecialRewardResponse other)
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

		// Token: 0x0601C042 RID: 114754 RVA: 0x004119EF File Offset: 0x0040FBEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C043 RID: 114755 RVA: 0x004119F8 File Offset: 0x0040FBF8
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

		// Token: 0x0400A247 RID: 41543
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A248 RID: 41544
		public const int ErrorCodeFieldNumber = 3;

		// Token: 0x0400A249 RID: 41545
		private ErrorCode errorCode_;
	}
}
