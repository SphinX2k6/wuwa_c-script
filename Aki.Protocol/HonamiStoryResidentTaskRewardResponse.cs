using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000787 RID: 1927
	[NetMessage(EMessageId.HonamiStoryResidentTaskRewardResponse)]
	public sealed class HonamiStoryResidentTaskRewardResponse : IMessage<HonamiStoryResidentTaskRewardResponse>, IMessage, IEquatable<HonamiStoryResidentTaskRewardResponse>, IDeepCloneable<HonamiStoryResidentTaskRewardResponse>, IBufferMessage
	{
		// Token: 0x0600AE43 RID: 44611 RVA: 0x001A2C7F File Offset: 0x001A0E7F
		[NullableContext(1)]
		public static HonamiStoryResidentTaskRewardResponse Create()
		{
			return new HonamiStoryResidentTaskRewardResponse();
		}

		// Token: 0x17002322 RID: 8994
		// (get) Token: 0x0600AE44 RID: 44612 RVA: 0x001A2C86 File Offset: 0x001A0E86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002323 RID: 8995
		// (get) Token: 0x0600AE45 RID: 44613 RVA: 0x001A2C89 File Offset: 0x001A0E89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HonamiStoryResidentTaskRewardResponse.Descriptor;
			}
		}

		// Token: 0x0600AE46 RID: 44614 RVA: 0x001A2C90 File Offset: 0x001A0E90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryResidentTaskRewardResponse()
		{
		}

		// Token: 0x0600AE47 RID: 44615 RVA: 0x001A2C98 File Offset: 0x001A0E98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryResidentTaskRewardResponse(HonamiStoryResidentTaskRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AE48 RID: 44616 RVA: 0x001A2CBD File Offset: 0x001A0EBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryResidentTaskRewardResponse Clone()
		{
			return new HonamiStoryResidentTaskRewardResponse(this);
		}

		// Token: 0x17002324 RID: 8996
		// (get) Token: 0x0600AE49 RID: 44617 RVA: 0x001A2CC5 File Offset: 0x001A0EC5
		// (set) Token: 0x0600AE4A RID: 44618 RVA: 0x001A2CCD File Offset: 0x001A0ECD
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

		// Token: 0x0600AE4B RID: 44619 RVA: 0x001A2CD6 File Offset: 0x001A0ED6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HonamiStoryResidentTaskRewardResponse);
		}

		// Token: 0x0600AE4C RID: 44620 RVA: 0x001A2CE4 File Offset: 0x001A0EE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HonamiStoryResidentTaskRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600AE4D RID: 44621 RVA: 0x001A2D14 File Offset: 0x001A0F14
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

		// Token: 0x0600AE4E RID: 44622 RVA: 0x001A2D59 File Offset: 0x001A0F59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600AE4F RID: 44623 RVA: 0x001A2D66 File Offset: 0x001A0F66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AE50 RID: 44624 RVA: 0x001A2D6F File Offset: 0x001A0F6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AE51 RID: 44625 RVA: 0x001A2DA4 File Offset: 0x001A0FA4
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

		// Token: 0x0600AE52 RID: 44626 RVA: 0x001A2DE2 File Offset: 0x001A0FE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HonamiStoryResidentTaskRewardResponse other)
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

		// Token: 0x0600AE53 RID: 44627 RVA: 0x001A2E13 File Offset: 0x001A1013
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AE54 RID: 44628 RVA: 0x001A2E1C File Offset: 0x001A101C
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
				if (num != 40U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04004EFE RID: 20222
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004EFF RID: 20223
		public const int ErrorCodeFieldNumber = 5;

		// Token: 0x04004F00 RID: 20224
		private ErrorCode errorCode_;
	}
}
