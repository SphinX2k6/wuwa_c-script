using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200056D RID: 1389
	[NetMessage(EMessageId.FishingShipSkinChangeRequest)]
	public sealed class FishingShipSkinChangeRequest : IMessage<FishingShipSkinChangeRequest>, IMessage, IEquatable<FishingShipSkinChangeRequest>, IDeepCloneable<FishingShipSkinChangeRequest>, IBufferMessage
	{
		// Token: 0x0600818C RID: 33164 RVA: 0x00139094 File Offset: 0x00137294
		[NullableContext(1)]
		public static FishingShipSkinChangeRequest Create()
		{
			return new FishingShipSkinChangeRequest();
		}

		// Token: 0x1700193A RID: 6458
		// (get) Token: 0x0600818D RID: 33165 RVA: 0x0013909B File Offset: 0x0013729B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700193B RID: 6459
		// (get) Token: 0x0600818E RID: 33166 RVA: 0x0013909E File Offset: 0x0013729E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingShipSkinChangeRequest.Descriptor;
			}
		}

		// Token: 0x0600818F RID: 33167 RVA: 0x001390A5 File Offset: 0x001372A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingShipSkinChangeRequest()
		{
		}

		// Token: 0x06008190 RID: 33168 RVA: 0x001390AD File Offset: 0x001372AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingShipSkinChangeRequest(FishingShipSkinChangeRequest other) : this()
		{
			this.skinId_ = other.skinId_;
			this.portId_ = other.portId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008191 RID: 33169 RVA: 0x001390DE File Offset: 0x001372DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingShipSkinChangeRequest Clone()
		{
			return new FishingShipSkinChangeRequest(this);
		}

		// Token: 0x1700193C RID: 6460
		// (get) Token: 0x06008192 RID: 33170 RVA: 0x001390E6 File Offset: 0x001372E6
		// (set) Token: 0x06008193 RID: 33171 RVA: 0x001390EE File Offset: 0x001372EE
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

		// Token: 0x1700193D RID: 6461
		// (get) Token: 0x06008194 RID: 33172 RVA: 0x001390F7 File Offset: 0x001372F7
		// (set) Token: 0x06008195 RID: 33173 RVA: 0x001390FF File Offset: 0x001372FF
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

		// Token: 0x06008196 RID: 33174 RVA: 0x00139108 File Offset: 0x00137308
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingShipSkinChangeRequest);
		}

		// Token: 0x06008197 RID: 33175 RVA: 0x00139116 File Offset: 0x00137316
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingShipSkinChangeRequest other)
		{
			return other != null && (other == this || (this.SkinId == other.SkinId && this.PortId == other.PortId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008198 RID: 33176 RVA: 0x00139154 File Offset: 0x00137354
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

		// Token: 0x06008199 RID: 33177 RVA: 0x001391AC File Offset: 0x001373AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600819A RID: 33178 RVA: 0x001391B9 File Offset: 0x001373B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600819B RID: 33179 RVA: 0x001391C4 File Offset: 0x001373C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SkinId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.SkinId);
			}
			if (this.PortId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.PortId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600819C RID: 33180 RVA: 0x0013921C File Offset: 0x0013741C
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

		// Token: 0x0600819D RID: 33181 RVA: 0x00139274 File Offset: 0x00137474
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

		// Token: 0x0600819E RID: 33182 RVA: 0x001392C4 File Offset: 0x001374C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600819F RID: 33183 RVA: 0x001392D0 File Offset: 0x001374D0
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
					if (num != 40U)
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
					this.SkinId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004157 RID: 16727
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004158 RID: 16728
		public const int SkinIdFieldNumber = 1;

		// Token: 0x04004159 RID: 16729
		private int skinId_;

		// Token: 0x0400415A RID: 16730
		public const int PortIdFieldNumber = 5;

		// Token: 0x0400415B RID: 16731
		private int portId_;
	}
}
