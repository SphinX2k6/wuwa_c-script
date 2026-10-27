using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010F0 RID: 4336
	public sealed class RoverRogueAttChange : IMessage<RoverRogueAttChange>, IMessage, IEquatable<RoverRogueAttChange>, IDeepCloneable<RoverRogueAttChange>, IBufferMessage
	{
		// Token: 0x060171FC RID: 94716 RVA: 0x0035B3A7 File Offset: 0x003595A7
		[NullableContext(1)]
		public static RoverRogueAttChange Create()
		{
			return new RoverRogueAttChange();
		}

		// Token: 0x17004D79 RID: 19833
		// (get) Token: 0x060171FD RID: 94717 RVA: 0x0035B3AE File Offset: 0x003595AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RoverRogueAttChange> Parser
		{
			get
			{
				return RoverRogueAttChange._parser;
			}
		}

		// Token: 0x17004D7A RID: 19834
		// (get) Token: 0x060171FE RID: 94718 RVA: 0x0035B3B5 File Offset: 0x003595B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004D7B RID: 19835
		// (get) Token: 0x060171FF RID: 94719 RVA: 0x0035B3B8 File Offset: 0x003595B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoverRogueAttChange.Descriptor;
			}
		}

		// Token: 0x06017200 RID: 94720 RVA: 0x0035B3BF File Offset: 0x003595BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueAttChange()
		{
		}

		// Token: 0x06017201 RID: 94721 RVA: 0x0035B3C7 File Offset: 0x003595C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueAttChange(RoverRogueAttChange other) : this()
		{
			this.attId_ = other.attId_;
			this.changeAttValue_ = other.changeAttValue_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017202 RID: 94722 RVA: 0x0035B3F8 File Offset: 0x003595F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueAttChange Clone()
		{
			return new RoverRogueAttChange(this);
		}

		// Token: 0x17004D7C RID: 19836
		// (get) Token: 0x06017203 RID: 94723 RVA: 0x0035B400 File Offset: 0x00359600
		// (set) Token: 0x06017204 RID: 94724 RVA: 0x0035B408 File Offset: 0x00359608
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int AttId
		{
			get
			{
				return this.attId_;
			}
			set
			{
				this.attId_ = value;
			}
		}

		// Token: 0x17004D7D RID: 19837
		// (get) Token: 0x06017205 RID: 94725 RVA: 0x0035B411 File Offset: 0x00359611
		// (set) Token: 0x06017206 RID: 94726 RVA: 0x0035B419 File Offset: 0x00359619
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ChangeAttValue
		{
			get
			{
				return this.changeAttValue_;
			}
			set
			{
				this.changeAttValue_ = value;
			}
		}

		// Token: 0x06017207 RID: 94727 RVA: 0x0035B422 File Offset: 0x00359622
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoverRogueAttChange);
		}

		// Token: 0x06017208 RID: 94728 RVA: 0x0035B430 File Offset: 0x00359630
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoverRogueAttChange other)
		{
			return other != null && (other == this || (this.AttId == other.AttId && this.ChangeAttValue == other.ChangeAttValue && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017209 RID: 94729 RVA: 0x0035B470 File Offset: 0x00359670
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.AttId != 0)
			{
				num ^= this.AttId.GetHashCode();
			}
			if (this.ChangeAttValue != 0)
			{
				num ^= this.ChangeAttValue.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601720A RID: 94730 RVA: 0x0035B4C8 File Offset: 0x003596C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601720B RID: 94731 RVA: 0x0035B4D5 File Offset: 0x003596D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601720C RID: 94732 RVA: 0x0035B4E0 File Offset: 0x003596E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.AttId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.AttId);
			}
			if (this.ChangeAttValue != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.ChangeAttValue);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601720D RID: 94733 RVA: 0x0035B538 File Offset: 0x00359738
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.AttId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.AttId);
			}
			if (this.ChangeAttValue != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ChangeAttValue);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601720E RID: 94734 RVA: 0x0035B590 File Offset: 0x00359790
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoverRogueAttChange other)
		{
			if (other == null)
			{
				return;
			}
			if (other.AttId != 0)
			{
				this.AttId = other.AttId;
			}
			if (other.ChangeAttValue != 0)
			{
				this.ChangeAttValue = other.ChangeAttValue;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601720F RID: 94735 RVA: 0x0035B5E0 File Offset: 0x003597E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017210 RID: 94736 RVA: 0x0035B5EC File Offset: 0x003597EC
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
						this.ChangeAttValue = input.ReadInt32();
					}
				}
				else
				{
					this.AttId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04008994 RID: 35220
		private static readonly MessageParser<RoverRogueAttChange> _parser = new MessageParser<RoverRogueAttChange>(() => new RoverRogueAttChange());

		// Token: 0x04008995 RID: 35221
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008996 RID: 35222
		public const int AttIdFieldNumber = 1;

		// Token: 0x04008997 RID: 35223
		private int attId_;

		// Token: 0x04008998 RID: 35224
		public const int ChangeAttValueFieldNumber = 2;

		// Token: 0x04008999 RID: 35225
		private int changeAttValue_;
	}
}
