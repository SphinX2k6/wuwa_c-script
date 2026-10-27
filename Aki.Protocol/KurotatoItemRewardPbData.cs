using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200089D RID: 2205
	public sealed class KurotatoItemRewardPbData : IMessage<KurotatoItemRewardPbData>, IMessage, IEquatable<KurotatoItemRewardPbData>, IDeepCloneable<KurotatoItemRewardPbData>, IBufferMessage
	{
		// Token: 0x0600C3F6 RID: 50166 RVA: 0x001D0D79 File Offset: 0x001CEF79
		[NullableContext(1)]
		public static KurotatoItemRewardPbData Create()
		{
			return new KurotatoItemRewardPbData();
		}

		// Token: 0x1700279E RID: 10142
		// (get) Token: 0x0600C3F7 RID: 50167 RVA: 0x001D0D80 File Offset: 0x001CEF80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<KurotatoItemRewardPbData> Parser
		{
			get
			{
				return KurotatoItemRewardPbData._parser;
			}
		}

		// Token: 0x1700279F RID: 10143
		// (get) Token: 0x0600C3F8 RID: 50168 RVA: 0x001D0D87 File Offset: 0x001CEF87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170027A0 RID: 10144
		// (get) Token: 0x0600C3F9 RID: 50169 RVA: 0x001D0D8A File Offset: 0x001CEF8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoItemRewardPbData.Descriptor;
			}
		}

		// Token: 0x0600C3FA RID: 50170 RVA: 0x001D0D91 File Offset: 0x001CEF91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoItemRewardPbData()
		{
		}

		// Token: 0x0600C3FB RID: 50171 RVA: 0x001D0D99 File Offset: 0x001CEF99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoItemRewardPbData(KurotatoItemRewardPbData other) : this()
		{
			this.itemId_ = other.itemId_;
			this.selectionId_ = other.selectionId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C3FC RID: 50172 RVA: 0x001D0DCA File Offset: 0x001CEFCA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoItemRewardPbData Clone()
		{
			return new KurotatoItemRewardPbData(this);
		}

		// Token: 0x170027A1 RID: 10145
		// (get) Token: 0x0600C3FD RID: 50173 RVA: 0x001D0DD2 File Offset: 0x001CEFD2
		// (set) Token: 0x0600C3FE RID: 50174 RVA: 0x001D0DDA File Offset: 0x001CEFDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ItemId
		{
			get
			{
				return this.itemId_;
			}
			set
			{
				this.itemId_ = value;
			}
		}

		// Token: 0x170027A2 RID: 10146
		// (get) Token: 0x0600C3FF RID: 50175 RVA: 0x001D0DE3 File Offset: 0x001CEFE3
		// (set) Token: 0x0600C400 RID: 50176 RVA: 0x001D0DEB File Offset: 0x001CEFEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SelectionId
		{
			get
			{
				return this.selectionId_;
			}
			set
			{
				this.selectionId_ = value;
			}
		}

		// Token: 0x0600C401 RID: 50177 RVA: 0x001D0DF4 File Offset: 0x001CEFF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoItemRewardPbData);
		}

		// Token: 0x0600C402 RID: 50178 RVA: 0x001D0E02 File Offset: 0x001CF002
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoItemRewardPbData other)
		{
			return other != null && (other == this || (this.ItemId == other.ItemId && this.SelectionId == other.SelectionId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C403 RID: 50179 RVA: 0x001D0E40 File Offset: 0x001CF040
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ItemId != 0)
			{
				num ^= this.ItemId.GetHashCode();
			}
			if (this.SelectionId != 0)
			{
				num ^= this.SelectionId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C404 RID: 50180 RVA: 0x001D0E98 File Offset: 0x001CF098
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C405 RID: 50181 RVA: 0x001D0EA5 File Offset: 0x001CF0A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C406 RID: 50182 RVA: 0x001D0EB0 File Offset: 0x001CF0B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ItemId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ItemId);
			}
			if (this.SelectionId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.SelectionId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C407 RID: 50183 RVA: 0x001D0F08 File Offset: 0x001CF108
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ItemId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ItemId);
			}
			if (this.SelectionId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SelectionId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C408 RID: 50184 RVA: 0x001D0F60 File Offset: 0x001CF160
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(KurotatoItemRewardPbData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ItemId != 0)
			{
				this.ItemId = other.ItemId;
			}
			if (other.SelectionId != 0)
			{
				this.SelectionId = other.SelectionId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C409 RID: 50185 RVA: 0x001D0FB0 File Offset: 0x001CF1B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C40A RID: 50186 RVA: 0x001D0FBC File Offset: 0x001CF1BC
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
						this.SelectionId = input.ReadInt32();
					}
				}
				else
				{
					this.ItemId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400549A RID: 21658
		private static readonly MessageParser<KurotatoItemRewardPbData> _parser = new MessageParser<KurotatoItemRewardPbData>(() => new KurotatoItemRewardPbData());

		// Token: 0x0400549B RID: 21659
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400549C RID: 21660
		public const int ItemIdFieldNumber = 1;

		// Token: 0x0400549D RID: 21661
		private int itemId_;

		// Token: 0x0400549E RID: 21662
		public const int SelectionIdFieldNumber = 2;

		// Token: 0x0400549F RID: 21663
		private int selectionId_;
	}
}
