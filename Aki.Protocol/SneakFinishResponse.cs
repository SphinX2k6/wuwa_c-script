using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001297 RID: 4759
	[NetMessage(EMessageId.SneakFinishResponse)]
	public sealed class SneakFinishResponse : IMessage<SneakFinishResponse>, IMessage, IEquatable<SneakFinishResponse>, IDeepCloneable<SneakFinishResponse>, IBufferMessage
	{
		// Token: 0x06019669 RID: 104041 RVA: 0x003B4548 File Offset: 0x003B2748
		[NullableContext(1)]
		public static SneakFinishResponse Create()
		{
			return new SneakFinishResponse();
		}

		// Token: 0x170055EB RID: 21995
		// (get) Token: 0x0601966A RID: 104042 RVA: 0x003B454F File Offset: 0x003B274F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170055EC RID: 21996
		// (get) Token: 0x0601966B RID: 104043 RVA: 0x003B4552 File Offset: 0x003B2752
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SneakFinishResponse.Descriptor;
			}
		}

		// Token: 0x0601966C RID: 104044 RVA: 0x003B4559 File Offset: 0x003B2759
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SneakFinishResponse()
		{
		}

		// Token: 0x0601966D RID: 104045 RVA: 0x003B4561 File Offset: 0x003B2761
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SneakFinishResponse(SneakFinishResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601966E RID: 104046 RVA: 0x003B4586 File Offset: 0x003B2786
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SneakFinishResponse Clone()
		{
			return new SneakFinishResponse(this);
		}

		// Token: 0x170055ED RID: 21997
		// (get) Token: 0x0601966F RID: 104047 RVA: 0x003B458E File Offset: 0x003B278E
		// (set) Token: 0x06019670 RID: 104048 RVA: 0x003B4596 File Offset: 0x003B2796
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

		// Token: 0x06019671 RID: 104049 RVA: 0x003B459F File Offset: 0x003B279F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SneakFinishResponse);
		}

		// Token: 0x06019672 RID: 104050 RVA: 0x003B45AD File Offset: 0x003B27AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SneakFinishResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019673 RID: 104051 RVA: 0x003B45DC File Offset: 0x003B27DC
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

		// Token: 0x06019674 RID: 104052 RVA: 0x003B4621 File Offset: 0x003B2821
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019675 RID: 104053 RVA: 0x003B462E File Offset: 0x003B282E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019676 RID: 104054 RVA: 0x003B4637 File Offset: 0x003B2837
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019677 RID: 104055 RVA: 0x003B466C File Offset: 0x003B286C
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

		// Token: 0x06019678 RID: 104056 RVA: 0x003B46AA File Offset: 0x003B28AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SneakFinishResponse other)
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

		// Token: 0x06019679 RID: 104057 RVA: 0x003B46DB File Offset: 0x003B28DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601967A RID: 104058 RVA: 0x003B46E4 File Offset: 0x003B28E4
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
				if (num != 48U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04009630 RID: 38448
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009631 RID: 38449
		public const int ErrorCodeFieldNumber = 6;

		// Token: 0x04009632 RID: 38450
		private ErrorCode errorCode_;
	}
}
