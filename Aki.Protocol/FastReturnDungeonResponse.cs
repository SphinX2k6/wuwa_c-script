using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000519 RID: 1305
	[NetMessage(EMessageId.FastReturnDungeonResponse)]
	public sealed class FastReturnDungeonResponse : IMessage<FastReturnDungeonResponse>, IMessage, IEquatable<FastReturnDungeonResponse>, IDeepCloneable<FastReturnDungeonResponse>, IBufferMessage
	{
		// Token: 0x06007ADE RID: 31454 RVA: 0x0012A6B6 File Offset: 0x001288B6
		[NullableContext(1)]
		public static FastReturnDungeonResponse Create()
		{
			return new FastReturnDungeonResponse();
		}

		// Token: 0x170017D0 RID: 6096
		// (get) Token: 0x06007ADF RID: 31455 RVA: 0x0012A6BD File Offset: 0x001288BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170017D1 RID: 6097
		// (get) Token: 0x06007AE0 RID: 31456 RVA: 0x0012A6C0 File Offset: 0x001288C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FastReturnDungeonResponse.Descriptor;
			}
		}

		// Token: 0x06007AE1 RID: 31457 RVA: 0x0012A6C7 File Offset: 0x001288C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FastReturnDungeonResponse()
		{
		}

		// Token: 0x06007AE2 RID: 31458 RVA: 0x0012A6CF File Offset: 0x001288CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FastReturnDungeonResponse(FastReturnDungeonResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007AE3 RID: 31459 RVA: 0x0012A6F4 File Offset: 0x001288F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FastReturnDungeonResponse Clone()
		{
			return new FastReturnDungeonResponse(this);
		}

		// Token: 0x170017D2 RID: 6098
		// (get) Token: 0x06007AE4 RID: 31460 RVA: 0x0012A6FC File Offset: 0x001288FC
		// (set) Token: 0x06007AE5 RID: 31461 RVA: 0x0012A704 File Offset: 0x00128904
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

		// Token: 0x06007AE6 RID: 31462 RVA: 0x0012A70D File Offset: 0x0012890D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FastReturnDungeonResponse);
		}

		// Token: 0x06007AE7 RID: 31463 RVA: 0x0012A71B File Offset: 0x0012891B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FastReturnDungeonResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007AE8 RID: 31464 RVA: 0x0012A74C File Offset: 0x0012894C
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

		// Token: 0x06007AE9 RID: 31465 RVA: 0x0012A791 File Offset: 0x00128991
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007AEA RID: 31466 RVA: 0x0012A79E File Offset: 0x0012899E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007AEB RID: 31467 RVA: 0x0012A7A7 File Offset: 0x001289A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(72);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007AEC RID: 31468 RVA: 0x0012A7DC File Offset: 0x001289DC
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

		// Token: 0x06007AED RID: 31469 RVA: 0x0012A81A File Offset: 0x00128A1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FastReturnDungeonResponse other)
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

		// Token: 0x06007AEE RID: 31470 RVA: 0x0012A84B File Offset: 0x00128A4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007AEF RID: 31471 RVA: 0x0012A854 File Offset: 0x00128A54
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
				if (num != 72U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04003F5B RID: 16219
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003F5C RID: 16220
		public const int ErrorCodeFieldNumber = 9;

		// Token: 0x04003F5D RID: 16221
		private ErrorCode errorCode_;
	}
}
