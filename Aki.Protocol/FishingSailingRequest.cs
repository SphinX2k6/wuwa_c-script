using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000561 RID: 1377
	[NetMessage(EMessageId.FishingSailingRequest)]
	public sealed class FishingSailingRequest : IMessage<FishingSailingRequest>, IMessage, IEquatable<FishingSailingRequest>, IDeepCloneable<FishingSailingRequest>, IBufferMessage
	{
		// Token: 0x060080A2 RID: 32930 RVA: 0x001372B1 File Offset: 0x001354B1
		[NullableContext(1)]
		public static FishingSailingRequest Create()
		{
			return new FishingSailingRequest();
		}

		// Token: 0x1700190D RID: 6413
		// (get) Token: 0x060080A3 RID: 32931 RVA: 0x001372B8 File Offset: 0x001354B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700190E RID: 6414
		// (get) Token: 0x060080A4 RID: 32932 RVA: 0x001372BB File Offset: 0x001354BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingSailingRequest.Descriptor;
			}
		}

		// Token: 0x060080A5 RID: 32933 RVA: 0x001372C2 File Offset: 0x001354C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingSailingRequest()
		{
		}

		// Token: 0x060080A6 RID: 32934 RVA: 0x001372CA File Offset: 0x001354CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingSailingRequest(FishingSailingRequest other) : this()
		{
			this.fix_ = other.fix_;
			this.portId_ = other.portId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060080A7 RID: 32935 RVA: 0x001372FB File Offset: 0x001354FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingSailingRequest Clone()
		{
			return new FishingSailingRequest(this);
		}

		// Token: 0x1700190F RID: 6415
		// (get) Token: 0x060080A8 RID: 32936 RVA: 0x00137303 File Offset: 0x00135503
		// (set) Token: 0x060080A9 RID: 32937 RVA: 0x0013730B File Offset: 0x0013550B
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

		// Token: 0x17001910 RID: 6416
		// (get) Token: 0x060080AA RID: 32938 RVA: 0x00137314 File Offset: 0x00135514
		// (set) Token: 0x060080AB RID: 32939 RVA: 0x0013731C File Offset: 0x0013551C
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

		// Token: 0x060080AC RID: 32940 RVA: 0x00137325 File Offset: 0x00135525
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingSailingRequest);
		}

		// Token: 0x060080AD RID: 32941 RVA: 0x00137333 File Offset: 0x00135533
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingSailingRequest other)
		{
			return other != null && (other == this || (this.Fix == other.Fix && this.PortId == other.PortId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060080AE RID: 32942 RVA: 0x00137374 File Offset: 0x00135574
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

		// Token: 0x060080AF RID: 32943 RVA: 0x001373CC File Offset: 0x001355CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060080B0 RID: 32944 RVA: 0x001373D9 File Offset: 0x001355D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060080B1 RID: 32945 RVA: 0x001373E4 File Offset: 0x001355E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Fix)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.Fix);
			}
			if (this.PortId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.PortId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060080B2 RID: 32946 RVA: 0x0013743C File Offset: 0x0013563C
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

		// Token: 0x060080B3 RID: 32947 RVA: 0x00137488 File Offset: 0x00135688
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

		// Token: 0x060080B4 RID: 32948 RVA: 0x001374D8 File Offset: 0x001356D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060080B5 RID: 32949 RVA: 0x001374E4 File Offset: 0x001356E4
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
					if (num != 32U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.PortId = input.ReadInt32();
					}
				}
				else
				{
					this.Fix = input.ReadBool();
				}
			}
		}

		// Token: 0x0400411E RID: 16670
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400411F RID: 16671
		public const int FixFieldNumber = 1;

		// Token: 0x04004120 RID: 16672
		private bool fix_;

		// Token: 0x04004121 RID: 16673
		public const int PortIdFieldNumber = 4;

		// Token: 0x04004122 RID: 16674
		private int portId_;
	}
}
