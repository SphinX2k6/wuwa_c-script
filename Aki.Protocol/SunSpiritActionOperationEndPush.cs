using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001325 RID: 4901
	[NetMessage(EMessageId.SunSpiritActionOperationEndPush)]
	public sealed class SunSpiritActionOperationEndPush : IMessage<SunSpiritActionOperationEndPush>, IMessage, IEquatable<SunSpiritActionOperationEndPush>, IDeepCloneable<SunSpiritActionOperationEndPush>, IBufferMessage
	{
		// Token: 0x0601A206 RID: 107014 RVA: 0x003CEBE9 File Offset: 0x003CCDE9
		[NullableContext(1)]
		public static SunSpiritActionOperationEndPush Create()
		{
			return new SunSpiritActionOperationEndPush();
		}

		// Token: 0x17005874 RID: 22644
		// (get) Token: 0x0601A207 RID: 107015 RVA: 0x003CEBF0 File Offset: 0x003CCDF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005875 RID: 22645
		// (get) Token: 0x0601A208 RID: 107016 RVA: 0x003CEBF3 File Offset: 0x003CCDF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SunSpiritActionOperationEndPush.Descriptor;
			}
		}

		// Token: 0x0601A209 RID: 107017 RVA: 0x003CEBFA File Offset: 0x003CCDFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SunSpiritActionOperationEndPush()
		{
		}

		// Token: 0x0601A20A RID: 107018 RVA: 0x003CEC02 File Offset: 0x003CCE02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SunSpiritActionOperationEndPush(SunSpiritActionOperationEndPush other) : this()
		{
			this.playerId_ = other.playerId_;
			this.incId_ = other.incId_;
			this.index_ = other.index_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A20B RID: 107019 RVA: 0x003CEC3F File Offset: 0x003CCE3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SunSpiritActionOperationEndPush Clone()
		{
			return new SunSpiritActionOperationEndPush(this);
		}

		// Token: 0x17005876 RID: 22646
		// (get) Token: 0x0601A20C RID: 107020 RVA: 0x003CEC47 File Offset: 0x003CCE47
		// (set) Token: 0x0601A20D RID: 107021 RVA: 0x003CEC4F File Offset: 0x003CCE4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PlayerId
		{
			get
			{
				return this.playerId_;
			}
			set
			{
				this.playerId_ = value;
			}
		}

		// Token: 0x17005877 RID: 22647
		// (get) Token: 0x0601A20E RID: 107022 RVA: 0x003CEC58 File Offset: 0x003CCE58
		// (set) Token: 0x0601A20F RID: 107023 RVA: 0x003CEC60 File Offset: 0x003CCE60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int IncId
		{
			get
			{
				return this.incId_;
			}
			set
			{
				this.incId_ = value;
			}
		}

		// Token: 0x17005878 RID: 22648
		// (get) Token: 0x0601A210 RID: 107024 RVA: 0x003CEC69 File Offset: 0x003CCE69
		// (set) Token: 0x0601A211 RID: 107025 RVA: 0x003CEC71 File Offset: 0x003CCE71
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

		// Token: 0x0601A212 RID: 107026 RVA: 0x003CEC7A File Offset: 0x003CCE7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SunSpiritActionOperationEndPush);
		}

		// Token: 0x0601A213 RID: 107027 RVA: 0x003CEC88 File Offset: 0x003CCE88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SunSpiritActionOperationEndPush other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && this.IncId == other.IncId && this.Index == other.Index && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A214 RID: 107028 RVA: 0x003CECE4 File Offset: 0x003CCEE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PlayerId != 0)
			{
				num ^= this.PlayerId.GetHashCode();
			}
			if (this.IncId != 0)
			{
				num ^= this.IncId.GetHashCode();
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

		// Token: 0x0601A215 RID: 107029 RVA: 0x003CED55 File Offset: 0x003CCF55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A216 RID: 107030 RVA: 0x003CED62 File Offset: 0x003CCF62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A217 RID: 107031 RVA: 0x003CED6C File Offset: 0x003CCF6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.PlayerId);
			}
			if (this.IncId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.IncId);
			}
			if (this.Index != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.Index);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A218 RID: 107032 RVA: 0x003CEDE4 File Offset: 0x003CCFE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PlayerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerId);
			}
			if (this.IncId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.IncId);
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

		// Token: 0x0601A219 RID: 107033 RVA: 0x003CEE54 File Offset: 0x003CD054
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SunSpiritActionOperationEndPush other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PlayerId != 0)
			{
				this.PlayerId = other.PlayerId;
			}
			if (other.IncId != 0)
			{
				this.IncId = other.IncId;
			}
			if (other.Index != 0)
			{
				this.Index = other.Index;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601A21A RID: 107034 RVA: 0x003CEEB8 File Offset: 0x003CD0B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A21B RID: 107035 RVA: 0x003CEEC4 File Offset: 0x003CD0C4
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
					if (num != 72U)
					{
						if (num != 112U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Index = input.ReadInt32();
						}
					}
					else
					{
						this.IncId = input.ReadInt32();
					}
				}
				else
				{
					this.PlayerId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040099B5 RID: 39349
		private UnknownFieldSet _unknownFields;

		// Token: 0x040099B6 RID: 39350
		public const int PlayerIdFieldNumber = 7;

		// Token: 0x040099B7 RID: 39351
		private int playerId_;

		// Token: 0x040099B8 RID: 39352
		public const int IncIdFieldNumber = 9;

		// Token: 0x040099B9 RID: 39353
		private int incId_;

		// Token: 0x040099BA RID: 39354
		public const int IndexFieldNumber = 14;

		// Token: 0x040099BB RID: 39355
		private int index_;
	}
}
