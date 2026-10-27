using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C4D RID: 3149
	[NetMessage(EMessageId.PhantomBattleCardGroupNameRequest)]
	public sealed class PhantomBattleCardGroupNameRequest : IMessage<PhantomBattleCardGroupNameRequest>, IMessage, IEquatable<PhantomBattleCardGroupNameRequest>, IDeepCloneable<PhantomBattleCardGroupNameRequest>, IBufferMessage
	{
		// Token: 0x06011140 RID: 69952 RVA: 0x00280575 File Offset: 0x0027E775
		[NullableContext(1)]
		public static PhantomBattleCardGroupNameRequest Create()
		{
			return new PhantomBattleCardGroupNameRequest();
		}

		// Token: 0x17003874 RID: 14452
		// (get) Token: 0x06011141 RID: 69953 RVA: 0x0028057C File Offset: 0x0027E77C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003875 RID: 14453
		// (get) Token: 0x06011142 RID: 69954 RVA: 0x0028057F File Offset: 0x0027E77F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleCardGroupNameRequest.Descriptor;
			}
		}

		// Token: 0x06011143 RID: 69955 RVA: 0x00280586 File Offset: 0x0027E786
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardGroupNameRequest()
		{
		}

		// Token: 0x06011144 RID: 69956 RVA: 0x00280599 File Offset: 0x0027E799
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardGroupNameRequest(PhantomBattleCardGroupNameRequest other) : this()
		{
			this.name_ = other.name_;
			this.index_ = other.index_;
			this.activityId_ = other.activityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011145 RID: 69957 RVA: 0x002805D6 File Offset: 0x0027E7D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardGroupNameRequest Clone()
		{
			return new PhantomBattleCardGroupNameRequest(this);
		}

		// Token: 0x17003876 RID: 14454
		// (get) Token: 0x06011146 RID: 69958 RVA: 0x002805DE File Offset: 0x0027E7DE
		// (set) Token: 0x06011147 RID: 69959 RVA: 0x002805E6 File Offset: 0x0027E7E6
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

		// Token: 0x17003877 RID: 14455
		// (get) Token: 0x06011148 RID: 69960 RVA: 0x002805F9 File Offset: 0x0027E7F9
		// (set) Token: 0x06011149 RID: 69961 RVA: 0x00280601 File Offset: 0x0027E801
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

		// Token: 0x17003878 RID: 14456
		// (get) Token: 0x0601114A RID: 69962 RVA: 0x0028060A File Offset: 0x0027E80A
		// (set) Token: 0x0601114B RID: 69963 RVA: 0x00280612 File Offset: 0x0027E812
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

		// Token: 0x0601114C RID: 69964 RVA: 0x0028061B File Offset: 0x0027E81B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleCardGroupNameRequest);
		}

		// Token: 0x0601114D RID: 69965 RVA: 0x0028062C File Offset: 0x0027E82C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleCardGroupNameRequest other)
		{
			return other != null && (other == this || (!(this.Name != other.Name) && this.Index == other.Index && this.ActivityId == other.ActivityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601114E RID: 69966 RVA: 0x0028068C File Offset: 0x0027E88C
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

		// Token: 0x0601114F RID: 69967 RVA: 0x002806FF File Offset: 0x0027E8FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011150 RID: 69968 RVA: 0x0028070C File Offset: 0x0027E90C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011151 RID: 69969 RVA: 0x00280718 File Offset: 0x0027E918
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
				output.WriteRawTag(74);
				output.WriteString(this.Name);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011152 RID: 69970 RVA: 0x00280794 File Offset: 0x0027E994
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

		// Token: 0x06011153 RID: 69971 RVA: 0x00280808 File Offset: 0x0027EA08
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

		// Token: 0x06011154 RID: 69972 RVA: 0x00280871 File Offset: 0x0027EA71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011155 RID: 69973 RVA: 0x0028087C File Offset: 0x0027EA7C
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
						if (num != 74U)
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

		// Token: 0x04006C3A RID: 27706
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006C3B RID: 27707
		public const int NameFieldNumber = 9;

		// Token: 0x04006C3C RID: 27708
		private string name_ = "";

		// Token: 0x04006C3D RID: 27709
		public const int IndexFieldNumber = 7;

		// Token: 0x04006C3E RID: 27710
		private int index_;

		// Token: 0x04006C3F RID: 27711
		public const int ActivityIdFieldNumber = 3;

		// Token: 0x04006C40 RID: 27712
		private int activityId_;
	}
}
