using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DC3 RID: 3523
	public sealed class PlayInstShareFirstInfo : IMessage<PlayInstShareFirstInfo>, IMessage, IEquatable<PlayInstShareFirstInfo>, IDeepCloneable<PlayInstShareFirstInfo>, IBufferMessage
	{
		// Token: 0x06012F8D RID: 77709 RVA: 0x002C4294 File Offset: 0x002C2494
		[NullableContext(1)]
		public static PlayInstShareFirstInfo Create()
		{
			return new PlayInstShareFirstInfo();
		}

		// Token: 0x17003EF6 RID: 16118
		// (get) Token: 0x06012F8E RID: 77710 RVA: 0x002C429B File Offset: 0x002C249B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PlayInstShareFirstInfo> Parser
		{
			get
			{
				return PlayInstShareFirstInfo._parser;
			}
		}

		// Token: 0x17003EF7 RID: 16119
		// (get) Token: 0x06012F8F RID: 77711 RVA: 0x002C42A2 File Offset: 0x002C24A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003EF8 RID: 16120
		// (get) Token: 0x06012F90 RID: 77712 RVA: 0x002C42A5 File Offset: 0x002C24A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayInstShareFirstInfo.Descriptor;
			}
		}

		// Token: 0x06012F91 RID: 77713 RVA: 0x002C42AC File Offset: 0x002C24AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayInstShareFirstInfo()
		{
		}

		// Token: 0x06012F92 RID: 77714 RVA: 0x002C42B4 File Offset: 0x002C24B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayInstShareFirstInfo(PlayInstShareFirstInfo other) : this()
		{
			this.levelPlayId_ = other.levelPlayId_;
			this.instId_ = other.instId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012F93 RID: 77715 RVA: 0x002C42E5 File Offset: 0x002C24E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayInstShareFirstInfo Clone()
		{
			return new PlayInstShareFirstInfo(this);
		}

		// Token: 0x17003EF9 RID: 16121
		// (get) Token: 0x06012F94 RID: 77716 RVA: 0x002C42ED File Offset: 0x002C24ED
		// (set) Token: 0x06012F95 RID: 77717 RVA: 0x002C42F5 File Offset: 0x002C24F5
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

		// Token: 0x17003EFA RID: 16122
		// (get) Token: 0x06012F96 RID: 77718 RVA: 0x002C42FE File Offset: 0x002C24FE
		// (set) Token: 0x06012F97 RID: 77719 RVA: 0x002C4306 File Offset: 0x002C2506
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

		// Token: 0x06012F98 RID: 77720 RVA: 0x002C430F File Offset: 0x002C250F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayInstShareFirstInfo);
		}

		// Token: 0x06012F99 RID: 77721 RVA: 0x002C431D File Offset: 0x002C251D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayInstShareFirstInfo other)
		{
			return other != null && (other == this || (this.LevelPlayId == other.LevelPlayId && this.InstId == other.InstId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012F9A RID: 77722 RVA: 0x002C435C File Offset: 0x002C255C
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

		// Token: 0x06012F9B RID: 77723 RVA: 0x002C43B4 File Offset: 0x002C25B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012F9C RID: 77724 RVA: 0x002C43C1 File Offset: 0x002C25C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012F9D RID: 77725 RVA: 0x002C43CC File Offset: 0x002C25CC
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

		// Token: 0x06012F9E RID: 77726 RVA: 0x002C4424 File Offset: 0x002C2624
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

		// Token: 0x06012F9F RID: 77727 RVA: 0x002C447C File Offset: 0x002C267C
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

		// Token: 0x06012FA0 RID: 77728 RVA: 0x002C44CC File Offset: 0x002C26CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012FA1 RID: 77729 RVA: 0x002C44D8 File Offset: 0x002C26D8
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

		// Token: 0x04007542 RID: 30018
		private static readonly MessageParser<PlayInstShareFirstInfo> _parser = new MessageParser<PlayInstShareFirstInfo>(() => new PlayInstShareFirstInfo());

		// Token: 0x04007543 RID: 30019
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007544 RID: 30020
		public const int LevelPlayIdFieldNumber = 1;

		// Token: 0x04007545 RID: 30021
		private int levelPlayId_;

		// Token: 0x04007546 RID: 30022
		public const int InstIdFieldNumber = 2;

		// Token: 0x04007547 RID: 30023
		private int instId_;
	}
}
