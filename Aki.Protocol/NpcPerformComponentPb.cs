using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B55 RID: 2901
	public sealed class NpcPerformComponentPb : IMessage<NpcPerformComponentPb>, IMessage, IEquatable<NpcPerformComponentPb>, IDeepCloneable<NpcPerformComponentPb>, IBufferMessage
	{
		// Token: 0x0600FBB2 RID: 64434 RVA: 0x0024AC30 File Offset: 0x00248E30
		[NullableContext(1)]
		public static NpcPerformComponentPb Create()
		{
			return new NpcPerformComponentPb();
		}

		// Token: 0x17003349 RID: 13129
		// (get) Token: 0x0600FBB3 RID: 64435 RVA: 0x0024AC37 File Offset: 0x00248E37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700334A RID: 13130
		// (get) Token: 0x0600FBB4 RID: 64436 RVA: 0x0024AC3A File Offset: 0x00248E3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NpcPerformComponentPb.Descriptor;
			}
		}

		// Token: 0x0600FBB5 RID: 64437 RVA: 0x0024AC41 File Offset: 0x00248E41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcPerformComponentPb()
		{
		}

		// Token: 0x0600FBB6 RID: 64438 RVA: 0x0024AC5F File Offset: 0x00248E5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcPerformComponentPb(NpcPerformComponentPb other) : this()
		{
			this.type_ = other.type_;
			this.state_ = other.state_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600FBB7 RID: 64439 RVA: 0x0024AC90 File Offset: 0x00248E90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcPerformComponentPb Clone()
		{
			return new NpcPerformComponentPb(this);
		}

		// Token: 0x1700334B RID: 13131
		// (get) Token: 0x0600FBB8 RID: 64440 RVA: 0x0024AC98 File Offset: 0x00248E98
		// (set) Token: 0x0600FBB9 RID: 64441 RVA: 0x0024ACA0 File Offset: 0x00248EA0
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

		// Token: 0x1700334C RID: 13132
		// (get) Token: 0x0600FBBA RID: 64442 RVA: 0x0024ACB3 File Offset: 0x00248EB3
		// (set) Token: 0x0600FBBB RID: 64443 RVA: 0x0024ACBB File Offset: 0x00248EBB
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

		// Token: 0x0600FBBC RID: 64444 RVA: 0x0024ACCE File Offset: 0x00248ECE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NpcPerformComponentPb);
		}

		// Token: 0x0600FBBD RID: 64445 RVA: 0x0024ACDC File Offset: 0x00248EDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NpcPerformComponentPb other)
		{
			return other != null && (other == this || (!(this.Type != other.Type) && !(this.State != other.State) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600FBBE RID: 64446 RVA: 0x0024AD30 File Offset: 0x00248F30
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

		// Token: 0x0600FBBF RID: 64447 RVA: 0x0024AD8C File Offset: 0x00248F8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600FBC0 RID: 64448 RVA: 0x0024AD99 File Offset: 0x00248F99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600FBC1 RID: 64449 RVA: 0x0024ADA4 File Offset: 0x00248FA4
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

		// Token: 0x0600FBC2 RID: 64450 RVA: 0x0024AE08 File Offset: 0x00249008
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

		// Token: 0x0600FBC3 RID: 64451 RVA: 0x0024AE68 File Offset: 0x00249068
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

		// Token: 0x0600FBC4 RID: 64452 RVA: 0x0024AEC2 File Offset: 0x002490C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600FBC5 RID: 64453 RVA: 0x0024AECC File Offset: 0x002490CC
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

		// Token: 0x040064E4 RID: 25828
		private UnknownFieldSet _unknownFields;

		// Token: 0x040064E5 RID: 25829
		public const int TypeFieldNumber = 1;

		// Token: 0x040064E6 RID: 25830
		private string type_ = "";

		// Token: 0x040064E7 RID: 25831
		public const int StateFieldNumber = 2;

		// Token: 0x040064E8 RID: 25832
		private string state_ = "";
	}
}
