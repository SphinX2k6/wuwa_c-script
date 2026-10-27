using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000655 RID: 1621
	public sealed class FriendInfo : IMessage<FriendInfo>, IMessage, IEquatable<FriendInfo>, IDeepCloneable<FriendInfo>, IBufferMessage
	{
		// Token: 0x060094F4 RID: 38132 RVA: 0x00167B11 File Offset: 0x00165D11
		[NullableContext(1)]
		public static FriendInfo Create()
		{
			return new FriendInfo();
		}

		// Token: 0x17001DA4 RID: 7588
		// (get) Token: 0x060094F5 RID: 38133 RVA: 0x00167B18 File Offset: 0x00165D18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FriendInfo> Parser
		{
			get
			{
				return FriendInfo._parser;
			}
		}

		// Token: 0x17001DA5 RID: 7589
		// (get) Token: 0x060094F6 RID: 38134 RVA: 0x00167B1F File Offset: 0x00165D1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001DA6 RID: 7590
		// (get) Token: 0x060094F7 RID: 38135 RVA: 0x00167B22 File Offset: 0x00165D22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FriendInfo.Descriptor;
			}
		}

		// Token: 0x060094F8 RID: 38136 RVA: 0x00167B29 File Offset: 0x00165D29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FriendInfo()
		{
		}

		// Token: 0x060094F9 RID: 38137 RVA: 0x00167B3C File Offset: 0x00165D3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FriendInfo(FriendInfo other) : this()
		{
			this.info_ = ((other.info_ != null) ? other.info_.Clone() : null);
			this.remark_ = other.remark_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060094FA RID: 38138 RVA: 0x00167B88 File Offset: 0x00165D88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FriendInfo Clone()
		{
			return new FriendInfo(this);
		}

		// Token: 0x17001DA7 RID: 7591
		// (get) Token: 0x060094FB RID: 38139 RVA: 0x00167B90 File Offset: 0x00165D90
		// (set) Token: 0x060094FC RID: 38140 RVA: 0x00167B98 File Offset: 0x00165D98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerDetails Info
		{
			get
			{
				return this.info_;
			}
			set
			{
				this.info_ = value;
			}
		}

		// Token: 0x17001DA8 RID: 7592
		// (get) Token: 0x060094FD RID: 38141 RVA: 0x00167BA1 File Offset: 0x00165DA1
		// (set) Token: 0x060094FE RID: 38142 RVA: 0x00167BA9 File Offset: 0x00165DA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Remark
		{
			get
			{
				return this.remark_;
			}
			set
			{
				this.remark_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x060094FF RID: 38143 RVA: 0x00167BBC File Offset: 0x00165DBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FriendInfo);
		}

		// Token: 0x06009500 RID: 38144 RVA: 0x00167BCC File Offset: 0x00165DCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FriendInfo other)
		{
			return other != null && (other == this || (object.Equals(this.Info, other.Info) && !(this.Remark != other.Remark) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009501 RID: 38145 RVA: 0x00167C20 File Offset: 0x00165E20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.info_ != null)
			{
				num ^= this.Info.GetHashCode();
			}
			if (this.Remark.Length != 0)
			{
				num ^= this.Remark.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009502 RID: 38146 RVA: 0x00167C77 File Offset: 0x00165E77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009503 RID: 38147 RVA: 0x00167C84 File Offset: 0x00165E84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009504 RID: 38148 RVA: 0x00167C90 File Offset: 0x00165E90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.info_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Info);
			}
			if (this.Remark.Length != 0)
			{
				output.WriteRawTag(18);
				output.WriteString(this.Remark);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009505 RID: 38149 RVA: 0x00167CF0 File Offset: 0x00165EF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.info_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Info);
			}
			if (this.Remark.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Remark);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009506 RID: 38150 RVA: 0x00167D4C File Offset: 0x00165F4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FriendInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.info_ != null)
			{
				if (this.info_ == null)
				{
					this.Info = new PlayerDetails();
				}
				this.Info.MergeFrom(other.Info);
			}
			if (other.Remark.Length != 0)
			{
				this.Remark = other.Remark;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009507 RID: 38151 RVA: 0x00167DB9 File Offset: 0x00165FB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009508 RID: 38152 RVA: 0x00167DC4 File Offset: 0x00165FC4
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
						this.Remark = input.ReadString();
					}
				}
				else
				{
					if (this.info_ == null)
					{
						this.Info = new PlayerDetails();
					}
					input.ReadMessage(this.Info);
				}
			}
		}

		// Token: 0x04004742 RID: 18242
		private static readonly MessageParser<FriendInfo> _parser = new MessageParser<FriendInfo>(() => new FriendInfo());

		// Token: 0x04004743 RID: 18243
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004744 RID: 18244
		public const int InfoFieldNumber = 1;

		// Token: 0x04004745 RID: 18245
		private PlayerDetails info_;

		// Token: 0x04004746 RID: 18246
		public const int RemarkFieldNumber = 2;

		// Token: 0x04004747 RID: 18247
		private string remark_ = "";
	}
}
