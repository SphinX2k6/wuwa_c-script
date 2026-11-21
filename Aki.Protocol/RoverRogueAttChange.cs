using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200112A RID: 4394
	public sealed class RoverRogueAttChange : IMessage<RoverRogueAttChange>, IMessage, IEquatable<RoverRogueAttChange>, IDeepCloneable<RoverRogueAttChange>, IBufferMessage
	{
		// Token: 0x0601779D RID: 96157 RVA: 0x0036A6FF File Offset: 0x003688FF
		[NullableContext(1)]
		public static RoverRogueAttChange Create()
		{
			return new RoverRogueAttChange();
		}

		// Token: 0x17004EE5 RID: 20197
		// (get) Token: 0x0601779E RID: 96158 RVA: 0x0036A706 File Offset: 0x00368906
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RoverRogueAttChange> Parser
		{
			get
			{
				return RoverRogueAttChange._parser;
			}
		}

		// Token: 0x17004EE6 RID: 20198
		// (get) Token: 0x0601779F RID: 96159 RVA: 0x0036A70D File Offset: 0x0036890D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004EE7 RID: 20199
		// (get) Token: 0x060177A0 RID: 96160 RVA: 0x0036A710 File Offset: 0x00368910
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoverRogueAttChange.Descriptor;
			}
		}

		// Token: 0x060177A1 RID: 96161 RVA: 0x0036A717 File Offset: 0x00368917
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueAttChange()
		{
		}

		// Token: 0x060177A2 RID: 96162 RVA: 0x0036A71F File Offset: 0x0036891F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueAttChange(RoverRogueAttChange other) : this()
		{
			this.attId_ = other.attId_;
			this.changeAttValue_ = other.changeAttValue_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060177A3 RID: 96163 RVA: 0x0036A750 File Offset: 0x00368950
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueAttChange Clone()
		{
			return new RoverRogueAttChange(this);
		}

		// Token: 0x17004EE8 RID: 20200
		// (get) Token: 0x060177A4 RID: 96164 RVA: 0x0036A758 File Offset: 0x00368958
		// (set) Token: 0x060177A5 RID: 96165 RVA: 0x0036A760 File Offset: 0x00368960
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

		// Token: 0x17004EE9 RID: 20201
		// (get) Token: 0x060177A6 RID: 96166 RVA: 0x0036A769 File Offset: 0x00368969
		// (set) Token: 0x060177A7 RID: 96167 RVA: 0x0036A771 File Offset: 0x00368971
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

		// Token: 0x060177A8 RID: 96168 RVA: 0x0036A77A File Offset: 0x0036897A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoverRogueAttChange);
		}

		// Token: 0x060177A9 RID: 96169 RVA: 0x0036A788 File Offset: 0x00368988
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoverRogueAttChange other)
		{
			return other != null && (other == this || (this.AttId == other.AttId && this.ChangeAttValue == other.ChangeAttValue && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060177AA RID: 96170 RVA: 0x0036A7C8 File Offset: 0x003689C8
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

		// Token: 0x060177AB RID: 96171 RVA: 0x0036A820 File Offset: 0x00368A20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060177AC RID: 96172 RVA: 0x0036A82D File Offset: 0x00368A2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060177AD RID: 96173 RVA: 0x0036A838 File Offset: 0x00368A38
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

		// Token: 0x060177AE RID: 96174 RVA: 0x0036A890 File Offset: 0x00368A90
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

		// Token: 0x060177AF RID: 96175 RVA: 0x0036A8E8 File Offset: 0x00368AE8
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

		// Token: 0x060177B0 RID: 96176 RVA: 0x0036A938 File Offset: 0x00368B38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060177B1 RID: 96177 RVA: 0x0036A944 File Offset: 0x00368B44
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

		// Token: 0x04008C27 RID: 35879
		private static readonly MessageParser<RoverRogueAttChange> _parser = new MessageParser<RoverRogueAttChange>(() => new RoverRogueAttChange());

		// Token: 0x04008C28 RID: 35880
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008C29 RID: 35881
		public const int AttIdFieldNumber = 1;

		// Token: 0x04008C2A RID: 35882
		private int attId_;

		// Token: 0x04008C2B RID: 35883
		public const int ChangeAttValueFieldNumber = 2;

		// Token: 0x04008C2C RID: 35884
		private int changeAttValue_;
	}
}
