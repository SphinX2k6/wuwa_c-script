using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E98 RID: 3736
	public sealed class RecallInfo : IMessage<RecallInfo>, IMessage, IEquatable<RecallInfo>, IDeepCloneable<RecallInfo>, IBufferMessage
	{
		// Token: 0x06014145 RID: 82245 RVA: 0x002ECA41 File Offset: 0x002EAC41
		[NullableContext(1)]
		public static RecallInfo Create()
		{
			return new RecallInfo();
		}

		// Token: 0x170042CD RID: 17101
		// (get) Token: 0x06014146 RID: 82246 RVA: 0x002ECA48 File Offset: 0x002EAC48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RecallInfo> Parser
		{
			get
			{
				return RecallInfo._parser;
			}
		}

		// Token: 0x170042CE RID: 17102
		// (get) Token: 0x06014147 RID: 82247 RVA: 0x002ECA4F File Offset: 0x002EAC4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170042CF RID: 17103
		// (get) Token: 0x06014148 RID: 82248 RVA: 0x002ECA52 File Offset: 0x002EAC52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RecallInfo.Descriptor;
			}
		}

		// Token: 0x06014149 RID: 82249 RVA: 0x002ECA59 File Offset: 0x002EAC59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallInfo()
		{
		}

		// Token: 0x0601414A RID: 82250 RVA: 0x002ECA61 File Offset: 0x002EAC61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallInfo(RecallInfo other) : this()
		{
			this.recallId_ = other.recallId_;
			this.state_ = other.state_;
			this.status_ = other.status_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601414B RID: 82251 RVA: 0x002ECA9E File Offset: 0x002EAC9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallInfo Clone()
		{
			return new RecallInfo(this);
		}

		// Token: 0x170042D0 RID: 17104
		// (get) Token: 0x0601414C RID: 82252 RVA: 0x002ECAA6 File Offset: 0x002EACA6
		// (set) Token: 0x0601414D RID: 82253 RVA: 0x002ECAAE File Offset: 0x002EACAE
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

		// Token: 0x170042D1 RID: 17105
		// (get) Token: 0x0601414E RID: 82254 RVA: 0x002ECAB7 File Offset: 0x002EACB7
		// (set) Token: 0x0601414F RID: 82255 RVA: 0x002ECABF File Offset: 0x002EACBF
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

		// Token: 0x170042D2 RID: 17106
		// (get) Token: 0x06014150 RID: 82256 RVA: 0x002ECAC8 File Offset: 0x002EACC8
		// (set) Token: 0x06014151 RID: 82257 RVA: 0x002ECAD0 File Offset: 0x002EACD0
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

		// Token: 0x06014152 RID: 82258 RVA: 0x002ECAD9 File Offset: 0x002EACD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RecallInfo);
		}

		// Token: 0x06014153 RID: 82259 RVA: 0x002ECAE8 File Offset: 0x002EACE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RecallInfo other)
		{
			return other != null && (other == this || (this.RecallId == other.RecallId && this.State == other.State && this.Status == other.Status && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014154 RID: 82260 RVA: 0x002ECB44 File Offset: 0x002EAD44
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

		// Token: 0x06014155 RID: 82261 RVA: 0x002ECBBB File Offset: 0x002EADBB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014156 RID: 82262 RVA: 0x002ECBC8 File Offset: 0x002EADC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014157 RID: 82263 RVA: 0x002ECBD4 File Offset: 0x002EADD4
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

		// Token: 0x06014158 RID: 82264 RVA: 0x002ECC48 File Offset: 0x002EAE48
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

		// Token: 0x06014159 RID: 82265 RVA: 0x002ECCB8 File Offset: 0x002EAEB8
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

		// Token: 0x0601415A RID: 82266 RVA: 0x002ECD1C File Offset: 0x002EAF1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601415B RID: 82267 RVA: 0x002ECD28 File Offset: 0x002EAF28
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

		// Token: 0x04007AD1 RID: 31441
		private static readonly MessageParser<RecallInfo> _parser = new MessageParser<RecallInfo>(() => new RecallInfo());

		// Token: 0x04007AD2 RID: 31442
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007AD3 RID: 31443
		public const int RecallIdFieldNumber = 1;

		// Token: 0x04007AD4 RID: 31444
		private int recallId_;

		// Token: 0x04007AD5 RID: 31445
		public const int StateFieldNumber = 2;

		// Token: 0x04007AD6 RID: 31446
		private RecallState state_;

		// Token: 0x04007AD7 RID: 31447
		public const int StatusFieldNumber = 3;

		// Token: 0x04007AD8 RID: 31448
		private int status_;
	}
}
