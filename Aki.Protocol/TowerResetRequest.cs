using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001439 RID: 5177
	[NetMessage(EMessageId.TowerResetRequest)]
	public sealed class TowerResetRequest : IMessage<TowerResetRequest>, IMessage, IEquatable<TowerResetRequest>, IDeepCloneable<TowerResetRequest>, IBufferMessage
	{
		// Token: 0x0601B826 RID: 112678 RVA: 0x003FFB22 File Offset: 0x003FDD22
		[NullableContext(1)]
		public static TowerResetRequest Create()
		{
			return new TowerResetRequest();
		}

		// Token: 0x17005D23 RID: 23843
		// (get) Token: 0x0601B827 RID: 112679 RVA: 0x003FFB29 File Offset: 0x003FDD29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005D24 RID: 23844
		// (get) Token: 0x0601B828 RID: 112680 RVA: 0x003FFB2C File Offset: 0x003FDD2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TowerResetRequest.Descriptor;
			}
		}

		// Token: 0x0601B829 RID: 112681 RVA: 0x003FFB33 File Offset: 0x003FDD33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerResetRequest()
		{
		}

		// Token: 0x0601B82A RID: 112682 RVA: 0x003FFB3B File Offset: 0x003FDD3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerResetRequest(TowerResetRequest other) : this()
		{
			this.towerConfigId_ = other.towerConfigId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B82B RID: 112683 RVA: 0x003FFB60 File Offset: 0x003FDD60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerResetRequest Clone()
		{
			return new TowerResetRequest(this);
		}

		// Token: 0x17005D25 RID: 23845
		// (get) Token: 0x0601B82C RID: 112684 RVA: 0x003FFB68 File Offset: 0x003FDD68
		// (set) Token: 0x0601B82D RID: 112685 RVA: 0x003FFB70 File Offset: 0x003FDD70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TowerConfigId
		{
			get
			{
				return this.towerConfigId_;
			}
			set
			{
				this.towerConfigId_ = value;
			}
		}

		// Token: 0x0601B82E RID: 112686 RVA: 0x003FFB79 File Offset: 0x003FDD79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TowerResetRequest);
		}

		// Token: 0x0601B82F RID: 112687 RVA: 0x003FFB87 File Offset: 0x003FDD87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TowerResetRequest other)
		{
			return other != null && (other == this || (this.TowerConfigId == other.TowerConfigId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B830 RID: 112688 RVA: 0x003FFBB8 File Offset: 0x003FDDB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TowerConfigId != 0)
			{
				num ^= this.TowerConfigId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601B831 RID: 112689 RVA: 0x003FFBF7 File Offset: 0x003FDDF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B832 RID: 112690 RVA: 0x003FFC04 File Offset: 0x003FDE04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B833 RID: 112691 RVA: 0x003FFC0D File Offset: 0x003FDE0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TowerConfigId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.TowerConfigId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B834 RID: 112692 RVA: 0x003FFC40 File Offset: 0x003FDE40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TowerConfigId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TowerConfigId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601B835 RID: 112693 RVA: 0x003FFC7E File Offset: 0x003FDE7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TowerResetRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TowerConfigId != 0)
			{
				this.TowerConfigId = other.TowerConfigId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B836 RID: 112694 RVA: 0x003FFCAF File Offset: 0x003FDEAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B837 RID: 112695 RVA: 0x003FFCB8 File Offset: 0x003FDEB8
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
				if (num != 88U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.TowerConfigId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400A014 RID: 40980
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A015 RID: 40981
		public const int TowerConfigIdFieldNumber = 11;

		// Token: 0x0400A016 RID: 40982
		private int towerConfigId_;
	}
}
