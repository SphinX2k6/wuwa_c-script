using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001209 RID: 4617
	[NetMessage(EMessageId.ShortMessageReplyRequest)]
	public sealed class ShortMessageReplyRequest : IMessage<ShortMessageReplyRequest>, IMessage, IEquatable<ShortMessageReplyRequest>, IDeepCloneable<ShortMessageReplyRequest>, IBufferMessage
	{
		// Token: 0x060189C2 RID: 100802 RVA: 0x003943A1 File Offset: 0x003925A1
		[NullableContext(1)]
		public static ShortMessageReplyRequest Create()
		{
			return new ShortMessageReplyRequest();
		}

		// Token: 0x170052EA RID: 21226
		// (get) Token: 0x060189C3 RID: 100803 RVA: 0x003943A8 File Offset: 0x003925A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170052EB RID: 21227
		// (get) Token: 0x060189C4 RID: 100804 RVA: 0x003943AB File Offset: 0x003925AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ShortMessageReplyRequest.Descriptor;
			}
		}

		// Token: 0x060189C5 RID: 100805 RVA: 0x003943B2 File Offset: 0x003925B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShortMessageReplyRequest()
		{
		}

		// Token: 0x060189C6 RID: 100806 RVA: 0x003943BA File Offset: 0x003925BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShortMessageReplyRequest(ShortMessageReplyRequest other) : this()
		{
			this.configId_ = other.configId_;
			this.curOptionId_ = other.curOptionId_;
			this.selectId_ = other.selectId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060189C7 RID: 100807 RVA: 0x003943F7 File Offset: 0x003925F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShortMessageReplyRequest Clone()
		{
			return new ShortMessageReplyRequest(this);
		}

		// Token: 0x170052EC RID: 21228
		// (get) Token: 0x060189C8 RID: 100808 RVA: 0x003943FF File Offset: 0x003925FF
		// (set) Token: 0x060189C9 RID: 100809 RVA: 0x00394407 File Offset: 0x00392607
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ConfigId
		{
			get
			{
				return this.configId_;
			}
			set
			{
				this.configId_ = value;
			}
		}

		// Token: 0x170052ED RID: 21229
		// (get) Token: 0x060189CA RID: 100810 RVA: 0x00394410 File Offset: 0x00392610
		// (set) Token: 0x060189CB RID: 100811 RVA: 0x00394418 File Offset: 0x00392618
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CurOptionId
		{
			get
			{
				return this.curOptionId_;
			}
			set
			{
				this.curOptionId_ = value;
			}
		}

		// Token: 0x170052EE RID: 21230
		// (get) Token: 0x060189CC RID: 100812 RVA: 0x00394421 File Offset: 0x00392621
		// (set) Token: 0x060189CD RID: 100813 RVA: 0x00394429 File Offset: 0x00392629
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SelectId
		{
			get
			{
				return this.selectId_;
			}
			set
			{
				this.selectId_ = value;
			}
		}

		// Token: 0x060189CE RID: 100814 RVA: 0x00394432 File Offset: 0x00392632
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ShortMessageReplyRequest);
		}

		// Token: 0x060189CF RID: 100815 RVA: 0x00394440 File Offset: 0x00392640
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ShortMessageReplyRequest other)
		{
			return other != null && (other == this || (this.ConfigId == other.ConfigId && this.CurOptionId == other.CurOptionId && this.SelectId == other.SelectId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060189D0 RID: 100816 RVA: 0x0039449C File Offset: 0x0039269C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ConfigId != 0)
			{
				num ^= this.ConfigId.GetHashCode();
			}
			if (this.CurOptionId != 0)
			{
				num ^= this.CurOptionId.GetHashCode();
			}
			if (this.SelectId != 0)
			{
				num ^= this.SelectId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060189D1 RID: 100817 RVA: 0x0039450D File Offset: 0x0039270D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060189D2 RID: 100818 RVA: 0x0039451A File Offset: 0x0039271A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060189D3 RID: 100819 RVA: 0x00394524 File Offset: 0x00392724
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SelectId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.SelectId);
			}
			if (this.CurOptionId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.CurOptionId);
			}
			if (this.ConfigId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.ConfigId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060189D4 RID: 100820 RVA: 0x0039459C File Offset: 0x0039279C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ConfigId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ConfigId);
			}
			if (this.CurOptionId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CurOptionId);
			}
			if (this.SelectId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SelectId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060189D5 RID: 100821 RVA: 0x0039460C File Offset: 0x0039280C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ShortMessageReplyRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ConfigId != 0)
			{
				this.ConfigId = other.ConfigId;
			}
			if (other.CurOptionId != 0)
			{
				this.CurOptionId = other.CurOptionId;
			}
			if (other.SelectId != 0)
			{
				this.SelectId = other.SelectId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060189D6 RID: 100822 RVA: 0x00394670 File Offset: 0x00392870
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060189D7 RID: 100823 RVA: 0x0039467C File Offset: 0x0039287C
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
				if (num != 40U)
				{
					if (num != 48U)
					{
						if (num != 72U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.ConfigId = input.ReadInt32();
						}
					}
					else
					{
						this.CurOptionId = input.ReadInt32();
					}
				}
				else
				{
					this.SelectId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400916E RID: 37230
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400916F RID: 37231
		public const int ConfigIdFieldNumber = 9;

		// Token: 0x04009170 RID: 37232
		private int configId_;

		// Token: 0x04009171 RID: 37233
		public const int CurOptionIdFieldNumber = 6;

		// Token: 0x04009172 RID: 37234
		private int curOptionId_;

		// Token: 0x04009173 RID: 37235
		public const int SelectIdFieldNumber = 5;

		// Token: 0x04009174 RID: 37236
		private int selectId_;
	}
}
