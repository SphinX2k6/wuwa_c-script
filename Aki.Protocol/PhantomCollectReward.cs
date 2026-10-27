using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CC7 RID: 3271
	public sealed class PhantomCollectReward : IMessage<PhantomCollectReward>, IMessage, IEquatable<PhantomCollectReward>, IDeepCloneable<PhantomCollectReward>, IBufferMessage
	{
		// Token: 0x06011B59 RID: 72537 RVA: 0x0029797E File Offset: 0x00295B7E
		[NullableContext(1)]
		public static PhantomCollectReward Create()
		{
			return new PhantomCollectReward();
		}

		// Token: 0x17003AAB RID: 15019
		// (get) Token: 0x06011B5A RID: 72538 RVA: 0x00297985 File Offset: 0x00295B85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PhantomCollectReward> Parser
		{
			get
			{
				return PhantomCollectReward._parser;
			}
		}

		// Token: 0x17003AAC RID: 15020
		// (get) Token: 0x06011B5B RID: 72539 RVA: 0x0029798C File Offset: 0x00295B8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003AAD RID: 15021
		// (get) Token: 0x06011B5C RID: 72540 RVA: 0x0029798F File Offset: 0x00295B8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomCollectReward.Descriptor;
			}
		}

		// Token: 0x06011B5D RID: 72541 RVA: 0x00297996 File Offset: 0x00295B96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomCollectReward()
		{
		}

		// Token: 0x06011B5E RID: 72542 RVA: 0x002979A0 File Offset: 0x00295BA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomCollectReward(PhantomCollectReward other) : this()
		{
			this.type_ = other.type_;
			this.state_ = other.state_;
			if (other.DataCase == PhantomCollectReward.DataOneofCase.Progress)
			{
				this.Progress = other.Progress.Clone();
			}
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011B5F RID: 72543 RVA: 0x002979F6 File Offset: 0x00295BF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomCollectReward Clone()
		{
			return new PhantomCollectReward(this);
		}

		// Token: 0x17003AAE RID: 15022
		// (get) Token: 0x06011B60 RID: 72544 RVA: 0x002979FE File Offset: 0x00295BFE
		// (set) Token: 0x06011B61 RID: 72545 RVA: 0x00297A06 File Offset: 0x00295C06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomCollectRewardType Type
		{
			get
			{
				return this.type_;
			}
			set
			{
				this.type_ = value;
			}
		}

		// Token: 0x17003AAF RID: 15023
		// (get) Token: 0x06011B62 RID: 72546 RVA: 0x00297A0F File Offset: 0x00295C0F
		// (set) Token: 0x06011B63 RID: 72547 RVA: 0x00297A17 File Offset: 0x00295C17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SignState State
		{
			get
			{
				return this.state_;
			}
			set
			{
				this.state_ = value;
			}
		}

		// Token: 0x17003AB0 RID: 15024
		// (get) Token: 0x06011B64 RID: 72548 RVA: 0x00297A20 File Offset: 0x00295C20
		// (set) Token: 0x06011B65 RID: 72549 RVA: 0x00297A38 File Offset: 0x00295C38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomCollectProgress Progress
		{
			get
			{
				if (this.dataCase_ != PhantomCollectReward.DataOneofCase.Progress)
				{
					return null;
				}
				return (PhantomCollectProgress)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? PhantomCollectReward.DataOneofCase.None : PhantomCollectReward.DataOneofCase.Progress);
			}
		}

		// Token: 0x17003AB1 RID: 15025
		// (get) Token: 0x06011B66 RID: 72550 RVA: 0x00297A4E File Offset: 0x00295C4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomCollectReward.DataOneofCase DataCase
		{
			get
			{
				return this.dataCase_;
			}
		}

		// Token: 0x06011B67 RID: 72551 RVA: 0x00297A56 File Offset: 0x00295C56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearData()
		{
			this.dataCase_ = PhantomCollectReward.DataOneofCase.None;
			this.data_ = null;
		}

		// Token: 0x06011B68 RID: 72552 RVA: 0x00297A66 File Offset: 0x00295C66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomCollectReward);
		}

		// Token: 0x06011B69 RID: 72553 RVA: 0x00297A74 File Offset: 0x00295C74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomCollectReward other)
		{
			return other != null && (other == this || (this.Type == other.Type && this.State == other.State && object.Equals(this.Progress, other.Progress) && this.DataCase == other.DataCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011B6A RID: 72554 RVA: 0x00297AE4 File Offset: 0x00295CE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Type != PhantomCollectRewardType.PhantomsCollect)
			{
				num ^= this.Type.GetHashCode();
			}
			if (this.State != SignState.Lock)
			{
				num ^= this.State.GetHashCode();
			}
			if (this.dataCase_ == PhantomCollectReward.DataOneofCase.Progress)
			{
				num ^= this.Progress.GetHashCode();
			}
			num ^= (int)this.dataCase_;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06011B6B RID: 72555 RVA: 0x00297B68 File Offset: 0x00295D68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011B6C RID: 72556 RVA: 0x00297B75 File Offset: 0x00295D75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011B6D RID: 72557 RVA: 0x00297B80 File Offset: 0x00295D80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Type != PhantomCollectRewardType.PhantomsCollect)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.Type);
			}
			if (this.State != SignState.Lock)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.State);
			}
			if (this.dataCase_ == PhantomCollectReward.DataOneofCase.Progress)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.Progress);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011B6E RID: 72558 RVA: 0x00297BF8 File Offset: 0x00295DF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Type != PhantomCollectRewardType.PhantomsCollect)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Type);
			}
			if (this.State != SignState.Lock)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.State);
			}
			if (this.dataCase_ == PhantomCollectReward.DataOneofCase.Progress)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Progress);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06011B6F RID: 72559 RVA: 0x00297C68 File Offset: 0x00295E68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomCollectReward other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Type != PhantomCollectRewardType.PhantomsCollect)
			{
				this.Type = other.Type;
			}
			if (other.State != SignState.Lock)
			{
				this.State = other.State;
			}
			if (other.DataCase == PhantomCollectReward.DataOneofCase.Progress)
			{
				if (this.Progress == null)
				{
					this.Progress = new PhantomCollectProgress();
				}
				this.Progress.MergeFrom(other.Progress);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06011B70 RID: 72560 RVA: 0x00297CE5 File Offset: 0x00295EE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011B71 RID: 72561 RVA: 0x00297CF0 File Offset: 0x00295EF0
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
						if (num != 26U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							PhantomCollectProgress phantomCollectProgress = new PhantomCollectProgress();
							if (this.dataCase_ == PhantomCollectReward.DataOneofCase.Progress)
							{
								phantomCollectProgress.MergeFrom(this.Progress);
							}
							input.ReadMessage(phantomCollectProgress);
							this.Progress = phantomCollectProgress;
						}
					}
					else
					{
						this.State = (SignState)input.ReadEnum();
					}
				}
				else
				{
					this.Type = (PhantomCollectRewardType)input.ReadEnum();
				}
			}
		}

		// Token: 0x04006F5D RID: 28509
		private static readonly MessageParser<PhantomCollectReward> _parser = new MessageParser<PhantomCollectReward>(() => new PhantomCollectReward());

		// Token: 0x04006F5E RID: 28510
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006F5F RID: 28511
		public const int TypeFieldNumber = 1;

		// Token: 0x04006F60 RID: 28512
		private PhantomCollectRewardType type_;

		// Token: 0x04006F61 RID: 28513
		public const int StateFieldNumber = 2;

		// Token: 0x04006F62 RID: 28514
		private SignState state_;

		// Token: 0x04006F63 RID: 28515
		public const int ProgressFieldNumber = 3;

		// Token: 0x04006F64 RID: 28516
		private object data_;

		// Token: 0x04006F65 RID: 28517
		private PhantomCollectReward.DataOneofCase dataCase_;

		// Token: 0x020018B8 RID: 6328
		public enum DataOneofCase
		{
			// Token: 0x0400C8BC RID: 51388
			None,
			// Token: 0x0400C8BD RID: 51389
			Progress = 3
		}
	}
}
