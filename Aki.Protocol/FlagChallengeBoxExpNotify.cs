using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000594 RID: 1428
	[NetMessage(EMessageId.FlagChallengeBoxExpNotify)]
	public sealed class FlagChallengeBoxExpNotify : IMessage<FlagChallengeBoxExpNotify>, IMessage, IEquatable<FlagChallengeBoxExpNotify>, IDeepCloneable<FlagChallengeBoxExpNotify>, IBufferMessage
	{
		// Token: 0x06008449 RID: 33865 RVA: 0x0013E5F8 File Offset: 0x0013C7F8
		[NullableContext(1)]
		public static FlagChallengeBoxExpNotify Create()
		{
			return new FlagChallengeBoxExpNotify();
		}

		// Token: 0x170019C7 RID: 6599
		// (get) Token: 0x0600844A RID: 33866 RVA: 0x0013E5FF File Offset: 0x0013C7FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170019C8 RID: 6600
		// (get) Token: 0x0600844B RID: 33867 RVA: 0x0013E602 File Offset: 0x0013C802
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FlagChallengeBoxExpNotify.Descriptor;
			}
		}

		// Token: 0x0600844C RID: 33868 RVA: 0x0013E609 File Offset: 0x0013C809
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlagChallengeBoxExpNotify()
		{
		}

		// Token: 0x0600844D RID: 33869 RVA: 0x0013E611 File Offset: 0x0013C811
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlagChallengeBoxExpNotify(FlagChallengeBoxExpNotify other) : this()
		{
			this.challengeLevelId_ = other.challengeLevelId_;
			this.boxExp_ = other.boxExp_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600844E RID: 33870 RVA: 0x0013E642 File Offset: 0x0013C842
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlagChallengeBoxExpNotify Clone()
		{
			return new FlagChallengeBoxExpNotify(this);
		}

		// Token: 0x170019C9 RID: 6601
		// (get) Token: 0x0600844F RID: 33871 RVA: 0x0013E64A File Offset: 0x0013C84A
		// (set) Token: 0x06008450 RID: 33872 RVA: 0x0013E652 File Offset: 0x0013C852
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ChallengeLevelId
		{
			get
			{
				return this.challengeLevelId_;
			}
			set
			{
				this.challengeLevelId_ = value;
			}
		}

		// Token: 0x170019CA RID: 6602
		// (get) Token: 0x06008451 RID: 33873 RVA: 0x0013E65B File Offset: 0x0013C85B
		// (set) Token: 0x06008452 RID: 33874 RVA: 0x0013E663 File Offset: 0x0013C863
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BoxExp
		{
			get
			{
				return this.boxExp_;
			}
			set
			{
				this.boxExp_ = value;
			}
		}

		// Token: 0x06008453 RID: 33875 RVA: 0x0013E66C File Offset: 0x0013C86C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FlagChallengeBoxExpNotify);
		}

		// Token: 0x06008454 RID: 33876 RVA: 0x0013E67A File Offset: 0x0013C87A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FlagChallengeBoxExpNotify other)
		{
			return other != null && (other == this || (this.ChallengeLevelId == other.ChallengeLevelId && this.BoxExp == other.BoxExp && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008455 RID: 33877 RVA: 0x0013E6B8 File Offset: 0x0013C8B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ChallengeLevelId != 0)
			{
				num ^= this.ChallengeLevelId.GetHashCode();
			}
			if (this.BoxExp != 0)
			{
				num ^= this.BoxExp.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008456 RID: 33878 RVA: 0x0013E710 File Offset: 0x0013C910
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008457 RID: 33879 RVA: 0x0013E71D File Offset: 0x0013C91D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008458 RID: 33880 RVA: 0x0013E728 File Offset: 0x0013C928
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.BoxExp != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.BoxExp);
			}
			if (this.ChallengeLevelId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.ChallengeLevelId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008459 RID: 33881 RVA: 0x0013E780 File Offset: 0x0013C980
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ChallengeLevelId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ChallengeLevelId);
			}
			if (this.BoxExp != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BoxExp);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600845A RID: 33882 RVA: 0x0013E7D8 File Offset: 0x0013C9D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FlagChallengeBoxExpNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ChallengeLevelId != 0)
			{
				this.ChallengeLevelId = other.ChallengeLevelId;
			}
			if (other.BoxExp != 0)
			{
				this.BoxExp = other.BoxExp;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600845B RID: 33883 RVA: 0x0013E828 File Offset: 0x0013CA28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600845C RID: 33884 RVA: 0x0013E834 File Offset: 0x0013CA34
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
				if (num != 8U)
				{
					if (num != 88U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ChallengeLevelId = input.ReadInt32();
					}
				}
				else
				{
					this.BoxExp = input.ReadInt32();
				}
			}
		}

		// Token: 0x040041B0 RID: 16816
		private UnknownFieldSet _unknownFields;

		// Token: 0x040041B1 RID: 16817
		public const int ChallengeLevelIdFieldNumber = 11;

		// Token: 0x040041B2 RID: 16818
		private int challengeLevelId_;

		// Token: 0x040041B3 RID: 16819
		public const int BoxExpFieldNumber = 1;

		// Token: 0x040041B4 RID: 16820
		private int boxExp_;
	}
}
