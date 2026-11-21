using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000808 RID: 2056
	public sealed class InstanceTimer : IMessage<InstanceTimer>, IMessage, IEquatable<InstanceTimer>, IDeepCloneable<InstanceTimer>, IBufferMessage
	{
		// Token: 0x0600B82E RID: 47150 RVA: 0x001B6FB4 File Offset: 0x001B51B4
		[NullableContext(1)]
		public static InstanceTimer Create()
		{
			return new InstanceTimer();
		}

		// Token: 0x17002516 RID: 9494
		// (get) Token: 0x0600B82F RID: 47151 RVA: 0x001B6FBB File Offset: 0x001B51BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<InstanceTimer> Parser
		{
			get
			{
				return InstanceTimer._parser;
			}
		}

		// Token: 0x17002517 RID: 9495
		// (get) Token: 0x0600B830 RID: 47152 RVA: 0x001B6FC2 File Offset: 0x001B51C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002518 RID: 9496
		// (get) Token: 0x0600B831 RID: 47153 RVA: 0x001B6FC5 File Offset: 0x001B51C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InstanceTimer.Descriptor;
			}
		}

		// Token: 0x0600B832 RID: 47154 RVA: 0x001B6FCC File Offset: 0x001B51CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InstanceTimer()
		{
		}

		// Token: 0x0600B833 RID: 47155 RVA: 0x001B6FD4 File Offset: 0x001B51D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InstanceTimer(InstanceTimer other) : this()
		{
			this.status_ = other.status_;
			this.remainTick_ = other.remainTick_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B834 RID: 47156 RVA: 0x001B7005 File Offset: 0x001B5205
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InstanceTimer Clone()
		{
			return new InstanceTimer(this);
		}

		// Token: 0x17002519 RID: 9497
		// (get) Token: 0x0600B835 RID: 47157 RVA: 0x001B700D File Offset: 0x001B520D
		// (set) Token: 0x0600B836 RID: 47158 RVA: 0x001B7015 File Offset: 0x001B5215
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

		// Token: 0x1700251A RID: 9498
		// (get) Token: 0x0600B837 RID: 47159 RVA: 0x001B701E File Offset: 0x001B521E
		// (set) Token: 0x0600B838 RID: 47160 RVA: 0x001B7026 File Offset: 0x001B5226
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

		// Token: 0x0600B839 RID: 47161 RVA: 0x001B702F File Offset: 0x001B522F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InstanceTimer);
		}

		// Token: 0x0600B83A RID: 47162 RVA: 0x001B703D File Offset: 0x001B523D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InstanceTimer other)
		{
			return other != null && (other == this || (this.Status == other.Status && this.RemainTick == other.RemainTick && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B83B RID: 47163 RVA: 0x001B707C File Offset: 0x001B527C
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

		// Token: 0x0600B83C RID: 47164 RVA: 0x001B70D4 File Offset: 0x001B52D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B83D RID: 47165 RVA: 0x001B70E1 File Offset: 0x001B52E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B83E RID: 47166 RVA: 0x001B70EC File Offset: 0x001B52EC
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

		// Token: 0x0600B83F RID: 47167 RVA: 0x001B7144 File Offset: 0x001B5344
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

		// Token: 0x0600B840 RID: 47168 RVA: 0x001B719C File Offset: 0x001B539C
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

		// Token: 0x0600B841 RID: 47169 RVA: 0x001B71EC File Offset: 0x001B53EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B842 RID: 47170 RVA: 0x001B71F8 File Offset: 0x001B53F8
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

		// Token: 0x0400517F RID: 20863
		private static readonly MessageParser<InstanceTimer> _parser = new MessageParser<InstanceTimer>(() => new InstanceTimer());

		// Token: 0x04005180 RID: 20864
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005181 RID: 20865
		public const int StatusFieldNumber = 1;

		// Token: 0x04005182 RID: 20866
		private int status_;

		// Token: 0x04005183 RID: 20867
		public const int RemainTickFieldNumber = 2;

		// Token: 0x04005184 RID: 20868
		private int remainTick_;
	}
}
