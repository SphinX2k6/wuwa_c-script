using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001117 RID: 4375
	[NetMessage(EMessageId.RoverRogueRefreshGainRequest)]
	public sealed class RoverRogueRefreshGainRequest : IMessage<RoverRogueRefreshGainRequest>, IMessage, IEquatable<RoverRogueRefreshGainRequest>, IDeepCloneable<RoverRogueRefreshGainRequest>, IBufferMessage
	{
		// Token: 0x06017550 RID: 95568 RVA: 0x00363208 File Offset: 0x00361408
		[NullableContext(1)]
		public static RoverRogueRefreshGainRequest Create()
		{
			return new RoverRogueRefreshGainRequest();
		}

		// Token: 0x17004E3F RID: 20031
		// (get) Token: 0x06017551 RID: 95569 RVA: 0x0036320F File Offset: 0x0036140F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004E40 RID: 20032
		// (get) Token: 0x06017552 RID: 95570 RVA: 0x00363212 File Offset: 0x00361412
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoverRogueRefreshGainRequest.Descriptor;
			}
		}

		// Token: 0x06017553 RID: 95571 RVA: 0x00363219 File Offset: 0x00361419
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueRefreshGainRequest()
		{
		}

		// Token: 0x06017554 RID: 95572 RVA: 0x00363221 File Offset: 0x00361421
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueRefreshGainRequest(RoverRogueRefreshGainRequest other) : this()
		{
			this.bindId_ = other.bindId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017555 RID: 95573 RVA: 0x00363246 File Offset: 0x00361446
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueRefreshGainRequest Clone()
		{
			return new RoverRogueRefreshGainRequest(this);
		}

		// Token: 0x17004E41 RID: 20033
		// (get) Token: 0x06017556 RID: 95574 RVA: 0x0036324E File Offset: 0x0036144E
		// (set) Token: 0x06017557 RID: 95575 RVA: 0x00363256 File Offset: 0x00361456
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BindId
		{
			get
			{
				return this.bindId_;
			}
			set
			{
				this.bindId_ = value;
			}
		}

		// Token: 0x06017558 RID: 95576 RVA: 0x0036325F File Offset: 0x0036145F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoverRogueRefreshGainRequest);
		}

		// Token: 0x06017559 RID: 95577 RVA: 0x0036326D File Offset: 0x0036146D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoverRogueRefreshGainRequest other)
		{
			return other != null && (other == this || (this.BindId == other.BindId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601755A RID: 95578 RVA: 0x0036329C File Offset: 0x0036149C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.BindId != 0)
			{
				num ^= this.BindId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601755B RID: 95579 RVA: 0x003632DB File Offset: 0x003614DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601755C RID: 95580 RVA: 0x003632E8 File Offset: 0x003614E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601755D RID: 95581 RVA: 0x003632F1 File Offset: 0x003614F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.BindId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.BindId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601755E RID: 95582 RVA: 0x00363324 File Offset: 0x00361524
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.BindId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BindId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601755F RID: 95583 RVA: 0x00363362 File Offset: 0x00361562
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoverRogueRefreshGainRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.BindId != 0)
			{
				this.BindId = other.BindId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06017560 RID: 95584 RVA: 0x00363393 File Offset: 0x00361593
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017561 RID: 95585 RVA: 0x0036339C File Offset: 0x0036159C
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
				if (num != 88U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.BindId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04008ABA RID: 35514
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008ABB RID: 35515
		public const int BindIdFieldNumber = 11;

		// Token: 0x04008ABC RID: 35516
		private int bindId_;
	}
}
