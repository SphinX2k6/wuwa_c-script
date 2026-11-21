using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200133E RID: 4926
	[NetMessage(EMessageId.SurvivorsLockResponse)]
	public sealed class SurvivorsLockResponse : IMessage<SurvivorsLockResponse>, IMessage, IEquatable<SurvivorsLockResponse>, IDeepCloneable<SurvivorsLockResponse>, IBufferMessage
	{
		// Token: 0x0601A41D RID: 107549 RVA: 0x003D3F6F File Offset: 0x003D216F
		[NullableContext(1)]
		public static SurvivorsLockResponse Create()
		{
			return new SurvivorsLockResponse();
		}

		// Token: 0x170058F0 RID: 22768
		// (get) Token: 0x0601A41E RID: 107550 RVA: 0x003D3F76 File Offset: 0x003D2176
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170058F1 RID: 22769
		// (get) Token: 0x0601A41F RID: 107551 RVA: 0x003D3F79 File Offset: 0x003D2179
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SurvivorsLockResponse.Descriptor;
			}
		}

		// Token: 0x0601A420 RID: 107552 RVA: 0x003D3F80 File Offset: 0x003D2180
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsLockResponse()
		{
		}

		// Token: 0x0601A421 RID: 107553 RVA: 0x003D3F88 File Offset: 0x003D2188
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsLockResponse(SurvivorsLockResponse other) : this()
		{
			this.errCode_ = other.errCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A422 RID: 107554 RVA: 0x003D3FAD File Offset: 0x003D21AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsLockResponse Clone()
		{
			return new SurvivorsLockResponse(this);
		}

		// Token: 0x170058F2 RID: 22770
		// (get) Token: 0x0601A423 RID: 107555 RVA: 0x003D3FB5 File Offset: 0x003D21B5
		// (set) Token: 0x0601A424 RID: 107556 RVA: 0x003D3FBD File Offset: 0x003D21BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrCode
		{
			get
			{
				return this.errCode_;
			}
			set
			{
				this.errCode_ = value;
			}
		}

		// Token: 0x0601A425 RID: 107557 RVA: 0x003D3FC6 File Offset: 0x003D21C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SurvivorsLockResponse);
		}

		// Token: 0x0601A426 RID: 107558 RVA: 0x003D3FD4 File Offset: 0x003D21D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SurvivorsLockResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A427 RID: 107559 RVA: 0x003D4004 File Offset: 0x003D2204
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrCode != ErrorCode.Success)
			{
				num ^= this.ErrCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601A428 RID: 107560 RVA: 0x003D4049 File Offset: 0x003D2249
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A429 RID: 107561 RVA: 0x003D4056 File Offset: 0x003D2256
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A42A RID: 107562 RVA: 0x003D405F File Offset: 0x003D225F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrCode != ErrorCode.Success)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A42B RID: 107563 RVA: 0x003D4094 File Offset: 0x003D2294
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601A42C RID: 107564 RVA: 0x003D40D2 File Offset: 0x003D22D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SurvivorsLockResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrCode != ErrorCode.Success)
			{
				this.ErrCode = other.ErrCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601A42D RID: 107565 RVA: 0x003D4103 File Offset: 0x003D2303
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A42E RID: 107566 RVA: 0x003D410C File Offset: 0x003D230C
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
					this.ErrCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04009A6F RID: 39535
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009A70 RID: 39536
		public const int ErrCodeFieldNumber = 3;

		// Token: 0x04009A71 RID: 39537
		private ErrorCode errCode_;
	}
}
