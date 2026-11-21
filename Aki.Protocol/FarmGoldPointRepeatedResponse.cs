using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000512 RID: 1298
	[NetMessage(EMessageId.FarmGoldPointRepeatedResponse)]
	public sealed class FarmGoldPointRepeatedResponse : IMessage<FarmGoldPointRepeatedResponse>, IMessage, IEquatable<FarmGoldPointRepeatedResponse>, IDeepCloneable<FarmGoldPointRepeatedResponse>, IBufferMessage
	{
		// Token: 0x06007A52 RID: 31314 RVA: 0x001294A8 File Offset: 0x001276A8
		[NullableContext(1)]
		public static FarmGoldPointRepeatedResponse Create()
		{
			return new FarmGoldPointRepeatedResponse();
		}

		// Token: 0x170017B4 RID: 6068
		// (get) Token: 0x06007A53 RID: 31315 RVA: 0x001294AF File Offset: 0x001276AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170017B5 RID: 6069
		// (get) Token: 0x06007A54 RID: 31316 RVA: 0x001294B2 File Offset: 0x001276B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FarmGoldPointRepeatedResponse.Descriptor;
			}
		}

		// Token: 0x06007A55 RID: 31317 RVA: 0x001294B9 File Offset: 0x001276B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FarmGoldPointRepeatedResponse()
		{
		}

		// Token: 0x06007A56 RID: 31318 RVA: 0x001294C1 File Offset: 0x001276C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FarmGoldPointRepeatedResponse(FarmGoldPointRepeatedResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007A57 RID: 31319 RVA: 0x001294E6 File Offset: 0x001276E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FarmGoldPointRepeatedResponse Clone()
		{
			return new FarmGoldPointRepeatedResponse(this);
		}

		// Token: 0x170017B6 RID: 6070
		// (get) Token: 0x06007A58 RID: 31320 RVA: 0x001294EE File Offset: 0x001276EE
		// (set) Token: 0x06007A59 RID: 31321 RVA: 0x001294F6 File Offset: 0x001276F6
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

		// Token: 0x06007A5A RID: 31322 RVA: 0x001294FF File Offset: 0x001276FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FarmGoldPointRepeatedResponse);
		}

		// Token: 0x06007A5B RID: 31323 RVA: 0x0012950D File Offset: 0x0012770D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FarmGoldPointRepeatedResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007A5C RID: 31324 RVA: 0x0012953C File Offset: 0x0012773C
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

		// Token: 0x06007A5D RID: 31325 RVA: 0x00129581 File Offset: 0x00127781
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007A5E RID: 31326 RVA: 0x0012958E File Offset: 0x0012778E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007A5F RID: 31327 RVA: 0x00129597 File Offset: 0x00127797
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007A60 RID: 31328 RVA: 0x001295CC File Offset: 0x001277CC
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

		// Token: 0x06007A61 RID: 31329 RVA: 0x0012960A File Offset: 0x0012780A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FarmGoldPointRepeatedResponse other)
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

		// Token: 0x06007A62 RID: 31330 RVA: 0x0012963B File Offset: 0x0012783B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007A63 RID: 31331 RVA: 0x00129644 File Offset: 0x00127844
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
				if (num != 64U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04003F37 RID: 16183
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003F38 RID: 16184
		public const int ErrorCodeFieldNumber = 8;

		// Token: 0x04003F39 RID: 16185
		private ErrorCode errorCode_;
	}
}
