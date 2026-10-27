using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001451 RID: 5201
	[NetMessage(EMessageId.TrapDefenseSpecialRewardUpdateNotify)]
	public sealed class TrapDefenseSpecialRewardUpdateNotify : IMessage<TrapDefenseSpecialRewardUpdateNotify>, IMessage, IEquatable<TrapDefenseSpecialRewardUpdateNotify>, IDeepCloneable<TrapDefenseSpecialRewardUpdateNotify>, IBufferMessage
	{
		// Token: 0x0601B8AE RID: 112814 RVA: 0x003FC974 File Offset: 0x003FAB74
		[NullableContext(1)]
		public static TrapDefenseSpecialRewardUpdateNotify Create()
		{
			return new TrapDefenseSpecialRewardUpdateNotify();
		}

		// Token: 0x17005CDD RID: 23773
		// (get) Token: 0x0601B8AF RID: 112815 RVA: 0x003FC97B File Offset: 0x003FAB7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005CDE RID: 23774
		// (get) Token: 0x0601B8B0 RID: 112816 RVA: 0x003FC97E File Offset: 0x003FAB7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseSpecialRewardUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0601B8B1 RID: 112817 RVA: 0x003FC985 File Offset: 0x003FAB85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseSpecialRewardUpdateNotify()
		{
		}

		// Token: 0x0601B8B2 RID: 112818 RVA: 0x003FC998 File Offset: 0x003FAB98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseSpecialRewardUpdateNotify(TrapDefenseSpecialRewardUpdateNotify other) : this()
		{
			this.specialRewards_ = other.specialRewards_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B8B3 RID: 112819 RVA: 0x003FC9C2 File Offset: 0x003FABC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseSpecialRewardUpdateNotify Clone()
		{
			return new TrapDefenseSpecialRewardUpdateNotify(this);
		}

		// Token: 0x17005CDF RID: 23775
		// (get) Token: 0x0601B8B4 RID: 112820 RVA: 0x003FC9CA File Offset: 0x003FABCA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<TrapDefenseRewardInfo> SpecialRewards
		{
			get
			{
				return this.specialRewards_;
			}
		}

		// Token: 0x0601B8B5 RID: 112821 RVA: 0x003FC9D2 File Offset: 0x003FABD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseSpecialRewardUpdateNotify);
		}

		// Token: 0x0601B8B6 RID: 112822 RVA: 0x003FC9E0 File Offset: 0x003FABE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseSpecialRewardUpdateNotify other)
		{
			return other != null && (other == this || (this.specialRewards_.Equals(other.specialRewards_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B8B7 RID: 112823 RVA: 0x003FCA14 File Offset: 0x003FAC14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.specialRewards_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601B8B8 RID: 112824 RVA: 0x003FCA48 File Offset: 0x003FAC48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B8B9 RID: 112825 RVA: 0x003FCA55 File Offset: 0x003FAC55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B8BA RID: 112826 RVA: 0x003FCA5E File Offset: 0x003FAC5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.specialRewards_.WriteTo(ref output, TrapDefenseSpecialRewardUpdateNotify._repeated_specialRewards_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B8BB RID: 112827 RVA: 0x003FCA88 File Offset: 0x003FAC88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.specialRewards_.CalculateSize(TrapDefenseSpecialRewardUpdateNotify._repeated_specialRewards_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601B8BC RID: 112828 RVA: 0x003FCAC1 File Offset: 0x003FACC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrapDefenseSpecialRewardUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.specialRewards_.Add(other.specialRewards_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B8BD RID: 112829 RVA: 0x003FCAEF File Offset: 0x003FACEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B8BE RID: 112830 RVA: 0x003FCAF8 File Offset: 0x003FACF8
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
				if (num != 82U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.specialRewards_.AddEntriesFrom(ref input, TrapDefenseSpecialRewardUpdateNotify._repeated_specialRewards_codec);
				}
			}
		}

		// Token: 0x04009EC9 RID: 40649
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009ECA RID: 40650
		public const int SpecialRewardsFieldNumber = 10;

		// Token: 0x04009ECB RID: 40651
		private static readonly FieldCodec<TrapDefenseRewardInfo> _repeated_specialRewards_codec = FieldCodec.ForMessage<TrapDefenseRewardInfo>(82U, TrapDefenseRewardInfo.Parser);

		// Token: 0x04009ECC RID: 40652
		private readonly RepeatedField<TrapDefenseRewardInfo> specialRewards_ = new RepeatedField<TrapDefenseRewardInfo>();
	}
}
