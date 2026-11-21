using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200024E RID: 590
	[NetMessage(EMessageId.ChangeDataLayerFinishResponse)]
	public sealed class ChangeDataLayerFinishResponse : IMessage<ChangeDataLayerFinishResponse>, IMessage, IEquatable<ChangeDataLayerFinishResponse>, IDeepCloneable<ChangeDataLayerFinishResponse>, IBufferMessage
	{
		// Token: 0x06003F3A RID: 16186 RVA: 0x0009C258 File Offset: 0x0009A458
		[NullableContext(1)]
		public static ChangeDataLayerFinishResponse Create()
		{
			return new ChangeDataLayerFinishResponse();
		}

		// Token: 0x17000A94 RID: 2708
		// (get) Token: 0x06003F3B RID: 16187 RVA: 0x0009C25F File Offset: 0x0009A45F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000A95 RID: 2709
		// (get) Token: 0x06003F3C RID: 16188 RVA: 0x0009C262 File Offset: 0x0009A462
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChangeDataLayerFinishResponse.Descriptor;
			}
		}

		// Token: 0x06003F3D RID: 16189 RVA: 0x0009C269 File Offset: 0x0009A469
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeDataLayerFinishResponse()
		{
		}

		// Token: 0x06003F3E RID: 16190 RVA: 0x0009C271 File Offset: 0x0009A471
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeDataLayerFinishResponse(ChangeDataLayerFinishResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003F3F RID: 16191 RVA: 0x0009C296 File Offset: 0x0009A496
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeDataLayerFinishResponse Clone()
		{
			return new ChangeDataLayerFinishResponse(this);
		}

		// Token: 0x17000A96 RID: 2710
		// (get) Token: 0x06003F40 RID: 16192 RVA: 0x0009C29E File Offset: 0x0009A49E
		// (set) Token: 0x06003F41 RID: 16193 RVA: 0x0009C2A6 File Offset: 0x0009A4A6
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

		// Token: 0x06003F42 RID: 16194 RVA: 0x0009C2AF File Offset: 0x0009A4AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChangeDataLayerFinishResponse);
		}

		// Token: 0x06003F43 RID: 16195 RVA: 0x0009C2BD File Offset: 0x0009A4BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChangeDataLayerFinishResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003F44 RID: 16196 RVA: 0x0009C2EC File Offset: 0x0009A4EC
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

		// Token: 0x06003F45 RID: 16197 RVA: 0x0009C331 File Offset: 0x0009A531
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003F46 RID: 16198 RVA: 0x0009C33E File Offset: 0x0009A53E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003F47 RID: 16199 RVA: 0x0009C347 File Offset: 0x0009A547
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003F48 RID: 16200 RVA: 0x0009C37C File Offset: 0x0009A57C
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

		// Token: 0x06003F49 RID: 16201 RVA: 0x0009C3BA File Offset: 0x0009A5BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChangeDataLayerFinishResponse other)
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

		// Token: 0x06003F4A RID: 16202 RVA: 0x0009C3EB File Offset: 0x0009A5EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003F4B RID: 16203 RVA: 0x0009C3F4 File Offset: 0x0009A5F4
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
				if (num != 40U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04002D6D RID: 11629
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002D6E RID: 11630
		public const int ErrorCodeFieldNumber = 5;

		// Token: 0x04002D6F RID: 11631
		private ErrorCode errorCode_;
	}
}
