using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E6C RID: 3692
	[NetMessage(EMessageId.RacingBetsTaskRewardResponse)]
	public sealed class RacingBetsTaskRewardResponse : IMessage<RacingBetsTaskRewardResponse>, IMessage, IEquatable<RacingBetsTaskRewardResponse>, IDeepCloneable<RacingBetsTaskRewardResponse>, IBufferMessage
	{
		// Token: 0x06013DBC RID: 81340 RVA: 0x002E4D31 File Offset: 0x002E2F31
		[NullableContext(1)]
		public static RacingBetsTaskRewardResponse Create()
		{
			return new RacingBetsTaskRewardResponse();
		}

		// Token: 0x1700420E RID: 16910
		// (get) Token: 0x06013DBD RID: 81341 RVA: 0x002E4D38 File Offset: 0x002E2F38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700420F RID: 16911
		// (get) Token: 0x06013DBE RID: 81342 RVA: 0x002E4D3B File Offset: 0x002E2F3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RacingBetsTaskRewardResponse.Descriptor;
			}
		}

		// Token: 0x06013DBF RID: 81343 RVA: 0x002E4D42 File Offset: 0x002E2F42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsTaskRewardResponse()
		{
		}

		// Token: 0x06013DC0 RID: 81344 RVA: 0x002E4D4A File Offset: 0x002E2F4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsTaskRewardResponse(RacingBetsTaskRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013DC1 RID: 81345 RVA: 0x002E4D6F File Offset: 0x002E2F6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsTaskRewardResponse Clone()
		{
			return new RacingBetsTaskRewardResponse(this);
		}

		// Token: 0x17004210 RID: 16912
		// (get) Token: 0x06013DC2 RID: 81346 RVA: 0x002E4D77 File Offset: 0x002E2F77
		// (set) Token: 0x06013DC3 RID: 81347 RVA: 0x002E4D7F File Offset: 0x002E2F7F
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

		// Token: 0x06013DC4 RID: 81348 RVA: 0x002E4D88 File Offset: 0x002E2F88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RacingBetsTaskRewardResponse);
		}

		// Token: 0x06013DC5 RID: 81349 RVA: 0x002E4D96 File Offset: 0x002E2F96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RacingBetsTaskRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013DC6 RID: 81350 RVA: 0x002E4DC4 File Offset: 0x002E2FC4
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

		// Token: 0x06013DC7 RID: 81351 RVA: 0x002E4E09 File Offset: 0x002E3009
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013DC8 RID: 81352 RVA: 0x002E4E16 File Offset: 0x002E3016
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013DC9 RID: 81353 RVA: 0x002E4E1F File Offset: 0x002E301F
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

		// Token: 0x06013DCA RID: 81354 RVA: 0x002E4E54 File Offset: 0x002E3054
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

		// Token: 0x06013DCB RID: 81355 RVA: 0x002E4E92 File Offset: 0x002E3092
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RacingBetsTaskRewardResponse other)
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

		// Token: 0x06013DCC RID: 81356 RVA: 0x002E4EC3 File Offset: 0x002E30C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013DCD RID: 81357 RVA: 0x002E4ECC File Offset: 0x002E30CC
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

		// Token: 0x040079DD RID: 31197
		private UnknownFieldSet _unknownFields;

		// Token: 0x040079DE RID: 31198
		public const int ErrorCodeFieldNumber = 11;

		// Token: 0x040079DF RID: 31199
		private ErrorCode errorCode_;
	}
}
