using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001293 RID: 4755
	public sealed class SlashLevelRecommend : IMessage<SlashLevelRecommend>, IMessage, IEquatable<SlashLevelRecommend>, IDeepCloneable<SlashLevelRecommend>, IBufferMessage
	{
		// Token: 0x06019615 RID: 103957 RVA: 0x003B3991 File Offset: 0x003B1B91
		[NullableContext(1)]
		public static SlashLevelRecommend Create()
		{
			return new SlashLevelRecommend();
		}

		// Token: 0x170055D9 RID: 21977
		// (get) Token: 0x06019616 RID: 103958 RVA: 0x003B3998 File Offset: 0x003B1B98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SlashLevelRecommend> Parser
		{
			get
			{
				return SlashLevelRecommend._parser;
			}
		}

		// Token: 0x170055DA RID: 21978
		// (get) Token: 0x06019617 RID: 103959 RVA: 0x003B399F File Offset: 0x003B1B9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170055DB RID: 21979
		// (get) Token: 0x06019618 RID: 103960 RVA: 0x003B39A2 File Offset: 0x003B1BA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SlashLevelRecommend.Descriptor;
			}
		}

		// Token: 0x06019619 RID: 103961 RVA: 0x003B39A9 File Offset: 0x003B1BA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SlashLevelRecommend()
		{
		}

		// Token: 0x0601961A RID: 103962 RVA: 0x003B39B4 File Offset: 0x003B1BB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SlashLevelRecommend(SlashLevelRecommend other) : this()
		{
			this.formationFirst_ = ((other.formationFirst_ != null) ? other.formationFirst_.Clone() : null);
			this.formationSecond_ = ((other.formationSecond_ != null) ? other.formationSecond_.Clone() : null);
			this.usage_ = other.usage_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601961B RID: 103963 RVA: 0x003B3A1C File Offset: 0x003B1C1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SlashLevelRecommend Clone()
		{
			return new SlashLevelRecommend(this);
		}

		// Token: 0x170055DC RID: 21980
		// (get) Token: 0x0601961C RID: 103964 RVA: 0x003B3A24 File Offset: 0x003B1C24
		// (set) Token: 0x0601961D RID: 103965 RVA: 0x003B3A2C File Offset: 0x003B1C2C
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

		// Token: 0x170055DD RID: 21981
		// (get) Token: 0x0601961E RID: 103966 RVA: 0x003B3A35 File Offset: 0x003B1C35
		// (set) Token: 0x0601961F RID: 103967 RVA: 0x003B3A3D File Offset: 0x003B1C3D
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

		// Token: 0x170055DE RID: 21982
		// (get) Token: 0x06019620 RID: 103968 RVA: 0x003B3A46 File Offset: 0x003B1C46
		// (set) Token: 0x06019621 RID: 103969 RVA: 0x003B3A4E File Offset: 0x003B1C4E
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

		// Token: 0x06019622 RID: 103970 RVA: 0x003B3A57 File Offset: 0x003B1C57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SlashLevelRecommend);
		}

		// Token: 0x06019623 RID: 103971 RVA: 0x003B3A68 File Offset: 0x003B1C68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SlashLevelRecommend other)
		{
			return other != null && (other == this || (object.Equals(this.FormationFirst, other.FormationFirst) && object.Equals(this.FormationSecond, other.FormationSecond) && this.Usage == other.Usage && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019624 RID: 103972 RVA: 0x003B3ACC File Offset: 0x003B1CCC
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

		// Token: 0x06019625 RID: 103973 RVA: 0x003B3B37 File Offset: 0x003B1D37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019626 RID: 103974 RVA: 0x003B3B44 File Offset: 0x003B1D44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019627 RID: 103975 RVA: 0x003B3B50 File Offset: 0x003B1D50
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

		// Token: 0x06019628 RID: 103976 RVA: 0x003B3BC8 File Offset: 0x003B1DC8
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

		// Token: 0x06019629 RID: 103977 RVA: 0x003B3C38 File Offset: 0x003B1E38
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

		// Token: 0x0601962A RID: 103978 RVA: 0x003B3CCC File Offset: 0x003B1ECC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601962B RID: 103979 RVA: 0x003B3CD8 File Offset: 0x003B1ED8
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

		// Token: 0x04009619 RID: 38425
		private static readonly MessageParser<SlashLevelRecommend> _parser = new MessageParser<SlashLevelRecommend>(() => new SlashLevelRecommend());

		// Token: 0x0400961A RID: 38426
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400961B RID: 38427
		public const int FormationFirstFieldNumber = 1;

		// Token: 0x0400961C RID: 38428
		private BattleFormation formationFirst_;

		// Token: 0x0400961D RID: 38429
		public const int FormationSecondFieldNumber = 2;

		// Token: 0x0400961E RID: 38430
		private BattleFormation formationSecond_;

		// Token: 0x0400961F RID: 38431
		public const int UsageFieldNumber = 3;

		// Token: 0x04009620 RID: 38432
		private int usage_;
	}
}
