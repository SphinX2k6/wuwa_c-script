using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200071A RID: 1818
	public sealed class GridObjectComponentPb : IMessage<GridObjectComponentPb>, IMessage, IEquatable<GridObjectComponentPb>, IDeepCloneable<GridObjectComponentPb>, IBufferMessage
	{
		// Token: 0x0600A540 RID: 42304 RVA: 0x0018EC6E File Offset: 0x0018CE6E
		[NullableContext(1)]
		public static GridObjectComponentPb Create()
		{
			return new GridObjectComponentPb();
		}

		// Token: 0x1700213C RID: 8508
		// (get) Token: 0x0600A541 RID: 42305 RVA: 0x0018EC75 File Offset: 0x0018CE75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700213D RID: 8509
		// (get) Token: 0x0600A542 RID: 42306 RVA: 0x0018EC78 File Offset: 0x0018CE78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GridObjectComponentPb.Descriptor;
			}
		}

		// Token: 0x0600A543 RID: 42307 RVA: 0x0018EC7F File Offset: 0x0018CE7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GridObjectComponentPb()
		{
		}

		// Token: 0x0600A544 RID: 42308 RVA: 0x0018EC87 File Offset: 0x0018CE87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GridObjectComponentPb(GridObjectComponentPb other) : this()
		{
			this.initGridPlacementPbInfo_ = ((other.initGridPlacementPbInfo_ != null) ? other.initGridPlacementPbInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A545 RID: 42309 RVA: 0x0018ECBC File Offset: 0x0018CEBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GridObjectComponentPb Clone()
		{
			return new GridObjectComponentPb(this);
		}

		// Token: 0x1700213E RID: 8510
		// (get) Token: 0x0600A546 RID: 42310 RVA: 0x0018ECC4 File Offset: 0x0018CEC4
		// (set) Token: 0x0600A547 RID: 42311 RVA: 0x0018ECCC File Offset: 0x0018CECC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GridPlacementPbInfo InitGridPlacementPbInfo
		{
			get
			{
				return this.initGridPlacementPbInfo_;
			}
			set
			{
				this.initGridPlacementPbInfo_ = value;
			}
		}

		// Token: 0x0600A548 RID: 42312 RVA: 0x0018ECD5 File Offset: 0x0018CED5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GridObjectComponentPb);
		}

		// Token: 0x0600A549 RID: 42313 RVA: 0x0018ECE3 File Offset: 0x0018CEE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GridObjectComponentPb other)
		{
			return other != null && (other == this || (object.Equals(this.InitGridPlacementPbInfo, other.InitGridPlacementPbInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A54A RID: 42314 RVA: 0x0018ED18 File Offset: 0x0018CF18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.initGridPlacementPbInfo_ != null)
			{
				num ^= this.InitGridPlacementPbInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A54B RID: 42315 RVA: 0x0018ED54 File Offset: 0x0018CF54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A54C RID: 42316 RVA: 0x0018ED61 File Offset: 0x0018CF61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A54D RID: 42317 RVA: 0x0018ED6A File Offset: 0x0018CF6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.initGridPlacementPbInfo_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.InitGridPlacementPbInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A54E RID: 42318 RVA: 0x0018ED9C File Offset: 0x0018CF9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.initGridPlacementPbInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.InitGridPlacementPbInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A54F RID: 42319 RVA: 0x0018EDDC File Offset: 0x0018CFDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GridObjectComponentPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.initGridPlacementPbInfo_ != null)
			{
				if (this.initGridPlacementPbInfo_ == null)
				{
					this.InitGridPlacementPbInfo = new GridPlacementPbInfo();
				}
				this.InitGridPlacementPbInfo.MergeFrom(other.InitGridPlacementPbInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A550 RID: 42320 RVA: 0x0018EE30 File Offset: 0x0018D030
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A551 RID: 42321 RVA: 0x0018EE3C File Offset: 0x0018D03C
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.initGridPlacementPbInfo_ == null)
					{
						this.InitGridPlacementPbInfo = new GridPlacementPbInfo();
					}
					input.ReadMessage(this.InitGridPlacementPbInfo);
				}
			}
		}

		// Token: 0x04004C02 RID: 19458
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004C03 RID: 19459
		public const int InitGridPlacementPbInfoFieldNumber = 1;

		// Token: 0x04004C04 RID: 19460
		private GridPlacementPbInfo initGridPlacementPbInfo_;
	}
}
