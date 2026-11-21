using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007E9 RID: 2025
	[NetMessage(EMessageId.InfrV2LevelUpResponse)]
	public sealed class InfrV2LevelUpResponse : IMessage<InfrV2LevelUpResponse>, IMessage, IEquatable<InfrV2LevelUpResponse>, IDeepCloneable<InfrV2LevelUpResponse>, IBufferMessage
	{
		// Token: 0x0600B5D4 RID: 46548 RVA: 0x001B2376 File Offset: 0x001B0576
		[NullableContext(1)]
		public static InfrV2LevelUpResponse Create()
		{
			return new InfrV2LevelUpResponse();
		}

		// Token: 0x170024A1 RID: 9377
		// (get) Token: 0x0600B5D5 RID: 46549 RVA: 0x001B237D File Offset: 0x001B057D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170024A2 RID: 9378
		// (get) Token: 0x0600B5D6 RID: 46550 RVA: 0x001B2380 File Offset: 0x001B0580
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InfrV2LevelUpResponse.Descriptor;
			}
		}

		// Token: 0x0600B5D7 RID: 46551 RVA: 0x001B2387 File Offset: 0x001B0587
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrV2LevelUpResponse()
		{
		}

		// Token: 0x0600B5D8 RID: 46552 RVA: 0x001B238F File Offset: 0x001B058F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrV2LevelUpResponse(InfrV2LevelUpResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B5D9 RID: 46553 RVA: 0x001B23B4 File Offset: 0x001B05B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrV2LevelUpResponse Clone()
		{
			return new InfrV2LevelUpResponse(this);
		}

		// Token: 0x170024A3 RID: 9379
		// (get) Token: 0x0600B5DA RID: 46554 RVA: 0x001B23BC File Offset: 0x001B05BC
		// (set) Token: 0x0600B5DB RID: 46555 RVA: 0x001B23C4 File Offset: 0x001B05C4
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

		// Token: 0x0600B5DC RID: 46556 RVA: 0x001B23CD File Offset: 0x001B05CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InfrV2LevelUpResponse);
		}

		// Token: 0x0600B5DD RID: 46557 RVA: 0x001B23DB File Offset: 0x001B05DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InfrV2LevelUpResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B5DE RID: 46558 RVA: 0x001B240C File Offset: 0x001B060C
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

		// Token: 0x0600B5DF RID: 46559 RVA: 0x001B2451 File Offset: 0x001B0651
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B5E0 RID: 46560 RVA: 0x001B245E File Offset: 0x001B065E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B5E1 RID: 46561 RVA: 0x001B2467 File Offset: 0x001B0667
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

		// Token: 0x0600B5E2 RID: 46562 RVA: 0x001B2498 File Offset: 0x001B0698
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

		// Token: 0x0600B5E3 RID: 46563 RVA: 0x001B24D6 File Offset: 0x001B06D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InfrV2LevelUpResponse other)
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

		// Token: 0x0600B5E4 RID: 46564 RVA: 0x001B2507 File Offset: 0x001B0707
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B5E5 RID: 46565 RVA: 0x001B2510 File Offset: 0x001B0710
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

		// Token: 0x040050E9 RID: 20713
		private UnknownFieldSet _unknownFields;

		// Token: 0x040050EA RID: 20714
		public const int ErrorCodeFieldNumber = 1;

		// Token: 0x040050EB RID: 20715
		private ErrorCode errorCode_;
	}
}
