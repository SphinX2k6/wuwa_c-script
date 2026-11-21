using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011E5 RID: 4581
	public sealed class SeasonReward : IMessage<SeasonReward>, IMessage, IEquatable<SeasonReward>, IDeepCloneable<SeasonReward>, IBufferMessage
	{
		// Token: 0x0601873E RID: 100158 RVA: 0x0038F46E File Offset: 0x0038D66E
		[NullableContext(1)]
		public static SeasonReward Create()
		{
			return new SeasonReward();
		}

		// Token: 0x1700526F RID: 21103
		// (get) Token: 0x0601873F RID: 100159 RVA: 0x0038F475 File Offset: 0x0038D675
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SeasonReward> Parser
		{
			get
			{
				return SeasonReward._parser;
			}
		}

		// Token: 0x17005270 RID: 21104
		// (get) Token: 0x06018740 RID: 100160 RVA: 0x0038F47C File Offset: 0x0038D67C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005271 RID: 21105
		// (get) Token: 0x06018741 RID: 100161 RVA: 0x0038F47F File Offset: 0x0038D67F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SeasonReward.Descriptor;
			}
		}

		// Token: 0x06018742 RID: 100162 RVA: 0x0038F486 File Offset: 0x0038D686
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SeasonReward()
		{
		}

		// Token: 0x06018743 RID: 100163 RVA: 0x0038F48E File Offset: 0x0038D68E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SeasonReward(SeasonReward other) : this()
		{
			this.id_ = other.id_;
			this.isReceive_ = other.isReceive_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018744 RID: 100164 RVA: 0x0038F4BF File Offset: 0x0038D6BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SeasonReward Clone()
		{
			return new SeasonReward(this);
		}

		// Token: 0x17005272 RID: 21106
		// (get) Token: 0x06018745 RID: 100165 RVA: 0x0038F4C7 File Offset: 0x0038D6C7
		// (set) Token: 0x06018746 RID: 100166 RVA: 0x0038F4CF File Offset: 0x0038D6CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x17005273 RID: 21107
		// (get) Token: 0x06018747 RID: 100167 RVA: 0x0038F4D8 File Offset: 0x0038D6D8
		// (set) Token: 0x06018748 RID: 100168 RVA: 0x0038F4E0 File Offset: 0x0038D6E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsReceive
		{
			get
			{
				return this.isReceive_;
			}
			set
			{
				this.isReceive_ = value;
			}
		}

		// Token: 0x06018749 RID: 100169 RVA: 0x0038F4E9 File Offset: 0x0038D6E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SeasonReward);
		}

		// Token: 0x0601874A RID: 100170 RVA: 0x0038F4F7 File Offset: 0x0038D6F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SeasonReward other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.IsReceive == other.IsReceive && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601874B RID: 100171 RVA: 0x0038F538 File Offset: 0x0038D738
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.IsReceive)
			{
				num ^= this.IsReceive.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601874C RID: 100172 RVA: 0x0038F590 File Offset: 0x0038D790
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601874D RID: 100173 RVA: 0x0038F59D File Offset: 0x0038D79D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601874E RID: 100174 RVA: 0x0038F5A8 File Offset: 0x0038D7A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			if (this.IsReceive)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.IsReceive);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601874F RID: 100175 RVA: 0x0038F600 File Offset: 0x0038D800
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.IsReceive)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06018750 RID: 100176 RVA: 0x0038F64C File Offset: 0x0038D84C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SeasonReward other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.IsReceive)
			{
				this.IsReceive = other.IsReceive;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06018751 RID: 100177 RVA: 0x0038F69C File Offset: 0x0038D89C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018752 RID: 100178 RVA: 0x0038F6A8 File Offset: 0x0038D8A8
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
						this.IsReceive = input.ReadBool();
					}
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x04009139 RID: 37177
		private static readonly MessageParser<SeasonReward> _parser = new MessageParser<SeasonReward>(() => new SeasonReward());

		// Token: 0x0400913A RID: 37178
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400913B RID: 37179
		public const int IdFieldNumber = 1;

		// Token: 0x0400913C RID: 37180
		private int id_;

		// Token: 0x0400913D RID: 37181
		public const int IsReceiveFieldNumber = 2;

		// Token: 0x0400913E RID: 37182
		private bool isReceive_;
	}
}
