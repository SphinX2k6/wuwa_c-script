using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000815 RID: 2069
	[NetMessage(EMessageId.InstResultNotify)]
	public sealed class InstResultNotify : IMessage<InstResultNotify>, IMessage, IEquatable<InstResultNotify>, IDeepCloneable<InstResultNotify>, IBufferMessage
	{
		// Token: 0x0600B953 RID: 47443 RVA: 0x001B9CB1 File Offset: 0x001B7EB1
		[NullableContext(1)]
		public static InstResultNotify Create()
		{
			return new InstResultNotify();
		}

		// Token: 0x1700255E RID: 9566
		// (get) Token: 0x0600B954 RID: 47444 RVA: 0x001B9CB8 File Offset: 0x001B7EB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700255F RID: 9567
		// (get) Token: 0x0600B955 RID: 47445 RVA: 0x001B9CBB File Offset: 0x001B7EBB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InstResultNotify.Descriptor;
			}
		}

		// Token: 0x0600B956 RID: 47446 RVA: 0x001B9CC2 File Offset: 0x001B7EC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InstResultNotify()
		{
		}

		// Token: 0x0600B957 RID: 47447 RVA: 0x001B9CCC File Offset: 0x001B7ECC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InstResultNotify(InstResultNotify other) : this()
		{
			this.id_ = other.id_;
			this.succ_ = other.succ_;
			this.reason_ = other.reason_;
			this.isRecReward_ = other.isRecReward_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B958 RID: 47448 RVA: 0x001B9D20 File Offset: 0x001B7F20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InstResultNotify Clone()
		{
			return new InstResultNotify(this);
		}

		// Token: 0x17002560 RID: 9568
		// (get) Token: 0x0600B959 RID: 47449 RVA: 0x001B9D28 File Offset: 0x001B7F28
		// (set) Token: 0x0600B95A RID: 47450 RVA: 0x001B9D30 File Offset: 0x001B7F30
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

		// Token: 0x17002561 RID: 9569
		// (get) Token: 0x0600B95B RID: 47451 RVA: 0x001B9D39 File Offset: 0x001B7F39
		// (set) Token: 0x0600B95C RID: 47452 RVA: 0x001B9D41 File Offset: 0x001B7F41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Succ
		{
			get
			{
				return this.succ_;
			}
			set
			{
				this.succ_ = value;
			}
		}

		// Token: 0x17002562 RID: 9570
		// (get) Token: 0x0600B95D RID: 47453 RVA: 0x001B9D4A File Offset: 0x001B7F4A
		// (set) Token: 0x0600B95E RID: 47454 RVA: 0x001B9D52 File Offset: 0x001B7F52
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

		// Token: 0x17002563 RID: 9571
		// (get) Token: 0x0600B95F RID: 47455 RVA: 0x001B9D5B File Offset: 0x001B7F5B
		// (set) Token: 0x0600B960 RID: 47456 RVA: 0x001B9D63 File Offset: 0x001B7F63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsRecReward
		{
			get
			{
				return this.isRecReward_;
			}
			set
			{
				this.isRecReward_ = value;
			}
		}

		// Token: 0x0600B961 RID: 47457 RVA: 0x001B9D6C File Offset: 0x001B7F6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InstResultNotify);
		}

		// Token: 0x0600B962 RID: 47458 RVA: 0x001B9D7C File Offset: 0x001B7F7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InstResultNotify other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.Succ == other.Succ && this.Reason == other.Reason && this.IsRecReward == other.IsRecReward && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B963 RID: 47459 RVA: 0x001B9DE8 File Offset: 0x001B7FE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.Succ)
			{
				num ^= this.Succ.GetHashCode();
			}
			if (this.Reason != 0)
			{
				num ^= this.Reason.GetHashCode();
			}
			if (this.IsRecReward)
			{
				num ^= this.IsRecReward.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B964 RID: 47460 RVA: 0x001B9E72 File Offset: 0x001B8072
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B965 RID: 47461 RVA: 0x001B9E7F File Offset: 0x001B807F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B966 RID: 47462 RVA: 0x001B9E88 File Offset: 0x001B8088
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Reason != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.Reason);
			}
			if (this.Succ)
			{
				output.WriteRawTag(64);
				output.WriteBool(this.Succ);
			}
			if (this.IsRecReward)
			{
				output.WriteRawTag(72);
				output.WriteBool(this.IsRecReward);
			}
			if (this.Id != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B967 RID: 47463 RVA: 0x001B9F1C File Offset: 0x001B811C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.Succ)
			{
				num += 2;
			}
			if (this.Reason != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Reason);
			}
			if (this.IsRecReward)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B968 RID: 47464 RVA: 0x001B9F8C File Offset: 0x001B818C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InstResultNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.Succ)
			{
				this.Succ = other.Succ;
			}
			if (other.Reason != 0)
			{
				this.Reason = other.Reason;
			}
			if (other.IsRecReward)
			{
				this.IsRecReward = other.IsRecReward;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B969 RID: 47465 RVA: 0x001BA004 File Offset: 0x001B8204
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B96A RID: 47466 RVA: 0x001BA010 File Offset: 0x001B8210
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
				if (num <= 64U)
				{
					if (num == 40U)
					{
						this.Reason = input.ReadInt32();
						continue;
					}
					if (num == 64U)
					{
						this.Succ = input.ReadBool();
						continue;
					}
				}
				else
				{
					if (num == 72U)
					{
						this.IsRecReward = input.ReadBool();
						continue;
					}
					if (num == 112U)
					{
						this.Id = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040051ED RID: 20973
		private UnknownFieldSet _unknownFields;

		// Token: 0x040051EE RID: 20974
		public const int IdFieldNumber = 14;

		// Token: 0x040051EF RID: 20975
		private int id_;

		// Token: 0x040051F0 RID: 20976
		public const int SuccFieldNumber = 8;

		// Token: 0x040051F1 RID: 20977
		private bool succ_;

		// Token: 0x040051F2 RID: 20978
		public const int ReasonFieldNumber = 5;

		// Token: 0x040051F3 RID: 20979
		private int reason_;

		// Token: 0x040051F4 RID: 20980
		public const int IsRecRewardFieldNumber = 9;

		// Token: 0x040051F5 RID: 20981
		private bool isRecReward_;
	}
}
