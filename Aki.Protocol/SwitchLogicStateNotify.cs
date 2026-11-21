using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200136C RID: 4972
	[NetMessage(EMessageId.SwitchLogicStateNotify)]
	public sealed class SwitchLogicStateNotify : IMessage<SwitchLogicStateNotify>, IMessage, IEquatable<SwitchLogicStateNotify>, IDeepCloneable<SwitchLogicStateNotify>, IBufferMessage
	{
		// Token: 0x0601A7B0 RID: 108464 RVA: 0x003DBD29 File Offset: 0x003D9F29
		[NullableContext(1)]
		public static SwitchLogicStateNotify Create()
		{
			return new SwitchLogicStateNotify();
		}

		// Token: 0x170059A8 RID: 22952
		// (get) Token: 0x0601A7B1 RID: 108465 RVA: 0x003DBD30 File Offset: 0x003D9F30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170059A9 RID: 22953
		// (get) Token: 0x0601A7B2 RID: 108466 RVA: 0x003DBD33 File Offset: 0x003D9F33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SwitchLogicStateNotify.Descriptor;
			}
		}

		// Token: 0x0601A7B3 RID: 108467 RVA: 0x003DBD3A File Offset: 0x003D9F3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwitchLogicStateNotify()
		{
		}

		// Token: 0x0601A7B4 RID: 108468 RVA: 0x003DBD42 File Offset: 0x003D9F42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwitchLogicStateNotify(SwitchLogicStateNotify other) : this()
		{
			this.states_ = ((other.states_ != null) ? other.states_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A7B5 RID: 108469 RVA: 0x003DBD77 File Offset: 0x003D9F77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwitchLogicStateNotify Clone()
		{
			return new SwitchLogicStateNotify(this);
		}

		// Token: 0x170059AA RID: 22954
		// (get) Token: 0x0601A7B6 RID: 108470 RVA: 0x003DBD7F File Offset: 0x003D9F7F
		// (set) Token: 0x0601A7B7 RID: 108471 RVA: 0x003DBD87 File Offset: 0x003D9F87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LogicStateComponentPb States
		{
			get
			{
				return this.states_;
			}
			set
			{
				this.states_ = value;
			}
		}

		// Token: 0x0601A7B8 RID: 108472 RVA: 0x003DBD90 File Offset: 0x003D9F90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SwitchLogicStateNotify);
		}

		// Token: 0x0601A7B9 RID: 108473 RVA: 0x003DBD9E File Offset: 0x003D9F9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SwitchLogicStateNotify other)
		{
			return other != null && (other == this || (object.Equals(this.States, other.States) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A7BA RID: 108474 RVA: 0x003DBDD4 File Offset: 0x003D9FD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.states_ != null)
			{
				num ^= this.States.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601A7BB RID: 108475 RVA: 0x003DBE10 File Offset: 0x003DA010
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A7BC RID: 108476 RVA: 0x003DBE1D File Offset: 0x003DA01D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A7BD RID: 108477 RVA: 0x003DBE26 File Offset: 0x003DA026
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.states_ != null)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.States);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A7BE RID: 108478 RVA: 0x003DBE58 File Offset: 0x003DA058
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.states_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.States);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601A7BF RID: 108479 RVA: 0x003DBE98 File Offset: 0x003DA098
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SwitchLogicStateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.states_ != null)
			{
				if (this.states_ == null)
				{
					this.States = new LogicStateComponentPb();
				}
				this.States.MergeFrom(other.States);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601A7C0 RID: 108480 RVA: 0x003DBEEC File Offset: 0x003DA0EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A7C1 RID: 108481 RVA: 0x003DBEF8 File Offset: 0x003DA0F8
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
				if (num != 66U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.states_ == null)
					{
						this.States = new LogicStateComponentPb();
					}
					input.ReadMessage(this.States);
				}
			}
		}

		// Token: 0x04009B54 RID: 39764
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009B55 RID: 39765
		public const int StatesFieldNumber = 8;

		// Token: 0x04009B56 RID: 39766
		private LogicStateComponentPb states_;
	}
}
