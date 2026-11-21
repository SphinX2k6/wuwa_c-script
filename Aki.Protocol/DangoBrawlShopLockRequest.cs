using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200037A RID: 890
	[NetMessage(EMessageId.DangoBrawlShopLockRequest)]
	public sealed class DangoBrawlShopLockRequest : IMessage<DangoBrawlShopLockRequest>, IMessage, IEquatable<DangoBrawlShopLockRequest>, IDeepCloneable<DangoBrawlShopLockRequest>, IBufferMessage
	{
		// Token: 0x060058A3 RID: 22691 RVA: 0x000D89FF File Offset: 0x000D6BFF
		[NullableContext(1)]
		public static DangoBrawlShopLockRequest Create()
		{
			return new DangoBrawlShopLockRequest();
		}

		// Token: 0x17001056 RID: 4182
		// (get) Token: 0x060058A4 RID: 22692 RVA: 0x000D8A06 File Offset: 0x000D6C06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001057 RID: 4183
		// (get) Token: 0x060058A5 RID: 22693 RVA: 0x000D8A09 File Offset: 0x000D6C09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoBrawlShopLockRequest.Descriptor;
			}
		}

		// Token: 0x060058A6 RID: 22694 RVA: 0x000D8A10 File Offset: 0x000D6C10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlShopLockRequest()
		{
		}

		// Token: 0x060058A7 RID: 22695 RVA: 0x000D8A18 File Offset: 0x000D6C18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlShopLockRequest(DangoBrawlShopLockRequest other) : this()
		{
			this.slotUid_ = other.slotUid_;
			this.locked_ = other.locked_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060058A8 RID: 22696 RVA: 0x000D8A49 File Offset: 0x000D6C49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlShopLockRequest Clone()
		{
			return new DangoBrawlShopLockRequest(this);
		}

		// Token: 0x17001058 RID: 4184
		// (get) Token: 0x060058A9 RID: 22697 RVA: 0x000D8A51 File Offset: 0x000D6C51
		// (set) Token: 0x060058AA RID: 22698 RVA: 0x000D8A59 File Offset: 0x000D6C59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SlotUid
		{
			get
			{
				return this.slotUid_;
			}
			set
			{
				this.slotUid_ = value;
			}
		}

		// Token: 0x17001059 RID: 4185
		// (get) Token: 0x060058AB RID: 22699 RVA: 0x000D8A62 File Offset: 0x000D6C62
		// (set) Token: 0x060058AC RID: 22700 RVA: 0x000D8A6A File Offset: 0x000D6C6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Locked
		{
			get
			{
				return this.locked_;
			}
			set
			{
				this.locked_ = value;
			}
		}

		// Token: 0x060058AD RID: 22701 RVA: 0x000D8A73 File Offset: 0x000D6C73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoBrawlShopLockRequest);
		}

		// Token: 0x060058AE RID: 22702 RVA: 0x000D8A81 File Offset: 0x000D6C81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoBrawlShopLockRequest other)
		{
			return other != null && (other == this || (this.SlotUid == other.SlotUid && this.Locked == other.Locked && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060058AF RID: 22703 RVA: 0x000D8AC0 File Offset: 0x000D6CC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SlotUid != 0)
			{
				num ^= this.SlotUid.GetHashCode();
			}
			if (this.Locked)
			{
				num ^= this.Locked.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060058B0 RID: 22704 RVA: 0x000D8B18 File Offset: 0x000D6D18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060058B1 RID: 22705 RVA: 0x000D8B25 File Offset: 0x000D6D25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060058B2 RID: 22706 RVA: 0x000D8B30 File Offset: 0x000D6D30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SlotUid != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.SlotUid);
			}
			if (this.Locked)
			{
				output.WriteRawTag(96);
				output.WriteBool(this.Locked);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060058B3 RID: 22707 RVA: 0x000D8B8C File Offset: 0x000D6D8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SlotUid != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SlotUid);
			}
			if (this.Locked)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060058B4 RID: 22708 RVA: 0x000D8BD8 File Offset: 0x000D6DD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DangoBrawlShopLockRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SlotUid != 0)
			{
				this.SlotUid = other.SlotUid;
			}
			if (other.Locked)
			{
				this.Locked = other.Locked;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060058B5 RID: 22709 RVA: 0x000D8C28 File Offset: 0x000D6E28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060058B6 RID: 22710 RVA: 0x000D8C34 File Offset: 0x000D6E34
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
				if (num != 48U)
				{
					if (num != 96U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Locked = input.ReadBool();
					}
				}
				else
				{
					this.SlotUid = input.ReadInt32();
				}
			}
		}

		// Token: 0x04003585 RID: 13701
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003586 RID: 13702
		public const int SlotUidFieldNumber = 6;

		// Token: 0x04003587 RID: 13703
		private int slotUid_;

		// Token: 0x04003588 RID: 13704
		public const int LockedFieldNumber = 12;

		// Token: 0x04003589 RID: 13705
		private bool locked_;
	}
}
