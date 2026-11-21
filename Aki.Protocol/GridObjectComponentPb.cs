using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000706 RID: 1798
	public sealed class GridObjectComponentPb : IMessage<GridObjectComponentPb>, IMessage, IEquatable<GridObjectComponentPb>, IDeepCloneable<GridObjectComponentPb>, IBufferMessage
	{
		// Token: 0x0600A3EA RID: 41962 RVA: 0x0018C23A File Offset: 0x0018A43A
		[NullableContext(1)]
		public static GridObjectComponentPb Create()
		{
			return new GridObjectComponentPb();
		}

		// Token: 0x170020F2 RID: 8434
		// (get) Token: 0x0600A3EB RID: 41963 RVA: 0x0018C241 File Offset: 0x0018A441
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170020F3 RID: 8435
		// (get) Token: 0x0600A3EC RID: 41964 RVA: 0x0018C244 File Offset: 0x0018A444
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GridObjectComponentPb.Descriptor;
			}
		}

		// Token: 0x0600A3ED RID: 41965 RVA: 0x0018C24B File Offset: 0x0018A44B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GridObjectComponentPb()
		{
		}

		// Token: 0x0600A3EE RID: 41966 RVA: 0x0018C253 File Offset: 0x0018A453
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GridObjectComponentPb(GridObjectComponentPb other) : this()
		{
			this.initGridPlacementPbInfo_ = ((other.initGridPlacementPbInfo_ != null) ? other.initGridPlacementPbInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A3EF RID: 41967 RVA: 0x0018C288 File Offset: 0x0018A488
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GridObjectComponentPb Clone()
		{
			return new GridObjectComponentPb(this);
		}

		// Token: 0x170020F4 RID: 8436
		// (get) Token: 0x0600A3F0 RID: 41968 RVA: 0x0018C290 File Offset: 0x0018A490
		// (set) Token: 0x0600A3F1 RID: 41969 RVA: 0x0018C298 File Offset: 0x0018A498
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

		// Token: 0x0600A3F2 RID: 41970 RVA: 0x0018C2A1 File Offset: 0x0018A4A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GridObjectComponentPb);
		}

		// Token: 0x0600A3F3 RID: 41971 RVA: 0x0018C2AF File Offset: 0x0018A4AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GridObjectComponentPb other)
		{
			return other != null && (other == this || (object.Equals(this.InitGridPlacementPbInfo, other.InitGridPlacementPbInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A3F4 RID: 41972 RVA: 0x0018C2E4 File Offset: 0x0018A4E4
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

		// Token: 0x0600A3F5 RID: 41973 RVA: 0x0018C320 File Offset: 0x0018A520
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A3F6 RID: 41974 RVA: 0x0018C32D File Offset: 0x0018A52D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A3F7 RID: 41975 RVA: 0x0018C336 File Offset: 0x0018A536
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

		// Token: 0x0600A3F8 RID: 41976 RVA: 0x0018C368 File Offset: 0x0018A568
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

		// Token: 0x0600A3F9 RID: 41977 RVA: 0x0018C3A8 File Offset: 0x0018A5A8
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

		// Token: 0x0600A3FA RID: 41978 RVA: 0x0018C3FC File Offset: 0x0018A5FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A3FB RID: 41979 RVA: 0x0018C408 File Offset: 0x0018A608
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

		// Token: 0x04004BFB RID: 19451
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004BFC RID: 19452
		public const int InitGridPlacementPbInfoFieldNumber = 1;

		// Token: 0x04004BFD RID: 19453
		private GridPlacementPbInfo initGridPlacementPbInfo_;
	}
}
