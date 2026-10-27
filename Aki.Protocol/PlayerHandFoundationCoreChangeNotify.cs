using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D92 RID: 3474
	[NetMessage(EMessageId.PlayerHandFoundationCoreChangeNotify)]
	public sealed class PlayerHandFoundationCoreChangeNotify : IMessage<PlayerHandFoundationCoreChangeNotify>, IMessage, IEquatable<PlayerHandFoundationCoreChangeNotify>, IDeepCloneable<PlayerHandFoundationCoreChangeNotify>, IBufferMessage
	{
		// Token: 0x06012BB8 RID: 76728 RVA: 0x002BBF96 File Offset: 0x002BA196
		[NullableContext(1)]
		public static PlayerHandFoundationCoreChangeNotify Create()
		{
			return new PlayerHandFoundationCoreChangeNotify();
		}

		// Token: 0x17003E2D RID: 15917
		// (get) Token: 0x06012BB9 RID: 76729 RVA: 0x002BBF9D File Offset: 0x002BA19D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003E2E RID: 15918
		// (get) Token: 0x06012BBA RID: 76730 RVA: 0x002BBFA0 File Offset: 0x002BA1A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerHandFoundationCoreChangeNotify.Descriptor;
			}
		}

		// Token: 0x06012BBB RID: 76731 RVA: 0x002BBFA7 File Offset: 0x002BA1A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerHandFoundationCoreChangeNotify()
		{
		}

		// Token: 0x06012BBC RID: 76732 RVA: 0x002BBFB0 File Offset: 0x002BA1B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerHandFoundationCoreChangeNotify(PlayerHandFoundationCoreChangeNotify other) : this()
		{
			this.fromFoundationEntityId_ = other.fromFoundationEntityId_;
			this.foundationCoreInfo_ = ((other.foundationCoreInfo_ != null) ? other.foundationCoreInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012BBD RID: 76733 RVA: 0x002BBFFC File Offset: 0x002BA1FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerHandFoundationCoreChangeNotify Clone()
		{
			return new PlayerHandFoundationCoreChangeNotify(this);
		}

		// Token: 0x17003E2F RID: 15919
		// (get) Token: 0x06012BBE RID: 76734 RVA: 0x002BC004 File Offset: 0x002BA204
		// (set) Token: 0x06012BBF RID: 76735 RVA: 0x002BC00C File Offset: 0x002BA20C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int FromFoundationEntityId
		{
			get
			{
				return this.fromFoundationEntityId_;
			}
			set
			{
				this.fromFoundationEntityId_ = value;
			}
		}

		// Token: 0x17003E30 RID: 15920
		// (get) Token: 0x06012BC0 RID: 76736 RVA: 0x002BC015 File Offset: 0x002BA215
		// (set) Token: 0x06012BC1 RID: 76737 RVA: 0x002BC01D File Offset: 0x002BA21D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FoundationCoreInfo FoundationCoreInfo
		{
			get
			{
				return this.foundationCoreInfo_;
			}
			set
			{
				this.foundationCoreInfo_ = value;
			}
		}

		// Token: 0x06012BC2 RID: 76738 RVA: 0x002BC026 File Offset: 0x002BA226
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerHandFoundationCoreChangeNotify);
		}

		// Token: 0x06012BC3 RID: 76739 RVA: 0x002BC034 File Offset: 0x002BA234
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerHandFoundationCoreChangeNotify other)
		{
			return other != null && (other == this || (this.FromFoundationEntityId == other.FromFoundationEntityId && object.Equals(this.FoundationCoreInfo, other.FoundationCoreInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012BC4 RID: 76740 RVA: 0x002BC084 File Offset: 0x002BA284
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.FromFoundationEntityId != 0)
			{
				num ^= this.FromFoundationEntityId.GetHashCode();
			}
			if (this.foundationCoreInfo_ != null)
			{
				num ^= this.FoundationCoreInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06012BC5 RID: 76741 RVA: 0x002BC0D9 File Offset: 0x002BA2D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012BC6 RID: 76742 RVA: 0x002BC0E6 File Offset: 0x002BA2E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012BC7 RID: 76743 RVA: 0x002BC0F0 File Offset: 0x002BA2F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.foundationCoreInfo_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.FoundationCoreInfo);
			}
			if (this.FromFoundationEntityId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.FromFoundationEntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012BC8 RID: 76744 RVA: 0x002BC14C File Offset: 0x002BA34C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.FromFoundationEntityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FromFoundationEntityId);
			}
			if (this.foundationCoreInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.FoundationCoreInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06012BC9 RID: 76745 RVA: 0x002BC1A4 File Offset: 0x002BA3A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PlayerHandFoundationCoreChangeNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.FromFoundationEntityId != 0)
			{
				this.FromFoundationEntityId = other.FromFoundationEntityId;
			}
			if (other.foundationCoreInfo_ != null)
			{
				if (this.foundationCoreInfo_ == null)
				{
					this.FoundationCoreInfo = new FoundationCoreInfo();
				}
				this.FoundationCoreInfo.MergeFrom(other.FoundationCoreInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06012BCA RID: 76746 RVA: 0x002BC20C File Offset: 0x002BA40C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012BCB RID: 76747 RVA: 0x002BC218 File Offset: 0x002BA418
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
				if (num != 42U)
				{
					if (num != 56U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.FromFoundationEntityId = input.ReadInt32();
					}
				}
				else
				{
					if (this.foundationCoreInfo_ == null)
					{
						this.FoundationCoreInfo = new FoundationCoreInfo();
					}
					input.ReadMessage(this.FoundationCoreInfo);
				}
			}
		}

		// Token: 0x04007431 RID: 29745
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007432 RID: 29746
		public const int FromFoundationEntityIdFieldNumber = 7;

		// Token: 0x04007433 RID: 29747
		private int fromFoundationEntityId_;

		// Token: 0x04007434 RID: 29748
		public const int FoundationCoreInfoFieldNumber = 5;

		// Token: 0x04007435 RID: 29749
		private FoundationCoreInfo foundationCoreInfo_;
	}
}
