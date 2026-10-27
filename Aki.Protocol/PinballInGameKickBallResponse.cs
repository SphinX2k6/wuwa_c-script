using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D4A RID: 3402
	[NetMessage(EMessageId.PinballInGameKickBallResponse)]
	public sealed class PinballInGameKickBallResponse : IMessage<PinballInGameKickBallResponse>, IMessage, IEquatable<PinballInGameKickBallResponse>, IDeepCloneable<PinballInGameKickBallResponse>, IBufferMessage
	{
		// Token: 0x060125A3 RID: 75171 RVA: 0x002AD7E2 File Offset: 0x002AB9E2
		[NullableContext(1)]
		public static PinballInGameKickBallResponse Create()
		{
			return new PinballInGameKickBallResponse();
		}

		// Token: 0x17003CCE RID: 15566
		// (get) Token: 0x060125A4 RID: 75172 RVA: 0x002AD7E9 File Offset: 0x002AB9E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003CCF RID: 15567
		// (get) Token: 0x060125A5 RID: 75173 RVA: 0x002AD7EC File Offset: 0x002AB9EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PinballInGameKickBallResponse.Descriptor;
			}
		}

		// Token: 0x060125A6 RID: 75174 RVA: 0x002AD7F3 File Offset: 0x002AB9F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballInGameKickBallResponse()
		{
		}

		// Token: 0x060125A7 RID: 75175 RVA: 0x002AD7FB File Offset: 0x002AB9FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballInGameKickBallResponse(PinballInGameKickBallResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060125A8 RID: 75176 RVA: 0x002AD820 File Offset: 0x002ABA20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballInGameKickBallResponse Clone()
		{
			return new PinballInGameKickBallResponse(this);
		}

		// Token: 0x17003CD0 RID: 15568
		// (get) Token: 0x060125A9 RID: 75177 RVA: 0x002AD828 File Offset: 0x002ABA28
		// (set) Token: 0x060125AA RID: 75178 RVA: 0x002AD830 File Offset: 0x002ABA30
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

		// Token: 0x060125AB RID: 75179 RVA: 0x002AD839 File Offset: 0x002ABA39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PinballInGameKickBallResponse);
		}

		// Token: 0x060125AC RID: 75180 RVA: 0x002AD847 File Offset: 0x002ABA47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PinballInGameKickBallResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060125AD RID: 75181 RVA: 0x002AD878 File Offset: 0x002ABA78
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

		// Token: 0x060125AE RID: 75182 RVA: 0x002AD8BD File Offset: 0x002ABABD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060125AF RID: 75183 RVA: 0x002AD8CA File Offset: 0x002ABACA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060125B0 RID: 75184 RVA: 0x002AD8D3 File Offset: 0x002ABAD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060125B1 RID: 75185 RVA: 0x002AD908 File Offset: 0x002ABB08
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

		// Token: 0x060125B2 RID: 75186 RVA: 0x002AD946 File Offset: 0x002ABB46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PinballInGameKickBallResponse other)
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

		// Token: 0x060125B3 RID: 75187 RVA: 0x002AD977 File Offset: 0x002ABB77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060125B4 RID: 75188 RVA: 0x002AD980 File Offset: 0x002ABB80
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
				if (num != 64U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04007252 RID: 29266
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007253 RID: 29267
		public const int ErrorCodeFieldNumber = 8;

		// Token: 0x04007254 RID: 29268
		private ErrorCode errorCode_;
	}
}
