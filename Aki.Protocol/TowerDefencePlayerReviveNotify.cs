using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013A8 RID: 5032
	[NetMessage(EMessageId.TowerDefencePlayerReviveNotify)]
	public sealed class TowerDefencePlayerReviveNotify : IMessage<TowerDefencePlayerReviveNotify>, IMessage, IEquatable<TowerDefencePlayerReviveNotify>, IDeepCloneable<TowerDefencePlayerReviveNotify>, IBufferMessage
	{
		// Token: 0x0601AB33 RID: 109363 RVA: 0x003DF609 File Offset: 0x003DD809
		[NullableContext(1)]
		public static TowerDefencePlayerReviveNotify Create()
		{
			return new TowerDefencePlayerReviveNotify();
		}

		// Token: 0x17005A0A RID: 23050
		// (get) Token: 0x0601AB34 RID: 109364 RVA: 0x003DF610 File Offset: 0x003DD810
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005A0B RID: 23051
		// (get) Token: 0x0601AB35 RID: 109365 RVA: 0x003DF613 File Offset: 0x003DD813
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TowerDefencePlayerReviveNotify.Descriptor;
			}
		}

		// Token: 0x0601AB36 RID: 109366 RVA: 0x003DF61A File Offset: 0x003DD81A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDefencePlayerReviveNotify()
		{
		}

		// Token: 0x0601AB37 RID: 109367 RVA: 0x003DF622 File Offset: 0x003DD822
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDefencePlayerReviveNotify(TowerDefencePlayerReviveNotify other) : this()
		{
			this.playerId_ = other.playerId_;
			this.reviveTime_ = other.reviveTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601AB38 RID: 109368 RVA: 0x003DF653 File Offset: 0x003DD853
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDefencePlayerReviveNotify Clone()
		{
			return new TowerDefencePlayerReviveNotify(this);
		}

		// Token: 0x17005A0C RID: 23052
		// (get) Token: 0x0601AB39 RID: 109369 RVA: 0x003DF65B File Offset: 0x003DD85B
		// (set) Token: 0x0601AB3A RID: 109370 RVA: 0x003DF663 File Offset: 0x003DD863
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

		// Token: 0x17005A0D RID: 23053
		// (get) Token: 0x0601AB3B RID: 109371 RVA: 0x003DF66C File Offset: 0x003DD86C
		// (set) Token: 0x0601AB3C RID: 109372 RVA: 0x003DF674 File Offset: 0x003DD874
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

		// Token: 0x0601AB3D RID: 109373 RVA: 0x003DF67D File Offset: 0x003DD87D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TowerDefencePlayerReviveNotify);
		}

		// Token: 0x0601AB3E RID: 109374 RVA: 0x003DF68B File Offset: 0x003DD88B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TowerDefencePlayerReviveNotify other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && this.ReviveTime == other.ReviveTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601AB3F RID: 109375 RVA: 0x003DF6CC File Offset: 0x003DD8CC
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

		// Token: 0x0601AB40 RID: 109376 RVA: 0x003DF724 File Offset: 0x003DD924
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601AB41 RID: 109377 RVA: 0x003DF731 File Offset: 0x003DD931
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601AB42 RID: 109378 RVA: 0x003DF73C File Offset: 0x003DD93C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.PlayerId);
			}
			if (this.ReviveTime != 0L)
			{
				output.WriteRawTag(88);
				output.WriteInt64(this.ReviveTime);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601AB43 RID: 109379 RVA: 0x003DF798 File Offset: 0x003DD998
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

		// Token: 0x0601AB44 RID: 109380 RVA: 0x003DF7F0 File Offset: 0x003DD9F0
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

		// Token: 0x0601AB45 RID: 109381 RVA: 0x003DF840 File Offset: 0x003DDA40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601AB46 RID: 109382 RVA: 0x003DF84C File Offset: 0x003DDA4C
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
				if (num != 56U)
				{
					if (num != 88U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ReviveTime = input.ReadInt64();
					}
				}
				else
				{
					this.PlayerId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04009B16 RID: 39702
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009B17 RID: 39703
		public const int PlayerIdFieldNumber = 7;

		// Token: 0x04009B18 RID: 39704
		private int playerId_;

		// Token: 0x04009B19 RID: 39705
		public const int ReviveTimeFieldNumber = 11;

		// Token: 0x04009B1A RID: 39706
		private long reviveTime_;
	}
}
