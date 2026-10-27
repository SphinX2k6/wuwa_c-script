using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200081C RID: 2076
	public sealed class InstanceTimer : IMessage<InstanceTimer>, IMessage, IEquatable<InstanceTimer>, IDeepCloneable<InstanceTimer>, IBufferMessage
	{
		// Token: 0x0600B984 RID: 47492 RVA: 0x001B99F0 File Offset: 0x001B7BF0
		[NullableContext(1)]
		public static InstanceTimer Create()
		{
			return new InstanceTimer();
		}

		// Token: 0x17002560 RID: 9568
		// (get) Token: 0x0600B985 RID: 47493 RVA: 0x001B99F7 File Offset: 0x001B7BF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<InstanceTimer> Parser
		{
			get
			{
				return InstanceTimer._parser;
			}
		}

		// Token: 0x17002561 RID: 9569
		// (get) Token: 0x0600B986 RID: 47494 RVA: 0x001B99FE File Offset: 0x001B7BFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002562 RID: 9570
		// (get) Token: 0x0600B987 RID: 47495 RVA: 0x001B9A01 File Offset: 0x001B7C01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InstanceTimer.Descriptor;
			}
		}

		// Token: 0x0600B988 RID: 47496 RVA: 0x001B9A08 File Offset: 0x001B7C08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InstanceTimer()
		{
		}

		// Token: 0x0600B989 RID: 47497 RVA: 0x001B9A10 File Offset: 0x001B7C10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InstanceTimer(InstanceTimer other) : this()
		{
			this.status_ = other.status_;
			this.remainTick_ = other.remainTick_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B98A RID: 47498 RVA: 0x001B9A41 File Offset: 0x001B7C41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InstanceTimer Clone()
		{
			return new InstanceTimer(this);
		}

		// Token: 0x17002563 RID: 9571
		// (get) Token: 0x0600B98B RID: 47499 RVA: 0x001B9A49 File Offset: 0x001B7C49
		// (set) Token: 0x0600B98C RID: 47500 RVA: 0x001B9A51 File Offset: 0x001B7C51
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

		// Token: 0x17002564 RID: 9572
		// (get) Token: 0x0600B98D RID: 47501 RVA: 0x001B9A5A File Offset: 0x001B7C5A
		// (set) Token: 0x0600B98E RID: 47502 RVA: 0x001B9A62 File Offset: 0x001B7C62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RemainTick
		{
			get
			{
				return this.remainTick_;
			}
			set
			{
				this.remainTick_ = value;
			}
		}

		// Token: 0x0600B98F RID: 47503 RVA: 0x001B9A6B File Offset: 0x001B7C6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InstanceTimer);
		}

		// Token: 0x0600B990 RID: 47504 RVA: 0x001B9A79 File Offset: 0x001B7C79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InstanceTimer other)
		{
			return other != null && (other == this || (this.Status == other.Status && this.RemainTick == other.RemainTick && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B991 RID: 47505 RVA: 0x001B9AB8 File Offset: 0x001B7CB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Status != 0)
			{
				num ^= this.Status.GetHashCode();
			}
			if (this.RemainTick != 0)
			{
				num ^= this.RemainTick.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B992 RID: 47506 RVA: 0x001B9B10 File Offset: 0x001B7D10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B993 RID: 47507 RVA: 0x001B9B1D File Offset: 0x001B7D1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B994 RID: 47508 RVA: 0x001B9B28 File Offset: 0x001B7D28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Status != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Status);
			}
			if (this.RemainTick != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.RemainTick);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B995 RID: 47509 RVA: 0x001B9B80 File Offset: 0x001B7D80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Status != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Status);
			}
			if (this.RemainTick != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RemainTick);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B996 RID: 47510 RVA: 0x001B9BD8 File Offset: 0x001B7DD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InstanceTimer other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Status != 0)
			{
				this.Status = other.Status;
			}
			if (other.RemainTick != 0)
			{
				this.RemainTick = other.RemainTick;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B997 RID: 47511 RVA: 0x001B9C28 File Offset: 0x001B7E28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B998 RID: 47512 RVA: 0x001B9C34 File Offset: 0x001B7E34
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
						this.RemainTick = input.ReadInt32();
					}
				}
				else
				{
					this.Status = input.ReadInt32();
				}
			}
		}

		// Token: 0x04005186 RID: 20870
		private static readonly MessageParser<InstanceTimer> _parser = new MessageParser<InstanceTimer>(() => new InstanceTimer());

		// Token: 0x04005187 RID: 20871
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005188 RID: 20872
		public const int StatusFieldNumber = 1;

		// Token: 0x04005189 RID: 20873
		private int status_;

		// Token: 0x0400518A RID: 20874
		public const int RemainTickFieldNumber = 2;

		// Token: 0x0400518B RID: 20875
		private int remainTick_;
	}
}
