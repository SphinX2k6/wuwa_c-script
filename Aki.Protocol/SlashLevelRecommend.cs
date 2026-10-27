using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001256 RID: 4694
	public sealed class SlashLevelRecommend : IMessage<SlashLevelRecommend>, IMessage, IEquatable<SlashLevelRecommend>, IDeepCloneable<SlashLevelRecommend>, IBufferMessage
	{
		// Token: 0x0601902B RID: 102443 RVA: 0x003A3A41 File Offset: 0x003A1C41
		[NullableContext(1)]
		public static SlashLevelRecommend Create()
		{
			return new SlashLevelRecommend();
		}

		// Token: 0x1700545A RID: 21594
		// (get) Token: 0x0601902C RID: 102444 RVA: 0x003A3A48 File Offset: 0x003A1C48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SlashLevelRecommend> Parser
		{
			get
			{
				return SlashLevelRecommend._parser;
			}
		}

		// Token: 0x1700545B RID: 21595
		// (get) Token: 0x0601902D RID: 102445 RVA: 0x003A3A4F File Offset: 0x003A1C4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700545C RID: 21596
		// (get) Token: 0x0601902E RID: 102446 RVA: 0x003A3A52 File Offset: 0x003A1C52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SlashLevelRecommend.Descriptor;
			}
		}

		// Token: 0x0601902F RID: 102447 RVA: 0x003A3A59 File Offset: 0x003A1C59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SlashLevelRecommend()
		{
		}

		// Token: 0x06019030 RID: 102448 RVA: 0x003A3A64 File Offset: 0x003A1C64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SlashLevelRecommend(SlashLevelRecommend other) : this()
		{
			this.formationFirst_ = ((other.formationFirst_ != null) ? other.formationFirst_.Clone() : null);
			this.formationSecond_ = ((other.formationSecond_ != null) ? other.formationSecond_.Clone() : null);
			this.usage_ = other.usage_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019031 RID: 102449 RVA: 0x003A3ACC File Offset: 0x003A1CCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SlashLevelRecommend Clone()
		{
			return new SlashLevelRecommend(this);
		}

		// Token: 0x1700545D RID: 21597
		// (get) Token: 0x06019032 RID: 102450 RVA: 0x003A3AD4 File Offset: 0x003A1CD4
		// (set) Token: 0x06019033 RID: 102451 RVA: 0x003A3ADC File Offset: 0x003A1CDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattleFormation FormationFirst
		{
			get
			{
				return this.formationFirst_;
			}
			set
			{
				this.formationFirst_ = value;
			}
		}

		// Token: 0x1700545E RID: 21598
		// (get) Token: 0x06019034 RID: 102452 RVA: 0x003A3AE5 File Offset: 0x003A1CE5
		// (set) Token: 0x06019035 RID: 102453 RVA: 0x003A3AED File Offset: 0x003A1CED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattleFormation FormationSecond
		{
			get
			{
				return this.formationSecond_;
			}
			set
			{
				this.formationSecond_ = value;
			}
		}

		// Token: 0x1700545F RID: 21599
		// (get) Token: 0x06019036 RID: 102454 RVA: 0x003A3AF6 File Offset: 0x003A1CF6
		// (set) Token: 0x06019037 RID: 102455 RVA: 0x003A3AFE File Offset: 0x003A1CFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Usage
		{
			get
			{
				return this.usage_;
			}
			set
			{
				this.usage_ = value;
			}
		}

		// Token: 0x06019038 RID: 102456 RVA: 0x003A3B07 File Offset: 0x003A1D07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SlashLevelRecommend);
		}

		// Token: 0x06019039 RID: 102457 RVA: 0x003A3B18 File Offset: 0x003A1D18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SlashLevelRecommend other)
		{
			return other != null && (other == this || (object.Equals(this.FormationFirst, other.FormationFirst) && object.Equals(this.FormationSecond, other.FormationSecond) && this.Usage == other.Usage && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601903A RID: 102458 RVA: 0x003A3B7C File Offset: 0x003A1D7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.formationFirst_ != null)
			{
				num ^= this.FormationFirst.GetHashCode();
			}
			if (this.formationSecond_ != null)
			{
				num ^= this.FormationSecond.GetHashCode();
			}
			if (this.Usage != 0)
			{
				num ^= this.Usage.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601903B RID: 102459 RVA: 0x003A3BE7 File Offset: 0x003A1DE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601903C RID: 102460 RVA: 0x003A3BF4 File Offset: 0x003A1DF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601903D RID: 102461 RVA: 0x003A3C00 File Offset: 0x003A1E00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.formationFirst_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.FormationFirst);
			}
			if (this.formationSecond_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.FormationSecond);
			}
			if (this.Usage != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Usage);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601903E RID: 102462 RVA: 0x003A3C78 File Offset: 0x003A1E78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.formationFirst_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.FormationFirst);
			}
			if (this.formationSecond_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.FormationSecond);
			}
			if (this.Usage != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Usage);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601903F RID: 102463 RVA: 0x003A3CE8 File Offset: 0x003A1EE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SlashLevelRecommend other)
		{
			if (other == null)
			{
				return;
			}
			if (other.formationFirst_ != null)
			{
				if (this.formationFirst_ == null)
				{
					this.FormationFirst = new BattleFormation();
				}
				this.FormationFirst.MergeFrom(other.FormationFirst);
			}
			if (other.formationSecond_ != null)
			{
				if (this.formationSecond_ == null)
				{
					this.FormationSecond = new BattleFormation();
				}
				this.FormationSecond.MergeFrom(other.FormationSecond);
			}
			if (other.Usage != 0)
			{
				this.Usage = other.Usage;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06019040 RID: 102464 RVA: 0x003A3D7C File Offset: 0x003A1F7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019041 RID: 102465 RVA: 0x003A3D88 File Offset: 0x003A1F88
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
				if (num != 10U)
				{
					if (num != 18U)
					{
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Usage = input.ReadInt32();
						}
					}
					else
					{
						if (this.formationSecond_ == null)
						{
							this.FormationSecond = new BattleFormation();
						}
						input.ReadMessage(this.FormationSecond);
					}
				}
				else
				{
					if (this.formationFirst_ == null)
					{
						this.FormationFirst = new BattleFormation();
					}
					input.ReadMessage(this.FormationFirst);
				}
			}
		}

		// Token: 0x04009367 RID: 37735
		private static readonly MessageParser<SlashLevelRecommend> _parser = new MessageParser<SlashLevelRecommend>(() => new SlashLevelRecommend());

		// Token: 0x04009368 RID: 37736
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009369 RID: 37737
		public const int FormationFirstFieldNumber = 1;

		// Token: 0x0400936A RID: 37738
		private BattleFormation formationFirst_;

		// Token: 0x0400936B RID: 37739
		public const int FormationSecondFieldNumber = 2;

		// Token: 0x0400936C RID: 37740
		private BattleFormation formationSecond_;

		// Token: 0x0400936D RID: 37741
		public const int UsageFieldNumber = 3;

		// Token: 0x0400936E RID: 37742
		private int usage_;
	}
}
