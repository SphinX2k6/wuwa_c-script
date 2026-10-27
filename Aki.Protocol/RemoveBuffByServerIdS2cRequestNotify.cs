using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000EF2 RID: 3826
	[NetMessage(EMessageId.RemoveBuffByServerIdS2cRequestNotify)]
	public sealed class RemoveBuffByServerIdS2cRequestNotify : IMessage<RemoveBuffByServerIdS2cRequestNotify>, IMessage, IEquatable<RemoveBuffByServerIdS2cRequestNotify>, IDeepCloneable<RemoveBuffByServerIdS2cRequestNotify>, IBufferMessage
	{
		// Token: 0x06014804 RID: 83972 RVA: 0x002FA8F1 File Offset: 0x002F8AF1
		[NullableContext(1)]
		public static RemoveBuffByServerIdS2cRequestNotify Create()
		{
			return new RemoveBuffByServerIdS2cRequestNotify();
		}

		// Token: 0x1700442D RID: 17453
		// (get) Token: 0x06014805 RID: 83973 RVA: 0x002FA8F8 File Offset: 0x002F8AF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700442E RID: 17454
		// (get) Token: 0x06014806 RID: 83974 RVA: 0x002FA8FB File Offset: 0x002F8AFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RemoveBuffByServerIdS2cRequestNotify.Descriptor;
			}
		}

		// Token: 0x06014807 RID: 83975 RVA: 0x002FA902 File Offset: 0x002F8B02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveBuffByServerIdS2cRequestNotify()
		{
		}

		// Token: 0x06014808 RID: 83976 RVA: 0x002FA90C File Offset: 0x002F8B0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveBuffByServerIdS2cRequestNotify(RemoveBuffByServerIdS2cRequestNotify other) : this()
		{
			this.serverId_ = other.serverId_;
			this.stackCount_ = other.stackCount_;
			this.reason_ = other.reason_;
			this.instigatorId_ = other.instigatorId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014809 RID: 83977 RVA: 0x002FA960 File Offset: 0x002F8B60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveBuffByServerIdS2cRequestNotify Clone()
		{
			return new RemoveBuffByServerIdS2cRequestNotify(this);
		}

		// Token: 0x1700442F RID: 17455
		// (get) Token: 0x0601480A RID: 83978 RVA: 0x002FA968 File Offset: 0x002F8B68
		// (set) Token: 0x0601480B RID: 83979 RVA: 0x002FA970 File Offset: 0x002F8B70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ServerId
		{
			get
			{
				return this.serverId_;
			}
			set
			{
				this.serverId_ = value;
			}
		}

		// Token: 0x17004430 RID: 17456
		// (get) Token: 0x0601480C RID: 83980 RVA: 0x002FA979 File Offset: 0x002F8B79
		// (set) Token: 0x0601480D RID: 83981 RVA: 0x002FA981 File Offset: 0x002F8B81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int StackCount
		{
			get
			{
				return this.stackCount_;
			}
			set
			{
				this.stackCount_ = value;
			}
		}

		// Token: 0x17004431 RID: 17457
		// (get) Token: 0x0601480E RID: 83982 RVA: 0x002FA98A File Offset: 0x002F8B8A
		// (set) Token: 0x0601480F RID: 83983 RVA: 0x002FA992 File Offset: 0x002F8B92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Reason
		{
			get
			{
				return this.reason_;
			}
			set
			{
				this.reason_ = value;
			}
		}

		// Token: 0x17004432 RID: 17458
		// (get) Token: 0x06014810 RID: 83984 RVA: 0x002FA99B File Offset: 0x002F8B9B
		// (set) Token: 0x06014811 RID: 83985 RVA: 0x002FA9A3 File Offset: 0x002F8BA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long InstigatorId
		{
			get
			{
				return this.instigatorId_;
			}
			set
			{
				this.instigatorId_ = value;
			}
		}

		// Token: 0x06014812 RID: 83986 RVA: 0x002FA9AC File Offset: 0x002F8BAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RemoveBuffByServerIdS2cRequestNotify);
		}

		// Token: 0x06014813 RID: 83987 RVA: 0x002FA9BC File Offset: 0x002F8BBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RemoveBuffByServerIdS2cRequestNotify other)
		{
			return other != null && (other == this || (this.ServerId == other.ServerId && this.StackCount == other.StackCount && this.Reason == other.Reason && this.InstigatorId == other.InstigatorId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014814 RID: 83988 RVA: 0x002FAA28 File Offset: 0x002F8C28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ServerId != 0)
			{
				num ^= this.ServerId.GetHashCode();
			}
			if (this.StackCount != 0)
			{
				num ^= this.StackCount.GetHashCode();
			}
			if (this.Reason != 0)
			{
				num ^= this.Reason.GetHashCode();
			}
			if (this.InstigatorId != 0L)
			{
				num ^= this.InstigatorId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06014815 RID: 83989 RVA: 0x002FAAB2 File Offset: 0x002F8CB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014816 RID: 83990 RVA: 0x002FAABF File Offset: 0x002F8CBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014817 RID: 83991 RVA: 0x002FAAC8 File Offset: 0x002F8CC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ServerId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.ServerId);
			}
			if (this.Reason != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.Reason);
			}
			if (this.StackCount != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.StackCount);
			}
			if (this.InstigatorId != 0L)
			{
				output.WriteRawTag(112);
				output.WriteInt64(this.InstigatorId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014818 RID: 83992 RVA: 0x002FAB5C File Offset: 0x002F8D5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ServerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ServerId);
			}
			if (this.StackCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.StackCount);
			}
			if (this.Reason != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Reason);
			}
			if (this.InstigatorId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.InstigatorId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06014819 RID: 83993 RVA: 0x002FABE4 File Offset: 0x002F8DE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RemoveBuffByServerIdS2cRequestNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ServerId != 0)
			{
				this.ServerId = other.ServerId;
			}
			if (other.StackCount != 0)
			{
				this.StackCount = other.StackCount;
			}
			if (other.Reason != 0)
			{
				this.Reason = other.Reason;
			}
			if (other.InstigatorId != 0L)
			{
				this.InstigatorId = other.InstigatorId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601481A RID: 83994 RVA: 0x002FAC5C File Offset: 0x002F8E5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601481B RID: 83995 RVA: 0x002FAC68 File Offset: 0x002F8E68
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
				if (num <= 80U)
				{
					if (num == 56U)
					{
						this.ServerId = input.ReadInt32();
						continue;
					}
					if (num == 80U)
					{
						this.Reason = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 104U)
					{
						this.StackCount = input.ReadInt32();
						continue;
					}
					if (num == 112U)
					{
						this.InstigatorId = input.ReadInt64();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04007C50 RID: 31824
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007C51 RID: 31825
		public const int ServerIdFieldNumber = 7;

		// Token: 0x04007C52 RID: 31826
		private int serverId_;

		// Token: 0x04007C53 RID: 31827
		public const int StackCountFieldNumber = 13;

		// Token: 0x04007C54 RID: 31828
		private int stackCount_;

		// Token: 0x04007C55 RID: 31829
		public const int ReasonFieldNumber = 10;

		// Token: 0x04007C56 RID: 31830
		private int reason_;

		// Token: 0x04007C57 RID: 31831
		public const int InstigatorIdFieldNumber = 14;

		// Token: 0x04007C58 RID: 31832
		private long instigatorId_;
	}
}
