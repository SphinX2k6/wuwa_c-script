using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DB6 RID: 3510
	[NetMessage(EMessageId.PolluteGridCellRequest)]
	public sealed class PolluteGridCellRequest : IMessage<PolluteGridCellRequest>, IMessage, IEquatable<PolluteGridCellRequest>, IDeepCloneable<PolluteGridCellRequest>, IBufferMessage
	{
		// Token: 0x06012EC9 RID: 77513 RVA: 0x002C2C42 File Offset: 0x002C0E42
		[NullableContext(1)]
		public static PolluteGridCellRequest Create()
		{
			return new PolluteGridCellRequest();
		}

		// Token: 0x17003ECB RID: 16075
		// (get) Token: 0x06012ECA RID: 77514 RVA: 0x002C2C49 File Offset: 0x002C0E49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003ECC RID: 16076
		// (get) Token: 0x06012ECB RID: 77515 RVA: 0x002C2C4C File Offset: 0x002C0E4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PolluteGridCellRequest.Descriptor;
			}
		}

		// Token: 0x06012ECC RID: 77516 RVA: 0x002C2C53 File Offset: 0x002C0E53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PolluteGridCellRequest()
		{
		}

		// Token: 0x06012ECD RID: 77517 RVA: 0x002C2C5C File Offset: 0x002C0E5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PolluteGridCellRequest(PolluteGridCellRequest other) : this()
		{
			this.trapGridPlacementPbInfo_ = ((other.trapGridPlacementPbInfo_ != null) ? other.trapGridPlacementPbInfo_.Clone() : null);
			this.isPolluted_ = other.isPolluted_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012ECE RID: 77518 RVA: 0x002C2CA8 File Offset: 0x002C0EA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PolluteGridCellRequest Clone()
		{
			return new PolluteGridCellRequest(this);
		}

		// Token: 0x17003ECD RID: 16077
		// (get) Token: 0x06012ECF RID: 77519 RVA: 0x002C2CB0 File Offset: 0x002C0EB0
		// (set) Token: 0x06012ED0 RID: 77520 RVA: 0x002C2CB8 File Offset: 0x002C0EB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GridPlacementPbInfo TrapGridPlacementPbInfo
		{
			get
			{
				return this.trapGridPlacementPbInfo_;
			}
			set
			{
				this.trapGridPlacementPbInfo_ = value;
			}
		}

		// Token: 0x17003ECE RID: 16078
		// (get) Token: 0x06012ED1 RID: 77521 RVA: 0x002C2CC1 File Offset: 0x002C0EC1
		// (set) Token: 0x06012ED2 RID: 77522 RVA: 0x002C2CC9 File Offset: 0x002C0EC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsPolluted
		{
			get
			{
				return this.isPolluted_;
			}
			set
			{
				this.isPolluted_ = value;
			}
		}

		// Token: 0x06012ED3 RID: 77523 RVA: 0x002C2CD2 File Offset: 0x002C0ED2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PolluteGridCellRequest);
		}

		// Token: 0x06012ED4 RID: 77524 RVA: 0x002C2CE0 File Offset: 0x002C0EE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PolluteGridCellRequest other)
		{
			return other != null && (other == this || (object.Equals(this.TrapGridPlacementPbInfo, other.TrapGridPlacementPbInfo) && this.IsPolluted == other.IsPolluted && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012ED5 RID: 77525 RVA: 0x002C2D30 File Offset: 0x002C0F30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.trapGridPlacementPbInfo_ != null)
			{
				num ^= this.TrapGridPlacementPbInfo.GetHashCode();
			}
			if (this.IsPolluted)
			{
				num ^= this.IsPolluted.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06012ED6 RID: 77526 RVA: 0x002C2D85 File Offset: 0x002C0F85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012ED7 RID: 77527 RVA: 0x002C2D92 File Offset: 0x002C0F92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012ED8 RID: 77528 RVA: 0x002C2D9C File Offset: 0x002C0F9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.trapGridPlacementPbInfo_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.TrapGridPlacementPbInfo);
			}
			if (this.IsPolluted)
			{
				output.WriteRawTag(56);
				output.WriteBool(this.IsPolluted);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012ED9 RID: 77529 RVA: 0x002C2DF8 File Offset: 0x002C0FF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.trapGridPlacementPbInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.TrapGridPlacementPbInfo);
			}
			if (this.IsPolluted)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06012EDA RID: 77530 RVA: 0x002C2E44 File Offset: 0x002C1044
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PolluteGridCellRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.trapGridPlacementPbInfo_ != null)
			{
				if (this.trapGridPlacementPbInfo_ == null)
				{
					this.TrapGridPlacementPbInfo = new GridPlacementPbInfo();
				}
				this.TrapGridPlacementPbInfo.MergeFrom(other.TrapGridPlacementPbInfo);
			}
			if (other.IsPolluted)
			{
				this.IsPolluted = other.IsPolluted;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06012EDB RID: 77531 RVA: 0x002C2EAC File Offset: 0x002C10AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012EDC RID: 77532 RVA: 0x002C2EB8 File Offset: 0x002C10B8
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
				if (num != 18U)
				{
					if (num != 56U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.IsPolluted = input.ReadBool();
					}
				}
				else
				{
					if (this.trapGridPlacementPbInfo_ == null)
					{
						this.TrapGridPlacementPbInfo = new GridPlacementPbInfo();
					}
					input.ReadMessage(this.TrapGridPlacementPbInfo);
				}
			}
		}

		// Token: 0x04007565 RID: 30053
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007566 RID: 30054
		public const int TrapGridPlacementPbInfoFieldNumber = 2;

		// Token: 0x04007567 RID: 30055
		private GridPlacementPbInfo trapGridPlacementPbInfo_;

		// Token: 0x04007568 RID: 30056
		public const int IsPollutedFieldNumber = 7;

		// Token: 0x04007569 RID: 30057
		private bool isPolluted_;
	}
}
