using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E7A RID: 3706
	[NetMessage(EMessageId.RacingBetsTaskResponse)]
	public sealed class RacingBetsTaskResponse : IMessage<RacingBetsTaskResponse>, IMessage, IEquatable<RacingBetsTaskResponse>, IDeepCloneable<RacingBetsTaskResponse>, IBufferMessage
	{
		// Token: 0x06013E7D RID: 81533 RVA: 0x002E6039 File Offset: 0x002E4239
		[NullableContext(1)]
		public static RacingBetsTaskResponse Create()
		{
			return new RacingBetsTaskResponse();
		}

		// Token: 0x17004232 RID: 16946
		// (get) Token: 0x06013E7E RID: 81534 RVA: 0x002E6040 File Offset: 0x002E4240
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004233 RID: 16947
		// (get) Token: 0x06013E7F RID: 81535 RVA: 0x002E6043 File Offset: 0x002E4243
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RacingBetsTaskResponse.Descriptor;
			}
		}

		// Token: 0x06013E80 RID: 81536 RVA: 0x002E604A File Offset: 0x002E424A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsTaskResponse()
		{
		}

		// Token: 0x06013E81 RID: 81537 RVA: 0x002E6052 File Offset: 0x002E4252
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsTaskResponse(RacingBetsTaskResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013E82 RID: 81538 RVA: 0x002E6077 File Offset: 0x002E4277
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsTaskResponse Clone()
		{
			return new RacingBetsTaskResponse(this);
		}

		// Token: 0x17004234 RID: 16948
		// (get) Token: 0x06013E83 RID: 81539 RVA: 0x002E607F File Offset: 0x002E427F
		// (set) Token: 0x06013E84 RID: 81540 RVA: 0x002E6087 File Offset: 0x002E4287
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

		// Token: 0x06013E85 RID: 81541 RVA: 0x002E6090 File Offset: 0x002E4290
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RacingBetsTaskResponse);
		}

		// Token: 0x06013E86 RID: 81542 RVA: 0x002E609E File Offset: 0x002E429E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RacingBetsTaskResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013E87 RID: 81543 RVA: 0x002E60CC File Offset: 0x002E42CC
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

		// Token: 0x06013E88 RID: 81544 RVA: 0x002E6111 File Offset: 0x002E4311
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013E89 RID: 81545 RVA: 0x002E611E File Offset: 0x002E431E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013E8A RID: 81546 RVA: 0x002E6127 File Offset: 0x002E4327
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

		// Token: 0x06013E8B RID: 81547 RVA: 0x002E615C File Offset: 0x002E435C
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

		// Token: 0x06013E8C RID: 81548 RVA: 0x002E619A File Offset: 0x002E439A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RacingBetsTaskResponse other)
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

		// Token: 0x06013E8D RID: 81549 RVA: 0x002E61CB File Offset: 0x002E43CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013E8E RID: 81550 RVA: 0x002E61D4 File Offset: 0x002E43D4
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

		// Token: 0x040079AD RID: 31149
		private UnknownFieldSet _unknownFields;

		// Token: 0x040079AE RID: 31150
		public const int ErrorCodeFieldNumber = 6;

		// Token: 0x040079AF RID: 31151
		private ErrorCode errorCode_;
	}
}
