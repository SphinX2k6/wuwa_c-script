using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F58 RID: 3928
	[NetMessage(EMessageId.RiskHarvestStarRewardRequest)]
	public sealed class RiskHarvestStarRewardRequest : IMessage<RiskHarvestStarRewardRequest>, IMessage, IEquatable<RiskHarvestStarRewardRequest>, IDeepCloneable<RiskHarvestStarRewardRequest>, IBufferMessage
	{
		// Token: 0x06015085 RID: 86149 RVA: 0x0030D5AB File Offset: 0x0030B7AB
		[NullableContext(1)]
		public static RiskHarvestStarRewardRequest Create()
		{
			return new RiskHarvestStarRewardRequest();
		}

		// Token: 0x170045FA RID: 17914
		// (get) Token: 0x06015086 RID: 86150 RVA: 0x0030D5B2 File Offset: 0x0030B7B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170045FB RID: 17915
		// (get) Token: 0x06015087 RID: 86151 RVA: 0x0030D5B5 File Offset: 0x0030B7B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RiskHarvestStarRewardRequest.Descriptor;
			}
		}

		// Token: 0x06015088 RID: 86152 RVA: 0x0030D5BC File Offset: 0x0030B7BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RiskHarvestStarRewardRequest()
		{
		}

		// Token: 0x06015089 RID: 86153 RVA: 0x0030D5C4 File Offset: 0x0030B7C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RiskHarvestStarRewardRequest(RiskHarvestStarRewardRequest other) : this()
		{
			this.id_ = other.id_;
			this.index_ = other.index_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601508A RID: 86154 RVA: 0x0030D5F5 File Offset: 0x0030B7F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RiskHarvestStarRewardRequest Clone()
		{
			return new RiskHarvestStarRewardRequest(this);
		}

		// Token: 0x170045FC RID: 17916
		// (get) Token: 0x0601508B RID: 86155 RVA: 0x0030D5FD File Offset: 0x0030B7FD
		// (set) Token: 0x0601508C RID: 86156 RVA: 0x0030D605 File Offset: 0x0030B805
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x170045FD RID: 17917
		// (get) Token: 0x0601508D RID: 86157 RVA: 0x0030D60E File Offset: 0x0030B80E
		// (set) Token: 0x0601508E RID: 86158 RVA: 0x0030D616 File Offset: 0x0030B816
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Index
		{
			get
			{
				return this.index_;
			}
			set
			{
				this.index_ = value;
			}
		}

		// Token: 0x0601508F RID: 86159 RVA: 0x0030D61F File Offset: 0x0030B81F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RiskHarvestStarRewardRequest);
		}

		// Token: 0x06015090 RID: 86160 RVA: 0x0030D62D File Offset: 0x0030B82D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RiskHarvestStarRewardRequest other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.Index == other.Index && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015091 RID: 86161 RVA: 0x0030D66C File Offset: 0x0030B86C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.Index != 0)
			{
				num ^= this.Index.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06015092 RID: 86162 RVA: 0x0030D6C4 File Offset: 0x0030B8C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015093 RID: 86163 RVA: 0x0030D6D1 File Offset: 0x0030B8D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015094 RID: 86164 RVA: 0x0030D6DC File Offset: 0x0030B8DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Index != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.Index);
			}
			if (this.Id != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015095 RID: 86165 RVA: 0x0030D738 File Offset: 0x0030B938
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.Index != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Index);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06015096 RID: 86166 RVA: 0x0030D790 File Offset: 0x0030B990
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RiskHarvestStarRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.Index != 0)
			{
				this.Index = other.Index;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06015097 RID: 86167 RVA: 0x0030D7E0 File Offset: 0x0030B9E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015098 RID: 86168 RVA: 0x0030D7EC File Offset: 0x0030B9EC
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
				if (num != 48U)
				{
					if (num != 88U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Id = input.ReadInt32();
					}
				}
				else
				{
					this.Index = input.ReadInt32();
				}
			}
		}

		// Token: 0x04007F1C RID: 32540
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007F1D RID: 32541
		public const int IdFieldNumber = 11;

		// Token: 0x04007F1E RID: 32542
		private int id_;

		// Token: 0x04007F1F RID: 32543
		public const int IndexFieldNumber = 6;

		// Token: 0x04007F20 RID: 32544
		private int index_;
	}
}
