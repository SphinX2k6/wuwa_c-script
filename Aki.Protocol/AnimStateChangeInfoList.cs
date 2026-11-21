using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020000F7 RID: 247
	public sealed class AnimStateChangeInfoList : IMessage<AnimStateChangeInfoList>, IMessage, IEquatable<AnimStateChangeInfoList>, IDeepCloneable<AnimStateChangeInfoList>, IBufferMessage
	{
		// Token: 0x06002356 RID: 9046 RVA: 0x0005E575 File Offset: 0x0005C775
		[NullableContext(1)]
		public static AnimStateChangeInfoList Create()
		{
			return new AnimStateChangeInfoList();
		}

		// Token: 0x17000493 RID: 1171
		// (get) Token: 0x06002357 RID: 9047 RVA: 0x0005E57C File Offset: 0x0005C77C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AnimStateChangeInfoList> Parser
		{
			get
			{
				return AnimStateChangeInfoList._parser;
			}
		}

		// Token: 0x17000494 RID: 1172
		// (get) Token: 0x06002358 RID: 9048 RVA: 0x0005E583 File Offset: 0x0005C783
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000495 RID: 1173
		// (get) Token: 0x06002359 RID: 9049 RVA: 0x0005E586 File Offset: 0x0005C786
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AnimStateChangeInfoList.Descriptor;
			}
		}

		// Token: 0x0600235A RID: 9050 RVA: 0x0005E58D File Offset: 0x0005C78D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AnimStateChangeInfoList()
		{
		}

		// Token: 0x0600235B RID: 9051 RVA: 0x0005E5A0 File Offset: 0x0005C7A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AnimStateChangeInfoList(AnimStateChangeInfoList other) : this()
		{
			this.entityId_ = other.entityId_;
			this.animStateChangeInfos_ = other.animStateChangeInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600235C RID: 9052 RVA: 0x0005E5D6 File Offset: 0x0005C7D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AnimStateChangeInfoList Clone()
		{
			return new AnimStateChangeInfoList(this);
		}

		// Token: 0x17000496 RID: 1174
		// (get) Token: 0x0600235D RID: 9053 RVA: 0x0005E5DE File Offset: 0x0005C7DE
		// (set) Token: 0x0600235E RID: 9054 RVA: 0x0005E5E6 File Offset: 0x0005C7E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EntityId
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

		// Token: 0x17000497 RID: 1175
		// (get) Token: 0x0600235F RID: 9055 RVA: 0x0005E5EF File Offset: 0x0005C7EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<AnimStateChangeInfo> AnimStateChangeInfos
		{
			get
			{
				return this.animStateChangeInfos_;
			}
		}

		// Token: 0x06002360 RID: 9056 RVA: 0x0005E5F7 File Offset: 0x0005C7F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AnimStateChangeInfoList);
		}

		// Token: 0x06002361 RID: 9057 RVA: 0x0005E608 File Offset: 0x0005C808
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AnimStateChangeInfoList other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.animStateChangeInfos_.Equals(other.animStateChangeInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002362 RID: 9058 RVA: 0x0005E658 File Offset: 0x0005C858
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			num ^= this.animStateChangeInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002363 RID: 9059 RVA: 0x0005E6A5 File Offset: 0x0005C8A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002364 RID: 9060 RVA: 0x0005E6B2 File Offset: 0x0005C8B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002365 RID: 9061 RVA: 0x0005E6BC File Offset: 0x0005C8BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.EntityId);
			}
			this.animStateChangeInfos_.WriteTo(ref output, AnimStateChangeInfoList._repeated_animStateChangeInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002366 RID: 9062 RVA: 0x0005E70C File Offset: 0x0005C90C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			num += this.animStateChangeInfos_.CalculateSize(AnimStateChangeInfoList._repeated_animStateChangeInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002367 RID: 9063 RVA: 0x0005E760 File Offset: 0x0005C960
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AnimStateChangeInfoList other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			this.animStateChangeInfos_.Add(other.animStateChangeInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002368 RID: 9064 RVA: 0x0005E7AD File Offset: 0x0005C9AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002369 RID: 9065 RVA: 0x0005E7B8 File Offset: 0x0005C9B8
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
					if (num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.animStateChangeInfos_.AddEntriesFrom(ref input, AnimStateChangeInfoList._repeated_animStateChangeInfos_codec);
					}
				}
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04002536 RID: 9526
		private static readonly MessageParser<AnimStateChangeInfoList> _parser = new MessageParser<AnimStateChangeInfoList>(() => new AnimStateChangeInfoList());

		// Token: 0x04002537 RID: 9527
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002538 RID: 9528
		public const int EntityIdFieldNumber = 1;

		// Token: 0x04002539 RID: 9529
		private long entityId_;

		// Token: 0x0400253A RID: 9530
		public const int AnimStateChangeInfosFieldNumber = 2;

		// Token: 0x0400253B RID: 9531
		private static readonly FieldCodec<AnimStateChangeInfo> _repeated_animStateChangeInfos_codec = FieldCodec.ForMessage<AnimStateChangeInfo>(18U, AnimStateChangeInfo.Parser);

		// Token: 0x0400253C RID: 9532
		private readonly RepeatedField<AnimStateChangeInfo> animStateChangeInfos_ = new RepeatedField<AnimStateChangeInfo>();
	}
}
