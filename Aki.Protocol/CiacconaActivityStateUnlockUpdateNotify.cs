using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200028E RID: 654
	[NetMessage(EMessageId.CiacconaActivityStateUnlockUpdateNotify)]
	public sealed class CiacconaActivityStateUnlockUpdateNotify : IMessage<CiacconaActivityStateUnlockUpdateNotify>, IMessage, IEquatable<CiacconaActivityStateUnlockUpdateNotify>, IDeepCloneable<CiacconaActivityStateUnlockUpdateNotify>, IBufferMessage
	{
		// Token: 0x06004442 RID: 17474 RVA: 0x000A77FB File Offset: 0x000A59FB
		[NullableContext(1)]
		public static CiacconaActivityStateUnlockUpdateNotify Create()
		{
			return new CiacconaActivityStateUnlockUpdateNotify();
		}

		// Token: 0x17000BAF RID: 2991
		// (get) Token: 0x06004443 RID: 17475 RVA: 0x000A7802 File Offset: 0x000A5A02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000BB0 RID: 2992
		// (get) Token: 0x06004444 RID: 17476 RVA: 0x000A7805 File Offset: 0x000A5A05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CiacconaActivityStateUnlockUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06004445 RID: 17477 RVA: 0x000A780C File Offset: 0x000A5A0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CiacconaActivityStateUnlockUpdateNotify()
		{
		}

		// Token: 0x06004446 RID: 17478 RVA: 0x000A7814 File Offset: 0x000A5A14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CiacconaActivityStateUnlockUpdateNotify(CiacconaActivityStateUnlockUpdateNotify other) : this()
		{
			this.activityId_ = other.activityId_;
			this.state1Unlock_ = other.state1Unlock_;
			this.state2Unlock_ = other.state2Unlock_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004447 RID: 17479 RVA: 0x000A7851 File Offset: 0x000A5A51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CiacconaActivityStateUnlockUpdateNotify Clone()
		{
			return new CiacconaActivityStateUnlockUpdateNotify(this);
		}

		// Token: 0x17000BB1 RID: 2993
		// (get) Token: 0x06004448 RID: 17480 RVA: 0x000A7859 File Offset: 0x000A5A59
		// (set) Token: 0x06004449 RID: 17481 RVA: 0x000A7861 File Offset: 0x000A5A61
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

		// Token: 0x17000BB2 RID: 2994
		// (get) Token: 0x0600444A RID: 17482 RVA: 0x000A786A File Offset: 0x000A5A6A
		// (set) Token: 0x0600444B RID: 17483 RVA: 0x000A7872 File Offset: 0x000A5A72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool State1Unlock
		{
			get
			{
				return this.state1Unlock_;
			}
			set
			{
				this.state1Unlock_ = value;
			}
		}

		// Token: 0x17000BB3 RID: 2995
		// (get) Token: 0x0600444C RID: 17484 RVA: 0x000A787B File Offset: 0x000A5A7B
		// (set) Token: 0x0600444D RID: 17485 RVA: 0x000A7883 File Offset: 0x000A5A83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool State2Unlock
		{
			get
			{
				return this.state2Unlock_;
			}
			set
			{
				this.state2Unlock_ = value;
			}
		}

		// Token: 0x0600444E RID: 17486 RVA: 0x000A788C File Offset: 0x000A5A8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CiacconaActivityStateUnlockUpdateNotify);
		}

		// Token: 0x0600444F RID: 17487 RVA: 0x000A789C File Offset: 0x000A5A9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CiacconaActivityStateUnlockUpdateNotify other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.State1Unlock == other.State1Unlock && this.State2Unlock == other.State2Unlock && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004450 RID: 17488 RVA: 0x000A78F8 File Offset: 0x000A5AF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this.State1Unlock)
			{
				num ^= this.State1Unlock.GetHashCode();
			}
			if (this.State2Unlock)
			{
				num ^= this.State2Unlock.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004451 RID: 17489 RVA: 0x000A7969 File Offset: 0x000A5B69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004452 RID: 17490 RVA: 0x000A7976 File Offset: 0x000A5B76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004453 RID: 17491 RVA: 0x000A7980 File Offset: 0x000A5B80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.State2Unlock)
			{
				output.WriteRawTag(56);
				output.WriteBool(this.State2Unlock);
			}
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.ActivityId);
			}
			if (this.State1Unlock)
			{
				output.WriteRawTag(112);
				output.WriteBool(this.State1Unlock);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004454 RID: 17492 RVA: 0x000A79F8 File Offset: 0x000A5BF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this.State1Unlock)
			{
				num += 2;
			}
			if (this.State2Unlock)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004455 RID: 17493 RVA: 0x000A7A50 File Offset: 0x000A5C50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CiacconaActivityStateUnlockUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			if (other.State1Unlock)
			{
				this.State1Unlock = other.State1Unlock;
			}
			if (other.State2Unlock)
			{
				this.State2Unlock = other.State2Unlock;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004456 RID: 17494 RVA: 0x000A7AB4 File Offset: 0x000A5CB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004457 RID: 17495 RVA: 0x000A7AC0 File Offset: 0x000A5CC0
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
				if (num != 56U)
				{
					if (num != 104U)
					{
						if (num != 112U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.State1Unlock = input.ReadBool();
						}
					}
					else
					{
						this.ActivityId = input.ReadInt32();
					}
				}
				else
				{
					this.State2Unlock = input.ReadBool();
				}
			}
		}

		// Token: 0x04002E90 RID: 11920
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002E91 RID: 11921
		public const int ActivityIdFieldNumber = 13;

		// Token: 0x04002E92 RID: 11922
		private int activityId_;

		// Token: 0x04002E93 RID: 11923
		public const int State1UnlockFieldNumber = 14;

		// Token: 0x04002E94 RID: 11924
		private bool state1Unlock_;

		// Token: 0x04002E95 RID: 11925
		public const int State2UnlockFieldNumber = 7;

		// Token: 0x04002E96 RID: 11926
		private bool state2Unlock_;
	}
}
