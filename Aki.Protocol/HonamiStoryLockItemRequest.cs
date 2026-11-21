using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000777 RID: 1911
	[NetMessage(EMessageId.HonamiStoryLockItemRequest)]
	public sealed class HonamiStoryLockItemRequest : IMessage<HonamiStoryLockItemRequest>, IMessage, IEquatable<HonamiStoryLockItemRequest>, IDeepCloneable<HonamiStoryLockItemRequest>, IBufferMessage
	{
		// Token: 0x0600AD09 RID: 44297 RVA: 0x001A04E5 File Offset: 0x0019E6E5
		[NullableContext(1)]
		public static HonamiStoryLockItemRequest Create()
		{
			return new HonamiStoryLockItemRequest();
		}

		// Token: 0x170022E4 RID: 8932
		// (get) Token: 0x0600AD0A RID: 44298 RVA: 0x001A04EC File Offset: 0x0019E6EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170022E5 RID: 8933
		// (get) Token: 0x0600AD0B RID: 44299 RVA: 0x001A04EF File Offset: 0x0019E6EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HonamiStoryLockItemRequest.Descriptor;
			}
		}

		// Token: 0x0600AD0C RID: 44300 RVA: 0x001A04F6 File Offset: 0x0019E6F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryLockItemRequest()
		{
		}

		// Token: 0x0600AD0D RID: 44301 RVA: 0x001A04FE File Offset: 0x0019E6FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryLockItemRequest(HonamiStoryLockItemRequest other) : this()
		{
			this.backPackId_ = other.backPackId_;
			this.itemUid_ = other.itemUid_;
			this.isLock_ = other.isLock_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AD0E RID: 44302 RVA: 0x001A053B File Offset: 0x0019E73B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryLockItemRequest Clone()
		{
			return new HonamiStoryLockItemRequest(this);
		}

		// Token: 0x170022E6 RID: 8934
		// (get) Token: 0x0600AD0F RID: 44303 RVA: 0x001A0543 File Offset: 0x0019E743
		// (set) Token: 0x0600AD10 RID: 44304 RVA: 0x001A054B File Offset: 0x0019E74B
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

		// Token: 0x170022E7 RID: 8935
		// (get) Token: 0x0600AD11 RID: 44305 RVA: 0x001A0554 File Offset: 0x0019E754
		// (set) Token: 0x0600AD12 RID: 44306 RVA: 0x001A055C File Offset: 0x0019E75C
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

		// Token: 0x170022E8 RID: 8936
		// (get) Token: 0x0600AD13 RID: 44307 RVA: 0x001A0565 File Offset: 0x0019E765
		// (set) Token: 0x0600AD14 RID: 44308 RVA: 0x001A056D File Offset: 0x0019E76D
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

		// Token: 0x0600AD15 RID: 44309 RVA: 0x001A0576 File Offset: 0x0019E776
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HonamiStoryLockItemRequest);
		}

		// Token: 0x0600AD16 RID: 44310 RVA: 0x001A0584 File Offset: 0x0019E784
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HonamiStoryLockItemRequest other)
		{
			return other != null && (other == this || (this.BackPackId == other.BackPackId && this.ItemUid == other.ItemUid && this.IsLock == other.IsLock && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600AD17 RID: 44311 RVA: 0x001A05E0 File Offset: 0x0019E7E0
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

		// Token: 0x0600AD18 RID: 44312 RVA: 0x001A0651 File Offset: 0x0019E851
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600AD19 RID: 44313 RVA: 0x001A065E File Offset: 0x0019E85E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AD1A RID: 44314 RVA: 0x001A0668 File Offset: 0x0019E868
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.BackPackId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.BackPackId);
			}
			if (this.ItemUid != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.ItemUid);
			}
			if (this.IsLock)
			{
				output.WriteRawTag(64);
				output.WriteBool(this.IsLock);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AD1B RID: 44315 RVA: 0x001A06E0 File Offset: 0x0019E8E0
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

		// Token: 0x0600AD1C RID: 44316 RVA: 0x001A0744 File Offset: 0x0019E944
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

		// Token: 0x0600AD1D RID: 44317 RVA: 0x001A07A8 File Offset: 0x0019E9A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AD1E RID: 44318 RVA: 0x001A07B4 File Offset: 0x0019E9B4
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
				if (num != 32U)
				{
					if (num != 56U)
					{
						if (num != 64U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.IsLock = input.ReadBool();
						}
					}
					else
					{
						this.ItemUid = input.ReadInt32();
					}
				}
				else
				{
					this.BackPackId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004EAE RID: 20142
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004EAF RID: 20143
		public const int BackPackIdFieldNumber = 4;

		// Token: 0x04004EB0 RID: 20144
		private int backPackId_;

		// Token: 0x04004EB1 RID: 20145
		public const int ItemUidFieldNumber = 7;

		// Token: 0x04004EB2 RID: 20146
		private int itemUid_;

		// Token: 0x04004EB3 RID: 20147
		public const int IsLockFieldNumber = 8;

		// Token: 0x04004EB4 RID: 20148
		private bool isLock_;
	}
}
