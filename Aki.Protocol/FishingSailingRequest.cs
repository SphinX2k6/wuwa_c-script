using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000576 RID: 1398
	[NetMessage(EMessageId.FishingSailingRequest)]
	public sealed class FishingSailingRequest : IMessage<FishingSailingRequest>, IMessage, IEquatable<FishingSailingRequest>, IDeepCloneable<FishingSailingRequest>, IBufferMessage
	{
		// Token: 0x0600820A RID: 33290 RVA: 0x00139EB1 File Offset: 0x001380B1
		[NullableContext(1)]
		public static FishingSailingRequest Create()
		{
			return new FishingSailingRequest();
		}

		// Token: 0x1700195A RID: 6490
		// (get) Token: 0x0600820B RID: 33291 RVA: 0x00139EB8 File Offset: 0x001380B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700195B RID: 6491
		// (get) Token: 0x0600820C RID: 33292 RVA: 0x00139EBB File Offset: 0x001380BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingSailingRequest.Descriptor;
			}
		}

		// Token: 0x0600820D RID: 33293 RVA: 0x00139EC2 File Offset: 0x001380C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingSailingRequest()
		{
		}

		// Token: 0x0600820E RID: 33294 RVA: 0x00139ECA File Offset: 0x001380CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingSailingRequest(FishingSailingRequest other) : this()
		{
			this.fix_ = other.fix_;
			this.portId_ = other.portId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600820F RID: 33295 RVA: 0x00139EFB File Offset: 0x001380FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingSailingRequest Clone()
		{
			return new FishingSailingRequest(this);
		}

		// Token: 0x1700195C RID: 6492
		// (get) Token: 0x06008210 RID: 33296 RVA: 0x00139F03 File Offset: 0x00138103
		// (set) Token: 0x06008211 RID: 33297 RVA: 0x00139F0B File Offset: 0x0013810B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Fix
		{
			get
			{
				return this.fix_;
			}
			set
			{
				this.fix_ = value;
			}
		}

		// Token: 0x1700195D RID: 6493
		// (get) Token: 0x06008212 RID: 33298 RVA: 0x00139F14 File Offset: 0x00138114
		// (set) Token: 0x06008213 RID: 33299 RVA: 0x00139F1C File Offset: 0x0013811C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PortId
		{
			get
			{
				return this.portId_;
			}
			set
			{
				this.portId_ = value;
			}
		}

		// Token: 0x06008214 RID: 33300 RVA: 0x00139F25 File Offset: 0x00138125
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingSailingRequest);
		}

		// Token: 0x06008215 RID: 33301 RVA: 0x00139F33 File Offset: 0x00138133
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingSailingRequest other)
		{
			return other != null && (other == this || (this.Fix == other.Fix && this.PortId == other.PortId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008216 RID: 33302 RVA: 0x00139F74 File Offset: 0x00138174
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Fix)
			{
				num ^= this.Fix.GetHashCode();
			}
			if (this.PortId != 0)
			{
				num ^= this.PortId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008217 RID: 33303 RVA: 0x00139FCC File Offset: 0x001381CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008218 RID: 33304 RVA: 0x00139FD9 File Offset: 0x001381D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008219 RID: 33305 RVA: 0x00139FE4 File Offset: 0x001381E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PortId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.PortId);
			}
			if (this.Fix)
			{
				output.WriteRawTag(120);
				output.WriteBool(this.Fix);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600821A RID: 33306 RVA: 0x0013A040 File Offset: 0x00138240
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Fix)
			{
				num += 2;
			}
			if (this.PortId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PortId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600821B RID: 33307 RVA: 0x0013A08C File Offset: 0x0013828C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FishingSailingRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Fix)
			{
				this.Fix = other.Fix;
			}
			if (other.PortId != 0)
			{
				this.PortId = other.PortId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600821C RID: 33308 RVA: 0x0013A0DC File Offset: 0x001382DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600821D RID: 33309 RVA: 0x0013A0E8 File Offset: 0x001382E8
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
				if (num != 104U)
				{
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Fix = input.ReadBool();
					}
				}
				else
				{
					this.PortId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004128 RID: 16680
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004129 RID: 16681
		public const int FixFieldNumber = 15;

		// Token: 0x0400412A RID: 16682
		private bool fix_;

		// Token: 0x0400412B RID: 16683
		public const int PortIdFieldNumber = 13;

		// Token: 0x0400412C RID: 16684
		private int portId_;
	}
}
