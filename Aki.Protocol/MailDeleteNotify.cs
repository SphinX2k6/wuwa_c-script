using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000976 RID: 2422
	[NetMessage(EMessageId.MailDeleteNotify)]
	public sealed class MailDeleteNotify : IMessage<MailDeleteNotify>, IMessage, IEquatable<MailDeleteNotify>, IDeepCloneable<MailDeleteNotify>, IBufferMessage
	{
		// Token: 0x0600D51A RID: 54554 RVA: 0x001F5B0D File Offset: 0x001F3D0D
		[NullableContext(1)]
		public static MailDeleteNotify Create()
		{
			return new MailDeleteNotify();
		}

		// Token: 0x17002B23 RID: 11043
		// (get) Token: 0x0600D51B RID: 54555 RVA: 0x001F5B14 File Offset: 0x001F3D14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002B24 RID: 11044
		// (get) Token: 0x0600D51C RID: 54556 RVA: 0x001F5B17 File Offset: 0x001F3D17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MailDeleteNotify.Descriptor;
			}
		}

		// Token: 0x0600D51D RID: 54557 RVA: 0x001F5B1E File Offset: 0x001F3D1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MailDeleteNotify()
		{
		}

		// Token: 0x0600D51E RID: 54558 RVA: 0x001F5B31 File Offset: 0x001F3D31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MailDeleteNotify(MailDeleteNotify other) : this()
		{
			this.id_ = other.id_;
			this.reason_ = other.reason_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D51F RID: 54559 RVA: 0x001F5B62 File Offset: 0x001F3D62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MailDeleteNotify Clone()
		{
			return new MailDeleteNotify(this);
		}

		// Token: 0x17002B25 RID: 11045
		// (get) Token: 0x0600D520 RID: 54560 RVA: 0x001F5B6A File Offset: 0x001F3D6A
		// (set) Token: 0x0600D521 RID: 54561 RVA: 0x001F5B72 File Offset: 0x001F3D72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17002B26 RID: 11046
		// (get) Token: 0x0600D522 RID: 54562 RVA: 0x001F5B85 File Offset: 0x001F3D85
		// (set) Token: 0x0600D523 RID: 54563 RVA: 0x001F5B8D File Offset: 0x001F3D8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MailDeleteReason Reason
		{
			get
			{
				return this.reason_;
			}
			set
			{
				this.reason_ = value;
			}
		}

		// Token: 0x0600D524 RID: 54564 RVA: 0x001F5B96 File Offset: 0x001F3D96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MailDeleteNotify);
		}

		// Token: 0x0600D525 RID: 54565 RVA: 0x001F5BA4 File Offset: 0x001F3DA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MailDeleteNotify other)
		{
			return other != null && (other == this || (!(this.Id != other.Id) && this.Reason == other.Reason && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D526 RID: 54566 RVA: 0x001F5BF4 File Offset: 0x001F3DF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id.Length != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.Reason != MailDeleteReason.OverTime)
			{
				num ^= this.Reason.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D527 RID: 54567 RVA: 0x001F5C54 File Offset: 0x001F3E54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D528 RID: 54568 RVA: 0x001F5C61 File Offset: 0x001F3E61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D529 RID: 54569 RVA: 0x001F5C6C File Offset: 0x001F3E6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Reason != MailDeleteReason.OverTime)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.Reason);
			}
			if (this.Id.Length != 0)
			{
				output.WriteRawTag(50);
				output.WriteString(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D52A RID: 54570 RVA: 0x001F5CCC File Offset: 0x001F3ECC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Id);
			}
			if (this.Reason != MailDeleteReason.OverTime)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Reason);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D52B RID: 54571 RVA: 0x001F5D28 File Offset: 0x001F3F28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MailDeleteNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id.Length != 0)
			{
				this.Id = other.Id;
			}
			if (other.Reason != MailDeleteReason.OverTime)
			{
				this.Reason = other.Reason;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D52C RID: 54572 RVA: 0x001F5D7D File Offset: 0x001F3F7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D52D RID: 54573 RVA: 0x001F5D88 File Offset: 0x001F3F88
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
				if (num != 24U)
				{
					if (num != 50U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Id = input.ReadString();
					}
				}
				else
				{
					this.Reason = (MailDeleteReason)input.ReadEnum();
				}
			}
		}

		// Token: 0x04005940 RID: 22848
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005941 RID: 22849
		public const int IdFieldNumber = 6;

		// Token: 0x04005942 RID: 22850
		private string id_ = "";

		// Token: 0x04005943 RID: 22851
		public const int ReasonFieldNumber = 3;

		// Token: 0x04005944 RID: 22852
		private MailDeleteReason reason_;
	}
}
