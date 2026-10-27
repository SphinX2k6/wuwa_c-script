using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001483 RID: 5251
	public sealed class UnlimitedScoreInfo : IMessage<UnlimitedScoreInfo>, IMessage, IEquatable<UnlimitedScoreInfo>, IDeepCloneable<UnlimitedScoreInfo>, IBufferMessage
	{
		// Token: 0x0601BC9B RID: 113819 RVA: 0x00405045 File Offset: 0x00403245
		[NullableContext(1)]
		public static UnlimitedScoreInfo Create()
		{
			return new UnlimitedScoreInfo();
		}

		// Token: 0x17005DAE RID: 23982
		// (get) Token: 0x0601BC9C RID: 113820 RVA: 0x0040504C File Offset: 0x0040324C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<UnlimitedScoreInfo> Parser
		{
			get
			{
				return UnlimitedScoreInfo._parser;
			}
		}

		// Token: 0x17005DAF RID: 23983
		// (get) Token: 0x0601BC9D RID: 113821 RVA: 0x00405053 File Offset: 0x00403253
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005DB0 RID: 23984
		// (get) Token: 0x0601BC9E RID: 113822 RVA: 0x00405056 File Offset: 0x00403256
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UnlimitedScoreInfo.Descriptor;
			}
		}

		// Token: 0x0601BC9F RID: 113823 RVA: 0x0040505D File Offset: 0x0040325D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UnlimitedScoreInfo()
		{
		}

		// Token: 0x0601BCA0 RID: 113824 RVA: 0x00405065 File Offset: 0x00403265
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UnlimitedScoreInfo(UnlimitedScoreInfo other) : this()
		{
			this.entityId_ = other.entityId_;
			this.highestScore_ = other.highestScore_;
			this.accumulatedScore_ = other.accumulatedScore_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601BCA1 RID: 113825 RVA: 0x004050A2 File Offset: 0x004032A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UnlimitedScoreInfo Clone()
		{
			return new UnlimitedScoreInfo(this);
		}

		// Token: 0x17005DB1 RID: 23985
		// (get) Token: 0x0601BCA2 RID: 113826 RVA: 0x004050AA File Offset: 0x004032AA
		// (set) Token: 0x0601BCA3 RID: 113827 RVA: 0x004050B2 File Offset: 0x004032B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int EntityId
		{
			get
			{
				return this.entityId_;
			}
			set
			{
				this.entityId_ = value;
			}
		}

		// Token: 0x17005DB2 RID: 23986
		// (get) Token: 0x0601BCA4 RID: 113828 RVA: 0x004050BB File Offset: 0x004032BB
		// (set) Token: 0x0601BCA5 RID: 113829 RVA: 0x004050C3 File Offset: 0x004032C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int HighestScore
		{
			get
			{
				return this.highestScore_;
			}
			set
			{
				this.highestScore_ = value;
			}
		}

		// Token: 0x17005DB3 RID: 23987
		// (get) Token: 0x0601BCA6 RID: 113830 RVA: 0x004050CC File Offset: 0x004032CC
		// (set) Token: 0x0601BCA7 RID: 113831 RVA: 0x004050D4 File Offset: 0x004032D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int AccumulatedScore
		{
			get
			{
				return this.accumulatedScore_;
			}
			set
			{
				this.accumulatedScore_ = value;
			}
		}

		// Token: 0x0601BCA8 RID: 113832 RVA: 0x004050DD File Offset: 0x004032DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UnlimitedScoreInfo);
		}

		// Token: 0x0601BCA9 RID: 113833 RVA: 0x004050EC File Offset: 0x004032EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UnlimitedScoreInfo other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.HighestScore == other.HighestScore && this.AccumulatedScore == other.AccumulatedScore && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601BCAA RID: 113834 RVA: 0x00405148 File Offset: 0x00403348
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.HighestScore != 0)
			{
				num ^= this.HighestScore.GetHashCode();
			}
			if (this.AccumulatedScore != 0)
			{
				num ^= this.AccumulatedScore.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601BCAB RID: 113835 RVA: 0x004051B9 File Offset: 0x004033B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601BCAC RID: 113836 RVA: 0x004051C6 File Offset: 0x004033C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601BCAD RID: 113837 RVA: 0x004051D0 File Offset: 0x004033D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.EntityId);
			}
			if (this.HighestScore != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.HighestScore);
			}
			if (this.AccumulatedScore != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.AccumulatedScore);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601BCAE RID: 113838 RVA: 0x00405244 File Offset: 0x00403444
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.EntityId);
			}
			if (this.HighestScore != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.HighestScore);
			}
			if (this.AccumulatedScore != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.AccumulatedScore);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601BCAF RID: 113839 RVA: 0x004052B4 File Offset: 0x004034B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(UnlimitedScoreInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0)
			{
				this.EntityId = other.EntityId;
			}
			if (other.HighestScore != 0)
			{
				this.HighestScore = other.HighestScore;
			}
			if (other.AccumulatedScore != 0)
			{
				this.AccumulatedScore = other.AccumulatedScore;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601BCB0 RID: 113840 RVA: 0x00405318 File Offset: 0x00403518
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601BCB1 RID: 113841 RVA: 0x00405324 File Offset: 0x00403524
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
							this.AccumulatedScore = input.ReadInt32();
						}
					}
					else
					{
						this.HighestScore = input.ReadInt32();
					}
				}
				else
				{
					this.EntityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04009FEA RID: 40938
		private static readonly MessageParser<UnlimitedScoreInfo> _parser = new MessageParser<UnlimitedScoreInfo>(() => new UnlimitedScoreInfo());

		// Token: 0x04009FEB RID: 40939
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009FEC RID: 40940
		public const int EntityIdFieldNumber = 1;

		// Token: 0x04009FED RID: 40941
		private int entityId_;

		// Token: 0x04009FEE RID: 40942
		public const int HighestScoreFieldNumber = 2;

		// Token: 0x04009FEF RID: 40943
		private int highestScore_;

		// Token: 0x04009FF0 RID: 40944
		public const int AccumulatedScoreFieldNumber = 3;

		// Token: 0x04009FF1 RID: 40945
		private int accumulatedScore_;
	}
}
