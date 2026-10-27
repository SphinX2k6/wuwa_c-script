using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010E9 RID: 4329
	[NetMessage(EMessageId.RollBlockToggleHintRequest)]
	public sealed class RollBlockToggleHintRequest : IMessage<RollBlockToggleHintRequest>, IMessage, IEquatable<RollBlockToggleHintRequest>, IDeepCloneable<RollBlockToggleHintRequest>, IBufferMessage
	{
		// Token: 0x06017163 RID: 94563 RVA: 0x003598B1 File Offset: 0x00357AB1
		[NullableContext(1)]
		public static RollBlockToggleHintRequest Create()
		{
			return new RollBlockToggleHintRequest();
		}

		// Token: 0x17004D52 RID: 19794
		// (get) Token: 0x06017164 RID: 94564 RVA: 0x003598B8 File Offset: 0x00357AB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004D53 RID: 19795
		// (get) Token: 0x06017165 RID: 94565 RVA: 0x003598BB File Offset: 0x00357ABB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RollBlockToggleHintRequest.Descriptor;
			}
		}

		// Token: 0x06017166 RID: 94566 RVA: 0x003598C2 File Offset: 0x00357AC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RollBlockToggleHintRequest()
		{
		}

		// Token: 0x06017167 RID: 94567 RVA: 0x003598CA File Offset: 0x00357ACA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RollBlockToggleHintRequest(RollBlockToggleHintRequest other) : this()
		{
			this.incId_ = other.incId_;
			this.isOpen_ = other.isOpen_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017168 RID: 94568 RVA: 0x003598FB File Offset: 0x00357AFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RollBlockToggleHintRequest Clone()
		{
			return new RollBlockToggleHintRequest(this);
		}

		// Token: 0x17004D54 RID: 19796
		// (get) Token: 0x06017169 RID: 94569 RVA: 0x00359903 File Offset: 0x00357B03
		// (set) Token: 0x0601716A RID: 94570 RVA: 0x0035990B File Offset: 0x00357B0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int IncId
		{
			get
			{
				return this.incId_;
			}
			set
			{
				this.incId_ = value;
			}
		}

		// Token: 0x17004D55 RID: 19797
		// (get) Token: 0x0601716B RID: 94571 RVA: 0x00359914 File Offset: 0x00357B14
		// (set) Token: 0x0601716C RID: 94572 RVA: 0x0035991C File Offset: 0x00357B1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsOpen
		{
			get
			{
				return this.isOpen_;
			}
			set
			{
				this.isOpen_ = value;
			}
		}

		// Token: 0x0601716D RID: 94573 RVA: 0x00359925 File Offset: 0x00357B25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RollBlockToggleHintRequest);
		}

		// Token: 0x0601716E RID: 94574 RVA: 0x00359933 File Offset: 0x00357B33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RollBlockToggleHintRequest other)
		{
			return other != null && (other == this || (this.IncId == other.IncId && this.IsOpen == other.IsOpen && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601716F RID: 94575 RVA: 0x00359974 File Offset: 0x00357B74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IncId != 0)
			{
				num ^= this.IncId.GetHashCode();
			}
			if (this.IsOpen)
			{
				num ^= this.IsOpen.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06017170 RID: 94576 RVA: 0x003599CC File Offset: 0x00357BCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017171 RID: 94577 RVA: 0x003599D9 File Offset: 0x00357BD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017172 RID: 94578 RVA: 0x003599E4 File Offset: 0x00357BE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsOpen)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.IsOpen);
			}
			if (this.IncId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.IncId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017173 RID: 94579 RVA: 0x00359A40 File Offset: 0x00357C40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IncId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.IncId);
			}
			if (this.IsOpen)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06017174 RID: 94580 RVA: 0x00359A8C File Offset: 0x00357C8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RollBlockToggleHintRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IncId != 0)
			{
				this.IncId = other.IncId;
			}
			if (other.IsOpen)
			{
				this.IsOpen = other.IsOpen;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06017175 RID: 94581 RVA: 0x00359ADC File Offset: 0x00357CDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017176 RID: 94582 RVA: 0x00359AE8 File Offset: 0x00357CE8
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
				if (num != 32U)
				{
					if (num != 112U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.IncId = input.ReadInt32();
					}
				}
				else
				{
					this.IsOpen = input.ReadBool();
				}
			}
		}

		// Token: 0x0400894E RID: 35150
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400894F RID: 35151
		public const int IncIdFieldNumber = 14;

		// Token: 0x04008950 RID: 35152
		private int incId_;

		// Token: 0x04008951 RID: 35153
		public const int IsOpenFieldNumber = 4;

		// Token: 0x04008952 RID: 35154
		private bool isOpen_;
	}
}
