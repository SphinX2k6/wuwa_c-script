using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000756 RID: 1878
	public sealed class HonamiStoryBagItemInfo : IMessage<HonamiStoryBagItemInfo>, IMessage, IEquatable<HonamiStoryBagItemInfo>, IDeepCloneable<HonamiStoryBagItemInfo>, IBufferMessage
	{
		// Token: 0x0600AA56 RID: 43606 RVA: 0x0019A4D1 File Offset: 0x001986D1
		[NullableContext(1)]
		public static HonamiStoryBagItemInfo Create()
		{
			return new HonamiStoryBagItemInfo();
		}

		// Token: 0x1700224F RID: 8783
		// (get) Token: 0x0600AA57 RID: 43607 RVA: 0x0019A4D8 File Offset: 0x001986D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<HonamiStoryBagItemInfo> Parser
		{
			get
			{
				return HonamiStoryBagItemInfo._parser;
			}
		}

		// Token: 0x17002250 RID: 8784
		// (get) Token: 0x0600AA58 RID: 43608 RVA: 0x0019A4DF File Offset: 0x001986DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002251 RID: 8785
		// (get) Token: 0x0600AA59 RID: 43609 RVA: 0x0019A4E2 File Offset: 0x001986E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HonamiStoryBagItemInfo.Descriptor;
			}
		}

		// Token: 0x0600AA5A RID: 43610 RVA: 0x0019A4E9 File Offset: 0x001986E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryBagItemInfo()
		{
		}

		// Token: 0x0600AA5B RID: 43611 RVA: 0x0019A4F4 File Offset: 0x001986F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryBagItemInfo(HonamiStoryBagItemInfo other) : this()
		{
			this.honamiStoryItemInfo_ = ((other.honamiStoryItemInfo_ != null) ? other.honamiStoryItemInfo_.Clone() : null);
			this.honamiStoryPosInfo_ = ((other.honamiStoryPosInfo_ != null) ? other.honamiStoryPosInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AA5C RID: 43612 RVA: 0x0019A550 File Offset: 0x00198750
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryBagItemInfo Clone()
		{
			return new HonamiStoryBagItemInfo(this);
		}

		// Token: 0x17002252 RID: 8786
		// (get) Token: 0x0600AA5D RID: 43613 RVA: 0x0019A558 File Offset: 0x00198758
		// (set) Token: 0x0600AA5E RID: 43614 RVA: 0x0019A560 File Offset: 0x00198760
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryItemInfo HonamiStoryItemInfo
		{
			get
			{
				return this.honamiStoryItemInfo_;
			}
			set
			{
				this.honamiStoryItemInfo_ = value;
			}
		}

		// Token: 0x17002253 RID: 8787
		// (get) Token: 0x0600AA5F RID: 43615 RVA: 0x0019A569 File Offset: 0x00198769
		// (set) Token: 0x0600AA60 RID: 43616 RVA: 0x0019A571 File Offset: 0x00198771
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryPosInfo HonamiStoryPosInfo
		{
			get
			{
				return this.honamiStoryPosInfo_;
			}
			set
			{
				this.honamiStoryPosInfo_ = value;
			}
		}

		// Token: 0x0600AA61 RID: 43617 RVA: 0x0019A57A File Offset: 0x0019877A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HonamiStoryBagItemInfo);
		}

		// Token: 0x0600AA62 RID: 43618 RVA: 0x0019A588 File Offset: 0x00198788
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HonamiStoryBagItemInfo other)
		{
			return other != null && (other == this || (object.Equals(this.HonamiStoryItemInfo, other.HonamiStoryItemInfo) && object.Equals(this.HonamiStoryPosInfo, other.HonamiStoryPosInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600AA63 RID: 43619 RVA: 0x0019A5DC File Offset: 0x001987DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.honamiStoryItemInfo_ != null)
			{
				num ^= this.HonamiStoryItemInfo.GetHashCode();
			}
			if (this.honamiStoryPosInfo_ != null)
			{
				num ^= this.HonamiStoryPosInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600AA64 RID: 43620 RVA: 0x0019A62E File Offset: 0x0019882E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600AA65 RID: 43621 RVA: 0x0019A63B File Offset: 0x0019883B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AA66 RID: 43622 RVA: 0x0019A644 File Offset: 0x00198844
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.honamiStoryItemInfo_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.HonamiStoryItemInfo);
			}
			if (this.honamiStoryPosInfo_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.HonamiStoryPosInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AA67 RID: 43623 RVA: 0x0019A6A0 File Offset: 0x001988A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.honamiStoryItemInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.HonamiStoryItemInfo);
			}
			if (this.honamiStoryPosInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.HonamiStoryPosInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600AA68 RID: 43624 RVA: 0x0019A6F8 File Offset: 0x001988F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HonamiStoryBagItemInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.honamiStoryItemInfo_ != null)
			{
				if (this.honamiStoryItemInfo_ == null)
				{
					this.HonamiStoryItemInfo = new HonamiStoryItemInfo();
				}
				this.HonamiStoryItemInfo.MergeFrom(other.HonamiStoryItemInfo);
			}
			if (other.honamiStoryPosInfo_ != null)
			{
				if (this.honamiStoryPosInfo_ == null)
				{
					this.HonamiStoryPosInfo = new HonamiStoryPosInfo();
				}
				this.HonamiStoryPosInfo.MergeFrom(other.HonamiStoryPosInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600AA69 RID: 43625 RVA: 0x0019A778 File Offset: 0x00198978
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AA6A RID: 43626 RVA: 0x0019A784 File Offset: 0x00198984
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
				if (num != 10U)
				{
					if (num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.honamiStoryPosInfo_ == null)
						{
							this.HonamiStoryPosInfo = new HonamiStoryPosInfo();
						}
						input.ReadMessage(this.HonamiStoryPosInfo);
					}
				}
				else
				{
					if (this.honamiStoryItemInfo_ == null)
					{
						this.HonamiStoryItemInfo = new HonamiStoryItemInfo();
					}
					input.ReadMessage(this.HonamiStoryItemInfo);
				}
			}
		}

		// Token: 0x04004DDF RID: 19935
		private static readonly MessageParser<HonamiStoryBagItemInfo> _parser = new MessageParser<HonamiStoryBagItemInfo>(() => new HonamiStoryBagItemInfo());

		// Token: 0x04004DE0 RID: 19936
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004DE1 RID: 19937
		public const int HonamiStoryItemInfoFieldNumber = 1;

		// Token: 0x04004DE2 RID: 19938
		private HonamiStoryItemInfo honamiStoryItemInfo_;

		// Token: 0x04004DE3 RID: 19939
		public const int HonamiStoryPosInfoFieldNumber = 2;

		// Token: 0x04004DE4 RID: 19940
		private HonamiStoryPosInfo honamiStoryPosInfo_;
	}
}
