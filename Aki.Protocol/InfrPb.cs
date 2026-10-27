using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007EA RID: 2026
	public sealed class InfrPb : IMessage<InfrPb>, IMessage, IEquatable<InfrPb>, IDeepCloneable<InfrPb>, IBufferMessage
	{
		// Token: 0x0600B5BF RID: 46527 RVA: 0x001B203A File Offset: 0x001B023A
		[NullableContext(1)]
		public static InfrPb Create()
		{
			return new InfrPb();
		}

		// Token: 0x170024A7 RID: 9383
		// (get) Token: 0x0600B5C0 RID: 46528 RVA: 0x001B2041 File Offset: 0x001B0241
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170024A8 RID: 9384
		// (get) Token: 0x0600B5C1 RID: 46529 RVA: 0x001B2044 File Offset: 0x001B0244
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InfrPb.Descriptor;
			}
		}

		// Token: 0x0600B5C2 RID: 46530 RVA: 0x001B204B File Offset: 0x001B024B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrPb()
		{
		}

		// Token: 0x0600B5C3 RID: 46531 RVA: 0x001B2054 File Offset: 0x001B0254
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrPb(InfrPb other) : this()
		{
			this.fireInfo_ = ((other.fireInfo_ != null) ? other.fireInfo_.Clone() : null);
			this.roadInfo_ = ((other.roadInfo_ != null) ? other.roadInfo_.Clone() : null);
			this.libraryInfo_ = ((other.libraryInfo_ != null) ? other.libraryInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B5C4 RID: 46532 RVA: 0x001B20CC File Offset: 0x001B02CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrPb Clone()
		{
			return new InfrPb(this);
		}

		// Token: 0x170024A9 RID: 9385
		// (get) Token: 0x0600B5C5 RID: 46533 RVA: 0x001B20D4 File Offset: 0x001B02D4
		// (set) Token: 0x0600B5C6 RID: 46534 RVA: 0x001B20DC File Offset: 0x001B02DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrFirePb FireInfo
		{
			get
			{
				return this.fireInfo_;
			}
			set
			{
				this.fireInfo_ = value;
			}
		}

		// Token: 0x170024AA RID: 9386
		// (get) Token: 0x0600B5C7 RID: 46535 RVA: 0x001B20E5 File Offset: 0x001B02E5
		// (set) Token: 0x0600B5C8 RID: 46536 RVA: 0x001B20ED File Offset: 0x001B02ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrRoadPb RoadInfo
		{
			get
			{
				return this.roadInfo_;
			}
			set
			{
				this.roadInfo_ = value;
			}
		}

		// Token: 0x170024AB RID: 9387
		// (get) Token: 0x0600B5C9 RID: 46537 RVA: 0x001B20F6 File Offset: 0x001B02F6
		// (set) Token: 0x0600B5CA RID: 46538 RVA: 0x001B20FE File Offset: 0x001B02FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrLibraryPb LibraryInfo
		{
			get
			{
				return this.libraryInfo_;
			}
			set
			{
				this.libraryInfo_ = value;
			}
		}

		// Token: 0x0600B5CB RID: 46539 RVA: 0x001B2107 File Offset: 0x001B0307
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InfrPb);
		}

		// Token: 0x0600B5CC RID: 46540 RVA: 0x001B2118 File Offset: 0x001B0318
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InfrPb other)
		{
			return other != null && (other == this || (object.Equals(this.FireInfo, other.FireInfo) && object.Equals(this.RoadInfo, other.RoadInfo) && object.Equals(this.LibraryInfo, other.LibraryInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B5CD RID: 46541 RVA: 0x001B2180 File Offset: 0x001B0380
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.fireInfo_ != null)
			{
				num ^= this.FireInfo.GetHashCode();
			}
			if (this.roadInfo_ != null)
			{
				num ^= this.RoadInfo.GetHashCode();
			}
			if (this.libraryInfo_ != null)
			{
				num ^= this.LibraryInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B5CE RID: 46542 RVA: 0x001B21E8 File Offset: 0x001B03E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B5CF RID: 46543 RVA: 0x001B21F5 File Offset: 0x001B03F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B5D0 RID: 46544 RVA: 0x001B2200 File Offset: 0x001B0400
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.fireInfo_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.FireInfo);
			}
			if (this.roadInfo_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.RoadInfo);
			}
			if (this.libraryInfo_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.LibraryInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B5D1 RID: 46545 RVA: 0x001B2278 File Offset: 0x001B0478
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.fireInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.FireInfo);
			}
			if (this.roadInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RoadInfo);
			}
			if (this.libraryInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.LibraryInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B5D2 RID: 46546 RVA: 0x001B22E8 File Offset: 0x001B04E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InfrPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.fireInfo_ != null)
			{
				if (this.fireInfo_ == null)
				{
					this.FireInfo = new InfrFirePb();
				}
				this.FireInfo.MergeFrom(other.FireInfo);
			}
			if (other.roadInfo_ != null)
			{
				if (this.roadInfo_ == null)
				{
					this.RoadInfo = new InfrRoadPb();
				}
				this.RoadInfo.MergeFrom(other.RoadInfo);
			}
			if (other.libraryInfo_ != null)
			{
				if (this.libraryInfo_ == null)
				{
					this.LibraryInfo = new InfrLibraryPb();
				}
				this.LibraryInfo.MergeFrom(other.LibraryInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B5D3 RID: 46547 RVA: 0x001B2394 File Offset: 0x001B0594
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B5D4 RID: 46548 RVA: 0x001B23A0 File Offset: 0x001B05A0
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
						if (num != 26U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							if (this.libraryInfo_ == null)
							{
								this.LibraryInfo = new InfrLibraryPb();
							}
							input.ReadMessage(this.LibraryInfo);
						}
					}
					else
					{
						if (this.roadInfo_ == null)
						{
							this.RoadInfo = new InfrRoadPb();
						}
						input.ReadMessage(this.RoadInfo);
					}
				}
				else
				{
					if (this.fireInfo_ == null)
					{
						this.FireInfo = new InfrFirePb();
					}
					input.ReadMessage(this.FireInfo);
				}
			}
		}

		// Token: 0x0400509E RID: 20638
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400509F RID: 20639
		public const int FireInfoFieldNumber = 1;

		// Token: 0x040050A0 RID: 20640
		private InfrFirePb fireInfo_;

		// Token: 0x040050A1 RID: 20641
		public const int RoadInfoFieldNumber = 2;

		// Token: 0x040050A2 RID: 20642
		private InfrRoadPb roadInfo_;

		// Token: 0x040050A3 RID: 20643
		public const int LibraryInfoFieldNumber = 3;

		// Token: 0x040050A4 RID: 20644
		private InfrLibraryPb libraryInfo_;
	}
}
