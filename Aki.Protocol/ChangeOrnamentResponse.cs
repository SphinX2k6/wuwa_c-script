using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000254 RID: 596
	[NetMessage(EMessageId.ChangeOrnamentResponse)]
	public sealed class ChangeOrnamentResponse : IMessage<ChangeOrnamentResponse>, IMessage, IEquatable<ChangeOrnamentResponse>, IDeepCloneable<ChangeOrnamentResponse>, IBufferMessage
	{
		// Token: 0x06003F6F RID: 16239 RVA: 0x0009C19F File Offset: 0x0009A39F
		[NullableContext(1)]
		public static ChangeOrnamentResponse Create()
		{
			return new ChangeOrnamentResponse();
		}

		// Token: 0x17000AA0 RID: 2720
		// (get) Token: 0x06003F70 RID: 16240 RVA: 0x0009C1A6 File Offset: 0x0009A3A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000AA1 RID: 2721
		// (get) Token: 0x06003F71 RID: 16241 RVA: 0x0009C1A9 File Offset: 0x0009A3A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChangeOrnamentResponse.Descriptor;
			}
		}

		// Token: 0x06003F72 RID: 16242 RVA: 0x0009C1B0 File Offset: 0x0009A3B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeOrnamentResponse()
		{
		}

		// Token: 0x06003F73 RID: 16243 RVA: 0x0009C1B8 File Offset: 0x0009A3B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeOrnamentResponse(ChangeOrnamentResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003F74 RID: 16244 RVA: 0x0009C1DD File Offset: 0x0009A3DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeOrnamentResponse Clone()
		{
			return new ChangeOrnamentResponse(this);
		}

		// Token: 0x17000AA2 RID: 2722
		// (get) Token: 0x06003F75 RID: 16245 RVA: 0x0009C1E5 File Offset: 0x0009A3E5
		// (set) Token: 0x06003F76 RID: 16246 RVA: 0x0009C1ED File Offset: 0x0009A3ED
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

		// Token: 0x06003F77 RID: 16247 RVA: 0x0009C1F6 File Offset: 0x0009A3F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChangeOrnamentResponse);
		}

		// Token: 0x06003F78 RID: 16248 RVA: 0x0009C204 File Offset: 0x0009A404
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChangeOrnamentResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003F79 RID: 16249 RVA: 0x0009C234 File Offset: 0x0009A434
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

		// Token: 0x06003F7A RID: 16250 RVA: 0x0009C279 File Offset: 0x0009A479
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003F7B RID: 16251 RVA: 0x0009C286 File Offset: 0x0009A486
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003F7C RID: 16252 RVA: 0x0009C28F File Offset: 0x0009A48F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003F7D RID: 16253 RVA: 0x0009C2C4 File Offset: 0x0009A4C4
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

		// Token: 0x06003F7E RID: 16254 RVA: 0x0009C302 File Offset: 0x0009A502
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChangeOrnamentResponse other)
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

		// Token: 0x06003F7F RID: 16255 RVA: 0x0009C333 File Offset: 0x0009A533
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003F80 RID: 16256 RVA: 0x0009C33C File Offset: 0x0009A53C
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
				if (num != 120U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04002D20 RID: 11552
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002D21 RID: 11553
		public const int ErrorCodeFieldNumber = 15;

		// Token: 0x04002D22 RID: 11554
		private ErrorCode errorCode_;
	}
}
