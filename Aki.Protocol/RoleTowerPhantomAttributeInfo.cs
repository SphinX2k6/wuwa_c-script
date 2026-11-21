using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010D2 RID: 4306
	public sealed class RoleTowerPhantomAttributeInfo : IMessage<RoleTowerPhantomAttributeInfo>, IMessage, IEquatable<RoleTowerPhantomAttributeInfo>, IDeepCloneable<RoleTowerPhantomAttributeInfo>, IBufferMessage
	{
		// Token: 0x0601703D RID: 94269 RVA: 0x00358D60 File Offset: 0x00356F60
		[NullableContext(1)]
		public static RoleTowerPhantomAttributeInfo Create()
		{
			return new RoleTowerPhantomAttributeInfo();
		}

		// Token: 0x17004D37 RID: 19767
		// (get) Token: 0x0601703E RID: 94270 RVA: 0x00358D67 File Offset: 0x00356F67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RoleTowerPhantomAttributeInfo> Parser
		{
			get
			{
				return RoleTowerPhantomAttributeInfo._parser;
			}
		}

		// Token: 0x17004D38 RID: 19768
		// (get) Token: 0x0601703F RID: 94271 RVA: 0x00358D6E File Offset: 0x00356F6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004D39 RID: 19769
		// (get) Token: 0x06017040 RID: 94272 RVA: 0x00358D71 File Offset: 0x00356F71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleTowerPhantomAttributeInfo.Descriptor;
			}
		}

		// Token: 0x06017041 RID: 94273 RVA: 0x00358D78 File Offset: 0x00356F78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerPhantomAttributeInfo()
		{
		}

		// Token: 0x06017042 RID: 94274 RVA: 0x00358D80 File Offset: 0x00356F80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerPhantomAttributeInfo(RoleTowerPhantomAttributeInfo other) : this()
		{
			this.phantomId_ = other.phantomId_;
			this.slotIndex_ = other.slotIndex_;
			this.totalAttrs_ = ((other.totalAttrs_ != null) ? other.totalAttrs_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017043 RID: 94275 RVA: 0x00358DD8 File Offset: 0x00356FD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerPhantomAttributeInfo Clone()
		{
			return new RoleTowerPhantomAttributeInfo(this);
		}

		// Token: 0x17004D3A RID: 19770
		// (get) Token: 0x06017044 RID: 94276 RVA: 0x00358DE0 File Offset: 0x00356FE0
		// (set) Token: 0x06017045 RID: 94277 RVA: 0x00358DE8 File Offset: 0x00356FE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PhantomId
		{
			get
			{
				return this.phantomId_;
			}
			set
			{
				this.phantomId_ = value;
			}
		}

		// Token: 0x17004D3B RID: 19771
		// (get) Token: 0x06017046 RID: 94278 RVA: 0x00358DF1 File Offset: 0x00356FF1
		// (set) Token: 0x06017047 RID: 94279 RVA: 0x00358DF9 File Offset: 0x00356FF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SlotIndex
		{
			get
			{
				return this.slotIndex_;
			}
			set
			{
				this.slotIndex_ = value;
			}
		}

		// Token: 0x17004D3C RID: 19772
		// (get) Token: 0x06017048 RID: 94280 RVA: 0x00358E02 File Offset: 0x00357002
		// (set) Token: 0x06017049 RID: 94281 RVA: 0x00358E0A File Offset: 0x0035700A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RolePhantomPropInfo TotalAttrs
		{
			get
			{
				return this.totalAttrs_;
			}
			set
			{
				this.totalAttrs_ = value;
			}
		}

		// Token: 0x0601704A RID: 94282 RVA: 0x00358E13 File Offset: 0x00357013
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleTowerPhantomAttributeInfo);
		}

		// Token: 0x0601704B RID: 94283 RVA: 0x00358E24 File Offset: 0x00357024
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleTowerPhantomAttributeInfo other)
		{
			return other != null && (other == this || (this.PhantomId == other.PhantomId && this.SlotIndex == other.SlotIndex && object.Equals(this.TotalAttrs, other.TotalAttrs) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601704C RID: 94284 RVA: 0x00358E84 File Offset: 0x00357084
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PhantomId != 0)
			{
				num ^= this.PhantomId.GetHashCode();
			}
			if (this.SlotIndex != 0)
			{
				num ^= this.SlotIndex.GetHashCode();
			}
			if (this.totalAttrs_ != null)
			{
				num ^= this.TotalAttrs.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601704D RID: 94285 RVA: 0x00358EF2 File Offset: 0x003570F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601704E RID: 94286 RVA: 0x00358EFF File Offset: 0x003570FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601704F RID: 94287 RVA: 0x00358F08 File Offset: 0x00357108
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PhantomId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.PhantomId);
			}
			if (this.SlotIndex != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.SlotIndex);
			}
			if (this.totalAttrs_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.TotalAttrs);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017050 RID: 94288 RVA: 0x00358F7C File Offset: 0x0035717C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PhantomId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PhantomId);
			}
			if (this.SlotIndex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SlotIndex);
			}
			if (this.totalAttrs_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.TotalAttrs);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06017051 RID: 94289 RVA: 0x00358FEC File Offset: 0x003571EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleTowerPhantomAttributeInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PhantomId != 0)
			{
				this.PhantomId = other.PhantomId;
			}
			if (other.SlotIndex != 0)
			{
				this.SlotIndex = other.SlotIndex;
			}
			if (other.totalAttrs_ != null)
			{
				if (this.totalAttrs_ == null)
				{
					this.TotalAttrs = new RolePhantomPropInfo();
				}
				this.TotalAttrs.MergeFrom(other.TotalAttrs);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06017052 RID: 94290 RVA: 0x00359068 File Offset: 0x00357268
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017053 RID: 94291 RVA: 0x00359074 File Offset: 0x00357274
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
						if (num != 34U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							if (this.totalAttrs_ == null)
							{
								this.TotalAttrs = new RolePhantomPropInfo();
							}
							input.ReadMessage(this.TotalAttrs);
						}
					}
					else
					{
						this.SlotIndex = input.ReadInt32();
					}
				}
				else
				{
					this.PhantomId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040089BC RID: 35260
		private static readonly MessageParser<RoleTowerPhantomAttributeInfo> _parser = new MessageParser<RoleTowerPhantomAttributeInfo>(() => new RoleTowerPhantomAttributeInfo());

		// Token: 0x040089BD RID: 35261
		private UnknownFieldSet _unknownFields;

		// Token: 0x040089BE RID: 35262
		public const int PhantomIdFieldNumber = 1;

		// Token: 0x040089BF RID: 35263
		private int phantomId_;

		// Token: 0x040089C0 RID: 35264
		public const int SlotIndexFieldNumber = 2;

		// Token: 0x040089C1 RID: 35265
		private int slotIndex_;

		// Token: 0x040089C2 RID: 35266
		public const int TotalAttrsFieldNumber = 4;

		// Token: 0x040089C3 RID: 35267
		private RolePhantomPropInfo totalAttrs_;
	}
}
