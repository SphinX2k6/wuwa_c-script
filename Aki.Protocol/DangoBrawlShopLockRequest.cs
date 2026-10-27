using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000372 RID: 882
	[NetMessage(EMessageId.DangoBrawlShopLockRequest)]
	public sealed class DangoBrawlShopLockRequest : IMessage<DangoBrawlShopLockRequest>, IMessage, IEquatable<DangoBrawlShopLockRequest>, IDeepCloneable<DangoBrawlShopLockRequest>, IBufferMessage
	{
		// Token: 0x060057B6 RID: 22454 RVA: 0x000D6377 File Offset: 0x000D4577
		[NullableContext(1)]
		public static DangoBrawlShopLockRequest Create()
		{
			return new DangoBrawlShopLockRequest();
		}

		// Token: 0x17001025 RID: 4133
		// (get) Token: 0x060057B7 RID: 22455 RVA: 0x000D637E File Offset: 0x000D457E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001026 RID: 4134
		// (get) Token: 0x060057B8 RID: 22456 RVA: 0x000D6381 File Offset: 0x000D4581
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoBrawlShopLockRequest.Descriptor;
			}
		}

		// Token: 0x060057B9 RID: 22457 RVA: 0x000D6388 File Offset: 0x000D4588
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlShopLockRequest()
		{
		}

		// Token: 0x060057BA RID: 22458 RVA: 0x000D6390 File Offset: 0x000D4590
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlShopLockRequest(DangoBrawlShopLockRequest other) : this()
		{
			this.slotUid_ = other.slotUid_;
			this.locked_ = other.locked_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060057BB RID: 22459 RVA: 0x000D63C1 File Offset: 0x000D45C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlShopLockRequest Clone()
		{
			return new DangoBrawlShopLockRequest(this);
		}

		// Token: 0x17001027 RID: 4135
		// (get) Token: 0x060057BC RID: 22460 RVA: 0x000D63C9 File Offset: 0x000D45C9
		// (set) Token: 0x060057BD RID: 22461 RVA: 0x000D63D1 File Offset: 0x000D45D1
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

		// Token: 0x17001028 RID: 4136
		// (get) Token: 0x060057BE RID: 22462 RVA: 0x000D63DA File Offset: 0x000D45DA
		// (set) Token: 0x060057BF RID: 22463 RVA: 0x000D63E2 File Offset: 0x000D45E2
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

		// Token: 0x060057C0 RID: 22464 RVA: 0x000D63EB File Offset: 0x000D45EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoBrawlShopLockRequest);
		}

		// Token: 0x060057C1 RID: 22465 RVA: 0x000D63F9 File Offset: 0x000D45F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoBrawlShopLockRequest other)
		{
			return other != null && (other == this || (this.SlotUid == other.SlotUid && this.Locked == other.Locked && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060057C2 RID: 22466 RVA: 0x000D6438 File Offset: 0x000D4638
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

		// Token: 0x060057C3 RID: 22467 RVA: 0x000D6490 File Offset: 0x000D4690
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060057C4 RID: 22468 RVA: 0x000D649D File Offset: 0x000D469D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060057C5 RID: 22469 RVA: 0x000D64A8 File Offset: 0x000D46A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Locked)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.Locked);
			}
			if (this.SlotUid != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.SlotUid);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060057C6 RID: 22470 RVA: 0x000D6504 File Offset: 0x000D4704
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

		// Token: 0x060057C7 RID: 22471 RVA: 0x000D6550 File Offset: 0x000D4750
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

		// Token: 0x060057C8 RID: 22472 RVA: 0x000D65A0 File Offset: 0x000D47A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060057C9 RID: 22473 RVA: 0x000D65AC File Offset: 0x000D47AC
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
					if (num != 48U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.SlotUid = input.ReadInt32();
					}
				}
				else
				{
					this.Locked = input.ReadBool();
				}
			}
		}

		// Token: 0x040034E9 RID: 13545
		private UnknownFieldSet _unknownFields;

		// Token: 0x040034EA RID: 13546
		public const int SlotUidFieldNumber = 6;

		// Token: 0x040034EB RID: 13547
		private int slotUid_;

		// Token: 0x040034EC RID: 13548
		public const int LockedFieldNumber = 3;

		// Token: 0x040034ED RID: 13549
		private bool locked_;
	}
}
