using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D7B RID: 3451
	[NetMessage(EMessageId.PlayerEnterPollutionResponse)]
	public sealed class PlayerEnterPollutionResponse : IMessage<PlayerEnterPollutionResponse>, IMessage, IEquatable<PlayerEnterPollutionResponse>, IDeepCloneable<PlayerEnterPollutionResponse>, IBufferMessage
	{
		// Token: 0x06012A34 RID: 76340 RVA: 0x002B922F File Offset: 0x002B742F
		[NullableContext(1)]
		public static PlayerEnterPollutionResponse Create()
		{
			return new PlayerEnterPollutionResponse();
		}

		// Token: 0x17003DDD RID: 15837
		// (get) Token: 0x06012A35 RID: 76341 RVA: 0x002B9236 File Offset: 0x002B7436
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003DDE RID: 15838
		// (get) Token: 0x06012A36 RID: 76342 RVA: 0x002B9239 File Offset: 0x002B7439
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerEnterPollutionResponse.Descriptor;
			}
		}

		// Token: 0x06012A37 RID: 76343 RVA: 0x002B9240 File Offset: 0x002B7440
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerEnterPollutionResponse()
		{
		}

		// Token: 0x06012A38 RID: 76344 RVA: 0x002B9248 File Offset: 0x002B7448
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerEnterPollutionResponse(PlayerEnterPollutionResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012A39 RID: 76345 RVA: 0x002B926D File Offset: 0x002B746D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerEnterPollutionResponse Clone()
		{
			return new PlayerEnterPollutionResponse(this);
		}

		// Token: 0x17003DDF RID: 15839
		// (get) Token: 0x06012A3A RID: 76346 RVA: 0x002B9275 File Offset: 0x002B7475
		// (set) Token: 0x06012A3B RID: 76347 RVA: 0x002B927D File Offset: 0x002B747D
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

		// Token: 0x06012A3C RID: 76348 RVA: 0x002B9286 File Offset: 0x002B7486
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerEnterPollutionResponse);
		}

		// Token: 0x06012A3D RID: 76349 RVA: 0x002B9294 File Offset: 0x002B7494
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerEnterPollutionResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012A3E RID: 76350 RVA: 0x002B92C4 File Offset: 0x002B74C4
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

		// Token: 0x06012A3F RID: 76351 RVA: 0x002B9309 File Offset: 0x002B7509
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012A40 RID: 76352 RVA: 0x002B9316 File Offset: 0x002B7516
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012A41 RID: 76353 RVA: 0x002B931F File Offset: 0x002B751F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012A42 RID: 76354 RVA: 0x002B9354 File Offset: 0x002B7554
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

		// Token: 0x06012A43 RID: 76355 RVA: 0x002B9392 File Offset: 0x002B7592
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PlayerEnterPollutionResponse other)
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

		// Token: 0x06012A44 RID: 76356 RVA: 0x002B93C3 File Offset: 0x002B75C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012A45 RID: 76357 RVA: 0x002B93CC File Offset: 0x002B75CC
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
				if (num != 24U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04007428 RID: 29736
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007429 RID: 29737
		public const int ErrorCodeFieldNumber = 3;

		// Token: 0x0400742A RID: 29738
		private ErrorCode errorCode_;
	}
}
