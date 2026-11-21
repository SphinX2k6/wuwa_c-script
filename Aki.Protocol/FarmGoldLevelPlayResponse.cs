using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000510 RID: 1296
	[NetMessage(EMessageId.FarmGoldLevelPlayResponse)]
	public sealed class FarmGoldLevelPlayResponse : IMessage<FarmGoldLevelPlayResponse>, IMessage, IEquatable<FarmGoldLevelPlayResponse>, IDeepCloneable<FarmGoldLevelPlayResponse>, IBufferMessage
	{
		// Token: 0x06007A2C RID: 31276 RVA: 0x0012901C File Offset: 0x0012721C
		[NullableContext(1)]
		public static FarmGoldLevelPlayResponse Create()
		{
			return new FarmGoldLevelPlayResponse();
		}

		// Token: 0x170017AD RID: 6061
		// (get) Token: 0x06007A2D RID: 31277 RVA: 0x00129023 File Offset: 0x00127223
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170017AE RID: 6062
		// (get) Token: 0x06007A2E RID: 31278 RVA: 0x00129026 File Offset: 0x00127226
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FarmGoldLevelPlayResponse.Descriptor;
			}
		}

		// Token: 0x06007A2F RID: 31279 RVA: 0x0012902D File Offset: 0x0012722D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FarmGoldLevelPlayResponse()
		{
		}

		// Token: 0x06007A30 RID: 31280 RVA: 0x00129035 File Offset: 0x00127235
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FarmGoldLevelPlayResponse(FarmGoldLevelPlayResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007A31 RID: 31281 RVA: 0x0012905A File Offset: 0x0012725A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FarmGoldLevelPlayResponse Clone()
		{
			return new FarmGoldLevelPlayResponse(this);
		}

		// Token: 0x170017AF RID: 6063
		// (get) Token: 0x06007A32 RID: 31282 RVA: 0x00129062 File Offset: 0x00127262
		// (set) Token: 0x06007A33 RID: 31283 RVA: 0x0012906A File Offset: 0x0012726A
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

		// Token: 0x06007A34 RID: 31284 RVA: 0x00129073 File Offset: 0x00127273
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FarmGoldLevelPlayResponse);
		}

		// Token: 0x06007A35 RID: 31285 RVA: 0x00129081 File Offset: 0x00127281
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FarmGoldLevelPlayResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007A36 RID: 31286 RVA: 0x001290B0 File Offset: 0x001272B0
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

		// Token: 0x06007A37 RID: 31287 RVA: 0x001290F5 File Offset: 0x001272F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007A38 RID: 31288 RVA: 0x00129102 File Offset: 0x00127302
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007A39 RID: 31289 RVA: 0x0012910B File Offset: 0x0012730B
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

		// Token: 0x06007A3A RID: 31290 RVA: 0x00129140 File Offset: 0x00127340
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

		// Token: 0x06007A3B RID: 31291 RVA: 0x0012917E File Offset: 0x0012737E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FarmGoldLevelPlayResponse other)
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

		// Token: 0x06007A3C RID: 31292 RVA: 0x001291AF File Offset: 0x001273AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007A3D RID: 31293 RVA: 0x001291B8 File Offset: 0x001273B8
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

		// Token: 0x04003F2E RID: 16174
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003F2F RID: 16175
		public const int ErrorCodeFieldNumber = 11;

		// Token: 0x04003F30 RID: 16176
		private ErrorCode errorCode_;
	}
}
