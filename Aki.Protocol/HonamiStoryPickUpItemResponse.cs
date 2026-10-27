using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000793 RID: 1939
	[NetMessage(EMessageId.HonamiStoryPickUpItemResponse)]
	public sealed class HonamiStoryPickUpItemResponse : IMessage<HonamiStoryPickUpItemResponse>, IMessage, IEquatable<HonamiStoryPickUpItemResponse>, IDeepCloneable<HonamiStoryPickUpItemResponse>, IBufferMessage
	{
		// Token: 0x0600AEFB RID: 44795 RVA: 0x001A41E8 File Offset: 0x001A23E8
		[NullableContext(1)]
		public static HonamiStoryPickUpItemResponse Create()
		{
			return new HonamiStoryPickUpItemResponse();
		}

		// Token: 0x1700234C RID: 9036
		// (get) Token: 0x0600AEFC RID: 44796 RVA: 0x001A41EF File Offset: 0x001A23EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700234D RID: 9037
		// (get) Token: 0x0600AEFD RID: 44797 RVA: 0x001A41F2 File Offset: 0x001A23F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HonamiStoryPickUpItemResponse.Descriptor;
			}
		}

		// Token: 0x0600AEFE RID: 44798 RVA: 0x001A41F9 File Offset: 0x001A23F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryPickUpItemResponse()
		{
		}

		// Token: 0x0600AEFF RID: 44799 RVA: 0x001A4201 File Offset: 0x001A2401
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryPickUpItemResponse(HonamiStoryPickUpItemResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AF00 RID: 44800 RVA: 0x001A4226 File Offset: 0x001A2426
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryPickUpItemResponse Clone()
		{
			return new HonamiStoryPickUpItemResponse(this);
		}

		// Token: 0x1700234E RID: 9038
		// (get) Token: 0x0600AF01 RID: 44801 RVA: 0x001A422E File Offset: 0x001A242E
		// (set) Token: 0x0600AF02 RID: 44802 RVA: 0x001A4236 File Offset: 0x001A2436
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

		// Token: 0x0600AF03 RID: 44803 RVA: 0x001A423F File Offset: 0x001A243F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HonamiStoryPickUpItemResponse);
		}

		// Token: 0x0600AF04 RID: 44804 RVA: 0x001A424D File Offset: 0x001A244D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HonamiStoryPickUpItemResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600AF05 RID: 44805 RVA: 0x001A427C File Offset: 0x001A247C
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

		// Token: 0x0600AF06 RID: 44806 RVA: 0x001A42C1 File Offset: 0x001A24C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600AF07 RID: 44807 RVA: 0x001A42CE File Offset: 0x001A24CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AF08 RID: 44808 RVA: 0x001A42D7 File Offset: 0x001A24D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AF09 RID: 44809 RVA: 0x001A430C File Offset: 0x001A250C
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

		// Token: 0x0600AF0A RID: 44810 RVA: 0x001A434A File Offset: 0x001A254A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HonamiStoryPickUpItemResponse other)
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

		// Token: 0x0600AF0B RID: 44811 RVA: 0x001A437B File Offset: 0x001A257B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AF0C RID: 44812 RVA: 0x001A4384 File Offset: 0x001A2584
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
				if (num != 48U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04004ED9 RID: 20185
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004EDA RID: 20186
		public const int ErrorCodeFieldNumber = 6;

		// Token: 0x04004EDB RID: 20187
		private ErrorCode errorCode_;
	}
}
