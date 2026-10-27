using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003C8 RID: 968
	[NetMessage(EMessageId.DestroyBulletResponse)]
	public sealed class DestroyBulletResponse : IMessage<DestroyBulletResponse>, IMessage, IEquatable<DestroyBulletResponse>, IDeepCloneable<DestroyBulletResponse>, IBufferMessage
	{
		// Token: 0x06005E8B RID: 24203 RVA: 0x000E503E File Offset: 0x000E323E
		[NullableContext(1)]
		public static DestroyBulletResponse Create()
		{
			return new DestroyBulletResponse();
		}

		// Token: 0x17001190 RID: 4496
		// (get) Token: 0x06005E8C RID: 24204 RVA: 0x000E5045 File Offset: 0x000E3245
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001191 RID: 4497
		// (get) Token: 0x06005E8D RID: 24205 RVA: 0x000E5048 File Offset: 0x000E3248
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DestroyBulletResponse.Descriptor;
			}
		}

		// Token: 0x06005E8E RID: 24206 RVA: 0x000E504F File Offset: 0x000E324F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DestroyBulletResponse()
		{
		}

		// Token: 0x06005E8F RID: 24207 RVA: 0x000E5057 File Offset: 0x000E3257
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DestroyBulletResponse(DestroyBulletResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005E90 RID: 24208 RVA: 0x000E507C File Offset: 0x000E327C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DestroyBulletResponse Clone()
		{
			return new DestroyBulletResponse(this);
		}

		// Token: 0x17001192 RID: 4498
		// (get) Token: 0x06005E91 RID: 24209 RVA: 0x000E5084 File Offset: 0x000E3284
		// (set) Token: 0x06005E92 RID: 24210 RVA: 0x000E508C File Offset: 0x000E328C
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

		// Token: 0x06005E93 RID: 24211 RVA: 0x000E5095 File Offset: 0x000E3295
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DestroyBulletResponse);
		}

		// Token: 0x06005E94 RID: 24212 RVA: 0x000E50A3 File Offset: 0x000E32A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DestroyBulletResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005E95 RID: 24213 RVA: 0x000E50D4 File Offset: 0x000E32D4
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

		// Token: 0x06005E96 RID: 24214 RVA: 0x000E5119 File Offset: 0x000E3319
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005E97 RID: 24215 RVA: 0x000E5126 File Offset: 0x000E3326
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005E98 RID: 24216 RVA: 0x000E512F File Offset: 0x000E332F
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

		// Token: 0x06005E99 RID: 24217 RVA: 0x000E5164 File Offset: 0x000E3364
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

		// Token: 0x06005E9A RID: 24218 RVA: 0x000E51A2 File Offset: 0x000E33A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DestroyBulletResponse other)
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

		// Token: 0x06005E9B RID: 24219 RVA: 0x000E51D3 File Offset: 0x000E33D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005E9C RID: 24220 RVA: 0x000E51DC File Offset: 0x000E33DC
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

		// Token: 0x040036D2 RID: 14034
		private UnknownFieldSet _unknownFields;

		// Token: 0x040036D3 RID: 14035
		public const int ErrorCodeFieldNumber = 9;

		// Token: 0x040036D4 RID: 14036
		private ErrorCode errorCode_;
	}
}
