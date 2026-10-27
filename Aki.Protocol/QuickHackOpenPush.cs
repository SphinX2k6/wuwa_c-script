using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E36 RID: 3638
	[NetMessage(EMessageId.QuickHackOpenPush)]
	public sealed class QuickHackOpenPush : IMessage<QuickHackOpenPush>, IMessage, IEquatable<QuickHackOpenPush>, IDeepCloneable<QuickHackOpenPush>, IBufferMessage
	{
		// Token: 0x06013873 RID: 79987 RVA: 0x002D646C File Offset: 0x002D466C
		[NullableContext(1)]
		public static QuickHackOpenPush Create()
		{
			return new QuickHackOpenPush();
		}

		// Token: 0x170040BC RID: 16572
		// (get) Token: 0x06013874 RID: 79988 RVA: 0x002D6473 File Offset: 0x002D4673
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170040BD RID: 16573
		// (get) Token: 0x06013875 RID: 79989 RVA: 0x002D6476 File Offset: 0x002D4676
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QuickHackOpenPush.Descriptor;
			}
		}

		// Token: 0x06013876 RID: 79990 RVA: 0x002D647D File Offset: 0x002D467D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuickHackOpenPush()
		{
		}

		// Token: 0x06013877 RID: 79991 RVA: 0x002D6485 File Offset: 0x002D4685
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuickHackOpenPush(QuickHackOpenPush other) : this()
		{
			this.deviceId_ = other.deviceId_;
			this.ownerEntityId_ = other.ownerEntityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013878 RID: 79992 RVA: 0x002D64B6 File Offset: 0x002D46B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuickHackOpenPush Clone()
		{
			return new QuickHackOpenPush(this);
		}

		// Token: 0x170040BE RID: 16574
		// (get) Token: 0x06013879 RID: 79993 RVA: 0x002D64BE File Offset: 0x002D46BE
		// (set) Token: 0x0601387A RID: 79994 RVA: 0x002D64C6 File Offset: 0x002D46C6
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

		// Token: 0x170040BF RID: 16575
		// (get) Token: 0x0601387B RID: 79995 RVA: 0x002D64CF File Offset: 0x002D46CF
		// (set) Token: 0x0601387C RID: 79996 RVA: 0x002D64D7 File Offset: 0x002D46D7
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

		// Token: 0x0601387D RID: 79997 RVA: 0x002D64E0 File Offset: 0x002D46E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as QuickHackOpenPush);
		}

		// Token: 0x0601387E RID: 79998 RVA: 0x002D64EE File Offset: 0x002D46EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(QuickHackOpenPush other)
		{
			return other != null && (other == this || (this.DeviceId == other.DeviceId && this.OwnerEntityId == other.OwnerEntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601387F RID: 79999 RVA: 0x002D652C File Offset: 0x002D472C
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

		// Token: 0x06013880 RID: 80000 RVA: 0x002D6584 File Offset: 0x002D4784
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013881 RID: 80001 RVA: 0x002D6591 File Offset: 0x002D4791
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013882 RID: 80002 RVA: 0x002D659C File Offset: 0x002D479C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.DeviceId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.DeviceId);
			}
			if (this.OwnerEntityId != 0L)
			{
				output.WriteRawTag(104);
				output.WriteInt64(this.OwnerEntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013883 RID: 80003 RVA: 0x002D65F8 File Offset: 0x002D47F8
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

		// Token: 0x06013884 RID: 80004 RVA: 0x002D6650 File Offset: 0x002D4850
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

		// Token: 0x06013885 RID: 80005 RVA: 0x002D66A0 File Offset: 0x002D48A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013886 RID: 80006 RVA: 0x002D66AC File Offset: 0x002D48AC
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
				if (num != 96U)
				{
					if (num != 104U)
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

		// Token: 0x04007788 RID: 30600
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007789 RID: 30601
		public const int DeviceIdFieldNumber = 12;

		// Token: 0x0400778A RID: 30602
		private int deviceId_;

		// Token: 0x0400778B RID: 30603
		public const int OwnerEntityIdFieldNumber = 13;

		// Token: 0x0400778C RID: 30604
		private long ownerEntityId_;
	}
}
