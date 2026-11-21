using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E26 RID: 3622
	[NetMessage(EMessageId.QuickHackOpenPush)]
	public sealed class QuickHackOpenPush : IMessage<QuickHackOpenPush>, IMessage, IEquatable<QuickHackOpenPush>, IDeepCloneable<QuickHackOpenPush>, IBufferMessage
	{
		// Token: 0x0601378E RID: 79758 RVA: 0x002D4DA9 File Offset: 0x002D2FA9
		[NullableContext(1)]
		public static QuickHackOpenPush Create()
		{
			return new QuickHackOpenPush();
		}

		// Token: 0x17004092 RID: 16530
		// (get) Token: 0x0601378F RID: 79759 RVA: 0x002D4DB0 File Offset: 0x002D2FB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004093 RID: 16531
		// (get) Token: 0x06013790 RID: 79760 RVA: 0x002D4DB3 File Offset: 0x002D2FB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QuickHackOpenPush.Descriptor;
			}
		}

		// Token: 0x06013791 RID: 79761 RVA: 0x002D4DBA File Offset: 0x002D2FBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuickHackOpenPush()
		{
		}

		// Token: 0x06013792 RID: 79762 RVA: 0x002D4DC2 File Offset: 0x002D2FC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuickHackOpenPush(QuickHackOpenPush other) : this()
		{
			this.deviceId_ = other.deviceId_;
			this.ownerEntityId_ = other.ownerEntityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013793 RID: 79763 RVA: 0x002D4DF3 File Offset: 0x002D2FF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuickHackOpenPush Clone()
		{
			return new QuickHackOpenPush(this);
		}

		// Token: 0x17004094 RID: 16532
		// (get) Token: 0x06013794 RID: 79764 RVA: 0x002D4DFB File Offset: 0x002D2FFB
		// (set) Token: 0x06013795 RID: 79765 RVA: 0x002D4E03 File Offset: 0x002D3003
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int DeviceId
		{
			get
			{
				return this.deviceId_;
			}
			set
			{
				this.deviceId_ = value;
			}
		}

		// Token: 0x17004095 RID: 16533
		// (get) Token: 0x06013796 RID: 79766 RVA: 0x002D4E0C File Offset: 0x002D300C
		// (set) Token: 0x06013797 RID: 79767 RVA: 0x002D4E14 File Offset: 0x002D3014
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long OwnerEntityId
		{
			get
			{
				return this.ownerEntityId_;
			}
			set
			{
				this.ownerEntityId_ = value;
			}
		}

		// Token: 0x06013798 RID: 79768 RVA: 0x002D4E1D File Offset: 0x002D301D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as QuickHackOpenPush);
		}

		// Token: 0x06013799 RID: 79769 RVA: 0x002D4E2B File Offset: 0x002D302B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(QuickHackOpenPush other)
		{
			return other != null && (other == this || (this.DeviceId == other.DeviceId && this.OwnerEntityId == other.OwnerEntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601379A RID: 79770 RVA: 0x002D4E6C File Offset: 0x002D306C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.DeviceId != 0)
			{
				num ^= this.DeviceId.GetHashCode();
			}
			if (this.OwnerEntityId != 0L)
			{
				num ^= this.OwnerEntityId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601379B RID: 79771 RVA: 0x002D4EC4 File Offset: 0x002D30C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601379C RID: 79772 RVA: 0x002D4ED1 File Offset: 0x002D30D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601379D RID: 79773 RVA: 0x002D4EDC File Offset: 0x002D30DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.DeviceId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.DeviceId);
			}
			if (this.OwnerEntityId != 0L)
			{
				output.WriteRawTag(96);
				output.WriteInt64(this.OwnerEntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601379E RID: 79774 RVA: 0x002D4F38 File Offset: 0x002D3138
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.DeviceId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.DeviceId);
			}
			if (this.OwnerEntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.OwnerEntityId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601379F RID: 79775 RVA: 0x002D4F90 File Offset: 0x002D3190
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(QuickHackOpenPush other)
		{
			if (other == null)
			{
				return;
			}
			if (other.DeviceId != 0)
			{
				this.DeviceId = other.DeviceId;
			}
			if (other.OwnerEntityId != 0L)
			{
				this.OwnerEntityId = other.OwnerEntityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060137A0 RID: 79776 RVA: 0x002D4FE0 File Offset: 0x002D31E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060137A1 RID: 79777 RVA: 0x002D4FEC File Offset: 0x002D31EC
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
					if (num != 96U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.OwnerEntityId = input.ReadInt64();
					}
				}
				else
				{
					this.DeviceId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040077B2 RID: 30642
		private UnknownFieldSet _unknownFields;

		// Token: 0x040077B3 RID: 30643
		public const int DeviceIdFieldNumber = 9;

		// Token: 0x040077B4 RID: 30644
		private int deviceId_;

		// Token: 0x040077B5 RID: 30645
		public const int OwnerEntityIdFieldNumber = 12;

		// Token: 0x040077B6 RID: 30646
		private long ownerEntityId_;
	}
}
