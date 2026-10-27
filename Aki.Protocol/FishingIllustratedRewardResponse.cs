using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000565 RID: 1381
	[NetMessage(EMessageId.FishingIllustratedRewardResponse)]
	public sealed class FishingIllustratedRewardResponse : IMessage<FishingIllustratedRewardResponse>, IMessage, IEquatable<FishingIllustratedRewardResponse>, IDeepCloneable<FishingIllustratedRewardResponse>, IBufferMessage
	{
		// Token: 0x060080B4 RID: 32948 RVA: 0x00136D2D File Offset: 0x00134F2D
		[NullableContext(1)]
		public static FishingIllustratedRewardResponse Create()
		{
			return new FishingIllustratedRewardResponse();
		}

		// Token: 0x17001910 RID: 6416
		// (get) Token: 0x060080B5 RID: 32949 RVA: 0x00136D34 File Offset: 0x00134F34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001911 RID: 6417
		// (get) Token: 0x060080B6 RID: 32950 RVA: 0x00136D37 File Offset: 0x00134F37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingIllustratedRewardResponse.Descriptor;
			}
		}

		// Token: 0x060080B7 RID: 32951 RVA: 0x00136D3E File Offset: 0x00134F3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingIllustratedRewardResponse()
		{
		}

		// Token: 0x060080B8 RID: 32952 RVA: 0x00136D46 File Offset: 0x00134F46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingIllustratedRewardResponse(FishingIllustratedRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060080B9 RID: 32953 RVA: 0x00136D6B File Offset: 0x00134F6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingIllustratedRewardResponse Clone()
		{
			return new FishingIllustratedRewardResponse(this);
		}

		// Token: 0x17001912 RID: 6418
		// (get) Token: 0x060080BA RID: 32954 RVA: 0x00136D73 File Offset: 0x00134F73
		// (set) Token: 0x060080BB RID: 32955 RVA: 0x00136D7B File Offset: 0x00134F7B
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

		// Token: 0x060080BC RID: 32956 RVA: 0x00136D84 File Offset: 0x00134F84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingIllustratedRewardResponse);
		}

		// Token: 0x060080BD RID: 32957 RVA: 0x00136D92 File Offset: 0x00134F92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingIllustratedRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060080BE RID: 32958 RVA: 0x00136DC0 File Offset: 0x00134FC0
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

		// Token: 0x060080BF RID: 32959 RVA: 0x00136E05 File Offset: 0x00135005
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060080C0 RID: 32960 RVA: 0x00136E12 File Offset: 0x00135012
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060080C1 RID: 32961 RVA: 0x00136E1B File Offset: 0x0013501B
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

		// Token: 0x060080C2 RID: 32962 RVA: 0x00136E50 File Offset: 0x00135050
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

		// Token: 0x060080C3 RID: 32963 RVA: 0x00136E8E File Offset: 0x0013508E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FishingIllustratedRewardResponse other)
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

		// Token: 0x060080C4 RID: 32964 RVA: 0x00136EBF File Offset: 0x001350BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060080C5 RID: 32965 RVA: 0x00136EC8 File Offset: 0x001350C8
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

		// Token: 0x040040B8 RID: 16568
		private UnknownFieldSet _unknownFields;

		// Token: 0x040040B9 RID: 16569
		public const int ErrorCodeFieldNumber = 13;

		// Token: 0x040040BA RID: 16570
		private ErrorCode errorCode_;
	}
}
