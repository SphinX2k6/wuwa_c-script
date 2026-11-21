using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200075A RID: 1882
	public sealed class HonamiStoryBagUpdateContext : IMessage<HonamiStoryBagUpdateContext>, IMessage, IEquatable<HonamiStoryBagUpdateContext>, IDeepCloneable<HonamiStoryBagUpdateContext>, IBufferMessage
	{
		// Token: 0x0600AAA4 RID: 43684 RVA: 0x0019AE93 File Offset: 0x00199093
		[NullableContext(1)]
		public static HonamiStoryBagUpdateContext Create()
		{
			return new HonamiStoryBagUpdateContext();
		}

		// Token: 0x1700225E RID: 8798
		// (get) Token: 0x0600AAA5 RID: 43685 RVA: 0x0019AE9A File Offset: 0x0019909A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<HonamiStoryBagUpdateContext> Parser
		{
			get
			{
				return HonamiStoryBagUpdateContext._parser;
			}
		}

		// Token: 0x1700225F RID: 8799
		// (get) Token: 0x0600AAA6 RID: 43686 RVA: 0x0019AEA1 File Offset: 0x001990A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002260 RID: 8800
		// (get) Token: 0x0600AAA7 RID: 43687 RVA: 0x0019AEA4 File Offset: 0x001990A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HonamiStoryBagUpdateContext.Descriptor;
			}
		}

		// Token: 0x0600AAA8 RID: 43688 RVA: 0x0019AEAB File Offset: 0x001990AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryBagUpdateContext()
		{
		}

		// Token: 0x0600AAA9 RID: 43689 RVA: 0x0019AEBE File Offset: 0x001990BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryBagUpdateContext(HonamiStoryBagUpdateContext other) : this()
		{
			this.backPackConfigId_ = other.backPackConfigId_;
			this.honamiStoryBagUpdateInfo_ = other.honamiStoryBagUpdateInfo_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AAAA RID: 43690 RVA: 0x0019AEF4 File Offset: 0x001990F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryBagUpdateContext Clone()
		{
			return new HonamiStoryBagUpdateContext(this);
		}

		// Token: 0x17002261 RID: 8801
		// (get) Token: 0x0600AAAB RID: 43691 RVA: 0x0019AEFC File Offset: 0x001990FC
		// (set) Token: 0x0600AAAC RID: 43692 RVA: 0x0019AF04 File Offset: 0x00199104
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BackPackConfigId
		{
			get
			{
				return this.backPackConfigId_;
			}
			set
			{
				this.backPackConfigId_ = value;
			}
		}

		// Token: 0x17002262 RID: 8802
		// (get) Token: 0x0600AAAD RID: 43693 RVA: 0x0019AF0D File Offset: 0x0019910D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<HonamiStoryBagUpdateInfo> HonamiStoryBagUpdateInfo
		{
			get
			{
				return this.honamiStoryBagUpdateInfo_;
			}
		}

		// Token: 0x0600AAAE RID: 43694 RVA: 0x0019AF15 File Offset: 0x00199115
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HonamiStoryBagUpdateContext);
		}

		// Token: 0x0600AAAF RID: 43695 RVA: 0x0019AF24 File Offset: 0x00199124
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HonamiStoryBagUpdateContext other)
		{
			return other != null && (other == this || (this.BackPackConfigId == other.BackPackConfigId && this.honamiStoryBagUpdateInfo_.Equals(other.honamiStoryBagUpdateInfo_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600AAB0 RID: 43696 RVA: 0x0019AF74 File Offset: 0x00199174
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.BackPackConfigId != 0)
			{
				num ^= this.BackPackConfigId.GetHashCode();
			}
			num ^= this.honamiStoryBagUpdateInfo_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600AAB1 RID: 43697 RVA: 0x0019AFC1 File Offset: 0x001991C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600AAB2 RID: 43698 RVA: 0x0019AFCE File Offset: 0x001991CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AAB3 RID: 43699 RVA: 0x0019AFD8 File Offset: 0x001991D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.BackPackConfigId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.BackPackConfigId);
			}
			this.honamiStoryBagUpdateInfo_.WriteTo(ref output, HonamiStoryBagUpdateContext._repeated_honamiStoryBagUpdateInfo_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AAB4 RID: 43700 RVA: 0x0019B028 File Offset: 0x00199228
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.BackPackConfigId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BackPackConfigId);
			}
			num += this.honamiStoryBagUpdateInfo_.CalculateSize(HonamiStoryBagUpdateContext._repeated_honamiStoryBagUpdateInfo_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600AAB5 RID: 43701 RVA: 0x0019B07C File Offset: 0x0019927C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HonamiStoryBagUpdateContext other)
		{
			if (other == null)
			{
				return;
			}
			if (other.BackPackConfigId != 0)
			{
				this.BackPackConfigId = other.BackPackConfigId;
			}
			this.honamiStoryBagUpdateInfo_.Add(other.honamiStoryBagUpdateInfo_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600AAB6 RID: 43702 RVA: 0x0019B0C9 File Offset: 0x001992C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AAB7 RID: 43703 RVA: 0x0019B0D4 File Offset: 0x001992D4
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
					if (num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.honamiStoryBagUpdateInfo_.AddEntriesFrom(ref input, HonamiStoryBagUpdateContext._repeated_honamiStoryBagUpdateInfo_codec);
					}
				}
				else
				{
					this.BackPackConfigId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004DF2 RID: 19954
		private static readonly MessageParser<HonamiStoryBagUpdateContext> _parser = new MessageParser<HonamiStoryBagUpdateContext>(() => new HonamiStoryBagUpdateContext());

		// Token: 0x04004DF3 RID: 19955
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004DF4 RID: 19956
		public const int BackPackConfigIdFieldNumber = 1;

		// Token: 0x04004DF5 RID: 19957
		private int backPackConfigId_;

		// Token: 0x04004DF6 RID: 19958
		public const int HonamiStoryBagUpdateInfoFieldNumber = 2;

		// Token: 0x04004DF7 RID: 19959
		private static readonly FieldCodec<HonamiStoryBagUpdateInfo> _repeated_honamiStoryBagUpdateInfo_codec = FieldCodec.ForMessage<HonamiStoryBagUpdateInfo>(18U, Aki.Protocol.HonamiStoryBagUpdateInfo.Parser);

		// Token: 0x04004DF8 RID: 19960
		private readonly RepeatedField<HonamiStoryBagUpdateInfo> honamiStoryBagUpdateInfo_ = new RepeatedField<HonamiStoryBagUpdateInfo>();
	}
}
