using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000799 RID: 1945
	[NetMessage(EMessageId.HonamiStoryWeaponDressRequest)]
	public sealed class HonamiStoryWeaponDressRequest : IMessage<HonamiStoryWeaponDressRequest>, IMessage, IEquatable<HonamiStoryWeaponDressRequest>, IDeepCloneable<HonamiStoryWeaponDressRequest>, IBufferMessage
	{
		// Token: 0x0600AFB1 RID: 44977 RVA: 0x001A5BBA File Offset: 0x001A3DBA
		[NullableContext(1)]
		public static HonamiStoryWeaponDressRequest Create()
		{
			return new HonamiStoryWeaponDressRequest();
		}

		// Token: 0x1700236D RID: 9069
		// (get) Token: 0x0600AFB2 RID: 44978 RVA: 0x001A5BC1 File Offset: 0x001A3DC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700236E RID: 9070
		// (get) Token: 0x0600AFB3 RID: 44979 RVA: 0x001A5BC4 File Offset: 0x001A3DC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HonamiStoryWeaponDressRequest.Descriptor;
			}
		}

		// Token: 0x0600AFB4 RID: 44980 RVA: 0x001A5BCB File Offset: 0x001A3DCB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryWeaponDressRequest()
		{
		}

		// Token: 0x0600AFB5 RID: 44981 RVA: 0x001A5BD3 File Offset: 0x001A3DD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryWeaponDressRequest(HonamiStoryWeaponDressRequest other) : this()
		{
			this.weaponItemId_ = other.weaponItemId_;
			this.rackIndex_ = other.rackIndex_;
			this.activityId_ = other.activityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AFB6 RID: 44982 RVA: 0x001A5C10 File Offset: 0x001A3E10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryWeaponDressRequest Clone()
		{
			return new HonamiStoryWeaponDressRequest(this);
		}

		// Token: 0x1700236F RID: 9071
		// (get) Token: 0x0600AFB7 RID: 44983 RVA: 0x001A5C18 File Offset: 0x001A3E18
		// (set) Token: 0x0600AFB8 RID: 44984 RVA: 0x001A5C20 File Offset: 0x001A3E20
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

		// Token: 0x17002370 RID: 9072
		// (get) Token: 0x0600AFB9 RID: 44985 RVA: 0x001A5C29 File Offset: 0x001A3E29
		// (set) Token: 0x0600AFBA RID: 44986 RVA: 0x001A5C31 File Offset: 0x001A3E31
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

		// Token: 0x17002371 RID: 9073
		// (get) Token: 0x0600AFBB RID: 44987 RVA: 0x001A5C3A File Offset: 0x001A3E3A
		// (set) Token: 0x0600AFBC RID: 44988 RVA: 0x001A5C42 File Offset: 0x001A3E42
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

		// Token: 0x0600AFBD RID: 44989 RVA: 0x001A5C4B File Offset: 0x001A3E4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HonamiStoryWeaponDressRequest);
		}

		// Token: 0x0600AFBE RID: 44990 RVA: 0x001A5C5C File Offset: 0x001A3E5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HonamiStoryWeaponDressRequest other)
		{
			return other != null && (other == this || (this.WeaponItemId == other.WeaponItemId && this.RackIndex == other.RackIndex && this.ActivityId == other.ActivityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600AFBF RID: 44991 RVA: 0x001A5CB8 File Offset: 0x001A3EB8
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

		// Token: 0x0600AFC0 RID: 44992 RVA: 0x001A5D29 File Offset: 0x001A3F29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600AFC1 RID: 44993 RVA: 0x001A5D36 File Offset: 0x001A3F36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AFC2 RID: 44994 RVA: 0x001A5D40 File Offset: 0x001A3F40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.WeaponItemId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.WeaponItemId);
			}
			if (this.RackIndex != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.RackIndex);
			}
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AFC3 RID: 44995 RVA: 0x001A5DB4 File Offset: 0x001A3FB4
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

		// Token: 0x0600AFC4 RID: 44996 RVA: 0x001A5E24 File Offset: 0x001A4024
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

		// Token: 0x0600AFC5 RID: 44997 RVA: 0x001A5E88 File Offset: 0x001A4088
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AFC6 RID: 44998 RVA: 0x001A5E94 File Offset: 0x001A4094
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
				if (num != 8U)
				{
					if (num != 80U)
					{
						if (num != 104U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.ActivityId = input.ReadInt32();
						}
					}
					else
					{
						this.RackIndex = input.ReadInt32();
					}
				}
				else
				{
					this.WeaponItemId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004F63 RID: 20323
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004F64 RID: 20324
		public const int WeaponItemIdFieldNumber = 1;

		// Token: 0x04004F65 RID: 20325
		private int weaponItemId_;

		// Token: 0x04004F66 RID: 20326
		public const int RackIndexFieldNumber = 10;

		// Token: 0x04004F67 RID: 20327
		private int rackIndex_;

		// Token: 0x04004F68 RID: 20328
		public const int ActivityIdFieldNumber = 13;

		// Token: 0x04004F69 RID: 20329
		private int activityId_;
	}
}
