using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200077F RID: 1919
	[NetMessage(EMessageId.HonamiStoryPickUpItemResponse)]
	public sealed class HonamiStoryPickUpItemResponse : IMessage<HonamiStoryPickUpItemResponse>, IMessage, IEquatable<HonamiStoryPickUpItemResponse>, IDeepCloneable<HonamiStoryPickUpItemResponse>, IBufferMessage
	{
		// Token: 0x0600ADA5 RID: 44453 RVA: 0x001A17C0 File Offset: 0x0019F9C0
		[NullableContext(1)]
		public static HonamiStoryPickUpItemResponse Create()
		{
			return new HonamiStoryPickUpItemResponse();
		}

		// Token: 0x17002302 RID: 8962
		// (get) Token: 0x0600ADA6 RID: 44454 RVA: 0x001A17C7 File Offset: 0x0019F9C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002303 RID: 8963
		// (get) Token: 0x0600ADA7 RID: 44455 RVA: 0x001A17CA File Offset: 0x0019F9CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HonamiStoryPickUpItemResponse.Descriptor;
			}
		}

		// Token: 0x0600ADA8 RID: 44456 RVA: 0x001A17D1 File Offset: 0x0019F9D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryPickUpItemResponse()
		{
		}

		// Token: 0x0600ADA9 RID: 44457 RVA: 0x001A17D9 File Offset: 0x0019F9D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryPickUpItemResponse(HonamiStoryPickUpItemResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600ADAA RID: 44458 RVA: 0x001A17FE File Offset: 0x0019F9FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryPickUpItemResponse Clone()
		{
			return new HonamiStoryPickUpItemResponse(this);
		}

		// Token: 0x17002304 RID: 8964
		// (get) Token: 0x0600ADAB RID: 44459 RVA: 0x001A1806 File Offset: 0x0019FA06
		// (set) Token: 0x0600ADAC RID: 44460 RVA: 0x001A180E File Offset: 0x0019FA0E
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

		// Token: 0x0600ADAD RID: 44461 RVA: 0x001A1817 File Offset: 0x0019FA17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HonamiStoryPickUpItemResponse);
		}

		// Token: 0x0600ADAE RID: 44462 RVA: 0x001A1825 File Offset: 0x0019FA25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HonamiStoryPickUpItemResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600ADAF RID: 44463 RVA: 0x001A1854 File Offset: 0x0019FA54
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

		// Token: 0x0600ADB0 RID: 44464 RVA: 0x001A1899 File Offset: 0x0019FA99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600ADB1 RID: 44465 RVA: 0x001A18A6 File Offset: 0x0019FAA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600ADB2 RID: 44466 RVA: 0x001A18AF File Offset: 0x0019FAAF
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

		// Token: 0x0600ADB3 RID: 44467 RVA: 0x001A18E4 File Offset: 0x0019FAE4
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

		// Token: 0x0600ADB4 RID: 44468 RVA: 0x001A1922 File Offset: 0x0019FB22
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

		// Token: 0x0600ADB5 RID: 44469 RVA: 0x001A1953 File Offset: 0x0019FB53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600ADB6 RID: 44470 RVA: 0x001A195C File Offset: 0x0019FB5C
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

		// Token: 0x04004ED2 RID: 20178
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004ED3 RID: 20179
		public const int ErrorCodeFieldNumber = 11;

		// Token: 0x04004ED4 RID: 20180
		private ErrorCode errorCode_;
	}
}
