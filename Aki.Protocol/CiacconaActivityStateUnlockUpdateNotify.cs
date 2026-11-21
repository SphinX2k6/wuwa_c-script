using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000293 RID: 659
	[NetMessage(EMessageId.CiacconaActivityStateUnlockUpdateNotify)]
	public sealed class CiacconaActivityStateUnlockUpdateNotify : IMessage<CiacconaActivityStateUnlockUpdateNotify>, IMessage, IEquatable<CiacconaActivityStateUnlockUpdateNotify>, IDeepCloneable<CiacconaActivityStateUnlockUpdateNotify>, IBufferMessage
	{
		// Token: 0x060044E9 RID: 17641 RVA: 0x000A94C3 File Offset: 0x000A76C3
		[NullableContext(1)]
		public static CiacconaActivityStateUnlockUpdateNotify Create()
		{
			return new CiacconaActivityStateUnlockUpdateNotify();
		}

		// Token: 0x17000BCF RID: 3023
		// (get) Token: 0x060044EA RID: 17642 RVA: 0x000A94CA File Offset: 0x000A76CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000BD0 RID: 3024
		// (get) Token: 0x060044EB RID: 17643 RVA: 0x000A94CD File Offset: 0x000A76CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CiacconaActivityStateUnlockUpdateNotify.Descriptor;
			}
		}

		// Token: 0x060044EC RID: 17644 RVA: 0x000A94D4 File Offset: 0x000A76D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CiacconaActivityStateUnlockUpdateNotify()
		{
		}

		// Token: 0x060044ED RID: 17645 RVA: 0x000A94DC File Offset: 0x000A76DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CiacconaActivityStateUnlockUpdateNotify(CiacconaActivityStateUnlockUpdateNotify other) : this()
		{
			this.activityId_ = other.activityId_;
			this.state1Unlock_ = other.state1Unlock_;
			this.state2Unlock_ = other.state2Unlock_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060044EE RID: 17646 RVA: 0x000A9519 File Offset: 0x000A7719
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CiacconaActivityStateUnlockUpdateNotify Clone()
		{
			return new CiacconaActivityStateUnlockUpdateNotify(this);
		}

		// Token: 0x17000BD1 RID: 3025
		// (get) Token: 0x060044EF RID: 17647 RVA: 0x000A9521 File Offset: 0x000A7721
		// (set) Token: 0x060044F0 RID: 17648 RVA: 0x000A9529 File Offset: 0x000A7729
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

		// Token: 0x17000BD2 RID: 3026
		// (get) Token: 0x060044F1 RID: 17649 RVA: 0x000A9532 File Offset: 0x000A7732
		// (set) Token: 0x060044F2 RID: 17650 RVA: 0x000A953A File Offset: 0x000A773A
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

		// Token: 0x17000BD3 RID: 3027
		// (get) Token: 0x060044F3 RID: 17651 RVA: 0x000A9543 File Offset: 0x000A7743
		// (set) Token: 0x060044F4 RID: 17652 RVA: 0x000A954B File Offset: 0x000A774B
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

		// Token: 0x060044F5 RID: 17653 RVA: 0x000A9554 File Offset: 0x000A7754
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CiacconaActivityStateUnlockUpdateNotify);
		}

		// Token: 0x060044F6 RID: 17654 RVA: 0x000A9564 File Offset: 0x000A7764
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CiacconaActivityStateUnlockUpdateNotify other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.State1Unlock == other.State1Unlock && this.State2Unlock == other.State2Unlock && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060044F7 RID: 17655 RVA: 0x000A95C0 File Offset: 0x000A77C0
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

		// Token: 0x060044F8 RID: 17656 RVA: 0x000A9631 File Offset: 0x000A7831
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060044F9 RID: 17657 RVA: 0x000A963E File Offset: 0x000A783E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060044FA RID: 17658 RVA: 0x000A9648 File Offset: 0x000A7848
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.State1Unlock)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.State1Unlock);
			}
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.ActivityId);
			}
			if (this.State2Unlock)
			{
				output.WriteRawTag(112);
				output.WriteBool(this.State2Unlock);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060044FB RID: 17659 RVA: 0x000A96C0 File Offset: 0x000A78C0
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

		// Token: 0x060044FC RID: 17660 RVA: 0x000A9718 File Offset: 0x000A7918
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

		// Token: 0x060044FD RID: 17661 RVA: 0x000A977C File Offset: 0x000A797C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060044FE RID: 17662 RVA: 0x000A9788 File Offset: 0x000A7988
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
				if (num != 16U)
				{
					if (num != 88U)
					{
						if (num != 112U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.State2Unlock = input.ReadBool();
						}
					}
					else
					{
						this.ActivityId = input.ReadInt32();
					}
				}
				else
				{
					this.State1Unlock = input.ReadBool();
				}
			}
		}

		// Token: 0x04002F14 RID: 12052
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002F15 RID: 12053
		public const int ActivityIdFieldNumber = 11;

		// Token: 0x04002F16 RID: 12054
		private int activityId_;

		// Token: 0x04002F17 RID: 12055
		public const int State1UnlockFieldNumber = 2;

		// Token: 0x04002F18 RID: 12056
		private bool state1Unlock_;

		// Token: 0x04002F19 RID: 12057
		public const int State2UnlockFieldNumber = 14;

		// Token: 0x04002F1A RID: 12058
		private bool state2Unlock_;
	}
}
