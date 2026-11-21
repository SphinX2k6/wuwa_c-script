using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000AAD RID: 2733
	[NetMessage(EMessageId.MovePlacementResponse)]
	public sealed class MovePlacementResponse : IMessage<MovePlacementResponse>, IMessage, IEquatable<MovePlacementResponse>, IDeepCloneable<MovePlacementResponse>, IBufferMessage
	{
		// Token: 0x0600EE34 RID: 60980 RVA: 0x0022CC63 File Offset: 0x0022AE63
		[NullableContext(1)]
		public static MovePlacementResponse Create()
		{
			return new MovePlacementResponse();
		}

		// Token: 0x17003068 RID: 12392
		// (get) Token: 0x0600EE35 RID: 60981 RVA: 0x0022CC6A File Offset: 0x0022AE6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003069 RID: 12393
		// (get) Token: 0x0600EE36 RID: 60982 RVA: 0x0022CC6D File Offset: 0x0022AE6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MovePlacementResponse.Descriptor;
			}
		}

		// Token: 0x0600EE37 RID: 60983 RVA: 0x0022CC74 File Offset: 0x0022AE74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MovePlacementResponse()
		{
		}

		// Token: 0x0600EE38 RID: 60984 RVA: 0x0022CC7C File Offset: 0x0022AE7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MovePlacementResponse(MovePlacementResponse other) : this()
		{
			this.errCode_ = other.errCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600EE39 RID: 60985 RVA: 0x0022CCA1 File Offset: 0x0022AEA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MovePlacementResponse Clone()
		{
			return new MovePlacementResponse(this);
		}

		// Token: 0x1700306A RID: 12394
		// (get) Token: 0x0600EE3A RID: 60986 RVA: 0x0022CCA9 File Offset: 0x0022AEA9
		// (set) Token: 0x0600EE3B RID: 60987 RVA: 0x0022CCB1 File Offset: 0x0022AEB1
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

		// Token: 0x0600EE3C RID: 60988 RVA: 0x0022CCBA File Offset: 0x0022AEBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MovePlacementResponse);
		}

		// Token: 0x0600EE3D RID: 60989 RVA: 0x0022CCC8 File Offset: 0x0022AEC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MovePlacementResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600EE3E RID: 60990 RVA: 0x0022CCF8 File Offset: 0x0022AEF8
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

		// Token: 0x0600EE3F RID: 60991 RVA: 0x0022CD3D File Offset: 0x0022AF3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600EE40 RID: 60992 RVA: 0x0022CD4A File Offset: 0x0022AF4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600EE41 RID: 60993 RVA: 0x0022CD53 File Offset: 0x0022AF53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrCode != ErrorCode.Success)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600EE42 RID: 60994 RVA: 0x0022CD84 File Offset: 0x0022AF84
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

		// Token: 0x0600EE43 RID: 60995 RVA: 0x0022CDC2 File Offset: 0x0022AFC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MovePlacementResponse other)
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

		// Token: 0x0600EE44 RID: 60996 RVA: 0x0022CDF3 File Offset: 0x0022AFF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600EE45 RID: 60997 RVA: 0x0022CDFC File Offset: 0x0022AFFC
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
				if (num != 8U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040060C7 RID: 24775
		private UnknownFieldSet _unknownFields;

		// Token: 0x040060C8 RID: 24776
		public const int ErrCodeFieldNumber = 1;

		// Token: 0x040060C9 RID: 24777
		private ErrorCode errCode_;
	}
}
