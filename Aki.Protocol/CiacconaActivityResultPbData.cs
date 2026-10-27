using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200028D RID: 653
	public sealed class CiacconaActivityResultPbData : IMessage<CiacconaActivityResultPbData>, IMessage, IEquatable<CiacconaActivityResultPbData>, IDeepCloneable<CiacconaActivityResultPbData>, IBufferMessage
	{
		// Token: 0x0600442C RID: 17452 RVA: 0x000A754F File Offset: 0x000A574F
		[NullableContext(1)]
		public static CiacconaActivityResultPbData Create()
		{
			return new CiacconaActivityResultPbData();
		}

		// Token: 0x17000BAA RID: 2986
		// (get) Token: 0x0600442D RID: 17453 RVA: 0x000A7556 File Offset: 0x000A5756
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<CiacconaActivityResultPbData> Parser
		{
			get
			{
				return CiacconaActivityResultPbData._parser;
			}
		}

		// Token: 0x17000BAB RID: 2987
		// (get) Token: 0x0600442E RID: 17454 RVA: 0x000A755D File Offset: 0x000A575D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000BAC RID: 2988
		// (get) Token: 0x0600442F RID: 17455 RVA: 0x000A7560 File Offset: 0x000A5760
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CiacconaActivityResultPbData.Descriptor;
			}
		}

		// Token: 0x06004430 RID: 17456 RVA: 0x000A7567 File Offset: 0x000A5767
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CiacconaActivityResultPbData()
		{
		}

		// Token: 0x06004431 RID: 17457 RVA: 0x000A756F File Offset: 0x000A576F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CiacconaActivityResultPbData(CiacconaActivityResultPbData other) : this()
		{
			this.resultId_ = other.resultId_;
			this.takeReward_ = other.takeReward_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004432 RID: 17458 RVA: 0x000A75A0 File Offset: 0x000A57A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CiacconaActivityResultPbData Clone()
		{
			return new CiacconaActivityResultPbData(this);
		}

		// Token: 0x17000BAD RID: 2989
		// (get) Token: 0x06004433 RID: 17459 RVA: 0x000A75A8 File Offset: 0x000A57A8
		// (set) Token: 0x06004434 RID: 17460 RVA: 0x000A75B0 File Offset: 0x000A57B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ResultId
		{
			get
			{
				return this.resultId_;
			}
			set
			{
				this.resultId_ = value;
			}
		}

		// Token: 0x17000BAE RID: 2990
		// (get) Token: 0x06004435 RID: 17461 RVA: 0x000A75B9 File Offset: 0x000A57B9
		// (set) Token: 0x06004436 RID: 17462 RVA: 0x000A75C1 File Offset: 0x000A57C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool TakeReward
		{
			get
			{
				return this.takeReward_;
			}
			set
			{
				this.takeReward_ = value;
			}
		}

		// Token: 0x06004437 RID: 17463 RVA: 0x000A75CA File Offset: 0x000A57CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CiacconaActivityResultPbData);
		}

		// Token: 0x06004438 RID: 17464 RVA: 0x000A75D8 File Offset: 0x000A57D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CiacconaActivityResultPbData other)
		{
			return other != null && (other == this || (this.ResultId == other.ResultId && this.TakeReward == other.TakeReward && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004439 RID: 17465 RVA: 0x000A7618 File Offset: 0x000A5818
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ResultId != 0)
			{
				num ^= this.ResultId.GetHashCode();
			}
			if (this.TakeReward)
			{
				num ^= this.TakeReward.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600443A RID: 17466 RVA: 0x000A7670 File Offset: 0x000A5870
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600443B RID: 17467 RVA: 0x000A767D File Offset: 0x000A587D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600443C RID: 17468 RVA: 0x000A7688 File Offset: 0x000A5888
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ResultId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ResultId);
			}
			if (this.TakeReward)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.TakeReward);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600443D RID: 17469 RVA: 0x000A76E0 File Offset: 0x000A58E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ResultId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ResultId);
			}
			if (this.TakeReward)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600443E RID: 17470 RVA: 0x000A772C File Offset: 0x000A592C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CiacconaActivityResultPbData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ResultId != 0)
			{
				this.ResultId = other.ResultId;
			}
			if (other.TakeReward)
			{
				this.TakeReward = other.TakeReward;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600443F RID: 17471 RVA: 0x000A777C File Offset: 0x000A597C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004440 RID: 17472 RVA: 0x000A7788 File Offset: 0x000A5988
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
						this.TakeReward = input.ReadBool();
					}
				}
				else
				{
					this.ResultId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04002E8A RID: 11914
		private static readonly MessageParser<CiacconaActivityResultPbData> _parser = new MessageParser<CiacconaActivityResultPbData>(() => new CiacconaActivityResultPbData());

		// Token: 0x04002E8B RID: 11915
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002E8C RID: 11916
		public const int ResultIdFieldNumber = 1;

		// Token: 0x04002E8D RID: 11917
		private int resultId_;

		// Token: 0x04002E8E RID: 11918
		public const int TakeRewardFieldNumber = 2;

		// Token: 0x04002E8F RID: 11919
		private bool takeReward_;
	}
}
