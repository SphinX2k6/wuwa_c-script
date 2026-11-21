using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001485 RID: 5253
	public sealed class TrapDefenseBuildingPbData : IMessage<TrapDefenseBuildingPbData>, IMessage, IEquatable<TrapDefenseBuildingPbData>, IDeepCloneable<TrapDefenseBuildingPbData>, IBufferMessage
	{
		// Token: 0x0601BE4A RID: 114250 RVA: 0x0040D765 File Offset: 0x0040B965
		[NullableContext(1)]
		public static TrapDefenseBuildingPbData Create()
		{
			return new TrapDefenseBuildingPbData();
		}

		// Token: 0x17005E70 RID: 24176
		// (get) Token: 0x0601BE4B RID: 114251 RVA: 0x0040D76C File Offset: 0x0040B96C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005E71 RID: 24177
		// (get) Token: 0x0601BE4C RID: 114252 RVA: 0x0040D76F File Offset: 0x0040B96F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseBuildingPbData.Descriptor;
			}
		}

		// Token: 0x0601BE4D RID: 114253 RVA: 0x0040D776 File Offset: 0x0040B976
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseBuildingPbData()
		{
		}

		// Token: 0x0601BE4E RID: 114254 RVA: 0x0040D780 File Offset: 0x0040B980
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseBuildingPbData(TrapDefenseBuildingPbData other) : this()
		{
			this.configId_ = other.configId_;
			this.battleLevel_ = other.battleLevel_;
			this.constructCost_ = other.constructCost_;
			this.deconstructReturn_ = other.deconstructReturn_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601BE4F RID: 114255 RVA: 0x0040D7D4 File Offset: 0x0040B9D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseBuildingPbData Clone()
		{
			return new TrapDefenseBuildingPbData(this);
		}

		// Token: 0x17005E72 RID: 24178
		// (get) Token: 0x0601BE50 RID: 114256 RVA: 0x0040D7DC File Offset: 0x0040B9DC
		// (set) Token: 0x0601BE51 RID: 114257 RVA: 0x0040D7E4 File Offset: 0x0040B9E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ConfigId
		{
			get
			{
				return this.configId_;
			}
			set
			{
				this.configId_ = value;
			}
		}

		// Token: 0x17005E73 RID: 24179
		// (get) Token: 0x0601BE52 RID: 114258 RVA: 0x0040D7ED File Offset: 0x0040B9ED
		// (set) Token: 0x0601BE53 RID: 114259 RVA: 0x0040D7F5 File Offset: 0x0040B9F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BattleLevel
		{
			get
			{
				return this.battleLevel_;
			}
			set
			{
				this.battleLevel_ = value;
			}
		}

		// Token: 0x17005E74 RID: 24180
		// (get) Token: 0x0601BE54 RID: 114260 RVA: 0x0040D7FE File Offset: 0x0040B9FE
		// (set) Token: 0x0601BE55 RID: 114261 RVA: 0x0040D806 File Offset: 0x0040BA06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ConstructCost
		{
			get
			{
				return this.constructCost_;
			}
			set
			{
				this.constructCost_ = value;
			}
		}

		// Token: 0x17005E75 RID: 24181
		// (get) Token: 0x0601BE56 RID: 114262 RVA: 0x0040D80F File Offset: 0x0040BA0F
		// (set) Token: 0x0601BE57 RID: 114263 RVA: 0x0040D817 File Offset: 0x0040BA17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int DeconstructReturn
		{
			get
			{
				return this.deconstructReturn_;
			}
			set
			{
				this.deconstructReturn_ = value;
			}
		}

		// Token: 0x0601BE58 RID: 114264 RVA: 0x0040D820 File Offset: 0x0040BA20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseBuildingPbData);
		}

		// Token: 0x0601BE59 RID: 114265 RVA: 0x0040D830 File Offset: 0x0040BA30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseBuildingPbData other)
		{
			return other != null && (other == this || (this.ConfigId == other.ConfigId && this.BattleLevel == other.BattleLevel && this.ConstructCost == other.ConstructCost && this.DeconstructReturn == other.DeconstructReturn && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601BE5A RID: 114266 RVA: 0x0040D89C File Offset: 0x0040BA9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ConfigId != 0)
			{
				num ^= this.ConfigId.GetHashCode();
			}
			if (this.BattleLevel != 0)
			{
				num ^= this.BattleLevel.GetHashCode();
			}
			if (this.ConstructCost != 0)
			{
				num ^= this.ConstructCost.GetHashCode();
			}
			if (this.DeconstructReturn != 0)
			{
				num ^= this.DeconstructReturn.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601BE5B RID: 114267 RVA: 0x0040D926 File Offset: 0x0040BB26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601BE5C RID: 114268 RVA: 0x0040D933 File Offset: 0x0040BB33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601BE5D RID: 114269 RVA: 0x0040D93C File Offset: 0x0040BB3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ConfigId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ConfigId);
			}
			if (this.BattleLevel != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.BattleLevel);
			}
			if (this.ConstructCost != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.ConstructCost);
			}
			if (this.DeconstructReturn != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.DeconstructReturn);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601BE5E RID: 114270 RVA: 0x0040D9CC File Offset: 0x0040BBCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ConfigId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ConfigId);
			}
			if (this.BattleLevel != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BattleLevel);
			}
			if (this.ConstructCost != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ConstructCost);
			}
			if (this.DeconstructReturn != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.DeconstructReturn);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601BE5F RID: 114271 RVA: 0x0040DA54 File Offset: 0x0040BC54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrapDefenseBuildingPbData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ConfigId != 0)
			{
				this.ConfigId = other.ConfigId;
			}
			if (other.BattleLevel != 0)
			{
				this.BattleLevel = other.BattleLevel;
			}
			if (other.ConstructCost != 0)
			{
				this.ConstructCost = other.ConstructCost;
			}
			if (other.DeconstructReturn != 0)
			{
				this.DeconstructReturn = other.DeconstructReturn;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601BE60 RID: 114272 RVA: 0x0040DACC File Offset: 0x0040BCCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601BE61 RID: 114273 RVA: 0x0040DAD8 File Offset: 0x0040BCD8
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
				if (num <= 16U)
				{
					if (num == 8U)
					{
						this.ConfigId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.BattleLevel = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.ConstructCost = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.DeconstructReturn = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400A1CB RID: 41419
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A1CC RID: 41420
		public const int ConfigIdFieldNumber = 1;

		// Token: 0x0400A1CD RID: 41421
		private int configId_;

		// Token: 0x0400A1CE RID: 41422
		public const int BattleLevelFieldNumber = 2;

		// Token: 0x0400A1CF RID: 41423
		private int battleLevel_;

		// Token: 0x0400A1D0 RID: 41424
		public const int ConstructCostFieldNumber = 3;

		// Token: 0x0400A1D1 RID: 41425
		private int constructCost_;

		// Token: 0x0400A1D2 RID: 41426
		public const int DeconstructReturnFieldNumber = 4;

		// Token: 0x0400A1D3 RID: 41427
		private int deconstructReturn_;
	}
}
