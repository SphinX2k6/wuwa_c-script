using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000440 RID: 1088
	[NetMessage(EMessageId.EnterLevelPlayNotify)]
	public sealed class EnterLevelPlayNotify : IMessage<EnterLevelPlayNotify>, IMessage, IEquatable<EnterLevelPlayNotify>, IDeepCloneable<EnterLevelPlayNotify>, IBufferMessage
	{
		// Token: 0x060068BA RID: 26810 RVA: 0x000FDB31 File Offset: 0x000FBD31
		[NullableContext(1)]
		public static EnterLevelPlayNotify Create()
		{
			return new EnterLevelPlayNotify();
		}

		// Token: 0x170013CD RID: 5069
		// (get) Token: 0x060068BB RID: 26811 RVA: 0x000FDB38 File Offset: 0x000FBD38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170013CE RID: 5070
		// (get) Token: 0x060068BC RID: 26812 RVA: 0x000FDB3B File Offset: 0x000FBD3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EnterLevelPlayNotify.Descriptor;
			}
		}

		// Token: 0x060068BD RID: 26813 RVA: 0x000FDB42 File Offset: 0x000FBD42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterLevelPlayNotify()
		{
		}

		// Token: 0x060068BE RID: 26814 RVA: 0x000FDB4A File Offset: 0x000FBD4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterLevelPlayNotify(EnterLevelPlayNotify other) : this()
		{
			this.id_ = other.id_;
			this.canGetReward_ = other.canGetReward_;
			this.state_ = other.state_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060068BF RID: 26815 RVA: 0x000FDB87 File Offset: 0x000FBD87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterLevelPlayNotify Clone()
		{
			return new EnterLevelPlayNotify(this);
		}

		// Token: 0x170013CF RID: 5071
		// (get) Token: 0x060068C0 RID: 26816 RVA: 0x000FDB8F File Offset: 0x000FBD8F
		// (set) Token: 0x060068C1 RID: 26817 RVA: 0x000FDB97 File Offset: 0x000FBD97
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

		// Token: 0x170013D0 RID: 5072
		// (get) Token: 0x060068C2 RID: 26818 RVA: 0x000FDBA0 File Offset: 0x000FBDA0
		// (set) Token: 0x060068C3 RID: 26819 RVA: 0x000FDBA8 File Offset: 0x000FBDA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool CanGetReward
		{
			get
			{
				return this.canGetReward_;
			}
			set
			{
				this.canGetReward_ = value;
			}
		}

		// Token: 0x170013D1 RID: 5073
		// (get) Token: 0x060068C4 RID: 26820 RVA: 0x000FDBB1 File Offset: 0x000FBDB1
		// (set) Token: 0x060068C5 RID: 26821 RVA: 0x000FDBB9 File Offset: 0x000FBDB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int State
		{
			get
			{
				return this.state_;
			}
			set
			{
				this.state_ = value;
			}
		}

		// Token: 0x060068C6 RID: 26822 RVA: 0x000FDBC2 File Offset: 0x000FBDC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EnterLevelPlayNotify);
		}

		// Token: 0x060068C7 RID: 26823 RVA: 0x000FDBD0 File Offset: 0x000FBDD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EnterLevelPlayNotify other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.CanGetReward == other.CanGetReward && this.State == other.State && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060068C8 RID: 26824 RVA: 0x000FDC2C File Offset: 0x000FBE2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.CanGetReward)
			{
				num ^= this.CanGetReward.GetHashCode();
			}
			if (this.State != 0)
			{
				num ^= this.State.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060068C9 RID: 26825 RVA: 0x000FDC9D File Offset: 0x000FBE9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060068CA RID: 26826 RVA: 0x000FDCAA File Offset: 0x000FBEAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060068CB RID: 26827 RVA: 0x000FDCB4 File Offset: 0x000FBEB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CanGetReward)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.CanGetReward);
			}
			if (this.State != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.State);
			}
			if (this.Id != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060068CC RID: 26828 RVA: 0x000FDD2C File Offset: 0x000FBF2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.CanGetReward)
			{
				num += 2;
			}
			if (this.State != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.State);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060068CD RID: 26829 RVA: 0x000FDD90 File Offset: 0x000FBF90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EnterLevelPlayNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.CanGetReward)
			{
				this.CanGetReward = other.CanGetReward;
			}
			if (other.State != 0)
			{
				this.State = other.State;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060068CE RID: 26830 RVA: 0x000FDDF4 File Offset: 0x000FBFF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060068CF RID: 26831 RVA: 0x000FDE00 File Offset: 0x000FC000
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
						if (num != 48U)
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
						this.State = input.ReadInt32();
					}
				}
				else
				{
					this.CanGetReward = input.ReadBool();
				}
			}
		}

		// Token: 0x04003A35 RID: 14901
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003A36 RID: 14902
		public const int IdFieldNumber = 6;

		// Token: 0x04003A37 RID: 14903
		private int id_;

		// Token: 0x04003A38 RID: 14904
		public const int CanGetRewardFieldNumber = 2;

		// Token: 0x04003A39 RID: 14905
		private bool canGetReward_;

		// Token: 0x04003A3A RID: 14906
		public const int StateFieldNumber = 4;

		// Token: 0x04003A3B RID: 14907
		private int state_;
	}
}
