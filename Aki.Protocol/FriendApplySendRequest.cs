using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200063C RID: 1596
	[NetMessage(EMessageId.FriendApplySendRequest)]
	public sealed class FriendApplySendRequest : IMessage<FriendApplySendRequest>, IMessage, IEquatable<FriendApplySendRequest>, IDeepCloneable<FriendApplySendRequest>, IBufferMessage
	{
		// Token: 0x06009342 RID: 37698 RVA: 0x001646D4 File Offset: 0x001628D4
		[NullableContext(1)]
		public static FriendApplySendRequest Create()
		{
			return new FriendApplySendRequest();
		}

		// Token: 0x17001D4A RID: 7498
		// (get) Token: 0x06009343 RID: 37699 RVA: 0x001646DB File Offset: 0x001628DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001D4B RID: 7499
		// (get) Token: 0x06009344 RID: 37700 RVA: 0x001646DE File Offset: 0x001628DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FriendApplySendRequest.Descriptor;
			}
		}

		// Token: 0x06009345 RID: 37701 RVA: 0x001646E5 File Offset: 0x001628E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FriendApplySendRequest()
		{
		}

		// Token: 0x06009346 RID: 37702 RVA: 0x001646ED File Offset: 0x001628ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FriendApplySendRequest(FriendApplySendRequest other) : this()
		{
			this.id_ = other.id_;
			this.way_ = other.way_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009347 RID: 37703 RVA: 0x0016471E File Offset: 0x0016291E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FriendApplySendRequest Clone()
		{
			return new FriendApplySendRequest(this);
		}

		// Token: 0x17001D4C RID: 7500
		// (get) Token: 0x06009348 RID: 37704 RVA: 0x00164726 File Offset: 0x00162926
		// (set) Token: 0x06009349 RID: 37705 RVA: 0x0016472E File Offset: 0x0016292E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x17001D4D RID: 7501
		// (get) Token: 0x0600934A RID: 37706 RVA: 0x00164737 File Offset: 0x00162937
		// (set) Token: 0x0600934B RID: 37707 RVA: 0x0016473F File Offset: 0x0016293F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FriendApplyWay Way
		{
			get
			{
				return this.way_;
			}
			set
			{
				this.way_ = value;
			}
		}

		// Token: 0x0600934C RID: 37708 RVA: 0x00164748 File Offset: 0x00162948
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FriendApplySendRequest);
		}

		// Token: 0x0600934D RID: 37709 RVA: 0x00164756 File Offset: 0x00162956
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FriendApplySendRequest other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.Way == other.Way && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600934E RID: 37710 RVA: 0x00164794 File Offset: 0x00162994
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.Way != FriendApplyWay.Search)
			{
				num ^= this.Way.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600934F RID: 37711 RVA: 0x001647F2 File Offset: 0x001629F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009350 RID: 37712 RVA: 0x001647FF File Offset: 0x001629FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009351 RID: 37713 RVA: 0x00164808 File Offset: 0x00162A08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Way != FriendApplyWay.Search)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.Way);
			}
			if (this.Id != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009352 RID: 37714 RVA: 0x00164864 File Offset: 0x00162A64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.Way != FriendApplyWay.Search)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Way);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009353 RID: 37715 RVA: 0x001648BC File Offset: 0x00162ABC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FriendApplySendRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.Way != FriendApplyWay.Search)
			{
				this.Way = other.Way;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009354 RID: 37716 RVA: 0x0016490C File Offset: 0x00162B0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009355 RID: 37717 RVA: 0x00164918 File Offset: 0x00162B18
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
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Id = input.ReadInt32();
					}
				}
				else
				{
					this.Way = (FriendApplyWay)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400472A RID: 18218
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400472B RID: 18219
		public const int IdFieldNumber = 11;

		// Token: 0x0400472C RID: 18220
		private int id_;

		// Token: 0x0400472D RID: 18221
		public const int WayFieldNumber = 2;

		// Token: 0x0400472E RID: 18222
		private FriendApplyWay way_;
	}
}
