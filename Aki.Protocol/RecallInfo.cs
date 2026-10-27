using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000EA8 RID: 3752
	public sealed class RecallInfo : IMessage<RecallInfo>, IMessage, IEquatable<RecallInfo>, IDeepCloneable<RecallInfo>, IBufferMessage
	{
		// Token: 0x0601422A RID: 82474 RVA: 0x002EE0ED File Offset: 0x002EC2ED
		[NullableContext(1)]
		public static RecallInfo Create()
		{
			return new RecallInfo();
		}

		// Token: 0x170042F7 RID: 17143
		// (get) Token: 0x0601422B RID: 82475 RVA: 0x002EE0F4 File Offset: 0x002EC2F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RecallInfo> Parser
		{
			get
			{
				return RecallInfo._parser;
			}
		}

		// Token: 0x170042F8 RID: 17144
		// (get) Token: 0x0601422C RID: 82476 RVA: 0x002EE0FB File Offset: 0x002EC2FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170042F9 RID: 17145
		// (get) Token: 0x0601422D RID: 82477 RVA: 0x002EE0FE File Offset: 0x002EC2FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RecallInfo.Descriptor;
			}
		}

		// Token: 0x0601422E RID: 82478 RVA: 0x002EE105 File Offset: 0x002EC305
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallInfo()
		{
		}

		// Token: 0x0601422F RID: 82479 RVA: 0x002EE10D File Offset: 0x002EC30D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallInfo(RecallInfo other) : this()
		{
			this.recallId_ = other.recallId_;
			this.state_ = other.state_;
			this.status_ = other.status_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014230 RID: 82480 RVA: 0x002EE14A File Offset: 0x002EC34A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallInfo Clone()
		{
			return new RecallInfo(this);
		}

		// Token: 0x170042FA RID: 17146
		// (get) Token: 0x06014231 RID: 82481 RVA: 0x002EE152 File Offset: 0x002EC352
		// (set) Token: 0x06014232 RID: 82482 RVA: 0x002EE15A File Offset: 0x002EC35A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RecallId
		{
			get
			{
				return this.recallId_;
			}
			set
			{
				this.recallId_ = value;
			}
		}

		// Token: 0x170042FB RID: 17147
		// (get) Token: 0x06014233 RID: 82483 RVA: 0x002EE163 File Offset: 0x002EC363
		// (set) Token: 0x06014234 RID: 82484 RVA: 0x002EE16B File Offset: 0x002EC36B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallState State
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

		// Token: 0x170042FC RID: 17148
		// (get) Token: 0x06014235 RID: 82485 RVA: 0x002EE174 File Offset: 0x002EC374
		// (set) Token: 0x06014236 RID: 82486 RVA: 0x002EE17C File Offset: 0x002EC37C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Status
		{
			get
			{
				return this.status_;
			}
			set
			{
				this.status_ = value;
			}
		}

		// Token: 0x06014237 RID: 82487 RVA: 0x002EE185 File Offset: 0x002EC385
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RecallInfo);
		}

		// Token: 0x06014238 RID: 82488 RVA: 0x002EE194 File Offset: 0x002EC394
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RecallInfo other)
		{
			return other != null && (other == this || (this.RecallId == other.RecallId && this.State == other.State && this.Status == other.Status && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014239 RID: 82489 RVA: 0x002EE1F0 File Offset: 0x002EC3F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RecallId != 0)
			{
				num ^= this.RecallId.GetHashCode();
			}
			if (this.State != RecallState.NotStart)
			{
				num ^= this.State.GetHashCode();
			}
			if (this.Status != 0)
			{
				num ^= this.Status.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601423A RID: 82490 RVA: 0x002EE267 File Offset: 0x002EC467
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601423B RID: 82491 RVA: 0x002EE274 File Offset: 0x002EC474
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601423C RID: 82492 RVA: 0x002EE280 File Offset: 0x002EC480
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RecallId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.RecallId);
			}
			if (this.State != RecallState.NotStart)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.State);
			}
			if (this.Status != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Status);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601423D RID: 82493 RVA: 0x002EE2F4 File Offset: 0x002EC4F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RecallId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RecallId);
			}
			if (this.State != RecallState.NotStart)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.State);
			}
			if (this.Status != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Status);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601423E RID: 82494 RVA: 0x002EE364 File Offset: 0x002EC564
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RecallInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RecallId != 0)
			{
				this.RecallId = other.RecallId;
			}
			if (other.State != RecallState.NotStart)
			{
				this.State = other.State;
			}
			if (other.Status != 0)
			{
				this.Status = other.Status;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601423F RID: 82495 RVA: 0x002EE3C8 File Offset: 0x002EC5C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014240 RID: 82496 RVA: 0x002EE3D4 File Offset: 0x002EC5D4
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
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Status = input.ReadInt32();
						}
					}
					else
					{
						this.State = (RecallState)input.ReadEnum();
					}
				}
				else
				{
					this.RecallId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04007AA7 RID: 31399
		private static readonly MessageParser<RecallInfo> _parser = new MessageParser<RecallInfo>(() => new RecallInfo());

		// Token: 0x04007AA8 RID: 31400
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007AA9 RID: 31401
		public const int RecallIdFieldNumber = 1;

		// Token: 0x04007AAA RID: 31402
		private int recallId_;

		// Token: 0x04007AAB RID: 31403
		public const int StateFieldNumber = 2;

		// Token: 0x04007AAC RID: 31404
		private RecallState state_;

		// Token: 0x04007AAD RID: 31405
		public const int StatusFieldNumber = 3;

		// Token: 0x04007AAE RID: 31406
		private int status_;
	}
}
