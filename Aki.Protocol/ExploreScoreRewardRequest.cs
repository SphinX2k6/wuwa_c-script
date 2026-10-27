using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004FE RID: 1278
	[NetMessage(EMessageId.ExploreScoreRewardRequest)]
	public sealed class ExploreScoreRewardRequest : IMessage<ExploreScoreRewardRequest>, IMessage, IEquatable<ExploreScoreRewardRequest>, IDeepCloneable<ExploreScoreRewardRequest>, IBufferMessage
	{
		// Token: 0x06007885 RID: 30853 RVA: 0x00125649 File Offset: 0x00123849
		[NullableContext(1)]
		public static ExploreScoreRewardRequest Create()
		{
			return new ExploreScoreRewardRequest();
		}

		// Token: 0x1700175B RID: 5979
		// (get) Token: 0x06007886 RID: 30854 RVA: 0x00125650 File Offset: 0x00123850
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700175C RID: 5980
		// (get) Token: 0x06007887 RID: 30855 RVA: 0x00125653 File Offset: 0x00123853
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ExploreScoreRewardRequest.Descriptor;
			}
		}

		// Token: 0x06007888 RID: 30856 RVA: 0x0012565A File Offset: 0x0012385A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreScoreRewardRequest()
		{
		}

		// Token: 0x06007889 RID: 30857 RVA: 0x00125662 File Offset: 0x00123862
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreScoreRewardRequest(ExploreScoreRewardRequest other) : this()
		{
			this.areaId_ = other.areaId_;
			this.exploreProgress_ = other.exploreProgress_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600788A RID: 30858 RVA: 0x00125693 File Offset: 0x00123893
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreScoreRewardRequest Clone()
		{
			return new ExploreScoreRewardRequest(this);
		}

		// Token: 0x1700175D RID: 5981
		// (get) Token: 0x0600788B RID: 30859 RVA: 0x0012569B File Offset: 0x0012389B
		// (set) Token: 0x0600788C RID: 30860 RVA: 0x001256A3 File Offset: 0x001238A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int AreaId
		{
			get
			{
				return this.areaId_;
			}
			set
			{
				this.areaId_ = value;
			}
		}

		// Token: 0x1700175E RID: 5982
		// (get) Token: 0x0600788D RID: 30861 RVA: 0x001256AC File Offset: 0x001238AC
		// (set) Token: 0x0600788E RID: 30862 RVA: 0x001256B4 File Offset: 0x001238B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ExploreProgress
		{
			get
			{
				return this.exploreProgress_;
			}
			set
			{
				this.exploreProgress_ = value;
			}
		}

		// Token: 0x0600788F RID: 30863 RVA: 0x001256BD File Offset: 0x001238BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ExploreScoreRewardRequest);
		}

		// Token: 0x06007890 RID: 30864 RVA: 0x001256CB File Offset: 0x001238CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ExploreScoreRewardRequest other)
		{
			return other != null && (other == this || (this.AreaId == other.AreaId && this.ExploreProgress == other.ExploreProgress && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007891 RID: 30865 RVA: 0x0012570C File Offset: 0x0012390C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.AreaId != 0)
			{
				num ^= this.AreaId.GetHashCode();
			}
			if (this.ExploreProgress != 0)
			{
				num ^= this.ExploreProgress.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007892 RID: 30866 RVA: 0x00125764 File Offset: 0x00123964
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007893 RID: 30867 RVA: 0x00125771 File Offset: 0x00123971
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007894 RID: 30868 RVA: 0x0012577C File Offset: 0x0012397C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ExploreProgress != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.ExploreProgress);
			}
			if (this.AreaId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.AreaId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007895 RID: 30869 RVA: 0x001257D8 File Offset: 0x001239D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.AreaId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.AreaId);
			}
			if (this.ExploreProgress != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ExploreProgress);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007896 RID: 30870 RVA: 0x00125830 File Offset: 0x00123A30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ExploreScoreRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.AreaId != 0)
			{
				this.AreaId = other.AreaId;
			}
			if (other.ExploreProgress != 0)
			{
				this.ExploreProgress = other.ExploreProgress;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007897 RID: 30871 RVA: 0x00125880 File Offset: 0x00123A80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007898 RID: 30872 RVA: 0x0012588C File Offset: 0x00123A8C
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
				if (num != 16U)
				{
					if (num != 80U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.AreaId = input.ReadInt32();
					}
				}
				else
				{
					this.ExploreProgress = input.ReadInt32();
				}
			}
		}

		// Token: 0x04003E6F RID: 15983
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003E70 RID: 15984
		public const int AreaIdFieldNumber = 10;

		// Token: 0x04003E71 RID: 15985
		private int areaId_;

		// Token: 0x04003E72 RID: 15986
		public const int ExploreProgressFieldNumber = 2;

		// Token: 0x04003E73 RID: 15987
		private int exploreProgress_;
	}
}
