using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B74 RID: 2932
	public sealed class OneExploreItem : IMessage<OneExploreItem>, IMessage, IEquatable<OneExploreItem>, IDeepCloneable<OneExploreItem>, IBufferMessage
	{
		// Token: 0x0600FE7B RID: 65147 RVA: 0x002524B7 File Offset: 0x002506B7
		[NullableContext(1)]
		public static OneExploreItem Create()
		{
			return new OneExploreItem();
		}

		// Token: 0x170033F6 RID: 13302
		// (get) Token: 0x0600FE7C RID: 65148 RVA: 0x002524BE File Offset: 0x002506BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<OneExploreItem> Parser
		{
			get
			{
				return OneExploreItem._parser;
			}
		}

		// Token: 0x170033F7 RID: 13303
		// (get) Token: 0x0600FE7D RID: 65149 RVA: 0x002524C5 File Offset: 0x002506C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170033F8 RID: 13304
		// (get) Token: 0x0600FE7E RID: 65150 RVA: 0x002524C8 File Offset: 0x002506C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return OneExploreItem.Descriptor;
			}
		}

		// Token: 0x0600FE7F RID: 65151 RVA: 0x002524CF File Offset: 0x002506CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OneExploreItem()
		{
		}

		// Token: 0x0600FE80 RID: 65152 RVA: 0x002524D8 File Offset: 0x002506D8
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

		// Token: 0x0600FE81 RID: 65153 RVA: 0x00252538 File Offset: 0x00250738
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OneExploreItem Clone()
		{
			return new OneExploreItem(this);
		}

		// Token: 0x170033F9 RID: 13305
		// (get) Token: 0x0600FE82 RID: 65154 RVA: 0x00252540 File Offset: 0x00250740
		// (set) Token: 0x0600FE83 RID: 65155 RVA: 0x00252548 File Offset: 0x00250748
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

		// Token: 0x170033FA RID: 13306
		// (get) Token: 0x0600FE84 RID: 65156 RVA: 0x00252551 File Offset: 0x00250751
		// (set) Token: 0x0600FE85 RID: 65157 RVA: 0x00252559 File Offset: 0x00250759
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

		// Token: 0x170033FB RID: 13307
		// (get) Token: 0x0600FE86 RID: 65158 RVA: 0x00252562 File Offset: 0x00250762
		// (set) Token: 0x0600FE87 RID: 65159 RVA: 0x0025256A File Offset: 0x0025076A
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

		// Token: 0x170033FC RID: 13308
		// (get) Token: 0x0600FE88 RID: 65160 RVA: 0x00252573 File Offset: 0x00250773
		// (set) Token: 0x0600FE89 RID: 65161 RVA: 0x0025257B File Offset: 0x0025077B
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

		// Token: 0x170033FD RID: 13309
		// (get) Token: 0x0600FE8A RID: 65162 RVA: 0x00252584 File Offset: 0x00250784
		// (set) Token: 0x0600FE8B RID: 65163 RVA: 0x0025258C File Offset: 0x0025078C
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

		// Token: 0x0600FE8C RID: 65164 RVA: 0x00252595 File Offset: 0x00250795
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as OneExploreItem);
		}

		// Token: 0x0600FE8D RID: 65165 RVA: 0x002525A4 File Offset: 0x002507A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(OneExploreItem other)
		{
			return other != null && (other == this || (this.ExploreProgressId == other.ExploreProgressId && this.ExplorePercent == other.ExplorePercent && this.CurCount == other.CurCount && this.TotalCount == other.TotalCount && this.UnLock == other.UnLock && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600FE8E RID: 65166 RVA: 0x00252620 File Offset: 0x00250820
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

		// Token: 0x0600FE8F RID: 65167 RVA: 0x002526C3 File Offset: 0x002508C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600FE90 RID: 65168 RVA: 0x002526D0 File Offset: 0x002508D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600FE91 RID: 65169 RVA: 0x002526DC File Offset: 0x002508DC
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

		// Token: 0x0600FE92 RID: 65170 RVA: 0x00252788 File Offset: 0x00250988
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

		// Token: 0x0600FE93 RID: 65171 RVA: 0x0025281C File Offset: 0x00250A1C
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

		// Token: 0x0600FE94 RID: 65172 RVA: 0x002528A8 File Offset: 0x00250AA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600FE95 RID: 65173 RVA: 0x002528B4 File Offset: 0x00250AB4
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

		// Token: 0x040065D7 RID: 26071
		private static readonly MessageParser<OneExploreItem> _parser = new MessageParser<OneExploreItem>(() => new OneExploreItem());

		// Token: 0x040065D8 RID: 26072
		private UnknownFieldSet _unknownFields;

		// Token: 0x040065D9 RID: 26073
		public const int ExploreProgressIdFieldNumber = 1;

		// Token: 0x040065DA RID: 26074
		private int exploreProgressId_;

		// Token: 0x040065DB RID: 26075
		public const int ExplorePercentFieldNumber = 2;

		// Token: 0x040065DC RID: 26076
		private int explorePercent_;

		// Token: 0x040065DD RID: 26077
		public const int CurCountFieldNumber = 3;

		// Token: 0x040065DE RID: 26078
		private int curCount_;

		// Token: 0x040065DF RID: 26079
		public const int TotalCountFieldNumber = 4;

		// Token: 0x040065E0 RID: 26080
		private int totalCount_;

		// Token: 0x040065E1 RID: 26081
		public const int UnLockFieldNumber = 5;

		// Token: 0x040065E2 RID: 26082
		private bool unLock_;
	}
}
