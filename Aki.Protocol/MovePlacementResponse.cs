using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000ABE RID: 2750
	[NetMessage(EMessageId.MovePlacementResponse)]
	public sealed class MovePlacementResponse : IMessage<MovePlacementResponse>, IMessage, IEquatable<MovePlacementResponse>, IDeepCloneable<MovePlacementResponse>, IBufferMessage
	{
		// Token: 0x0600EF4E RID: 61262 RVA: 0x0022EE64 File Offset: 0x0022D064
		[NullableContext(1)]
		public static MovePlacementResponse Create()
		{
			return new MovePlacementResponse();
		}

		// Token: 0x170030A6 RID: 12454
		// (get) Token: 0x0600EF4F RID: 61263 RVA: 0x0022EE6B File Offset: 0x0022D06B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170030A7 RID: 12455
		// (get) Token: 0x0600EF50 RID: 61264 RVA: 0x0022EE6E File Offset: 0x0022D06E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MovePlacementResponse.Descriptor;
			}
		}

		// Token: 0x0600EF51 RID: 61265 RVA: 0x0022EE75 File Offset: 0x0022D075
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MovePlacementResponse()
		{
		}

		// Token: 0x0600EF52 RID: 61266 RVA: 0x0022EE7D File Offset: 0x0022D07D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MovePlacementResponse(MovePlacementResponse other) : this()
		{
			this.errCode_ = other.errCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600EF53 RID: 61267 RVA: 0x0022EEA2 File Offset: 0x0022D0A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MovePlacementResponse Clone()
		{
			return new MovePlacementResponse(this);
		}

		// Token: 0x170030A8 RID: 12456
		// (get) Token: 0x0600EF54 RID: 61268 RVA: 0x0022EEAA File Offset: 0x0022D0AA
		// (set) Token: 0x0600EF55 RID: 61269 RVA: 0x0022EEB2 File Offset: 0x0022D0B2
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

		// Token: 0x0600EF56 RID: 61270 RVA: 0x0022EEBB File Offset: 0x0022D0BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MovePlacementResponse);
		}

		// Token: 0x0600EF57 RID: 61271 RVA: 0x0022EEC9 File Offset: 0x0022D0C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MovePlacementResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600EF58 RID: 61272 RVA: 0x0022EEF8 File Offset: 0x0022D0F8
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

		// Token: 0x0600EF59 RID: 61273 RVA: 0x0022EF3D File Offset: 0x0022D13D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600EF5A RID: 61274 RVA: 0x0022EF4A File Offset: 0x0022D14A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600EF5B RID: 61275 RVA: 0x0022EF53 File Offset: 0x0022D153
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrCode != ErrorCode.Success)
			{
				output.WriteRawTag(104);
				output.WriteEnum((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600EF5C RID: 61276 RVA: 0x0022EF88 File Offset: 0x0022D188
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

		// Token: 0x0600EF5D RID: 61277 RVA: 0x0022EFC6 File Offset: 0x0022D1C6
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

		// Token: 0x0600EF5E RID: 61278 RVA: 0x0022EFF7 File Offset: 0x0022D1F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600EF5F RID: 61279 RVA: 0x0022F000 File Offset: 0x0022D200
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
				if (num != 104U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040060BE RID: 24766
		private UnknownFieldSet _unknownFields;

		// Token: 0x040060BF RID: 24767
		public const int ErrCodeFieldNumber = 13;

		// Token: 0x040060C0 RID: 24768
		private ErrorCode errCode_;
	}
}
