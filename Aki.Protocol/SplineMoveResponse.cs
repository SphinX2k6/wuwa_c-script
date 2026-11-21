using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012DD RID: 4829
	[NetMessage(EMessageId.SplineMoveResponse)]
	public sealed class SplineMoveResponse : IMessage<SplineMoveResponse>, IMessage, IEquatable<SplineMoveResponse>, IDeepCloneable<SplineMoveResponse>, IBufferMessage
	{
		// Token: 0x06019C52 RID: 105554 RVA: 0x003C2513 File Offset: 0x003C0713
		[NullableContext(1)]
		public static SplineMoveResponse Create()
		{
			return new SplineMoveResponse();
		}

		// Token: 0x17005744 RID: 22340
		// (get) Token: 0x06019C53 RID: 105555 RVA: 0x003C251A File Offset: 0x003C071A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005745 RID: 22341
		// (get) Token: 0x06019C54 RID: 105556 RVA: 0x003C251D File Offset: 0x003C071D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SplineMoveResponse.Descriptor;
			}
		}

		// Token: 0x06019C55 RID: 105557 RVA: 0x003C2524 File Offset: 0x003C0724
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SplineMoveResponse()
		{
		}

		// Token: 0x06019C56 RID: 105558 RVA: 0x003C252C File Offset: 0x003C072C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SplineMoveResponse(SplineMoveResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019C57 RID: 105559 RVA: 0x003C2551 File Offset: 0x003C0751
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SplineMoveResponse Clone()
		{
			return new SplineMoveResponse(this);
		}

		// Token: 0x17005746 RID: 22342
		// (get) Token: 0x06019C58 RID: 105560 RVA: 0x003C2559 File Offset: 0x003C0759
		// (set) Token: 0x06019C59 RID: 105561 RVA: 0x003C2561 File Offset: 0x003C0761
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

		// Token: 0x06019C5A RID: 105562 RVA: 0x003C256A File Offset: 0x003C076A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SplineMoveResponse);
		}

		// Token: 0x06019C5B RID: 105563 RVA: 0x003C2578 File Offset: 0x003C0778
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SplineMoveResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019C5C RID: 105564 RVA: 0x003C25A8 File Offset: 0x003C07A8
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

		// Token: 0x06019C5D RID: 105565 RVA: 0x003C25ED File Offset: 0x003C07ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019C5E RID: 105566 RVA: 0x003C25FA File Offset: 0x003C07FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019C5F RID: 105567 RVA: 0x003C2603 File Offset: 0x003C0803
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

		// Token: 0x06019C60 RID: 105568 RVA: 0x003C2638 File Offset: 0x003C0838
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

		// Token: 0x06019C61 RID: 105569 RVA: 0x003C2676 File Offset: 0x003C0876
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SplineMoveResponse other)
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

		// Token: 0x06019C62 RID: 105570 RVA: 0x003C26A7 File Offset: 0x003C08A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019C63 RID: 105571 RVA: 0x003C26B0 File Offset: 0x003C08B0
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

		// Token: 0x04009818 RID: 38936
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009819 RID: 38937
		public const int ErrorCodeFieldNumber = 3;

		// Token: 0x0400981A RID: 38938
		private ErrorCode errorCode_;
	}
}
