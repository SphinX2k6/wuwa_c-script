using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007B8 RID: 1976
	[NetMessage(EMessageId.HookLockPointInfoNotify)]
	public sealed class HookLockPointInfoNotify : IMessage<HookLockPointInfoNotify>, IMessage, IEquatable<HookLockPointInfoNotify>, IDeepCloneable<HookLockPointInfoNotify>, IBufferMessage
	{
		// Token: 0x0600B1E5 RID: 45541 RVA: 0x001AA39D File Offset: 0x001A859D
		[NullableContext(1)]
		public static HookLockPointInfoNotify Create()
		{
			return new HookLockPointInfoNotify();
		}

		// Token: 0x170023E4 RID: 9188
		// (get) Token: 0x0600B1E6 RID: 45542 RVA: 0x001AA3A4 File Offset: 0x001A85A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170023E5 RID: 9189
		// (get) Token: 0x0600B1E7 RID: 45543 RVA: 0x001AA3A7 File Offset: 0x001A85A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HookLockPointInfoNotify.Descriptor;
			}
		}

		// Token: 0x0600B1E8 RID: 45544 RVA: 0x001AA3AE File Offset: 0x001A85AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HookLockPointInfoNotify()
		{
		}

		// Token: 0x0600B1E9 RID: 45545 RVA: 0x001AA3B6 File Offset: 0x001A85B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HookLockPointInfoNotify(HookLockPointInfoNotify other) : this()
		{
			this.hookLockPointEntityId_ = other.hookLockPointEntityId_;
			this.isDisabled_ = other.isDisabled_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B1EA RID: 45546 RVA: 0x001AA3E7 File Offset: 0x001A85E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HookLockPointInfoNotify Clone()
		{
			return new HookLockPointInfoNotify(this);
		}

		// Token: 0x170023E6 RID: 9190
		// (get) Token: 0x0600B1EB RID: 45547 RVA: 0x001AA3EF File Offset: 0x001A85EF
		// (set) Token: 0x0600B1EC RID: 45548 RVA: 0x001AA3F7 File Offset: 0x001A85F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long HookLockPointEntityId
		{
			get
			{
				return this.hookLockPointEntityId_;
			}
			set
			{
				this.hookLockPointEntityId_ = value;
			}
		}

		// Token: 0x170023E7 RID: 9191
		// (get) Token: 0x0600B1ED RID: 45549 RVA: 0x001AA400 File Offset: 0x001A8600
		// (set) Token: 0x0600B1EE RID: 45550 RVA: 0x001AA408 File Offset: 0x001A8608
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsDisabled
		{
			get
			{
				return this.isDisabled_;
			}
			set
			{
				this.isDisabled_ = value;
			}
		}

		// Token: 0x0600B1EF RID: 45551 RVA: 0x001AA411 File Offset: 0x001A8611
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HookLockPointInfoNotify);
		}

		// Token: 0x0600B1F0 RID: 45552 RVA: 0x001AA41F File Offset: 0x001A861F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HookLockPointInfoNotify other)
		{
			return other != null && (other == this || (this.HookLockPointEntityId == other.HookLockPointEntityId && this.IsDisabled == other.IsDisabled && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B1F1 RID: 45553 RVA: 0x001AA460 File Offset: 0x001A8660
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.HookLockPointEntityId != 0L)
			{
				num ^= this.HookLockPointEntityId.GetHashCode();
			}
			if (this.IsDisabled)
			{
				num ^= this.IsDisabled.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B1F2 RID: 45554 RVA: 0x001AA4B8 File Offset: 0x001A86B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B1F3 RID: 45555 RVA: 0x001AA4C5 File Offset: 0x001A86C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B1F4 RID: 45556 RVA: 0x001AA4D0 File Offset: 0x001A86D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsDisabled)
			{
				output.WriteRawTag(80);
				output.WriteBool(this.IsDisabled);
			}
			if (this.HookLockPointEntityId != 0L)
			{
				output.WriteRawTag(104);
				output.WriteInt64(this.HookLockPointEntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B1F5 RID: 45557 RVA: 0x001AA52C File Offset: 0x001A872C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.HookLockPointEntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.HookLockPointEntityId);
			}
			if (this.IsDisabled)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B1F6 RID: 45558 RVA: 0x001AA578 File Offset: 0x001A8778
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HookLockPointInfoNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.HookLockPointEntityId != 0L)
			{
				this.HookLockPointEntityId = other.HookLockPointEntityId;
			}
			if (other.IsDisabled)
			{
				this.IsDisabled = other.IsDisabled;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B1F7 RID: 45559 RVA: 0x001AA5C8 File Offset: 0x001A87C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B1F8 RID: 45560 RVA: 0x001AA5D4 File Offset: 0x001A87D4
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
				if (num != 80U)
				{
					if (num != 104U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.HookLockPointEntityId = input.ReadInt64();
					}
				}
				else
				{
					this.IsDisabled = input.ReadBool();
				}
			}
		}

		// Token: 0x04004FA6 RID: 20390
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004FA7 RID: 20391
		public const int HookLockPointEntityIdFieldNumber = 13;

		// Token: 0x04004FA8 RID: 20392
		private long hookLockPointEntityId_;

		// Token: 0x04004FA9 RID: 20393
		public const int IsDisabledFieldNumber = 10;

		// Token: 0x04004FAA RID: 20394
		private bool isDisabled_;
	}
}
