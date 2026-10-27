using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000568 RID: 1384
	[NetMessage(EMessageId.FishingInfoResponse)]
	public sealed class FishingInfoResponse : IMessage<FishingInfoResponse>, IMessage, IEquatable<FishingInfoResponse>, IDeepCloneable<FishingInfoResponse>, IBufferMessage
	{
		// Token: 0x060080F7 RID: 33015 RVA: 0x00137AAA File Offset: 0x00135CAA
		[NullableContext(1)]
		public static FishingInfoResponse Create()
		{
			return new FishingInfoResponse();
		}

		// Token: 0x17001923 RID: 6435
		// (get) Token: 0x060080F8 RID: 33016 RVA: 0x00137AB1 File Offset: 0x00135CB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001924 RID: 6436
		// (get) Token: 0x060080F9 RID: 33017 RVA: 0x00137AB4 File Offset: 0x00135CB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingInfoResponse.Descriptor;
			}
		}

		// Token: 0x060080FA RID: 33018 RVA: 0x00137ABB File Offset: 0x00135CBB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingInfoResponse()
		{
		}

		// Token: 0x060080FB RID: 33019 RVA: 0x00137AC3 File Offset: 0x00135CC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingInfoResponse(FishingInfoResponse other) : this()
		{
			this.fishingInfo_ = ((other.fishingInfo_ != null) ? other.fishingInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060080FC RID: 33020 RVA: 0x00137AF8 File Offset: 0x00135CF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingInfoResponse Clone()
		{
			return new FishingInfoResponse(this);
		}

		// Token: 0x17001925 RID: 6437
		// (get) Token: 0x060080FD RID: 33021 RVA: 0x00137B00 File Offset: 0x00135D00
		// (set) Token: 0x060080FE RID: 33022 RVA: 0x00137B08 File Offset: 0x00135D08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingInfo FishingInfo
		{
			get
			{
				return this.fishingInfo_;
			}
			set
			{
				this.fishingInfo_ = value;
			}
		}

		// Token: 0x060080FF RID: 33023 RVA: 0x00137B11 File Offset: 0x00135D11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingInfoResponse);
		}

		// Token: 0x06008100 RID: 33024 RVA: 0x00137B1F File Offset: 0x00135D1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingInfoResponse other)
		{
			return other != null && (other == this || (object.Equals(this.FishingInfo, other.FishingInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008101 RID: 33025 RVA: 0x00137B54 File Offset: 0x00135D54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.fishingInfo_ != null)
			{
				num ^= this.FishingInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008102 RID: 33026 RVA: 0x00137B90 File Offset: 0x00135D90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008103 RID: 33027 RVA: 0x00137B9D File Offset: 0x00135D9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008104 RID: 33028 RVA: 0x00137BA6 File Offset: 0x00135DA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.fishingInfo_ != null)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.FishingInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008105 RID: 33029 RVA: 0x00137BD8 File Offset: 0x00135DD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.fishingInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.FishingInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008106 RID: 33030 RVA: 0x00137C18 File Offset: 0x00135E18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FishingInfoResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.fishingInfo_ != null)
			{
				if (this.fishingInfo_ == null)
				{
					this.FishingInfo = new FishingInfo();
				}
				this.FishingInfo.MergeFrom(other.FishingInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008107 RID: 33031 RVA: 0x00137C6C File Offset: 0x00135E6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008108 RID: 33032 RVA: 0x00137C78 File Offset: 0x00135E78
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
				if (num != 58U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.fishingInfo_ == null)
					{
						this.FishingInfo = new FishingInfo();
					}
					input.ReadMessage(this.FishingInfo);
				}
			}
		}

		// Token: 0x040040DD RID: 16605
		private UnknownFieldSet _unknownFields;

		// Token: 0x040040DE RID: 16606
		public const int FishingInfoFieldNumber = 7;

		// Token: 0x040040DF RID: 16607
		private FishingInfo fishingInfo_;
	}
}
