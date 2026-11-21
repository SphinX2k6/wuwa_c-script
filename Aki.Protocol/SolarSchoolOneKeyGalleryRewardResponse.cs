using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012B5 RID: 4789
	[NetMessage(EMessageId.SolarSchoolOneKeyGalleryRewardResponse)]
	public sealed class SolarSchoolOneKeyGalleryRewardResponse : IMessage<SolarSchoolOneKeyGalleryRewardResponse>, IMessage, IEquatable<SolarSchoolOneKeyGalleryRewardResponse>, IDeepCloneable<SolarSchoolOneKeyGalleryRewardResponse>, IBufferMessage
	{
		// Token: 0x06019900 RID: 104704 RVA: 0x003BA861 File Offset: 0x003B8A61
		[NullableContext(1)]
		public static SolarSchoolOneKeyGalleryRewardResponse Create()
		{
			return new SolarSchoolOneKeyGalleryRewardResponse();
		}

		// Token: 0x17005685 RID: 22149
		// (get) Token: 0x06019901 RID: 104705 RVA: 0x003BA868 File Offset: 0x003B8A68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005686 RID: 22150
		// (get) Token: 0x06019902 RID: 104706 RVA: 0x003BA86B File Offset: 0x003B8A6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SolarSchoolOneKeyGalleryRewardResponse.Descriptor;
			}
		}

		// Token: 0x06019903 RID: 104707 RVA: 0x003BA872 File Offset: 0x003B8A72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolOneKeyGalleryRewardResponse()
		{
		}

		// Token: 0x06019904 RID: 104708 RVA: 0x003BA87A File Offset: 0x003B8A7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolOneKeyGalleryRewardResponse(SolarSchoolOneKeyGalleryRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019905 RID: 104709 RVA: 0x003BA89F File Offset: 0x003B8A9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolOneKeyGalleryRewardResponse Clone()
		{
			return new SolarSchoolOneKeyGalleryRewardResponse(this);
		}

		// Token: 0x17005687 RID: 22151
		// (get) Token: 0x06019906 RID: 104710 RVA: 0x003BA8A7 File Offset: 0x003B8AA7
		// (set) Token: 0x06019907 RID: 104711 RVA: 0x003BA8AF File Offset: 0x003B8AAF
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

		// Token: 0x06019908 RID: 104712 RVA: 0x003BA8B8 File Offset: 0x003B8AB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SolarSchoolOneKeyGalleryRewardResponse);
		}

		// Token: 0x06019909 RID: 104713 RVA: 0x003BA8C6 File Offset: 0x003B8AC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SolarSchoolOneKeyGalleryRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601990A RID: 104714 RVA: 0x003BA8F4 File Offset: 0x003B8AF4
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

		// Token: 0x0601990B RID: 104715 RVA: 0x003BA939 File Offset: 0x003B8B39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601990C RID: 104716 RVA: 0x003BA946 File Offset: 0x003B8B46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601990D RID: 104717 RVA: 0x003BA94F File Offset: 0x003B8B4F
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

		// Token: 0x0601990E RID: 104718 RVA: 0x003BA984 File Offset: 0x003B8B84
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

		// Token: 0x0601990F RID: 104719 RVA: 0x003BA9C2 File Offset: 0x003B8BC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SolarSchoolOneKeyGalleryRewardResponse other)
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

		// Token: 0x06019910 RID: 104720 RVA: 0x003BA9F3 File Offset: 0x003B8BF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019911 RID: 104721 RVA: 0x003BA9FC File Offset: 0x003B8BFC
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

		// Token: 0x04009707 RID: 38663
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009708 RID: 38664
		public const int ErrorCodeFieldNumber = 6;

		// Token: 0x04009709 RID: 38665
		private ErrorCode errorCode_;
	}
}
