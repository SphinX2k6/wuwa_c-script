using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200138E RID: 5006
	[NetMessage(EMessageId.TotalTopUpRewardRequest)]
	public sealed class TotalTopUpRewardRequest : IMessage<TotalTopUpRewardRequest>, IMessage, IEquatable<TotalTopUpRewardRequest>, IDeepCloneable<TotalTopUpRewardRequest>, IBufferMessage
	{
		// Token: 0x0601A912 RID: 108818 RVA: 0x003DAC59 File Offset: 0x003D8E59
		[NullableContext(1)]
		public static TotalTopUpRewardRequest Create()
		{
			return new TotalTopUpRewardRequest();
		}

		// Token: 0x17005994 RID: 22932
		// (get) Token: 0x0601A913 RID: 108819 RVA: 0x003DAC60 File Offset: 0x003D8E60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005995 RID: 22933
		// (get) Token: 0x0601A914 RID: 108820 RVA: 0x003DAC63 File Offset: 0x003D8E63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TotalTopUpRewardRequest.Descriptor;
			}
		}

		// Token: 0x0601A915 RID: 108821 RVA: 0x003DAC6A File Offset: 0x003D8E6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TotalTopUpRewardRequest()
		{
		}

		// Token: 0x0601A916 RID: 108822 RVA: 0x003DAC7D File Offset: 0x003D8E7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TotalTopUpRewardRequest(TotalTopUpRewardRequest other) : this()
		{
			this.totalTopUpRewardId_ = other.totalTopUpRewardId_;
			this.selectedId_ = other.selectedId_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A917 RID: 108823 RVA: 0x003DACB3 File Offset: 0x003D8EB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TotalTopUpRewardRequest Clone()
		{
			return new TotalTopUpRewardRequest(this);
		}

		// Token: 0x17005996 RID: 22934
		// (get) Token: 0x0601A918 RID: 108824 RVA: 0x003DACBB File Offset: 0x003D8EBB
		// (set) Token: 0x0601A919 RID: 108825 RVA: 0x003DACC3 File Offset: 0x003D8EC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TotalTopUpRewardId
		{
			get
			{
				return this.totalTopUpRewardId_;
			}
			set
			{
				this.totalTopUpRewardId_ = value;
			}
		}

		// Token: 0x17005997 RID: 22935
		// (get) Token: 0x0601A91A RID: 108826 RVA: 0x003DACCC File Offset: 0x003D8ECC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> SelectedId
		{
			get
			{
				return this.selectedId_;
			}
		}

		// Token: 0x0601A91B RID: 108827 RVA: 0x003DACD4 File Offset: 0x003D8ED4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TotalTopUpRewardRequest);
		}

		// Token: 0x0601A91C RID: 108828 RVA: 0x003DACE4 File Offset: 0x003D8EE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TotalTopUpRewardRequest other)
		{
			return other != null && (other == this || (this.TotalTopUpRewardId == other.TotalTopUpRewardId && this.selectedId_.Equals(other.selectedId_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A91D RID: 108829 RVA: 0x003DAD34 File Offset: 0x003D8F34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TotalTopUpRewardId != 0)
			{
				num ^= this.TotalTopUpRewardId.GetHashCode();
			}
			num ^= this.selectedId_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601A91E RID: 108830 RVA: 0x003DAD81 File Offset: 0x003D8F81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A91F RID: 108831 RVA: 0x003DAD8E File Offset: 0x003D8F8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A920 RID: 108832 RVA: 0x003DAD98 File Offset: 0x003D8F98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TotalTopUpRewardId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.TotalTopUpRewardId);
			}
			this.selectedId_.WriteTo(ref output, TotalTopUpRewardRequest._repeated_selectedId_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A921 RID: 108833 RVA: 0x003DADE8 File Offset: 0x003D8FE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TotalTopUpRewardId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TotalTopUpRewardId);
			}
			num += this.selectedId_.CalculateSize(TotalTopUpRewardRequest._repeated_selectedId_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601A922 RID: 108834 RVA: 0x003DAE3C File Offset: 0x003D903C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TotalTopUpRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TotalTopUpRewardId != 0)
			{
				this.TotalTopUpRewardId = other.TotalTopUpRewardId;
			}
			this.selectedId_.Add(other.selectedId_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601A923 RID: 108835 RVA: 0x003DAE89 File Offset: 0x003D9089
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A924 RID: 108836 RVA: 0x003DAE94 File Offset: 0x003D9094
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
				if (num != 72U)
				{
					if (num != 104U && num != 106U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.selectedId_.AddEntriesFrom(ref input, TotalTopUpRewardRequest._repeated_selectedId_codec);
					}
				}
				else
				{
					this.TotalTopUpRewardId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04009A72 RID: 39538
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009A73 RID: 39539
		public const int TotalTopUpRewardIdFieldNumber = 9;

		// Token: 0x04009A74 RID: 39540
		private int totalTopUpRewardId_;

		// Token: 0x04009A75 RID: 39541
		public const int SelectedIdFieldNumber = 13;

		// Token: 0x04009A76 RID: 39542
		private static readonly FieldCodec<int> _repeated_selectedId_codec = FieldCodec.ForInt32(106U);

		// Token: 0x04009A77 RID: 39543
		private readonly RepeatedField<int> selectedId_ = new RepeatedField<int>();
	}
}
