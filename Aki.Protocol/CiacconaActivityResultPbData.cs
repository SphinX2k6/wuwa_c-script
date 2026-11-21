using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000292 RID: 658
	public sealed class CiacconaActivityResultPbData : IMessage<CiacconaActivityResultPbData>, IMessage, IEquatable<CiacconaActivityResultPbData>, IDeepCloneable<CiacconaActivityResultPbData>, IBufferMessage
	{
		// Token: 0x060044D3 RID: 17619 RVA: 0x000A9217 File Offset: 0x000A7417
		[NullableContext(1)]
		public static CiacconaActivityResultPbData Create()
		{
			return new CiacconaActivityResultPbData();
		}

		// Token: 0x17000BCA RID: 3018
		// (get) Token: 0x060044D4 RID: 17620 RVA: 0x000A921E File Offset: 0x000A741E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<CiacconaActivityResultPbData> Parser
		{
			get
			{
				return CiacconaActivityResultPbData._parser;
			}
		}

		// Token: 0x17000BCB RID: 3019
		// (get) Token: 0x060044D5 RID: 17621 RVA: 0x000A9225 File Offset: 0x000A7425
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000BCC RID: 3020
		// (get) Token: 0x060044D6 RID: 17622 RVA: 0x000A9228 File Offset: 0x000A7428
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CiacconaActivityResultPbData.Descriptor;
			}
		}

		// Token: 0x060044D7 RID: 17623 RVA: 0x000A922F File Offset: 0x000A742F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CiacconaActivityResultPbData()
		{
		}

		// Token: 0x060044D8 RID: 17624 RVA: 0x000A9237 File Offset: 0x000A7437
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CiacconaActivityResultPbData(CiacconaActivityResultPbData other) : this()
		{
			this.resultId_ = other.resultId_;
			this.takeReward_ = other.takeReward_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060044D9 RID: 17625 RVA: 0x000A9268 File Offset: 0x000A7468
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CiacconaActivityResultPbData Clone()
		{
			return new CiacconaActivityResultPbData(this);
		}

		// Token: 0x17000BCD RID: 3021
		// (get) Token: 0x060044DA RID: 17626 RVA: 0x000A9270 File Offset: 0x000A7470
		// (set) Token: 0x060044DB RID: 17627 RVA: 0x000A9278 File Offset: 0x000A7478
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ResultId
		{
			get
			{
				return this.resultId_;
			}
			set
			{
				this.resultId_ = value;
			}
		}

		// Token: 0x17000BCE RID: 3022
		// (get) Token: 0x060044DC RID: 17628 RVA: 0x000A9281 File Offset: 0x000A7481
		// (set) Token: 0x060044DD RID: 17629 RVA: 0x000A9289 File Offset: 0x000A7489
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool TakeReward
		{
			get
			{
				return this.takeReward_;
			}
			set
			{
				this.takeReward_ = value;
			}
		}

		// Token: 0x060044DE RID: 17630 RVA: 0x000A9292 File Offset: 0x000A7492
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CiacconaActivityResultPbData);
		}

		// Token: 0x060044DF RID: 17631 RVA: 0x000A92A0 File Offset: 0x000A74A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CiacconaActivityResultPbData other)
		{
			return other != null && (other == this || (this.ResultId == other.ResultId && this.TakeReward == other.TakeReward && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060044E0 RID: 17632 RVA: 0x000A92E0 File Offset: 0x000A74E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ResultId != 0)
			{
				num ^= this.ResultId.GetHashCode();
			}
			if (this.TakeReward)
			{
				num ^= this.TakeReward.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060044E1 RID: 17633 RVA: 0x000A9338 File Offset: 0x000A7538
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060044E2 RID: 17634 RVA: 0x000A9345 File Offset: 0x000A7545
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060044E3 RID: 17635 RVA: 0x000A9350 File Offset: 0x000A7550
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ResultId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ResultId);
			}
			if (this.TakeReward)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.TakeReward);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060044E4 RID: 17636 RVA: 0x000A93A8 File Offset: 0x000A75A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ResultId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ResultId);
			}
			if (this.TakeReward)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060044E5 RID: 17637 RVA: 0x000A93F4 File Offset: 0x000A75F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CiacconaActivityResultPbData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ResultId != 0)
			{
				this.ResultId = other.ResultId;
			}
			if (other.TakeReward)
			{
				this.TakeReward = other.TakeReward;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060044E6 RID: 17638 RVA: 0x000A9444 File Offset: 0x000A7644
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060044E7 RID: 17639 RVA: 0x000A9450 File Offset: 0x000A7650
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
						this.TakeReward = input.ReadBool();
					}
				}
				else
				{
					this.ResultId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04002F0E RID: 12046
		private static readonly MessageParser<CiacconaActivityResultPbData> _parser = new MessageParser<CiacconaActivityResultPbData>(() => new CiacconaActivityResultPbData());

		// Token: 0x04002F0F RID: 12047
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002F10 RID: 12048
		public const int ResultIdFieldNumber = 1;

		// Token: 0x04002F11 RID: 12049
		private int resultId_;

		// Token: 0x04002F12 RID: 12050
		public const int TakeRewardFieldNumber = 2;

		// Token: 0x04002F13 RID: 12051
		private bool takeReward_;
	}
}
