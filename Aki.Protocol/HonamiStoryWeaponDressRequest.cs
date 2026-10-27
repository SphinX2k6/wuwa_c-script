using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007AD RID: 1965
	[NetMessage(EMessageId.HonamiStoryWeaponDressRequest)]
	public sealed class HonamiStoryWeaponDressRequest : IMessage<HonamiStoryWeaponDressRequest>, IMessage, IEquatable<HonamiStoryWeaponDressRequest>, IDeepCloneable<HonamiStoryWeaponDressRequest>, IBufferMessage
	{
		// Token: 0x0600B107 RID: 45319 RVA: 0x001A85E6 File Offset: 0x001A67E6
		[NullableContext(1)]
		public static HonamiStoryWeaponDressRequest Create()
		{
			return new HonamiStoryWeaponDressRequest();
		}

		// Token: 0x170023B7 RID: 9143
		// (get) Token: 0x0600B108 RID: 45320 RVA: 0x001A85ED File Offset: 0x001A67ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170023B8 RID: 9144
		// (get) Token: 0x0600B109 RID: 45321 RVA: 0x001A85F0 File Offset: 0x001A67F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HonamiStoryWeaponDressRequest.Descriptor;
			}
		}

		// Token: 0x0600B10A RID: 45322 RVA: 0x001A85F7 File Offset: 0x001A67F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryWeaponDressRequest()
		{
		}

		// Token: 0x0600B10B RID: 45323 RVA: 0x001A85FF File Offset: 0x001A67FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryWeaponDressRequest(HonamiStoryWeaponDressRequest other) : this()
		{
			this.weaponItemId_ = other.weaponItemId_;
			this.rackIndex_ = other.rackIndex_;
			this.activityId_ = other.activityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B10C RID: 45324 RVA: 0x001A863C File Offset: 0x001A683C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryWeaponDressRequest Clone()
		{
			return new HonamiStoryWeaponDressRequest(this);
		}

		// Token: 0x170023B9 RID: 9145
		// (get) Token: 0x0600B10D RID: 45325 RVA: 0x001A8644 File Offset: 0x001A6844
		// (set) Token: 0x0600B10E RID: 45326 RVA: 0x001A864C File Offset: 0x001A684C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int WeaponItemId
		{
			get
			{
				return this.weaponItemId_;
			}
			set
			{
				this.weaponItemId_ = value;
			}
		}

		// Token: 0x170023BA RID: 9146
		// (get) Token: 0x0600B10F RID: 45327 RVA: 0x001A8655 File Offset: 0x001A6855
		// (set) Token: 0x0600B110 RID: 45328 RVA: 0x001A865D File Offset: 0x001A685D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RackIndex
		{
			get
			{
				return this.rackIndex_;
			}
			set
			{
				this.rackIndex_ = value;
			}
		}

		// Token: 0x170023BB RID: 9147
		// (get) Token: 0x0600B111 RID: 45329 RVA: 0x001A8666 File Offset: 0x001A6866
		// (set) Token: 0x0600B112 RID: 45330 RVA: 0x001A866E File Offset: 0x001A686E
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

		// Token: 0x0600B113 RID: 45331 RVA: 0x001A8677 File Offset: 0x001A6877
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HonamiStoryWeaponDressRequest);
		}

		// Token: 0x0600B114 RID: 45332 RVA: 0x001A8688 File Offset: 0x001A6888
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HonamiStoryWeaponDressRequest other)
		{
			return other != null && (other == this || (this.WeaponItemId == other.WeaponItemId && this.RackIndex == other.RackIndex && this.ActivityId == other.ActivityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B115 RID: 45333 RVA: 0x001A86E4 File Offset: 0x001A68E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.WeaponItemId != 0)
			{
				num ^= this.WeaponItemId.GetHashCode();
			}
			if (this.RackIndex != 0)
			{
				num ^= this.RackIndex.GetHashCode();
			}
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B116 RID: 45334 RVA: 0x001A8755 File Offset: 0x001A6955
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B117 RID: 45335 RVA: 0x001A8762 File Offset: 0x001A6962
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B118 RID: 45336 RVA: 0x001A876C File Offset: 0x001A696C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.ActivityId);
			}
			if (this.RackIndex != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.RackIndex);
			}
			if (this.WeaponItemId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.WeaponItemId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B119 RID: 45337 RVA: 0x001A87E4 File Offset: 0x001A69E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.WeaponItemId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.WeaponItemId);
			}
			if (this.RackIndex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RackIndex);
			}
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B11A RID: 45338 RVA: 0x001A8854 File Offset: 0x001A6A54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HonamiStoryWeaponDressRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.WeaponItemId != 0)
			{
				this.WeaponItemId = other.WeaponItemId;
			}
			if (other.RackIndex != 0)
			{
				this.RackIndex = other.RackIndex;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B11B RID: 45339 RVA: 0x001A88B8 File Offset: 0x001A6AB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B11C RID: 45340 RVA: 0x001A88C4 File Offset: 0x001A6AC4
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
					if (num != 32U)
					{
						if (num != 40U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.WeaponItemId = input.ReadInt32();
						}
					}
					else
					{
						this.RackIndex = input.ReadInt32();
					}
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004F6A RID: 20330
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004F6B RID: 20331
		public const int WeaponItemIdFieldNumber = 5;

		// Token: 0x04004F6C RID: 20332
		private int weaponItemId_;

		// Token: 0x04004F6D RID: 20333
		public const int RackIndexFieldNumber = 4;

		// Token: 0x04004F6E RID: 20334
		private int rackIndex_;

		// Token: 0x04004F6F RID: 20335
		public const int ActivityIdFieldNumber = 2;

		// Token: 0x04004F70 RID: 20336
		private int activityId_;
	}
}
