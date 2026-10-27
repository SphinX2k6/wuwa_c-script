using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DD7 RID: 3543
	[NetMessage(EMessageId.PressGameResponse)]
	public sealed class PressGameResponse : IMessage<PressGameResponse>, IMessage, IEquatable<PressGameResponse>, IDeepCloneable<PressGameResponse>, IBufferMessage
	{
		// Token: 0x0601311F RID: 78111 RVA: 0x002C770F File Offset: 0x002C590F
		[NullableContext(1)]
		public static PressGameResponse Create()
		{
			return new PressGameResponse();
		}

		// Token: 0x17003F47 RID: 16199
		// (get) Token: 0x06013120 RID: 78112 RVA: 0x002C7716 File Offset: 0x002C5916
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003F48 RID: 16200
		// (get) Token: 0x06013121 RID: 78113 RVA: 0x002C7719 File Offset: 0x002C5919
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PressGameResponse.Descriptor;
			}
		}

		// Token: 0x06013122 RID: 78114 RVA: 0x002C7720 File Offset: 0x002C5920
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PressGameResponse()
		{
		}

		// Token: 0x06013123 RID: 78115 RVA: 0x002C7733 File Offset: 0x002C5933
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PressGameResponse(PressGameResponse other) : this()
		{
			this.payload_ = other.payload_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013124 RID: 78116 RVA: 0x002C7758 File Offset: 0x002C5958
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PressGameResponse Clone()
		{
			return new PressGameResponse(this);
		}

		// Token: 0x17003F49 RID: 16201
		// (get) Token: 0x06013125 RID: 78117 RVA: 0x002C7760 File Offset: 0x002C5960
		// (set) Token: 0x06013126 RID: 78118 RVA: 0x002C7768 File Offset: 0x002C5968
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ByteString Payload
		{
			get
			{
				return this.payload_;
			}
			set
			{
				this.payload_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		// Token: 0x06013127 RID: 78119 RVA: 0x002C777B File Offset: 0x002C597B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PressGameResponse);
		}

		// Token: 0x06013128 RID: 78120 RVA: 0x002C7789 File Offset: 0x002C5989
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PressGameResponse other)
		{
			return other != null && (other == this || (!(this.Payload != other.Payload) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013129 RID: 78121 RVA: 0x002C77BC File Offset: 0x002C59BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Payload.Length != 0)
			{
				num ^= this.Payload.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601312A RID: 78122 RVA: 0x002C77FD File Offset: 0x002C59FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601312B RID: 78123 RVA: 0x002C780A File Offset: 0x002C5A0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601312C RID: 78124 RVA: 0x002C7813 File Offset: 0x002C5A13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Payload.Length != 0)
			{
				output.WriteRawTag(66);
				output.WriteBytes(this.Payload);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601312D RID: 78125 RVA: 0x002C784C File Offset: 0x002C5A4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Payload.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.Payload);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601312E RID: 78126 RVA: 0x002C788F File Offset: 0x002C5A8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PressGameResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Payload.Length != 0)
			{
				this.Payload = other.Payload;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601312F RID: 78127 RVA: 0x002C78C5 File Offset: 0x002C5AC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013130 RID: 78128 RVA: 0x002C78D0 File Offset: 0x002C5AD0
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
				if (num != 66U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Payload = input.ReadBytes();
				}
			}
		}

		// Token: 0x040075A8 RID: 30120
		private UnknownFieldSet _unknownFields;

		// Token: 0x040075A9 RID: 30121
		public const int PayloadFieldNumber = 8;

		// Token: 0x040075AA RID: 30122
		private ByteString payload_ = ByteString.Empty;
	}
}
