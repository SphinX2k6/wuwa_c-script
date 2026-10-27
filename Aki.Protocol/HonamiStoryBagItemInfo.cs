using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200076A RID: 1898
	public sealed class HonamiStoryBagItemInfo : IMessage<HonamiStoryBagItemInfo>, IMessage, IEquatable<HonamiStoryBagItemInfo>, IDeepCloneable<HonamiStoryBagItemInfo>, IBufferMessage
	{
		// Token: 0x0600ABAC RID: 43948 RVA: 0x0019CEF9 File Offset: 0x0019B0F9
		[NullableContext(1)]
		public static HonamiStoryBagItemInfo Create()
		{
			return new HonamiStoryBagItemInfo();
		}

		// Token: 0x17002299 RID: 8857
		// (get) Token: 0x0600ABAD RID: 43949 RVA: 0x0019CF00 File Offset: 0x0019B100
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<HonamiStoryBagItemInfo> Parser
		{
			get
			{
				return HonamiStoryBagItemInfo._parser;
			}
		}

		// Token: 0x1700229A RID: 8858
		// (get) Token: 0x0600ABAE RID: 43950 RVA: 0x0019CF07 File Offset: 0x0019B107
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700229B RID: 8859
		// (get) Token: 0x0600ABAF RID: 43951 RVA: 0x0019CF0A File Offset: 0x0019B10A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HonamiStoryBagItemInfo.Descriptor;
			}
		}

		// Token: 0x0600ABB0 RID: 43952 RVA: 0x0019CF11 File Offset: 0x0019B111
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryBagItemInfo()
		{
		}

		// Token: 0x0600ABB1 RID: 43953 RVA: 0x0019CF1C File Offset: 0x0019B11C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryBagItemInfo(HonamiStoryBagItemInfo other) : this()
		{
			this.honamiStoryItemInfo_ = ((other.honamiStoryItemInfo_ != null) ? other.honamiStoryItemInfo_.Clone() : null);
			this.honamiStoryPosInfo_ = ((other.honamiStoryPosInfo_ != null) ? other.honamiStoryPosInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600ABB2 RID: 43954 RVA: 0x0019CF78 File Offset: 0x0019B178
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryBagItemInfo Clone()
		{
			return new HonamiStoryBagItemInfo(this);
		}

		// Token: 0x1700229C RID: 8860
		// (get) Token: 0x0600ABB3 RID: 43955 RVA: 0x0019CF80 File Offset: 0x0019B180
		// (set) Token: 0x0600ABB4 RID: 43956 RVA: 0x0019CF88 File Offset: 0x0019B188
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

		// Token: 0x1700229D RID: 8861
		// (get) Token: 0x0600ABB5 RID: 43957 RVA: 0x0019CF91 File Offset: 0x0019B191
		// (set) Token: 0x0600ABB6 RID: 43958 RVA: 0x0019CF99 File Offset: 0x0019B199
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

		// Token: 0x0600ABB7 RID: 43959 RVA: 0x0019CFA2 File Offset: 0x0019B1A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HonamiStoryBagItemInfo);
		}

		// Token: 0x0600ABB8 RID: 43960 RVA: 0x0019CFB0 File Offset: 0x0019B1B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HonamiStoryBagItemInfo other)
		{
			return other != null && (other == this || (object.Equals(this.HonamiStoryItemInfo, other.HonamiStoryItemInfo) && object.Equals(this.HonamiStoryPosInfo, other.HonamiStoryPosInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600ABB9 RID: 43961 RVA: 0x0019D004 File Offset: 0x0019B204
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

		// Token: 0x0600ABBA RID: 43962 RVA: 0x0019D056 File Offset: 0x0019B256
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600ABBB RID: 43963 RVA: 0x0019D063 File Offset: 0x0019B263
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600ABBC RID: 43964 RVA: 0x0019D06C File Offset: 0x0019B26C
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

		// Token: 0x0600ABBD RID: 43965 RVA: 0x0019D0C8 File Offset: 0x0019B2C8
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

		// Token: 0x0600ABBE RID: 43966 RVA: 0x0019D120 File Offset: 0x0019B320
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

		// Token: 0x0600ABBF RID: 43967 RVA: 0x0019D1A0 File Offset: 0x0019B3A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600ABC0 RID: 43968 RVA: 0x0019D1AC File Offset: 0x0019B3AC
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

		// Token: 0x04004DE6 RID: 19942
		private static readonly MessageParser<HonamiStoryBagItemInfo> _parser = new MessageParser<HonamiStoryBagItemInfo>(() => new HonamiStoryBagItemInfo());

		// Token: 0x04004DE7 RID: 19943
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004DE8 RID: 19944
		public const int HonamiStoryItemInfoFieldNumber = 1;

		// Token: 0x04004DE9 RID: 19945
		private HonamiStoryItemInfo honamiStoryItemInfo_;

		// Token: 0x04004DEA RID: 19946
		public const int HonamiStoryPosInfoFieldNumber = 2;

		// Token: 0x04004DEB RID: 19947
		private HonamiStoryPosInfo honamiStoryPosInfo_;
	}
}
