using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012D4 RID: 4820
	[NetMessage(EMessageId.SurvivorsNormalAwardResponse)]
	public sealed class SurvivorsNormalAwardResponse : IMessage<SurvivorsNormalAwardResponse>, IMessage, IEquatable<SurvivorsNormalAwardResponse>, IDeepCloneable<SurvivorsNormalAwardResponse>, IBufferMessage
	{
		// Token: 0x06019A41 RID: 105025 RVA: 0x003BA185 File Offset: 0x003B8385
		[NullableContext(1)]
		public static SurvivorsNormalAwardResponse Create()
		{
			return new SurvivorsNormalAwardResponse();
		}

		// Token: 0x1700567E RID: 22142
		// (get) Token: 0x06019A42 RID: 105026 RVA: 0x003BA18C File Offset: 0x003B838C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700567F RID: 22143
		// (get) Token: 0x06019A43 RID: 105027 RVA: 0x003BA18F File Offset: 0x003B838F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SurvivorsNormalAwardResponse.Descriptor;
			}
		}

		// Token: 0x06019A44 RID: 105028 RVA: 0x003BA196 File Offset: 0x003B8396
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsNormalAwardResponse()
		{
		}

		// Token: 0x06019A45 RID: 105029 RVA: 0x003BA19E File Offset: 0x003B839E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsNormalAwardResponse(SurvivorsNormalAwardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019A46 RID: 105030 RVA: 0x003BA1C3 File Offset: 0x003B83C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsNormalAwardResponse Clone()
		{
			return new SurvivorsNormalAwardResponse(this);
		}

		// Token: 0x17005680 RID: 22144
		// (get) Token: 0x06019A47 RID: 105031 RVA: 0x003BA1CB File Offset: 0x003B83CB
		// (set) Token: 0x06019A48 RID: 105032 RVA: 0x003BA1D3 File Offset: 0x003B83D3
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

		// Token: 0x06019A49 RID: 105033 RVA: 0x003BA1DC File Offset: 0x003B83DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SurvivorsNormalAwardResponse);
		}

		// Token: 0x06019A4A RID: 105034 RVA: 0x003BA1EA File Offset: 0x003B83EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SurvivorsNormalAwardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019A4B RID: 105035 RVA: 0x003BA218 File Offset: 0x003B8418
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

		// Token: 0x06019A4C RID: 105036 RVA: 0x003BA25D File Offset: 0x003B845D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019A4D RID: 105037 RVA: 0x003BA26A File Offset: 0x003B846A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019A4E RID: 105038 RVA: 0x003BA273 File Offset: 0x003B8473
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

		// Token: 0x06019A4F RID: 105039 RVA: 0x003BA2A8 File Offset: 0x003B84A8
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

		// Token: 0x06019A50 RID: 105040 RVA: 0x003BA2E6 File Offset: 0x003B84E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SurvivorsNormalAwardResponse other)
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

		// Token: 0x06019A51 RID: 105041 RVA: 0x003BA317 File Offset: 0x003B8517
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019A52 RID: 105042 RVA: 0x003BA320 File Offset: 0x003B8520
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

		// Token: 0x04009655 RID: 38485
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009656 RID: 38486
		public const int ErrorCodeFieldNumber = 5;

		// Token: 0x04009657 RID: 38487
		private ErrorCode errorCode_;
	}
}
