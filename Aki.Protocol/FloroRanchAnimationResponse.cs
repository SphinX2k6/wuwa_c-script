using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005A9 RID: 1449
	[NetMessage(EMessageId.FloroRanchAnimationResponse)]
	public sealed class FloroRanchAnimationResponse : IMessage<FloroRanchAnimationResponse>, IMessage, IEquatable<FloroRanchAnimationResponse>, IDeepCloneable<FloroRanchAnimationResponse>, IBufferMessage
	{
		// Token: 0x060085F5 RID: 34293 RVA: 0x00141F6D File Offset: 0x0014016D
		[NullableContext(1)]
		public static FloroRanchAnimationResponse Create()
		{
			return new FloroRanchAnimationResponse();
		}

		// Token: 0x17001A1F RID: 6687
		// (get) Token: 0x060085F6 RID: 34294 RVA: 0x00141F74 File Offset: 0x00140174
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001A20 RID: 6688
		// (get) Token: 0x060085F7 RID: 34295 RVA: 0x00141F77 File Offset: 0x00140177
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FloroRanchAnimationResponse.Descriptor;
			}
		}

		// Token: 0x060085F8 RID: 34296 RVA: 0x00141F7E File Offset: 0x0014017E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchAnimationResponse()
		{
		}

		// Token: 0x060085F9 RID: 34297 RVA: 0x00141F86 File Offset: 0x00140186
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchAnimationResponse(FloroRanchAnimationResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060085FA RID: 34298 RVA: 0x00141FAB File Offset: 0x001401AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchAnimationResponse Clone()
		{
			return new FloroRanchAnimationResponse(this);
		}

		// Token: 0x17001A21 RID: 6689
		// (get) Token: 0x060085FB RID: 34299 RVA: 0x00141FB3 File Offset: 0x001401B3
		// (set) Token: 0x060085FC RID: 34300 RVA: 0x00141FBB File Offset: 0x001401BB
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

		// Token: 0x060085FD RID: 34301 RVA: 0x00141FC4 File Offset: 0x001401C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FloroRanchAnimationResponse);
		}

		// Token: 0x060085FE RID: 34302 RVA: 0x00141FD2 File Offset: 0x001401D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FloroRanchAnimationResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060085FF RID: 34303 RVA: 0x00142000 File Offset: 0x00140200
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

		// Token: 0x06008600 RID: 34304 RVA: 0x00142045 File Offset: 0x00140245
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008601 RID: 34305 RVA: 0x00142052 File Offset: 0x00140252
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008602 RID: 34306 RVA: 0x0014205B File Offset: 0x0014025B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008603 RID: 34307 RVA: 0x00142090 File Offset: 0x00140290
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

		// Token: 0x06008604 RID: 34308 RVA: 0x001420CE File Offset: 0x001402CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FloroRanchAnimationResponse other)
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

		// Token: 0x06008605 RID: 34309 RVA: 0x001420FF File Offset: 0x001402FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008606 RID: 34310 RVA: 0x00142108 File Offset: 0x00140308
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
				if (num != 80U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04004224 RID: 16932
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004225 RID: 16933
		public const int ErrorCodeFieldNumber = 10;

		// Token: 0x04004226 RID: 16934
		private ErrorCode errorCode_;
	}
}
