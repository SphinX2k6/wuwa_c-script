using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020000BA RID: 186
	public sealed class AdventureDetectionConfig : IMessage<AdventureDetectionConfig>, IMessage, IEquatable<AdventureDetectionConfig>, IDeepCloneable<AdventureDetectionConfig>, IBufferMessage
	{
		// Token: 0x06001E74 RID: 7796 RVA: 0x00053432 File Offset: 0x00051632
		[NullableContext(1)]
		public static AdventureDetectionConfig Create()
		{
			return new AdventureDetectionConfig();
		}

		// Token: 0x17000384 RID: 900
		// (get) Token: 0x06001E75 RID: 7797 RVA: 0x00053439 File Offset: 0x00051639
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AdventureDetectionConfig> Parser
		{
			get
			{
				return AdventureDetectionConfig._parser;
			}
		}

		// Token: 0x17000385 RID: 901
		// (get) Token: 0x06001E76 RID: 7798 RVA: 0x00053440 File Offset: 0x00051640
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000386 RID: 902
		// (get) Token: 0x06001E77 RID: 7799 RVA: 0x00053443 File Offset: 0x00051643
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AdventureDetectionConfig.Descriptor;
			}
		}

		// Token: 0x06001E78 RID: 7800 RVA: 0x0005344A File Offset: 0x0005164A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdventureDetectionConfig()
		{
		}

		// Token: 0x06001E79 RID: 7801 RVA: 0x00053452 File Offset: 0x00051652
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdventureDetectionConfig(AdventureDetectionConfig other) : this()
		{
			this.id_ = other.id_;
			this.effectBeginTime_ = other.effectBeginTime_;
			this.effectEndTime_ = other.effectEndTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001E7A RID: 7802 RVA: 0x0005348F File Offset: 0x0005168F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdventureDetectionConfig Clone()
		{
			return new AdventureDetectionConfig(this);
		}

		// Token: 0x17000387 RID: 903
		// (get) Token: 0x06001E7B RID: 7803 RVA: 0x00053497 File Offset: 0x00051697
		// (set) Token: 0x06001E7C RID: 7804 RVA: 0x0005349F File Offset: 0x0005169F
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

		// Token: 0x17000388 RID: 904
		// (get) Token: 0x06001E7D RID: 7805 RVA: 0x000534A8 File Offset: 0x000516A8
		// (set) Token: 0x06001E7E RID: 7806 RVA: 0x000534B0 File Offset: 0x000516B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EffectBeginTime
		{
			get
			{
				return this.effectBeginTime_;
			}
			set
			{
				this.effectBeginTime_ = value;
			}
		}

		// Token: 0x17000389 RID: 905
		// (get) Token: 0x06001E7F RID: 7807 RVA: 0x000534B9 File Offset: 0x000516B9
		// (set) Token: 0x06001E80 RID: 7808 RVA: 0x000534C1 File Offset: 0x000516C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EffectEndTime
		{
			get
			{
				return this.effectEndTime_;
			}
			set
			{
				this.effectEndTime_ = value;
			}
		}

		// Token: 0x06001E81 RID: 7809 RVA: 0x000534CA File Offset: 0x000516CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AdventureDetectionConfig);
		}

		// Token: 0x06001E82 RID: 7810 RVA: 0x000534D8 File Offset: 0x000516D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AdventureDetectionConfig other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.EffectBeginTime == other.EffectBeginTime && this.EffectEndTime == other.EffectEndTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001E83 RID: 7811 RVA: 0x00053534 File Offset: 0x00051734
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.EffectBeginTime != 0L)
			{
				num ^= this.EffectBeginTime.GetHashCode();
			}
			if (this.EffectEndTime != 0L)
			{
				num ^= this.EffectEndTime.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001E84 RID: 7812 RVA: 0x000535A5 File Offset: 0x000517A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001E85 RID: 7813 RVA: 0x000535B2 File Offset: 0x000517B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001E86 RID: 7814 RVA: 0x000535BC File Offset: 0x000517BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			if (this.EffectBeginTime != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.EffectBeginTime);
			}
			if (this.EffectEndTime != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.EffectEndTime);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001E87 RID: 7815 RVA: 0x00053630 File Offset: 0x00051830
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.EffectBeginTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EffectBeginTime);
			}
			if (this.EffectEndTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EffectEndTime);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001E88 RID: 7816 RVA: 0x000536A0 File Offset: 0x000518A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AdventureDetectionConfig other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.EffectBeginTime != 0L)
			{
				this.EffectBeginTime = other.EffectBeginTime;
			}
			if (other.EffectEndTime != 0L)
			{
				this.EffectEndTime = other.EffectEndTime;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001E89 RID: 7817 RVA: 0x00053704 File Offset: 0x00051904
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001E8A RID: 7818 RVA: 0x00053710 File Offset: 0x00051910
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
					if (num != 16U)
					{
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.EffectEndTime = input.ReadInt64();
						}
					}
					else
					{
						this.EffectBeginTime = input.ReadInt64();
					}
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x040023AD RID: 9133
		private static readonly MessageParser<AdventureDetectionConfig> _parser = new MessageParser<AdventureDetectionConfig>(() => new AdventureDetectionConfig());

		// Token: 0x040023AE RID: 9134
		private UnknownFieldSet _unknownFields;

		// Token: 0x040023AF RID: 9135
		public const int IdFieldNumber = 1;

		// Token: 0x040023B0 RID: 9136
		private int id_;

		// Token: 0x040023B1 RID: 9137
		public const int EffectBeginTimeFieldNumber = 2;

		// Token: 0x040023B2 RID: 9138
		private long effectBeginTime_;

		// Token: 0x040023B3 RID: 9139
		public const int EffectEndTimeFieldNumber = 3;

		// Token: 0x040023B4 RID: 9140
		private long effectEndTime_;
	}
}
