using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FBA RID: 4026
	[NetMessage(EMessageId.RoguelikeWriteCatLevelPlayRewardRequest)]
	public sealed class RoguelikeWriteCatLevelPlayRewardRequest : IMessage<RoguelikeWriteCatLevelPlayRewardRequest>, IMessage, IEquatable<RoguelikeWriteCatLevelPlayRewardRequest>, IDeepCloneable<RoguelikeWriteCatLevelPlayRewardRequest>, IBufferMessage
	{
		// Token: 0x060158D5 RID: 88277 RVA: 0x0032180D File Offset: 0x0031FA0D
		[NullableContext(1)]
		public static RoguelikeWriteCatLevelPlayRewardRequest Create()
		{
			return new RoguelikeWriteCatLevelPlayRewardRequest();
		}

		// Token: 0x170047E5 RID: 18405
		// (get) Token: 0x060158D6 RID: 88278 RVA: 0x00321814 File Offset: 0x0031FA14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170047E6 RID: 18406
		// (get) Token: 0x060158D7 RID: 88279 RVA: 0x00321817 File Offset: 0x0031FA17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoguelikeWriteCatLevelPlayRewardRequest.Descriptor;
			}
		}

		// Token: 0x060158D8 RID: 88280 RVA: 0x0032181E File Offset: 0x0031FA1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeWriteCatLevelPlayRewardRequest()
		{
		}

		// Token: 0x060158D9 RID: 88281 RVA: 0x00321826 File Offset: 0x0031FA26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeWriteCatLevelPlayRewardRequest(RoguelikeWriteCatLevelPlayRewardRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.index_ = other.index_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060158DA RID: 88282 RVA: 0x00321857 File Offset: 0x0031FA57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeWriteCatLevelPlayRewardRequest Clone()
		{
			return new RoguelikeWriteCatLevelPlayRewardRequest(this);
		}

		// Token: 0x170047E7 RID: 18407
		// (get) Token: 0x060158DB RID: 88283 RVA: 0x0032185F File Offset: 0x0031FA5F
		// (set) Token: 0x060158DC RID: 88284 RVA: 0x00321867 File Offset: 0x0031FA67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ActivityId
		{
			get
			{
				return this.activityId_;
			}
			set
			{
				this.activityId_ = value;
			}
		}

		// Token: 0x170047E8 RID: 18408
		// (get) Token: 0x060158DD RID: 88285 RVA: 0x00321870 File Offset: 0x0031FA70
		// (set) Token: 0x060158DE RID: 88286 RVA: 0x00321878 File Offset: 0x0031FA78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Index
		{
			get
			{
				return this.index_;
			}
			set
			{
				this.index_ = value;
			}
		}

		// Token: 0x060158DF RID: 88287 RVA: 0x00321881 File Offset: 0x0031FA81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoguelikeWriteCatLevelPlayRewardRequest);
		}

		// Token: 0x060158E0 RID: 88288 RVA: 0x0032188F File Offset: 0x0031FA8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoguelikeWriteCatLevelPlayRewardRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.Index == other.Index && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060158E1 RID: 88289 RVA: 0x003218D0 File Offset: 0x0031FAD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this.Index != 0)
			{
				num ^= this.Index.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060158E2 RID: 88290 RVA: 0x00321928 File Offset: 0x0031FB28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060158E3 RID: 88291 RVA: 0x00321935 File Offset: 0x0031FB35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060158E4 RID: 88292 RVA: 0x00321940 File Offset: 0x0031FB40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Index != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Index);
			}
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060158E5 RID: 88293 RVA: 0x0032199C File Offset: 0x0031FB9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this.Index != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Index);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060158E6 RID: 88294 RVA: 0x003219F4 File Offset: 0x0031FBF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoguelikeWriteCatLevelPlayRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			if (other.Index != 0)
			{
				this.Index = other.Index;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060158E7 RID: 88295 RVA: 0x00321A44 File Offset: 0x0031FC44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060158E8 RID: 88296 RVA: 0x00321A50 File Offset: 0x0031FC50
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
				if (num != 24U)
				{
					if (num != 48U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ActivityId = input.ReadInt32();
					}
				}
				else
				{
					this.Index = input.ReadInt32();
				}
			}
		}

		// Token: 0x040081F4 RID: 33268
		private UnknownFieldSet _unknownFields;

		// Token: 0x040081F5 RID: 33269
		public const int ActivityIdFieldNumber = 6;

		// Token: 0x040081F6 RID: 33270
		private int activityId_;

		// Token: 0x040081F7 RID: 33271
		public const int IndexFieldNumber = 3;

		// Token: 0x040081F8 RID: 33272
		private int index_;
	}
}
