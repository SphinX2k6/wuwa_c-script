using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000575 RID: 1397
	[NetMessage(EMessageId.FishingQuickSellResponse)]
	public sealed class FishingQuickSellResponse : IMessage<FishingQuickSellResponse>, IMessage, IEquatable<FishingQuickSellResponse>, IDeepCloneable<FishingQuickSellResponse>, IBufferMessage
	{
		// Token: 0x060081F8 RID: 33272 RVA: 0x00139CCE File Offset: 0x00137ECE
		[NullableContext(1)]
		public static FishingQuickSellResponse Create()
		{
			return new FishingQuickSellResponse();
		}

		// Token: 0x17001957 RID: 6487
		// (get) Token: 0x060081F9 RID: 33273 RVA: 0x00139CD5 File Offset: 0x00137ED5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001958 RID: 6488
		// (get) Token: 0x060081FA RID: 33274 RVA: 0x00139CD8 File Offset: 0x00137ED8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingQuickSellResponse.Descriptor;
			}
		}

		// Token: 0x060081FB RID: 33275 RVA: 0x00139CDF File Offset: 0x00137EDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingQuickSellResponse()
		{
		}

		// Token: 0x060081FC RID: 33276 RVA: 0x00139CE7 File Offset: 0x00137EE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingQuickSellResponse(FishingQuickSellResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060081FD RID: 33277 RVA: 0x00139D0C File Offset: 0x00137F0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingQuickSellResponse Clone()
		{
			return new FishingQuickSellResponse(this);
		}

		// Token: 0x17001959 RID: 6489
		// (get) Token: 0x060081FE RID: 33278 RVA: 0x00139D14 File Offset: 0x00137F14
		// (set) Token: 0x060081FF RID: 33279 RVA: 0x00139D1C File Offset: 0x00137F1C
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

		// Token: 0x06008200 RID: 33280 RVA: 0x00139D25 File Offset: 0x00137F25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingQuickSellResponse);
		}

		// Token: 0x06008201 RID: 33281 RVA: 0x00139D33 File Offset: 0x00137F33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingQuickSellResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008202 RID: 33282 RVA: 0x00139D64 File Offset: 0x00137F64
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

		// Token: 0x06008203 RID: 33283 RVA: 0x00139DA9 File Offset: 0x00137FA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008204 RID: 33284 RVA: 0x00139DB6 File Offset: 0x00137FB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008205 RID: 33285 RVA: 0x00139DBF File Offset: 0x00137FBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(72);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008206 RID: 33286 RVA: 0x00139DF4 File Offset: 0x00137FF4
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

		// Token: 0x06008207 RID: 33287 RVA: 0x00139E32 File Offset: 0x00138032
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FishingQuickSellResponse other)
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

		// Token: 0x06008208 RID: 33288 RVA: 0x00139E63 File Offset: 0x00138063
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008209 RID: 33289 RVA: 0x00139E6C File Offset: 0x0013806C
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
				if (num != 72U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04004125 RID: 16677
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004126 RID: 16678
		public const int ErrorCodeFieldNumber = 9;

		// Token: 0x04004127 RID: 16679
		private ErrorCode errorCode_;
	}
}
