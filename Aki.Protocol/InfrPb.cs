using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007D6 RID: 2006
	public sealed class InfrPb : IMessage<InfrPb>, IMessage, IEquatable<InfrPb>, IDeepCloneable<InfrPb>, IBufferMessage
	{
		// Token: 0x0600B469 RID: 46185 RVA: 0x001AF606 File Offset: 0x001AD806
		[NullableContext(1)]
		public static InfrPb Create()
		{
			return new InfrPb();
		}

		// Token: 0x1700245D RID: 9309
		// (get) Token: 0x0600B46A RID: 46186 RVA: 0x001AF60D File Offset: 0x001AD80D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700245E RID: 9310
		// (get) Token: 0x0600B46B RID: 46187 RVA: 0x001AF610 File Offset: 0x001AD810
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InfrPb.Descriptor;
			}
		}

		// Token: 0x0600B46C RID: 46188 RVA: 0x001AF617 File Offset: 0x001AD817
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrPb()
		{
		}

		// Token: 0x0600B46D RID: 46189 RVA: 0x001AF620 File Offset: 0x001AD820
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrPb(InfrPb other) : this()
		{
			this.fireInfo_ = ((other.fireInfo_ != null) ? other.fireInfo_.Clone() : null);
			this.roadInfo_ = ((other.roadInfo_ != null) ? other.roadInfo_.Clone() : null);
			this.libraryInfo_ = ((other.libraryInfo_ != null) ? other.libraryInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B46E RID: 46190 RVA: 0x001AF698 File Offset: 0x001AD898
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrPb Clone()
		{
			return new InfrPb(this);
		}

		// Token: 0x1700245F RID: 9311
		// (get) Token: 0x0600B46F RID: 46191 RVA: 0x001AF6A0 File Offset: 0x001AD8A0
		// (set) Token: 0x0600B470 RID: 46192 RVA: 0x001AF6A8 File Offset: 0x001AD8A8
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

		// Token: 0x17002460 RID: 9312
		// (get) Token: 0x0600B471 RID: 46193 RVA: 0x001AF6B1 File Offset: 0x001AD8B1
		// (set) Token: 0x0600B472 RID: 46194 RVA: 0x001AF6B9 File Offset: 0x001AD8B9
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

		// Token: 0x17002461 RID: 9313
		// (get) Token: 0x0600B473 RID: 46195 RVA: 0x001AF6C2 File Offset: 0x001AD8C2
		// (set) Token: 0x0600B474 RID: 46196 RVA: 0x001AF6CA File Offset: 0x001AD8CA
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

		// Token: 0x0600B475 RID: 46197 RVA: 0x001AF6D3 File Offset: 0x001AD8D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InfrPb);
		}

		// Token: 0x0600B476 RID: 46198 RVA: 0x001AF6E4 File Offset: 0x001AD8E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InfrPb other)
		{
			return other != null && (other == this || (object.Equals(this.FireInfo, other.FireInfo) && object.Equals(this.RoadInfo, other.RoadInfo) && object.Equals(this.LibraryInfo, other.LibraryInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B477 RID: 46199 RVA: 0x001AF74C File Offset: 0x001AD94C
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

		// Token: 0x0600B478 RID: 46200 RVA: 0x001AF7B4 File Offset: 0x001AD9B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B479 RID: 46201 RVA: 0x001AF7C1 File Offset: 0x001AD9C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B47A RID: 46202 RVA: 0x001AF7CC File Offset: 0x001AD9CC
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

		// Token: 0x0600B47B RID: 46203 RVA: 0x001AF844 File Offset: 0x001ADA44
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

		// Token: 0x0600B47C RID: 46204 RVA: 0x001AF8B4 File Offset: 0x001ADAB4
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

		// Token: 0x0600B47D RID: 46205 RVA: 0x001AF960 File Offset: 0x001ADB60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B47E RID: 46206 RVA: 0x001AF96C File Offset: 0x001ADB6C
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

		// Token: 0x04005097 RID: 20631
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005098 RID: 20632
		public const int FireInfoFieldNumber = 1;

		// Token: 0x04005099 RID: 20633
		private InfrFirePb fireInfo_;

		// Token: 0x0400509A RID: 20634
		public const int RoadInfoFieldNumber = 2;

		// Token: 0x0400509B RID: 20635
		private InfrRoadPb roadInfo_;

		// Token: 0x0400509C RID: 20636
		public const int LibraryInfoFieldNumber = 3;

		// Token: 0x0400509D RID: 20637
		private InfrLibraryPb libraryInfo_;
	}
}
