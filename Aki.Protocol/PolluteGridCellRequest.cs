using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DC7 RID: 3527
	[NetMessage(EMessageId.PolluteGridCellRequest)]
	public sealed class PolluteGridCellRequest : IMessage<PolluteGridCellRequest>, IMessage, IEquatable<PolluteGridCellRequest>, IDeepCloneable<PolluteGridCellRequest>, IBufferMessage
	{
		// Token: 0x06012FD9 RID: 77785 RVA: 0x002C4AF2 File Offset: 0x002C2CF2
		[NullableContext(1)]
		public static PolluteGridCellRequest Create()
		{
			return new PolluteGridCellRequest();
		}

		// Token: 0x17003F04 RID: 16132
		// (get) Token: 0x06012FDA RID: 77786 RVA: 0x002C4AF9 File Offset: 0x002C2CF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003F05 RID: 16133
		// (get) Token: 0x06012FDB RID: 77787 RVA: 0x002C4AFC File Offset: 0x002C2CFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PolluteGridCellRequest.Descriptor;
			}
		}

		// Token: 0x06012FDC RID: 77788 RVA: 0x002C4B03 File Offset: 0x002C2D03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PolluteGridCellRequest()
		{
		}

		// Token: 0x06012FDD RID: 77789 RVA: 0x002C4B0C File Offset: 0x002C2D0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PolluteGridCellRequest(PolluteGridCellRequest other) : this()
		{
			this.trapGridPlacementPbInfo_ = ((other.trapGridPlacementPbInfo_ != null) ? other.trapGridPlacementPbInfo_.Clone() : null);
			this.isPolluted_ = other.isPolluted_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012FDE RID: 77790 RVA: 0x002C4B58 File Offset: 0x002C2D58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PolluteGridCellRequest Clone()
		{
			return new PolluteGridCellRequest(this);
		}

		// Token: 0x17003F06 RID: 16134
		// (get) Token: 0x06012FDF RID: 77791 RVA: 0x002C4B60 File Offset: 0x002C2D60
		// (set) Token: 0x06012FE0 RID: 77792 RVA: 0x002C4B68 File Offset: 0x002C2D68
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

		// Token: 0x17003F07 RID: 16135
		// (get) Token: 0x06012FE1 RID: 77793 RVA: 0x002C4B71 File Offset: 0x002C2D71
		// (set) Token: 0x06012FE2 RID: 77794 RVA: 0x002C4B79 File Offset: 0x002C2D79
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

		// Token: 0x06012FE3 RID: 77795 RVA: 0x002C4B82 File Offset: 0x002C2D82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PolluteGridCellRequest);
		}

		// Token: 0x06012FE4 RID: 77796 RVA: 0x002C4B90 File Offset: 0x002C2D90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PolluteGridCellRequest other)
		{
			return other != null && (other == this || (object.Equals(this.TrapGridPlacementPbInfo, other.TrapGridPlacementPbInfo) && this.IsPolluted == other.IsPolluted && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012FE5 RID: 77797 RVA: 0x002C4BE0 File Offset: 0x002C2DE0
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

		// Token: 0x06012FE6 RID: 77798 RVA: 0x002C4C35 File Offset: 0x002C2E35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012FE7 RID: 77799 RVA: 0x002C4C42 File Offset: 0x002C2E42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012FE8 RID: 77800 RVA: 0x002C4C4C File Offset: 0x002C2E4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsPolluted)
			{
				output.WriteRawTag(64);
				output.WriteBool(this.IsPolluted);
			}
			if (this.trapGridPlacementPbInfo_ != null)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.TrapGridPlacementPbInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012FE9 RID: 77801 RVA: 0x002C4CA8 File Offset: 0x002C2EA8
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

		// Token: 0x06012FEA RID: 77802 RVA: 0x002C4CF4 File Offset: 0x002C2EF4
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

		// Token: 0x06012FEB RID: 77803 RVA: 0x002C4D5C File Offset: 0x002C2F5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012FEC RID: 77804 RVA: 0x002C4D68 File Offset: 0x002C2F68
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
				if (num != 64U)
				{
					if (num != 106U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
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
				else
				{
					this.IsPolluted = input.ReadBool();
				}
			}
		}

		// Token: 0x04007552 RID: 30034
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007553 RID: 30035
		public const int TrapGridPlacementPbInfoFieldNumber = 13;

		// Token: 0x04007554 RID: 30036
		private GridPlacementPbInfo trapGridPlacementPbInfo_;

		// Token: 0x04007555 RID: 30037
		public const int IsPollutedFieldNumber = 8;

		// Token: 0x04007556 RID: 30038
		private bool isPolluted_;
	}
}
