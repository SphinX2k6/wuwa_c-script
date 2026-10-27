using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200078B RID: 1931
	[NetMessage(EMessageId.HonamiStoryLockItemRequest)]
	public sealed class HonamiStoryLockItemRequest : IMessage<HonamiStoryLockItemRequest>, IMessage, IEquatable<HonamiStoryLockItemRequest>, IDeepCloneable<HonamiStoryLockItemRequest>, IBufferMessage
	{
		// Token: 0x0600AE5F RID: 44639 RVA: 0x001A2F09 File Offset: 0x001A1109
		[NullableContext(1)]
		public static HonamiStoryLockItemRequest Create()
		{
			return new HonamiStoryLockItemRequest();
		}

		// Token: 0x1700232E RID: 9006
		// (get) Token: 0x0600AE60 RID: 44640 RVA: 0x001A2F10 File Offset: 0x001A1110
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700232F RID: 9007
		// (get) Token: 0x0600AE61 RID: 44641 RVA: 0x001A2F13 File Offset: 0x001A1113
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HonamiStoryLockItemRequest.Descriptor;
			}
		}

		// Token: 0x0600AE62 RID: 44642 RVA: 0x001A2F1A File Offset: 0x001A111A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryLockItemRequest()
		{
		}

		// Token: 0x0600AE63 RID: 44643 RVA: 0x001A2F22 File Offset: 0x001A1122
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryLockItemRequest(HonamiStoryLockItemRequest other) : this()
		{
			this.backPackId_ = other.backPackId_;
			this.itemUid_ = other.itemUid_;
			this.isLock_ = other.isLock_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AE64 RID: 44644 RVA: 0x001A2F5F File Offset: 0x001A115F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryLockItemRequest Clone()
		{
			return new HonamiStoryLockItemRequest(this);
		}

		// Token: 0x17002330 RID: 9008
		// (get) Token: 0x0600AE65 RID: 44645 RVA: 0x001A2F67 File Offset: 0x001A1167
		// (set) Token: 0x0600AE66 RID: 44646 RVA: 0x001A2F6F File Offset: 0x001A116F
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

		// Token: 0x17002331 RID: 9009
		// (get) Token: 0x0600AE67 RID: 44647 RVA: 0x001A2F78 File Offset: 0x001A1178
		// (set) Token: 0x0600AE68 RID: 44648 RVA: 0x001A2F80 File Offset: 0x001A1180
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

		// Token: 0x17002332 RID: 9010
		// (get) Token: 0x0600AE69 RID: 44649 RVA: 0x001A2F89 File Offset: 0x001A1189
		// (set) Token: 0x0600AE6A RID: 44650 RVA: 0x001A2F91 File Offset: 0x001A1191
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

		// Token: 0x0600AE6B RID: 44651 RVA: 0x001A2F9A File Offset: 0x001A119A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HonamiStoryLockItemRequest);
		}

		// Token: 0x0600AE6C RID: 44652 RVA: 0x001A2FA8 File Offset: 0x001A11A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HonamiStoryLockItemRequest other)
		{
			return other != null && (other == this || (this.BackPackId == other.BackPackId && this.ItemUid == other.ItemUid && this.IsLock == other.IsLock && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600AE6D RID: 44653 RVA: 0x001A3004 File Offset: 0x001A1204
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
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

		// Token: 0x0600AE6E RID: 44654 RVA: 0x001A3075 File Offset: 0x001A1275
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600AE6F RID: 44655 RVA: 0x001A3082 File Offset: 0x001A1282
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AE70 RID: 44656 RVA: 0x001A308C File Offset: 0x001A128C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.BackPackId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.BackPackId);
			}
			if (this.IsLock)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.IsLock);
			}
			if (this.ItemUid != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.ItemUid);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AE71 RID: 44657 RVA: 0x001A3104 File Offset: 0x001A1304
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
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

		// Token: 0x0600AE72 RID: 44658 RVA: 0x001A3168 File Offset: 0x001A1368
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HonamiStoryLockItemRequest other)
		{
			if (other == null)
			{
				return;
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

		// Token: 0x0600AE73 RID: 44659 RVA: 0x001A31CC File Offset: 0x001A13CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AE74 RID: 44660 RVA: 0x001A31D8 File Offset: 0x001A13D8
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
					if (num != 32U)
					{
						if (num != 96U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.ItemUid = input.ReadInt32();
						}
					}
					else
					{
						this.IsLock = input.ReadBool();
					}
				}
				else
				{
					this.BackPackId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004EB5 RID: 20149
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004EB6 RID: 20150
		public const int BackPackIdFieldNumber = 3;

		// Token: 0x04004EB7 RID: 20151
		private int backPackId_;

		// Token: 0x04004EB8 RID: 20152
		public const int ItemUidFieldNumber = 12;

		// Token: 0x04004EB9 RID: 20153
		private int itemUid_;

		// Token: 0x04004EBA RID: 20154
		public const int IsLockFieldNumber = 4;

		// Token: 0x04004EBB RID: 20155
		private bool isLock_;
	}
}
