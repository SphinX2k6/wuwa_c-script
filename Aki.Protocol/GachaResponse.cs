using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000689 RID: 1673
	[NetMessage(EMessageId.GachaResponse)]
	public sealed class GachaResponse : IMessage<GachaResponse>, IMessage, IEquatable<GachaResponse>, IDeepCloneable<GachaResponse>, IBufferMessage
	{
		// Token: 0x060099A8 RID: 39336 RVA: 0x00173564 File Offset: 0x00171764
		[NullableContext(1)]
		public static GachaResponse Create()
		{
			return new GachaResponse();
		}

		// Token: 0x17001EB8 RID: 7864
		// (get) Token: 0x060099A9 RID: 39337 RVA: 0x0017356B File Offset: 0x0017176B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001EB9 RID: 7865
		// (get) Token: 0x060099AA RID: 39338 RVA: 0x0017356E File Offset: 0x0017176E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GachaResponse.Descriptor;
			}
		}

		// Token: 0x060099AB RID: 39339 RVA: 0x00173575 File Offset: 0x00171775
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaResponse()
		{
		}

		// Token: 0x060099AC RID: 39340 RVA: 0x00173588 File Offset: 0x00171788
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaResponse(GachaResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.gachaResults_ = other.gachaResults_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060099AD RID: 39341 RVA: 0x001735BE File Offset: 0x001717BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaResponse Clone()
		{
			return new GachaResponse(this);
		}

		// Token: 0x17001EBA RID: 7866
		// (get) Token: 0x060099AE RID: 39342 RVA: 0x001735C6 File Offset: 0x001717C6
		// (set) Token: 0x060099AF RID: 39343 RVA: 0x001735CE File Offset: 0x001717CE
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

		// Token: 0x17001EBB RID: 7867
		// (get) Token: 0x060099B0 RID: 39344 RVA: 0x001735D7 File Offset: 0x001717D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<GachaResult> GachaResults
		{
			get
			{
				return this.gachaResults_;
			}
		}

		// Token: 0x060099B1 RID: 39345 RVA: 0x001735DF File Offset: 0x001717DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GachaResponse);
		}

		// Token: 0x060099B2 RID: 39346 RVA: 0x001735F0 File Offset: 0x001717F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GachaResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.gachaResults_.Equals(other.gachaResults_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060099B3 RID: 39347 RVA: 0x00173640 File Offset: 0x00171840
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			num ^= this.gachaResults_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060099B4 RID: 39348 RVA: 0x00173693 File Offset: 0x00171893
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060099B5 RID: 39349 RVA: 0x001736A0 File Offset: 0x001718A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060099B6 RID: 39350 RVA: 0x001736AC File Offset: 0x001718AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.gachaResults_.WriteTo(ref output, GachaResponse._repeated_gachaResults_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060099B7 RID: 39351 RVA: 0x001736FC File Offset: 0x001718FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.gachaResults_.CalculateSize(GachaResponse._repeated_gachaResults_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060099B8 RID: 39352 RVA: 0x00173750 File Offset: 0x00171950
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GachaResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this.gachaResults_.Add(other.gachaResults_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060099B9 RID: 39353 RVA: 0x0017379D File Offset: 0x0017199D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060099BA RID: 39354 RVA: 0x001737A8 File Offset: 0x001719A8
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
					if (num != 82U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.gachaResults_.AddEntriesFrom(ref input, GachaResponse._repeated_gachaResults_codec);
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400493A RID: 18746
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400493B RID: 18747
		public const int ErrorCodeFieldNumber = 5;

		// Token: 0x0400493C RID: 18748
		private ErrorCode errorCode_;

		// Token: 0x0400493D RID: 18749
		public const int GachaResultsFieldNumber = 10;

		// Token: 0x0400493E RID: 18750
		private static readonly FieldCodec<GachaResult> _repeated_gachaResults_codec = FieldCodec.ForMessage<GachaResult>(82U, GachaResult.Parser);

		// Token: 0x0400493F RID: 18751
		private readonly RepeatedField<GachaResult> gachaResults_ = new RepeatedField<GachaResult>();
	}
}
