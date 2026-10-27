using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200078C RID: 1932
	[NetMessage(EMessageId.HonamiStoryLockItemResponse)]
	public sealed class HonamiStoryLockItemResponse : IMessage<HonamiStoryLockItemResponse>, IMessage, IEquatable<HonamiStoryLockItemResponse>, IDeepCloneable<HonamiStoryLockItemResponse>, IBufferMessage
	{
		// Token: 0x0600AE75 RID: 44661 RVA: 0x001A3243 File Offset: 0x001A1443
		[NullableContext(1)]
		public static HonamiStoryLockItemResponse Create()
		{
			return new HonamiStoryLockItemResponse();
		}

		// Token: 0x17002333 RID: 9011
		// (get) Token: 0x0600AE76 RID: 44662 RVA: 0x001A324A File Offset: 0x001A144A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002334 RID: 9012
		// (get) Token: 0x0600AE77 RID: 44663 RVA: 0x001A324D File Offset: 0x001A144D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HonamiStoryLockItemResponse.Descriptor;
			}
		}

		// Token: 0x0600AE78 RID: 44664 RVA: 0x001A3254 File Offset: 0x001A1454
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryLockItemResponse()
		{
		}

		// Token: 0x0600AE79 RID: 44665 RVA: 0x001A325C File Offset: 0x001A145C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryLockItemResponse(HonamiStoryLockItemResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.backPackId_ = other.backPackId_;
			this.itemUid_ = other.itemUid_;
			this.isLock_ = other.isLock_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AE7A RID: 44666 RVA: 0x001A32B0 File Offset: 0x001A14B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryLockItemResponse Clone()
		{
			return new HonamiStoryLockItemResponse(this);
		}

		// Token: 0x17002335 RID: 9013
		// (get) Token: 0x0600AE7B RID: 44667 RVA: 0x001A32B8 File Offset: 0x001A14B8
		// (set) Token: 0x0600AE7C RID: 44668 RVA: 0x001A32C0 File Offset: 0x001A14C0
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

		// Token: 0x17002336 RID: 9014
		// (get) Token: 0x0600AE7D RID: 44669 RVA: 0x001A32C9 File Offset: 0x001A14C9
		// (set) Token: 0x0600AE7E RID: 44670 RVA: 0x001A32D1 File Offset: 0x001A14D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BackPackId
		{
			get
			{
				return this.backPackId_;
			}
			set
			{
				this.backPackId_ = value;
			}
		}

		// Token: 0x17002337 RID: 9015
		// (get) Token: 0x0600AE7F RID: 44671 RVA: 0x001A32DA File Offset: 0x001A14DA
		// (set) Token: 0x0600AE80 RID: 44672 RVA: 0x001A32E2 File Offset: 0x001A14E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ItemUid
		{
			get
			{
				return this.itemUid_;
			}
			set
			{
				this.itemUid_ = value;
			}
		}

		// Token: 0x17002338 RID: 9016
		// (get) Token: 0x0600AE81 RID: 44673 RVA: 0x001A32EB File Offset: 0x001A14EB
		// (set) Token: 0x0600AE82 RID: 44674 RVA: 0x001A32F3 File Offset: 0x001A14F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsLock
		{
			get
			{
				return this.isLock_;
			}
			set
			{
				this.isLock_ = value;
			}
		}

		// Token: 0x0600AE83 RID: 44675 RVA: 0x001A32FC File Offset: 0x001A14FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HonamiStoryLockItemResponse);
		}

		// Token: 0x0600AE84 RID: 44676 RVA: 0x001A330C File Offset: 0x001A150C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HonamiStoryLockItemResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.BackPackId == other.BackPackId && this.ItemUid == other.ItemUid && this.IsLock == other.IsLock && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600AE85 RID: 44677 RVA: 0x001A3378 File Offset: 0x001A1578
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.BackPackId != 0)
			{
				num ^= this.BackPackId.GetHashCode();
			}
			if (this.ItemUid != 0)
			{
				num ^= this.ItemUid.GetHashCode();
			}
			if (this.IsLock)
			{
				num ^= this.IsLock.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600AE86 RID: 44678 RVA: 0x001A3408 File Offset: 0x001A1608
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600AE87 RID: 44679 RVA: 0x001A3415 File Offset: 0x001A1615
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AE88 RID: 44680 RVA: 0x001A3420 File Offset: 0x001A1620
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.ItemUid != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.ItemUid);
			}
			if (this.BackPackId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.BackPackId);
			}
			if (this.IsLock)
			{
				output.WriteRawTag(48);
				output.WriteBool(this.IsLock);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AE89 RID: 44681 RVA: 0x001A34B4 File Offset: 0x001A16B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.BackPackId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BackPackId);
			}
			if (this.ItemUid != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ItemUid);
			}
			if (this.IsLock)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600AE8A RID: 44682 RVA: 0x001A3530 File Offset: 0x001A1730
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HonamiStoryLockItemResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.BackPackId != 0)
			{
				this.BackPackId = other.BackPackId;
			}
			if (other.ItemUid != 0)
			{
				this.ItemUid = other.ItemUid;
			}
			if (other.IsLock)
			{
				this.IsLock = other.IsLock;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600AE8B RID: 44683 RVA: 0x001A35A8 File Offset: 0x001A17A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AE8C RID: 44684 RVA: 0x001A35B4 File Offset: 0x001A17B4
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
				if (num <= 32U)
				{
					if (num == 16U)
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
						continue;
					}
					if (num == 32U)
					{
						this.ItemUid = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 40U)
					{
						this.BackPackId = input.ReadInt32();
						continue;
					}
					if (num == 48U)
					{
						this.IsLock = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004EBC RID: 20156
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004EBD RID: 20157
		public const int ErrorCodeFieldNumber = 2;

		// Token: 0x04004EBE RID: 20158
		private ErrorCode errorCode_;

		// Token: 0x04004EBF RID: 20159
		public const int BackPackIdFieldNumber = 5;

		// Token: 0x04004EC0 RID: 20160
		private int backPackId_;

		// Token: 0x04004EC1 RID: 20161
		public const int ItemUidFieldNumber = 4;

		// Token: 0x04004EC2 RID: 20162
		private int itemUid_;

		// Token: 0x04004EC3 RID: 20163
		public const int IsLockFieldNumber = 6;

		// Token: 0x04004EC4 RID: 20164
		private bool isLock_;
	}
}
