using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200142A RID: 5162
	[NetMessage(EMessageId.TowerEndNotify)]
	public sealed class TowerEndNotify : IMessage<TowerEndNotify>, IMessage, IEquatable<TowerEndNotify>, IDeepCloneable<TowerEndNotify>, IBufferMessage
	{
		// Token: 0x0601B6F1 RID: 112369 RVA: 0x003FD1A1 File Offset: 0x003FB3A1
		[NullableContext(1)]
		public static TowerEndNotify Create()
		{
			return new TowerEndNotify();
		}

		// Token: 0x17005CE1 RID: 23777
		// (get) Token: 0x0601B6F2 RID: 112370 RVA: 0x003FD1A8 File Offset: 0x003FB3A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005CE2 RID: 23778
		// (get) Token: 0x0601B6F3 RID: 112371 RVA: 0x003FD1AB File Offset: 0x003FB3AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TowerEndNotify.Descriptor;
			}
		}

		// Token: 0x0601B6F4 RID: 112372 RVA: 0x003FD1B2 File Offset: 0x003FB3B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerEndNotify()
		{
		}

		// Token: 0x0601B6F5 RID: 112373 RVA: 0x003FD1BC File Offset: 0x003FB3BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerEndNotify(TowerEndNotify other) : this()
		{
			this.needUpdateSeason_ = other.needUpdateSeason_;
			this.currentFloorData_ = ((other.currentFloorData_ != null) ? other.currentFloorData_.Clone() : null);
			this.success_ = other.success_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B6F6 RID: 112374 RVA: 0x003FD214 File Offset: 0x003FB414
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerEndNotify Clone()
		{
			return new TowerEndNotify(this);
		}

		// Token: 0x17005CE3 RID: 23779
		// (get) Token: 0x0601B6F7 RID: 112375 RVA: 0x003FD21C File Offset: 0x003FB41C
		// (set) Token: 0x0601B6F8 RID: 112376 RVA: 0x003FD224 File Offset: 0x003FB424
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool NeedUpdateSeason
		{
			get
			{
				return this.needUpdateSeason_;
			}
			set
			{
				this.needUpdateSeason_ = value;
			}
		}

		// Token: 0x17005CE4 RID: 23780
		// (get) Token: 0x0601B6F9 RID: 112377 RVA: 0x003FD22D File Offset: 0x003FB42D
		// (set) Token: 0x0601B6FA RID: 112378 RVA: 0x003FD235 File Offset: 0x003FB435
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerFloorPb CurrentFloorData
		{
			get
			{
				return this.currentFloorData_;
			}
			set
			{
				this.currentFloorData_ = value;
			}
		}

		// Token: 0x17005CE5 RID: 23781
		// (get) Token: 0x0601B6FB RID: 112379 RVA: 0x003FD23E File Offset: 0x003FB43E
		// (set) Token: 0x0601B6FC RID: 112380 RVA: 0x003FD246 File Offset: 0x003FB446
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Success
		{
			get
			{
				return this.success_;
			}
			set
			{
				this.success_ = value;
			}
		}

		// Token: 0x0601B6FD RID: 112381 RVA: 0x003FD24F File Offset: 0x003FB44F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TowerEndNotify);
		}

		// Token: 0x0601B6FE RID: 112382 RVA: 0x003FD260 File Offset: 0x003FB460
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TowerEndNotify other)
		{
			return other != null && (other == this || (this.NeedUpdateSeason == other.NeedUpdateSeason && object.Equals(this.CurrentFloorData, other.CurrentFloorData) && this.Success == other.Success && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B6FF RID: 112383 RVA: 0x003FD2C0 File Offset: 0x003FB4C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.NeedUpdateSeason)
			{
				num ^= this.NeedUpdateSeason.GetHashCode();
			}
			if (this.currentFloorData_ != null)
			{
				num ^= this.CurrentFloorData.GetHashCode();
			}
			if (this.Success)
			{
				num ^= this.Success.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601B700 RID: 112384 RVA: 0x003FD32E File Offset: 0x003FB52E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B701 RID: 112385 RVA: 0x003FD33B File Offset: 0x003FB53B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B702 RID: 112386 RVA: 0x003FD344 File Offset: 0x003FB544
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Success)
			{
				output.WriteRawTag(56);
				output.WriteBool(this.Success);
			}
			if (this.NeedUpdateSeason)
			{
				output.WriteRawTag(64);
				output.WriteBool(this.NeedUpdateSeason);
			}
			if (this.currentFloorData_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.CurrentFloorData);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B703 RID: 112387 RVA: 0x003FD3BC File Offset: 0x003FB5BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.NeedUpdateSeason)
			{
				num += 2;
			}
			if (this.currentFloorData_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.CurrentFloorData);
			}
			if (this.Success)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601B704 RID: 112388 RVA: 0x003FD414 File Offset: 0x003FB614
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TowerEndNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.NeedUpdateSeason)
			{
				this.NeedUpdateSeason = other.NeedUpdateSeason;
			}
			if (other.currentFloorData_ != null)
			{
				if (this.currentFloorData_ == null)
				{
					this.CurrentFloorData = new TowerFloorPb();
				}
				this.CurrentFloorData.MergeFrom(other.CurrentFloorData);
			}
			if (other.Success)
			{
				this.Success = other.Success;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B705 RID: 112389 RVA: 0x003FD490 File Offset: 0x003FB690
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B706 RID: 112390 RVA: 0x003FD49C File Offset: 0x003FB69C
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
				if (num != 56U)
				{
					if (num != 64U)
					{
						if (num != 114U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							if (this.currentFloorData_ == null)
							{
								this.CurrentFloorData = new TowerFloorPb();
							}
							input.ReadMessage(this.CurrentFloorData);
						}
					}
					else
					{
						this.NeedUpdateSeason = input.ReadBool();
					}
				}
				else
				{
					this.Success = input.ReadBool();
				}
			}
		}

		// Token: 0x04009FB9 RID: 40889
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009FBA RID: 40890
		public const int NeedUpdateSeasonFieldNumber = 8;

		// Token: 0x04009FBB RID: 40891
		private bool needUpdateSeason_;

		// Token: 0x04009FBC RID: 40892
		public const int CurrentFloorDataFieldNumber = 14;

		// Token: 0x04009FBD RID: 40893
		private TowerFloorPb currentFloorData_;

		// Token: 0x04009FBE RID: 40894
		public const int SuccessFieldNumber = 7;

		// Token: 0x04009FBF RID: 40895
		private bool success_;
	}
}
