using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200141B RID: 5147
	[NetMessage(EMessageId.TowerDefencePlayerReviveNotify)]
	public sealed class TowerDefencePlayerReviveNotify : IMessage<TowerDefencePlayerReviveNotify>, IMessage, IEquatable<TowerDefencePlayerReviveNotify>, IDeepCloneable<TowerDefencePlayerReviveNotify>, IBufferMessage
	{
		// Token: 0x0601B5BE RID: 112062 RVA: 0x003FA8C9 File Offset: 0x003F8AC9
		[NullableContext(1)]
		public static TowerDefencePlayerReviveNotify Create()
		{
			return new TowerDefencePlayerReviveNotify();
		}

		// Token: 0x17005C9F RID: 23711
		// (get) Token: 0x0601B5BF RID: 112063 RVA: 0x003FA8D0 File Offset: 0x003F8AD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005CA0 RID: 23712
		// (get) Token: 0x0601B5C0 RID: 112064 RVA: 0x003FA8D3 File Offset: 0x003F8AD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TowerDefencePlayerReviveNotify.Descriptor;
			}
		}

		// Token: 0x0601B5C1 RID: 112065 RVA: 0x003FA8DA File Offset: 0x003F8ADA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDefencePlayerReviveNotify()
		{
		}

		// Token: 0x0601B5C2 RID: 112066 RVA: 0x003FA8E2 File Offset: 0x003F8AE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDefencePlayerReviveNotify(TowerDefencePlayerReviveNotify other) : this()
		{
			this.playerId_ = other.playerId_;
			this.reviveTime_ = other.reviveTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B5C3 RID: 112067 RVA: 0x003FA913 File Offset: 0x003F8B13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDefencePlayerReviveNotify Clone()
		{
			return new TowerDefencePlayerReviveNotify(this);
		}

		// Token: 0x17005CA1 RID: 23713
		// (get) Token: 0x0601B5C4 RID: 112068 RVA: 0x003FA91B File Offset: 0x003F8B1B
		// (set) Token: 0x0601B5C5 RID: 112069 RVA: 0x003FA923 File Offset: 0x003F8B23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PlayerId
		{
			get
			{
				return this.playerId_;
			}
			set
			{
				this.playerId_ = value;
			}
		}

		// Token: 0x17005CA2 RID: 23714
		// (get) Token: 0x0601B5C6 RID: 112070 RVA: 0x003FA92C File Offset: 0x003F8B2C
		// (set) Token: 0x0601B5C7 RID: 112071 RVA: 0x003FA934 File Offset: 0x003F8B34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long ReviveTime
		{
			get
			{
				return this.reviveTime_;
			}
			set
			{
				this.reviveTime_ = value;
			}
		}

		// Token: 0x0601B5C8 RID: 112072 RVA: 0x003FA93D File Offset: 0x003F8B3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TowerDefencePlayerReviveNotify);
		}

		// Token: 0x0601B5C9 RID: 112073 RVA: 0x003FA94B File Offset: 0x003F8B4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TowerDefencePlayerReviveNotify other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && this.ReviveTime == other.ReviveTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B5CA RID: 112074 RVA: 0x003FA98C File Offset: 0x003F8B8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PlayerId != 0)
			{
				num ^= this.PlayerId.GetHashCode();
			}
			if (this.ReviveTime != 0L)
			{
				num ^= this.ReviveTime.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601B5CB RID: 112075 RVA: 0x003FA9E4 File Offset: 0x003F8BE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B5CC RID: 112076 RVA: 0x003FA9F1 File Offset: 0x003F8BF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B5CD RID: 112077 RVA: 0x003FA9FC File Offset: 0x003F8BFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ReviveTime != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.ReviveTime);
			}
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.PlayerId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B5CE RID: 112078 RVA: 0x003FAA58 File Offset: 0x003F8C58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PlayerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerId);
			}
			if (this.ReviveTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.ReviveTime);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601B5CF RID: 112079 RVA: 0x003FAAB0 File Offset: 0x003F8CB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TowerDefencePlayerReviveNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PlayerId != 0)
			{
				this.PlayerId = other.PlayerId;
			}
			if (other.ReviveTime != 0L)
			{
				this.ReviveTime = other.ReviveTime;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B5D0 RID: 112080 RVA: 0x003FAB00 File Offset: 0x003F8D00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B5D1 RID: 112081 RVA: 0x003FAB0C File Offset: 0x003F8D0C
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
					if (num != 96U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.PlayerId = input.ReadInt32();
					}
				}
				else
				{
					this.ReviveTime = input.ReadInt64();
				}
			}
		}

		// Token: 0x04009F5D RID: 40797
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009F5E RID: 40798
		public const int PlayerIdFieldNumber = 12;

		// Token: 0x04009F5F RID: 40799
		private int playerId_;

		// Token: 0x04009F60 RID: 40800
		public const int ReviveTimeFieldNumber = 2;

		// Token: 0x04009F61 RID: 40801
		private long reviveTime_;
	}
}
