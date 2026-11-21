using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200021F RID: 543
	public sealed class CalabashDevelopConditionState : IMessage<CalabashDevelopConditionState>, IMessage, IEquatable<CalabashDevelopConditionState>, IDeepCloneable<CalabashDevelopConditionState>, IBufferMessage
	{
		// Token: 0x06003B96 RID: 15254 RVA: 0x0009490C File Offset: 0x00092B0C
		[NullableContext(1)]
		public static CalabashDevelopConditionState Create()
		{
			return new CalabashDevelopConditionState();
		}

		// Token: 0x170009DB RID: 2523
		// (get) Token: 0x06003B97 RID: 15255 RVA: 0x00094913 File Offset: 0x00092B13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<CalabashDevelopConditionState> Parser
		{
			get
			{
				return CalabashDevelopConditionState._parser;
			}
		}

		// Token: 0x170009DC RID: 2524
		// (get) Token: 0x06003B98 RID: 15256 RVA: 0x0009491A File Offset: 0x00092B1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170009DD RID: 2525
		// (get) Token: 0x06003B99 RID: 15257 RVA: 0x0009491D File Offset: 0x00092B1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CalabashDevelopConditionState.Descriptor;
			}
		}

		// Token: 0x06003B9A RID: 15258 RVA: 0x00094924 File Offset: 0x00092B24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CalabashDevelopConditionState()
		{
		}

		// Token: 0x06003B9B RID: 15259 RVA: 0x0009492C File Offset: 0x00092B2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CalabashDevelopConditionState(CalabashDevelopConditionState other) : this()
		{
			this.conditionId_ = other.conditionId_;
			this.rewarded_ = other.rewarded_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003B9C RID: 15260 RVA: 0x0009495D File Offset: 0x00092B5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CalabashDevelopConditionState Clone()
		{
			return new CalabashDevelopConditionState(this);
		}

		// Token: 0x170009DE RID: 2526
		// (get) Token: 0x06003B9D RID: 15261 RVA: 0x00094965 File Offset: 0x00092B65
		// (set) Token: 0x06003B9E RID: 15262 RVA: 0x0009496D File Offset: 0x00092B6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ConditionId
		{
			get
			{
				return this.conditionId_;
			}
			set
			{
				this.conditionId_ = value;
			}
		}

		// Token: 0x170009DF RID: 2527
		// (get) Token: 0x06003B9F RID: 15263 RVA: 0x00094976 File Offset: 0x00092B76
		// (set) Token: 0x06003BA0 RID: 15264 RVA: 0x0009497E File Offset: 0x00092B7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Rewarded
		{
			get
			{
				return this.rewarded_;
			}
			set
			{
				this.rewarded_ = value;
			}
		}

		// Token: 0x06003BA1 RID: 15265 RVA: 0x00094987 File Offset: 0x00092B87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CalabashDevelopConditionState);
		}

		// Token: 0x06003BA2 RID: 15266 RVA: 0x00094995 File Offset: 0x00092B95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CalabashDevelopConditionState other)
		{
			return other != null && (other == this || (this.ConditionId == other.ConditionId && this.Rewarded == other.Rewarded && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003BA3 RID: 15267 RVA: 0x000949D4 File Offset: 0x00092BD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ConditionId != 0)
			{
				num ^= this.ConditionId.GetHashCode();
			}
			if (this.Rewarded)
			{
				num ^= this.Rewarded.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003BA4 RID: 15268 RVA: 0x00094A2C File Offset: 0x00092C2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003BA5 RID: 15269 RVA: 0x00094A39 File Offset: 0x00092C39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003BA6 RID: 15270 RVA: 0x00094A44 File Offset: 0x00092C44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ConditionId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ConditionId);
			}
			if (this.Rewarded)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.Rewarded);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003BA7 RID: 15271 RVA: 0x00094A9C File Offset: 0x00092C9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ConditionId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ConditionId);
			}
			if (this.Rewarded)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003BA8 RID: 15272 RVA: 0x00094AE8 File Offset: 0x00092CE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CalabashDevelopConditionState other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ConditionId != 0)
			{
				this.ConditionId = other.ConditionId;
			}
			if (other.Rewarded)
			{
				this.Rewarded = other.Rewarded;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003BA9 RID: 15273 RVA: 0x00094B38 File Offset: 0x00092D38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003BAA RID: 15274 RVA: 0x00094B44 File Offset: 0x00092D44
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
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Rewarded = input.ReadBool();
					}
				}
				else
				{
					this.ConditionId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04002C84 RID: 11396
		private static readonly MessageParser<CalabashDevelopConditionState> _parser = new MessageParser<CalabashDevelopConditionState>(() => new CalabashDevelopConditionState());

		// Token: 0x04002C85 RID: 11397
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002C86 RID: 11398
		public const int ConditionIdFieldNumber = 1;

		// Token: 0x04002C87 RID: 11399
		private int conditionId_;

		// Token: 0x04002C88 RID: 11400
		public const int RewardedFieldNumber = 2;

		// Token: 0x04002C89 RID: 11401
		private bool rewarded_;
	}
}
