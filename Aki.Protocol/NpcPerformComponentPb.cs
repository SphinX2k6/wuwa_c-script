using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B65 RID: 2917
	public sealed class NpcPerformComponentPb : IMessage<NpcPerformComponentPb>, IMessage, IEquatable<NpcPerformComponentPb>, IDeepCloneable<NpcPerformComponentPb>, IBufferMessage
	{
		// Token: 0x0600FCB6 RID: 64694 RVA: 0x0024CB00 File Offset: 0x0024AD00
		[NullableContext(1)]
		public static NpcPerformComponentPb Create()
		{
			return new NpcPerformComponentPb();
		}

		// Token: 0x17003382 RID: 13186
		// (get) Token: 0x0600FCB7 RID: 64695 RVA: 0x0024CB07 File Offset: 0x0024AD07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003383 RID: 13187
		// (get) Token: 0x0600FCB8 RID: 64696 RVA: 0x0024CB0A File Offset: 0x0024AD0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NpcPerformComponentPb.Descriptor;
			}
		}

		// Token: 0x0600FCB9 RID: 64697 RVA: 0x0024CB11 File Offset: 0x0024AD11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcPerformComponentPb()
		{
		}

		// Token: 0x0600FCBA RID: 64698 RVA: 0x0024CB2F File Offset: 0x0024AD2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcPerformComponentPb(NpcPerformComponentPb other) : this()
		{
			this.type_ = other.type_;
			this.state_ = other.state_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600FCBB RID: 64699 RVA: 0x0024CB60 File Offset: 0x0024AD60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcPerformComponentPb Clone()
		{
			return new NpcPerformComponentPb(this);
		}

		// Token: 0x17003384 RID: 13188
		// (get) Token: 0x0600FCBC RID: 64700 RVA: 0x0024CB68 File Offset: 0x0024AD68
		// (set) Token: 0x0600FCBD RID: 64701 RVA: 0x0024CB70 File Offset: 0x0024AD70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Type
		{
			get
			{
				return this.type_;
			}
			set
			{
				this.type_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17003385 RID: 13189
		// (get) Token: 0x0600FCBE RID: 64702 RVA: 0x0024CB83 File Offset: 0x0024AD83
		// (set) Token: 0x0600FCBF RID: 64703 RVA: 0x0024CB8B File Offset: 0x0024AD8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string State
		{
			get
			{
				return this.state_;
			}
			set
			{
				this.state_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x0600FCC0 RID: 64704 RVA: 0x0024CB9E File Offset: 0x0024AD9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NpcPerformComponentPb);
		}

		// Token: 0x0600FCC1 RID: 64705 RVA: 0x0024CBAC File Offset: 0x0024ADAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NpcPerformComponentPb other)
		{
			return other != null && (other == this || (!(this.Type != other.Type) && !(this.State != other.State) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600FCC2 RID: 64706 RVA: 0x0024CC00 File Offset: 0x0024AE00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Type.Length != 0)
			{
				num ^= this.Type.GetHashCode();
			}
			if (this.State.Length != 0)
			{
				num ^= this.State.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600FCC3 RID: 64707 RVA: 0x0024CC5C File Offset: 0x0024AE5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600FCC4 RID: 64708 RVA: 0x0024CC69 File Offset: 0x0024AE69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600FCC5 RID: 64709 RVA: 0x0024CC74 File Offset: 0x0024AE74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Type.Length != 0)
			{
				output.WriteRawTag(10);
				output.WriteString(this.Type);
			}
			if (this.State.Length != 0)
			{
				output.WriteRawTag(18);
				output.WriteString(this.State);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600FCC6 RID: 64710 RVA: 0x0024CCD8 File Offset: 0x0024AED8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Type.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Type);
			}
			if (this.State.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.State);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600FCC7 RID: 64711 RVA: 0x0024CD38 File Offset: 0x0024AF38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NpcPerformComponentPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Type.Length != 0)
			{
				this.Type = other.Type;
			}
			if (other.State.Length != 0)
			{
				this.State = other.State;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600FCC8 RID: 64712 RVA: 0x0024CD92 File Offset: 0x0024AF92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600FCC9 RID: 64713 RVA: 0x0024CD9C File Offset: 0x0024AF9C
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
				if (num != 10U)
				{
					if (num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.State = input.ReadString();
					}
				}
				else
				{
					this.Type = input.ReadString();
				}
			}
		}

		// Token: 0x040064D4 RID: 25812
		private UnknownFieldSet _unknownFields;

		// Token: 0x040064D5 RID: 25813
		public const int TypeFieldNumber = 1;

		// Token: 0x040064D6 RID: 25814
		private string type_ = "";

		// Token: 0x040064D7 RID: 25815
		public const int StateFieldNumber = 2;

		// Token: 0x040064D8 RID: 25816
		private string state_ = "";
	}
}
