using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000189 RID: 393
	[NetMessage(EMessageId.BeControlledEntityHoverResponse)]
	public sealed class BeControlledEntityHoverResponse : IMessage<BeControlledEntityHoverResponse>, IMessage, IEquatable<BeControlledEntityHoverResponse>, IDeepCloneable<BeControlledEntityHoverResponse>, IBufferMessage
	{
		// Token: 0x06002F31 RID: 12081 RVA: 0x0007901D File Offset: 0x0007721D
		[NullableContext(1)]
		public static BeControlledEntityHoverResponse Create()
		{
			return new BeControlledEntityHoverResponse();
		}

		// Token: 0x17000738 RID: 1848
		// (get) Token: 0x06002F32 RID: 12082 RVA: 0x00079024 File Offset: 0x00077224
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000739 RID: 1849
		// (get) Token: 0x06002F33 RID: 12083 RVA: 0x00079027 File Offset: 0x00077227
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BeControlledEntityHoverResponse.Descriptor;
			}
		}

		// Token: 0x06002F34 RID: 12084 RVA: 0x0007902E File Offset: 0x0007722E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BeControlledEntityHoverResponse()
		{
		}

		// Token: 0x06002F35 RID: 12085 RVA: 0x00079036 File Offset: 0x00077236
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BeControlledEntityHoverResponse(BeControlledEntityHoverResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002F36 RID: 12086 RVA: 0x0007905B File Offset: 0x0007725B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BeControlledEntityHoverResponse Clone()
		{
			return new BeControlledEntityHoverResponse(this);
		}

		// Token: 0x1700073A RID: 1850
		// (get) Token: 0x06002F37 RID: 12087 RVA: 0x00079063 File Offset: 0x00077263
		// (set) Token: 0x06002F38 RID: 12088 RVA: 0x0007906B File Offset: 0x0007726B
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

		// Token: 0x06002F39 RID: 12089 RVA: 0x00079074 File Offset: 0x00077274
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BeControlledEntityHoverResponse);
		}

		// Token: 0x06002F3A RID: 12090 RVA: 0x00079082 File Offset: 0x00077282
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BeControlledEntityHoverResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002F3B RID: 12091 RVA: 0x000790B0 File Offset: 0x000772B0
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

		// Token: 0x06002F3C RID: 12092 RVA: 0x000790F5 File Offset: 0x000772F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002F3D RID: 12093 RVA: 0x00079102 File Offset: 0x00077302
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002F3E RID: 12094 RVA: 0x0007910B File Offset: 0x0007730B
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

		// Token: 0x06002F3F RID: 12095 RVA: 0x00079140 File Offset: 0x00077340
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

		// Token: 0x06002F40 RID: 12096 RVA: 0x0007917E File Offset: 0x0007737E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BeControlledEntityHoverResponse other)
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

		// Token: 0x06002F41 RID: 12097 RVA: 0x000791AF File Offset: 0x000773AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002F42 RID: 12098 RVA: 0x000791B8 File Offset: 0x000773B8
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

		// Token: 0x0400289F RID: 10399
		private UnknownFieldSet _unknownFields;

		// Token: 0x040028A0 RID: 10400
		public const int ErrorCodeFieldNumber = 9;

		// Token: 0x040028A1 RID: 10401
		private ErrorCode errorCode_;
	}
}
