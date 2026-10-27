using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013B7 RID: 5047
	[NetMessage(EMessageId.TowerEndNotify)]
	public sealed class TowerEndNotify : IMessage<TowerEndNotify>, IMessage, IEquatable<TowerEndNotify>, IDeepCloneable<TowerEndNotify>, IBufferMessage
	{
		// Token: 0x0601AC66 RID: 109670 RVA: 0x003E1EE1 File Offset: 0x003E00E1
		[NullableContext(1)]
		public static TowerEndNotify Create()
		{
			return new TowerEndNotify();
		}

		// Token: 0x17005A4C RID: 23116
		// (get) Token: 0x0601AC67 RID: 109671 RVA: 0x003E1EE8 File Offset: 0x003E00E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005A4D RID: 23117
		// (get) Token: 0x0601AC68 RID: 109672 RVA: 0x003E1EEB File Offset: 0x003E00EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TowerEndNotify.Descriptor;
			}
		}

		// Token: 0x0601AC69 RID: 109673 RVA: 0x003E1EF2 File Offset: 0x003E00F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerEndNotify()
		{
		}

		// Token: 0x0601AC6A RID: 109674 RVA: 0x003E1EFC File Offset: 0x003E00FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerEndNotify(TowerEndNotify other) : this()
		{
			this.needUpdateSeason_ = other.needUpdateSeason_;
			this.currentFloorData_ = ((other.currentFloorData_ != null) ? other.currentFloorData_.Clone() : null);
			this.success_ = other.success_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601AC6B RID: 109675 RVA: 0x003E1F54 File Offset: 0x003E0154
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerEndNotify Clone()
		{
			return new TowerEndNotify(this);
		}

		// Token: 0x17005A4E RID: 23118
		// (get) Token: 0x0601AC6C RID: 109676 RVA: 0x003E1F5C File Offset: 0x003E015C
		// (set) Token: 0x0601AC6D RID: 109677 RVA: 0x003E1F64 File Offset: 0x003E0164
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

		// Token: 0x17005A4F RID: 23119
		// (get) Token: 0x0601AC6E RID: 109678 RVA: 0x003E1F6D File Offset: 0x003E016D
		// (set) Token: 0x0601AC6F RID: 109679 RVA: 0x003E1F75 File Offset: 0x003E0175
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

		// Token: 0x17005A50 RID: 23120
		// (get) Token: 0x0601AC70 RID: 109680 RVA: 0x003E1F7E File Offset: 0x003E017E
		// (set) Token: 0x0601AC71 RID: 109681 RVA: 0x003E1F86 File Offset: 0x003E0186
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

		// Token: 0x0601AC72 RID: 109682 RVA: 0x003E1F8F File Offset: 0x003E018F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TowerEndNotify);
		}

		// Token: 0x0601AC73 RID: 109683 RVA: 0x003E1FA0 File Offset: 0x003E01A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TowerEndNotify other)
		{
			return other != null && (other == this || (this.NeedUpdateSeason == other.NeedUpdateSeason && object.Equals(this.CurrentFloorData, other.CurrentFloorData) && this.Success == other.Success && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601AC74 RID: 109684 RVA: 0x003E2000 File Offset: 0x003E0200
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

		// Token: 0x0601AC75 RID: 109685 RVA: 0x003E206E File Offset: 0x003E026E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601AC76 RID: 109686 RVA: 0x003E207B File Offset: 0x003E027B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601AC77 RID: 109687 RVA: 0x003E2084 File Offset: 0x003E0284
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.NeedUpdateSeason)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.NeedUpdateSeason);
			}
			if (this.Success)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.Success);
			}
			if (this.currentFloorData_ != null)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.CurrentFloorData);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601AC78 RID: 109688 RVA: 0x003E20F8 File Offset: 0x003E02F8
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

		// Token: 0x0601AC79 RID: 109689 RVA: 0x003E2150 File Offset: 0x003E0350
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

		// Token: 0x0601AC7A RID: 109690 RVA: 0x003E21CC File Offset: 0x003E03CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601AC7B RID: 109691 RVA: 0x003E21D8 File Offset: 0x003E03D8
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
					if (num != 16U)
					{
						if (num != 74U)
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
						this.Success = input.ReadBool();
					}
				}
				else
				{
					this.NeedUpdateSeason = input.ReadBool();
				}
			}
		}

		// Token: 0x04009B72 RID: 39794
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009B73 RID: 39795
		public const int NeedUpdateSeasonFieldNumber = 1;

		// Token: 0x04009B74 RID: 39796
		private bool needUpdateSeason_;

		// Token: 0x04009B75 RID: 39797
		public const int CurrentFloorDataFieldNumber = 9;

		// Token: 0x04009B76 RID: 39798
		private TowerFloorPb currentFloorData_;

		// Token: 0x04009B77 RID: 39799
		public const int SuccessFieldNumber = 2;

		// Token: 0x04009B78 RID: 39800
		private bool success_;
	}
}
