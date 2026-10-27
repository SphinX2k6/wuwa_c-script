using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020000B9 RID: 185
	public sealed class AdventureDetectionConfig : IMessage<AdventureDetectionConfig>, IMessage, IEquatable<AdventureDetectionConfig>, IDeepCloneable<AdventureDetectionConfig>, IBufferMessage
	{
		// Token: 0x06001E2B RID: 7723 RVA: 0x0005277E File Offset: 0x0005097E
		[NullableContext(1)]
		public static AdventureDetectionConfig Create()
		{
			return new AdventureDetectionConfig();
		}

		// Token: 0x1700037B RID: 891
		// (get) Token: 0x06001E2C RID: 7724 RVA: 0x00052785 File Offset: 0x00050985
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AdventureDetectionConfig> Parser
		{
			get
			{
				return AdventureDetectionConfig._parser;
			}
		}

		// Token: 0x1700037C RID: 892
		// (get) Token: 0x06001E2D RID: 7725 RVA: 0x0005278C File Offset: 0x0005098C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700037D RID: 893
		// (get) Token: 0x06001E2E RID: 7726 RVA: 0x0005278F File Offset: 0x0005098F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AdventureDetectionConfig.Descriptor;
			}
		}

		// Token: 0x06001E2F RID: 7727 RVA: 0x00052796 File Offset: 0x00050996
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdventureDetectionConfig()
		{
		}

		// Token: 0x06001E30 RID: 7728 RVA: 0x0005279E File Offset: 0x0005099E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdventureDetectionConfig(AdventureDetectionConfig other) : this()
		{
			this.id_ = other.id_;
			this.effectBeginTime_ = other.effectBeginTime_;
			this.effectEndTime_ = other.effectEndTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001E31 RID: 7729 RVA: 0x000527DB File Offset: 0x000509DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdventureDetectionConfig Clone()
		{
			return new AdventureDetectionConfig(this);
		}

		// Token: 0x1700037E RID: 894
		// (get) Token: 0x06001E32 RID: 7730 RVA: 0x000527E3 File Offset: 0x000509E3
		// (set) Token: 0x06001E33 RID: 7731 RVA: 0x000527EB File Offset: 0x000509EB
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

		// Token: 0x1700037F RID: 895
		// (get) Token: 0x06001E34 RID: 7732 RVA: 0x000527F4 File Offset: 0x000509F4
		// (set) Token: 0x06001E35 RID: 7733 RVA: 0x000527FC File Offset: 0x000509FC
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

		// Token: 0x17000380 RID: 896
		// (get) Token: 0x06001E36 RID: 7734 RVA: 0x00052805 File Offset: 0x00050A05
		// (set) Token: 0x06001E37 RID: 7735 RVA: 0x0005280D File Offset: 0x00050A0D
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

		// Token: 0x06001E38 RID: 7736 RVA: 0x00052816 File Offset: 0x00050A16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AdventureDetectionConfig);
		}

		// Token: 0x06001E39 RID: 7737 RVA: 0x00052824 File Offset: 0x00050A24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AdventureDetectionConfig other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.EffectBeginTime == other.EffectBeginTime && this.EffectEndTime == other.EffectEndTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001E3A RID: 7738 RVA: 0x00052880 File Offset: 0x00050A80
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

		// Token: 0x06001E3B RID: 7739 RVA: 0x000528F1 File Offset: 0x00050AF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001E3C RID: 7740 RVA: 0x000528FE File Offset: 0x00050AFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001E3D RID: 7741 RVA: 0x00052908 File Offset: 0x00050B08
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

		// Token: 0x06001E3E RID: 7742 RVA: 0x0005297C File Offset: 0x00050B7C
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

		// Token: 0x06001E3F RID: 7743 RVA: 0x000529EC File Offset: 0x00050BEC
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

		// Token: 0x06001E40 RID: 7744 RVA: 0x00052A50 File Offset: 0x00050C50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001E41 RID: 7745 RVA: 0x00052A5C File Offset: 0x00050C5C
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

		// Token: 0x0400234A RID: 9034
		private static readonly MessageParser<AdventureDetectionConfig> _parser = new MessageParser<AdventureDetectionConfig>(() => new AdventureDetectionConfig());

		// Token: 0x0400234B RID: 9035
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400234C RID: 9036
		public const int IdFieldNumber = 1;

		// Token: 0x0400234D RID: 9037
		private int id_;

		// Token: 0x0400234E RID: 9038
		public const int EffectBeginTimeFieldNumber = 2;

		// Token: 0x0400234F RID: 9039
		private long effectBeginTime_;

		// Token: 0x04002350 RID: 9040
		public const int EffectEndTimeFieldNumber = 3;

		// Token: 0x04002351 RID: 9041
		private long effectEndTime_;
	}
}
