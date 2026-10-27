using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B84 RID: 2948
	public sealed class OneExploreItem : IMessage<OneExploreItem>, IMessage, IEquatable<OneExploreItem>, IDeepCloneable<OneExploreItem>, IBufferMessage
	{
		// Token: 0x0600FF7F RID: 65407 RVA: 0x00254387 File Offset: 0x00252587
		[NullableContext(1)]
		public static OneExploreItem Create()
		{
			return new OneExploreItem();
		}

		// Token: 0x1700342F RID: 13359
		// (get) Token: 0x0600FF80 RID: 65408 RVA: 0x0025438E File Offset: 0x0025258E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<OneExploreItem> Parser
		{
			get
			{
				return OneExploreItem._parser;
			}
		}

		// Token: 0x17003430 RID: 13360
		// (get) Token: 0x0600FF81 RID: 65409 RVA: 0x00254395 File Offset: 0x00252595
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003431 RID: 13361
		// (get) Token: 0x0600FF82 RID: 65410 RVA: 0x00254398 File Offset: 0x00252598
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return OneExploreItem.Descriptor;
			}
		}

		// Token: 0x0600FF83 RID: 65411 RVA: 0x0025439F File Offset: 0x0025259F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OneExploreItem()
		{
		}

		// Token: 0x0600FF84 RID: 65412 RVA: 0x002543A8 File Offset: 0x002525A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OneExploreItem(OneExploreItem other) : this()
		{
			this.exploreProgressId_ = other.exploreProgressId_;
			this.explorePercent_ = other.explorePercent_;
			this.curCount_ = other.curCount_;
			this.totalCount_ = other.totalCount_;
			this.unLock_ = other.unLock_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600FF85 RID: 65413 RVA: 0x00254408 File Offset: 0x00252608
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OneExploreItem Clone()
		{
			return new OneExploreItem(this);
		}

		// Token: 0x17003432 RID: 13362
		// (get) Token: 0x0600FF86 RID: 65414 RVA: 0x00254410 File Offset: 0x00252610
		// (set) Token: 0x0600FF87 RID: 65415 RVA: 0x00254418 File Offset: 0x00252618
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ExploreProgressId
		{
			get
			{
				return this.exploreProgressId_;
			}
			set
			{
				this.exploreProgressId_ = value;
			}
		}

		// Token: 0x17003433 RID: 13363
		// (get) Token: 0x0600FF88 RID: 65416 RVA: 0x00254421 File Offset: 0x00252621
		// (set) Token: 0x0600FF89 RID: 65417 RVA: 0x00254429 File Offset: 0x00252629
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ExplorePercent
		{
			get
			{
				return this.explorePercent_;
			}
			set
			{
				this.explorePercent_ = value;
			}
		}

		// Token: 0x17003434 RID: 13364
		// (get) Token: 0x0600FF8A RID: 65418 RVA: 0x00254432 File Offset: 0x00252632
		// (set) Token: 0x0600FF8B RID: 65419 RVA: 0x0025443A File Offset: 0x0025263A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CurCount
		{
			get
			{
				return this.curCount_;
			}
			set
			{
				this.curCount_ = value;
			}
		}

		// Token: 0x17003435 RID: 13365
		// (get) Token: 0x0600FF8C RID: 65420 RVA: 0x00254443 File Offset: 0x00252643
		// (set) Token: 0x0600FF8D RID: 65421 RVA: 0x0025444B File Offset: 0x0025264B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TotalCount
		{
			get
			{
				return this.totalCount_;
			}
			set
			{
				this.totalCount_ = value;
			}
		}

		// Token: 0x17003436 RID: 13366
		// (get) Token: 0x0600FF8E RID: 65422 RVA: 0x00254454 File Offset: 0x00252654
		// (set) Token: 0x0600FF8F RID: 65423 RVA: 0x0025445C File Offset: 0x0025265C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool UnLock
		{
			get
			{
				return this.unLock_;
			}
			set
			{
				this.unLock_ = value;
			}
		}

		// Token: 0x0600FF90 RID: 65424 RVA: 0x00254465 File Offset: 0x00252665
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as OneExploreItem);
		}

		// Token: 0x0600FF91 RID: 65425 RVA: 0x00254474 File Offset: 0x00252674
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(OneExploreItem other)
		{
			return other != null && (other == this || (this.ExploreProgressId == other.ExploreProgressId && this.ExplorePercent == other.ExplorePercent && this.CurCount == other.CurCount && this.TotalCount == other.TotalCount && this.UnLock == other.UnLock && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600FF92 RID: 65426 RVA: 0x002544F0 File Offset: 0x002526F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ExploreProgressId != 0)
			{
				num ^= this.ExploreProgressId.GetHashCode();
			}
			if (this.ExplorePercent != 0)
			{
				num ^= this.ExplorePercent.GetHashCode();
			}
			if (this.CurCount != 0)
			{
				num ^= this.CurCount.GetHashCode();
			}
			if (this.TotalCount != 0)
			{
				num ^= this.TotalCount.GetHashCode();
			}
			if (this.UnLock)
			{
				num ^= this.UnLock.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600FF93 RID: 65427 RVA: 0x00254593 File Offset: 0x00252793
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600FF94 RID: 65428 RVA: 0x002545A0 File Offset: 0x002527A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600FF95 RID: 65429 RVA: 0x002545AC File Offset: 0x002527AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ExploreProgressId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ExploreProgressId);
			}
			if (this.ExplorePercent != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.ExplorePercent);
			}
			if (this.CurCount != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.CurCount);
			}
			if (this.TotalCount != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.TotalCount);
			}
			if (this.UnLock)
			{
				output.WriteRawTag(40);
				output.WriteBool(this.UnLock);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600FF96 RID: 65430 RVA: 0x00254658 File Offset: 0x00252858
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ExploreProgressId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ExploreProgressId);
			}
			if (this.ExplorePercent != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ExplorePercent);
			}
			if (this.CurCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CurCount);
			}
			if (this.TotalCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TotalCount);
			}
			if (this.UnLock)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600FF97 RID: 65431 RVA: 0x002546EC File Offset: 0x002528EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(OneExploreItem other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ExploreProgressId != 0)
			{
				this.ExploreProgressId = other.ExploreProgressId;
			}
			if (other.ExplorePercent != 0)
			{
				this.ExplorePercent = other.ExplorePercent;
			}
			if (other.CurCount != 0)
			{
				this.CurCount = other.CurCount;
			}
			if (other.TotalCount != 0)
			{
				this.TotalCount = other.TotalCount;
			}
			if (other.UnLock)
			{
				this.UnLock = other.UnLock;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600FF98 RID: 65432 RVA: 0x00254778 File Offset: 0x00252978
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600FF99 RID: 65433 RVA: 0x00254784 File Offset: 0x00252984
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
						this.ExploreProgressId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.ExplorePercent = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.CurCount = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.TotalCount = input.ReadInt32();
						continue;
					}
					if (num == 40U)
					{
						this.UnLock = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040065C7 RID: 26055
		private static readonly MessageParser<OneExploreItem> _parser = new MessageParser<OneExploreItem>(() => new OneExploreItem());

		// Token: 0x040065C8 RID: 26056
		private UnknownFieldSet _unknownFields;

		// Token: 0x040065C9 RID: 26057
		public const int ExploreProgressIdFieldNumber = 1;

		// Token: 0x040065CA RID: 26058
		private int exploreProgressId_;

		// Token: 0x040065CB RID: 26059
		public const int ExplorePercentFieldNumber = 2;

		// Token: 0x040065CC RID: 26060
		private int explorePercent_;

		// Token: 0x040065CD RID: 26061
		public const int CurCountFieldNumber = 3;

		// Token: 0x040065CE RID: 26062
		private int curCount_;

		// Token: 0x040065CF RID: 26063
		public const int TotalCountFieldNumber = 4;

		// Token: 0x040065D0 RID: 26064
		private int totalCount_;

		// Token: 0x040065D1 RID: 26065
		public const int UnLockFieldNumber = 5;

		// Token: 0x040065D2 RID: 26066
		private bool unLock_;
	}
}
