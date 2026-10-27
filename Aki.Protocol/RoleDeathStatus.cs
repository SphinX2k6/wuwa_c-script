using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001063 RID: 4195
	public sealed class RoleDeathStatus : IMessage<RoleDeathStatus>, IMessage, IEquatable<RoleDeathStatus>, IDeepCloneable<RoleDeathStatus>, IBufferMessage
	{
		// Token: 0x06016697 RID: 91799 RVA: 0x00341AE9 File Offset: 0x0033FCE9
		[NullableContext(1)]
		public static RoleDeathStatus Create()
		{
			return new RoleDeathStatus();
		}

		// Token: 0x17004AFB RID: 19195
		// (get) Token: 0x06016698 RID: 91800 RVA: 0x00341AF0 File Offset: 0x0033FCF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004AFC RID: 19196
		// (get) Token: 0x06016699 RID: 91801 RVA: 0x00341AF3 File Offset: 0x0033FCF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleDeathStatus.Descriptor;
			}
		}

		// Token: 0x0601669A RID: 91802 RVA: 0x00341AFA File Offset: 0x0033FCFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleDeathStatus()
		{
		}

		// Token: 0x0601669B RID: 91803 RVA: 0x00341B02 File Offset: 0x0033FD02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleDeathStatus(RoleDeathStatus other) : this()
		{
			this.entityId_ = other.entityId_;
			this.status_ = other.status_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601669C RID: 91804 RVA: 0x00341B33 File Offset: 0x0033FD33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleDeathStatus Clone()
		{
			return new RoleDeathStatus(this);
		}

		// Token: 0x17004AFD RID: 19197
		// (get) Token: 0x0601669D RID: 91805 RVA: 0x00341B3B File Offset: 0x0033FD3B
		// (set) Token: 0x0601669E RID: 91806 RVA: 0x00341B43 File Offset: 0x0033FD43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EntityId
		{
			get
			{
				return this.entityId_;
			}
			set
			{
				this.entityId_ = value;
			}
		}

		// Token: 0x17004AFE RID: 19198
		// (get) Token: 0x0601669F RID: 91807 RVA: 0x00341B4C File Offset: 0x0033FD4C
		// (set) Token: 0x060166A0 RID: 91808 RVA: 0x00341B54 File Offset: 0x0033FD54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Status
		{
			get
			{
				return this.status_;
			}
			set
			{
				this.status_ = value;
			}
		}

		// Token: 0x060166A1 RID: 91809 RVA: 0x00341B5D File Offset: 0x0033FD5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleDeathStatus);
		}

		// Token: 0x060166A2 RID: 91810 RVA: 0x00341B6B File Offset: 0x0033FD6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleDeathStatus other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.Status == other.Status && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060166A3 RID: 91811 RVA: 0x00341BAC File Offset: 0x0033FDAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.Status)
			{
				num ^= this.Status.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060166A4 RID: 91812 RVA: 0x00341C04 File Offset: 0x0033FE04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060166A5 RID: 91813 RVA: 0x00341C11 File Offset: 0x0033FE11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060166A6 RID: 91814 RVA: 0x00341C1C File Offset: 0x0033FE1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.EntityId);
			}
			if (this.Status)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.Status);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060166A7 RID: 91815 RVA: 0x00341C74 File Offset: 0x0033FE74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.Status)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060166A8 RID: 91816 RVA: 0x00341CC0 File Offset: 0x0033FEC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleDeathStatus other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.Status)
			{
				this.Status = other.Status;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060166A9 RID: 91817 RVA: 0x00341D10 File Offset: 0x0033FF10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060166AA RID: 91818 RVA: 0x00341D1C File Offset: 0x0033FF1C
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
					if (num != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Status = input.ReadBool();
					}
				}
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04008602 RID: 34306
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008603 RID: 34307
		public const int EntityIdFieldNumber = 1;

		// Token: 0x04008604 RID: 34308
		private long entityId_;

		// Token: 0x04008605 RID: 34309
		public const int StatusFieldNumber = 2;

		// Token: 0x04008606 RID: 34310
		private bool status_;
	}
}
