using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000264 RID: 612
	[NetMessage(EMessageId.ChangeStateConfirmRequest)]
	public sealed class ChangeStateConfirmRequest : IMessage<ChangeStateConfirmRequest>, IMessage, IEquatable<ChangeStateConfirmRequest>, IDeepCloneable<ChangeStateConfirmRequest>, IBufferMessage
	{
		// Token: 0x060040EC RID: 16620 RVA: 0x0009F988 File Offset: 0x0009DB88
		[NullableContext(1)]
		public static ChangeStateConfirmRequest Create()
		{
			return new ChangeStateConfirmRequest();
		}

		// Token: 0x17000AE9 RID: 2793
		// (get) Token: 0x060040ED RID: 16621 RVA: 0x0009F98F File Offset: 0x0009DB8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000AEA RID: 2794
		// (get) Token: 0x060040EE RID: 16622 RVA: 0x0009F992 File Offset: 0x0009DB92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChangeStateConfirmRequest.Descriptor;
			}
		}

		// Token: 0x060040EF RID: 16623 RVA: 0x0009F999 File Offset: 0x0009DB99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeStateConfirmRequest()
		{
		}

		// Token: 0x060040F0 RID: 16624 RVA: 0x0009F9A1 File Offset: 0x0009DBA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeStateConfirmRequest(ChangeStateConfirmRequest other) : this()
		{
			this.fsmId_ = other.fsmId_;
			this.state_ = other.state_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060040F1 RID: 16625 RVA: 0x0009F9D2 File Offset: 0x0009DBD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeStateConfirmRequest Clone()
		{
			return new ChangeStateConfirmRequest(this);
		}

		// Token: 0x17000AEB RID: 2795
		// (get) Token: 0x060040F2 RID: 16626 RVA: 0x0009F9DA File Offset: 0x0009DBDA
		// (set) Token: 0x060040F3 RID: 16627 RVA: 0x0009F9E2 File Offset: 0x0009DBE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int FsmId
		{
			get
			{
				return this.fsmId_;
			}
			set
			{
				this.fsmId_ = value;
			}
		}

		// Token: 0x17000AEC RID: 2796
		// (get) Token: 0x060040F4 RID: 16628 RVA: 0x0009F9EB File Offset: 0x0009DBEB
		// (set) Token: 0x060040F5 RID: 16629 RVA: 0x0009F9F3 File Offset: 0x0009DBF3
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

		// Token: 0x060040F6 RID: 16630 RVA: 0x0009F9FC File Offset: 0x0009DBFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChangeStateConfirmRequest);
		}

		// Token: 0x060040F7 RID: 16631 RVA: 0x0009FA0A File Offset: 0x0009DC0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChangeStateConfirmRequest other)
		{
			return other != null && (other == this || (this.FsmId == other.FsmId && this.State == other.State && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060040F8 RID: 16632 RVA: 0x0009FA48 File Offset: 0x0009DC48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.FsmId != 0)
			{
				num ^= this.FsmId.GetHashCode();
			}
			if (this.State != 0)
			{
				num ^= this.State.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060040F9 RID: 16633 RVA: 0x0009FAA0 File Offset: 0x0009DCA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060040FA RID: 16634 RVA: 0x0009FAAD File Offset: 0x0009DCAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060040FB RID: 16635 RVA: 0x0009FAB8 File Offset: 0x0009DCB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.State != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.State);
			}
			if (this.FsmId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.FsmId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060040FC RID: 16636 RVA: 0x0009FB14 File Offset: 0x0009DD14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.FsmId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FsmId);
			}
			if (this.State != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.State);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060040FD RID: 16637 RVA: 0x0009FB6C File Offset: 0x0009DD6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChangeStateConfirmRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.FsmId != 0)
			{
				this.FsmId = other.FsmId;
			}
			if (other.State != 0)
			{
				this.State = other.State;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060040FE RID: 16638 RVA: 0x0009FBBC File Offset: 0x0009DDBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060040FF RID: 16639 RVA: 0x0009FBC8 File Offset: 0x0009DDC8
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
				if (num != 40U)
				{
					if (num != 112U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.FsmId = input.ReadInt32();
					}
				}
				else
				{
					this.State = input.ReadInt32();
				}
			}
		}

		// Token: 0x04002DD8 RID: 11736
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002DD9 RID: 11737
		public const int FsmIdFieldNumber = 14;

		// Token: 0x04002DDA RID: 11738
		private int fsmId_;

		// Token: 0x04002DDB RID: 11739
		public const int StateFieldNumber = 5;

		// Token: 0x04002DDC RID: 11740
		private int state_;
	}
}
