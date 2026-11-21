using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007B9 RID: 1977
	[NetMessage(EMessageId.IllustratedUnlockRequest)]
	public sealed class IllustratedUnlockRequest : IMessage<IllustratedUnlockRequest>, IMessage, IEquatable<IllustratedUnlockRequest>, IDeepCloneable<IllustratedUnlockRequest>, IBufferMessage
	{
		// Token: 0x0600B23C RID: 45628 RVA: 0x001AB1B9 File Offset: 0x001A93B9
		[NullableContext(1)]
		public static IllustratedUnlockRequest Create()
		{
			return new IllustratedUnlockRequest();
		}

		// Token: 0x170023F3 RID: 9203
		// (get) Token: 0x0600B23D RID: 45629 RVA: 0x001AB1C0 File Offset: 0x001A93C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170023F4 RID: 9204
		// (get) Token: 0x0600B23E RID: 45630 RVA: 0x001AB1C3 File Offset: 0x001A93C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return IllustratedUnlockRequest.Descriptor;
			}
		}

		// Token: 0x0600B23F RID: 45631 RVA: 0x001AB1CA File Offset: 0x001A93CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public IllustratedUnlockRequest()
		{
		}

		// Token: 0x0600B240 RID: 45632 RVA: 0x001AB1D2 File Offset: 0x001A93D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public IllustratedUnlockRequest(IllustratedUnlockRequest other) : this()
		{
			this.type_ = other.type_;
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B241 RID: 45633 RVA: 0x001AB203 File Offset: 0x001A9403
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public IllustratedUnlockRequest Clone()
		{
			return new IllustratedUnlockRequest(this);
		}

		// Token: 0x170023F5 RID: 9205
		// (get) Token: 0x0600B242 RID: 45634 RVA: 0x001AB20B File Offset: 0x001A940B
		// (set) Token: 0x0600B243 RID: 45635 RVA: 0x001AB213 File Offset: 0x001A9413
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public IllustratedType Type
		{
			get
			{
				return this.type_;
			}
			set
			{
				this.type_ = value;
			}
		}

		// Token: 0x170023F6 RID: 9206
		// (get) Token: 0x0600B244 RID: 45636 RVA: 0x001AB21C File Offset: 0x001A941C
		// (set) Token: 0x0600B245 RID: 45637 RVA: 0x001AB224 File Offset: 0x001A9424
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x0600B246 RID: 45638 RVA: 0x001AB22D File Offset: 0x001A942D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as IllustratedUnlockRequest);
		}

		// Token: 0x0600B247 RID: 45639 RVA: 0x001AB23B File Offset: 0x001A943B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(IllustratedUnlockRequest other)
		{
			return other != null && (other == this || (this.Type == other.Type && this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B248 RID: 45640 RVA: 0x001AB27C File Offset: 0x001A947C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Type != IllustratedType.Monster)
			{
				num ^= this.Type.GetHashCode();
			}
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B249 RID: 45641 RVA: 0x001AB2DA File Offset: 0x001A94DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B24A RID: 45642 RVA: 0x001AB2E7 File Offset: 0x001A94E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B24B RID: 45643 RVA: 0x001AB2F0 File Offset: 0x001A94F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Type != IllustratedType.Monster)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.Type);
			}
			if (this.Id != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B24C RID: 45644 RVA: 0x001AB348 File Offset: 0x001A9548
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Type != IllustratedType.Monster)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Type);
			}
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B24D RID: 45645 RVA: 0x001AB3A0 File Offset: 0x001A95A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(IllustratedUnlockRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Type != IllustratedType.Monster)
			{
				this.Type = other.Type;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B24E RID: 45646 RVA: 0x001AB3F0 File Offset: 0x001A95F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B24F RID: 45647 RVA: 0x001AB3FC File Offset: 0x001A95FC
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
				if (num != 8U)
				{
					if (num != 32U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Id = input.ReadInt32();
					}
				}
				else
				{
					this.Type = (IllustratedType)input.ReadEnum();
				}
			}
		}

		// Token: 0x04005010 RID: 20496
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005011 RID: 20497
		public const int TypeFieldNumber = 1;

		// Token: 0x04005012 RID: 20498
		private IllustratedType type_;

		// Token: 0x04005013 RID: 20499
		public const int IdFieldNumber = 4;

		// Token: 0x04005014 RID: 20500
		private int id_;
	}
}
