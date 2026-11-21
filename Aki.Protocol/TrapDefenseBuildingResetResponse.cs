using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001487 RID: 5255
	[NetMessage(EMessageId.TrapDefenseBuildingResetResponse)]
	public sealed class TrapDefenseBuildingResetResponse : IMessage<TrapDefenseBuildingResetResponse>, IMessage, IEquatable<TrapDefenseBuildingResetResponse>, IDeepCloneable<TrapDefenseBuildingResetResponse>, IBufferMessage
	{
		// Token: 0x0601BE74 RID: 114292 RVA: 0x0040DD35 File Offset: 0x0040BF35
		[NullableContext(1)]
		public static TrapDefenseBuildingResetResponse Create()
		{
			return new TrapDefenseBuildingResetResponse();
		}

		// Token: 0x17005E79 RID: 24185
		// (get) Token: 0x0601BE75 RID: 114293 RVA: 0x0040DD3C File Offset: 0x0040BF3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005E7A RID: 24186
		// (get) Token: 0x0601BE76 RID: 114294 RVA: 0x0040DD3F File Offset: 0x0040BF3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseBuildingResetResponse.Descriptor;
			}
		}

		// Token: 0x0601BE77 RID: 114295 RVA: 0x0040DD46 File Offset: 0x0040BF46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseBuildingResetResponse()
		{
		}

		// Token: 0x0601BE78 RID: 114296 RVA: 0x0040DD4E File Offset: 0x0040BF4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseBuildingResetResponse(TrapDefenseBuildingResetResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601BE79 RID: 114297 RVA: 0x0040DD73 File Offset: 0x0040BF73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseBuildingResetResponse Clone()
		{
			return new TrapDefenseBuildingResetResponse(this);
		}

		// Token: 0x17005E7B RID: 24187
		// (get) Token: 0x0601BE7A RID: 114298 RVA: 0x0040DD7B File Offset: 0x0040BF7B
		// (set) Token: 0x0601BE7B RID: 114299 RVA: 0x0040DD83 File Offset: 0x0040BF83
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

		// Token: 0x0601BE7C RID: 114300 RVA: 0x0040DD8C File Offset: 0x0040BF8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseBuildingResetResponse);
		}

		// Token: 0x0601BE7D RID: 114301 RVA: 0x0040DD9A File Offset: 0x0040BF9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseBuildingResetResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601BE7E RID: 114302 RVA: 0x0040DDC8 File Offset: 0x0040BFC8
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

		// Token: 0x0601BE7F RID: 114303 RVA: 0x0040DE0D File Offset: 0x0040C00D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601BE80 RID: 114304 RVA: 0x0040DE1A File Offset: 0x0040C01A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601BE81 RID: 114305 RVA: 0x0040DE23 File Offset: 0x0040C023
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

		// Token: 0x0601BE82 RID: 114306 RVA: 0x0040DE58 File Offset: 0x0040C058
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

		// Token: 0x0601BE83 RID: 114307 RVA: 0x0040DE96 File Offset: 0x0040C096
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrapDefenseBuildingResetResponse other)
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

		// Token: 0x0601BE84 RID: 114308 RVA: 0x0040DEC7 File Offset: 0x0040C0C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601BE85 RID: 114309 RVA: 0x0040DED0 File Offset: 0x0040C0D0
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

		// Token: 0x0400A1D7 RID: 41431
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A1D8 RID: 41432
		public const int ErrorCodeFieldNumber = 14;

		// Token: 0x0400A1D9 RID: 41433
		private ErrorCode errorCode_;
	}
}
