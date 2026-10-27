using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B00 RID: 2816
	[NetMessage(EMessageId.NewbieCarnivalAwardRequest)]
	public sealed class NewbieCarnivalAwardRequest : IMessage<NewbieCarnivalAwardRequest>, IMessage, IEquatable<NewbieCarnivalAwardRequest>, IDeepCloneable<NewbieCarnivalAwardRequest>, IBufferMessage
	{
		// Token: 0x0600F4C8 RID: 62664 RVA: 0x0023BAD9 File Offset: 0x00239CD9
		[NullableContext(1)]
		public static NewbieCarnivalAwardRequest Create()
		{
			return new NewbieCarnivalAwardRequest();
		}

		// Token: 0x170031DD RID: 12765
		// (get) Token: 0x0600F4C9 RID: 62665 RVA: 0x0023BAE0 File Offset: 0x00239CE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170031DE RID: 12766
		// (get) Token: 0x0600F4CA RID: 62666 RVA: 0x0023BAE3 File Offset: 0x00239CE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewbieCarnivalAwardRequest.Descriptor;
			}
		}

		// Token: 0x0600F4CB RID: 62667 RVA: 0x0023BAEA File Offset: 0x00239CEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewbieCarnivalAwardRequest()
		{
		}

		// Token: 0x0600F4CC RID: 62668 RVA: 0x0023BAF2 File Offset: 0x00239CF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewbieCarnivalAwardRequest(NewbieCarnivalAwardRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.config_ = other.config_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F4CD RID: 62669 RVA: 0x0023BB23 File Offset: 0x00239D23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewbieCarnivalAwardRequest Clone()
		{
			return new NewbieCarnivalAwardRequest(this);
		}

		// Token: 0x170031DF RID: 12767
		// (get) Token: 0x0600F4CE RID: 62670 RVA: 0x0023BB2B File Offset: 0x00239D2B
		// (set) Token: 0x0600F4CF RID: 62671 RVA: 0x0023BB33 File Offset: 0x00239D33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ActivityId
		{
			get
			{
				return this.activityId_;
			}
			set
			{
				this.activityId_ = value;
			}
		}

		// Token: 0x170031E0 RID: 12768
		// (get) Token: 0x0600F4D0 RID: 62672 RVA: 0x0023BB3C File Offset: 0x00239D3C
		// (set) Token: 0x0600F4D1 RID: 62673 RVA: 0x0023BB44 File Offset: 0x00239D44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Config
		{
			get
			{
				return this.config_;
			}
			set
			{
				this.config_ = value;
			}
		}

		// Token: 0x0600F4D2 RID: 62674 RVA: 0x0023BB4D File Offset: 0x00239D4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewbieCarnivalAwardRequest);
		}

		// Token: 0x0600F4D3 RID: 62675 RVA: 0x0023BB5B File Offset: 0x00239D5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewbieCarnivalAwardRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.Config == other.Config && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F4D4 RID: 62676 RVA: 0x0023BB9C File Offset: 0x00239D9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this.Config != 0)
			{
				num ^= this.Config.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600F4D5 RID: 62677 RVA: 0x0023BBF4 File Offset: 0x00239DF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F4D6 RID: 62678 RVA: 0x0023BC01 File Offset: 0x00239E01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F4D7 RID: 62679 RVA: 0x0023BC0C File Offset: 0x00239E0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.ActivityId);
			}
			if (this.Config != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.Config);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F4D8 RID: 62680 RVA: 0x0023BC68 File Offset: 0x00239E68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this.Config != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Config);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600F4D9 RID: 62681 RVA: 0x0023BCC0 File Offset: 0x00239EC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NewbieCarnivalAwardRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			if (other.Config != 0)
			{
				this.Config = other.Config;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600F4DA RID: 62682 RVA: 0x0023BD10 File Offset: 0x00239F10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F4DB RID: 62683 RVA: 0x0023BD1C File Offset: 0x00239F1C
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
					if (num != 96U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Config = input.ReadInt32();
					}
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04006287 RID: 25223
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006288 RID: 25224
		public const int ActivityIdFieldNumber = 3;

		// Token: 0x04006289 RID: 25225
		private int activityId_;

		// Token: 0x0400628A RID: 25226
		public const int ConfigFieldNumber = 12;

		// Token: 0x0400628B RID: 25227
		private int config_;
	}
}
