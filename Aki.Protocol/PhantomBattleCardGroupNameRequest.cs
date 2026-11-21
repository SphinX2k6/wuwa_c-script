using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C3D RID: 3133
	[NetMessage(EMessageId.PhantomBattleCardGroupNameRequest)]
	public sealed class PhantomBattleCardGroupNameRequest : IMessage<PhantomBattleCardGroupNameRequest>, IMessage, IEquatable<PhantomBattleCardGroupNameRequest>, IDeepCloneable<PhantomBattleCardGroupNameRequest>, IBufferMessage
	{
		// Token: 0x06011040 RID: 69696 RVA: 0x0027E80D File Offset: 0x0027CA0D
		[NullableContext(1)]
		public static PhantomBattleCardGroupNameRequest Create()
		{
			return new PhantomBattleCardGroupNameRequest();
		}

		// Token: 0x1700383D RID: 14397
		// (get) Token: 0x06011041 RID: 69697 RVA: 0x0027E814 File Offset: 0x0027CA14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700383E RID: 14398
		// (get) Token: 0x06011042 RID: 69698 RVA: 0x0027E817 File Offset: 0x0027CA17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleCardGroupNameRequest.Descriptor;
			}
		}

		// Token: 0x06011043 RID: 69699 RVA: 0x0027E81E File Offset: 0x0027CA1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardGroupNameRequest()
		{
		}

		// Token: 0x06011044 RID: 69700 RVA: 0x0027E831 File Offset: 0x0027CA31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardGroupNameRequest(PhantomBattleCardGroupNameRequest other) : this()
		{
			this.name_ = other.name_;
			this.index_ = other.index_;
			this.activityId_ = other.activityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011045 RID: 69701 RVA: 0x0027E86E File Offset: 0x0027CA6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardGroupNameRequest Clone()
		{
			return new PhantomBattleCardGroupNameRequest(this);
		}

		// Token: 0x1700383F RID: 14399
		// (get) Token: 0x06011046 RID: 69702 RVA: 0x0027E876 File Offset: 0x0027CA76
		// (set) Token: 0x06011047 RID: 69703 RVA: 0x0027E87E File Offset: 0x0027CA7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Name
		{
			get
			{
				return this.name_;
			}
			set
			{
				this.name_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17003840 RID: 14400
		// (get) Token: 0x06011048 RID: 69704 RVA: 0x0027E891 File Offset: 0x0027CA91
		// (set) Token: 0x06011049 RID: 69705 RVA: 0x0027E899 File Offset: 0x0027CA99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Index
		{
			get
			{
				return this.index_;
			}
			set
			{
				this.index_ = value;
			}
		}

		// Token: 0x17003841 RID: 14401
		// (get) Token: 0x0601104A RID: 69706 RVA: 0x0027E8A2 File Offset: 0x0027CAA2
		// (set) Token: 0x0601104B RID: 69707 RVA: 0x0027E8AA File Offset: 0x0027CAAA
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

		// Token: 0x0601104C RID: 69708 RVA: 0x0027E8B3 File Offset: 0x0027CAB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleCardGroupNameRequest);
		}

		// Token: 0x0601104D RID: 69709 RVA: 0x0027E8C4 File Offset: 0x0027CAC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleCardGroupNameRequest other)
		{
			return other != null && (other == this || (!(this.Name != other.Name) && this.Index == other.Index && this.ActivityId == other.ActivityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601104E RID: 69710 RVA: 0x0027E924 File Offset: 0x0027CB24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Name.Length != 0)
			{
				num ^= this.Name.GetHashCode();
			}
			if (this.Index != 0)
			{
				num ^= this.Index.GetHashCode();
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

		// Token: 0x0601104F RID: 69711 RVA: 0x0027E997 File Offset: 0x0027CB97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011050 RID: 69712 RVA: 0x0027E9A4 File Offset: 0x0027CBA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011051 RID: 69713 RVA: 0x0027E9B0 File Offset: 0x0027CBB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.ActivityId);
			}
			if (this.Index != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.Index);
			}
			if (this.Name.Length != 0)
			{
				output.WriteRawTag(90);
				output.WriteString(this.Name);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011052 RID: 69714 RVA: 0x0027EA2C File Offset: 0x0027CC2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Name.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Name);
			}
			if (this.Index != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Index);
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

		// Token: 0x06011053 RID: 69715 RVA: 0x0027EAA0 File Offset: 0x0027CCA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleCardGroupNameRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Name.Length != 0)
			{
				this.Name = other.Name;
			}
			if (other.Index != 0)
			{
				this.Index = other.Index;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06011054 RID: 69716 RVA: 0x0027EB09 File Offset: 0x0027CD09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011055 RID: 69717 RVA: 0x0027EB14 File Offset: 0x0027CD14
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
					if (num != 56U)
					{
						if (num != 90U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Name = input.ReadString();
						}
					}
					else
					{
						this.Index = input.ReadInt32();
					}
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04006C4E RID: 27726
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006C4F RID: 27727
		public const int NameFieldNumber = 11;

		// Token: 0x04006C50 RID: 27728
		private string name_ = "";

		// Token: 0x04006C51 RID: 27729
		public const int IndexFieldNumber = 7;

		// Token: 0x04006C52 RID: 27730
		private int index_;

		// Token: 0x04006C53 RID: 27731
		public const int ActivityIdFieldNumber = 3;

		// Token: 0x04006C54 RID: 27732
		private int activityId_;
	}
}
