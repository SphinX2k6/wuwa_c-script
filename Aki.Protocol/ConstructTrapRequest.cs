using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002DE RID: 734
	[NetMessage(EMessageId.ConstructTrapRequest)]
	public sealed class ConstructTrapRequest : IMessage<ConstructTrapRequest>, IMessage, IEquatable<ConstructTrapRequest>, IDeepCloneable<ConstructTrapRequest>, IBufferMessage
	{
		// Token: 0x06004ADF RID: 19167 RVA: 0x000B6A34 File Offset: 0x000B4C34
		[NullableContext(1)]
		public static ConstructTrapRequest Create()
		{
			return new ConstructTrapRequest();
		}

		// Token: 0x17000D26 RID: 3366
		// (get) Token: 0x06004AE0 RID: 19168 RVA: 0x000B6A3B File Offset: 0x000B4C3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000D27 RID: 3367
		// (get) Token: 0x06004AE1 RID: 19169 RVA: 0x000B6A3E File Offset: 0x000B4C3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ConstructTrapRequest.Descriptor;
			}
		}

		// Token: 0x06004AE2 RID: 19170 RVA: 0x000B6A45 File Offset: 0x000B4C45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConstructTrapRequest()
		{
		}

		// Token: 0x06004AE3 RID: 19171 RVA: 0x000B6A50 File Offset: 0x000B4C50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConstructTrapRequest(ConstructTrapRequest other) : this()
		{
			this.configId_ = other.configId_;
			this.trapGridPlacementPbInfo_ = ((other.trapGridPlacementPbInfo_ != null) ? other.trapGridPlacementPbInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004AE4 RID: 19172 RVA: 0x000B6A9C File Offset: 0x000B4C9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConstructTrapRequest Clone()
		{
			return new ConstructTrapRequest(this);
		}

		// Token: 0x17000D28 RID: 3368
		// (get) Token: 0x06004AE5 RID: 19173 RVA: 0x000B6AA4 File Offset: 0x000B4CA4
		// (set) Token: 0x06004AE6 RID: 19174 RVA: 0x000B6AAC File Offset: 0x000B4CAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ConfigId
		{
			get
			{
				return this.configId_;
			}
			set
			{
				this.configId_ = value;
			}
		}

		// Token: 0x17000D29 RID: 3369
		// (get) Token: 0x06004AE7 RID: 19175 RVA: 0x000B6AB5 File Offset: 0x000B4CB5
		// (set) Token: 0x06004AE8 RID: 19176 RVA: 0x000B6ABD File Offset: 0x000B4CBD
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

		// Token: 0x06004AE9 RID: 19177 RVA: 0x000B6AC6 File Offset: 0x000B4CC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ConstructTrapRequest);
		}

		// Token: 0x06004AEA RID: 19178 RVA: 0x000B6AD4 File Offset: 0x000B4CD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ConstructTrapRequest other)
		{
			return other != null && (other == this || (this.ConfigId == other.ConfigId && object.Equals(this.TrapGridPlacementPbInfo, other.TrapGridPlacementPbInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004AEB RID: 19179 RVA: 0x000B6B24 File Offset: 0x000B4D24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ConfigId != 0)
			{
				num ^= this.ConfigId.GetHashCode();
			}
			if (this.trapGridPlacementPbInfo_ != null)
			{
				num ^= this.TrapGridPlacementPbInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004AEC RID: 19180 RVA: 0x000B6B79 File Offset: 0x000B4D79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004AED RID: 19181 RVA: 0x000B6B86 File Offset: 0x000B4D86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004AEE RID: 19182 RVA: 0x000B6B90 File Offset: 0x000B4D90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.trapGridPlacementPbInfo_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.TrapGridPlacementPbInfo);
			}
			if (this.ConfigId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.ConfigId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004AEF RID: 19183 RVA: 0x000B6BEC File Offset: 0x000B4DEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ConfigId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ConfigId);
			}
			if (this.trapGridPlacementPbInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.TrapGridPlacementPbInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004AF0 RID: 19184 RVA: 0x000B6C44 File Offset: 0x000B4E44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ConstructTrapRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ConfigId != 0)
			{
				this.ConfigId = other.ConfigId;
			}
			if (other.trapGridPlacementPbInfo_ != null)
			{
				if (this.trapGridPlacementPbInfo_ == null)
				{
					this.TrapGridPlacementPbInfo = new GridPlacementPbInfo();
				}
				this.TrapGridPlacementPbInfo.MergeFrom(other.TrapGridPlacementPbInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004AF1 RID: 19185 RVA: 0x000B6CAC File Offset: 0x000B4EAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004AF2 RID: 19186 RVA: 0x000B6CB8 File Offset: 0x000B4EB8
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
				if (num != 50U)
				{
					if (num != 88U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ConfigId = input.ReadInt32();
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

		// Token: 0x04003092 RID: 12434
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003093 RID: 12435
		public const int ConfigIdFieldNumber = 11;

		// Token: 0x04003094 RID: 12436
		private int configId_;

		// Token: 0x04003095 RID: 12437
		public const int TrapGridPlacementPbInfoFieldNumber = 6;

		// Token: 0x04003096 RID: 12438
		private GridPlacementPbInfo trapGridPlacementPbInfo_;
	}
}
