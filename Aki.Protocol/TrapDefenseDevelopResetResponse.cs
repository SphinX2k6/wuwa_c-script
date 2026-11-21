using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001495 RID: 5269
	[NetMessage(EMessageId.TrapDefenseDevelopResetResponse)]
	public sealed class TrapDefenseDevelopResetResponse : IMessage<TrapDefenseDevelopResetResponse>, IMessage, IEquatable<TrapDefenseDevelopResetResponse>, IDeepCloneable<TrapDefenseDevelopResetResponse>, IBufferMessage
	{
		// Token: 0x0601BF98 RID: 114584 RVA: 0x0041061D File Offset: 0x0040E81D
		[NullableContext(1)]
		public static TrapDefenseDevelopResetResponse Create()
		{
			return new TrapDefenseDevelopResetResponse();
		}

		// Token: 0x17005EB8 RID: 24248
		// (get) Token: 0x0601BF99 RID: 114585 RVA: 0x00410624 File Offset: 0x0040E824
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005EB9 RID: 24249
		// (get) Token: 0x0601BF9A RID: 114586 RVA: 0x00410627 File Offset: 0x0040E827
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseDevelopResetResponse.Descriptor;
			}
		}

		// Token: 0x0601BF9B RID: 114587 RVA: 0x0041062E File Offset: 0x0040E82E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseDevelopResetResponse()
		{
		}

		// Token: 0x0601BF9C RID: 114588 RVA: 0x00410636 File Offset: 0x0040E836
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseDevelopResetResponse(TrapDefenseDevelopResetResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601BF9D RID: 114589 RVA: 0x0041065B File Offset: 0x0040E85B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseDevelopResetResponse Clone()
		{
			return new TrapDefenseDevelopResetResponse(this);
		}

		// Token: 0x17005EBA RID: 24250
		// (get) Token: 0x0601BF9E RID: 114590 RVA: 0x00410663 File Offset: 0x0040E863
		// (set) Token: 0x0601BF9F RID: 114591 RVA: 0x0041066B File Offset: 0x0040E86B
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

		// Token: 0x0601BFA0 RID: 114592 RVA: 0x00410674 File Offset: 0x0040E874
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseDevelopResetResponse);
		}

		// Token: 0x0601BFA1 RID: 114593 RVA: 0x00410682 File Offset: 0x0040E882
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseDevelopResetResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601BFA2 RID: 114594 RVA: 0x004106B0 File Offset: 0x0040E8B0
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

		// Token: 0x0601BFA3 RID: 114595 RVA: 0x004106F5 File Offset: 0x0040E8F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601BFA4 RID: 114596 RVA: 0x00410702 File Offset: 0x0040E902
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601BFA5 RID: 114597 RVA: 0x0041070B File Offset: 0x0040E90B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(104);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601BFA6 RID: 114598 RVA: 0x00410740 File Offset: 0x0040E940
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

		// Token: 0x0601BFA7 RID: 114599 RVA: 0x0041077E File Offset: 0x0040E97E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrapDefenseDevelopResetResponse other)
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

		// Token: 0x0601BFA8 RID: 114600 RVA: 0x004107AF File Offset: 0x0040E9AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601BFA9 RID: 114601 RVA: 0x004107B8 File Offset: 0x0040E9B8
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
				if (num != 104U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400A224 RID: 41508
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A225 RID: 41509
		public const int ErrorCodeFieldNumber = 13;

		// Token: 0x0400A226 RID: 41510
		private ErrorCode errorCode_;
	}
}
