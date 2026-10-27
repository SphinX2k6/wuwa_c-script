using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000582 RID: 1410
	[NetMessage(EMessageId.FishingShipSkinChangeRequest)]
	public sealed class FishingShipSkinChangeRequest : IMessage<FishingShipSkinChangeRequest>, IMessage, IEquatable<FishingShipSkinChangeRequest>, IDeepCloneable<FishingShipSkinChangeRequest>, IBufferMessage
	{
		// Token: 0x060082F4 RID: 33524 RVA: 0x0013BC9C File Offset: 0x00139E9C
		[NullableContext(1)]
		public static FishingShipSkinChangeRequest Create()
		{
			return new FishingShipSkinChangeRequest();
		}

		// Token: 0x17001987 RID: 6535
		// (get) Token: 0x060082F5 RID: 33525 RVA: 0x0013BCA3 File Offset: 0x00139EA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001988 RID: 6536
		// (get) Token: 0x060082F6 RID: 33526 RVA: 0x0013BCA6 File Offset: 0x00139EA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingShipSkinChangeRequest.Descriptor;
			}
		}

		// Token: 0x060082F7 RID: 33527 RVA: 0x0013BCAD File Offset: 0x00139EAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingShipSkinChangeRequest()
		{
		}

		// Token: 0x060082F8 RID: 33528 RVA: 0x0013BCB5 File Offset: 0x00139EB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingShipSkinChangeRequest(FishingShipSkinChangeRequest other) : this()
		{
			this.skinId_ = other.skinId_;
			this.portId_ = other.portId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060082F9 RID: 33529 RVA: 0x0013BCE6 File Offset: 0x00139EE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingShipSkinChangeRequest Clone()
		{
			return new FishingShipSkinChangeRequest(this);
		}

		// Token: 0x17001989 RID: 6537
		// (get) Token: 0x060082FA RID: 33530 RVA: 0x0013BCEE File Offset: 0x00139EEE
		// (set) Token: 0x060082FB RID: 33531 RVA: 0x0013BCF6 File Offset: 0x00139EF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SkinId
		{
			get
			{
				return this.skinId_;
			}
			set
			{
				this.skinId_ = value;
			}
		}

		// Token: 0x1700198A RID: 6538
		// (get) Token: 0x060082FC RID: 33532 RVA: 0x0013BCFF File Offset: 0x00139EFF
		// (set) Token: 0x060082FD RID: 33533 RVA: 0x0013BD07 File Offset: 0x00139F07
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

		// Token: 0x060082FE RID: 33534 RVA: 0x0013BD10 File Offset: 0x00139F10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingShipSkinChangeRequest);
		}

		// Token: 0x060082FF RID: 33535 RVA: 0x0013BD1E File Offset: 0x00139F1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingShipSkinChangeRequest other)
		{
			return other != null && (other == this || (this.SkinId == other.SkinId && this.PortId == other.PortId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008300 RID: 33536 RVA: 0x0013BD5C File Offset: 0x00139F5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SkinId != 0)
			{
				num ^= this.SkinId.GetHashCode();
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

		// Token: 0x06008301 RID: 33537 RVA: 0x0013BDB4 File Offset: 0x00139FB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008302 RID: 33538 RVA: 0x0013BDC1 File Offset: 0x00139FC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008303 RID: 33539 RVA: 0x0013BDCC File Offset: 0x00139FCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PortId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.PortId);
			}
			if (this.SkinId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.SkinId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008304 RID: 33540 RVA: 0x0013BE28 File Offset: 0x0013A028
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SkinId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SkinId);
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

		// Token: 0x06008305 RID: 33541 RVA: 0x0013BE80 File Offset: 0x0013A080
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FishingShipSkinChangeRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SkinId != 0)
			{
				this.SkinId = other.SkinId;
			}
			if (other.PortId != 0)
			{
				this.PortId = other.PortId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008306 RID: 33542 RVA: 0x0013BED0 File Offset: 0x0013A0D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008307 RID: 33543 RVA: 0x0013BEDC File Offset: 0x0013A0DC
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
				if (num != 16U)
				{
					if (num != 72U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.SkinId = input.ReadInt32();
					}
				}
				else
				{
					this.PortId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004161 RID: 16737
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004162 RID: 16738
		public const int SkinIdFieldNumber = 9;

		// Token: 0x04004163 RID: 16739
		private int skinId_;

		// Token: 0x04004164 RID: 16740
		public const int PortIdFieldNumber = 2;

		// Token: 0x04004165 RID: 16741
		private int portId_;
	}
}
