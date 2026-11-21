using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DB3 RID: 3507
	public sealed class PlayInstShareFirstInfo : IMessage<PlayInstShareFirstInfo>, IMessage, IEquatable<PlayInstShareFirstInfo>, IDeepCloneable<PlayInstShareFirstInfo>, IBufferMessage
	{
		// Token: 0x06012E91 RID: 77457 RVA: 0x002C2670 File Offset: 0x002C0870
		[NullableContext(1)]
		public static PlayInstShareFirstInfo Create()
		{
			return new PlayInstShareFirstInfo();
		}

		// Token: 0x17003EC1 RID: 16065
		// (get) Token: 0x06012E92 RID: 77458 RVA: 0x002C2677 File Offset: 0x002C0877
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PlayInstShareFirstInfo> Parser
		{
			get
			{
				return PlayInstShareFirstInfo._parser;
			}
		}

		// Token: 0x17003EC2 RID: 16066
		// (get) Token: 0x06012E93 RID: 77459 RVA: 0x002C267E File Offset: 0x002C087E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003EC3 RID: 16067
		// (get) Token: 0x06012E94 RID: 77460 RVA: 0x002C2681 File Offset: 0x002C0881
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayInstShareFirstInfo.Descriptor;
			}
		}

		// Token: 0x06012E95 RID: 77461 RVA: 0x002C2688 File Offset: 0x002C0888
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayInstShareFirstInfo()
		{
		}

		// Token: 0x06012E96 RID: 77462 RVA: 0x002C2690 File Offset: 0x002C0890
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayInstShareFirstInfo(PlayInstShareFirstInfo other) : this()
		{
			this.levelPlayId_ = other.levelPlayId_;
			this.instId_ = other.instId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012E97 RID: 77463 RVA: 0x002C26C1 File Offset: 0x002C08C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayInstShareFirstInfo Clone()
		{
			return new PlayInstShareFirstInfo(this);
		}

		// Token: 0x17003EC4 RID: 16068
		// (get) Token: 0x06012E98 RID: 77464 RVA: 0x002C26C9 File Offset: 0x002C08C9
		// (set) Token: 0x06012E99 RID: 77465 RVA: 0x002C26D1 File Offset: 0x002C08D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LevelPlayId
		{
			get
			{
				return this.levelPlayId_;
			}
			set
			{
				this.levelPlayId_ = value;
			}
		}

		// Token: 0x17003EC5 RID: 16069
		// (get) Token: 0x06012E9A RID: 77466 RVA: 0x002C26DA File Offset: 0x002C08DA
		// (set) Token: 0x06012E9B RID: 77467 RVA: 0x002C26E2 File Offset: 0x002C08E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int InstId
		{
			get
			{
				return this.instId_;
			}
			set
			{
				this.instId_ = value;
			}
		}

		// Token: 0x06012E9C RID: 77468 RVA: 0x002C26EB File Offset: 0x002C08EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayInstShareFirstInfo);
		}

		// Token: 0x06012E9D RID: 77469 RVA: 0x002C26F9 File Offset: 0x002C08F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayInstShareFirstInfo other)
		{
			return other != null && (other == this || (this.LevelPlayId == other.LevelPlayId && this.InstId == other.InstId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012E9E RID: 77470 RVA: 0x002C2738 File Offset: 0x002C0938
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.LevelPlayId != 0)
			{
				num ^= this.LevelPlayId.GetHashCode();
			}
			if (this.InstId != 0)
			{
				num ^= this.InstId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06012E9F RID: 77471 RVA: 0x002C2790 File Offset: 0x002C0990
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012EA0 RID: 77472 RVA: 0x002C279D File Offset: 0x002C099D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012EA1 RID: 77473 RVA: 0x002C27A8 File Offset: 0x002C09A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LevelPlayId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.LevelPlayId);
			}
			if (this.InstId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.InstId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012EA2 RID: 77474 RVA: 0x002C2800 File Offset: 0x002C0A00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.LevelPlayId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LevelPlayId);
			}
			if (this.InstId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.InstId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06012EA3 RID: 77475 RVA: 0x002C2858 File Offset: 0x002C0A58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PlayInstShareFirstInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.LevelPlayId != 0)
			{
				this.LevelPlayId = other.LevelPlayId;
			}
			if (other.InstId != 0)
			{
				this.InstId = other.InstId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06012EA4 RID: 77476 RVA: 0x002C28A8 File Offset: 0x002C0AA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012EA5 RID: 77477 RVA: 0x002C28B4 File Offset: 0x002C0AB4
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
						this.InstId = input.ReadInt32();
					}
				}
				else
				{
					this.LevelPlayId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400755A RID: 30042
		private static readonly MessageParser<PlayInstShareFirstInfo> _parser = new MessageParser<PlayInstShareFirstInfo>(() => new PlayInstShareFirstInfo());

		// Token: 0x0400755B RID: 30043
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400755C RID: 30044
		public const int LevelPlayIdFieldNumber = 1;

		// Token: 0x0400755D RID: 30045
		private int levelPlayId_;

		// Token: 0x0400755E RID: 30046
		public const int InstIdFieldNumber = 2;

		// Token: 0x0400755F RID: 30047
		private int instId_;
	}
}
