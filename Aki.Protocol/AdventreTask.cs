using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020000B9 RID: 185
	public sealed class AdventreTask : IMessage<AdventreTask>, IMessage, IEquatable<AdventreTask>, IDeepCloneable<AdventreTask>, IBufferMessage
	{
		// Token: 0x06001E5C RID: 7772 RVA: 0x000530CD File Offset: 0x000512CD
		[NullableContext(1)]
		public static AdventreTask Create()
		{
			return new AdventreTask();
		}

		// Token: 0x1700037E RID: 894
		// (get) Token: 0x06001E5D RID: 7773 RVA: 0x000530D4 File Offset: 0x000512D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AdventreTask> Parser
		{
			get
			{
				return AdventreTask._parser;
			}
		}

		// Token: 0x1700037F RID: 895
		// (get) Token: 0x06001E5E RID: 7774 RVA: 0x000530DB File Offset: 0x000512DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000380 RID: 896
		// (get) Token: 0x06001E5F RID: 7775 RVA: 0x000530DE File Offset: 0x000512DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AdventreTask.Descriptor;
			}
		}

		// Token: 0x06001E60 RID: 7776 RVA: 0x000530E5 File Offset: 0x000512E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdventreTask()
		{
		}

		// Token: 0x06001E61 RID: 7777 RVA: 0x000530ED File Offset: 0x000512ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdventreTask(AdventreTask other) : this()
		{
			this.id_ = other.id_;
			this.state_ = other.state_;
			this.adventreProgress_ = other.adventreProgress_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001E62 RID: 7778 RVA: 0x0005312A File Offset: 0x0005132A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdventreTask Clone()
		{
			return new AdventreTask(this);
		}

		// Token: 0x17000381 RID: 897
		// (get) Token: 0x06001E63 RID: 7779 RVA: 0x00053132 File Offset: 0x00051332
		// (set) Token: 0x06001E64 RID: 7780 RVA: 0x0005313A File Offset: 0x0005133A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x17000382 RID: 898
		// (get) Token: 0x06001E65 RID: 7781 RVA: 0x00053143 File Offset: 0x00051343
		// (set) Token: 0x06001E66 RID: 7782 RVA: 0x0005314B File Offset: 0x0005134B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int State
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

		// Token: 0x17000383 RID: 899
		// (get) Token: 0x06001E67 RID: 7783 RVA: 0x00053154 File Offset: 0x00051354
		// (set) Token: 0x06001E68 RID: 7784 RVA: 0x0005315C File Offset: 0x0005135C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int AdventreProgress
		{
			get
			{
				return this.adventreProgress_;
			}
			set
			{
				this.adventreProgress_ = value;
			}
		}

		// Token: 0x06001E69 RID: 7785 RVA: 0x00053165 File Offset: 0x00051365
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AdventreTask);
		}

		// Token: 0x06001E6A RID: 7786 RVA: 0x00053174 File Offset: 0x00051374
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AdventreTask other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.State == other.State && this.AdventreProgress == other.AdventreProgress && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001E6B RID: 7787 RVA: 0x000531D0 File Offset: 0x000513D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.State != 0)
			{
				num ^= this.State.GetHashCode();
			}
			if (this.AdventreProgress != 0)
			{
				num ^= this.AdventreProgress.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001E6C RID: 7788 RVA: 0x00053241 File Offset: 0x00051441
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001E6D RID: 7789 RVA: 0x0005324E File Offset: 0x0005144E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001E6E RID: 7790 RVA: 0x00053258 File Offset: 0x00051458
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			if (this.State != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.State);
			}
			if (this.AdventreProgress != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.AdventreProgress);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001E6F RID: 7791 RVA: 0x000532CC File Offset: 0x000514CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.State != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.State);
			}
			if (this.AdventreProgress != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.AdventreProgress);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001E70 RID: 7792 RVA: 0x0005333C File Offset: 0x0005153C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AdventreTask other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.State != 0)
			{
				this.State = other.State;
			}
			if (other.AdventreProgress != 0)
			{
				this.AdventreProgress = other.AdventreProgress;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001E71 RID: 7793 RVA: 0x000533A0 File Offset: 0x000515A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001E72 RID: 7794 RVA: 0x000533AC File Offset: 0x000515AC
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
							this.AdventreProgress = input.ReadInt32();
						}
					}
					else
					{
						this.State = input.ReadInt32();
					}
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x040023A5 RID: 9125
		private static readonly MessageParser<AdventreTask> _parser = new MessageParser<AdventreTask>(() => new AdventreTask());

		// Token: 0x040023A6 RID: 9126
		private UnknownFieldSet _unknownFields;

		// Token: 0x040023A7 RID: 9127
		public const int IdFieldNumber = 1;

		// Token: 0x040023A8 RID: 9128
		private int id_;

		// Token: 0x040023A9 RID: 9129
		public const int StateFieldNumber = 2;

		// Token: 0x040023AA RID: 9130
		private int state_;

		// Token: 0x040023AB RID: 9131
		public const int AdventreProgressFieldNumber = 3;

		// Token: 0x040023AC RID: 9132
		private int adventreProgress_;
	}
}
